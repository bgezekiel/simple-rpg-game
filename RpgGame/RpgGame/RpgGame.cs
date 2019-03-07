using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Author: Brandon Ezekiel
 * Project: Simple RPG Game
 * Main class
 */

namespace RpgGame
{
    public partial class RpgGame : Form
    {
        private Player _player;

        public RpgGame()
        {
            InitializeComponent();

            _player = new Player(10, 10, 20, 0, 1); // instantiate new player object

            // print player values to labels
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExp.Text = _player.Experience.ToString();
            lblLevel.Text = _player.Level.ToString();

        }

    }
}
