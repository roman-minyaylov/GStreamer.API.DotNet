// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES 
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

	using GStreamer;

	#region Autogenerated code
	public partial class VideoTestSource : GES.VideoSource {

		public VideoTestSource (IntPtr raw) : base(raw) {}

		protected VideoTestSource() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_ges_reserved"
							, GES.VideoSource.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _ges_reserved
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport(DLL.GES, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_video_test_source_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = ges_video_test_source_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.GES, CallingConvention = CallingConvention.Cdecl)]
		static extern int ges_video_test_source_get_pattern(IntPtr raw);

		[DllImport(DLL.GES, CallingConvention = CallingConvention.Cdecl)]
		static extern void ges_video_test_source_set_pattern(IntPtr raw, int pattern);

		public GES.VideoTestPattern Pattern { 
			get {
				int raw_ret = ges_video_test_source_get_pattern(Handle);
				GES.VideoTestPattern ret = (GES.VideoTestPattern) raw_ret;
				return ret;
			}
			set {
				ges_video_test_source_set_pattern(Handle, (int) value);
			}
		}


		static VideoTestSource ()
		{
			GtkSharp.GstEditingServices.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GES.VideoSource.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, "_ges_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_ges_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _ges_reserved
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
