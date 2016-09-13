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
        int archerCost;
        int knightCost;
        int mountedKnightCost;
        public Form2()
        {
            InitializeComponent();
            panelOverWiew.Height = 410;
            panelOverWiew.Width = 927;
            panelOverWiew.BringToFront();
            LoadAccount();
            RefreshGame();        
        }

        private void LoadAccount()
        {
            Acc.Location = "Im here!";
            Acc.Power = 19929;
            Acc.Size = 45;
            Acc.Gold = 1000;  
        }

        private void RefreshGame()
        {
            txtKDName.Text = Acc.Username;
            txtPower.Text = Acc.Power.ToString();
            txtLocation.Text = Acc.Location;
            txtSize.Text = Acc.Size.ToString();
            txtGold.Text = Acc.Gold.ToString();
            lblOverWiewArcher.Text = Acc.archer.quantity.ToString();
            lblOverWiewKnight.Text = Acc.knight.quantity.ToString();
            lblOverWiewHorse.Text = Acc.mountedKnight.quantity.ToString();
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
            int totalCost;
            int.TryParse(lblTrainCost.Text, out totalCost);

            if (totalCost <= Acc.Gold)
            {
                Acc.Gold -= totalCost;
                Acc.archer.quantity += shopArcher;
                Acc.knight.quantity += shopKnight;
                Acc.mountedKnight.quantity += shopHorse;
                numArcher.Value = 0;
                numKnight.Value = 0;
                numHorse.Value = 0;
            }

         
            RefreshGame();
        }
   

        private void btnOverWiew_Click(object sender, EventArgs e)
        {
            panelOverWiew.Dock = DockStyle.Fill;
            panelOverWiew.BringToFront();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            panelBuild.BringToFront();     
            panelBuild.Dock = DockStyle.Fill;
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            panelTrain.BringToFront();
            panelTrain.Dock = DockStyle.Fill;
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            panelAttack.BringToFront();
            panelAttack.Dock = DockStyle.Fill;
        }

        private void btnExplore_Click(object sender, EventArgs e)
        {
            panelExplore.BringToFront();
            panelExplore.Dock = DockStyle.Fill;
        }

        private void btnResearch_Click(object sender, EventArgs e)
        {
            panelResearch.BringToFront();
            panelResearch.Dock = DockStyle.Fill;
        }

        private void numKnight_ValueChanged(object sender, EventArgs e)
        {
            knightCost = 0;
           knightCost = StaticShit.AddValue(numKnight.Value,Acc.knight.cost);
            lblTrainCost.Text = (knightCost + archerCost + mountedKnightCost).ToString();
        }

        private void numArcher_ValueChanged(object sender, EventArgs e)
        {
            archerCost = 0;
           archerCost = StaticShit.AddValue(numArcher.Value, Acc.archer.cost);
            lblTrainCost.Text = (knightCost + archerCost + mountedKnightCost).ToString();
        }

        private void numHorse_ValueChanged(object sender, EventArgs e)
        {
            mountedKnightCost = 0;
            mountedKnightCost = StaticShit.AddValue(numHorse.Value, Acc.mountedKnight.cost);
            lblTrainCost.Text = (knightCost + archerCost + mountedKnightCost).ToString();          
        }
    }
}
