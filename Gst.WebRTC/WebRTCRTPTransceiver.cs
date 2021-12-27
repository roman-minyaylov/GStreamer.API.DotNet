﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.WebRTC {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class WebRTCRTPTransceiver : Gst.Object {

		protected WebRTCRTPTransceiver (IntPtr raw) : base(raw) {}

		protected WebRTCRTPTransceiver() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("direction")]
		public Gst.WebRTC.WebRTCRTPTransceiverDirection Direction {
			get {
				GLib.Value val = GetProperty ("direction");
				Gst.WebRTC.WebRTCRTPTransceiverDirection ret = (Gst.WebRTC.WebRTCRTPTransceiverDirection) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("direction", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("mlineindex")]
		public uint Mlineindex {
			get {
				GLib.Value val = GetProperty ("mlineindex");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("receiver")]
		public Gst.WebRTC.WebRTCRTPReceiver Receiver {
			get {
				GLib.Value val = GetProperty ("receiver");
				Gst.WebRTC.WebRTCRTPReceiver ret = (Gst.WebRTC.WebRTCRTPReceiver) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("sender")]
		public Gst.WebRTC.WebRTCRTPSender Sender {
			get {
				GLib.Value val = GetProperty ("sender");
				Gst.WebRTC.WebRTCRTPSender ret = (Gst.WebRTC.WebRTCRTPSender) val;
				val.Dispose ();
				return ret;
			}
		}

		public uint Mline {
			get {
				unsafe {
					uint* raw_ptr = (uint*)(((byte*)Handle) + abi_info.GetFieldOffset("mline"));
					return (*raw_ptr);
				}
			}
		}

		public string Mid {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("mid"));
					return GLib.Marshaller.Utf8PtrToString ((*raw_ptr));
				}
			}
		}

		public bool Stopped {
			get {
				unsafe {
					bool* raw_ptr = (bool*)(((byte*)Handle) + abi_info.GetFieldOffset("stopped"));
					return (*raw_ptr);
				}
			}
		}

		public Gst.WebRTC.WebRTCRTPSender SenderField {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("sender"));
					return GLib.Object.GetObject((*raw_ptr)) as Gst.WebRTC.WebRTCRTPSender;
				}
			}
		}

		public Gst.WebRTC.WebRTCRTPReceiver ReceiverField {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("receiver"));
					return GLib.Object.GetObject((*raw_ptr)) as Gst.WebRTC.WebRTCRTPReceiver;
				}
			}
		}

		public Gst.WebRTC.WebRTCRTPTransceiverDirection DirectionField {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("direction"));
					return (Gst.WebRTC.WebRTCRTPTransceiverDirection) (*raw_ptr);
				}
			}
		}

		public Gst.WebRTC.WebRTCRTPTransceiverDirection CurrentDirection {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("current_direction"));
					return (Gst.WebRTC.WebRTCRTPTransceiverDirection) (*raw_ptr);
				}
			}
		}

		public Gst.Caps CodecPreferences {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("codec_preferences"));
					return (*raw_ptr) == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque ((*raw_ptr), typeof (Gst.Caps), false);
				}
			}
		}

		public Gst.WebRTC.WebRTCKind Kind {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("kind"));
					return (Gst.WebRTC.WebRTCKind) (*raw_ptr);
				}
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_padding"
							, Gst.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _padding
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport(DLL.GstWebRTC, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_webrtc_rtp_transceiver_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_webrtc_rtp_transceiver_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		static WebRTCRTPTransceiver ()
		{
			GtkSharp.GstreamerSharp.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("mline"
							, Gst.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(uint)) // mline
							, null
							, "mid"
							, (long) Marshal.OffsetOf(typeof(GstWebRTCRTPTransceiver_mlineAlign), "mline")
							, 0
							),
						new GLib.AbiField("mid"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // mid
							, "mline"
							, "stopped"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("stopped"
							, -1
							, (uint) Marshal.SizeOf(typeof(bool)) // stopped
							, "mid"
							, "sender"
							, (long) Marshal.OffsetOf(typeof(GstWebRTCRTPTransceiver_stoppedAlign), "stopped")
							, 0
							),
						new GLib.AbiField("sender"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // sender
							, "stopped"
							, "receiver"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("receiver"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // receiver
							, "sender"
							, "direction"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("direction"
							, -1
							, (uint) Marshal.SizeOf(System.Enum.GetUnderlyingType(typeof(Gst.WebRTC.WebRTCRTPTransceiverDirection))) // direction
							, "receiver"
							, "current_direction"
							, (long) Marshal.OffsetOf(typeof(GstWebRTCRTPTransceiver_directionAlign), "direction")
							, 0
							),
						new GLib.AbiField("current_direction"
							, -1
							, (uint) Marshal.SizeOf(System.Enum.GetUnderlyingType(typeof(Gst.WebRTC.WebRTCRTPTransceiverDirection))) // current_direction
							, "direction"
							, "codec_preferences"
							, (long) Marshal.OffsetOf(typeof(GstWebRTCRTPTransceiver_current_directionAlign), "current_direction")
							, 0
							),
						new GLib.AbiField("codec_preferences"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // codec_preferences
							, "current_direction"
							, "kind"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("kind"
							, -1
							, (uint) Marshal.SizeOf(System.Enum.GetUnderlyingType(typeof(Gst.WebRTC.WebRTCKind))) // kind
							, "codec_preferences"
							, "_padding"
							, (long) Marshal.OffsetOf(typeof(GstWebRTCRTPTransceiver_kindAlign), "kind")
							, 0
							),
						new GLib.AbiField("_padding"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _padding
							, "kind"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstWebRTCRTPTransceiver_mlineAlign
		{
			sbyte f1;
			private uint mline;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstWebRTCRTPTransceiver_stoppedAlign
		{
			sbyte f1;
			private bool stopped;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstWebRTCRTPTransceiver_directionAlign
		{
			sbyte f1;
			private Gst.WebRTC.WebRTCRTPTransceiverDirection direction;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstWebRTCRTPTransceiver_current_directionAlign
		{
			sbyte f1;
			private Gst.WebRTC.WebRTCRTPTransceiverDirection current_direction;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstWebRTCRTPTransceiver_kindAlign
		{
			sbyte f1;
			private Gst.WebRTC.WebRTCKind kind;
		}


		// End of the ABI representation.

#endregion
	}
}
