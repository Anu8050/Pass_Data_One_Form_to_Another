using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pass_Data_One_Form_to_Another
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuStrip MainMenu = new MenuStrip();
            MainMenu.BackColor = Color.OrangeRed;
            MainMenu.ForeColor = Color.Black;
            MainMenu.Text ="File Menu";
            this.MainMenuStrip = MainMenu;
            Controls.Add(MainMenu);
            MainMenu.Name = "MainMenu";
            MainMenu.Dock = DockStyle.Left;
            this.Controls.Add(MainMenu);
            ToolStripMenuItem FileMenu = new ToolStripMenuItem("File");
            FileMenu.ForeColor = Color.Black;
            FileMenu.Text = " Menu";
            FileMenu.TextAlign = ContentAlignment.BottomRight;
            FileMenu.ToolTipText = "Click Me";
            MainMenu.Items.Add(FileMenu);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void hiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            TreeNode node = treeView1.Nodes.Add("root", "Government Space Agencies");

            // Add child node
            TreeNode sub_node = node.Nodes.Add("country", "Country");

            // Add sub nodes
            sub_node.Nodes.Add("usa", "United States").Nodes.Add("nasa", "National Aeronautics and Space Administration (NASA)");
            sub_node.Nodes.Add("chn", "China").Nodes.Add("cnsa", "China National Space Administration (CNSA)");
            sub_node.Nodes.Add("jpn", "Japan").Nodes.Add("jaxa", "Japan Aerospace Exploration Agency (JAXA)");
            sub_node.Nodes.Add("ind", "India").Nodes.Add("isro", "Indian Space Research Organization (ISRO)");
            sub_node.Nodes.Add("rus", "Russia").Nodes.Add("rfsa", "Russian Federal Space Agency (RFSA)");

            sub_node.Nodes.Add("dummy-node", "Dummy Node");

            // -- Remove dummy node(s)

            // This will not remove the dummy-node, because it is not in this Nodes collection
            treeView1.Nodes.RemoveByKey("dummy-node");

            // Find for the dummy node & remove it
            treeView1.Nodes.Find("dummy-node", true)[0].Remove();

            // Expand all nodes
            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            label1.Text = e.Node.Text;
        }
    }
}
