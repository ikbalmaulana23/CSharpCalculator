namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PnlTitle = new Panel();
            button2 = new Button();
            button1 = new Button();
            BtnExit = new Button();
            PnlHistory = new Panel();
            RtBoxDisplayHistory = new RichTextBox();
            TxtDisplay2 = new TextBox();
            TxtDisplay1 = new TextBox();
            BtnBackspace = new Button();
            BtnPercent = new Button();
            BtnCE = new Button();
            BtnC = new Button();
            BtnSquare = new Button();
            BtnX2 = new Button();
            Btn1X = new Button();
            BtnDivision = new Button();
            btn9 = new Button();
            Btn8 = new Button();
            Btn7 = new Button();
            BtnMultiply = new Button();
            Btn6 = new Button();
            Btn5 = new Button();
            Btn4 = new Button();
            BtnSubstraction = new Button();
            button25 = new Button();
            Btn2 = new Button();
            Btn1 = new Button();
            BtnAdd = new Button();
            BtnDesimal = new Button();
            Btn0 = new Button();
            BtnPM = new Button();
            BtnEquals = new Button();
            PnlTitle.SuspendLayout();
            SuspendLayout();
            // 
            // PnlTitle
            // 
            PnlTitle.BackColor = SystemColors.WindowFrame;
            PnlTitle.Controls.Add(button2);
            PnlTitle.Controls.Add(button1);
            PnlTitle.Controls.Add(BtnExit);
            PnlTitle.Dock = DockStyle.Top;
            PnlTitle.Location = new Point(0, 0);
            PnlTitle.Name = "PnlTitle";
            PnlTitle.Size = new Size(380, 40);
            PnlTitle.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.WindowFrame;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(76, -1);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(40, 40);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowFrame;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(39, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = SystemColors.WindowFrame;
            BtnExit.BackgroundImage = (Image)resources.GetObject("BtnExit.BackgroundImage");
            BtnExit.BackgroundImageLayout = ImageLayout.Center;
            BtnExit.Dock = DockStyle.Left;
            BtnExit.FlatAppearance.BorderSize = 0;
            BtnExit.FlatStyle = FlatStyle.Flat;
            BtnExit.ForeColor = SystemColors.ActiveCaptionText;
            BtnExit.ImageAlign = ContentAlignment.TopCenter;
            BtnExit.Location = new Point(0, 0);
            BtnExit.Margin = new Padding(0);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(44, 40);
            BtnExit.TabIndex = 0;
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // PnlHistory
            // 
            PnlHistory.Dock = DockStyle.Bottom;
            PnlHistory.Location = new Point(0, 582);
            PnlHistory.Name = "PnlHistory";
            PnlHistory.Size = new Size(380, 5);
            PnlHistory.TabIndex = 1;
            // 
            // RtBoxDisplayHistory
            // 
            RtBoxDisplayHistory.BackColor = SystemColors.AppWorkspace;
            RtBoxDisplayHistory.BorderStyle = BorderStyle.None;
            RtBoxDisplayHistory.Location = new Point(1, 186);
            RtBoxDisplayHistory.Name = "RtBoxDisplayHistory";
            RtBoxDisplayHistory.Size = new Size(380, 396);
            RtBoxDisplayHistory.TabIndex = 0;
            RtBoxDisplayHistory.Text = "";
            RtBoxDisplayHistory.TextChanged += RtBoxDisplayHistory_TextChanged;
            // 
            // TxtDisplay2
            // 
            TxtDisplay2.BackColor = SystemColors.AppWorkspace;
            TxtDisplay2.BorderStyle = BorderStyle.None;
            TxtDisplay2.Dock = DockStyle.Top;
            TxtDisplay2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            TxtDisplay2.Location = new Point(0, 40);
            TxtDisplay2.Margin = new Padding(0);
            TxtDisplay2.Multiline = true;
            TxtDisplay2.Name = "TxtDisplay2";
            TxtDisplay2.Size = new Size(380, 31);
            TxtDisplay2.TabIndex = 3;
            TxtDisplay2.Text = "0";
            TxtDisplay2.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtDisplay1
            // 
            TxtDisplay1.BackColor = SystemColors.AppWorkspace;
            TxtDisplay1.BorderStyle = BorderStyle.None;
            TxtDisplay1.Dock = DockStyle.Top;
            TxtDisplay1.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            TxtDisplay1.Location = new Point(0, 71);
            TxtDisplay1.Margin = new Padding(0);
            TxtDisplay1.Multiline = true;
            TxtDisplay1.Name = "TxtDisplay1";
            TxtDisplay1.Size = new Size(380, 62);
            TxtDisplay1.TabIndex = 4;
            TxtDisplay1.Text = "0";
            TxtDisplay1.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnBackspace
            // 
            BtnBackspace.BackColor = Color.FromArgb(255, 128, 0);
            BtnBackspace.FlatAppearance.BorderSize = 0;
            BtnBackspace.FlatStyle = FlatStyle.Flat;
            BtnBackspace.Image = (Image)resources.GetObject("BtnBackspace.Image");
            BtnBackspace.Location = new Point(284, 184);
            BtnBackspace.Name = "BtnBackspace";
            BtnBackspace.Size = new Size(90, 61);
            BtnBackspace.TabIndex = 5;
            BtnBackspace.UseVisualStyleBackColor = false;
            BtnBackspace.Click += BtnBackspace_Click;
            // 
            // BtnPercent
            // 
            BtnPercent.BackColor = Color.LightGray;
            BtnPercent.FlatAppearance.BorderSize = 0;
            BtnPercent.FlatStyle = FlatStyle.Flat;
            BtnPercent.ForeColor = SystemColors.ActiveCaptionText;
            BtnPercent.Location = new Point(5, 184);
            BtnPercent.Name = "BtnPercent";
            BtnPercent.Size = new Size(90, 61);
            BtnPercent.TabIndex = 12;
            BtnPercent.Text = "%";
            BtnPercent.UseVisualStyleBackColor = false;
            BtnPercent.Click += BtnOperations_Click;
            // 
            // BtnCE
            // 
            BtnCE.BackColor = Color.LightGray;
            BtnCE.FlatAppearance.BorderSize = 0;
            BtnCE.FlatStyle = FlatStyle.Flat;
            BtnCE.ForeColor = SystemColors.ActiveCaptionText;
            BtnCE.Location = new Point(98, 184);
            BtnCE.Name = "BtnCE";
            BtnCE.Size = new Size(90, 61);
            BtnCE.TabIndex = 13;
            BtnCE.Text = "CE";
            BtnCE.UseVisualStyleBackColor = false;
            BtnCE.Click += BtnCE_Click;
            // 
            // BtnC
            // 
            BtnC.BackColor = Color.LightGray;
            BtnC.FlatAppearance.BorderSize = 0;
            BtnC.FlatStyle = FlatStyle.Flat;
            BtnC.ForeColor = SystemColors.ActiveCaptionText;
            BtnC.Location = new Point(191, 184);
            BtnC.Name = "BtnC";
            BtnC.Size = new Size(90, 61);
            BtnC.TabIndex = 15;
            BtnC.Text = "C";
            BtnC.UseVisualStyleBackColor = false;
            BtnC.Click += BtnC_Click;
            // 
            // BtnSquare
            // 
            BtnSquare.BackColor = Color.LightGray;
            BtnSquare.FlatAppearance.BorderSize = 0;
            BtnSquare.FlatStyle = FlatStyle.Flat;
            BtnSquare.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSquare.ForeColor = SystemColors.ActiveCaptionText;
            BtnSquare.Location = new Point(191, 250);
            BtnSquare.Name = "BtnSquare";
            BtnSquare.Size = new Size(90, 61);
            BtnSquare.TabIndex = 19;
            BtnSquare.Text = "√x";
            BtnSquare.UseVisualStyleBackColor = false;
            BtnSquare.Click += BtnOperations_Click;
            // 
            // BtnX2
            // 
            BtnX2.BackColor = Color.LightGray;
            BtnX2.FlatAppearance.BorderSize = 0;
            BtnX2.FlatStyle = FlatStyle.Flat;
            BtnX2.ForeColor = SystemColors.ActiveCaptionText;
            BtnX2.Location = new Point(98, 250);
            BtnX2.Name = "BtnX2";
            BtnX2.Size = new Size(90, 61);
            BtnX2.TabIndex = 18;
            BtnX2.Text = "^2";
            BtnX2.UseVisualStyleBackColor = false;
            BtnX2.Click += BtnOperations_Click;
            // 
            // Btn1X
            // 
            Btn1X.BackColor = Color.LightGray;
            Btn1X.FlatAppearance.BorderSize = 0;
            Btn1X.FlatStyle = FlatStyle.Flat;
            Btn1X.ForeColor = SystemColors.ActiveCaptionText;
            Btn1X.Location = new Point(5, 250);
            Btn1X.Name = "Btn1X";
            Btn1X.Size = new Size(90, 61);
            Btn1X.TabIndex = 17;
            Btn1X.Text = "1/x";
            Btn1X.UseVisualStyleBackColor = false;
            Btn1X.Click += BtnOperations_Click;
            // 
            // BtnDivision
            // 
            BtnDivision.BackColor = Color.FromArgb(255, 128, 0);
            BtnDivision.FlatAppearance.BorderSize = 0;
            BtnDivision.FlatStyle = FlatStyle.Flat;
            BtnDivision.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnDivision.Location = new Point(284, 250);
            BtnDivision.Name = "BtnDivision";
            BtnDivision.Size = new Size(90, 61);
            BtnDivision.TabIndex = 16;
            BtnDivision.Text = "÷";
            BtnDivision.UseVisualStyleBackColor = false;
            BtnDivision.Click += BtnMathOperation_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.LightGray;
            btn9.FlatAppearance.BorderSize = 0;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.ForeColor = SystemColors.ActiveCaptionText;
            btn9.Location = new Point(191, 315);
            btn9.Name = "btn9";
            btn9.Size = new Size(90, 61);
            btn9.TabIndex = 23;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += BtnNum_Click;
            // 
            // Btn8
            // 
            Btn8.BackColor = Color.LightGray;
            Btn8.FlatAppearance.BorderSize = 0;
            Btn8.FlatStyle = FlatStyle.Flat;
            Btn8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn8.ForeColor = SystemColors.ActiveCaptionText;
            Btn8.Location = new Point(98, 315);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(90, 61);
            Btn8.TabIndex = 22;
            Btn8.Text = "8";
            Btn8.UseVisualStyleBackColor = false;
            Btn8.Click += BtnNum_Click;
            // 
            // Btn7
            // 
            Btn7.BackColor = Color.LightGray;
            Btn7.FlatAppearance.BorderSize = 0;
            Btn7.FlatStyle = FlatStyle.Flat;
            Btn7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn7.ForeColor = SystemColors.ActiveCaptionText;
            Btn7.Location = new Point(5, 315);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(90, 61);
            Btn7.TabIndex = 21;
            Btn7.Text = "7";
            Btn7.UseVisualStyleBackColor = false;
            Btn7.Click += BtnNum_Click;
            // 
            // BtnMultiply
            // 
            BtnMultiply.BackColor = Color.FromArgb(255, 128, 0);
            BtnMultiply.FlatAppearance.BorderSize = 0;
            BtnMultiply.FlatStyle = FlatStyle.Flat;
            BtnMultiply.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMultiply.Location = new Point(284, 315);
            BtnMultiply.Name = "BtnMultiply";
            BtnMultiply.Size = new Size(90, 61);
            BtnMultiply.TabIndex = 20;
            BtnMultiply.Text = " ×";
            BtnMultiply.UseVisualStyleBackColor = false;
            BtnMultiply.Click += BtnMathOperation_Click;
            // 
            // Btn6
            // 
            Btn6.BackColor = Color.LightGray;
            Btn6.FlatAppearance.BorderSize = 0;
            Btn6.FlatStyle = FlatStyle.Flat;
            Btn6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn6.ForeColor = SystemColors.ActiveCaptionText;
            Btn6.Location = new Point(191, 381);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(90, 61);
            Btn6.TabIndex = 27;
            Btn6.Text = "6";
            Btn6.UseVisualStyleBackColor = false;
            Btn6.Click += BtnNum_Click;
            // 
            // Btn5
            // 
            Btn5.BackColor = Color.LightGray;
            Btn5.FlatAppearance.BorderSize = 0;
            Btn5.FlatStyle = FlatStyle.Flat;
            Btn5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn5.ForeColor = SystemColors.ActiveCaptionText;
            Btn5.Location = new Point(98, 381);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(90, 61);
            Btn5.TabIndex = 26;
            Btn5.Text = "5";
            Btn5.UseVisualStyleBackColor = false;
            Btn5.Click += BtnNum_Click;
            // 
            // Btn4
            // 
            Btn4.BackColor = Color.LightGray;
            Btn4.FlatAppearance.BorderSize = 0;
            Btn4.FlatStyle = FlatStyle.Flat;
            Btn4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn4.ForeColor = SystemColors.ActiveCaptionText;
            Btn4.Location = new Point(5, 381);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(90, 61);
            Btn4.TabIndex = 25;
            Btn4.Text = "4";
            Btn4.UseVisualStyleBackColor = false;
            Btn4.Click += BtnNum_Click;
            // 
            // BtnSubstraction
            // 
            BtnSubstraction.BackColor = Color.FromArgb(255, 128, 0);
            BtnSubstraction.FlatAppearance.BorderSize = 0;
            BtnSubstraction.FlatStyle = FlatStyle.Flat;
            BtnSubstraction.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSubstraction.Location = new Point(284, 381);
            BtnSubstraction.Name = "BtnSubstraction";
            BtnSubstraction.Size = new Size(90, 61);
            BtnSubstraction.TabIndex = 24;
            BtnSubstraction.Text = "-";
            BtnSubstraction.UseVisualStyleBackColor = false;
            BtnSubstraction.Click += BtnMathOperation_Click;
            // 
            // button25
            // 
            button25.BackColor = Color.LightGray;
            button25.FlatAppearance.BorderSize = 0;
            button25.FlatStyle = FlatStyle.Flat;
            button25.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button25.ForeColor = SystemColors.ActiveCaptionText;
            button25.Location = new Point(191, 447);
            button25.Name = "button25";
            button25.Size = new Size(90, 61);
            button25.TabIndex = 31;
            button25.Text = "3";
            button25.UseVisualStyleBackColor = false;
            button25.Click += BtnNum_Click;
            // 
            // Btn2
            // 
            Btn2.BackColor = Color.LightGray;
            Btn2.FlatAppearance.BorderSize = 0;
            Btn2.FlatStyle = FlatStyle.Flat;
            Btn2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn2.ForeColor = SystemColors.ActiveCaptionText;
            Btn2.Location = new Point(98, 447);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(90, 61);
            Btn2.TabIndex = 30;
            Btn2.Text = "2";
            Btn2.UseVisualStyleBackColor = false;
            Btn2.Click += BtnNum_Click;
            // 
            // Btn1
            // 
            Btn1.BackColor = Color.LightGray;
            Btn1.FlatAppearance.BorderSize = 0;
            Btn1.FlatStyle = FlatStyle.Flat;
            Btn1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn1.ForeColor = SystemColors.ActiveCaptionText;
            Btn1.Location = new Point(5, 447);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(90, 61);
            Btn1.TabIndex = 29;
            Btn1.Text = "1";
            Btn1.UseVisualStyleBackColor = false;
            Btn1.Click += BtnNum_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = Color.FromArgb(255, 128, 0);
            BtnAdd.FlatAppearance.BorderSize = 0;
            BtnAdd.FlatStyle = FlatStyle.Flat;
            BtnAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAdd.Location = new Point(284, 447);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(90, 61);
            BtnAdd.TabIndex = 28;
            BtnAdd.Text = "+";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnMathOperation_Click;
            // 
            // BtnDesimal
            // 
            BtnDesimal.BackColor = Color.LightGray;
            BtnDesimal.FlatAppearance.BorderSize = 0;
            BtnDesimal.FlatStyle = FlatStyle.Flat;
            BtnDesimal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDesimal.ForeColor = SystemColors.ActiveCaptionText;
            BtnDesimal.Location = new Point(191, 512);
            BtnDesimal.Name = "BtnDesimal";
            BtnDesimal.Size = new Size(90, 61);
            BtnDesimal.TabIndex = 34;
            BtnDesimal.Text = ".";
            BtnDesimal.UseVisualStyleBackColor = false;
            BtnDesimal.Click += BtnNum_Click;
            // 
            // Btn0
            // 
            Btn0.BackColor = Color.LightGray;
            Btn0.FlatAppearance.BorderSize = 0;
            Btn0.FlatStyle = FlatStyle.Flat;
            Btn0.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn0.ForeColor = SystemColors.ActiveCaptionText;
            Btn0.Location = new Point(99, 512);
            Btn0.Name = "Btn0";
            Btn0.Size = new Size(90, 61);
            Btn0.TabIndex = 33;
            Btn0.Text = "0";
            Btn0.UseVisualStyleBackColor = false;
            Btn0.Click += BtnNum_Click;
            // 
            // BtnPM
            // 
            BtnPM.BackColor = Color.LightGray;
            BtnPM.FlatAppearance.BorderSize = 0;
            BtnPM.FlatStyle = FlatStyle.Flat;
            BtnPM.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPM.ForeColor = SystemColors.ActiveCaptionText;
            BtnPM.Location = new Point(5, 512);
            BtnPM.Name = "BtnPM";
            BtnPM.Size = new Size(90, 61);
            BtnPM.TabIndex = 32;
            BtnPM.Text = " ±";
            BtnPM.UseVisualStyleBackColor = false;
            BtnPM.Click += BtnOperations_Click;
            // 
            // BtnEquals
            // 
            BtnEquals.BackColor = Color.FromArgb(255, 128, 0);
            BtnEquals.FlatAppearance.BorderSize = 0;
            BtnEquals.FlatStyle = FlatStyle.Flat;
            BtnEquals.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnEquals.Location = new Point(284, 512);
            BtnEquals.Name = "BtnEquals";
            BtnEquals.Size = new Size(90, 61);
            BtnEquals.TabIndex = 35;
            BtnEquals.Text = "=";
            BtnEquals.UseVisualStyleBackColor = false;
            BtnEquals.Click += BtnEquals_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(380, 587);
            Controls.Add(BtnEquals);
            Controls.Add(BtnDesimal);
            Controls.Add(Btn0);
            Controls.Add(BtnPM);
            Controls.Add(button25);
            Controls.Add(Btn2);
            Controls.Add(Btn1);
            Controls.Add(BtnAdd);
            Controls.Add(Btn6);
            Controls.Add(Btn5);
            Controls.Add(Btn4);
            Controls.Add(BtnSubstraction);
            Controls.Add(btn9);
            Controls.Add(Btn8);
            Controls.Add(Btn7);
            Controls.Add(BtnMultiply);
            Controls.Add(BtnSquare);
            Controls.Add(BtnX2);
            Controls.Add(Btn1X);
            Controls.Add(BtnDivision);
            Controls.Add(BtnC);
            Controls.Add(BtnCE);
            Controls.Add(BtnPercent);
            Controls.Add(BtnBackspace);
            Controls.Add(TxtDisplay1);
            Controls.Add(TxtDisplay2);
            Controls.Add(PnlHistory);
            Controls.Add(PnlTitle);
            Controls.Add(RtBoxDisplayHistory);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            PnlTitle.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PnlTitle;
        private Panel PnlHistory;
        private Button button2;
        private Button button1;
        private TextBox TxtDisplay2;
        private TextBox TxtDisplay1;
        private RichTextBox RtBoxDisplayHistory;
        private Button BtnBackspace;
        private Button BtnPercent;
        private Button BtnCE;
        private Button BtnC;
        private Button BtnSquare;
        private Button BtnX2;
        private Button Btn1X;
        private Button BtnDivision;
        private Button btn9;
        private Button Btn8;
        private Button Btn7;
        private Button BtnMultiply;
        private Button Btn6;
        private Button Btn5;
        private Button Btn4;
        private Button BtnSubstraction;
        private Button button25;
        private Button Btn2;
        private Button Btn1;
        private Button BtnAdd;
        private Button BtnDesimal;
        private Button Btn0;
        private Button BtnPM;
        private Button BtnEquals;
        private Button BtnExit;
    }
}