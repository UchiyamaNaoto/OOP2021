﻿
namespace Sample0823
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Value = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Jyou = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Exec = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Value
            // 
            this.Value.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Value.Location = new System.Drawing.Point(12, 12);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(107, 44);
            this.Value.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(125, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "の";
            // 
            // Jyou
            // 
            this.Jyou.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Jyou.Location = new System.Drawing.Point(175, 12);
            this.Jyou.Name = "Jyou";
            this.Jyou.Size = new System.Drawing.Size(107, 44);
            this.Jyou.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(288, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "乗";
            // 
            // Exec
            // 
            this.Exec.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Exec.Location = new System.Drawing.Point(358, 12);
            this.Exec.Name = "Exec";
            this.Exec.Size = new System.Drawing.Size(134, 44);
            this.Exec.TabIndex = 2;
            this.Exec.Text = "結果 →";
            this.Exec.UseVisualStyleBackColor = true;
            this.Exec.Click += new System.EventHandler(this.Exec_Click);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Result.Location = new System.Drawing.Point(518, 12);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(173, 44);
            this.Result.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(247, 277);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 19);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 487);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Exec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Jyou);
            this.Controls.Add(this.Value);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Jyou;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exec;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

