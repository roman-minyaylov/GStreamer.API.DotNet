﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Base {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class BaseParse : Gst.Element {

		protected BaseParse (IntPtr raw) : base(raw) {}

		protected BaseParse() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("disable-passthrough")]
		public bool DisablePassthrough {
			get {
				GLib.Value val = GetProperty ("disable-passthrough");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("disable-passthrough", val);
				val.Dispose ();
			}
		}

		public Gst.Pad Sinkpad {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("sinkpad"));
					return GLib.Object.GetObject((*raw_ptr)) as Gst.Pad;
				}
			}
		}

		public Gst.Pad Srcpad {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("srcpad"));
					return GLib.Object.GetObject((*raw_ptr)) as Gst.Pad;
				}
			}
		}

		public uint Flags {
			get {
				unsafe {
					uint* raw_ptr = (uint*)(((byte*)Handle) + abi_info.GetFieldOffset("flags"));
					return (*raw_ptr);
				}
			}
		}

		public Gst.Segment Segment {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("segment"));
					return Gst.Segment.New ((*raw_ptr));
				}
			}
		}

		static StartNativeDelegate Start_cb_delegate;
		static StartNativeDelegate StartVMCallback {
			get {
				if (Start_cb_delegate == null)
					Start_cb_delegate = new StartNativeDelegate (Start_cb);
				return Start_cb_delegate;
			}
		}

		static void OverrideStart (GLib.GType gtype)
		{
			OverrideStart (gtype, StartVMCallback);
		}

		static void OverrideStart (GLib.GType gtype, StartNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("start"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool StartNativeDelegate (IntPtr inst);

		static bool Start_cb (IntPtr inst)
		{
			try {
				BaseParse __obj = GLib.Object.GetObject (inst, false) as BaseParse;
				bool __result;
				__result = __obj.OnStart ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Base.BaseParse), ConnectionMethod="OverrideStart")]
		protected virtual bool OnStart ()
		{
			return InternalStart ();
		}

		private bool InternalStart ()
		{
			StartNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("start"));
				unmanaged = (StartNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(StartNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle);
			return __result;
		}

		static StopNativeDelegate Stop_cb_delegate;
		static StopNativeDelegate StopVMCallback {
			get {
				if (Stop_cb_delegate == null)
					Stop_cb_delegate = new StopNativeDelegate (Stop_cb);
				return Stop_cb_delegate;
			}
		}

		static void OverrideStop (GLib.GType gtype)
		{
			OverrideStop (gtype, StopVMCallback);
		}

		static void OverrideStop (GLib.GType gtype, StopNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("stop"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool StopNativeDelegate (IntPtr inst);

		static bool Stop_cb (IntPtr inst)
		{
			try {
				BaseParse __obj = GLib.Object.GetObject (inst, false) as BaseParse;
				bool __result;
				__result = __obj.OnStop ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Base.BaseParse), ConnectionMethod="OverrideStop")]
		protected virtual bool OnStop ()
		{
			return InternalStop ();
		}

		private bool InternalStop ()
		{
			StopNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("stop"));
				unmanaged = (StopNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(StopNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle);
			return __result;
		}

		static SetSinkCapsNativeDelegate SetSinkCaps_cb_delegate;
		static SetSinkCapsNativeDelegate SetSinkCapsVMCallback {
			get {
				if (SetSinkCaps_cb_delegate == null)
					SetSinkCaps_cb_delegate = new SetSinkCapsNativeDelegate (SetSinkCaps_cb);
				return SetSinkCaps_cb_delegate;
			}
		}

		static void OverrideSetSinkCaps (GLib.GType gtype)
		{
			OverrideSetSinkCaps (gtype, SetSinkCapsVMCallback);
		}

		static void OverrideSetSinkCaps (GLib.GType gtype, SetSinkCapsNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("set_sink_caps"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool SetSinkCapsNativeDelegate (IntPtr inst, IntPtr caps);

		static bool SetSinkCaps_cb (IntPtr inst, IntPtr caps)
		{
			try {
				BaseParse __obj = GLib.Object.GetObject (inst, false) as BaseParse;
				bool __result;
				__result = __obj.OnSetSinkCaps (caps == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (caps, typeof (Gst.Caps), false));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Base.BaseParse), ConnectionMethod="OverrideSetSinkCaps")]
		protected virtual bool OnSetSinkCaps (Gst.Caps caps)
		{
			return InternalSetSinkCaps (caps);
		}

		private bool InternalSetSinkCaps (Gst.Caps caps)
		{
			SetSinkCapsNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("set_sink_caps"));
				unmanaged = (SetSinkCapsNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(SetSinkCapsNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle, caps == null ? IntPtr.Zero : caps.Handle);
			return __result;
		}

		static HandleFrameNativeDelegate HandleFrame_cb_delegate;
		static HandleFrameNativeDelegate HandleFrameVMCallback {
			get {
				if (HandleFrame_cb_delegate == null)
					HandleFrame_cb_delegate = new HandleFrameNativeDelegate (HandleFrame_cb);
				return HandleFrame_cb_delegate;
			}
		}

		static void OverrideHandleFrame (GLib.GType gtype)
		{
			OverrideHandleFrame (gtype, HandleFrameVMCallback);
		}

		static void OverrideHandleFrame (GLib.GType gtype, HandleFrameNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("handle_frame"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int HandleFrameNativeDelegate (IntPtr inst, IntPtr frame, int skipsize);

		static int HandleFrame_cb (IntPtr inst, IntPtr frame, int skipsize)
		{
			try {
				BaseParse __obj = GLib.Object.GetObject (inst, false) as BaseParse;
				Gst.FlowReturn __result;
				__result = __obj.OnHandleFrame (Gst.Base.BaseParseFrame.New (frame), skipsize);
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Base.BaseParse), ConnectionMethod="OverrideHandleFrame")]
		protected virtual Gst.FlowReturn OnHandleFrame (Gst.Base.BaseParseFrame frame, int skipsize)
		{
			return InternalHandleFrame (frame, skipsize);
		}

		private Gst.FlowReturn InternalHandleFrame (Gst.Base.BaseParseFrame frame, int skipsize)
		{
			HandleFrameNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("handle_frame"));
				unmanaged = (HandleFrameNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(HandleFrameNativeDelegate));
			}
			if (unmanaged == null) return (Gst.FlowReturn) 0;

			IntPtr native_frame = GLib.Marshaller.StructureToPtrAlloc (frame);
			int __result = unmanaged (this.Handle, native_frame, skipsize);
			Marshal.FreeHGlobal (native_frame);
			return (Gst.FlowReturn) __result;
		}

		static PrePushFrameNativeDelegate PrePushFrame_cb_delegate;
		static PrePushFrameNativeDelegate PrePushFrameVMCallback {
			get {
				if (PrePushFrame_cb_delegate == null)
					PrePushFrame_cb_delegate = new PrePushFrameNativeDelegate (PrePushFrame_cb);
				return PrePushFrame_cb_delegate;
			}
		}

		static void OverridePrePushFrame (GLib.GType gtype)
		{
			OverridePrePushFrame (gtype, PrePushFrameVMCallback);
		}

		static void OverridePrePushFrame (GLib.GType gtype, PrePushFrameNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("pre_push_frame"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int PrePushFrameNativeDelegate (IntPtr inst, IntPtr frame);

		static int PrePushFrame_cb (IntPtr inst, IntPtr frame)
		{
			try {
				BaseParse __obj = GLib.Object.GetObject (inst, false) as BaseParse;
				Gst.FlowReturn __result;
				__result = __obj.OnPrePushFrame (Gst.Base.BaseParseFrame.New (frame));
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Base.BaseParse), ConnectionMethod="OverridePrePushFrame")]
		protected virtual Gst.FlowReturn OnPrePushFrame (Gst.Base.BaseParseFrame frame)
		{
			return InternalPrePushFrame (frame);
		}

		private Gst.FlowReturn InternalPrePushFrame (Gst.Base.BaseParseFrame frame)
		{
			PrePushFrameNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("pre_push_frame"));
				unmanaged = (PrePushFrameNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(PrePushFrameNativeDelegate));
			}
			if (unmanaged == null) return (Gst.FlowReturn) 0;

			IntPtr native_frame = GLib.Marshaller.StructureToPtrAlloc (frame);
			int __result = unmanaged (this.Handle, native_frame);
			Marshal.FreeHGlobal (native_frame);
			return (Gst.FlowReturn) __result;
		}

		static ConvertNativeDelegate Convert_cb_delegate;
		static ConvertNativeDelegate ConvertVMCallback {
			get {
				if (Convert_cb_delegate == null)
					Convert_cb_delegate = new ConvertNativeDelegate (Convert_cb);
				return Convert_cb_delegate;
			}
		}

		static void OverrideConvert (GLib.GType gtype)
		{
			OverrideConvert (gtype, ConvertVMCallback);
		}

		static void OverrideConvert (GLib.GType gtype, ConvertNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("convert"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool ConvertNativeDelegate (IntPtr inst, int src_format, long src_value, int dest_format, long dest_value);

		static bool Convert_cb (IntPtr inst, int src_format, long src_value, int dest_format, long dest_value)
		{
			try {
				BaseParse __obj = GLib.Object.GetObject (inst, false) as BaseParse;
				bool __result;
				__result = __obj.OnConvert ((Gst.Format) src_format, src_value, (Gst.Format) dest_format, dest_value);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Base.BaseParse), ConnectionMethod="OverrideConvert")]
		protected virtual bool OnConvert (Gst.Format src_format, long src_value, Gst.Format dest_format, long dest_value)
		{
			return InternalConvert (src_format, src_value, dest_format, dest_value);
		}

		private bool InternalConvert (Gst.Format src_format, long src_value, Gst.Format dest_format, long dest_value)
		{
			ConvertNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("convert"));
				unmanaged = (ConvertNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ConvertNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle, (int) src_format, src_value, (int) dest_format, dest_value);
			return __result;
		}

		static SinkEventNativeDelegate SinkEvent_cb_delegate;
		static SinkEventNativeDelegate SinkEventVMCallback {
			get {
				if (SinkEvent_cb_delegate == null)
					SinkEvent_cb_delegate = new SinkEventNativeDelegate (SinkEvent_cb);
				return SinkEvent_cb_delegate;
			}
		}

		static void OverrideSinkEvent (GLib.GType gtype)
		{
			OverrideSinkEvent (gtype, SinkEventVMCallback);
		}

		static void OverrideSinkEvent (GLib.GType gtype, SinkEventNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("sink_event"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool SinkEventNativeDelegate (IntPtr inst, IntPtr evnt);

		static bool SinkEvent_cb (IntPtr inst, IntPtr evnt)
		{
			try {
				BaseParse __obj = GLib.Object.GetObject (inst, false) as BaseParse;
				bool __result;
				__result = __obj.OnSinkEvent (evnt == IntPtr.Zero ? null : (Gst.Event) GLib.Opaque.GetOpaque (evnt, typeof (Gst.Event), false));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Base.BaseParse), ConnectionMethod="OverrideSinkEvent")]
		protected virtual bool OnSinkEvent (Gst.Event evnt)
		{
			return InternalSinkEvent (evnt);
		}

		private bool InternalSinkEvent (Gst.Event evnt)
		{
			SinkEventNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("sink_event"));
				unmanaged = (SinkEventNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(SinkEventNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle, evnt == null ? IntPtr.Zero : evnt.Handle);
			return __result;
		}

		static SrcEventNativeDelegate SrcEvent_cb_delegate;
		static SrcEventNativeDelegate SrcEventVMCallback {
			get {
				if (SrcEvent_cb_delegate == null)
					SrcEvent_cb_delegate = new SrcEventNativeDelegate (SrcEvent_cb);
				return SrcEvent_cb_delegate;
			}
		}

		static void OverrideSrcEvent (GLib.GType gtype)
		{
			OverrideSrcEvent (gtype, SrcEventVMCallback);
		}

		static void OverrideSrcEvent (GLib.GType gtype, SrcEventNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("src_event"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool SrcEventNativeDelegate (IntPtr inst, IntPtr evnt);

		static bool SrcEvent_cb (IntPtr inst, IntPtr evnt)
		{
			try {
				BaseParse __obj = GLib.Object.GetObject (inst, false) as BaseParse;
				bool __result;
				__result = __obj.OnSrcEvent (evnt == IntPtr.Zero ? null : (Gst.Event) GLib.Opaque.GetOpaque (evnt, typeof (Gst.Event), false));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Base.BaseParse), ConnectionMethod="OverrideSrcEvent")]
		protected virtual bool OnSrcEvent (Gst.Event evnt)
		{
			return InternalSrcEvent (evnt);
		}

		private bool InternalSrcEvent (Gst.Event evnt)
		{
			SrcEventNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("src_event"));
				unmanaged = (SrcEventNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(SrcEventNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle, evnt == null ? IntPtr.Zero : evnt.Handle);
			return __result;
		}

		static GetSinkCapsNativeDelegate GetSinkCaps_cb_delegate;
		static GetSinkCapsNativeDelegate GetSinkCapsVMCallback {
			get {
				if (GetSinkCaps_cb_delegate == null)
					GetSinkCaps_cb_delegate = new GetSinkCapsNativeDelegate (GetSinkCaps_cb);
				return GetSinkCaps_cb_delegate;
			}
		}

		static void OverrideGetSinkCaps (GLib.GType gtype)
		{
			OverrideGetSinkCaps (gtype, GetSinkCapsVMCallback);
		}

		static void OverrideGetSinkCaps (GLib.GType gtype, GetSinkCapsNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_sink_caps"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetSinkCapsNativeDelegate (IntPtr inst, IntPtr filter);

		static IntPtr GetSinkCaps_cb (IntPtr inst, IntPtr filter)
		{
			try {
				BaseParse __obj = GLib.Object.GetObject (inst, false) as BaseParse;
				Gst.Caps __result;
				__result = __obj.OnGetSinkCaps (filter == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (filter, typeof (Gst.Caps), false));
				return __result == null ? IntPtr.Zero : __result.OwnedCopy;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Base.BaseParse), ConnectionMethod="OverrideGetSinkCaps")]
		protected virtual Gst.Caps OnGetSinkCaps (Gst.Caps filter)
		{
			return InternalGetSinkCaps (filter);
		}

		private Gst.Caps InternalGetSinkCaps (Gst.Caps filter)
		{
			GetSinkCapsNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("get_sink_caps"));
				unmanaged = (GetSinkCapsNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GetSinkCapsNativeDelegate));
			}
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle, filter == null ? IntPtr.Zero : filter.Handle);
			return __result == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (__result, typeof (Gst.Caps), true);
		}

		static DetectNativeDelegate Detect_cb_delegate;
		static DetectNativeDelegate DetectVMCallback {
			get {
				if (Detect_cb_delegate == null)
					Detect_cb_delegate = new DetectNativeDelegate (Detect_cb);
				return Detect_cb_delegate;
			}
		}

		static void OverrideDetect (GLib.GType gtype)
		{
			OverrideDetect (gtype, DetectVMCallback);
		}

		static void OverrideDetect (GLib.GType gtype, DetectNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("detect"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int DetectNativeDelegate (IntPtr inst, IntPtr buffer);

		static int Detect_cb (IntPtr inst, IntPtr buffer)
		{
			try {
				BaseParse __obj = GLib.Object.GetObject (inst, false) as BaseParse;
				Gst.FlowReturn __result;
				__result = __obj.OnDetect (buffer == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (buffer, typeof (Gst.Buffer), false));
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Base.BaseParse), ConnectionMethod="OverrideDetect")]
		protected virtual Gst.FlowReturn OnDetect (Gst.Buffer buffer)
		{
			return InternalDetect (buffer);
		}

		private Gst.FlowReturn InternalDetect (Gst.Buffer buffer)
		{
			DetectNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("detect"));
				unmanaged = (DetectNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(DetectNativeDelegate));
			}
			if (unmanaged == null) return (Gst.FlowReturn) 0;

			int __result = unmanaged (this.Handle, buffer == null ? IntPtr.Zero : buffer.Handle);
			return (Gst.FlowReturn) __result;
		}

		static SinkQueryNativeDelegate SinkQuery_cb_delegate;
		static SinkQueryNativeDelegate SinkQueryVMCallback {
			get {
				if (SinkQuery_cb_delegate == null)
					SinkQuery_cb_delegate = new SinkQueryNativeDelegate (SinkQuery_cb);
				return SinkQuery_cb_delegate;
			}
		}

		static void OverrideSinkQuery (GLib.GType gtype)
		{
			OverrideSinkQuery (gtype, SinkQueryVMCallback);
		}

		static void OverrideSinkQuery (GLib.GType gtype, SinkQueryNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("sink_query"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool SinkQueryNativeDelegate (IntPtr inst, IntPtr query);

		static bool SinkQuery_cb (IntPtr inst, IntPtr query)
		{
			try {
				BaseParse __obj = GLib.Object.GetObject (inst, false) as BaseParse;
				bool __result;
				__result = __obj.OnSinkQuery (query == IntPtr.Zero ? null : (Gst.Query) GLib.Opaque.GetOpaque (query, typeof (Gst.Query), false));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Base.BaseParse), ConnectionMethod="OverrideSinkQuery")]
		protected virtual bool OnSinkQuery (Gst.Query query)
		{
			return InternalSinkQuery (query);
		}

		private bool InternalSinkQuery (Gst.Query query)
		{
			SinkQueryNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("sink_query"));
				unmanaged = (SinkQueryNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(SinkQueryNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle, query == null ? IntPtr.Zero : query.Handle);
			return __result;
		}

		static SrcQueryNativeDelegate SrcQuery_cb_delegate;
		static SrcQueryNativeDelegate SrcQueryVMCallback {
			get {
				if (SrcQuery_cb_delegate == null)
					SrcQuery_cb_delegate = new SrcQueryNativeDelegate (SrcQuery_cb);
				return SrcQuery_cb_delegate;
			}
		}

		static void OverrideSrcQuery (GLib.GType gtype)
		{
			OverrideSrcQuery (gtype, SrcQueryVMCallback);
		}

		static void OverrideSrcQuery (GLib.GType gtype, SrcQueryNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("src_query"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool SrcQueryNativeDelegate (IntPtr inst, IntPtr query);

		static bool SrcQuery_cb (IntPtr inst, IntPtr query)
		{
			try {
				BaseParse __obj = GLib.Object.GetObject (inst, false) as BaseParse;
				bool __result;
				__result = __obj.OnSrcQuery (query == IntPtr.Zero ? null : (Gst.Query) GLib.Opaque.GetOpaque (query, typeof (Gst.Query), false));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Base.BaseParse), ConnectionMethod="OverrideSrcQuery")]
		protected virtual bool OnSrcQuery (Gst.Query query)
		{
			return InternalSrcQuery (query);
		}

		private bool InternalSrcQuery (Gst.Query query)
		{
			SrcQueryNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("src_query"));
				unmanaged = (SrcQueryNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(SrcQueryNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle, query == null ? IntPtr.Zero : query.Handle);
			return __result;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("start"
							, Gst.Element.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // start
							, null
							, "stop"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("stop"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // stop
							, "start"
							, "set_sink_caps"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("set_sink_caps"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // set_sink_caps
							, "stop"
							, "handle_frame"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("handle_frame"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // handle_frame
							, "set_sink_caps"
							, "pre_push_frame"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("pre_push_frame"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // pre_push_frame
							, "handle_frame"
							, "convert"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("convert"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // convert
							, "pre_push_frame"
							, "sink_event"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("sink_event"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // sink_event
							, "convert"
							, "src_event"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("src_event"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // src_event
							, "sink_event"
							, "get_sink_caps"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("get_sink_caps"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_sink_caps
							, "src_event"
							, "detect"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("detect"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // detect
							, "get_sink_caps"
							, "sink_query"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("sink_query"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // sink_query
							, "detect"
							, "src_query"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("src_query"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // src_query
							, "sink_query"
							, "_gst_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 18 // _gst_reserved
							, "src_query"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport(DLL.GstBase, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_base_parse_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_base_parse_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.GstBase, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_base_parse_add_index_entry(IntPtr raw, ulong offset, ulong ts, bool key, bool force);

		public bool AddIndexEntry(ulong offset, ulong ts, bool key, bool force) {
			bool raw_ret = gst_base_parse_add_index_entry(Handle, offset, ts, key, force);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GstBase, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_base_parse_convert_default(IntPtr raw, int src_format, long src_value, int dest_format, out long dest_value);

		public bool ConvertDefault(Gst.Format src_format, long src_value, Gst.Format dest_format, out long dest_value) {
			bool raw_ret = gst_base_parse_convert_default(Handle, (int) src_format, src_value, (int) dest_format, out dest_value);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GstBase, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_base_parse_drain(IntPtr raw);

		public void Drain() {
			gst_base_parse_drain(Handle);
		}

		[DllImport(DLL.GstBase, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_base_parse_finish_frame(IntPtr raw, IntPtr frame, int size);

		public Gst.FlowReturn FinishFrame(Gst.Base.BaseParseFrame frame, int size) {
			IntPtr native_frame = GLib.Marshaller.StructureToPtrAlloc (frame);
			int raw_ret = gst_base_parse_finish_frame(Handle, native_frame, size);
			Gst.FlowReturn ret = (Gst.FlowReturn) raw_ret;
			Marshal.FreeHGlobal (native_frame);
			return ret;
		}

		[DllImport(DLL.GstBase, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_base_parse_merge_tags(IntPtr raw, IntPtr tags, int mode);

		public void MergeTags(Gst.TagList tags, Gst.TagMergeMode mode) {
			gst_base_parse_merge_tags(Handle, tags == null ? IntPtr.Zero : tags.Handle, (int) mode);
		}

		public void MergeTags(Gst.TagMergeMode mode) {
			MergeTags (null, mode);
		}

		[DllImport(DLL.GstBase, CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_base_parse_push_frame(IntPtr raw, IntPtr frame);

		public Gst.FlowReturn PushFrame(Gst.Base.BaseParseFrame frame) {
			IntPtr native_frame = GLib.Marshaller.StructureToPtrAlloc (frame);
			int raw_ret = gst_base_parse_push_frame(Handle, native_frame);
			Gst.FlowReturn ret = (Gst.FlowReturn) raw_ret;
			Marshal.FreeHGlobal (native_frame);
			return ret;
		}

		[DllImport(DLL.GstBase, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_base_parse_set_average_bitrate(IntPtr raw, uint bitrate);

		public uint AverageBitrate { 
			set {
				gst_base_parse_set_average_bitrate(Handle, value);
			}
		}

		[DllImport(DLL.GstBase, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_base_parse_set_duration(IntPtr raw, int fmt, long duration, int interval);

		public void SetDuration(Gst.Format fmt, long duration, int interval) {
			gst_base_parse_set_duration(Handle, (int) fmt, duration, interval);
		}

		[DllImport(DLL.GstBase, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_base_parse_set_frame_rate(IntPtr raw, uint fps_num, uint fps_den, uint lead_in, uint lead_out);

		public void SetFrameRate(uint fps_num, uint fps_den, uint lead_in, uint lead_out) {
			gst_base_parse_set_frame_rate(Handle, fps_num, fps_den, lead_in, lead_out);
		}

		[DllImport(DLL.GstBase, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_base_parse_set_has_timing_info(IntPtr raw, bool has_timing);

		public bool HasTimingInfo { 
			set {
				gst_base_parse_set_has_timing_info(Handle, value);
			}
		}

		[DllImport(DLL.GstBase, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_base_parse_set_infer_ts(IntPtr raw, bool infer_ts);

		public bool InferTs { 
			set {
				gst_base_parse_set_infer_ts(Handle, value);
			}
		}

		[DllImport(DLL.GstBase, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_base_parse_set_latency(IntPtr raw, ulong min_latency, ulong max_latency);

		public void SetLatency(ulong min_latency, ulong max_latency) {
			gst_base_parse_set_latency(Handle, min_latency, max_latency);
		}

		[DllImport(DLL.GstBase, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_base_parse_set_min_frame_size(IntPtr raw, uint min_size);

		public uint MinFrameSize { 
			set {
				gst_base_parse_set_min_frame_size(Handle, value);
			}
		}

		[DllImport(DLL.GstBase, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_base_parse_set_passthrough(IntPtr raw, bool passthrough);

		public bool Passthrough { 
			set {
				gst_base_parse_set_passthrough(Handle, value);
			}
		}

		[DllImport(DLL.GstBase, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_base_parse_set_pts_interpolation(IntPtr raw, bool pts_interpolate);

		public bool PtsInterpolation { 
			set {
				gst_base_parse_set_pts_interpolation(Handle, value);
			}
		}

		[DllImport(DLL.GstBase, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_base_parse_set_syncable(IntPtr raw, bool syncable);

		public bool Syncable { 
			set {
				gst_base_parse_set_syncable(Handle, value);
			}
		}

		[DllImport(DLL.GstBase, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_base_parse_set_ts_at_offset(IntPtr raw, UIntPtr offset);

		public ulong TsAtOffset { 
			set {
				gst_base_parse_set_ts_at_offset(Handle, new UIntPtr (value));
			}
		}


		static BaseParse ()
		{
			GtkSharp.GstreamerSharp.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("sinkpad"
							, Gst.Element.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // sinkpad
							, null
							, "srcpad"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("srcpad"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // srcpad
							, "sinkpad"
							, "flags"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("flags"
							, -1
							, (uint) Marshal.SizeOf(typeof(uint)) // flags
							, "srcpad"
							, "segment"
							, (long) Marshal.OffsetOf(typeof(GstBaseParse_flagsAlign), "flags")
							, 0
							),
						new GLib.AbiField("segment"
							, -1
							, (uint) Marshal.SizeOf(typeof(Gst.Segment)) // segment
							, "flags"
							, "_gst_reserved"
							, (long) Marshal.OffsetOf(typeof(GstBaseParse_segmentAlign), "segment")
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 20 // _gst_reserved
							, "segment"
							, "priv"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("priv"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, "_gst_reserved"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstBaseParse_flagsAlign
		{
			sbyte f1;
			private uint flags;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstBaseParse_segmentAlign
		{
			sbyte f1;
			private Gst.Segment segment;
		}


		// End of the ABI representation.

#endregion
	}
}
