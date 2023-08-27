namespace Ejercicio_4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cantA = new TextBox();
            cantB = new TextBox();
            cantC = new TextBox();
            button1 = new Button();
            label4 = new Label();
            HyM = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(80, 95);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 0;
            label1.Text = "Alumnos del A:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(82, 152);
            label2.Name = "label2";
            label2.Size = new Size(107, 18);
            label2.TabIndex = 1;
            label2.Text = "Alumnos del B:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 214);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 2;
            label3.Text = "Alumnos del C:";
            // 
            // cantA
            // 
            cantA.Location = new Point(215, 92);
            cantA.Name = "cantA";
            cantA.Size = new Size(100, 27);
            cantA.TabIndex = 3;
            // 
            // cantB
            // 
            cantB.Location = new Point(215, 148);
            cantB.Name = "cantB";
            cantB.Size = new Size(100, 27);
            cantB.TabIndex = 4;
            // 
            // cantC
            // 
            cantC.Location = new Point(215, 211);
            cantC.Name = "cantC";
            cantC.Size = new Size(100, 27);
            cantC.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(198, 285);
            button1.Name = "button1";
            button1.Size = new Size(131, 44);
            button1.TabIndex = 6;
            button1.Text = "calcular tiempo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 372);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 7;
            label4.Text = "Total de tiempo:";
            // 
            // HyM
            // 
            HyM.Location = new Point(215, 369);
            HyM.Name = "HyM";
            HyM.ReadOnly = true;
            HyM.Size = new Size(100, 27);
            HyM.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(HyM);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(cantC);
            Controls.Add(cantB);
            Controls.Add(cantA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox cantA;
        private TextBox cantB;
        private TextBox cantC;
        private Button button1;
        private Label label4;
        private TextBox HyM;
    }
}