
namespace HotelReservation.userControls
{
    partial class ucHotel
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
            this.ChambresPanel = new System.Windows.Forms.TableLayoutPanel();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ChambresPanel
            // 
            this.ChambresPanel.AutoSize = true;
            this.ChambresPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChambresPanel.ColumnCount = 4;
            this.ChambresPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ChambresPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ChambresPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ChambresPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ChambresPanel.Location = new System.Drawing.Point(3, 3);
            this.ChambresPanel.Margin = new System.Windows.Forms.Padding(3, 20, 0, 0);
            this.ChambresPanel.Name = "ChambresPanel";
            this.ChambresPanel.RowCount = 2;
            this.ChambresPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ChambresPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ChambresPanel.Size = new System.Drawing.Size(0, 0);
            this.ChambresPanel.TabIndex = 0;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(4, 350);
            this.date.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 1;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // ucHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.date);
            this.Controls.Add(this.ChambresPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "ucHotel";
            this.Size = new System.Drawing.Size(207, 380);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ChambresPanel;
        private System.Windows.Forms.DateTimePicker date;
    }
}
