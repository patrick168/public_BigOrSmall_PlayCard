using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guest_Big_Small
{
    public partial class Form1 : Form
    {
        string[] d = new string[54];  //紙牌路徑
        static int[] numbers = new int[52];        //紙牌編碼
        static List<int> cardNumList = new List<int>();
        static int pcWin,playerWin;

        bool gameover; //判斷是否還有籌碼和排堆還有沒有牌，沒籌碼或沒牌則遊戲結束      

        string topText = "A最大，2最小。";

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            gameover = false;
            EnableButton(false);
            infolabel.Text = string.Empty;
            lbtoptext.Text = topText;
            pcWin = 0; playerWin=0;
            lbwinlose.Text = "";

            //撲克牌圖案建置
            string picPath = GetDirectory("pic");      
            for (int i = 0; i <= 52; i++)
                d[i] = picPath + @"\g" + i.ToString() + ".jpg";

            shuffle_playcard();
        }

        //取得撲克牌檔案路徑
        private string GetDirectory(string name)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(Application.StartupPath);
            string path = (dir.Parent).Parent.FullName;
            return path + string.Format(@"\{0}\", name);
        }

        private void shuffle_playcard()
        {
            cardNumList.Clear();
            int i, rnum, temp;
         
            //隨機出一張牌
            Random ran = new Random();
            for (i = 0; i < 52; i++)
            {
                numbers[i] = i;
            }

            for (i = 0; i < 52; i++)
            {
                rnum = ran.Next(51);
                temp = numbers[i];
                numbers[i] = numbers[rnum];
                numbers[rnum] = temp;
            }

            foreach (int n in numbers)            
            {
                cardNumList.Add(n);
            }
        }

        private void DealTest_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 25; i++)
                opencard(true);
        }

        //按下發牌
        private void btnDeal_Click(object sender, EventArgs e)
        {
            EnableButton(true);
            pictureBox1.Image = Image.FromFile(@d[52]);//蓋牌
            pictureBox2.Image = Image.FromFile(@d[52]);//蓋牌
            //應該改成玩家不蓋牌
            
         
            //opencard(true);

            if (gameover)
            {
                lbtoptext.Text = topText;
                btnDeal.Text = "發牌";
                tbmoney.Text = "10";
                lbmoney.Text = "100";
                pcWin = 0;
                playerWin = 0;
                leftWin.Text = "0";
                rightWin.Text = "0";
                gameover = false;
            }

        }      

        //下注完成開牌 
        public void opencard(bool guessbigsmall)
        {           
            bool isBig = true;
         
            int playermoney;
            int[] gameCardNO = new int[2];

            int[] point = new int[2];
            int[] flower=new int[2];
           

            if (!Int32.TryParse(lbmoney.Text, out playermoney))
            {
                playermoney = 0;
            }
            int betMoney;
            if (!Int32.TryParse(tbmoney.Text, out betMoney))
            {
                betMoney = 0;
                MessageBox.Show("下注金額請輸入整數數字");
                return;
            }

            if (betMoney > 0 && betMoney <= playermoney)  //押注金額>0並且<=剩下籌碼
            {
                EnableButton(false); //隱藏按鈕

                if (cardNumList.Count>0)
                {
                    pictureBox1.Image = Image.FromFile(@d[cardNumList[0]]);
                    pictureBox2.Image = Image.FromFile(@d[cardNumList[1]]);
                    for (int i = 0; i < 2; i++)
                    {
                        gameCardNO[i] = cardNumList[0];
                        cardNumList.RemoveAt(0);                      
                    }                
                }
                
                int cardRate = -1;            
                infolabel.Text = "";

                for (int i = 0; i < 2; i++)
                {
                    flower[i] = (byte)gameCardNO[i] % 4;       //花色
                    if (gameCardNO[i] / 4 == 0)
                    { point[i] = 13; }
                    else
                    { point[i] = gameCardNO[i] / 4; }            //點數
                }

                //相同點數直接可以從數字比，但是這裡還是練習一下用花色來比較大小
                if (point[1]<=point[0])
                {
                    isBig = false; //玩家小
                    if (point[1] == point[0])
                    {
                        if (flower[1] > flower[0])
                        {
                            isBig = true; //玩家大
                        }
                    }                  
                }

                lbwinlose.Text = "你輸了";
              
                //玩家押對時的設定，預設已經是玩家押錯，只有勝場數需要做增加動作
                if (guessbigsmall == isBig) 
                {
                    playerWin++;
                    lbwinlose.Text = "你贏了";
                    cardRate = 1;                  
                    rightWin.Text = playerWin.ToString();
                }
                else
                {
                    pcWin++;
                    leftWin.Text = pcWin.ToString();
                }

                playermoney += betMoney * cardRate;
                lbmoney.Text = playermoney.ToString();

                //籌碼輸光
                if (playermoney <= 0)
                {
                    btnDeal.Text = "重新開始";
                    lbtoptext.Text = "你破產了，請按重新開始";
                    gameover = true;
                }
                else if(pcWin+playerWin==26)
                {
                    btnDeal.Text = "重新開始";
                    lbtoptext.Text = string.Format(@"本局結束，比賽結果{0}:{1}，請按重新開始",pcWin,playerWin);
                    gameover = true;
                }
            }

            else
            {
                MessageBox.Show("請輸入大於0並且小於等於剩餘籌碼的金額。");
            }
        }

        private void btnbig_Click(object sender, EventArgs e)
        {    
            opencard(true); //猜大
        }

        private void btnsmall_Click(object sender, EventArgs e)
        {           
            opencard(false); //猜小
        }

        private void EnableButton(bool isEnable)
        {
            btnbig.Enabled = isEnable;
            btnsmall.Enabled = isEnable;        
            btnDeal.Enabled = !isEnable;
        }

      

        //按下結束遊戲
        private void btnend_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("你確定要結束遊戲嗎?","結束遊戲", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }  
        }
    }
}