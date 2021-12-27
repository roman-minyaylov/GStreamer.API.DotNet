﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class NetworkAddress : GLib.Object, GLib.ISocketConnectable {

		public NetworkAddress (IntPtr raw) : base(raw) {}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_network_address_new(IntPtr hostname, ushort port);

		public NetworkAddress (string hostname, ushort port) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (NetworkAddress)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("hostname");
				vals.Add (new GLib.Value (hostname));
				names.Add ("port");
				vals.Add (new GLib.Value (port));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_hostname = GLib.Marshaller.StringToPtrGStrdup (hostname);
			Raw = g_network_address_new(native_hostname, port);
			GLib.Marshaller.Free (native_hostname);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_network_address_new_loopback(ushort port);

		public NetworkAddress (ushort port) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (NetworkAddress)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("port");
				vals.Add (new GLib.Value (port));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = g_network_address_new_loopback(port);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_network_address_get_hostname(IntPtr raw);

		[GLib.Property ("hostname")]
		public string Hostname {
			get  {
				IntPtr raw_ret = g_network_address_get_hostname(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern ushort g_network_address_get_port(IntPtr raw);

		[GLib.Property ("port")]
		public ushort Port {
			get  {
				ushort raw_ret = g_network_address_get_port(Handle);
				ushort ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_network_address_get_scheme(IntPtr raw);

		[GLib.Property ("scheme")]
		public string Scheme {
			get  {
				IntPtr raw_ret = g_network_address_get_scheme(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (GLib.Object.class_abi.Fields);

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_network_address_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_network_address_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_network_address_parse(IntPtr host_and_port, ushort default_port, out IntPtr error);

		public static unsafe GLib.ISocketConnectable Parse(string host_and_port, ushort default_port) {
			IntPtr native_host_and_port = GLib.Marshaller.StringToPtrGStrdup (host_and_port);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_network_address_parse(native_host_and_port, default_port, out error);
			GLib.ISocketConnectable ret = GLib.SocketConnectableAdapter.GetObject (raw_ret, false);
			GLib.Marshaller.Free (native_host_and_port);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_network_address_parse_uri(IntPtr uri, ushort default_port, out IntPtr error);

		public static unsafe GLib.ISocketConnectable ParseUri(string uri, ushort default_port) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_network_address_parse_uri(native_uri, default_port, out error);
			GLib.ISocketConnectable ret = GLib.SocketConnectableAdapter.GetObject (raw_ret, false);
			GLib.Marshaller.Free (native_uri);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_socket_connectable_enumerate(IntPtr raw);

		public GLib.SocketAddressEnumerator Enumerate() {
			IntPtr raw_ret = g_socket_connectable_enumerate(Handle);
			GLib.SocketAddressEnumerator ret = GLib.Object.GetObject(raw_ret) as GLib.SocketAddressEnumerator;
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_socket_connectable_proxy_enumerate(IntPtr raw);

		public GLib.SocketAddressEnumerator ProxyEnumerate() {
			IntPtr raw_ret = g_socket_connectable_proxy_enumerate(Handle);
			GLib.SocketAddressEnumerator ret = GLib.Object.GetObject(raw_ret) as GLib.SocketAddressEnumerator;
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_socket_connectable_to_string(IntPtr raw);

		public override string ToString() {
			IntPtr raw_ret = g_socket_connectable_to_string(Handle);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
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
