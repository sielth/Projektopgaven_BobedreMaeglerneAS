﻿namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    partial class SælgerUI
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
            this.components = new System.ComponentModel.Container();
            this.sælgerVej_txt = new System.Windows.Forms.TextBox();
            this.sælgerPostnummer_txt = new System.Windows.Forms.TextBox();
            this.sælgerEfternavn_txt = new System.Windows.Forms.TextBox();
            this.sælgerPostnummer_lbl = new System.Windows.Forms.Label();
            this.sælgerVej_lbl = new System.Windows.Forms.Label();
            this.sælgerEmail_lbl = new System.Windows.Forms.Label();
            this.sælgerTelefon_lbl = new System.Windows.Forms.Label();
            this.sælgerEfternavn_lbl = new System.Windows.Forms.Label();
            this.sælgerFornavn_lbl = new System.Windows.Forms.Label();
            this.sælgerCPR_lbl = new System.Windows.Forms.Label();
            this.sælgerID_lbl = new System.Windows.Forms.Label();
            this.sælgerEmail_txt = new System.Windows.Forms.TextBox();
            this.sælgerTelefon_txt = new System.Windows.Forms.TextBox();
            this.sælgerFornavn_txt = new System.Windows.Forms.TextBox();
            this.sælgerCPR_txt = new System.Windows.Forms.TextBox();
            this.sælgerID_txt = new System.Windows.Forms.TextBox();
            this.btn_SletSælger = new System.Windows.Forms.Button();
            this.btn_OpdaterSælger = new System.Windows.Forms.Button();
            this.btn_HentSælger = new System.Windows.Forms.Button();
            this.btn_OpretSælger = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ejendomsmæglerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejendomsmægler_createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejendomsmægler_readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejendomsmægler_deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sælgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sælger_createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sælger_readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sælger_deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.køberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.køber_createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.køber_readToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.køber_deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.boligToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolig_createToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bolig_readToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bolig_deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.komTilÅbentHusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.handelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.udtrækStatistikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_SælgerClearOpret = new System.Windows.Forms.Button();
            this.btn_SælgerRediger = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sælgerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vejDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sælgerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sælgerDataSet = new Projektopgaven_BobedreMaeglerneAS.sælgerDataSet();
            this.sælgerTableAdapter = new Projektopgaven_BobedreMaeglerneAS.sælgerDataSetTableAdapters.SælgerTableAdapter();
            this.btn_SælgerClearHent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sælgerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sælgerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sælgerVej_txt
            // 
            this.sælgerVej_txt.Location = new System.Drawing.Point(399, 108);
            this.sælgerVej_txt.Name = "sælgerVej_txt";
            this.sælgerVej_txt.Size = new System.Drawing.Size(100, 20);
            this.sælgerVej_txt.TabIndex = 100;
            // 
            // sælgerPostnummer_txt
            // 
            this.sælgerPostnummer_txt.Location = new System.Drawing.Point(399, 139);
            this.sælgerPostnummer_txt.Name = "sælgerPostnummer_txt";
            this.sælgerPostnummer_txt.Size = new System.Drawing.Size(100, 20);
            this.sælgerPostnummer_txt.TabIndex = 99;
            // 
            // sælgerEfternavn_txt
            // 
            this.sælgerEfternavn_txt.Location = new System.Drawing.Point(90, 139);
            this.sælgerEfternavn_txt.Name = "sælgerEfternavn_txt";
            this.sælgerEfternavn_txt.Size = new System.Drawing.Size(100, 20);
            this.sælgerEfternavn_txt.TabIndex = 98;
            // 
            // sælgerPostnummer_lbl
            // 
            this.sælgerPostnummer_lbl.AutoSize = true;
            this.sælgerPostnummer_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sælgerPostnummer_lbl.Location = new System.Drawing.Point(329, 141);
            this.sælgerPostnummer_lbl.Name = "sælgerPostnummer_lbl";
            this.sælgerPostnummer_lbl.Size = new System.Drawing.Size(65, 13);
            this.sælgerPostnummer_lbl.TabIndex = 97;
            this.sælgerPostnummer_lbl.Text = "Postnummer";
            // 
            // sælgerVej_lbl
            // 
            this.sælgerVej_lbl.AutoSize = true;
            this.sælgerVej_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sælgerVej_lbl.Location = new System.Drawing.Point(329, 110);
            this.sælgerVej_lbl.Name = "sælgerVej_lbl";
            this.sælgerVej_lbl.Size = new System.Drawing.Size(22, 13);
            this.sælgerVej_lbl.TabIndex = 96;
            this.sælgerVej_lbl.Text = "Vej";
            // 
            // sælgerEmail_lbl
            // 
            this.sælgerEmail_lbl.AutoSize = true;
            this.sælgerEmail_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sælgerEmail_lbl.Location = new System.Drawing.Point(329, 76);
            this.sælgerEmail_lbl.Name = "sælgerEmail_lbl";
            this.sælgerEmail_lbl.Size = new System.Drawing.Size(32, 13);
            this.sælgerEmail_lbl.TabIndex = 95;
            this.sælgerEmail_lbl.Text = "Email";
            // 
            // sælgerTelefon_lbl
            // 
            this.sælgerTelefon_lbl.AutoSize = true;
            this.sælgerTelefon_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sælgerTelefon_lbl.Location = new System.Drawing.Point(329, 49);
            this.sælgerTelefon_lbl.Name = "sælgerTelefon_lbl";
            this.sælgerTelefon_lbl.Size = new System.Drawing.Size(43, 13);
            this.sælgerTelefon_lbl.TabIndex = 94;
            this.sælgerTelefon_lbl.Text = "Telefon";
            // 
            // sælgerEfternavn_lbl
            // 
            this.sælgerEfternavn_lbl.AutoSize = true;
            this.sælgerEfternavn_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sælgerEfternavn_lbl.Location = new System.Drawing.Point(26, 141);
            this.sælgerEfternavn_lbl.Name = "sælgerEfternavn_lbl";
            this.sælgerEfternavn_lbl.Size = new System.Drawing.Size(53, 13);
            this.sælgerEfternavn_lbl.TabIndex = 93;
            this.sælgerEfternavn_lbl.Text = "Efternavn";
            // 
            // sælgerFornavn_lbl
            // 
            this.sælgerFornavn_lbl.AutoSize = true;
            this.sælgerFornavn_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sælgerFornavn_lbl.Location = new System.Drawing.Point(26, 110);
            this.sælgerFornavn_lbl.Name = "sælgerFornavn_lbl";
            this.sælgerFornavn_lbl.Size = new System.Drawing.Size(46, 13);
            this.sælgerFornavn_lbl.TabIndex = 92;
            this.sælgerFornavn_lbl.Text = "Fornavn";
            // 
            // sælgerCPR_lbl
            // 
            this.sælgerCPR_lbl.AutoSize = true;
            this.sælgerCPR_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sælgerCPR_lbl.Location = new System.Drawing.Point(26, 76);
            this.sælgerCPR_lbl.Name = "sælgerCPR_lbl";
            this.sælgerCPR_lbl.Size = new System.Drawing.Size(29, 13);
            this.sælgerCPR_lbl.TabIndex = 91;
            this.sælgerCPR_lbl.Text = "CPR";
            // 
            // sælgerID_lbl
            // 
            this.sælgerID_lbl.AutoSize = true;
            this.sælgerID_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sælgerID_lbl.Location = new System.Drawing.Point(26, 49);
            this.sælgerID_lbl.Name = "sælgerID_lbl";
            this.sælgerID_lbl.Size = new System.Drawing.Size(18, 13);
            this.sælgerID_lbl.TabIndex = 90;
            this.sælgerID_lbl.Text = "ID";
            // 
            // sælgerEmail_txt
            // 
            this.sælgerEmail_txt.Location = new System.Drawing.Point(399, 75);
            this.sælgerEmail_txt.Name = "sælgerEmail_txt";
            this.sælgerEmail_txt.Size = new System.Drawing.Size(100, 20);
            this.sælgerEmail_txt.TabIndex = 89;
            // 
            // sælgerTelefon_txt
            // 
            this.sælgerTelefon_txt.Location = new System.Drawing.Point(399, 47);
            this.sælgerTelefon_txt.Name = "sælgerTelefon_txt";
            this.sælgerTelefon_txt.Size = new System.Drawing.Size(100, 20);
            this.sælgerTelefon_txt.TabIndex = 88;
            // 
            // sælgerFornavn_txt
            // 
            this.sælgerFornavn_txt.Location = new System.Drawing.Point(90, 108);
            this.sælgerFornavn_txt.Name = "sælgerFornavn_txt";
            this.sælgerFornavn_txt.Size = new System.Drawing.Size(100, 20);
            this.sælgerFornavn_txt.TabIndex = 87;
            // 
            // sælgerCPR_txt
            // 
            this.sælgerCPR_txt.Location = new System.Drawing.Point(90, 75);
            this.sælgerCPR_txt.Name = "sælgerCPR_txt";
            this.sælgerCPR_txt.Size = new System.Drawing.Size(100, 20);
            this.sælgerCPR_txt.TabIndex = 86;
            // 
            // sælgerID_txt
            // 
            this.sælgerID_txt.Location = new System.Drawing.Point(90, 45);
            this.sælgerID_txt.Name = "sælgerID_txt";
            this.sælgerID_txt.Size = new System.Drawing.Size(100, 20);
            this.sælgerID_txt.TabIndex = 85;
            // 
            // btn_SletSælger
            // 
            this.btn_SletSælger.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_SletSælger.Location = new System.Drawing.Point(27, 183);
            this.btn_SletSælger.Name = "btn_SletSælger";
            this.btn_SletSælger.Size = new System.Drawing.Size(113, 23);
            this.btn_SletSælger.TabIndex = 104;
            this.btn_SletSælger.Text = "Slet Sælger";
            this.btn_SletSælger.UseVisualStyleBackColor = true;
            this.btn_SletSælger.Click += new System.EventHandler(this.btn_SletSælger_Click);
            // 
            // btn_OpdaterSælger
            // 
            this.btn_OpdaterSælger.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_OpdaterSælger.Location = new System.Drawing.Point(159, 183);
            this.btn_OpdaterSælger.Name = "btn_OpdaterSælger";
            this.btn_OpdaterSælger.Size = new System.Drawing.Size(113, 23);
            this.btn_OpdaterSælger.TabIndex = 103;
            this.btn_OpdaterSælger.Text = "Gem og opdater";
            this.btn_OpdaterSælger.UseVisualStyleBackColor = true;
            this.btn_OpdaterSælger.Click += new System.EventHandler(this.btn_OpdaterSælger_Click);
            // 
            // btn_HentSælger
            // 
            this.btn_HentSælger.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_HentSælger.Location = new System.Drawing.Point(27, 183);
            this.btn_HentSælger.Name = "btn_HentSælger";
            this.btn_HentSælger.Size = new System.Drawing.Size(113, 23);
            this.btn_HentSælger.TabIndex = 102;
            this.btn_HentSælger.Text = "Hent";
            this.btn_HentSælger.UseVisualStyleBackColor = true;
            this.btn_HentSælger.Click += new System.EventHandler(this.btn_HentSælger_Click);
            // 
            // btn_OpretSælger
            // 
            this.btn_OpretSælger.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_OpretSælger.Location = new System.Drawing.Point(27, 184);
            this.btn_OpretSælger.Name = "btn_OpretSælger";
            this.btn_OpretSælger.Size = new System.Drawing.Size(113, 23);
            this.btn_OpretSælger.TabIndex = 101;
            this.btn_OpretSælger.Text = "Opret Sælger";
            this.btn_OpretSælger.UseVisualStyleBackColor = true;
            this.btn_OpretSælger.Click += new System.EventHandler(this.btn_OpretSælger_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejendomsmæglerToolStripMenuItem,
            this.sælgerToolStripMenuItem,
            this.køberToolStripMenuItem,
            this.boligToolStripMenuItem,
            this.sagToolStripMenuItem,
            this.handelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 106;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ejendomsmæglerToolStripMenuItem
            // 
            this.ejendomsmæglerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejendomsmægler_createToolStripMenuItem,
            this.ejendomsmægler_readToolStripMenuItem,
            this.ejendomsmægler_deleteToolStripMenuItem});
            this.ejendomsmæglerToolStripMenuItem.Name = "ejendomsmæglerToolStripMenuItem";
            this.ejendomsmæglerToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.ejendomsmæglerToolStripMenuItem.Text = "Ejendomsmægler";
            // 
            // ejendomsmægler_createToolStripMenuItem
            // 
            this.ejendomsmægler_createToolStripMenuItem.Name = "ejendomsmægler_createToolStripMenuItem";
            this.ejendomsmægler_createToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.ejendomsmægler_createToolStripMenuItem.Text = "Opret en ejendomsmægler";
            this.ejendomsmægler_createToolStripMenuItem.Click += new System.EventHandler(this.ejendomsmægler_createToolStripMenuItem_Click);
            // 
            // ejendomsmægler_readToolStripMenuItem
            // 
            this.ejendomsmægler_readToolStripMenuItem.Name = "ejendomsmægler_readToolStripMenuItem";
            this.ejendomsmægler_readToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.ejendomsmægler_readToolStripMenuItem.Text = "Hent og opdater en ejendomsmægler";
            this.ejendomsmægler_readToolStripMenuItem.Click += new System.EventHandler(this.ejendomsmægler_readToolStripMenuItem_Click);
            // 
            // ejendomsmægler_deleteToolStripMenuItem
            // 
            this.ejendomsmægler_deleteToolStripMenuItem.Name = "ejendomsmægler_deleteToolStripMenuItem";
            this.ejendomsmægler_deleteToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.ejendomsmægler_deleteToolStripMenuItem.Text = "Slet en ejendomsmægler";
            this.ejendomsmægler_deleteToolStripMenuItem.Click += new System.EventHandler(this.ejendomsmægler_deleteToolStripMenuItem_Click);
            // 
            // sælgerToolStripMenuItem
            // 
            this.sælgerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sælger_createToolStripMenuItem,
            this.sælger_readToolStripMenuItem,
            this.sælger_deleteToolStripMenuItem});
            this.sælgerToolStripMenuItem.Name = "sælgerToolStripMenuItem";
            this.sælgerToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.sælgerToolStripMenuItem.Text = "Sælger";
            // 
            // sælger_createToolStripMenuItem
            // 
            this.sælger_createToolStripMenuItem.Name = "sælger_createToolStripMenuItem";
            this.sælger_createToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.sælger_createToolStripMenuItem.Text = "Opret en sælger";
            this.sælger_createToolStripMenuItem.Click += new System.EventHandler(this.sælger_createToolStripMenuItem_Click);
            // 
            // sælger_readToolStripMenuItem
            // 
            this.sælger_readToolStripMenuItem.Name = "sælger_readToolStripMenuItem";
            this.sælger_readToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.sælger_readToolStripMenuItem.Text = "Hent og opdater en sælger";
            this.sælger_readToolStripMenuItem.Click += new System.EventHandler(this.sælger_readToolStripMenuItem_Click);
            // 
            // sælger_deleteToolStripMenuItem
            // 
            this.sælger_deleteToolStripMenuItem.Name = "sælger_deleteToolStripMenuItem";
            this.sælger_deleteToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.sælger_deleteToolStripMenuItem.Text = "Slet en sælger";
            this.sælger_deleteToolStripMenuItem.Click += new System.EventHandler(this.sælger_deleteToolStripMenuItem_Click);
            // 
            // køberToolStripMenuItem
            // 
            this.køberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.køber_createToolStripMenuItem1,
            this.køber_readToolStripMenuItem1,
            this.køber_deleteToolStripMenuItem1});
            this.køberToolStripMenuItem.Name = "køberToolStripMenuItem";
            this.køberToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.køberToolStripMenuItem.Text = "Køber";
            // 
            // køber_createToolStripMenuItem1
            // 
            this.køber_createToolStripMenuItem1.Name = "køber_createToolStripMenuItem1";
            this.køber_createToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.køber_createToolStripMenuItem1.Text = "Opret Køber";
            this.køber_createToolStripMenuItem1.Click += new System.EventHandler(this.køber_createToolStripMenuItem1_Click);
            // 
            // køber_readToolStripMenuItem1
            // 
            this.køber_readToolStripMenuItem1.Name = "køber_readToolStripMenuItem1";
            this.køber_readToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.køber_readToolStripMenuItem1.Text = "Find og Opdater Køber";
            this.køber_readToolStripMenuItem1.Click += new System.EventHandler(this.køber_readToolStripMenuItem1_Click);
            // 
            // køber_deleteToolStripMenuItem1
            // 
            this.køber_deleteToolStripMenuItem1.Name = "køber_deleteToolStripMenuItem1";
            this.køber_deleteToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.køber_deleteToolStripMenuItem1.Text = "Slet Køber";
            this.køber_deleteToolStripMenuItem1.Click += new System.EventHandler(this.køber_deleteToolStripMenuItem1_Click);
            // 
            // boligToolStripMenuItem
            // 
            this.boligToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bolig_createToolStripMenuItem2,
            this.bolig_readToolStripMenuItem2,
            this.bolig_deleteToolStripMenuItem2,
            this.komTilÅbentHusToolStripMenuItem});
            this.boligToolStripMenuItem.Name = "boligToolStripMenuItem";
            this.boligToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.boligToolStripMenuItem.Text = "Bolig";
            // 
            // bolig_createToolStripMenuItem2
            // 
            this.bolig_createToolStripMenuItem2.Name = "bolig_createToolStripMenuItem2";
            this.bolig_createToolStripMenuItem2.Size = new System.Drawing.Size(174, 22);
            this.bolig_createToolStripMenuItem2.Text = "Opret en ny Bolig";
            this.bolig_createToolStripMenuItem2.Click += new System.EventHandler(this.bolig_createToolStripMenuItem2_Click);
            // 
            // bolig_readToolStripMenuItem2
            // 
            this.bolig_readToolStripMenuItem2.Name = "bolig_readToolStripMenuItem2";
            this.bolig_readToolStripMenuItem2.Size = new System.Drawing.Size(174, 22);
            this.bolig_readToolStripMenuItem2.Text = "Hent og Opdater";
            this.bolig_readToolStripMenuItem2.Click += new System.EventHandler(this.bolig_readToolStripMenuItem2_Click);
            // 
            // bolig_deleteToolStripMenuItem2
            // 
            this.bolig_deleteToolStripMenuItem2.Name = "bolig_deleteToolStripMenuItem2";
            this.bolig_deleteToolStripMenuItem2.Size = new System.Drawing.Size(174, 22);
            this.bolig_deleteToolStripMenuItem2.Text = "Slet en Bolig";
            this.bolig_deleteToolStripMenuItem2.Click += new System.EventHandler(this.bolig_deleteToolStripMenuItem2_Click);
            // 
            // komTilÅbentHusToolStripMenuItem
            // 
            this.komTilÅbentHusToolStripMenuItem.Name = "komTilÅbentHusToolStripMenuItem";
            this.komTilÅbentHusToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.komTilÅbentHusToolStripMenuItem.Text = "Kom til Åbent Hus!";
            this.komTilÅbentHusToolStripMenuItem.Click += new System.EventHandler(this.komTilÅbentHusToolStripMenuItem_Click);
            // 
            // sagToolStripMenuItem
            // 
            this.sagToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.readToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.sagToolStripMenuItem.Name = "sagToolStripMenuItem";
            this.sagToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sagToolStripMenuItem.Text = "Sag";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.createToolStripMenuItem.Text = "Opret en ny Sag";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.readToolStripMenuItem.Text = "Hent og Opdater";
            this.readToolStripMenuItem.Click += new System.EventHandler(this.readToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.deleteToolStripMenuItem.Text = "Slet en Sag";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // handelToolStripMenuItem
            // 
            this.handelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem1,
            this.readToolStripMenuItem1,
            this.deleteToolStripMenuItem1,
            this.udtrækStatistikToolStripMenuItem});
            this.handelToolStripMenuItem.Name = "handelToolStripMenuItem";
            this.handelToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.handelToolStripMenuItem.Text = "Handel";
            // 
            // createToolStripMenuItem1
            // 
            this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            this.createToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.createToolStripMenuItem1.Text = "Opret Handel";
            this.createToolStripMenuItem1.Click += new System.EventHandler(this.createToolStripMenuItem1_Click);
            // 
            // readToolStripMenuItem1
            // 
            this.readToolStripMenuItem1.Name = "readToolStripMenuItem1";
            this.readToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.readToolStripMenuItem1.Text = "Find og Opdater Handel";
            this.readToolStripMenuItem1.Click += new System.EventHandler(this.readToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.deleteToolStripMenuItem1.Text = "Slet Handel";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // udtrækStatistikToolStripMenuItem
            // 
            this.udtrækStatistikToolStripMenuItem.Name = "udtrækStatistikToolStripMenuItem";
            this.udtrækStatistikToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.udtrækStatistikToolStripMenuItem.Text = "Udtræk Statistik";
            this.udtrækStatistikToolStripMenuItem.Click += new System.EventHandler(this.udtrækStatistikToolStripMenuItem_Click);
            // 
            // btn_SælgerClearOpret
            // 
            this.btn_SælgerClearOpret.Location = new System.Drawing.Point(532, 132);
            this.btn_SælgerClearOpret.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SælgerClearOpret.Name = "btn_SælgerClearOpret";
            this.btn_SælgerClearOpret.Size = new System.Drawing.Size(63, 23);
            this.btn_SælgerClearOpret.TabIndex = 107;
            this.btn_SælgerClearOpret.Text = "Clear";
            this.btn_SælgerClearOpret.UseVisualStyleBackColor = true;
            this.btn_SælgerClearOpret.Click += new System.EventHandler(this.btn_SælgerClear_Click);
            // 
            // btn_SælgerRediger
            // 
            this.btn_SælgerRediger.Location = new System.Drawing.Point(532, 93);
            this.btn_SælgerRediger.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SælgerRediger.Name = "btn_SælgerRediger";
            this.btn_SælgerRediger.Size = new System.Drawing.Size(63, 23);
            this.btn_SælgerRediger.TabIndex = 108;
            this.btn_SælgerRediger.Text = "Rediger";
            this.btn_SælgerRediger.UseVisualStyleBackColor = true;
            this.btn_SælgerRediger.Click += new System.EventHandler(this.btn_SælgerRediger_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sælgerIDDataGridViewTextBoxColumn,
            this.cPRDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.fnavnDataGridViewTextBoxColumn,
            this.enavnDataGridViewTextBoxColumn,
            this.vejDataGridViewTextBoxColumn,
            this.postnummerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sælgerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 225);
            this.dataGridView1.TabIndex = 109;
            // 
            // sælgerIDDataGridViewTextBoxColumn
            // 
            this.sælgerIDDataGridViewTextBoxColumn.DataPropertyName = "SælgerID";
            this.sælgerIDDataGridViewTextBoxColumn.HeaderText = "SælgerID";
            this.sælgerIDDataGridViewTextBoxColumn.Name = "sælgerIDDataGridViewTextBoxColumn";
            this.sælgerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPRDataGridViewTextBoxColumn
            // 
            this.cPRDataGridViewTextBoxColumn.DataPropertyName = "CPR";
            this.cPRDataGridViewTextBoxColumn.HeaderText = "CPR";
            this.cPRDataGridViewTextBoxColumn.Name = "cPRDataGridViewTextBoxColumn";
            this.cPRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fnavnDataGridViewTextBoxColumn
            // 
            this.fnavnDataGridViewTextBoxColumn.DataPropertyName = "Fnavn";
            this.fnavnDataGridViewTextBoxColumn.HeaderText = "Fnavn";
            this.fnavnDataGridViewTextBoxColumn.Name = "fnavnDataGridViewTextBoxColumn";
            this.fnavnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enavnDataGridViewTextBoxColumn
            // 
            this.enavnDataGridViewTextBoxColumn.DataPropertyName = "Enavn";
            this.enavnDataGridViewTextBoxColumn.HeaderText = "Enavn";
            this.enavnDataGridViewTextBoxColumn.Name = "enavnDataGridViewTextBoxColumn";
            this.enavnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vejDataGridViewTextBoxColumn
            // 
            this.vejDataGridViewTextBoxColumn.DataPropertyName = "Vej";
            this.vejDataGridViewTextBoxColumn.HeaderText = "Vej";
            this.vejDataGridViewTextBoxColumn.Name = "vejDataGridViewTextBoxColumn";
            this.vejDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postnummerDataGridViewTextBoxColumn
            // 
            this.postnummerDataGridViewTextBoxColumn.DataPropertyName = "Postnummer";
            this.postnummerDataGridViewTextBoxColumn.HeaderText = "Postnummer";
            this.postnummerDataGridViewTextBoxColumn.Name = "postnummerDataGridViewTextBoxColumn";
            this.postnummerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sælgerBindingSource
            // 
            this.sælgerBindingSource.DataMember = "Sælger";
            this.sælgerBindingSource.DataSource = this.sælgerDataSet;
            // 
            // sælgerDataSet
            // 
            this.sælgerDataSet.DataSetName = "sælgerDataSet";
            this.sælgerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sælgerTableAdapter
            // 
            this.sælgerTableAdapter.ClearBeforeFill = true;
            // 
            // btn_SælgerClearHent
            // 
            this.btn_SælgerClearHent.Location = new System.Drawing.Point(532, 132);
            this.btn_SælgerClearHent.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SælgerClearHent.Name = "btn_SælgerClearHent";
            this.btn_SælgerClearHent.Size = new System.Drawing.Size(63, 23);
            this.btn_SælgerClearHent.TabIndex = 110;
            this.btn_SælgerClearHent.Text = "Clear";
            this.btn_SælgerClearHent.UseVisualStyleBackColor = true;
            this.btn_SælgerClearHent.Click += new System.EventHandler(this.btn_SælgerClearHent_Click);
            // 
            // SælgerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SælgerClearHent);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_SælgerRediger);
            this.Controls.Add(this.btn_SælgerClearOpret);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_SletSælger);
            this.Controls.Add(this.btn_OpdaterSælger);
            this.Controls.Add(this.btn_HentSælger);
            this.Controls.Add(this.btn_OpretSælger);
            this.Controls.Add(this.sælgerVej_txt);
            this.Controls.Add(this.sælgerPostnummer_txt);
            this.Controls.Add(this.sælgerEfternavn_txt);
            this.Controls.Add(this.sælgerPostnummer_lbl);
            this.Controls.Add(this.sælgerVej_lbl);
            this.Controls.Add(this.sælgerEmail_lbl);
            this.Controls.Add(this.sælgerTelefon_lbl);
            this.Controls.Add(this.sælgerEfternavn_lbl);
            this.Controls.Add(this.sælgerFornavn_lbl);
            this.Controls.Add(this.sælgerCPR_lbl);
            this.Controls.Add(this.sælgerID_lbl);
            this.Controls.Add(this.sælgerEmail_txt);
            this.Controls.Add(this.sælgerTelefon_txt);
            this.Controls.Add(this.sælgerFornavn_txt);
            this.Controls.Add(this.sælgerCPR_txt);
            this.Controls.Add(this.sælgerID_txt);
            this.Name = "SælgerUI";
            this.Text = "SælgerUI";
            this.Load += new System.EventHandler(this.SælgerUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sælgerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sælgerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sælgerVej_txt;
        private System.Windows.Forms.TextBox sælgerPostnummer_txt;
        private System.Windows.Forms.TextBox sælgerEfternavn_txt;
        private System.Windows.Forms.Label sælgerPostnummer_lbl;
        private System.Windows.Forms.Label sælgerVej_lbl;
        private System.Windows.Forms.Label sælgerEmail_lbl;
        private System.Windows.Forms.Label sælgerTelefon_lbl;
        private System.Windows.Forms.Label sælgerEfternavn_lbl;
        private System.Windows.Forms.Label sælgerFornavn_lbl;
        private System.Windows.Forms.Label sælgerCPR_lbl;
        private System.Windows.Forms.Label sælgerID_lbl;
        private System.Windows.Forms.TextBox sælgerEmail_txt;
        private System.Windows.Forms.TextBox sælgerTelefon_txt;
        private System.Windows.Forms.TextBox sælgerFornavn_txt;
        private System.Windows.Forms.TextBox sælgerCPR_txt;
        private System.Windows.Forms.TextBox sælgerID_txt;
        public System.Windows.Forms.Button btn_SletSælger;
        public System.Windows.Forms.Button btn_OpdaterSælger;
        public System.Windows.Forms.Button btn_HentSælger;
        public System.Windows.Forms.Button btn_OpretSælger;
        private System.Windows.Forms.ErrorProvider errorProvider1;


        #region Get tekstbokse
        public System.Windows.Forms.TextBox GetSælgerIDTekstboks()
        {
            return sælgerID_txt;
        }

        public System.Windows.Forms.TextBox GetSælgerCPRTekstboks()
        {
            return sælgerCPR_txt;
        }

        public System.Windows.Forms.TextBox GetSælgerTelefonTekstboks()
        {
            return sælgerTelefon_txt;
        }

        public System.Windows.Forms.TextBox GetSælgerEmailTekstboks()
        {
            return sælgerEmail_txt;
        }

        public System.Windows.Forms.TextBox GetSælgerFnavnTekstboks()
        {
            return sælgerFornavn_txt;
        }

        public System.Windows.Forms.TextBox GetSælgerEnavnTekstboks()
        {
            return sælgerEfternavn_txt;
        }

        public System.Windows.Forms.TextBox GetSælgerVejTekstboks()
        {
            return sælgerVej_txt;
        }

        public System.Windows.Forms.TextBox GetSælgerPostnummerTekstboks()
        {
            return sælgerPostnummer_txt;
        }
        #endregion

        #region Get knapper
        public System.Windows.Forms.Button GetOpretSælgerKnap()
        {
            return btn_OpretSælger;
        }

        public System.Windows.Forms.Button GetHentSælgerKnap()
        {
            return btn_HentSælger;
        }

        public System.Windows.Forms.Button GetOpdaterSælgerKnap()
        {
            return btn_OpdaterSælger;
        }

        public System.Windows.Forms.Button GetSletSælgerKnap()
        {
            return btn_SletSælger;
        }

        public System.Windows.Forms.Button GetClearAllKnap()
        {
            return btn_SælgerClearOpret;
        }

        public System.Windows.Forms.Button GetRedigerSælgerKnap()
        {
            return btn_SælgerRediger;
        }

        public System.Windows.Forms.Button GetClearHentButton()
        {
            return btn_SælgerClearHent;
        }
        #endregion

        #region Clear All
        public void ClearAll()
        {
            sælgerID_txt.Clear();
            sælgerCPR_txt.Clear();
            sælgerTelefon_txt.Clear();
            sælgerEmail_txt.Clear();
            sælgerFornavn_txt.Clear();
            sælgerEfternavn_txt.Clear();
            sælgerVej_txt.Clear();
            sælgerPostnummer_txt.Clear();
        }
        #endregion

        #region Enable All
        public void EnableAll()
        {
            sælgerID_txt.Enabled = true;
            sælgerCPR_txt.Enabled = true;
            sælgerTelefon_txt.Enabled = true;
            sælgerEmail_txt.Enabled = true;
            sælgerFornavn_txt.Enabled = true;
            sælgerEfternavn_txt.Enabled = true;
            sælgerVej_txt.Enabled = true;
            sælgerPostnummer_txt.Enabled = true;
        }
        #endregion

        public void DisableAll()
        {
            sælgerID_txt.Enabled = false;
            sælgerCPR_txt.Enabled = false;
            sælgerTelefon_txt.Enabled = false;
            sælgerEmail_txt.Enabled = false;
            sælgerFornavn_txt.Enabled = false;
            sælgerEfternavn_txt.Enabled = false;
            sælgerVej_txt.Enabled = false;
            sælgerPostnummer_txt.Enabled = false;
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ejendomsmæglerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejendomsmægler_createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejendomsmægler_readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejendomsmægler_deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sælgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sælger_createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sælger_readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sælger_deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem køberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem køber_createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem køber_readToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem køber_deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem boligToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bolig_createToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bolig_readToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bolig_deleteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem komTilÅbentHusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem handelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem udtrækStatistikToolStripMenuItem;
        private System.Windows.Forms.Button btn_SælgerClearOpret;
        private System.Windows.Forms.Button btn_SælgerRediger;
        private System.Windows.Forms.DataGridView dataGridView1;
        private sælgerDataSet sælgerDataSet;
        private System.Windows.Forms.BindingSource sælgerBindingSource;
        private sælgerDataSetTableAdapters.SælgerTableAdapter sælgerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sælgerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vejDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_SælgerClearHent;
    }
}