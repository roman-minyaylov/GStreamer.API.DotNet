﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class SimpleProxyResolver : GLib.Object, GLib.IProxyResolver {

		public SimpleProxyResolver (IntPtr raw) : base(raw) {}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_simple_proxy_resolver_new(IntPtr default_proxy, IntPtr ignore_hosts);

		public SimpleProxyResolver (string default_proxy, string ignore_hosts) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (SimpleProxyResolver)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("default_proxy");
				vals.Add (new GLib.Value (default_proxy));
				names.Add ("ignore_hosts");
				vals.Add (new GLib.Value (ignore_hosts));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_default_proxy = GLib.Marshaller.StringToPtrGStrdup (default_proxy);
			Raw = g_simple_proxy_resolver_new(native_default_proxy, GLib.Marshaller.StringToPtrGStrdup(ignore_hosts));
			GLib.Marshaller.Free (native_default_proxy);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_simple_proxy_resolver_set_default_proxy(IntPtr raw, IntPtr default_proxy);

		[GLib.Property ("default-proxy")]
		public string DefaultProxy {
			get {
				GLib.Value val = GetProperty ("default-proxy");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				g_simple_proxy_resolver_set_default_proxy(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_simple_proxy_resolver_set_ignore_hosts(IntPtr raw, IntPtr ignore_hosts);

		[GLib.Property ("ignore-hosts")]
		public string IgnoreHosts {
			get {
				GLib.Value val = GetProperty ("ignore-hosts");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set  {
				g_simple_proxy_resolver_set_ignore_hosts(Handle, GLib.Marshaller.StringToPtrGStrdup(value));
			}
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
		static extern IntPtr g_simple_proxy_resolver_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_simple_proxy_resolver_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_simple_proxy_resolver_set_uri_proxy(IntPtr raw, IntPtr uri_scheme, IntPtr proxy);

		public void SetUriProxy(string uri_scheme, string proxy) {
			IntPtr native_uri_scheme = GLib.Marshaller.StringToPtrGStrdup (uri_scheme);
			IntPtr native_proxy = GLib.Marshaller.StringToPtrGStrdup (proxy);
			g_simple_proxy_resolver_set_uri_proxy(Handle, native_uri_scheme, native_proxy);
			GLib.Marshaller.Free (native_uri_scheme);
			GLib.Marshaller.Free (native_proxy);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_proxy_resolver_is_supported(IntPtr raw);

		public bool IsSupported { 
			get {
				bool raw_ret = g_proxy_resolver_is_supported(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_proxy_resolver_lookup(IntPtr raw, IntPtr uri, IntPtr cancellable, out IntPtr error);

		public string Lookup(string uri, GLib.Cancellable cancellable) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_proxy_resolver_lookup(Handle, native_uri, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_uri);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_proxy_resolver_lookup_async(IntPtr raw, IntPtr uri, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void LookupAsync(string uri, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_proxy_resolver_lookup_async(Handle, native_uri, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
			GLib.Marshaller.Free (native_uri);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_proxy_resolver_lookup_finish(IntPtr raw, IntPtr result, out IntPtr error);

		public string LookupFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_proxy_resolver_lookup_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
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