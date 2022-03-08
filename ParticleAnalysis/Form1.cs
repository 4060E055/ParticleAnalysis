using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;



namespace ParticleAnalysis
{

    public partial class Form1 : Form
    {
        //宣告繪圖工具
        Bitmap Bee;
        Graphics g;
        public Form1()
        {
            InitializeComponent();

            //Set lablel's background color
            labelBackcolor(trackBar.Value);

        }


        private void SetBar(int step, int Max_2Length, int nowValue = 0)
        {//progress bar設定
            AnyProgressBar.Value = nowValue;
            AnyProgressBar.Step = step;
            AnyProgressBar.Maximum = Max_2Length;
        }

        public class Global

        {//全域 放處理完的粒子電壓數據資料

            public static double[,] PositiveData;

        }

        private void StartShow_Click(object sender, EventArgs e)
        {
            try
            {
                //設定進度條(step,max,now value=0)
                SetBar(1, 100, 0);

                //**這邊進度條暫且先手動設定比例，待未來找到適當計算比例方法
                AnyProgressBar.Value += AnyProgressBar.Step * 6;
                //Get all txt's data
                string[] AllData = LoadingData(dataList.Text);


                //Get 處理後的粒子電壓資料(去程資料)
                Global.PositiveData = DataProcess(AllData);

                AnyProgressBar.Value += AnyProgressBar.Step * 14;

                //draw picture
                Draw(Global.PositiveData);


                AnyProgressBar.Value += AnyProgressBar.Step * 20;
                //計算粒子數量
                GetAmount(Global.PositiveData);
                trackBar.Enabled = true;
                saveIMG.Enabled = true;


                //degug--------------------------------------
                if (checkBox3.Checked == true)
                {
                    Console.WriteLine();
                    Console.WriteLine(checkBox3.Text);

                    //debug觀察所有對應位置電壓(正確)判斷為粒子才顯示
                    for (int i = 0; i < Global.PositiveData.GetLength(0); i++)//debug  
                    {
                        Console.Write(String.Format("{0,3}", (i + 1)) + "：");
                        for (int j = 0; j < Global.PositiveData.GetLength(1); j += 1)
                        {
                            if (Global.PositiveData[i, j] > -2.0F)
                            {
                                Console.Write(String.Format("{0,7}", Global.PositiveData[i, j]));
                            }
                            else
                            {
                                Console.Write("_______");
                            }
                        }
                        Console.Write(" ：" + (i + 1));
                        Console.WriteLine();
                    }
                }

                // debug觀察所有粒子電壓(全部資料)
                if (checkBox6.Checked == true)
                {
                    Console.WriteLine();
                    Console.WriteLine(checkBox6.Text);
                    for (int i = 0; i < Global.PositiveData.GetLength(0); i++)//debug  
                    {

                        Console.Write(String.Format("{0,3}", (i + 1)) + "：");
                        for (int j = 0; j < Global.PositiveData.GetLength(1); j++)//debug  
                        {
                            Console.Write(String.Format("{0,7}", Global.PositiveData[i, j]));

                        }
                        Console.Write(" ：" + (i + 1));
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }  //degug end--------------------------------------



            }
            catch (Exception x)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file is error. Please change open file.");
                Console.WriteLine(x.Message);
                AnyProgressBar.Value = 0;
            }


        }

        private void GetAmount(double[,] PositiveData)
        {// Count the number of particles

            //給予同顆粒子編號
            (int[,] NumLocation, int max) = SetNumLocation(PositiveData);


            double[,] Num = new double[max - 1, 2];// [該編號數量(目前沒用到) 該編號電壓最大值]

            for (int i = 0; i < NumLocation.GetLength(0); i++)
            {
                for (int j = 0; j < NumLocation.GetLength(1); j++)
                {
                    if (NumLocation[i, j] > 0)
                    {
                        //ex:若編號為116 ，Num[115,0]的位置數量+1
                        Num[NumLocation[i, j] - 1, 0] += 1;//計算形成該粒子的數據數量
                        if (PositiveData[i, j] > Num[NumLocation[i, j] - 1, 1])//找出該範圍最大電壓大小值
                        {
                            Num[NumLocation[i, j] - 1, 1] = PositiveData[i, j];
                        }
                    }

                }
            }

            //Print Particle count
            AddAndShow(Num);

        }
        private void AddAndShow(double[,] Num)
        {
            int a = 0, b = 0, c = 0, d = 0, e = 0, f = 0;//-2~10
            int total = 0;//總數

            for (int i = 0; i < Num.GetLength(0); i++)
            {
                if (Num[i, 0] != 0)
                {
                    if (Num[i, 1] > 8.0F)
                    {
                        a += 1;
                    }
                    else if (Num[i, 1] > 6.0F)
                    {
                        b += 1;
                    }
                    else if (Num[i, 1] > 4.0F)
                    {
                        c += 1;
                    }
                    else if (Num[i, 1] > 2.0F)
                    {
                        d += 1;
                    }
                    else if (Num[i, 1] > 0.0F)
                    {
                        e += 1;
                    }
                    else if (Num[i, 1] > -2.0F)
                    {
                        f += 1;
                    }
                }
            }
            count06.Text = "";
            count05.Text = "";
            count04.Text = "";
            count03.Text = "";
            count02.Text = "";
            count01.Text = "";


            if (size01.Checked == true)
            {
                count01.Text = a.ToString();
                total += a;
            }
            if (size02.Checked == true)
            {
                count02.Text = b.ToString();
                total += b;
            }
            if (size03.Checked == true)
            {
                count03.Text = c.ToString();
                total += c;
            }
            if (size04.Checked == true)
            {
                count04.Text = d.ToString();
                total += d;
            }
            if (size05.Checked == true)
            {
                count05.Text = e.ToString();
                total += e;
            }
            if (size06.Checked == true)
            {
                count06.Text = f.ToString();
                total += f;
            }

            totalBox.Text = total.ToString();

        }


