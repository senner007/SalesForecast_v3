namespace SalesForecast_v3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.beregn = new System.Windows.Forms.Button();
            this.SalesLabel = new System.Windows.Forms.Label();
            this.txtTicketsSold = new System.Windows.Forms.TextBox();
            this.txtTVCover = new System.Windows.Forms.TextBox();
            this.txtSportsVisitors = new System.Windows.Forms.TextBox();
            this.txtFitnessSubscribers = new System.Windows.Forms.TextBox();
            this.txtVisitorsAppear = new System.Windows.Forms.TextBox();
            this.TotalSalesLabel = new System.Windows.Forms.Label();
            this.TotalExpensesLabel = new System.Windows.Forms.Label();
            this.TotalEarningsLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.error_TicketsSold = new System.Windows.Forms.Label();
            this.error_TVCover = new System.Windows.Forms.Label();
            this.error_SportsVisitors = new System.Windows.Forms.Label();
            this.error_FitnessSubscribers = new System.Windows.Forms.Label();
            this.error_VisitorsAppear = new System.Windows.Forms.Label();
            this.afslutOgBeregn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketsSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVCover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SportsVistors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FitnessSubscribers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitorsAppear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalExpenses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalEarnings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSalesLabelShow = new System.Windows.Forms.Label();
            this.TotalExpensesLabelShow = new System.Windows.Forms.Label();
            this.TotalEarningsLabelShow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tickets Sold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TV Cover";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sports Visitors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fitness Subscribers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Visitors who appear in %";
            // 
            // beregn
            // 
            this.beregn.Enabled = false;
            this.beregn.Location = new System.Drawing.Point(46, 293);
            this.beregn.Name = "beregn";
            this.beregn.Size = new System.Drawing.Size(89, 23);
            this.beregn.TabIndex = 5;
            this.beregn.Text = "Beregn Salg";
            this.beregn.UseVisualStyleBackColor = true;
            this.beregn.Click += new System.EventHandler(this.beregn_Click);
            // 
            // SalesLabel
            // 
            this.SalesLabel.AutoSize = true;
            this.SalesLabel.Location = new System.Drawing.Point(43, 354);
            this.SalesLabel.Name = "SalesLabel";
            this.SalesLabel.Size = new System.Drawing.Size(0, 13);
            this.SalesLabel.TabIndex = 6;
            // 
            // txtTicketsSold
            // 
            this.txtTicketsSold.Location = new System.Drawing.Point(224, 42);
            this.txtTicketsSold.Name = "txtTicketsSold";
            this.txtTicketsSold.Size = new System.Drawing.Size(100, 20);
            this.txtTicketsSold.TabIndex = 7;
            this.txtTicketsSold.TextChanged += new System.EventHandler(this.onTextChange_TextChanged);
            // 
            // txtTVCover
            // 
            this.txtTVCover.Location = new System.Drawing.Point(224, 76);
            this.txtTVCover.Name = "txtTVCover";
            this.txtTVCover.Size = new System.Drawing.Size(100, 20);
            this.txtTVCover.TabIndex = 8;
            this.txtTVCover.TextChanged += new System.EventHandler(this.onTextChange_TextChanged);
            // 
            // txtSportsVisitors
            // 
            this.txtSportsVisitors.Location = new System.Drawing.Point(224, 111);
            this.txtSportsVisitors.Name = "txtSportsVisitors";
            this.txtSportsVisitors.Size = new System.Drawing.Size(100, 20);
            this.txtSportsVisitors.TabIndex = 9;
            this.txtSportsVisitors.TextChanged += new System.EventHandler(this.onTextChange_TextChanged);
            // 
            // txtFitnessSubscribers
            // 
            this.txtFitnessSubscribers.Location = new System.Drawing.Point(224, 149);
            this.txtFitnessSubscribers.Name = "txtFitnessSubscribers";
            this.txtFitnessSubscribers.Size = new System.Drawing.Size(100, 20);
            this.txtFitnessSubscribers.TabIndex = 10;
            this.txtFitnessSubscribers.TextChanged += new System.EventHandler(this.onTextChange_TextChanged);
            // 
            // txtVisitorsAppear
            // 
            this.txtVisitorsAppear.Location = new System.Drawing.Point(224, 181);
            this.txtVisitorsAppear.Name = "txtVisitorsAppear";
            this.txtVisitorsAppear.Size = new System.Drawing.Size(100, 20);
            this.txtVisitorsAppear.TabIndex = 11;
            this.txtVisitorsAppear.TextChanged += new System.EventHandler(this.onTextChange_TextChanged);
            // 
            // TotalSalesLabel
            // 
            this.TotalSalesLabel.AutoSize = true;
            this.TotalSalesLabel.Location = new System.Drawing.Point(650, 49);
            this.TotalSalesLabel.Name = "TotalSalesLabel";
            this.TotalSalesLabel.Size = new System.Drawing.Size(0, 13);
            this.TotalSalesLabel.TabIndex = 12;
            // 
            // TotalExpensesLabel
            // 
            this.TotalExpensesLabel.AutoSize = true;
            this.TotalExpensesLabel.Location = new System.Drawing.Point(650, 79);
            this.TotalExpensesLabel.Name = "TotalExpensesLabel";
            this.TotalExpensesLabel.Size = new System.Drawing.Size(0, 13);
            this.TotalExpensesLabel.TabIndex = 13;
            // 
            // TotalEarningsLabel
            // 
            this.TotalEarningsLabel.AutoSize = true;
            this.TotalEarningsLabel.Location = new System.Drawing.Point(650, 111);
            this.TotalEarningsLabel.Name = "TotalEarningsLabel";
            this.TotalEarningsLabel.Size = new System.Drawing.Size(0, 13);
            this.TotalEarningsLabel.TabIndex = 14;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(154, 293);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(92, 23);
            this.ResetButton.TabIndex = 15;
            this.ResetButton.Text = "Nulstil";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.reset_Click);
            // 
            // error_TicketsSold
            // 
            this.error_TicketsSold.AutoSize = true;
            this.error_TicketsSold.Location = new System.Drawing.Point(341, 45);
            this.error_TicketsSold.Name = "error_TicketsSold";
            this.error_TicketsSold.Size = new System.Drawing.Size(75, 13);
            this.error_TicketsSold.TabIndex = 16;
            this.error_TicketsSold.Text = "Enter numbers";
            // 
            // error_TVCover
            // 
            this.error_TVCover.AutoSize = true;
            this.error_TVCover.Location = new System.Drawing.Point(341, 79);
            this.error_TVCover.Name = "error_TVCover";
            this.error_TVCover.Size = new System.Drawing.Size(75, 13);
            this.error_TVCover.TabIndex = 17;
            this.error_TVCover.Text = "Enter numbers";
            // 
            // error_SportsVisitors
            // 
            this.error_SportsVisitors.AutoSize = true;
            this.error_SportsVisitors.Location = new System.Drawing.Point(341, 111);
            this.error_SportsVisitors.Name = "error_SportsVisitors";
            this.error_SportsVisitors.Size = new System.Drawing.Size(75, 13);
            this.error_SportsVisitors.TabIndex = 18;
            this.error_SportsVisitors.Text = "Enter numbers";
            // 
            // error_FitnessSubscribers
            // 
            this.error_FitnessSubscribers.AutoSize = true;
            this.error_FitnessSubscribers.Location = new System.Drawing.Point(341, 149);
            this.error_FitnessSubscribers.Name = "error_FitnessSubscribers";
            this.error_FitnessSubscribers.Size = new System.Drawing.Size(75, 13);
            this.error_FitnessSubscribers.TabIndex = 19;
            this.error_FitnessSubscribers.Text = "Enter numbers";
            // 
            // error_VisitorsAppear
            // 
            this.error_VisitorsAppear.AutoSize = true;
            this.error_VisitorsAppear.Location = new System.Drawing.Point(341, 184);
            this.error_VisitorsAppear.Name = "error_VisitorsAppear";
            this.error_VisitorsAppear.Size = new System.Drawing.Size(75, 13);
            this.error_VisitorsAppear.TabIndex = 20;
            this.error_VisitorsAppear.Text = "Enter numbers";
            // 
            // afslutOgBeregn
            // 
            this.afslutOgBeregn.Enabled = false;
            this.afslutOgBeregn.Location = new System.Drawing.Point(526, 146);
            this.afslutOgBeregn.Name = "afslutOgBeregn";
            this.afslutOgBeregn.Size = new System.Drawing.Size(153, 23);
            this.afslutOgBeregn.TabIndex = 21;
            this.afslutOgBeregn.Text = "Vis of afslut beregninger";
            this.afslutOgBeregn.UseVisualStyleBackColor = true;
            this.afslutOgBeregn.Click += new System.EventHandler(this.afslutOgBeregn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(46, 220);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(526, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 138);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.TicketsSold,
            this.TVCover,
            this.SportsVistors,
            this.FitnessSubscribers,
            this.VisitorsAppear,
            this.TotalSales,
            this.TotalExpenses,
            this.TotalEarnings});
            this.dataGridView1.Location = new System.Drawing.Point(46, 354);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 150);
            this.dataGridView1.TabIndex = 24;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(46, 255);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(89, 20);
            this.txtDate.TabIndex = 25;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(165, 258);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(69, 13);
            this.DateLabel.TabIndex = 26;
            this.DateLabel.Text = "Choose Date";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 75;
            // 
            // TicketsSold
            // 
            this.TicketsSold.HeaderText = "Tickets Sold";
            this.TicketsSold.Name = "TicketsSold";
            this.TicketsSold.Width = 50;
            // 
            // TVCover
            // 
            this.TVCover.HeaderText = "TV Cover";
            this.TVCover.Name = "TVCover";
            this.TVCover.Width = 40;
            // 
            // SportsVistors
            // 
            this.SportsVistors.HeaderText = "Sports Visitors";
            this.SportsVistors.Name = "SportsVistors";
            // 
            // FitnessSubscribers
            // 
            this.FitnessSubscribers.HeaderText = "Fitness Subscribers";
            this.FitnessSubscribers.Name = "FitnessSubscribers";
            // 
            // VisitorsAppear
            // 
            this.VisitorsAppear.HeaderText = "Visitors who appear in %";
            this.VisitorsAppear.Name = "VisitorsAppear";
            this.VisitorsAppear.Width = 50;
            // 
            // TotalSales
            // 
            this.TotalSales.HeaderText = "Total Sales";
            this.TotalSales.Name = "TotalSales";
            // 
            // TotalExpenses
            // 
            this.TotalExpenses.HeaderText = "Total Expenses";
            this.TotalExpenses.Name = "TotalExpenses";
            // 
            // TotalEarnings
            // 
            this.TotalEarnings.HeaderText = "Total Earnings";
            this.TotalEarnings.Name = "TotalEarnings";
            // 
            // TotalSalesLabelShow
            // 
            this.TotalSalesLabelShow.AutoSize = true;
            this.TotalSalesLabelShow.Location = new System.Drawing.Point(523, 45);
            this.TotalSalesLabelShow.Name = "TotalSalesLabelShow";
            this.TotalSalesLabelShow.Size = new System.Drawing.Size(63, 13);
            this.TotalSalesLabelShow.TabIndex = 27;
            this.TotalSalesLabelShow.Text = "Total Sales:";
            // 
            // TotalExpensesLabelShow
            // 
            this.TotalExpensesLabelShow.AutoSize = true;
            this.TotalExpensesLabelShow.Location = new System.Drawing.Point(523, 79);
            this.TotalExpensesLabelShow.Name = "TotalExpensesLabelShow";
            this.TotalExpensesLabelShow.Size = new System.Drawing.Size(83, 13);
            this.TotalExpensesLabelShow.TabIndex = 28;
            this.TotalExpensesLabelShow.Text = "Total Expenses:";
            // 
            // TotalEarningsLabelShow
            // 
            this.TotalEarningsLabelShow.AutoSize = true;
            this.TotalEarningsLabelShow.Location = new System.Drawing.Point(523, 111);
            this.TotalEarningsLabelShow.Name = "TotalEarningsLabelShow";
            this.TotalEarningsLabelShow.Size = new System.Drawing.Size(78, 13);
            this.TotalEarningsLabelShow.TabIndex = 29;
            this.TotalEarningsLabelShow.Text = "Total Earnings:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 539);
            this.Controls.Add(this.TotalEarningsLabelShow);
            this.Controls.Add(this.TotalExpensesLabelShow);
            this.Controls.Add(this.TotalSalesLabelShow);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.afslutOgBeregn);
            this.Controls.Add(this.error_VisitorsAppear);
            this.Controls.Add(this.error_FitnessSubscribers);
            this.Controls.Add(this.error_SportsVisitors);
            this.Controls.Add(this.error_TVCover);
            this.Controls.Add(this.error_TicketsSold);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.TotalEarningsLabel);
            this.Controls.Add(this.TotalExpensesLabel);
            this.Controls.Add(this.TotalSalesLabel);
            this.Controls.Add(this.txtVisitorsAppear);
            this.Controls.Add(this.txtFitnessSubscribers);
            this.Controls.Add(this.txtSportsVisitors);
            this.Controls.Add(this.txtTVCover);
            this.Controls.Add(this.txtTicketsSold);
            this.Controls.Add(this.SalesLabel);
            this.Controls.Add(this.beregn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button beregn;
        private System.Windows.Forms.Label SalesLabel;
        private System.Windows.Forms.TextBox txtTicketsSold;
        private System.Windows.Forms.TextBox txtTVCover;
        private System.Windows.Forms.TextBox txtSportsVisitors;
        private System.Windows.Forms.TextBox txtFitnessSubscribers;
        private System.Windows.Forms.TextBox txtVisitorsAppear;
        private System.Windows.Forms.Label TotalSalesLabel;
        private System.Windows.Forms.Label TotalExpensesLabel;
        private System.Windows.Forms.Label TotalEarningsLabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label error_TicketsSold;
        private System.Windows.Forms.Label error_TVCover;
        private System.Windows.Forms.Label error_SportsVisitors;
        private System.Windows.Forms.Label error_FitnessSubscribers;
        private System.Windows.Forms.Label error_VisitorsAppear;
        private System.Windows.Forms.Button afslutOgBeregn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketsSold;
        private System.Windows.Forms.DataGridViewTextBoxColumn TVCover;
        private System.Windows.Forms.DataGridViewTextBoxColumn SportsVistors;
        private System.Windows.Forms.DataGridViewTextBoxColumn FitnessSubscribers;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitorsAppear;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalExpenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalEarnings;
        private System.Windows.Forms.Label TotalSalesLabelShow;
        private System.Windows.Forms.Label TotalExpensesLabelShow;
        private System.Windows.Forms.Label TotalEarningsLabelShow;
    }
}

