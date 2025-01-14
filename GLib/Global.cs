﻿// GLib.Global.cs - Global glib properties and methods.
//
// Authors: Andres G. Aragoneses <aaragoneses@novell.com>
//          Stephane Delcroix (stephane@delcroix.org)
//
// Copyright (c) 2008 Novell, Inc.
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of version 2 of the Lesser GNU General 
// Public License as published by the Free Software Foundation.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this program; if not, write to the
// Free Software Foundation, Inc., 59 Temple Place - Suite 330,
// Boston, MA 02111-1307, USA.


namespace GLib {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    public class Global
	{

		//this is a static class
		private Global () {}

		internal const string GLibNativeDll = DLL.GLib;
		internal const string GObjectNativeDll = DLL.GObject;

		internal static bool IsWindowsPlatform {
			get {
				switch (Environment.OSVersion.Platform) {
				case PlatformID.Win32NT:
				case PlatformID.Win32S:
				case PlatformID.Win32Windows:
				case PlatformID.WinCE:
					return true;
				default:
					return false;
				}
			}
		}

		public static string ProgramName {
			get {
				return GLib.Marshaller.Utf8PtrToString (g_get_prgname());
			}
			set { 
				IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (value);
				g_set_prgname (native_name);
				GLib.Marshaller.Free (native_name);
			}
		}

		[DllImport (Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_set_prgname (IntPtr name);

		[DllImport (Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_get_prgname ();

		public static string ApplicationName {
			get {
				return GLib.Marshaller.Utf8PtrToString (g_get_application_name());	
			}
			set {
				IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (value);
				g_set_application_name (native_name);
				GLib.Marshaller.Free (native_name);				
			}
		}

		[DllImport (Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_set_application_name (IntPtr name);

		[DllImport (Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_get_application_name ();

		[DllImport (Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_format_size_for_display (long size);
		
		static public string FormatSizeForDisplay (long size)
		{
			return Marshaller.PtrToStringGFree (g_format_size_for_display (size));
		}
	}
}
