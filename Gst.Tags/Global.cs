﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Tags {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class Global {

		[DllImport(DLL.GstTag, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_vorbis_tag_add(IntPtr list, IntPtr tag, IntPtr value);

		public static void VorbisTagAdd(Gst.TagList list, string tag, string value) {
			IntPtr native_tag = GLib.Marshaller.StringToPtrGStrdup (tag);
			IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
			gst_vorbis_tag_add(list == null ? IntPtr.Zero : list.Handle, native_tag, native_value);
			GLib.Marshaller.Free (native_tag);
			GLib.Marshaller.Free (native_value);
		}

#endregion
	}
}
