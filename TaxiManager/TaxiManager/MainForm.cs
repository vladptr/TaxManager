using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiManager.Core;

namespace TaxiManager
{
    public partial class MainForm : Form
    {
        private Station _station;
        
        public MainForm()
        {
            InitializeComponent();
            CreateStation();
        }

        private void ShowDrivers()
        {
            lvDrivers.Items.Clear();

            var drivers = _station.GetDrivers();
            foreach (var driver in drivers)
            {
                var item = new ListViewItem();

                item.Text = driver.Name;
                item.SubItems.Add(driver.Car.Name);

                if (driver.Car.IsBusinessClass)
                    item.SubItems.Add("Business");
                else
                    item.SubItems.Add("Econom");
                item.SubItems.Add("Free");

                item.Tag = driver;
                lvDrivers.Items.Add(item);

            }
        }

        private void CreateStation()
        {
            _station = new Station();

            RegisterDriver(12, "John", "Audi", true, "+380989665455");
            RegisterDriver(8, "Michael", "BMW", false, "+380965551194");
            RegisterDriver(10, "Daniel", "Mercedes", true, "+380682436557");
            RegisterDriver(6, "William", "Woldzwagen", false, "+380985428972");
            RegisterDriver(9, "Mason", "Skoda", false, "+380685269730");
            RegisterDriver(4, "Jack", "Renault", false, "+380968452196");

            ShowDrivers();
        }

        private void RegisterDriver(int experience, string name, string carName, bool business, string phonenumber)
        {
            var car = business ? (Car)new BusinessClass(carName) : (Car)new EconomClass(carName);
            var driver = new Driver(experience, car, name, phonenumber);
            _station.AddDriver(driver);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("Name is not defined");
                return;
            }

            if (string.IsNullOrEmpty(tbPhone.Text))
            {
                MessageBox.Show("Phone is not defined");
                return;
            }

            if (string.IsNullOrEmpty(tbDistance.Text))
            {
                MessageBox.Show("Distance is not defined");
                return;
            }

            if (!float.TryParse(tbDistance.Text, out var distance))
            {
                MessageBox.Show("Unable to convert distance");
                return;
            }

            var customer = new Customer(tbName.Text, tbPhone.Text);
            var order = new Order(customer, distance, cbBusiness.Checked);
            var orderDetails = _station.AddOrder(order);

            if (orderDetails == null)
                MessageBox.Show("No free drivers");
            else
                MessageBox.Show($"Your driver is on his way. " +
                    $"Driver name: {orderDetails.Driver.Name}, Coast: {orderDetails.Cost}");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _station.UpdateOrders();
            UpdateCompliteOrders();
            UpdateActiveOrders();
            UpdateDrivers();
        }
       
        private void UpdateCompliteOrders()
        {
            lvCompliteOrders.Items.Clear();
            var compliteorders = _station.GetCompliteOrders();
            foreach (var order in compliteorders)
            {
                var item = new ListViewItem();
                item.Text = order.Order.Customer.Phonenumber;
                item.SubItems.Add(order.Driver.Phonenumber);
                item.SubItems.Add(order.Cost.ToString());

                lvCompliteOrders.Items.Add(item);
            }
        }

        private void UpdateActiveOrders()
        {
            lvActiveOrders.Items.Clear();
            var activeorders = _station.GetActiveOrders();
            foreach (var order in activeorders)
            {
                var item = new ListViewItem();

                item.Text = order.Order.Customer.Phonenumber;
                item.SubItems.Add(order.Driver.Phonenumber);
                item.SubItems.Add(order.Cost.ToString());

                var secondsLeft = (order.CompletionTime - DateTime.Now).TotalSeconds;
                if (secondsLeft > 0)
                    item.SubItems.Add(TimeSpan.FromSeconds(secondsLeft).ToString("hh\\:mm\\:ss"));
                else
                    item.SubItems.Add("-");

                lvActiveOrders.Items.Add(item);
            }
        }

        private void UpdateDrivers()
        {

            foreach (var item in lvDrivers.Items.Cast<ListViewItem>())
            {
                var driver = item.Tag as Driver;
                var isActive = _station.IsActiveDriver(driver);

                item.SubItems[3].Text = isActive ? "Busy" : "Free";

            }
        }

        private void lvDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvDrivers.SelectedItems.Count > 0)
            {
                var driver = lvDrivers.SelectedItems[0].Tag as Driver;
                var driverDetails = _station.GetDriverDetails(driver);
                lbName.Text = driverDetails.Driver.Name;
                lbExperience.Text = driverDetails.Driver.Experience.ToString();
                lbPhoneNumber.Text = driverDetails.Driver.Phonenumber;
                lbSalary.Text = driverDetails.Salary.ToString();
                lbDistance.Text = driverDetails.Distance.ToString();
                lbBonus.Text = driverDetails.Bonus.ToString();
                if (driver.Car.IsBusinessClass)
                    lbClass.Text = ("Business");
                else
                    lbClass.Text = ("Econom");
                lbComplitedOrdersCount.Text = driverDetails.ComplitedOrdersCount.ToString();
                lbOperatingHoursPerDay.Text = TimeSpan.FromMinutes(driverDetails.TotalHours).ToString();
            }
        }   
    }
}
