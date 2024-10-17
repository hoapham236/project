using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement_FinalProject
{
    public partial class CleanerMission : Form
    {
        Room room = new Room();
        Clean clean = new Clean();
        public CleanerMission()
        {
            InitializeComponent();
        }

        private void CleanerMission_Load(object sender, EventArgs e)
        {
            if (this.check == 1) // co nhiem vu moi
            {
                panelNotice.Visible = true;
                labelContent.Text = "Clean Room " + clean.getIdRoom(this.idCleaner);
            }
            else
            {
                labelCount.Text = "Empty";
                panelNotice.Visible = false;

            }

        }


        private void guna2ImageButtonChuaXong_Click(object sender, EventArgs e)
        {
            labelStatus.Text = "Not Done";
        }

        private void guna2ImageButtonDaXong_Click(object sender, EventArgs e)
        {
            labelStatus.Text = "Done";
            this.check = 0;

        }

        private void guna2ImageButtonSubmit_Click(object sender, EventArgs e)
        {
            if (labelStatus.Text == "Done")
            {
                if (room.updateRoom(clean.getIdRoom(this.idCleaner), "Blank"))
                    MessageBox.Show("Submit succussfully", "Mission", MessageBoxButtons.OK);
                if (clean.deleteClean(this.idCleaner))
                {

                }
                panelNotice.Visible = false;
                labelCount.Text = "Empty";
                
            }
            else if (labelStatus.Text == "Not Done")
            {
                if (room.updateRoom(clean.getIdRoom(this.idCleaner), "Not Cleaned"))
                    MessageBox.Show("Submit succussfully", "Mission", MessageBoxButtons.OK);
                if (clean.deleteClean(this.idCleaner))
                {

                }
                panelNotice.Visible = false;
                labelCount.Text = "Empty";
            }
            else
            {
                MessageBox.Show("Select done or not done", "Mission", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
