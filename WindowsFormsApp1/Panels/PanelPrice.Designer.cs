namespace WindowsFormsApp1.Panels
{
    partial class PanelPrice
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
            this.ServiceName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumericPrice = new System.Windows.Forms.NumericUpDown();
            this.ButtonAddService = new System.Windows.Forms.Button();
            this.GridServices = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonWordExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridServices)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiceName
            // 
            this.ServiceName.Location = new System.Drawing.Point(17, 38);
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.Size = new System.Drawing.Size(100, 20);
            this.ServiceName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Назва послуги";
            // 
            // NumericPrice
            // 
            this.NumericPrice.Location = new System.Drawing.Point(189, 38);
            this.NumericPrice.Name = "NumericPrice";
            this.NumericPrice.Size = new System.Drawing.Size(120, 20);
            this.NumericPrice.TabIndex = 2;
            // 
            // ButtonAddService
            // 
            this.ButtonAddService.Location = new System.Drawing.Point(399, 35);
            this.ButtonAddService.Name = "ButtonAddService";
            this.ButtonAddService.Size = new System.Drawing.Size(99, 23);
            this.ButtonAddService.TabIndex = 3;
            this.ButtonAddService.Text = "Додати";
            this.ButtonAddService.UseVisualStyleBackColor = true;
            this.ButtonAddService.Click += new System.EventHandler(this.ButtonAddService_Click);
            // 
            // GridServices
            // 
            this.GridServices.AllowUserToAddRows = false;
            this.GridServices.AllowUserToDeleteRows = false;
            this.GridServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridServices.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridServices.Location = new System.Drawing.Point(0, 106);
            this.GridServices.MultiSelect = false;
            this.GridServices.Name = "GridServices";
            this.GridServices.ReadOnly = true;
            this.GridServices.RowHeadersVisible = false;
            this.GridServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridServices.Size = new System.Drawing.Size(527, 254);
            this.GridServices.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ціна";
            // 
            // ButtonWordExport
            // 
            this.ButtonWordExport.Location = new System.Drawing.Point(399, 77);
            this.ButtonWordExport.Name = "ButtonWordExport";
            this.ButtonWordExport.Size = new System.Drawing.Size(99, 23);
            this.ButtonWordExport.TabIndex = 3;
            this.ButtonWordExport.Text = "Експорт у ворд";
            this.ButtonWordExport.UseVisualStyleBackColor = true;
            this.ButtonWordExport.Click += new System.EventHandler(this.ButtonWordExport_Click);
            // 
            // PanelPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GridServices);
            this.Controls.Add(this.ButtonWordExport);
            this.Controls.Add(this.ButtonAddService);
            this.Controls.Add(this.NumericPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServiceName);
            this.Name = "PanelPrice";
            this.Size = new System.Drawing.Size(527, 360);
            ((System.ComponentModel.ISupportInitialize)(this.NumericPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ServiceName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumericPrice;
        private System.Windows.Forms.Button ButtonAddService;
        private System.Windows.Forms.DataGridView GridServices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonWordExport;
    }
}
