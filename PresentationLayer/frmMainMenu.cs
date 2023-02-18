using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataObjects;
using LogicLayer;

namespace PresentationLayer
{
    public partial class frmMainMenu : Form
    {
        private Equations _equationManager = new Equations();
        private List<ScoreData> _scoreDataList = null;
        public frmMainMenu()
        {
            InitializeComponent();
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (txtPlayerName.Text == "")
            {
                MessageBox.Show("You need to enter a player name.", "Missing Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPlayerName.Focus();
                return;
            }
            else
            {

                //open frmPlay
                frmPlay playForm = new frmPlay(txtPlayerName.Text);
                DialogResult result = playForm.ShowDialog();
            }
        }//play:

        private void btnRules_Click(object sender, EventArgs e)
        {
            frmRules rulesForm = new frmRules();
            DialogResult result = rulesForm.ShowDialog();
        }//Rules:

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Really quit?\n\nAre you sure you are done here?", "Close Program", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }//Quit:

        private void btnContinue_Click(object sender, EventArgs e)
        {
            
            frmPlay playForm = new frmPlay();
            DialogResult result = playForm.ShowDialog();
        }//continue: 

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                _scoreDataList = _equationManager.FetchScoreDataList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.InnerException.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            displayScore();
            
        }//Main Menu Load:
        private void displayScore()
        {
            
            lblHighScore.Text = ("High Score: " + _scoreDataList[0].Score + "\n\n" + "Score Holder: " + _scoreDataList[0].ScoreHolder);

        }
    }
    
}

