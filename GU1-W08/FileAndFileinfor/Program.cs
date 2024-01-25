internal class Program
{
    private static void Main(string[] args)
    {
       
       //string sourcepath = @"H:\DATA\Map.txt";
       string destination =@"H:\DATA\Des.txt";
      /* if(File.Exists(sourcepath)&&File.Exists(destination))
       {
       File.Copy(sourcepath,destination,overwrite:true);
       //File.Delete(sourcepath);
       }
       */
      /* FileInfo fileInfo = new FileInfo(sourcepath);
       fileInfo.CopyTo(destination,overwrite:true);
       */

      /* string sourcepath = @"D:\DATA\map.txt";
       string destination =@"D:\DATA\des.txt";
       FileInfo fileInfo = new FileInfo(sourcepath);
       fileInfo.CopyTo(destination,overwrite: true);
      // fileInfo.Delete();
       Console.WriteLine(fileInfo.Length);
       */

       
       string sourcepath = @"H:\DATA\map";
       //Directory.CreateDirectory(sourcepath);
       Console.WriteLine(Directory.GetFiles(sourcepath));
       
       /* string sourcepath = @"D:\DATA/Name";
        DirectoryInfo directoryInfo = new DirectoryInfo(sourcepath);

        directoryInfo.Create();
        */

    }
}