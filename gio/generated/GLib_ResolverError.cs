﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (GLib.ResolverErrorGType))]
	public enum ResolverError {

		NotFound,
		TemporaryFailure,
		Internal,
	}

	internal class ResolverErrorGType {
		[DllImport (DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_resolver_error_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_resolver_error_get_type ());
			}
		}
	}
#endregion
}
