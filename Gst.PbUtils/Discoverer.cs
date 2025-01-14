﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.PbUtils {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class Discoverer : GLib.Object {

		public Discoverer (IntPtr raw) : base(raw) {}

		[DllImport(DLL.GstPbUtils, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_discoverer_new(ulong timeout);

		public Discoverer (ulong timeout) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Discoverer)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("timeout");
				vals.Add (new GLib.Value (timeout));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}

			Raw = gst_discoverer_new(timeout);
		}

		[GLib.Property ("timeout")]
		public ulong Timeout {
			get {
				GLib.Value val = GetProperty ("timeout");
				ulong ret = (ulong) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("timeout", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("use-cache")]
		public bool UseCache {
			get {
				GLib.Value val = GetProperty ("use-cache");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("use-cache", val);
				val.Dispose ();
			}
		}

		[GLib.Signal("discovered")]
		public event Gst.PbUtils.DiscoveredHandler Discovered {
			add {
				this.AddSignalHandler ("discovered", value, typeof (Gst.PbUtils.DiscoveredArgs));
			}
			remove {
				this.RemoveSignalHandler ("discovered", value);
			}
		}

		[GLib.Signal("starting")]
		public event System.EventHandler Starting {
			add {
				this.AddSignalHandler ("starting", value);
			}
			remove {
				this.RemoveSignalHandler ("starting", value);
			}
		}

		[GLib.Signal("finished")]
		public event System.EventHandler Finished {
			add {
				this.AddSignalHandler ("finished", value);
			}
			remove {
				this.RemoveSignalHandler ("finished", value);
			}
		}

		[GLib.Signal("source-setup")]
		public event Gst.PbUtils.SourceSetupHandler SourceSetup {
			add {
				this.AddSignalHandler ("source-setup", value, typeof (Gst.PbUtils.SourceSetupArgs));
			}
			remove {
				this.RemoveSignalHandler ("source-setup", value);
			}
		}

		static FinishedNativeDelegate Finished_cb_delegate;
		static FinishedNativeDelegate FinishedVMCallback {
			get {
				if (Finished_cb_delegate == null)
					Finished_cb_delegate = new FinishedNativeDelegate (Finished_cb);
				return Finished_cb_delegate;
			}
		}

		static void OverrideFinished (GLib.GType gtype)
		{
			OverrideFinished (gtype, FinishedVMCallback);
		}

		static void OverrideFinished (GLib.GType gtype, FinishedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("finished"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void FinishedNativeDelegate (IntPtr inst);

		static void Finished_cb (IntPtr inst)
		{
			try {
				Discoverer __obj = GLib.Object.GetObject (inst, false) as Discoverer;
				__obj.OnFinished ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.PbUtils.Discoverer), ConnectionMethod="OverrideFinished")]
		protected virtual void OnFinished ()
		{
			InternalFinished ();
		}

		private void InternalFinished ()
		{
			FinishedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("finished"));
				unmanaged = (FinishedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(FinishedNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static StartingNativeDelegate Starting_cb_delegate;
		static StartingNativeDelegate StartingVMCallback {
			get {
				if (Starting_cb_delegate == null)
					Starting_cb_delegate = new StartingNativeDelegate (Starting_cb);
				return Starting_cb_delegate;
			}
		}

		static void OverrideStarting (GLib.GType gtype)
		{
			OverrideStarting (gtype, StartingVMCallback);
		}

		static void OverrideStarting (GLib.GType gtype, StartingNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("starting"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void StartingNativeDelegate (IntPtr inst);

		static void Starting_cb (IntPtr inst)
		{
			try {
				Discoverer __obj = GLib.Object.GetObject (inst, false) as Discoverer;
				__obj.OnStarting ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.PbUtils.Discoverer), ConnectionMethod="OverrideStarting")]
		protected virtual void OnStarting ()
		{
			InternalStarting ();
		}

		private void InternalStarting ()
		{
			StartingNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("starting"));
				unmanaged = (StartingNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(StartingNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static DiscoveredNativeDelegate Discovered_cb_delegate;
		static DiscoveredNativeDelegate DiscoveredVMCallback {
			get {
				if (Discovered_cb_delegate == null)
					Discovered_cb_delegate = new DiscoveredNativeDelegate (Discovered_cb);
				return Discovered_cb_delegate;
			}
		}

		static void OverrideDiscovered (GLib.GType gtype)
		{
			OverrideDiscovered (gtype, DiscoveredVMCallback);
		}

		static void OverrideDiscovered (GLib.GType gtype, DiscoveredNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("discovered"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DiscoveredNativeDelegate (IntPtr inst, IntPtr info, IntPtr error);

		static void Discovered_cb (IntPtr inst, IntPtr info, IntPtr error)
		{
			try {
				Discoverer __obj = GLib.Object.GetObject (inst, false) as Discoverer;
				__obj.OnDiscovered (GLib.Object.GetObject(info) as Gst.PbUtils.DiscovererInfo, error);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.PbUtils.Discoverer), ConnectionMethod="OverrideDiscovered")]
		protected virtual void OnDiscovered (Gst.PbUtils.DiscovererInfo info, IntPtr error)
		{
			InternalDiscovered (info, error);
		}

		private void InternalDiscovered (Gst.PbUtils.DiscovererInfo info, IntPtr error)
		{
			DiscoveredNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("discovered"));
				unmanaged = (DiscoveredNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(DiscoveredNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, info == null ? IntPtr.Zero : info.Handle, error);
		}

		static SourceSetupNativeDelegate SourceSetup_cb_delegate;
		static SourceSetupNativeDelegate SourceSetupVMCallback {
			get {
				if (SourceSetup_cb_delegate == null)
					SourceSetup_cb_delegate = new SourceSetupNativeDelegate (SourceSetup_cb);
				return SourceSetup_cb_delegate;
			}
		}

		static void OverrideSourceSetup (GLib.GType gtype)
		{
			OverrideSourceSetup (gtype, SourceSetupVMCallback);
		}

		static void OverrideSourceSetup (GLib.GType gtype, SourceSetupNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("source_setup"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SourceSetupNativeDelegate (IntPtr inst, IntPtr source);

		static void SourceSetup_cb (IntPtr inst, IntPtr source)
		{
			try {
				Discoverer __obj = GLib.Object.GetObject (inst, false) as Discoverer;
				__obj.OnSourceSetup (GLib.Object.GetObject(source) as Gst.Element);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.PbUtils.Discoverer), ConnectionMethod="OverrideSourceSetup")]
		protected virtual void OnSourceSetup (Gst.Element source)
		{
			InternalSourceSetup (source);
		}

		private void InternalSourceSetup (Gst.Element source)
		{
			SourceSetupNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("source_setup"));
				unmanaged = (SourceSetupNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(SourceSetupNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, source == null ? IntPtr.Zero : source.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("finished"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // finished
							, null
							, "starting"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("starting"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // starting
							, "finished"
							, "discovered"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("discovered"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // discovered
							, "starting"
							, "source_setup"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("source_setup"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // source_setup
							, "discovered"
							, "_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _reserved
							, "source_setup"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport(DLL.GstPbUtils, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_discoverer_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_discoverer_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.GstPbUtils, CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr gst_discoverer_discover_uri(IntPtr raw, IntPtr uri, out IntPtr error);

		public unsafe Gst.PbUtils.DiscovererInfo DiscoverUri(string uri) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = gst_discoverer_discover_uri(Handle, native_uri, out error);
			Gst.PbUtils.DiscovererInfo ret = GLib.Object.GetObject(raw_ret, true) as Gst.PbUtils.DiscovererInfo;
			GLib.Marshaller.Free (native_uri);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.GstPbUtils, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_discoverer_discover_uri_async(IntPtr raw, IntPtr uri);

		public bool DiscoverUriAsync(string uri) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			bool raw_ret = gst_discoverer_discover_uri_async(Handle, native_uri);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_uri);
			return ret;
		}

		[DllImport(DLL.GstPbUtils, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_discoverer_start(IntPtr raw);

		public void Start() {
			gst_discoverer_start(Handle);
		}

		[DllImport(DLL.GstPbUtils, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_discoverer_stop(IntPtr raw);

		public void Stop() {
			gst_discoverer_stop(Handle);
		}


		static Discoverer ()
		{
			GtkSharp.GstreamerSharp.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GLib.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, "_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _reserved
							, "priv"
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
