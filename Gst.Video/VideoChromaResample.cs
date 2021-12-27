﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class VideoChromaResample : GLib.Opaque {

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_video_chroma_resample_get_info(IntPtr raw, uint n_lines, int offset);

		public void GetInfo(uint n_lines, int offset) {
			gst_video_chroma_resample_get_info(Handle, n_lines, offset);
		}

		public VideoChromaResample(IntPtr raw) : base(raw) {}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_video_chroma_resample_free(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			gst_video_chroma_resample_free (raw);
		}

		class FinalizerInfo {
			IntPtr handle;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				gst_video_chroma_resample_free (handle);
				return false;
			}
		}

		~VideoChromaResample ()
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
