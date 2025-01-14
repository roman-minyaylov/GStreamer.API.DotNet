﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.PbUtils {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class EncodingAudioProfile : Gst.PbUtils.EncodingProfile {

		public EncodingAudioProfile (IntPtr raw) : base(raw) {}

		[DllImport(DLL.GstPbUtils, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_encoding_audio_profile_new(IntPtr format, IntPtr preset, IntPtr restriction, uint presence);

		public EncodingAudioProfile (Gst.Caps format, string preset, Gst.Caps restriction, uint presence) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (EncodingAudioProfile)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_preset = GLib.Marshaller.StringToPtrGStrdup (preset);
			Raw = gst_encoding_audio_profile_new(format == null ? IntPtr.Zero : format.Handle, native_preset, restriction == null ? IntPtr.Zero : restriction.Handle, presence);
			GLib.Marshaller.Free (native_preset);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (Gst.PbUtils.EncodingProfile.class_abi.Fields);

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport(DLL.GstPbUtils, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_encoding_audio_profile_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_encoding_audio_profile_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		static EncodingAudioProfile ()
		{
			GtkSharp.GstreamerSharp.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (Gst.PbUtils.EncodingProfile.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
