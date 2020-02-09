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
    public partial class ActorConfig : Form
    {
        public Form1 originalForm;
        public createPL parentForm;
        public int RemainValue, TotalValue, MinimumValue, PrevEx1, PrevEx2, CurrentValue, PrevExMin1, PrevExMin2, n;
        public Boolean flag, searched;
        
        public ActorConfig()
        {
            InitializeComponent();
        }

        // 選択した職業で変更可能な技能の取得
        public void txtBoxValidityF(int WorkNumber, int SkillNumber, Label SelectText, NumericUpDown SelectValue)
        {
            try
            {
                SelectText.Text = originalForm.CthulhuAct[WorkNumber].CandoSkills[SkillNumber];
                SelectValue.Minimum = SearchMinF(originalForm.CthulhuAct[WorkNumber].CandoSkills[SkillNumber]);
            }
            catch(Exception ex)
            {
                SelectText.Text = "選択不可: ";
                SelectValue.Enabled = false;
                originalForm.notifications[originalForm.noticenum] = ex.ToString();
                originalForm.noticenum += 1;
            }
        }

        // 残スキルポイント数の計算
        public void MinimumValueEvaluationCheckF()
        {
            CurrentValue = Decimal.ToInt32(SkillValue1.Value) + Decimal.ToInt32(SkillValue2.Value) + Decimal.ToInt32(SkillValue3.Value) + Decimal.ToInt32(SkillValue4.Value) + Decimal.ToInt32(SkillValue5.Value) + Decimal.ToInt32(SkillValue6.Value) + Decimal.ToInt32(SkillValue7.Value) + Decimal.ToInt32(SkillValue8.Value) + Decimal.ToInt32(ExSkillValue1.Value) + Decimal.ToInt32(ExSkillValue2.Value);
            RemainValue = TotalValue - ( CurrentValue - MinimumValue );
            txtValue.Text = RemainValue.ToString() + " / " + TotalValue.ToString();

            if (RemainValue < 0)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        // 各技能の初期値の取得
        public int SearchMinF(string SkillName)
        {
            int SearchIndex = 0;
            for (int i = 1; i <= 60; i++)
            {
                if (SkillName == originalForm.CthulhuSkill[i].SkillName)
                {
                    SearchIndex = originalForm.CthulhuSkill[i].OrgP;
                    break;
                }
            }

            return SearchIndex;
        }

        // 【冗長】PLステータスの入力
        public void ReplaceValueF(string SelectText, NumericUpDown SelectValue)
        {
            try
            {
                for (int i = 1; i <= 60; i++)
                {
                    if (originalForm.newPlayer.PlayerSkill[i].SkillName == SelectText)
                    {
                        originalForm.newPlayer.PlayerSkill[i].OrgP = Decimal.ToInt32(SelectValue.Value);
                        n += 1;
                        searched = true;
                        break;
                    }
                    else
                    {
                        
                    }
                }
                if (searched)
                {
                    searched = false;
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                originalForm.notifications[originalForm.noticenum] = ex.ToString();
                originalForm.noticenum += 1;
            }
        }

        private void ActorConfig_Load(object sender, EventArgs e)
        {
            flag = false;
            searched = false;
            MinimumValue = 0;
            n = 1;
            TotalValue = int.Parse(parentForm.intEDU.Text) * 20;
            txtActor.Text = parentForm.txtName.Text + ": ";
            txtValue.Text = RemainValue.ToString() + " / " + TotalValue.ToString();

            for (int i = 1; i <= 27; i++)
            {
                if (parentForm.cmbWork.Text == originalForm.CthulhuAct[i].ActName)
                {
                    txtBoxValidityF(i, 0, txtSkill1, SkillValue1);
                    txtBoxValidityF(i, 1, txtSkill2, SkillValue2);
                    txtBoxValidityF(i, 2, txtSkill3, SkillValue3);
                    txtBoxValidityF(i, 3, txtSkill4, SkillValue4);
                    txtBoxValidityF(i, 4, txtSkill5, SkillValue5);
                    txtBoxValidityF(i, 5, txtSkill6, SkillValue6);
                    txtBoxValidityF(i, 6, txtSkill7, SkillValue7);
                    txtBoxValidityF(i, 7, txtSkill8, SkillValue8);

                    if (originalForm.CthulhuAct[i].ExtraSkill == 1)
                    {
                        for (int j = 1; j <= 60; j++)
                        {
                            cmbExSkill1.Items.Add(originalForm.CthulhuSkill[j].SkillName);
                        }
                        cmbExSkill1.Enabled = true;
                    }
                    else if (originalForm.CthulhuAct[i].ExtraSkill == 2)
                    {
                        if (parentForm.cmbWork.Text == originalForm.CthulhuAct[4].ActName)
                        {
                            cmbExSkill1.Items.AddRange(originalForm.KyoujuSelection);
                            cmbExSkill2.Items.AddRange(originalForm.KyoujuSelection);
                        }
                        else if (parentForm.cmbWork.Text == originalForm.CthulhuAct[7].ActName)
                        {
                            cmbExSkill1.Items.AddRange(originalForm.KeikanSelection);
                            cmbExSkill2.Items.AddRange(originalForm.KeikanSelection);
                        }
                        cmbExSkill1.Enabled = true;
                        cmbExSkill2.Enabled = true;

                    }
                    else
                    {
                    }
                }
                else
                { 
                }
            }
            RemainValue = TotalValue;
            MinimumValue = Decimal.ToInt32(SkillValue1.Value) + Decimal.ToInt32(SkillValue2.Value) + Decimal.ToInt32(SkillValue3.Value) + Decimal.ToInt32(SkillValue4.Value) + Decimal.ToInt32(SkillValue5.Value) + Decimal.ToInt32(SkillValue6.Value) + Decimal.ToInt32(SkillValue7.Value) + Decimal.ToInt32(SkillValue8.Value);
            txtActor.Text = parentForm.txtName.Text + ": ";
            txtValue.Text = RemainValue.ToString() + " / " + TotalValue.ToString();

        }

        private void SkillValue1_ValueChanged(object sender, EventArgs e)
        {
            MinimumValueEvaluationCheckF();
        }

        private void SkillValue2_ValueChanged(object sender, EventArgs e)
        {
            MinimumValueEvaluationCheckF();
        }

        private void SkillValue3_ValueChanged(object sender, EventArgs e)
        {
            MinimumValueEvaluationCheckF();
        }

        private void SkillValue4_ValueChanged(object sender, EventArgs e)
        {
            MinimumValueEvaluationCheckF();
        }

        private void SkillValue5_ValueChanged(object sender, EventArgs e)
        {
            MinimumValueEvaluationCheckF();
        }

        private void SkillValue6_ValueChanged(object sender, EventArgs e)
        {
            MinimumValueEvaluationCheckF();
        }

        private void SkillValue7_ValueChanged(object sender, EventArgs e)
        {
            MinimumValueEvaluationCheckF();
        }

        private void SkillValue8_ValueChanged(object sender, EventArgs e)
        {
            MinimumValueEvaluationCheckF();
        }

        private void ExSkillValue1_ValueChanged(object sender, EventArgs e)
        {
            if (flag)
            {

            }
            else
            {
                MinimumValueEvaluationCheckF();
                PrevEx1 = decimal.ToInt32(ExSkillValue1.Value);
            }
        }

        private void ExSkillValue2_ValueChanged(object sender, EventArgs e)
        {
            if (flag)
            {

            }
            else
            {
                MinimumValueEvaluationCheckF();
                PrevEx2 = decimal.ToInt32(ExSkillValue2.Value);
            }
        }

        private void cmbExSkill1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbExSkill1.Text == "")
            {
                ExSkillValue1.Enabled = false;
            }
            else
            {
                flag = true;
                CurrentValue = CurrentValue - PrevEx1;
                MinimumValue = MinimumValue - PrevExMin1;

                ExSkillValue1.Minimum = SearchMinF(cmbExSkill1.Text);
                ExSkillValue1.Value = ExSkillValue1.Minimum;
                PrevExMin1 = decimal.ToInt32(ExSkillValue1.Minimum);
                PrevEx1 = PrevExMin1;
                MinimumValue = MinimumValue + PrevExMin1;
                ExSkillValue1.Enabled = true;
                MinimumValueEvaluationCheckF();
                flag = false;
            }
        }

        private void cmbExSkill2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbExSkill2.Text == "")
            {
                ExSkillValue2.Enabled = false;
            }
            else
            {
                flag = true;
                CurrentValue = CurrentValue - PrevEx2;
                MinimumValue = MinimumValue - PrevExMin2;

                ExSkillValue2.Minimum = SearchMinF(cmbExSkill2.Text);
                ExSkillValue2.Value = ExSkillValue2.Minimum;
                PrevExMin2 = decimal.ToInt32(ExSkillValue2.Minimum);
                PrevEx2 = PrevExMin2;
                MinimumValue = MinimumValue + PrevExMin2;
                ExSkillValue2.Enabled = true;
                MinimumValueEvaluationCheckF();
                flag = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReplaceValueF(txtSkill1.Text, SkillValue1);
            originalForm.newPlayer.StatusSkills[1] = txtSkill1.Text + " " + SkillValue1.Value;
            ReplaceValueF(txtSkill2.Text, SkillValue2);
            originalForm.newPlayer.StatusSkills[2] = txtSkill2.Text + " " + SkillValue2.Value;
            ReplaceValueF(txtSkill3.Text, SkillValue3);
            originalForm.newPlayer.StatusSkills[3] = txtSkill3.Text + " " + SkillValue3.Value;
            ReplaceValueF(txtSkill4.Text, SkillValue4);
            originalForm.newPlayer.StatusSkills[4] = txtSkill4.Text + " " + SkillValue4.Value;
            ReplaceValueF(txtSkill5.Text, SkillValue5);
            originalForm.newPlayer.StatusSkills[5] = txtSkill5.Text + " " + SkillValue5.Value;
            ReplaceValueF(txtSkill6.Text, SkillValue6);
            originalForm.newPlayer.StatusSkills[6] = txtSkill6.Text + " " + SkillValue6.Value;
            ReplaceValueF(txtSkill7.Text, SkillValue7);
            originalForm.newPlayer.StatusSkills[7] = txtSkill7.Text + " " + SkillValue7.Value;
            ReplaceValueF(txtSkill8.Text, SkillValue8);
            originalForm.newPlayer.StatusSkills[8] = txtSkill8.Text + " " + SkillValue8.Value;
            ReplaceValueF(cmbExSkill1.Text, ExSkillValue1);
            originalForm.newPlayer.StatusSkills[9] = cmbExSkill1.Text + " " + ExSkillValue1.Value;
            ReplaceValueF(cmbExSkill2.Text, ExSkillValue2);
            originalForm.newPlayer.StatusSkills[10] = cmbExSkill2.Text + " " + ExSkillValue2.Value;

            originalForm.newPlayer.PlayerSkill[54].OrgP = int.Parse(parentForm.intEDU.Text) * 5;

            parentForm.blWork = true;

            for (int i = 1; i <= 60; i++)
            {
                Console.Write(originalForm.newPlayer.PlayerSkill[i].SkillName + ": " + originalForm.newPlayer.PlayerSkill[i].OrgP + Environment.NewLine);
            }
            this.Close();
        }

        private void ActorConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
