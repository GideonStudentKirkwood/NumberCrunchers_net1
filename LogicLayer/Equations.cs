using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataObjects;

namespace LogicLayer
{

    public class Equations
    {

        public string[] ProblemNumbers()
        {
            Random random = new Random();
            int valueone = random.Next(1, 11);
            string firstnumber = valueone.ToString();
            int valuetwo = random.Next(1, 11);
            string secondnumber = valuetwo.ToString();
            int symbolfinder = random.Next(1, 4);
            string fullproblem;
            string Answer;
            if (symbolfinder==1)
            {
               fullproblem = (firstnumber + " + " + secondnumber);
               int AnswerValue = valueone + valuetwo;
               Answer = AnswerValue.ToString();
            }
            else if(symbolfinder==2)
            {
                fullproblem = (firstnumber + " - " + secondnumber+" =");
                int AnswerValue = valueone - valuetwo;
                Answer = AnswerValue.ToString();
            }
            else
            {
                fullproblem = (firstnumber + " * " + secondnumber);
                int AnswerValue = valueone * valuetwo;
                Answer = AnswerValue.ToString();
            }

            string[] x = new string[] {Answer, fullproblem};


            return x;
        } //Problem generator: still needs to be upgraded to increase difficulty

        public List<ScoreData> FetchScoreDataList()
        {
            List<ScoreData> scoredataList = null;

            try
            {
                scoredataList = numberDataAccessor.RetrieveScoreDataList();
            }
            catch (Exception ex)
            {
                // rewrap exception
                throw new ApplicationException("Your data could not be retrieved.", ex);
            }

            return scoredataList;
        }//High score fetching

        public List<SavedGame> FetchSavedGame()
        {
            List<SavedGame> savedgame = null;
            
            try
            {
                savedgame = numberDataAccessor.RetrieveSavedGame();
            }
            catch (Exception ex)
            {
                // rewrap exception
                throw new ApplicationException("Your data could not be retrieved.", ex);
            }

            return savedgame;
        }//saved game



    }
}
