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
        DateTime now;
        int archerCost;
        int knightCost;
        int mountedKnightCost;
        int bankCost;
        int labCost;
        int barrackCost;
        public Form2()
        {
            InitializeComponent();
            panelOverWiew.Height = 410;
            panelOverWiew.Width = 927;
            panelOverWiew.BringToFront();
            LoadAccount();
            RefreshGame();
            timer1.Start();    
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
            lblOverwieBank.Text = Acc.bank.quantity.ToString();
            lblOverViewLab.Text = Acc.lab.quantity.ToString();
            lblOverViewBarrack.Text = Acc.barrack.quantity.ToString();

            lblArcherCost.Text = "cost" + Acc.archer.cost;
            lblKnightCost.Text = "cost" + Acc.knight.cost;
            lblMountedCost.Text = "cost" + Acc.mountedKnight.cost;
            lblBankCost.Text = "cost" + Acc.bank.cost;
            lblLabCost.Text = "cost" + Acc.lab.cost;
            lblBarrackCost.Text = "cost" + Acc.barrack.cost;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            now = DateTime.Now;
            lblTime.Text = now.Hour + ":" + now.Minute + ":" + now.Second;
        }

        //MainNavButtons
        #region MainNavButtons
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();

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
        #endregion
        //Soldiers
        #region Soldiers
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

        private void numKnight_ValueChanged(object sender, EventArgs e)
        {
            knightCost = 0;
            knightCost = StaticShit.AddValue(numKnight.Value, Acc.knight.cost);
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
        #endregion
        //Building
        #region Buildings
        private void btnBuildBuild_Click(object sender, EventArgs e)
        {
            int shopBank = (int)numBank.Value;
            int shopLab = (int)numLab.Value;
            int shopBarrack = (int)numBarrack.Value;
            int totalCost;
            int.TryParse(lblBuildCost.Text, out totalCost);

            if (totalCost <= Acc.Gold)
            {
                Acc.Gold -= totalCost;
                Acc.bank.quantity += shopBank;
                Acc.lab.quantity += shopLab;
                Acc.barrack.quantity += shopBarrack;
                numBank.Value = 0;
                numLab.Value = 0;
                numBarrack.Value = 0;
            }
            RefreshGame();
        }

        private void numBank_ValueChanged(object sender, EventArgs e)
        {
            bankCost = 0;
            bankCost = StaticShit.AddValue(numBank.Value, Acc.bank.cost);
            lblBuildCost.Text = (bankCost + labCost + barrackCost).ToString();
        }

        private void numBarrack_ValueChanged(object sender, EventArgs e)
        {
            barrackCost = 0;
            barrackCost = StaticShit.AddValue(numBarrack.Value, Acc.barrack.cost);
            lblBuildCost.Text = (bankCost + labCost + barrackCost).ToString();
        }

        private void numLab_ValueChanged(object sender, EventArgs e)
        {
            labCost = 0;
            labCost = StaticShit.AddValue(numLab.Value, Acc.lab.cost);
            lblBuildCost.Text = (bankCost + labCost + barrackCost).ToString();
        }

      
    } 
    #endregion
}
