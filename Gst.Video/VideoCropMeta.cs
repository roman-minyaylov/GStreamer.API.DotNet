﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct VideoCropMeta : IEquatable<VideoCropMeta> {

		public Gst.Meta Meta;
		public uint X;
		public uint Y;
		public uint Width;
		public uint Height;

		public static Gst.Video.VideoCropMeta Zero = new Gst.Video.VideoCropMeta ();

		public static Gst.Video.VideoCropMeta New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Video.VideoCropMeta.Zero;
			return (Gst.Video.VideoCropMeta) Marshal.PtrToStructure (raw, typeof (Gst.Video.VideoCropMeta));
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_crop_meta_get_info();

		public static Gst.MetaInfo Info { 
			get {
				IntPtr raw_ret = gst_video_crop_meta_get_info();
				Gst.MetaInfo ret = Gst.MetaInfo.New (raw_ret);
				return ret;
			}
		}

		public bool Equals (VideoCropMeta other)
		{
			return true && Meta.Equals (other.Meta) && X.Equals (other.X) && Y.Equals (other.Y) && Width.Equals (other.Width) && Height.Equals (other.Height);
		}

		public override bool Equals (object other)
		{
			return other is VideoCropMeta && Equals ((VideoCropMeta) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Meta.GetHashCode () ^ X.GetHashCode () ^ Y.GetHashCode () ^ Width.GetHashCode () ^ Height.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
