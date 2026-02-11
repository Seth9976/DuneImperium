using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001A0 RID: 416
	public class GenericLinuxUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000FB6 RID: 4022 RVA: 0x0003F144 File Offset: 0x0003D344
		// Note: this type is marked as 'beforefieldinit'.
		static GenericLinuxUnityProfile()
		{
			Il2CppClassPointerStore<GenericLinuxUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "GenericLinuxUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericLinuxUnityProfile>.NativeClassPtr);
			GenericLinuxUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericLinuxUnityProfile>.NativeClassPtr, 100665426);
			GenericLinuxUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericLinuxUnityProfile>.NativeClassPtr, 100665427);
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x0003F19C File Offset: 0x0003D39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 828766, XrefRangeEnd = 828989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericLinuxUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x0003F1D8 File Offset: 0x0003D3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 828989, XrefRangeEnd = 828993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericLinuxUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericLinuxUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericLinuxUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x00006BC6 File Offset: 0x00004DC6
		public GenericLinuxUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C8E RID: 3214
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C8F RID: 3215
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
