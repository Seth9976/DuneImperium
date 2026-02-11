using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000105 RID: 261
	public class EightBitdoNES30ProBTMacNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000D25 RID: 3365 RVA: 0x000367EC File Offset: 0x000349EC
		// Note: this type is marked as 'beforefieldinit'.
		static EightBitdoNES30ProBTMacNativeProfile()
		{
			Il2CppClassPointerStore<EightBitdoNES30ProBTMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "EightBitdoNES30ProBTMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EightBitdoNES30ProBTMacNativeProfile>.NativeClassPtr);
			EightBitdoNES30ProBTMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EightBitdoNES30ProBTMacNativeProfile>.NativeClassPtr, 100665079);
			EightBitdoNES30ProBTMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EightBitdoNES30ProBTMacNativeProfile>.NativeClassPtr, 100665080);
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00036844 File Offset: 0x00034A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794798, XrefRangeEnd = 795101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EightBitdoNES30ProBTMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00036880 File Offset: 0x00034A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795101, XrefRangeEnd = 795105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EightBitdoNES30ProBTMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EightBitdoNES30ProBTMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EightBitdoNES30ProBTMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x00006653 File Offset: 0x00004853
		public EightBitdoNES30ProBTMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B33 RID: 2867
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B34 RID: 2868
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
