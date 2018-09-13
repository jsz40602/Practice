namespace Homework02_WinForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.picturePokemon = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.typeLable = new System.Windows.Forms.Label();
            this.speciesLabel = new System.Windows.Forms.Label();
            this.messageButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.speciesTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturePokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // picturePokemon
            // 
            this.picturePokemon.Image = ((System.Drawing.Image)(resources.GetObject("picturePokemon.Image")));
            this.picturePokemon.Location = new System.Drawing.Point(29, 99);
            this.picturePokemon.Name = "picturePokemon";
            this.picturePokemon.Size = new System.Drawing.Size(200, 184);
            this.picturePokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePokemon.TabIndex = 0;
            this.picturePokemon.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(251, 99);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(48, 15);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name :";
            // 
            // typeLable
            // 
            this.typeLable.AutoSize = true;
            this.typeLable.Location = new System.Drawing.Point(251, 185);
            this.typeLable.Name = "typeLable";
            this.typeLable.Size = new System.Drawing.Size(44, 15);
            this.typeLable.TabIndex = 2;
            this.typeLable.Text = "Type :";
            // 
            // speciesLabel
            // 
            this.speciesLabel.AutoSize = true;
            this.speciesLabel.Location = new System.Drawing.Point(251, 268);
            this.speciesLabel.Name = "speciesLabel";
            this.speciesLabel.Size = new System.Drawing.Size(57, 15);
            this.speciesLabel.TabIndex = 3;
            this.speciesLabel.Text = "Species :";
            // 
            // messageButton
            // 
            this.messageButton.Location = new System.Drawing.Point(161, 343);
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(204, 61);
            this.messageButton.TabIndex = 4;
            this.messageButton.Text = "點我";
            this.messageButton.UseVisualStyleBackColor = true;
            this.messageButton.Click += new System.EventHandler(this.messageButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(332, 96);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(147, 25);
            this.nameTextBox.TabIndex = 5;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(332, 182);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(147, 25);
            this.typeTextBox.TabIndex = 6;
            // 
            // speciesTextBox
            // 
            this.speciesTextBox.Location = new System.Drawing.Point(332, 265);
            this.speciesTextBox.Name = "speciesTextBox";
            this.speciesTextBox.Size = new System.Drawing.Size(147, 25);
            this.speciesTextBox.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.speciesTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.messageButton);
            this.Controls.Add(this.speciesLabel);
            this.Controls.Add(this.typeLable);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.picturePokemon);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picturePokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturePokemon;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label typeLable;
        private System.Windows.Forms.Label speciesLabel;
        private System.Windows.Forms.Button messageButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox speciesTextBox;
    }
}

