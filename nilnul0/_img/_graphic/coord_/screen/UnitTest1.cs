using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using static nilnul._img_._TEST_.nilnul0._img._graphic.coord_.screen.NativeMethods;

namespace nilnul._img_._TEST_.nilnul0._img._graphic.coord_.screen
{

	public static class NativeMethods
	{
		public const Int32 MONITOR_DEFAULTTOPRIMERTY = 0x00000001;
		public const Int32 MONITOR_DEFAULTTONEAREST = 0x00000002;


		[DllImport("user32.dll")]
		public static extern IntPtr MonitorFromWindow(IntPtr handle, Int32 flags);


		[DllImport("user32.dll")]
		public static extern Boolean GetMonitorInfo(IntPtr hMonitor, NativeMonitorInfo lpmi);


		[Serializable, StructLayout(LayoutKind.Sequential)]
		public struct NativeRectangle
		{
			public Int32 Left;
			public Int32 Top;
			public Int32 Right;
			public Int32 Bottom;


			public NativeRectangle(Int32 left, Int32 top, Int32 right, Int32 bottom)
			{
				this.Left = left;
				this.Top = top;
				this.Right = right;
				this.Bottom = bottom;
			}
		}


		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		public sealed class NativeMonitorInfo
		{
			public Int32 Size = Marshal.SizeOf(typeof(NativeMonitorInfo));
			public NativeRectangle Monitor;
			public NativeRectangle Work;
			public Int32 Flags;
		}
	}


	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var hwnd = new WindowInteropHelper(this).EnsureHandle();
			var monitor = NativeMethods.MonitorFromWindow(hwnd, NativeMethods.MONITOR_DEFAULTTONEAREST);

			if (monitor != IntPtr.Zero)
			{
				var monitorInfo = new NativeMonitorInfo();
				NativeMethods.GetMonitorInfo(monitor, monitorInfo);

				var left = monitorInfo.Monitor.Left;
				var top = monitorInfo.Monitor.Top;
				var width = (monitorInfo.Monitor.Right - monitorInfo.Monitor.Left);
				var height = (monitorInfo.Monitor.Bottom - monitorInfo.Monitor.Top);
			}
		}
	}
}
