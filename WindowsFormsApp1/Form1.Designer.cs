namespace WindowsFormsApp1
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
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.ButtonTop = new System.Windows.Forms.Button();
            this.ButtonAppointment = new System.Windows.Forms.Button();
            this.ButtonPrice = new System.Windows.Forms.Button();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.Controls.Add(this.ButtonTop);
            this.PanelMenu.Controls.Add(this.ButtonAppointment);
            this.PanelMenu.Controls.Add(this.ButtonPrice);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(800, 66);
            this.PanelMenu.TabIndex = 0;
            // 
            // ButtonTop
            // 
            this.ButtonTop.Location = new System.Drawing.Point(634, 0);
            this.ButtonTop.Name = "ButtonTop";
            this.ButtonTop.Size = new System.Drawing.Size(166, 66);
            this.ButtonTop.TabIndex = 0;
            this.ButtonTop.Text = "Топ послуг";
            this.ButtonTop.UseVisualStyleBackColor = true;
            this.ButtonTop.Click += new System.EventHandler(this.ButtonTop_Click);
            // 
            // ButtonAppointment
            // 
            this.ButtonAppointment.Location = new System.Drawing.Point(337, 0);
            this.ButtonAppointment.Name = "ButtonAppointment";
            this.ButtonAppointment.Size = new System.Drawing.Size(166, 66);
            this.ButtonAppointment.TabIndex = 0;
            this.ButtonAppointment.Text = "Запис";
            this.ButtonAppointment.UseVisualStyleBackColor = true;
            this.ButtonAppointment.Click += new System.EventHandler(this.ButtonAppointment_Click);
            // 
            // ButtonPrice
            // 
            this.ButtonPrice.Location = new System.Drawing.Point(0, 0);
            this.ButtonPrice.Name = "ButtonPrice";
            this.ButtonPrice.Size = new System.Drawing.Size(166, 66);
            this.ButtonPrice.TabIndex = 0;
            this.ButtonPrice.Text = "Прайс";
            this.ButtonPrice.UseVisualStyleBackColor = true;
            this.ButtonPrice.Click += new System.EventHandler(this.ButtonPrice_Click);
            // 
            // PanelContainer
            // 
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(0, 66);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(800, 384);
            this.PanelContainer.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.PanelMenu);
            this.Name = "Form1";
            this.Text = "Вікно";
            this.PanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button ButtonTop;
        private System.Windows.Forms.Button ButtonAppointment;
        private System.Windows.Forms.Button ButtonPrice;
        private System.Windows.Forms.Panel PanelContainer;
    }
}

