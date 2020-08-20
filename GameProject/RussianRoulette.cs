using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProject
{
    public partial class RussianRoulette : Form
    {
        WinLose objResult = new WinLose();
        SpinChamber spin = new SpinChamber();
        bool IsGunLoad = false;
        int round = 1;
        public RussianRoulette()
        {
            InitializeComponent();
        }
        private static Random generator = new Random();
        private void btnBulleteLoad_Click(object sender, EventArgs e)
        {
            IsGunLoad = true;
            btnChamber.Enabled = true;
           btnBulleteLoad.Enabled = false;
            round = 1;
            pictureBoxGun.Image = Properties.Resources.loadGun;
        }

        private void btnChamber_Click(object sender, EventArgs e)
        {
            if (IsGunLoad == true)
            {
                spin.ChamberStart = spinChamber(); //Set Chamber to start game
                spin.BulleteInChamber = spinChamber(); //Bullet is which chamber
               btnShot.Enabled = true;
                btnChamber.Enabled = false;
                lblGameResult.Text = "Round 1 (Fire The Gun)";
                lblGameResult.Visible = true;
                btnPlatStart.Enabled = false;
                pictureBoxGun.Image = Properties.Resources.GunLoaded;
            }
            else
            {
                lblGameResult.Text="Please Load the bullete";
            }
        }
        public int spinChamber()
        {

            return generator.Next(1, 7);

        }

        private void btnShot_Click(object sender, EventArgs e)
        {
            Player gamePlayer = new Player();
           
            btnShot.Enabled = false;
            //Play the game
            int currentChamber = PlayGame(gamePlayer.NumberOfPlayer, spin.ChamberStart, spin.BulleteInChamber);
            spin.ChamberStart = currentChamber;

            if (currentChamber == -1)
            {
                btnShot.Enabled = false;
                btnPlatStart.Enabled = true;
            }
            else
            {

                lblGameResult.Visible = false;
                btnShot.Enabled = true;
                round++;
                lblGameResult.Text = "Round " + round +"(Fire the gun)";
                lblGameResult.Visible = true;
            }
        }
        public int PlayGame(int numPlayers, int currentChamber, int bulletChamber)
        {
            for (int i = 1; i <= numPlayers; i++)
            {

                // chamber with bullet is fired

                if (currentChamber == bulletChamber)
                {
                    SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\gun-fire.wav");
                    simpleSound.Play();
                    lblDeadInfo.Visible = true;
                    if (i == 1)
                    {
                        lblDeadInfo.Text = "You Dead!!!";
                        lblGameResult.Text = "LOSE GAME!!!";
                        lblDeadInfo.Visible = true;
                        lblGameResult.Visible = true;
                        objResult.LoseGame++;
                       lblWinLose.Text =objResult.WinGame.ToString()+"/"+ objResult.LoseGame.ToString();
                    }
                    else
                    {
                        
                        lblDeadInfo.Text = "Player " + i + " is dead...";
                        lblGameResult.Text = "WIN GAME!!!";
                        lblDeadInfo.Visible = true;
                        lblGameResult.Visible = true;
                        objResult.WinGame++;
                        lblWinLose.Text = objResult.WinGame.ToString() + "/" + objResult.LoseGame.ToString();
                    }


                    return -1;

                }
                else
                {
                   
                    if (i == 1)
                    {
                        lblGameResult.Text = "You Are Lucky";
                    }
                    else
                    {
                        lblGameResult.Text = "Player " + i + " is Lucky";
                    }

                    lblGameResult.Visible = true;

                    lblGameResult.Visible = false;
                    

                }
                if (currentChamber == 6)
                {

                    currentChamber = 1;

                }
                else
                {

                    currentChamber++;

                }


            }
            return currentChamber;


        }

        private void btnPlatStart_Click(object sender, EventArgs e)
        {
            btnChamber.Enabled = false;
            btnBulleteLoad.Enabled = true;
            btnShot.Enabled = false;
            spin.ChamberStart = 0;
            spin.BulleteInChamber = 0;
            
            IsGunLoad = false;
          
            lblDeadInfo.Visible = false;
            lblGameResult.Visible = false;
            round = 1;
            pictureBoxGun.Image = Properties.Resources.chamber;
        }

        private void RussianRoulette_Load(object sender, EventArgs e)
        {
            
            btnChamber.Enabled = false;
            lblGameResult.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    public class Player
    {
        public int NumberOfPlayer = 2;
    }
    public class SpinChamber
    {
        public int ChamberStart { get; set; }
        public int BulleteInChamber { get; set; }
    }
    public class WinLose
    {
        public int WinGame = 0;
        public int LoseGame = 0;
    }
}
