namespace SystemHR.UserInterface.Forms
{
    partial class MainForm
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
            this.tpGenral = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.tpConfiguration = new System.Windows.Forms.TabPage();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnContract = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btnOrganizationalStructure = new System.Windows.Forms.Button();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.btnSalaries = new System.Windows.Forms.Button();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.btnDepartaments = new System.Windows.Forms.Button();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.btnPositions = new System.Windows.Forms.Button();
            this.tsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDataBase = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tpGenral.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpGenral
            // 
            this.tpGenral.Controls.Add(this.tpGeneral);
            this.tpGenral.Controls.Add(this.tpConfiguration);
            this.tpGenral.Dock = System.Windows.Forms.DockStyle.Top;
            this.tpGenral.Location = new System.Drawing.Point(0, 0);
            this.tpGenral.Name = "tpGenral";
            this.tpGenral.SelectedIndex = 0;
            this.tpGenral.Size = new System.Drawing.Size(874, 54);
            this.tpGenral.TabIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.btnPositions);
            this.tpGeneral.Controls.Add(this.splitter5);
            this.tpGeneral.Controls.Add(this.btnDepartaments);
            this.tpGeneral.Controls.Add(this.splitter4);
            this.tpGeneral.Controls.Add(this.btnSalaries);
            this.tpGeneral.Controls.Add(this.splitter3);
            this.tpGeneral.Controls.Add(this.btnOrganizationalStructure);
            this.tpGeneral.Controls.Add(this.splitter2);
            this.tpGeneral.Controls.Add(this.btnContract);
            this.tpGeneral.Controls.Add(this.splitter1);
            this.tpGeneral.Controls.Add(this.btnEmployees);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(866, 28);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "Ogólne";
            this.tpGeneral.UseVisualStyleBackColor = true;
            this.tpGeneral.Click += new System.EventHandler(this.tpGeneral_Click);
            // 
            // tpConfiguration
            // 
            this.tpConfiguration.Location = new System.Drawing.Point(4, 22);
            this.tpConfiguration.Name = "tpConfiguration";
            this.tpConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfiguration.Size = new System.Drawing.Size(866, 28);
            this.tpConfiguration.TabIndex = 1;
            this.tpConfiguration.Text = "Konfiguracja";
            this.tpConfiguration.UseVisualStyleBackColor = true;
            this.tpConfiguration.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslVersion,
            this.tsslDataBase,
            this.tsslUser});
            this.ssMain.Location = new System.Drawing.Point(0, 539);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(874, 22);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            this.ssMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ssMain_ItemClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 485);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.SystemColors.Control;
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEmployees.Location = new System.Drawing.Point(3, 3);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(80, 22);
            this.btnEmployees.TabIndex = 0;
            this.btnEmployees.Text = "Pracownicy";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(83, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 22);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // btnContract
            // 
            this.btnContract.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnContract.Location = new System.Drawing.Point(86, 3);
            this.btnContract.Name = "btnContract";
            this.btnContract.Size = new System.Drawing.Size(75, 22);
            this.btnContract.TabIndex = 2;
            this.btnContract.Text = "Umowy";
            this.btnContract.UseVisualStyleBackColor = true;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(161, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 22);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // btnOrganizationalStructure
            // 
            this.btnOrganizationalStructure.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOrganizationalStructure.Location = new System.Drawing.Point(164, 3);
            this.btnOrganizationalStructure.Name = "btnOrganizationalStructure";
            this.btnOrganizationalStructure.Size = new System.Drawing.Size(145, 22);
            this.btnOrganizationalStructure.TabIndex = 4;
            this.btnOrganizationalStructure.Text = "Struktura Organizacyjna";
            this.btnOrganizationalStructure.UseVisualStyleBackColor = true;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(309, 3);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 22);
            this.splitter3.TabIndex = 5;
            this.splitter3.TabStop = false;
            // 
            // btnSalaries
            // 
            this.btnSalaries.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalaries.Location = new System.Drawing.Point(312, 3);
            this.btnSalaries.Name = "btnSalaries";
            this.btnSalaries.Size = new System.Drawing.Size(75, 22);
            this.btnSalaries.TabIndex = 6;
            this.btnSalaries.Text = "Wynagrodzenia";
            this.btnSalaries.UseVisualStyleBackColor = true;
            // 
            // splitter4
            // 
            this.splitter4.Location = new System.Drawing.Point(387, 3);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(3, 22);
            this.splitter4.TabIndex = 7;
            this.splitter4.TabStop = false;
            // 
            // btnDepartaments
            // 
            this.btnDepartaments.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDepartaments.Location = new System.Drawing.Point(390, 3);
            this.btnDepartaments.Name = "btnDepartaments";
            this.btnDepartaments.Size = new System.Drawing.Size(75, 22);
            this.btnDepartaments.TabIndex = 8;
            this.btnDepartaments.Text = "Działy";
            this.btnDepartaments.UseVisualStyleBackColor = true;
            // 
            // splitter5
            // 
            this.splitter5.Location = new System.Drawing.Point(465, 3);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(3, 22);
            this.splitter5.TabIndex = 9;
            this.splitter5.TabStop = false;
            // 
            // btnPositions
            // 
            this.btnPositions.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPositions.Location = new System.Drawing.Point(468, 3);
            this.btnPositions.Name = "btnPositions";
            this.btnPositions.Size = new System.Drawing.Size(75, 22);
            this.btnPositions.TabIndex = 10;
            this.btnPositions.Text = "Stanowiska";
            this.btnPositions.UseVisualStyleBackColor = true;
            // 
            // tsslVersion
            // 
            this.tsslVersion.Name = "tsslVersion";
            this.tsslVersion.Size = new System.Drawing.Size(75, 17);
            this.tsslVersion.Text = "Wersja1.0.0.0";
            // 
            // tsslDataBase
            // 
            this.tsslDataBase.Name = "tsslDataBase";
            this.tsslDataBase.Size = new System.Drawing.Size(31, 17);
            this.tsslDataBase.Text = "Baza";
            // 
            // tsslUser
            // 
            this.tsslUser.Name = "tsslUser";
            this.tsslUser.Size = new System.Drawing.Size(56, 17);
            this.tsslUser.Text = "Piotr Krol";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tpGenral);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemHR";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tpGenral.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tpGenral;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpConfiguration;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.Button btnPositions;
        private System.Windows.Forms.Splitter splitter5;
        private System.Windows.Forms.Button btnDepartaments;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Button btnSalaries;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Button btnOrganizationalStructure;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btnContract;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
        private System.Windows.Forms.ToolStripStatusLabel tsslDataBase;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.Panel panel1;
    }
}