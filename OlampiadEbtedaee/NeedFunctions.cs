using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.IO;
namespace OlampiadEbtedaee
{
   public static class NeedFunctions
    {


       public static bool IsStringInFile(string fileName, string searchString)
       {
           return File.ReadAllText(fileName).Contains(searchString);
       }

       ////////////////////برای سوال 13 پیش دبستانی////////////////////
       public static string TaskbarsizeState()
       {
           RegistryKey myKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", false);
           String value = myKey.GetValue("TaskbarSizeMove").ToString();
           return value;
       }

       public static string PaintStatusBarState()
       {
           RegistryKey myKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Applets\paint\view", false);
           String value = myKey.GetValue("ShowStatusBar").ToString();
           return value;
       }
     
       public static string magnifierState()
       {
           RegistryKey myKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\ScreenMagnifier", false);
           String value = myKey.GetValue("ZoomIncrement").ToString();
           return value;
       }
       public static string taskbarSizeMove = TaskbarsizeState();
       public static string paintStatusBarState = PaintStatusBarState();
       public static string getMagnifierZoomState = magnifierState();


      
       public static string GetPathOfWallpaper()
       {
           string pathWallpaper = "";
           RegistryKey regKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", false);
           if (regKey != null)
           {
               pathWallpaper = regKey.GetValue("TileWallpaper").ToString();
             
               regKey.Close();
           }
           return pathWallpaper;
       }

       public static void CreatePrequires()
       {
           Directory.CreateDirectory(@"D:\D");
           Directory.Delete(@"D:\D");
           Directory.CreateDirectory(@"D:\F");
           Directory.CreateDirectory(@"D:\X");
       }

      
    }
}
