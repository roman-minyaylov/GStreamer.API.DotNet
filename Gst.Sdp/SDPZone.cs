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
	public partial struct SDPZone : IEquatable<SDPZone> {

		public string Time;
		public string TypedTime;

		public static Gst.Sdp.SDPZone Zero = new Gst.Sdp.SDPZone ();

		public static Gst.Sdp.SDPZone New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Sdp.SDPZone.Zero;
			return (Gst.Sdp.SDPZone) Marshal.PtrToStructure (raw, typeof (Gst.Sdp.SDPZone));
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_zone_clear(IntPtr raw);

		public Gst.Sdp.SDPResult Clear() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			int raw_ret = gst_sdp_zone_clear(this_as_native);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_zone_set(IntPtr raw, IntPtr adj_time, IntPtr typed_time);

		public Gst.Sdp.SDPResult Set(string adj_time, string typed_time) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_adj_time = GLib.Marshaller.StringToPtrGStrdup (adj_time);
			IntPtr native_typed_time = GLib.Marshaller.StringToPtrGStrdup (typed_time);
			int raw_ret = gst_sdp_zone_set(this_as_native, native_adj_time, native_typed_time);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_adj_time);
			GLib.Marshaller.Free (native_typed_time);
			return ret;
		}

		static void ReadNative (IntPtr native, ref Gst.Sdp.SDPZone target)
		{
			target = New (native);
		}

		public bool Equals (SDPZone other)
		{
			return true && Time.Equals (other.Time) && TypedTime.Equals (other.TypedTime);
		}

		public override bool Equals (object other)
		{
			return other is SDPZone && Equals ((SDPZone) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Time.GetHashCode () ^ TypedTime.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
