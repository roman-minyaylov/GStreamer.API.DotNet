﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class MiniObject : GLib.Opaque {

		public GLib.GType Type {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("type"));
					return new GLib.GType((*raw_ptr));
				}
			}
			set {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("type"));
					*raw_ptr = value.Val;
				}
			}
		}

		public int Refcount {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("refcount"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("refcount"));
					*raw_ptr = value;
				}
			}
		}

		public int Lockstate {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("lockstate"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("lockstate"));
					*raw_ptr = value;
				}
			}
		}

		public uint Flags {
			get {
				unsafe {
					uint* raw_ptr = (uint*)(((byte*)Handle) + abi_info.GetFieldOffset("flags"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					uint* raw_ptr = (uint*)(((byte*)Handle) + abi_info.GetFieldOffset("flags"));
					*raw_ptr = value;
				}
			}
		}

		public IntPtr CopyFunc {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("copy"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("copy"));
					*raw_ptr = value;
				}
			}
		}

		public IntPtr Dispose {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("dispose"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("dispose"));
					*raw_ptr = value;
				}
			}
		}

		public IntPtr Free {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("free"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("free"));
					*raw_ptr = value;
				}
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_mini_object_add_parent(IntPtr raw, IntPtr parent);

		public void AddParent(Gst.MiniObject parent) {
			gst_mini_object_add_parent(Handle, parent == null ? IntPtr.Zero : parent.Handle);
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_mini_object_get_qdata(IntPtr raw, uint quark);

		public IntPtr GetQdata(uint quark) {
			IntPtr raw_ret = gst_mini_object_get_qdata(Handle, quark);
			IntPtr ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_mini_object_is_writable(IntPtr raw);

		public bool IsWritable { 
			get {
				bool raw_ret = gst_mini_object_is_writable(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_mini_object_lock(IntPtr raw, int flags);

		public bool Lock(Gst.LockFlags flags) {
			bool raw_ret = gst_mini_object_lock(Handle, (int) flags);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_mini_object_remove_parent(IntPtr raw, IntPtr parent);

		public void RemoveParent(Gst.MiniObject parent) {
			gst_mini_object_remove_parent(Handle, parent == null ? IntPtr.Zero : parent.Handle);
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_mini_object_set_qdata(IntPtr raw, uint quark, IntPtr data, GLib.DestroyNotify destroy);

		public void SetQdata(uint quark, IntPtr data, GLib.DestroyNotify destroy) {
			gst_mini_object_set_qdata(Handle, quark, data, destroy);
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_mini_object_steal_qdata(IntPtr raw, uint quark);

		public IntPtr StealQdata(uint quark) {
			IntPtr raw_ret = gst_mini_object_steal_qdata(Handle, quark);
			IntPtr ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_mini_object_unlock(IntPtr raw, int flags);

		public void Unlock(Gst.LockFlags flags) {
			gst_mini_object_unlock(Handle, (int) flags);
		}

		public MiniObject(IntPtr raw) : base(raw) {}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_mini_object_ref(IntPtr raw);

		protected override void Ref (IntPtr raw)
		{
			if (!Owned) {
				gst_mini_object_ref (raw);
				Owned = true;
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_mini_object_unref(IntPtr raw);

		protected override void Unref (IntPtr raw)
		{
			if (Owned) {
				gst_mini_object_unref (raw);
				Owned = false;
			}
		}

		class FinalizerInfo {
			IntPtr handle;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				gst_mini_object_unref (handle);
				return false;
			}
		}

		~MiniObject ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("type"
							, 0
							, (uint) Marshal.SizeOf(typeof(GLib.GType)) // type
							, null
							, "refcount"
							, (long) Marshal.OffsetOf(typeof(GstMiniObject_typeAlign), "type")
							, 0
							),
						new GLib.AbiField("refcount"
							, -1
							, (uint) Marshal.SizeOf(typeof(int)) // refcount
							, "type"
							, "lockstate"
							, (long) Marshal.OffsetOf(typeof(GstMiniObject_refcountAlign), "refcount")
							, 0
							),
						new GLib.AbiField("lockstate"
							, -1
							, (uint) Marshal.SizeOf(typeof(int)) // lockstate
							, "refcount"
							, "flags"
							, (long) Marshal.OffsetOf(typeof(GstMiniObject_lockstateAlign), "lockstate")
							, 0
							),
						new GLib.AbiField("flags"
							, -1
							, (uint) Marshal.SizeOf(typeof(uint)) // flags
							, "lockstate"
							, "copy"
							, (long) Marshal.OffsetOf(typeof(GstMiniObject_flagsAlign), "flags")
							, 0
							),
						new GLib.AbiField("copy"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // copy
							, "flags"
							, "dispose"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("dispose"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // dispose
							, "copy"
							, "free"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("free"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // free
							, "dispose"
							, "priv_uint"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("priv_uint"
							, -1
							, (uint) Marshal.SizeOf(typeof(uint)) // priv_uint
							, "free"
							, "priv_pointer"
							, (long) Marshal.OffsetOf(typeof(GstMiniObject_priv_uintAlign), "priv_uint")
							, 0
							),
						new GLib.AbiField("priv_pointer"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv_pointer
							, "priv_uint"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstMiniObject_typeAlign
		{
			sbyte f1;
			private GLib.GType type;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstMiniObject_refcountAlign
		{
			sbyte f1;
			private int refcount;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstMiniObject_lockstateAlign
		{
			sbyte f1;
			private int lockstate;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstMiniObject_flagsAlign
		{
			sbyte f1;
			private uint flags;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstMiniObject_priv_uintAlign
		{
			sbyte f1;
			private uint priv_uint;
		}


		// End of the ABI representation.

#endregion
	}
}
