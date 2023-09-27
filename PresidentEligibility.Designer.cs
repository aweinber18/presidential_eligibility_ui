namespace PresidentEligibilityUI
{
    partial class PresidentEligibilityForm
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
            NaturalBorn = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            HasRebelled = new CheckBox();
            button1 = new Button();
            YOB = new TextBox();
            YearsOfResidence = new TextBox();
            PriorTerms = new TextBox();
            SuspendLayout();
            // 
            // checkBox1
            // 
            NaturalBorn.AutoSize = true;
            NaturalBorn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            NaturalBorn.Location = new Point(259, 79);
            NaturalBorn.Name = "checkBox1";
            NaturalBorn.Size = new Size(221, 25);
            NaturalBorn.TabIndex = 0;
            NaturalBorn.Text = "I am a natural born citizen";
            NaturalBorn.UseVisualStyleBackColor = true;
            NaturalBorn.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(259, 124);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 1;
            label1.Text = "Year of birth:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(259, 171);
            label2.Name = "label2";
            label2.Size = new Size(272, 21);
            label2.TabIndex = 2;
            label2.Text = "Amount of years resided in the US:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(259, 221);
            label3.Name = "label3";
            label3.Size = new Size(217, 21);
            label3.TabIndex = 3;
            label3.Text = "Prior terms served in office:";
            // 
            // checkBox2
            // 
            HasRebelled.AutoSize = true;
            HasRebelled.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            HasRebelled.Location = new Point(259, 271);
            HasRebelled.Name = "checkBox2";
            HasRebelled.Size = new Size(249, 25);
            HasRebelled.TabIndex = 4;
            HasRebelled.Text = "I have rebelled against the US";
            HasRebelled.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(334, 335);
            button1.Name = "button1";
            button1.Size = new Size(197, 48);
            button1.TabIndex = 5;
            button1.Text = "Are you eligible???";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            YOB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            YOB.Location = new Point(540, 117);
            YOB.MaxLength = 4;
            YOB.Name = "textBox1";
            YOB.Size = new Size(60, 33);
            YOB.TabIndex = 6;
            // 
            // textBox2
            // 
            YearsOfResidence.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            YearsOfResidence.Location = new Point(540, 164);
            YearsOfResidence.MaxLength = 3;
            YearsOfResidence.Name = "textBox2";
            YearsOfResidence.Size = new Size(60, 33);
            YearsOfResidence.TabIndex = 7;
            // 
            // textBox3
            // 
            PriorTerms.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PriorTerms.Location = new Point(540, 214);
            PriorTerms.MaxLength = 2;
            PriorTerms.Name = "textBox3";
            PriorTerms.Size = new Size(60, 33);
            PriorTerms.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PriorTerms);
            Controls.Add(YearsOfResidence);
            Controls.Add(YOB);
            Controls.Add(button1);
            Controls.Add(HasRebelled);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NaturalBorn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox NaturalBorn;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox HasRebelled;
        private TextBox YOB;
        private TextBox YearsOfResidence;
        private TextBox PriorTerms;
        private Button button1;
    }
}