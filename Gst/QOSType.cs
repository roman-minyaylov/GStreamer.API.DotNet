﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.QOSTypeGType))]
	public enum QOSType {

		Overflow = 0,
		Underflow = 1,
		Throttle = 2,
	}

	internal class QOSTypeGType {
		[DllImport (DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_qos_type_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_qos_type_get_type ());
			}
		}
	}
#endregion
}
