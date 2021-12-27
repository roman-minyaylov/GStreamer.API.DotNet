﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class BufferedInputStream : GLib.FilterInputStream, GLib.ISeekable {

		public BufferedInputStream (IntPtr raw) : base(raw) {}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_buffered_input_stream_new(IntPtr base_stream);

		public BufferedInputStream (GLib.InputStream base_stream) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (BufferedInputStream)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (base_stream != null) {
					names.Add ("base_stream");
					vals.Add (new GLib.Value (base_stream));
				}
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = g_buffered_input_stream_new(base_stream == null ? IntPtr.Zero : base_stream.Handle);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_buffered_input_stream_new_sized(IntPtr base_stream, UIntPtr size);

		public BufferedInputStream (GLib.InputStream base_stream, ulong size) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (BufferedInputStream)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (base_stream != null) {
					names.Add ("base_stream");
					vals.Add (new GLib.Value (base_stream));
				}
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = g_buffered_input_stream_new_sized(base_stream == null ? IntPtr.Zero : base_stream.Handle, new UIntPtr (size));
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern UIntPtr g_buffered_input_stream_get_buffer_size(IntPtr raw);

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_buffered_input_stream_set_buffer_size(IntPtr raw, UIntPtr size);

		[GLib.Property ("buffer-size")]
		public ulong BufferSize {
			get  {
				UIntPtr raw_ret = g_buffered_input_stream_get_buffer_size(Handle);
				ulong ret = (ulong) raw_ret;
				return ret;
			}
			set  {
				g_buffered_input_stream_set_buffer_size(Handle, new UIntPtr (value));
			}
		}

		static FillNativeDelegate Fill_cb_delegate;
		static FillNativeDelegate FillVMCallback {
			get {
				if (Fill_cb_delegate == null)
					Fill_cb_delegate = new FillNativeDelegate (Fill_cb);
				return Fill_cb_delegate;
			}
		}

		static void OverrideFill (GLib.GType gtype)
		{
			OverrideFill (gtype, FillVMCallback);
		}

		static void OverrideFill (GLib.GType gtype, FillNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("fill"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr FillNativeDelegate (IntPtr inst, IntPtr count, IntPtr cancellable, out IntPtr error);

		static IntPtr Fill_cb (IntPtr inst, IntPtr count, IntPtr cancellable, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				BufferedInputStream __obj = GLib.Object.GetObject (inst, false) as BufferedInputStream;
				long __result;
				__result = __obj.OnFill ((long) count, GLib.Object.GetObject(cancellable) as GLib.Cancellable);
				return new IntPtr (__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.BufferedInputStream), ConnectionMethod="OverrideFill")]
		protected virtual long OnFill (long count, GLib.Cancellable cancellable)
		{
			return InternalFill (count, cancellable);
		}

		private long InternalFill (long count, GLib.Cancellable cancellable)
		{
			FillNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("fill"));
				unmanaged = (FillNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(FillNativeDelegate));
			}
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr error = IntPtr.Zero;
			IntPtr __result = unmanaged (this.Handle, new IntPtr (count), cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			return (long) __result;
		}

		static FillAsyncNativeDelegate FillAsync_cb_delegate;
		static FillAsyncNativeDelegate FillAsyncVMCallback {
			get {
				if (FillAsync_cb_delegate == null)
					FillAsync_cb_delegate = new FillAsyncNativeDelegate (FillAsync_cb);
				return FillAsync_cb_delegate;
			}
		}

		static void OverrideFillAsync (GLib.GType gtype)
		{
			OverrideFillAsync (gtype, FillAsyncVMCallback);
		}

		static void OverrideFillAsync (GLib.GType gtype, FillAsyncNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("fill_async"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void FillAsyncNativeDelegate (IntPtr inst, IntPtr count, int io_priority, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		static void FillAsync_cb (IntPtr inst, IntPtr count, int io_priority, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data)
		{
			try {
				BufferedInputStream __obj = GLib.Object.GetObject (inst, false) as BufferedInputStream;
				GLibSharp.AsyncReadyCallbackInvoker cb_invoker = new GLibSharp.AsyncReadyCallbackInvoker (cb, user_data);
				__obj.OnFillAsync ((long) count, io_priority, GLib.Object.GetObject(cancellable) as GLib.Cancellable, cb_invoker.Handler);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.BufferedInputStream), ConnectionMethod="OverrideFillAsync")]
		protected virtual void OnFillAsync (long count, int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb)
		{
			InternalFillAsync (count, io_priority, cancellable, cb);
		}

		private void InternalFillAsync (long count, int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb)
		{
			FillAsyncNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("fill_async"));
				unmanaged = (FillAsyncNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(FillAsyncNativeDelegate));
			}
			if (unmanaged == null) return;

			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			unmanaged (this.Handle, new IntPtr (count), io_priority, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		static FillFinishNativeDelegate FillFinish_cb_delegate;
		static FillFinishNativeDelegate FillFinishVMCallback {
			get {
				if (FillFinish_cb_delegate == null)
					FillFinish_cb_delegate = new FillFinishNativeDelegate (FillFinish_cb);
				return FillFinish_cb_delegate;
			}
		}

		static void OverrideFillFinish (GLib.GType gtype)
		{
			OverrideFillFinish (gtype, FillFinishVMCallback);
		}

		static void OverrideFillFinish (GLib.GType gtype, FillFinishNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("fill_finish"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr FillFinishNativeDelegate (IntPtr inst, IntPtr result, out IntPtr error);

		static IntPtr FillFinish_cb (IntPtr inst, IntPtr result, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				BufferedInputStream __obj = GLib.Object.GetObject (inst, false) as BufferedInputStream;
				long __result;
				__result = __obj.OnFillFinish (GLib.AsyncResultAdapter.GetObject (result, false));
				return new IntPtr (__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.BufferedInputStream), ConnectionMethod="OverrideFillFinish")]
		protected virtual long OnFillFinish (GLib.IAsyncResult result)
		{
			return InternalFillFinish (result);
		}

		private long InternalFillFinish (GLib.IAsyncResult result)
		{
			FillFinishNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("fill_finish"));
				unmanaged = (FillFinishNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(FillFinishNativeDelegate));
			}
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr error = IntPtr.Zero;
			IntPtr __result = unmanaged (this.Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			return (long) __result;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("fill"
							, GLib.FilterInputStream.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // fill
							, null
							, "fill_async"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("fill_async"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // fill_async
							, "fill"
							, "fill_finish"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("fill_finish"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // fill_finish
							, "fill_async"
							, "_g_reserved1"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_g_reserved1"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _g_reserved1
							, "fill_finish"
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
		static extern unsafe IntPtr g_buffered_input_stream_fill(IntPtr raw, IntPtr count, IntPtr cancellable, out IntPtr error);

		public unsafe long Fill(long count, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_buffered_input_stream_fill(Handle, new IntPtr (count), cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			long ret = (long) raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_buffered_input_stream_fill_async(IntPtr raw, IntPtr count, int io_priority, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void FillAsync(long count, int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_buffered_input_stream_fill_async(Handle, new IntPtr (count), io_priority, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_buffered_input_stream_fill_finish(IntPtr raw, IntPtr result, out IntPtr error);

		public unsafe long FillFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_buffered_input_stream_fill_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			long ret = (long) raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern UIntPtr g_buffered_input_stream_get_available(IntPtr raw);

		public ulong Available { 
			get {
				UIntPtr raw_ret = g_buffered_input_stream_get_available(Handle);
				ulong ret = (ulong) raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_buffered_input_stream_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_buffered_input_stream_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern UIntPtr g_buffered_input_stream_peek(IntPtr raw, IntPtr buffer, UIntPtr offset, UIntPtr count);

		public ulong Peek(IntPtr buffer, ulong offset, ulong count) {
			UIntPtr raw_ret = g_buffered_input_stream_peek(Handle, buffer, new UIntPtr (offset), new UIntPtr (count));
			ulong ret = (ulong) raw_ret;
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_buffered_input_stream_peek_buffer(IntPtr raw, out UIntPtr count);

		public IntPtr PeekBuffer(out ulong count) {
			UIntPtr native_count;
			IntPtr raw_ret = g_buffered_input_stream_peek_buffer(Handle, out native_count);
			IntPtr ret = raw_ret;
			count = (ulong) native_count;
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe int g_buffered_input_stream_read_byte(IntPtr raw, IntPtr cancellable, out IntPtr error);

		public unsafe int ReadByte(GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			int raw_ret = g_buffered_input_stream_read_byte(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			int ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_seekable_can_seek(IntPtr raw);

		public bool CanSeek { 
			get {
				bool raw_ret = g_seekable_can_seek(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_seekable_can_truncate(IntPtr raw);

		public bool CanTruncate() {
			bool raw_ret = g_seekable_can_truncate(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_seekable_seek(IntPtr raw, long offset, int type, IntPtr cancellable, out IntPtr error);

		public bool Seek(long offset, GLib.SeekType type, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_seekable_seek(Handle, offset, (int) type, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern long g_seekable_tell(IntPtr raw);

		public long Position { 
			get {
				long raw_ret = g_seekable_tell(Handle);
				long ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_seekable_truncate(IntPtr raw, long offset, IntPtr cancellable, out IntPtr error);

		public bool Truncate(long offset, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_seekable_truncate(Handle, offset, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			bool ret = raw_ret;
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
							, GLib.FilterInputStream.abi_info.Fields
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
