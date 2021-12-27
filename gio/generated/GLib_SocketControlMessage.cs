﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class SocketControlMessage : GLib.Object {

		public SocketControlMessage (IntPtr raw) : base(raw) {}

		protected SocketControlMessage() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		static GetSizeNativeDelegate GetSize_cb_delegate;
		static GetSizeNativeDelegate GetSizeVMCallback {
			get {
				if (GetSize_cb_delegate == null)
					GetSize_cb_delegate = new GetSizeNativeDelegate (GetSize_cb);
				return GetSize_cb_delegate;
			}
		}

		static void OverrideGetSize (GLib.GType gtype)
		{
			OverrideGetSize (gtype, GetSizeVMCallback);
		}

		static void OverrideGetSize (GLib.GType gtype, GetSizeNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_size"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate UIntPtr GetSizeNativeDelegate (IntPtr inst);

		static UIntPtr GetSize_cb (IntPtr inst)
		{
			try {
				SocketControlMessage __obj = GLib.Object.GetObject (inst, false) as SocketControlMessage;
				ulong __result;
				__result = __obj.OnGetSize ();
				return new UIntPtr (__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.SocketControlMessage), ConnectionMethod="OverrideGetSize")]
		protected virtual ulong OnGetSize ()
		{
			return InternalGetSize ();
		}

		private ulong InternalGetSize ()
		{
			GetSizeNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("get_size"));
				unmanaged = (GetSizeNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GetSizeNativeDelegate));
			}
			if (unmanaged == null) return 0;

			UIntPtr __result = unmanaged (this.Handle);
			return (ulong) __result;
		}

		static GetLevelNativeDelegate GetLevel_cb_delegate;
		static GetLevelNativeDelegate GetLevelVMCallback {
			get {
				if (GetLevel_cb_delegate == null)
					GetLevel_cb_delegate = new GetLevelNativeDelegate (GetLevel_cb);
				return GetLevel_cb_delegate;
			}
		}

		static void OverrideGetLevel (GLib.GType gtype)
		{
			OverrideGetLevel (gtype, GetLevelVMCallback);
		}

		static void OverrideGetLevel (GLib.GType gtype, GetLevelNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_level"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetLevelNativeDelegate (IntPtr inst);

		static int GetLevel_cb (IntPtr inst)
		{
			try {
				SocketControlMessage __obj = GLib.Object.GetObject (inst, false) as SocketControlMessage;
				int __result;
				__result = __obj.OnGetLevel ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.SocketControlMessage), ConnectionMethod="OverrideGetLevel")]
		protected virtual int OnGetLevel ()
		{
			return InternalGetLevel ();
		}

		private int InternalGetLevel ()
		{
			GetLevelNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("get_level"));
				unmanaged = (GetLevelNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GetLevelNativeDelegate));
			}
			if (unmanaged == null) return 0;

			int __result = unmanaged (this.Handle);
			return __result;
		}

		static GetTypeNativeDelegate GetType_cb_delegate;
		static GetTypeNativeDelegate GetTypeVMCallback {
			get {
				if (GetType_cb_delegate == null)
					GetType_cb_delegate = new GetTypeNativeDelegate (GetType_cb);
				return GetType_cb_delegate;
			}
		}

		static void OverrideGetType (GLib.GType gtype)
		{
			OverrideGetType (gtype, GetTypeVMCallback);
		}

		static void OverrideGetType (GLib.GType gtype, GetTypeNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_type"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetTypeNativeDelegate (IntPtr inst);

		static int GetType_cb (IntPtr inst)
		{
			try {
				SocketControlMessage __obj = GLib.Object.GetObject (inst, false) as SocketControlMessage;
				int __result;
				__result = __obj.OnGetType ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.SocketControlMessage), ConnectionMethod="OverrideGetType")]
		protected virtual int OnGetType ()
		{
			return InternalGetType ();
		}

		private int InternalGetType ()
		{
			GetTypeNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("get_type"));
				unmanaged = (GetTypeNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GetTypeNativeDelegate));
			}
			if (unmanaged == null) return 0;

			int __result = unmanaged (this.Handle);
			return __result;
		}

		static SerializeNativeDelegate Serialize_cb_delegate;
		static SerializeNativeDelegate SerializeVMCallback {
			get {
				if (Serialize_cb_delegate == null)
					Serialize_cb_delegate = new SerializeNativeDelegate (Serialize_cb);
				return Serialize_cb_delegate;
			}
		}

		static void OverrideSerialize (GLib.GType gtype)
		{
			OverrideSerialize (gtype, SerializeVMCallback);
		}

		static void OverrideSerialize (GLib.GType gtype, SerializeNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("serialize"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SerializeNativeDelegate (IntPtr inst, IntPtr data);

		static void Serialize_cb (IntPtr inst, IntPtr data)
		{
			try {
				SocketControlMessage __obj = GLib.Object.GetObject (inst, false) as SocketControlMessage;
				__obj.OnSerialize (data);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.SocketControlMessage), ConnectionMethod="OverrideSerialize")]
		protected virtual void OnSerialize (IntPtr data)
		{
			InternalSerialize (data);
		}

		private void InternalSerialize (IntPtr data)
		{
			SerializeNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("serialize"));
				unmanaged = (SerializeNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(SerializeNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, data);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("get_size"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_size
							, null
							, "get_level"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("get_level"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_level
							, "get_size"
							, "get_type"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("get_type"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_type
							, "get_level"
							, "serialize"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("serialize"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // serialize
							, "get_type"
							, "deserialize"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("deserialize"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // deserialize
							, "serialize"
							, "_g_reserved1"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_g_reserved1"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _g_reserved1
							, "deserialize"
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
		static extern IntPtr g_socket_control_message_deserialize(int level, int type, UIntPtr size, IntPtr data);

		public static GLib.SocketControlMessage Deserialize(int level, int type, ulong size, IntPtr data) {
			IntPtr raw_ret = g_socket_control_message_deserialize(level, type, new UIntPtr (size), data);
			GLib.SocketControlMessage ret = GLib.Object.GetObject(raw_ret) as GLib.SocketControlMessage;
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern int g_socket_control_message_get_level(IntPtr raw);

		public int Level { 
			get {
				int raw_ret = g_socket_control_message_get_level(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern int g_socket_control_message_get_msg_type(IntPtr raw);

		public int MsgType { 
			get {
				int raw_ret = g_socket_control_message_get_msg_type(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern UIntPtr g_socket_control_message_get_size(IntPtr raw);

		public ulong Size { 
			get {
				UIntPtr raw_ret = g_socket_control_message_get_size(Handle);
				ulong ret = (ulong) raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_socket_control_message_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_socket_control_message_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_socket_control_message_serialize(IntPtr raw, IntPtr data);

		public void Serialize(IntPtr data) {
			g_socket_control_message_serialize(Handle, data);
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
