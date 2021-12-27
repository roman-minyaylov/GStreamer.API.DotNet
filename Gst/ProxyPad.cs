﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class ProxyPad : Gst.Pad {

		public ProxyPad (IntPtr raw) : base(raw) {}

		protected ProxyPad() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gst_reserved"
							, Gst.Pad.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 1 // _gst_reserved
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_proxy_pad_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_proxy_pad_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_proxy_pad_chain_default(IntPtr pad, IntPtr parent, IntPtr buffer);

		public static Gst.FlowReturn ChainDefault(Gst.Pad pad, Gst.Object parent, Gst.Buffer buffer) {
			buffer.Owned = false;
			int raw_ret = gst_proxy_pad_chain_default(pad == null ? IntPtr.Zero : pad.Handle, parent == null ? IntPtr.Zero : parent.Handle, buffer == null ? IntPtr.Zero : buffer.Handle);
			Gst.FlowReturn ret = (Gst.FlowReturn) raw_ret;
			return ret;
		}

		public static Gst.FlowReturn ChainDefault(Gst.Pad pad, Gst.Buffer buffer) {
			return ChainDefault (pad, null, buffer);
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_proxy_pad_chain_list_default(IntPtr pad, IntPtr parent, IntPtr list);

		public static Gst.FlowReturn ChainListDefault(Gst.Pad pad, Gst.Object parent, Gst.BufferList list) {
			list.Owned = false;
			int raw_ret = gst_proxy_pad_chain_list_default(pad == null ? IntPtr.Zero : pad.Handle, parent == null ? IntPtr.Zero : parent.Handle, list == null ? IntPtr.Zero : list.Handle);
			Gst.FlowReturn ret = (Gst.FlowReturn) raw_ret;
			return ret;
		}

		public static Gst.FlowReturn ChainListDefault(Gst.Pad pad, Gst.BufferList list) {
			return ChainListDefault (pad, null, list);
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_proxy_pad_getrange_default(IntPtr pad, IntPtr parent, ulong offset, uint size, out IntPtr buffer);

		public static Gst.FlowReturn GetrangeDefault(Gst.Pad pad, Gst.Object parent, ulong offset, uint size, out Gst.Buffer buffer) {
			IntPtr native_buffer;
			int raw_ret = gst_proxy_pad_getrange_default(pad == null ? IntPtr.Zero : pad.Handle, parent == null ? IntPtr.Zero : parent.Handle, offset, size, out native_buffer);
			Gst.FlowReturn ret = (Gst.FlowReturn) raw_ret;
			buffer = native_buffer == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (native_buffer, typeof (Gst.Buffer), true);
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_proxy_pad_iterate_internal_links_default(IntPtr pad, IntPtr parent);

		public static Gst.Iterator IterateInternalLinksDefault(Gst.Pad pad, Gst.Object parent) {
			IntPtr raw_ret = gst_proxy_pad_iterate_internal_links_default(pad == null ? IntPtr.Zero : pad.Handle, parent == null ? IntPtr.Zero : parent.Handle);
			Gst.Iterator ret = raw_ret == IntPtr.Zero ? null : (Gst.Iterator) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Iterator), true);
			return ret;
		}

		public static Gst.Iterator IterateInternalLinksDefault(Gst.Pad pad) {
			return IterateInternalLinksDefault (pad, null);
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_proxy_pad_get_internal(IntPtr raw);

		public Gst.ProxyPad Internal { 
			get {
				IntPtr raw_ret = gst_proxy_pad_get_internal(Handle);
				Gst.ProxyPad ret = GLib.Object.GetObject(raw_ret, true) as Gst.ProxyPad;
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gst.Pad.abi_info.Fields
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
