namespace PURENOK_TI_2;

partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PlainTextBox = new System.Windows.Forms.TextBox();
            this.PlainLabel = new System.Windows.Forms.Label();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.CipherTextBox = new System.Windows.Forms.TextBox();
            this.LabelCipherText = new System.Windows.Forms.Label();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ResultButton = new System.Windows.Forms.Button();
            this.RegisterTextBox = new System.Windows.Forms.TextBox();
            this.LabelRegister = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlainTextBox
            // 
            this.PlainTextBox.Location = new System.Drawing.Point(49, 362);
            this.PlainTextBox.Multiline = true;
            this.PlainTextBox.Name = "PlainTextBox";
            this.PlainTextBox.ReadOnly = true;
            this.PlainTextBox.Size = new System.Drawing.Size(360, 95);
            this.PlainTextBox.TabIndex = 6;
            // 
            // PlainLabel
            // 
            this.PlainLabel.Location = new System.Drawing.Point(131, 330);
            this.PlainLabel.Name = "PlainLabel";
            this.PlainLabel.Size = new System.Drawing.Size(206, 29);
            this.PlainLabel.TabIndex = 7;
            this.PlainLabel.Text = "Исходный текст:";
            this.PlainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(49, 222);
            this.KeyTextBox.Multiline = true;
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.ReadOnly = true;
            this.KeyTextBox.Size = new System.Drawing.Size(360, 105);
            this.KeyTextBox.TabIndex = 8;
            // 
            // KeyLabel
            // 
            this.KeyLabel.Location = new System.Drawing.Point(131, 190);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(206, 29);
            this.KeyLabel.TabIndex = 9;
            this.KeyLabel.Text = "Сгенерированный ключ:";
            this.KeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CipherTextBox
            // 
            this.CipherTextBox.Location = new System.Drawing.Point(49, 505);
            this.CipherTextBox.Multiline = true;
            this.CipherTextBox.Name = "CipherTextBox";
            this.CipherTextBox.ReadOnly = true;
            this.CipherTextBox.Size = new System.Drawing.Size(360, 123);
            this.CipherTextBox.TabIndex = 10;
            // 
            // LabelCipherText
            // 
            this.LabelCipherText.Location = new System.Drawing.Point(131, 473);
            this.LabelCipherText.Name = "LabelCipherText";
            this.LabelCipherText.Size = new System.Drawing.Size(197, 29);
            this.LabelCipherText.TabIndex = 11;
            this.LabelCipherText.Text = "Зашифрованный текст:";
            this.LabelCipherText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // ResultButton
            // 
            this.ResultButton.BackColor = System.Drawing.Color.White;
            this.ResultButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResultButton.ForeColor = System.Drawing.Color.Black;
            this.ResultButton.Location = new System.Drawing.Point(49, 102);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(244, 38);
            this.ResultButton.TabIndex = 3;
            this.ResultButton.Text = "Шифровать или Дешифровать\r\n";
            this.ResultButton.UseVisualStyleBackColor = false;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // RegisterTextBox
            // 
            this.RegisterTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.RegisterTextBox.Location = new System.Drawing.Point(49, 54);
            this.RegisterTextBox.Multiline = true;
            this.RegisterTextBox.Name = "RegisterTextBox";
            this.RegisterTextBox.Size = new System.Drawing.Size(360, 42);
            this.RegisterTextBox.TabIndex = 4;
            this.RegisterTextBox.TextChanged += new System.EventHandler(this.RegisterTextBox_TextChanged);
            // 
            // LabelRegister
            // 
            this.LabelRegister.BackColor = System.Drawing.Color.White;
            this.LabelRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelRegister.Location = new System.Drawing.Point(82, 7);
            this.LabelRegister.Name = "LabelRegister";
            this.LabelRegister.Size = new System.Drawing.Size(308, 29);
            this.LabelRegister.TabIndex = 5;
            this.LabelRegister.Text = "Состояние регистра (36 состояний):";
            this.LabelRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(174, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Сохранить в файл";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(49, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 34);
            this.button2.TabIndex = 18;
            this.button2.Text = "Открыть файл";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(322, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 34);
            this.button3.TabIndex = 19;
            this.button3.Text = "Очистить ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Кол-во состояний:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 21;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(448, 683);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LabelCipherText);
            this.Controls.Add(this.CipherTextBox);
            this.Controls.Add(this.PlainLabel);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.PlainTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LabelRegister);
            this.Controls.Add(this.RegisterTextBox);
            this.Controls.Add(this.ResultButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ТИ Лаб2 Пуренок 351004";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    private System.Windows.Forms.OpenFileDialog OpenFileDialog;

    private System.Windows.Forms.Label LabelCipherText;

    private System.Windows.Forms.TextBox CipherTextBox;

    private System.Windows.Forms.Label KeyLabel;

    private System.Windows.Forms.TextBox KeyTextBox;

    private System.Windows.Forms.Label PlainLabel;

    private System.Windows.Forms.TextBox PlainTextBox;

    #endregion

    private System.Windows.Forms.Button ResultButton;
    private System.Windows.Forms.TextBox RegisterTextBox;
    private System.Windows.Forms.Label LabelRegister;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
}