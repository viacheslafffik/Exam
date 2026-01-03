namespace WindowsFormsApp1.Panels
{
    partial class PanelAppointment
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
            this.DateAppointment = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListServices = new System.Windows.Forms.CheckedListBox();
            this.ButtonAddAppointment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateAppointment
            // 
            this.DateAppointment.Location = new System.Drawing.Point(30, 38);
            this.DateAppointment.Name = "DateAppointment";
            this.DateAppointment.Size = new System.Drawing.Size(200, 20);
            this.DateAppointment.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Список";
            // 
            // ListServices
            // 
            this.ListServices.FormattingEnabled = true;
            this.ListServices.Location = new System.Drawing.Point(30, 109);
            this.ListServices.Name = "ListServices";
            this.ListServices.Size = new System.Drawing.Size(200, 199);
            this.ListServices.TabIndex = 3;
            // 
            // ButtonAddAppointment
            // 
            this.ButtonAddAppointment.Location = new System.Drawing.Point(143, 78);
            this.ButtonAddAppointment.Name = "ButtonAddAppointment";
            this.ButtonAddAppointment.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddAppointment.TabIndex = 4;
            this.ButtonAddAppointment.Text = "Записати";
            this.ButtonAddAppointment.UseVisualStyleBackColor = true;
            this.ButtonAddAppointment.Click += new System.EventHandler(this.ButtonAddAppointment_Click);
            // 
            // PanelAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonAddAppointment);
            this.Controls.Add(this.ListServices);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateAppointment);
            this.Name = "PanelAppointment";
            this.Size = new System.Drawing.Size(272, 328);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateAppointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox ListServices;
        private System.Windows.Forms.Button ButtonAddAppointment;
    }
}
