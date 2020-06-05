namespace TaxiManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvDrivers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gbNewOrder = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDistance = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.cbBusiness = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lvActiveOrders = new System.Windows.Forms.ListView();
            this.PhonenumberCustomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhonenumberDriver = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbActiveOrder = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvCompliteOrders = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbDriverInfo = new System.Windows.Forms.GroupBox();
            this.lbOperatingHoursPerDay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbBonus = new System.Windows.Forms.Label();
            this.lbSalary = new System.Windows.Forms.Label();
            this.lbExperience = new System.Windows.Forms.Label();
            this.lbDistance = new System.Windows.Forms.Label();
            this.lbComplitedOrdersCount = new System.Windows.Forms.Label();
            this.lbClass = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbBonusTitle = new System.Windows.Forms.Label();
            this.lbDistanceTitle = new System.Windows.Forms.Label();
            this.lbComplitedOrdersCountTitle = new System.Windows.Forms.Label();
            this.lbExperienceTitle = new System.Windows.Forms.Label();
            this.lbSalaryTitle = new System.Windows.Forms.Label();
            this.lbClassTitle = new System.Windows.Forms.Label();
            this.lbPhoneNumberTitle = new System.Windows.Forms.Label();
            this.lbNameTitle = new System.Windows.Forms.Label();
            this.gbCompliteOrder = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.gbNewOrder.SuspendLayout();
            this.gbActiveOrder.SuspendLayout();
            this.gbDriverInfo.SuspendLayout();
            this.gbCompliteOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lvDrivers);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 305);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drivers";
            // 
            // lvDrivers
            // 
            this.lvDrivers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDrivers.BackColor = System.Drawing.Color.White;
            this.lvDrivers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvDrivers.FullRowSelect = true;
            this.lvDrivers.Location = new System.Drawing.Point(6, 21);
            this.lvDrivers.MultiSelect = false;
            this.lvDrivers.Name = "lvDrivers";
            this.lvDrivers.Size = new System.Drawing.Size(500, 278);
            this.lvDrivers.TabIndex = 2;
            this.lvDrivers.UseCompatibleStateImageBehavior = false;
            this.lvDrivers.View = System.Windows.Forms.View.Details;
            this.lvDrivers.SelectedIndexChanged += new System.EventHandler(this.lvDrivers_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Car";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Class";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "State";
            this.columnHeader4.Width = 80;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // gbNewOrder
            // 
            this.gbNewOrder.BackColor = System.Drawing.SystemColors.Control;
            this.gbNewOrder.Controls.Add(this.label4);
            this.gbNewOrder.Controls.Add(this.tbDistance);
            this.gbNewOrder.Controls.Add(this.btnOrder);
            this.gbNewOrder.Controls.Add(this.tbPhone);
            this.gbNewOrder.Controls.Add(this.cbBusiness);
            this.gbNewOrder.Controls.Add(this.label3);
            this.gbNewOrder.Controls.Add(this.label2);
            this.gbNewOrder.Controls.Add(this.label1);
            this.gbNewOrder.Controls.Add(this.tbName);
            this.gbNewOrder.Location = new System.Drawing.Point(550, 12);
            this.gbNewOrder.Name = "gbNewOrder";
            this.gbNewOrder.Size = new System.Drawing.Size(330, 214);
            this.gbNewOrder.TabIndex = 2;
            this.gbNewOrder.TabStop = false;
            this.gbNewOrder.Text = "New Order";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(24, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Distance:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbDistance
            // 
            this.tbDistance.Location = new System.Drawing.Point(130, 103);
            this.tbDistance.Name = "tbDistance";
            this.tbDistance.Size = new System.Drawing.Size(187, 22);
            this.tbDistance.TabIndex = 7;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(130, 168);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(187, 35);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(130, 66);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(187, 22);
            this.tbPhone.TabIndex = 5;
            // 
            // cbBusiness
            // 
            this.cbBusiness.AutoSize = true;
            this.cbBusiness.Location = new System.Drawing.Point(130, 145);
            this.cbBusiness.Name = "cbBusiness";
            this.cbBusiness.Size = new System.Drawing.Size(18, 17);
            this.cbBusiness.TabIndex = 4;
            this.cbBusiness.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Business Class:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(130, 28);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(187, 22);
            this.tbName.TabIndex = 0;
            // 
            // lvActiveOrders
            // 
            this.lvActiveOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvActiveOrders.BackColor = System.Drawing.Color.White;
            this.lvActiveOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PhonenumberCustomer,
            this.PhonenumberDriver,
            this.Cost,
            this.Time});
            this.lvActiveOrders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvActiveOrders.HideSelection = false;
            this.lvActiveOrders.Location = new System.Drawing.Point(7, 21);
            this.lvActiveOrders.MultiSelect = false;
            this.lvActiveOrders.Name = "lvActiveOrders";
            this.lvActiveOrders.Size = new System.Drawing.Size(668, 138);
            this.lvActiveOrders.TabIndex = 6;
            this.lvActiveOrders.UseCompatibleStateImageBehavior = false;
            this.lvActiveOrders.View = System.Windows.Forms.View.Details;
            // 
            // PhonenumberCustomer
            // 
            this.PhonenumberCustomer.Text = "Phonenumber Customer";
            this.PhonenumberCustomer.Width = 160;
            // 
            // PhonenumberDriver
            // 
            this.PhonenumberDriver.Text = "Phonenumber Driver";
            this.PhonenumberDriver.Width = 160;
            // 
            // Cost
            // 
            this.Cost.Text = "Cost";
            // 
            // Time
            // 
            this.Time.Text = "Time";
            // 
            // gbActiveOrder
            // 
            this.gbActiveOrder.Controls.Add(this.lvActiveOrders);
            this.gbActiveOrder.Location = new System.Drawing.Point(550, 254);
            this.gbActiveOrder.Name = "gbActiveOrder";
            this.gbActiveOrder.Size = new System.Drawing.Size(681, 165);
            this.gbActiveOrder.TabIndex = 7;
            this.gbActiveOrder.TabStop = false;
            this.gbActiveOrder.Text = "Active Order";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(550, 452);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(681, 155);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Complite Order";
            // 
            // lvCompliteOrders
            // 
            this.lvCompliteOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvCompliteOrders.BackColor = System.Drawing.Color.White;
            this.lvCompliteOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvCompliteOrders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCompliteOrders.HideSelection = false;
            this.lvCompliteOrders.Location = new System.Drawing.Point(7, 19);
            this.lvCompliteOrders.MultiSelect = false;
            this.lvCompliteOrders.Name = "lvCompliteOrders";
            this.lvCompliteOrders.Size = new System.Drawing.Size(668, 149);
            this.lvCompliteOrders.TabIndex = 6;
            this.lvCompliteOrders.UseCompatibleStateImageBehavior = false;
            this.lvCompliteOrders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Phonenumber Customer";
            this.columnHeader5.Width = 180;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Phonenumber Driver";
            this.columnHeader6.Width = 180;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Cost";
            this.columnHeader7.Width = 61;
            // 
            // gbDriverInfo
            // 
            this.gbDriverInfo.BackColor = System.Drawing.Color.White;
            this.gbDriverInfo.Controls.Add(this.lbOperatingHoursPerDay);
            this.gbDriverInfo.Controls.Add(this.label5);
            this.gbDriverInfo.Controls.Add(this.lbBonus);
            this.gbDriverInfo.Controls.Add(this.lbSalary);
            this.gbDriverInfo.Controls.Add(this.lbExperience);
            this.gbDriverInfo.Controls.Add(this.lbDistance);
            this.gbDriverInfo.Controls.Add(this.lbComplitedOrdersCount);
            this.gbDriverInfo.Controls.Add(this.lbClass);
            this.gbDriverInfo.Controls.Add(this.lbPhoneNumber);
            this.gbDriverInfo.Controls.Add(this.lbName);
            this.gbDriverInfo.Controls.Add(this.lbBonusTitle);
            this.gbDriverInfo.Controls.Add(this.lbDistanceTitle);
            this.gbDriverInfo.Controls.Add(this.lbComplitedOrdersCountTitle);
            this.gbDriverInfo.Controls.Add(this.lbExperienceTitle);
            this.gbDriverInfo.Controls.Add(this.lbSalaryTitle);
            this.gbDriverInfo.Controls.Add(this.lbClassTitle);
            this.gbDriverInfo.Controls.Add(this.lbPhoneNumberTitle);
            this.gbDriverInfo.Controls.Add(this.lbNameTitle);
            this.gbDriverInfo.Location = new System.Drawing.Point(18, 338);
            this.gbDriverInfo.Name = "gbDriverInfo";
            this.gbDriverInfo.Size = new System.Drawing.Size(500, 269);
            this.gbDriverInfo.TabIndex = 9;
            this.gbDriverInfo.TabStop = false;
            this.gbDriverInfo.Text = "Driver Info";
            // 
            // lbOperatingHoursPerDay
            // 
            this.lbOperatingHoursPerDay.AutoSize = true;
            this.lbOperatingHoursPerDay.Location = new System.Drawing.Point(202, 213);
            this.lbOperatingHoursPerDay.Name = "lbOperatingHoursPerDay";
            this.lbOperatingHoursPerDay.Size = new System.Drawing.Size(13, 17);
            this.lbOperatingHoursPerDay.TabIndex = 23;
            this.lbOperatingHoursPerDay.Text = "-";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Total Time :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbBonus
            // 
            this.lbBonus.AutoSize = true;
            this.lbBonus.Location = new System.Drawing.Point(202, 196);
            this.lbBonus.Name = "lbBonus";
            this.lbBonus.Size = new System.Drawing.Size(13, 17);
            this.lbBonus.TabIndex = 21;
            this.lbBonus.Text = "-";
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Location = new System.Drawing.Point(203, 176);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(13, 17);
            this.lbSalary.TabIndex = 19;
            this.lbSalary.Text = "-";
            // 
            // lbExperience
            // 
            this.lbExperience.AutoSize = true;
            this.lbExperience.Location = new System.Drawing.Point(203, 153);
            this.lbExperience.Name = "lbExperience";
            this.lbExperience.Size = new System.Drawing.Size(13, 17);
            this.lbExperience.TabIndex = 17;
            this.lbExperience.Text = "-";
            // 
            // lbDistance
            // 
            this.lbDistance.AutoSize = true;
            this.lbDistance.Location = new System.Drawing.Point(203, 130);
            this.lbDistance.Name = "lbDistance";
            this.lbDistance.Size = new System.Drawing.Size(13, 17);
            this.lbDistance.TabIndex = 15;
            this.lbDistance.Text = "-";
            // 
            // lbComplitedOrdersCount
            // 
            this.lbComplitedOrdersCount.AutoSize = true;
            this.lbComplitedOrdersCount.Location = new System.Drawing.Point(203, 107);
            this.lbComplitedOrdersCount.Name = "lbComplitedOrdersCount";
            this.lbComplitedOrdersCount.Size = new System.Drawing.Size(13, 17);
            this.lbComplitedOrdersCount.TabIndex = 13;
            this.lbComplitedOrdersCount.Text = "-";
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Location = new System.Drawing.Point(203, 85);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(13, 17);
            this.lbClass.TabIndex = 11;
            this.lbClass.Text = "-";
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Location = new System.Drawing.Point(203, 61);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(13, 17);
            this.lbPhoneNumber.TabIndex = 9;
            this.lbPhoneNumber.Text = "-";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(203, 37);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(13, 17);
            this.lbName.TabIndex = 8;
            this.lbName.Text = "-";
            // 
            // lbBonusTitle
            // 
            this.lbBonusTitle.Location = new System.Drawing.Point(97, 193);
            this.lbBonusTitle.Name = "lbBonusTitle";
            this.lbBonusTitle.Size = new System.Drawing.Size(100, 23);
            this.lbBonusTitle.TabIndex = 7;
            this.lbBonusTitle.Text = "Bonus  :";
            this.lbBonusTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDistanceTitle
            // 
            this.lbDistanceTitle.Location = new System.Drawing.Point(97, 127);
            this.lbDistanceTitle.Name = "lbDistanceTitle";
            this.lbDistanceTitle.Size = new System.Drawing.Size(100, 23);
            this.lbDistanceTitle.TabIndex = 6;
            this.lbDistanceTitle.Text = "Distance :";
            this.lbDistanceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbComplitedOrdersCountTitle
            // 
            this.lbComplitedOrdersCountTitle.Location = new System.Drawing.Point(29, 104);
            this.lbComplitedOrdersCountTitle.Name = "lbComplitedOrdersCountTitle";
            this.lbComplitedOrdersCountTitle.Size = new System.Drawing.Size(168, 23);
            this.lbComplitedOrdersCountTitle.TabIndex = 5;
            this.lbComplitedOrdersCountTitle.Text = "Complited Orders :";
            this.lbComplitedOrdersCountTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbExperienceTitle
            // 
            this.lbExperienceTitle.Location = new System.Drawing.Point(97, 150);
            this.lbExperienceTitle.Name = "lbExperienceTitle";
            this.lbExperienceTitle.Size = new System.Drawing.Size(100, 23);
            this.lbExperienceTitle.TabIndex = 4;
            this.lbExperienceTitle.Text = "Experience :";
            this.lbExperienceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSalaryTitle
            // 
            this.lbSalaryTitle.Location = new System.Drawing.Point(97, 173);
            this.lbSalaryTitle.Name = "lbSalaryTitle";
            this.lbSalaryTitle.Size = new System.Drawing.Size(100, 23);
            this.lbSalaryTitle.TabIndex = 3;
            this.lbSalaryTitle.Text = "Salary :";
            this.lbSalaryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbClassTitle
            // 
            this.lbClassTitle.Location = new System.Drawing.Point(97, 82);
            this.lbClassTitle.Name = "lbClassTitle";
            this.lbClassTitle.Size = new System.Drawing.Size(100, 23);
            this.lbClassTitle.TabIndex = 2;
            this.lbClassTitle.Text = "Class :";
            this.lbClassTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbPhoneNumberTitle
            // 
            this.lbPhoneNumberTitle.Location = new System.Drawing.Point(64, 58);
            this.lbPhoneNumberTitle.Name = "lbPhoneNumberTitle";
            this.lbPhoneNumberTitle.Size = new System.Drawing.Size(133, 23);
            this.lbPhoneNumberTitle.TabIndex = 1;
            this.lbPhoneNumberTitle.Text = "Phonenumber :";
            this.lbPhoneNumberTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbNameTitle
            // 
            this.lbNameTitle.Location = new System.Drawing.Point(97, 34);
            this.lbNameTitle.Name = "lbNameTitle";
            this.lbNameTitle.Size = new System.Drawing.Size(100, 23);
            this.lbNameTitle.TabIndex = 0;
            this.lbNameTitle.Text = "Name :";
            this.lbNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbCompliteOrder
            // 
            this.gbCompliteOrder.Controls.Add(this.lvCompliteOrders);
            this.gbCompliteOrder.Location = new System.Drawing.Point(550, 426);
            this.gbCompliteOrder.Name = "gbCompliteOrder";
            this.gbCompliteOrder.Size = new System.Drawing.Size(675, 158);
            this.gbCompliteOrder.TabIndex = 10;
            this.gbCompliteOrder.TabStop = false;
            this.gbCompliteOrder.Text = "Complite Order";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1353, 674);
            this.Controls.Add(this.gbCompliteOrder);
            this.Controls.Add(this.gbDriverInfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbActiveOrder);
            this.Controls.Add(this.gbNewOrder);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taxi Station";
            this.groupBox1.ResumeLayout(false);
            this.gbNewOrder.ResumeLayout(false);
            this.gbNewOrder.PerformLayout();
            this.gbActiveOrder.ResumeLayout(false);
            this.gbDriverInfo.ResumeLayout(false);
            this.gbDriverInfo.PerformLayout();
            this.gbCompliteOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvDrivers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox gbNewOrder;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.CheckBox cbBusiness;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDistance;
        private System.Windows.Forms.ListView lvActiveOrders;
        private System.Windows.Forms.ColumnHeader PhonenumberCustomer;
        private System.Windows.Forms.ColumnHeader Cost;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader PhonenumberDriver;
        private System.Windows.Forms.GroupBox gbActiveOrder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvCompliteOrders;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox gbDriverInfo;
        private System.Windows.Forms.Label lbDistanceTitle;
        private System.Windows.Forms.Label lbComplitedOrdersCountTitle;
        private System.Windows.Forms.Label lbExperienceTitle;
        private System.Windows.Forms.Label lbSalaryTitle;
        private System.Windows.Forms.Label lbClassTitle;
        private System.Windows.Forms.Label lbPhoneNumberTitle;
        private System.Windows.Forms.Label lbNameTitle;
        private System.Windows.Forms.Label lbBonusTitle;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbBonus;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.Label lbExperience;
        private System.Windows.Forms.Label lbDistance;
        private System.Windows.Forms.Label lbComplitedOrdersCount;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label lbOperatingHoursPerDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbCompliteOrder;
    }
}

