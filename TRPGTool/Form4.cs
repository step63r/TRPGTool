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
    public partial class ActorInterest : Form
    {
        public Form1 originalForm;
        public createPL parentForm;
        public int RemainValue, TotalValue, MinimumValue, CurrentValue;
        public int[] Prev, PrevMin;
        public Boolean flag, searched;

        public ActorInterest()
        {
            InitializeComponent();
        }

        // 残スキルポイント数の計算
        public void MinimumValueEvaluationCheckF()
        {
            CurrentValue = Decimal.ToInt32(valueInterest1.Value) + Decimal.ToInt32(valueInterest2.Value) + Decimal.ToInt32(valueInterest3.Value) + Decimal.ToInt32(valueInterest4.Value) + Decimal.ToInt32(valueInterest5.Value);
            RemainValue = TotalValue - (CurrentValue - MinimumValue);
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
            catch(Exception ex)
            {
                originalForm.notifications[originalForm.noticenum] = ex.ToString();
                originalForm.noticenum += 1;
            }
        }

        // comboBoxに技能をぶっ込む
        public void comboBoxAddingF(ComboBox SelectCombo)
        {
            for (int i = 1; i <= 60; i++)
            {
                SelectCombo.Items.Add(originalForm.CthulhuSkill[i].SkillName);
            }
        }

        // comboBoxが変化した時
        public void comboBoxChangingF(ComboBox SelectCombo, NumericUpDown SelectValue, int Num)
        {
            if (SelectCombo.Text == "")
            {
                SelectValue.Enabled = false;
            }
            else
            {
                flag = true;
                CurrentValue = CurrentValue - Prev[Num];
                MinimumValue = MinimumValue - PrevMin[Num];

                SelectValue.Minimum = SearchMinF(SelectCombo.Text);
                SelectValue.Value = SelectValue.Minimum;
                PrevMin[Num] = decimal.ToInt32(SelectValue.Minimum);
                Prev[Num] = PrevMin[Num];
                MinimumValue = MinimumValue + PrevMin[Num];
                SelectValue.Enabled = true;
                flag = false;
            }
        }

        // numericUpdownが変化した時
        public void numericUpdownChangingF(int Num, NumericUpDown SelectValue)
        {
            if (flag)
            {

            }
            else
            {
                MinimumValueEvaluationCheckF();
                Prev[Num] = Decimal.ToInt32(SelectValue.Value);
            }
        }

        private void ActorInterest_Load(object sender, EventArgs e)
        {
            flag = false;
            searched = false;
            MinimumValue = 0;
            Prev = new int[6];
            PrevMin = new int[6];

            TotalValue = int.Parse(parentForm.intINT.Text) * 10;
            txtActor.Text = parentForm.txtName.Text + ": ";
            txtValue.Text = RemainValue.ToString() + " / " + TotalValue.ToString();

            comboBoxAddingF(cmbInterest1);
            comboBoxAddingF(cmbInterest2);
            comboBoxAddingF(cmbInterest3);
            comboBoxAddingF(cmbInterest4);
            comboBoxAddingF(cmbInterest5);

            RemainValue = TotalValue;
            MinimumValue = Decimal.ToInt32(valueInterest1.Value) + Decimal.ToInt32(valueInterest2.Value) + Decimal.ToInt32(valueInterest3.Value) + Decimal.ToInt32(valueInterest4.Value) + Decimal.ToInt32(valueInterest5.Value);
            txtActor.Text = parentForm.txtName.Text + ": ";
            txtValue.Text = RemainValue.ToString() + " / " + TotalValue.ToString();
        }

        private void cmbInterest1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxChangingF(cmbInterest1, valueInterest1, 1);
        }

        private void cmbInterest2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxChangingF(cmbInterest2, valueInterest2, 2);
        }

        private void cmbInterest3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxChangingF(cmbInterest3, valueInterest3, 3);
        }

        private void cmbInterest4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxChangingF(cmbInterest4, valueInterest4, 4);
        }

        private void cmbInterest5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxChangingF(cmbInterest5, valueInterest5, 5);
        }

        private void valueInterest1_ValueChanged(object sender, EventArgs e)
        {
            numericUpdownChangingF(1, valueInterest1);
        }

        private void valueInterest2_ValueChanged(object sender, EventArgs e)
        {
            numericUpdownChangingF(2, valueInterest2);
        }

        private void valueInterest3_ValueChanged(object sender, EventArgs e)
        {
            numericUpdownChangingF(3, valueInterest3);
        }

        private void valueInterest4_ValueChanged(object sender, EventArgs e)
        {
            numericUpdownChangingF(4, valueInterest4);
        }

        private void valueInterest5_ValueChanged(object sender, EventArgs e)
        {
            numericUpdownChangingF(5, valueInterest5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReplaceValueF(cmbInterest1.Text, valueInterest1);
            ReplaceValueF(cmbInterest2.Text, valueInterest2);
            ReplaceValueF(cmbInterest3.Text, valueInterest3);
            ReplaceValueF(cmbInterest4.Text, valueInterest4);
            ReplaceValueF(cmbInterest5.Text, valueInterest5);
            parentForm.blInterest = true;

            for (int i = 1; i <= 60; i++)
            {
                Console.Write(originalForm.newPlayer.PlayerSkill[i].SkillName + ": " + originalForm.newPlayer.PlayerSkill[i].OrgP + Environment.NewLine);
            }
            this.Close();
        }

        private void ActorInterest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
