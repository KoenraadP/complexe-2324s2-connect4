using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    // ieder veld moet de waarde
    // empty (leeg), red of yellow krijgen
    enum State
    {
        Empty,
        Red,
        Yellow
    }

    public partial class frmConnect4 : Form
    {
        // globale array maken met states
        // dit is ons code speelveld
        // 6 rijen, 7 kolommen
        State[,] grid = new State[6, 7];

        public frmConnect4()
        {
            InitializeComponent();
        }

        // methode om alle tokens te tonen op de juiste plaats
        private void ShowTokens()
        {
            // loop die alle rij indexen overloopt
            for (int row = 0; row < grid.GetLength(0); row++)
            {
                // tweede loop die alle kolom indexen overloopt
                for (int col = 0;  col < grid.GetLength(1); col++)
                {
                    // token aanmaken
                    Token t = new Token();
                    // standaard --> grijze tokens (vakjes)
                    t.BackColor = Color.LightGray;
                    // token op form plaatsen
                    Controls.Add(t);
                }
            }
        }

        // Load event --> wordt automatisch uitgevoerd
        // nadat form volledig ingeladen is
        private void frmConnect4_Load(object sender, EventArgs e)
        {
            ShowTokens();

            // nieuwe token maken
            // Token t = new Token();
            // locatie voor token bepalen
            // ClientSize.Width = breedte van het veld
            // ClientSize.Height = hoogte van het veld
            // t.Location = new Point(ClientSize.Width - t.Width, ClientSize.Height - t.Height);
            // token op form plaatsen
            // Controls.Add(t);

            // controleren wat er momenteel op de eerste plaats
            // van ons grid staat
            // Debug.WriteLine(grid[0, 0]);
        }
    }
}
