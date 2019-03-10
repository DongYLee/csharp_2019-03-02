using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF290
{
    public partial class Form1 : Form
    {
        Random r = new Random(37);
        public Form1()
        {
            InitializeComponent();
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Depth");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        void TreeToList()
        {
            listView1.Items.Clear();
            foreach (TreeNode node in treeView1.Nodes)
            {
                TreeToList(node);
            }
        }

        void TreeToList(TreeNode node)
        {
            listView1.Items.Add(
                new ListViewItem(
                    new string[] {node.Text, node.FullPath.Count(f=>f=='\\').ToString() }));
            foreach (TreeNode n in node.Nodes)
            {
                TreeToList(n);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(r.Next().ToString());
            TreeToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("선택된 노드 없음.", "트리뷰테스트", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            treeView1.SelectedNode.Nodes.Add(r.Next().ToString());
            treeView1.SelectedNode.Expand();
            TreeToList();
        }
    }
}
