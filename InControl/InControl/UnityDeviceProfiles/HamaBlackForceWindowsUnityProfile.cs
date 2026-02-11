using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001E9 RID: 489
	public class HamaBlackForceWindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x060010DA RID: 4314 RVA: 0x00042C94 File Offset: 0x00040E94
		// Note: this type is marked as 'beforefieldinit'.
		static HamaBlackForceWindowsUnityProfile()
		{
			Il2CppClassPointerStore<HamaBlackForceWindowsUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "HamaBlackForceWindowsUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HamaBlackForceWindowsUnityProfile>.NativeClassPtr);
			HamaBlackForceWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HamaBlackForceWindowsUnityProfile>.NativeClassPtr, 100665572);
			HamaBlackForceWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HamaBlackForceWindowsUnityProfile>.NativeClassPtr, 100665573);
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x00042CEC File Offset: 0x00040EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 843849, XrefRangeEnd = 844026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HamaBlackForceWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x00042D28 File Offset: 0x00040F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 844026, XrefRangeEnd = 844030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HamaBlackForceWindowsUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HamaBlackForceWindowsUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HamaBlackForceWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x00006E57 File Offset: 0x00005057
		public HamaBlackForceWindowsUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D20 RID: 3360
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D21 RID: 3361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
