namespace FlashGenerator
{
    partial class Form1
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
            label1 = new Label();
            tb_SKU = new TextBox();
            label2 = new Label();
            cb_brand = new ComboBox();
            label3 = new Label();
            cb_manufacturer = new ComboBox();
            btn_Generate = new Button();
            btn_SelectFlash = new Button();
            l_FlashFile = new Label();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            manufacturersToolStripMenuItem = new ToolStripMenuItem();
            brandsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "SKU";
            // 
            // tb_SKU
            // 
            tb_SKU.Location = new Point(12, 60);
            tb_SKU.Name = "tb_SKU";
            tb_SKU.Size = new Size(310, 23);
            tb_SKU.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 2;
            label2.Text = "Manufacturer";
            // 
            // cb_brand
            // 
            cb_brand.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_brand.FormattingEnabled = true;
            cb_brand.Items.AddRange(new object[] { "VeryPC", "OPSPC", "Clevertouch" });
            cb_brand.Location = new Point(174, 119);
            cb_brand.Name = "cb_brand";
            cb_brand.Size = new Size(148, 23);
            cb_brand.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 101);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "Brand";
            // 
            // cb_manufacturer
            // 
            cb_manufacturer.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_manufacturer.FormattingEnabled = true;
            cb_manufacturer.Items.AddRange(new object[] { "ASUS", "ASROCK", "CLEVO", "GIGABYTE", "JWIPC", "MSI" });
            cb_manufacturer.Location = new Point(12, 120);
            cb_manufacturer.Name = "cb_manufacturer";
            cb_manufacturer.Size = new Size(148, 23);
            cb_manufacturer.TabIndex = 3;
            // 
            // btn_Generate
            // 
            btn_Generate.Location = new Point(201, 216);
            btn_Generate.Name = "btn_Generate";
            btn_Generate.Size = new Size(121, 33);
            btn_Generate.TabIndex = 8;
            btn_Generate.Text = "Generate";
            btn_Generate.UseVisualStyleBackColor = true;
            btn_Generate.Click += btn_Generate_Click;
            // 
            // btn_SelectFlash
            // 
            btn_SelectFlash.Location = new Point(12, 170);
            btn_SelectFlash.Name = "btn_SelectFlash";
            btn_SelectFlash.Size = new Size(99, 31);
            btn_SelectFlash.TabIndex = 7;
            btn_SelectFlash.Text = "Select Flash ...";
            btn_SelectFlash.UseVisualStyleBackColor = true;
            btn_SelectFlash.Click += btn_SelectFlash_Click;
            // 
            // l_FlashFile
            // 
            l_FlashFile.AutoSize = true;
            l_FlashFile.Location = new Point(117, 178);
            l_FlashFile.Name = "l_FlashFile";
            l_FlashFile.Size = new Size(100, 15);
            l_FlashFile.TabIndex = 9;
            l_FlashFile.Text = "No Flash Selected";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(334, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, aboutToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(116, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(116, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manufacturersToolStripMenuItem, brandsToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // manufacturersToolStripMenuItem
            // 
            manufacturersToolStripMenuItem.Name = "manufacturersToolStripMenuItem";
            manufacturersToolStripMenuItem.Size = new Size(151, 22);
            manufacturersToolStripMenuItem.Text = "Manufacturers";
            manufacturersToolStripMenuItem.Click += manufacturersToolStripMenuItem_Click;
            // 
            // brandsToolStripMenuItem
            // 
            brandsToolStripMenuItem.Name = "brandsToolStripMenuItem";
            brandsToolStripMenuItem.Size = new Size(151, 22);
            brandsToolStripMenuItem.Text = "Brands";
            brandsToolStripMenuItem.Click += brandsToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 261);
            Controls.Add(l_FlashFile);
            Controls.Add(btn_SelectFlash);
            Controls.Add(btn_Generate);
            Controls.Add(cb_brand);
            Controls.Add(label3);
            Controls.Add(cb_manufacturer);
            Controls.Add(label2);
            Controls.Add(tb_SKU);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Flash Generator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_SKU;
        private Label label2;
        private ComboBox cb_brand;
        private Label label3;
        private ComboBox cb_manufacturer;
        private Button btn_Generate;
        private Button btn_SelectFlash;
        private Label l_FlashFile;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem manufacturersToolStripMenuItem;
        private ToolStripMenuItem brandsToolStripMenuItem;
    }
}