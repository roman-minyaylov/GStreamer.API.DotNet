﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Rtsp {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct RTSPTransport : IEquatable<RTSPTransport> {

		public Gst.Rtsp.RTSPTransMode Trans;
		public Gst.Rtsp.RTSPProfile Profile;
		public Gst.Rtsp.RTSPLowerTrans LowerTransport;
		public string Destination;
		public string Source;
		public uint Layers;
		public bool ModePlay;
		public bool ModeRecord;
		public bool Append;
		public Gst.Rtsp.RTSPRange Interleaved;
		public uint Ttl;
		public Gst.Rtsp.RTSPRange Port;
		public Gst.Rtsp.RTSPRange ClientPort;
		public Gst.Rtsp.RTSPRange ServerPort;
		public uint Ssrc;
		[MarshalAs (UnmanagedType.ByValArray, SizeConst=4)]
		private IntPtr[] _gstGstReserved;

		public static Gst.Rtsp.RTSPTransport Zero = new Gst.Rtsp.RTSPTransport ();

		public static Gst.Rtsp.RTSPTransport New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Rtsp.RTSPTransport.Zero;
			return (Gst.Rtsp.RTSPTransport) Marshal.PtrToStructure (raw, typeof (Gst.Rtsp.RTSPTransport));
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_transport_as_text(IntPtr raw);

		public string AsText() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = gst_rtsp_transport_as_text(this_as_native);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_transport_free(IntPtr raw);

		public Gst.Rtsp.RTSPResult Free() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			int raw_ret = gst_rtsp_transport_free(this_as_native);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_transport_get_media_type(IntPtr raw, out IntPtr media_type);

		public Gst.Rtsp.RTSPResult GetMediaType(out string media_type) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_media_type;
			int raw_ret = gst_rtsp_transport_get_media_type(this_as_native, out native_media_type);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			media_type = GLib.Marshaller.Utf8PtrToString (native_media_type);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_transport_init(IntPtr raw);

		public Gst.Rtsp.RTSPResult Init() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			int raw_ret = gst_rtsp_transport_init(this_as_native);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_transport_get_manager(int trans, out IntPtr manager, uint option);

		public static Gst.Rtsp.RTSPResult GetManager(Gst.Rtsp.RTSPTransMode trans, out string manager, uint option) {
			IntPtr native_manager;
			int raw_ret = gst_rtsp_transport_get_manager((int) trans, out native_manager, option);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			manager = GLib.Marshaller.Utf8PtrToString (native_manager);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_transport_get_mime(int trans, IntPtr mime);

		[Obsolete]
		public static Gst.Rtsp.RTSPResult GetMime(Gst.Rtsp.RTSPTransMode trans, string mime) {
			IntPtr native_mime = GLib.Marshaller.StringToPtrGStrdup (mime);
			int raw_ret = gst_rtsp_transport_get_mime((int) trans, native_mime);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			GLib.Marshaller.Free (native_mime);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_transport_new(IntPtr transport);

		public static Gst.Rtsp.RTSPResult New(Gst.Rtsp.RTSPTransport transport) {
			IntPtr native_transport = GLib.Marshaller.StructureToPtrAlloc (transport);
			int raw_ret = gst_rtsp_transport_new(native_transport);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			Marshal.FreeHGlobal (native_transport);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_transport_parse(IntPtr str, IntPtr transport);

		public static Gst.Rtsp.RTSPResult Parse(string str, Gst.Rtsp.RTSPTransport transport) {
			IntPtr native_str = GLib.Marshaller.StringToPtrGStrdup (str);
			IntPtr native_transport = GLib.Marshaller.StructureToPtrAlloc (transport);
			int raw_ret = gst_rtsp_transport_parse(native_str, native_transport);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			GLib.Marshaller.Free (native_str);
			Marshal.FreeHGlobal (native_transport);
			return ret;
		}

		static void ReadNative (IntPtr native, ref Gst.Rtsp.RTSPTransport target)
		{
			target = New (native);
		}

		public bool Equals (RTSPTransport other)
		{
			return true && Trans.Equals (other.Trans) && Profile.Equals (other.Profile) && LowerTransport.Equals (other.LowerTransport) && Destination.Equals (other.Destination) && Source.Equals (other.Source) && Layers.Equals (other.Layers) && ModePlay.Equals (other.ModePlay) && ModeRecord.Equals (other.ModeRecord) && Append.Equals (other.Append) && Interleaved.Equals (other.Interleaved) && Ttl.Equals (other.Ttl) && Port.Equals (other.Port) && ClientPort.Equals (other.ClientPort) && ServerPort.Equals (other.ServerPort) && Ssrc.Equals (other.Ssrc);
		}

		public override bool Equals (object other)
		{
			return other is RTSPTransport && Equals ((RTSPTransport) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Trans.GetHashCode () ^ Profile.GetHashCode () ^ LowerTransport.GetHashCode () ^ Destination.GetHashCode () ^ Source.GetHashCode () ^ Layers.GetHashCode () ^ ModePlay.GetHashCode () ^ ModeRecord.GetHashCode () ^ Append.GetHashCode () ^ Interleaved.GetHashCode () ^ Ttl.GetHashCode () ^ Port.GetHashCode () ^ ClientPort.GetHashCode () ^ ServerPort.GetHashCode () ^ Ssrc.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
