using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acts
{
    public partial class loginForm : Form
    {
        public Roles Role { get; private set; }
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlManager.Connect("fromTextBox", "fromTextBox");
                Role = SqlManager.GetCurrentRole();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}
