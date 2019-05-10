namespace WindowsFormsApp12
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.txtBox_NewItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddNewItem = new System.Windows.Forms.Button();
            this.btn_AddNewSubItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_NewSubItem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(466, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // txtBox_NewItem
            // 
            this.txtBox_NewItem.Location = new System.Drawing.Point(105, 190);
            this.txtBox_NewItem.Name = "txtBox_NewItem";
            this.txtBox_NewItem.Size = new System.Drawing.Size(194, 20);
            this.txtBox_NewItem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "New MenuItem";
            // 
            // btn_AddNewItem
            // 
            this.btn_AddNewItem.Location = new System.Drawing.Point(224, 229);
            this.btn_AddNewItem.Name = "btn_AddNewItem";
            this.btn_AddNewItem.Size = new System.Drawing.Size(75, 23);
            this.btn_AddNewItem.TabIndex = 3;
            this.btn_AddNewItem.Text = "Add";
            this.btn_AddNewItem.UseVisualStyleBackColor = true;
            this.btn_AddNewItem.Click += new System.EventHandler(this.btn_AddNewItem_Click);
            // 
            // btn_AddNewSubItem
            // 
            this.btn_AddNewSubItem.Location = new System.Drawing.Point(224, 331);
            this.btn_AddNewSubItem.Name = "btn_AddNewSubItem";
            this.btn_AddNewSubItem.Size = new System.Drawing.Size(75, 23);
            this.btn_AddNewSubItem.TabIndex = 6;
            this.btn_AddNewSubItem.Text = "Add";
            this.btn_AddNewSubItem.UseVisualStyleBackColor = true;
            this.btn_AddNewSubItem.Click += new System.EventHandler(this.btn_AddNewSubItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "New SubItem";
            // 
            // txtBox_NewSubItem
            // 
            this.txtBox_NewSubItem.Location = new System.Drawing.Point(105, 292);
            this.txtBox_NewSubItem.Name = "txtBox_NewSubItem";
            this.txtBox_NewSubItem.Size = new System.Drawing.Size(194, 20);
            this.txtBox_NewSubItem.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 432);
            this.Controls.Add(this.btn_AddNewSubItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_NewSubItem);
            this.Controls.Add(this.btn_AddNewItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_NewItem);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.TextBox txtBox_NewItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddNewItem;
        private System.Windows.Forms.Button btn_AddNewSubItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_NewSubItem;
    }
}

