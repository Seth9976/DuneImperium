using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200014D RID: 333
	public class XboxOneEliteWindows10AENativeProfile : InputDeviceProfile
	{
		// Token: 0x06000E6A RID: 3690 RVA: 0x0003ADD4 File Offset: 0x00038FD4
		// Note: this type is marked as 'beforefieldinit'.
		static XboxOneEliteWindows10AENativeProfile()
		{
			Il2CppClassPointerStore<XboxOneEliteWindows10AENativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "XboxOneEliteWindows10AENativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XboxOneEliteWindows10AENativeProfile>.NativeClassPtr);
			XboxOneEliteWindows10AENativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneEliteWindows10AENativeProfile>.NativeClassPtr, 100665260);
			XboxOneEliteWindows10AENativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneEliteWindows10AENativeProfile>.NativeClassPtr, 100665261);
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x0003AE2C File Offset: 0x0003902C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 813850, XrefRangeEnd = 814173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XboxOneEliteWindows10AENativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x0003AE68 File Offset: 0x00039068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 814173, XrefRangeEnd = 814177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XboxOneEliteWindows10AENativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XboxOneEliteWindows10AENativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneEliteWindows10AENativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x000068DB File Offset: 0x00004ADB
		public XboxOneEliteWindows10AENativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BE8 RID: 3048
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000BE9 RID: 3049
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
