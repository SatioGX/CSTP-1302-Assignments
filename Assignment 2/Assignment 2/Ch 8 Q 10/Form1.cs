using System.Text;

namespace Ch_8_Q_10
{
    public partial class Form1 : Form
    {

        private static readonly Dictionary<char, string> MorseCodeTable = new Dictionary<char, string>()
        {
            {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."},
            {'F', "..-."}, {'G', "--."}, {'H', "...."}, {'I', ".."}, {'J', ".---"},
            {'K', "-.-"}, {'L', ".-.."}, {'M', "--"}, {'N', "-."}, {'O', "---"},
            {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"},
            {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"}, {'Y', "-.--"},
            {'Z', "--.."},
            {'0', "-----"}, {'1', ".----"}, {'2', "..---"}, {'3', "...--"}, {'4', "....-"},
            {'5', "....."}, {'6', "-...."}, {'7', "--..."}, {'8', "---.."}, {'9', "----."},
            {'.', ".-.-.-"}, {',', "--..--"}, {'?', "..--.."}, {'!', "-.-.--"},
            {' ', " "}
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string input = txtLetter.Text;
            string morseCode = ConvertToMorseCode(input);
            listBoxMorseCode.Items.Add(morseCode);
        }

        private string ConvertToMorseCode(string input)
        {
            StringBuilder morseCode = new StringBuilder();

            foreach (char c in input.ToUpper())
            {
                if (MorseCodeTable.ContainsKey(c))
                {
                    morseCode.Append(MorseCodeTable[c]);
                    morseCode.Append(" ");
                }
            }

            return morseCode.ToString();
        }
    }
}