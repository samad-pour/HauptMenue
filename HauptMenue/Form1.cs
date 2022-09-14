using static System.Net.Mime.MediaTypeNames;

namespace HauptMenue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripComboBox1.SelectedIndex = 0;
        }

        private void menuItem_Clicked(object sender, EventArgs e)
        {
            //var itemText = (sender as ToolStripMenuItem).Text;
            var itemName = (sender as ToolStripMenuItem).Name;
            lblDisplay.Text = itemName;

            switch (itemName)
            {
                case "neuToolStripMenuItem":
                    MessageBox.Show(itemName);
                    break;

                case "speichernToolStripMenuItem":
                    MessageBox.Show(itemName);
                    break;

                case "endeToolStripMenuItem":
                    Close();
                    break;

                case "mnuGelb":
                    mnuGelb.Checked = true;
                    mnuBlau.Checked = false;
                    mnuRot.Checked = false;
                    this.BackColor = Color.Yellow;
                    break;

                case "mnuBlau":
                    mnuGelb.Checked = false;
                    mnuBlau.Checked = true;
                    mnuRot.Checked = false;
                    this.BackColor = Color.Blue;
                    break;

                case "mnuRot":
                    mnuGelb.Checked = false;
                    mnuBlau.Checked = false;
                    mnuRot.Checked = true;
                    this.BackColor = Color.Red;
                    break;

                case "mnuArial":
                    mnuArial.Checked = true;
                    this.Font = new Font("Arial Nova Light", this.Font.Size);
                    MessageBox.Show("Arial Nova Light");
                    break;
            }
        }

    }
}