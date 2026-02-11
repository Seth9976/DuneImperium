using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000176 RID: 374
	public class FixXBG301AndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000F0E RID: 3854 RVA: 0x0003CF24 File Offset: 0x0003B124
		// Note: this type is marked as 'beforefieldinit'.
		static FixXBG301AndroidUnityProfile()
		{
			Il2CppClassPointerStore<FixXBG301AndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "FixXBG301AndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixXBG301AndroidUnityProfile>.NativeClassPtr);
			FixXBG301AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixXBG301AndroidUnityProfile>.NativeClassPtr, 100665342);
			FixXBG301AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixXBG301AndroidUnityProfile>.NativeClassPtr, 100665343);
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x0003CF7C File Offset: 0x0003B17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 821492, XrefRangeEnd = 821689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FixXBG301AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x0003CFB8 File Offset: 0x0003B1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 821689, XrefRangeEnd = 821693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FixXBG301AndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FixXBG301AndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixXBG301AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x00006A4C File Offset: 0x00004C4C
		public FixXBG301AndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C3A RID: 3130
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C3B RID: 3131
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
