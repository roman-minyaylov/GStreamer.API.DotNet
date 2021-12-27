﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class FileMonitor : GLib.Object {

		public FileMonitor (IntPtr raw) : base(raw) {}

		protected FileMonitor() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_file_monitor_set_rate_limit(IntPtr raw, int limit_msecs);

		[GLib.Property ("rate-limit")]
		public int RateLimit {
			get {
				GLib.Value val = GetProperty ("rate-limit");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set  {
				g_file_monitor_set_rate_limit(Handle, value);
			}
		}

		[GLib.Property ("cancelled")]
		public bool Cancelled {
			get {
				GLib.Value val = GetProperty ("cancelled");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Signal("changed")]
		public event GLib.ChangedHandler Changed {
			add {
				this.AddSignalHandler ("changed", value, typeof (GLib.ChangedArgs));
			}
			remove {
				this.RemoveSignalHandler ("changed", value);
			}
		}

		static ChangedNativeDelegate Changed_cb_delegate;
		static ChangedNativeDelegate ChangedVMCallback {
			get {
				if (Changed_cb_delegate == null)
					Changed_cb_delegate = new ChangedNativeDelegate (Changed_cb);
				return Changed_cb_delegate;
			}
		}

		static void OverrideChanged (GLib.GType gtype)
		{
			OverrideChanged (gtype, ChangedVMCallback);
		}

		static void OverrideChanged (GLib.GType gtype, ChangedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("changed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ChangedNativeDelegate (IntPtr inst, IntPtr file, IntPtr other_file, int event_type);

		static void Changed_cb (IntPtr inst, IntPtr file, IntPtr other_file, int event_type)
		{
			try {
				FileMonitor __obj = GLib.Object.GetObject (inst, false) as FileMonitor;
				__obj.OnChanged (GLib.FileAdapter.GetObject (file, false), GLib.FileAdapter.GetObject (other_file, false), (GLib.FileMonitorEvent) event_type);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.FileMonitor), ConnectionMethod="OverrideChanged")]
		protected virtual void OnChanged (GLib.IFile file, GLib.IFile other_file, GLib.FileMonitorEvent event_type)
		{
			InternalChanged (file, other_file, event_type);
		}

		private void InternalChanged (GLib.IFile file, GLib.IFile other_file, GLib.FileMonitorEvent event_type)
		{
			ChangedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("changed"));
				unmanaged = (ChangedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ChangedNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, file == null ? IntPtr.Zero : ((file is GLib.Object) ? (file as GLib.Object).Handle : (file as GLib.FileAdapter).Handle), other_file == null ? IntPtr.Zero : ((other_file is GLib.Object) ? (other_file as GLib.Object).Handle : (other_file as GLib.FileAdapter).Handle), (int) event_type);
		}

		static CancelNativeDelegate Cancel_cb_delegate;
		static CancelNativeDelegate CancelVMCallback {
			get {
				if (Cancel_cb_delegate == null)
					Cancel_cb_delegate = new CancelNativeDelegate (Cancel_cb);
				return Cancel_cb_delegate;
			}
		}

		static void OverrideCancel (GLib.GType gtype)
		{
			OverrideCancel (gtype, CancelVMCallback);
		}

		static void OverrideCancel (GLib.GType gtype, CancelNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("cancel"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool CancelNativeDelegate (IntPtr inst);

		static bool Cancel_cb (IntPtr inst)
		{
			try {
				FileMonitor __obj = GLib.Object.GetObject (inst, false) as FileMonitor;
				bool __result;
				__result = __obj.OnCancel ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.FileMonitor), ConnectionMethod="OverrideCancel")]
		protected virtual bool OnCancel ()
		{
			return InternalCancel ();
		}

		private bool InternalCancel ()
		{
			CancelNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("cancel"));
				unmanaged = (CancelNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(CancelNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle);
			return __result;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("changed"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // changed
							, null
							, "cancel"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("cancel"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // cancel
							, "changed"
							, "_g_reserved1"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_g_reserved1"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _g_reserved1
							, "cancel"
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
		static extern bool g_file_monitor_cancel(IntPtr raw);

		public bool Cancel() {
			bool raw_ret = g_file_monitor_cancel(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_file_monitor_directory(IntPtr file, int flags, IntPtr cancellable, out IntPtr error);

		public static unsafe GLib.FileMonitor Directory(GLib.IFile file, GLib.FileMonitorFlags flags, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_file_monitor_directory(file == null ? IntPtr.Zero : ((file is GLib.Object) ? (file as GLib.Object).Handle : (file as GLib.FileAdapter).Handle), (int) flags, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			GLib.FileMonitor ret = GLib.Object.GetObject(raw_ret) as GLib.FileMonitor;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_file_monitor_emit_event(IntPtr raw, IntPtr child, IntPtr other_file, int event_type);

		public void EmitEvent(GLib.IFile child, GLib.IFile other_file, GLib.FileMonitorEvent event_type) {
			g_file_monitor_emit_event(Handle, child == null ? IntPtr.Zero : ((child is GLib.Object) ? (child as GLib.Object).Handle : (child as GLib.FileAdapter).Handle), other_file == null ? IntPtr.Zero : ((other_file is GLib.Object) ? (other_file as GLib.Object).Handle : (other_file as GLib.FileAdapter).Handle), (int) event_type);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_file_monitor_file(IntPtr file, int flags, IntPtr cancellable, out IntPtr error);

		public static unsafe GLib.FileMonitor File(GLib.IFile file, GLib.FileMonitorFlags flags, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_file_monitor_file(file == null ? IntPtr.Zero : ((file is GLib.Object) ? (file as GLib.Object).Handle : (file as GLib.FileAdapter).Handle), (int) flags, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			GLib.FileMonitor ret = GLib.Object.GetObject(raw_ret) as GLib.FileMonitor;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_file_monitor_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_file_monitor_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_file_monitor_is_cancelled(IntPtr raw);

		public bool IsCancelled { 
			get {
				bool raw_ret = g_file_monitor_is_cancelled(Handle);
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
