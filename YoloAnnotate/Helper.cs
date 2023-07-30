using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace YoloAnnotate
{
	static class Helper
	{
		public static Cursor GetResizeCursor(RectangleF rect, Point mouseLocation, out LTRB rmp)
		{
			rmp = default;

			if (IsBetween(rect.Left, mouseLocation.X))
			{
				rmp.Left = 1;

				if (IsBetween(rect.Top, mouseLocation.Y))
				{
					rmp.Top = 1;
					return Cursors.SizeNWSE;
				}
				else if (IsBetween(rect.Bottom, mouseLocation.Y))
				{
					rmp.Bottom = 1;
					return Cursors.SizeNESW;
				}
				else
				{
					return Cursors.SizeWE;
				}
			}
			else if (IsBetween(rect.Right, mouseLocation.X))
			{
				rmp.Right = 1;

				if (IsBetween(rect.Top, mouseLocation.Y))
				{
					rmp.Top = 1;
					return Cursors.SizeNESW;
				}
				else if (IsBetween(rect.Bottom, mouseLocation.Y))
				{
					rmp.Bottom = 1;
					return Cursors.SizeNWSE;
				}
				else
				{
					return Cursors.SizeWE;
				}
			}
			else if (IsBetween(rect.Top, mouseLocation.Y))
			{
				rmp.Top = 1;
				return Cursors.SizeNS;
			}
			else if (IsBetween(rect.Bottom, mouseLocation.Y))
			{
				rmp.Bottom = 1;
				return Cursors.SizeNS;
			}

			return null;
		}

		static bool IsBetween(float edge, int value)
		{
			return value >= edge - 4 && value <= edge + 4;
		}

		public static string EnsureYoloExportPath(string path)
		{
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}

			return path;
		}

		public static void EnsureObjectNames(string dataPath, ClassName[] classes)
		{
			string namesFilename = Path.Combine(dataPath, "obj.names");

			File.WriteAllLines(namesFilename, classes.Select(x => x.Name).ToArray());

			string filename = Path.Combine(dataPath, "obj.data");

			string backup = Path.Combine(dataPath, "backup");

			if (!Directory.Exists(backup))
			{
				Directory.CreateDirectory(backup);
			}

			File.WriteAllLines(filename,
				new string[]
				{
					$"classes={classes.Length}",
					$"train={Path.Combine(dataPath, "train.txt")}",
					$"valid={Path.Combine(dataPath, "train.txt")}",
					$"names={namesFilename}",
					$"backup={backup}",
				});
		}

		public static void EnsureYoloYaml(string dataPath, string imagesPath, ClassName[] classes)
		{
			string filename = Path.Combine(dataPath, "config.yaml");

			File.WriteAllLines(filename,
				new string[]
				{
					$"path: {dataPath}",
					$"train: {imagesPath}",
					$"val: {imagesPath}",
					$"names:"
				}.Concat(classes.Select((x, y) => $"  {y}: {x.Name}")));
		}

		public static IEnumerable<string> EnsureImages(string imagesPath, ClassName[] classes, ImageInfo[] images, LoadingForm.LoadingState loadingState)
		{
			List<string> imagesUsed = new List<string>();

			foreach (var item in images)
			{
				if (loadingState.Aborted)
				{
					return default;
				}

				if (item.Marks != null)
				{
					imagesUsed.Add(Path.Combine(imagesPath, item.Name));

					List<string> markInfo = new List<string>();

					foreach (var mark in item.Marks)
					{
						markInfo.Add($"{Array.IndexOf(classes, mark.ClassName)} {mark.CenterX:0.000000} {mark.CenterY:0.000000} {mark.Width:0.000000} {mark.Height:0.000000}");
					}

					File.WriteAllLines(Path.Combine(imagesPath, Path.GetFileNameWithoutExtension(item.Name) + ".txt"), markInfo.ToArray());
				}
			}

			return imagesUsed;
		}
	}
}
