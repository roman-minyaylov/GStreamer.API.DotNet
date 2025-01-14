﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib
{

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
    public partial class SocketListener : GLib.Object
    {

        public SocketListener(IntPtr raw) : base(raw) { }

        [DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr g_socket_listener_new();

        public SocketListener() : base(IntPtr.Zero)
        {
            if (GetType() != typeof(SocketListener))
            {
                CreateNativeObject(new string[0], new GLib.Value[0]);
                return;
            }
            Raw = g_socket_listener_new();
        }

        [GLib.Property("listen-backlog")]
        public int ListenBacklog
        {
            get
            {
                GLib.Value val = GetProperty("listen-backlog");
                int ret = (int)val;
                val.Dispose();
                return ret;
            }
            set
            {
                GLib.Value val = new GLib.Value(value);
                SetProperty("listen-backlog", val);
                val.Dispose();
            }
        }

        [GLib.Signal("event")]
        public event GLib.GEventHandler Event
        {
            add
            {
                this.AddSignalHandler("event", value, typeof(GLib.GEventArgs));
            }
            remove
            {
                this.RemoveSignalHandler("event", value);
            }
        }

        static ChangedNativeDelegate Changed_cb_delegate;
        static ChangedNativeDelegate ChangedVMCallback
        {
            get
            {
                if (Changed_cb_delegate == null)
                    Changed_cb_delegate = new ChangedNativeDelegate(Changed_cb);
                return Changed_cb_delegate;
            }
        }

        static void OverrideChanged(GLib.GType gtype)
        {
            OverrideChanged(gtype, ChangedVMCallback);
        }

        static void OverrideChanged(GLib.GType gtype, ChangedNativeDelegate callback)
        {
            unsafe
            {
                IntPtr* raw_ptr = (IntPtr*)(((long)gtype.GetClassPtr()) + (long)class_abi.GetFieldOffset("changed"));
                *raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate)callback);
            }
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        delegate void ChangedNativeDelegate(IntPtr inst);

        static void Changed_cb(IntPtr inst)
        {
            try
            {
                SocketListener __obj = GLib.Object.GetObject(inst, false) as SocketListener;
                __obj.OnChanged();
            }
            catch (Exception e)
            {
                GLib.ExceptionManager.RaiseUnhandledException(e, false);
            }
        }

        [GLib.DefaultSignalHandler(Type = typeof(GLib.SocketListener), ConnectionMethod = "OverrideChanged")]
        protected virtual void OnChanged()
        {
            InternalChanged();
        }

        private void InternalChanged()
        {
            ChangedNativeDelegate unmanaged = null;
            unsafe
            {
                IntPtr* raw_ptr = (IntPtr*)(((long)this.LookupGType().GetThresholdType().GetClassPtr()) + (long)class_abi.GetFieldOffset("changed"));
                unmanaged = (ChangedNativeDelegate)Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ChangedNativeDelegate));
            }
            if (unmanaged == null) return;

            unmanaged(this.Handle);
        }

        static EventNativeDelegate Event_cb_delegate;
        static EventNativeDelegate EventVMCallback
        {
            get
            {
                if (Event_cb_delegate == null)
                    Event_cb_delegate = new EventNativeDelegate(Event_cb);
                return Event_cb_delegate;
            }
        }

        static void OverrideEvent(GLib.GType gtype)
        {
            OverrideEvent(gtype, EventVMCallback);
        }

        static void OverrideEvent(GLib.GType gtype, EventNativeDelegate callback)
        {
            unsafe
            {
                IntPtr* raw_ptr = (IntPtr*)(((long)gtype.GetClassPtr()) + (long)class_abi.GetFieldOffset("event"));
                *raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate)callback);
            }
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        delegate void EventNativeDelegate(IntPtr inst, out int evnt, IntPtr socket);

        static void Event_cb(IntPtr inst, out int evnt, IntPtr socket)
        {
            try
            {
                SocketListener __obj = GLib.Object.GetObject(inst, false) as SocketListener;
                GLib.SocketListenerEvent myevnt;
                __obj.OnEvent(out myevnt, socket == IntPtr.Zero ? null : (GLib.Socket)GLib.Opaque.GetOpaque(socket, typeof(GLib.Socket), false));
                evnt = (int)myevnt;
            }
            catch (Exception e)
            {
                GLib.ExceptionManager.RaiseUnhandledException(e, true);
                // NOTREACHED: above call does not return.
                throw e;
            }
        }

        [GLib.DefaultSignalHandler(Type = typeof(GLib.SocketListener), ConnectionMethod = "OverrideEvent")]
        protected virtual void OnEvent(out GLib.SocketListenerEvent evnt, GLib.Socket socket)
        {
            InternalEvent(out evnt, socket);
        }

        private void InternalEvent(out GLib.SocketListenerEvent evnt, GLib.Socket socket)
        {
            EventNativeDelegate unmanaged = null;
            unsafe
            {
                IntPtr* raw_ptr = (IntPtr*)(((long)this.LookupGType().GetThresholdType().GetClassPtr()) + (long)class_abi.GetFieldOffset("event"));
                unmanaged = (EventNativeDelegate)Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(EventNativeDelegate));
            }
            if (unmanaged == null) throw new InvalidOperationException("No base method to invoke");

            int native_evnt;
            unmanaged(this.Handle, out native_evnt, socket == null ? IntPtr.Zero : socket.Handle);
            evnt = (GLib.SocketListenerEvent)native_evnt;
        }


        // Internal representation of the wrapped structure ABI.
        static GLib.AbiStruct _class_abi = null;
        static public new GLib.AbiStruct class_abi
        {
            get
            {
                if (_class_abi == null)
                    _class_abi = new GLib.AbiStruct(new List<GLib.AbiField>{
                        new GLib.AbiField("changed"
                            , GLib.Object.class_abi.Fields
                            , (uint) Marshal.SizeOf(typeof(IntPtr)) // changed
							, null
                            , "event"
                            , (uint) Marshal.SizeOf(typeof(IntPtr))
                            , 0
                            ),
                        new GLib.AbiField("event"
                            , -1
                            , (uint) Marshal.SizeOf(typeof(IntPtr)) // event
							, "changed"
                            , "_g_reserved2"
                            , (uint) Marshal.SizeOf(typeof(IntPtr))
                            , 0
                            ),
                        new GLib.AbiField("_g_reserved2"
                            , -1
                            , (uint) Marshal.SizeOf(typeof(IntPtr)) // _g_reserved2
							, "event"
                            , "_g_reserved3"
                            , (uint) Marshal.SizeOf(typeof(IntPtr))
                            , 0
                            ),
                        new GLib.AbiField("_g_reserved3"
                            , -1
                            , (uint) Marshal.SizeOf(typeof(IntPtr)) // _g_reserved3
							, "_g_reserved2"
                            , "_g_reserved4"
                            , (uint) Marshal.SizeOf(typeof(IntPtr))
                            , 0
                            ),
                        new GLib.AbiField("_g_reserved4"
                            , -1
                            , (uint) Marshal.SizeOf(typeof(IntPtr)) // _g_reserved4
							, "_g_reserved3"
                            , "_g_reserved5"
                            , (uint) Marshal.SizeOf(typeof(IntPtr))
                            , 0
                            ),
                        new GLib.AbiField("_g_reserved5"
                            , -1
                            , (uint) Marshal.SizeOf(typeof(IntPtr)) // _g_reserved5
							, "_g_reserved4"
                            , "_g_reserved6"
                            , (uint) Marshal.SizeOf(typeof(IntPtr))
                            , 0
                            ),
                        new GLib.AbiField("_g_reserved6"
                            , -1
                            , (uint) Marshal.SizeOf(typeof(IntPtr)) // _g_reserved6
							, "_g_reserved5"
                            , null
                            , (uint) Marshal.SizeOf(typeof(IntPtr))
                            , 0
                            ),
                    });

                return _class_abi;
            }
        }


        // End of the ABI representation.

        [DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
        static extern unsafe IntPtr g_socket_listener_accept(IntPtr raw, IntPtr source_object, IntPtr cancellable, out IntPtr error);

        public unsafe GLib.SocketConnection Accept(GLib.Object source_object, GLib.Cancellable cancellable)
        {
            IntPtr error = IntPtr.Zero;
            IntPtr raw_ret = g_socket_listener_accept(Handle, source_object == null ? IntPtr.Zero : source_object.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
            GLib.SocketConnection ret = GLib.Object.GetObject(raw_ret) as GLib.SocketConnection;
            if (error != IntPtr.Zero) throw new GLib.GException(error);
            return ret;
        }

        [DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
        static extern void g_socket_listener_accept_async(IntPtr raw, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

        public void AcceptAsync(GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb)
        {
            GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper(cb);
            cb_wrapper.PersistUntilCalled();
            g_socket_listener_accept_async(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
        }

        [DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
        static extern unsafe IntPtr g_socket_listener_accept_finish(IntPtr raw, IntPtr result, IntPtr source_object, out IntPtr error);

        public unsafe GLib.SocketConnection AcceptFinish(GLib.IAsyncResult result, GLib.Object source_object)
        {
            IntPtr error = IntPtr.Zero;
            IntPtr raw_ret = g_socket_listener_accept_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), source_object == null ? IntPtr.Zero : source_object.Handle, out error);
            GLib.SocketConnection ret = GLib.Object.GetObject(raw_ret) as GLib.SocketConnection;
            if (error != IntPtr.Zero) throw new GLib.GException(error);
            return ret;
        }

        [DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
        static extern unsafe IntPtr g_socket_listener_accept_socket(IntPtr raw, IntPtr source_object, IntPtr cancellable, out IntPtr error);

        public unsafe GLib.Socket AcceptSocket(GLib.Object source_object, GLib.Cancellable cancellable)
        {
            IntPtr error = IntPtr.Zero;
            IntPtr raw_ret = g_socket_listener_accept_socket(Handle, source_object == null ? IntPtr.Zero : source_object.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
            GLib.Socket ret = raw_ret == IntPtr.Zero ? null : (GLib.Socket)GLib.Opaque.GetOpaque(raw_ret, typeof(GLib.Socket), false);
            if (error != IntPtr.Zero) throw new GLib.GException(error);
            return ret;
        }

        [DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
        static extern void g_socket_listener_accept_socket_async(IntPtr raw, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

        public void AcceptSocketAsync(GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb)
        {
            GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper(cb);
            cb_wrapper.PersistUntilCalled();
            g_socket_listener_accept_socket_async(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
        }

        [DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
        static extern unsafe IntPtr g_socket_listener_accept_socket_finish(IntPtr raw, IntPtr result, IntPtr source_object, out IntPtr error);

        public unsafe GLib.Socket AcceptSocketFinish(GLib.IAsyncResult result, GLib.Object source_object)
        {
            IntPtr error = IntPtr.Zero;
            IntPtr raw_ret = g_socket_listener_accept_socket_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), source_object == null ? IntPtr.Zero : source_object.Handle, out error);
            GLib.Socket ret = raw_ret == IntPtr.Zero ? null : (GLib.Socket)GLib.Opaque.GetOpaque(raw_ret, typeof(GLib.Socket), false);
            if (error != IntPtr.Zero) throw new GLib.GException(error);
            return ret;
        }

        [DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
        static extern unsafe bool g_socket_listener_add_address(IntPtr raw, IntPtr address, int type, int protocol, IntPtr source_object, IntPtr effective_address, out IntPtr error);

        public unsafe bool AddAddress(GLib.SocketAddress address, GLib.SocketType type, GLib.SocketProtocol protocol, GLib.Object source_object, GLib.SocketAddress effective_address)
        {
            IntPtr error = IntPtr.Zero;
            bool raw_ret = g_socket_listener_add_address(Handle, address == null ? IntPtr.Zero : address.Handle, (int)type, (int)protocol, source_object == null ? IntPtr.Zero : source_object.Handle, effective_address == null ? IntPtr.Zero : effective_address.Handle, out error);
            bool ret = raw_ret;
            if (error != IntPtr.Zero) throw new GLib.GException(error);
            return ret;
        }

        [DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
        static extern unsafe ushort g_socket_listener_add_any_inet_port(IntPtr raw, IntPtr source_object, out IntPtr error);

        public unsafe ushort AddAnyInetPort(GLib.Object source_object)
        {
            IntPtr error = IntPtr.Zero;
            ushort raw_ret = g_socket_listener_add_any_inet_port(Handle, source_object == null ? IntPtr.Zero : source_object.Handle, out error);
            ushort ret = raw_ret;
            if (error != IntPtr.Zero) throw new GLib.GException(error);
            return ret;
        }

        [DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
        static extern unsafe bool g_socket_listener_add_inet_port(IntPtr raw, ushort port, IntPtr source_object, out IntPtr error);

        public unsafe bool AddInetPort(ushort port, GLib.Object source_object)
        {
            IntPtr error = IntPtr.Zero;
            bool raw_ret = g_socket_listener_add_inet_port(Handle, port, source_object == null ? IntPtr.Zero : source_object.Handle, out error);
            bool ret = raw_ret;
            if (error != IntPtr.Zero) throw new GLib.GException(error);
            return ret;
        }

        [DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
        static extern unsafe bool g_socket_listener_add_socket(IntPtr raw, IntPtr socket, IntPtr source_object, out IntPtr error);

        public unsafe bool AddSocket(GLib.Socket socket, GLib.Object source_object)
        {
            IntPtr error = IntPtr.Zero;
            bool raw_ret = g_socket_listener_add_socket(Handle, socket == null ? IntPtr.Zero : socket.Handle, source_object == null ? IntPtr.Zero : source_object.Handle, out error);
            bool ret = raw_ret;
            if (error != IntPtr.Zero) throw new GLib.GException(error);
            return ret;
        }

        [DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
        static extern void g_socket_listener_close(IntPtr raw);

        public void Close()
        {
            g_socket_listener_close(Handle);
        }

        [DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr g_socket_listener_get_type();

        public static new GLib.GType GType
        {
            get
            {
                IntPtr raw_ret = g_socket_listener_get_type();
                GLib.GType ret = new GLib.GType(raw_ret);
                return ret;
            }
        }

        [DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
        static extern void g_socket_listener_set_backlog(IntPtr raw, int listen_backlog);

        public int Backlog
        {
            set
            {
                g_socket_listener_set_backlog(Handle, value);
            }
        }


        // Internal representation of the wrapped structure ABI.
        static GLib.AbiStruct _abi_info = null;
        static public new GLib.AbiStruct abi_info
        {
            get
            {
                if (_abi_info == null)
                    _abi_info = new GLib.AbiStruct(new List<GLib.AbiField>{
                        new GLib.AbiField("priv"
                            , GLib.Object.abi_info.Fields
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
