﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Sdp {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDPMedia : IEquatable<SDPMedia> {

		public string Media;
		public uint Port;
		public uint NumPorts;
		public string Proto;
		private IntPtr FmtsPtr;
		public IntPtr[] Fmts {
			get { return GLib.Marshaller.StructArrayFromNullTerminatedIntPtr<IntPtr> (FmtsPtr); }
			set { FmtsPtr = GLib.Marshaller.StructArrayToNullTerminatedStructArrayIntPtr<IntPtr> (value); }
		}
		public string Information;
		private IntPtr ConnectionsPtr;
		public IntPtr[] Connections {
			get { return GLib.Marshaller.StructArrayFromNullTerminatedIntPtr<IntPtr> (ConnectionsPtr); }
			set { ConnectionsPtr = GLib.Marshaller.StructArrayToNullTerminatedStructArrayIntPtr<IntPtr> (value); }
		}
		private IntPtr BandwidthsPtr;
		public IntPtr[] Bandwidths {
			get { return GLib.Marshaller.StructArrayFromNullTerminatedIntPtr<IntPtr> (BandwidthsPtr); }
			set { BandwidthsPtr = GLib.Marshaller.StructArrayToNullTerminatedStructArrayIntPtr<IntPtr> (value); }
		}
		public Gst.Sdp.SDPKey Key;
		private IntPtr AttributesPtr;
		public IntPtr[] Attributes {
			get { return GLib.Marshaller.StructArrayFromNullTerminatedIntPtr<IntPtr> (AttributesPtr); }
			set { AttributesPtr = GLib.Marshaller.StructArrayToNullTerminatedStructArrayIntPtr<IntPtr> (value); }
		}

		public static Gst.Sdp.SDPMedia Zero = new Gst.Sdp.SDPMedia ();

		public static Gst.Sdp.SDPMedia New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Sdp.SDPMedia.Zero;
			return (Gst.Sdp.SDPMedia) Marshal.PtrToStructure (raw, typeof (Gst.Sdp.SDPMedia));
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_add_attribute(IntPtr raw, IntPtr key, IntPtr value);

		public Gst.Sdp.SDPResult AddAttribute(string key, string value) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
			int raw_ret = gst_sdp_media_add_attribute(this_as_native, native_key, native_value);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_key);
			GLib.Marshaller.Free (native_value);
			return ret;
		}

		public Gst.Sdp.SDPResult AddAttribute(string key) {
			return AddAttribute (key, null);
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_add_bandwidth(IntPtr raw, IntPtr bwtype, uint bandwidth);

		public Gst.Sdp.SDPResult AddBandwidth(string bwtype, uint bandwidth) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_bwtype = GLib.Marshaller.StringToPtrGStrdup (bwtype);
			int raw_ret = gst_sdp_media_add_bandwidth(this_as_native, native_bwtype, bandwidth);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_bwtype);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_add_connection(IntPtr raw, IntPtr nettype, IntPtr addrtype, IntPtr address, uint ttl, uint addr_number);

		public Gst.Sdp.SDPResult AddConnection(string nettype, string addrtype, string address, uint ttl, uint addr_number) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_nettype = GLib.Marshaller.StringToPtrGStrdup (nettype);
			IntPtr native_addrtype = GLib.Marshaller.StringToPtrGStrdup (addrtype);
			IntPtr native_address = GLib.Marshaller.StringToPtrGStrdup (address);
			int raw_ret = gst_sdp_media_add_connection(this_as_native, native_nettype, native_addrtype, native_address, ttl, addr_number);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_nettype);
			GLib.Marshaller.Free (native_addrtype);
			GLib.Marshaller.Free (native_address);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_add_format(IntPtr raw, IntPtr format);

		public Gst.Sdp.SDPResult AddFormat(string format) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_format = GLib.Marshaller.StringToPtrGStrdup (format);
			int raw_ret = gst_sdp_media_add_format(this_as_native, native_format);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_format);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_sdp_media_as_text(IntPtr raw);

		public string AsText() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = gst_sdp_media_as_text(this_as_native);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_sdp_media_attributes_len(IntPtr raw);

		public uint AttributesLen() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			uint raw_ret = gst_sdp_media_attributes_len(this_as_native);
			uint ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_attributes_to_caps(IntPtr raw, IntPtr caps);

		public Gst.Sdp.SDPResult AttributesToCaps(Gst.Caps caps) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			int raw_ret = gst_sdp_media_attributes_to_caps(this_as_native, caps == null ? IntPtr.Zero : caps.Handle);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_sdp_media_bandwidths_len(IntPtr raw);

		public uint BandwidthsLen() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			uint raw_ret = gst_sdp_media_bandwidths_len(this_as_native);
			uint ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_sdp_media_connections_len(IntPtr raw);

		public uint ConnectionsLen() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			uint raw_ret = gst_sdp_media_connections_len(this_as_native);
			uint ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_copy(IntPtr raw, IntPtr copy);

		public Gst.Sdp.SDPResult Copy(out Gst.Sdp.SDPMedia copy) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_copy = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gst.Sdp.SDPMedia)));
			int raw_ret = gst_sdp_media_copy(this_as_native, native_copy);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			copy = Gst.Sdp.SDPMedia.New (native_copy);
			Marshal.FreeHGlobal (native_copy);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_sdp_media_formats_len(IntPtr raw);

		public uint FormatsLen() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			uint raw_ret = gst_sdp_media_formats_len(this_as_native);
			uint ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_free(IntPtr raw);

		public Gst.Sdp.SDPResult Free() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			int raw_ret = gst_sdp_media_free(this_as_native);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_sdp_media_get_attribute(IntPtr raw, uint idx);

		public Gst.Sdp.SDPAttribute GetAttribute(uint idx) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = gst_sdp_media_get_attribute(this_as_native, idx);
			Gst.Sdp.SDPAttribute ret = Gst.Sdp.SDPAttribute.New (raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_sdp_media_get_attribute_val(IntPtr raw, IntPtr key);

		public string GetAttributeVal(string key) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr raw_ret = gst_sdp_media_get_attribute_val(this_as_native, native_key);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_sdp_media_get_attribute_val_n(IntPtr raw, IntPtr key, uint nth);

		public string GetAttributeValN(string key, uint nth) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr raw_ret = gst_sdp_media_get_attribute_val_n(this_as_native, native_key, nth);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_sdp_media_get_bandwidth(IntPtr raw, uint idx);

		public Gst.Sdp.SDPBandwidth GetBandwidth(uint idx) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = gst_sdp_media_get_bandwidth(this_as_native, idx);
			Gst.Sdp.SDPBandwidth ret = Gst.Sdp.SDPBandwidth.New (raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_sdp_media_get_caps_from_media(IntPtr raw, int pt);

		public Gst.Caps GetCapsFromMedia(int pt) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = gst_sdp_media_get_caps_from_media(this_as_native, pt);
			Gst.Caps ret = raw_ret == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Caps), true);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_sdp_media_get_connection(IntPtr raw, uint idx);

		public Gst.Sdp.SDPConnection GetConnection(uint idx) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = gst_sdp_media_get_connection(this_as_native, idx);
			Gst.Sdp.SDPConnection ret = Gst.Sdp.SDPConnection.New (raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_sdp_media_get_format(IntPtr raw, uint idx);

		public string GetFormat(uint idx) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = gst_sdp_media_get_format(this_as_native, idx);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_init(IntPtr raw);

		public Gst.Sdp.SDPResult Init() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			int raw_ret = gst_sdp_media_init(this_as_native);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_insert_attribute(IntPtr raw, int idx, IntPtr attr);

		public Gst.Sdp.SDPResult InsertAttribute(int idx, Gst.Sdp.SDPAttribute attr) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_attr = GLib.Marshaller.StructureToPtrAlloc (attr);
			int raw_ret = gst_sdp_media_insert_attribute(this_as_native, idx, native_attr);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			Marshal.FreeHGlobal (native_attr);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_insert_bandwidth(IntPtr raw, int idx, IntPtr bw);

		public Gst.Sdp.SDPResult InsertBandwidth(int idx, Gst.Sdp.SDPBandwidth bw) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_bw = GLib.Marshaller.StructureToPtrAlloc (bw);
			int raw_ret = gst_sdp_media_insert_bandwidth(this_as_native, idx, native_bw);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			Marshal.FreeHGlobal (native_bw);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_insert_connection(IntPtr raw, int idx, IntPtr conn);

		public Gst.Sdp.SDPResult InsertConnection(int idx, Gst.Sdp.SDPConnection conn) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_conn = GLib.Marshaller.StructureToPtrAlloc (conn);
			int raw_ret = gst_sdp_media_insert_connection(this_as_native, idx, native_conn);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			Marshal.FreeHGlobal (native_conn);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_insert_format(IntPtr raw, int idx, IntPtr format);

		public Gst.Sdp.SDPResult InsertFormat(int idx, string format) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_format = GLib.Marshaller.StringToPtrGStrdup (format);
			int raw_ret = gst_sdp_media_insert_format(this_as_native, idx, native_format);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_format);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_parse_keymgmt(IntPtr raw, out IntPtr mikey);

		public Gst.Sdp.SDPResult ParseKeymgmt(out Gst.Sdp.MIKEYMessage mikey) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_mikey;
			int raw_ret = gst_sdp_media_parse_keymgmt(this_as_native, out native_mikey);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			mikey = native_mikey == IntPtr.Zero ? null : (Gst.Sdp.MIKEYMessage) GLib.Opaque.GetOpaque (native_mikey, typeof (Gst.Sdp.MIKEYMessage), true);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_remove_attribute(IntPtr raw, uint idx);

		public Gst.Sdp.SDPResult RemoveAttribute(uint idx) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			int raw_ret = gst_sdp_media_remove_attribute(this_as_native, idx);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_remove_bandwidth(IntPtr raw, uint idx);

		public Gst.Sdp.SDPResult RemoveBandwidth(uint idx) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			int raw_ret = gst_sdp_media_remove_bandwidth(this_as_native, idx);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_remove_connection(IntPtr raw, uint idx);

		public Gst.Sdp.SDPResult RemoveConnection(uint idx) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			int raw_ret = gst_sdp_media_remove_connection(this_as_native, idx);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_remove_format(IntPtr raw, uint idx);

		public Gst.Sdp.SDPResult RemoveFormat(uint idx) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			int raw_ret = gst_sdp_media_remove_format(this_as_native, idx);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_replace_attribute(IntPtr raw, uint idx, IntPtr attr);

		public Gst.Sdp.SDPResult ReplaceAttribute(uint idx, Gst.Sdp.SDPAttribute attr) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_attr = GLib.Marshaller.StructureToPtrAlloc (attr);
			int raw_ret = gst_sdp_media_replace_attribute(this_as_native, idx, native_attr);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			Marshal.FreeHGlobal (native_attr);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_replace_bandwidth(IntPtr raw, uint idx, IntPtr bw);

		public Gst.Sdp.SDPResult ReplaceBandwidth(uint idx, Gst.Sdp.SDPBandwidth bw) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_bw = GLib.Marshaller.StructureToPtrAlloc (bw);
			int raw_ret = gst_sdp_media_replace_bandwidth(this_as_native, idx, native_bw);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			Marshal.FreeHGlobal (native_bw);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_replace_connection(IntPtr raw, uint idx, IntPtr conn);

		public Gst.Sdp.SDPResult ReplaceConnection(uint idx, Gst.Sdp.SDPConnection conn) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_conn = GLib.Marshaller.StructureToPtrAlloc (conn);
			int raw_ret = gst_sdp_media_replace_connection(this_as_native, idx, native_conn);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			Marshal.FreeHGlobal (native_conn);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_replace_format(IntPtr raw, uint idx, IntPtr format);

		public Gst.Sdp.SDPResult ReplaceFormat(uint idx, string format) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_format = GLib.Marshaller.StringToPtrGStrdup (format);
			int raw_ret = gst_sdp_media_replace_format(this_as_native, idx, native_format);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_format);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_set_information(IntPtr raw, IntPtr information);

		public Gst.Sdp.SDPResult SetInformation(string information) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_information = GLib.Marshaller.StringToPtrGStrdup (information);
			int raw_ret = gst_sdp_media_set_information(this_as_native, native_information);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_information);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_set_key(IntPtr raw, IntPtr type, IntPtr data);

		public Gst.Sdp.SDPResult SetKey(string type, string data) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_type = GLib.Marshaller.StringToPtrGStrdup (type);
			IntPtr native_data = GLib.Marshaller.StringToPtrGStrdup (data);
			int raw_ret = gst_sdp_media_set_key(this_as_native, native_type, native_data);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_type);
			GLib.Marshaller.Free (native_data);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_set_media(IntPtr raw, IntPtr med);

		public Gst.Sdp.SDPResult SetMedia(string med) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_med = GLib.Marshaller.StringToPtrGStrdup (med);
			int raw_ret = gst_sdp_media_set_media(this_as_native, native_med);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_med);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_set_port_info(IntPtr raw, uint port, uint num_ports);

		public Gst.Sdp.SDPResult SetPortInfo(uint port, uint num_ports) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			int raw_ret = gst_sdp_media_set_port_info(this_as_native, port, num_ports);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_set_proto(IntPtr raw, IntPtr proto);

		public Gst.Sdp.SDPResult SetProto(string proto) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_proto = GLib.Marshaller.StringToPtrGStrdup (proto);
			int raw_ret = gst_sdp_media_set_proto(this_as_native, native_proto);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_proto);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_uninit(IntPtr raw);

		public Gst.Sdp.SDPResult Uninit() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			int raw_ret = gst_sdp_media_uninit(this_as_native);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_new(IntPtr media);

		public static Gst.Sdp.SDPResult New(out Gst.Sdp.SDPMedia media) {
			IntPtr native_media = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gst.Sdp.SDPMedia)));
			int raw_ret = gst_sdp_media_new(native_media);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			media = Gst.Sdp.SDPMedia.New (native_media);
			Marshal.FreeHGlobal (native_media);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_media_set_media_from_caps(IntPtr caps, IntPtr media);

		public static Gst.Sdp.SDPResult SetMediaFromCaps(Gst.Caps caps, Gst.Sdp.SDPMedia media) {
			IntPtr native_media = GLib.Marshaller.StructureToPtrAlloc (media);
			int raw_ret = gst_sdp_media_set_media_from_caps(caps == null ? IntPtr.Zero : caps.Handle, native_media);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			Marshal.FreeHGlobal (native_media);
			return ret;
		}

		static void ReadNative (IntPtr native, ref Gst.Sdp.SDPMedia target)
		{
			target = New (native);
		}

		public bool Equals (SDPMedia other)
		{
			return true && Media.Equals (other.Media) && Port.Equals (other.Port) && NumPorts.Equals (other.NumPorts) && Proto.Equals (other.Proto) && FmtsPtr.Equals (other.FmtsPtr) && Information.Equals (other.Information) && ConnectionsPtr.Equals (other.ConnectionsPtr) && BandwidthsPtr.Equals (other.BandwidthsPtr) && Key.Equals (other.Key) && AttributesPtr.Equals (other.AttributesPtr);
		}

		public override bool Equals (object other)
		{
			return other is SDPMedia && Equals ((SDPMedia) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Media.GetHashCode () ^ Port.GetHashCode () ^ NumPorts.GetHashCode () ^ Proto.GetHashCode () ^ FmtsPtr.GetHashCode () ^ Information.GetHashCode () ^ ConnectionsPtr.GetHashCode () ^ BandwidthsPtr.GetHashCode () ^ Key.GetHashCode () ^ AttributesPtr.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
