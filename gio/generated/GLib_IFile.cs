// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;

#region Autogenerated code
	public partial interface IFile : GLib.IWrapper {

		GLib.FileOutputStream AppendTo(GLib.FileCreateFlags flags, GLib.Cancellable cancellable);
		void AppendToAsync(GLib.FileCreateFlags flags, int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		GLib.FileOutputStream AppendToFinish(GLib.IAsyncResult res);
		bool Copy(GLib.IFile destination, GLib.FileCopyFlags flags, GLib.Cancellable cancellable, GLib.FileProgressCallback progress_callback);
		void CopyAsync(GLib.IFile destination, GLib.FileCopyFlags flags, int io_priority, GLib.Cancellable cancellable, GLib.FileProgressCallback progress_callback, GLib.AsyncReadyCallback cb);
		bool CopyAttributes(GLib.IFile destination, GLib.FileCopyFlags flags, GLib.Cancellable cancellable);
		bool CopyFinish(GLib.IAsyncResult res);
		GLib.FileOutputStream Create(GLib.FileCreateFlags flags, GLib.Cancellable cancellable);
		void CreateAsync(GLib.FileCreateFlags flags, int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		GLib.FileOutputStream CreateFinish(GLib.IAsyncResult res);
		GLib.FileIOStream CreateReadwrite(GLib.FileCreateFlags flags, GLib.Cancellable cancellable);
		void CreateReadwriteAsync(GLib.FileCreateFlags flags, int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		GLib.FileIOStream CreateReadwriteFinish(GLib.IAsyncResult res);
		bool Delete(GLib.Cancellable cancellable);
		void DeleteAsync(int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		bool DeleteFinish(GLib.IAsyncResult result);
		GLib.IFile Dup();
		void EjectMountableWithOperation(GLib.MountUnmountFlags flags, GLib.MountOperation mount_operation, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		bool EjectMountableWithOperationFinish(GLib.IAsyncResult result);
		GLib.FileEnumerator EnumerateChildren(string attributes, GLib.FileQueryInfoFlags flags, GLib.Cancellable cancellable);
		void EnumerateChildrenAsync(string attributes, GLib.FileQueryInfoFlags flags, int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		GLib.FileEnumerator EnumerateChildrenFinish(GLib.IAsyncResult res);
		bool Equal(GLib.IFile file2);
		GLib.IMount FindEnclosingMount(GLib.Cancellable cancellable);
		void FindEnclosingMountAsync(int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		GLib.IMount FindEnclosingMountFinish(GLib.IAsyncResult res);
		string Basename { 
			get;
		}
		GLib.IFile GetChild(string name);
		GLib.IFile GetChildForDisplayName(string display_name);
		GLib.IFile Parent { 
			get;
		}
		string ParsedName { 
			get;
		}
		string Path { 
			get;
		}
		string GetRelativePath(GLib.IFile descendant);
		string UriScheme { 
			get;
		}
		bool HasParent(GLib.IFile parent);
		bool HasPrefix(GLib.IFile prefix);
		bool HasUriScheme(string uri_scheme);
		bool IsNative { 
			get;
		}
		bool LoadContents(GLib.Cancellable cancellable, string contents, out ulong length, string etag_out);
		void LoadContentsAsync(GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		bool LoadContentsFinish(GLib.IAsyncResult res, string contents, out ulong length, string etag_out);
		void LoadPartialContentsAsync(GLib.Cancellable cancellable, GLib.FileReadMoreCallback read_more_callback, GLib.AsyncReadyCallback cb);
		bool LoadPartialContentsFinish(GLib.IAsyncResult res, string contents, out ulong length, string etag_out);
		bool MakeDirectory(GLib.Cancellable cancellable);
		void MakeDirectoryAsync(int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		bool MakeDirectoryFinish(GLib.IAsyncResult result);
		bool MakeDirectoryWithParents(GLib.Cancellable cancellable);
		bool MakeSymbolicLink(string symlink_value, GLib.Cancellable cancellable);
		bool MeasureDiskUsage(GLib.FileMeasureFlags flags, GLib.Cancellable cancellable, GLib.FileMeasureProgressCallback progress_callback, out ulong disk_usage, out ulong num_dirs, out ulong num_files);
		void MeasureDiskUsageAsync(GLib.FileMeasureFlags flags, int io_priority, GLib.Cancellable cancellable, GLib.FileMeasureProgressCallback progress_callback, GLib.AsyncReadyCallback cb);
		bool MeasureDiskUsageFinish(GLib.IAsyncResult result, out ulong disk_usage, out ulong num_dirs, out ulong num_files);
		GLib.FileMonitor Monitor(GLib.FileMonitorFlags flags, GLib.Cancellable cancellable);
		void MountEnclosingVolume(GLib.MountMountFlags flags, GLib.MountOperation mount_operation, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		bool MountEnclosingVolumeFinish(GLib.IAsyncResult result);
		void MountMountable(GLib.MountMountFlags flags, GLib.MountOperation mount_operation, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		GLib.IFile MountMountableFinish(GLib.IAsyncResult result);
		bool Move(GLib.IFile destination, GLib.FileCopyFlags flags, GLib.Cancellable cancellable, GLib.FileProgressCallback progress_callback);
		GLib.FileIOStream OpenReadwrite(GLib.Cancellable cancellable);
		void OpenReadwriteAsync(int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		GLib.FileIOStream OpenReadwriteFinish(GLib.IAsyncResult res);
		void PollMountable(GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		bool PollMountableFinish(GLib.IAsyncResult result);
		GLib.IAppInfo QueryDefaultHandler(GLib.Cancellable cancellable);
		bool QueryExists(GLib.Cancellable cancellable);
		GLib.FileType QueryFileType(GLib.FileQueryInfoFlags flags, GLib.Cancellable cancellable);
		GLib.FileInfo QueryFilesystemInfo(string attributes, GLib.Cancellable cancellable);
		void QueryFilesystemInfoAsync(string attributes, int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		GLib.FileInfo QueryFilesystemInfoFinish(GLib.IAsyncResult res);
		GLib.FileInfo QueryInfo(string attributes, GLib.FileQueryInfoFlags flags, GLib.Cancellable cancellable);
		void QueryInfoAsync(string attributes, GLib.FileQueryInfoFlags flags, int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		GLib.FileInfo QueryInfoFinish(GLib.IAsyncResult res);
		GLib.FileAttributeInfoList QuerySettableAttributes(GLib.Cancellable cancellable);
		GLib.FileAttributeInfoList QueryWritableNamespaces(GLib.Cancellable cancellable);
		GLib.FileInputStream Read(GLib.Cancellable cancellable);
		void ReadAsync(int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		GLib.FileInputStream ReadFinish(GLib.IAsyncResult res);
		GLib.FileOutputStream Replace(string etag, bool make_backup, GLib.FileCreateFlags flags, GLib.Cancellable cancellable);
		void ReplaceAsync(string etag, bool make_backup, GLib.FileCreateFlags flags, int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		bool ReplaceContents(string contents, string etag, bool make_backup, GLib.FileCreateFlags flags, string new_etag, GLib.Cancellable cancellable);
		void ReplaceContentsAsync(string contents, string etag, bool make_backup, GLib.FileCreateFlags flags, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		void ReplaceContentsBytesAsync(GLib.Bytes contents, string etag, bool make_backup, GLib.FileCreateFlags flags, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		bool ReplaceContentsFinish(GLib.IAsyncResult res, string new_etag);
		GLib.FileOutputStream ReplaceFinish(GLib.IAsyncResult res);
		GLib.FileIOStream ReplaceReadwrite(string etag, bool make_backup, GLib.FileCreateFlags flags, GLib.Cancellable cancellable);
		void ReplaceReadwriteAsync(string etag, bool make_backup, GLib.FileCreateFlags flags, int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		GLib.FileIOStream ReplaceReadwriteFinish(GLib.IAsyncResult res);
		GLib.IFile ResolveRelativePath(string relative_path);
		bool SetAttribute(string attribute, GLib.FileAttributeType type, IntPtr value_p, GLib.FileQueryInfoFlags flags, GLib.Cancellable cancellable);
		bool SetAttributeByteString(string attribute, string value, GLib.FileQueryInfoFlags flags, GLib.Cancellable cancellable);
		bool SetAttributeInt32(string attribute, int value, GLib.FileQueryInfoFlags flags, GLib.Cancellable cancellable);
		bool SetAttributeInt64(string attribute, long value, GLib.FileQueryInfoFlags flags, GLib.Cancellable cancellable);
		bool SetAttributeString(string attribute, string value, GLib.FileQueryInfoFlags flags, GLib.Cancellable cancellable);
		bool SetAttributeUint32(string attribute, uint value, GLib.FileQueryInfoFlags flags, GLib.Cancellable cancellable);
		bool SetAttributeUint64(string attribute, ulong value, GLib.FileQueryInfoFlags flags, GLib.Cancellable cancellable);
		void SetAttributesAsync(GLib.FileInfo info, GLib.FileQueryInfoFlags flags, int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		bool SetAttributesFinish(GLib.IAsyncResult result, GLib.FileInfo info);
		bool SetAttributesFromInfo(GLib.FileInfo info, GLib.FileQueryInfoFlags flags, GLib.Cancellable cancellable);
		GLib.IFile SetDisplayName(string display_name, GLib.Cancellable cancellable);
		void SetDisplayNameAsync(string display_name, int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		GLib.IFile SetDisplayNameFinish(GLib.IAsyncResult res);
		void StartMountable(GLib.DriveStartFlags flags, GLib.MountOperation start_operation, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		bool StartMountableFinish(GLib.IAsyncResult result);
		void StopMountable(GLib.MountUnmountFlags flags, GLib.MountOperation mount_operation, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		bool StopMountableFinish(GLib.IAsyncResult result);
		bool SupportsThreadContexts();
		bool Trash(GLib.Cancellable cancellable);
		void TrashAsync(int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		bool TrashFinish(GLib.IAsyncResult result);
		void UnmountMountableWithOperation(GLib.MountUnmountFlags flags, GLib.MountOperation mount_operation, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		bool UnmountMountableWithOperationFinish(GLib.IAsyncResult result);
	}
#endregion
}
