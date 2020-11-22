namespace nasledovanie
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
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("");
            this.refillButton = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.RichTextBox();
            this.getButton = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabletCountLabel = new System.Windows.Forms.Label();
            this.smartphoneCountLabel = new System.Windows.Forms.Label();
            this.notebookCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // refillButton
            // 
            this.refillButton.Location = new System.Drawing.Point(12, 12);
            this.refillButton.Name = "refillButton";
            this.refillButton.Size = new System.Drawing.Size(347, 45);
            this.refillButton.TabIndex = 0;
            this.refillButton.Text = "Перезаполнить";
            this.refillButton.UseVisualStyleBackColor = true;
            this.refillButton.Click += new System.EventHandler(this.refillButton_Click);
            // 
            // txtOut
            // 
            this.txtOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOut.Location = new System.Drawing.Point(12, 113);
            this.txtOut.Name = "txtOut";
            this.txtOut.ReadOnly = true;
            this.txtOut.Size = new System.Drawing.Size(249, 127);
            this.txtOut.TabIndex = 2;
            this.txtOut.Text = "";
            // 
            // getButton
            // 
            this.getButton.Location = new System.Drawing.Point(267, 113);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(92, 127);
            this.getButton.TabIndex = 3;
            this.getButton.Text = "button1";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // outputBox
            // 
            this.outputBox.HideSelection = false;
            this.outputBox.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20});
            this.outputBox.Location = new System.Drawing.Point(374, 12);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(172, 228);
            this.outputBox.TabIndex = 7;
            this.outputBox.UseCompatibleStateImageBehavior = false;
            this.outputBox.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ноутбуки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Планшеты:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Смартфоны:";
            // 
            // tabletCountLabel
            // 
            this.tabletCountLabel.AutoSize = true;
            this.tabletCountLabel.Location = new System.Drawing.Point(307, 77);
            this.tabletCountLabel.Name = "tabletCountLabel";
            this.tabletCountLabel.Size = new System.Drawing.Size(0, 13);
            this.tabletCountLabel.TabIndex = 12;
            // 
            // smartphoneCountLabel
            // 
            this.smartphoneCountLabel.AutoSize = true;
            this.smartphoneCountLabel.Location = new System.Drawing.Point(197, 77);
            this.smartphoneCountLabel.Name = "smartphoneCountLabel";
            this.smartphoneCountLabel.Size = new System.Drawing.Size(0, 13);
            this.smartphoneCountLabel.TabIndex = 13;
            // 
            // notebookCountLabel
            // 
            this.notebookCountLabel.AutoSize = true;
            this.notebookCountLabel.Location = new System.Drawing.Point(75, 77);
            this.notebookCountLabel.Name = "notebookCountLabel";
            this.notebookCountLabel.Size = new System.Drawing.Size(0, 13);
            this.notebookCountLabel.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 250);
            this.Controls.Add(this.notebookCountLabel);
            this.Controls.Add(this.smartphoneCountLabel);
            this.Controls.Add(this.tabletCountLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.refillButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гаджеты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refillButton;
        private System.Windows.Forms.RichTextBox txtOut;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.ListView outputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tabletCountLabel;
        private System.Windows.Forms.Label smartphoneCountLabel;
        private System.Windows.Forms.Label notebookCountLabel;
    }
}

