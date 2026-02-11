using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001D2 RID: 466
	public class PlayStation4MacChromeUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600107E RID: 4222 RVA: 0x000419E4 File Offset: 0x0003FBE4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayStation4MacChromeUnityProfile()
		{
			Il2CppClassPointerStore<PlayStation4MacChromeUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "PlayStation4MacChromeUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayStation4MacChromeUnityProfile>.NativeClassPtr);
			PlayStation4MacChromeUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayStation4MacChromeUnityProfile>.NativeClassPtr, 100665526);
			PlayStation4MacChromeUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayStation4MacChromeUnityProfile>.NativeClassPtr, 100665527);
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x00041A3C File Offset: 0x0003FC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 838171, XrefRangeEnd = 838463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayStation4MacChromeUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x00041A78 File Offset: 0x0003FC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 838463, XrefRangeEnd = 838467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayStation4MacChromeUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayStation4MacChromeUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayStation4MacChromeUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x00006D88 File Offset: 0x00004F88
		public PlayStation4MacChromeUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CF2 RID: 3314
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CF3 RID: 3315
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
