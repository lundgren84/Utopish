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
        DataBaseConection dbc = new DataBaseConection();
        Player Acc = new Player();
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
            dbc.OpenConnection(StaticShit.ConString);
            Acc.Name = StaticShit.AccName;
            Acc.Size = Convert.ToInt32((dbc.GetAccInfo("Size", StaticShit.AccName)));
            Acc.Power = Convert.ToInt32((dbc.GetAccInfo("Power", StaticShit.AccName)));
            Acc.Gold = Convert.ToInt32((dbc.GetAccInfo("Gold", StaticShit.AccName)));
            Acc.Archer_Quant = Convert.ToInt32((dbc.GetAccInfo("Archer_Quant", StaticShit.AccName)));
            Acc.Knight_Quant = Convert.ToInt32((dbc.GetAccInfo("Knight_Quant", StaticShit.AccName)));
            Acc.MountedKnight_Quant = Convert.ToInt32((dbc.GetAccInfo("MountKnight_Quant", StaticShit.AccName)));
            Acc.Bank_Quant = Convert.ToInt32((dbc.GetAccInfo("Bank_Quant", StaticShit.AccName)));
            Acc.Lab_Quant = Convert.ToInt32((dbc.GetAccInfo("Lab_Quant", StaticShit.AccName)));
            Acc.Barrack_Quant = Convert.ToInt32((dbc.GetAccInfo("Barrack_Quant", StaticShit.AccName)));
            dbc.CloseConnection();
        }

        private void RefreshGame()
        {
            LoadAccount();
            txtKDName.Text = Acc.Name;
            txtPower.Text = Acc.Power.ToString();

            txtSize.Text = Acc.Size.ToString();
            txtGold.Text = Acc.Gold.ToString();
            lblOverWiewArcher.Text = Acc.Archer_Quant.ToString();
            lblOverWiewKnight.Text = Acc.Knight_Quant.ToString();
            lblOverWiewHorse.Text = Acc.MountedKnight_Quant.ToString();
            lblOverwieBank.Text = Acc.Bank_Quant.ToString();
            lblOverViewLab.Text = Acc.Lab_Quant.ToString();
            lblOverViewBarrack.Text = Acc.Barrack_Quant.ToString();

            //lblArcherCost.Text = "cost" + Acc.archer.cost;
            //lblKnightCost.Text = "cost" + Acc.knight.cost;
            //lblMountedCost.Text = "cost" + Acc.mountedKnight.cost;
            //lblBankCost.Text = "cost" + Acc.bank.cost;
            //lblLabCost.Text = "cost" + Acc.lab.cost;
            //lblBarrackCost.Text = "cost" + Acc.barrack.cost;
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
            RefreshGame();
            int shopKnight = (int)numKnight.Value;
            int shopArcher = (int)numArcher.Value;
            int shopHorse = (int)numHorse.Value;
            int totalCost;
            int.TryParse(lblTrainCost.Text, out totalCost);

            if (totalCost <= Acc.Gold)
            {
                dbc.OpenConnection(StaticShit.ConString);
                dbc.RemoveGold(totalCost,Acc.Name);
                dbc.AddToQuant("Archer_Quant", shopArcher, Acc.Name);
                dbc.AddToQuant("Knight_Quant", shopKnight, Acc.Name);
                dbc.AddToQuant("MountKnight_Quant", shopHorse, Acc.Name);            
                numArcher.Value = 0;
                numKnight.Value = 0;
                numHorse.Value = 0;
                dbc.CloseConnection();
            }


            RefreshGame();
        }

        private void numKnight_ValueChanged(object sender, EventArgs e)
        {
            knightCost = 0;
            dbc.OpenConnection(StaticShit.ConString);
            knightCost =  StaticShit.AddValue(numKnight.Value,dbc.GetPrice("Knights"));
            dbc.CloseConnection();
            lblTrainCost.Text = (knightCost + archerCost + mountedKnightCost).ToString();
        }

        private void numArcher_ValueChanged(object sender, EventArgs e)
        {
            archerCost = 0;
            dbc.OpenConnection(StaticShit.ConString);
            archerCost = StaticShit.AddValue(numArcher.Value, dbc.GetPrice("Archers"));
            dbc.CloseConnection();
            lblTrainCost.Text = (knightCost + archerCost + mountedKnightCost).ToString();
        }

        private void numHorse_ValueChanged(object sender, EventArgs e)
        {
            mountedKnightCost = 0;
            dbc.OpenConnection(StaticShit.ConString);
            mountedKnightCost = StaticShit.AddValue(numHorse.Value, dbc.GetPrice("MountedKnights"));
            dbc.CloseConnection();
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
                Acc.Bank_Quant += shopBank;
                Acc.Lab_Quant += shopLab;
                Acc.Barrack_Quant += shopBarrack;
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
