﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[Flags]
	[GLib.GType (typeof (GLib.SettingsBindFlagsGType))]
	public enum SettingsBindFlags {

		Default,
		Get = 1 << 0,
		Set = 1 << 1,
		NoSensitivity = 1 << 2,
		GetNoChanges = 1 << 3,
		InvertBoolean = 1 << 4,
	}

	internal class SettingsBindFlagsGType {
		[DllImport (DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_settings_bind_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_settings_bind_flags_get_type ());
			}
		}
	}
#endregion
}
