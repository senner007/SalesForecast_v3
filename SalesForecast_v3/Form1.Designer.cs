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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SalesLabel = new System.Windows.Forms.Label();
            this.txtTicketsSold = new System.Windows.Forms.TextBox();
            this.txtTVCover = new System.Windows.Forms.TextBox();
            this.txtSportsVisitors = new System.Windows.Forms.TextBox();
            this.txtFitnessSubscribers = new System.Windows.Forms.TextBox();
            this.txtVisitorsAppear = new System.Windows.Forms.TextBox();
            this.TotalSalesLabel = new System.Windows.Forms.Label();
            this.TotalExpensesLabel = new System.Windows.Forms.Label();
            this.TotalEarningsLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.error_TicketsSold = new System.Windows.Forms.Label();
            this.error_TVCover = new System.Windows.Forms.Label();
            this.error_SportsVisitors = new System.Windows.Forms.Label();
            this.error_FitnessSubscribers = new System.Windows.Forms.Label();
            this.error_VisitorsAppear = new System.Windows.Forms.Label();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Beregn Salg";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.txtTicketsSold.Location = new System.Drawing.Point(252, 42);
            this.txtTicketsSold.Name = "txtTicketsSold";
            this.txtTicketsSold.Size = new System.Drawing.Size(100, 20);
            this.txtTicketsSold.TabIndex = 7;
            this.txtTicketsSold.TextChanged += new System.EventHandler(this.onTextChange_TextChanged);
            // 
            // txtTVCover
            // 
            this.txtTVCover.Location = new System.Drawing.Point(252, 76);
            this.txtTVCover.Name = "txtTVCover";
            this.txtTVCover.Size = new System.Drawing.Size(100, 20);
            this.txtTVCover.TabIndex = 8;
            this.txtTVCover.TextChanged += new System.EventHandler(this.onTextChange_TextChanged);
            // 
            // txtSportsVisitors
            // 
            this.txtSportsVisitors.Location = new System.Drawing.Point(252, 111);
            this.txtSportsVisitors.Name = "txtSportsVisitors";
            this.txtSportsVisitors.Size = new System.Drawing.Size(100, 20);
            this.txtSportsVisitors.TabIndex = 9;
            this.txtSportsVisitors.TextChanged += new System.EventHandler(this.onTextChange_TextChanged);
            // 
            // txtFitnessSubscribers
            // 
            this.txtFitnessSubscribers.Location = new System.Drawing.Point(252, 149);
            this.txtFitnessSubscribers.Name = "txtFitnessSubscribers";
            this.txtFitnessSubscribers.Size = new System.Drawing.Size(100, 20);
            this.txtFitnessSubscribers.TabIndex = 10;
            this.txtFitnessSubscribers.TextChanged += new System.EventHandler(this.onTextChange_TextChanged);
            // 
            // txtVisitorsAppear
            // 
            this.txtVisitorsAppear.Location = new System.Drawing.Point(252, 181);
            this.txtVisitorsAppear.Name = "txtVisitorsAppear";
            this.txtVisitorsAppear.Size = new System.Drawing.Size(100, 20);
            this.txtVisitorsAppear.TabIndex = 11;
            this.txtVisitorsAppear.TextChanged += new System.EventHandler(this.onTextChange_TextChanged);
            // 
            // TotalSalesLabel
            // 
            this.TotalSalesLabel.AutoSize = true;
            this.TotalSalesLabel.Location = new System.Drawing.Point(492, 49);
            this.TotalSalesLabel.Name = "TotalSalesLabel";
            this.TotalSalesLabel.Size = new System.Drawing.Size(63, 13);
            this.TotalSalesLabel.TabIndex = 12;
            this.TotalSalesLabel.Text = "Total Sales:";
            // 
            // TotalExpensesLabel
            // 
            this.TotalExpensesLabel.AutoSize = true;
            this.TotalExpensesLabel.Location = new System.Drawing.Point(492, 79);
            this.TotalExpensesLabel.Name = "TotalExpensesLabel";
            this.TotalExpensesLabel.Size = new System.Drawing.Size(83, 13);
            this.TotalExpensesLabel.TabIndex = 13;
            this.TotalExpensesLabel.Text = "Total Expenses:";
            // 
            // TotalEarningsLabel
            // 
            this.TotalEarningsLabel.AutoSize = true;
            this.TotalEarningsLabel.Location = new System.Drawing.Point(492, 111);
            this.TotalEarningsLabel.Name = "TotalEarningsLabel";
            this.TotalEarningsLabel.Size = new System.Drawing.Size(78, 13);
            this.TotalEarningsLabel.TabIndex = 14;
            this.TotalEarningsLabel.Text = "Total Earnings:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Nulstil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // error_TicketsSold
            // 
            this.error_TicketsSold.AutoSize = true;
            this.error_TicketsSold.Location = new System.Drawing.Point(386, 42);
            this.error_TicketsSold.Name = "error_TicketsSold";
            this.error_TicketsSold.Size = new System.Drawing.Size(35, 13);
            this.error_TicketsSold.TabIndex = 16;
            this.error_TicketsSold.Text = "label6";
            // 
            // error_TVCover
            // 
            this.error_TVCover.AutoSize = true;
            this.error_TVCover.Location = new System.Drawing.Point(386, 76);
            this.error_TVCover.Name = "error_TVCover";
            this.error_TVCover.Size = new System.Drawing.Size(35, 13);
            this.error_TVCover.TabIndex = 17;
            this.error_TVCover.Text = "label6";
            // 
            // error_SportsVisitors
            // 
            this.error_SportsVisitors.AutoSize = true;
            this.error_SportsVisitors.Location = new System.Drawing.Point(386, 111);
            this.error_SportsVisitors.Name = "error_SportsVisitors";
            this.error_SportsVisitors.Size = new System.Drawing.Size(35, 13);
            this.error_SportsVisitors.TabIndex = 18;
            this.error_SportsVisitors.Text = "label6";
            // 
            // error_FitnessSubscribers
            // 
            this.error_FitnessSubscribers.AutoSize = true;
            this.error_FitnessSubscribers.Location = new System.Drawing.Point(386, 149);
            this.error_FitnessSubscribers.Name = "error_FitnessSubscribers";
            this.error_FitnessSubscribers.Size = new System.Drawing.Size(35, 13);
            this.error_FitnessSubscribers.TabIndex = 19;
            this.error_FitnessSubscribers.Text = "label6";
            // 
            // error_VisitorsAppear
            // 
            this.error_VisitorsAppear.AutoSize = true;
            this.error_VisitorsAppear.Location = new System.Drawing.Point(386, 187);
            this.error_VisitorsAppear.Name = "error_VisitorsAppear";
            this.error_VisitorsAppear.Size = new System.Drawing.Size(35, 13);
            this.error_VisitorsAppear.TabIndex = 20;
            this.error_VisitorsAppear.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.error_VisitorsAppear);
            this.Controls.Add(this.error_FitnessSubscribers);
            this.Controls.Add(this.error_SportsVisitors);
            this.Controls.Add(this.error_TVCover);
            this.Controls.Add(this.error_TicketsSold);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TotalEarningsLabel);
            this.Controls.Add(this.TotalExpensesLabel);
            this.Controls.Add(this.TotalSalesLabel);
            this.Controls.Add(this.txtVisitorsAppear);
            this.Controls.Add(this.txtFitnessSubscribers);
            this.Controls.Add(this.txtSportsVisitors);
            this.Controls.Add(this.txtTVCover);
            this.Controls.Add(this.txtTicketsSold);
            this.Controls.Add(this.SalesLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label SalesLabel;
        private System.Windows.Forms.TextBox txtTicketsSold;
        private System.Windows.Forms.TextBox txtTVCover;
        private System.Windows.Forms.TextBox txtSportsVisitors;
        private System.Windows.Forms.TextBox txtFitnessSubscribers;
        private System.Windows.Forms.TextBox txtVisitorsAppear;
        private System.Windows.Forms.Label TotalSalesLabel;
        private System.Windows.Forms.Label TotalExpensesLabel;
        private System.Windows.Forms.Label TotalEarningsLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label error_TicketsSold;
        private System.Windows.Forms.Label error_TVCover;
        private System.Windows.Forms.Label error_SportsVisitors;
        private System.Windows.Forms.Label error_FitnessSubscribers;
        private System.Windows.Forms.Label error_VisitorsAppear;
    }
}

