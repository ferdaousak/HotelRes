
namespace HotelReservation
{
    partial class ReservationForm
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
            this.lblusername = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateReservation = new System.Windows.Forms.DateTimePicker();
            this.nbrJoursReserv = new System.Windows.Forms.NumericUpDown();
            this.lblNbrDays = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nbrJoursReserv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(27, 49);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(109, 13);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "Veuillez saisir le nom :";
            this.lblusername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(30, 77);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(151, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(27, 118);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(204, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Veuillez choisir Votre date de réservation :";
            // 
            // dateReservation
            // 
            this.dateReservation.Location = new System.Drawing.Point(30, 151);
            this.dateReservation.MinDate = new System.DateTime(2021, 7, 3, 0, 0, 0, 0);
            this.dateReservation.Name = "dateReservation";
            this.dateReservation.Size = new System.Drawing.Size(200, 20);
            this.dateReservation.TabIndex = 3;
            // 
            // nbrJoursReserv
            // 
            this.nbrJoursReserv.BackColor = System.Drawing.Color.Wheat;
            this.nbrJoursReserv.Location = new System.Drawing.Point(282, 151);
            this.nbrJoursReserv.Name = "nbrJoursReserv";
            this.nbrJoursReserv.Size = new System.Drawing.Size(45, 20);
            this.nbrJoursReserv.TabIndex = 4;
            // 
            // lblNbrDays
            // 
            this.lblNbrDays.AutoSize = true;
            this.lblNbrDays.Location = new System.Drawing.Point(279, 118);
            this.lblNbrDays.Name = "lblNbrDays";
            this.lblNbrDays.Size = new System.Drawing.Size(118, 13);
            this.lblNbrDays.TabIndex = 5;
            this.lblNbrDays.Text = "Veuillez saisir la Durée :";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(136, 189);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(123, 23);
            this.confirmBtn.TabIndex = 6;
            this.confirmBtn.Text = "Réserver";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.DarkBlue;
            this.Title.Location = new System.Drawing.Point(142, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(107, 24);
            this.Title.TabIndex = 7;
            this.Title.Text = "Chambre :";
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(404, 224);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.lblNbrDays);
            this.Controls.Add(this.nbrJoursReserv);
            this.Controls.Add(this.dateReservation);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.lblusername);
            this.Name = "ReservationForm";
            this.Text = "Reservation du chambre :";
            ((System.ComponentModel.ISupportInitialize)(this.nbrJoursReserv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateReservation;
        private System.Windows.Forms.NumericUpDown nbrJoursReserv;
        private System.Windows.Forms.Label lblNbrDays;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label Title;
    }
}