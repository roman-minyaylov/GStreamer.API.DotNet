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
	public partial struct RTSPUrl : IEquatable<RTSPUrl> {

		public Gst.Rtsp.RTSPLowerTrans Transports;
		public Gst.Rtsp.RTSPFamily Family;
		public string User;
		public string Passwd;
		public string Host;
		public ushort Port;
		public string Abspath;
		public string Query;

		public static Gst.Rtsp.RTSPUrl Zero = new Gst.Rtsp.RTSPUrl ();

		public static Gst.Rtsp.RTSPUrl New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Rtsp.RTSPUrl.Zero;
			return (Gst.Rtsp.RTSPUrl) Marshal.PtrToStructure (raw, typeof (Gst.Rtsp.RTSPUrl));
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_url_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_rtsp_url_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_url_decode_path_components(IntPtr raw);

		public string[] DecodePathComponents() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = gst_rtsp_url_decode_path_components(this_as_native);
			string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, true);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_url_get_port(IntPtr raw, out ushort port);

		public Gst.Rtsp.RTSPResult GetPort(out ushort port) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			int raw_ret = gst_rtsp_url_get_port(this_as_native, out port);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_url_get_request_uri(IntPtr raw);

		public string RequestUri { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				IntPtr raw_ret = gst_rtsp_url_get_request_uri(this_as_native);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_url_get_request_uri_with_control(IntPtr raw, IntPtr control_path);

		public string GetRequestUriWithControl(string control_path) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_control_path = GLib.Marshaller.StringToPtrGStrdup (control_path);
			IntPtr raw_ret = gst_rtsp_url_get_request_uri_with_control(this_as_native, native_control_path);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_control_path);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_url_set_port(IntPtr raw, ushort port);

		public Gst.Rtsp.RTSPResult SetPort(ushort port) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			int raw_ret = gst_rtsp_url_set_port(this_as_native, port);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_url_parse(IntPtr urlstr, IntPtr url);

		public static Gst.Rtsp.RTSPResult Parse(string urlstr, out Gst.Rtsp.RTSPUrl url) {
			IntPtr native_urlstr = GLib.Marshaller.StringToPtrGStrdup (urlstr);
			IntPtr native_url = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gst.Rtsp.RTSPUrl)));
			int raw_ret = gst_rtsp_url_parse(native_urlstr, native_url);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			GLib.Marshaller.Free (native_urlstr);
			url = Gst.Rtsp.RTSPUrl.New (native_url);
			Marshal.FreeHGlobal (native_url);
			return ret;
		}

		static void ReadNative (IntPtr native, ref Gst.Rtsp.RTSPUrl target)
		{
			target = New (native);
		}

		public bool Equals (RTSPUrl other)
		{
			return true && Transports.Equals (other.Transports) && Family.Equals (other.Family) && User.Equals (other.User) && Passwd.Equals (other.Passwd) && Host.Equals (other.Host) && Port.Equals (other.Port) && Abspath.Equals (other.Abspath) && Query.Equals (other.Query);
		}

		public override bool Equals (object other)
		{
			return other is RTSPUrl && Equals ((RTSPUrl) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Transports.GetHashCode () ^ Family.GetHashCode () ^ User.GetHashCode () ^ Passwd.GetHashCode () ^ Host.GetHashCode () ^ Port.GetHashCode () ^ Abspath.GetHashCode () ^ Query.GetHashCode ();
		}

		public static explicit operator GLib.Value (Gst.Rtsp.RTSPUrl boxed)
		{
			GLib.Value val = GLib.Value.Empty;
			val.Init (Gst.Rtsp.RTSPUrl.GType);
			val.Val = boxed;
			return val;
		}

		public static explicit operator Gst.Rtsp.RTSPUrl (GLib.Value val)
		{
			return (Gst.Rtsp.RTSPUrl) val.Val;
		}
#endregion
	}
}
