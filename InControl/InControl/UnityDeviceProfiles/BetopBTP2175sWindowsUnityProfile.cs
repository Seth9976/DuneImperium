using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001E0 RID: 480
	public class BetopBTP2175sWindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x060010B6 RID: 4278 RVA: 0x00042544 File Offset: 0x00040744
		// Note: this type is marked as 'beforefieldinit'.
		static BetopBTP2175sWindowsUnityProfile()
		{
			Il2CppClassPointerStore<BetopBTP2175sWindowsUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "BetopBTP2175sWindowsUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BetopBTP2175sWindowsUnityProfile>.NativeClassPtr);
			BetopBTP2175sWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetopBTP2175sWindowsUnityProfile>.NativeClassPtr, 100665554);
			BetopBTP2175sWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetopBTP2175sWindowsUnityProfile>.NativeClassPtr, 100665555);
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x0004259C File Offset: 0x0004079C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 842083, XrefRangeEnd = 842276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BetopBTP2175sWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x000425D8 File Offset: 0x000407D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 842276, XrefRangeEnd = 842280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BetopBTP2175sWindowsUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BetopBTP2175sWindowsUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BetopBTP2175sWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x00006E06 File Offset: 0x00005006
		public BetopBTP2175sWindowsUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D0E RID: 3342
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D0F RID: 3343
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
