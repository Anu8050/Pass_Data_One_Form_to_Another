namespace Pass_Data_One_Form_to_Another
{
    partial class Form15
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
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.firstItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thirdItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subThridItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fouthItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "ShowContextMenu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstItemToolStripMenuItem,
            this.secondItemToolStripMenuItem,
            this.thirdItemToolStripMenuItem,
            this.fouthItemToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 132);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // firstItemToolStripMenuItem
            // 
            this.firstItemToolStripMenuItem.Name = "firstItemToolStripMenuItem";
            this.firstItemToolStripMenuItem.Size = new System.Drawing.Size(184, 32);
            this.firstItemToolStripMenuItem.Text = "First Item";
            // 
            // secondItemToolStripMenuItem
            // 
            this.secondItemToolStripMenuItem.Name = "secondItemToolStripMenuItem";
            this.secondItemToolStripMenuItem.Size = new System.Drawing.Size(184, 32);
            this.secondItemToolStripMenuItem.Text = "Second Item";
            // 
            // thirdItemToolStripMenuItem
            // 
            this.thirdItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subThridItemToolStripMenuItem});
            this.thirdItemToolStripMenuItem.Name = "thirdItemToolStripMenuItem";
            this.thirdItemToolStripMenuItem.Size = new System.Drawing.Size(184, 32);
            this.thirdItemToolStripMenuItem.Text = "Third Item";
            // 
            // subThridItemToolStripMenuItem
            // 
            this.subThridItemToolStripMenuItem.Name = "subThridItemToolStripMenuItem";
            this.subThridItemToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.subThridItemToolStripMenuItem.Text = "Sub Thrid Item";
            // 
            // fouthItemToolStripMenuItem
            // 
            this.fouthItemToolStripMenuItem.Name = "fouthItemToolStripMenuItem";
            this.fouthItemToolStripMenuItem.Size = new System.Drawing.Size(184, 32);
            this.fouthItemToolStripMenuItem.Text = "Fouth Item";
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Name = "Form15";
            this.Text = "Form15";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem firstItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thirdItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subThridItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fouthItemToolStripMenuItem;
    }
}