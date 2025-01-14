﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Rtp {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class Global {

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_add_rtp_source_meta(IntPtr buffer, uint ssrc, uint csrc, uint csrc_count);

		public static Gst.Rtp.RTPSourceMeta BufferAddRtpSourceMeta(Gst.Buffer buffer, uint ssrc, uint csrc, uint csrc_count) {
			IntPtr raw_ret = gst_buffer_add_rtp_source_meta(buffer == null ? IntPtr.Zero : buffer.Handle, ssrc, csrc, csrc_count);
			Gst.Rtp.RTPSourceMeta ret = Gst.Rtp.RTPSourceMeta.New (raw_ret);
			return ret;
		}

		public static Gst.Rtp.RTPSourceMeta BufferAddRtpSourceMeta(Gst.Buffer buffer, uint csrc_count) {
			return BufferAddRtpSourceMeta (buffer, 0, 0, csrc_count);
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_get_rtp_source_meta(IntPtr buffer);

		public static Gst.Rtp.RTPSourceMeta BufferGetRtpSourceMeta(Gst.Buffer buffer) {
			IntPtr raw_ret = gst_buffer_get_rtp_source_meta(buffer == null ? IntPtr.Zero : buffer.Handle);
			Gst.Rtp.RTPSourceMeta ret = Gst.Rtp.RTPSourceMeta.New (raw_ret);
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_rtcp_buffer_map(IntPtr buffer, int flags, IntPtr rtcp);

		public static bool RtcpBufferMap(Gst.Buffer buffer, Gst.MapFlags flags, Gst.Rtp.RTCPBuffer rtcp) {
			IntPtr native_rtcp = GLib.Marshaller.StructureToPtrAlloc (rtcp);
			bool raw_ret = gst_rtcp_buffer_map(buffer == null ? IntPtr.Zero : buffer.Handle, (int) flags, native_rtcp);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_rtcp);
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtcp_buffer_new(uint mtu);

		public static Gst.Buffer RtcpBufferNew(uint mtu) {
			IntPtr raw_ret = gst_rtcp_buffer_new(mtu);
			Gst.Buffer ret = raw_ret == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Buffer), true);
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtcp_buffer_new_copy_data(byte[] data, uint n_length);

		public static Gst.Buffer RtcpBufferNewCopyData(byte[] data) {
			IntPtr raw_ret = gst_rtcp_buffer_new_copy_data(data, (uint) (data == null ? 0 : data.Length));
			Gst.Buffer ret = raw_ret == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Buffer), true);
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtcp_buffer_new_take_data(byte[] data, uint n_length);

		public static Gst.Buffer RtcpBufferNewTakeData(byte[] data) {
			IntPtr raw_ret = gst_rtcp_buffer_new_take_data(data, (uint) (data == null ? 0 : data.Length));
			Gst.Buffer ret = raw_ret == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Buffer), true);
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_rtcp_buffer_validate(IntPtr buffer);

		public static bool RtcpBufferValidate(Gst.Buffer buffer) {
			bool raw_ret = gst_rtcp_buffer_validate(buffer == null ? IntPtr.Zero : buffer.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_rtcp_buffer_validate_data(byte[] data, uint len);

		public static bool RtcpBufferValidateData(byte[] data, uint len) {
			bool raw_ret = gst_rtcp_buffer_validate_data(data, len);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_rtcp_buffer_validate_data_reduced(byte[] data, uint len);

		public static bool RtcpBufferValidateDataReduced(byte[] data, uint len) {
			bool raw_ret = gst_rtcp_buffer_validate_data_reduced(data, len);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_rtcp_buffer_validate_reduced(IntPtr buffer);

		public static bool RtcpBufferValidateReduced(Gst.Buffer buffer) {
			bool raw_ret = gst_rtcp_buffer_validate_reduced(buffer == null ? IntPtr.Zero : buffer.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern ulong gst_rtcp_ntp_to_unix(ulong ntptime);

		public static ulong RtcpNtpToUnix(ulong ntptime) {
			ulong raw_ret = gst_rtcp_ntp_to_unix(ntptime);
			ulong ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtcp_sdes_name_to_type(IntPtr name);

		public static Gst.Rtp.RTCPSDESType RtcpSdesNameToType(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			int raw_ret = gst_rtcp_sdes_name_to_type(native_name);
			Gst.Rtp.RTCPSDESType ret = (Gst.Rtp.RTCPSDESType) raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtcp_sdes_type_to_name(int type);

		public static string RtcpSdesTypeToName(Gst.Rtp.RTCPSDESType type) {
			IntPtr raw_ret = gst_rtcp_sdes_type_to_name((int) type);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern ulong gst_rtcp_unix_to_ntp(ulong unixtime);

		public static ulong RtcpUnixToNtp(ulong unixtime) {
			ulong raw_ret = gst_rtcp_unix_to_ntp(unixtime);
			ulong ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_rtp_buffer_allocate_data(IntPtr buffer, uint payload_len, byte pad_len, byte csrc_count);

		public static void RtpBufferAllocateData(Gst.Buffer buffer, uint payload_len, byte pad_len, byte csrc_count) {
			gst_rtp_buffer_allocate_data(buffer == null ? IntPtr.Zero : buffer.Handle, payload_len, pad_len, csrc_count);
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_rtp_buffer_calc_header_len(byte csrc_count);

		public static uint RtpBufferCalcHeaderLen(byte csrc_count) {
			uint raw_ret = gst_rtp_buffer_calc_header_len(csrc_count);
			uint ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_rtp_buffer_calc_packet_len(uint payload_len, byte pad_len, byte csrc_count);

		public static uint RtpBufferCalcPacketLen(uint payload_len, byte pad_len, byte csrc_count) {
			uint raw_ret = gst_rtp_buffer_calc_packet_len(payload_len, pad_len, csrc_count);
			uint ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_rtp_buffer_calc_payload_len(uint packet_len, byte pad_len, byte csrc_count);

		public static uint RtpBufferCalcPayloadLen(uint packet_len, byte pad_len, byte csrc_count) {
			uint raw_ret = gst_rtp_buffer_calc_payload_len(packet_len, pad_len, csrc_count);
			uint ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtp_buffer_compare_seqnum(ushort seqnum1, ushort seqnum2);

		public static int RtpBufferCompareSeqnum(ushort seqnum1, ushort seqnum2) {
			int raw_ret = gst_rtp_buffer_compare_seqnum(seqnum1, seqnum2);
			int ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_rtp_buffer_default_clock_rate(byte payload_type);

		public static uint RtpBufferDefaultClockRate(byte payload_type) {
			uint raw_ret = gst_rtp_buffer_default_clock_rate(payload_type);
			uint ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern ulong gst_rtp_buffer_ext_timestamp(ref ulong exttimestamp, uint timestamp);

		public static ulong RtpBufferExtTimestamp(ref ulong exttimestamp, uint timestamp) {
			ulong raw_ret = gst_rtp_buffer_ext_timestamp(ref exttimestamp, timestamp);
			ulong ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_rtp_buffer_map(IntPtr buffer, int flags, IntPtr rtp);

		public static bool RtpBufferMap(Gst.Buffer buffer, Gst.MapFlags flags, out Gst.Rtp.RTPBuffer rtp) {
			IntPtr native_rtp = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gst.Rtp.RTPBuffer)));
			bool raw_ret = gst_rtp_buffer_map(buffer == null ? IntPtr.Zero : buffer.Handle, (int) flags, native_rtp);
			bool ret = raw_ret;
			rtp = Gst.Rtp.RTPBuffer.New (native_rtp);
			Marshal.FreeHGlobal (native_rtp);
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtp_buffer_new_allocate(uint payload_len, byte pad_len, byte csrc_count);

		public static Gst.Buffer RtpBufferNewAllocate(uint payload_len, byte pad_len, byte csrc_count) {
			IntPtr raw_ret = gst_rtp_buffer_new_allocate(payload_len, pad_len, csrc_count);
			Gst.Buffer ret = raw_ret == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Buffer), true);
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtp_buffer_new_allocate_len(uint packet_len, byte pad_len, byte csrc_count);

		public static Gst.Buffer RtpBufferNewAllocateLen(uint packet_len, byte pad_len, byte csrc_count) {
			IntPtr raw_ret = gst_rtp_buffer_new_allocate_len(packet_len, pad_len, csrc_count);
			Gst.Buffer ret = raw_ret == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Buffer), true);
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtp_buffer_new_copy_data(byte[] data, UIntPtr n_length);

		public static Gst.Buffer RtpBufferNewCopyData(byte[] data) {
			IntPtr raw_ret = gst_rtp_buffer_new_copy_data(data, new UIntPtr ((ulong) (data == null ? 0 : data.Length)));
			Gst.Buffer ret = raw_ret == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Buffer), true);
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtp_buffer_new_take_data(byte[] data, UIntPtr n_length);

		public static Gst.Buffer RtpBufferNewTakeData(byte[] data) {
			IntPtr raw_ret = gst_rtp_buffer_new_take_data(data, new UIntPtr ((ulong) (data == null ? 0 : data.Length)));
			Gst.Buffer ret = raw_ret == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Buffer), true);
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_rtp_hdrext_get_ntp_56(IntPtr[] data, uint size, out ulong ntptime);

		public static bool RtpHdrextGetNtp56(IntPtr[] data, uint size, out ulong ntptime) {
			bool raw_ret = gst_rtp_hdrext_get_ntp_56(data, size, out ntptime);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_rtp_hdrext_get_ntp_64(IntPtr[] data, uint size, out ulong ntptime);

		public static bool RtpHdrextGetNtp64(IntPtr[] data, uint size, out ulong ntptime) {
			bool raw_ret = gst_rtp_hdrext_get_ntp_64(data, size, out ntptime);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_rtp_hdrext_set_ntp_56(IntPtr data, uint size, ulong ntptime);

		public static bool RtpHdrextSetNtp56(IntPtr data, uint size, ulong ntptime) {
			bool raw_ret = gst_rtp_hdrext_set_ntp_56(data, size, ntptime);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_rtp_hdrext_set_ntp_64(IntPtr data, uint size, ulong ntptime);

		public static bool RtpHdrextSetNtp64(IntPtr data, uint size, ulong ntptime) {
			bool raw_ret = gst_rtp_hdrext_set_ntp_64(data, size, ntptime);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtp_payload_info_for_name(IntPtr media, IntPtr encoding_name);

		public static Gst.Rtp.RTPPayloadInfo RtpPayloadInfoForName(string media, string encoding_name) {
			IntPtr native_media = GLib.Marshaller.StringToPtrGStrdup (media);
			IntPtr native_encoding_name = GLib.Marshaller.StringToPtrGStrdup (encoding_name);
			IntPtr raw_ret = gst_rtp_payload_info_for_name(native_media, native_encoding_name);
			Gst.Rtp.RTPPayloadInfo ret = Gst.Rtp.RTPPayloadInfo.New (raw_ret);
			GLib.Marshaller.Free (native_media);
			GLib.Marshaller.Free (native_encoding_name);
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtp_payload_info_for_pt(byte payload_type);

		public static Gst.Rtp.RTPPayloadInfo RtpPayloadInfoForPt(byte payload_type) {
			IntPtr raw_ret = gst_rtp_payload_info_for_pt(payload_type);
			Gst.Rtp.RTPPayloadInfo ret = Gst.Rtp.RTPPayloadInfo.New (raw_ret);
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtp_source_meta_api_get_type();

		public static GLib.GType RtpSourceMetaApiGetType() {
			IntPtr raw_ret = gst_rtp_source_meta_api_get_type();
			GLib.GType ret = new GLib.GType(raw_ret);
			return ret;
		}

		[DllImport(DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtp_source_meta_get_info();

		public static Gst.MetaInfo RtpSourceMetaGetInfo() {
			IntPtr raw_ret = gst_rtp_source_meta_get_info();
			Gst.MetaInfo ret = Gst.MetaInfo.New (raw_ret);
			return ret;
		}

#endregion
	}
}
