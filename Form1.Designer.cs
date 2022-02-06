using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WindowsFormsApp1 {
    partial class Form1 {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Button btnReset;
        private List < TextBox > St;
        private List < TextBox > Lt;
        private List < Label > lblPeriod;
        private TextBox price;
        private Button addInputBtn;
        private Button removeInputBtn;

        private Label lblPrice;
        private Label lblSt;
        private Label lblLt;
        private Label lblCalc;
        private Label lblOutput;

        private CheckBox showDebug;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnSendData = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.addInputBtn = new System.Windows.Forms.Button();
            this.removeInputBtn = new System.Windows.Forms.Button();
            this.St = new List < TextBox > () {};
            this.Lt = new List < TextBox > () {};
            this.price = new TextBox();
            this.lblSt = new System.Windows.Forms.Label();
            this.lblLt = new System.Windows.Forms.Label();
            this.lblCalc = new System.Windows.Forms.Label();
            this.lblPeriod = new List < Label > () {};
            this.showDebug = new CheckBox();
            this.SuspendLayout();
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(600, 175);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(150, 32);
            this.btnSendData.TabIndex = 0;
            this.btnSendData.Text = "Розрахувати";
            this.btnSendData.UseCompatibleTextRendering = true;
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(800, 175);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 32);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Перезавантажити форму";
            this.btnReset.UseCompatibleTextRendering = true;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(565, 90);
            this.lblPrice.Name = "lblOutput";
            this.lblPrice.Size = new System.Drawing.Size(46, 17);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Ціна заміни, грн.";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(375, 250);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(46, 17);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "Будь-ласка, зазначте дані по періодам, вартість заміни і натисніть кнопку \"Розрахувати\"";
            // 
            // lblSt
            // 
            this.lblSt.AutoSize = true;
            this.lblSt.Location = new System.Drawing.Point(135, 50);
            this.lblSt.Name = "lblSt";
            this.lblSt.Size = new System.Drawing.Size(46, 17);
            this.lblSt.TabIndex = 1;
            this.lblSt.Text = "St, грн.";
            // 
            // lblLt
            // 
            this.lblLt.AutoSize = true;
            this.lblLt.Location = new System.Drawing.Point(250, 50);
            this.lblLt.Name = "lblLt";
            this.lblLt.Size = new System.Drawing.Size(46, 17);
            this.lblLt.TabIndex = 1;
            this.lblLt.Text = "Lt, грн.";
            // 
            // lblCalc
            // 
            this.lblCalc.AutoSize = true;
            this.lblCalc.Location = new System.Drawing.Point(375, 175);
            this.lblCalc.Name = "lblCalc";
            this.lblCalc.Size = new System.Drawing.Size(46, 17);
            this.lblCalc.TabIndex = 1;
            this.lblCalc.Text = "St - залишкова вартість, грн.\nLt - прибуток за період, грн.";
            // 
            // lblPeriod
            // 
            Label lblPeriod = new System.Windows.Forms.Label();
            lblPeriod.AutoSize = true;
            lblPeriod.Location = new System.Drawing.Point(35, 95);
            lblPeriod.Name = "lblPeriod0";
            lblPeriod.Size = new System.Drawing.Size(46, 17);
            lblPeriod.TabIndex = 1;
            lblPeriod.Text = "Період 0";
            this.lblPeriod.Add(lblPeriod);
            // 
            // textBoxes
            // 

            TextBox StStart = new TextBox();
            StStart.Location = new System.Drawing.Point(135, 90);
            StStart.Name = "stBox0";
            StStart.Size = new System.Drawing.Size(100, 22);
            StStart.TabIndex = 2;

            St.Add(StStart);

            TextBox LtStart = new TextBox();
            LtStart.Location = new System.Drawing.Point(250, 90);
            LtStart.Name = "ltBox0";
            LtStart.Size = new System.Drawing.Size(100, 22);
            LtStart.TabIndex = 3;

            Lt.Add(LtStart);

            // 
            // price
            // 
            price.Location = new System.Drawing.Point(715, 90);
            price.Name = "price";
            price.Size = new System.Drawing.Size(100, 22);
            price.TabIndex = 4;

            // 
            // showDebug
            // 
            this.showDebug.AutoSize = true;
            this.showDebug.Location = new System.Drawing.Point(565, 130);
            this.showDebug.Name = "showDebug";
            this.showDebug.Size = new System.Drawing.Size(46, 17);
            this.showDebug.TabIndex = 1;
            this.showDebug.Text = "Показати етапи розрахунків";
            this.showDebug.Checked = false;

            // 
            // addInputBtn
            // 
            this.addInputBtn.Location = new System.Drawing.Point(375, 90);
            this.addInputBtn.Name = "addInputBtn";
            this.addInputBtn.Size = new System.Drawing.Size(150, 24);
            this.addInputBtn.TabIndex = 5;
            this.addInputBtn.Text = "Додати період";
            this.addInputBtn.UseVisualStyleBackColor = true;
            this.addInputBtn.Click += new System.EventHandler(this.addInput_Click);

            // 
            // removeInputBtn
            // 
            this.removeInputBtn.Location = new System.Drawing.Point(375, 132);
            this.removeInputBtn.Name = "removeInputBtn";
            this.removeInputBtn.Size = new System.Drawing.Size(150, 24);
            this.removeInputBtn.TabIndex = 6;
            this.removeInputBtn.Text = "Видалити період";
            this.removeInputBtn.UseVisualStyleBackColor = true;
            this.removeInputBtn.Click += new System.EventHandler(this.removeInput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addInputBtn);
            this.Controls.Add(this.removeInputBtn);
            this.Controls.Add(StStart);
            this.Controls.Add(LtStart);
            this.Controls.Add(this.price);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblSt);
            this.Controls.Add(this.lblLt);
            this.Controls.Add(this.lblCalc);
            this.Controls.Add(lblPeriod);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.showDebug);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    }
}