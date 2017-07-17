using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using XTest3_Logic;
using XTest3_Logic.Testing;
using Microsoft.Office.Interop.Word;

namespace XTest3_1
{
    /// <summary>
    /// Interaction logic for W_Test.xaml
    /// </summary>
    public partial class W_Test
    {
        public W_Test()
        {
            this.InitializeComponent();
            Lb_Quest.Content = "Вопрос № 1 ";
            GetQuests();
            CodeNameLabel.Content = MainWindow.CurTestName;

        }

        private int quest_num = 0;
        private Question[] quests;

        private void GetQuests()
        {
            quests = CheckCode.Check(MainWindow.CurTest);
            RefreshTask();
        }


        private void NextTask()
        {
            if (quest_num != 9)
                quest_num++;
            else quest_num = 0;
            int num = quest_num + 1;
            Lb_Quest.Content = "Вопрос № " + num;
        }

        private string YNanswer;
        private void Rb_Y_OnChecked(object sender, RoutedEventArgs e)
        {
            YNanswer = "y";
        }

        private void Rb_N_OnChecked(object sender, RoutedEventArgs e)
        {
            YNanswer = "n";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            quests[quest_num].Answer = InputAnswer.Text;
            if (MainWindow.CurTest == 32 && quest_num > 4) quests[quest_num].Answer = YNanswer;
            switch (quest_num)
            {
                case 0:
                    if (Answer.CheckAnswer(quests[quest_num]))
                        Im_1.Source = new BitmapImage(new Uri("CIRCLE.png", UriKind.Relative));
                    else
                        MessageBox.Show("Неправильно");
                    break;
                case 1:
                    if (Answer.CheckAnswer(quests[quest_num]))
                        Im_2.Source = new BitmapImage(new Uri("CIRCLE.png", UriKind.Relative));
                    else
                        MessageBox.Show("Неправильно");
                    break;
                case 2:
                    if (Answer.CheckAnswer(quests[quest_num]))
                        Im_3.Source = new BitmapImage(new Uri("CIRCLE.png", UriKind.Relative));
                    else
                        MessageBox.Show("Неправильно");
                    break;
                case 3:
                    if (Answer.CheckAnswer(quests[quest_num]))
                        Im_4.Source = new BitmapImage(new Uri("CIRCLE.png", UriKind.Relative));
                    else
                        MessageBox.Show("Неправильно");
                    break;
                case 4:
                    if (Answer.CheckAnswer(quests[quest_num]))
                        Im_5.Source = new BitmapImage(new Uri("CIRCLE.png", UriKind.Relative));
                    else
                        MessageBox.Show("Неправильно");
                    break;



                case 5:
                    if (Answer.CheckAnswer(quests[quest_num]))
                        Im_6.Source = new BitmapImage(new Uri("CIRCLE.png", UriKind.Relative));
                    else
                        MessageBox.Show("Неправильно");
                    break;
                case 6:
                    if (Answer.CheckAnswer(quests[quest_num]))
                        Im_7.Source = new BitmapImage(new Uri("CIRCLE.png", UriKind.Relative));
                    else
                        MessageBox.Show("Неправильно");
                    break;
                case 7:
                    if (Answer.CheckAnswer(quests[quest_num]))
                        Im_8.Source = new BitmapImage(new Uri("CIRCLE.png", UriKind.Relative));
                    else
                        MessageBox.Show("Неправильно");
                    break;
                case 8:
                    if (Answer.CheckAnswer(quests[quest_num]))
                        Im_9.Source = new BitmapImage(new Uri("CIRCLE.png", UriKind.Relative));
                    else
                        MessageBox.Show("Неправильно");
                    break;
                case 9:
                    if (Answer.CheckAnswer(quests[quest_num]))
                        Im_10.Source = new BitmapImage(new Uri("CIRCLE.png", UriKind.Relative));
                    else
                        MessageBox.Show("Неправильно");
                    break;
            }
            NextTask();
            RefreshTask();
        }

