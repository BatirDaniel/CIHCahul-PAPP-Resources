namespace BiletulNR_18
{
    public partial class Form1 : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void btnNumere_Click_1(object sender, EventArgs e)
        {
            int a = int.Parse(tbxNumberOne.Text);
            int b = int.Parse(tbxNumberTwo.Text);
            try
            {
                if (tbxNumberOne.Text != "" && tbxNumberTwo.Text != "")
                {
                    while (a != b)
                    {
                        if (a > b)
                        {
                            a -= b;
                        }
                        else
                        {
                            b -= a;
                        }

                    }
                    lblRezultat.Text = "\t\tRezultat : \nCel mai mare divizor comun este : " + a.ToString();
                }
                else
                {
                    MessageBox.Show("Introduceti valori !");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}