﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.StackTraceFlagsGType))]
	public enum StackTraceFlags {

		None = 0,
		Full = 1,
	}

	internal class StackTraceFlagsGType {
		[DllImport (DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_stack_trace_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_stack_trace_flags_get_type ());
			}
		}
	}
#endregion
}
