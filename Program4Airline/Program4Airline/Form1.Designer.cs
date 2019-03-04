namespace Program4Airline
{
    partial class frmFlights
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
            this.grpFlightsToday = new System.Windows.Forms.GroupBox();
            this.rdoSccAir = new System.Windows.Forms.RadioButton();
            this.rdoLincolnAir = new System.Windows.Forms.RadioButton();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSeatNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFlights = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.grpFlightsToday.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFlightsToday
            // 
            this.grpFlightsToday.Controls.Add(this.rdoSccAir);
            this.grpFlightsToday.Controls.Add(this.rdoLincolnAir);
            this.grpFlightsToday.Location = new System.Drawing.Point(12, 12);
            this.grpFlightsToday.Name = "grpFlightsToday";
            this.grpFlightsToday.Size = new System.Drawing.Size(356, 85);
            this.grpFlightsToday.TabIndex = 0;
            this.grpFlightsToday.TabStop = false;
            this.grpFlightsToday.Text = "Flights Today";
            // 
            // rdoSccAir
            // 
            this.rdoSccAir.AutoSize = true;
            this.rdoSccAir.Location = new System.Drawing.Point(201, 34);
            this.rdoSccAir.Name = "rdoSccAir";
            this.rdoSccAir.Size = new System.Drawing.Size(77, 17);
            this.rdoSccAir.TabIndex = 1;
            this.rdoSccAir.TabStop = true;
            this.rdoSccAir.Text = "SCC Airline";
            this.rdoSccAir.UseVisualStyleBackColor = true;
            this.rdoSccAir.CheckedChanged += new System.EventHandler(this.FlightsToday_Changed);
            // 
            // rdoLincolnAir
            // 
            this.rdoLincolnAir.AutoSize = true;
            this.rdoLincolnAir.Checked = true;
            this.rdoLincolnAir.Location = new System.Drawing.Point(22, 34);
            this.rdoLincolnAir.Name = "rdoLincolnAir";
            this.rdoLincolnAir.Size = new System.Drawing.Size(90, 17);
            this.rdoLincolnAir.TabIndex = 0;
            this.rdoLincolnAir.TabStop = true;
            this.rdoLincolnAir.Text = "Lincoln Airline";
            this.rdoLincolnAir.UseVisualStyleBackColor = true;
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(310, 154);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(75, 23);
            this.btnReserve.TabIndex = 2;
            this.btnReserve.Text = "Reserve Flight";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(495, 309);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(470, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            this.txtName.Tag = "Name";
            // 
            // txtSeatNumber
            // 
            this.txtSeatNumber.Location = new System.Drawing.Point(470, 193);
            this.txtSeatNumber.Name = "txtSeatNumber";
            this.txtSeatNumber.Size = new System.Drawing.Size(100, 20);
            this.txtSeatNumber.TabIndex = 6;
            this.txtSeatNumber.Tag = "Seat Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Seat Number";
            // 
            // lblFlights
            // 
            this.lblFlights.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFlights.Location = new System.Drawing.Point(12, 100);
            this.lblFlights.Name = "lblFlights";
            this.lblFlights.Size = new System.Drawing.Size(236, 232);
            this.lblFlights.TabIndex = 8;
            this.lblFlights.Text = "\"\"";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(458, 253);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(121, 23);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove From Seat";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 341);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblFlights);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSeatNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.grpFlightsToday);
            this.Name = "frmFlights";
            this.Text = "Flights Form";
            this.Load += new System.EventHandler(this.frmFlights_Load);
            this.grpFlightsToday.ResumeLayout(false);
            this.grpFlightsToday.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFlightsToday;
        private System.Windows.Forms.RadioButton rdoSccAir;
        private System.Windows.Forms.RadioButton rdoLincolnAir;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSeatNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFlights;
        private System.Windows.Forms.Button btnRemove;

    }
}

