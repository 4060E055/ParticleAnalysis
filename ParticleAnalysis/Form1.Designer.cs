
namespace ParticleAnalysis
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoadDataName = new System.Windows.Forms.Button();
            this.AnyProgressBar = new System.Windows.Forms.ProgressBar();
            this.dataList = new System.Windows.Forms.ComboBox();
            this.StartShow = new System.Windows.Forms.Button();
            this.count01 = new System.Windows.Forms.TextBox();
            this.count06 = new System.Windows.Forms.TextBox();
            this.test = new System.Windows.Forms.Button();
            this.colorlabel1 = new System.Windows.Forms.Label();
            this.colorlabel3 = new System.Windows.Forms.Label();
            this.colorlabel4 = new System.Windows.Forms.Label();
            this.colorlabel5 = new System.Windows.Forms.Label();
            this.colorlabel2 = new System.Windows.Forms.Label();
            this.saveIMG = new System.Windows.Forms.Button();
            this.SelectData = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.size06 = new System.Windows.Forms.CheckBox();
            this.size05 = new System.Windows.Forms.CheckBox();
            this.size04 = new System.Windows.Forms.CheckBox();
            this.size03 = new System.Windows.Forms.CheckBox();
            this.size02 = new System.Windows.Forms.CheckBox();
            this.size01 = new System.Windows.Forms.CheckBox();
            this.count04 = new System.Windows.Forms.TextBox();
            this.count03 = new System.Windows.Forms.TextBox();
            this.count02 = new System.Windows.Forms.TextBox();
            this.count05 = new System.Windows.Forms.TextBox();
            this.colorlabel6 = new System.Windows.Forms.Label();
            this.debug = new System.Windows.Forms.GroupBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.show = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.debug.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadDataName
            // 
            this.LoadDataName.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.LoadDataName.Location = new System.Drawing.Point(1286, 128);
            this.LoadDataName.Name = "LoadDataName";
            this.LoadDataName.Size = new System.Drawing.Size(109, 43);
            this.LoadDataName.TabIndex = 0;
            this.LoadDataName.Text = "LoadData";
            this.LoadDataName.UseVisualStyleBackColor = true;
            this.LoadDataName.Click += new System.EventHandler(this.LoadDataName_Click);
            // 
            // AnyProgressBar
            // 
            this.AnyProgressBar.Location = new System.Drawing.Point(1020, 43);
            this.AnyProgressBar.Name = "AnyProgressBar";
            this.AnyProgressBar.Size = new System.Drawing.Size(188, 25);
            this.AnyProgressBar.TabIndex = 3;
            // 
            // dataList
            // 
            this.dataList.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.dataList.FormattingEnabled = true;
            this.dataList.Location = new System.Drawing.Point(1020, 87);
            this.dataList.Name = "dataList";
            this.dataList.Size = new System.Drawing.Size(188, 25);
            this.dataList.TabIndex = 5;
            // 
            // StartShow
            // 
            this.StartShow.Enabled = false;
            this.StartShow.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartShow.Location = new System.Drawing.Point(1074, 226);
            this.StartShow.Name = "StartShow";
            this.StartShow.Size = new System.Drawing.Size(133, 52);
            this.StartShow.TabIndex = 6;
            this.StartShow.Text = "Start";
            this.StartShow.UseVisualStyleBackColor = true;
            this.StartShow.Click += new System.EventHandler(this.StartShow_Click);
            // 
            // count01
            // 
            this.count01.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.count01.Location = new System.Drawing.Point(67, 37);
            this.count01.Name = "count01";
            this.count01.ReadOnly = true;
            this.count01.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.count01.Size = new System.Drawing.Size(55, 25);
            this.count01.TabIndex = 9;
            // 
            // count06
            // 
            this.count06.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.count06.Location = new System.Drawing.Point(67, 242);
            this.count06.Name = "count06";
            this.count06.ReadOnly = true;
            this.count06.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.count06.Size = new System.Drawing.Size(55, 25);
            this.count06.TabIndex = 10;
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(65, 452);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(105, 30);
            this.test.TabIndex = 7;
            this.test.Text = "testbutton1";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // colorlabel1
            // 
            this.colorlabel1.AutoSize = true;
            this.colorlabel1.BackColor = System.Drawing.Color.Indigo;
            this.colorlabel1.Location = new System.Drawing.Point(18, 43);
            this.colorlabel1.Name = "colorlabel1";
            this.colorlabel1.Size = new System.Drawing.Size(43, 17);
            this.colorlabel1.TabIndex = 20;
            this.colorlabel1.Text = "       ";
            // 
            // colorlabel3
            // 
            this.colorlabel3.AutoSize = true;
            this.colorlabel3.BackColor = System.Drawing.Color.DarkOrchid;
            this.colorlabel3.Location = new System.Drawing.Point(18, 125);
            this.colorlabel3.Name = "colorlabel3";
            this.colorlabel3.Size = new System.Drawing.Size(43, 17);
            this.colorlabel3.TabIndex = 21;
            this.colorlabel3.Text = "       ";
            // 
            // colorlabel4
            // 
            this.colorlabel4.AutoSize = true;
            this.colorlabel4.BackColor = System.Drawing.Color.MediumOrchid;
            this.colorlabel4.Location = new System.Drawing.Point(18, 166);
            this.colorlabel4.Name = "colorlabel4";
            this.colorlabel4.Size = new System.Drawing.Size(43, 17);
            this.colorlabel4.TabIndex = 22;
            this.colorlabel4.Text = "       ";
            // 
            // colorlabel5
            // 
            this.colorlabel5.AutoSize = true;
            this.colorlabel5.BackColor = System.Drawing.Color.Plum;
            this.colorlabel5.Location = new System.Drawing.Point(18, 207);
            this.colorlabel5.Name = "colorlabel5";
            this.colorlabel5.Size = new System.Drawing.Size(43, 17);
            this.colorlabel5.TabIndex = 23;
            this.colorlabel5.Text = "       ";
            // 
            // colorlabel2
            // 
            this.colorlabel2.AutoSize = true;
            this.colorlabel2.BackColor = System.Drawing.Color.DarkViolet;
            this.colorlabel2.Location = new System.Drawing.Point(18, 84);
            this.colorlabel2.Name = "colorlabel2";
            this.colorlabel2.Size = new System.Drawing.Size(43, 17);
            this.colorlabel2.TabIndex = 24;
            this.colorlabel2.Text = "       ";
            // 
            // saveIMG
            // 
            this.saveIMG.Enabled = false;
            this.saveIMG.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveIMG.Location = new System.Drawing.Point(1075, 176);
            this.saveIMG.Name = "saveIMG";
            this.saveIMG.Size = new System.Drawing.Size(133, 44);
            this.saveIMG.TabIndex = 25;
            this.saveIMG.Text = "Save to IMG";
            this.saveIMG.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.saveIMG.UseVisualStyleBackColor = true;
            this.saveIMG.Click += new System.EventHandler(this.saveIMG_Click);
            // 
            // SelectData
            // 
            this.SelectData.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectData.Location = new System.Drawing.Point(1074, 128);
            this.SelectData.Name = "SelectData";
            this.SelectData.Size = new System.Drawing.Size(133, 42);
            this.SelectData.TabIndex = 26;
            this.SelectData.Text = "Select Data";
            this.SelectData.UseVisualStyleBackColor = true;
            this.SelectData.Click += new System.EventHandler(this.SelectData_Click);
            // 
            // FilePath
            // 
            this.FilePath.AutoSize = true;
            this.FilePath.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.FilePath.Location = new System.Drawing.Point(65, 23);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(88, 17);
            this.FilePath.TabIndex = 27;
            this.FilePath.Text = "File Path：";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(30, 141);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(151, 23);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "頭尾電壓位準均值";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(30, 309);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(91, 23);
            this.checkBox2.TabIndex = 29;
            this.checkBox2.Text = "粒子編號";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(30, 197);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(133, 23);
            this.checkBox3.TabIndex = 30;
            this.checkBox3.Text = "所有電壓(>0.2)";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(30, 281);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(148, 23);
            this.checkBox5.TabIndex = 32;
            this.checkBox5.Text = "每橫長度and數量";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(30, 225);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(146, 23);
            this.checkBox6.TabIndex = 33;
            this.checkBox6.Text = "所有電壓(無篩選)";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(30, 113);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(151, 23);
            this.checkBox7.TabIndex = 34;
            this.checkBox7.Text = "所有頭尾電壓位準";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(30, 365);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(175, 23);
            this.checkBox8.TabIndex = 35;
            this.checkBox8.Text = "第n行電壓與電壓位準";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 394);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 36;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(30, 253);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(183, 23);
            this.checkBox9.TabIndex = 37;
            this.checkBox9.Text = ">0.2所有電壓未補位前";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // size06
            // 
            this.size06.AutoSize = true;
            this.size06.Checked = true;
            this.size06.CheckState = System.Windows.Forms.CheckState.Checked;
            this.size06.Location = new System.Drawing.Point(130, 244);
            this.size06.Name = "size06";
            this.size06.Size = new System.Drawing.Size(62, 21);
            this.size06.TabIndex = 39;
            this.size06.Text = "-2~0";
            this.size06.UseVisualStyleBackColor = true;
            this.size06.CheckedChanged += new System.EventHandler(this.size06_CheckedChanged);
            // 
            // size05
            // 
            this.size05.AutoSize = true;
            this.size05.Checked = true;
            this.size05.CheckState = System.Windows.Forms.CheckState.Checked;
            this.size05.Location = new System.Drawing.Point(130, 203);
            this.size05.Name = "size05";
            this.size05.Size = new System.Drawing.Size(57, 21);
            this.size05.TabIndex = 40;
            this.size05.Text = "0~2";
            this.size05.UseVisualStyleBackColor = true;
            this.size05.CheckedChanged += new System.EventHandler(this.size05_CheckedChanged);
            // 
            // size04
            // 
            this.size04.AutoSize = true;
            this.size04.Checked = true;
            this.size04.CheckState = System.Windows.Forms.CheckState.Checked;
            this.size04.Location = new System.Drawing.Point(130, 162);
            this.size04.Name = "size04";
            this.size04.Size = new System.Drawing.Size(57, 21);
            this.size04.TabIndex = 41;
            this.size04.Text = "2~4";
            this.size04.UseVisualStyleBackColor = true;
            this.size04.CheckedChanged += new System.EventHandler(this.size04_CheckedChanged);
            // 
            // size03
            // 
            this.size03.AutoSize = true;
            this.size03.Checked = true;
            this.size03.CheckState = System.Windows.Forms.CheckState.Checked;
            this.size03.Location = new System.Drawing.Point(130, 121);
            this.size03.Name = "size03";
            this.size03.Size = new System.Drawing.Size(57, 21);
            this.size03.TabIndex = 42;
            this.size03.Text = "4~6";
            this.size03.UseVisualStyleBackColor = true;
            this.size03.CheckedChanged += new System.EventHandler(this.size03_CheckedChanged);
            // 
            // size02
            // 
            this.size02.AutoSize = true;
            this.size02.Checked = true;
            this.size02.CheckState = System.Windows.Forms.CheckState.Checked;
            this.size02.Location = new System.Drawing.Point(130, 80);
            this.size02.Name = "size02";
            this.size02.Size = new System.Drawing.Size(57, 21);
            this.size02.TabIndex = 43;
            this.size02.Text = "6~8";
            this.size02.UseVisualStyleBackColor = true;
            this.size02.CheckedChanged += new System.EventHandler(this.size02_CheckedChanged);
            // 
            // size01
            // 
            this.size01.AutoSize = true;
            this.size01.Checked = true;
            this.size01.CheckState = System.Windows.Forms.CheckState.Checked;
            this.size01.Location = new System.Drawing.Point(130, 39);
            this.size01.Name = "size01";
            this.size01.Size = new System.Drawing.Size(66, 21);
            this.size01.TabIndex = 44;
            this.size01.Text = "8~10";
            this.size01.UseVisualStyleBackColor = true;
            this.size01.CheckedChanged += new System.EventHandler(this.size01_CheckedChanged);
            // 
            // count04
            // 
            this.count04.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.count04.Location = new System.Drawing.Point(67, 160);
            this.count04.Name = "count04";
            this.count04.ReadOnly = true;
            this.count04.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.count04.Size = new System.Drawing.Size(55, 25);
            this.count04.TabIndex = 45;
            // 
            // count03
            // 
            this.count03.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.count03.Location = new System.Drawing.Point(67, 119);
            this.count03.Name = "count03";
            this.count03.ReadOnly = true;
            this.count03.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.count03.Size = new System.Drawing.Size(55, 25);
            this.count03.TabIndex = 46;
            // 
            // count02
            // 
            this.count02.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.count02.Location = new System.Drawing.Point(67, 78);
            this.count02.Name = "count02";
            this.count02.ReadOnly = true;
            this.count02.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.count02.Size = new System.Drawing.Size(55, 25);
            this.count02.TabIndex = 47;
            // 
            // count05
            // 
            this.count05.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.count05.Location = new System.Drawing.Point(67, 201);
            this.count05.Name = "count05";
            this.count05.ReadOnly = true;
            this.count05.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.count05.Size = new System.Drawing.Size(55, 25);
            this.count05.TabIndex = 48;
            // 
            // colorlabel6
            // 
            this.colorlabel6.AutoSize = true;
            this.colorlabel6.BackColor = System.Drawing.Color.Thistle;
            this.colorlabel6.Location = new System.Drawing.Point(18, 248);
            this.colorlabel6.Name = "colorlabel6";
            this.colorlabel6.Size = new System.Drawing.Size(43, 17);
            this.colorlabel6.TabIndex = 49;
            this.colorlabel6.Text = "       ";
            // 
            // debug
            // 
            this.debug.Controls.Add(this.checkBox13);
            this.debug.Controls.Add(this.checkBox12);
            this.debug.Controls.Add(this.checkBox11);
            this.debug.Controls.Add(this.checkBox4);
            this.debug.Controls.Add(this.checkBox10);
            this.debug.Controls.Add(this.test);
            this.debug.Controls.Add(this.checkBox1);
            this.debug.Controls.Add(this.checkBox2);
            this.debug.Controls.Add(this.checkBox3);
            this.debug.Controls.Add(this.checkBox5);
            this.debug.Controls.Add(this.checkBox6);
            this.debug.Controls.Add(this.checkBox7);
            this.debug.Controls.Add(this.checkBox8);
            this.debug.Controls.Add(this.textBox1);
            this.debug.Controls.Add(this.checkBox9);
            this.debug.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debug.Location = new System.Drawing.Point(1286, 221);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(228, 498);
            this.debug.TabIndex = 50;
            this.debug.TabStop = false;
            this.debug.Text = "debug";
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(30, 27);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(121, 23);
            this.checkBox13.TabIndex = 57;
            this.checkBox13.Text = "電壓位準極值";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(30, 56);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(151, 23);
            this.checkBox12.TabIndex = 41;
            this.checkBox12.Text = "所有移動位準電壓";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(30, 337);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(166, 23);
            this.checkBox11.TabIndex = 40;
            this.checkBox11.Text = "處理後的一二維長度";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(30, 169);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(121, 23);
            this.checkBox4.TabIndex = 39;
            this.checkBox4.Text = "電壓大小極值";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(30, 85);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(151, 23);
            this.checkBox10.TabIndex = 38;
            this.checkBox10.Text = "頭尾電壓位準極值";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.label1.Location = new System.Drawing.Point(1280, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "( 以下輸出的電壓位準皆為加權後的值 )";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.totalBox);
            this.groupBox1.Controls.Add(this.size01);
            this.groupBox1.Controls.Add(this.colorlabel6);
            this.groupBox1.Controls.Add(this.count01);
            this.groupBox1.Controls.Add(this.count06);
            this.groupBox1.Controls.Add(this.colorlabel3);
            this.groupBox1.Controls.Add(this.count02);
            this.groupBox1.Controls.Add(this.count05);
            this.groupBox1.Controls.Add(this.size06);
            this.groupBox1.Controls.Add(this.count03);
            this.groupBox1.Controls.Add(this.size05);
            this.groupBox1.Controls.Add(this.colorlabel1);
            this.groupBox1.Controls.Add(this.colorlabel5);
            this.groupBox1.Controls.Add(this.colorlabel4);
            this.groupBox1.Controls.Add(this.colorlabel2);
            this.groupBox1.Controls.Add(this.count04);
            this.groupBox1.Controls.Add(this.size04);
            this.groupBox1.Controls.Add(this.size02);
            this.groupBox1.Controls.Add(this.size03);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.groupBox1.Location = new System.Drawing.Point(1020, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 325);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Particle count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(142, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 22);
            this.label2.TabIndex = 55;
            this.label2.Text = "總數";
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(29, 287);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(93, 25);
            this.totalBox.TabIndex = 55;
            this.totalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // trackBar
            // 
            this.trackBar.Enabled = false;
            this.trackBar.Location = new System.Drawing.Point(1019, 303);
            this.trackBar.Maximum = 5;
            this.trackBar.Name = "trackBar";
            this.trackBar.RightToLeftLayout = true;
            this.trackBar.Size = new System.Drawing.Size(202, 56);
            this.trackBar.TabIndex = 52;
            this.trackBar.Value = 3;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.MistyRose;
            this.show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.show.Location = new System.Drawing.Point(68, 43);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(935, 675);
            this.show.TabIndex = 55;
            this.show.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(1032, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 23);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1566, 754);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.show);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.SelectData);
            this.Controls.Add(this.saveIMG);
            this.Controls.Add(this.StartShow);
            this.Controls.Add(this.dataList);
            this.Controls.Add(this.AnyProgressBar);
            this.Controls.Add(this.LoadDataName);
            this.Controls.Add(this.trackBar);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Form1";
            this.Text = "ParticleAnalysis";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.debug.ResumeLayout(false);
            this.debug.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadDataName;
        private System.Windows.Forms.ProgressBar AnyProgressBar;
        private System.Windows.Forms.Button StartShow;
        private System.Windows.Forms.TextBox count01;
        private System.Windows.Forms.TextBox count06;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.Label colorlabel1;
        private System.Windows.Forms.Label colorlabel3;
        private System.Windows.Forms.Label colorlabel4;
        private System.Windows.Forms.Label colorlabel5;
        private System.Windows.Forms.Label colorlabel2;
        private System.Windows.Forms.Button saveIMG;
        private System.Windows.Forms.Button SelectData;
        private System.Windows.Forms.Label FilePath;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox size06;
        private System.Windows.Forms.CheckBox size05;
        private System.Windows.Forms.CheckBox size04;
        private System.Windows.Forms.CheckBox size03;
        private System.Windows.Forms.CheckBox size02;
        private System.Windows.Forms.CheckBox size01;
        private System.Windows.Forms.TextBox count04;
        private System.Windows.Forms.TextBox count03;
        private System.Windows.Forms.TextBox count02;
        private System.Windows.Forms.TextBox count05;
        private System.Windows.Forms.Label colorlabel6;
        private System.Windows.Forms.GroupBox debug;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.PictureBox show;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox13;
        internal System.Windows.Forms.ComboBox dataList;
    }
}

