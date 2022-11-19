namespace WinFormsControlsBaseProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello " + textBox1.Text);
            textBox1.Text += "Hello world ";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked) 
            {
                MessageBox.Show("Check");
            }
            else
                MessageBox.Show("Uncheck");
        }
    }
}