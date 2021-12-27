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
	public partial struct VideoVBIParser : IEquatable<VideoVBIParser> {


		public static Gst.Video.VideoVBIParser Zero = new Gst.Video.VideoVBIParser ();

		public static Gst.Video.VideoVBIParser New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Video.VideoVBIParser.Zero;
			return (Gst.Video.VideoVBIParser) Marshal.PtrToStructure (raw, typeof (Gst.Video.VideoVBIParser));
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_vbi_parser_new(int format, uint pixel_width);

		public static VideoVBIParser New(Gst.Video.VideoFormat format, uint pixel_width)
		{
			VideoVBIParser result = VideoVBIParser.New (gst_video_vbi_parser_new((int) format, pixel_width));
			return result;
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_vbi_parser_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_video_vbi_parser_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_video_vbi_parser_add_line(IntPtr raw, byte[] data);

		public void AddLine(byte[] data) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			gst_video_vbi_parser_add_line(this_as_native, data);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_video_vbi_parser_get_ancillary(IntPtr raw, IntPtr anc);

		public Gst.Video.VideoVBIParserResult GetAncillary(out Gst.Video.VideoAncillary anc) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_anc = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gst.Video.VideoAncillary)));
			int raw_ret = gst_video_vbi_parser_get_ancillary(this_as_native, native_anc);
			Gst.Video.VideoVBIParserResult ret = (Gst.Video.VideoVBIParserResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			anc = Gst.Video.VideoAncillary.New (native_anc);
			Marshal.FreeHGlobal (native_anc);
			return ret;
		}

		static void ReadNative (IntPtr native, ref Gst.Video.VideoVBIParser target)
		{
			target = New (native);
		}

		public bool Equals (VideoVBIParser other)
		{
			return true;
		}

		public override bool Equals (object other)
		{
			return other is VideoVBIParser && Equals ((VideoVBIParser) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode ();
		}

		public static explicit operator GLib.Value (Gst.Video.VideoVBIParser boxed)
		{
			GLib.Value val = GLib.Value.Empty;
			val.Init (Gst.Video.VideoVBIParser.GType);
			val.Val = boxed;
			return val;
		}

		public static explicit operator Gst.Video.VideoVBIParser (GLib.Value val)
		{
			return (Gst.Video.VideoVBIParser) val.Val;
		}
#endregion
	}
}
