﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class Application {

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_version(out uint major, out uint minor, out uint micro, out uint nano);

		public static void Version(out uint major, out uint minor, out uint micro, out uint nano) {
			gst_version(out major, out minor, out micro, out nano);
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_version_string();

		public static string VersionString() {
			IntPtr raw_ret = gst_version_string();
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

#endregion
	}
}
