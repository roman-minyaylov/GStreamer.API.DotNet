﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (GLib.FilesystemPreviewTypeGType))]
	public enum FilesystemPreviewType {

		IfAlways,
		IfLocal,
		Never,
	}

	internal class FilesystemPreviewTypeGType {
		[DllImport (DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_filesystem_preview_type_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_filesystem_preview_type_get_type ());
			}
		}
	}
#endregion
}
