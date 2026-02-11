using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200013B RID: 315
	public class KiwitataNESWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000E22 RID: 3618 RVA: 0x00039F34 File Offset: 0x00038134
		// Note: this type is marked as 'beforefieldinit'.
		static KiwitataNESWindowsNativeProfile()
		{
			Il2CppClassPointerStore<KiwitataNESWindowsNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "KiwitataNESWindowsNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KiwitataNESWindowsNativeProfile>.NativeClassPtr);
			KiwitataNESWindowsNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KiwitataNESWindowsNativeProfile>.NativeClassPtr, 100665224);
			KiwitataNESWindowsNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KiwitataNESWindowsNativeProfile>.NativeClassPtr, 100665225);
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x00039F8C File Offset: 0x0003818C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 808437, XrefRangeEnd = 808602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KiwitataNESWindowsNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x00039FC8 File Offset: 0x000381C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 808602, XrefRangeEnd = 808606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KiwitataNESWindowsNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KiwitataNESWindowsNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KiwitataNESWindowsNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x00006839 File Offset: 0x00004A39
		public KiwitataNESWindowsNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
