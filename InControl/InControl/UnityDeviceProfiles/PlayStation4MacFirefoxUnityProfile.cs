using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001D3 RID: 467
	public class PlayStation4MacFirefoxUnityProfile : InputDeviceProfile
	{
		// Token: 0x06001082 RID: 4226 RVA: 0x00041AB4 File Offset: 0x0003FCB4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayStation4MacFirefoxUnityProfile()
		{
			Il2CppClassPointerStore<PlayStation4MacFirefoxUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "PlayStation4MacFirefoxUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayStation4MacFirefoxUnityProfile>.NativeClassPtr);
			PlayStation4MacFirefoxUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayStation4MacFirefoxUnityProfile>.NativeClassPtr, 100665528);
			PlayStation4MacFirefoxUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayStation4MacFirefoxUnityProfile>.NativeClassPtr, 100665529);
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x00041B0C File Offset: 0x0003FD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 838467, XrefRangeEnd = 838745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayStation4MacFirefoxUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x00041B48 File Offset: 0x0003FD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 838745, XrefRangeEnd = 838749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayStation4MacFirefoxUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayStation4MacFirefoxUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayStation4MacFirefoxUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00006D91 File Offset: 0x00004F91
		public PlayStation4MacFirefoxUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CF4 RID: 3316
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CF5 RID: 3317
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
