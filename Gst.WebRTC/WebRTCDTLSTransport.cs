﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.WebRTC {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class WebRTCDTLSTransport : Gst.Object {

		public WebRTCDTLSTransport (IntPtr raw) : base(raw) {}

		[DllImport(DLL.GstWebRTC, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_webrtc_dtls_transport_new(uint session_id);

		public WebRTCDTLSTransport (uint session_id) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (WebRTCDTLSTransport)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("session_id");
				vals.Add (new GLib.Value (session_id));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gst_webrtc_dtls_transport_new(session_id);
		}

		[GLib.Property ("certificate")]
		public string Certificate {
			get {
				GLib.Value val = GetProperty ("certificate");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("certificate", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("client")]
		public bool Client {
			get {
				GLib.Value val = GetProperty ("client");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("client", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("remote-certificate")]
		public string RemoteCertificate {
			get {
				GLib.Value val = GetProperty ("remote-certificate");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("session-id")]
		public uint SessionId {
			get {
				GLib.Value val = GetProperty ("session-id");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("state")]
		public Gst.WebRTC.WebRTCDTLSTransportState State {
			get {
				GLib.Value val = GetProperty ("state");
				Gst.WebRTC.WebRTCDTLSTransportState ret = (Gst.WebRTC.WebRTCDTLSTransportState) (Enum) val;
				val.Dispose ();
				return ret;
			}
		}

		[DllImport(DLL.GstWebRTC, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_webrtc_dtls_transport_set_transport(IntPtr raw, IntPtr ice);

		[GLib.Property ("transport")]
		public Gst.WebRTC.WebRTCICETransport Transport {
			get {
				GLib.Value val = GetProperty ("transport");
				Gst.WebRTC.WebRTCICETransport ret = (Gst.WebRTC.WebRTCICETransport) val;
				val.Dispose ();
				return ret;
			}
			set  {
				gst_webrtc_dtls_transport_set_transport(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		public Gst.WebRTC.WebRTCICETransport TransportField {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("transport"));
					return GLib.Object.GetObject((*raw_ptr)) as Gst.WebRTC.WebRTCICETransport;
				}
			}
		}

		public Gst.WebRTC.WebRTCDTLSTransportState StateField {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("state"));
					return (Gst.WebRTC.WebRTCDTLSTransportState) (*raw_ptr);
				}
			}
		}

		public bool ClientField {
			get {
				unsafe {
					bool* raw_ptr = (bool*)(((byte*)Handle) + abi_info.GetFieldOffset("client"));
					return (*raw_ptr);
				}
			}
		}

		public uint SessionIdField {
			get {
				unsafe {
					uint* raw_ptr = (uint*)(((byte*)Handle) + abi_info.GetFieldOffset("session_id"));
					return (*raw_ptr);
				}
			}
		}

		public Gst.Element Dtlssrtpenc {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("dtlssrtpenc"));
					return GLib.Object.GetObject((*raw_ptr)) as Gst.Element;
				}
			}
		}

		public Gst.Element Dtlssrtpdec {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("dtlssrtpdec"));
					return GLib.Object.GetObject((*raw_ptr)) as Gst.Element;
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
		static extern IntPtr gst_webrtc_dtls_transport_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_webrtc_dtls_transport_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		static WebRTCDTLSTransport ()
		{
			GtkSharp.GstreamerSharp.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("transport"
							, Gst.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // transport
							, null
							, "state"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("state"
							, -1
							, (uint) Marshal.SizeOf(System.Enum.GetUnderlyingType(typeof(Gst.WebRTC.WebRTCDTLSTransportState))) // state
							, "transport"
							, "client"
							, (long) Marshal.OffsetOf(typeof(GstWebRTCDTLSTransport_stateAlign), "state")
							, 0
							),
						new GLib.AbiField("client"
							, -1
							, (uint) Marshal.SizeOf(typeof(bool)) // client
							, "state"
							, "session_id"
							, (long) Marshal.OffsetOf(typeof(GstWebRTCDTLSTransport_clientAlign), "client")
							, 0
							),
						new GLib.AbiField("session_id"
							, -1
							, (uint) Marshal.SizeOf(typeof(uint)) // session_id
							, "client"
							, "dtlssrtpenc"
							, (long) Marshal.OffsetOf(typeof(GstWebRTCDTLSTransport_session_idAlign), "session_id")
							, 0
							),
						new GLib.AbiField("dtlssrtpenc"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // dtlssrtpenc
							, "session_id"
							, "dtlssrtpdec"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("dtlssrtpdec"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // dtlssrtpdec
							, "dtlssrtpenc"
							, "_padding"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_padding"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _padding
							, "dtlssrtpdec"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstWebRTCDTLSTransport_stateAlign
		{
			sbyte f1;
			private Gst.WebRTC.WebRTCDTLSTransportState state;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstWebRTCDTLSTransport_clientAlign
		{
			sbyte f1;
			private bool client;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstWebRTCDTLSTransport_session_idAlign
		{
			sbyte f1;
			private uint session_id;
		}


		// End of the ABI representation.

#endregion
	}
}
