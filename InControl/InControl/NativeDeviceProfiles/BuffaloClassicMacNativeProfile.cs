using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000104 RID: 260
	public class BuffaloClassicMacNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000D21 RID: 3361 RVA: 0x0003671C File Offset: 0x0003491C
		// Note: this type is marked as 'beforefieldinit'.
		static BuffaloClassicMacNativeProfile()
		{
			Il2CppClassPointerStore<BuffaloClassicMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "BuffaloClassicMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffaloClassicMacNativeProfile>.NativeClassPtr);
			BuffaloClassicMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffaloClassicMacNativeProfile>.NativeClassPtr, 100665077);
			BuffaloClassicMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffaloClassicMacNativeProfile>.NativeClassPtr, 100665078);
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x00036774 File Offset: 0x00034974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794626, XrefRangeEnd = 794794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuffaloClassicMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x000367B0 File Offset: 0x000349B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794794, XrefRangeEnd = 794798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuffaloClassicMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffaloClassicMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffaloClassicMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x0000664A File Offset: 0x0000484A
		public BuffaloClassicMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B32 RID: 2866
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
