using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Shell32;
using IWshRuntimeLibrary;
using Microsoft.Win32;
using System.Diagnostics;
using System.Xml;

namespace OlampiadEbtedaee
{
    public static class Correction
    {

        // این تابع شماره سوال و شماره ترتیب سوال و زمان را میگیرد و تصحیح میکند
        public static void WinPracticalCorrection(int questionNumber, int n, int time)
        {
            ///////////////سوالات پیش دبستانی////////////////////   

            ////////////سوال 1 پیش دبستانی///////////////
            if (questionNumber == 1)
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (Directory.Exists(path + @"\A"))
                {

                    Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    Directory.Delete(path + @"\A");

                }
                else
                {
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

                }


            }


            ////////////سوال 2 پیش دبستانی///////////////
            if (questionNumber == 2)
            {

                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var combinedPath = Path.Combine(desktopPath, @"p.lnk");
                if (System.IO.File.Exists(combinedPath))
                {
                    Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    System.IO.File.Delete(combinedPath);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }




            ////////////سوال 3 پیش دبستانی///////////////
            if (questionNumber == 3)
            {
                RegistryKey myKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Applets\paint\view", false);
                String value = myKey.GetValue("ShowStatusBar").ToString();

                if (NeedFunctions.paintStatusBarState == "0") //If Before was Lock
                {
                    if (value == "1")
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    if (value == "0")
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                if (NeedFunctions.paintStatusBarState == "1") //If Before was UnLock
                {
                    if (value == "0")
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    if (value == "1")
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                myKey.Close();
            }



            ////////////سوال 4 پیش دبستانی///////////////
            if (questionNumber == 4)
            {
                RegistryKey myKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\ScreenMagnifier", false);
                String value = myKey.GetValue("ZoomIncrement").ToString();

                if (NeedFunctions.getMagnifierZoomState == "190") //If Before was Lock
                {
                    if (value == "64")
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                if (NeedFunctions.taskbarSizeMove == "64") //If Before was UnLock
                {
                    if (value == "190")
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                   else 
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                myKey.Close();
            }

            ////////////سوال 5 پیش دبستانی///////////////
            if (questionNumber == 5)
            {

                 string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                 var combinedPath = Path.Combine(desktopPath, @"A.png");
                if (System.IO.File.Exists(combinedPath))
                {
                    Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    System.IO.File.Delete(combinedPath);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }



            ////////////سوال 6 پیش دبستانی///////////////
            if (questionNumber == 6)
            {
                if (System.IO.File.Exists(@"D:\S.png"))
                {
                    Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    System.IO.File.Delete(@"D:\S.png");
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }

            ////////////سوال 7 پیش دبستانی/////////////// تغییر کرده
            if (questionNumber == 7)
            {
                if (NeedFunctions.GetPathOfWallpaper() == @"1")
                {
                    Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    ///??????????????????????????????کـــــد تغییر پیش فرض بکگراند????????????????????????
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }


            ////////////سوال 8 پیش دبستانی///////////////
            if (questionNumber == 8)
            {
                Process[] pname = Process.GetProcessesByName("magnify");
                if (pname.Length==0)
                {
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                   
                }
                else
                    Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
            }

            ////////////سوال 9 پیش دبستانی///////////////
            if (questionNumber == 9)
            {
                Process[] pname = Process.GetProcessesByName("narrator");
                if (pname.Length == 0)
                {
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

                }
                else
                    Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
            }

            ////////////سوال 10 پیش دبستانی///////////////
            if (questionNumber == 10)
            {
               
                if (!Directory.Exists(@"D:\F"))
                {
                    Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    Directory.CreateDirectory(@"D:\F");

                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

                Directory.CreateDirectory(@"D:\F");
            }



            ////////////سوال 11 پیش دبستانی///////////////
            if (questionNumber == 11)
            {
                  string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                  if (Directory.Exists(@"D:\C") && Directory.Exists(path + @"\C"))
                {
                    Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    Directory.Delete(path + @"\C");
                    if (!Directory.Exists(@"D:\C"))
                        Directory.CreateDirectory(@"D:\C");
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }

            ////////////سوال 12 پیش دبستانی///////////////
            if (questionNumber == 12)
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (!Directory.Exists(@"D:\X") && Directory.Exists(path + @"\X"))
                {
                    Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    Directory.Delete(path + @"\X");
                    if (!Directory.Exists(@"D:\X"))
                        Directory.CreateDirectory(@"D:\X");
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }

            ////////////سوال 13 پیش دبستانی///////////////
            if (questionNumber == 13)
            {
                RegistryKey myKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", false);
                String value =myKey.GetValue("TaskbarSizeMove").ToString();

                if (NeedFunctions.taskbarSizeMove == "0") //If Before was Lock
                {
                    if (value == "1")
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    if (value == "0")
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                if (NeedFunctions.taskbarSizeMove == "1") //If Before was UnLock
                {
                    if (value == "0")
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    if (value == "1")
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                myKey.Close();
            }

            ////////////سوال 14 پیش دبستانی///////////////
            if (questionNumber == 14)
            {
                Process[] pname = Process.GetProcessesByName("taskmgr");
                if (pname.Length == 0)
                {
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

                }
                else
                    Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
            }

            ////////////سوال 15 پیش دبستانی///////////////
            if (questionNumber == 15)
            {
                RegistryKey desktopKey = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop",true);
                String value = desktopKey.GetValue("ScreenSaveTimeOut").ToString();
                if (value == "180")
                {
                    Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    desktopKey.SetValue("ScreenSaveTimeOut", 60,RegistryValueKind.String);
                }
                   
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                desktopKey.Close();
            }
            ///////////////////////////////////پایان سوالات پیش دبستانی/////////////////////////////








            ///////////////////////////شروع سوالات کلاس اول////////////////////////////////////

            ////////////سوال 16 کلاس اول///////////////
            if (questionNumber == 16)
            {
                Process[] pname = Process.GetProcessesByName("msinfo32");
                if (pname.Length == 0)
                {
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

                }
                else
                    Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
            }

            ////////////سوال 17 کلاس اول///////////////
            if (questionNumber == 17)
            {
                RegistryKey desktopKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", true);
                String value = desktopKey.GetValue("Hidden").ToString();
                if (value == "1")
                {
                    Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    desktopKey.SetValue("Hidden", 2, RegistryValueKind.String);
                }

                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                desktopKey.Close();
            }

            ////////////سوال 18 کلاس اول///////////////
            if (questionNumber == 18)
            {
                RegistryKey desktopKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", true);
                String value = desktopKey.GetValue("HideFileExt").ToString();
                if (value == "0")
                {
                    Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    desktopKey.SetValue("HideFileExt", 1, RegistryValueKind.String);
                }

                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                desktopKey.Close();
            }

            ////////////سوال 19 کلاس دوم سوم///////////////
            if (questionNumber == 19)
            {
                RegistryKey desktopKey = Registry.CurrentUser.OpenSubKey(@"Control Panel\Mouse", true);
                String value = desktopKey.GetValue("MouseTrails").ToString();
                if (value != "0")
                {
                    Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    desktopKey.SetValue("MouseTrails", 0, RegistryValueKind.String);
                }

                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                desktopKey.Close();
            }

            ////////////سوال 20 کلاس دوم سوم///////////////
            if (questionNumber == 20)
            {
                RegistryKey desktopKey = Registry.CurrentUser.OpenSubKey(@"Control Panel\Mouse", true);
                String value = desktopKey.GetValue("SnapToDefaultButton").ToString();
                if (value == "1")
                {
                    Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    desktopKey.SetValue("MouseTrails", 0, RegistryValueKind.String);
                }

                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                desktopKey.Close();
            }

            ////////////سوال بیست و یکم کلاس دوم و سوم///////////////
            if (questionNumber == 21)
            {
                Process[] pname = Process.GetProcessesByName("StikyNot");
                if (pname.Length == 0)
                {
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

                }
                else
                    Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
            }



            ////////////سوال بیست و دوم کلاس دوم و سوم///////////////
            if (questionNumber == 22)
            {
                Process[] pname = Process.GetProcessesByName("Sdclt");
                if (pname.Length == 0)
                {
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

                }
                else
                    Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
            }
        }

        public static void WordPracticalCorrection(int questionNumber, int n, int time)
        {
            /////////////////سوالات پیش دبستانی//////////////////
            
            ///////سوال اول پیش دبستانی/////////
            if (questionNumber == 1)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\Word\" + Session.currentUserId + "-1";
                if (System.IO.File.Exists( path1 + @".xml"))
                {

                   var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-1.xml";
                   var fileInfo = new FileInfo(myfile);
                   fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                   myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-1.txt";

                    if (NeedFunctions.IsStringInFile(myfile,"Smiley Face"))
                    Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                    
            }


            ///////سوال دوم پیش دبستانی/////////
            if (questionNumber == 2)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\Word\" + Session.currentUserId + "-2";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-2.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-2.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "txbxContent"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }


            ///////سوال سوم پیش دبستانی/////////
            if (questionNumber == 3)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-3";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-3.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-3.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "bottom=\"2268\""))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }

            ///////سوال چهارم پیش دبستانی/////////
            if (questionNumber == 4)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-4";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-4.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-4.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "w:w=\"15840\" w:h=\"12240\""))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }

            ///////سوال پنجم پیش دبستانی/////////
            if (questionNumber == 5)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-5";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-5.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-5.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "<w:sz w:val=\"40\"/>"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }


            ///////سوال ششم پیش دبستانی/////////
            if (questionNumber == 6)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-6";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-6.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-6.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "pgBorders"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }

            ///////سوال هفتم پیش دبستانی/////////
            if (questionNumber == 7)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-6";
                if (System.IO.File.Exists(path1 + @".pdf"))
                {
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }
            

                 ///////سوال هشتم پیش دبستانی/////////
            if (questionNumber == 8)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-8";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-8.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-8.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "<w:b/>"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }

            ///////سوال نهم پیش دبستانی/////////
            if (questionNumber == 9)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-9";
                if (System.IO.File.Exists(path1 + @".xml"))
                {

                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-9.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-9.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "pkg:contentType=\"image"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }
            

            ///////سوال دهم پیش دبستانی/////////
            if (questionNumber == 10)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-10";
                if (System.IO.File.Exists(path1 + @".xml"))
                {

                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-10.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-10.txt";
                    
                    if (NeedFunctions.IsStringInFile(myfile, "w:val=\"Page Numbers") || ( NeedFunctions.IsStringInFile(myfile, "data=\"1\"") && ( NeedFunctions.IsStringInFile(myfile, "Header")) ))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }

            //////////////////////////////پایان سوالات پیش دبستانی//////////////////////////////////





            //////////////////////////////شروع سوالات اول//////////////////////////////////

            ///////سوال یازدهم کلاس اول/////////
            if (questionNumber == 11)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-11";
                if (System.IO.File.Exists(path1 + @".xml"))
                {

                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-11.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-11.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "آزمون") && NeedFunctions.IsStringInFile(myfile, "∑"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }

            ///////سوال دوازدهم کلاس اول/////////
            if (questionNumber == 12)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-12";
                if (System.IO.File.Exists(path1 + @".doc"))
                {
                    Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }


                  ///////سوال سیزدهم کلاس اول/////////
            if (questionNumber == 13)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-13";
                if (System.IO.File.Exists(path1 + @".xml"))
                {

                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-13.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-13.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "vert=\"vert\""))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }


            ///////سوال چهاردهم کلاس اول/////////
            if (questionNumber == 14)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-14";
                if (System.IO.File.Exists(path1 + @".xml"))
                {

                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-14.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-14.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "Heading2"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }
               ///////سوال پانزدهم کلاس اول/////////
            if (questionNumber == 15)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-15";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-15.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-15.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "<w:pgSz w:w=\"16839\" w:h=\"23814\""))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }


