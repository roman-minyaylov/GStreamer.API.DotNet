﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (GLib.NetworkConnectivityGType))]
	public enum NetworkConnectivity {

		Local = 1,
		Limited = 2,
		Portal = 3,
		Full = 4,
	}

	internal class NetworkConnectivityGType {
		[DllImport (DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_network_connectivity_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_network_connectivity_get_type ());
			}
		}
	}
#endregion
}
