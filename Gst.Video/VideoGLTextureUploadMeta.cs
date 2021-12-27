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
	public partial struct VideoGLTextureUploadMeta : IEquatable<VideoGLTextureUploadMeta> {

		public Gst.Meta Meta;
		public Gst.Video.VideoGLTextureOrientation TextureOrientation;
		public uint NTextures;
		[MarshalAs (UnmanagedType.ByValArray, SizeConst=4)]
		public Gst.Video.VideoGLTextureType[] TextureType;
		private IntPtr _buffer;
		private Gst.VideoSharp.VideoGLTextureUploadNative _upload;
		private IntPtr _user_data;

		public static Gst.Video.VideoGLTextureUploadMeta Zero = new Gst.Video.VideoGLTextureUploadMeta ();

		public static Gst.Video.VideoGLTextureUploadMeta New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Video.VideoGLTextureUploadMeta.Zero;
			return (Gst.Video.VideoGLTextureUploadMeta) Marshal.PtrToStructure (raw, typeof (Gst.Video.VideoGLTextureUploadMeta));
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_gl_texture_upload_meta_upload(IntPtr raw, uint texture_id);

		public bool Upload(uint texture_id) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			bool raw_ret = gst_video_gl_texture_upload_meta_upload(this_as_native, texture_id);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_gl_texture_upload_meta_get_info();

		public static Gst.MetaInfo Info { 
			get {
				IntPtr raw_ret = gst_video_gl_texture_upload_meta_get_info();
				Gst.MetaInfo ret = Gst.MetaInfo.New (raw_ret);
				return ret;
			}
		}

		static void ReadNative (IntPtr native, ref Gst.Video.VideoGLTextureUploadMeta target)
		{
			target = New (native);
		}

		public override bool Equals (object other)
		{
			return other is VideoGLTextureUploadMeta && Equals ((VideoGLTextureUploadMeta) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Meta.GetHashCode () ^ TextureOrientation.GetHashCode () ^ NTextures.GetHashCode () ^ TextureType.GetHashCode () ^ _buffer.GetHashCode () ^ _upload.GetHashCode () ^ _user_data.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
