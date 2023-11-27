namespace Minecraft_Texture_Json
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxParent = new System.Windows.Forms.TextBox();
            this.txtBoxPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxTextureName = new System.Windows.Forms.TextBox();
            this.txtBoxJsonPreview = new System.Windows.Forms.TextBox();
            this.txtBoxCustomModelDataCopy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxOutput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReference = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.chkComma = new System.Windows.Forms.CheckBox();
            this.lblTextureName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(429, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parent：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(441, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Path：";
            // 
            // txtBoxParent
            // 
            this.txtBoxParent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxParent.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxParent.Location = new System.Drawing.Point(488, 30);
            this.txtBoxParent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxParent.Name = "txtBoxParent";
            this.txtBoxParent.Size = new System.Drawing.Size(313, 23);
            this.txtBoxParent.TabIndex = 0;
            this.txtBoxParent.Text = "item/handheld";
            this.txtBoxParent.TextChanged += new System.EventHandler(this.txtBoxParent_TextChanged);
            // 
            // txtBoxPath
            // 
            this.txtBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPath.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxPath.Location = new System.Drawing.Point(488, 61);
            this.txtBoxPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxPath.Name = "txtBoxPath";
            this.txtBoxPath.Size = new System.Drawing.Size(313, 23);
            this.txtBoxPath.TabIndex = 1;
            this.txtBoxPath.Text = "resource:item/carrot_on_a_stick";
            this.txtBoxPath.TextChanged += new System.EventHandler(this.txtBoxPath_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(428, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "TextureName：";
            // 
            // txtBoxTextureName
            // 
            this.txtBoxTextureName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxTextureName.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxTextureName.Location = new System.Drawing.Point(432, 115);
            this.txtBoxTextureName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxTextureName.Multiline = true;
            this.txtBoxTextureName.Name = "txtBoxTextureName";
            this.txtBoxTextureName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxTextureName.Size = new System.Drawing.Size(369, 152);
            this.txtBoxTextureName.TabIndex = 2;
            this.txtBoxTextureName.TextChanged += new System.EventHandler(this.txtBoxTextureName_TextChanged);
            this.txtBoxTextureName.Enter += new System.EventHandler(this.txtBoxTextureName_Enter);
            this.txtBoxTextureName.Leave += new System.EventHandler(this.txtBoxTextureName_Leave);
            // 
            // txtBoxJsonPreview
            // 
            this.txtBoxJsonPreview.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtBoxJsonPreview.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxJsonPreview.Location = new System.Drawing.Point(14, 30);
            this.txtBoxJsonPreview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxJsonPreview.Multiline = true;
            this.txtBoxJsonPreview.Name = "txtBoxJsonPreview";
            this.txtBoxJsonPreview.ReadOnly = true;
            this.txtBoxJsonPreview.Size = new System.Drawing.Size(408, 236);
            this.txtBoxJsonPreview.TabIndex = 12;
            this.txtBoxJsonPreview.Text = "{\r\n    \"parent\": \"item/handheld\",\r\n    \"textures\": {\r\n        \"layer0\": \"resource" +
    ":item/carrot_on_a_stick/ \"\r\n    }\r\n}";
            // 
            // txtBoxCustomModelDataCopy
            // 
            this.txtBoxCustomModelDataCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCustomModelDataCopy.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxCustomModelDataCopy.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxCustomModelDataCopy.Location = new System.Drawing.Point(14, 294);
            this.txtBoxCustomModelDataCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxCustomModelDataCopy.Multiline = true;
            this.txtBoxCustomModelDataCopy.Name = "txtBoxCustomModelDataCopy";
            this.txtBoxCustomModelDataCopy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxCustomModelDataCopy.Size = new System.Drawing.Size(787, 149);
            this.txtBoxCustomModelDataCopy.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(12, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "CustomModelData (コピペ用)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(12, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "JsonPreview";
            // 
            // txtBoxOutput
            // 
            this.txtBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxOutput.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxOutput.Location = new System.Drawing.Point(73, 454);
            this.txtBoxOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxOutput.Name = "txtBoxOutput";
            this.txtBoxOutput.Size = new System.Drawing.Size(522, 23);
            this.txtBoxOutput.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(14, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Output：";
            // 
            // btnReference
            // 
            this.btnReference.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReference.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReference.Location = new System.Drawing.Point(603, 451);
            this.btnReference.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReference.Name = "btnReference";
            this.btnReference.Size = new System.Drawing.Size(96, 29);
            this.btnReference.TabIndex = 3;
            this.btnReference.Text = "参照";
            this.btnReference.UseVisualStyleBackColor = true;
            this.btnReference.Click += new System.EventHandler(this.btnReference_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOutput.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnOutput.Location = new System.Drawing.Point(706, 451);
            this.btnOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(96, 29);
            this.btnOutput.TabIndex = 4;
            this.btnOutput.Text = "出力";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // chkComma
            // 
            this.chkComma.AutoSize = true;
            this.chkComma.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkComma.Location = new System.Drawing.Point(710, 274);
            this.chkComma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkComma.Name = "chkComma";
            this.chkComma.Size = new System.Drawing.Size(91, 19);
            this.chkComma.TabIndex = 6;
            this.chkComma.Text = "すべてにカンマ";
            this.chkComma.UseVisualStyleBackColor = true;
            this.chkComma.CheckedChanged += new System.EventHandler(this.chkComma_CheckedChanged);
            // 
            // lblTextureName
            // 
            this.lblTextureName.AutoSize = true;
            this.lblTextureName.BackColor = System.Drawing.SystemColors.Window;
            this.lblTextureName.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTextureName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTextureName.Location = new System.Drawing.Point(435, 118);
            this.lblTextureName.Name = "lblTextureName";
            this.lblTextureName.Size = new System.Drawing.Size(288, 15);
            this.lblTextureName.TabIndex = 21;
            this.lblTextureName.Text = "改行で複数入力(ファイルのDragAndDropでも入力可能)";
            this.lblTextureName.Click += new System.EventHandler(this.lblTextureName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(815, 495);
            this.Controls.Add(this.lblTextureName);
            this.Controls.Add(this.chkComma);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnReference);
            this.Controls.Add(this.txtBoxOutput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxCustomModelDataCopy);
            this.Controls.Add(this.txtBoxJsonPreview);
            this.Controls.Add(this.txtBoxTextureName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxPath);
            this.Controls.Add(this.txtBoxParent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "timtam : Texture_Json";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxParent;
        private System.Windows.Forms.TextBox txtBoxPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxTextureName;
        private System.Windows.Forms.TextBox txtBoxJsonPreview;
        private System.Windows.Forms.TextBox txtBoxCustomModelDataCopy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReference;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.CheckBox chkComma;
        private System.Windows.Forms.Label lblTextureName;
    }
}

