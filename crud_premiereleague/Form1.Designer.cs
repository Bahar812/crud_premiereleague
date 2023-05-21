namespace crud_premiereleague
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paneladdplayer = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxteamname = new System.Windows.Forms.ComboBox();
            this.dateTimePickerbirthdate = new System.Windows.Forms.DateTimePicker();
            this.textBoxweight = new System.Windows.Forms.TextBox();
            this.comboBoxposition = new System.Windows.Forms.ComboBox();
            this.comboBoxnationality = new System.Windows.Forms.ComboBox();
            this.textBoxheight = new System.Windows.Forms.TextBox();
            this.textBoxplayernumber = new System.Windows.Forms.TextBox();
            this.textboxnameplayer = new System.Windows.Forms.TextBox();
            this.panelmanager = new System.Windows.Forms.Panel();
            this.buttonswitch = new System.Windows.Forms.Button();
            this.dataGridViewcurrent = new System.Windows.Forms.DataGridView();
            this.comboBoxteammanager = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelRemove = new System.Windows.Forms.Panel();
            this.comboBoxTeamRemove = new System.Windows.Forms.ComboBox();
            this.dataGridViewPlayerRemove = new System.Windows.Forms.DataGridView();
            this.buttonRemovePlayer = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.paneladdplayer.SuspendLayout();
            this.panelmanager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcurrent)).BeginInit();
            this.panelRemove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayerRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlayerToolStripMenuItem,
            this.editManagerToolStripMenuItem,
            this.removePlayerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addPlayerToolStripMenuItem
            // 
            this.addPlayerToolStripMenuItem.Name = "addPlayerToolStripMenuItem";
            this.addPlayerToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.addPlayerToolStripMenuItem.Text = "Add Player";
            this.addPlayerToolStripMenuItem.Click += new System.EventHandler(this.addPlayerToolStripMenuItem_Click);
            // 
            // editManagerToolStripMenuItem
            // 
            this.editManagerToolStripMenuItem.Name = "editManagerToolStripMenuItem";
            this.editManagerToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.editManagerToolStripMenuItem.Text = "Edit Manager";
            this.editManagerToolStripMenuItem.Click += new System.EventHandler(this.editManagerToolStripMenuItem_Click);
            // 
            // removePlayerToolStripMenuItem
            // 
            this.removePlayerToolStripMenuItem.Name = "removePlayerToolStripMenuItem";
            this.removePlayerToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.removePlayerToolStripMenuItem.Text = "Remove Player";
            this.removePlayerToolStripMenuItem.Click += new System.EventHandler(this.removePlayerToolStripMenuItem_Click);
            // 
            // paneladdplayer
            // 
            this.paneladdplayer.Controls.Add(this.button1);
            this.paneladdplayer.Controls.Add(this.label11);
            this.paneladdplayer.Controls.Add(this.textBoxid);
            this.paneladdplayer.Controls.Add(this.label8);
            this.paneladdplayer.Controls.Add(this.label7);
            this.paneladdplayer.Controls.Add(this.label6);
            this.paneladdplayer.Controls.Add(this.label5);
            this.paneladdplayer.Controls.Add(this.label4);
            this.paneladdplayer.Controls.Add(this.label3);
            this.paneladdplayer.Controls.Add(this.label2);
            this.paneladdplayer.Controls.Add(this.label1);
            this.paneladdplayer.Controls.Add(this.comboBoxteamname);
            this.paneladdplayer.Controls.Add(this.dateTimePickerbirthdate);
            this.paneladdplayer.Controls.Add(this.textBoxweight);
            this.paneladdplayer.Controls.Add(this.comboBoxposition);
            this.paneladdplayer.Controls.Add(this.comboBoxnationality);
            this.paneladdplayer.Controls.Add(this.textBoxheight);
            this.paneladdplayer.Controls.Add(this.textBoxplayernumber);
            this.paneladdplayer.Controls.Add(this.textboxnameplayer);
            this.paneladdplayer.Location = new System.Drawing.Point(8, 27);
            this.paneladdplayer.Name = "paneladdplayer";
            this.paneladdplayer.Size = new System.Drawing.Size(726, 393);
            this.paneladdplayer.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(185, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Player ID";
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(188, 33);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(100, 20);
            this.textBoxid.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Team Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Birthdate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nationality";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Player Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name Player";
            // 
            // comboBoxteamname
            // 
            this.comboBoxteamname.FormattingEnabled = true;
            this.comboBoxteamname.Location = new System.Drawing.Point(39, 324);
            this.comboBoxteamname.Name = "comboBoxteamname";
            this.comboBoxteamname.Size = new System.Drawing.Size(121, 21);
            this.comboBoxteamname.TabIndex = 7;
            // 
            // dateTimePickerbirthdate
            // 
            this.dateTimePickerbirthdate.Location = new System.Drawing.Point(39, 281);
            this.dateTimePickerbirthdate.Name = "dateTimePickerbirthdate";
            this.dateTimePickerbirthdate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerbirthdate.TabIndex = 6;
            // 
            // textBoxweight
            // 
            this.textBoxweight.Location = new System.Drawing.Point(36, 238);
            this.textBoxweight.Name = "textBoxweight";
            this.textBoxweight.Size = new System.Drawing.Size(100, 20);
            this.textBoxweight.TabIndex = 5;
            // 
            // comboBoxposition
            // 
            this.comboBoxposition.FormattingEnabled = true;
            this.comboBoxposition.Location = new System.Drawing.Point(36, 159);
            this.comboBoxposition.Name = "comboBoxposition";
            this.comboBoxposition.Size = new System.Drawing.Size(121, 21);
            this.comboBoxposition.TabIndex = 4;
            // 
            // comboBoxnationality
            // 
            this.comboBoxnationality.FormattingEnabled = true;
            this.comboBoxnationality.Location = new System.Drawing.Point(36, 115);
            this.comboBoxnationality.Name = "comboBoxnationality";
            this.comboBoxnationality.Size = new System.Drawing.Size(121, 21);
            this.comboBoxnationality.TabIndex = 3;
            this.comboBoxnationality.SelectedIndexChanged += new System.EventHandler(this.comboBoxnationality_SelectedIndexChanged);
            // 
            // textBoxheight
            // 
            this.textBoxheight.Location = new System.Drawing.Point(36, 199);
            this.textBoxheight.Name = "textBoxheight";
            this.textBoxheight.Size = new System.Drawing.Size(100, 20);
            this.textBoxheight.TabIndex = 2;
            // 
            // textBoxplayernumber
            // 
            this.textBoxplayernumber.Location = new System.Drawing.Point(36, 76);
            this.textBoxplayernumber.Name = "textBoxplayernumber";
            this.textBoxplayernumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxplayernumber.TabIndex = 1;
            // 
            // textboxnameplayer
            // 
            this.textboxnameplayer.Location = new System.Drawing.Point(36, 33);
            this.textboxnameplayer.Name = "textboxnameplayer";
            this.textboxnameplayer.Size = new System.Drawing.Size(100, 20);
            this.textboxnameplayer.TabIndex = 0;
            // 
            // panelmanager
            // 
            this.panelmanager.Controls.Add(this.label10);
            this.panelmanager.Controls.Add(this.buttonswitch);
            this.panelmanager.Controls.Add(this.dataGridViewcurrent);
            this.panelmanager.Controls.Add(this.comboBoxteammanager);
            this.panelmanager.Controls.Add(this.label9);
            this.panelmanager.Location = new System.Drawing.Point(5, 27);
            this.panelmanager.Name = "panelmanager";
            this.panelmanager.Size = new System.Drawing.Size(728, 392);
            this.panelmanager.TabIndex = 2;
            // 
            // buttonswitch
            // 
            this.buttonswitch.Location = new System.Drawing.Point(197, 27);
            this.buttonswitch.Name = "buttonswitch";
            this.buttonswitch.Size = new System.Drawing.Size(112, 37);
            this.buttonswitch.TabIndex = 4;
            this.buttonswitch.Text = "Edit";
            this.buttonswitch.UseVisualStyleBackColor = true;
            this.buttonswitch.Click += new System.EventHandler(this.buttonswitch_Click);
            // 
            // dataGridViewcurrent
            // 
            this.dataGridViewcurrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcurrent.Location = new System.Drawing.Point(18, 99);
            this.dataGridViewcurrent.Name = "dataGridViewcurrent";
            this.dataGridViewcurrent.Size = new System.Drawing.Size(291, 219);
            this.dataGridViewcurrent.TabIndex = 2;
            // 
            // comboBoxteammanager
            // 
            this.comboBoxteammanager.FormattingEnabled = true;
            this.comboBoxteammanager.Location = new System.Drawing.Point(18, 36);
            this.comboBoxteammanager.Name = "comboBoxteammanager";
            this.comboBoxteammanager.Size = new System.Drawing.Size(121, 21);
            this.comboBoxteammanager.TabIndex = 1;
            this.comboBoxteammanager.SelectedIndexChanged += new System.EventHandler(this.comboBoxteammanager_SelectedIndexChanged);
            this.comboBoxteammanager.SelectionChangeCommitted += new System.EventHandler(this.comboBoxteammanager_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nama Team";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(388, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Manager Team";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // panelRemove
            // 
            this.panelRemove.Controls.Add(this.buttonRemovePlayer);
            this.panelRemove.Controls.Add(this.dataGridViewPlayerRemove);
            this.panelRemove.Controls.Add(this.comboBoxTeamRemove);
            this.panelRemove.Location = new System.Drawing.Point(2, 27);
            this.panelRemove.Name = "panelRemove";
            this.panelRemove.Size = new System.Drawing.Size(729, 389);
            this.panelRemove.TabIndex = 3;
            // 
            // comboBoxTeamRemove
            // 
            this.comboBoxTeamRemove.FormattingEnabled = true;
            this.comboBoxTeamRemove.Location = new System.Drawing.Point(21, 17);
            this.comboBoxTeamRemove.Name = "comboBoxTeamRemove";
            this.comboBoxTeamRemove.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTeamRemove.TabIndex = 2;
            this.comboBoxTeamRemove.SelectionChangeCommitted += new System.EventHandler(this.comboBoxTeamRemove_SelectionChangeCommitted);
            // 
            // dataGridViewPlayerRemove
            // 
            this.dataGridViewPlayerRemove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayerRemove.Location = new System.Drawing.Point(203, 17);
            this.dataGridViewPlayerRemove.Name = "dataGridViewPlayerRemove";
            this.dataGridViewPlayerRemove.Size = new System.Drawing.Size(429, 179);
            this.dataGridViewPlayerRemove.TabIndex = 3;
            // 
            // buttonRemovePlayer
            // 
            this.buttonRemovePlayer.Location = new System.Drawing.Point(557, 235);
            this.buttonRemovePlayer.Name = "buttonRemovePlayer";
            this.buttonRemovePlayer.Size = new System.Drawing.Size(75, 23);
            this.buttonRemovePlayer.TabIndex = 4;
            this.buttonRemovePlayer.Text = "Remove";
            this.buttonRemovePlayer.UseVisualStyleBackColor = true;
            this.buttonRemovePlayer.Click += new System.EventHandler(this.buttonRemovePlayer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelRemove);
            this.Controls.Add(this.panelmanager);
            this.Controls.Add(this.paneladdplayer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.paneladdplayer.ResumeLayout(false);
            this.paneladdplayer.PerformLayout();
            this.panelmanager.ResumeLayout(false);
            this.panelmanager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcurrent)).EndInit();
            this.panelRemove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayerRemove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePlayerToolStripMenuItem;
        private System.Windows.Forms.Panel paneladdplayer;
        private System.Windows.Forms.TextBox textboxnameplayer;
        private System.Windows.Forms.ComboBox comboBoxteamname;
        private System.Windows.Forms.DateTimePicker dateTimePickerbirthdate;
        private System.Windows.Forms.TextBox textBoxweight;
        private System.Windows.Forms.ComboBox comboBoxposition;
        private System.Windows.Forms.ComboBox comboBoxnationality;
        private System.Windows.Forms.TextBox textBoxheight;
        private System.Windows.Forms.TextBox textBoxplayernumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelmanager;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewcurrent;
        private System.Windows.Forms.ComboBox comboBoxteammanager;
        private System.Windows.Forms.Button buttonswitch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelRemove;
        private System.Windows.Forms.Button buttonRemovePlayer;
        private System.Windows.Forms.DataGridView dataGridViewPlayerRemove;
        private System.Windows.Forms.ComboBox comboBoxTeamRemove;
    }
}

