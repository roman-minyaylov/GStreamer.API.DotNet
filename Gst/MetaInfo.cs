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
	public partial struct MetaInfo : IEquatable<MetaInfo> {

		public GLib.GType Api;
		public GLib.GType Type;
		private UIntPtr size;
		public ulong Size {
			get {
				return (ulong) size;
			}
			set {
				size = new UIntPtr (value);
			}
		}
		private GstSharp.MetaInitFunctionNative _init_func;
		public Gst.MetaInitFunction InitFunc {
			get {
				return GstSharp.MetaInitFunctionWrapper.GetManagedDelegate (_init_func);
			}
		}
		private GstSharp.MetaFreeFunctionNative _free_func;
		public Gst.MetaFreeFunction FreeFunc {
			get {
				return GstSharp.MetaFreeFunctionWrapper.GetManagedDelegate (_free_func);
			}
		}
		private GstSharp.MetaTransformFunctionNative _transform_func;
		public Gst.MetaTransformFunction TransformFunc {
			get {
				return GstSharp.MetaTransformFunctionWrapper.GetManagedDelegate (_transform_func);
			}
		}

		public static Gst.MetaInfo Zero = new Gst.MetaInfo ();

		public static Gst.MetaInfo New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.MetaInfo.Zero;
			return (Gst.MetaInfo) Marshal.PtrToStructure (raw, typeof (Gst.MetaInfo));
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_meta_info_is_custom(IntPtr raw);

		public bool IsCustom { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				bool raw_ret = gst_meta_info_is_custom(this_as_native);
				bool ret = raw_ret;
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		static void ReadNative (IntPtr native, ref Gst.MetaInfo target)
		{
			target = New (native);
		}

		public bool Equals (MetaInfo other)
		{
			return true && Api.Equals (other.Api) && Type.Equals (other.Type) && Size.Equals (other.Size) && InitFunc.Equals (other.InitFunc) && FreeFunc.Equals (other.FreeFunc) && TransformFunc.Equals (other.TransformFunc);
		}

		public override bool Equals (object other)
		{
			return other is MetaInfo && Equals ((MetaInfo) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Api.GetHashCode () ^ Type.GetHashCode () ^ Size.GetHashCode () ^ InitFunc.GetHashCode () ^ FreeFunc.GetHashCode () ^ TransformFunc.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}