using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using DataObjects;

namespace PresentationLayer
{
    public partial class frmPlay : Form
    {
        private Equations _problemManager = new Equations();
        private string[] _problemMaker;
        private List<SavedGame> _savedgame = null; 
        private int Score;
        private string PlayerName;
        private int AnswerValue;
        public frmPlay(string playername)
        {
            InitializeComponent();
            //the returned items whould be in the order "Answer, fullproblem"

            btnSave.Visible = false;
            btnSave.Enabled = false;
            NextProblem();
            Score = 0;
            PlayerName = playername;
            lblPlayerName.Text = ("Player: " + PlayerName);
            lblScore.Text = ("Score: " + Score);
        }


        public frmPlay()
        {
            InitializeComponent();
            //the returned items whould be in the order "Score,PlayerName,VisualEquation,EquationAnswer"

            btnSave.Visible = false;
            btnSave.Enabled = false;


            try
            {
                _savedgame = _problemManager.FetchSavedGame();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.InnerException.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            lblPlayerName.Text = ("Player: " + _savedgame[0].Score);
            lblScore.Text = ("Score: " + _savedgame[0].ScoreHolder);
            lblEquation.Text = _savedgame[0].VisualEquation;
            AnswerValue = Int32.Parse(_savedgame[0].EquationAnswer);
        }


        public void NextProblem()
        {
            _problemMaker = _problemManager.ProblemNumbers();
            lblEquation.Text = _problemMaker[1];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnConfrim_Click(object sender, EventArgs e)
        {
            int PlayerAnswer = (int)numPlayerAnswer.Value;
            string Answer = _problemMaker[0];
            AnswerValue = Int32.Parse(Answer);
            if (PlayerAnswer == AnswerValue)
            {
                Score = Score+1;
                lblScore.Text = ("Score: " + Score);
                btnSave.Visible = true;
                btnSave.Enabled = true;
                NextProblem();
            }
            else
            {
                
                frmGameOver GameOverFrm = new frmGameOver();
                DialogResult result = GameOverFrm.ShowDialog();
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
