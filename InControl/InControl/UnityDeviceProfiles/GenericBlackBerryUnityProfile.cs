using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001CA RID: 458
	public class GenericBlackBerryUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600105E RID: 4190 RVA: 0x00041364 File Offset: 0x0003F564
		// Note: this type is marked as 'beforefieldinit'.
		static GenericBlackBerryUnityProfile()
		{
			Il2CppClassPointerStore<GenericBlackBerryUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "GenericBlackBerryUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericBlackBerryUnityProfile>.NativeClassPtr);
			GenericBlackBerryUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBlackBerryUnityProfile>.NativeClassPtr, 100665510);
			GenericBlackBerryUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBlackBerryUnityProfile>.NativeClassPtr, 100665511);
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x000413BC File Offset: 0x0003F5BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 836433, XrefRangeEnd = 836610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericBlackBerryUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x000413F8 File Offset: 0x0003F5F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 836610, XrefRangeEnd = 836614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericBlackBerryUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericBlackBerryUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericBlackBerryUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x00006D40 File Offset: 0x00004F40
		public GenericBlackBerryUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CE2 RID: 3298
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CE3 RID: 3299
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
