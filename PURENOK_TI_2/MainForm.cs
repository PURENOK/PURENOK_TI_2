using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PURENOK_TI_2;

public partial class MainForm : Form
{
    readonly Cipher streamCipher = new();
    public MainForm()
    {
        InitializeComponent();
    }

    void RegisterTextBox_TextChanged(object sender, EventArgs e)
    {
        label2.Text = $@"{RegisterTextBox.Text.Count(x => x is '0' or '1')}";
    }

    void ResultButton_Click(object sender, EventArgs e)
    {
        RegisterTextBox.Text = string.Join("", RegisterTextBox.Text.Where(x => x is '0' or '1'));
        if (RegisterTextBox.Text.Length != 36)
        {
            MessageBox.Show("Длина вашего регистра должна равняться 36 состояниям!");
            return;
        }

        if (PlainTextBox.Text.Length is 0)
        {
            MessageBox.Show("Выберите исходный файл для шифрования или дешифрования!");
            return;
        }
        
        streamCipher.InitializeLfsrRegister(RegisterTextBox.Text);
        streamCipher.GenerateKey(streamCipher.PlainText.Length);
        KeyTextBox.Text = BitArrayToStr(streamCipher.GeneratedKey);

        streamCipher.CipherFunc();
        CipherTextBox.Text = BitArrayToStr(streamCipher.CipherBit);
    }

    string BitArrayToStr(BitArray array)
    {
        StringBuilder temp = new();
        if (array.Length <= 128)
        {
            foreach (bool bit in array)
            {
                temp.Append(bit ? 1 : 0);
            }       
        }
        else
        {
            temp.Append("Первые 8 байт: \n");
            for (int i = 0; i < 64; i++)
                temp.Append(array[i] ? 1 : 0);
            temp.Append($"{Environment.NewLine}Последние 8 байт: \n");
            for (int i = 64; i > 0; i--)
            {
                temp.Append(array[array.Length - i] ? 1 : 0);
            }
        }

        return temp.ToString();
    }
    
   

   

  

    private void button2_Click(object sender, EventArgs e)
    {
        if (OpenFileDialog.ShowDialog() != DialogResult.Cancel)
        {
            StringBuilder stringBuilder = new StringBuilder();

            var bytes = File.ReadAllBytes(OpenFileDialog.FileName);
            for (int i = 0; i < bytes.Length; i++)
            {
                BitArray help = new BitArray(new[] { bytes[i] });
                foreach (bool bit in help)
                {
                    stringBuilder.Append(bit ? 1 : 0);
                }
            }



            streamCipher.PlainText = new BitArray(stringBuilder.Length);
            for (int i = 0; i < streamCipher.PlainText.Length; i++)
            {
                streamCipher.PlainText[i] = stringBuilder[i] == '1';
            }

            PlainTextBox.Text = BitArrayToStr(streamCipher.PlainText);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {

        if (SaveFileDialog.ShowDialog() != DialogResult.Cancel)
        {
            using FileStream fileStream = new FileStream(SaveFileDialog.FileName, FileMode.Create);
            byte[] result = new byte[streamCipher.CipherBit.Count / 8];
            streamCipher.CipherBit.CopyTo(result, 0);
            fileStream.Write(result, 0, result.Length);
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        KeyTextBox.Clear();
        CipherTextBox.Clear();
        PlainTextBox.Clear();
    }

    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }
}