namespace Homework03_WinForm
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
            this.speciesTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.speciesLabel = new System.Windows.Forms.Label();
            this.typeLable = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pokemonLabel = new System.Windows.Forms.Label();
            this.indexLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturePokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // picturePokemon
            // 
            this.picturePokemon.Image = ((System.Drawing.Image)(resources.GetObject("picturePokemon.Image")));
            this.picturePokemon.Location = new System.Drawing.Point(38, 64);
            this.picturePokemon.Name = "picturePokemon";
            this.picturePokemon.Size = new System.Drawing.Size(200, 184);
            this.picturePokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePokemon.TabIndex = 1;
            this.picturePokemon.TabStop = false;
            // 
            // speciesTextBox
            // 
            this.speciesTextBox.Location = new System.Drawing.Point(360, 230);
            this.speciesTextBox.Name = "speciesTextBox";
            this.speciesTextBox.Size = new System.Drawing.Size(147, 25);
            this.speciesTextBox.TabIndex = 13;
            this.speciesTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.speciesTextBox_KeyDown);
            this.speciesTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.speciesTextBox_KeyUp);
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(360, 147);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(147, 25);
            this.typeTextBox.TabIndex = 12;
            this.typeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.typeTextBox_KeyDown);
            this.typeTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.typeTextBox_KeyUp);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(360, 61);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(147, 25);
            this.nameTextBox.TabIndex = 11;
            this.nameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameTextBox_KeyDown);
            this.nameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nameTextBox_KeyUp);
            // 
            // speciesLabel
            // 
            this.speciesLabel.AutoSize = true;
            this.speciesLabel.Location = new System.Drawing.Point(279, 233);
            this.speciesLabel.Name = "speciesLabel";
            this.speciesLabel.Size = new System.Drawing.Size(57, 15);
            this.speciesLabel.TabIndex = 10;
            this.speciesLabel.Text = "Species :";
            // 
            // typeLable
            // 
            this.typeLable.AutoSize = true;
            this.typeLable.Location = new System.Drawing.Point(279, 150);
            this.typeLable.Name = "typeLable";
            this.typeLable.Size = new System.Drawing.Size(44, 15);
            this.typeLable.TabIndex = 9;
            this.typeLable.Text = "Type :";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(279, 64);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(48, 15);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name :";
            // 
            // pokemonLabel
            // 
            this.pokemonLabel.AutoSize = true;
            this.pokemonLabel.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pokemonLabel.Location = new System.Drawing.Point(34, 289);
            this.pokemonLabel.Name = "pokemonLabel";
            this.pokemonLabel.Size = new System.Drawing.Size(127, 17);
            this.pokemonLabel.TabIndex = 14;
            this.pokemonLabel.Text = "Pokemon Message";
            // 
            // indexLabel
            // 
            this.indexLabel.AutoSize = true;
            this.indexLabel.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.indexLabel.Location = new System.Drawing.Point(66, 22);
            this.indexLabel.Name = "indexLabel";
            this.indexLabel.Size = new System.Drawing.Size(145, 24);
            this.indexLabel.TabIndex = 15;
            this.indexLabel.Text = "Pokemon 001";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 348);
            this.Controls.Add(this.indexLabel);
            this.Controls.Add(this.pokemonLabel);
            this.Controls.Add(this.speciesTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.speciesLabel);
            this.Controls.Add(this.typeLable);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.picturePokemon);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturePokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturePokemon;
        private System.Windows.Forms.TextBox speciesTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label speciesLabel;
        private System.Windows.Forms.Label typeLable;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label pokemonLabel;
        private System.Windows.Forms.Label indexLabel;
    }
}

