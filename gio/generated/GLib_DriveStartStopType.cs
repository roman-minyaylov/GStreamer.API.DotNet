﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (GLib.DriveStartStopTypeGType))]
	public enum DriveStartStopType {

		Unknown,
		Shutdown,
		Network,
		Multidisk,
		Password,
	}

	internal class DriveStartStopTypeGType {
		[DllImport (DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_drive_start_stop_type_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_drive_start_stop_type_get_type ());
			}
		}
	}
#endregion
}