              ///////سوال شانزدهم کلاس اول/////////
            if (questionNumber == 16)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-16";
                if (System.IO.File.Exists(path1 + @".xml"))
                {

                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-16.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-16.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "w:line=\"720\""))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }

            

            /////////////////////////////////سوالات کلاس دوم و سوم /////////////////////////////////////////////
              ///////سوال هفدهم کلاس دوم سوم/////////
            if (questionNumber == 17)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-17";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-17.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-17.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "PowerPlusWaterMarkObject") && NeedFunctions.IsStringInFile(myfile, "mso-position-horizontal"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }

            ///////سوال هجدهم کلاس دوم سوم/////////
            if (questionNumber == 18)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-18";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-18.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-18.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "<w:cols w:num=\"3\" w:sep=\"1\"") && NeedFunctions.IsStringInFile(myfile, "mso-position-horizontal"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }


            ///////سوال نوزدهم کلاس دوم سوم/////////
            if (questionNumber == 19)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-19";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-19.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-19.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "bullet"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }

            ///////سوال بیستم کلاس دوم سوم/////////
            if (questionNumber == 20)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-20";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-20.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-20.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "bullet"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }

            ///////سوال بیست و یکم کلاس دوم سوم/////////
            if (questionNumber == 21)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-21";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-21.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-21.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "<w:pgSz w:w=\"16840\" w:h=\"23814\"") && NeedFunctions.IsStringInFile(myfile, "<w:pgMar w:top=\"1134\" w:right=\"1134\" w:bottom=\"1134\" w:left=\"1134\""))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }
            
            
           ///////سوال بیست و دوم کلاس دوم سوم/////////
            if (questionNumber == 22)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-22";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-22.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-22.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "a:glow"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }

            ///////سوال بیست و سوم کلاس دوم سوم/////////
            if (questionNumber == 23)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-23";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-23.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-23.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "</wps:txbx>") && NeedFunctions.IsStringInFile(myfile, "<a:prstGeom prst="))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }

            ///////سوال بیست و چهارم کلاس دوم سوم/////////
            if (questionNumber == 24)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-24";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-24.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-24.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "<w:docPartGallery w:val=\"Cover Pages\""))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }

            
           ///////سوال بیست و پنجم کلاس دوم سوم/////////
            if (questionNumber == 25)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-25";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-25.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-25.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "w:val=\"superscript\""))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }

            ///////سوال بیست و ششم کلاس دوم سوم/////////
            if (questionNumber == 26)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-26";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-26.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-26.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "<w:evenAndOddHeaders/>"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }

            //////////////////شروع سوالات کلاس چهارم و پنجم/////////////////////

            ///////سوال بیست و هفتم کلاس چهارم پنجم/////////
            if (questionNumber == 27)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-27";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-27.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-27.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "comp") && NeedFunctions.IsStringInFile(myfile, "compo") && !NeedFunctions.IsStringInFile(myfile, "<w:proofErr"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }

            ///////سوال بیست و هشتم کلاس چهارم پنجم/////////
            if (questionNumber == 28)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-28";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-28.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-28.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "<w:ind w:firstLine=\"1134\""))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }

            ///////سوال بیست و نهم کلاس چهارم پنجم/////////
            if (questionNumber == 28)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-29";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-29.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-29.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "<w:spacing w:before=\"1200\""))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }


            ///////سوال سی کلاس چهارم پنجم/////////
            if (questionNumber == 30)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-30";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-30.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-30.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "w:val=\"FootnoteReference\""))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }



             ///////سوال سی و یکم کلاس چهارم پنجم/////////
            if (questionNumber == 31)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-31";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-31.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-31.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "w:val=\"EndnoteReference\""))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }

            ///////سوال سی و دوم کلاس چهارم پنجم/////////
            if (questionNumber == 32)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-32";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-32.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-32.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "w:val=\"ListParagraph\"/><w:numPr><w:ilvl w:val=\"0\""))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }


            ///////سوال سی و سوم کلاس چهارم پنجم/////////
            if (questionNumber == 33)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-33";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-33.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-33.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "<m:oMathPara>"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }
            
            
            ///////سوال سی و چهارم کلاس چهارم پنجم/////////
            if (questionNumber == 34)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-34";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-34.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-34.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "w:val=\"CommentReference\"/>"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }


            ///////سوال سی و پنج کلاس چهارم پنجم/////////
            if (questionNumber == 35)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-35";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-35.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-35.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "6804") && NeedFunctions.IsStringInFile(myfile, "8505"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }


            ///////سوال سی و ششم کلاس چهارم پنجم/////////
            if (questionNumber == 36)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-36";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-36.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-36.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "mailto"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }
            

            /////////////////سوالات کلاس ششم////////////////////
            ///////سوال سی و هفتم کلاس ششم/////////
            if (questionNumber == 37)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-37";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-37.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-37.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "<w:mailMerge>"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }
            ///////سوال سی و هشتم کلاس ششم/////////
            if (questionNumber == 38)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-38";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-38.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-38.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "<w:mailMerge>"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }

            ///////سوال سی و نهم کلاس ششم/////////
            if (questionNumber == 39)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-39";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-39.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-39.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "8505") && NeedFunctions.IsStringInFile(myfile, "11340"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }
            
            ///////سوال چهلم کلاس ششم/////////
            if (questionNumber == 40)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-40";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-40.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\word\" + Session.currentUserId + "-40.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "Border") && NeedFunctions.IsStringInFile(myfile, "w:sz=\"24\""))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);

            }




            
        }
  
        public static void PowerPointPracticalCorrection(int questionNumber, int n, int time)
        {
            //////////سوالات کلاس اول//////////////
            if (questionNumber == 1)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-1";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-1.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-1.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "</p:anim>"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }
            

                 //////////سوال دوم کلاس اول//////////////
            if (questionNumber == 2)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-2";
                if (System.IO.File.Exists(path1 + @".xml"))
                {

                    var myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-2.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-2.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "p:transition spd="))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }



            //////////سوال سوم کلاس اول//////////////
            if (questionNumber == 3)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-3";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-3.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-3.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "<a:audioFile"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }


            
            //////////سوال چهارم کلاس اول//////////////
            if (questionNumber == 4)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-4";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-4.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-4.txt";

                    if (!NeedFunctions.IsStringInFile(myfile, "<a:clrScheme name=\"Office\""))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }
            


          //////////سوال پنجم کلاس اول//////////////
            if (questionNumber == 5)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-5";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-5.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-5.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "<p:animMotion origin=\"layout\" path="))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }

            

           //////////سوال پنجم کلاس اول//////////////
            if (questionNumber == 6)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-6";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-6.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-6.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "<a:prstGeom prst=") && System.IO.File.Exists(path1 + @".ppsx"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }

            

                  //////////سوال هفتم کلاس اول//////////////
            if (questionNumber == 7)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-7";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-7.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-7.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "Custom Show"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }


            //////////سوال هشتم کلاس اول//////////////
            if (questionNumber == 8)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-8";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-8.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-8.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "<a:tbl>") && NeedFunctions.IsStringInFile(myfile, "prst"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }

            

            //////////سوال نهم کلاس دوم سوم//////////////
            if (questionNumber == 9)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-9";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-9.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-9.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "jump="))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }

            //////////سوال دهم کلاس دوم سوم//////////////
            if (questionNumber == 10)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-10";
                if (System.IO.File.Exists(path1 + @".ppt"))
                {
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }

            //////////سوال یازدهم کلاس دوم سوم//////////////
            if (questionNumber == 11)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-11";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-11.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-11.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "google") && NeedFunctions.IsStringInFile(myfile, "hyperlink"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }

            

           //////////سوال دوازدهم کلاس دوم سوم//////////////
            if (questionNumber == 12)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-12";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-12.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-12.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "<p:cm") && NeedFunctions.IsStringInFile(myfile, "آزمون"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }

            //////////سوال سیزدهم کلاس دوم سوم//////////////
            if (questionNumber == 13)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-13";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-13.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-13.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "<p:showPr loop=\"1\""))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }


            //////////سوال چهاردهم کلاس دوم سوم//////////////
            if (questionNumber == 14)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-14";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-14.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-14.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "showNarration=\"0\""))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }
            

          //////////سوال پانزدهم کلاس دوم سوم//////////////
            if (questionNumber == 15)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-15";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-15.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-15.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "showAnimation=\"0\""))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }

            ///////////////////////سوالات کلاس چهارم پنجم/////////////////////////

            //////////سوال شانزدهم کلاس چهارم پنجم//////////////
            if (questionNumber == 16)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-16";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-16.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-16.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "TargetMode=\"External\"") && NeedFunctions.IsStringInFile(myfile, "calc"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }


            //////////سوال هفدهم کلاس چهارم پنجم//////////////
            if (questionNumber == 17)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-17";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-17.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-17.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "presetClass=\"entr\"") && NeedFunctions.IsStringInFile(myfile, "presetClass=\"exit\""))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }

            
            //////////سوال هجدهم کلاس چهارم پنجم//////////////
            if (questionNumber == 18)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-18";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-18.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-18.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "<p:audio isNarration=\"1\">"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }  
          
            


            //////////سوال نوزدهم کلاس چهارم پنجم//////////////
            if (questionNumber == 19)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-19";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-19.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-19.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "repeatCount=\"10000\""))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }

            
            //////////سوال بیستم کلاس چهارم پنجم//////////////
            if (questionNumber == 20)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-20";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-20.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-20.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "<p:cond delay=\"4000\"/>"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }


            

                //////////سوال بیست و یکم کلاس چهارم پنجم//////////////
            if (questionNumber == 21)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-21";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-21.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-21.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "<p:sndTgt r:embed="))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }


            

            //////////سوال بیست و دوم کلاس چهارم پنجم//////////////
            if (questionNumber == 22)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-22";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-22.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-22.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "jump=firstslide") || NeedFunctions.IsStringInFile(myfile, "jump=previousslide"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }
            

            //////////سوال بیست و سوم کلاس چهارم پنجم//////////////
            if (questionNumber == 23)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-23";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-23.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-23.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "orgChart"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }


            //////////سوال بیست و چهارم کلاس چهارم پنجم//////////////
            if (questionNumber == 24)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-24";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-24.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-24.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "withEffect") && NeedFunctions.IsStringInFile(myfile, "<p:animEffect transition=\"in\""))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }

            //////////سوال بیست و پنجم کلاس چهارم پنجم//////////////
            if (questionNumber == 25)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-25";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-25.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-25.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "jump=endshow\" highlightClick=\"1\""))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }


            //////////سوال بیست و ششم کلاس چهارم پنجم//////////////
            if (questionNumber == 26)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-26";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-26.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-26.txt";

                    if (NeedFunctions.IsStringInFile(myfile, ""))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }

            
           //////////سوال بیست و هفتم کلاس چهارم پنجم//////////////
            if (questionNumber == 27)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-27";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-27.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\PowerPoint\" + Session.currentUserId + "-27.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "dur=\"10250\""))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }

            
        }

        public static void ExcelPracticalCorrection(int questionNumber, int n, int time)
        {
            ////////////شروع سوالات اکسل//////////////

            /////////////سوالات اکسل دوم و سوم////////////////



            ///////////////سوال اول کلاس دوم سوم/////////////////
            if (questionNumber ==1)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-1";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-1.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-1.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "<Worksheet ss:Name=\"آزمون\">"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }


            ///////////////سوال دوم کلاس دوم سوم/////////////////
            if (questionNumber == 2)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-2";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-2.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-2.txt";

                    if (!NeedFunctions.IsStringInFile(myfile, "<Worksheet ss:Name=\"Sheet2\">"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }



            ///////////////سوال سوم کلاس دوم سوم/////////////////
            if (questionNumber == 3)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-3";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-3.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-3.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "\"><Data ss:Type=\"Number\">10</Data>") && NeedFunctions.IsStringInFile(myfile, "=Min("))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }



            ///////////////سوال چهارم کلاس دوم سوم/////////////////
            if (questionNumber == 4)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-4";
                if (System.IO.File.Exists(path1 + @".xml"))
                {

                    var myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-4.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-4.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "</ss:Data></Comment>"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }

            


               ///////////////سوال پنجم کلاس دوم سوم/////////////////
            if (questionNumber == 5)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-5";
                if (System.IO.File.Exists(path1 + @".xml"))
                {

                    var myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-5.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-5.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "=(R[-1]C+R[-2]C)") || NeedFunctions.IsStringInFile(myfile, "=SUM(R[-2]C:R[-1]C)")
                         || NeedFunctions.IsStringInFile(myfile, "=SUM(R[-2]C,R[-1]C)") || NeedFunctions.IsStringInFile(myfile, "=(R[-2]C+R[-1]C)")
                        || NeedFunctions.IsStringInFile(myfile, "=SUM(R[-1]C:R[-2]C)") || NeedFunctions.IsStringInFile(myfile, "=SUM(R[-1]C,R[-2]C)") )
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }

            


          ///////////////سوال ششم کلاس دوم سوم/////////////////
            if (questionNumber == 6)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-6";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-6.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-6.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "h:mm:ss"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }


            

            ////////////////////شروع سوالات کلاس چهارم و پنجم///////////////////////
            ///////////////سوال هفتم کلاس چهارم و پنجم/////////////////
            if (questionNumber == 7)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-7";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-7.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-7.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "=IF(RC[-2]&gt;RC[-1],&quot;")&& !NeedFunctions.IsStringInFile(myfile, "ss:Type=\"Error\">"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }



            ////////////////////سوال هشتم کلاس چهارم پنجم////////////////////
            if (questionNumber == 8)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-8";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-8.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-8.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "<Data ss:Type=\"String\">") && NeedFunctions.IsStringInFile(myfile, "<Cell ss:Formula=\"=Sheet1!RC\"><Data ss:Type=\"String\">"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }

            
            ////////////////////سوال نهم کلاس چهارم پنجم////////////////////
            if (questionNumber == 9)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-9";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-9.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-9.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "ss:Format=\"0.0"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }


            

            ////////////////////سوال دهم کلاس چهارم پنجم////////////////////
            if (questionNumber == 10)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-10";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-10.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-10.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "ss:HRef=\"#Sheet2!B12\">"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }


            ////////////////////سوال یازدهم کلاس چهارم پنجم////////////////////
            if (questionNumber == 11)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-11";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-11.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-11.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "x:Data=\"&amp;C"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }


            ////////////////////سوال دوازدهم کلاس چهارم پنجم////////////////////
            if (questionNumber == 12)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-12";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-12.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-12.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "<NamedRange ss:Name=\"_FilterDatabase\""))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }


            ////////////////////سوال چهاردهم کلاس چهارم پنجم////////////////////
            if (questionNumber == 14)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-14";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-14.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-14.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "ss:Rotate="))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }

            
            ////////////////////سوال پانزدهم کلاس چهارم پنجم////////////////////
            if (questionNumber == 15)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-15";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-15.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-15.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "ss:WrapText=\"1\""))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }

             ////////////////////سوال شانزدهم کلاس چهارم پنجم////////////////////
            if (questionNumber == 16)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-16";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-16.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-16.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "</ConditionalFormatting>"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }


            

            ////////////////////سوال هفدهم کلاس چهارم پنجم////////////////////
            if (questionNumber == 17)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-17";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-17.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-17.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "ss:Formula=\"=AVERAGE(") && NeedFunctions.IsStringInFile(myfile, "/SUM(") && NeedFunctions.IsStringInFile(myfile, "ss:Type=\"Number\">0.05"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }

            ////////////////////سوال هجدهم کلاس چهارم پنجم////////////////////
            if (questionNumber == 18)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-18";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-18.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-18.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "21150"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }


            ////////////////////سوال نوزدهم کلاس چهارم پنجم////////////////////
            if (questionNumber == 19)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-19";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-19.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-19.txt";

                    if (NeedFunctions.IsStringInFile(myfile, "ss:Format=\"0%\""))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }

            
            ////////////////////سوال بیستم کلاس چهارم پنجم////////////////////
            if (questionNumber == 20)
            {
                string path1 = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-20";
                if (System.IO.File.Exists(path1 + @".xml"))
                {
                    var myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-20.xml";
                    var fileInfo = new FileInfo(myfile);
                    fileInfo.CopyTo(Path.ChangeExtension(myfile, ".txt"));
                    myfile = @"D:\" + Session.currentUserId + @"\Excel\" + Session.currentUserId + "-20.txt";

                    if (NeedFunctions.IsStringInFile(myfile, @"ر\ی\ا\ل"))
                        Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
                    else
                        Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
                }
                else
                    Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
            }
        }
        

       


        
        public static void WinTheory (int questionNumber, int n, int time, string choice)
        {
            var q = (from c in Session.DB.WindowsTheorySet
                     where c.Id == questionNumber
                     select c).Single();
            if (choice == q.Correct)
                Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
            else
                Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
        }

        public static void PowerPointTheory(int questionNumber, int n, int time, string choice)
        {
            var q = (from c in Session.DB.PowerPointTheorySet
                     where c.Id == questionNumber
                     select c).Single();
            if (choice == q.Correct)
                Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
            else
                Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
        }

        public static void WordTheory(int questionNumber, int n, int time, string choice)
        {
            var q = (from c in Session.DB.WordTheorySet
                     where c.Id == questionNumber
                     select c).Single();
            if (choice == q.Correct)
                Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
            else
                Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
        }

        public static void excelTheory(int questionNumber, int n, int time, string choice)
        {
            var q = (from c in Session.DB.ExcelTheorySet
                     where c.Id == questionNumber
                     select c).Single();
            if (choice == q.Correct)
                Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
            else
                Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
        }

        public static void hardware(int questionNumber, int n, int time, string choice)
        {
            var q = (from c in Session.DB.HardwareQuestionSet
                     where c.Id == questionNumber
                     select c).Single();
            if (choice == q.Correct)
                Controller.ExamController.AddExam(1, n, 7, time, Session.currentUserId);
            else
                Controller.ExamController.AddExam(1, n, 0, time, Session.currentUserId);
        }
    }

  

}









