using System;

namespace Core
{
    public static class FileHelper
    {
        public static string GetDir() => Environment.GetFolderPath(Environment.SpecialFolder.Personal);
    }
}