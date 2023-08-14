using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_7thLab
{
  public partial class Form1 : Form
  {
    private static int amountFox = 1;
    private static string warningMessage1 = $"имя пользователя не должно содержать запрещенные символы: space, !, {'"'}, #, $, %, &, (), *, +, ', -, .,/, ?, @";
    private static string warningMessage2 = "пожалуйста, введите имя пользователя";
    private string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=myBDlab7.mdb;";
    //private string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=myBDlab7.mdb;";
    private OleDbConnection myConnection;
    private int selectedIndex;
    private List<int> bdIndexList = new List<int>();
    
    public Form1()
    {
      InitializeComponent();
      //textBox1.Text = "standardName";
      
    }


    private void buttonStart_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(textBox1.Text))
      {
        var _foxes = new Foxes(this, amountFox, textBox1.Text);
        myWarningMessage.ForeColor = Color.Black;
        myWarningMessage.Text = string.Empty;
        _foxes.FormClosed += (object s, FormClosedEventArgs ev) => { Show(); };
        _foxes.ShowDialog();
        _foxes.Close();
        textBox1.Clear();
      }
      else
      {
        var colorInit = Color.Red;
        myWarningMessage.ForeColor = colorInit;
        myWarningMessage.Text = warningMessage2;
      }
    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {
      amountFox = Convert.ToInt32(numericUpDown1.Value);
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == (int)Keys.Space || (e.KeyChar > 32 && e.KeyChar <= 47) || e.KeyChar == 63 || e.KeyChar == 64)
      {
        e.Handled = true;
        var colorInit = Color.Red;
        myWarningMessage.ForeColor = colorInit;
        myWarningMessage.Text = warningMessage1;
      }
    }
    

    private void usersTable_Click(object sender, EventArgs e)
    {
      myConnection = new OleDbConnection(connectString);
      myConnection.Open();
      listBox1.Enabled = true;
      listBox1.Visible = true;
      showData.Visible = true;
      showData.Enabled = true;
      deleteSelectedData.Enabled = true;
      deleteSelectedData.Visible = true;
      moveBack.Enabled = true;
      moveBack.Visible = true;
      
      label1.Visible = false;
      numericUpDown1.Enabled = false;
      numericUpDown1.Visible = false;
      label2.Visible = false;
      textBox1.Enabled = false;
      textBox1.Visible = false;
      myWarningMessage.Visible = false;
      buttonStart.Enabled = false;
      buttonStart.Visible = false;
      usersTable.Visible = false;
      usersTable.Enabled = false;
    }

    private void moveBack_Click(object sender, EventArgs e)
    {
      listBox1.Items.Clear();
      listBox1.Enabled = false;
      listBox1.Visible = false;
      showData.Visible = false;
      showData.Enabled = false;
      deleteSelectedData.Enabled = false;
      deleteSelectedData.Visible = false;
      moveBack.Enabled = false;
      moveBack.Visible = false;
      
      label1.Visible = true;
      numericUpDown1.Enabled = true;
      numericUpDown1.Visible = true;
      label2.Visible = true;
      textBox1.Enabled = true;
      textBox1.Visible = true;
      myWarningMessage.Visible = true;
      buttonStart.Enabled = true;
      buttonStart.Visible = true;
      usersTable.Visible = true;
      usersTable.Enabled = true;
      myConnection.Close();
    }

    private void showData_Click(object sender, EventArgs e)
    {
      string query = "SELECT user_name, mouse_clicks, fox_amount, user_ID FROM players ORDER BY user_ID";
      var command = new OleDbCommand(query, myConnection);
      var myReader = command.ExecuteReader();
      listBox1.Items.Clear();
      bdIndexList.Clear();
      while (myReader.Read())
      {
        listBox1.Items.Add($"user: {myReader[0]} mouse clicks: {myReader[1]} fox amount: {myReader[2]}");
        bdIndexList.Add(Convert.ToInt32(myReader[3]));
      }
      myReader.Close();
    }

    private void deleteSelectedData_Click(object sender, EventArgs e)
    {
      try
      {
        if (listBox1.Items.Count != 0)
        {
          string query = $"DELETE FROM players WHERE user_ID = {bdIndexList[selectedIndex]}";
          var command = new OleDbCommand(query, myConnection);
          command.ExecuteNonQuery();
          listBox1.Items.RemoveAt(selectedIndex);
        }
      }
      catch (Exception error)
      {
        var title = "An error has been occured";
        MessageBox.Show(error.ToString(), title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      selectedIndex = listBox1.SelectedIndex;
    }
  }
}
