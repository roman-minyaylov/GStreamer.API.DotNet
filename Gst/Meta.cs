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
	public partial struct Meta : IEquatable<Meta> {

		public Gst.MetaFlags Flags;
		private IntPtr _info;

		public Gst.MetaInfo info {
			get { return Gst.MetaInfo.New (_info); }
		}

		public static Gst.Meta Zero = new Gst.Meta ();

		public static Gst.Meta New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Meta.Zero;
			return (Gst.Meta) Marshal.PtrToStructure (raw, typeof (Gst.Meta));
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_meta_compare_seqnum(IntPtr raw, IntPtr meta2);

		public int CompareSeqnum(Gst.Meta meta2) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_meta2 = GLib.Marshaller.StructureToPtrAlloc (meta2);
			int raw_ret = gst_meta_compare_seqnum(this_as_native, native_meta2);
			int ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			Marshal.FreeHGlobal (native_meta2);
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern ulong gst_meta_get_seqnum(IntPtr raw);

		public ulong Seqnum { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				ulong raw_ret = gst_meta_get_seqnum(this_as_native);
				ulong ret = raw_ret;
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_meta_api_type_has_tag(IntPtr api, uint tag);

		public static bool ApiTypeHasTag(GLib.GType api, uint tag) {
			bool raw_ret = gst_meta_api_type_has_tag(api.Val, tag);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_meta_api_type_register(IntPtr api, IntPtr[] tags);

		public static GLib.GType ApiTypeRegister(string api, string[] tags) {
			IntPtr native_api = GLib.Marshaller.StringToPtrGStrdup (api);
			int cnt_tags = tags == null ? 0 : tags.Length;
			IntPtr[] native_tags = new IntPtr [cnt_tags + 1];
			for (int i = 0; i < cnt_tags; i++)
				native_tags [i] = GLib.Marshaller.StringToPtrGStrdup(tags[i]);
			native_tags [cnt_tags] = IntPtr.Zero;
			IntPtr raw_ret = gst_meta_api_type_register(native_api, native_tags);
			GLib.GType ret = new GLib.GType(raw_ret);
			GLib.Marshaller.Free (native_api);
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_meta_get_info(IntPtr impl);

		public static Gst.MetaInfo GetInfo(string impl) {
			IntPtr native_impl = GLib.Marshaller.StringToPtrGStrdup (impl);
			IntPtr raw_ret = gst_meta_get_info(native_impl);
			Gst.MetaInfo ret = Gst.MetaInfo.New (raw_ret);
			GLib.Marshaller.Free (native_impl);
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_meta_register(IntPtr api, IntPtr impl, UIntPtr size, GstSharp.MetaInitFunctionNative init_func, GstSharp.MetaFreeFunctionNative free_func, GstSharp.MetaTransformFunctionNative transform_func);

		public static Gst.MetaInfo Register(GLib.GType api, string impl, ulong size, Gst.MetaInitFunction init_func, Gst.MetaFreeFunction free_func, Gst.MetaTransformFunction transform_func) {
			IntPtr native_impl = GLib.Marshaller.StringToPtrGStrdup (impl);
			GstSharp.MetaInitFunctionWrapper init_func_wrapper = new GstSharp.MetaInitFunctionWrapper (init_func);
			init_func_wrapper.PersistUntilCalled ();
			GstSharp.MetaFreeFunctionWrapper free_func_wrapper = new GstSharp.MetaFreeFunctionWrapper (free_func);
			free_func_wrapper.PersistUntilCalled ();
			GstSharp.MetaTransformFunctionWrapper transform_func_wrapper = new GstSharp.MetaTransformFunctionWrapper (transform_func);
			transform_func_wrapper.PersistUntilCalled ();
			IntPtr raw_ret = gst_meta_register(api.Val, native_impl, new UIntPtr (size), init_func_wrapper.NativeDelegate, free_func_wrapper.NativeDelegate, transform_func_wrapper.NativeDelegate);
			Gst.MetaInfo ret = Gst.MetaInfo.New (raw_ret);
			GLib.Marshaller.Free (native_impl);
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_meta_register_custom(IntPtr name, IntPtr[] tags, GstSharp.CustomMetaTransformFunctionNative transform_func, IntPtr user_data, GLib.DestroyNotify destroy_data);

		public static Gst.MetaInfo RegisterCustom(string name, string[] tags, Gst.CustomMetaTransformFunction transform_func) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			int cnt_tags = tags == null ? 0 : tags.Length;
			IntPtr[] native_tags = new IntPtr [cnt_tags + 1];
			for (int i = 0; i < cnt_tags; i++)
				native_tags [i] = GLib.Marshaller.StringToPtrGStrdup(tags[i]);
			native_tags [cnt_tags] = IntPtr.Zero;
			GstSharp.CustomMetaTransformFunctionWrapper transform_func_wrapper = new GstSharp.CustomMetaTransformFunctionWrapper (transform_func);
			IntPtr user_data;
			GLib.DestroyNotify destroy_data;
			if (transform_func == null) {
				user_data = IntPtr.Zero;
				destroy_data = null;
			} else {
				user_data = (IntPtr) GCHandle.Alloc (transform_func_wrapper);
				destroy_data = GLib.DestroyHelper.NotifyHandler;
			}
			IntPtr raw_ret = gst_meta_register_custom(native_name, native_tags, transform_func_wrapper.NativeDelegate, user_data, destroy_data);
			Gst.MetaInfo ret = Gst.MetaInfo.New (raw_ret);
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		public static Gst.MetaInfo RegisterCustom(string name, string[] tags) {
			return RegisterCustom (name, tags, null);
		}

		static void ReadNative (IntPtr native, ref Gst.Meta target)
		{
			target = New (native);
		}

		public bool Equals (Meta other)
		{
			return true && Flags.Equals (other.Flags) && info.Equals (other.info);
		}

		public override bool Equals (object other)
		{
			return other is Meta && Equals ((Meta) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Flags.GetHashCode () ^ info.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
