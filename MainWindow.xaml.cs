using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Intel8086
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] Operacje { get; set; }
        public string[] Rejestr_1 { get; set; }
        public string[] Rejestr_2 { get; set; }
        public string[] Procesor { get; set; }
        public MainWindow()
        {

            InitializeComponent();
            Operacje = new string[] { "MOV", "XCHG", "AND", "OR","XOR","ADD","SUBB", "INC", "DEC", "NOT", "NEG" };
            Rejestr_1 = new string[] { "AH", "BH", "CH", "DH","AL", "BL", "CL", "DL"};
            Rejestr_2 = new string[] { "AH", "BH", "CH", "DH", "AL", "BL", "CL", "DL"};
            Procesor = new string[] { AH.Text.ToUpper(), BH.Text.ToUpper(), CH.Text.ToUpper(), DH.Text.ToUpper(), AL.Text.ToUpper(), BL.Text.ToUpper(), CL.Text.ToUpper(), DL.Text.ToUpper() };

            DataContext = this;

            AH.MaxLength = 2;
            BH.MaxLength = 2;
            CH.MaxLength = 2;
            DH.MaxLength = 2;
            AL.MaxLength = 2;
            BL.MaxLength = 2;
            DL.MaxLength = 2;
            CL.MaxLength = 2;

        }

        private void AH_TextChanged(object sender, TextChangedEventArgs e)
        {
            var AHinput = AH.Text.ToCharArray();

            if (AHinput.Length == 1)
            {
                char a = AHinput[0];

                if (a >= '0' && a <= '9' || a >= 'A' && a <= 'F' || a >= 'a' && a <= 'f')
                {

                }
                else
                {
                    MessageBox.Show("Błędne dane w rejestrze AH");
                    return;
                }
            }

            if (AHinput.Length == 2)
            {
                char a = AHinput[0];
                char b = AHinput[1];

                if ((a >= '0' && a <= '9' || a >= 'A' && a <= 'F' || a >= 'a' && a <= 'f')
                && (b >= '0' && b <= '9' || b >= 'A' && b <= 'F' || b >= 'a' && b <= 'f'))
                {

                }
                else
                {
                    MessageBox.Show("Błędne dane w rejestrze AH");
                    return;
                }
            }

        }
        private void BH_TextChanged(object sender, TextChangedEventArgs e)
        {
            var AHinput = BH.Text.ToCharArray();

            if (AHinput.Length == 1)
            {
                char a = AHinput[0];

                if (a >= '0' && a <= '9' || a >= 'A' && a <= 'F' || a >= 'a' && a <= 'f')
                {

                }
                else
                {
                    MessageBox.Show("Błędne dane w rejestrze BH");
                }
            }

            if (AHinput.Length == 2)
            {
                char a = AHinput[0];
                char b = AHinput[1];

                if ((a >= '0' && a <= '9' || a >= 'A' && a <= 'F' || a >= 'a' && a <= 'f')
                && (b >= '0' && b <= '9' || b >= 'A' && b <= 'F' || b >= 'a' && b <= 'f'))
                {

                }
                else
                {
                    MessageBox.Show("Błędne dane w rejestrze BH");
                }
            }

        }
        private void CH_TextChanged(object sender, TextChangedEventArgs e)
        {
            var AHinput = CH.Text.ToCharArray();

            if (AHinput.Length == 1)
            {
                char a = AHinput[0];

                if (a >= '0' && a <= '9' || a >= 'A' && a <= 'F' || a >= 'a' && a <= 'f')
                {

                }
                else
                {
                    MessageBox.Show("Błędne dane w rejestrze CH");
                }
            }

            if (AHinput.Length == 2)
            {
                char a = AHinput[0];
                char b = AHinput[1];

                if ((a >= '0' && a <= '9' || a >= 'A' && a <= 'F' || a >= 'a' && a <= 'f')
                && (b >= '0' && b <= '9' || b >= 'A' && b <= 'F' || b >= 'a' && b <= 'f'))
                {

                }
                else
                {
                    MessageBox.Show("Błędne dane w rejestrze CH");
                }
            }

        }
        private void DH_TextChanged(object sender, TextChangedEventArgs e)
        {
            var AHinput = DH.Text.ToCharArray();

            if (AHinput.Length == 1)
            {
                char a = AHinput[0];

                if (a >= '0' && a <= '9' || a >= 'A' && a <= 'F' || a >= 'a' && a <= 'f')
                {

                }
                else
                {
                    MessageBox.Show("Błędne dane w rejestrze DH");
                }
            }

            if (AHinput.Length == 2)
            {
                char a = AHinput[0];
                char b = AHinput[1];

                if ((a >= '0' && a <= '9' || a >= 'A' && a <= 'F' || a >= 'a' && a <= 'f')
                && (b >= '0' && b <= '9' || b >= 'A' && b <= 'F' || b >= 'a' && b <= 'f'))
                {

                }
                else
                {
                    MessageBox.Show("Błędne dane w rejestrze DH");
                }
            }

        }
        private void AL_TextChanged(object sender, TextChangedEventArgs e)
        {
            var AHinput = AL.Text.ToCharArray();

            if (AHinput.Length == 1)
            {
                char a = AHinput[0];

                if (a >= '0' && a <= '9' || a >= 'A' && a <= 'F' || a >= 'a' && a <= 'f')
                {

                }
                else
                {
                    MessageBox.Show("Błędne dane w rejestrze AL");
                }
            }

            if (AHinput.Length == 2)
            {
                char a = AHinput[0];
                char b = AHinput[1];

                if ((a >= '0' && a <= '9' || a >= 'A' && a <= 'F' || a >= 'a' && a <= 'f')
                && (b >= '0' && b <= '9' || b >= 'A' && b <= 'F' || b >= 'a' && b <= 'f'))
                {

                }
                else
                {
                    MessageBox.Show("Błędne dane w rejestrze AL");
                }
            }

        }
        private void BL_TextChanged(object sender, TextChangedEventArgs e)
        {
            var AHinput = BL.Text.ToCharArray();

            if (AHinput.Length == 1)
            {
                char a = AHinput[0];

                if (a >= '0' && a <= '9' || a >= 'A' && a <= 'F' || a >= 'a' && a <= 'f')
                {

                }
                else
                {
                    MessageBox.Show("Błędne dane w rejestrze BL");
                }
            }

            if (AHinput.Length == 2)
            {
                char a = AHinput[0];
                char b = AHinput[1];

                if ((a >= '0' && a <= '9' || a >= 'A' && a <= 'F' || a >= 'a' && a <= 'f')
                && (b >= '0' && b <= '9' || b >= 'A' && b <= 'F' || b >= 'a' && b <= 'f'))
                {

                }
                else
                {
                    MessageBox.Show("Błędne dane w rejestrze BL");
                }
            }

        }
        private void CL_TextChanged(object sender, TextChangedEventArgs e)
        {
            var AHinput = CL.Text.ToCharArray();

            if (AHinput.Length == 1)
            {
                char a = AHinput[0];

                if (a >= '0' && a <= '9' || a >= 'A' && a <= 'F' || a >= 'a' && a <= 'f')
                {

                }
                else
                {
                    MessageBox.Show("Błędne dane w rejestrze CL");
                }
            }

            if (AHinput.Length == 2)
            {
                char a = AHinput[0];
                char b = AHinput[1];

                if ((a >= '0' && a <= '9' || a >= 'A' && a <= 'F' || a >= 'a' && a <= 'f')
                && (b >= '0' && b <= '9' || b >= 'A' && b <= 'F' || b >= 'a' && b <= 'f'))
                {

                }
                else
                {
                    MessageBox.Show("Błędne dane w rejestrze CL");
                }
            }

        }
        private void DL_TextChanged(object sender, TextChangedEventArgs e)
        {
            var AHinput = DL.Text.ToCharArray();

            if (AHinput.Length == 1)
            {
                char a = AHinput[0];

                if (a >= '0' && a <= '9' || a >= 'A' && a <= 'F' || a >= 'a' && a <= 'f')
                {

                }
                else
                {
                    MessageBox.Show("Błędne dane w rejestrze DL");
                }
            }

            if (AHinput.Length == 2)
            {
                char a = AHinput[0];
                char b = AHinput[1];

                if ((a >= '0' && a <= '9' || a >= 'A' && a <= 'F' || a >= 'a' && a <= 'f')
                && (b >= '0' && b <= '9' || b >= 'A' && b <= 'F' || b >= 'a' && b <= 'f'))
                {

                }
                else
                {
                    MessageBox.Show("Błędne dane w rejestrze DL");
                }
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (AH.Text.Length == 0 || BH.Text.Length == 0 || CH.Text.Length == 0 || DH.Text.Length == 0 || AL.Text.Length == 0 || BL.Text.Length == 0 || CL.Text.Length == 0 || DL.Text.Length == 0)
            {
                MessageBox.Show("Proszę zapełnić wszystkie rejestry");
                return;
            }
            
            if (Operacja.Text == "MOV")
            {
                int procFirst;
                int procSecond;

                switch (Rejestr1.Text)
                {
                    case "AH":
                        procFirst = 0;
                        break;
                    case "BH":
                        procFirst = 1;
                        break;
                    case "CH":
                        procFirst = 2;
                        break;
                    case "DH":
                        procFirst = 3;
                        break;
                    case "AL":
                        procFirst = 4;
                        break;
                    case "BL":
                        procFirst = 5;
                        break;
                    case "CL":
                        procFirst = 6;
                        break;
                    case "DL":
                        procFirst = 7;
                        break;
                    default:
                        procFirst = 0;
                        break;
                }

                switch (Rejestr2.Text)
                {
                    case "AH":
                        procSecond = 0;
                        break;
                    case "BH":
                        procSecond = 1;
                        break;
                    case "CH":
                        procSecond = 2;
                        break;
                    case "DH":
                        procSecond = 3;
                        break;
                    case "AL":
                        procSecond = 4;
                        break;
                    case "BL":
                        procSecond = 5;
                        break;
                    case "CL":
                        procSecond = 6;
                        break;
                    case "DL":
                        procSecond = 7;
                        break;
                    default: procSecond = 0;
                        break;
                }

                Procesor[procSecond] = Procesor[procFirst];

            }

            if (Operacja.Text == "XCHG")
            {
                int procFirst;
                int procSecond;

                switch (Rejestr1.Text)
                {
                    case "AH":
                        procFirst = 0;
                        break;
                    case "BH":
                        procFirst = 1;
                        break;
                    case "CH":
                        procFirst = 2;
                        break;
                    case "DH":
                        procFirst = 3;
                        break;
                    case "AL":
                        procFirst = 4;
                        break;
                    case "BL":
                        procFirst = 5;
                        break;
                    case "CL":
                        procFirst = 6;
                        break;
                    case "DL":
                        procFirst = 7;
                        break;
                    default:
                        procFirst = 0;
                        break;
                }

                switch (Rejestr2.Text)
                {
                    case "AH":
                        procSecond = 0;
                        break;
                    case "BH":
                        procSecond = 1;
                        break;
                    case "CH":
                        procSecond = 2;
                        break;
                    case "DH":
                        procSecond = 3;
                        break;
                    case "AL":
                        procSecond = 4;
                        break;
                    case "BL":
                        procSecond = 5;
                        break;
                    case "CL":
                        procSecond = 6;
                        break;
                    case "DL":
                        procSecond = 7;
                        break;
                    default:
                        procSecond = 0;
                        break;
                }

                string i = Procesor[procFirst];
                Procesor[procFirst] = Procesor[procSecond];
                Procesor[procSecond] = i;

            }

            if (Operacja.Text == "INC")
            {
                int procFirst;

                switch (Rejestr1.Text)
                {

                    case "AH":
                        procFirst = 0;
                        break;
                    case "BH":
                        procFirst = 1;
                        break;
                    case "CH":
                        procFirst = 2;
                        break;
                    case "DH":
                        procFirst = 3;
                        break;
                    case "AL":
                        procFirst = 4;
                        break;
                    case "BL":
                        procFirst = 5;
                        break;
                    case "CL":
                        procFirst = 6;
                        break;
                    case "DL":
                        procFirst = 7;
                        break;
                    default:
                        procFirst = 0;
                        break;

                }

                string stringHex = Procesor[procFirst];

                int intFromHex = int.Parse(stringHex, System.Globalization.NumberStyles.HexNumber) + 1;
                if (intFromHex > 100)
                {
                    intFromHex = 0;
                }
                Procesor[procFirst] = intFromHex.ToString("X");

            }

            if (Operacja.Text == "DEC")
            {
                int procFirst;

                switch (Rejestr1.Text)
                {

                    case "AH":
                        procFirst = 0;
                        break;
                    case "BH":
                        procFirst = 1;
                        break;
                    case "CH":
                        procFirst = 2;
                        break;
                    case "DH":
                        procFirst = 3;
                        break;
                    case "AL":
                        procFirst = 4;
                        break;
                    case "BL":
                        procFirst = 5;
                        break;
                    case "CL":
                        procFirst = 6;
                        break;
                    case "DL":
                        procFirst = 7;
                        break;
                    default:
                        procFirst = 0;
                        break;

                }


                string stringHex = Procesor[procFirst];

                int intFromHex = int.Parse(stringHex, System.Globalization.NumberStyles.HexNumber) - 1;

                if (intFromHex < 00)
                {
                    intFromHex = 255;
                }

                Procesor[procFirst] = intFromHex.ToString("X");

            }


            if (Operacja.Text == "NOT")
            {
                int procFirst;

                switch (Rejestr1.Text)
                {

                    case "AH":
                        procFirst = 0;
                        break;
                    case "BH":
                        procFirst = 1;
                        break;
                    case "CH":
                        procFirst = 2;
                        break;
                    case "DH":
                        procFirst = 3;
                        break;
                    case "AL":
                        procFirst = 4;
                        break;
                    case "BL":
                        procFirst = 5;
                        break;
                    case "CL":
                        procFirst = 6;
                        break;
                    case "DL":
                        procFirst = 7;
                        break;
                    default:
                        procFirst = 0;
                        break;

                }

                
                byte binaryval = Convert.ToByte(Procesor[procFirst], 16);

                byte[] negatedBin = {(byte)~(binaryval)};
            

                string hex = BitConverter.ToString(negatedBin);

                int intFromHex = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);

                if (intFromHex == 100)
                {
                    intFromHex = 00;
                }

                Procesor[procFirst] = intFromHex.ToString("X");
           
            }


            if (Operacja.Text == "NEG")
            {
                int procFirst;

                switch (Rejestr1.Text)
                {

                    case "AH":
                        procFirst = 0;
                        break;
                    case "BH":
                        procFirst = 1;
                        break;
                    case "CH":
                        procFirst = 2;
                        break;
                    case "DH":
                        procFirst = 3;
                        break;
                    case "AL":
                        procFirst = 4;
                        break;
                    case "BL":
                        procFirst = 5;
                        break;
                    case "CL":
                        procFirst = 6;
                        break;
                    case "DL":
                        procFirst = 7;
                        break;
                    default:
                        procFirst = 0;
                        break;

                }


                byte binaryval = Convert.ToByte(Procesor[procFirst], 16);

                byte[] negatedBin = { (byte)~(binaryval) };


                string hex = BitConverter.ToString(negatedBin);

                int intFromHex = int.Parse(hex, System.Globalization.NumberStyles.HexNumber) + 1;

                if (intFromHex > 255)
                {
                    intFromHex = 00;
                }

                Procesor[procFirst] = intFromHex.ToString("X");

            }

            Output1.Text = Procesor[0];
            Output2.Text = Procesor[1];
            Output3.Text = Procesor[2];
            Output4.Text = Procesor[3];
            Output5.Text = Procesor[4];
            Output6.Text = Procesor[5];
            Output7.Text = Procesor[6];
            Output8.Text = Procesor[7];
        
        }


        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Procesor = new string[] { AH.Text.ToUpper(), BH.Text.ToUpper(), CH.Text.ToUpper(), DH.Text.ToUpper(), AL.Text.ToUpper(), BL.Text.ToUpper(), CL.Text.ToUpper(), DL.Text.ToUpper() };
            Output1.Text = Procesor[0];
            Output2.Text = Procesor[1];
            Output3.Text = Procesor[2];
            Output4.Text = Procesor[3];
            Output5.Text = Procesor[4];
            Output6.Text = Procesor[5];
            Output7.Text = Procesor[6];
            Output8.Text = Procesor[7];
        }

        private void Operacja_DropDownClosed(object sender, EventArgs e)
        {
            if (Operacja.Text == "INC" || Operacja.Text == "DEC" || Operacja.Text == "NOT" || Operacja.Text == "NEG")
            {
                Rejestr2.Visibility = Visibility.Collapsed;
                Rejestr2_.Visibility = Visibility.Collapsed;
            }
            else
            {
                Rejestr2.Visibility = Visibility.Visible;
                Rejestr2_.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Random random = new Random();

            int num = random.Next(255);
            int num1 = random.Next(255);
            int num2 = random.Next(255);
            int num3 = random.Next(255);
            int num4 = random.Next(255);
            int num5 = random.Next(255);
            int num6 = random.Next(255);
            int num7 = random.Next(255);

            string hexString = num.ToString("X");
            string hexString1 = num1.ToString("X");
            string hexString2 = num2.ToString("X");
            string hexString3 = num3.ToString("X");
            string hexString4 = num4.ToString("X");
            string hexString5 = num5.ToString("X");
            string hexString6 = num6.ToString("X");
            string hexString7 = num7.ToString("X");

            AH.Text = hexString;
            BH.Text = hexString1;
            CH.Text = hexString2;
            DH.Text = hexString3;
            AL.Text = hexString4;
            BL.Text = hexString5;
            CL.Text = hexString6;
            DL.Text = hexString7;
        }
    }
}
