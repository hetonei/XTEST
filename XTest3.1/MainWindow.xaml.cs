using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using Microsoft.Office.Interop.Word;

namespace XTest3_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static int CurTest;
        public static string CurTestName;
        private void Rc_Bar_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        

        private void Bt_Close_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Bt_Min_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Bt_Menu_1_Click(object sender, RoutedEventArgs e)
        {
            Gb_Sub1.Visibility = Gb_Sub1.Visibility.Equals(Visibility.Collapsed) ? Visibility.Visible : Visibility.Collapsed;
            Gb_Sub2.Visibility = Visibility.Collapsed;
            Gb_Sub3.Visibility = Visibility.Collapsed;
            Gb_Sub4.Visibility = Visibility.Collapsed;
            Gb_Sub5.Visibility = Visibility.Collapsed;
        }

        private void Bt_Menu_2_Click(object sender, RoutedEventArgs e)
        {
            Gb_Sub2.Visibility = Gb_Sub2.Visibility.Equals(Visibility.Collapsed) ? Visibility.Visible : Visibility.Collapsed;
            Gb_Sub1.Visibility = Visibility.Collapsed;
            Gb_Sub3.Visibility = Visibility.Collapsed;
            Gb_Sub4.Visibility = Visibility.Collapsed;
            Gb_Sub5.Visibility = Visibility.Collapsed;
        }

        private void Bt_Menu_3_Click(object sender, RoutedEventArgs e)
        {
            Gb_Sub3.Visibility = Gb_Sub3.Visibility.Equals(Visibility.Collapsed) ? Visibility.Visible : Visibility.Collapsed;
            Gb_Sub2.Visibility = Visibility.Collapsed;
            Gb_Sub1.Visibility = Visibility.Collapsed;
            Gb_Sub4.Visibility = Visibility.Collapsed;
            Gb_Sub5.Visibility = Visibility.Collapsed;
        }

        private void Bt_Menu_4_Click(object sender, RoutedEventArgs e)
        {
            Gb_Sub4.Visibility = Gb_Sub4.Visibility.Equals(Visibility.Collapsed) ? Visibility.Visible : Visibility.Collapsed;
            Gb_Sub2.Visibility = Visibility.Collapsed;
            Gb_Sub3.Visibility = Visibility.Collapsed;
            Gb_Sub1.Visibility = Visibility.Collapsed;
            Gb_Sub5.Visibility = Visibility.Collapsed;
        }

        private void Bt_Menu_5_OnClick(object sender, RoutedEventArgs e)
        {
            Gb_Sub5.Visibility = Gb_Sub5.Visibility.Equals(Visibility.Collapsed) ? Visibility.Visible : Visibility.Collapsed;
            Gb_Sub2.Visibility = Visibility.Collapsed;
            Gb_Sub3.Visibility = Visibility.Collapsed;
            Gb_Sub1.Visibility = Visibility.Collapsed;
            Gb_Sub4.Visibility = Visibility.Collapsed;
        }

        private void OpenTheory()
        {
            try
            {
                string path = "Theory/";
                switch (CurTest)
                {
                    case 21:
                        path += "Abramson.xaml";
                        break;
                    case 22:
                        path += "Faira.xaml";
                        break;
                    case 32:
                        path += "QMOD.xaml";
                        break;
                    case 33:
                        path += "EzRepeat.xaml";
                        break;
                    case 41:
                        path += "GreyT.xaml";
                        break;
                    case 42:
                        path += "DTCT.xaml";
                        break;
                    case 43:
                        path += "BergT.xaml";
                        break;
                    case 48:
                        path += "Recurrence.xaml";
                        break;

                }
                using (FileStream xamlFile = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    FlowDocument content = XamlReader.Load(xamlFile) as FlowDocument;

                    Tb_Info.Document = content;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Bt_S21_OnClick(object sender, RoutedEventArgs e)
        {
            CurTest = 21;
            CurTestName = Bt_S21.Content.ToString();
            OpenTheory();
        }

        private void Bt_S22_OnClick(object sender, RoutedEventArgs e)
        {
            CurTest = 22;
            CurTestName = Bt_S22.Content.ToString();
            OpenTheory();
        }
        private void Bt_S32_OnClick(object sender, RoutedEventArgs e)
        {
            CurTest = 32;
            CurTestName = Bt_S32.Content.ToString();
            OpenTheory();
        }

        private void Bt_S33_OnClick(object sender, RoutedEventArgs e)
        {
            CurTest = 33;
            CurTestName = Bt_S33.Content.ToString();
            OpenTheory();
        }

        private void Bt_S41_OnClick(object sender, RoutedEventArgs e)
        {
            CurTest = 41;
            CurTestName = Bt_S41.Content.ToString();
            OpenTheory();
        }

        private void Bt_S42_OnClick(object sender, RoutedEventArgs e)
        {
            CurTest = 42;
            CurTestName = Bt_S42.Content.ToString();
            OpenTheory();
        }

        private void Bt_S43_OnClick(object sender, RoutedEventArgs e)
        {
            CurTest = 43;
            CurTestName = Bt_S43.Content.ToString();
            OpenTheory();
        }

        private void Bt_S48_OnClick(object sender, RoutedEventArgs e)
        {
            CurTest = 48;
            CurTestName = Bt_S48.Content.ToString();
            OpenTheory();
        }

        private void Bt_S51_OnClick(object sender, RoutedEventArgs e)
        {
            CurTest = 51;
            CurTestName = Bt_S51.Content.ToString();
            OpenTheory();
        }

        private void Bt_Code_OnClick(object sender, RoutedEventArgs e)
        {
            //CheckCode.Check(_curTest);
        }

        private void Bt_Test_Click(object sender, RoutedEventArgs e)
        {
            W_Test wt = new W_Test {Owner = this};
            wt.ShowDialog();
        }
        private struct keyWordEntry
        {
            public string keyword;
            public int position;
            public string spacesAfter;

            public keyWordEntry(string kword, int pos, string spaces)
            {
                keyword = kword;
                position = pos;
                spacesAfter = spaces;
            }
        }
        private void Bt_Set_Click(object sender, RoutedEventArgs e)
        {
            object oMissing = System.Reflection.Missing.Value;
            object pageBreak = WdBreakType.wdPageBreak;
            object noSave = WdSaveOptions.wdDoNotSaveChanges;
            object template = AppDomain.CurrentDomain.BaseDirectory + @"\template1.docx";
            object destination = @"C:\destination.docx";


            _Application word = new Microsoft.Office.Interop.Word.Application();
            _Document sdoc = word.Documents.Add(AppDomain.CurrentDomain.BaseDirectory + @"\template1.docx", ref oMissing, ref oMissing, ref oMissing);
            string[] keyWords = { "NUM", "THEME", "GNAME", "TNAME", "FNAMEONE", "FNAMETWO", "TEXT", "RESULTS" };

            List<keyWordEntry> keyWordEntries = new List<keyWordEntry>();
            for (int i = 0; i < sdoc.Words.Count; i++)
            {
                foreach (string keyWord in keyWords)
                {
                    if (sdoc.Words[i + 1].Text.Trim() == keyWord)
                    {
                        keyWordEntries.Add(new keyWordEntry(keyWord, i + 1,
                            sdoc.Words[i + 1].Text.Remove(0, keyWord.Length)));
                    }
                    
                }
                
            }
            


            _Document ddoc = word.Documents.Add(ref template, ref oMissing, ref oMissing, ref oMissing);

            ddoc.Range(ref oMissing, ref oMissing).Delete(ref oMissing, ref oMissing);
            ddoc.Range(ref oMissing, ref oMissing).InsertParagraphAfter();
            keyWordEntries.Reverse();
            foreach (keyWordEntry ke in keyWordEntries)
            {
                string replaceWith = "";
                switch (ke.keyword)
                {
                    case "NUM":
                        replaceWith = CurTest + ke.spacesAfter;
                        break;
                    case "THEME":
                        replaceWith = CurTestName + ke.spacesAfter;
                        break;
                    case "GNAME":
                        replaceWith = "ИА-41" + ke.spacesAfter;
                        break;
                    case "TNAME":
                        replaceWith = "ИМЯ ФАМИЛИЯ" + ke.spacesAfter;
                        break;
                    case "TEXT":
                        replaceWith = "ТЕКСТ ТЕКСТ" + ke.spacesAfter;
                        break;
                    case "FNAMETWO":
                        replaceWith = "СЫЧЕНКО ИВАН" + ke.spacesAfter;
                        break;
                    case "FNAMEONE":
                        replaceWith = "КИРИЛЛ МОРОЗ" + ke.spacesAfter;
                        break;
                    case "RESULTS":
                        replaceWith = "РЕЗУЛЬТАТ РЕЗУЛЬТАТ" + ke.spacesAfter;
                        break;
                    default:
                        replaceWith = ke.keyword + ke.spacesAfter;
                        break;
                }
                ;
                sdoc.Words[ke.position].Text = replaceWith;


            }
            ;
            sdoc.Range(ref oMissing, ref oMissing).Copy();
            ddoc.Paragraphs[1].Range.Paste();



            sdoc.Close(ref noSave, ref oMissing, ref oMissing);

            ddoc.SaveAs(ref destination, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing);
            //ddoc.Save();
            ddoc.Close(ref oMissing, ref oMissing, ref oMissing);

            word.Quit(ref oMissing, ref oMissing, ref oMissing);
        }


        
    }
}
