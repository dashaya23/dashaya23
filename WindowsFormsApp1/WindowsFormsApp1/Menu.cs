using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Program.connection.Open();
            comboBoxFilter.Items.Add("Все производители");
            comboBoxFilter.SelectedIndex = 0;
            if(Program.userRole == null || (int)Program.userRole == 2 || (int)Program.userRole == 3)
            {
                buttonAdd.Visible = false;

                if(Program.userRole == null)
                {
                    labelFIO.Visible = false;
                }
                else if((int)Program.userRole == 3)
                {
                    buttonAdd.Visible = false;
                }
            }
            labelFIO.Text = $"{Program.userSurame} {Program.userName} {Program.userPatronymic}";

            var cmd = new NpgsqlCommand($"Select categoryname From category", Program.connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read()) 
            { 
                comboBoxFilter.Items.Add(reader.GetString(0));
            }
            reader.Close();
            cmd.Cancel();
        }

        private void FillMyPanel()
        {
            flowLayoutPanelProduct.Controls.Clear();
            int count = 0;
            string filter = string.Empty;
            if(comboBoxFilter.Items.Count > 0) 
            {
                filter = $"AND product.productmanufid = '{comboBoxFilter.SelectedIndex}'";
            }
            string sort = string.Empty;
            if(radioButtonASC.Checked) { sort = "ASC"; }
            else { sort = "DESC"; }
            string querty = $"SELECT *, manufname FROM product, manuf Where (productname LIKE '' or productdesc LIKE '') AND (product.productmanufid = manuf.manufid " + filter +") ORDER BY productcost " + sort;
            NpgsqlCommand cmd = new NpgsqlCommand(querty, Program.connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Panel Product = new Panel();
                Product.Name = reader.GetValue(0).ToString();
                Product.Size = new Size(986, 123);
                Product.BorderStyle = BorderStyle.FixedSingle;
                Product.Cursor = Cursors.Hand;
                
                PictureBox picture = new PictureBox();
                picture.Size = new Size(125, 89);
                picture.Location = new Point(10, 17);
                picture.SizeMode = PictureBoxSizeMode.AutoSize;
                string part = reader["productfoto"].ToString();
                if(part == null)
                {
                    picture.Image = Properties.Resources.picture;
                }
                else
                {
                    part = Environment.CurrentDirectory + "\\Товар_import\\" + reader["productfoto"].ToString();
                    picture.Load(part);
                }
                Product.Controls.Add(picture);

                Label productname = new Label();
                productname.Name = reader.GetValue(0).ToString();
                productname.Size = new Size(71, 19);
                productname.Location = new Point(195, 17);
                productname.Font = new Font("Comic Sans MS", 10);
                productname.Text = reader["productname"].ToString();
                Product.Controls.Add(productname);


                Label productdesc = new Label();
                productdesc.Name = reader.GetValue(0).ToString();
                productdesc.Size = new Size(587, 19);
                productdesc.Location = new Point(199, 56);
                productdesc.Font = new Font("Comic Sans MS", 10);
                productdesc.Text = $"{reader["productdesc"].ToString()}\n" +
                    $"Производитель: {reader["manufname"].ToString()}\n" +
                    $"Цена: {reader["productcost"].ToString()}\n";
                Product.Controls.Add(productdesc);

                Label productquan = new Label();
                productquan.Name = reader.GetValue(0).ToString();
                productquan.Size = new Size(71, 19);
                productquan.Location = new Point(195, 17);
                productquan.Font = new Font("Comic Sans MS", 10);
                if(reader.GetInt32(9)>0)
                {
                    productquan.Text = "Есть на складе";
                    Product.BackColor = Color.White;
                }
                else
                {
                    productquan.Text = "Нет на складе";
                    Product.BackColor = Color.Gray;
                }
                Product.Controls.Add(productquan);
                Product.Click += Product_Click;
                count++;
                flowLayoutPanelProduct.Controls.Add(Product);
            }
            reader.Close();
            cmd.Cancel();

            var cmdCount = new NpgsqlCommand("Select count(*) from product", Program.connection);
            int count1 = Convert.ToInt32(cmdCount.ExecuteScalar());
            labelCount.Text = count + " из " + count1;
            cmdCount.Cancel();
        }

        private void Product_Click(object sender, EventArgs e)
        {
            foreach(var control in flowLayoutPanelProduct.Controls)
            {
                ((Panel)control).BackColor = Color.White;
            }
            int num = Convert.ToInt32(((Panel)sender).Name);
            ((Panel)sender).BackColor = Color.White;
            if((int)Program.userRole == 1)
            {
                Update form = new Update(num);
                form.Tag = this;
                form.Show();
            }
        }

        private void buttonNaz_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Вы действительно хотите выйти?", "Выйти", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                FormUser form = new FormUser();
                Program.connection.Close();
                form.Show();
                this.Close();
            }
        }
    }
}
