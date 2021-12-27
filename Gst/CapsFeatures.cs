﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct CapsFeatures : IEquatable<CapsFeatures> {


		public static Gst.CapsFeatures Zero = new Gst.CapsFeatures ();

		public static Gst.CapsFeatures New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.CapsFeatures.Zero;
			return (Gst.CapsFeatures) Marshal.PtrToStructure (raw, typeof (Gst.CapsFeatures));
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_caps_features_new_any();

		public static CapsFeatures NewAny()
		{
			CapsFeatures result = CapsFeatures.New (gst_caps_features_new_any());
			return result;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_caps_features_new_empty();

		public static CapsFeatures NewEmpty()
		{
			CapsFeatures result = CapsFeatures.New (gst_caps_features_new_empty());
			return result;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_caps_features_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_caps_features_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_caps_features_add(IntPtr raw, IntPtr feature);

		public void Add(string feature) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_feature = GLib.Marshaller.StringToPtrGStrdup (feature);
			gst_caps_features_add(this_as_native, native_feature);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_feature);
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_caps_features_add_id(IntPtr raw, uint feature);

		public void AddId(uint feature) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			gst_caps_features_add_id(this_as_native, feature);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_caps_features_contains(IntPtr raw, IntPtr feature);

		public bool Contains(string feature) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_feature = GLib.Marshaller.StringToPtrGStrdup (feature);
			bool raw_ret = gst_caps_features_contains(this_as_native, native_feature);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_feature);
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_caps_features_contains_id(IntPtr raw, uint feature);

		public bool ContainsId(uint feature) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			bool raw_ret = gst_caps_features_contains_id(this_as_native, feature);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_caps_features_get_nth(IntPtr raw, uint i);

		public string GetNth(uint i) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = gst_caps_features_get_nth(this_as_native, i);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_caps_features_get_nth_id(IntPtr raw, uint i);

		public uint GetNthId(uint i) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			uint raw_ret = gst_caps_features_get_nth_id(this_as_native, i);
			uint ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_caps_features_get_size(IntPtr raw);

		public uint Size { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				uint raw_ret = gst_caps_features_get_size(this_as_native);
				uint ret = raw_ret;
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_caps_features_is_any(IntPtr raw);

		public bool IsAny { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				bool raw_ret = gst_caps_features_is_any(this_as_native);
				bool ret = raw_ret;
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_caps_features_is_equal(IntPtr raw, IntPtr features2);

		public bool IsEqual(Gst.CapsFeatures features2) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_features2 = GLib.Marshaller.StructureToPtrAlloc (features2);
			bool raw_ret = gst_caps_features_is_equal(this_as_native, native_features2);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			Marshal.FreeHGlobal (native_features2);
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_caps_features_remove(IntPtr raw, IntPtr feature);

		public void Remove(string feature) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_feature = GLib.Marshaller.StringToPtrGStrdup (feature);
			gst_caps_features_remove(this_as_native, native_feature);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_feature);
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_caps_features_remove_id(IntPtr raw, uint feature);

		public void RemoveId(uint feature) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			gst_caps_features_remove_id(this_as_native, feature);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_caps_features_set_parent_refcount(IntPtr raw, int refcount);

		public bool SetParentRefcount(int refcount) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			bool raw_ret = gst_caps_features_set_parent_refcount(this_as_native, refcount);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_caps_features_to_string(IntPtr raw);

		public override string ToString() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = gst_caps_features_to_string(this_as_native);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_caps_features_from_string(IntPtr features);

		public static Gst.CapsFeatures FromString(string features) {
			IntPtr native_features = GLib.Marshaller.StringToPtrGStrdup (features);
			IntPtr raw_ret = gst_caps_features_from_string(native_features);
			Gst.CapsFeatures ret = Gst.CapsFeatures.New (raw_ret);
			GLib.Marshaller.Free (native_features);
			return ret;
		}

		static void ReadNative (IntPtr native, ref Gst.CapsFeatures target)
		{
			target = New (native);
		}

		public bool Equals (CapsFeatures other)
		{
			return true;
		}

		public override bool Equals (object other)
		{
			return other is CapsFeatures && Equals ((CapsFeatures) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode ();
		}

		public static explicit operator GLib.Value (Gst.CapsFeatures boxed)
		{
			GLib.Value val = GLib.Value.Empty;
			val.Init (Gst.CapsFeatures.GType);
			val.Val = boxed;
			return val;
		}

		public static explicit operator Gst.CapsFeatures (GLib.Value val)
		{
			return (Gst.CapsFeatures) val.Val;
		}
#endregion
	}
}