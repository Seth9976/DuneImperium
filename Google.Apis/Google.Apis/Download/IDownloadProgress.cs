using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Download
{
	// Token: 0x02000019 RID: 25
	public class IDownloadProgress : Il2CppObjectBase
	{
		// Token: 0x06000190 RID: 400 RVA: 0x0000B124 File Offset: 0x00009324
		// Note: this type is marked as 'beforefieldinit'.
		static IDownloadProgress()
		{
			Il2CppClassPointerStore<IDownloadProgress>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.dll", "Google.Apis.Download", "IDownloadProgress");
			IDownloadProgress.NativeMethodInfoPtr_get_Status_Public_Abstract_Virtual_New_get_DownloadStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDownloadProgress>.NativeClassPtr, 100663640);
			IDownloadProgress.NativeMethodInfoPtr_get_BytesDownloaded_Public_Abstract_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDownloadProgress>.NativeClassPtr, 100663641);
			IDownloadProgress.NativeMethodInfoPtr_get_Exception_Public_Abstract_Virtual_New_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDownloadProgress>.NativeClassPtr, 100663642);
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000191 RID: 401 RVA: 0x0000B188 File Offset: 0x00009388
		public unsafe virtual DownloadStatus Status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDownloadProgress.NativeMethodInfoPtr_get_Status_Public_Abstract_Virtual_New_get_DownloadStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000192 RID: 402 RVA: 0x0000B1D0 File Offset: 0x000093D0
		public unsafe virtual long BytesDownloaded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDownloadProgress.NativeMethodInfoPtr_get_BytesDownloaded_Public_Abstract_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000193 RID: 403 RVA: 0x0000B218 File Offset: 0x00009418
		public unsafe virtual Exception Exception
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDownloadProgress.NativeMethodInfoPtr_get_Exception_Public_Abstract_Virtual_New_get_Exception_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002846 File Offset: 0x00000A46
		public IDownloadProgress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_Abstract_Virtual_New_get_DownloadStatus_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_get_BytesDownloaded_Public_Abstract_Virtual_New_get_Int64_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_get_Exception_Public_Abstract_Virtual_New_get_Exception_0;
	}
}
