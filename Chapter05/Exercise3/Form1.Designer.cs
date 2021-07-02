
namespace Exercise3 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.inputStrText = new System.Windows.Forms.TextBox();
            this.Button5_3_1 = new System.Windows.Forms.Button();
            this.TextBoxSpaceCount = new System.Windows.Forms.TextBox();
            this.Button5_3_2 = new System.Windows.Forms.Button();
            this.TextBoxWordChange = new System.Windows.Forms.TextBox();
            this.Button5_3_3 = new System.Windows.Forms.Button();
            this.tbWordCount = new System.Windows.Forms.TextBox();
            this.Button5_3_4 = new System.Windows.Forms.Button();
            this.tbWordCount4 = new System.Windows.Forms.TextBox();
            this.tbStrBuilder = new System.Windows.Forms.TextBox();
            this.Button5_3_5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.outputStrData = new System.Windows.Forms.TextBox();
            this.inputStrData = new System.Windows.Forms.TextBox();
            this.Button5_4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "問題5.3";
            // 
            // inputStrText
            // 
            this.inputStrText.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inputStrText.Location = new System.Drawing.Point(28, 63);
            this.inputStrText.Name = "inputStrText";
            this.inputStrText.Size = new System.Drawing.Size(757, 31);
            this.inputStrText.TabIndex = 1;
            // 
            // Button5_3_1
            // 
            this.Button5_3_1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_3_1.Location = new System.Drawing.Point(55, 136);
            this.Button5_3_1.Name = "Button5_3_1";
            this.Button5_3_1.Size = new System.Drawing.Size(190, 53);
            this.Button5_3_1.TabIndex = 2;
            this.Button5_3_1.Text = "空白をカウント";
            this.Button5_3_1.UseVisualStyleBackColor = true;
            this.Button5_3_1.Click += new System.EventHandler(this.Button5_3_1_Click);
            // 
            // TextBoxSpaceCount
            // 
            this.TextBoxSpaceCount.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxSpaceCount.Location = new System.Drawing.Point(296, 147);
            this.TextBoxSpaceCount.Name = "TextBoxSpaceCount";
            this.TextBoxSpaceCount.Size = new System.Drawing.Size(152, 31);
            this.TextBoxSpaceCount.TabIndex = 3;
            // 
            // Button5_3_2
            // 
            this.Button5_3_2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_3_2.Location = new System.Drawing.Point(55, 225);
            this.Button5_3_2.Name = "Button5_3_2";
            this.Button5_3_2.Size = new System.Drawing.Size(190, 53);
            this.Button5_3_2.TabIndex = 2;
            this.Button5_3_2.Text = "big → small";
            this.Button5_3_2.UseVisualStyleBackColor = true;
            this.Button5_3_2.Click += new System.EventHandler(this.Button5_3_2_Click);
            // 
            // TextBoxWordChange
            // 
            this.TextBoxWordChange.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxWordChange.Location = new System.Drawing.Point(296, 236);
            this.TextBoxWordChange.Name = "TextBoxWordChange";
            this.TextBoxWordChange.Size = new System.Drawing.Size(489, 31);
            this.TextBoxWordChange.TabIndex = 3;
            // 
            // Button5_3_3
            // 
            this.Button5_3_3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_3_3.Location = new System.Drawing.Point(55, 306);
            this.Button5_3_3.Name = "Button5_3_3";
            this.Button5_3_3.Size = new System.Drawing.Size(190, 53);
            this.Button5_3_3.TabIndex = 2;
            this.Button5_3_3.Text = "単語の数";
            this.Button5_3_3.UseVisualStyleBackColor = true;
            this.Button5_3_3.Click += new System.EventHandler(this.Button5_3_3_Click);
            // 
            // tbWordCount
            // 
            this.tbWordCount.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWordCount.Location = new System.Drawing.Point(296, 317);
            this.tbWordCount.Name = "tbWordCount";
            this.tbWordCount.Size = new System.Drawing.Size(152, 31);
            this.tbWordCount.TabIndex = 3;
            // 
            // Button5_3_4
            // 
            this.Button5_3_4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_3_4.Location = new System.Drawing.Point(55, 383);
            this.Button5_3_4.Name = "Button5_3_4";
            this.Button5_3_4.Size = new System.Drawing.Size(190, 53);
            this.Button5_3_4.TabIndex = 2;
            this.Button5_3_4.Text = "4文字以下の単語";
            this.Button5_3_4.UseVisualStyleBackColor = true;
            this.Button5_3_4.Click += new System.EventHandler(this.Button5_3_4_Click);
            // 
            // tbWordCount4
            // 
            this.tbWordCount4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWordCount4.Location = new System.Drawing.Point(296, 392);
            this.tbWordCount4.Name = "tbWordCount4";
            this.tbWordCount4.Size = new System.Drawing.Size(489, 31);
            this.tbWordCount4.TabIndex = 3;
            // 
            // tbStrBuilder
            // 
            this.tbStrBuilder.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbStrBuilder.Location = new System.Drawing.Point(296, 469);
            this.tbStrBuilder.Name = "tbStrBuilder";
            this.tbStrBuilder.Size = new System.Drawing.Size(489, 31);
            this.tbStrBuilder.TabIndex = 3;
            // 
            // Button5_3_5
            // 
            this.Button5_3_5.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_3_5.Location = new System.Drawing.Point(55, 460);
            this.Button5_3_5.Name = "Button5_3_5";
            this.Button5_3_5.Size = new System.Drawing.Size(190, 53);
            this.Button5_3_5.TabIndex = 2;
            this.Button5_3_5.Text = "StringBuilder";
            this.Button5_3_5.UseVisualStyleBackColor = true;
            this.Button5_3_5.Click += new System.EventHandler(this.Button5_3_5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(23, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "問題5.4";
            // 
            // outputStrData
            // 
            this.outputStrData.Location = new System.Drawing.Point(296, 645);
            this.outputStrData.Multiline = true;
            this.outputStrData.Name = "outputStrData";
            this.outputStrData.Size = new System.Drawing.Size(489, 123);
            this.outputStrData.TabIndex = 4;
            // 
            // inputStrData
            // 
            this.inputStrData.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inputStrData.Location = new System.Drawing.Point(296, 608);
            this.inputStrData.Name = "inputStrData";
            this.inputStrData.Size = new System.Drawing.Size(489, 31);
            this.inputStrData.TabIndex = 3;
            // 
            // Button5_4
            // 
            this.Button5_4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_4.Location = new System.Drawing.Point(55, 608);
            this.Button5_4.Name = "Button5_4";
            this.Button5_4.Size = new System.Drawing.Size(190, 53);
            this.Button5_4.TabIndex = 2;
            this.Button5_4.Text = "問題5.4";
            this.Button5_4.UseVisualStyleBackColor = true;
            this.Button5_4.Click += new System.EventHandler(this.Button5_4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 823);
            this.Controls.Add(this.outputStrData);
            this.Controls.Add(this.TextBoxWordChange);
            this.Controls.Add(this.Button5_4);
            this.Controls.Add(this.Button5_3_5);
            this.Controls.Add(this.Button5_3_4);
            this.Controls.Add(this.Button5_3_3);
            this.Controls.Add(this.Button5_3_2);
            this.Controls.Add(this.inputStrData);
            this.Controls.Add(this.tbStrBuilder);
            this.Controls.Add(this.tbWordCount4);
            this.Controls.Add(this.tbWordCount);
            this.Controls.Add(this.TextBoxSpaceCount);
            this.Controls.Add(this.Button5_3_1);
            this.Controls.Add(this.inputStrText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputStrText;
        private System.Windows.Forms.Button Button5_3_1;
        private System.Windows.Forms.TextBox TextBoxSpaceCount;
        private System.Windows.Forms.Button Button5_3_2;
        private System.Windows.Forms.TextBox TextBoxWordChange;
        private System.Windows.Forms.Button Button5_3_3;
        private System.Windows.Forms.TextBox tbWordCount;
        private System.Windows.Forms.Button Button5_3_4;
        private System.Windows.Forms.TextBox tbWordCount4;
        private System.Windows.Forms.TextBox tbStrBuilder;
        private System.Windows.Forms.Button Button5_3_5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputStrData;
        private System.Windows.Forms.TextBox inputStrData;
        private System.Windows.Forms.Button Button5_4;
    }
}

