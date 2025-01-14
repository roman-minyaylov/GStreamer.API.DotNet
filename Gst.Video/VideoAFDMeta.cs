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
	public partial struct VideoAFDMeta : IEquatable<VideoAFDMeta> {

		public Gst.Meta Meta;
		public byte Field;
		public Gst.Video.VideoAFDSpec Spec;
		public Gst.Video.VideoAFDValue Afd;

		public static Gst.Video.VideoAFDMeta Zero = new Gst.Video.VideoAFDMeta ();

		public static Gst.Video.VideoAFDMeta New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Video.VideoAFDMeta.Zero;
			return (Gst.Video.VideoAFDMeta) Marshal.PtrToStructure (raw, typeof (Gst.Video.VideoAFDMeta));
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_afd_meta_get_info();

		public static Gst.MetaInfo Info { 
			get {
				IntPtr raw_ret = gst_video_afd_meta_get_info();
				Gst.MetaInfo ret = Gst.MetaInfo.New (raw_ret);
				return ret;
			}
		}

		public bool Equals (VideoAFDMeta other)
		{
			return true && Meta.Equals (other.Meta) && Field.Equals (other.Field) && Spec.Equals (other.Spec) && Afd.Equals (other.Afd);
		}

		public override bool Equals (object other)
		{
			return other is VideoAFDMeta && Equals ((VideoAFDMeta) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Meta.GetHashCode () ^ Field.GetHashCode () ^ Spec.GetHashCode () ^ Afd.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
