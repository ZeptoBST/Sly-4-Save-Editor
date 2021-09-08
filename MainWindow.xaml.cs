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
using System.IO;
using System.Media;

namespace Sly_4_Save_Editor_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string thePath;
        public MainWindow()
        {
            InitializeComponent();

            this.Closed += new EventHandler(MainWindow_Closed);

            //Plays the thief.net startup sound
            SoundPlayer audio = new SoundPlayer(Sly_4_Save_Editor_GUI.Properties.Resources.StartupSound);
            audio.Play();
        }

        void MainWindow_Closed(object sender, EventArgs e)
        {
            //Plays the thief.net exit sound
            SoundPlayer audio = new SoundPlayer(Sly_4_Save_Editor_GUI.Properties.Resources.ExitSound);
            audio.Play();
            System.Threading.Thread.Sleep(1000);
        }

        private void BassSelection() // This plays the sound effect when pressing a button
        {
            SoundPlayer audio = new SoundPlayer(Sly_4_Save_Editor_GUI.Properties.Resources.BassSelection);
            audio.Play();

            //Displays a positive confirmation
            statusBox.Foreground = Brushes.Green;
            statusBox.Text = "Ok";
        }

        private void ErrorSelection() // This plays the sound effect when an error occured
        {
            SoundPlayer audio = new SoundPlayer(Sly_4_Save_Editor_GUI.Properties.Resources.ErrorSelection);
            audio.Play();

            //Displays a negative confirmation
            statusBox.Foreground = Brushes.Red;
            statusBox.Text = "Error";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool fileExist = File.Exists(thePath + "\\SYS_DATA");
            {
                if (fileExist)
                {
                    //This will take a file, take the position desired (offset is in decimal) and write the value desired to it.
                    using (var stream = new FileStream(thePath + "\\SYS_DATA", FileMode.Open, FileAccess.ReadWrite))
                    {

                        //Turning Japanese/Pretty In Pinker/Bentley's Hack Skip
                        stream.Position = 48;
                        stream.WriteByte(0xFE);
                        stream.Position = 49;
                        stream.WriteByte(0x37);
                        stream.Position = 50;
                        stream.WriteByte(0x0B);
                        stream.Position = 51;
                        stream.WriteByte(0x12);

                        BassSelection();
                    }  

                }

                else
                {
                    ErrorSelection();
                }


            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bool fileExist = File.Exists(thePath + "\\SYS_DATA");
            {
                if (fileExist)
                {
                    //This will take a file, take the position desired (offset is in decimal) and write the value desired to it.
                    using (var stream = new FileStream(thePath + "\\SYS_DATA", FileMode.Open, FileAccess.ReadWrite))
                    {
                        //Clan of the Cave Raccoon/Getting Stronger/Egg Minigame Skip
                        stream.Position = 44;
                        stream.WriteByte(0x00);
                        stream.Position = 45;
                        stream.WriteByte(0x00);
                        stream.Position = 46;
                        stream.WriteByte(0x00);
                        stream.Position = 47;
                        stream.WriteByte(0x00);
                        stream.Position = 48;
                        stream.WriteByte(0x00);
                        stream.Position = 49;
                        stream.WriteByte(0x00);
                        stream.Position = 50;
                        stream.WriteByte(0x00);
                        stream.Position = 51;
                        stream.WriteByte(0x00);

                        stream.Position = 430;
                        stream.WriteByte(0x03);

                        stream.Position = 483;
                        stream.WriteByte(0x02);
                        stream.Position = 484;
                        stream.WriteByte(0x01);

                        BassSelection();
                    }

                }

                else
                {
                    ErrorSelection();
                }


            }
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            thePath = teText.Text;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            bool fileExist = File.Exists(thePath + "\\SYS_DATA");
            {
                if (fileExist)
                {
                    //This will take a file, take the position desired (offset is in decimal) and write the value desired to it.
                    using (var stream = new FileStream(thePath + "\\SYS_DATA", FileMode.Open, FileAccess.ReadWrite))
                    {
                        //Clan of the Cave Raccoon/Operation: Jurassic Thievery/Bentley's Hack Skip
                        stream.Position = 48;
                        stream.WriteByte(0x07);
                        stream.Position = 49;
                        stream.WriteByte(0x9A);
                        stream.Position = 50;
                        stream.WriteByte(0xAD);
                        stream.Position = 51;
                        stream.WriteByte(0xF2);

                        BassSelection();
                    }

                }

                else
                {
                    ErrorSelection();
                }


            }
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            bool fileExist = File.Exists(thePath + "\\SYS_DATA");
            {
                if (fileExist)
                {
                    //This will take a file, take the position desired (offset is in decimal) and write the value desired to it.
                    using (var stream = new FileStream(thePath + "\\SYS_DATA", FileMode.Open, FileAccess.ReadWrite))
                    {
                        //Of Mice and Mechs/Short Supply/Bentley's Hack Skip
                        stream.Position = 48;
                        stream.WriteByte(0x58);
                        stream.Position = 49;
                        stream.WriteByte(0xB3);
                        stream.Position = 50;
                        stream.WriteByte(0x8C);
                        stream.Position = 51;
                        stream.WriteByte(0x8C);

                        BassSelection();
                    }

                }

                else
                {
                    ErrorSelection();
                }


            }
            
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            bool fileExist = File.Exists(thePath + "\\SYS_DATA");
            {
                if (fileExist)
                {
                    //This will take a file, take the position desired (offset is in decimal) and write the value desired to it.
                    using (var stream = new FileStream(thePath + "\\SYS_DATA", FileMode.Open, FileAccess.ReadWrite))
                    {
                        //Forthy Thieves/Rug Rats/Bentley's Hack Skip
                        stream.Position = 48;
                        stream.WriteByte(0x3F);
                        stream.Position = 49;
                        stream.WriteByte(0x07);
                        stream.Position = 50;
                        stream.WriteByte(0xB0);
                        stream.Position = 51;
                        stream.WriteByte(0x10);

                        BassSelection();
                    }

                }

                else
                {
                    ErrorSelection();
                }


            }
            
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            bool fileExist = File.Exists(thePath + "\\SYS_DATA");
            {
                if (fileExist)
                {
                    //This will take a file, take the position desired (offset is in decimal) and write the value desired to it.
                    using (var stream = new FileStream(thePath + "\\SYS_DATA", FileMode.Open, FileAccess.ReadWrite))
                    {
                        //Forthy Thieves/All Rolled Up!/Bentley's Hack Skip
                        stream.Position = 48;
                        stream.WriteByte(0x9C);
                        stream.Position = 49;
                        stream.WriteByte(0x29);
                        stream.Position = 50;
                        stream.WriteByte(0x40);
                        stream.Position = 51;
                        stream.WriteByte(0x62);

                        BassSelection();
                    }

                }

                else
                {
                    ErrorSelection();
                }


            }
            
        }
    }
}
