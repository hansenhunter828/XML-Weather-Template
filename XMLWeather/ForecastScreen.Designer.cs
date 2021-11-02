namespace XMLWeather
{
    partial class ForecastScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.min1 = new System.Windows.Forms.Label();
            this.max1 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.min2 = new System.Windows.Forms.Label();
            this.max2 = new System.Windows.Forms.Label();
            this.menuLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.date4 = new System.Windows.Forms.Label();
            this.min4 = new System.Windows.Forms.Label();
            this.max4 = new System.Windows.Forms.Label();
            this.date3 = new System.Windows.Forms.Label();
            this.min3 = new System.Windows.Forms.Label();
            this.max3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // min1
            // 
            this.min1.BackColor = System.Drawing.Color.Transparent;
            this.min1.ForeColor = System.Drawing.Color.Cyan;
            this.min1.Location = new System.Drawing.Point(273, 13);
            this.min1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min1.Name = "min1";
            this.min1.Size = new System.Drawing.Size(29, 16);
            this.min1.TabIndex = 48;
            // 
            // max1
            // 
            this.max1.BackColor = System.Drawing.Color.Transparent;
            this.max1.ForeColor = System.Drawing.Color.Red;
            this.max1.Location = new System.Drawing.Point(236, 13);
            this.max1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max1.Name = "max1";
            this.max1.Size = new System.Drawing.Size(29, 16);
            this.max1.TabIndex = 45;
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.ForeColor = System.Drawing.Color.White;
            this.date1.Location = new System.Drawing.Point(81, 12);
            this.date1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(38, 17);
            this.date1.TabIndex = 64;
            this.date1.Text = "Date";
            // 
            // date2
            // 
            this.date2.AutoSize = true;
            this.date2.ForeColor = System.Drawing.Color.White;
            this.date2.Location = new System.Drawing.Point(81, 62);
            this.date2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(38, 17);
            this.date2.TabIndex = 69;
            this.date2.Text = "Date";
            // 
            // min2
            // 
            this.min2.BackColor = System.Drawing.Color.Transparent;
            this.min2.ForeColor = System.Drawing.Color.Cyan;
            this.min2.Location = new System.Drawing.Point(273, 62);
            this.min2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min2.Name = "min2";
            this.min2.Size = new System.Drawing.Size(29, 16);
            this.min2.TabIndex = 68;
            // 
            // max2
            // 
            this.max2.BackColor = System.Drawing.Color.Transparent;
            this.max2.ForeColor = System.Drawing.Color.Red;
            this.max2.Location = new System.Drawing.Point(236, 62);
            this.max2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max2.Name = "max2";
            this.max2.Size = new System.Drawing.Size(29, 16);
            this.max2.TabIndex = 66;
            // 
            // menuLabel
            // 
            this.menuLabel.BackColor = System.Drawing.Color.Transparent;
            this.menuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.Color.White;
            this.menuLabel.Location = new System.Drawing.Point(5, 0);
            this.menuLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(47, 34);
            this.menuLabel.TabIndex = 73;
            this.menuLabel.Text = "---";
            this.menuLabel.Click += new System.EventHandler(this.menuLabel_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(5, 97);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(79, 34);
            this.searchLabel.TabIndex = 72;
            this.searchLabel.Text = "Search";
            this.searchLabel.Click += new System.EventHandler(this.searchLabel_Click);
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(5, 63);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(70, 34);
            this.forecastLabel.TabIndex = 71;
            this.forecastLabel.Text = "7 Day";
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.Transparent;
            this.todayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.ForeColor = System.Drawing.Color.White;
            this.todayLabel.Location = new System.Drawing.Point(4, 29);
            this.todayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(71, 34);
            this.todayLabel.TabIndex = 70;
            this.todayLabel.Text = "Today";
            this.todayLabel.Click += new System.EventHandler(this.todayLabel_Click);
            // 
            // date4
            // 
            this.date4.AutoSize = true;
            this.date4.ForeColor = System.Drawing.Color.White;
            this.date4.Location = new System.Drawing.Point(81, 164);
            this.date4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date4.Name = "date4";
            this.date4.Size = new System.Drawing.Size(38, 17);
            this.date4.TabIndex = 83;
            this.date4.Text = "Date";
            // 
            // min4
            // 
            this.min4.BackColor = System.Drawing.Color.Transparent;
            this.min4.ForeColor = System.Drawing.Color.Cyan;
            this.min4.Location = new System.Drawing.Point(273, 164);
            this.min4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min4.Name = "min4";
            this.min4.Size = new System.Drawing.Size(29, 16);
            this.min4.TabIndex = 82;
            // 
            // max4
            // 
            this.max4.BackColor = System.Drawing.Color.Transparent;
            this.max4.ForeColor = System.Drawing.Color.Red;
            this.max4.Location = new System.Drawing.Point(236, 164);
            this.max4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max4.Name = "max4";
            this.max4.Size = new System.Drawing.Size(29, 16);
            this.max4.TabIndex = 80;
            // 
            // date3
            // 
            this.date3.AutoSize = true;
            this.date3.ForeColor = System.Drawing.Color.White;
            this.date3.Location = new System.Drawing.Point(81, 115);
            this.date3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date3.Name = "date3";
            this.date3.Size = new System.Drawing.Size(38, 17);
            this.date3.TabIndex = 78;
            this.date3.Text = "Date";
            // 
            // min3
            // 
            this.min3.BackColor = System.Drawing.Color.Transparent;
            this.min3.ForeColor = System.Drawing.Color.Cyan;
            this.min3.Location = new System.Drawing.Point(273, 114);
            this.min3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min3.Name = "min3";
            this.min3.Size = new System.Drawing.Size(29, 16);
            this.min3.TabIndex = 77;
            // 
            // max3
            // 
            this.max3.BackColor = System.Drawing.Color.Transparent;
            this.max3.ForeColor = System.Drawing.Color.Brown;
            this.max3.Location = new System.Drawing.Point(236, 114);
            this.max3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max3.Name = "max3";
            this.max3.Size = new System.Drawing.Size(29, 16);
            this.max3.TabIndex = 75;
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.date4);
            this.Controls.Add(this.min4);
            this.Controls.Add(this.max4);
            this.Controls.Add(this.date3);
            this.Controls.Add(this.min3);
            this.Controls.Add(this.max3);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.min2);
            this.Controls.Add(this.max2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.min1);
            this.Controls.Add(this.max1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(333, 492);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label min1;
        private System.Windows.Forms.Label max1;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label min2;
        private System.Windows.Forms.Label max2;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label date4;
        private System.Windows.Forms.Label min4;
        private System.Windows.Forms.Label max4;
        private System.Windows.Forms.Label date3;
        private System.Windows.Forms.Label min3;
        private System.Windows.Forms.Label max3;
    }
}
