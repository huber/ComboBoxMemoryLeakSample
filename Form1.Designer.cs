namespace ComboBoxMemoryLeakSample
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxLeak = new System.Windows.Forms.ComboBox();
            this.buttonAddItems = new System.Windows.Forms.Button();
            this.buttonRemoveItem = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBoxLeak
            // 
            this.comboBoxLeak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLeak.FormattingEnabled = true;
            this.comboBoxLeak.Location = new System.Drawing.Point(12, 12);
            this.comboBoxLeak.Name = "comboBoxLeak";
            this.comboBoxLeak.Size = new System.Drawing.Size(322, 21);
            this.comboBoxLeak.TabIndex = 0;
            // 
            // buttonAddItems
            // 
            this.buttonAddItems.Location = new System.Drawing.Point(340, 12);
            this.buttonAddItems.Name = "buttonAddItems";
            this.buttonAddItems.Size = new System.Drawing.Size(75, 23);
            this.buttonAddItems.TabIndex = 1;
            this.buttonAddItems.Text = "AddItems";
            this.buttonAddItems.UseVisualStyleBackColor = true;
            this.buttonAddItems.Click += new System.EventHandler(this.buttonAddItems_Click);
            // 
            // buttonRemoveItem
            // 
            this.buttonRemoveItem.Enabled = false;
            this.buttonRemoveItem.Location = new System.Drawing.Point(340, 41);
            this.buttonRemoveItem.Name = "buttonRemoveItem";
            this.buttonRemoveItem.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveItem.TabIndex = 2;
            this.buttonRemoveItem.Text = "RemoveItem";
            this.buttonRemoveItem.UseVisualStyleBackColor = true;
            this.buttonRemoveItem.Click += new System.EventHandler(this.buttonRemoveItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(403, 160);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 251);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonRemoveItem);
            this.Controls.Add(this.buttonAddItems);
            this.Controls.Add(this.comboBoxLeak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLeak;
        private System.Windows.Forms.Button buttonAddItems;
        private System.Windows.Forms.Button buttonRemoveItem;
        private System.Windows.Forms.ListBox listBox1;
    }
}

