using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001A1 RID: 417
	public class HavitHVG95WLinuxProfile : InputDeviceProfile
	{
		// Token: 0x06000FBA RID: 4026 RVA: 0x0003F214 File Offset: 0x0003D414
		// Note: this type is marked as 'beforefieldinit'.
		static HavitHVG95WLinuxProfile()
		{
			Il2CppClassPointerStore<HavitHVG95WLinuxProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "HavitHVG95WLinuxProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HavitHVG95WLinuxProfile>.NativeClassPtr);
			HavitHVG95WLinuxProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HavitHVG95WLinuxProfile>.NativeClassPtr, 100665428);
			HavitHVG95WLinuxProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HavitHVG95WLinuxProfile>.NativeClassPtr, 100665429);
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x0003F26C File Offset: 0x0003D46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 828993, XrefRangeEnd = 829170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HavitHVG95WLinuxProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x0003F2A8 File Offset: 0x0003D4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 829170, XrefRangeEnd = 829174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HavitHVG95WLinuxProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HavitHVG95WLinuxProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HavitHVG95WLinuxProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00006BCF File Offset: 0x00004DCF
		public HavitHVG95WLinuxProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C90 RID: 3216
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
