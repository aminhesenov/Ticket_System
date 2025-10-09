namespace Tickect_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           DialogResult r=MessageBox.Show("Cixmaq isteyirsiniz?", "Melumat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String a = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = a;
        }
        int n = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "" || comboBox2.Text == "" || textBox1.Text == "" || textBox2.Text == ""
                || textBox3.Text == "" || textBox4.Text == "" || maskedTextBox1.Text == "" ||
                maskedTextBox2.Text == "" || maskedTextBox3.Text == "")
            {
                MessageBox.Show("Verilen xanalari tam doldurun", "Melumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (comboBox1.Text == comboBox2.Text)
                {
                    MessageBox.Show("Eyni seherleri secmek olmaz", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    n++;
                    listBox1.Items.Add(n + ") " + "Haradan: " + comboBox1.Text + " " + " Haraya: " + comboBox2.Text + " " + " Tarix: " + maskedTextBox1.Text + " " + " Saat: " + maskedTextBox2.Text + " " + " Yer:" + textBox1.Text);
                }
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult d= MessageBox.Show("Bilet silinsin?", "Melumat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(d == DialogResult.Yes)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }
    }
}
