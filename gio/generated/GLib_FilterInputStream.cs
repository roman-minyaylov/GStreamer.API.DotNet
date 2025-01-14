﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class FilterInputStream : GLib.InputStream {

		public FilterInputStream (IntPtr raw) : base(raw) {}

		protected FilterInputStream() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_filter_input_stream_get_base_stream(IntPtr raw);

		[GLib.Property ("base-stream")]
		public GLib.InputStream BaseStream {
			get  {
				IntPtr raw_ret = g_filter_input_stream_get_base_stream(Handle);
				GLib.InputStream ret = GLib.Object.GetObject(raw_ret) as GLib.InputStream;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_filter_input_stream_get_close_base_stream(IntPtr raw);

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_filter_input_stream_set_close_base_stream(IntPtr raw, bool close_base);

		[GLib.Property ("close-base-stream")]
		public bool CloseBaseStream {
			get  {
				bool raw_ret = g_filter_input_stream_get_close_base_stream(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				g_filter_input_stream_set_close_base_stream(Handle, value);
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_g_reserved1"
							, GLib.InputStream.class_abi.Fields
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
		static extern IntPtr g_filter_input_stream_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_filter_input_stream_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (GLib.InputStream.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
