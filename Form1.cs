using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1 {
    public partial class Form1: Form {
        private int periodsCount = 1;
        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {
            lblOutput.Text = "Haha!";
        }

        private void btnSendData_Click_1(object sender, EventArgs e) {
            int priceValue;
            bool priceValueParsed = int.TryParse(price.Text, out priceValue);
            if (!priceValueParsed || priceValue <= 0) {
                MessageBox.Show("Введіть значення ціни заміни");
                return;
            }

            List < int > StData = new List < int > ();
            for (int i = 0; i <= St.Count; i++) {
                TextBox currentTextBox = this.Controls["stBox" + i.ToString()] as TextBox;
                if (currentTextBox != null) {
                    int input;
                    bool textBoxValueParsed = int.TryParse(currentTextBox.Text, out input);
                    if (textBoxValueParsed) {
                        StData.Add(input);
                    } else {
                        MessageBox.Show("Тільки цілі числа");
                        return;
                    }

                }

            }
            List < int > LtData = new List < int > ();
            for (int i = 0; i <= St.Count; i++) {
                TextBox currentTextBox = this.Controls["ltBox" + i.ToString()] as TextBox;
                if (currentTextBox != null) {
                    int input;
                    bool textBoxValueParsed = int.TryParse(currentTextBox.Text, out input);
                    if (textBoxValueParsed) {
                        LtData.Add(input);
                    } else {
                        MessageBox.Show("Тільки цілі числа");
                        return;
                    }

                }

            }
            Handler handler = new Handler(StData, LtData, priceValue);
            handler.process();

            lblOutput.Text = handler.getOutput(showDebug.Checked);
        }

        private void btnReset_Click_1(object sender, EventArgs e) {
            this.resetForm();
        }

        private void addInput_Click(object sender, EventArgs e) {

            TextBox StStart = St.First();
            TextBox newSt = new TextBox();
            newSt.Location = new System.Drawing.Point(StStart.Location.X, StStart.Location.Y + 35 * this.periodsCount);
            newSt.Name = "stBox" + this.periodsCount.ToString();
            newSt.Size = new System.Drawing.Size(StStart.Size.Width, StStart.Size.Height);
            newSt.TabIndex = this.Controls.Count + 1;
            St.Add(newSt);
            this.Controls.Add(newSt);
            TextBox LtStart = Lt.First();
            TextBox newLt = new TextBox();
            newLt.Location = new System.Drawing.Point(LtStart.Location.X, LtStart.Location.Y + 35 * this.periodsCount);
            newLt.Name = "ltBox" + this.periodsCount.ToString();
            newLt.Size = new System.Drawing.Size(LtStart.Size.Width, LtStart.Size.Height);
            newLt.TabIndex = this.Controls.Count + 1;
            Lt.Add(newLt);
            this.Controls.Add(newLt);
            Label newLblPeriod = new System.Windows.Forms.Label();
            Label lblPeriodStart = lblPeriod.First();
            newLblPeriod.AutoSize = true;
            newLblPeriod.Location = new System.Drawing.Point(lblPeriodStart.Location.X, lblPeriodStart.Location.Y + 35 * this.periodsCount);
            newLblPeriod.Name = "lblPeriod" + this.periodsCount.ToString();
            newLblPeriod.Size = new System.Drawing.Size(lblPeriodStart.Size.Width, lblPeriodStart.Size.Height);
            newLblPeriod.TabIndex = this.Controls.Count + 1;
            newLblPeriod.Text = "Період " + this.periodsCount.ToString();
            lblPeriod.Add(newLblPeriod);
            this.Controls.Add(newLblPeriod);
            this.periodsCount++;
        }
        private void removeInput_Click(object sender, EventArgs e) {
            this.removeInput();
        }

        private bool removeInput() {
            if (this.periodsCount > 1) {
                this.Controls.Remove(Lt.Last());
                this.Controls.Remove(St.Last());
                this.Controls.Remove(lblPeriod.Last());
                Lt.RemoveAt(Lt.Count - 1);
                St.RemoveAt(St.Count - 1);
                lblPeriod.RemoveAt(lblPeriod.Count - 1);
                this.periodsCount--;

                return true;
            }

            return false;
        }

        private void resetForm() {
            for (int i = 0; i <= St.Count; i++) {
                TextBox currentSTBox = this.Controls["stBox" + i.ToString()] as TextBox;
                TextBox currentLTBox = this.Controls["ltBox" + i.ToString()] as TextBox;
                if (currentSTBox != null) {
                    currentSTBox.Text = "0";
                }
                if (currentLTBox != null) {
                    currentLTBox.Text = "0";
                }
            }
        }
    }
}