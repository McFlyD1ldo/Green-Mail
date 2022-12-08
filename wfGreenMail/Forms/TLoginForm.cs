using clMailer;
using wfGreenMail.Forms;

namespace wfGreenMail
{
    public partial class TLoginForm : Form
    {
        static Mailer mailer = new();

        public List<Provider> providerList = new()
        {
           new Provider("", 0, ""), new Provider("smtp.gmail.com", 587, "Gmail"), new Provider("smtp.live.com", 465, "Hotmail"), new Provider("smtp.ethereal.email", 587, "Ethereal")
        };
        public TLoginForm()
        {
            InitializeComponent();
            cbProvider.DataSource = providerList;
            cbProvider.DisplayMember = "Name";
            cbProvider.ValueMember = "Host";
            cbProvider.SelectedIndex = 0;
            cbProvider.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mailer.Username = edtUser.Text;
            Mailer.Password = edtPass.Text;
            if (!mailer.Authenticate())
            {
                MessageBox.Show("Either your username or password is incorrect");
            }
            else
            {
                TMainForm mainForm = new(mailer);
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!mailer.establishConnection(cbProvider.SelectedValue.ToString(), 587))
            {
                MessageBox.Show("SMTP Connection failed");
            }
            else
            {
                MessageBox.Show("SMTP Connection established");
            };
        }

        //destructor
        ~TLoginForm()
        {
            Mailer.client.Disconnect(true);
        }

        private void edtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                button1_Click(null, null);
            }
        }

        private void edtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                edtPass.Focus();
            }
        }
    }
}