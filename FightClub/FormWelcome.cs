using System;
using System.Windows.Forms;

namespace FightClub
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void btnInputUserName_Click(object sender, EventArgs e)
        {
            FormFightBattle ifrm = new FormFightBattle();
            Data.ValueName = txtUserName.Text.ToString();
            this.Close(); // закрываем FormWelcome (this - текущая форма)
            ifrm.Show(); // отображаем FormFightClub
        }
    }
}