        private (int[,], int) SetNumLocation(double[,] PositiveData)
        {//粒子分群(同一個粒子的電壓分類到同一編號)
            int[,] NumLocation = new int[PositiveData.GetLength(0), PositiveData.GetLength(1)];//編號位置

            int max = 0;//給予粒子編號用，並非用來計算粒子編號

            for (int i = 1; i < NumLocation.GetLength(0) - 1; i++)
            {//從左到右
                for (int j = 1; j < NumLocation.GetLength(1) - 1; j++)
                {//從上到下
                    for (int k = -1; k <= 1; k++)
                    {//九宮格的縱向
                        if (PositiveData[i, j] > -2.0F)//判斷中心點位置是否是粒子
                        {
                            for (int z = -1; z <= 1; z++)
                            {//九宮格的橫向
                                if (PositiveData[i + z, j + k] > -2.0F)//判斷周圍九宮格位置是否為粒子(逐一比對)
                                {
                                    (NumLocation[i, j], NumLocation[i + z, j + k], max) =
                                        JudgmentPosition(NumLocation[i, j], NumLocation[i + z, j + k], max);
                                }
                            }
                            if (NumLocation[i, j] == 0 && k == 0)//中心點 獨立一點+1
                            {// 九宮格的最上排都沒粒子編號的狀態才給予新的粒子編號
                                max += 1;
                                NumLocation[i, j] = max;
                            }
                        }
                    }
                }
            }

            //微調編號錯誤部分
            for (int i = NumLocation.GetLength(0) - 1; i >= 0; i--)
            {//右至左
                for (int j = NumLocation.GetLength(1) - 1; j >= 0; j--)
                {//下至上
                    if (NumLocation[i, j] != 0 && NumLocation[i, j - 1] != 0)
                    {//逐一比對，取較小粒子編號部分
                        if (j - 1 >= 0)
                        {
                            if (NumLocation[i, j - 1] > NumLocation[i, j])//從下到上
                            {
                                NumLocation[i, j - 1] = NumLocation[i, j];
                            }
                        }
                        if (i - 1 >= 0)
                        {
                            if (NumLocation[i - 1, j] > NumLocation[i, j])//從右到左
                            {
                                NumLocation[i - 1, j] = NumLocation[i, j];
                            }
                        }

                    }
                }
            }


            //debug觀察粒子編號
            if (checkBox2.Checked == true)
            {
                Console.WriteLine();
                Console.WriteLine(checkBox2.Text);
                for (int i = 0; i < NumLocation.GetLength(0); i++)//debug  
                {
                    Console.Write(String.Format("{0,3}", i + 1) + "：");
                    for (int j = 0; j < NumLocation.GetLength(1); j += 1)
                    {
                        // Console.Write(NumLocation[i, j]);
                        if (NumLocation[i, j] == 0)
                        {
                            Console.Write(String.Format("____"));
                        }
                        else
                        {
                            Console.Write(String.Format("{0,4}", NumLocation[i, j]));
                        }
                    }
                    Console.Write("：" + String.Format("{0,3}", i + 1));
                    Console.WriteLine();
                }
            }
            return (NumLocation, max);
        }


