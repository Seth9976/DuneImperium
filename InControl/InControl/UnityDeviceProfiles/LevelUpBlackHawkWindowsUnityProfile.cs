using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001EA RID: 490
	public class LevelUpBlackHawkWindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x060010DE RID: 4318 RVA: 0x00042D64 File Offset: 0x00040F64
		// Note: this type is marked as 'beforefieldinit'.
		static LevelUpBlackHawkWindowsUnityProfile()
		{
			Il2CppClassPointerStore<LevelUpBlackHawkWindowsUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "LevelUpBlackHawkWindowsUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LevelUpBlackHawkWindowsUnityProfile>.NativeClassPtr);
			LevelUpBlackHawkWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelUpBlackHawkWindowsUnityProfile>.NativeClassPtr, 100665574);
			LevelUpBlackHawkWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelUpBlackHawkWindowsUnityProfile>.NativeClassPtr, 100665575);
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x00042DBC File Offset: 0x00040FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 844030, XrefRangeEnd = 844189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelUpBlackHawkWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x00042DF8 File Offset: 0x00040FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 844189, XrefRangeEnd = 844193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LevelUpBlackHawkWindowsUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LevelUpBlackHawkWindowsUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelUpBlackHawkWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x00006E60 File Offset: 0x00005060
		public LevelUpBlackHawkWindowsUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D22 RID: 3362
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D23 RID: 3363
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
