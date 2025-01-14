﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class VideoOverlayComposition : Gst.MiniObject {

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_overlay_composition_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_video_overlay_composition_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_video_overlay_composition_add_rectangle(IntPtr raw, IntPtr rectangle);

		public void AddRectangle(Gst.Video.VideoOverlayRectangle rectangle) {
			gst_video_overlay_composition_add_rectangle(Handle, rectangle == null ? IntPtr.Zero : rectangle.Handle);
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_overlay_composition_blend(IntPtr raw, IntPtr video_buf);

		public bool Blend(Gst.Video.VideoFrame video_buf) {
			IntPtr native_video_buf = GLib.Marshaller.StructureToPtrAlloc (video_buf);
			bool raw_ret = gst_video_overlay_composition_blend(Handle, native_video_buf);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_video_buf);
			return ret;
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_overlay_composition_copy(IntPtr raw);

		public Gst.Video.VideoOverlayComposition Copy() {
			IntPtr raw_ret = gst_video_overlay_composition_copy(Handle);
			Gst.Video.VideoOverlayComposition ret = raw_ret == IntPtr.Zero ? null : (Gst.Video.VideoOverlayComposition) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Video.VideoOverlayComposition), true);
			return ret;
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_overlay_composition_get_rectangle(IntPtr raw, uint n);

		public Gst.Video.VideoOverlayRectangle GetRectangle(uint n) {
			IntPtr raw_ret = gst_video_overlay_composition_get_rectangle(Handle, n);
			Gst.Video.VideoOverlayRectangle ret = raw_ret == IntPtr.Zero ? null : (Gst.Video.VideoOverlayRectangle) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Video.VideoOverlayRectangle), false);
			return ret;
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_video_overlay_composition_get_seqnum(IntPtr raw);

		public uint Seqnum { 
			get {
				uint raw_ret = gst_video_overlay_composition_get_seqnum(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_overlay_composition_make_writable(IntPtr raw);

		public Gst.Video.VideoOverlayComposition MakeWritable() {
			IntPtr raw_ret = gst_video_overlay_composition_make_writable(Handle);
			Gst.Video.VideoOverlayComposition ret = raw_ret == IntPtr.Zero ? null : (Gst.Video.VideoOverlayComposition) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Video.VideoOverlayComposition), true);
			return ret;
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_video_overlay_composition_n_rectangles(IntPtr raw);

		public uint NRectangles() {
			uint raw_ret = gst_video_overlay_composition_n_rectangles(Handle);
			uint ret = raw_ret;
			return ret;
		}

		public VideoOverlayComposition(IntPtr raw) : base(raw) {}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_overlay_composition_new(IntPtr rectangle);

		public VideoOverlayComposition (Gst.Video.VideoOverlayRectangle rectangle) 
		{
			Raw = gst_video_overlay_composition_new(rectangle == null ? IntPtr.Zero : rectangle.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (Gst.MiniObject.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
