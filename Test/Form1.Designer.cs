namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableInterface1 = new CourseTable.TableInterface();
            this.SuspendLayout();
            // 
            // tableInterface1
            // 
            this.tableInterface1.Location = new System.Drawing.Point(3, 2);
            this.tableInterface1.Name = "tableInterface1";
            this.tableInterface1.Size = new System.Drawing.Size(1068, 726);
            this.tableInterface1.TabIndex = 0;
            this.tableInterface1.Load += new System.EventHandler(this.tableInterface1_Load);
            this.tableInterface1.Click += new System.EventHandler(this.tableInterface1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 839);
            this.Controls.Add(this.tableInterface1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CourseTable.TableInterface tableInterface1;
    }
}

