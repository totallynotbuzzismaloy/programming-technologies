using System.Collections.Generic;
using System.Windows.Forms;

namespace tp_8thLab
{
    public partial class secondForm : Form
    {

        public secondForm(Form f, List<string> list)
        {
            InitializeComponent();
            Text = "Чтобы вернуться обратно, закройте эту форму";
            f.Hide();
            listBox1.DataSource = list;
        }
    }
}