using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPGTool
{
    public partial class Information : Form
    {
        public Form1 parentForm;
        public Information()
        {
            InitializeComponent();
        }

        private void Information_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void Information_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                parentForm.newPlayer.Memo = txtbxMemo.Text;
                parentForm.newPlayer.Belong = txtbxBelongs.Text;
                parentForm.newPlayer.CurHP = int.Parse(cmbHP.Text);
                parentForm.newPlayer.CurMP = int.Parse(cmbMP.Text);
                parentForm.newPlayer.CurSAN = int.Parse(cmbSAN.Text);
                parentForm.PLStatusLabel.Text = parentForm.newPlayer.Name + " |";
                parentForm.POWStatusLabel.Text = "HP: " + parentForm.newPlayer.CurHP.ToString() + " |";
                parentForm.MPStatusLabel.Text = "MP: " + parentForm.newPlayer.CurMP.ToString() + " |";
                parentForm.SANStatusLabel.Text = "SAN: " + parentForm.newPlayer.CurSAN.ToString() + " |";
            }
            catch (Exception ex)
            {
                parentForm.notifications[parentForm.noticenum] = ex.ToString();
                parentForm.noticenum += 1;
            }

            parentForm.探索者情報IToolStripMenuItem.Checked = false;

        }

        private void Information_Load(object sender, EventArgs e)
        {
            intSTR.Text = parentForm.newPlayer.STR.ToString();
            intDEX.Text = parentForm.newPlayer.DEX.ToString();
            intINT.Text = parentForm.newPlayer.INT.ToString();
            intCON.Text = parentForm.newPlayer.CON.ToString();
            intAPP.Text = parentForm.newPlayer.APP.ToString();
            intPOW.Text = parentForm.newPlayer.POW.ToString();
            intSIZ.Text = parentForm.newPlayer.SIZ.ToString();
            intEDU.Text = parentForm.newPlayer.EDU.ToString();
            strdb.Text = parentForm.newPlayer.db;
            intIdea.Text = parentForm.newPlayer.Idea.ToString();
            intLuck.Text = parentForm.newPlayer.Luck.ToString();
            intKnowledge.Text = parentForm.newPlayer.Knowledge.ToString();
            strActor.Text = parentForm.newPlayer.Actor;
            strName.Text = parentForm.newPlayer.Name;
            intYear.Text = parentForm.newPlayer.Age.ToString();
            strSex.Text = parentForm.newPlayer.Sex;
            txtbxMemo.Text = parentForm.newPlayer.Memo;
            txtbxBelongs.Text = parentForm.newPlayer.Belong;

            for (int i = 1; i <= parentForm.newPlayer.HP; i++)
                cmbHP.Items.Add(i);

            var indHP = cmbHP.FindStringExact(parentForm.newPlayer.CurHP.ToString());
            cmbHP.SelectedIndex = indHP;

            for (int i = 1; i <= parentForm.newPlayer.MP; i++)
                cmbMP.Items.Add(i);

            var indMP = cmbMP.FindStringExact(parentForm.newPlayer.CurMP.ToString());
            cmbMP.SelectedIndex = indMP;

            for (int i = 1; i <= parentForm.newPlayer.SAN; i++)
                cmbSAN.Items.Add(i);

            var indSAN = cmbSAN.FindStringExact(parentForm.newPlayer.CurSAN.ToString());
            cmbSAN.SelectedIndex = indSAN;

            for (int i = 1; i <= 60; i++)
            {
                listSkills.Items.Add(parentForm.newPlayer.PlayerSkill[i].SkillName + " " + parentForm.newPlayer.PlayerSkill[i].OrgP.ToString());
            }


        }
    }
}
