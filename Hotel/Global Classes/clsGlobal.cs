using Hotel_Buisness;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Global_Classes
{
    public class clsGlobal
    {
        public static clsUser CurrentUser;// المستخدم الدي قام بتسجيل الدخول
                                          //  يحفظ كلمة السر و اسم النستخدم باملف من اجل يرجع يستخدمهن
        public static bool RememberUsernameAndPassword(string Username, string Password)
        {

            try
            {
                //this will get the current project directory folder.
                //نحصل على امتداد مجلد المشروع من اجل نحط الملف داخلة
                //  string currentDirectory = System.IO.Directory.GetCurrentDirectory();
                string currentDirectory = "D:/كورسات ابو هد هود/Hotel/Hotel/Fixed_files_Hotel";





                // إذا كان الـ Username null أو فارغًا، قم بحذف البيانات من الـ Registry
                /* if (string.IsNullOrEmpty(Username))
                 {
                     DeleteRegistryValues();

                     return true;
                 }
                 //string KeyPath = @"Hkey_CURRENT_USER\SOFTWARE\DVLD_PROJECT";

                     string UserName = "UserName";
                     string UserValue = Username;

                     string PassWordName = "PassWord";
                     string PassWordValue = Password;

                 try
                 {
                     // Write the value to the Registry
                     Registry.SetValue(registryKeyPath, UserName, UserValue, RegistryValueKind.String);
                     Registry.SetValue(registryKeyPath, PassWordName, PassWordValue, RegistryValueKind.String);

                     return true;
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Error : " + ex.Message);
                     return false;
                 }*/


                // Define the path to the text file where you want to save the data
                //حدد المسار إلى الملف النصي الذي تريد حفظ البيانات فيه
                string filePath = currentDirectory + "/data.txt";
                //incase the username is empty, delete the file
                //إذا كان اسم المستخدم فارغا، احذف الملف
                if (Username == "" && File.Exists(filePath))
                {
                    File.Delete(filePath);
                    return true;

                }

                // concatonate username and passwrod withe seperator.
                // حفض اسم المستخدم وكلمة المرور بهاذا التشفير داخل هاذاالمتغير من اجل حفضة بالملف
                string dataToSave = Username + "#//#" + Password;

                // Create a StreamWriter to write to the file
                // نقوم بكتابة او حفظ البيانات داخل الملف
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write the data to the file
                    writer.WriteLine(dataToSave);

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }





        // يرجع بيانات الذي داخل الملف
        public static bool GetStoredCredential(ref string Username, ref string Password)
        {

            //string UserName = "UserName";
            //string PassWordName = "PassWord";

            //try
            //{
            //    Username = Registry.GetValue(registryKeyPath, UserName, null) as string;
            //    Password = Registry.GetValue(registryKeyPath, PassWordName, null) as string;


            //    if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"An error occurred: {ex.Message}");
            //    return false;

            //}




            //  this will get the stored username and password and will return true if found and false if not found.
            try
            {
                //gets the current project's directory
                //نحصل على امتداد مجلد المشروع من الذي داخلة الملف البيانات

                //  string currentDirectory = System.IO.Directory.GetCurrentDirectory();
                string currentDirectory = "D:/كورسات ابو هد هود/Hotel/Hotel/Fixed_files_Hotel";

                // Path for the file that contains the credential.
                //حدد المسار إلى الملف النصي الذي نريد الحصول على البيانات منه

                string filePath = currentDirectory + "/data.txt";

                // Check if the file exists before attempting to read it
                // هل كان الملف موجود
                if (File.Exists(filePath))
                {
                    // Create a StreamReader to read from the file
                    // قوم بقرءاة البيانات التي داخل الملف وحطها في المتغيرات
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        // Read data line by line until the end of the file
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line); // Output each line of data to the console
                            string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                            Username = result[0];
                            Password = result[1];
                        }
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }


    }
}
