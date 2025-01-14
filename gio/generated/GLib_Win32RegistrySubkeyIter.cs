﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct Win32RegistrySubkeyIter : IEquatable<Win32RegistrySubkeyIter> {

		private IntPtr _key;
		private int counter;
		private int subkey_count;
		private IntPtr _subkey_name;
		private UIntPtr subkey_name_size;
		private UIntPtr subkey_name_len;
		private string subkey_name_u8;

		public static GLib.Win32RegistrySubkeyIter Zero = new GLib.Win32RegistrySubkeyIter ();

		public static GLib.Win32RegistrySubkeyIter New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return GLib.Win32RegistrySubkeyIter.Zero;
			return (GLib.Win32RegistrySubkeyIter) Marshal.PtrToStructure (raw, typeof (GLib.Win32RegistrySubkeyIter));
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_win32_registry_subkey_iter_assign(IntPtr raw, IntPtr other);

		public void Assign(GLib.Win32RegistrySubkeyIter other) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_other = GLib.Marshaller.StructureToPtrAlloc (other);
			g_win32_registry_subkey_iter_assign(this_as_native, native_other);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			Marshal.FreeHGlobal (native_other);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_win32_registry_subkey_iter_clear(IntPtr raw);

		public void Clear() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			g_win32_registry_subkey_iter_clear(this_as_native);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool g_win32_registry_subkey_iter_get_name(IntPtr raw, IntPtr subkey_name, out UIntPtr subkey_name_len, out IntPtr error);

		public unsafe bool GetName(string subkey_name, out ulong subkey_name_len) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			UIntPtr native_subkey_name_len;
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_win32_registry_subkey_iter_get_name(this_as_native, GLib.Marshaller.StringToPtrGStrdup(subkey_name), out native_subkey_name_len, out error);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			subkey_name_len = (ulong) native_subkey_name_len;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_win32_registry_subkey_iter_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = g_win32_registry_subkey_iter_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool g_win32_registry_subkey_iter_init(IntPtr raw, IntPtr key, out IntPtr error);

		public unsafe bool Init(GLib.Win32RegistryKey key) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_win32_registry_subkey_iter_init(this_as_native, key == null ? IntPtr.Zero : key.Handle, out error);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern UIntPtr g_win32_registry_subkey_iter_n_subkeys(IntPtr raw);

		public ulong NSubkeys() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			UIntPtr raw_ret = g_win32_registry_subkey_iter_n_subkeys(this_as_native);
			ulong ret = (ulong) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool g_win32_registry_subkey_iter_next(IntPtr raw, bool skip_errors, out IntPtr error);

		public unsafe bool Next(bool skip_errors) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_win32_registry_subkey_iter_next(this_as_native, skip_errors, out error);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		static void ReadNative (IntPtr native, ref GLib.Win32RegistrySubkeyIter target)
		{
			target = New (native);
		}

		public bool Equals (Win32RegistrySubkeyIter other)
		{
			return true && _key.Equals (other._key) && counter.Equals (other.counter) && subkey_count.Equals (other.subkey_count) && _subkey_name.Equals (other._subkey_name) && subkey_name_size.Equals (other.subkey_name_size) && subkey_name_len.Equals (other.subkey_name_len) && subkey_name_u8.Equals (other.subkey_name_u8);
		}

		public override bool Equals (object other)
		{
			return other is Win32RegistrySubkeyIter && Equals ((Win32RegistrySubkeyIter) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ _key.GetHashCode () ^ counter.GetHashCode () ^ subkey_count.GetHashCode () ^ _subkey_name.GetHashCode () ^ subkey_name_size.GetHashCode () ^ subkey_name_len.GetHashCode () ^ subkey_name_u8.GetHashCode ();
		}

		public static explicit operator GLib.Value (GLib.Win32RegistrySubkeyIter boxed)
		{
			GLib.Value val = GLib.Value.Empty;
			val.Init (GLib.Win32RegistrySubkeyIter.GType);
			val.Val = boxed;
			return val;
		}

		public static explicit operator GLib.Win32RegistrySubkeyIter (GLib.Value val)
		{
			return (GLib.Win32RegistrySubkeyIter) val.Val;
		}
#endregion
	}
}
