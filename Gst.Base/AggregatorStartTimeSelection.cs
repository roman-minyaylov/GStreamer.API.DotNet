﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Base {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.Base.AggregatorStartTimeSelectionGType))]
	public enum AggregatorStartTimeSelection {

		Zero = 0,
		First = 1,
		Set = 2,
	}

	internal class AggregatorStartTimeSelectionGType {
		[DllImport (DLL.GstBase, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_aggregator_start_time_selection_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_aggregator_start_time_selection_get_type ());
			}
		}
	}
#endregion
}
