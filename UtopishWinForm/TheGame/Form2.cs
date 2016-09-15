using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheGame;
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
            RefreshGame();
            SetText_Lables();
            timer1.Start();
        }

        private void SetText_Lables()
        {
            dbc.OpenConnection(StaticShit.ConString);
            lblArcherCost.Text = dbc.GetPrice("Archers",1).ToString();
            lblKnightCost.Text = dbc.GetPrice("Knights", 1).ToString();
            lblMountedCost.Text = dbc.GetPrice("MountedKnights", 1).ToString();
            lblBankCost.Text = dbc.GetPrice("Banks", 0).ToString();
            lblLabCost.Text = dbc.GetPrice("Labs", 0).ToString();
            lblBarrackCost.Text = dbc.GetPrice("Barracks", 0).ToString();
            dbc.CloseConnection();        }

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
           

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            now = DateTime.Now;
            RefreshGame();
            lblTime.Text = now.Hour + ":" + now.Minute + ":" + now.Second;
        }

        //MainNavButtons
        #region MainNavButtons
        private void button7_Click(object sender, EventArgs e)
        {
            StaticShit.form.Show();
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
            knightCost =  StaticShit.AddValue(numKnight.Value,dbc.GetPrice("Knights",1));
            dbc.CloseConnection();
            lblTrainCost.Text = (knightCost + archerCost + mountedKnightCost).ToString();
        }

        private void numArcher_ValueChanged(object sender, EventArgs e)
        {
            archerCost = 0;
            dbc.OpenConnection(StaticShit.ConString);
            archerCost = StaticShit.AddValue(numArcher.Value, dbc.GetPrice("Archers",1));
            dbc.CloseConnection();
            lblTrainCost.Text = (knightCost + archerCost + mountedKnightCost).ToString();
        }

        private void numHorse_ValueChanged(object sender, EventArgs e)
        {
            mountedKnightCost = 0;
            dbc.OpenConnection(StaticShit.ConString);
            mountedKnightCost = StaticShit.AddValue(numHorse.Value, dbc.GetPrice("MountedKnights",1));
            dbc.CloseConnection();
            lblTrainCost.Text = (knightCost + archerCost + mountedKnightCost).ToString();
        }
        #endregion
        //Building
        #region Buildings
        private void btnBuildBuild_Click(object sender, EventArgs e)
        {
            RefreshGame();
            int shopBank = (int)numBank.Value;
            int shopLab = (int)numLab.Value;
            int shopBarrack = (int)numBarrack.Value;
            int totalCost;
            int.TryParse(lblBuildCost.Text, out totalCost);

            if (totalCost <= Acc.Gold)
            {
                dbc.OpenConnection(StaticShit.ConString);
                dbc.RemoveGold(totalCost, Acc.Name);
                dbc.AddToQuant("Bank_Quant", shopBank, Acc.Name);
                dbc.AddToQuant("Lab_Quant", shopLab, Acc.Name);
                dbc.AddToQuant("Barrack_Quant", shopBarrack, Acc.Name);             
                numBank.Value = 0;
                numLab.Value = 0;
                numBarrack.Value = 0;
                dbc.CloseConnection();
            }
            RefreshGame();
        }

        private void numBank_ValueChanged(object sender, EventArgs e)
        {
            bankCost = 0;
            dbc.OpenConnection(StaticShit.ConString);
            bankCost = StaticShit.AddValue(numBank.Value, dbc.GetPrice("Banks", 0));
            dbc.CloseConnection();
            lblBuildCost.Text = (bankCost + labCost + barrackCost).ToString();   
        }

        private void numBarrack_ValueChanged(object sender, EventArgs e)
        {
            barrackCost = 0;
            dbc.OpenConnection(StaticShit.ConString);
            barrackCost = StaticShit.AddValue(numBarrack.Value, dbc.GetPrice("Labs", 0));
            dbc.CloseConnection();
            lblBuildCost.Text = (bankCost + labCost + barrackCost).ToString();
        }

        private void numLab_ValueChanged(object sender, EventArgs e)
        {
            labCost = 0;
            dbc.OpenConnection(StaticShit.ConString);
            labCost = StaticShit.AddValue(numLab.Value, dbc.GetPrice("Barracks", 0));
            dbc.CloseConnection();
            lblBuildCost.Text = (bankCost + labCost + barrackCost).ToString();
        }


    }
    #endregion
}
