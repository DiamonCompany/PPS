using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPS
{
    public partial class Authorization : Form
    {
        private MainGUI father;
        private bool bRegistry;
        public Authorization(MainGUI newFather)
        {
            InitializeComponent();
            father = newFather;
            bRegistry = false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_Login.Text != "")
            {
                father.Text += " - " + tb_Login.Text;
                this.Close();
            }
            else
                MessageBox.Show("Неверное имя пользователя");
        }

        private void btn_registry_Click(object sender, EventArgs e)
        {
            bRegistry = !bRegistry;
            if (bRegistry == true)
            {
                for (int i = 0; i < 120; i++)
                    this.Height++;
                btn_login.Top += 120;
                btn_registry.Top += 120;
                btn_registry.Text = "Отмена";
                createRegistry();
            }
            else
            {
                for (int i = 0; i < 120; i++)
                    this.Height--;
                btn_login.Top -= 120;
                btn_registry.Top -= 120;
                btn_registry.Text = "Регистрация";
                deleteRegistry();
            }
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
