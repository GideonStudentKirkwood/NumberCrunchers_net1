using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;
using System.IO;

namespace DataAccessLayer
{
    public class numberDataAccessor
    {
        public static List<ScoreData> RetrieveScoreDataList()
        {
            // start with the return type
            List<ScoreData> scorelist = new List<ScoreData>();

            char[] separator = { ',' };

            try
            {
                StreamReader fileReader = new StreamReader(AppData.DataPath + "\\" + AppData.HighScore);
                while (fileReader.EndOfStream == false)
                {
                    
                    string line = fileReader.ReadLine();
                    string[] parts;
                    if (line.Length > 4) // minimum for out data
                    {
                        parts = line.Split(separator);

                        if (parts.Count() == 2)
                        {
                            ScoreData newScoreData = new ScoreData();
                            newScoreData.Score = parts[0];
                            newScoreData.ScoreHolder = parts[1];

                            scorelist.Add(newScoreData);
                        }
                    }
                }
                fileReader.Close();
            }
            catch (Exception up)
            {
                throw up;
            }
            return scorelist;
        } // end of RetrieveScoreDataList

        public static List<SavedGame> RetrieveSavedGame()
        {
            // start with the return type
            List<SavedGame> savedgame = new List<SavedGame>();

            char[] separator = { ',' };

            try
            {
                StreamReader fileReader = new StreamReader(AppData.DataPath + "\\" + AppData.SavedGame);
                while (fileReader.EndOfStream == false)
                {

                    string line = fileReader.ReadLine();
                    string[] parts;
                    if (line.Length > 4) // minimum for out data
                    {
                        parts = line.Split(separator);

                        if (parts.Count() == 4)
                        {
                            SavedGame newSavedGame = new SavedGame();
                            newSavedGame.Score = parts[0];
                            newSavedGame.ScoreHolder = parts[1];
                            newSavedGame.VisualEquation = parts[2];
                            newSavedGame.EquationAnswer = parts[3];

                            savedgame.Add(newSavedGame);
                        }
                    }
                }
                fileReader.Close();
            }
            catch (Exception up)
            {
                throw up;
            }
            return savedgame;
        }//end of RetrieveSavedGame
    }
}
