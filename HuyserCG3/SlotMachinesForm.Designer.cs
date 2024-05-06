namespace HuyserCG3
{
    partial class SlotMachinesForm
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
            components = new System.ComponentModel.Container();
            NumOfGamesLabel = new Label();
            NewPlayerButton = new Button();
            AddPlayerButton = new Button();
            PlayersComboBox = new ComboBox();
            SpinButton = new Button();
            AmountInsertedLabel = new Label();
            AmountInsertedTextBox = new TextBox();
            PrizeLabel = new Label();
            TotalWinsLabel = new Label();
            WinningsListBox = new ListBox();
            WriteToFileButton = new Button();
            ReportFromFileButton = new Button();
            ExitButton = new Button();
            RemovePlayerButton = new Button();
            ReportLabel = new Label();
            FruitPictureBox1 = new PictureBox();
            FruitPictureBox2 = new PictureBox();
            FruitPictureBox3 = new PictureBox();
            SlotMachineErrorProvider = new ErrorProvider(components);
            NumOfGamesNumericUpDown = new NumericUpDown();
            GameOverLabel = new Label();
            PrizeAmountLabel = new Label();
            NumOfWinsLabel = new Label();
            TestButton = new Button();
            SlotMachineSaveFileDialog = new SaveFileDialog();
            SlotMachineOpenFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)FruitPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FruitPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FruitPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SlotMachineErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumOfGamesNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // NumOfGamesLabel
            // 
            NumOfGamesLabel.AutoSize = true;
            NumOfGamesLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NumOfGamesLabel.Location = new Point(53, 646);
            NumOfGamesLabel.Name = "NumOfGamesLabel";
            NumOfGamesLabel.Size = new Size(265, 45);
            NumOfGamesLabel.TabIndex = 2;
            NumOfGamesLabel.Text = "Enter # of Games";
            // 
            // NewPlayerButton
            // 
            NewPlayerButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NewPlayerButton.Location = new Point(53, 887);
            NewPlayerButton.Name = "NewPlayerButton";
            NewPlayerButton.Size = new Size(239, 98);
            NewPlayerButton.TabIndex = 4;
            NewPlayerButton.Text = "New Player";
            NewPlayerButton.UseVisualStyleBackColor = true;
            NewPlayerButton.Click += NewPlayerButton_Click;
            // 
            // AddPlayerButton
            // 
            AddPlayerButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddPlayerButton.Location = new Point(53, 1007);
            AddPlayerButton.Name = "AddPlayerButton";
            AddPlayerButton.Size = new Size(239, 84);
            AddPlayerButton.TabIndex = 5;
            AddPlayerButton.Text = "Add Player";
            AddPlayerButton.UseVisualStyleBackColor = true;
            AddPlayerButton.Click += AddPlayerButton_Click;
            // 
            // PlayersComboBox
            // 
            PlayersComboBox.DropDownStyle = ComboBoxStyle.Simple;
            PlayersComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PlayersComboBox.FormattingEnabled = true;
            PlayersComboBox.Items.AddRange(new object[] { "Caleb", "Allie", "Ben", "Noah", "Bob", "Andrew" });
            PlayersComboBox.Location = new Point(53, 110);
            PlayersComboBox.Name = "PlayersComboBox";
            PlayersComboBox.Size = new Size(265, 495);
            PlayersComboBox.TabIndex = 7;
            PlayersComboBox.SelectedIndexChanged += PlayersComboBox_SelectedIndexChanged;
            // 
            // SpinButton
            // 
            SpinButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SpinButton.Location = new Point(424, 988);
            SpinButton.Name = "SpinButton";
            SpinButton.Size = new Size(230, 122);
            SpinButton.TabIndex = 8;
            SpinButton.Text = "SPIN";
            SpinButton.UseVisualStyleBackColor = true;
            SpinButton.Click += SpinButton_Click;
            // 
            // AmountInsertedLabel
            // 
            AmountInsertedLabel.AutoSize = true;
            AmountInsertedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AmountInsertedLabel.Location = new Point(746, 612);
            AmountInsertedLabel.Name = "AmountInsertedLabel";
            AmountInsertedLabel.Size = new Size(293, 45);
            AmountInsertedLabel.TabIndex = 9;
            AmountInsertedLabel.Text = "Amount Inserted: $";
            // 
            // AmountInsertedTextBox
            // 
            AmountInsertedTextBox.Location = new Point(1039, 618);
            AmountInsertedTextBox.Name = "AmountInsertedTextBox";
            AmountInsertedTextBox.Size = new Size(200, 39);
            AmountInsertedTextBox.TabIndex = 10;
            AmountInsertedTextBox.TextChanged += AmountInsertedTextBox_TextChanged;
            // 
            // PrizeLabel
            // 
            PrizeLabel.AutoSize = true;
            PrizeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PrizeLabel.Location = new Point(917, 657);
            PrizeLabel.Name = "PrizeLabel";
            PrizeLabel.Size = new Size(95, 45);
            PrizeLabel.TabIndex = 11;
            PrizeLabel.Text = "Prize:";
            // 
            // TotalWinsLabel
            // 
            TotalWinsLabel.AutoSize = true;
            TotalWinsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TotalWinsLabel.Location = new Point(838, 702);
            TotalWinsLabel.Name = "TotalWinsLabel";
            TotalWinsLabel.Size = new Size(174, 45);
            TotalWinsLabel.TabIndex = 12;
            TotalWinsLabel.Text = "Total Wins:";
            // 
            // WinningsListBox
            // 
            WinningsListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WinningsListBox.FormattingEnabled = true;
            WinningsListBox.ItemHeight = 45;
            WinningsListBox.Location = new Point(817, 801);
            WinningsListBox.Name = "WinningsListBox";
            WinningsListBox.Size = new Size(422, 409);
            WinningsListBox.TabIndex = 13;
            // 
            // WriteToFileButton
            // 
            WriteToFileButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            WriteToFileButton.Location = new Point(1376, 980);
            WriteToFileButton.Name = "WriteToFileButton";
            WriteToFileButton.Size = new Size(230, 111);
            WriteToFileButton.TabIndex = 14;
            WriteToFileButton.Text = "Write To File";
            WriteToFileButton.UseVisualStyleBackColor = true;
            WriteToFileButton.Click += WriteToFileButton_Click;
            // 
            // ReportFromFileButton
            // 
            ReportFromFileButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ReportFromFileButton.Location = new Point(1376, 1104);
            ReportFromFileButton.Name = "ReportFromFileButton";
            ReportFromFileButton.Size = new Size(230, 106);
            ReportFromFileButton.TabIndex = 15;
            ReportFromFileButton.Text = "Report From File";
            ReportFromFileButton.UseVisualStyleBackColor = true;
            ReportFromFileButton.Click += ReportFromFileButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ExitButton.Location = new Point(2309, 1114);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(230, 87);
            ExitButton.TabIndex = 16;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // RemovePlayerButton
            // 
            RemovePlayerButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RemovePlayerButton.Location = new Point(53, 1110);
            RemovePlayerButton.Name = "RemovePlayerButton";
            RemovePlayerButton.Size = new Size(239, 100);
            RemovePlayerButton.TabIndex = 17;
            RemovePlayerButton.Text = "Remove Player";
            RemovePlayerButton.UseVisualStyleBackColor = true;
            RemovePlayerButton.Click += RemovePlayerButton_Click;
            // 
            // ReportLabel
            // 
            ReportLabel.AutoSize = true;
            ReportLabel.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ReportLabel.Location = new Point(1721, 123);
            ReportLabel.Name = "ReportLabel";
            ReportLabel.Size = new Size(129, 36);
            ReportLabel.TabIndex = 18;
            ReportLabel.Text = "label1";
            // 
            // FruitPictureBox1
            // 
            FruitPictureBox1.Location = new Point(379, 110);
            FruitPictureBox1.Name = "FruitPictureBox1";
            FruitPictureBox1.Size = new Size(400, 477);
            FruitPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            FruitPictureBox1.TabIndex = 19;
            FruitPictureBox1.TabStop = false;
            // 
            // FruitPictureBox2
            // 
            FruitPictureBox2.Location = new Point(828, 110);
            FruitPictureBox2.Name = "FruitPictureBox2";
            FruitPictureBox2.Size = new Size(400, 477);
            FruitPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            FruitPictureBox2.TabIndex = 20;
            FruitPictureBox2.TabStop = false;
            // 
            // FruitPictureBox3
            // 
            FruitPictureBox3.Location = new Point(1278, 110);
            FruitPictureBox3.Name = "FruitPictureBox3";
            FruitPictureBox3.Size = new Size(400, 477);
            FruitPictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            FruitPictureBox3.TabIndex = 21;
            FruitPictureBox3.TabStop = false;
            // 
            // SlotMachineErrorProvider
            // 
            SlotMachineErrorProvider.ContainerControl = this;
            // 
            // NumOfGamesNumericUpDown
            // 
            NumOfGamesNumericUpDown.Location = new Point(130, 702);
            NumOfGamesNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumOfGamesNumericUpDown.Name = "NumOfGamesNumericUpDown";
            NumOfGamesNumericUpDown.Size = new Size(70, 39);
            NumOfGamesNumericUpDown.TabIndex = 22;
            NumOfGamesNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // GameOverLabel
            // 
            GameOverLabel.AutoSize = true;
            GameOverLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GameOverLabel.ForeColor = Color.FromArgb(192, 0, 0);
            GameOverLabel.Location = new Point(549, 748);
            GameOverLabel.Name = "GameOverLabel";
            GameOverLabel.Size = new Size(105, 45);
            GameOverLabel.TabIndex = 23;
            GameOverLabel.Text = "label1";
            // 
            // PrizeAmountLabel
            // 
            PrizeAmountLabel.AutoSize = true;
            PrizeAmountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PrizeAmountLabel.ForeColor = Color.FromArgb(192, 0, 0);
            PrizeAmountLabel.Location = new Point(1027, 660);
            PrizeAmountLabel.Name = "PrizeAmountLabel";
            PrizeAmountLabel.Size = new Size(105, 45);
            PrizeAmountLabel.TabIndex = 24;
            PrizeAmountLabel.Text = "label1";
            // 
            // NumOfWinsLabel
            // 
            NumOfWinsLabel.AutoSize = true;
            NumOfWinsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NumOfWinsLabel.ForeColor = Color.FromArgb(192, 0, 0);
            NumOfWinsLabel.Location = new Point(1027, 705);
            NumOfWinsLabel.Name = "NumOfWinsLabel";
            NumOfWinsLabel.Size = new Size(105, 45);
            NumOfWinsLabel.TabIndex = 25;
            NumOfWinsLabel.Text = "label2";
            // 
            // TestButton
            // 
            TestButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TestButton.Location = new Point(2309, 1007);
            TestButton.Name = "TestButton";
            TestButton.Size = new Size(230, 87);
            TestButton.TabIndex = 26;
            TestButton.Text = "Test";
            TestButton.UseVisualStyleBackColor = true;
            TestButton.Click += TestButton_Click;
            // 
            // SlotMachineOpenFileDialog
            // 
            SlotMachineOpenFileDialog.FileName = "openFileDialog1";
            // 
            // SlotMachinesForm
            // 
            AcceptButton = AddPlayerButton;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            CancelButton = ExitButton;
            ClientSize = new Size(2560, 1240);
            Controls.Add(TestButton);
            Controls.Add(NumOfWinsLabel);
            Controls.Add(PrizeAmountLabel);
            Controls.Add(GameOverLabel);
            Controls.Add(NumOfGamesNumericUpDown);
            Controls.Add(FruitPictureBox3);
            Controls.Add(FruitPictureBox2);
            Controls.Add(FruitPictureBox1);
            Controls.Add(ReportLabel);
            Controls.Add(RemovePlayerButton);
            Controls.Add(ExitButton);
            Controls.Add(ReportFromFileButton);
            Controls.Add(WriteToFileButton);
            Controls.Add(WinningsListBox);
            Controls.Add(TotalWinsLabel);
            Controls.Add(PrizeLabel);
            Controls.Add(AmountInsertedTextBox);
            Controls.Add(AmountInsertedLabel);
            Controls.Add(SpinButton);
            Controls.Add(PlayersComboBox);
            Controls.Add(AddPlayerButton);
            Controls.Add(NewPlayerButton);
            Controls.Add(NumOfGamesLabel);
            Name = "SlotMachinesForm";
            Text = "Slot Machines          CHuyserG3";
            Load += SlotMachinesForm_Load;
            ((System.ComponentModel.ISupportInitialize)FruitPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)FruitPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)FruitPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)SlotMachineErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumOfGamesNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label NumOfGamesLabel;
        private Button NewPlayerButton;
        private Button AddPlayerButton;
        private ComboBox PlayersComboBox;
        private Button SpinButton;
        private Label AmountInsertedLabel;
        private TextBox AmountInsertedTextBox;
        private Label PrizeLabel;
        private Label TotalWinsLabel;
        private ListBox WinningsListBox;
        private Button WriteToFileButton;
        private Button ReportFromFileButton;
        private Button ExitButton;
        private Button RemovePlayerButton;
        private Label ReportLabel;
        private PictureBox FruitPictureBox1;
        private PictureBox FruitPictureBox2;
        private PictureBox FruitPictureBox3;
        private ErrorProvider SlotMachineErrorProvider;
        private NumericUpDown NumOfGamesNumericUpDown;
        private Label GameOverLabel;
        private Label NumOfWinsLabel;
        private Label PrizeAmountLabel;
        private Button TestButton;
        private SaveFileDialog SlotMachineSaveFileDialog;
        private OpenFileDialog SlotMachineOpenFileDialog;
    }
}