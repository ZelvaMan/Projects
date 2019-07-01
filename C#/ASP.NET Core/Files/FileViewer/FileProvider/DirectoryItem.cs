using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.WebUtilities;

namespace FileProvider
{
	class DirectoryItem
	{
		public string Title { get; private set; }
		public string FullPath { get; private set; }
		public string Extansion { get; private set; }
		public DateTime CreationTime { get; private set; }
		public bool isFolder;
	}

	class DirectoryItems
	{
		public List<DirectoryItem> FileInfos = new List<DirectoryItem>();

		public void Ordered()
		{
			FileInfos = (from u in FileInfos
				orderby u.isFolder descending, u.Title
				select u).ToList();

		}
	}
}
