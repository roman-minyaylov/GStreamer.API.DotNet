﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class SocketConnection : GLib.IOStream {

		public SocketConnection (IntPtr raw) : base(raw) {}

		protected SocketConnection() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_socket_connection_get_socket(IntPtr raw);

		[GLib.Property ("socket")]
		public GLib.Socket Socket {
			get  {
				IntPtr raw_ret = g_socket_connection_get_socket(Handle);
				GLib.Socket ret = raw_ret == IntPtr.Zero ? null : (GLib.Socket) GLib.Opaque.GetOpaque (raw_ret, typeof (GLib.Socket), false);
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_g_reserved1"
							, GLib.IOStream.class_abi.Fields
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
		static extern unsafe bool g_socket_connection_connect(IntPtr raw, IntPtr address, IntPtr cancellable, out IntPtr error);

		public unsafe bool Connect(GLib.SocketAddress address, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_socket_connection_connect(Handle, address == null ? IntPtr.Zero : address.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_socket_connection_connect_async(IntPtr raw, IntPtr address, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void ConnectAsync(GLib.SocketAddress address, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_socket_connection_connect_async(Handle, address == null ? IntPtr.Zero : address.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool g_socket_connection_connect_finish(IntPtr raw, IntPtr result, out IntPtr error);

		public unsafe bool ConnectFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_socket_connection_connect_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_socket_connection_factory_create_connection(IntPtr socket);

		public static GLib.SocketConnection FactoryCreateConnection(GLib.Socket socket) {
			IntPtr raw_ret = g_socket_connection_factory_create_connection(socket == null ? IntPtr.Zero : socket.Handle);
			GLib.SocketConnection ret = GLib.Object.GetObject(raw_ret) as GLib.SocketConnection;
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_socket_connection_factory_lookup_type(int family, int type, int protocol_id);

		public static GLib.GType FactoryLookupType(GLib.SocketFamily family, GLib.SocketType type, int protocol_id) {
			IntPtr raw_ret = g_socket_connection_factory_lookup_type((int) family, (int) type, protocol_id);
			GLib.GType ret = new GLib.GType(raw_ret);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_socket_connection_factory_register_type(IntPtr g_type, int family, int type, int protocol);

		public static void FactoryRegisterType(GLib.GType g_type, GLib.SocketFamily family, GLib.SocketType type, int protocol) {
			g_socket_connection_factory_register_type(g_type.Val, (int) family, (int) type, protocol);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_socket_connection_get_local_address(IntPtr raw, out IntPtr error);

		public unsafe GLib.SocketAddress GetLocalAddress() {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_socket_connection_get_local_address(Handle, out error);
			GLib.SocketAddress ret = GLib.Object.GetObject(raw_ret) as GLib.SocketAddress;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_socket_connection_get_remote_address(IntPtr raw, out IntPtr error);

		public unsafe GLib.SocketAddress GetRemoteAddress() {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_socket_connection_get_remote_address(Handle, out error);
			GLib.SocketAddress ret = GLib.Object.GetObject(raw_ret) as GLib.SocketAddress;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_socket_connection_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_socket_connection_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_socket_connection_is_connected(IntPtr raw);

		public bool IsConnected { 
			get {
				bool raw_ret = g_socket_connection_is_connected(Handle);
				bool ret = raw_ret;
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
							, GLib.IOStream.abi_info.Fields
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
