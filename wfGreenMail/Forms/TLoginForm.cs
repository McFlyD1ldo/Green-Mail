using clMailer;
using wfGreenMail.Forms;

namespace wfGreenMail
{
    public partial class TLoginForm : Form
    {
        static Mailer mailer = new();

        public List<Provider> providerList = new()
        {
            new Provider("smtp.gmail.com", 587, "Gmail"), new Provider("smtp.live.com", 587, "Hotmail")
        };
        public TLoginForm()
        {
            InitializeComponent();
            comboBox1.DataSource = providerList;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Host";
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mailer.Username = textBox1.Text;
            Mailer.Password = textBox2.Text;
            if (!mailer.Authenticate())
            {
                MessageBox.Show("Either your username or password is incorrect");
            }
            else
            {
                if(MessageBox.Show("Login successful. \n" + " Click ok to continue!", "", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    TMainForm mainForm = new(mailer);
                    this.Hide();
                    mainForm.Show();
                    this.Show();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (!mailer.establishConnection(comboBox1.SelectedValue.ToString(), 587))
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
        
    }
}