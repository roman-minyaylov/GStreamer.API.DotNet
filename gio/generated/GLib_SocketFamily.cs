﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (GLib.SocketFamilyGType))]
	public enum SocketFamily {

		Invalid = 0,
		Unix = 1,
		Ipv4 = 2,
		Ipv6 = 10,
	}

	internal class SocketFamilyGType {
		[DllImport (DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_socket_family_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_socket_family_get_type ());
			}
		}
	}
#endregion
}
