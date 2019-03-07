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

namespace RpgGame
{
    public partial class RpgGame : Form
    {
        private Player _player;

        public RpgGame()
        {
            InitializeComponent();

            _player = new Player();

            _player.CurrentHitPoints = 10;
            _player.MaxHitPoints = 10;
            _player.Gold = 20;
            _player.Experience = 0;
            _player.Level = 1;

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExp.Text = _player.Experience.ToString();
            lblLevel.Text = _player.Level.ToString();

        }

    }
}
