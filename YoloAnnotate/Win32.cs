using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace YoloAnnotate
{
	unsafe static class Win32
	{
		[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true, EntryPoint = "IsWindowVisible")]
		public static extern bool IsWindowVisible(IntPtr hWnd);

		public const uint GW_OWNER = 4;

		[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true, EntryPoint = "GetWindow")]
		public static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate bool WNDENUMPROC(IntPtr hwnd, IntPtr lParam);

		[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true, EntryPoint = "EnumWindows")]
		public static extern bool EnumWindows([MarshalAs(UnmanagedType.FunctionPtr)] WNDENUMPROC lpEnumFunc, IntPtr lParam);

		public static void EnumWindows(Action<IntPtr> action)
		{
			EnumWindows((a, b) => { action(a); return true; }, IntPtr.Zero);
		}

		public static bool IsMainWindow(IntPtr hWnd)
		{
			return GetWindow(hWnd, GW_OWNER) == IntPtr.Zero && IsWindowVisible(hWnd);
		}

		[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true, EntryPoint = "GetWindowTextLengthW")]
		public static extern int GetWindowTextLength(IntPtr hWnd);

		[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true, EntryPoint = "GetWindowTextW")]
		public static extern int GetWindowText(IntPtr hWnd, char* lpString, int nMaxCount);

		public static string GetWindowText(IntPtr hWnd)
		{
			int num = GetWindowTextLength(hWnd);

			fixed (char* c = new char[num + 1])
			{
				return new string(c, 0, GetWindowText(hWnd, c, num + 1));
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct RECT
		{
			public int left;
			public int top;
			public int right;
			public int bottom;
		}

		[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true, EntryPoint = "GetWindowRect")]
		public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

		[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true, EntryPoint = "GetClientRect")]
		public static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);

		public const int GCL_HICONSM = (-34);
		public const int GCL_HICON = (-14);

		public const uint ICON_SMALL = 0;
		public const uint ICON_BIG = 1;
		public const uint ICON_SMALL2 = 2;

		public const uint WM_GETICON = 0x007F;

		[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true, EntryPoint = "GetClassLongW")]
		static extern int GetClassLongPtr32(IntPtr hWnd, int nIndex);

		[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true, EntryPoint = "GetClassLongPtrW")]
		static extern IntPtr GetClassLongPtr64(IntPtr hWnd, int nIndex);

		public static IntPtr GetClassLong(IntPtr hWnd, int nIndex)
		{
			if (IntPtr.Size == sizeof(int))
			{
				return (IntPtr)GetClassLongPtr32(hWnd, nIndex);
			}
			else
			{
				return GetClassLongPtr64(hWnd, nIndex);
			}
		}

		[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true, EntryPoint = "SendMessageW")]
		public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

		public static Icon GetAppIcon(IntPtr hwnd)
		{
			IntPtr hIcon = SendMessage(hwnd, WM_GETICON, (IntPtr)ICON_SMALL2, 0);

			if (hIcon == IntPtr.Zero)
			{
				hIcon = SendMessage(hwnd, WM_GETICON, (IntPtr)ICON_SMALL, 0);

				if (hIcon == IntPtr.Zero)
				{
					hIcon = SendMessage(hwnd, WM_GETICON, (IntPtr)ICON_BIG, 0);

					if (hIcon == IntPtr.Zero)
					{
						hIcon = GetClassLong(hwnd, GCL_HICON);

						if (hIcon == IntPtr.Zero)
						{
							hIcon = GetClassLong(hwnd, GCL_HICONSM);

							if (hIcon == IntPtr.Zero)
							{
								return null;
							}
						}
					}
				}
			}

			return Icon.FromHandle(hIcon);
		}
				
		[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true, EntryPoint = "PrintWindow")]
		public static extern bool PrintWindow(IntPtr hwnd, IntPtr hdcBlt, uint nFlags);

		public const uint PW_CLIENTONLY = 0x00000001;
		public const uint PW_RENDERFULLCONTENT = 0x00000002;
	}
}
