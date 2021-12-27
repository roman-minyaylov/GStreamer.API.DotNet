﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class IOExtension : GLib.Opaque {

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_io_extension_get_name(IntPtr raw);

		public string Name { 
			get {
				IntPtr raw_ret = g_io_extension_get_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern int g_io_extension_get_priority(IntPtr raw);

		public int Priority { 
			get {
				int raw_ret = g_io_extension_get_priority(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_io_extension_get_type(IntPtr raw);

		public GLib.GType GType { 
			get {
				IntPtr raw_ret = g_io_extension_get_type(Handle);
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		public IOExtension(IntPtr raw) : base(raw) {}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}