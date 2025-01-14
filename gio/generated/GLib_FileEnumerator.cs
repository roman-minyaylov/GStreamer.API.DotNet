﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class FileEnumerator : GLib.Object {

		public FileEnumerator (IntPtr raw) : base(raw) {}

		protected FileEnumerator() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		static NextFileNativeDelegate NextFile_cb_delegate;
		static NextFileNativeDelegate NextFileVMCallback {
			get {
				if (NextFile_cb_delegate == null)
					NextFile_cb_delegate = new NextFileNativeDelegate (NextFile_cb);
				return NextFile_cb_delegate;
			}
		}

		static void OverrideNextFile (GLib.GType gtype)
		{
			OverrideNextFile (gtype, NextFileVMCallback);
		}

		static void OverrideNextFile (GLib.GType gtype, NextFileNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("next_file"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr NextFileNativeDelegate (IntPtr inst, IntPtr cancellable, out IntPtr error);

		static IntPtr NextFile_cb (IntPtr inst, IntPtr cancellable, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				FileEnumerator __obj = GLib.Object.GetObject (inst, false) as FileEnumerator;
				GLib.FileInfo __result;
				__result = __obj.OnNextFile (GLib.Object.GetObject(cancellable) as GLib.Cancellable);
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.FileEnumerator), ConnectionMethod="OverrideNextFile")]
		protected virtual GLib.FileInfo OnNextFile (GLib.Cancellable cancellable)
		{
			return InternalNextFile (cancellable);
		}

		private GLib.FileInfo InternalNextFile (GLib.Cancellable cancellable)
		{
			NextFileNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("next_file"));
				unmanaged = (NextFileNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(NextFileNativeDelegate));
			}
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr error = IntPtr.Zero;
			IntPtr __result = unmanaged (this.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			return GLib.Object.GetObject(__result) as GLib.FileInfo;
		}

		static CloseFnNativeDelegate CloseFn_cb_delegate;
		static CloseFnNativeDelegate CloseFnVMCallback {
			get {
				if (CloseFn_cb_delegate == null)
					CloseFn_cb_delegate = new CloseFnNativeDelegate (CloseFn_cb);
				return CloseFn_cb_delegate;
			}
		}

		static void OverrideCloseFn (GLib.GType gtype)
		{
			OverrideCloseFn (gtype, CloseFnVMCallback);
		}

		static void OverrideCloseFn (GLib.GType gtype, CloseFnNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("close_fn"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool CloseFnNativeDelegate (IntPtr inst, IntPtr cancellable, out IntPtr error);

		static bool CloseFn_cb (IntPtr inst, IntPtr cancellable, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				FileEnumerator __obj = GLib.Object.GetObject (inst, false) as FileEnumerator;
				bool __result;
				__result = __obj.OnCloseFn (GLib.Object.GetObject(cancellable) as GLib.Cancellable);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.FileEnumerator), ConnectionMethod="OverrideCloseFn")]
		protected virtual bool OnCloseFn (GLib.Cancellable cancellable)
		{
			return InternalCloseFn (cancellable);
		}

		private bool InternalCloseFn (GLib.Cancellable cancellable)
		{
			CloseFnNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("close_fn"));
				unmanaged = (CloseFnNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(CloseFnNativeDelegate));
			}
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr error = IntPtr.Zero;
			bool __result = unmanaged (this.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			return __result;
		}

		static NextFilesAsyncNativeDelegate NextFilesAsync_cb_delegate;
		static NextFilesAsyncNativeDelegate NextFilesAsyncVMCallback {
			get {
				if (NextFilesAsync_cb_delegate == null)
					NextFilesAsync_cb_delegate = new NextFilesAsyncNativeDelegate (NextFilesAsync_cb);
				return NextFilesAsync_cb_delegate;
			}
		}

		static void OverrideNextFilesAsync (GLib.GType gtype)
		{
			OverrideNextFilesAsync (gtype, NextFilesAsyncVMCallback);
		}

		static void OverrideNextFilesAsync (GLib.GType gtype, NextFilesAsyncNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("next_files_async"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void NextFilesAsyncNativeDelegate (IntPtr inst, int num_files, int io_priority, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		static void NextFilesAsync_cb (IntPtr inst, int num_files, int io_priority, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data)
		{
			try {
				FileEnumerator __obj = GLib.Object.GetObject (inst, false) as FileEnumerator;
				GLibSharp.AsyncReadyCallbackInvoker cb_invoker = new GLibSharp.AsyncReadyCallbackInvoker (cb, user_data);
				__obj.OnNextFilesAsync (num_files, io_priority, GLib.Object.GetObject(cancellable) as GLib.Cancellable, cb_invoker.Handler);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.FileEnumerator), ConnectionMethod="OverrideNextFilesAsync")]
		protected virtual void OnNextFilesAsync (int num_files, int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb)
		{
			InternalNextFilesAsync (num_files, io_priority, cancellable, cb);
		}

		private void InternalNextFilesAsync (int num_files, int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb)
		{
			NextFilesAsyncNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("next_files_async"));
				unmanaged = (NextFilesAsyncNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(NextFilesAsyncNativeDelegate));
			}
			if (unmanaged == null) return;

			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			unmanaged (this.Handle, num_files, io_priority, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		static NextFilesFinishNativeDelegate NextFilesFinish_cb_delegate;
		static NextFilesFinishNativeDelegate NextFilesFinishVMCallback {
			get {
				if (NextFilesFinish_cb_delegate == null)
					NextFilesFinish_cb_delegate = new NextFilesFinishNativeDelegate (NextFilesFinish_cb);
				return NextFilesFinish_cb_delegate;
			}
		}

		static void OverrideNextFilesFinish (GLib.GType gtype)
		{
			OverrideNextFilesFinish (gtype, NextFilesFinishVMCallback);
		}

		static void OverrideNextFilesFinish (GLib.GType gtype, NextFilesFinishNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("next_files_finish"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr NextFilesFinishNativeDelegate (IntPtr inst, IntPtr result, out IntPtr error);

		static IntPtr NextFilesFinish_cb (IntPtr inst, IntPtr result, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				FileEnumerator __obj = GLib.Object.GetObject (inst, false) as FileEnumerator;
				GLib.FileInfo[] __result;
				__result = __obj.OnNextFilesFinish (GLib.AsyncResultAdapter.GetObject (result, false));
				return new GLib.List(__result, typeof (GLib.FileInfo), true, true) == null ? IntPtr.Zero : new GLib.List(__result, typeof (GLib.FileInfo), true, true).Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.FileEnumerator), ConnectionMethod="OverrideNextFilesFinish")]
		protected virtual GLib.FileInfo[] OnNextFilesFinish (GLib.IAsyncResult result)
		{
			return InternalNextFilesFinish (result);
		}

		private GLib.FileInfo[] InternalNextFilesFinish (GLib.IAsyncResult result)
		{
			NextFilesFinishNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("next_files_finish"));
				unmanaged = (NextFilesFinishNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(NextFilesFinishNativeDelegate));
			}
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr error = IntPtr.Zero;
			IntPtr __result = unmanaged (this.Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			return (GLib.FileInfo[]) GLib.Marshaller.ListPtrToArray (__result, typeof(GLib.List), true, true, typeof(GLib.FileInfo));
		}

		static CloseAsyncNativeDelegate CloseAsync_cb_delegate;
		static CloseAsyncNativeDelegate CloseAsyncVMCallback {
			get {
				if (CloseAsync_cb_delegate == null)
					CloseAsync_cb_delegate = new CloseAsyncNativeDelegate (CloseAsync_cb);
				return CloseAsync_cb_delegate;
			}
		}

		static void OverrideCloseAsync (GLib.GType gtype)
		{
			OverrideCloseAsync (gtype, CloseAsyncVMCallback);
		}

		static void OverrideCloseAsync (GLib.GType gtype, CloseAsyncNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("close_async"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void CloseAsyncNativeDelegate (IntPtr inst, int io_priority, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		static void CloseAsync_cb (IntPtr inst, int io_priority, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data)
		{
			try {
				FileEnumerator __obj = GLib.Object.GetObject (inst, false) as FileEnumerator;
				GLibSharp.AsyncReadyCallbackInvoker cb_invoker = new GLibSharp.AsyncReadyCallbackInvoker (cb, user_data);
				__obj.OnCloseAsync (io_priority, GLib.Object.GetObject(cancellable) as GLib.Cancellable, cb_invoker.Handler);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.FileEnumerator), ConnectionMethod="OverrideCloseAsync")]
		protected virtual void OnCloseAsync (int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb)
		{
			InternalCloseAsync (io_priority, cancellable, cb);
		}

		private void InternalCloseAsync (int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb)
		{
			CloseAsyncNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("close_async"));
				unmanaged = (CloseAsyncNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(CloseAsyncNativeDelegate));
			}
			if (unmanaged == null) return;

			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			unmanaged (this.Handle, io_priority, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		static CloseFinishNativeDelegate CloseFinish_cb_delegate;
		static CloseFinishNativeDelegate CloseFinishVMCallback {
			get {
				if (CloseFinish_cb_delegate == null)
					CloseFinish_cb_delegate = new CloseFinishNativeDelegate (CloseFinish_cb);
				return CloseFinish_cb_delegate;
			}
		}

		static void OverrideCloseFinish (GLib.GType gtype)
		{
			OverrideCloseFinish (gtype, CloseFinishVMCallback);
		}

		static void OverrideCloseFinish (GLib.GType gtype, CloseFinishNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("close_finish"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool CloseFinishNativeDelegate (IntPtr inst, IntPtr result, out IntPtr error);

		static bool CloseFinish_cb (IntPtr inst, IntPtr result, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				FileEnumerator __obj = GLib.Object.GetObject (inst, false) as FileEnumerator;
				bool __result;
				__result = __obj.OnCloseFinish (GLib.AsyncResultAdapter.GetObject (result, false));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.FileEnumerator), ConnectionMethod="OverrideCloseFinish")]
		protected virtual bool OnCloseFinish (GLib.IAsyncResult result)
		{
			return InternalCloseFinish (result);
		}

		private bool InternalCloseFinish (GLib.IAsyncResult result)
		{
			CloseFinishNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("close_finish"));
				unmanaged = (CloseFinishNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(CloseFinishNativeDelegate));
			}
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr error = IntPtr.Zero;
			bool __result = unmanaged (this.Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			return __result;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("next_file"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // next_file
							, null
							, "close_fn"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("close_fn"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // close_fn
							, "next_file"
							, "next_files_async"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("next_files_async"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // next_files_async
							, "close_fn"
							, "next_files_finish"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("next_files_finish"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // next_files_finish
							, "next_files_async"
							, "close_async"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("close_async"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // close_async
							, "next_files_finish"
							, "close_finish"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("close_finish"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // close_finish
							, "close_async"
							, "_g_reserved1"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_g_reserved1"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _g_reserved1
							, "close_finish"
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
		static extern unsafe bool g_file_enumerator_close(IntPtr raw, IntPtr cancellable, out IntPtr error);

		public unsafe bool Close(GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_file_enumerator_close(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_file_enumerator_close_async(IntPtr raw, int io_priority, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void CloseAsync(int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_file_enumerator_close_async(Handle, io_priority, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool g_file_enumerator_close_finish(IntPtr raw, IntPtr result, out IntPtr error);

		public unsafe bool CloseFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_file_enumerator_close_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_file_enumerator_get_child(IntPtr raw, IntPtr info);

		public GLib.IFile GetChild(GLib.FileInfo info) {
			IntPtr raw_ret = g_file_enumerator_get_child(Handle, info == null ? IntPtr.Zero : info.Handle);
			GLib.IFile ret = GLib.FileAdapter.GetObject (raw_ret, false);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_file_enumerator_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_file_enumerator_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_file_enumerator_has_pending(IntPtr raw);

		public bool HasPending { 
			get {
				bool raw_ret = g_file_enumerator_has_pending(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_file_enumerator_is_closed(IntPtr raw);

		public bool IsClosed { 
			get {
				bool raw_ret = g_file_enumerator_is_closed(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool g_file_enumerator_iterate(IntPtr raw, IntPtr out_info, IntPtr out_child, IntPtr cancellable, out IntPtr error);

		public unsafe bool Iterate(GLib.FileInfo out_info, GLib.IFile out_child, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_file_enumerator_iterate(Handle, out_info == null ? IntPtr.Zero : out_info.Handle, out_child == null ? IntPtr.Zero : ((out_child is GLib.Object) ? (out_child as GLib.Object).Handle : (out_child as GLib.FileAdapter).Handle), cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_file_enumerator_next_file(IntPtr raw, IntPtr cancellable, out IntPtr error);

		public unsafe GLib.FileInfo NextFile(GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_file_enumerator_next_file(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			GLib.FileInfo ret = GLib.Object.GetObject(raw_ret) as GLib.FileInfo;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_file_enumerator_next_files_async(IntPtr raw, int num_files, int io_priority, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void NextFilesAsync(int num_files, int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_file_enumerator_next_files_async(Handle, num_files, io_priority, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_file_enumerator_next_files_finish(IntPtr raw, IntPtr result, out IntPtr error);

		public unsafe GLib.FileInfo[] NextFilesFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_file_enumerator_next_files_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			GLib.FileInfo[] ret = (GLib.FileInfo[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(GLib.FileInfo));
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_file_enumerator_set_pending(IntPtr raw, bool pending);

		public bool Pending { 
			set {
				g_file_enumerator_set_pending(Handle, value);
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
