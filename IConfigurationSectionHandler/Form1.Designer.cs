namespace MySectionHandler
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
            this.readSection = new System.Windows.Forms.Button();
            this.listViewSection = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAttribute = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOldValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNewValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // readSection
            // 
            this.readSection.Location = new System.Drawing.Point(227, 230);
            this.readSection.Name = "readSection";
            this.readSection.Size = new System.Drawing.Size(184, 46);
            this.readSection.TabIndex = 0;
            this.readSection.Text = "Read Section";
            this.readSection.UseVisualStyleBackColor = true;
            this.readSection.Click += new System.EventHandler(this.ReadSection_OnClick);
            // 
            // listViewSection
            // 
            this.listViewSection.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderAttribute,
            this.columnHeaderOldValue,
            this.columnHeaderNewValue});
            this.listViewSection.FullRowSelect = true;
            this.listViewSection.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewSection.Location = new System.Drawing.Point(14, 12);
            this.listViewSection.Name = "listViewSection";
            this.listViewSection.Size = new System.Drawing.Size(398, 212);
            this.listViewSection.TabIndex = 1;
            this.listViewSection.UseCompatibleStateImageBehavior = false;
            this.listViewSection.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Id";
            this.columnHeaderId.Width = 40;
            // 
            // columnHeaderAttribute
            // 
            this.columnHeaderAttribute.Text = "Attribute";
            this.columnHeaderAttribute.Width = 100;
            // 
            // columnHeaderOldValue
            // 
            this.columnHeaderOldValue.Text = "Old value";
            this.columnHeaderOldValue.Width = 100;
            // 
            // columnHeaderNewValue
            // 
            this.columnHeaderNewValue.Text = "New value";
            this.columnHeaderNewValue.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 288);
            this.Controls.Add(this.listViewSection);
            this.Controls.Add(this.readSection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "IConfigurationSectionHandler Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button readSection;
        private System.Windows.Forms.ListView listViewSection;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderAttribute;
        private System.Windows.Forms.ColumnHeader columnHeaderOldValue;
        private System.Windows.Forms.ColumnHeader columnHeaderNewValue;

    }
}

