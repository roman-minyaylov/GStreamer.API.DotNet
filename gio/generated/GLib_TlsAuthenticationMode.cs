﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (GLib.TlsAuthenticationModeGType))]
	public enum TlsAuthenticationMode {

		None,
		Requested,
		Required,
	}

	internal class TlsAuthenticationModeGType {
		[DllImport (DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_tls_authentication_mode_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_tls_authentication_mode_get_type ());
			}
		}
	}
#endregion
}