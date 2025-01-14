﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class FileIcon : GLib.Object, GLib.IIcon, GLib.ILoadableIcon {

		public FileIcon (IntPtr raw) : base(raw) {}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_file_icon_new(IntPtr file);

		public FileIcon (GLib.IFile file) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (FileIcon)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (file != null) {
					names.Add ("file");
					vals.Add (new GLib.Value (file));
				}
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = g_file_icon_new(file == null ? IntPtr.Zero : ((file is GLib.Object) ? (file as GLib.Object).Handle : (file as GLib.FileAdapter).Handle));
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_file_icon_get_file(IntPtr raw);

		[GLib.Property ("file")]
		public GLib.IFile File {
			get  {
				IntPtr raw_ret = g_file_icon_get_file(Handle);
				GLib.IFile ret = GLib.FileAdapter.GetObject (raw_ret, false);
				return ret;
			}
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
		static extern IntPtr g_file_icon_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_file_icon_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_icon_equal(IntPtr raw, IntPtr icon2);

		public bool Equal(GLib.IIcon icon2) {
			bool raw_ret = g_icon_equal(Handle, icon2 == null ? IntPtr.Zero : ((icon2 is GLib.Object) ? (icon2 as GLib.Object).Handle : (icon2 as GLib.IconAdapter).Handle));
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_icon_serialize(IntPtr raw);

		public GLib.Variant Serialize() {
			IntPtr raw_ret = g_icon_serialize(Handle);
			GLib.Variant ret = new GLib.Variant(raw_ret);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_icon_to_string(IntPtr raw);

		public override string ToString() {
			IntPtr raw_ret = g_icon_to_string(Handle);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_loadable_icon_load(IntPtr raw, int size, IntPtr type, IntPtr cancellable, out IntPtr error);

		public GLib.InputStream Load(int size, string type, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_loadable_icon_load(Handle, size, GLib.Marshaller.StringToPtrGStrdup(type), cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			GLib.InputStream ret = GLib.Object.GetObject(raw_ret) as GLib.InputStream;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_loadable_icon_load_async(IntPtr raw, int size, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void LoadAsync(int size, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_loadable_icon_load_async(Handle, size, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_loadable_icon_load_finish(IntPtr raw, IntPtr res, IntPtr type, out IntPtr error);

		public GLib.InputStream LoadFinish(GLib.IAsyncResult res, string type) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_loadable_icon_load_finish(Handle, res == null ? IntPtr.Zero : ((res is GLib.Object) ? (res as GLib.Object).Handle : (res as GLib.AsyncResultAdapter).Handle), GLib.Marshaller.StringToPtrGStrdup(type), out error);
			GLib.InputStream ret = GLib.Object.GetObject(raw_ret) as GLib.InputStream;
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
