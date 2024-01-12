namespace GuessTheNumberGame
{
    partial class GuessTheNumberForm
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
            StartGameButton = new Button();
            label1 = new Label();
            GuessTextBox = new TextBox();
            EnterTheGuessButton = new Button();
            InformationLabel = new Label();
            timerLabel = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // StartGameButton
            // 
            StartGameButton.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            StartGameButton.Location = new Point(12, 12);
            StartGameButton.Name = "StartGameButton";
            StartGameButton.Size = new Size(410, 60);
            StartGameButton.TabIndex = 0;
            StartGameButton.Text = "Start Game";
            StartGameButton.UseVisualStyleBackColor = true;
            StartGameButton.Click += StartGameButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 101);
            label1.Name = "label1";
            label1.Size = new Size(226, 18);
            label1.TabIndex = 1;
            label1.Text = "Guess a number from 1 to 100 :";
            // 
            // GuessTextBox
            // 
            GuessTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GuessTextBox.Location = new Point(272, 96);
            GuessTextBox.Name = "GuessTextBox";
            GuessTextBox.Size = new Size(100, 26);
            GuessTextBox.TabIndex = 2;
            // 
            // EnterTheGuessButton
            // 
            EnterTheGuessButton.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            EnterTheGuessButton.Location = new Point(12, 139);
            EnterTheGuessButton.Name = "EnterTheGuessButton";
            EnterTheGuessButton.Size = new Size(410, 60);
            EnterTheGuessButton.TabIndex = 3;
            EnterTheGuessButton.Text = "Enter the Guess";
            EnterTheGuessButton.UseVisualStyleBackColor = true;
            EnterTheGuessButton.Click += EnterTheGuessButton_Click;
            // 
            // InformationLabel
            // 
            InformationLabel.AutoSize = true;
            InformationLabel.BorderStyle = BorderStyle.FixedSingle;
            InformationLabel.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            InformationLabel.Location = new Point(12, 217);
            InformationLabel.MaximumSize = new Size(410, 50);
            InformationLabel.MinimumSize = new Size(410, 50);
            InformationLabel.Name = "InformationLabel";
            InformationLabel.Size = new Size(410, 50);
            InformationLabel.TabIndex = 4;
            InformationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.BorderStyle = BorderStyle.FixedSingle;
            timerLabel.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            timerLabel.Location = new Point(12, 342);
            timerLabel.MaximumSize = new Size(410, 80);
            timerLabel.MinimumSize = new Size(410, 80);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(410, 80);
            timerLabel.TabIndex = 5;
            timerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 295);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(410, 23);
            progressBar1.TabIndex = 6;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            // 
            // GuessTheNumberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 431);
            Controls.Add(progressBar1);
            Controls.Add(timerLabel);
            Controls.Add(InformationLabel);
            Controls.Add(EnterTheGuessButton);
            Controls.Add(GuessTextBox);
            Controls.Add(label1);
            Controls.Add(StartGameButton);
            Name = "GuessTheNumberForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guess The Number";
            Load += GuessTheNumberForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartGameButton;
        private Label label1;
        private TextBox GuessTextBox;
        private Button EnterTheGuessButton;
        private Label InformationLabel;
        private Label timerLabel;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}