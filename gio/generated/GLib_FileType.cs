﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;
    using GStreamer;

    #region Autogenerated code
    [GLib.GType (typeof (GLib.FileTypeGType))]
	public enum FileType {

		Unknown,
		Regular,
		Directory,
		SymbolicLink,
		Special,
		Shortcut,
		Mountable,
	}

	internal class FileTypeGType {
		[DllImport (DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_file_type_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_file_type_get_type ());
			}
		}
	}
#endregion
}
