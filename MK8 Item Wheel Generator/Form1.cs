using System;
using System.Windows.Forms;

namespace MK8_Item_Wheel_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ItemID = comboBox1.SelectedIndex.ToString("X");
            String button_type = "09020000 ";
            String controller = "";
            int button = 0;
            int wiimote = 0;
            int nunchuk = 0;
            bool only_these_buttons = checkBox36.Checked;
            bool Gamepad_A = checkBox1.Checked;
            bool Gamepad_B = checkBox2.Checked;
            bool Gamepad_X = checkBox3.Checked;
            bool Gamepad_Y = checkBox4.Checked;
            bool Gamepad_Minus = checkBox5.Checked;
            bool Gamepad_Plus = checkBox6.Checked;
            bool Gamepad_Home = checkBox7.Checked;
            bool Gamepad_TV = checkBox8.Checked;
            bool Gamepad_R = checkBox9.Checked;
            bool Gamepad_ZR = checkBox10.Checked;
            bool Gamepad_L = checkBox11.Checked;
            bool Gamepad_ZL = checkBox12.Checked;
            bool Gamepad_DUp = checkBox14.Checked;
            bool Gamepad_DDown = checkBox13.Checked;
            bool Gamepad_DLeft = checkBox15.Checked;
            bool Gamepad_DRight = checkBox16.Checked;
            bool Gamepad_RUp = checkBox23.Checked;
            bool Gamepad_RDown = checkBox24.Checked;
            bool Gamepad_RLeft = checkBox22.Checked;
            bool Gamepad_RRight = checkBox21.Checked;
            bool Gamepad_LUp = checkBox19.Checked;
            bool Gamepad_LDown = checkBox20.Checked;
            bool Gamepad_LLeft = checkBox18.Checked;
            bool Gamepad_LRight = checkBox17.Checked;
            bool Wiimote_A = checkBox25.Checked;
            bool Wiimote_B = checkBox26.Checked;
            bool Wiimote_1 = checkBox27.Checked;
            bool Wiimote_2 = checkBox28.Checked;
            bool Wiimote_Minus = checkBox29.Checked;
            bool Wiimote_Plus = checkBox30.Checked;
            bool Wiimote_Home = checkBox31.Checked;
            bool Wiimote_DUp = checkBox32.Checked;
            bool Wiimote_DDown = checkBox33.Checked;
            bool Wiimote_DLeft = checkBox34.Checked;
            bool Wiimote_DRight = checkBox35.Checked;
            bool Nun_A = checkBox37.Checked;
            bool Nun_B = checkBox38.Checked;
            bool Nun_1 = checkBox39.Checked;
            bool Nun_2 = checkBox40.Checked;
            bool Nun_Minus = checkBox41.Checked;
            bool Nun_Plus = checkBox42.Checked;
            bool Nun_Home = checkBox43.Checked;
            bool Nun_C = checkBox48.Checked;
            bool Nun_Z = checkBox49.Checked;
            bool Nun_DUp = checkBox44.Checked;
            bool Nun_DDown = checkBox45.Checked;
            bool Nun_DLeft = checkBox46.Checked;
            bool Nun_DRight = checkBox47.Checked;
            if (comboBox1.SelectedIndex == -1)
            {
                return;
            }
            if (!textBox1.Text.Contains("30000000 3FBBB448") || !textBox1.Text.Contains("0012005C 00000006"))
            {
                textBox1.Text = "10020008 110000A0" + System.Environment.NewLine +
                "30000000 3FBBB448" + System.Environment.NewLine +
                "42800000 49000000" + System.Environment.NewLine +
                "31000000 00000028" + System.Environment.NewLine +
                "11120008 0000001C" + System.Environment.NewLine +
                "00120020 00000001" + System.Environment.NewLine +
                "30100000 00000000" + System.Environment.NewLine +
                "42000000 4AC00000" + System.Environment.NewLine +
                "0012003C 04030200" + System.Environment.NewLine +
                "00120058 00000006" + System.Environment.NewLine +
                "0012005C 00000006" + System.Environment.NewLine +
                "D0000000 DEADCAFE" + System.Environment.NewLine;
            }
            if (only_these_buttons)
            {
                button_type = "03020000 ";
            }
            if (tabControl.SelectedIndex == 0)
            {
                controller = "1F604EA0";
                if (Gamepad_A)
                {
                    button += 0x8000;
                }
                if (Gamepad_B)
                {
                    button += 0x4000;
                }
                if (Gamepad_X)
                {
                    button += 0x2000;
                }
                if (Gamepad_Y)
                {
                    button += 0x1000;
                }
                if (Gamepad_Minus)
                {
                    button += 4;
                }
                if (Gamepad_Plus)
                {
                    button += 8;
                }
                if (Gamepad_Home)
                {
                    button += 2;
                }
                if (Gamepad_TV)
                {
                    button += 0x10000;
                }
                if (Gamepad_R)
                {
                    button += 0x10;
                }
                if (Gamepad_ZR)
                {
                    button += 0x40;
                }
                if (Gamepad_L)
                {
                    button += 0x20;
                }
                if (Gamepad_ZL)
                {
                    button += 0x80;
                }
                if (Gamepad_DUp)
                {
                    button += 0x200;
                }
                if (Gamepad_DDown)
                {
                    button += 0x100;
                }
                if (Gamepad_DLeft)
                {
                    button += 0x800;
                }
                if (Gamepad_DRight)
                {
                    button += 0x400;
                }
                if (Gamepad_DDown)
                {
                    button += 0x100;
                }
                if (Gamepad_RUp)
                {
                    button += 0x1000000;
                }
                if (Gamepad_RDown)
                {
                    button += 0x800000;
                }
                if (Gamepad_RRight)
                {
                    button += 0x2000000;
                }
                if (Gamepad_RLeft)
                {
                    button += 0x4000000;
                }
                if (Gamepad_LUp)
                {
                    button += 0x10000000;
                }
                if (Gamepad_LDown)
                {
                    button += 0x8000000;
                }
                if (Gamepad_LRight)
                {
                    button += 0x20000000;
                }
                if (Gamepad_LLeft)
                {
                    button += 0x40000000;
                }
                textBox1.Text += button_type + controller + System.Environment.NewLine +
                button.ToString("X").PadLeft(8, '0') + " 00000000" + System.Environment.NewLine +
               "00020000 110000A0" + System.Environment.NewLine +
               ItemID.PadLeft(8, '0') + " 00000000" + System.Environment.NewLine +
               "D0000000 DEADCAFE" + System.Environment.NewLine;
            }
            if (tabControl.SelectedIndex == 1)
            {
                controller = "1F5F7E1C";
                if (Wiimote_A)
                {
                    wiimote += 0x800;
                }
                if (Wiimote_B)
                {
                    wiimote += 0x400;
                }
                if (Wiimote_1)
                {
                    wiimote += 0x200;
                }
                if (Wiimote_2)
                {
                    wiimote += 0x100;
                }
                if (Wiimote_Minus)
                {
                    wiimote += 0x1000;
                }
                if (Wiimote_Plus)
                {
                    wiimote += 0x10;
                }
                if (Wiimote_Home)
                {
                    wiimote += 0x8000;
                }
                if (Wiimote_DUp)
                {
                    wiimote += 8;
                }
                if (Wiimote_DDown)
                {
                    wiimote += 4;
                }
                if (Wiimote_DLeft)
                {
                    wiimote += 1;
                }
                if (Wiimote_DRight)
                {
                    wiimote += 2;
                }
                textBox1.Text += button_type + controller + System.Environment.NewLine +
                wiimote.ToString("X").PadLeft(8, '0') + " 00000000" + System.Environment.NewLine +
               "00020000 110000A0" + System.Environment.NewLine +
               ItemID.PadLeft(8, '0') + " 00000000" + System.Environment.NewLine +
               "D0000000 DEADCAFE" + System.Environment.NewLine;
            }
            if (tabControl.SelectedIndex == 2)
            {
                controller = "1F5F7E98";
                if (Nun_A)
                {
                    nunchuk += 0x800;
                }
                if (Nun_B)
                {
                    nunchuk += 0x400;
                }
                if (Nun_1)
                {
                    nunchuk += 0x200;
                }
                if (Nun_2)
                {
                    nunchuk += 0x100;
                }
                if (Nun_Minus)
                {
                    nunchuk += 0x1000;
                }
                if (Nun_Plus)
                {
                    nunchuk += 0x10;
                }
                if (Nun_Home)
                {
                    nunchuk += 0x8000;
                }
                if (Nun_DUp)
                {
                    nunchuk += 8;
                }
                if (Nun_DDown)
                {
                    nunchuk += 4;
                }
                if (Nun_DLeft)
                {
                    nunchuk += 1;
                }
                if (Nun_DRight)
                {
                    nunchuk += 2;
                }
                if (Nun_C)
                {
                    nunchuk += 0x4000;
                }
                if (Nun_Z)
                {
                    nunchuk += 0x2000;
                }
                textBox1.Text += button_type + controller + System.Environment.NewLine +
                nunchuk.ToString("X").PadLeft(8, '0') + " 00000000" + System.Environment.NewLine +
               "00020000 110000A0" + System.Environment.NewLine +
               ItemID.PadLeft(8, '0') + " 00000000" + System.Environment.NewLine +
               "D0000000 DEADCAFE" + System.Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e) => textBox1.Text = "";

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
            MessageBox.Show("Copied to Clipboard!");
        }
    }
}
