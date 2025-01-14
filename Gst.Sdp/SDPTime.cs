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
	public partial struct SDPTime : IEquatable<SDPTime> {

		public string Start;
		public string Stop;
		private IntPtr RepeatPtr;
		public IntPtr[] Repeat {
			get { return GLib.Marshaller.StructArrayFromNullTerminatedIntPtr<IntPtr> (RepeatPtr); }
			set { RepeatPtr = GLib.Marshaller.StructArrayToNullTerminatedStructArrayIntPtr<IntPtr> (value); }
		}

		public static Gst.Sdp.SDPTime Zero = new Gst.Sdp.SDPTime ();

		public static Gst.Sdp.SDPTime New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Sdp.SDPTime.Zero;
			return (Gst.Sdp.SDPTime) Marshal.PtrToStructure (raw, typeof (Gst.Sdp.SDPTime));
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_time_clear(IntPtr raw);

		public Gst.Sdp.SDPResult Clear() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			int raw_ret = gst_sdp_time_clear(this_as_native);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.GstSDP, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_sdp_time_set(IntPtr raw, IntPtr start, IntPtr stop, IntPtr[] repeat);

		public Gst.Sdp.SDPResult Set(string start, string stop, string[] repeat) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_start = GLib.Marshaller.StringToPtrGStrdup (start);
			IntPtr native_stop = GLib.Marshaller.StringToPtrGStrdup (stop);
			int cnt_repeat = repeat == null ? 0 : repeat.Length;
			IntPtr[] native_repeat = new IntPtr [cnt_repeat + 1];
			for (int i = 0; i < cnt_repeat; i++)
				native_repeat [i] = GLib.Marshaller.StringToPtrGStrdup(repeat[i]);
			native_repeat [cnt_repeat] = IntPtr.Zero;
			int raw_ret = gst_sdp_time_set(this_as_native, native_start, native_stop, native_repeat);
			Gst.Sdp.SDPResult ret = (Gst.Sdp.SDPResult) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_start);
			GLib.Marshaller.Free (native_stop);
			return ret;
		}

		static void ReadNative (IntPtr native, ref Gst.Sdp.SDPTime target)
		{
			target = New (native);
		}

		public bool Equals (SDPTime other)
		{
			return true && Start.Equals (other.Start) && Stop.Equals (other.Stop) && RepeatPtr.Equals (other.RepeatPtr);
		}

		public override bool Equals (object other)
		{
			return other is SDPTime && Equals ((SDPTime) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Start.GetHashCode () ^ Stop.GetHashCode () ^ RepeatPtr.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
