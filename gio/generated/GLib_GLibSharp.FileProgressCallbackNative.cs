// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLibSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate void FileProgressCallbackNative(long current_num_bytes, long total_num_bytes, IntPtr user_data);

	internal class FileProgressCallbackInvoker {

		FileProgressCallbackNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~FileProgressCallbackInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal FileProgressCallbackInvoker (FileProgressCallbackNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal FileProgressCallbackInvoker (FileProgressCallbackNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal FileProgressCallbackInvoker (FileProgressCallbackNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal GLib.FileProgressCallback Handler {
			get {
				return new GLib.FileProgressCallback(InvokeNative);
			}
		}

		void InvokeNative (long current_num_bytes, long total_num_bytes)
		{
			native_cb (current_num_bytes, total_num_bytes, __data);
		}
	}

	internal class FileProgressCallbackWrapper {

		public void NativeCallback (long current_num_bytes, long total_num_bytes, IntPtr user_data)
		{
			try {
				managed (current_num_bytes, total_num_bytes);
				if (release_on_call)
					gch.Free ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal FileProgressCallbackNative NativeDelegate;
		GLib.FileProgressCallback managed;

		public FileProgressCallbackWrapper (GLib.FileProgressCallback managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new FileProgressCallbackNative (NativeCallback);
		}

		public static GLib.FileProgressCallback GetManagedDelegate (FileProgressCallbackNative native)
		{
			if (native == null)
				return null;
			FileProgressCallbackWrapper wrapper = (FileProgressCallbackWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
