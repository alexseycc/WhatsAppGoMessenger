namespace WhatsAppGo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connect_btnt = new System.Windows.Forms.Button();
            this.numcel_chkbox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.entrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adcionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desenvolvimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connect_btnt
            // 
            this.connect_btnt.Location = new System.Drawing.Point(219, 321);
            this.connect_btnt.Name = "connect_btnt";
            this.connect_btnt.Size = new System.Drawing.Size(170, 23);
            this.connect_btnt.TabIndex = 0;
            this.connect_btnt.Text = "Conectar";
            this.connect_btnt.UseVisualStyleBackColor = true;
            // 
            // numcel_chkbox
            // 
            this.numcel_chkbox.FormattingEnabled = true;
            this.numcel_chkbox.Location = new System.Drawing.Point(268, 256);
            this.numcel_chkbox.Name = "numcel_chkbox";
            this.numcel_chkbox.Size = new System.Drawing.Size(121, 21);
            this.numcel_chkbox.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "15(sp)",
            "21(rj)",
            "22(rj)",
            "71(ba)",
            "75(ba)"});
            this.comboBox1.Location = new System.Drawing.Point(219, 256);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(43, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entrarToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.desenvolvimentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(575, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // entrarToolStripMenuItem
            // 
            this.entrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adcionarToolStripMenuItem,
            this.removerToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.entrarToolStripMenuItem.Name = "entrarToolStripMenuItem";
            this.entrarToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.entrarToolStripMenuItem.Text = "Menu";
            this.entrarToolStripMenuItem.Click += new System.EventHandler(this.entrarToolStripMenuItem_Click);
            // 
            // adcionarToolStripMenuItem
            // 
            this.adcionarToolStripMenuItem.Name = "adcionarToolStripMenuItem";
            this.adcionarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.adcionarToolStripMenuItem.Text = "Adcionar";
            this.adcionarToolStripMenuItem.Click += new System.EventHandler(this.adcionarToolStripMenuItem_Click);
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removerToolStripMenuItem.Text = "Remover";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // desenvolvimentoToolStripMenuItem
            // 
            this.desenvolvimentoToolStripMenuItem.Name = "desenvolvimentoToolStripMenuItem";
            this.desenvolvimentoToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.desenvolvimentoToolStripMenuItem.Text = "Desenvolvimento";
            this.desenvolvimentoToolStripMenuItem.Click += new System.EventHandler(this.desenvolvimentoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WhatsAppGo.Properties.Resources.Whatsapp_37229;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(575, 454);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numcel_chkbox);
            this.Controls.Add(this.connect_btnt);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "WhatssAppGo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect_btnt;
        private System.Windows.Forms.ComboBox numcel_chkbox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem entrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desenvolvimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adcionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

