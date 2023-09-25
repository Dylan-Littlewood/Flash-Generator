namespace FlashGenerator
{
    partial class Edit
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
            lb_Edit = new ListBox();
            l_Title = new Label();
            SuspendLayout();
            // 
            // lb_Edit
            // 
            lb_Edit.FormattingEnabled = true;
            lb_Edit.ItemHeight = 15;
            lb_Edit.Items.AddRange(new object[] { "ASUS", "MSI", "ASROCK", "GIGABYTE" });
            lb_Edit.Location = new Point(12, 61);
            lb_Edit.Name = "lb_Edit";
            lb_Edit.Size = new Size(176, 49);
            lb_Edit.TabIndex = 0;
            // 
            // l_Title
            // 
            l_Title.AutoSize = true;
            l_Title.Location = new Point(12, 23);
            l_Title.Name = "l_Title";
            l_Title.Size = new Size(29, 15);
            l_Title.TabIndex = 1;
            l_Title.Text = "Title";
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(l_Title);
            Controls.Add(lb_Edit);
            Name = "Edit";
            Text = "Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lb_Edit;
        private Label l_Title;
    }
}