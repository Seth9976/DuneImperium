using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x0200015A RID: 346
	public class AmazonFireTVUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000E9E RID: 3742 RVA: 0x0003B864 File Offset: 0x00039A64
		// Note: this type is marked as 'beforefieldinit'.
		static AmazonFireTVUnityProfile()
		{
			Il2CppClassPointerStore<AmazonFireTVUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "AmazonFireTVUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmazonFireTVUnityProfile>.NativeClassPtr);
			AmazonFireTVUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmazonFireTVUnityProfile>.NativeClassPtr, 100665286);
			AmazonFireTVUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmazonFireTVUnityProfile>.NativeClassPtr, 100665287);
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x0003B8BC File Offset: 0x00039ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816868, XrefRangeEnd = 817048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AmazonFireTVUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x0003B8F8 File Offset: 0x00039AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 817048, XrefRangeEnd = 817052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmazonFireTVUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmazonFireTVUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmazonFireTVUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00006950 File Offset: 0x00004B50
		public AmazonFireTVUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C02 RID: 3074
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C03 RID: 3075
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
