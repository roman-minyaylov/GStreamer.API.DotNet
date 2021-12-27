﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class ProxyAddressEnumerator : GLib.SocketAddressEnumerator {

		public ProxyAddressEnumerator (IntPtr raw) : base(raw) {}

		protected ProxyAddressEnumerator() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("uri")]
		public string Uri {
			get {
				GLib.Value val = GetProperty ("uri");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("default-port")]
		public uint DefaultPort {
			get {
				GLib.Value val = GetProperty ("default-port");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("connectable")]
		public GLib.ISocketConnectable Connectable {
			get {
				GLib.Value val = GetProperty ("connectable");
				GLib.ISocketConnectable ret = GLib.SocketConnectableAdapter.GetObject ((GLib.Object) val);
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("proxy-resolver")]
		public GLib.IProxyResolver ProxyResolver {
			get {
				GLib.Value val = GetProperty ("proxy-resolver");
				GLib.IProxyResolver ret = GLib.ProxyResolverAdapter.GetObject ((GLib.Object) val);
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("proxy-resolver", val);
				val.Dispose ();
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_g_reserved1"
							, GLib.SocketAddressEnumerator.class_abi.Fields
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
							, "_g_reserved6"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_g_reserved6"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _g_reserved6
							, "_g_reserved5"
							, "_g_reserved7"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_g_reserved7"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _g_reserved7
							, "_g_reserved6"
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
		static extern IntPtr g_proxy_address_enumerator_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_proxy_address_enumerator_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
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
							, GLib.SocketAddressEnumerator.abi_info.Fields
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