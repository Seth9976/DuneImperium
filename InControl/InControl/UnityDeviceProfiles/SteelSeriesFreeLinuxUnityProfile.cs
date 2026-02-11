using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001A9 RID: 425
	public class SteelSeriesFreeLinuxUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000FDA RID: 4058 RVA: 0x0003F894 File Offset: 0x0003DA94
		// Note: this type is marked as 'beforefieldinit'.
		static SteelSeriesFreeLinuxUnityProfile()
		{
			Il2CppClassPointerStore<SteelSeriesFreeLinuxUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "SteelSeriesFreeLinuxUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteelSeriesFreeLinuxUnityProfile>.NativeClassPtr);
			SteelSeriesFreeLinuxUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteelSeriesFreeLinuxUnityProfile>.NativeClassPtr, 100665444);
			SteelSeriesFreeLinuxUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteelSeriesFreeLinuxUnityProfile>.NativeClassPtr, 100665445);
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x0003F8EC File Offset: 0x0003DAEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 830488, XrefRangeEnd = 830629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteelSeriesFreeLinuxUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x0003F928 File Offset: 0x0003DB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 830629, XrefRangeEnd = 830633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteelSeriesFreeLinuxUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteelSeriesFreeLinuxUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteelSeriesFreeLinuxUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x00006C17 File Offset: 0x00004E17
		public SteelSeriesFreeLinuxUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
