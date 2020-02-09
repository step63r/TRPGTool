using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TRPGTool
{
    // 技能と初期値の構造体
    public struct Skill
    {
        public string SkillName;
        public int OrgP;
    }

    // 職業と保有技能の構造体
    public struct Act
    {
        public string ActName;
        public string[] CandoSkills;
        public int ExtraSkill;
    }

    // プレイヤー情報の構造体
    // 職業ポイントはEDU*20, 趣味ポイントはINT*10
    public struct Player
    {
        public int STR, DEX, INT, CON, APP, POW, SIZ, EDU, HP, MP, SAN, Idea, Luck, Knowledge, Age, CurHP, CurMP, CurSAN;
        public string Actor, Name, Sex, Memo, Belong, db;
        public string[] StatusSkills;
        public Skill[] PlayerSkill;
    }

    public partial class Form1 : Form
    {
        OpenFileDialog ofd;
        SaveFileDialog sfd;
        string access;
        string[] AllData = new string[100];

        public Skill[] CthulhuSkill = new Skill[61];
        public Act[] CthulhuAct = new Act[28];
        public Player newPlayer = new Player();

        public int[] n = new int[100];
        public string[] KyoujuSelection = new string[12];
        public string[] KeikanSelection = new string[5];
        public string[] notifications = new string[1000];
        public string[] PanicST = new string[11];
        public string[] PanicLT = new string[11];
        public int noticenum;
        public bool loadState;

        public int RollDice(int Dice, int Number){
            int rslt = 0;
            int seed = Environment.TickCount;
            Random rollRandom = new System.Random(seed++);

            for (int i = 1; i <= 99; i++)
                n[i] = 0;

                for (int i = 1; i <= Number; i++)
                {
                    n[i] = rollRandom.Next(1, Dice + 1);
                    rslt = rslt + n[i];
                }
            return rslt;
        }

        public void DetailDiceF(ComboBox cmbName, NumericUpDown nmbName)
        {
            int d = RollDice(100, 1);
            if (cmbName.Text == "アイデア " + newPlayer.Idea)
            {
                DetailDiceCheckF(newPlayer.Idea + Decimal.ToInt32(nmbName.Value), d);
            }
            else if (cmbName.Text == "幸運 " + newPlayer.Luck)
            {
                DetailDiceCheckF(newPlayer.Luck + Decimal.ToInt32(nmbName.Value), d);
            }
            else if (cmbName.Text == "知識 " + newPlayer.Knowledge)
            {
                DetailDiceCheckF(newPlayer.Knowledge + Decimal.ToInt32(nmbName.Value), d);
            }
            else if (cmbName.Text != "")
            {
                for (int i = 1; i <= 60; i++)
                {
                    if (cmbName.Text == newPlayer.PlayerSkill[i].SkillName + " " + newPlayer.PlayerSkill[i].OrgP)
                    {
                        DetailDiceCheckF(newPlayer.PlayerSkill[i].OrgP + Decimal.ToInt32(nmbName.Value), d);
                    }
                }
            }
            else
            {

            }
        }
        
        public void DetailDiceCheckF(int Number, int Dice)
        {
            try
            {
                txtSubResult.Text = "1D100 <= " + Number + ", Res: " + Dice;
                if (Dice <= Number)
                {
                    txtResult.Text = "Success";
                }
                else
                {
                    txtResult.Text = "Failure";
                }
            }
            catch (Exception ex)
            {
                notifications[noticenum] = ex.ToString();
                noticenum += 1;
            }
        }

        createPL crtP;
        Information infP;
        ConsoleForm cons;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 技能と初期値の定義
            // 【注意】回避はDEX*2, 母国語はEDU*5を最低値として割り振ります
            CthulhuSkill[1].SkillName = "言いくるめ";
            CthulhuSkill[1].OrgP = 5;
            CthulhuSkill[2].SkillName = "医学";
            CthulhuSkill[2].OrgP = 5;
            CthulhuSkill[3].SkillName = "運転";
            CthulhuSkill[3].OrgP = 20;
            CthulhuSkill[4].SkillName = "応急手当";
            CthulhuSkill[4].OrgP = 30;
            CthulhuSkill[5].SkillName = "オカルト";
            CthulhuSkill[5].OrgP = 5;
            CthulhuSkill[6].SkillName = "回避";
            CthulhuSkill[6].OrgP = 1;
            CthulhuSkill[7].SkillName = "化学";
            CthulhuSkill[7].OrgP = 1;
            CthulhuSkill[8].SkillName = "鍵開け";
            CthulhuSkill[8].OrgP = 1;
            CthulhuSkill[9].SkillName = "隠す";
            CthulhuSkill[9].OrgP = 15;
            CthulhuSkill[10].SkillName = "隠れる";
            CthulhuSkill[10].OrgP = 10;
            CthulhuSkill[11].SkillName = "機械修理";
            CthulhuSkill[11].OrgP = 20;
            CthulhuSkill[12].SkillName = "聞き耳";
            CthulhuSkill[12].OrgP = 25;
            CthulhuSkill[13].SkillName = "キック";
            CthulhuSkill[13].OrgP = 25;
            CthulhuSkill[14].SkillName = "クトゥルフ神話";
            CthulhuSkill[14].OrgP = 0;
            CthulhuSkill[15].SkillName = "組みつき";
            CthulhuSkill[15].OrgP = 25;
            CthulhuSkill[16].SkillName = "芸術";
            CthulhuSkill[16].OrgP = 5;
            CthulhuSkill[17].SkillName = "経理";
            CthulhuSkill[17].OrgP = 10;
            CthulhuSkill[18].SkillName = "拳銃";
            CthulhuSkill[18].OrgP = 20;
            CthulhuSkill[19].SkillName = "考古学";
            CthulhuSkill[19].OrgP = 1;
            CthulhuSkill[20].SkillName = "こぶし / パンチ";
            CthulhuSkill[20].OrgP = 50;
            CthulhuSkill[21].SkillName = "コンピュータ";
            CthulhuSkill[21].OrgP = 1;
            CthulhuSkill[22].SkillName = "サブマシンガン";
            CthulhuSkill[22].OrgP = 15;
            CthulhuSkill[23].SkillName = "忍び歩き";
            CthulhuSkill[23].OrgP = 10;
            CthulhuSkill[24].SkillName = "写真術";
            CthulhuSkill[24].OrgP = 10;
            CthulhuSkill[25].SkillName = "重機械操作";
            CthulhuSkill[25].OrgP = 1;
            CthulhuSkill[26].SkillName = "乗馬";
            CthulhuSkill[26].OrgP = 5;
            CthulhuSkill[27].SkillName = "ショットガン";
            CthulhuSkill[27].OrgP = 30;
            CthulhuSkill[28].SkillName = "信用";
            CthulhuSkill[28].OrgP = 15;
            CthulhuSkill[29].SkillName = "心理学";
            CthulhuSkill[29].OrgP = 5;
            CthulhuSkill[30].SkillName = "人類学";
            CthulhuSkill[30].OrgP = 1;
            CthulhuSkill[31].SkillName = "水泳";
            CthulhuSkill[31].OrgP = 25;
            CthulhuSkill[32].SkillName = "製作";
            CthulhuSkill[32].OrgP = 5;
            CthulhuSkill[33].SkillName = "精神分析";
            CthulhuSkill[33].OrgP = 1;
            CthulhuSkill[34].SkillName = "生物学";
            CthulhuSkill[34].OrgP = 1;
            CthulhuSkill[35].SkillName = "説得";
            CthulhuSkill[35].OrgP = 15;
            CthulhuSkill[36].SkillName = "操縦";
            CthulhuSkill[36].OrgP = 1;
            CthulhuSkill[37].SkillName = "地質学";
            CthulhuSkill[37].OrgP = 1;
            CthulhuSkill[38].SkillName = "跳躍";
            CthulhuSkill[38].OrgP = 25;
            CthulhuSkill[39].SkillName = "追跡";
            CthulhuSkill[39].OrgP = 10;
            CthulhuSkill[40].SkillName = "頭突き";
            CthulhuSkill[40].OrgP = 10;
            CthulhuSkill[41].SkillName = "電気修理";
            CthulhuSkill[41].OrgP = 10;
            CthulhuSkill[42].SkillName = "電子工学";
            CthulhuSkill[42].OrgP = 1;
            CthulhuSkill[43].SkillName = "天文学";
            CthulhuSkill[43].OrgP = 1;
            CthulhuSkill[44].SkillName = "投擲";
            CthulhuSkill[44].OrgP = 25;
            CthulhuSkill[45].SkillName = "登攀";
            CthulhuSkill[45].OrgP = 40;
            CthulhuSkill[46].SkillName = "図書館";
            CthulhuSkill[46].OrgP = 25;
            CthulhuSkill[47].SkillName = "ナビゲート";
            CthulhuSkill[47].OrgP = 10;
            CthulhuSkill[48].SkillName = "値切り";
            CthulhuSkill[48].OrgP = 5;
            CthulhuSkill[49].SkillName = "博物学";
            CthulhuSkill[49].OrgP = 10;
            CthulhuSkill[50].SkillName = "物理学";
            CthulhuSkill[50].OrgP = 1;
            CthulhuSkill[51].SkillName = "変装";
            CthulhuSkill[51].OrgP = 1;
            CthulhuSkill[52].SkillName = "法律";
            CthulhuSkill[52].OrgP = 5;
            CthulhuSkill[53].SkillName = "ほかの言語";
            CthulhuSkill[53].OrgP = 1;
            CthulhuSkill[54].SkillName = "母国語";
            CthulhuSkill[54].OrgP = 1;
            CthulhuSkill[55].SkillName = "マーシャルアーツ";
            CthulhuSkill[55].OrgP = 1;
            CthulhuSkill[56].SkillName = "マシンガン";
            CthulhuSkill[56].OrgP = 15;
            CthulhuSkill[57].SkillName = "目星";
            CthulhuSkill[57].OrgP = 25;
            CthulhuSkill[58].SkillName = "薬学";
            CthulhuSkill[58].OrgP = 1;
            CthulhuSkill[59].SkillName = "ライフル";
            CthulhuSkill[59].OrgP = 25;
            CthulhuSkill[60].SkillName = "歴史";
            CthulhuSkill[60].OrgP = 20;

            // 職業と保有技能の定義
            CthulhuAct[1].ActName = "医師";
            CthulhuAct[1].ExtraSkill = 1;
            CthulhuAct[1].CandoSkills = new string[8] { CthulhuSkill[2].SkillName, CthulhuSkill[4].SkillName, CthulhuSkill[28].SkillName, CthulhuSkill[29].SkillName, CthulhuSkill[33].SkillName, CthulhuSkill[34].SkillName, CthulhuSkill[53].SkillName, CthulhuSkill[58].SkillName };
            
            CthulhuAct[2].ActName = "エンジニア";
            CthulhuAct[2].ExtraSkill = 1;
            CthulhuAct[2].CandoSkills = new string[7] { CthulhuSkill[7].SkillName, CthulhuSkill[11].SkillName, CthulhuSkill[25].SkillName, CthulhuSkill[41].SkillName, CthulhuSkill[37].SkillName, CthulhuSkill[46].SkillName, CthulhuSkill[50].SkillName };

            CthulhuAct[3].ActName = "エンターテイナー";
            CthulhuAct[3].ExtraSkill = 1;
            CthulhuAct[3].CandoSkills = new string[7] { CthulhuSkill[1].SkillName, CthulhuSkill[6].SkillName, CthulhuSkill[12].SkillName, CthulhuSkill[16].SkillName, CthulhuSkill[28].SkillName, CthulhuSkill[29].SkillName, CthulhuSkill[51].SkillName };

            CthulhuAct[4].ActName = "教授";
            CthulhuAct[4].ExtraSkill = 2;
            CthulhuAct[4].CandoSkills = new string[6] { CthulhuSkill[28].SkillName, CthulhuSkill[29].SkillName, CthulhuSkill[35].SkillName, CthulhuSkill[46].SkillName, CthulhuSkill[48].SkillName, CthulhuSkill[53].SkillName };
            
            CthulhuAct[5].ActName = "狂信者";
            CthulhuAct[5].ExtraSkill = 1;
            CthulhuAct[5].CandoSkills = new string[5] { CthulhuSkill[9].SkillName, CthulhuSkill[10].SkillName, CthulhuSkill[29].SkillName, CthulhuSkill[35].SkillName, CthulhuSkill[46].SkillName };
            
            CthulhuAct[6].ActName = "軍士官";
            CthulhuAct[6].ExtraSkill = 1;
            CthulhuAct[6].CandoSkills = new string[7] { CthulhuSkill[17].SkillName, CthulhuSkill[28].SkillName, CthulhuSkill[29].SkillName, CthulhuSkill[35].SkillName, CthulhuSkill[47].SkillName, CthulhuSkill[48].SkillName, CthulhuSkill[52].SkillName };
            
            CthulhuAct[7].ActName = "警官";
            CthulhuAct[7].ExtraSkill = 2;
            CthulhuAct[7].CandoSkills = new string[6] { CthulhuSkill[1].SkillName, CthulhuSkill[4].SkillName, CthulhuSkill[6].SkillName, CthulhuSkill[15].SkillName, CthulhuSkill[29].SkillName, CthulhuSkill[52].SkillName };
            
            CthulhuAct[8].ActName = "刑事";
            CthulhuAct[8].ExtraSkill = 1;
            CthulhuAct[8].CandoSkills = new string[7] { CthulhuSkill[1].SkillName, CthulhuSkill[12].SkillName, CthulhuSkill[29].SkillName, CthulhuSkill[35].SkillName, CthulhuSkill[48].SkillName, CthulhuSkill[52].SkillName, CthulhuSkill[57].SkillName };
            
            CthulhuAct[9].ActName = "芸術家";
            CthulhuAct[9].ExtraSkill = 0;
            CthulhuAct[9].CandoSkills = new string[7] { CthulhuSkill[1].SkillName, CthulhuSkill[16].SkillName, CthulhuSkill[24].SkillName, CthulhuSkill[29].SkillName, CthulhuSkill[32].SkillName, CthulhuSkill[57].SkillName, CthulhuSkill[60].SkillName };
            
            CthulhuAct[10].ActName = "古物研究家";
            CthulhuAct[10].ExtraSkill = 1;
            CthulhuAct[10].CandoSkills = new string[7] { CthulhuSkill[16].SkillName, CthulhuSkill[32].SkillName, CthulhuSkill[46].SkillName, CthulhuSkill[48].SkillName, CthulhuSkill[53].SkillName, CthulhuSkill[57].SkillName, CthulhuSkill[60].SkillName };
            
            CthulhuAct[11].ActName = "作家";
            CthulhuAct[11].ExtraSkill = 0;
            CthulhuAct[11].CandoSkills = new string[6] { CthulhuSkill[5].SkillName, CthulhuSkill[29].SkillName, CthulhuSkill[35].SkillName, CthulhuSkill[53].SkillName, CthulhuSkill[54].SkillName, CthulhuSkill[60].SkillName };
            
            CthulhuAct[12].ActName = "ジャーナリスト";
            CthulhuAct[12].ExtraSkill = 1;
            CthulhuAct[12].CandoSkills = new string[7] { CthulhuSkill[1].SkillName, CthulhuSkill[24].SkillName, CthulhuSkill[29].SkillName, CthulhuSkill[35].SkillName, CthulhuSkill[46].SkillName, CthulhuSkill[54].SkillName, CthulhuSkill[60].SkillName };
            
            CthulhuAct[13].ActName = "スポークスマン";
            CthulhuAct[13].ExtraSkill = 1;
            CthulhuAct[13].CandoSkills = new string[6] { CthulhuSkill[1].SkillName, CthulhuSkill[6].SkillName, CthulhuSkill[8].SkillName, CthulhuSkill[29].SkillName, CthulhuSkill[35].SkillName, CthulhuSkill[51].SkillName };
            
            CthulhuAct[14].ActName = "スポーツ選手";
            CthulhuAct[14].ExtraSkill = 1;
            CthulhuAct[14].CandoSkills = new string[7] { CthulhuSkill[6].SkillName, CthulhuSkill[26].SkillName, CthulhuSkill[31].SkillName, CthulhuSkill[38].SkillName, CthulhuSkill[44].SkillName, CthulhuSkill[45].SkillName, CthulhuSkill[55].SkillName };
            
            CthulhuAct[15].ActName = "聖職者";
            CthulhuAct[15].ExtraSkill = 1;
            CthulhuAct[15].CandoSkills = new string[7] { CthulhuSkill[12].SkillName, CthulhuSkill[17].SkillName, CthulhuSkill[29].SkillName, CthulhuSkill[35].SkillName, CthulhuSkill[46].SkillName, CthulhuSkill[53].SkillName, CthulhuSkill[60].SkillName };
            
            CthulhuAct[16].ActName = "超心理学者";
            CthulhuAct[16].ExtraSkill = 1;
            CthulhuAct[16].CandoSkills = new string[7] { CthulhuSkill[5].SkillName, CthulhuSkill[24].SkillName, CthulhuSkill[29].SkillName, CthulhuSkill[30].SkillName, CthulhuSkill[46].SkillName, CthulhuSkill[53].SkillName, CthulhuSkill[60].SkillName };
            
            CthulhuAct[17].ActName = "ディレッタント";
            CthulhuAct[17].ExtraSkill = 2;
            CthulhuAct[17].CandoSkills = new string[6] { CthulhuSkill[16].SkillName, CthulhuSkill[26].SkillName, CthulhuSkill[27].SkillName, CthulhuSkill[28].SkillName, CthulhuSkill[32].SkillName, CthulhuSkill[53].SkillName };
            
            CthulhuAct[18].ActName = "伝道者";
            CthulhuAct[18].ExtraSkill = 1;
            CthulhuAct[18].CandoSkills = new string[6] { CthulhuSkill[2].SkillName, CthulhuSkill[4].SkillName, CthulhuSkill[11].SkillName, CthulhuSkill[16].SkillName, CthulhuSkill[35].SkillName, CthulhuSkill[49].SkillName };
            
            CthulhuAct[19].ActName = "トライブ・メンバー";
            CthulhuAct[19].ExtraSkill = 1;
            CthulhuAct[19].CandoSkills = new string[7] { CthulhuSkill[5].SkillName, CthulhuSkill[12].SkillName, CthulhuSkill[31].SkillName, CthulhuSkill[44].SkillName, CthulhuSkill[48].SkillName, CthulhuSkill[49].SkillName, CthulhuSkill[57].SkillName };
            
            CthulhuAct[20].ActName = "農林業作業者";
            CthulhuAct[20].ExtraSkill = 1;
            CthulhuAct[20].CandoSkills = new string[7] { CthulhuSkill[4].SkillName, CthulhuSkill[11].SkillName, CthulhuSkill[25].SkillName, CthulhuSkill[32].SkillName, CthulhuSkill[39].SkillName, CthulhuSkill[41].SkillName, CthulhuSkill[49].SkillName };
            
            CthulhuAct[21].ActName = "パイロット";
            CthulhuAct[21].ExtraSkill = 1;
            CthulhuAct[21].CandoSkills = new string[7] { CthulhuSkill[11].SkillName, CthulhuSkill[25].SkillName, CthulhuSkill[36].SkillName, CthulhuSkill[41].SkillName, CthulhuSkill[43].SkillName, CthulhuSkill[47].SkillName, CthulhuSkill[50].SkillName };
            
            CthulhuAct[22].ActName = "ハッカー / コンサルタント";
            CthulhuAct[22].ExtraSkill = 1;
            CthulhuAct[22].CandoSkills = new string[7] { CthulhuSkill[1].SkillName, CthulhuSkill[21].SkillName, CthulhuSkill[41].SkillName, CthulhuSkill[42].SkillName, CthulhuSkill[46].SkillName, CthulhuSkill[50].SkillName, CthulhuSkill[53].SkillName };
            
            CthulhuAct[23].ActName = "犯罪者";
            CthulhuAct[23].ExtraSkill = 1;
            CthulhuAct[23].CandoSkills = new string[7] { CthulhuSkill[1].SkillName, CthulhuSkill[8].SkillName, CthulhuSkill[18].SkillName, CthulhuSkill[23].SkillName, CthulhuSkill[48].SkillName, CthulhuSkill[51].SkillName, CthulhuSkill[57].SkillName };
            
            CthulhuAct[24].ActName = "兵士";
            CthulhuAct[24].ExtraSkill = 1;
            CthulhuAct[24].CandoSkills = new string[7] { CthulhuSkill[4].SkillName, CthulhuSkill[6].SkillName, CthulhuSkill[9].SkillName, CthulhuSkill[11].SkillName, CthulhuSkill[12].SkillName, CthulhuSkill[23].SkillName, CthulhuSkill[59].SkillName };
            
            CthulhuAct[25].ActName = "弁護士";
            CthulhuAct[25].ExtraSkill = 1;
            CthulhuAct[25].CandoSkills = new string[7] { CthulhuSkill[1].SkillName, CthulhuSkill[28].SkillName, CthulhuSkill[30].SkillName, CthulhuSkill[35].SkillName, CthulhuSkill[46].SkillName, CthulhuSkill[48].SkillName, CthulhuSkill[52].SkillName };
            
            CthulhuAct[26].ActName = "放浪者";
            CthulhuAct[26].ExtraSkill = 1;
            CthulhuAct[26].CandoSkills = new string[7] { CthulhuSkill[1].SkillName, CthulhuSkill[10].SkillName, CthulhuSkill[12].SkillName, CthulhuSkill[23].SkillName, CthulhuSkill[29].SkillName, CthulhuSkill[48].SkillName, CthulhuSkill[49].SkillName };
            
            CthulhuAct[27].ActName = "ミュージシャン";
            CthulhuAct[27].ExtraSkill = 1;
            CthulhuAct[27].CandoSkills = new string[7] { CthulhuSkill[1].SkillName, CthulhuSkill[12].SkillName, CthulhuSkill[16].SkillName, CthulhuSkill[29].SkillName, CthulhuSkill[32].SkillName, CthulhuSkill[35].SkillName, CthulhuSkill[48].SkillName };

            // 狂気の定義
            PanicST = new string[11] { "", "気絶, 金切り声の発作", "パニック", "ヒステリー", "多弁症", "恐怖症", "殺人癖, 自殺癖", "幻覚, 妄想", "反響動作, 反響言語", "奇妙なものを食べたがる", "昏迷, 緊張症" };
            PanicLT = new string[11] { "", "健忘症, 昏迷, 緊張症", "恐怖症", "幻覚", "異常性癖", "フェティッシュ", "チック, 震え, コミュ障", "心因性視覚障害, 心因性難聴, 四肢不全", "心因反応", "一時的偏執症", "強迫観念的行動" };

            // 例外の定義
            KyoujuSelection = new string[12] { CthulhuSkill[2].SkillName, CthulhuSkill[7].SkillName, CthulhuSkill[19].SkillName, CthulhuSkill[30].SkillName, CthulhuSkill[34].SkillName, CthulhuSkill[37].SkillName, CthulhuSkill[42].SkillName, CthulhuSkill[43].SkillName, CthulhuSkill[49].SkillName, CthulhuSkill[50].SkillName, CthulhuSkill[52].SkillName, CthulhuSkill[60].SkillName };
            KeikanSelection = new string[5] { CthulhuSkill[3].SkillName, CthulhuSkill[26].SkillName, CthulhuSkill[48].SkillName, CthulhuSkill[55].SkillName, CthulhuSkill[57].SkillName };

            loadState = false;
            for (int i = 0; i <= 999; i++)
                notifications[i] = "";

            noticenum = 0;
        }

        // PLデータの新規作成
        private void 新規作成NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadState == true)
            {
                DialogResult result = MessageBox.Show("現在表示されているPL情報を消去し新たにPLを作成します。" + Environment.NewLine + "保存されていない情報は破棄されます。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    BasicName.Items.Clear();
                    BattleName.Items.Clear();
                    SkillName.Items.Clear();
                    AllName.Items.Clear();
                    txtResult.Text = "";
                    txtSubResult.Text = "";
                    grpBasis.Enabled = false;
                    grpSkill.Enabled = false;
                    grpBattle.Enabled = false;
                    grpAll.Enabled = false;
                    探索者情報IToolStripMenuItem.Enabled = false;
                    loadState = false;

                    newPlayer.StatusSkills = new string[11];
                    newPlayer.PlayerSkill = new Skill[61];
                    for (int i = 1; i <= 60; i++)
                    {
                        newPlayer.PlayerSkill[i].SkillName = CthulhuSkill[i].SkillName;
                        newPlayer.PlayerSkill[i].OrgP = CthulhuSkill[i].OrgP;
                    }
                    crtP = new createPL();
                    crtP.parentForm = this;
                    crtP.ShowDialog();
                    crtP.Dispose();
                }
                else
                {

                }
            }
            else
            {
                newPlayer.StatusSkills = new string[11];
                newPlayer.PlayerSkill = new Skill[61];
                for (int i = 1; i <= 60; i++)
                {
                    newPlayer.PlayerSkill[i].SkillName = CthulhuSkill[i].SkillName;
                    newPlayer.PlayerSkill[i].OrgP = CthulhuSkill[i].OrgP;
                }
                crtP = new createPL();
                crtP.parentForm = this;
                crtP.ShowDialog();
                crtP.Dispose();
            }
            
            
            
        }

        // PLデータの読み込み
        private void 読み込みLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadState == true)
            {
                DialogResult result = MessageBox.Show("現在表示されているPL情報を消去しPL情報をロードします。" + Environment.NewLine + "保存されていない情報は破棄されます。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    BasicName.Items.Clear();
                    BattleName.Items.Clear();
                    SkillName.Items.Clear();
                    AllName.Items.Clear();
                    txtResult.Text = "";
                    txtSubResult.Text = "";
                    grpBasis.Enabled = false;
                    grpSkill.Enabled = false;
                    grpBattle.Enabled = false;
                    grpAll.Enabled = false;
                    探索者情報IToolStripMenuItem.Enabled = false;

                    newPlayer.StatusSkills = new string[11];
                    newPlayer.PlayerSkill = new Skill[61];
                    for (int i = 1; i <= 60; i++)
                    {
                        newPlayer.PlayerSkill[i].SkillName = CthulhuSkill[i].SkillName;
                        newPlayer.PlayerSkill[i].OrgP = CthulhuSkill[i].OrgP;
                    }
                    Val_OpenFile(null, EventArgs.Empty);
                }
                else
                {

                }
            }
            else
            {
                Val_OpenFile(null, EventArgs.Empty);
            }
            
            
        }

        // PLデータの保存
        private void pLの管理MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Val_SaveFileAs(null, EventArgs.Empty);
            }
            catch (Exception)
            {
            }
            
        }

        private void tRPGToolの終了XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 未実装
        private void nDmロールNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 未実装
        private void 抵抗ロールRToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 一時的狂気ロールTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num = RollDice(10, 1);
            txtSubResult.Text = "10D1 = " + num;
            txtResult.Text = PanicST[num];
        }

        private void 長期一時的狂気ロールLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num = RollDice(10, 1);
            txtSubResult.Text = "10D1 = " + num;
            txtResult.Text = PanicLT[num];
        }
        
        private void nDmRollButton_Click(object sender, EventArgs e)
        {
            try
            {
                txtSubResult.Text = "";
                txtResult.Text = (RollDice(int.Parse(cmbDice.Text), int.Parse(cmbNumber.Text))).ToString();
                for (int i = 1; i <= 100; i++)
                {
                    txtSubResult.Text = txtSubResult.Text + n[i].ToString() + " ";
                    if (n[i + 1] == 0)
                        break;
                }
            }catch(Exception ex)
            {
                notifications[noticenum] = ex.ToString();
                noticenum += 1;
            }
            
        }

        private void ResRollButton_Click(object sender, EventArgs e)
        {
            try
            {
                int Per = 50 + (int.Parse(cmbNoudou.Text) * 5) - (int.Parse(cmbJudou.Text) * 5);
                if (Per >= 100)
                {
                    txtSubResult.Text = "Probability Over 100%";
                    txtResult.Text = "Auto Success";
                }
                else if (Per <= 0)
                {
                    txtSubResult.Text = "Probability Under 0%";
                    txtResult.Text = "Auto Failure";
                }
                else
                {
                    int Res = RollDice(100, 1);
                    txtSubResult.Text = "1D100 = " + Res.ToString();
                    if (Res <= Per)
                    {
                        txtResult.Text = "Success";
                    }
                    else
                    {
                        txtResult.Text = "Failure";
                    }
                }
            }catch (Exception ex)
            {
                notifications[noticenum] = ex.ToString();
                noticenum += 1;
            }
            
        }

        private void BasicRoll_Click(object sender, EventArgs e)
        {
            DetailDiceF(BasicName, BasicValue);
        }
        private void SkillRoll_Click(object sender, EventArgs e)
        {
            DetailDiceF(SkillName, SkillValue);
        }
        private void BattleRoll_Click(object sender, EventArgs e)
        {
            DetailDiceF(BattleName, BattleValue);
        }
        private void AllRoll_Click(object sender, EventArgs e)
        {
            DetailDiceF(AllName, AllValue);
        }

        private void 探索者情報IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (探索者情報IToolStripMenuItem.Checked == false)
                {
                    infP = new Information();
                    infP.parentForm = this;
                    infP.Show();
                    探索者情報IToolStripMenuItem.Checked = true;
                }
                else
                {
                    infP.Close();
                    探索者情報IToolStripMenuItem.Checked = false;
                }
            }
            catch (Exception ex)
            {
                notifications[noticenum] = ex.ToString();
                noticenum += 1;
            }
            
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void コンソールCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (コンソールCToolStripMenuItem.Checked == false)
                {
                    cons = new ConsoleForm();
                    cons.parentForm = this;
                    cons.Show();
                    コンソールCToolStripMenuItem.Checked = true;
                }
                else
                {
                    cons.Close();
                    コンソールCToolStripMenuItem.Checked = false;
                }
            }
            catch (Exception ex)
            {
                notifications[noticenum] = ex.ToString();
                noticenum += 1;
            }
            
        }

        // 名前を付けて保存の関数
        private void Val_SaveFileAs(object sender, EventArgs e)
        {
            sfd = new SaveFileDialog();
            sfd.Filter = "XMLファイル(*.xml)|*.xml|すべてのファイル(*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.FileName = "*.xml";
            DialogResult result = new DialogResult();
            result = sfd.ShowDialog();

            XmlSerializer serializer = new XmlSerializer(typeof(Player));
            StreamWriter sw = new StreamWriter(sfd.FileName, false, new System.Text.UTF8Encoding(false));

            if (result == DialogResult.OK)
            {
                access = Path.GetFullPath(sfd.FileName);
                serializer.Serialize(sw, newPlayer);
                sw.Close();
            }
            else
            {
            }

        }

        // PLデータを開く関数
        private void Val_OpenFile(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "XMLファイル(*.xml)|*.xml|すべてのファイル(*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                access = Path.GetFullPath(ofd.FileName);
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Player));
                    StreamReader sr = new StreamReader(ofd.FileName, new System.Text.UTF8Encoding(false));
                    newPlayer = (Player)serializer.Deserialize(sr);
                    sr.Close();

                    // コンソールへの出力
                    notifications[noticenum] = "Create new PL: "; noticenum += 1;
                    notifications[noticenum] = "Name " + newPlayer.Name; noticenum += 1;
                    notifications[noticenum] = "Age " + newPlayer.Age; noticenum += 1;
                    notifications[noticenum] = "Sex " + newPlayer.Sex; noticenum += 1;
                    notifications[noticenum] = "Actor " + newPlayer.Actor; noticenum += 1;
                    notifications[noticenum] = "STR " + newPlayer.STR; noticenum += 1;
                    notifications[noticenum] = "DEX " + newPlayer.DEX; noticenum += 1;
                    notifications[noticenum] = "INT " + newPlayer.INT; noticenum += 1;
                    notifications[noticenum] = "CON " + newPlayer.CON; noticenum += 1;
                    notifications[noticenum] = "APP " + newPlayer.APP; noticenum += 1;
                    notifications[noticenum] = "POW " + newPlayer.POW; noticenum += 1;
                    notifications[noticenum] = "SIZ " + newPlayer.SIZ; noticenum += 1;
                    notifications[noticenum] = "EDU " + newPlayer.EDU; noticenum += 1;
                    notifications[noticenum] = "HP " + newPlayer.HP; noticenum += 1;
                    notifications[noticenum] = "MP " + newPlayer.MP; noticenum += 1;
                    notifications[noticenum] = "SAN " + newPlayer.SAN; noticenum += 1;
                    notifications[noticenum] = "Idea " + newPlayer.Idea; noticenum += 1;
                    notifications[noticenum] = "Luck " + newPlayer.Luck; noticenum += 1;
                    notifications[noticenum] = "Knowledge " + newPlayer.Knowledge; noticenum += 1;
                    notifications[noticenum] = "damage bonus " + newPlayer.db; noticenum += 1;
                    for (int i = 1; i <= 60; i++)
                    {
                        notifications[noticenum] = newPlayer.PlayerSkill[i].SkillName + newPlayer.PlayerSkill[i].OrgP;
                        noticenum += 1;
                    }

                    // 基本値ロールの追加
                    BasicName.Items.Add("アイデア " + newPlayer.Idea);
                    BasicName.Items.Add("幸運 " + newPlayer.Luck);
                    BasicName.Items.Add("知識 " + newPlayer.Knowledge);
                    BasicName.Items.Add(newPlayer.PlayerSkill[6].SkillName + " " + newPlayer.PlayerSkill[6].OrgP);

                    // 職業ロールの追加
                    for (int i = 1; i <= 10; i++)
                    {
                        if ((newPlayer.StatusSkills[i] != null) && (newPlayer.StatusSkills[i] != " 0") && (newPlayer.StatusSkills[i] != "選択不可 0"))
                        {
                            SkillName.Items.Add(newPlayer.StatusSkills[i]);
                        }
                        else
                        {
                        }
                    }

                    // 戦闘ロールの追加
                    BattleName.Items.Add(newPlayer.PlayerSkill[13].SkillName + " " + newPlayer.PlayerSkill[13].OrgP);
                    BattleName.Items.Add(newPlayer.PlayerSkill[15].SkillName + " " + newPlayer.PlayerSkill[15].OrgP);
                    BattleName.Items.Add(newPlayer.PlayerSkill[18].SkillName + " " + newPlayer.PlayerSkill[18].OrgP);
                    BattleName.Items.Add(newPlayer.PlayerSkill[20].SkillName + " " + newPlayer.PlayerSkill[20].OrgP);
                    BattleName.Items.Add(newPlayer.PlayerSkill[22].SkillName + " " + newPlayer.PlayerSkill[22].OrgP);
                    BattleName.Items.Add(newPlayer.PlayerSkill[27].SkillName + " " + newPlayer.PlayerSkill[27].OrgP);
                    BattleName.Items.Add(newPlayer.PlayerSkill[40].SkillName + " " + newPlayer.PlayerSkill[40].OrgP);
                    BattleName.Items.Add(newPlayer.PlayerSkill[55].SkillName + " " + newPlayer.PlayerSkill[55].OrgP);
                    BattleName.Items.Add(newPlayer.PlayerSkill[56].SkillName + " " + newPlayer.PlayerSkill[56].OrgP);
                    BattleName.Items.Add(newPlayer.PlayerSkill[59].SkillName + " " + newPlayer.PlayerSkill[59].OrgP);

                    // 全てロールの追加
                    AllName.Items.Add("アイデア " + newPlayer.Idea);
                    AllName.Items.Add("幸運 " + newPlayer.Luck);
                    AllName.Items.Add("知識 " + newPlayer.Knowledge);
                    for (int i = 1; i <= 60; i++)
                    {
                        AllName.Items.Add(newPlayer.PlayerSkill[i].SkillName + " " + newPlayer.PlayerSkill[i].OrgP);
                    }

                    PLStatusLabel.Text = newPlayer.Name + " |";
                    POWStatusLabel.Text = "HP: " + newPlayer.CurHP.ToString() + " |";
                    MPStatusLabel.Text = "MP: " + newPlayer.CurMP.ToString() + " |";
                    SANStatusLabel.Text = "SAN: " + newPlayer.CurSAN.ToString() + " |";

                    grpBasis.Enabled = true;
                    grpSkill.Enabled = true;
                    grpBattle.Enabled = true;
                    grpAll.Enabled = true;
                    探索者情報IToolStripMenuItem.Enabled = true;
                    loadState = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
