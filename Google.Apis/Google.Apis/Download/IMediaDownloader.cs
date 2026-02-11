using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Download
{
	// Token: 0x0200001A RID: 26
	public class IMediaDownloader : Il2CppObjectBase
	{
		// Token: 0x06000195 RID: 405 RVA: 0x0000B264 File Offset: 0x00009464
		// Note: this type is marked as 'beforefieldinit'.
		static IMediaDownloader()
		{
			Il2CppClassPointerStore<IMediaDownloader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.dll", "Google.Apis.Download", "IMediaDownloader");
			IMediaDownloader.NativeMethodInfoPtr_add_ProgressChanged_Public_Abstract_Virtual_New_add_Void_Action_1_IDownloadProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMediaDownloader>.NativeClassPtr, 100663643);
			IMediaDownloader.NativeMethodInfoPtr_remove_ProgressChanged_Public_Abstract_Virtual_New_rem_Void_Action_1_IDownloadProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMediaDownloader>.NativeClassPtr, 100663644);
			IMediaDownloader.NativeMethodInfoPtr_get_ChunkSize_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMediaDownloader>.NativeClassPtr, 100663645);
			IMediaDownloader.NativeMethodInfoPtr_set_ChunkSize_Public_Abstract_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMediaDownloader>.NativeClassPtr, 100663646);
			IMediaDownloader.NativeMethodInfoPtr_Download_Public_Abstract_Virtual_New_IDownloadProgress_String_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMediaDownloader>.NativeClassPtr, 100663647);
			IMediaDownloader.NativeMethodInfoPtr_DownloadAsync_Public_Abstract_Virtual_New_Task_1_IDownloadProgress_String_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMediaDownloader>.NativeClassPtr, 100663648);
			IMediaDownloader.NativeMethodInfoPtr_DownloadAsync_Public_Abstract_Virtual_New_Task_1_IDownloadProgress_String_Stream_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMediaDownloader>.NativeClassPtr, 100663649);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000B318 File Offset: 0x00009518
		[CallerCount(0)]
		public unsafe virtual void add_ProgressChanged(Action<IDownloadProgress> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMediaDownloader.NativeMethodInfoPtr_add_ProgressChanged_Public_Abstract_Virtual_New_add_Void_Action_1_IDownloadProgress_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000B368 File Offset: 0x00009568
		[CallerCount(0)]
		public unsafe virtual void remove_ProgressChanged(Action<IDownloadProgress> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMediaDownloader.NativeMethodInfoPtr_remove_ProgressChanged_Public_Abstract_Virtual_New_rem_Void_Action_1_IDownloadProgress_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000198 RID: 408 RVA: 0x0000B3B8 File Offset: 0x000095B8
		// (set) Token: 0x06000199 RID: 409 RVA: 0x0000B400 File Offset: 0x00009600
		public unsafe virtual int ChunkSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMediaDownloader.NativeMethodInfoPtr_get_ChunkSize_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMediaDownloader.NativeMethodInfoPtr_set_ChunkSize_Public_Abstract_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000B44C File Offset: 0x0000964C
		[CallerCount(0)]
		public unsafe virtual IDownloadProgress Download(string url, Stream stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMediaDownloader.NativeMethodInfoPtr_Download_Public_Abstract_Virtual_New_IDownloadProgress_String_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDownloadProgress>(intPtr3) : null;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000B4BC File Offset: 0x000096BC
		[CallerCount(0)]
		public unsafe virtual Task<IDownloadProgress> DownloadAsync(string url, Stream stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMediaDownloader.NativeMethodInfoPtr_DownloadAsync_Public_Abstract_Virtual_New_Task_1_IDownloadProgress_String_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<IDownloadProgress>>(intPtr3) : null;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000B52C File Offset: 0x0000972C
		[CallerCount(0)]
		public unsafe virtual Task<IDownloadProgress> DownloadAsync(string url, Stream stream, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMediaDownloader.NativeMethodInfoPtr_DownloadAsync_Public_Abstract_Virtual_New_Task_1_IDownloadProgress_String_Stream_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<IDownloadProgress>>(intPtr3) : null;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000284F File Offset: 0x00000A4F
		public IMediaDownloader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_add_ProgressChanged_Public_Abstract_Virtual_New_add_Void_Action_1_IDownloadProgress_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_remove_ProgressChanged_Public_Abstract_Virtual_New_rem_Void_Action_1_IDownloadProgress_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_get_ChunkSize_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_set_ChunkSize_Public_Abstract_Virtual_New_set_Void_Int32_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_Download_Public_Abstract_Virtual_New_IDownloadProgress_String_Stream_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_DownloadAsync_Public_Abstract_Virtual_New_Task_1_IDownloadProgress_String_Stream_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_DownloadAsync_Public_Abstract_Virtual_New_Task_1_IDownloadProgress_String_Stream_CancellationToken_0;
	}
}
