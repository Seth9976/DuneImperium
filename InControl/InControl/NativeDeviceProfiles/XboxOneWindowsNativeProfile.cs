using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000151 RID: 337
	public class XboxOneWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000E7A RID: 3706 RVA: 0x0003B114 File Offset: 0x00039314
		// Note: this type is marked as 'beforefieldinit'.
		static XboxOneWindowsNativeProfile()
		{
			Il2CppClassPointerStore<XboxOneWindowsNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "XboxOneWindowsNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XboxOneWindowsNativeProfile>.NativeClassPtr);
			XboxOneWindowsNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneWindowsNativeProfile>.NativeClassPtr, 100665268);
			XboxOneWindowsNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneWindowsNativeProfile>.NativeClassPtr, 100665269);
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x0003B16C File Offset: 0x0003936C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 815145, XrefRangeEnd = 815455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XboxOneWindowsNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x0003B1A8 File Offset: 0x000393A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 815455, XrefRangeEnd = 815459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XboxOneWindowsNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XboxOneWindowsNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneWindowsNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x000068FF File Offset: 0x00004AFF
		public XboxOneWindowsNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BF0 RID: 3056
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000BF1 RID: 3057
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
