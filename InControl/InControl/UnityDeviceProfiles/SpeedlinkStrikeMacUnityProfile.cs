using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001BF RID: 447
	public class SpeedlinkStrikeMacUnityProfile : InputDeviceProfile
	{
		// Token: 0x06001032 RID: 4146 RVA: 0x00040A74 File Offset: 0x0003EC74
		// Note: this type is marked as 'beforefieldinit'.
		static SpeedlinkStrikeMacUnityProfile()
		{
			Il2CppClassPointerStore<SpeedlinkStrikeMacUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "SpeedlinkStrikeMacUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpeedlinkStrikeMacUnityProfile>.NativeClassPtr);
			SpeedlinkStrikeMacUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedlinkStrikeMacUnityProfile>.NativeClassPtr, 100665488);
			SpeedlinkStrikeMacUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedlinkStrikeMacUnityProfile>.NativeClassPtr, 100665489);
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x00040ACC File Offset: 0x0003ECCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 834706, XrefRangeEnd = 834883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpeedlinkStrikeMacUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x00040B08 File Offset: 0x0003ED08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 834883, XrefRangeEnd = 834887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpeedlinkStrikeMacUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpeedlinkStrikeMacUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedlinkStrikeMacUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x00006CDD File Offset: 0x00004EDD
		public SpeedlinkStrikeMacUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CCC RID: 3276
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CCD RID: 3277
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
