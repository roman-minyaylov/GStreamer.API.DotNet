﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.BusSyncReplyGType))]
	public enum BusSyncReply {

		Drop = 0,
		Pass = 1,
		Async = 2,
	}

	internal class BusSyncReplyGType {
		[DllImport (DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_bus_sync_reply_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_bus_sync_reply_get_type ());
			}
		}
	}
#endregion
}
