namespace lab67
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelResult.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double val1 = Convert.ToDouble(textBox1.Text);
                double val2 = Convert.ToDouble(textBox2.Text);
                double val3 = Convert.ToDouble(textBox3.Text);
                double val4 = Convert.ToDouble(textBox4.Text);
                double val5 = Convert.ToDouble(textBox5.Text);

                labelResult.Text = "Результат: " + string.Format("{0:f1}", ((val1 + val2) * val5 / (val4 - val3)));
                labelResult.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}