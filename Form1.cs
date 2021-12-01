namespace WinFormsControlesDinamicos
{
    public partial class Form1 : Form
    {
        Button btn;

        public Form1()
        {
            InitializeComponent();

            Button btn = new Button();
            btn.Text = "Clique";
            btn.Width = 200;
            btn.Click += Btn_Click;

            button1.Click += Button1_Click;

            panel1.Controls.Add(btn);

            int? x = null;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("metodo dinamico de um botão estatico");
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("metodo dinamico de um botão dinamico");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn = new Button();
            btn.Text = txbTexto.Text;
            btn.Location = new Point(int.Parse(txbX.Text), int.Parse(txbY.Text));
            btn.Size = new System.Drawing.Size(60, 60);
            //btn.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            //btn.AutoSize = true;
            this.Controls.Add(btn);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(btn);
        }
    }
}