        private (int, int, int) JudgmentPosition(int before, int after, int count)
        {
            //aftel = other localtion
            //befor = now localtion
            if (after != 0 && after < before)//如果after有粒子編號 且 after的粒子編號小於before的
            {//取最小粒子編號的覆蓋
                before = after;
            }
            else if (after != 0 && after > before)//如果after有粒子編號 且 after的粒子編號大於before的
            {//取最小粒子編號的覆蓋
                after = before;
            }
            else if (after == 0)//如果after無粒子編號則給予新的粒子編號
            {
                count += 1;
                after = count;
            }

            return (before, after, count);
        }

        private void Draw(double[,] ParticleSize)
        {

            //定義筆刷顏色
            Brush[] brushColor = SetBrushColor();
            
            //取得深淺值
            int val = trackBar.Value;
    

            for (int i = 0; i < ParticleSize.GetLength(0); i++)//y
            {//依照顏色區間依序畫點

                for (int j = 0; j < ParticleSize.GetLength(1); j++)//x
                {
                    //**有閒的話再把checkbox寫成物件陣列，這樣這部分能寫成迴圈
                    if (ParticleSize[i, j] >= 8.0F && ParticleSize[i, j] < 10.0F && size01.Checked == true)//8~10
                    {
                        g.FillPie(brushColor[10 + val], j, i, 2, 2, 0, 360);
                    }
                    else if (ParticleSize[i, j] >= 6.0F && ParticleSize[i, j] < 8.0F && size02.Checked == true)//6~8
                    {
                        g.FillPie(brushColor[8 + val], j, i, 2, 2, 0, 360);
                    }
                    else if (ParticleSize[i, j] >= 4.0F && ParticleSize[i, j] < 6.0F && size03.Checked == true)//4~6
                    {
                        g.FillPie(brushColor[6 + val], j, i, 2, 2, 0, 360);
                    }
                    else if (ParticleSize[i, j] >= 2.0F && ParticleSize[i, j] < 4.0F && size04.Checked == true)//2~4
                    {
                        g.FillPie(brushColor[4 + val], j, i, 2, 2, 0, 360);
                    }
                    else if (ParticleSize[i, j] >= 0.0F && ParticleSize[i, j] < 2.0F && size05.Checked == true)//0~2
                    {
                        g.FillPie(brushColor[2 + val], j, i, 2, 2, 0, 360);

                    }
                    else if (ParticleSize[i, j] >= -2.0F && ParticleSize[i, j] < 0.0F && size06.Checked == true)//-2~0
                    {
                        g.FillPie(brushColor[val], j, i, 2, 2, 0, 360);

                    }

                }

            }

            show.Image = Bee;//show picture

        }
        private Brush[] SetBrushColor()
        {//定義筆刷顏色陣列顏色


            //string[] hex = { "#FAF4FF", "#F1E1FF", "#E6CAFF", "#DCB5FF", "#D3A4FF", "#CA8EFF", "#BE77FF",
            //    "#B15BFF", "#9F35FF", "#921AFF", "#8600FF", "#6F00D2", "#5B00AE", "#4B0091", "#3A006F", "#28004D" };

            //淺紫到深紫顏色
            int[,] colorNum = { { 250, 244, 255 }, { 241,225,255},{ 230,202,255},{ 220,181,255},{ 211,164,255},
                { 202,142,255},{190,119,255 } ,{ 177,91,255} ,{ 159,53,255},{146,26,255 } ,{134,0,255 },{111,0,210 },
                { 91,0,174},{75,0,145 },{58,0,111 },{40,0,77 } };

            //Color[] _color = new Color[hex.Length];
            Brush[] brushColor = new SolidBrush[colorNum.GetLength(0)];
            for (int i = 0; i < brushColor.Length; i++)
            {
                //  _color[i] = System.Drawing.ColorTranslator.FromHtml(hex[i]);
                //要轉換成筆刷顏色
                brushColor[i] = new SolidBrush(Color.FromArgb(255, colorNum[i, 0], colorNum[i, 1], colorNum[i, 2]));
            }

            return brushColor;
        }

