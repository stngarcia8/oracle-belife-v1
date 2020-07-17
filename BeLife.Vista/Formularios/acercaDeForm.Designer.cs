namespace BeLife.Vista.Formularios
{
    partial class acercaDeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(acercaDeForm));
            this.formularioPictureBox = new System.Windows.Forms.PictureBox();
            this.formularioImageList = new System.Windows.Forms.ImageList(this.components);
            this.aplicacionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.aplicacionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.formularioPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // formularioPictureBox
            // 
            this.formularioPictureBox.Image = global::BeLife.Vista.Properties.Resources.LogoBeLife;
            this.formularioPictureBox.Location = new System.Drawing.Point(0, 0);
            this.formularioPictureBox.Name = "formularioPictureBox";
            this.formularioPictureBox.Size = new System.Drawing.Size(125, 50);
            this.formularioPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.formularioPictureBox.TabIndex = 0;
            this.formularioPictureBox.TabStop = false;
            // 
            // formularioImageList
            // 
            this.formularioImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("formularioImageList.ImageStream")));
            this.formularioImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.formularioImageList.Images.SetKeyName(0, "aceptar.png");
            // 
            // aplicacionRichTextBox
            // 
            this.aplicacionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aplicacionRichTextBox.BulletIndent = 4;
            this.aplicacionRichTextBox.Location = new System.Drawing.Point(150, 0);
            this.aplicacionRichTextBox.Name = "aplicacionRichTextBox";
            this.aplicacionRichTextBox.ReadOnly = true;
            this.aplicacionRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.aplicacionRichTextBox.Size = new System.Drawing.Size(400, 225);
            this.aplicacionRichTextBox.TabIndex = 4;
            this.aplicacionRichTextBox.Text = "";
            // 
            // aplicacionButton
            // 
            this.aplicacionButton.AutoSize = true;
            this.aplicacionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.aplicacionButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.aplicacionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aplicacionButton.ImageKey = "aceptar.png";
            this.aplicacionButton.ImageList = this.formularioImageList;
            this.aplicacionButton.Location = new System.Drawing.Point(450, 275);
            this.aplicacionButton.Name = "aplicacionButton";
            this.aplicacionButton.Size = new System.Drawing.Size(93, 29);
            this.aplicacionButton.TabIndex = 5;
            this.aplicacionButton.Text = "&Aceptar";
            this.aplicacionButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aplicacionButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.aplicacionButton.UseVisualStyleBackColor = true;
            // 
            // acercaDeForm
            // 
            this.AcceptButton = this.aplicacionButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.aplicacionButton;
            this.ClientSize = new System.Drawing.Size(557, 322);
            this.Controls.Add(this.aplicacionButton);
            this.Controls.Add(this.aplicacionRichTextBox);
            this.Controls.Add(this.formularioPictureBox);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "acercaDeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca de...";
            this.Load += new System.EventHandler(this.acercaDeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formularioPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox formularioPictureBox;
        private System.Windows.Forms.ImageList formularioImageList;
        private System.Windows.Forms.RichTextBox aplicacionRichTextBox;
        private System.Windows.Forms.Button aplicacionButton;
    }
}