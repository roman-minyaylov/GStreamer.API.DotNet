﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.PluginErrorGType))]
	public enum PluginError {

		Module = 0,
		Dependencies = 1,
		NameMismatch = 2,
	}

	internal class PluginErrorGType {
		[DllImport (DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_plugin_error_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_plugin_error_get_type ());
			}
		}
	}
#endregion
}
