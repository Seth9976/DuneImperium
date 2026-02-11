using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000142 RID: 322
	public class NintendoSwitchProWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000E3E RID: 3646 RVA: 0x0003A4E4 File Offset: 0x000386E4
		// Note: this type is marked as 'beforefieldinit'.
		static NintendoSwitchProWindowsNativeProfile()
		{
			Il2CppClassPointerStore<NintendoSwitchProWindowsNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "NintendoSwitchProWindowsNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NintendoSwitchProWindowsNativeProfile>.NativeClassPtr);
			NintendoSwitchProWindowsNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchProWindowsNativeProfile>.NativeClassPtr, 100665238);
			NintendoSwitchProWindowsNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchProWindowsNativeProfile>.NativeClassPtr, 100665239);
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x0003A53C File Offset: 0x0003873C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 810424, XrefRangeEnd = 810746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NintendoSwitchProWindowsNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x0003A578 File Offset: 0x00038778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 810746, XrefRangeEnd = 810750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NintendoSwitchProWindowsNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NintendoSwitchProWindowsNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchProWindowsNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x00006878 File Offset: 0x00004A78
		public NintendoSwitchProWindowsNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
