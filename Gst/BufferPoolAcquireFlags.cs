﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.BufferPoolAcquireFlagsGType))]
	public enum BufferPoolAcquireFlags {

		None = 0,
		KeyUnit = 1,
		Dontwait = 2,
		Discont = 4,
		Last = 65536,
	}

	internal class BufferPoolAcquireFlagsGType {
		[DllImport (DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_pool_acquire_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_buffer_pool_acquire_flags_get_type ());
			}
		}
	}
#endregion
}
