﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.QueryTypeGType))]
	public enum QueryType {

		Unknown = 0,
		Position = 2563,
		Duration = 5123,
		Latency = 7683,
		Jitter = 10243,
		Rate = 12803,
		Seeking = 15363,
		Segment = 17923,
		Convert = 20483,
		Formats = 23043,
		Buffering = 28163,
		Custom = 30723,
		Uri = 33283,
		Allocation = 35846,
		Scheduling = 38401,
		AcceptCaps = 40963,
		Caps = 43523,
		Drain = 46086,
		Context = 48643,
		Bitrate = 51202,
	}

	internal class QueryTypeGType {
		[DllImport (DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_query_type_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_query_type_get_type ());
			}
		}
	}
#endregion
}
