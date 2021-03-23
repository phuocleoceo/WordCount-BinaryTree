using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CountWord
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        /*-------------------------------------------------------------*/
        Tree root = null;
        BST bst= new BST() ;
        string FilePath = "";
        string result = "";
        string resultsave = "";
        int maxamount;
        private bool IsAlpha(char c)
        {
            if (c >= 'A' && c <= 'Z') return true;
            return false;
        }
        private void Handling()
        {
            int Count;
            int k = 0;
            string[] LINES = File.ReadAllText(FilePath).ToUpper().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            foreach (string Line in LINES)
            {
                string UniqueWord = "";
                for (int i = 0; i < Line.Length; i++)
                {
                    if (IsAlpha(Line[i]))
                    {
                        UniqueWord += Line[i];
                    }
                    if ( !IsAlpha(Line[i]) || i == Line.Length - 1)
                    {
                        Tree search = bst.Search(root, UniqueWord);
                        if (search == null)
                        {
                            if (k == maxamount) break;
                            if (String.Compare(UniqueWord, "") != 0)
                            {
                                k++;
                                root = bst.InsertNode(root, UniqueWord, 1);
                                UniqueWord = "";
                            }
                        }
                        else
                        {
                            Count = search.Count;
                            root = bst.DeleteNode(root, UniqueWord);
                            Count++;
                            root = bst.InsertNode(root, UniqueWord, Count);
                            UniqueWord = "";
                        }
                    }
                }
            }
        }
        private void ResetTree()
        {
            root = null;
            result = "";
            resultsave = "";
            dgvresult.DataSource = null;
            dgvresult.Rows.Clear();
        }
        private void LNR(Tree root)
        {
            if (root != null)
            {
                LNR(root.Left);
                result += root.Word + " " + root.Count.ToString() + " ";
                resultsave += String.Format("\t\t|\t{0,10}\t|\t{1}\t|\n", root.Word, root.Count);
                resultsave += "\t\t=========================================\n";
                LNR(root.Right);
            }
        }
        /*------------------------------------------------------------*/
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvresult.DefaultCellStyle.Font = new Font("Tahoma", 15);
            dgvresult.DefaultCellStyle.ForeColor = Color.Blue;
            dgvresult.DefaultCellStyle.BackColor = Color.Beige;   //Beige
            dgvresult.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            dgvresult.DefaultCellStyle.SelectionBackColor = Color.Black;
            dgvresult.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvresult.Hide();
        }
        private void btnopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Select Input File ";
            dlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtinput.Text = dlg.FileName;
                FilePath = dlg.FileName;
                ResetTree();  // Đọc file mới thì cần Cây mới
                btncount.Enabled = true;
                btnin.Enabled = true;
                btnin.PerformClick();
            }
            else
            {
                txtresult.Text = "Error ! Try again ";
            }
        }
        private void btncount_Click(object sender, EventArgs e)
        {   
            maxamount = Int32.Parse(txtamount.Text);
            Handling();
            btnout.Enabled = true;            
            LNR(root);
            btnout.PerformClick();           
                                 
            string[] RESULTS = result.Split(' '); 
            //result cuối có dấu " " nên split ra vẫn có , ta ko xét đến nó
            for (int i = 0; i < RESULTS.Length-1; i+=2)   
            {                
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvresult);
                row.Cells[0].Value = RESULTS[i];                
                row.Cells[1].Value = RESULTS[i+1];
                dgvresult.Rows.Add(row);
            }            
        }
        private void btnin_Click(object sender, EventArgs e)
        {
            txtresult.Show();
            dgvresult.Hide();
            label2.Show();
            pictureBox1.Show();
            pictureBox2.Show();
            StreamReader reader = new StreamReader(FilePath);
            txtresult.Text = reader.ReadToEnd();
        }
        private void btnout_Click(object sender, EventArgs e)
        {
            dgvresult.Show();
            txtresult.Hide();
            label2.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            btncount.Enabled = false;
            btnsave.Enabled = true;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            btnout.PerformClick();
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save Output";
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            save.FileName = "*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = save.OpenFile();
                StreamWriter sw = new StreamWriter(fileStream);
                sw.WriteLine("\t\t|\t\tWORD\t|\tCOUNT\t|");
                sw.WriteLine("\t\t=========================================");
                string[] ouput = resultsave.Split('\n');
                foreach (string i in ouput)
                {
                    sw.WriteLine(i.ToString());
                }
                sw.Close();
            }
        }
        private void textamount_TextChanged(object sender, EventArgs e)
        {   
            //thay đổi số lượng từ đếm thì ta cần empty lại từ đầu
            btncount.Enabled = true;
            ResetTree();
        }     
    }
}
