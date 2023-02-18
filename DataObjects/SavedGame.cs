using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataObjects
{
    public class SavedGame
    {

        // human readable display data for the list view
        public string Score { get; set; }
        public string ScoreHolder { get; set; }

        public string VisualEquation { get; set; }
        public string EquationAnswer { get; set; }



    }
}
