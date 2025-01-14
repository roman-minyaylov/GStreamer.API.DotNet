﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Rtsp {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class Global {

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_rtsp_auth_credentials_free(IntPtr credentials);

		public static void RtspAuthCredentialsFree(Gst.Rtsp.RTSPAuthCredential credentials) {
			IntPtr native_credentials = GLib.Marshaller.StructureToPtrAlloc (credentials);
			gst_rtsp_auth_credentials_free(native_credentials);
			Marshal.FreeHGlobal (native_credentials);
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_connection_accept(IntPtr socket, out IntPtr conn, IntPtr cancellable);

		public static Gst.Rtsp.RTSPResult RtspConnectionAccept(GLib.Socket socket, out Gst.Rtsp.RTSPConnection conn, GLib.Cancellable cancellable) {
			IntPtr native_conn;
			int raw_ret = gst_rtsp_connection_accept(socket == null ? IntPtr.Zero : socket.Handle, out native_conn, cancellable == null ? IntPtr.Zero : cancellable.Handle);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			conn = native_conn == IntPtr.Zero ? null : (Gst.Rtsp.RTSPConnection) GLib.Opaque.GetOpaque (native_conn, typeof (Gst.Rtsp.RTSPConnection), true);
			return ret;
		}

		public static Gst.Rtsp.RTSPResult RtspConnectionAccept(GLib.Socket socket, out Gst.Rtsp.RTSPConnection conn) {
			return RtspConnectionAccept (socket, out conn, null);
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_connection_create(IntPtr url, out IntPtr conn);

		public static Gst.Rtsp.RTSPResult RtspConnectionCreate(Gst.Rtsp.RTSPUrl url, out Gst.Rtsp.RTSPConnection conn) {
			IntPtr native_url = GLib.Marshaller.StructureToPtrAlloc (url);
			IntPtr native_conn;
			int raw_ret = gst_rtsp_connection_create(native_url, out native_conn);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			Marshal.FreeHGlobal (native_url);
			conn = native_conn == IntPtr.Zero ? null : (Gst.Rtsp.RTSPConnection) GLib.Opaque.GetOpaque (native_conn, typeof (Gst.Rtsp.RTSPConnection), true);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_connection_create_from_socket(IntPtr socket, IntPtr ip, ushort port, IntPtr initial_buffer, out IntPtr conn);

		public static Gst.Rtsp.RTSPResult RtspConnectionCreateFromSocket(GLib.Socket socket, string ip, ushort port, string initial_buffer, out Gst.Rtsp.RTSPConnection conn) {
			IntPtr native_ip = GLib.Marshaller.StringToPtrGStrdup (ip);
			IntPtr native_initial_buffer = GLib.Marshaller.StringToPtrGStrdup (initial_buffer);
			IntPtr native_conn;
			int raw_ret = gst_rtsp_connection_create_from_socket(socket == null ? IntPtr.Zero : socket.Handle, native_ip, port, native_initial_buffer, out native_conn);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			GLib.Marshaller.Free (native_ip);
			GLib.Marshaller.Free (native_initial_buffer);
			conn = native_conn == IntPtr.Zero ? null : (Gst.Rtsp.RTSPConnection) GLib.Opaque.GetOpaque (native_conn, typeof (Gst.Rtsp.RTSPConnection), true);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_find_header_field(IntPtr header);

		public static Gst.Rtsp.RTSPHeaderField RtspFindHeaderField(string header) {
			IntPtr native_header = GLib.Marshaller.StringToPtrGStrdup (header);
			int raw_ret = gst_rtsp_find_header_field(native_header);
			Gst.Rtsp.RTSPHeaderField ret = (Gst.Rtsp.RTSPHeaderField) raw_ret;
			GLib.Marshaller.Free (native_header);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_find_method(IntPtr method);

		public static Gst.Rtsp.RTSPMethod RtspFindMethod(string method) {
			IntPtr native_method = GLib.Marshaller.StringToPtrGStrdup (method);
			int raw_ret = gst_rtsp_find_method(native_method);
			Gst.Rtsp.RTSPMethod ret = (Gst.Rtsp.RTSPMethod) raw_ret;
			GLib.Marshaller.Free (native_method);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_generate_digest_auth_response(IntPtr algorithm, IntPtr method, IntPtr realm, IntPtr username, IntPtr password, IntPtr uri, IntPtr nonce);

		public static string RtspGenerateDigestAuthResponse(string algorithm, string method, string realm, string username, string password, string uri, string nonce) {
			IntPtr native_algorithm = GLib.Marshaller.StringToPtrGStrdup (algorithm);
			IntPtr native_method = GLib.Marshaller.StringToPtrGStrdup (method);
			IntPtr native_realm = GLib.Marshaller.StringToPtrGStrdup (realm);
			IntPtr native_username = GLib.Marshaller.StringToPtrGStrdup (username);
			IntPtr native_password = GLib.Marshaller.StringToPtrGStrdup (password);
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr native_nonce = GLib.Marshaller.StringToPtrGStrdup (nonce);
			IntPtr raw_ret = gst_rtsp_generate_digest_auth_response(native_algorithm, native_method, native_realm, native_username, native_password, native_uri, native_nonce);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_algorithm);
			GLib.Marshaller.Free (native_method);
			GLib.Marshaller.Free (native_realm);
			GLib.Marshaller.Free (native_username);
			GLib.Marshaller.Free (native_password);
			GLib.Marshaller.Free (native_uri);
			GLib.Marshaller.Free (native_nonce);
			return ret;
		}

		public static string RtspGenerateDigestAuthResponse(string method, string realm, string username, string password, string uri, string nonce) {
			return RtspGenerateDigestAuthResponse (null, method, realm, username, password, uri, nonce);
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_generate_digest_auth_response_from_md5(IntPtr algorithm, IntPtr method, IntPtr md5, IntPtr uri, IntPtr nonce);

		public static string RtspGenerateDigestAuthResponseFromMd5(string algorithm, string method, string md5, string uri, string nonce) {
			IntPtr native_algorithm = GLib.Marshaller.StringToPtrGStrdup (algorithm);
			IntPtr native_method = GLib.Marshaller.StringToPtrGStrdup (method);
			IntPtr native_md5 = GLib.Marshaller.StringToPtrGStrdup (md5);
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr native_nonce = GLib.Marshaller.StringToPtrGStrdup (nonce);
			IntPtr raw_ret = gst_rtsp_generate_digest_auth_response_from_md5(native_algorithm, native_method, native_md5, native_uri, native_nonce);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_algorithm);
			GLib.Marshaller.Free (native_method);
			GLib.Marshaller.Free (native_md5);
			GLib.Marshaller.Free (native_uri);
			GLib.Marshaller.Free (native_nonce);
			return ret;
		}

		public static string RtspGenerateDigestAuthResponseFromMd5(string method, string md5, string uri, string nonce) {
			return RtspGenerateDigestAuthResponseFromMd5 (null, method, md5, uri, nonce);
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_rtsp_header_allow_multiple(int field);

		public static bool RtspHeaderAllowMultiple(Gst.Rtsp.RTSPHeaderField field) {
			bool raw_ret = gst_rtsp_header_allow_multiple((int) field);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_header_as_text(int field);

		public static string RtspHeaderAsText(Gst.Rtsp.RTSPHeaderField field) {
			IntPtr raw_ret = gst_rtsp_header_as_text((int) field);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_message_new(IntPtr msg);

		public static Gst.Rtsp.RTSPResult RtspMessageNew(out Gst.Rtsp.RTSPMessage msg) {
			IntPtr native_msg = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gst.Rtsp.RTSPMessage)));
			int raw_ret = gst_rtsp_message_new(native_msg);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			msg = Gst.Rtsp.RTSPMessage.New (native_msg);
			Marshal.FreeHGlobal (native_msg);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_message_new_data(IntPtr msg, byte channel);

		public static Gst.Rtsp.RTSPResult RtspMessageNewData(out Gst.Rtsp.RTSPMessage msg, byte channel) {
			IntPtr native_msg = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gst.Rtsp.RTSPMessage)));
			int raw_ret = gst_rtsp_message_new_data(native_msg, channel);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			msg = Gst.Rtsp.RTSPMessage.New (native_msg);
			Marshal.FreeHGlobal (native_msg);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_message_new_request(IntPtr msg, int method, IntPtr uri);

		public static Gst.Rtsp.RTSPResult RtspMessageNewRequest(out Gst.Rtsp.RTSPMessage msg, Gst.Rtsp.RTSPMethod method, string uri) {
			IntPtr native_msg = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gst.Rtsp.RTSPMessage)));
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			int raw_ret = gst_rtsp_message_new_request(native_msg, (int) method, native_uri);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			msg = Gst.Rtsp.RTSPMessage.New (native_msg);
			Marshal.FreeHGlobal (native_msg);
			GLib.Marshaller.Free (native_uri);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_message_new_response(IntPtr msg, int code, IntPtr reason, IntPtr request);

		public static Gst.Rtsp.RTSPResult RtspMessageNewResponse(out Gst.Rtsp.RTSPMessage msg, Gst.Rtsp.RTSPStatusCode code, string reason, Gst.Rtsp.RTSPMessage request) {
			IntPtr native_msg = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gst.Rtsp.RTSPMessage)));
			IntPtr native_reason = GLib.Marshaller.StringToPtrGStrdup (reason);
			IntPtr native_request = GLib.Marshaller.StructureToPtrAlloc (request);
			int raw_ret = gst_rtsp_message_new_response(native_msg, (int) code, native_reason, native_request);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			msg = Gst.Rtsp.RTSPMessage.New (native_msg);
			Marshal.FreeHGlobal (native_msg);
			GLib.Marshaller.Free (native_reason);
			Marshal.FreeHGlobal (native_request);
			return ret;
		}

		public static Gst.Rtsp.RTSPResult RtspMessageNewResponse(out Gst.Rtsp.RTSPMessage msg, Gst.Rtsp.RTSPStatusCode code) {
			return RtspMessageNewResponse (out msg, code, null, Gst.Rtsp.RTSPMessage.Zero);
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_method_as_text(int method);

		public static string RtspMethodAsText(Gst.Rtsp.RTSPMethod method) {
			IntPtr raw_ret = gst_rtsp_method_as_text((int) method);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_options_as_text(int options);

		public static string RtspOptionsAsText(Gst.Rtsp.RTSPMethod options) {
			IntPtr raw_ret = gst_rtsp_options_as_text((int) options);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_options_from_text(IntPtr options);

		public static Gst.Rtsp.RTSPMethod RtspOptionsFromText(string options) {
			IntPtr native_options = GLib.Marshaller.StringToPtrGStrdup (options);
			int raw_ret = gst_rtsp_options_from_text(native_options);
			Gst.Rtsp.RTSPMethod ret = (Gst.Rtsp.RTSPMethod) raw_ret;
			GLib.Marshaller.Free (native_options);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_rtsp_range_convert_units(IntPtr range, int unit);

		public static bool RtspRangeConvertUnits(Gst.Rtsp.RTSPTimeRange range, Gst.Rtsp.RTSPRangeUnit unit) {
			IntPtr native_range = GLib.Marshaller.StructureToPtrAlloc (range);
			bool raw_ret = gst_rtsp_range_convert_units(native_range, (int) unit);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_range);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_rtsp_range_free(IntPtr range);

		public static void RtspRangeFree(Gst.Rtsp.RTSPTimeRange range) {
			IntPtr native_range = GLib.Marshaller.StructureToPtrAlloc (range);
			gst_rtsp_range_free(native_range);
			Marshal.FreeHGlobal (native_range);
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_rtsp_range_get_times(IntPtr range, out ulong min, out ulong max);

		public static bool RtspRangeGetTimes(Gst.Rtsp.RTSPTimeRange range, out ulong min, out ulong max) {
			IntPtr native_range = GLib.Marshaller.StructureToPtrAlloc (range);
			bool raw_ret = gst_rtsp_range_get_times(native_range, out min, out max);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_range);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_range_parse(IntPtr rangestr, IntPtr range);

		public static Gst.Rtsp.RTSPResult RtspRangeParse(string rangestr, out Gst.Rtsp.RTSPTimeRange range) {
			IntPtr native_rangestr = GLib.Marshaller.StringToPtrGStrdup (rangestr);
			IntPtr native_range = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gst.Rtsp.RTSPTimeRange)));
			int raw_ret = gst_rtsp_range_parse(native_rangestr, native_range);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			GLib.Marshaller.Free (native_rangestr);
			range = Gst.Rtsp.RTSPTimeRange.New (native_range);
			Marshal.FreeHGlobal (native_range);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_range_to_string(IntPtr range);

		public static string RtspRangeToString(Gst.Rtsp.RTSPTimeRange range) {
			IntPtr native_range = GLib.Marshaller.StructureToPtrAlloc (range);
			IntPtr raw_ret = gst_rtsp_range_to_string(native_range);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			Marshal.FreeHGlobal (native_range);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_status_as_text(int code);

		public static string RtspStatusAsText(Gst.Rtsp.RTSPStatusCode code) {
			IntPtr raw_ret = gst_rtsp_status_as_text((int) code);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_strresult(int _result);

		public static string RtspStrresult(Gst.Rtsp.RTSPResult _result) {
			IntPtr raw_ret = gst_rtsp_strresult((int) _result);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_transport_get_manager(int trans, out IntPtr manager, uint option);

		public static Gst.Rtsp.RTSPResult RtspTransportGetManager(Gst.Rtsp.RTSPTransMode trans, out string manager, uint option) {
			IntPtr native_manager;
			int raw_ret = gst_rtsp_transport_get_manager((int) trans, out native_manager, option);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			manager = GLib.Marshaller.Utf8PtrToString (native_manager);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_transport_get_mime(int trans, IntPtr mime);

		[Obsolete]
		public static Gst.Rtsp.RTSPResult RtspTransportGetMime(Gst.Rtsp.RTSPTransMode trans, string mime) {
			IntPtr native_mime = GLib.Marshaller.StringToPtrGStrdup (mime);
			int raw_ret = gst_rtsp_transport_get_mime((int) trans, native_mime);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			GLib.Marshaller.Free (native_mime);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_transport_new(IntPtr transport);

		public static Gst.Rtsp.RTSPResult RtspTransportNew(Gst.Rtsp.RTSPTransport transport) {
			IntPtr native_transport = GLib.Marshaller.StructureToPtrAlloc (transport);
			int raw_ret = gst_rtsp_transport_new(native_transport);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			Marshal.FreeHGlobal (native_transport);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_transport_parse(IntPtr str, IntPtr transport);

		public static Gst.Rtsp.RTSPResult RtspTransportParse(string str, Gst.Rtsp.RTSPTransport transport) {
			IntPtr native_str = GLib.Marshaller.StringToPtrGStrdup (str);
			IntPtr native_transport = GLib.Marshaller.StructureToPtrAlloc (transport);
			int raw_ret = gst_rtsp_transport_parse(native_str, native_transport);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			GLib.Marshaller.Free (native_str);
			Marshal.FreeHGlobal (native_transport);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_url_parse(IntPtr urlstr, IntPtr url);

		public static Gst.Rtsp.RTSPResult RtspUrlParse(string urlstr, out Gst.Rtsp.RTSPUrl url) {
			IntPtr native_urlstr = GLib.Marshaller.StringToPtrGStrdup (urlstr);
			IntPtr native_url = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gst.Rtsp.RTSPUrl)));
			int raw_ret = gst_rtsp_url_parse(native_urlstr, native_url);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			GLib.Marshaller.Free (native_urlstr);
			url = Gst.Rtsp.RTSPUrl.New (native_url);
			Marshal.FreeHGlobal (native_url);
			return ret;
		}

		[DllImport(DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_version_as_text(int version);

		public static string RtspVersionAsText(Gst.Rtsp.RTSPVersion version) {
			IntPtr raw_ret = gst_rtsp_version_as_text((int) version);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

#endregion
	}
}
