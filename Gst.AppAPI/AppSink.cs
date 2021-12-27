// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.App {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class AppSink : Gst.Base.BaseSink, Gst.IURIHandler {

		public AppSink (IntPtr raw) : base(raw) {}

		protected AppSink() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("buffer-list")]
		public bool BufferList {
			get {
				GLib.Value val = GetProperty ("buffer-list");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("buffer-list", val);
				val.Dispose ();
			}
		}

		[DllImport(DLL.GstApp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_app_sink_get_caps(IntPtr raw);

		[DllImport(DLL.GstApp, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_app_sink_set_caps(IntPtr raw, IntPtr caps);

		[GLib.Property ("caps")]
		public Gst.Caps Caps {
			get  {
				IntPtr raw_ret = gst_app_sink_get_caps(Handle);
				Gst.Caps ret = raw_ret == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Caps), true);
				return ret;
			}
			set  {
				gst_app_sink_set_caps(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport(DLL.GstApp, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_app_sink_get_drop(IntPtr raw);

		[DllImport(DLL.GstApp, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_app_sink_set_drop(IntPtr raw, bool drop);

		[GLib.Property ("drop")]
		public bool Drop {
			get  {
				bool raw_ret = gst_app_sink_get_drop(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gst_app_sink_set_drop(Handle, value);
			}
		}

		[DllImport(DLL.GstApp, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_app_sink_get_emit_signals(IntPtr raw);

		[DllImport(DLL.GstApp, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_app_sink_set_emit_signals(IntPtr raw, bool emit);

		[GLib.Property ("emit-signals")]
		public bool EmitSignals {
			get  {
				bool raw_ret = gst_app_sink_get_emit_signals(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gst_app_sink_set_emit_signals(Handle, value);
			}
		}

		[GLib.Property ("eos")]
		public bool EosProp
       {
			get {
				GLib.Value val = GetProperty ("eos");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[DllImport(DLL.GstApp, CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_app_sink_get_max_buffers(IntPtr raw);

		[DllImport(DLL.GstApp, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_app_sink_set_max_buffers(IntPtr raw, uint max);

		[GLib.Property ("max-buffers")]
		public uint MaxBuffers {
			get  {
				uint raw_ret = gst_app_sink_get_max_buffers(Handle);
				uint ret = raw_ret;
				return ret;
			}
			set  {
				gst_app_sink_set_max_buffers(Handle, value);
			}
		}

		[DllImport(DLL.GstApp, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_app_sink_get_wait_on_eos(IntPtr raw);

		[DllImport(DLL.GstApp, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_app_sink_set_wait_on_eos(IntPtr raw, bool wait);

		[GLib.Property ("wait-on-eos")]
		public bool WaitOnEos {
			get  {
				bool raw_ret = gst_app_sink_get_wait_on_eos(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gst_app_sink_set_wait_on_eos(Handle, value);
			}
		}

		[GLib.Signal("try-pull-sample")]
		public event Gst.App.TryPullSampleEventHandler TryPullSampleEvent {
			add {
				this.AddSignalHandler ("try-pull-sample", value, typeof (Gst.App.TryPullSampleEventArgs));
			}
			remove {
				this.RemoveSignalHandler ("try-pull-sample", value);
			}
		}

		[GLib.Signal("eos")]
		public event System.EventHandler Eos {
			add {
				this.AddSignalHandler ("eos", value);
			}
			remove {
				this.RemoveSignalHandler ("eos", value);
			}
		}

		[GLib.Signal("try-pull-preroll")]
		public event Gst.App.TryPullPrerollEventHandler TryPullPrerollEvent {
			add {
				this.AddSignalHandler ("try-pull-preroll", value, typeof (Gst.App.TryPullPrerollEventArgs));
			}
			remove {
				this.RemoveSignalHandler ("try-pull-preroll", value);
			}
		}

		[GLib.Signal("new-preroll")]
		public event Gst.App.NewPrerollHandler NewPreroll {
			add {
				this.AddSignalHandler ("new-preroll", value, typeof (Gst.App.NewPrerollArgs));
			}
			remove {
				this.RemoveSignalHandler ("new-preroll", value);
			}
		}

		[GLib.Signal("new-sample")]
		public event Gst.App.NewSampleHandler NewSample {
			add {
				this.AddSignalHandler ("new-sample", value, typeof (Gst.App.NewSampleArgs));
			}
			remove {
				this.RemoveSignalHandler ("new-sample", value);
			}
		}

		static EosNativeDelegate Eos_cb_delegate;
		static EosNativeDelegate EosVMCallback {
			get {
				if (Eos_cb_delegate == null)
					Eos_cb_delegate = new EosNativeDelegate (Eos_cb);
				return Eos_cb_delegate;
			}
		}

		static void OverrideEos (GLib.GType gtype)
		{
			OverrideEos (gtype, EosVMCallback);
		}

		static void OverrideEos (GLib.GType gtype, EosNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("eos"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void EosNativeDelegate (IntPtr inst);

		static void Eos_cb (IntPtr inst)
		{
			try {
				AppSink __obj = GLib.Object.GetObject (inst, false) as AppSink;
				__obj.OnEos ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.App.AppSink), ConnectionMethod="OverrideEos")]
		protected virtual void OnEos ()
		{
			InternalEos ();
		}

		private void InternalEos ()
		{
			EosNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("eos"));
				unmanaged = (EosNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(EosNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static NewPrerollNativeDelegate NewPreroll_cb_delegate;
		static NewPrerollNativeDelegate NewPrerollVMCallback {
			get {
				if (NewPreroll_cb_delegate == null)
					NewPreroll_cb_delegate = new NewPrerollNativeDelegate (NewPreroll_cb);
				return NewPreroll_cb_delegate;
			}
		}

		static void OverrideNewPreroll (GLib.GType gtype)
		{
			OverrideNewPreroll (gtype, NewPrerollVMCallback);
		}

		static void OverrideNewPreroll (GLib.GType gtype, NewPrerollNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("new_preroll"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int NewPrerollNativeDelegate (IntPtr inst);

		static int NewPreroll_cb (IntPtr inst)
		{
			try {
				AppSink __obj = GLib.Object.GetObject (inst, false) as AppSink;
				Gst.FlowReturn __result;
				__result = __obj.OnNewPreroll ();
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.App.AppSink), ConnectionMethod="OverrideNewPreroll")]
		protected virtual Gst.FlowReturn OnNewPreroll ()
		{
			return InternalNewPreroll ();
		}

		private Gst.FlowReturn InternalNewPreroll ()
		{
			NewPrerollNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("new_preroll"));
				unmanaged = (NewPrerollNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(NewPrerollNativeDelegate));
			}
			if (unmanaged == null) return (Gst.FlowReturn) 0;

			int __result = unmanaged (this.Handle);
			return (Gst.FlowReturn) __result;
		}

		static NewSampleNativeDelegate NewSample_cb_delegate;
		static NewSampleNativeDelegate NewSampleVMCallback {
			get {
				if (NewSample_cb_delegate == null)
					NewSample_cb_delegate = new NewSampleNativeDelegate (NewSample_cb);
				return NewSample_cb_delegate;
			}
		}

		static void OverrideNewSample (GLib.GType gtype)
		{
			OverrideNewSample (gtype, NewSampleVMCallback);
		}

		static void OverrideNewSample (GLib.GType gtype, NewSampleNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("new_sample"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int NewSampleNativeDelegate (IntPtr inst);

		static int NewSample_cb (IntPtr inst)
		{
			try {
				AppSink __obj = GLib.Object.GetObject (inst, false) as AppSink;
				Gst.FlowReturn __result;
				__result = __obj.OnNewSample ();
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.App.AppSink), ConnectionMethod="OverrideNewSample")]
		protected virtual Gst.FlowReturn OnNewSample ()
		{
			return InternalNewSample ();
		}

		private Gst.FlowReturn InternalNewSample ()
		{
			NewSampleNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("new_sample"));
				unmanaged = (NewSampleNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(NewSampleNativeDelegate));
			}
			if (unmanaged == null) return (Gst.FlowReturn) 0;

			int __result = unmanaged (this.Handle);
			return (Gst.FlowReturn) __result;
		}

		static TryPullPrerollEventNativeDelegate TryPullPrerollEvent_cb_delegate;
		static TryPullPrerollEventNativeDelegate TryPullPrerollEventVMCallback {
			get {
				if (TryPullPrerollEvent_cb_delegate == null)
					TryPullPrerollEvent_cb_delegate = new TryPullPrerollEventNativeDelegate (TryPullPrerollEvent_cb);
				return TryPullPrerollEvent_cb_delegate;
			}
		}

		static void OverrideTryPullPrerollEvent (GLib.GType gtype)
		{
			OverrideTryPullPrerollEvent (gtype, TryPullPrerollEventVMCallback);
		}

		static void OverrideTryPullPrerollEvent (GLib.GType gtype, TryPullPrerollEventNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("try_pull_preroll"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr TryPullPrerollEventNativeDelegate (IntPtr inst, ulong timeout);

		static IntPtr TryPullPrerollEvent_cb (IntPtr inst, ulong timeout)
		{
			try {
				AppSink __obj = GLib.Object.GetObject (inst, false) as AppSink;
				Gst.Sample __result;
				__result = __obj.OnTryPullPrerollEvent (timeout);
				return __result == null ? IntPtr.Zero : __result.OwnedCopy;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.App.AppSink), ConnectionMethod="OverrideTryPullPrerollEvent")]
		protected virtual Gst.Sample OnTryPullPrerollEvent (ulong timeout)
		{
			return InternalTryPullPrerollEvent (timeout);
		}

		private Gst.Sample InternalTryPullPrerollEvent (ulong timeout)
		{
			TryPullPrerollEventNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("try_pull_preroll"));
				unmanaged = (TryPullPrerollEventNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(TryPullPrerollEventNativeDelegate));
			}
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle, timeout);
			return __result == IntPtr.Zero ? null : (Gst.Sample) GLib.Opaque.GetOpaque (__result, typeof (Gst.Sample), true);
		}

		static TryPullSampleEventNativeDelegate TryPullSampleEvent_cb_delegate;
		static TryPullSampleEventNativeDelegate TryPullSampleEventVMCallback {
			get {
				if (TryPullSampleEvent_cb_delegate == null)
					TryPullSampleEvent_cb_delegate = new TryPullSampleEventNativeDelegate (TryPullSampleEvent_cb);
				return TryPullSampleEvent_cb_delegate;
			}
		}

		static void OverrideTryPullSampleEvent (GLib.GType gtype)
		{
			OverrideTryPullSampleEvent (gtype, TryPullSampleEventVMCallback);
		}

		static void OverrideTryPullSampleEvent (GLib.GType gtype, TryPullSampleEventNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("try_pull_sample"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr TryPullSampleEventNativeDelegate (IntPtr inst, ulong timeout);

		static IntPtr TryPullSampleEvent_cb (IntPtr inst, ulong timeout)
		{
			try {
				AppSink __obj = GLib.Object.GetObject (inst, false) as AppSink;
				Gst.Sample __result;
				__result = __obj.OnTryPullSampleEvent (timeout);
				return __result == null ? IntPtr.Zero : __result.OwnedCopy;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.App.AppSink), ConnectionMethod="OverrideTryPullSampleEvent")]
		protected virtual Gst.Sample OnTryPullSampleEvent (ulong timeout)
		{
			return InternalTryPullSampleEvent (timeout);
		}

		private Gst.Sample InternalTryPullSampleEvent (ulong timeout)
		{
			TryPullSampleEventNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("try_pull_sample"));
				unmanaged = (TryPullSampleEventNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(TryPullSampleEventNativeDelegate));
			}
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle, timeout);
			return __result == IntPtr.Zero ? null : (Gst.Sample) GLib.Opaque.GetOpaque (__result, typeof (Gst.Sample), true);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("eos"
							, Gst.Base.BaseSink.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // eos
							, null
							, "new_preroll"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("new_preroll"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // new_preroll
							, "eos"
							, "new_sample"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("new_sample"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // new_sample
							, "new_preroll"
							, "pull_preroll"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("pull_preroll"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // pull_preroll
							, "new_sample"
							, "pull_sample"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("pull_sample"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // pull_sample
							, "pull_preroll"
							, "try_pull_preroll"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("try_pull_preroll"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // try_pull_preroll
							, "pull_sample"
							, "try_pull_sample"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("try_pull_sample"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // try_pull_sample
							, "try_pull_preroll"
							, "_gst_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 2 // _gst_reserved
							, "try_pull_sample"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport(DLL.GstApp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_app_sink_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_app_sink_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.GstApp, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_app_sink_get_buffer_list_support(IntPtr raw);

		[DllImport(DLL.GstApp, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_app_sink_set_buffer_list_support(IntPtr raw, bool enable_lists);

		public bool BufferListSupport { 
			get {
				bool raw_ret = gst_app_sink_get_buffer_list_support(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gst_app_sink_set_buffer_list_support(Handle, value);
			}
		}

		[DllImport(DLL.GstApp, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_app_sink_is_eos(IntPtr raw);

		public bool IsEos { 
			get {
				bool raw_ret = gst_app_sink_is_eos(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.GstApp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_app_sink_pull_preroll(IntPtr raw);

		public Gst.Sample PullPreroll() {
			IntPtr raw_ret = gst_app_sink_pull_preroll(Handle);
			Gst.Sample ret = raw_ret == IntPtr.Zero ? null : (Gst.Sample) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Sample), true);
			return ret;
		}

		[DllImport(DLL.GstApp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_app_sink_pull_sample(IntPtr raw);

		public Gst.Sample PullSample() {
			IntPtr raw_ret = gst_app_sink_pull_sample(Handle);
			Gst.Sample ret = raw_ret == IntPtr.Zero ? null : (Gst.Sample) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Sample), true);
			return ret;
		}

		[DllImport(DLL.GstApp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_app_sink_try_pull_preroll(IntPtr raw, ulong timeout);

		public Gst.Sample TryPullPreroll(ulong timeout) {
			IntPtr raw_ret = gst_app_sink_try_pull_preroll(Handle, timeout);
			Gst.Sample ret = raw_ret == IntPtr.Zero ? null : (Gst.Sample) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Sample), true);
			return ret;
		}

		[DllImport(DLL.GstApp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_app_sink_try_pull_sample(IntPtr raw, ulong timeout);

		public Gst.Sample TryPullSample(ulong timeout) {
			IntPtr raw_ret = gst_app_sink_try_pull_sample(Handle, timeout);
			Gst.Sample ret = raw_ret == IntPtr.Zero ? null : (Gst.Sample) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Sample), true);
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_uri_handler_get_uri(IntPtr raw);

		public string Uri { 
			get {
				IntPtr raw_ret = gst_uri_handler_get_uri(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_uri_handler_get_uri_type(IntPtr raw);

		public Gst.URIType UriType { 
			get {
				int raw_ret = gst_uri_handler_get_uri_type(Handle);
				Gst.URIType ret = (Gst.URIType) raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_uri_handler_set_uri(IntPtr raw, IntPtr uri, out IntPtr error);

		public bool SetUri(string uri) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gst_uri_handler_set_uri(Handle, native_uri, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_uri);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}


		static AppSink ()
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
							, Gst.Base.BaseSink.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, "_gst_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _gst_reserved
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
