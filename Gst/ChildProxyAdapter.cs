﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class ChildProxyAdapter : GLib.GInterfaceAdapter, Gst.IChildProxy {

		[StructLayout (LayoutKind.Sequential)]
		struct GstChildProxyInterface {
			public GetChildByNameNativeDelegate GetChildByName;
			public GetChildByIndexNativeDelegate GetChildByIndex;
			public GetChildrenCountNativeDelegate GetChildrenCount;
			IntPtr ChildAddedEvent;
			IntPtr ChildRemovedEvent;
			[MarshalAs (UnmanagedType.ByValArray, SizeConst=4)]
			private IntPtr[] _gstGstReserved;
		}

		static GstChildProxyInterface iface;

		static ChildProxyAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (ChildProxyAdapter));
			iface.GetChildByName = new GetChildByNameNativeDelegate (GetChildByName_cb);
			iface.GetChildByIndex = new GetChildByIndexNativeDelegate (GetChildByIndex_cb);
			iface.GetChildrenCount = new GetChildrenCountNativeDelegate (GetChildrenCount_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetChildByNameNativeDelegate (IntPtr inst, IntPtr name);

		static IntPtr GetChildByName_cb (IntPtr inst, IntPtr name)
		{
			try {
				IChildProxyImplementor __obj = GLib.Object.GetObject (inst, false) as IChildProxyImplementor;
				GLib.Object __result;
				__result = __obj.GetChildByName (GLib.Marshaller.Utf8PtrToString (name));
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetChildByIndexNativeDelegate (IntPtr inst, uint index);

		static IntPtr GetChildByIndex_cb (IntPtr inst, uint index)
		{
			try {
				IChildProxyImplementor __obj = GLib.Object.GetObject (inst, false) as IChildProxyImplementor;
				GLib.Object __result;
				__result = __obj.GetChildByIndex (index);
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint GetChildrenCountNativeDelegate (IntPtr inst);

		static uint GetChildrenCount_cb (IntPtr inst)
		{
			try {
				IChildProxyImplementor __obj = GLib.Object.GetObject (inst, false) as IChildProxyImplementor;
				uint __result;
				__result = __obj.ChildrenCount;
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
			GstChildProxyInterface native_iface = (GstChildProxyInterface) Marshal.PtrToStructure (ifaceptr, typeof (GstChildProxyInterface));
			native_iface.GetChildByName = iface.GetChildByName;
			native_iface.GetChildByIndex = iface.GetChildByIndex;
			native_iface.GetChildrenCount = iface.GetChildrenCount;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public ChildProxyAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public ChildProxyAdapter (IChildProxyImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public ChildProxyAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_child_proxy_get_type();

		private static GLib.GType _gtype = new GLib.GType (gst_child_proxy_get_type ());

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

		public static IChildProxy GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static IChildProxy GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is IChildProxyImplementor)
				return new ChildProxyAdapter (obj as IChildProxyImplementor);
			else if (obj as IChildProxy == null)
				return new ChildProxyAdapter (obj.Handle);
			else
				return obj as IChildProxy;
		}

		public IChildProxyImplementor Implementor {
			get {
				return implementor as IChildProxyImplementor;
			}
		}

		[GLib.Signal("child-removed")]
		public event Gst.ChildRemovedEventHandler ChildRemovedEvent {
			add {
				GLib.Object.GetObject (Handle).AddSignalHandler ("child-removed", value, typeof (Gst.ChildRemovedEventArgs));
			}
			remove {
				GLib.Object.GetObject (Handle).RemoveSignalHandler ("child-removed", value);
			}
		}

		[GLib.Signal("child-added")]
		public event Gst.ChildAddedEventHandler ChildAddedEvent {
			add {
				GLib.Object.GetObject (Handle).AddSignalHandler ("child-added", value, typeof (Gst.ChildAddedEventArgs));
			}
			remove {
				GLib.Object.GetObject (Handle).RemoveSignalHandler ("child-added", value);
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_child_proxy_child_added(IntPtr raw, IntPtr child, IntPtr name);

		public void ChildAdded(GLib.Object child, string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_child_proxy_child_added(Handle, child == null ? IntPtr.Zero : child.Handle, native_name);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_child_proxy_child_removed(IntPtr raw, IntPtr child, IntPtr name);

		public void ChildRemoved(GLib.Object child, string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_child_proxy_child_removed(Handle, child == null ? IntPtr.Zero : child.Handle, native_name);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_child_proxy_get_child_by_index(IntPtr raw, uint index);

		public GLib.Object GetChildByIndex(uint index) {
			IntPtr raw_ret = gst_child_proxy_get_child_by_index(Handle, index);
			GLib.Object ret = GLib.Object.GetObject (raw_ret);
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_child_proxy_get_child_by_name(IntPtr raw, IntPtr name);

		public GLib.Object GetChildByName(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = gst_child_proxy_get_child_by_name(Handle, native_name);
			GLib.Object ret = GLib.Object.GetObject (raw_ret);
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_child_proxy_get_children_count(IntPtr raw);

		public uint ChildrenCount { 
			get {
				uint raw_ret = gst_child_proxy_get_children_count(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_child_proxy_lookup(IntPtr raw, IntPtr name, out IntPtr target, out IntPtr pspec);

		public bool Lookup(string name, out GLib.Object target, out IntPtr pspec) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr native_target;
			bool raw_ret = gst_child_proxy_lookup(Handle, native_name, out native_target, out pspec);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			target = GLib.Object.GetObject (native_target);
			return ret;
		}

#endregion
	}
}
