﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class VideoOrientationAdapter : GLib.GInterfaceAdapter, Gst.Video.IVideoOrientation {

		[StructLayout (LayoutKind.Sequential)]
		struct GstVideoOrientationInterface {
			public GetHflipNativeDelegate GetHflip;
			public GetVflipNativeDelegate GetVflip;
			public GetHcenterNativeDelegate GetHcenter;
			public GetVcenterNativeDelegate GetVcenter;
			public SetHflipNativeDelegate SetHflip;
			public SetVflipNativeDelegate SetVflip;
			public SetHcenterNativeDelegate SetHcenter;
			public SetVcenterNativeDelegate SetVcenter;
		}

		static GstVideoOrientationInterface iface;

		static VideoOrientationAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (VideoOrientationAdapter));
			iface.GetHflip = new GetHflipNativeDelegate (GetHflip_cb);
			iface.GetVflip = new GetVflipNativeDelegate (GetVflip_cb);
			iface.GetHcenter = new GetHcenterNativeDelegate (GetHcenter_cb);
			iface.GetVcenter = new GetVcenterNativeDelegate (GetVcenter_cb);
			iface.SetHflip = new SetHflipNativeDelegate (SetHflip_cb);
			iface.SetVflip = new SetVflipNativeDelegate (SetVflip_cb);
			iface.SetHcenter = new SetHcenterNativeDelegate (SetHcenter_cb);
			iface.SetVcenter = new SetVcenterNativeDelegate (SetVcenter_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool GetHflipNativeDelegate (IntPtr inst, out bool flip);

		static bool GetHflip_cb (IntPtr inst, out bool flip)
		{
			try {
				IVideoOrientationImplementor __obj = GLib.Object.GetObject (inst, false) as IVideoOrientationImplementor;
				bool __result;
				__result = __obj.GetHflip (out flip);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool GetVflipNativeDelegate (IntPtr inst, out bool flip);

		static bool GetVflip_cb (IntPtr inst, out bool flip)
		{
			try {
				IVideoOrientationImplementor __obj = GLib.Object.GetObject (inst, false) as IVideoOrientationImplementor;
				bool __result;
				__result = __obj.GetVflip (out flip);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool GetHcenterNativeDelegate (IntPtr inst, out int center);

		static bool GetHcenter_cb (IntPtr inst, out int center)
		{
			try {
				IVideoOrientationImplementor __obj = GLib.Object.GetObject (inst, false) as IVideoOrientationImplementor;
				bool __result;
				__result = __obj.GetHcenter (out center);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool GetVcenterNativeDelegate (IntPtr inst, out int center);

		static bool GetVcenter_cb (IntPtr inst, out int center)
		{
			try {
				IVideoOrientationImplementor __obj = GLib.Object.GetObject (inst, false) as IVideoOrientationImplementor;
				bool __result;
				__result = __obj.GetVcenter (out center);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool SetHflipNativeDelegate (IntPtr inst, bool flip);

		static bool SetHflip_cb (IntPtr inst, bool flip)
		{
			try {
				IVideoOrientationImplementor __obj = GLib.Object.GetObject (inst, false) as IVideoOrientationImplementor;
				bool __result;
				__result = __obj.SetHflip (flip);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool SetVflipNativeDelegate (IntPtr inst, bool flip);

		static bool SetVflip_cb (IntPtr inst, bool flip)
		{
			try {
				IVideoOrientationImplementor __obj = GLib.Object.GetObject (inst, false) as IVideoOrientationImplementor;
				bool __result;
				__result = __obj.SetVflip (flip);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool SetHcenterNativeDelegate (IntPtr inst, int center);

		static bool SetHcenter_cb (IntPtr inst, int center)
		{
			try {
				IVideoOrientationImplementor __obj = GLib.Object.GetObject (inst, false) as IVideoOrientationImplementor;
				bool __result;
				__result = __obj.SetHcenter (center);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool SetVcenterNativeDelegate (IntPtr inst, int center);

		static bool SetVcenter_cb (IntPtr inst, int center)
		{
			try {
				IVideoOrientationImplementor __obj = GLib.Object.GetObject (inst, false) as IVideoOrientationImplementor;
				bool __result;
				__result = __obj.SetVcenter (center);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		static int class_offset = 2 * IntPtr.Size;

		static void Initialize (IntPtr ptr, IntPtr data)
		{
			IntPtr ifaceptr = new IntPtr (ptr.ToInt64 () + class_offset);
			GstVideoOrientationInterface native_iface = (GstVideoOrientationInterface) Marshal.PtrToStructure (ifaceptr, typeof (GstVideoOrientationInterface));
			native_iface.GetHflip = iface.GetHflip;
			native_iface.GetVflip = iface.GetVflip;
			native_iface.GetHcenter = iface.GetHcenter;
			native_iface.GetVcenter = iface.GetVcenter;
			native_iface.SetHflip = iface.SetHflip;
			native_iface.SetVflip = iface.SetVflip;
			native_iface.SetHcenter = iface.SetHcenter;
			native_iface.SetVcenter = iface.SetVcenter;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public VideoOrientationAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public VideoOrientationAdapter (IVideoOrientationImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public VideoOrientationAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_orientation_get_type();

		private static GLib.GType _gtype = new GLib.GType (gst_video_orientation_get_type ());

		public static GLib.GType GType {
			get {
				return _gtype;
			}
		}

		public override GLib.GType GInterfaceGType {
			get {
				return _gtype;
			}
		}

		public override IntPtr Handle {
			get {
				return implementor.Handle;
			}
		}

		public IntPtr OwnedHandle {
			get {
				return implementor.OwnedHandle;
			}
		}

		public static IVideoOrientation GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static IVideoOrientation GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is IVideoOrientationImplementor)
				return new VideoOrientationAdapter (obj as IVideoOrientationImplementor);
			else if (obj as IVideoOrientation == null)
				return new VideoOrientationAdapter (obj.Handle);
			else
				return obj as IVideoOrientation;
		}

		public IVideoOrientationImplementor Implementor {
			get {
				return implementor as IVideoOrientationImplementor;
			}
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_orientation_get_hcenter(IntPtr raw, out int center);

		public bool GetHcenter(out int center) {
			bool raw_ret = gst_video_orientation_get_hcenter(Handle, out center);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_orientation_get_hflip(IntPtr raw, out bool flip);

		public bool GetHflip(out bool flip) {
			bool raw_ret = gst_video_orientation_get_hflip(Handle, out flip);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_orientation_get_vcenter(IntPtr raw, out int center);

		public bool GetVcenter(out int center) {
			bool raw_ret = gst_video_orientation_get_vcenter(Handle, out center);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_orientation_get_vflip(IntPtr raw, out bool flip);

		public bool GetVflip(out bool flip) {
			bool raw_ret = gst_video_orientation_get_vflip(Handle, out flip);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_orientation_set_hcenter(IntPtr raw, int center);

		public bool SetHcenter(int center) {
			bool raw_ret = gst_video_orientation_set_hcenter(Handle, center);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_orientation_set_hflip(IntPtr raw, bool flip);

		public bool SetHflip(bool flip) {
			bool raw_ret = gst_video_orientation_set_hflip(Handle, flip);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_orientation_set_vcenter(IntPtr raw, int center);

		public bool SetVcenter(int center) {
			bool raw_ret = gst_video_orientation_set_vcenter(Handle, center);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_orientation_set_vflip(IntPtr raw, bool flip);

		public bool SetVflip(bool flip) {
			bool raw_ret = gst_video_orientation_set_vflip(Handle, flip);
			bool ret = raw_ret;
			return ret;
		}

#endregion
	}
}
