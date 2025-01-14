﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class Registry : Gst.Object {

		public Registry (IntPtr raw) : base(raw) {}

		protected Registry() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Signal("plugin-added")]
		public event Gst.PluginAddedHandler PluginAdded {
			add {
				this.AddSignalHandler ("plugin-added", value, typeof (Gst.PluginAddedArgs));
			}
			remove {
				this.RemoveSignalHandler ("plugin-added", value);
			}
		}

		[GLib.Signal("feature-added")]
		public event Gst.FeatureAddedHandler FeatureAdded {
			add {
				this.AddSignalHandler ("feature-added", value, typeof (Gst.FeatureAddedArgs));
			}
			remove {
				this.RemoveSignalHandler ("feature-added", value);
			}
		}

		static FeatureAddedNativeDelegate FeatureAdded_cb_delegate;
		static FeatureAddedNativeDelegate FeatureAddedVMCallback {
			get {
				if (FeatureAdded_cb_delegate == null)
					FeatureAdded_cb_delegate = new FeatureAddedNativeDelegate (FeatureAdded_cb);
				return FeatureAdded_cb_delegate;
			}
		}

		static void OverrideFeatureAdded (GLib.GType gtype)
		{
			OverrideFeatureAdded (gtype, FeatureAddedVMCallback);
		}

		static void OverrideFeatureAdded (GLib.GType gtype, FeatureAddedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "feature-added", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void FeatureAddedNativeDelegate (IntPtr inst, IntPtr feature);

		static void FeatureAdded_cb (IntPtr inst, IntPtr feature)
		{
			try {
				Registry __obj = GLib.Object.GetObject (inst, false) as Registry;
				__obj.OnFeatureAdded (GLib.Object.GetObject(feature) as Gst.PluginFeature);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Registry), ConnectionMethod="OverrideFeatureAdded")]
		protected virtual void OnFeatureAdded (Gst.PluginFeature feature)
		{
			InternalFeatureAdded (feature);
		}

		private void InternalFeatureAdded (Gst.PluginFeature feature)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (feature);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static PluginAddedNativeDelegate PluginAdded_cb_delegate;
		static PluginAddedNativeDelegate PluginAddedVMCallback {
			get {
				if (PluginAdded_cb_delegate == null)
					PluginAdded_cb_delegate = new PluginAddedNativeDelegate (PluginAdded_cb);
				return PluginAdded_cb_delegate;
			}
		}

		static void OverridePluginAdded (GLib.GType gtype)
		{
			OverridePluginAdded (gtype, PluginAddedVMCallback);
		}

		static void OverridePluginAdded (GLib.GType gtype, PluginAddedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "plugin-added", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PluginAddedNativeDelegate (IntPtr inst, IntPtr plugin);

		static void PluginAdded_cb (IntPtr inst, IntPtr plugin)
		{
			try {
				Registry __obj = GLib.Object.GetObject (inst, false) as Registry;
				__obj.OnPluginAdded (GLib.Object.GetObject(plugin) as Gst.Plugin);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Registry), ConnectionMethod="OverridePluginAdded")]
		protected virtual void OnPluginAdded (Gst.Plugin plugin)
		{
			InternalPluginAdded (plugin);
		}

		private void InternalPluginAdded (Gst.Plugin plugin)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (plugin);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
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
		static extern IntPtr gst_registry_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_registry_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_registry_fork_is_enabled();

		public static bool ForkIsEnabled() {
			bool raw_ret = gst_registry_fork_is_enabled();
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_registry_fork_set_enabled(bool enabled);

		public static void ForkSetEnabled(bool enabled) {
			gst_registry_fork_set_enabled(enabled);
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_registry_get();

		public static Gst.Registry Get() {
			IntPtr raw_ret = gst_registry_get();
			Gst.Registry ret = GLib.Object.GetObject(raw_ret) as Gst.Registry;
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_registry_add_feature(IntPtr raw, IntPtr feature);

		public bool AddFeature(Gst.PluginFeature feature) {
			bool raw_ret = gst_registry_add_feature(Handle, feature == null ? IntPtr.Zero : feature.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_registry_add_plugin(IntPtr raw, IntPtr plugin);

		public bool AddPlugin(Gst.Plugin plugin) {
			bool raw_ret = gst_registry_add_plugin(Handle, plugin == null ? IntPtr.Zero : plugin.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_registry_check_feature_version(IntPtr raw, IntPtr feature_name, uint min_major, uint min_minor, uint min_micro);

		public bool CheckFeatureVersion(string feature_name, uint min_major, uint min_minor, uint min_micro) {
			IntPtr native_feature_name = GLib.Marshaller.StringToPtrGStrdup (feature_name);
			bool raw_ret = gst_registry_check_feature_version(Handle, native_feature_name, min_major, min_minor, min_micro);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_feature_name);
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_registry_feature_filter(IntPtr raw, GstSharp.PluginFeatureFilterNative filter, bool first, IntPtr user_data);

		public Gst.PluginFeature[] FeatureFilter(Gst.PluginFeatureFilter filter, bool first) {
			GstSharp.PluginFeatureFilterWrapper filter_wrapper = new GstSharp.PluginFeatureFilterWrapper (filter);
			IntPtr raw_ret = gst_registry_feature_filter(Handle, filter_wrapper.NativeDelegate, first, IntPtr.Zero);
			Gst.PluginFeature[] ret = (Gst.PluginFeature[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(Gst.PluginFeature));
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_registry_find_feature(IntPtr raw, IntPtr name, IntPtr type);

		public Gst.PluginFeature FindFeature(string name, GLib.GType type) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = gst_registry_find_feature(Handle, native_name, type.Val);
			Gst.PluginFeature ret = GLib.Object.GetObject(raw_ret, true) as Gst.PluginFeature;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_registry_find_plugin(IntPtr raw, IntPtr name);

		public Gst.Plugin FindPlugin(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = gst_registry_find_plugin(Handle, native_name);
			Gst.Plugin ret = GLib.Object.GetObject(raw_ret, true) as Gst.Plugin;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_registry_get_feature_list(IntPtr raw, IntPtr type);

		public Gst.PluginFeature[] GetFeatureList(GLib.GType type) {
			IntPtr raw_ret = gst_registry_get_feature_list(Handle, type.Val);
			Gst.PluginFeature[] ret = (Gst.PluginFeature[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(Gst.PluginFeature));
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_registry_get_feature_list_by_plugin(IntPtr raw, IntPtr name);

		public Gst.PluginFeature[] GetFeatureListByPlugin(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = gst_registry_get_feature_list_by_plugin(Handle, native_name);
			Gst.PluginFeature[] ret = (Gst.PluginFeature[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(Gst.PluginFeature));
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_registry_get_feature_list_cookie(IntPtr raw);

		public uint FeatureListCookie { 
			get {
				uint raw_ret = gst_registry_get_feature_list_cookie(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_registry_get_plugin_list(IntPtr raw);

		public Gst.Plugin[] PluginList { 
			get {
				IntPtr raw_ret = gst_registry_get_plugin_list(Handle);
				Gst.Plugin[] ret = (Gst.Plugin[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(Gst.Plugin));
				return ret;
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_registry_lookup(IntPtr raw, IntPtr filename);

		public Gst.Plugin Lookup(string filename) {
			IntPtr native_filename = GLib.Marshaller.StringToPtrGStrdup (filename);
			IntPtr raw_ret = gst_registry_lookup(Handle, native_filename);
			Gst.Plugin ret = GLib.Object.GetObject(raw_ret, true) as Gst.Plugin;
			GLib.Marshaller.Free (native_filename);
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_registry_lookup_feature(IntPtr raw, IntPtr name);

		public Gst.PluginFeature LookupFeature(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = gst_registry_lookup_feature(Handle, native_name);
			Gst.PluginFeature ret = GLib.Object.GetObject(raw_ret, true) as Gst.PluginFeature;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_registry_plugin_filter(IntPtr raw, GstSharp.PluginFilterNative filter, bool first, IntPtr user_data);

		public Gst.Plugin[] PluginFilter(Gst.PluginFilter filter, bool first) {
			GstSharp.PluginFilterWrapper filter_wrapper = new GstSharp.PluginFilterWrapper (filter);
			IntPtr raw_ret = gst_registry_plugin_filter(Handle, filter_wrapper.NativeDelegate, first, IntPtr.Zero);
			Gst.Plugin[] ret = (Gst.Plugin[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(Gst.Plugin));
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_registry_remove_feature(IntPtr raw, IntPtr feature);

		public void RemoveFeature(Gst.PluginFeature feature) {
			gst_registry_remove_feature(Handle, feature == null ? IntPtr.Zero : feature.Handle);
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_registry_remove_plugin(IntPtr raw, IntPtr plugin);

		public void RemovePlugin(Gst.Plugin plugin) {
			gst_registry_remove_plugin(Handle, plugin == null ? IntPtr.Zero : plugin.Handle);
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_registry_scan_path(IntPtr raw, IntPtr path);

		public bool ScanPath(string path) {
			IntPtr native_path = GLib.Marshaller.StringToFilenamePtr (path);
			bool raw_ret = gst_registry_scan_path(Handle, native_path);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_path);
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_update_registry();

		public static bool UpdateRegistry() {
			bool raw_ret = gst_update_registry();
			bool ret = raw_ret;
			return ret;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gst.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