        private double[,] DataProcess(string[] AllData)
        {
            //data(電壓位準，電壓大小)  HighMax=尾電壓最大值(高點) LowMin=頭電壓最小值(低點)
            (double[,] data, double HighMax, double LowMin) = SplitAllData(AllData);


            //只取向上位準(去程)，並按照二維不規則陣列位置放置
            double[][] PositiveData = GetPositive(data, HighMax, LowMin);

            //取得橫排數量的眾數 
            int MaxLengthCount = GetLengthCount(PositiveData);
            AnyProgressBar.Value += AnyProgressBar.Step * 10;

            double[,] ProcessedData = new double[PositiveData.Length, MaxLengthCount];
            int n = 0;

            //根據眾數 少前補 多刪  統一長度為橫排眾數長度
            for (int i = 0; i < PositiveData.Length; i++)
            {
                n = 0;
                if (PositiveData[i].Length <= MaxLengthCount)//前補位
                {

                    n = MaxLengthCount - PositiveData[i].Length;
                    for (int j = 0; j < n; j++)//少多少補多少
                    {
                        ProcessedData[i, j] = -4.0F;//設定-4為平面
                    }

                    for (int j = 0; j < PositiveData[i].Length; j++)//多刪
                    {
                        ProcessedData[i, j + n] = PositiveData[i][j];
                    }

                }
                else if (PositiveData[i].Length > MaxLengthCount)
                {
                    for (int j = 0; j < MaxLengthCount; j++)//694
                    {
                        ProcessedData[i, j + n] = PositiveData[i][j];

                    }
                }
            }
            AnyProgressBar.Value += AnyProgressBar.Step * 5;

            // debug觀察每行(橫)數據長度
            if (checkBox5.Checked == true)
            {
                Console.WriteLine();
                Console.WriteLine("每行(橫)數據長度");
                for (int i = 1; i <= PositiveData.Length; i++)//debug  
                {
                    Console.Write(i + "：" + PositiveData[i - 1].Length + " 　");

                    if (i % 10 == 0)
                        Console.WriteLine();
                }
                Console.WriteLine();
            }

            // debug觀察所有粒子電壓(全部資料)
            if (checkBox9.Checked == true)
            {
                Console.WriteLine();
                Console.WriteLine(checkBox9.Text);
                for (int i = 0; i < PositiveData.Length; i++)//debug  
                {
                    Console.Write(String.Format("{0,3}", (i + 1)) + "：");
                    for (int j = 0; j < PositiveData[i].Length; j += 1)
                    {
                        if (Convert.ToDouble(PositiveData[i][j]) > -2.0F)
                        {
                            Console.Write(String.Format("{0,7}", PositiveData[i][j]));
                        }
                        else
                        {
                            Console.Write("_______");
                        }

                    }
                    Console.Write(" ：" + (i + 1));
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            //debug
            if (checkBox11.Checked == true)
            {
                Console.WriteLine();
                Console.WriteLine(checkBox11.Text);
                Console.WriteLine("一維：" + ProcessedData.GetLength(0));
                Console.WriteLine("二維：" + ProcessedData.GetLength(1));
            }


            return ProcessedData;
        }



        private int GetLengthCount(double[][] PositiveData)
        {
            int[] LengthNum = new int[PositiveData.Length];//每橫排長度

            for (int i = 0; i < PositiveData.Length; i++)//debug  
            {
                LengthNum[i] = PositiveData[i].Length;//取出每橫長度

            }
            
            Dictionary<int, int> LengthCount = new Dictionary<int, int>();//LINQ
            AnyProgressBar.Value += AnyProgressBar.Step * 5;

            foreach (var s in LengthNum.GroupBy(c => c))
            {
                LengthCount.Add(s.Key, s.Count());//橫排長度種類:數量

            }
            AnyProgressBar.Value += AnyProgressBar.Step * 5;

            //根據數量(value)大到小排序
            LengthCount = LengthCount.OrderByDescending(o => o.Value).ToDictionary(o => o.Key, p => p.Value);

            int max = 0;//眾數
            foreach (var OneItem in LengthCount)//只取最大橫排長度數量(第一項取得就跳出迴圈)
            {
                max = OneItem.Key;
                break;
            }

            //debug
            if (checkBox5.Checked == true)
            {
                Console.WriteLine("");
                Console.WriteLine(checkBox5.Text);


                foreach (KeyValuePair<int, int> k in LengthCount)
                {
                    Console.WriteLine(k.Key + " 出現 " + k.Value + " 次");
                }
            }

            return max;
        }


        private double[][] GetPositive(double[,] data, double HighMax, double LowMin)
        {//只取向上位準，不取向下位準的資料，並將資料依照位準放置二維不規則陣列
            int Max_2Length = 0;//找出一維最大長度

            string line = "";//暫存每橫向所有資料連結
            string line11 = "";//debug
            string[] line22;//debug
            double[][] ParticelSize = new double[0][];
            string[] line2;//分割每橫排，放進陣列用
            double aum = 0.0F;//debug
            double aum2 = 0.0F;//debug
            double aumMax = -99F;//debug
            double aum2Min = 100F;//debug
            double aum2Max = -99F;//debug
            double aumMin = 100F;//debug

            HighMax *= 0.9926F;//**看狀況更改加成比例，配合掃描機台輸出的數據集
            LowMin *= 0.9926F;//**看狀況更改加成比例，配合掃描機台輸出的數據集

            bool TF = data[0, 0] < data[1, 0];//  TF 用來判定資料目前向上(去程)or向下(回程)
            bool upDown = false;//此為確保一定要從第一個底點開始取至高點 如果到達第一個底點，則值為T

            bool TF2 = TF;//用於判斷資料是否到達頂點or底點  此為前一個TF值


            //判斷從底點至頂點那段  一一連結成一string 最後再分割後放進不規則陣列中
            for (int i = 0; i < data.GetLength(0) - 1; i++)
            {
                //判斷目前向上True or 向下False

                TF = data[i, 0] < data[i + 1, 0];


                if (TF != TF2 && (data[i, 0] > HighMax || LowMin > data[i, 0]))//判斷 底點or頂點 f/t
                {
                    TF2 = TF;

                    if (TF == false && upDown == true)//頂點
                    {
                        upDown = false;

                        line += data[i, 1];//連結去程電壓大小資料

                        line11 += data[i, 0];//debug
                        line2 = line.Split('+');//分割去程電壓大小資料

                        if (line2.Length > Max_2Length)//找出一維最長段
                        {
                            Max_2Length = line2.Length;
                            // Console.WriteLine(Max_2Length);
                        }


                        Array.Resize(ref ParticelSize, ParticelSize.Length + 1);//重新定義陣列大長度

                        //把一整段分割後的去程資料轉成double再丟進一維不規則陣列中
                        ParticelSize[ParticelSize.Length - 1] = Array.ConvertAll<string, double>(line2, value => Convert.ToDouble(value));

                        line22 = line11.Split('+');//debug

                        if (line22.Length == 2 || line22.Length == 1)
                        {
                            Console.WriteLine("debug：" + line11);
                            Console.WriteLine("第" + (i + 1) + "行：");
                        }


                        //debug
                        if (checkBox8.Checked == true)
                        {
                            Console.WriteLine();
                            Console.WriteLine(checkBox8.Text);

                            if (ParticelSize.Length == Convert.ToInt16(textBox1.Text))
                            {
                                Console.WriteLine(textBox1.Text + "行電壓&電壓位準：");
                                Console.WriteLine(line);
                                Console.WriteLine(line11);
                                Console.WriteLine("第" + (i - line2.Length + 2) + "行到第" + (i + 1) + "行：");
                            }
                        }

                        if (checkBox7.Checked == true)
                        {
                            Console.WriteLine();
                            Console.WriteLine(checkBox7.Text);
                            Console.WriteLine(ParticelSize.Length + "：" + line22[0] + " " + line22[line22.Length - 1] + " " +
                              (Convert.ToDouble(line22[line22.Length - 1]) - Convert.ToDouble(line22[0])));//debub每段頭尾

                        }

                        aum += Convert.ToDouble(line22[0]);//debug
                        aum2 += Convert.ToDouble(line22[line22.Length - 1]);//debug

                        //debug
                        if (aumMin > Convert.ToDouble(line22[0]))
                        {
                            aumMin = Convert.ToDouble(line22[0]);
                        }
                        if (aumMax < Convert.ToDouble(line22[0]))
                        {
                            aumMax = Convert.ToDouble(line22[0]);
                        }
                        if (aum2Max < Convert.ToDouble(line22[line22.Length - 1]))
                        {
                            aum2Max = Convert.ToDouble(line22[line22.Length - 1]);
                        }
                        if (aum2Min > Convert.ToDouble(line22[line22.Length - 1]))
                        {
                            aum2Min = Convert.ToDouble(line22[line22.Length - 1]);
                        }


                        line = "";
                        line11 = "";//debug

                    }

                    else if (TF == true && data[i, 0] < LowMin)//底點
                    {
                        upDown = true;

                        line += data[i, 1] + "+";//連結電壓大小資料

                        line11 += data[i, 0] + "+";//debug

                        //if (data[i - 1, 0] == data[i, 0])//如果底點與前一項一樣(重複狀況)
                        //{
                        //    line += data[i - 1, 1] + "+";
                        //    line11 += data[i - 1, 0] + "+";//debug
                        //}
                    }
                }
                else if (upDown == true)//已到達過底點則為T
                {//取向上且非頂點部分
                    TF2 = TF;

                    line += data[i, 1] + "+";

                    line11 += data[i, 0] + "+";//debug
                }


            }
            AnyProgressBar.Value += AnyProgressBar.Step * 30;

            SetCanvas(Max_2Length, ParticelSize.Length);//設定畫布  寬,長

            if (checkBox1.Checked == true)
            {
                Console.WriteLine();
                Console.WriteLine(checkBox1.Text);
                Console.WriteLine("頭電壓均值：" + (aum / 540.0));
                Console.WriteLine("尾電壓均值：" + (aum2 / 540.0));
                Console.WriteLine("頭尾電壓差值：" + ((aum2 - aum) / 540));
            }
            if (checkBox10.Checked == true)
            {
                Console.WriteLine();
                Console.WriteLine(checkBox10.Text);
                Console.WriteLine("頭電壓最大值：" + aumMax);
                Console.WriteLine("頭電壓最小值：" + aumMin);
                Console.WriteLine("尾電壓最大值：" + aum2Max);
                Console.WriteLine("尾電壓最小值：" + aum2Min);
            }

            AnyProgressBar.Value += AnyProgressBar.Step * 5;
            return ParticelSize;

        }

        private void SetCanvas(int Max_2Length, int n)
        {
            // Console.WriteLine(Max_2Length + 10);
            show.Width = Max_2Length + 2;
            show.Height = n + 2;
            //show.BackColor = Color.DarkGray;

            g.Clip = new Region(new Rectangle(0, 0, Max_2Length+1, n+1));//設定畫布大小
            g.Clear(Color.MistyRose);

        }


        private (double[,], double, double) SplitAllData(string[] AllData)
        {//取得數據前兩筆資料並轉換成double的不規則陣列

            double[,] data = new Double[AllData.Length, 2];//取前兩筆資料(電壓位準，電壓大小)
            double HighMax = -99F;//尾電壓位準最大
            double LowMin = 99F;//頭電壓位準最小
            double SizeMax = -99F;//電壓大小最大值
            double SizeMin = 99F;//電壓大小最小值

            data[0, 0] = Convert.ToDouble(AllData[0].Split(';')[0]);

            for (int i = 1; i < AllData.Length; i++)
            {
                //平滑運算，加權取電壓位準，用於避免重複電壓位準
                data[i, 0] = Convert.ToDouble(AllData[i].Split(';')[0]) * 0.8 + data[i - 1, 0] * 0.2;
                data[i, 1] = Convert.ToDouble(AllData[i].Split(';')[1]);//取電壓大小

                //電壓位準
                if (HighMax < data[i, 0])
                {
                    HighMax = data[i, 0];
                }
                if (LowMin > data[i, 0])
                {
                    LowMin = data[i, 0];
                }

                //debug電壓大小
                if (SizeMax < Convert.ToDouble(AllData[i].Split(';')[1]))
                {
                    SizeMax = Convert.ToDouble(AllData[i].Split(';')[1]);
                }
                if (SizeMin > Convert.ToDouble(AllData[i].Split(';')[1]))
                {
                    SizeMin = Convert.ToDouble(AllData[i].Split(';')[1]);
                }

            }

            //debug
            if (checkBox13.Checked == true)
            {
                Console.WriteLine();
                Console.WriteLine(checkBox13.Text);
                Console.WriteLine("電壓位準最大值：" + HighMax);
                Console.WriteLine("電壓位準最小值：" + LowMin);
            }

            //debug
            if (checkBox4.Checked == true)
            {
                Console.WriteLine();
                Console.WriteLine(checkBox4.Text);
                Console.WriteLine("電壓大小最大值：" + SizeMax);
                Console.WriteLine("電壓大小最小值：" + SizeMin);
            }

            return (data, HighMax, LowMin);
        }

        private string[] SearchFileName(string file_path)
        {//取得當前路徑下ParticleData裡的所有txt檔
            DirectoryInfo folder = new DirectoryInfo(@file_path);//路徑宣告
            var all_file_name = folder.GetFiles("*.txt"); // or *.txt or 20210422-*.txt
            string[] file_name = new string[all_file_name.LongCount()];//檔名陣列
            int num = 0;

            // 每載入完一個文件增加設定增加多少progress bar
            SetBar(100 / Convert.ToInt32(all_file_name.LongCount()), 100, 0);//set progressbar(step,max,now value=0)

            dataList.Items.Clear();//清空顯示檔名項目
            foreach (var f in all_file_name)
            {//逐一放入檔名至檔名陣列file_name，並顯示再檔名清單dataList上

                file_name[num] = f.Name;
                dataList.Items.Add(f.Name);//add filename list
                num += 1;
                AnyProgressBar.Value += AnyProgressBar.Step;//set progress bar
            }

            return file_name;
        }

        private string[] LoadingData(string file_name)
        {//匯入txt所有資料，並將所有資料放到二維陣列裡(移動位準，掃描電壓，取樣時間) 

            string[] data = { };

            try
            {
                using (StreamReader sr = new StreamReader(@FilePath.Text.Split('：')[1] + file_name))//讀取檔案 (檔案路徑+檔名)
                {//一次讀進所有資料，並藉由換行符號分割，放進data中

                    char[] separators = new char[] { '\r', '\n' };//換行符號為 「 \r + \n 」
                    data = sr.ReadToEnd().Split(separators, StringSplitOptions.RemoveEmptyEntries);//分割換行符號
                    sr.Close();//關閉檔案
                }


            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return data;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bee = new Bitmap(show.Width, show.Height);
            g = Graphics.FromImage(Bee);

            //g = show.CreateGraphics();//建立畫布 error:這個無法永久儲存繪圖
        }


        private void test_Click(object sender, EventArgs e)
        {//debug or 測試新功能用
         // if (!Console.IsOutputRedirected) Console.Clear();//error


            //Color c = Color.FromArgb(int.Parse("#FF00FF".Replace("#", ""),
            // System.Globalization.NumberStyles.AllowHexSpecifier));
            //string[] hex = { "#FAF4FF", "#F1E1FF", "#E6CAFF", "#DCB5FF", "#D3A4FF", "#CA8EFF", "#BE77FF",
            //    "#B15BFF", "#9F35FF", "#921AFF", "#8600FF", "#6F00D2", "#5B00AE", "#4B0091", "#3A006F", "#28004D" };
            //Color _color = System.Drawing.ColorTranslator.FromHtml(hex[0]);

            // colorlabel1.BackColor = Color.FromArgb(255, 0, 255, 255);
            //Brush brush2 = new SolidBrush(_color);
            //test.BackColor = _color;

            //Button[] btns = new Button[8 * 8]; // 產生 64 個 Button Reference，並初始化為 null
            //for (int y = 0; y < 8; ++y)
            //{
            //    for (int x = 0; x < 8; ++x)
            //    {
            //        int idx = x + y * 8;
            //        btns[idx] = new Button();
            //        btns[idx].Text = String.Format("x={0}, y={1}", x, y);
            //        btns[idx].Left = x * btns[0].Width;
            //        btns[idx].Top = y * btns[0].Height;
            //       // btns[idx].BackColor = Color.Black;
            //    }
            //}

            //this.Controls.AddRange(btns);
            //        LinearGradientBrush linGrBrush = new LinearGradientBrush(
            //new Point(0, 10),
            //new Point(200, 10),
            //Color.FromArgb(255, 250, 244, 255),   // Opaque red
            //Color.FromArgb(255, 40, 0, 77));  // Opaque blue

            //        Pen pen = new Pen(linGrBrush);

            //        g.DrawLine(pen, 0, 10, 200, 10);
            //        g.FillEllipse(linGrBrush, 0, 30, 200, 100);
            //        g.FillRectangle(linGrBrush, 0, 155, 1000, 50);

            //        show.Image = Bee;//show picture
        }

        private void saveIMG_Click(object sender, EventArgs e)
        {//儲存粒子分佈圖

            // Displays a SaveFileDialog so the user can save the Image
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png";//可存的副檔名設定
            saveFileDialog1.InitialDirectory = Application.StartupPath;//Default path
            saveFileDialog1.Title = "Save an Image File";//save window title
            saveFileDialog1.FileName = dataList.Text.Split('.')[0];// Default save data name
            saveFileDialog1.ShowDialog();//show save window


            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();

                switch (saveFileDialog1.FilterIndex)
                {//根據選擇的副檔名來儲存
                    case 1:
                        Bee.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 2:
                        Bee.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case 3:
                        Bee.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case 4:
                        Bee.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        break;
                }

                fs.Close();
            }


        }

        private void SelectData_Click(object sender, EventArgs e)//doing
        {//讀取選擇的檔案路徑集(限定txt)，分割成檔名跟路徑部分

            OpenFileDialog openFileDialog1 = new System.Windows.Forms.OpenFileDialog();//宣告開啟檔案視窗
            openFileDialog1.Multiselect = true;//是否允許選擇多個檔案
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";//限定檔案為txt

            if (openFileDialog1.ShowDialog() == DialogResult.OK)//判斷是否選擇了檔案!!!
            {
                dataList.Items.Clear();//清空放置檔名的欄位

                //progress bar， setBar(step,max,now value =0)
                SetBar(100 / Convert.ToInt32(openFileDialog1.SafeFileNames.Length), 100, 0);

                //逐一寫入檔案名稱
                foreach (string s in openFileDialog1.SafeFileNames)
                {
                    dataList.Items.Add(s);
                    AnyProgressBar.Value += AnyProgressBar.Step;
                }
                dataList.SelectedIndex = 0;//設定目前檔名欄位索引為起始0
                string file_path = openFileDialog1.FileName;//記錄選擇的檔案全路徑
                FilePath.Text = "File Path：" + file_path.Substring(0,
                    file_path.LastIndexOf(Path.DirectorySeparatorChar) + 1);//顯示目前檔案路徑
                AnyProgressBar.Value = AnyProgressBar.Maximum;//填滿除不進的進度條部分

            }
            if (dataList.Text != "")
            {
                StartShow.Enabled = true;
            }


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {//Cheng particles color and label color

            //更改標籤示意圖顏色
            labelBackcolor(trackBar.Value);

            //粒子圖重新繪製
            Draw(Global.PositiveData);

        }
        private void labelBackcolor(int val)
        {//設定粒子區間大小識別的label顏色

            //string[] hex = { "#FAF4FF", "#F1E1FF", "#E6CAFF", "#DCB5FF", "#D3A4FF", "#CA8EFF", "#BE77FF",
            //    "#B15BFF", "#9F35FF", "#921AFF", "#8600FF", "#6F00D2", "#5B00AE", "#4B0091", "#3A006F", "#28004D" };
            //Color[] _color = new Color[hex.Length];


            int[,] color = { { 250, 244, 255 }, { 241,225,255},{ 230,202,255},{ 220,181,255},{ 211,164,255},
                { 202,142,255},{190,119,255 } ,{ 177,91,255} ,{ 159,53,255},{146,26,255 } ,{134,0,255 },{111,0,210 },
                { 91,0,174},{75,0,145 },{58,0,111 },{40,0,77 } };

            colorlabel1.BackColor = Color.FromArgb(255, color[10 + val, 0], color[10 + val, 1], color[10 + val, 2]);
            colorlabel2.BackColor = Color.FromArgb(255, color[8 + val, 0], color[8 + val, 1], color[8 + val, 2]);
            colorlabel3.BackColor = Color.FromArgb(255, color[6 + val, 0], color[6 + val, 1], color[6 + val, 2]);
            colorlabel4.BackColor = Color.FromArgb(255, color[4 + val, 0], color[4 + val, 1], color[4 + val, 2]);
            colorlabel5.BackColor = Color.FromArgb(255, color[2 + val, 0], color[2 + val, 1], color[2 + val, 2]);
            colorlabel6.BackColor = Color.FromArgb(255, color[val, 0], color[val, 1], color[val, 2]);

        }
        private void LoadDataName_Click(object sender, EventArgs e)
        {//Auto loab file ，開發程式時的懶人自動載入   自動載入當前執行檔位置的下\ParticleData\裡的所有txt

            string file_path = "ParticleData";

            FilePath.Text = "File Path：" + System.Environment.CurrentDirectory + "\\" + file_path + "\\";
            dataList.Text = SearchFileName(file_path)[0];//取得該路徑所有檔名

            StartShow.Enabled = true;
            AnyProgressBar.Value = AnyProgressBar.Maximum;

        }

        private void size01_CheckedChanged(object sender, EventArgs e)
        {
            if (trackBar.Enabled == true)
            {
                g.Clear(Color.MistyRose);//清空粒子分布圖
                Draw(Global.PositiveData);//繪製粒子分布圖
                GetAmount(Global.PositiveData);//計算粒子數量
            }

        }

        private void size02_CheckedChanged(object sender, EventArgs e)
        {
            if (trackBar.Enabled == true)
            {
                g.Clear(Color.MistyRose);
                Draw(Global.PositiveData);
                GetAmount(Global.PositiveData);
            }
        }

        private void size03_CheckedChanged(object sender, EventArgs e)
        {
            if (trackBar.Enabled == true)
            {
                g.Clear(Color.MistyRose);
                Draw(Global.PositiveData);
                GetAmount(Global.PositiveData);
            }
        }

        private void size04_CheckedChanged(object sender, EventArgs e)
        {
            if (trackBar.Enabled == true)
            {
                g.Clear(Color.MistyRose);
                Draw(Global.PositiveData);
                GetAmount(Global.PositiveData);
            }
        }

        private void size05_CheckedChanged(object sender, EventArgs e)
        {
            if (trackBar.Enabled == true)
            {
                g.Clear(Color.MistyRose);
                Draw(Global.PositiveData);
                GetAmount(Global.PositiveData);
            }
        }

        private void size06_CheckedChanged(object sender, EventArgs e)
        {
            if (trackBar.Enabled == true)
            {
                g.Clear(Color.MistyRose);
                Draw(Global.PositiveData);
                GetAmount(Global.PositiveData);
            }
        }


    }
}
