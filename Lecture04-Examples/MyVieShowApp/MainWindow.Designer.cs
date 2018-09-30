namespace MyVieShowApp
{
    partial class MainWindow
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.selectNumberComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.receiptRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // selectNumberComboBox
            // 
            this.selectNumberComboBox.FormattingEnabled = true;
            this.selectNumberComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.selectNumberComboBox.Location = new System.Drawing.Point(730, 82);
            this.selectNumberComboBox.Name = "selectNumberComboBox";
            this.selectNumberComboBox.Size = new System.Drawing.Size(185, 23);
            this.selectNumberComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(725, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "請選擇購買張數";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(730, 139);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(185, 53);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "自動劃位";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // receiptRichTextBox
            // 
            this.receiptRichTextBox.Location = new System.Drawing.Point(730, 238);
            this.receiptRichTextBox.Name = "receiptRichTextBox";
            this.receiptRichTextBox.Size = new System.Drawing.Size(184, 226);
            this.receiptRichTextBox.TabIndex = 3;
            this.receiptRichTextBox.Text = "";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 663);
            this.Controls.Add(this.receiptRichTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectNumberComboBox);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectNumberComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.RichTextBox receiptRichTextBox;
    }
}

