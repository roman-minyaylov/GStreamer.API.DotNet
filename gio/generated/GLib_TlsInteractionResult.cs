﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (GLib.TlsInteractionResultGType))]
	public enum TlsInteractionResult {

		Unhandled,
		Handled,
		Failed,
	}

	internal class TlsInteractionResultGType {
		[DllImport (DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_tls_interaction_result_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_tls_interaction_result_get_type ());
			}
		}
	}
#endregion
}
