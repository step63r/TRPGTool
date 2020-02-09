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
    public partial class createPL : Form
    {
        public Form1 parentForm;
        public string[] ActItems;
        ActorConfig actCon;
        ActorInterest actInt;
        public Boolean blWork, blInterest, blName, blYear, blSex;
        
        public createPL()
        {
            InitializeComponent();
        }

        private void createPL_Load(object sender, EventArgs e)
        {
            blWork = false;
            blInterest = false;
            blName = false;
            blYear = false;
            blSex = false;

            int seed = Environment.TickCount;
            intSTR.Text = parentForm.RollDice(6, 3).ToString();
            Random WaitRandom = new System.Random(seed++);
            System.Threading.Thread.Sleep(WaitRandom.Next(1, 100));
            intDEX.Text = parentForm.RollDice(6, 3).ToString();
            System.Threading.Thread.Sleep(WaitRandom.Next(1, 100));
            intINT.Text = (parentForm.RollDice(6, 2) + 6).ToString();
            System.Threading.Thread.Sleep(WaitRandom.Next(1, 100));
            intCON.Text = parentForm.RollDice(6, 3).ToString();
            System.Threading.Thread.Sleep(WaitRandom.Next(1, 100));
            intAPP.Text = parentForm.RollDice(6, 3).ToString();
            System.Threading.Thread.Sleep(WaitRandom.Next(1, 100));
            intPOW.Text = parentForm.RollDice(6, 3).ToString();
            System.Threading.Thread.Sleep(WaitRandom.Next(1, 100));
            intSIZ.Text = (parentForm.RollDice(6, 2) + 6).ToString();
            System.Threading.Thread.Sleep(WaitRandom.Next(1, 100));
            intEDU.Text = (parentForm.RollDice(6, 3) + 3).ToString();
            System.Threading.Thread.Sleep(WaitRandom.Next(1, 100));
            if (int.Parse(intSTR.Text) + int.Parse(intSIZ.Text) >= 2 && int.Parse(intSTR.Text) + int.Parse(intSIZ.Text) <= 12)
            {
                INTdb.Text = "-1D6";
            }
            else if (int.Parse(intSTR.Text) + int.Parse(intSIZ.Text) >= 13 && int.Parse(intSTR.Text) + int.Parse(intSIZ.Text) <= 16)
            {
                INTdb.Text = "-1D4";
            }
            else if (int.Parse(intSTR.Text) + int.Parse(intSIZ.Text) >= 17 && int.Parse(intSTR.Text) + int.Parse(intSIZ.Text) <= 24)
            {
                INTdb.Text = "0";
            }
            else if (int.Parse(intSTR.Text) + int.Parse(intSIZ.Text) >= 25 && int.Parse(intSTR.Text) + int.Parse(intSIZ.Text) <= 32)
            {
                INTdb.Text = "1D4";
            }
            else
            {
                INTdb.Text = "1D6";
            }
            //INTdb.Text = (int.Parse(intSTR.Text) + int.Parse(intSIZ.Text)).ToString();
            System.Threading.Thread.Sleep(WaitRandom.Next(1, 100));
            intHP.Text = (Math.Ceiling((double.Parse(intCON.Text) + double.Parse(intSIZ.Text)) / 2)).ToString();
            intMP.Text = intPOW.Text;
            intSAN.Text = (int.Parse(intPOW.Text) * 5).ToString();
            intIdea.Text = (int.Parse(intINT.Text) * 5).ToString();
            intLuck.Text = (int.Parse(intPOW.Text) * 5).ToString();
            intKnowledge.Text = (int.Parse(intEDU.Text) * 5).ToString();

            for (int i = int.Parse(intEDU.Text) + 6; i <= 80; i++)
            {
                cmbYear.Items.Add(i);
            }

            for (int i = 1; i <= 27; i++)
            {
                cmbWork.Items.Add(parentForm.CthulhuAct[i].ActName);
            }

            parentForm.newPlayer.PlayerSkill[6].OrgP = int.Parse(intDEX.Text) * 2;
            parentForm.newPlayer.PlayerSkill[54].OrgP = int.Parse(intEDU.Text) * 5;

        }

        private void cmbWork_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            if (cmbWork.Text == "")
            {

            }
            else
            {
                actCon = new ActorConfig();
                actCon.originalForm = this.parentForm;
                actCon.parentForm = this;
                actCon.ShowDialog();
                actCon.Dispose();
                if (blWork)
                {
                    WorkValidity.Text = "Valid";
                    WorkValidity.ForeColor = Color.Blue;
                    btninterest.Enabled = true;

                    // 修正必要
                    btnWork.Enabled = false;
                    cmbWork.Enabled = false;
                }
                else
                {
                    WorkValidity.Text = "Invalid";
                    WorkValidity.ForeColor = Color.Red;
                    btninterest.Enabled = false;
                }
            }
        }

        private void btninterest_Click(object sender, EventArgs e)
        {
            actInt = new ActorInterest();
            actInt.originalForm = this.parentForm;
            actInt.parentForm = this;
            actInt.ShowDialog();
            actInt.Dispose();
            if (blInterest)
            {
                InterestValidity.Text = "Valid";
                InterestValidity.ForeColor = Color.Blue;

                // 修正必要
                btninterest.Enabled = false;
            }
            else
            {
                InterestValidity.Text = "Invalid";
                InterestValidity.ForeColor = Color.Red;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if(txtName.Text != "")
            {
                NameValidity.Text = "Valid";
                NameValidity.ForeColor = Color.Blue;
                blName = true;
            }
            else
            {
                NameValidity.Text = "Invalid";
                NameValidity.ForeColor = Color.Red;
                blName = false;
            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYear.Text != "")
            {
                YearValidity.Text = "Valid";
                YearValidity.ForeColor = Color.Blue;
                blYear = true;
            }
            else
            {
                YearValidity.Text = "Invalid";
                YearValidity.ForeColor = Color.Red;
                blYear = false;
            }
        }

        private void cmbSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSex.Text != "")
            {
                SexValidity.Text = "Valid";
                SexValidity.ForeColor = Color.Blue;
                blSex = true;
            }
            else
            {
                SexValidity.Text = "Invalid";
                SexValidity.ForeColor = Color.Red;
                blSex = false;
            }
        }

        private void createPL_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.CthulhuSkill[6].OrgP = 1;
            parentForm.CthulhuSkill[54].OrgP = 1;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (blWork && blInterest && blName && blYear && blSex)
            {
                parentForm.newPlayer.Actor = cmbWork.Text;
                parentForm.newPlayer.Name = txtName.Text;
                parentForm.newPlayer.Age = int.Parse(cmbYear.Text);
                parentForm.newPlayer.Sex = cmbSex.Text;
                parentForm.newPlayer.Memo = txtMemo.Text;
                parentForm.newPlayer.Belong = txtBelong.Text;

                parentForm.newPlayer.STR = int.Parse(intSTR.Text);
                parentForm.newPlayer.DEX = int.Parse(intDEX.Text);
                parentForm.newPlayer.INT = int.Parse(intINT.Text);
                parentForm.newPlayer.CON = int.Parse(intCON.Text);
                parentForm.newPlayer.APP = int.Parse(intAPP.Text);
                parentForm.newPlayer.POW = int.Parse(intPOW.Text);
                parentForm.newPlayer.SIZ = int.Parse(intSIZ.Text);
                parentForm.newPlayer.EDU = int.Parse(intEDU.Text);
                parentForm.newPlayer.HP = int.Parse(intHP.Text);
                parentForm.newPlayer.CurHP = int.Parse(intHP.Text);
                parentForm.newPlayer.MP = int.Parse(intMP.Text);
                parentForm.newPlayer.CurMP = int.Parse(intMP.Text);
                parentForm.newPlayer.SAN = int.Parse(intSAN.Text);
                parentForm.newPlayer.CurSAN = int.Parse(intSAN.Text);
                parentForm.newPlayer.Idea = int.Parse(intIdea.Text);
                parentForm.newPlayer.Luck = int.Parse(intLuck.Text);
                parentForm.newPlayer.Knowledge = int.Parse(intKnowledge.Text);
                parentForm.newPlayer.db = INTdb.Text;

                // コンソールへの出力
                parentForm.notifications[parentForm.noticenum] = "Create new PL: "; parentForm.noticenum += 1;
                parentForm.notifications[parentForm.noticenum] = "Name " + parentForm.newPlayer.Name; parentForm.noticenum += 1;
                parentForm.notifications[parentForm.noticenum] = "Age " + parentForm.newPlayer.Age; parentForm.noticenum += 1;
                parentForm.notifications[parentForm.noticenum] = "Sex " + parentForm.newPlayer.Sex; parentForm.noticenum += 1;
                parentForm.notifications[parentForm.noticenum] = "Actor " + parentForm.newPlayer.Actor; parentForm.noticenum += 1;
                parentForm.notifications[parentForm.noticenum] = "STR " + parentForm.newPlayer.STR; parentForm.noticenum += 1;
                parentForm.notifications[parentForm.noticenum] = "DEX " + parentForm.newPlayer.DEX; parentForm.noticenum += 1;
                parentForm.notifications[parentForm.noticenum] = "INT " + parentForm.newPlayer.INT; parentForm.noticenum += 1;
                parentForm.notifications[parentForm.noticenum] = "CON " + parentForm.newPlayer.CON; parentForm.noticenum += 1;
                parentForm.notifications[parentForm.noticenum] = "APP " + parentForm.newPlayer.APP; parentForm.noticenum += 1;
                parentForm.notifications[parentForm.noticenum] = "POW " + parentForm.newPlayer.POW; parentForm.noticenum += 1;
                parentForm.notifications[parentForm.noticenum] = "SIZ " + parentForm.newPlayer.SIZ; parentForm.noticenum += 1;
                parentForm.notifications[parentForm.noticenum] = "EDU " + parentForm.newPlayer.EDU; parentForm.noticenum += 1;
                parentForm.notifications[parentForm.noticenum] = "HP " + parentForm.newPlayer.HP; parentForm.noticenum += 1;
                parentForm.notifications[parentForm.noticenum] = "MP " + parentForm.newPlayer.MP; parentForm.noticenum += 1;
                parentForm.notifications[parentForm.noticenum] = "SAN " + parentForm.newPlayer.SAN; parentForm.noticenum += 1;
                parentForm.notifications[parentForm.noticenum] = "Idea " + parentForm.newPlayer.Idea; parentForm.noticenum += 1;
                parentForm.notifications[parentForm.noticenum] = "Luck " + parentForm.newPlayer.Luck; parentForm.noticenum += 1;
                parentForm.notifications[parentForm.noticenum] = "Knowledge " + parentForm.newPlayer.Knowledge; parentForm.noticenum += 1;
                parentForm.notifications[parentForm.noticenum] = "damage bonus " + parentForm.newPlayer.db; parentForm.noticenum += 1;
                for (int i = 1; i <= 60; i++)
                {
                    parentForm.notifications[parentForm.noticenum] = parentForm.newPlayer.PlayerSkill[i].SkillName + parentForm.newPlayer.PlayerSkill[i].OrgP;
                    parentForm.noticenum += 1;
                }

                // 基本値ロールの追加
                parentForm.BasicName.Items.Add("アイデア " + parentForm.newPlayer.Idea);
                parentForm.BasicName.Items.Add("幸運 " + parentForm.newPlayer.Luck);
                parentForm.BasicName.Items.Add("知識 " + parentForm.newPlayer.Knowledge);
                parentForm.BasicName.Items.Add(parentForm.newPlayer.PlayerSkill[6].SkillName + " " + parentForm.newPlayer.PlayerSkill[6].OrgP);

                // 職業ロールの追加
                for (int i = 1; i <= 10; i++)
                {
                    if ((parentForm.newPlayer.StatusSkills[i] != null) && (parentForm.newPlayer.StatusSkills[i] != " 0") && (parentForm.newPlayer.StatusSkills[i] != "選択不可 0"))
                    {
                        parentForm.SkillName.Items.Add(parentForm.newPlayer.StatusSkills[i]);
                    }
                    else
                    {
                    }
                }

                // 戦闘ロールの追加
                parentForm.BattleName.Items.Add(parentForm.newPlayer.PlayerSkill[13].SkillName + " " + parentForm.newPlayer.PlayerSkill[13].OrgP);
                parentForm.BattleName.Items.Add(parentForm.newPlayer.PlayerSkill[15].SkillName + " " + parentForm.newPlayer.PlayerSkill[15].OrgP);
                parentForm.BattleName.Items.Add(parentForm.newPlayer.PlayerSkill[18].SkillName + " " + parentForm.newPlayer.PlayerSkill[18].OrgP);
                parentForm.BattleName.Items.Add(parentForm.newPlayer.PlayerSkill[20].SkillName + " " + parentForm.newPlayer.PlayerSkill[20].OrgP);
                parentForm.BattleName.Items.Add(parentForm.newPlayer.PlayerSkill[22].SkillName + " " + parentForm.newPlayer.PlayerSkill[22].OrgP);
                parentForm.BattleName.Items.Add(parentForm.newPlayer.PlayerSkill[27].SkillName + " " + parentForm.newPlayer.PlayerSkill[27].OrgP);
                parentForm.BattleName.Items.Add(parentForm.newPlayer.PlayerSkill[40].SkillName + " " + parentForm.newPlayer.PlayerSkill[40].OrgP);
                parentForm.BattleName.Items.Add(parentForm.newPlayer.PlayerSkill[55].SkillName + " " + parentForm.newPlayer.PlayerSkill[55].OrgP);
                parentForm.BattleName.Items.Add(parentForm.newPlayer.PlayerSkill[56].SkillName + " " + parentForm.newPlayer.PlayerSkill[56].OrgP);
                parentForm.BattleName.Items.Add(parentForm.newPlayer.PlayerSkill[59].SkillName + " " + parentForm.newPlayer.PlayerSkill[59].OrgP);

                // 全てロールの追加
                parentForm.AllName.Items.Add("アイデア " + parentForm.newPlayer.Idea);
                parentForm.AllName.Items.Add("幸運 " + parentForm.newPlayer.Luck);
                parentForm.AllName.Items.Add("知識 " + parentForm.newPlayer.Knowledge);
                for (int i = 1; i <= 60; i++)
                {
                    parentForm.AllName.Items.Add(parentForm.newPlayer.PlayerSkill[i].SkillName + " " + parentForm.newPlayer.PlayerSkill[i].OrgP);
                }

                parentForm.PLStatusLabel.Text = parentForm.newPlayer.Name + " |";
                parentForm.POWStatusLabel.Text = "HP: " + parentForm.newPlayer.CurHP.ToString() + " |";
                parentForm.MPStatusLabel.Text = "MP: " + parentForm.newPlayer.CurMP.ToString() + " |";
                parentForm.SANStatusLabel.Text = "SAN: " + parentForm.newPlayer.CurSAN.ToString() + " |";

                parentForm.grpBasis.Enabled = true;
                parentForm.grpSkill.Enabled = true;
                parentForm.grpBattle.Enabled = true;
                parentForm.grpAll.Enabled = true;
                parentForm.探索者情報IToolStripMenuItem.Enabled = true;
                parentForm.loadState = true;

                this.Close();
            }
            else
            {

            }
        }
    }
}
