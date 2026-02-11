using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001DC RID: 476
	public class PlayStation4WindowsFirefoxUnityProfile : InputDeviceProfile
	{
		// Token: 0x060010A6 RID: 4262 RVA: 0x00042204 File Offset: 0x00040404
		// Note: this type is marked as 'beforefieldinit'.
		static PlayStation4WindowsFirefoxUnityProfile()
		{
			Il2CppClassPointerStore<PlayStation4WindowsFirefoxUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "PlayStation4WindowsFirefoxUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayStation4WindowsFirefoxUnityProfile>.NativeClassPtr);
			PlayStation4WindowsFirefoxUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayStation4WindowsFirefoxUnityProfile>.NativeClassPtr, 100665546);
			PlayStation4WindowsFirefoxUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayStation4WindowsFirefoxUnityProfile>.NativeClassPtr, 100665547);
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0004225C File Offset: 0x0004045C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 841014, XrefRangeEnd = 841306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayStation4WindowsFirefoxUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x00042298 File Offset: 0x00040498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 841306, XrefRangeEnd = 841310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayStation4WindowsFirefoxUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayStation4WindowsFirefoxUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayStation4WindowsFirefoxUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x00006DE2 File Offset: 0x00004FE2
		public PlayStation4WindowsFirefoxUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D06 RID: 3334
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D07 RID: 3335
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
