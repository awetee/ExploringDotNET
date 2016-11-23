namespace ExploringDotNET
{
    using System;
    using System.IO;

    internal class MySettings
    {
        public int MyNumber { get; set; }
        public string MyString { get; set; }

        public static void Save()
        {
            throw new NotImplementedException();
        }

        public static MySettings Load()
        {
            throw new NotImplementedException();
        }

        private static string SettingsFolder
        {
            get
            {
                var folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                folder = Path.Combine(folder, "MyCompany");
                folder = Path.Combine(folder, "MyApp");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                return folder;
            }
        }

        private static MySettings DefaultSettings => new MySettings
        {
            MyNumber = 1,
            MyString = ""
        };
    }
}