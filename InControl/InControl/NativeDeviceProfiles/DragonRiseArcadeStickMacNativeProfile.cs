using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200007F RID: 127
	public class DragonRiseArcadeStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000B0D RID: 2829 RVA: 0x0002FB0C File Offset: 0x0002DD0C
		// Note: this type is marked as 'beforefieldinit'.
		static DragonRiseArcadeStickMacNativeProfile()
		{
			Il2CppClassPointerStore<DragonRiseArcadeStickMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "DragonRiseArcadeStickMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragonRiseArcadeStickMacNativeProfile>.NativeClassPtr);
			DragonRiseArcadeStickMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragonRiseArcadeStickMacNativeProfile>.NativeClassPtr, 100664811);
			DragonRiseArcadeStickMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragonRiseArcadeStickMacNativeProfile>.NativeClassPtr, 100664812);
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0002FB64 File Offset: 0x0002DD64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792333, XrefRangeEnd = 792347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragonRiseArcadeStickMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0002FBA0 File Offset: 0x0002DDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DragonRiseArcadeStickMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragonRiseArcadeStickMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragonRiseArcadeStickMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0000619D File Offset: 0x0000439D
		public DragonRiseArcadeStickMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
