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
	public partial struct SDPConnection : IEquatable<SDPConnection> {

		public string Nettype;
		public string Addrtype;
		public string Address;
		public uint Ttl;
		public uint AddrNumber;

		public static Gst.Sdp.SDPConnection Zero = new Gst.Sdp.SDPConnection ();

		public static Gst.Sdp.SDPConnection New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Sdp.SDPConnection.Zero;
			return (Gst.Sdp.SDPConnection) Marshal.PtrToStructure (raw, typeof (Gst.Sdp.SDPConnection));
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_connection_clear(IntPtr raw);

		public Gst.Sdp.SDPResult Clear() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			int raw_ret = gst_sdp_connection_clear(this_as_native);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_connection_set(IntPtr raw, IntPtr nettype, IntPtr addrtype, IntPtr address, uint ttl, uint addr_number);

		public Gst.Sdp.SDPResult Set(string nettype, string addrtype, string address, uint ttl, uint addr_number) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_nettype = GLib.Marshaller.StringToPtrGStrdup (nettype);
			IntPtr native_addrtype = GLib.Marshaller.StringToPtrGStrdup (addrtype);
			IntPtr native_address = GLib.Marshaller.StringToPtrGStrdup (address);
			int raw_ret = gst_sdp_connection_set(this_as_native, native_nettype, native_addrtype, native_address, ttl, addr_number);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_nettype);
			GLib.Marshaller.Free (native_addrtype);
			GLib.Marshaller.Free (native_address);
			return ret;
		}

		static void ReadNative (IntPtr native, ref Gst.Sdp.SDPConnection target)
		{
			target = New (native);
		}

		public bool Equals (SDPConnection other)
		{
			return true && Nettype.Equals (other.Nettype) && Addrtype.Equals (other.Addrtype) && Address.Equals (other.Address) && Ttl.Equals (other.Ttl) && AddrNumber.Equals (other.AddrNumber);
		}

		public override bool Equals (object other)
		{
			return other is SDPConnection && Equals ((SDPConnection) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Nettype.GetHashCode () ^ Addrtype.GetHashCode () ^ Address.GetHashCode () ^ Ttl.GetHashCode () ^ AddrNumber.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
