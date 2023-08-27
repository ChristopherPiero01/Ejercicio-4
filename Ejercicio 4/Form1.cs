namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(this.cantA.Text);
            int b = int.Parse(this.cantB.Text);
            int c = int.Parse(this.cantC.Text);

            int min = (a * 5 + b * 8 + c * 6)/60;
            int minres = a % 5 + b % 8 + c % 6;
            HyM.Text = min.ToString()+" horas y"+minres.ToString()+" minutos";
        }
    }
}