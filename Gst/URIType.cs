﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.URITypeGType))]
	public enum URIType {

		Unknown = 0,
		Sink = 1,
		Src = 2,
	}

	internal class URITypeGType {
		[DllImport (DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_uri_type_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_uri_type_get_type ());
			}
		}
	}
#endregion
}
