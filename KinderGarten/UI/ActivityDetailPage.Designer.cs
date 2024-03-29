﻿
namespace KinderGarten.UI
{
    partial class ActivityDetailPage
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
            this.activitiesdgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.contexttxt = new System.Windows.Forms.TextBox();
            this.periodtxt = new System.Windows.Forms.TextBox();
            this.ageGrouptxt = new System.Windows.Forms.TextBox();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesdgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // activitiesdgv
            // 
            this.activitiesdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activitiesdgv.Location = new System.Drawing.Point(48, 95);
            this.activitiesdgv.Name = "activitiesdgv";
            this.activitiesdgv.RowHeadersWidth = 51;
            this.activitiesdgv.RowTemplate.Height = 24;
            this.activitiesdgv.Size = new System.Drawing.Size(1060, 426);
            this.activitiesdgv.TabIndex = 0;
            this.activitiesdgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.activitiesdgv_RowHeaderMouseClick);
            this.activitiesdgv.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.activitiesdgv_RowHeaderMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deletebtn);
            this.groupBox1.Controls.Add(this.updatebtn);
            this.groupBox1.Controls.Add(this.ageGrouptxt);
            this.groupBox1.Controls.Add(this.periodtxt);
            this.groupBox1.Controls.Add(this.contexttxt);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Location = new System.Drawing.Point(48, 548);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1060, 233);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label31
            // 
            this.label31.Location = new System.Drawing.Point(25, 31);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(147, 23);
            this.label31.TabIndex = 2;
            this.label31.Text = "Inhalt";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.Location = new System.Drawing.Point(25, 106);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(147, 23);
            this.label30.TabIndex = 3;
            this.label30.Text = "Zeitraum";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.Location = new System.Drawing.Point(25, 178);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(147, 23);
            this.label29.TabIndex = 5;
            this.label29.Text = "Altersgruppe";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contexttxt
            // 
            this.contexttxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.contexttxt.Location = new System.Drawing.Point(303, 30);
            this.contexttxt.Name = "contexttxt";
            this.contexttxt.Size = new System.Drawing.Size(144, 22);
            this.contexttxt.TabIndex = 6;
            // 
            // periodtxt
            // 
            this.periodtxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.periodtxt.Location = new System.Drawing.Point(303, 106);
            this.periodtxt.Name = "periodtxt";
            this.periodtxt.Size = new System.Drawing.Size(144, 22);
            this.periodtxt.TabIndex = 7;
            // 
            // ageGrouptxt
            // 
            this.ageGrouptxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ageGrouptxt.Location = new System.Drawing.Point(303, 179);
            this.ageGrouptxt.Name = "ageGrouptxt";
            this.ageGrouptxt.Size = new System.Drawing.Size(144, 22);
            this.ageGrouptxt.TabIndex = 8;
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(748, 31);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(218, 74);
            this.updatebtn.TabIndex = 9;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(748, 134);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(218, 67);
            this.deletebtn.TabIndex = 10;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(48, 25);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(143, 42);
            this.closebtn.TabIndex = 2;
            this.closebtn.Text = "Verlassen";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // ActivityDetailPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 793);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.activitiesdgv);
            this.Name = "ActivityDetailPage";
            this.Text = "ActivityDetailPage";
            this.Load += new System.EventHandler(this.ActivityDetailPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activitiesdgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView activitiesdgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.TextBox ageGrouptxt;
        private System.Windows.Forms.TextBox periodtxt;
        private System.Windows.Forms.TextBox contexttxt;
        private System.Windows.Forms.Button closebtn;
    }
}