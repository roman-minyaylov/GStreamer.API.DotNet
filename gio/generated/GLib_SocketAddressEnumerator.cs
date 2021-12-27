﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class SocketAddressEnumerator : GLib.Object {

		public SocketAddressEnumerator (IntPtr raw) : base(raw) {}

		protected SocketAddressEnumerator() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		static NextNativeDelegate Next_cb_delegate;
		static NextNativeDelegate NextVMCallback {
			get {
				if (Next_cb_delegate == null)
					Next_cb_delegate = new NextNativeDelegate (Next_cb);
				return Next_cb_delegate;
			}
		}

		static void OverrideNext (GLib.GType gtype)
		{
			OverrideNext (gtype, NextVMCallback);
		}

		static void OverrideNext (GLib.GType gtype, NextNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("next"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr NextNativeDelegate (IntPtr inst, IntPtr cancellable, out IntPtr error);

		static IntPtr Next_cb (IntPtr inst, IntPtr cancellable, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				SocketAddressEnumerator __obj = GLib.Object.GetObject (inst, false) as SocketAddressEnumerator;
				GLib.SocketAddress __result;
				__result = __obj.OnNext (GLib.Object.GetObject(cancellable) as GLib.Cancellable);
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.SocketAddressEnumerator), ConnectionMethod="OverrideNext")]
		protected virtual GLib.SocketAddress OnNext (GLib.Cancellable cancellable)
		{
			return InternalNext (cancellable);
		}

		private GLib.SocketAddress InternalNext (GLib.Cancellable cancellable)
		{
			NextNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("next"));
				unmanaged = (NextNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(NextNativeDelegate));
			}
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr error = IntPtr.Zero;
			IntPtr __result = unmanaged (this.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			return GLib.Object.GetObject(__result) as GLib.SocketAddress;
		}

		static NextAsyncNativeDelegate NextAsync_cb_delegate;
		static NextAsyncNativeDelegate NextAsyncVMCallback {
			get {
				if (NextAsync_cb_delegate == null)
					NextAsync_cb_delegate = new NextAsyncNativeDelegate (NextAsync_cb);
				return NextAsync_cb_delegate;
			}
		}

		static void OverrideNextAsync (GLib.GType gtype)
		{
			OverrideNextAsync (gtype, NextAsyncVMCallback);
		}

		static void OverrideNextAsync (GLib.GType gtype, NextAsyncNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("next_async"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void NextAsyncNativeDelegate (IntPtr inst, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		static void NextAsync_cb (IntPtr inst, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data)
		{
			try {
				SocketAddressEnumerator __obj = GLib.Object.GetObject (inst, false) as SocketAddressEnumerator;
				GLibSharp.AsyncReadyCallbackInvoker cb_invoker = new GLibSharp.AsyncReadyCallbackInvoker (cb, user_data);
				__obj.OnNextAsync (GLib.Object.GetObject(cancellable) as GLib.Cancellable, cb_invoker.Handler);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.SocketAddressEnumerator), ConnectionMethod="OverrideNextAsync")]
		protected virtual void OnNextAsync (GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb)
		{
			InternalNextAsync (cancellable, cb);
		}

		private void InternalNextAsync (GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb)
		{
			NextAsyncNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("next_async"));
				unmanaged = (NextAsyncNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(NextAsyncNativeDelegate));
			}
			if (unmanaged == null) return;

			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			unmanaged (this.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		static NextFinishNativeDelegate NextFinish_cb_delegate;
		static NextFinishNativeDelegate NextFinishVMCallback {
			get {
				if (NextFinish_cb_delegate == null)
					NextFinish_cb_delegate = new NextFinishNativeDelegate (NextFinish_cb);
				return NextFinish_cb_delegate;
			}
		}

		static void OverrideNextFinish (GLib.GType gtype)
		{
			OverrideNextFinish (gtype, NextFinishVMCallback);
		}

		static void OverrideNextFinish (GLib.GType gtype, NextFinishNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("next_finish"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr NextFinishNativeDelegate (IntPtr inst, IntPtr result, out IntPtr error);

		static IntPtr NextFinish_cb (IntPtr inst, IntPtr result, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				SocketAddressEnumerator __obj = GLib.Object.GetObject (inst, false) as SocketAddressEnumerator;
				GLib.SocketAddress __result;
				__result = __obj.OnNextFinish (GLib.AsyncResultAdapter.GetObject (result, false));
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.SocketAddressEnumerator), ConnectionMethod="OverrideNextFinish")]
		protected virtual GLib.SocketAddress OnNextFinish (GLib.IAsyncResult result)
		{
			return InternalNextFinish (result);
		}

		private GLib.SocketAddress InternalNextFinish (GLib.IAsyncResult result)
		{
			NextFinishNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("next_finish"));
				unmanaged = (NextFinishNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(NextFinishNativeDelegate));
			}
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr error = IntPtr.Zero;
			IntPtr __result = unmanaged (this.Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			return GLib.Object.GetObject(__result) as GLib.SocketAddress;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("next"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // next
							, null
							, "next_async"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("next_async"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // next_async
							, "next"
							, "next_finish"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("next_finish"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // next_finish
							, "next_async"
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
		static extern IntPtr g_socket_address_enumerator_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_socket_address_enumerator_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_socket_address_enumerator_next(IntPtr raw, IntPtr cancellable, out IntPtr error);

		public unsafe GLib.SocketAddress Next(GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_socket_address_enumerator_next(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			GLib.SocketAddress ret = GLib.Object.GetObject(raw_ret) as GLib.SocketAddress;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_socket_address_enumerator_next_async(IntPtr raw, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void NextAsync(GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_socket_address_enumerator_next_async(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_socket_address_enumerator_next_finish(IntPtr raw, IntPtr result, out IntPtr error);

		public unsafe GLib.SocketAddress NextFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_socket_address_enumerator_next_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			GLib.SocketAddress ret = GLib.Object.GetObject(raw_ret) as GLib.SocketAddress;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (GLib.Object.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
