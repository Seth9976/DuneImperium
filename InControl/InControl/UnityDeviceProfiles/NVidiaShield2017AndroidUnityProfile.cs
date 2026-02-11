using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x0200018E RID: 398
	public class NVidiaShield2017AndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000F6E RID: 3950 RVA: 0x0003E2A4 File Offset: 0x0003C4A4
		// Note: this type is marked as 'beforefieldinit'.
		static NVidiaShield2017AndroidUnityProfile()
		{
			Il2CppClassPointerStore<NVidiaShield2017AndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "NVidiaShield2017AndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NVidiaShield2017AndroidUnityProfile>.NativeClassPtr);
			NVidiaShield2017AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NVidiaShield2017AndroidUnityProfile>.NativeClassPtr, 100665390);
			NVidiaShield2017AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NVidiaShield2017AndroidUnityProfile>.NativeClassPtr, 100665391);
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x0003E2FC File Offset: 0x0003C4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 825662, XrefRangeEnd = 825836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NVidiaShield2017AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x0003E338 File Offset: 0x0003C538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 825836, XrefRangeEnd = 825840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NVidiaShield2017AndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NVidiaShield2017AndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NVidiaShield2017AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x00006B24 File Offset: 0x00004D24
		public NVidiaShield2017AndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
