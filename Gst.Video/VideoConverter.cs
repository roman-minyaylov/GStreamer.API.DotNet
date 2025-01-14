﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class VideoConverter : GLib.Opaque {

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_video_converter_frame(IntPtr raw, IntPtr src, IntPtr dest);

		public void Frame(Gst.Video.VideoFrame src, Gst.Video.VideoFrame dest) {
			IntPtr native_src = GLib.Marshaller.StructureToPtrAlloc (src);
			IntPtr native_dest = GLib.Marshaller.StructureToPtrAlloc (dest);
			gst_video_converter_frame(Handle, native_src, native_dest);
			Marshal.FreeHGlobal (native_src);
			Marshal.FreeHGlobal (native_dest);
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_converter_get_config(IntPtr raw);

		public Gst.Structure Config { 
			get {
				IntPtr raw_ret = gst_video_converter_get_config(Handle);
				Gst.Structure ret = raw_ret == IntPtr.Zero ? null : (Gst.Structure) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Structure), false);
				return ret;
			}
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_converter_set_config(IntPtr raw, IntPtr config);

		public bool SetConfig(Gst.Structure config) {
			config.Owned = false;
			bool raw_ret = gst_video_converter_set_config(Handle, config == null ? IntPtr.Zero : config.Handle);
			bool ret = raw_ret;
			return ret;
		}

		public VideoConverter(IntPtr raw) : base(raw) {}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_video_converter_free(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			gst_video_converter_free (raw);
		}

		class FinalizerInfo {
			IntPtr handle;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				gst_video_converter_free (handle);
				return false;
			}
		}

		~VideoConverter ()
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
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