        private void RefreshTask()
        {
            Task.Content = quests[quest_num].Description;
            Lb_Quest.Content = "Вопрос № " + (quest_num + 1);
            if (quest_num > 4 && MainWindow.CurTest == 32)
            {
                Rb_Y.Visibility = Visibility.Visible;
                Rb_N.Visibility = Visibility.Visible;
                InputAnswer.Visibility = Visibility.Hidden;
            }
            else
            {
                Rb_Y.Visibility = Visibility.Hidden;
                Rb_N.Visibility = Visibility.Hidden;
                InputAnswer.Visibility = Visibility.Visible;
            }
        }

        private void Bt_Skip_Click(object sender, RoutedEventArgs e)
        {
            NextTask();
            RefreshTask();
        }

        private void Bt_Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Bt_Min_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;

        }

        private void Rc_Bar_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Im_1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            quest_num = 0;
            Lb_Quest.Content = "Вопрос № " + quest_num;
            RefreshTask();
        }

        private void Im_2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            quest_num = 1;
            Lb_Quest.Content = "Вопрос № " + quest_num;
            RefreshTask();
        }

        private void Im_3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            quest_num = 2;
            Lb_Quest.Content = "Вопрос № " + quest_num;
            RefreshTask();
        }


        private void Im_4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            quest_num = 3;
            Lb_Quest.Content = "Вопрос № " + quest_num;
            RefreshTask();
        }

        private void Im_5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            quest_num = 4;
            Lb_Quest.Content = "Вопрос № " + quest_num;
            RefreshTask();
        }

        private void Im_6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            quest_num = 5;
            Lb_Quest.Content = "Вопрос № " + quest_num;
            RefreshTask();
        }

        private void Im_7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            quest_num = 6;
            Lb_Quest.Content = "Вопрос № " + quest_num;
            RefreshTask();
        }

        private void Im_8_MouseDown(object sender, MouseButtonEventArgs e)
        {
            quest_num = 7;
            Lb_Quest.Content = "Вопрос № " + quest_num;
            RefreshTask();
        }

        private void Im_9_MouseDown(object sender, MouseButtonEventArgs e)
        {
            quest_num = 8;
            Lb_Quest.Content = "Вопрос № " + quest_num;
            RefreshTask();
        }

        private void Im_10_MouseDown(object sender, MouseButtonEventArgs e)
        {
            quest_num = 9;
            Lb_Quest.Content = "Вопрос № " + quest_num;
            RefreshTask();
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

        private void Bt_End_Click(object sender, RoutedEventArgs e)
        {
            object oMissing = System.Reflection.Missing.Value;
            object pageBreak = WdBreakType.wdPageBreak;
            object noSave = WdSaveOptions.wdDoNotSaveChanges;
            object template = "Resources\template1.docx";
            object destination = @"C:\destination.docx";


            _Application word = new Microsoft.Office.Interop.Word.Application();
            _Document sdoc = word.Documents.Add(new Uri(@"..\..\Files\template.docx",UriKind.Relative), ref oMissing, ref oMissing, ref oMissing);
            string[] keyWords = {"NUM", "THEME", "GNAME", "TNAME", "FNAMEONE", "FNAMETWO", "TEXT", "RESULTS"};

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
                    ;
                }
                ;
            }
            ;


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
                        replaceWith = MainWindow.CurTest + ke.spacesAfter;
                        break;
                    case "THEME":
                        replaceWith = MainWindow.CurTestName + ke.spacesAfter;
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

            ddoc.SaveAs(new Uri(@"..\..\Files\destination.docx", UriKind.Relative), ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing);
            //ddoc.Save();
            ddoc.Close(ref oMissing, ref oMissing, ref oMissing);

            word.Quit(ref oMissing, ref oMissing, ref oMissing);

        }


    }
}
    
