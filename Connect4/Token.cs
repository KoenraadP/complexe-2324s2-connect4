using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    // overerven van Panel om achtergrondkleur, grootte, ... te kunnen instellen
    internal class Token : Panel
    {
        // constructor met basis waarden voor een token
        public Token()
        {
            // grootte 50 op 50 pixels
            Height = 50;
            Width = Height;
            // achtergrondkleur standaard op rood zetten
            BackColor = Color.Red;
        }
    }
}
