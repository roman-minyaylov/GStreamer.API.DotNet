﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Tags {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.Tags.TagImageTypeGType))]
	public enum TagImageType {

		None = -1,
		Undefined = 0,
		FrontCover = 1,
		BackCover = 2,
		LeafletPage = 3,
		Medium = 4,
		LeadArtist = 5,
		Artist = 6,
		Conductor = 7,
		BandOrchestra = 8,
		Composer = 9,
		Lyricist = 10,
		RecordingLocation = 11,
		DuringRecording = 12,
		DuringPerformance = 13,
		VideoCapture = 14,
		Fish = 15,
		Illustration = 16,
		BandArtistLogo = 17,
		PublisherStudioLogo = 18,
	}

	internal class TagImageTypeGType {
		[DllImport (DLL.GstTag, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_tag_image_type_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_tag_image_type_get_type ());
			}
		}
	}
#endregion
}
