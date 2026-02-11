using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000198 RID: 408
	public class SteelSeriesFreeAndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000F96 RID: 3990 RVA: 0x0003EAC4 File Offset: 0x0003CCC4
		// Note: this type is marked as 'beforefieldinit'.
		static SteelSeriesFreeAndroidUnityProfile()
		{
			Il2CppClassPointerStore<SteelSeriesFreeAndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "SteelSeriesFreeAndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteelSeriesFreeAndroidUnityProfile>.NativeClassPtr);
			SteelSeriesFreeAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteelSeriesFreeAndroidUnityProfile>.NativeClassPtr, 100665410);
			SteelSeriesFreeAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteelSeriesFreeAndroidUnityProfile>.NativeClassPtr, 100665411);
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x0003EB1C File Offset: 0x0003CD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 827352, XrefRangeEnd = 827533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteelSeriesFreeAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x0003EB58 File Offset: 0x0003CD58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 827533, XrefRangeEnd = 827537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteelSeriesFreeAndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteelSeriesFreeAndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteelSeriesFreeAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00006B7E File Offset: 0x00004D7E
		public SteelSeriesFreeAndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C7E RID: 3198
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C7F RID: 3199
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
