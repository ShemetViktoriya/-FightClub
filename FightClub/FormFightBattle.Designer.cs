namespace FightClub
{
    partial class FormFightBattle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFightBattle));
            this.progressBarPlayer = new System.Windows.Forms.ProgressBar();
            this.progressBarComputer = new System.Windows.Forms.ProgressBar();
            this.lblComputer = new System.Windows.Forms.Label();
            this.btnLegs = new System.Windows.Forms.Button();
            this.btnTorso = new System.Windows.Forms.Button();
            this.btnHead = new System.Windows.Forms.Button();
            this.lblHuman = new System.Windows.Forms.Label();
            this.pctBoxComputer = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pctBoxHuman = new System.Windows.Forms.PictureBox();
            this.lblComputerHp = new System.Windows.Forms.Label();
            this.lblRoundsPlayed = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblHumanHp = new System.Windows.Forms.Label();
            this.LblWhoWon = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAtPr = new System.Windows.Forms.Label();
            this.lblPlayerAction = new System.Windows.Forms.Label();
            this.lblComputerAction = new System.Windows.Forms.Label();
            this.NameWinner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxHuman)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBarPlayer
            // 
            this.progressBarPlayer.Location = new System.Drawing.Point(201, 177);
            this.progressBarPlayer.Name = "progressBarPlayer";
            this.progressBarPlayer.Size = new System.Drawing.Size(254, 23);
            this.progressBarPlayer.TabIndex = 9;
            // 
            // progressBarComputer
            // 
            this.progressBarComputer.Location = new System.Drawing.Point(552, 174);
            this.progressBarComputer.Name = "progressBarComputer";
            this.progressBarComputer.Size = new System.Drawing.Size(254, 23);
            this.progressBarComputer.TabIndex = 10;
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblComputer.Location = new System.Drawing.Point(548, 144);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(101, 24);
            this.lblComputer.TabIndex = 24;
            this.lblComputer.Text = "Computer";
            // 
            // btnLegs
            // 
            this.btnLegs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLegs.Location = new System.Drawing.Point(35, 368);
            this.btnLegs.Name = "btnLegs";
            this.btnLegs.Size = new System.Drawing.Size(108, 46);
            this.btnLegs.TabIndex = 20;
            this.btnLegs.Text = "Legs";
            this.btnLegs.UseVisualStyleBackColor = true;
            // 
            // btnTorso
            // 
            this.btnTorso.Location = new System.Drawing.Point(35, 315);
            this.btnTorso.Name = "btnTorso";
            this.btnTorso.Size = new System.Drawing.Size(108, 47);
            this.btnTorso.TabIndex = 19;
            this.btnTorso.Text = "Torso";
            this.btnTorso.UseVisualStyleBackColor = true;
            // 
            // btnHead
            // 
            this.btnHead.Location = new System.Drawing.Point(35, 262);
            this.btnHead.Name = "btnHead";
            this.btnHead.Size = new System.Drawing.Size(108, 47);
            this.btnHead.TabIndex = 18;
            this.btnHead.Text = "Head";
            this.btnHead.UseVisualStyleBackColor = true;
            // 
            // lblHuman
            // 
            this.lblHuman.AutoSize = true;
            this.lblHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHuman.Location = new System.Drawing.Point(197, 144);
            this.lblHuman.Name = "lblHuman";
            this.lblHuman.Size = new System.Drawing.Size(129, 24);
            this.lblHuman.TabIndex = 36;
            this.lblHuman.Text = "Player Name";
            // 
            // pctBoxComputer
            // 
            this.pctBoxComputer.Image = global::FightClub.Properties.Resources.Question;
            this.pctBoxComputer.Location = new System.Drawing.Point(552, 231);
            this.pctBoxComputer.Name = "pctBoxComputer";
            this.pctBoxComputer.Size = new System.Drawing.Size(254, 233);
            this.pctBoxComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxComputer.TabIndex = 38;
            this.pctBoxComputer.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Who won round:";
            // 
            // pctBoxHuman
            // 
            this.pctBoxHuman.Image = global::FightClub.Properties.Resources.Question;
            this.pctBoxHuman.Location = new System.Drawing.Point(204, 231);
            this.pctBoxHuman.Name = "pctBoxHuman";
            this.pctBoxHuman.Size = new System.Drawing.Size(251, 233);
            this.pctBoxHuman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxHuman.TabIndex = 43;
            this.pctBoxHuman.TabStop = false;
            // 
            // lblComputerHp
            // 
            this.lblComputerHp.AutoSize = true;
            this.lblComputerHp.Location = new System.Drawing.Point(812, 174);
            this.lblComputerHp.Name = "lblComputerHp";
            this.lblComputerHp.Size = new System.Drawing.Size(66, 13);
            this.lblComputerHp.TabIndex = 50;
            this.lblComputerHp.Text = "ComputerHp";
            // 
            // lblRoundsPlayed
            // 
            this.lblRoundsPlayed.AutoSize = true;
            this.lblRoundsPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRoundsPlayed.Location = new System.Drawing.Point(182, 48);
            this.lblRoundsPlayed.Name = "lblRoundsPlayed";
            this.lblRoundsPlayed.Size = new System.Drawing.Size(182, 24);
            this.lblRoundsPlayed.TabIndex = 47;
            this.lblRoundsPlayed.Text = "labelCountRounds";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 24);
            this.label9.TabIndex = 46;
            this.label9.Text = "Rounds played:";
            // 
            // lblHumanHp
            // 
            this.lblHumanHp.AutoSize = true;
            this.lblHumanHp.Location = new System.Drawing.Point(461, 176);
            this.lblHumanHp.Name = "lblHumanHp";
            this.lblHumanHp.Size = new System.Drawing.Size(55, 13);
            this.lblHumanHp.TabIndex = 48;
            this.lblHumanHp.Text = "HumanHp";
            // 
            // LblWhoWon
            // 
            this.LblWhoWon.AutoSize = true;
            this.LblWhoWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblWhoWon.Location = new System.Drawing.Point(182, 87);
            this.LblWhoWon.Name = "LblWhoWon";
            this.LblWhoWon.Size = new System.Drawing.Size(0, 24);
            this.LblWhoWon.TabIndex = 51;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(998, 24);
            this.menuStrip1.TabIndex = 52;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // lblAtPr
            // 
            this.lblAtPr.AutoSize = true;
            this.lblAtPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAtPr.Location = new System.Drawing.Point(31, 231);
            this.lblAtPr.Name = "lblAtPr";
            this.lblAtPr.Size = new System.Drawing.Size(137, 24);
            this.lblAtPr.TabIndex = 1;
            this.lblAtPr.Text = "Attack/Protect";
            // 
            // lblPlayerAction
            // 
            this.lblPlayerAction.AutoSize = true;
            this.lblPlayerAction.Location = new System.Drawing.Point(201, 212);
            this.lblPlayerAction.Name = "lblPlayerAction";
            this.lblPlayerAction.Size = new System.Drawing.Size(69, 13);
            this.lblPlayerAction.TabIndex = 53;
            this.lblPlayerAction.Text = "Player Action";
            // 
            // lblComputerAction
            // 
            this.lblComputerAction.AutoSize = true;
            this.lblComputerAction.Location = new System.Drawing.Point(549, 212);
            this.lblComputerAction.Name = "lblComputerAction";
            this.lblComputerAction.Size = new System.Drawing.Size(85, 13);
            this.lblComputerAction.TabIndex = 54;
            this.lblComputerAction.Text = "Computer Action";
            // 
            // NameWinner
            // 
            this.NameWinner.AutoSize = true;
            this.NameWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameWinner.ForeColor = System.Drawing.Color.Red;
            this.NameWinner.Location = new System.Drawing.Point(200, 498);
            this.NameWinner.Name = "NameWinner";
            this.NameWinner.Size = new System.Drawing.Size(0, 24);
            this.NameWinner.TabIndex = 55;
            // 
            // FormFightBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 544);
            this.Controls.Add(this.NameWinner);
            this.Controls.Add(this.lblComputerAction);
            this.Controls.Add(this.lblPlayerAction);
            this.Controls.Add(this.lblAtPr);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LblWhoWon);
            this.Controls.Add(this.lblComputerHp);
            this.Controls.Add(this.lblHumanHp);
            this.Controls.Add(this.lblRoundsPlayed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pctBoxHuman);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pctBoxComputer);
            this.Controls.Add(this.lblHuman);
            this.Controls.Add(this.btnTorso);
            this.Controls.Add(this.btnHead);
            this.Controls.Add(this.btnLegs);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.progressBarComputer);
            this.Controls.Add(this.progressBarPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFightBattle";
            this.Text = "Fight Club";
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxHuman)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBarPlayer;
        private System.Windows.Forms.ProgressBar progressBarComputer;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Button btnLegs;
        private System.Windows.Forms.Button btnTorso;
        private System.Windows.Forms.Button btnHead;
        private System.Windows.Forms.Label lblHuman;
        private System.Windows.Forms.PictureBox pctBoxComputer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pctBoxHuman;
        private System.Windows.Forms.Label lblComputerHp;
        private System.Windows.Forms.Label lblRoundsPlayed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblHumanHp;
        private System.Windows.Forms.Label LblWhoWon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Label lblAtPr;
        private System.Windows.Forms.Label lblPlayerAction;
        private System.Windows.Forms.Label lblComputerAction;
        private System.Windows.Forms.Label NameWinner;
    }
}

