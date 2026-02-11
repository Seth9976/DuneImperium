using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000200 RID: 512
	public class SpeedlinkStrikeWindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x06001136 RID: 4406 RVA: 0x00043F44 File Offset: 0x00042144
		// Note: this type is marked as 'beforefieldinit'.
		static SpeedlinkStrikeWindowsUnityProfile()
		{
			Il2CppClassPointerStore<SpeedlinkStrikeWindowsUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "SpeedlinkStrikeWindowsUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpeedlinkStrikeWindowsUnityProfile>.NativeClassPtr);
			SpeedlinkStrikeWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedlinkStrikeWindowsUnityProfile>.NativeClassPtr, 100665618);
			SpeedlinkStrikeWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedlinkStrikeWindowsUnityProfile>.NativeClassPtr, 100665619);
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x00043F9C File Offset: 0x0004219C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 848268, XrefRangeEnd = 848445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpeedlinkStrikeWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x00043FD8 File Offset: 0x000421D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 848445, XrefRangeEnd = 848449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpeedlinkStrikeWindowsUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpeedlinkStrikeWindowsUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedlinkStrikeWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x00006F26 File Offset: 0x00005126
		public SpeedlinkStrikeWindowsUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D4E RID: 3406
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D4F RID: 3407
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
