﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class PluginFeature : Gst.Object {

		protected PluginFeature (IntPtr raw) : base(raw) {}

		protected PluginFeature() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (Gst.Object.class_abi.Fields);

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_plugin_feature_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_plugin_feature_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_plugin_feature_list_copy(IntPtr list);

		public static Gst.PluginFeature[] ListCopy(GLib.List list) {
			IntPtr raw_ret = gst_plugin_feature_list_copy(list == null ? IntPtr.Zero : list.Handle);
			Gst.PluginFeature[] ret = (Gst.PluginFeature[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(Gst.PluginFeature));
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_plugin_feature_list_debug(IntPtr list);

		public static void ListDebug(GLib.List list) {
			gst_plugin_feature_list_debug(list == null ? IntPtr.Zero : list.Handle);
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_plugin_feature_list_free(IntPtr list);

		public static void ListFree(GLib.List list) {
			gst_plugin_feature_list_free(list == null ? IntPtr.Zero : list.Handle);
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_plugin_feature_rank_compare_func(IntPtr p1, IntPtr p2);

		public static int RankCompareFunc(IntPtr p1, IntPtr p2) {
			int raw_ret = gst_plugin_feature_rank_compare_func(p1, p2);
			int ret = raw_ret;
			return ret;
		}

		public static int RankCompareFunc() {
			return RankCompareFunc (IntPtr.Zero, IntPtr.Zero);
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_plugin_feature_check_version(IntPtr raw, uint min_major, uint min_minor, uint min_micro);

		public bool CheckVersion(uint min_major, uint min_minor, uint min_micro) {
			bool raw_ret = gst_plugin_feature_check_version(Handle, min_major, min_minor, min_micro);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_plugin_feature_get_plugin(IntPtr raw);

		public Gst.Plugin Plugin { 
			get {
				IntPtr raw_ret = gst_plugin_feature_get_plugin(Handle);
				Gst.Plugin ret = GLib.Object.GetObject(raw_ret, true) as Gst.Plugin;
				return ret;
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_plugin_feature_get_plugin_name(IntPtr raw);

		public string PluginName { 
			get {
				IntPtr raw_ret = gst_plugin_feature_get_plugin_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_plugin_feature_get_rank(IntPtr raw);

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_plugin_feature_set_rank(IntPtr raw, uint rank);

		public uint Rank { 
			get {
				uint raw_ret = gst_plugin_feature_get_rank(Handle);
				uint ret = raw_ret;
				return ret;
			}
			set {
				gst_plugin_feature_set_rank(Handle, value);
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_plugin_feature_load(IntPtr raw);

		public Gst.PluginFeature Load() {
			IntPtr raw_ret = gst_plugin_feature_load(Handle);
			Gst.PluginFeature ret = GLib.Object.GetObject(raw_ret, true) as Gst.PluginFeature;
			return ret;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (Gst.Object.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
