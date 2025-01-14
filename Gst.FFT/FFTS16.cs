﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.FFT {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class FFTS16 : GLib.Opaque {

		[DllImport(DLL.GstFFT, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_fft_s16_fft(IntPtr raw, short timedata, IntPtr freqdata);

		public void Fft(short timedata, Gst.FFT.FFTS16Complex freqdata) {
			IntPtr native_freqdata = GLib.Marshaller.StructureToPtrAlloc (freqdata);
			gst_fft_s16_fft(Handle, timedata, native_freqdata);
			Marshal.FreeHGlobal (native_freqdata);
		}

		[DllImport(DLL.GstFFT, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_fft_s16_inverse_fft(IntPtr raw, IntPtr freqdata, short timedata);

		public void InverseFft(Gst.FFT.FFTS16Complex freqdata, short timedata) {
			IntPtr native_freqdata = GLib.Marshaller.StructureToPtrAlloc (freqdata);
			gst_fft_s16_inverse_fft(Handle, native_freqdata, timedata);
			Marshal.FreeHGlobal (native_freqdata);
		}

		[DllImport(DLL.GstFFT, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_fft_s16_window(IntPtr raw, short timedata, int window);

		public void Window(short timedata, Gst.FFT.FFTWindow window) {
			gst_fft_s16_window(Handle, timedata, (int) window);
		}

		public FFTS16(IntPtr raw) : base(raw) {}

		[DllImport(DLL.GstFFT, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_fft_s16_free(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			gst_fft_s16_free (raw);
		}

		class FinalizerInfo {
			IntPtr handle;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				gst_fft_s16_free (handle);
				return false;
			}
		}

		~FFTS16 ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
