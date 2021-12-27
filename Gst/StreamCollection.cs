﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class StreamCollection : Gst.Object {

		public StreamCollection (IntPtr raw) : base(raw) {}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_stream_collection_new(IntPtr upstream_id);

		public StreamCollection (string upstream_id) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (StreamCollection)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("upstream_id");
				vals.Add (new GLib.Value (upstream_id));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_upstream_id = GLib.Marshaller.StringToPtrGStrdup (upstream_id);
			Raw = gst_stream_collection_new(native_upstream_id);
			GLib.Marshaller.Free (native_upstream_id);
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_stream_collection_get_upstream_id(IntPtr raw);

		[GLib.Property ("upstream-id")]
		public string UpstreamId {
			get  {
				IntPtr raw_ret = gst_stream_collection_get_upstream_id(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("upstream-id", val);
				val.Dispose ();
			}
		}

		[GLib.Signal("stream-notify")]
		public event Gst.StreamNotifyHandler StreamNotify {
			add {
				this.AddSignalHandler ("stream-notify", value, typeof (Gst.StreamNotifyArgs));
			}
			remove {
				this.RemoveSignalHandler ("stream-notify", value);
			}
		}

		static StreamNotifyNativeDelegate StreamNotify_cb_delegate;
		static StreamNotifyNativeDelegate StreamNotifyVMCallback {
			get {
				if (StreamNotify_cb_delegate == null)
					StreamNotify_cb_delegate = new StreamNotifyNativeDelegate (StreamNotify_cb);
				return StreamNotify_cb_delegate;
			}
		}

		static void OverrideStreamNotify (GLib.GType gtype)
		{
			OverrideStreamNotify (gtype, StreamNotifyVMCallback);
		}

		static void OverrideStreamNotify (GLib.GType gtype, StreamNotifyNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("stream_notify"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void StreamNotifyNativeDelegate (IntPtr inst, IntPtr _object, IntPtr p0);

		static void StreamNotify_cb (IntPtr inst, IntPtr _object, IntPtr p0)
		{
			try {
				StreamCollection __obj = GLib.Object.GetObject (inst, false) as StreamCollection;
				__obj.OnStreamNotify (GLib.Object.GetObject(_object) as Gst.Stream, p0);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.StreamCollection), ConnectionMethod="OverrideStreamNotify")]
		protected virtual void OnStreamNotify (Gst.Stream _object, IntPtr p0)
		{
			InternalStreamNotify (_object, p0);
		}

		private void InternalStreamNotify (Gst.Stream _object, IntPtr p0)
		{
			StreamNotifyNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("stream_notify"));
				unmanaged = (StreamNotifyNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(StreamNotifyNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, _object == null ? IntPtr.Zero : _object.Handle, p0);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("stream_notify"
							, Gst.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // stream_notify
							, null
							, "_gst_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _gst_reserved
							, "stream_notify"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_stream_collection_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_stream_collection_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_stream_collection_add_stream(IntPtr raw, IntPtr stream);

		public bool AddStream(Gst.Stream stream) {
			bool raw_ret = gst_stream_collection_add_stream(Handle, stream == null ? IntPtr.Zero : stream.OwnedHandle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_stream_collection_get_size(IntPtr raw);

		public uint Size { 
			get {
				uint raw_ret = gst_stream_collection_get_size(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_stream_collection_get_stream(IntPtr raw, uint index);

		public Gst.Stream GetStream(uint index) {
			IntPtr raw_ret = gst_stream_collection_get_stream(Handle, index);
			Gst.Stream ret = GLib.Object.GetObject(raw_ret) as Gst.Stream;
			return ret;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("upstream_id"
							, Gst.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // upstream_id
							, null
							, "priv"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("priv"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, "upstream_id"
							, "_gst_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _gst_reserved
							, "priv"
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
