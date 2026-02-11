using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Upload
{
	// Token: 0x02000006 RID: 6
	public class IUploadProgress : Il2CppObjectBase
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00005134 File Offset: 0x00003334
		// Note: this type is marked as 'beforefieldinit'.
		static IUploadProgress()
		{
			Il2CppClassPointerStore<IUploadProgress>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.dll", "Google.Apis.Upload", "IUploadProgress");
			IUploadProgress.NativeMethodInfoPtr_get_Status_Public_Abstract_Virtual_New_get_UploadStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUploadProgress>.NativeClassPtr, 100663313);
			IUploadProgress.NativeMethodInfoPtr_get_BytesSent_Public_Abstract_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUploadProgress>.NativeClassPtr, 100663314);
			IUploadProgress.NativeMethodInfoPtr_get_Exception_Public_Abstract_Virtual_New_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUploadProgress>.NativeClassPtr, 100663315);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00005198 File Offset: 0x00003398
		public unsafe virtual UploadStatus Status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUploadProgress.NativeMethodInfoPtr_get_Status_Public_Abstract_Virtual_New_get_UploadStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000051E0 File Offset: 0x000033E0
		public unsafe virtual long BytesSent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUploadProgress.NativeMethodInfoPtr_get_BytesSent_Public_Abstract_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00005228 File Offset: 0x00003428
		public unsafe virtual Exception Exception
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUploadProgress.NativeMethodInfoPtr_get_Exception_Public_Abstract_Virtual_New_get_Exception_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000020B7 File Offset: 0x000002B7
		public IUploadProgress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_Abstract_Virtual_New_get_UploadStatus_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_get_BytesSent_Public_Abstract_Virtual_New_get_Int64_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_get_Exception_Public_Abstract_Virtual_New_get_Exception_0;
	}
}
