using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Upload
{
	// Token: 0x02000007 RID: 7
	public class IUploadSessionData : Il2CppObjectBase
	{
		// Token: 0x06000020 RID: 32 RVA: 0x000020C0 File Offset: 0x000002C0
		// Note: this type is marked as 'beforefieldinit'.
		static IUploadSessionData()
		{
			Il2CppClassPointerStore<IUploadSessionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.dll", "Google.Apis.Upload", "IUploadSessionData");
			IUploadSessionData.NativeMethodInfoPtr_get_UploadUri_Public_Abstract_Virtual_New_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUploadSessionData>.NativeClassPtr, 100663316);
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00005274 File Offset: 0x00003474
		public unsafe virtual Uri UploadUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUploadSessionData.NativeMethodInfoPtr_get_UploadUri_Public_Abstract_Virtual_New_get_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000020EF File Offset: 0x000002EF
		public IUploadSessionData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_get_UploadUri_Public_Abstract_Virtual_New_get_Uri_0;
	}
}
