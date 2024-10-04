using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        DataTable table = new DataTable("table");
        int index;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (namecombo.SelectedItem.ToString() == "Latte")
            {
                if (typecombo.SelectedItem.ToString() == "Frapp")
                {
                    idtext.Text = (int.Parse(idtext.Text)).ToString();
                    paytext.Text = (float.Parse(quantitycombo.Text) * 900).ToString();
                    textBox2.Text = (float.Parse(quantitycombo.Text) * 900).ToString();
                    MessageBox.Show("ITEMS ADDED SUCCESSFULLY!");
                }

                if (typecombo.SelectedItem.ToString() == "Ice")
                {
                    idtext.Text = (int.Parse(idtext.Text)).ToString();
                    paytext.Text = (float.Parse(quantitycombo.Text) * 700).ToString();
                    textBox2.Text = (float.Parse(quantitycombo.Text) * 700).ToString();
                    MessageBox.Show("ITEMS ADDED SUCCESSFULLY!");
                }

                if (typecombo.SelectedItem.ToString() == "Hot")
                {
                    idtext.Text = (int.Parse(idtext.Text)).ToString();
                    paytext.Text = (float.Parse(quantitycombo.Text) * 500).ToString();
                    textBox2.Text = (float.Parse(quantitycombo.Text) * 500).ToString();
                    MessageBox.Show("ITEMS ADDED SUCCESSFULLY!");
                }



                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quantitycombo.Text, paytext.Text);

            }


            

            if (namecombo.SelectedItem.ToString() == "Chappuccino")
            {
                if (typecombo.SelectedItem.ToString() == "Frapp")
                {
                    idtext.Text = (int.Parse(idtext.Text)).ToString();
                    paytext.Text = (float.Parse(quantitycombo.Text) * 1200).ToString();
                    textBox2.Text = (float.Parse(quantitycombo.Text) * 1200).ToString();
                    MessageBox.Show("ITEMS ADDED SUCCESSFULLY!");
                }

                if (typecombo.SelectedItem.ToString() == "Ice")
                {
                    idtext.Text = (int.Parse(idtext.Text)).ToString();
                    paytext.Text = (float.Parse(quantitycombo.Text) * 850).ToString();
                    textBox2.Text = (float.Parse(quantitycombo.Text) * 850).ToString();
                    MessageBox.Show("ITEMS ADDED SUCCESSFULLY!");
                }

                if (typecombo.SelectedItem.ToString() == "Hot")
                {
                    idtext.Text = (int.Parse(idtext.Text)).ToString();
                    paytext.Text = (float.Parse(quantitycombo.Text) * 650).ToString();
                    textBox2.Text = (float.Parse(quantitycombo.Text) * 650).ToString();
                    MessageBox.Show("ITEMS ADDED SUCCESSFULLY!");
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quantitycombo.Text, paytext.Text);

            }



            if (namecombo.SelectedItem.ToString() == "Chocolate")
            {
                if (typecombo.SelectedItem.ToString() == "Frapp")
                {
                    idtext.Text = (int.Parse(idtext.Text)).ToString();
                    paytext.Text = (float.Parse(quantitycombo.Text) * 450).ToString();
                    textBox2.Text = (float.Parse(quantitycombo.Text) * 450).ToString();
                    MessageBox.Show("ITEMS ADDED SUCCESSFULLY!");
                }

                if (typecombo.SelectedItem.ToString() == "Ice")
                {
                    idtext.Text = (int.Parse(idtext.Text)).ToString();
                    paytext.Text = (float.Parse(quantitycombo.Text) * 725).ToString();
                    textBox2.Text = (float.Parse(quantitycombo.Text) * 725).ToString();
                    MessageBox.Show("ITEMS ADDED SUCCESSFULLY!");
                }

                if (typecombo.SelectedItem.ToString() == "Hot")
                {
                    idtext.Text = (int.Parse(idtext.Text)).ToString();
                    paytext.Text = (float.Parse(quantitycombo.Text) * 630).ToString();
                    textBox2.Text = (float.Parse(quantitycombo.Text) * 630).ToString();
                    MessageBox.Show("ITEMS ADDED SUCCESSFULLY!");
                }


                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quantitycombo.Text, paytext.Text);

            }


        }
        private void idtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idtext.Text = "";
            namecombo.Text = "";
            typecombo.Text = "";
            quantitycombo.Text = "";
            paytext.Text = "";
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void idtext_TextChanged(object sender, EventArgs e)
        {
            idtext.Enabled = true;
        }

        private void namecombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cofeeShopDataSet.Coffee' table. You can move, or remove it, as needed.
            //this.coffeeTableAdapter.Fill(this.cofeeShopDataSet.Coffee);

        }

        private void paytext_TextChanged(object sender, EventArgs e)
        {
            paytext.Enabled = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = false;

        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            int Cash, Amount, Change;
           

            Cash = int.Parse(textBox1.Text);
            Amount = int.Parse(textBox2.Text);

            Change = Cash - Amount;

            
            textBox3.Text = Change.ToString();
            textBox3.Enabled = false;
            


           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            idtext.Text = row.Cells[0].Value.ToString();
            namecombo.Text = row.Cells[1].Value.ToString();
            typecombo.Text = row.Cells[2].Value.ToString();
            quantitycombo.Text = row.Cells[3].Value.ToString();
            paytext.Text = row.Cells[4].Value.ToString();

        }
            




        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2TKRES9;Initial Catalog=CofeeShop;Integrated Security=True");
                for(int i = 0; i<dataGridView1.Rows.Count-1;i++)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO Coffee([ServiceId],[CoffeeName],[CoffeeType],[Quantity],[Amount]) VALUES ('" + dataGridView1.Rows[i].Cells[0].Value+ "','"+dataGridView1.Rows[i].Cells[1].Value+"','"+dataGridView1.Rows[i].Cells[2].Value+"','"+dataGridView1.Rows[i].Cells[3].Value+"','"+dataGridView1.Rows[i].Cells[4].Value+"')",con);
                    
                        
                        cmd.ExecuteNonQuery();
                        con.Close();
                       
                }
                MessageBox.Show("Successfully saved");
              dataGridView1.Rows.Clear();
            }

        private void button7_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView1.Rows[index];
            newdata.Cells[0].Value = idtext.Text;
            newdata.Cells[1].Value = namecombo.Text;
            newdata.Cells[2].Value = typecombo.Text;
            newdata.Cells[3].Value = quantitycombo.Text;
            newdata.Cells[4].Value = paytext.Text;
            MessageBox.Show("Successfully updated");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
            MessageBox.Show("Successfully Deleted");
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       
            }
        

       
        }
 

