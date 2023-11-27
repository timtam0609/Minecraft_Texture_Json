using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;

namespace Minecraft_Texture_Json
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // フォームにファイルのドラッグアンドドロップを許可する
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(MainForm_DragEnter);
            this.DragDrop += new DragEventHandler(MainForm_DragDrop);
        }

        // ファイルがフォーム内にドラッグされたときの処理
        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        // ファイルがフォームにドロップされたときの処理
        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 0)
            {
                for (int i = 0; i < files.Length; i++)
                {
                    files[i] = Path.GetFileNameWithoutExtension(files[i]);
                }
                lblTextureName.Visible = false;
                txtBoxTextureName.Lines = files;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBoxOutput.Text = Properties.Settings.Default.LastFilePath;
        }

        private void txtBoxParent_TextChanged(object sender, EventArgs e)
        {
            // JsonPreviewの処理
            if (txtBoxParent.Text != "")
            {
                string[] JsonPreview = txtBoxJsonPreview.Lines;
                JsonPreview[1] = "    \"parent\": \"" + txtBoxParent.Text + "\",";
                txtBoxJsonPreview.Lines = JsonPreview;
            }
            else
            {
                string[] JsonPreview = txtBoxJsonPreview.Lines;
                JsonPreview[1] = "    \"parent\": \" \",";
                txtBoxJsonPreview.Lines = JsonPreview;
            }
        }

        private void txtBoxPath_TextChanged(object sender, EventArgs e)
        {
            ChangeTextureName();
        }

        private void txtBoxTextureName_TextChanged(object sender, EventArgs e)
        {
            ChangeTextureName();
        }

        void ChangeTextureName()
        {
            // JsonPreviewの処理
            if (txtBoxPath.Text != "")
            {
                string[] JsonPreview = txtBoxJsonPreview.Lines;
                string TextureName = " ";
                if (txtBoxTextureName.Text != "")
                {
                    TextureName = txtBoxTextureName.Lines[0];
                }
                JsonPreview[3] = "        \"layer0\": \"" + txtBoxPath.Text + "/" + TextureName + "\"";
                txtBoxJsonPreview.Lines = JsonPreview;
            }
            else
            {
                string[] JsonPreview = txtBoxJsonPreview.Lines;
                string TextureName = " ";
                if (txtBoxTextureName.Text != "")
                {
                    TextureName = txtBoxTextureName.Lines[0];
                }
                JsonPreview[3] = "        \"layer0\": \" /" + TextureName + "\"";
                txtBoxJsonPreview.Lines = JsonPreview;
            }

            // CustomModelDataの処理
            string[] CustomModelDataTexts = new string[txtBoxTextureName.Lines.Length + 1];
            CustomModelDataTexts[0] = "";
            int i = 1;
            foreach (string value in txtBoxTextureName.Lines)
            {
                // 文の作成
                string template = "\t{\"predicate\": {\"custom_model_data\": $1}, \"$2/$1\", \"#\": \"Name\"}";
                template = template.Replace("$1", value);
                if (txtBoxPath.Text != "")
                {
                    template = template.Replace("$2", txtBoxPath.Text);
                }
                else
                {
                    template = template.Replace("$2", "");
                }
                // 文を追加
                // カンマのモード確認
                if (chkComma.Checked == false)
                {
                    if (i != txtBoxTextureName.Lines.Length)
                    {
                        template += ",";
                    }
                }
                else
                {
                    template += ",";
                }
                CustomModelDataTexts[i] = template;
                i++;
            }
            txtBoxCustomModelDataCopy.Lines = CustomModelDataTexts;
        }

        /// <summary>
        /// 出力先フォルダを設定。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReference_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog() { FileName = "SelectFolder", Filter = "Folder|.", CheckFileExists = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtBoxOutput.Text = Path.GetDirectoryName(ofd.FileName);
                }
            }
                
        }

        /// <summary>
        /// Jsonファイルの出力。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOutput_Click(object sender, EventArgs e)
        {
            // エラーチェック
            if (txtBoxOutput.Text == "")
            {
                MessageBox.Show(this,"出力フォルダを選択してください。","エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxOutput.Focus();
                return;
            }
            if (txtBoxTextureName.Text == "")
            {
                MessageBox.Show(this, "Textureの名前を指定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxTextureName.Focus();
                return;
            }

            string template = "{\n" +
                "\t\"parent\": \"item/$1\",\n" +
                "\t\"textures\": {\n" +
                "\t\t\"layer0\": \"$2/$3\"\n" +
                "\t}\n" +
                "}\n";
            template = template.Replace("$1",txtBoxParent.Text);
            template = template.Replace("$2", txtBoxPath.Text);
            foreach (string value in txtBoxTextureName.Lines)
            {
                string templateTemp = template;
                templateTemp = templateTemp.Replace("$3", value);
                // ファイルに書き込む
                string filePath = txtBoxOutput.Text + @"\" +value + ".json";
                File.WriteAllText(filePath, templateTemp);
            }
        }

        private void chkComma_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTextureName();
        }

        private void txtBoxTextureName_Enter(object sender, EventArgs e)
        {
            lblTextureName.Visible = false;
        }

        private void lblTextureName_Click(object sender, EventArgs e)
        {
            lblTextureName.Visible = false;
            txtBoxTextureName.Focus();
        }

        private void txtBoxTextureName_Leave(object sender, EventArgs e)
        {
            if (txtBoxTextureName.Text == "")
            {
                lblTextureName.Visible = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.LastFilePath = txtBoxOutput.Text;
            Properties.Settings.Default.Save();
        }
    }
}
