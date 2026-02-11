using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001C1 RID: 449
	public class Xbox360MacUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600103A RID: 4154 RVA: 0x00040C14 File Offset: 0x0003EE14
		// Note: this type is marked as 'beforefieldinit'.
		static Xbox360MacUnityProfile()
		{
			Il2CppClassPointerStore<Xbox360MacUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "Xbox360MacUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Xbox360MacUnityProfile>.NativeClassPtr);
			Xbox360MacUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Xbox360MacUnityProfile>.NativeClassPtr, 100665492);
			Xbox360MacUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Xbox360MacUnityProfile>.NativeClassPtr, 100665493);
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x00040C6C File Offset: 0x0003EE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 835068, XrefRangeEnd = 835297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Xbox360MacUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x00040CA8 File Offset: 0x0003EEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 835297, XrefRangeEnd = 835301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Xbox360MacUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Xbox360MacUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Xbox360MacUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x00006CEF File Offset: 0x00004EEF
		public Xbox360MacUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CD0 RID: 3280
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CD1 RID: 3281
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
