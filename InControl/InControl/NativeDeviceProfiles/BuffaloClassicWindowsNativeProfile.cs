using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000132 RID: 306
	public class BuffaloClassicWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000DFE RID: 3582 RVA: 0x000397E4 File Offset: 0x000379E4
		// Note: this type is marked as 'beforefieldinit'.
		static BuffaloClassicWindowsNativeProfile()
		{
			Il2CppClassPointerStore<BuffaloClassicWindowsNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "BuffaloClassicWindowsNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffaloClassicWindowsNativeProfile>.NativeClassPtr);
			BuffaloClassicWindowsNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffaloClassicWindowsNativeProfile>.NativeClassPtr, 100665206);
			BuffaloClassicWindowsNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffaloClassicWindowsNativeProfile>.NativeClassPtr, 100665207);
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x0003983C File Offset: 0x00037A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806076, XrefRangeEnd = 806243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuffaloClassicWindowsNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00039878 File Offset: 0x00037A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806243, XrefRangeEnd = 806247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuffaloClassicWindowsNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffaloClassicWindowsNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffaloClassicWindowsNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x000067E8 File Offset: 0x000049E8
		public BuffaloClassicWindowsNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BB2 RID: 2994
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000BB3 RID: 2995
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
