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
	public partial struct VideoBarMeta : IEquatable<VideoBarMeta> {

		public Gst.Meta Meta;
		public byte Field;
		public bool IsLetterbox;
		public uint BarData1;
		public uint BarData2;

		public static Gst.Video.VideoBarMeta Zero = new Gst.Video.VideoBarMeta ();

		public static Gst.Video.VideoBarMeta New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Video.VideoBarMeta.Zero;
			return (Gst.Video.VideoBarMeta) Marshal.PtrToStructure (raw, typeof (Gst.Video.VideoBarMeta));
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_bar_meta_get_info();

		public static Gst.MetaInfo Info { 
			get {
				IntPtr raw_ret = gst_video_bar_meta_get_info();
				Gst.MetaInfo ret = Gst.MetaInfo.New (raw_ret);
				return ret;
			}
		}

		public bool Equals (VideoBarMeta other)
		{
			return true && Meta.Equals (other.Meta) && Field.Equals (other.Field) && IsLetterbox.Equals (other.IsLetterbox) && BarData1.Equals (other.BarData1) && BarData2.Equals (other.BarData2);
		}

		public override bool Equals (object other)
		{
			return other is VideoBarMeta && Equals ((VideoBarMeta) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Meta.GetHashCode () ^ Field.GetHashCode () ^ IsLetterbox.GetHashCode () ^ BarData1.GetHashCode () ^ BarData2.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
