using Newtonsoft.Json;

namespace JsonNormalizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void normilizeBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (inputJson.Text == string.Empty)
                    throw new inputJsonEmptyException("��� ������� ������.");
                dynamic? strInJson = JsonConvert.DeserializeObject(inputJson.Text);

                //string jsonStr = System.Text.Json.JsonSerializer.Serialize(strInJson, options);
                outputJson.Text = strInJson?.ToString();
            }
            catch (inputJsonEmptyException ex)
            {
                MessageBox.Show(ex.Message, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (JsonReaderException)
            {
                MessageBox.Show("�������� ������ JSON", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (JsonSerializationException)
            {
                MessageBox.Show("���������� ��������������� ������� ������.\n���������� ������ � JSON", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void fileSelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                string filename = openFileDialog1.FileName;
                string fileText = File.ReadAllText(filename);
                inputJson.Text = fileText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                string filename = saveFileDialog1.FileName;
                File.WriteAllText(filename, outputJson.Text);
                MessageBox.Show("���� ��������", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            inputJson.Text = string.Empty;
            outputJson.Text = string.Empty;
        }
    }

    public class inputJsonEmptyException : Exception
    {
        public inputJsonEmptyException(string message) : base(message) { }
    }
}
