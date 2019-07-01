using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileProvider
{
	public static class DirectoryProvider
	{
		/// <summary>
		/// get files in specific directory, if files, is on top, then order by Title
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public static List<FileSystemInfo> GetFilesInDirectory(string path)
		{
			string[] pathes;
			var files = new DirectoryItems();

			try
			{
				 pathes = Directory.GetFileSystemEntries(path, ".", SearchOption.TopDirectoryOnly);
			}
			catch (Exception e)
			{

				return null;
			}
			

			foreach (var filePath in pathes)
			{

				// get the file attributes for file or directory
				FileAttributes attr = File.GetAttributes(filePath);

				//detect whether its a directory or file
				if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
					files.FileInfos.Add(new DirectoryItem(){FileInfo = new DirectoryInfo(filePath),isFolder = true});
				else
					files.FileInfos.Add(new DirectoryItem() { FileInfo = new FileInfo(filePath), isFolder = false });
			}

			return files.ToOrderedList();
		}

		public static List<FileSystemInfo> GetDrives()
		{
			var drives = new List<FileSystemInfo>();
			foreach (var drive in Directory.GetLogicalDrives())
			{
				drives.Add(new DirectoryInfo(drive));
				

			}

			return drives;
		}

		public static string GetParentPath(string path)
		{
			try
			{
				return Directory.GetParent(path).FullName;
			}
			catch (Exception e)
			{
				return null;

			}
			
		}

		public static  FileInfo GetFileInfo(string path)
		{
			return new FileInfo(path);
			
		}
	}
}
