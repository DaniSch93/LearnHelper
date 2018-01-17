namespace LearnHelper
{
    partial class DataList
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
            this.listData = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listData
            // 
            this.listData.Location = new System.Drawing.Point(31, 32);
            this.listData.Name = "listData";
            this.listData.Size = new System.Drawing.Size(683, 589);
            this.listData.TabIndex = 0;
            this.listData.UseCompatibleStateImageBehavior = false;
            // 
            // DataList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 673);
            this.Controls.Add(this.listData);
            this.Name = "DataList";
            this.Text = "DataList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listData;
    }
}