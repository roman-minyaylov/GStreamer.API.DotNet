﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class SrvTarget : GLib.Opaque {

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_srv_target_copy(IntPtr raw);

		public GLib.SrvTarget Copy() {
			IntPtr raw_ret = g_srv_target_copy(Handle);
			GLib.SrvTarget ret = raw_ret == IntPtr.Zero ? null : (GLib.SrvTarget) GLib.Opaque.GetOpaque (raw_ret, typeof (GLib.SrvTarget), true);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_srv_target_get_hostname(IntPtr raw);

		public string Hostname { 
			get {
				IntPtr raw_ret = g_srv_target_get_hostname(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern ushort g_srv_target_get_port(IntPtr raw);

		public ushort Port { 
			get {
				ushort raw_ret = g_srv_target_get_port(Handle);
				ushort ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern ushort g_srv_target_get_priority(IntPtr raw);

		public ushort Priority { 
			get {
				ushort raw_ret = g_srv_target_get_priority(Handle);
				ushort ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_srv_target_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = g_srv_target_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern ushort g_srv_target_get_weight(IntPtr raw);

		public ushort Weight { 
			get {
				ushort raw_ret = g_srv_target_get_weight(Handle);
				ushort ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_srv_target_list_sort(IntPtr targets);

		public static GLib.SrvTarget[] ListSort(GLib.List targets) {
			IntPtr raw_ret = g_srv_target_list_sort(targets == null ? IntPtr.Zero : targets.Handle);
			GLib.SrvTarget[] ret = (GLib.SrvTarget[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), false, false, typeof(GLib.SrvTarget));
			return ret;
		}

		public SrvTarget(IntPtr raw) : base(raw) {}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_srv_target_new(IntPtr hostname, ushort port, ushort priority, ushort weight);

		public SrvTarget (string hostname, ushort port, ushort priority, ushort weight) 
		{
			IntPtr native_hostname = GLib.Marshaller.StringToPtrGStrdup (hostname);
			Raw = g_srv_target_new(native_hostname, port, priority, weight);
			GLib.Marshaller.Free (native_hostname);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_srv_target_free(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			g_srv_target_free (raw);
		}

		class FinalizerInfo {
			IntPtr handle;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				g_srv_target_free (handle);
				return false;
			}
		}

		~SrvTarget ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
