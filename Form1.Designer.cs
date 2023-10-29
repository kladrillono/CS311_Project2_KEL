namespace CS311_Project2_KEL
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
            lblDieOne = new Label();
            lblDieTwo = new Label();
            lblBalance = new Label();
            txtBet = new TextBox();
            btnRoll = new Button();
            lblOutcome = new Label();
            SuspendLayout();
            // 
            // lblDieOne
            // 
            lblDieOne.AutoSize = true;
            lblDieOne.Font = new Font("Elephant", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblDieOne.Location = new Point(22, 33);
            lblDieOne.Name = "lblDieOne";
            lblDieOne.Size = new Size(238, 41);
            lblDieOne.TabIndex = 0;
            lblDieOne.Text = "Die One Roll:";
            // 
            // lblDieTwo
            // 
            lblDieTwo.AutoSize = true;
            lblDieTwo.Font = new Font("Elephant", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblDieTwo.Location = new Point(22, 92);
            lblDieTwo.Name = "lblDieTwo";
            lblDieTwo.Size = new Size(241, 41);
            lblDieTwo.TabIndex = 1;
            lblDieTwo.Text = "Die Two Roll:";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(528, 97);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(160, 32);
            lblBalance.TabIndex = 2;
            lblBalance.Text = "Balance: $100";
            // 
            // txtBet
            // 
            txtBet.Location = new Point(528, 35);
            txtBet.Name = "txtBet";
            txtBet.PlaceholderText = "Enter your bet";
            txtBet.Size = new Size(200, 39);
            txtBet.TabIndex = 3;
            txtBet.Text = "Enter your bet";
            // 
            // btnRoll
            // 
            btnRoll.Font = new Font("Elephant", 10.8749981F, FontStyle.Bold, GraphicsUnit.Point);
            btnRoll.Location = new Point(358, 282);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(150, 73);
            btnRoll.TabIndex = 4;
            btnRoll.Text = "Roll";
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += btnRoll_Click;
            // 
            // lblOutcome
            // 
            lblOutcome.AutoSize = true;
            lblOutcome.Font = new Font("Elephant", 13.8749981F, FontStyle.Regular, GraphicsUnit.Point);
            lblOutcome.Location = new Point(22, 203);
            lblOutcome.Name = "lblOutcome";
            lblOutcome.Size = new Size(201, 47);
            lblOutcome.TabIndex = 5;
            lblOutcome.Text = "Outcome:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 422);
            Controls.Add(lblOutcome);
            Controls.Add(btnRoll);
            Controls.Add(txtBet);
            Controls.Add(lblBalance);
            Controls.Add(lblDieTwo);
            Controls.Add(lblDieOne);
            Name = "Form1";
            Text = "Craps";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDieOne;
        private Label lblDieTwo;
        private Label lblBalance;
        private TextBox txtBet;
        private Button btnRoll;
        private Label lblOutcome;
    }
}