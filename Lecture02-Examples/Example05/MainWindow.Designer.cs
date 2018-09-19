namespace Example05
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
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.number7Button = new System.Windows.Forms.Button();
            this.number8Button = new System.Windows.Forms.Button();
            this.number9Button = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.number6Button = new System.Windows.Forms.Button();
            this.number5Button = new System.Windows.Forms.Button();
            this.number4Button = new System.Windows.Forms.Button();
            this.multipleButton = new System.Windows.Forms.Button();
            this.number3Button = new System.Windows.Forms.Button();
            this.number2Button = new System.Windows.Forms.Button();
            this.number1Button = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.number0Button = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultTextBox
            // 
            this.resultTextBox.Enabled = false;
            this.resultTextBox.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultTextBox.Location = new System.Drawing.Point(34, 40);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(261, 43);
            this.resultTextBox.TabIndex = 0;
            // 
            // number7Button
            // 
            this.number7Button.Location = new System.Drawing.Point(35, 111);
            this.number7Button.Name = "number7Button";
            this.number7Button.Size = new System.Drawing.Size(59, 56);
            this.number7Button.TabIndex = 1;
            this.number7Button.Text = "7";
            this.number7Button.UseVisualStyleBackColor = true;
            this.number7Button.Click += new System.EventHandler(this.number7Button_Click);
            // 
            // number8Button
            // 
            this.number8Button.Location = new System.Drawing.Point(102, 111);
            this.number8Button.Name = "number8Button";
            this.number8Button.Size = new System.Drawing.Size(59, 56);
            this.number8Button.TabIndex = 2;
            this.number8Button.Text = "8";
            this.number8Button.UseVisualStyleBackColor = true;
            this.number8Button.Click += new System.EventHandler(this.number8Button_Click);
            // 
            // number9Button
            // 
            this.number9Button.Location = new System.Drawing.Point(169, 111);
            this.number9Button.Name = "number9Button";
            this.number9Button.Size = new System.Drawing.Size(59, 56);
            this.number9Button.TabIndex = 3;
            this.number9Button.Text = "9";
            this.number9Button.UseVisualStyleBackColor = true;
            this.number9Button.Click += new System.EventHandler(this.number9Button_Click);
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(236, 111);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(59, 56);
            this.plusButton.TabIndex = 4;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(237, 178);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(59, 56);
            this.minusButton.TabIndex = 8;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            // 
            // number6Button
            // 
            this.number6Button.Location = new System.Drawing.Point(170, 178);
            this.number6Button.Name = "number6Button";
            this.number6Button.Size = new System.Drawing.Size(59, 56);
            this.number6Button.TabIndex = 7;
            this.number6Button.Text = "6";
            this.number6Button.UseVisualStyleBackColor = true;
            this.number6Button.Click += new System.EventHandler(this.number6Button_Click);
            // 
            // number5Button
            // 
            this.number5Button.Location = new System.Drawing.Point(103, 178);
            this.number5Button.Name = "number5Button";
            this.number5Button.Size = new System.Drawing.Size(59, 56);
            this.number5Button.TabIndex = 6;
            this.number5Button.Text = "5";
            this.number5Button.UseVisualStyleBackColor = true;
            this.number5Button.Click += new System.EventHandler(this.number5Button_Click);
            // 
            // number4Button
            // 
            this.number4Button.Location = new System.Drawing.Point(36, 178);
            this.number4Button.Name = "number4Button";
            this.number4Button.Size = new System.Drawing.Size(59, 56);
            this.number4Button.TabIndex = 5;
            this.number4Button.Text = "4";
            this.number4Button.UseVisualStyleBackColor = true;
            this.number4Button.Click += new System.EventHandler(this.number4Button_Click);
            // 
            // multipleButton
            // 
            this.multipleButton.Location = new System.Drawing.Point(236, 240);
            this.multipleButton.Name = "multipleButton";
            this.multipleButton.Size = new System.Drawing.Size(59, 56);
            this.multipleButton.TabIndex = 12;
            this.multipleButton.Text = "x";
            this.multipleButton.UseVisualStyleBackColor = true;
            // 
            // number3Button
            // 
            this.number3Button.Location = new System.Drawing.Point(169, 240);
            this.number3Button.Name = "number3Button";
            this.number3Button.Size = new System.Drawing.Size(59, 56);
            this.number3Button.TabIndex = 11;
            this.number3Button.Text = "3";
            this.number3Button.UseVisualStyleBackColor = true;
            this.number3Button.Click += new System.EventHandler(this.number3Button_Click);
            // 
            // number2Button
            // 
            this.number2Button.Location = new System.Drawing.Point(102, 240);
            this.number2Button.Name = "number2Button";
            this.number2Button.Size = new System.Drawing.Size(59, 56);
            this.number2Button.TabIndex = 10;
            this.number2Button.Text = "2";
            this.number2Button.UseVisualStyleBackColor = true;
            this.number2Button.Click += new System.EventHandler(this.number2Button_Click);
            // 
            // number1Button
            // 
            this.number1Button.Location = new System.Drawing.Point(35, 240);
            this.number1Button.Name = "number1Button";
            this.number1Button.Size = new System.Drawing.Size(59, 56);
            this.number1Button.TabIndex = 9;
            this.number1Button.Text = "1";
            this.number1Button.UseVisualStyleBackColor = true;
            this.number1Button.Click += new System.EventHandler(this.number1Button_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(236, 302);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(59, 56);
            this.divideButton.TabIndex = 16;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            // 
            // equalButton
            // 
            this.equalButton.Location = new System.Drawing.Point(169, 302);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(59, 56);
            this.equalButton.TabIndex = 15;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // number0Button
            // 
            this.number0Button.Location = new System.Drawing.Point(102, 302);
            this.number0Button.Name = "number0Button";
            this.number0Button.Size = new System.Drawing.Size(59, 56);
            this.number0Button.TabIndex = 14;
            this.number0Button.Text = "0";
            this.number0Button.UseVisualStyleBackColor = true;
            this.number0Button.Click += new System.EventHandler(this.number0Button_Click);
            // 
            // dotButton
            // 
            this.dotButton.Location = new System.Drawing.Point(35, 302);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(59, 56);
            this.dotButton.TabIndex = 13;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = true;
            this.dotButton.Click += new System.EventHandler(this.dotButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 412);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.number0Button);
            this.Controls.Add(this.dotButton);
            this.Controls.Add(this.multipleButton);
            this.Controls.Add(this.number3Button);
            this.Controls.Add(this.number2Button);
            this.Controls.Add(this.number1Button);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.number6Button);
            this.Controls.Add(this.number5Button);
            this.Controls.Add(this.number4Button);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.number9Button);
            this.Controls.Add(this.number8Button);
            this.Controls.Add(this.number7Button);
            this.Controls.Add(this.resultTextBox);
            this.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button number7Button;
        private System.Windows.Forms.Button number8Button;
        private System.Windows.Forms.Button number9Button;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button number6Button;
        private System.Windows.Forms.Button number5Button;
        private System.Windows.Forms.Button number4Button;
        private System.Windows.Forms.Button multipleButton;
        private System.Windows.Forms.Button number3Button;
        private System.Windows.Forms.Button number2Button;
        private System.Windows.Forms.Button number1Button;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button number0Button;
        private System.Windows.Forms.Button dotButton;
    }
}

