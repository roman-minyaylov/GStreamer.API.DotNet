﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (GLib.DataStreamNewlineTypeGType))]
	public enum DataStreamNewlineType {

		Lf,
		Cr,
		CrLf,
		Any,
	}

	internal class DataStreamNewlineTypeGType {
		[DllImport (DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_data_stream_newline_type_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_data_stream_newline_type_get_type ());
			}
		}
	}
#endregion
}
