
namespace HelloWindowsForms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Divide = new System.Windows.Forms.Button();
            this.Mod = new System.Windows.Forms.Button();
            this.Go = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Backspace = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MathOutput = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Divide);
            this.panel1.Controls.Add(this.Mod);
            this.panel1.Controls.Add(this.Go);
            this.panel1.Controls.Add(this.Multiply);
            this.panel1.Controls.Add(this.One);
            this.panel1.Controls.Add(this.Zero);
            this.panel1.Controls.Add(this.Dot);
            this.panel1.Controls.Add(this.Minus);
            this.panel1.Controls.Add(this.Four);
            this.panel1.Controls.Add(this.Three);
            this.panel1.Controls.Add(this.Two);
            this.panel1.Controls.Add(this.Plus);
            this.panel1.Controls.Add(this.Seven);
            this.panel1.Controls.Add(this.Six);
            this.panel1.Controls.Add(this.Five);
            this.panel1.Controls.Add(this.Clear);
            this.panel1.Controls.Add(this.Backspace);
            this.panel1.Controls.Add(this.Nine);
            this.panel1.Controls.Add(this.Eight);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 561);
            this.panel1.TabIndex = 0;
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Divide.Location = new System.Drawing.Point(275, 457);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(75, 86);
            this.Divide.TabIndex = 19;
            this.Divide.TabStop = false;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.DivideClick);
            // 
            // Mod
            // 
            this.Mod.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mod.Location = new System.Drawing.Point(194, 457);
            this.Mod.Name = "Mod";
            this.Mod.Size = new System.Drawing.Size(75, 86);
            this.Mod.TabIndex = 18;
            this.Mod.TabStop = false;
            this.Mod.Text = "%";
            this.Mod.UseVisualStyleBackColor = true;
            this.Mod.Click += new System.EventHandler(this.ModClick);
            // 
            // Go
            // 
            this.Go.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Go.Location = new System.Drawing.Point(32, 457);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(156, 86);
            this.Go.TabIndex = 16;
            this.Go.TabStop = false;
            this.Go.Text = "=";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.GoClick);
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Multiply.Location = new System.Drawing.Point(275, 365);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(75, 86);
            this.Multiply.TabIndex = 15;
            this.Multiply.TabStop = false;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.MultiplyClick);
            // 
            // One
            // 
            this.One.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.One.Location = new System.Drawing.Point(194, 365);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(75, 86);
            this.One.TabIndex = 14;
            this.One.TabStop = false;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.OneClick);
            // 
            // Zero
            // 
            this.Zero.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Zero.Location = new System.Drawing.Point(113, 365);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(75, 86);
            this.Zero.TabIndex = 13;
            this.Zero.TabStop = false;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.ZeroClick);
            // 
            // Dot
            // 
            this.Dot.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Dot.Location = new System.Drawing.Point(32, 365);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(75, 86);
            this.Dot.TabIndex = 12;
            this.Dot.TabStop = false;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.MinusClick);
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Minus.Location = new System.Drawing.Point(275, 273);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(75, 86);
            this.Minus.TabIndex = 11;
            this.Minus.TabStop = false;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.MinusClick);
            // 
            // Four
            // 
            this.Four.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Four.Location = new System.Drawing.Point(194, 273);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(75, 86);
            this.Four.TabIndex = 10;
            this.Four.TabStop = false;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.FourClick);
            // 
            // Three
            // 
            this.Three.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Three.Location = new System.Drawing.Point(113, 273);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(75, 86);
            this.Three.TabIndex = 9;
            this.Three.TabStop = false;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.ThreeClick);
            // 
            // Two
            // 
            this.Two.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Two.Location = new System.Drawing.Point(32, 273);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(75, 86);
            this.Two.TabIndex = 8;
            this.Two.TabStop = false;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.TwoClick);
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Plus.Location = new System.Drawing.Point(275, 181);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(75, 86);
            this.Plus.TabIndex = 7;
            this.Plus.TabStop = false;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.PlusClick);
            // 
            // Seven
            // 
            this.Seven.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Seven.Location = new System.Drawing.Point(194, 181);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(75, 86);
            this.Seven.TabIndex = 6;
            this.Seven.TabStop = false;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.SevenClick);
            // 
            // Six
            // 
            this.Six.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Six.Location = new System.Drawing.Point(113, 181);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(75, 86);
            this.Six.TabIndex = 5;
            this.Six.TabStop = false;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.SixClick);
            // 
            // Five
            // 
            this.Five.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Five.Location = new System.Drawing.Point(32, 181);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(75, 86);
            this.Five.TabIndex = 4;
            this.Five.TabStop = false;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.FiveClick);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Clear.Location = new System.Drawing.Point(275, 91);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 86);
            this.Clear.TabIndex = 3;
            this.Clear.TabStop = false;
            this.Clear.Text = "CE";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.ClearClick);
            // 
            // Backspace
            // 
            this.Backspace.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Backspace.Location = new System.Drawing.Point(194, 91);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(75, 86);
            this.Backspace.TabIndex = 2;
            this.Backspace.TabStop = false;
            this.Backspace.Text = "<-";
            this.Backspace.UseVisualStyleBackColor = true;
            this.Backspace.Click += new System.EventHandler(this.BackspaceClick);
            // 
            // Nine
            // 
            this.Nine.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Nine.Location = new System.Drawing.Point(113, 91);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(75, 86);
            this.Nine.TabIndex = 1;
            this.Nine.TabStop = false;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.NineClick);
            // 
            // Eight
            // 
            this.Eight.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Eight.Location = new System.Drawing.Point(32, 91);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(75, 86);
            this.Eight.TabIndex = 0;
            this.Eight.TabStop = false;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.EightClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MathOutput);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 68);
            this.panel2.TabIndex = 1;
            // 
            // MathOutput
            // 
            this.MathOutput.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MathOutput.Location = new System.Drawing.Point(12, 12);
            this.MathOutput.Name = "MathOutput";
            this.MathOutput.ReadOnly = true;
            this.MathOutput.Size = new System.Drawing.Size(360, 40);
            this.MathOutput.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypeEquation);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox MathOutput;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Mod;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Backspace;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Eight;
    }
}

