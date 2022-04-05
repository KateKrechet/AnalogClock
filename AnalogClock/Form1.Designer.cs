
namespace AnalogClock
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
            this.myAnalogClock1 = new AnalogClock.MyAnalogClock();
            ((System.ComponentModel.ISupportInitialize)(this.myAnalogClock1)).BeginInit();
            this.SuspendLayout();
            // 
            // myAnalogClock1
            // 
            this.myAnalogClock1.BackgroundClockImage = global::AnalogClock.Properties.Resources.clock;
            this.myAnalogClock1.BackgroundColor = System.Drawing.Color.Aqua;
            this.myAnalogClock1.HourArrowColor = System.Drawing.Color.Black;
            this.myAnalogClock1.HourArrowWidth = 6;
            this.myAnalogClock1.Location = new System.Drawing.Point(148, 89);
            this.myAnalogClock1.MinuteArrowColor = System.Drawing.Color.Red;
            this.myAnalogClock1.MinuteArrowWidth = 4;
            this.myAnalogClock1.Name = "myAnalogClock1";
            this.myAnalogClock1.SecondArrowColor = System.Drawing.Color.Blue;
            this.myAnalogClock1.SecondArrowWidth = 2;
            this.myAnalogClock1.Size = new System.Drawing.Size(250, 250);
            this.myAnalogClock1.TabIndex = 0;
            this.myAnalogClock1.TabStop = false;
            this.myAnalogClock1.UseImage = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myAnalogClock1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myAnalogClock1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyAnalogClock myAnalogClock1;
    }
}

