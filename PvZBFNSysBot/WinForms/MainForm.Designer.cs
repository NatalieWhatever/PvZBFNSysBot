
namespace PvZBFNSysBot.WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.cheatsGroupBox = new System.Windows.Forms.GroupBox();
            this.fpsCapCheckbox = new System.Windows.Forms.CheckBox();
            this.instantPrestigeCheckbox = new System.Windows.Forms.CheckBox();
            this.freeOnlineCheckbox = new System.Windows.Forms.CheckBox();
            this.currenciesGroupBox = new System.Windows.Forms.GroupBox();
            this.badgesBox = new System.Windows.Forms.TextBox();
            this.marshmallowBox = new System.Windows.Forms.TextBox();
            this.tacoBox = new System.Windows.Forms.TextBox();
            this.bulbsBox = new System.Windows.Forms.TextBox();
            this.coinsBox = new System.Windows.Forms.TextBox();
            this.submitCurrencyChangesButton = new System.Windows.Forms.Button();
            this.badgesPictureBox = new System.Windows.Forms.PictureBox();
            this.marshmallowsPictureBox = new System.Windows.Forms.PictureBox();
            this.tacosPictureBox = new System.Windows.Forms.PictureBox();
            this.bulbsPictureBox = new System.Windows.Forms.PictureBox();
            this.coinsPictureBox = new System.Windows.Forms.PictureBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.cheatsGroupBox.SuspendLayout();
            this.currenciesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.badgesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marshmallowsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacosPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulbsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(12, 14);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.PlaceholderText = "IP Address";
            this.ipTextBox.Size = new System.Drawing.Size(100, 23);
            this.ipTextBox.TabIndex = 0;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(118, 14);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(80, 23);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(204, 18);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(86, 15);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Not connected";
            // 
            // cheatsGroupBox
            // 
            this.cheatsGroupBox.Controls.Add(this.fpsCapCheckbox);
            this.cheatsGroupBox.Controls.Add(this.instantPrestigeCheckbox);
            this.cheatsGroupBox.Controls.Add(this.freeOnlineCheckbox);
            this.cheatsGroupBox.Location = new System.Drawing.Point(12, 203);
            this.cheatsGroupBox.Name = "cheatsGroupBox";
            this.cheatsGroupBox.Size = new System.Drawing.Size(383, 98);
            this.cheatsGroupBox.TabIndex = 3;
            this.cheatsGroupBox.TabStop = false;
            this.cheatsGroupBox.Text = "Cheats";
            // 
            // fpsCapCheckbox
            // 
            this.fpsCapCheckbox.AutoSize = true;
            this.fpsCapCheckbox.Enabled = false;
            this.fpsCapCheckbox.Location = new System.Drawing.Point(8, 72);
            this.fpsCapCheckbox.Name = "fpsCapCheckbox";
            this.fpsCapCheckbox.Size = new System.Drawing.Size(84, 19);
            this.fpsCapCheckbox.TabIndex = 3;
            this.fpsCapCheckbox.Text = "60 FPS Cap";
            this.fpsCapCheckbox.UseVisualStyleBackColor = true;
            this.fpsCapCheckbox.CheckedChanged += new System.EventHandler(this.fpsCapCheckbox_CheckedChanged);
            // 
            // instantPrestigeCheckbox
            // 
            this.instantPrestigeCheckbox.AutoSize = true;
            this.instantPrestigeCheckbox.Enabled = false;
            this.instantPrestigeCheckbox.Location = new System.Drawing.Point(8, 22);
            this.instantPrestigeCheckbox.Name = "instantPrestigeCheckbox";
            this.instantPrestigeCheckbox.Size = new System.Drawing.Size(107, 19);
            this.instantPrestigeCheckbox.TabIndex = 0;
            this.instantPrestigeCheckbox.Text = "Instant Prestige";
            this.instantPrestigeCheckbox.UseVisualStyleBackColor = true;
            this.instantPrestigeCheckbox.CheckedChanged += new System.EventHandler(this.instantPrestigeCheckbox_CheckedChanged);
            // 
            // freeOnlineCheckbox
            // 
            this.freeOnlineCheckbox.AutoSize = true;
            this.freeOnlineCheckbox.Enabled = false;
            this.freeOnlineCheckbox.Location = new System.Drawing.Point(8, 47);
            this.freeOnlineCheckbox.Name = "freeOnlineCheckbox";
            this.freeOnlineCheckbox.Size = new System.Drawing.Size(86, 19);
            this.freeOnlineCheckbox.TabIndex = 2;
            this.freeOnlineCheckbox.Text = "Free Online";
            this.freeOnlineCheckbox.UseVisualStyleBackColor = true;
            this.freeOnlineCheckbox.CheckedChanged += new System.EventHandler(this.freeOnlineCheckbox_CheckedChanged);
            // 
            // currenciesGroupBox
            // 
            this.currenciesGroupBox.Controls.Add(this.badgesBox);
            this.currenciesGroupBox.Controls.Add(this.marshmallowBox);
            this.currenciesGroupBox.Controls.Add(this.tacoBox);
            this.currenciesGroupBox.Controls.Add(this.bulbsBox);
            this.currenciesGroupBox.Controls.Add(this.coinsBox);
            this.currenciesGroupBox.Controls.Add(this.submitCurrencyChangesButton);
            this.currenciesGroupBox.Controls.Add(this.badgesPictureBox);
            this.currenciesGroupBox.Controls.Add(this.marshmallowsPictureBox);
            this.currenciesGroupBox.Controls.Add(this.tacosPictureBox);
            this.currenciesGroupBox.Controls.Add(this.bulbsPictureBox);
            this.currenciesGroupBox.Controls.Add(this.coinsPictureBox);
            this.currenciesGroupBox.Location = new System.Drawing.Point(12, 43);
            this.currenciesGroupBox.Name = "currenciesGroupBox";
            this.currenciesGroupBox.Size = new System.Drawing.Size(383, 154);
            this.currenciesGroupBox.TabIndex = 5;
            this.currenciesGroupBox.TabStop = false;
            this.currenciesGroupBox.Text = "Currencies";
            // 
            // badgesBox
            // 
            this.badgesBox.Enabled = false;
            this.badgesBox.Location = new System.Drawing.Point(49, 119);
            this.badgesBox.Name = "badgesBox";
            this.badgesBox.Size = new System.Drawing.Size(137, 23);
            this.badgesBox.TabIndex = 16;
            // 
            // marshmallowBox
            // 
            this.marshmallowBox.Enabled = false;
            this.marshmallowBox.Location = new System.Drawing.Point(228, 74);
            this.marshmallowBox.Name = "marshmallowBox";
            this.marshmallowBox.Size = new System.Drawing.Size(137, 23);
            this.marshmallowBox.TabIndex = 15;
            // 
            // tacoBox
            // 
            this.tacoBox.Enabled = false;
            this.tacoBox.Location = new System.Drawing.Point(49, 74);
            this.tacoBox.Name = "tacoBox";
            this.tacoBox.Size = new System.Drawing.Size(137, 23);
            this.tacoBox.TabIndex = 14;
            // 
            // bulbsBox
            // 
            this.bulbsBox.Enabled = false;
            this.bulbsBox.Location = new System.Drawing.Point(228, 29);
            this.bulbsBox.Name = "bulbsBox";
            this.bulbsBox.Size = new System.Drawing.Size(137, 23);
            this.bulbsBox.TabIndex = 13;
            // 
            // coinsBox
            // 
            this.coinsBox.Enabled = false;
            this.coinsBox.Location = new System.Drawing.Point(49, 29);
            this.coinsBox.Name = "coinsBox";
            this.coinsBox.Size = new System.Drawing.Size(137, 23);
            this.coinsBox.TabIndex = 12;
            // 
            // submitCurrencyChangesButton
            // 
            this.submitCurrencyChangesButton.Location = new System.Drawing.Point(192, 105);
            this.submitCurrencyChangesButton.Name = "submitCurrencyChangesButton";
            this.submitCurrencyChangesButton.Size = new System.Drawing.Size(173, 37);
            this.submitCurrencyChangesButton.TabIndex = 11;
            this.submitCurrencyChangesButton.Text = "Submit";
            this.submitCurrencyChangesButton.UseVisualStyleBackColor = true;
            this.submitCurrencyChangesButton.Click += new System.EventHandler(this.submitCurrencyChangesButton_Click);
            // 
            // badgesPictureBox
            // 
            this.badgesPictureBox.Image = global::PvZBFNSysBot.Properties.Resources.Currency_Badge;
            this.badgesPictureBox.Location = new System.Drawing.Point(13, 112);
            this.badgesPictureBox.Name = "badgesPictureBox";
            this.badgesPictureBox.Size = new System.Drawing.Size(30, 30);
            this.badgesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.badgesPictureBox.TabIndex = 9;
            this.badgesPictureBox.TabStop = false;
            // 
            // marshmallowsPictureBox
            // 
            this.marshmallowsPictureBox.Image = global::PvZBFNSysBot.Properties.Resources.Currency_Marshmallow;
            this.marshmallowsPictureBox.Location = new System.Drawing.Point(192, 67);
            this.marshmallowsPictureBox.Name = "marshmallowsPictureBox";
            this.marshmallowsPictureBox.Size = new System.Drawing.Size(30, 30);
            this.marshmallowsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.marshmallowsPictureBox.TabIndex = 7;
            this.marshmallowsPictureBox.TabStop = false;
            // 
            // tacosPictureBox
            // 
            this.tacosPictureBox.Image = global::PvZBFNSysBot.Properties.Resources.Currency_Taco;
            this.tacosPictureBox.Location = new System.Drawing.Point(13, 67);
            this.tacosPictureBox.Name = "tacosPictureBox";
            this.tacosPictureBox.Size = new System.Drawing.Size(30, 30);
            this.tacosPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tacosPictureBox.TabIndex = 5;
            this.tacosPictureBox.TabStop = false;
            // 
            // bulbsPictureBox
            // 
            this.bulbsPictureBox.Image = global::PvZBFNSysBot.Properties.Resources.Currency_PrizeBulb;
            this.bulbsPictureBox.Location = new System.Drawing.Point(192, 22);
            this.bulbsPictureBox.Name = "bulbsPictureBox";
            this.bulbsPictureBox.Size = new System.Drawing.Size(30, 30);
            this.bulbsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulbsPictureBox.TabIndex = 3;
            this.bulbsPictureBox.TabStop = false;
            // 
            // coinsPictureBox
            // 
            this.coinsPictureBox.Image = global::PvZBFNSysBot.Properties.Resources.Currency_Coin;
            this.coinsPictureBox.Location = new System.Drawing.Point(13, 22);
            this.coinsPictureBox.Name = "coinsPictureBox";
            this.coinsPictureBox.Size = new System.Drawing.Size(30, 30);
            this.coinsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coinsPictureBox.TabIndex = 2;
            this.coinsPictureBox.TabStop = false;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(358, 18);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(37, 15);
            this.versionLabel.TabIndex = 6;
            this.versionLabel.Text = "v1.0.0";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 312);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.currenciesGroupBox);
            this.Controls.Add(this.cheatsGroupBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.ipTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "PVZBFN-SysBot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.cheatsGroupBox.ResumeLayout(false);
            this.cheatsGroupBox.PerformLayout();
            this.currenciesGroupBox.ResumeLayout(false);
            this.currenciesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.badgesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marshmallowsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacosPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulbsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Button connectButton;
        public System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.GroupBox cheatsGroupBox;
        private System.Windows.Forms.CheckBox freeOnlineCheckbox;
        private System.Windows.Forms.CheckBox fpsCapCheckbox;
        private System.Windows.Forms.GroupBox currenciesGroupBox;
        private System.Windows.Forms.Button submitCurrencyChangesButton;
        private System.Windows.Forms.PictureBox badgesPictureBox;
        private System.Windows.Forms.PictureBox marshmallowsPictureBox;
        private System.Windows.Forms.PictureBox tacosPictureBox;
        private System.Windows.Forms.PictureBox bulbsPictureBox;
        private System.Windows.Forms.PictureBox coinsPictureBox;
        private System.Windows.Forms.TextBox badgesBox;
        private System.Windows.Forms.TextBox marshmallowBox;
        private System.Windows.Forms.TextBox tacoBox;
        private System.Windows.Forms.TextBox bulbsBox;
        private System.Windows.Forms.TextBox coinsBox;
        private System.Windows.Forms.CheckBox instantPrestigeCheckbox;
        private System.Windows.Forms.Label versionLabel;
    }
}

