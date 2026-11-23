namespace GamePlusik_2026
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            pictureBoxPlus = new PictureBox();
            pictureBoxMult = new PictureBox();
            labelTarget = new Label();
            labelUserNumber = new Label();
            labelCountStep = new Label();
            buttonRestart = new Button();
            buttonRandom = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMult).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPlus
            // 
            pictureBoxPlus.Image = (Image)resources.GetObject("pictureBoxPlus.Image");
            pictureBoxPlus.Location = new Point(115, 70);
            pictureBoxPlus.Name = "pictureBoxPlus";
            pictureBoxPlus.Size = new Size(149, 155);
            pictureBoxPlus.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPlus.TabIndex = 0;
            pictureBoxPlus.TabStop = false;
            pictureBoxPlus.Click += pictureBoxPlus_Click;
            // 
            // pictureBoxMult
            // 
            pictureBoxMult.Image = (Image)resources.GetObject("pictureBoxMult.Image");
            pictureBoxMult.Location = new Point(543, 70);
            pictureBoxMult.Name = "pictureBoxMult";
            pictureBoxMult.Size = new Size(149, 155);
            pictureBoxMult.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMult.TabIndex = 1;
            pictureBoxMult.TabStop = false;
            pictureBoxMult.Click += pictureBoxMult_Click;
            // 
            // labelTarget
            // 
            labelTarget.AutoSize = true;
            labelTarget.BackColor = Color.Yellow;
            labelTarget.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTarget.Location = new Point(373, 70);
            labelTarget.Name = "labelTarget";
            labelTarget.Size = new Size(54, 44);
            labelTarget.TabIndex = 2;
            labelTarget.Text = "15";
            // 
            // labelUserNumber
            // 
            labelUserNumber.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelUserNumber.Location = new Point(327, 175);
            labelUserNumber.Name = "labelUserNumber";
            labelUserNumber.Size = new Size(146, 50);
            labelUserNumber.TabIndex = 3;
            labelUserNumber.Text = "1";
            labelUserNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCountStep
            // 
            labelCountStep.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCountStep.Location = new Point(115, 278);
            labelCountStep.Name = "labelCountStep";
            labelCountStep.Size = new Size(577, 50);
            labelCountStep.TabIndex = 4;
            labelCountStep.Text = "Количество шагов: 0";
            labelCountStep.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonRestart
            // 
            buttonRestart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonRestart.Location = new Point(115, 350);
            buttonRestart.Name = "buttonRestart";
            buttonRestart.Size = new Size(280, 50);
            buttonRestart.TabIndex = 5;
            buttonRestart.Text = "Начать сначала";
            buttonRestart.UseVisualStyleBackColor = true;
            buttonRestart.Click += buttonRestart_Click;
            // 
            // buttonRandom
            // 
            buttonRandom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonRandom.Location = new Point(412, 350);
            buttonRandom.Name = "buttonRandom";
            buttonRandom.Size = new Size(280, 50);
            buttonRandom.TabIndex = 6;
            buttonRandom.Text = "Задать случайное число";
            buttonRandom.UseVisualStyleBackColor = true;
            buttonRandom.Click += buttonRandom_Click;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRandom);
            Controls.Add(buttonRestart);
            Controls.Add(labelCountStep);
            Controls.Add(labelUserNumber);
            Controls.Add(labelTarget);
            Controls.Add(pictureBoxMult);
            Controls.Add(pictureBoxPlus);
            Name = "FormGame";
            Text = "Плюсик";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlus).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxPlus;
        private PictureBox pictureBoxMult;
        private Label labelTarget;
        private Label labelUserNumber;
        private Label labelCountStep;
        private Button buttonRestart;
        private Button buttonRandom;
    }
}
