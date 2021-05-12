﻿namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    partial class SagUI
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
            this.sagnr_lbl = new System.Windows.Forms.Label();
            this.sagStatus_lbl = new System.Windows.Forms.Label();
            this.sagID_txt = new System.Windows.Forms.TextBox();
            this.sagStatus_cbox = new System.Windows.Forms.ComboBox();
            this.sag_boligID_lbl = new System.Windows.Forms.Label();
            this.sag_ejendomsmæglerID_lbl = new System.Windows.Forms.Label();
            this.sag_sælgerID_lbl = new System.Windows.Forms.Label();
            this.sag_boligID_cbox = new System.Windows.Forms.ComboBox();
            this.sag_sælgerID_cbox = new System.Windows.Forms.ComboBox();
            this.sag_ejendomsmæglerID_cbox = new System.Windows.Forms.ComboBox();
            this.btn_OpretSag = new System.Windows.Forms.Button();
            this.btn_HentSag = new System.Windows.Forms.Button();
            this.btn_OpdaterSag = new System.Windows.Forms.Button();
            this.btn_SletSag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sagnr_lbl
            // 
            this.sagnr_lbl.AutoSize = true;
            this.sagnr_lbl.Location = new System.Drawing.Point(22, 23);
            this.sagnr_lbl.Name = "sagnr_lbl";
            this.sagnr_lbl.Size = new System.Drawing.Size(43, 13);
            this.sagnr_lbl.TabIndex = 0;
            this.sagnr_lbl.Text = "Sags nr";
            // 
            // sagStatus_lbl
            // 
            this.sagStatus_lbl.AutoSize = true;
            this.sagStatus_lbl.Location = new System.Drawing.Point(22, 66);
            this.sagStatus_lbl.Name = "sagStatus_lbl";
            this.sagStatus_lbl.Size = new System.Drawing.Size(37, 13);
            this.sagStatus_lbl.TabIndex = 1;
            this.sagStatus_lbl.Text = "Status";
            // 
            // sagID_txt
            // 
            this.sagID_txt.Location = new System.Drawing.Point(90, 20);
            this.sagID_txt.Name = "sagID_txt";
            this.sagID_txt.Size = new System.Drawing.Size(121, 20);
            this.sagID_txt.TabIndex = 2;
            // 
            // sagStatus_cbox
            // 
            this.sagStatus_cbox.FormattingEnabled = true;
            this.sagStatus_cbox.Items.AddRange(new object[] {
            "Åben",
            "Lukket (solgt bolig)",
            "Lukket (andre grunde)"});
            this.sagStatus_cbox.Location = new System.Drawing.Point(90, 63);
            this.sagStatus_cbox.Name = "sagStatus_cbox";
            this.sagStatus_cbox.Size = new System.Drawing.Size(121, 21);
            this.sagStatus_cbox.TabIndex = 3;
            // 
            // sag_boligID_lbl
            // 
            this.sag_boligID_lbl.AutoSize = true;
            this.sag_boligID_lbl.Location = new System.Drawing.Point(287, 27);
            this.sag_boligID_lbl.Name = "sag_boligID_lbl";
            this.sag_boligID_lbl.Size = new System.Drawing.Size(44, 13);
            this.sag_boligID_lbl.TabIndex = 4;
            this.sag_boligID_lbl.Text = "Bolig ID";
            // 
            // sag_ejendomsmæglerID_lbl
            // 
            this.sag_ejendomsmæglerID_lbl.AutoSize = true;
            this.sag_ejendomsmæglerID_lbl.Location = new System.Drawing.Point(604, 27);
            this.sag_ejendomsmæglerID_lbl.Name = "sag_ejendomsmæglerID_lbl";
            this.sag_ejendomsmæglerID_lbl.Size = new System.Drawing.Size(102, 13);
            this.sag_ejendomsmæglerID_lbl.TabIndex = 5;
            this.sag_ejendomsmæglerID_lbl.Text = "Ejendomsmægler ID";
            // 
            // sag_sælgerID_lbl
            // 
            this.sag_sælgerID_lbl.AutoSize = true;
            this.sag_sælgerID_lbl.Location = new System.Drawing.Point(443, 27);
            this.sag_sælgerID_lbl.Name = "sag_sælgerID_lbl";
            this.sag_sælgerID_lbl.Size = new System.Drawing.Size(55, 13);
            this.sag_sælgerID_lbl.TabIndex = 6;
            this.sag_sælgerID_lbl.Text = "Sælger ID";
            // 
            // sag_boligID_cbox
            // 
            this.sag_boligID_cbox.FormattingEnabled = true;
            this.sag_boligID_cbox.Items.AddRange(new object[] {
            "Åben",
            "Lukket (solgt bolig)",
            "Lukket (andre grunde)"});
            this.sag_boligID_cbox.Location = new System.Drawing.Point(252, 63);
            this.sag_boligID_cbox.Name = "sag_boligID_cbox";
            this.sag_boligID_cbox.Size = new System.Drawing.Size(121, 21);
            this.sag_boligID_cbox.TabIndex = 7;
            // 
            // sag_sælgerID_cbox
            // 
            this.sag_sælgerID_cbox.FormattingEnabled = true;
            this.sag_sælgerID_cbox.Location = new System.Drawing.Point(414, 63);
            this.sag_sælgerID_cbox.Name = "sag_sælgerID_cbox";
            this.sag_sælgerID_cbox.Size = new System.Drawing.Size(121, 21);
            this.sag_sælgerID_cbox.TabIndex = 8;
            // 
            // sag_ejendomsmæglerID_cbox
            // 
            this.sag_ejendomsmæglerID_cbox.FormattingEnabled = true;
            this.sag_ejendomsmæglerID_cbox.Location = new System.Drawing.Point(607, 63);
            this.sag_ejendomsmæglerID_cbox.Name = "sag_ejendomsmæglerID_cbox";
            this.sag_ejendomsmæglerID_cbox.Size = new System.Drawing.Size(121, 21);
            this.sag_ejendomsmæglerID_cbox.TabIndex = 9;
            // 
            // btn_OpretSag
            // 
            this.btn_OpretSag.Location = new System.Drawing.Point(12, 119);
            this.btn_OpretSag.Name = "btn_OpretSag";
            this.btn_OpretSag.Size = new System.Drawing.Size(75, 23);
            this.btn_OpretSag.TabIndex = 10;
            this.btn_OpretSag.Text = "Create";
            this.btn_OpretSag.UseVisualStyleBackColor = true;
            this.btn_OpretSag.Click += new System.EventHandler(this.btn_OpretSag_Click);
            // 
            // btn_HentSag
            // 
            this.btn_HentSag.Location = new System.Drawing.Point(136, 119);
            this.btn_HentSag.Name = "btn_HentSag";
            this.btn_HentSag.Size = new System.Drawing.Size(75, 23);
            this.btn_HentSag.TabIndex = 11;
            this.btn_HentSag.Text = "Hent";
            this.btn_HentSag.UseVisualStyleBackColor = true;
            this.btn_HentSag.Click += new System.EventHandler(this.btn_HentSag_Click);
            // 
            // btn_OpdaterSag
            // 
            this.btn_OpdaterSag.Location = new System.Drawing.Point(252, 119);
            this.btn_OpdaterSag.Name = "btn_OpdaterSag";
            this.btn_OpdaterSag.Size = new System.Drawing.Size(75, 23);
            this.btn_OpdaterSag.TabIndex = 12;
            this.btn_OpdaterSag.Text = "Opdater";
            this.btn_OpdaterSag.UseVisualStyleBackColor = true;
            this.btn_OpdaterSag.Click += new System.EventHandler(this.btn_OpdaterSag_Click);
            // 
            // btn_SletSag
            // 
            this.btn_SletSag.Location = new System.Drawing.Point(353, 119);
            this.btn_SletSag.Name = "btn_SletSag";
            this.btn_SletSag.Size = new System.Drawing.Size(75, 23);
            this.btn_SletSag.TabIndex = 13;
            this.btn_SletSag.Text = "Slet";
            this.btn_SletSag.UseVisualStyleBackColor = true;
            this.btn_SletSag.Click += new System.EventHandler(this.btn_SletSag_Click);
            // 
            // SagUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SletSag);
            this.Controls.Add(this.btn_OpdaterSag);
            this.Controls.Add(this.btn_HentSag);
            this.Controls.Add(this.btn_OpretSag);
            this.Controls.Add(this.sag_ejendomsmæglerID_cbox);
            this.Controls.Add(this.sag_sælgerID_cbox);
            this.Controls.Add(this.sag_boligID_cbox);
            this.Controls.Add(this.sag_sælgerID_lbl);
            this.Controls.Add(this.sag_ejendomsmæglerID_lbl);
            this.Controls.Add(this.sag_boligID_lbl);
            this.Controls.Add(this.sagStatus_cbox);
            this.Controls.Add(this.sagID_txt);
            this.Controls.Add(this.sagStatus_lbl);
            this.Controls.Add(this.sagnr_lbl);
            this.Name = "SagUI";
            this.Text = "SagUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sagnr_lbl;
        private System.Windows.Forms.Label sagStatus_lbl;
        private System.Windows.Forms.TextBox sagID_txt;
        private System.Windows.Forms.ComboBox sagStatus_cbox;
        private System.Windows.Forms.Label sag_boligID_lbl;
        private System.Windows.Forms.Label sag_ejendomsmæglerID_lbl;
        private System.Windows.Forms.Label sag_sælgerID_lbl;
        private System.Windows.Forms.ComboBox sag_boligID_cbox;
        private System.Windows.Forms.ComboBox sag_sælgerID_cbox;
        private System.Windows.Forms.ComboBox sag_ejendomsmæglerID_cbox;
        private System.Windows.Forms.Button btn_OpretSag;
        private System.Windows.Forms.Button btn_HentSag;
        private System.Windows.Forms.Button btn_OpdaterSag;
        private System.Windows.Forms.Button btn_SletSag;
    }
}