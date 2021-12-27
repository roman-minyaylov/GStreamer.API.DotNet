﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[Flags]
	[GLib.GType (typeof (GLib.TlsCertificateFlagsGType))]
	public enum TlsCertificateFlags {

		UnknownCa = 1 << 0,
		BadIdentity = 1 << 1,
		NotActivated = 1 << 2,
		Expired = 1 << 3,
		Revoked = 1 << 4,
		Insecure = 1 << 5,
		GenericError = 1 << 6,
		ValidateAll = 0x007f,
	}

	internal class TlsCertificateFlagsGType {
		[DllImport (DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_tls_certificate_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_tls_certificate_flags_get_type ());
			}
		}
	}
#endregion
}
