namespace WindowsFormsApp1.Panels
{
    partial class PanelTop
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
            this.TopDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TopList = new System.Windows.Forms.ListBox();
            this.ButtonShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TopDate
            // 
            this.TopDate.Location = new System.Drawing.Point(34, 40);
            this.TopDate.Name = "TopDate";
            this.TopDate.Size = new System.Drawing.Size(200, 20);
            this.TopDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Топ-3 послуг за обраною датою";
            // 
            // TopList
            // 
            this.TopList.FormattingEnabled = true;
            this.TopList.Location = new System.Drawing.Point(34, 145);
            this.TopList.Name = "TopList";
            this.TopList.Size = new System.Drawing.Size(200, 225);
            this.TopList.TabIndex = 3;
            // 
            // ButtonShow
            // 
            this.ButtonShow.Location = new System.Drawing.Point(92, 78);
            this.ButtonShow.Name = "ButtonShow";
            this.ButtonShow.Size = new System.Drawing.Size(75, 23);
            this.ButtonShow.TabIndex = 4;
            this.ButtonShow.Text = "Шукати";
            this.ButtonShow.UseVisualStyleBackColor = true;
            this.ButtonShow.Click += new System.EventHandler(this.ButtonShow_Click);
            // 
            // PanelTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonShow);
            this.Controls.Add(this.TopList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TopDate);
            this.Name = "PanelTop";
            this.Size = new System.Drawing.Size(281, 391);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker TopDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox TopList;
        private System.Windows.Forms.Button ButtonShow;
    }
}
