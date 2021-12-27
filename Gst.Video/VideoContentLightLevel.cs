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
	public partial struct VideoContentLightLevel : IEquatable<VideoContentLightLevel> {

		public ushort MaxContentLightLevel;
		public ushort MaxFrameAverageLightLevel;
		[MarshalAs (UnmanagedType.ByValArray, SizeConst=4)]
		private IntPtr[] _gstGstReserved;

		public static Gst.Video.VideoContentLightLevel Zero = new Gst.Video.VideoContentLightLevel ();

		public static Gst.Video.VideoContentLightLevel New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Video.VideoContentLightLevel.Zero;
			return (Gst.Video.VideoContentLightLevel) Marshal.PtrToStructure (raw, typeof (Gst.Video.VideoContentLightLevel));
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_content_light_level_add_to_caps(IntPtr raw, IntPtr caps);

		public bool AddToCaps(Gst.Caps caps) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			bool raw_ret = gst_video_content_light_level_add_to_caps(this_as_native, caps == null ? IntPtr.Zero : caps.Handle);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_content_light_level_from_caps(IntPtr raw, IntPtr caps);

		public bool FromCaps(Gst.Caps caps) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			bool raw_ret = gst_video_content_light_level_from_caps(this_as_native, caps == null ? IntPtr.Zero : caps.Handle);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_content_light_level_from_string(IntPtr raw, IntPtr level);

		public bool FromString(string level) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_level = GLib.Marshaller.StringToPtrGStrdup (level);
			bool raw_ret = gst_video_content_light_level_from_string(this_as_native, native_level);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_level);
			return ret;
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_video_content_light_level_init(IntPtr raw);

		public void Init() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			gst_video_content_light_level_init(this_as_native);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_content_light_level_to_string(IntPtr raw);

		public override string ToString() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = gst_video_content_light_level_to_string(this_as_native);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		static void ReadNative (IntPtr native, ref Gst.Video.VideoContentLightLevel target)
		{
			target = New (native);
		}

		public bool Equals (VideoContentLightLevel other)
		{
			return true && MaxContentLightLevel.Equals (other.MaxContentLightLevel) && MaxFrameAverageLightLevel.Equals (other.MaxFrameAverageLightLevel);
		}

		public override bool Equals (object other)
		{
			return other is VideoContentLightLevel && Equals ((VideoContentLightLevel) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ MaxContentLightLevel.GetHashCode () ^ MaxFrameAverageLightLevel.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
