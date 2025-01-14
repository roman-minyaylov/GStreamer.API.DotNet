﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class InetAddress : GLib.Object {

		public InetAddress (IntPtr raw) : base(raw) {}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_inet_address_new_any(int family);

		public InetAddress (GLib.SocketFamily family) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (InetAddress)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("family");
				vals.Add (new GLib.Value (family));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = g_inet_address_new_any((int) family);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_inet_address_new_from_bytes(byte[] bytes, int family);

		public InetAddress (byte[] bytes, GLib.SocketFamily family) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (InetAddress)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("bytes");
				vals.Add (new GLib.Value (bytes));
				names.Add ("family");
				vals.Add (new GLib.Value (family));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = g_inet_address_new_from_bytes(bytes, (int) family);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_inet_address_new_from_string(IntPtr str1ng);

		public InetAddress (string str1ng) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (InetAddress)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_str1ng = GLib.Marshaller.StringToPtrGStrdup (str1ng);
			Raw = g_inet_address_new_from_string(native_str1ng);
			GLib.Marshaller.Free (native_str1ng);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_inet_address_new_loopback(int family);

		public static InetAddress NewLoopback(GLib.SocketFamily family)
		{
			InetAddress result = new InetAddress (g_inet_address_new_loopback((int) family));
			return result;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern int g_inet_address_get_family(IntPtr raw);

		[GLib.Property ("family")]
		public GLib.SocketFamily Family {
			get  {
				int raw_ret = g_inet_address_get_family(Handle);
				GLib.SocketFamily ret = (GLib.SocketFamily) raw_ret;
				return ret;
			}
		}

		[GLib.Property ("bytes")]
		public IntPtr Bytes {
			get {
				GLib.Value val = GetProperty ("bytes");
				IntPtr ret = (IntPtr) val;
				val.Dispose ();
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_inet_address_get_is_any(IntPtr raw);

		[GLib.Property ("is-any")]
		public bool IsAny {
			get  {
				bool raw_ret = g_inet_address_get_is_any(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_inet_address_get_is_link_local(IntPtr raw);

		[GLib.Property ("is-link-local")]
		public bool IsLinkLocal {
			get  {
				bool raw_ret = g_inet_address_get_is_link_local(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_inet_address_get_is_loopback(IntPtr raw);

		[GLib.Property ("is-loopback")]
		public bool IsLoopback {
			get  {
				bool raw_ret = g_inet_address_get_is_loopback(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_inet_address_get_is_site_local(IntPtr raw);

		[GLib.Property ("is-site-local")]
		public bool IsSiteLocal {
			get  {
				bool raw_ret = g_inet_address_get_is_site_local(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_inet_address_get_is_multicast(IntPtr raw);

		[GLib.Property ("is-multicast")]
		public bool IsMulticast {
			get  {
				bool raw_ret = g_inet_address_get_is_multicast(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_inet_address_get_is_mc_global(IntPtr raw);

		[GLib.Property ("is-mc-global")]
		public bool IsMcGlobal {
			get  {
				bool raw_ret = g_inet_address_get_is_mc_global(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_inet_address_get_is_mc_link_local(IntPtr raw);

		[GLib.Property ("is-mc-link-local")]
		public bool IsMcLinkLocal {
			get  {
				bool raw_ret = g_inet_address_get_is_mc_link_local(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_inet_address_get_is_mc_node_local(IntPtr raw);

		[GLib.Property ("is-mc-node-local")]
		public bool IsMcNodeLocal {
			get  {
				bool raw_ret = g_inet_address_get_is_mc_node_local(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_inet_address_get_is_mc_org_local(IntPtr raw);

		[GLib.Property ("is-mc-org-local")]
		public bool IsMcOrgLocal {
			get  {
				bool raw_ret = g_inet_address_get_is_mc_org_local(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_inet_address_get_is_mc_site_local(IntPtr raw);

		[GLib.Property ("is-mc-site-local")]
		public bool IsMcSiteLocal {
			get  {
				bool raw_ret = g_inet_address_get_is_mc_site_local(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		static ToStringNativeDelegate ToString_cb_delegate;
		static ToStringNativeDelegate ToStringVMCallback {
			get {
				if (ToString_cb_delegate == null)
					ToString_cb_delegate = new ToStringNativeDelegate (ToString_cb);
				return ToString_cb_delegate;
			}
		}

		static void OverrideToString (GLib.GType gtype)
		{
			OverrideToString (gtype, ToStringVMCallback);
		}

		static void OverrideToString (GLib.GType gtype, ToStringNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("to_string"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr ToStringNativeDelegate (IntPtr inst);

		static IntPtr ToString_cb (IntPtr inst)
		{
			try {
				InetAddress __obj = GLib.Object.GetObject (inst, false) as InetAddress;
				string __result;
				__result = __obj.OnToString ();
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.InetAddress), ConnectionMethod="OverrideToString")]
		protected virtual string OnToString ()
		{
			return InternalToString ();
		}

		private string InternalToString ()
		{
			ToStringNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("to_string"));
				unmanaged = (ToStringNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ToStringNativeDelegate));
			}
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle);
			return GLib.Marshaller.PtrToStringGFree(__result);
		}

		static ToBytesNativeDelegate ToBytes_cb_delegate;
		static ToBytesNativeDelegate ToBytesVMCallback {
			get {
				if (ToBytes_cb_delegate == null)
					ToBytes_cb_delegate = new ToBytesNativeDelegate (ToBytes_cb);
				return ToBytes_cb_delegate;
			}
		}

		static void OverrideToBytes (GLib.GType gtype)
		{
			OverrideToBytes (gtype, ToBytesVMCallback);
		}

		static void OverrideToBytes (GLib.GType gtype, ToBytesNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("to_bytes"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate byte ToBytesNativeDelegate (IntPtr inst);

		static byte ToBytes_cb (IntPtr inst)
		{
			try {
				InetAddress __obj = GLib.Object.GetObject (inst, false) as InetAddress;
				byte __result;
				__result = __obj.OnToBytes ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.InetAddress), ConnectionMethod="OverrideToBytes")]
		protected virtual byte OnToBytes ()
		{
			return InternalToBytes ();
		}

		private byte InternalToBytes ()
		{
			ToBytesNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("to_bytes"));
				unmanaged = (ToBytesNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ToBytesNativeDelegate));
			}
			if (unmanaged == null) return 0;

			byte __result = unmanaged (this.Handle);
			return __result;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("to_string"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // to_string
							, null
							, "to_bytes"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("to_bytes"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // to_bytes
							, "to_string"
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
		static extern bool g_inet_address_equal(IntPtr raw, IntPtr other_address);

		public bool Equal(GLib.InetAddress other_address) {
			bool raw_ret = g_inet_address_equal(Handle, other_address == null ? IntPtr.Zero : other_address.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern UIntPtr g_inet_address_get_native_size(IntPtr raw);

		public ulong NativeSize { 
			get {
				UIntPtr raw_ret = g_inet_address_get_native_size(Handle);
				ulong ret = (ulong) raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_inet_address_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_inet_address_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern byte g_inet_address_to_bytes(IntPtr raw);

		public byte ToBytes() {
			byte raw_ret = g_inet_address_to_bytes(Handle);
			byte ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_inet_address_to_string(IntPtr raw);

		public override string ToString() {
			IntPtr raw_ret = g_inet_address_to_string(Handle);
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
