﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class Socks4aProxy : GLib.Object, GLib.IProxy {

		public Socks4aProxy (IntPtr raw) : base(raw) {}

		protected Socks4aProxy() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
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
		static extern IntPtr g_proxy_connect(IntPtr raw, IntPtr connection, IntPtr proxy_address, IntPtr cancellable, out IntPtr error);

		public GLib.IOStream Connect(GLib.IOStream connection, GLib.ProxyAddress proxy_address, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_proxy_connect(Handle, connection == null ? IntPtr.Zero : connection.Handle, proxy_address == null ? IntPtr.Zero : proxy_address.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			GLib.IOStream ret = GLib.Object.GetObject(raw_ret) as GLib.IOStream;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_proxy_connect_async(IntPtr raw, IntPtr connection, IntPtr proxy_address, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void ConnectAsync(GLib.IOStream connection, GLib.ProxyAddress proxy_address, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_proxy_connect_async(Handle, connection == null ? IntPtr.Zero : connection.Handle, proxy_address == null ? IntPtr.Zero : proxy_address.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_proxy_connect_finish(IntPtr raw, IntPtr result, out IntPtr error);

		public GLib.IOStream ConnectFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_proxy_connect_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			GLib.IOStream ret = GLib.Object.GetObject(raw_ret) as GLib.IOStream;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_proxy_supports_hostname(IntPtr raw);

		public bool SupportsHostname() {
			bool raw_ret = g_proxy_supports_hostname(Handle);
			bool ret = raw_ret;
			return ret;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("supports_hostname"
							, GLib.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(bool)) // supports_hostname
							, null
							, null
							, (long) Marshal.OffsetOf(typeof(GSocks4aProxy_supports_hostnameAlign), "supports_hostname")
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GSocks4aProxy_supports_hostnameAlign
		{
			sbyte f1;
			private bool supports_hostname;
		}


		// End of the ABI representation.

#endregion
	}
}
