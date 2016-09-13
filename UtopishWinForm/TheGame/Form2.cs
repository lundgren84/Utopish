using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YtopishWinForm;

namespace TheGame
{
    public partial class Form2 : Form
    {
        Account Acc = StaticShit.acc;
        public Form2()
        {
            InitializeComponent();
            LoadAccount();
            RefreshGame();        
        }

        private void LoadAccount()
        {
            Acc.Location = "Im here!";
            Acc.Power = 19929;
            Acc.Size = 45;    
        }

        private void RefreshGame()
        {
            txtKDName.Text = Acc.Username;
            txtPower.Text = Acc.Power.ToString();
            txtLocation.Text = Acc.Location;
            txtSize.Text = Acc.Size.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnTroopTrain_Click(object sender, EventArgs e)
        {
            int shopKnight = (int)numKnight.Value;
            int shopArcher = (int)numArcher.Value;
            int shopHorse = (int)numHorse.Value;


            Acc.archer.quantity += shopArcher;
            Acc.knight.quantity += shopKnight;
            Acc.mountedKnight.quantity += shopHorse;

            updateGame();
        }

        private void updateGame()
        {
            lblOverWiewArcher.Text = Acc.archer.quantity.ToString();
            lblOverWiewKnight.Text = Acc.knight.quantity.ToString();
            lblOverWiewHorse.Text = Acc.mountedKnight.quantity.ToString();
        }
    }
}
