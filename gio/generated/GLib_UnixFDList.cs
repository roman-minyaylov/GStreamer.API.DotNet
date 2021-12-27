﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class UnixFDList : GLib.Object {

		public UnixFDList (IntPtr raw) : base(raw) {}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_unix_fd_list_new();

		public UnixFDList () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (UnixFDList)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = g_unix_fd_list_new();
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_g_reserved1"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _g_reserved1
							, null
							, "_g_reserved2"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_g_reserved2"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _g_reserved2
							, "_g_reserved1"
							, "_g_reserved3"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_g_reserved3"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _g_reserved3
							, "_g_reserved2"
							, "_g_reserved4"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_g_reserved4"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _g_reserved4
							, "_g_reserved3"
							, "_g_reserved5"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_g_reserved5"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _g_reserved5
							, "_g_reserved4"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe int g_unix_fd_list_append(IntPtr raw, int fd, out IntPtr error);

		public unsafe int Append(int fd) {
			IntPtr error = IntPtr.Zero;
			int raw_ret = g_unix_fd_list_append(Handle, fd, out error);
			int ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe int g_unix_fd_list_get(IntPtr raw, int index_, out IntPtr error);

		public unsafe int Get(int index_) {
			IntPtr error = IntPtr.Zero;
			int raw_ret = g_unix_fd_list_get(Handle, index_, out error);
			int ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern int g_unix_fd_list_get_length(IntPtr raw);

		public int Length { 
			get {
				int raw_ret = g_unix_fd_list_get_length(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_unix_fd_list_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_unix_fd_list_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern int g_unix_fd_list_peek_fds(IntPtr raw, out int length);

		public int PeekFds(out int length) {
			int raw_ret = g_unix_fd_list_peek_fds(Handle, out length);
			int ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern int g_unix_fd_list_steal_fds(IntPtr raw, out int length);

		public int StealFds(out int length) {
			int raw_ret = g_unix_fd_list_steal_fds(Handle, out length);
			int ret = raw_ret;
			return ret;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GLib.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
