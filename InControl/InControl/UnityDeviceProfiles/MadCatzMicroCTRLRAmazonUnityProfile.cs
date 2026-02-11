using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000160 RID: 352
	public class MadCatzMicroCTRLRAmazonUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000EB6 RID: 3766 RVA: 0x0003BD44 File Offset: 0x00039F44
		// Note: this type is marked as 'beforefieldinit'.
		static MadCatzMicroCTRLRAmazonUnityProfile()
		{
			Il2CppClassPointerStore<MadCatzMicroCTRLRAmazonUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "MadCatzMicroCTRLRAmazonUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MadCatzMicroCTRLRAmazonUnityProfile>.NativeClassPtr);
			MadCatzMicroCTRLRAmazonUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MadCatzMicroCTRLRAmazonUnityProfile>.NativeClassPtr, 100665298);
			MadCatzMicroCTRLRAmazonUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MadCatzMicroCTRLRAmazonUnityProfile>.NativeClassPtr, 100665299);
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x0003BD9C File Offset: 0x00039F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 817869, XrefRangeEnd = 818046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MadCatzMicroCTRLRAmazonUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x0003BDD8 File Offset: 0x00039FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 818046, XrefRangeEnd = 818050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MadCatzMicroCTRLRAmazonUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MadCatzMicroCTRLRAmazonUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MadCatzMicroCTRLRAmazonUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x00006986 File Offset: 0x00004B86
		public MadCatzMicroCTRLRAmazonUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C0E RID: 3086
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C0F RID: 3087
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
