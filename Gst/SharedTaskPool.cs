﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class SharedTaskPool : Gst.TaskPool {

		public SharedTaskPool (IntPtr raw) : base(raw) {}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_shared_task_pool_new();

		public SharedTaskPool () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (SharedTaskPool)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gst_shared_task_pool_new();
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gst_reserved"
							, Gst.TaskPool.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _gst_reserved
							, null
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
		static extern IntPtr gst_shared_task_pool_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_shared_task_pool_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_shared_task_pool_get_max_threads(IntPtr raw);

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_shared_task_pool_set_max_threads(IntPtr raw, uint max_threads);

		public uint MaxThreads { 
			get {
				uint raw_ret = gst_shared_task_pool_get_max_threads(Handle);
				uint ret = raw_ret;
				return ret;
			}
			set {
				gst_shared_task_pool_set_max_threads(Handle, value);
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gst.TaskPool.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
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
