using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000159 RID: 345
	public class AmazonFireTVRemoteUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000E9A RID: 3738 RVA: 0x0003B794 File Offset: 0x00039994
		// Note: this type is marked as 'beforefieldinit'.
		static AmazonFireTVRemoteUnityProfile()
		{
			Il2CppClassPointerStore<AmazonFireTVRemoteUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "AmazonFireTVRemoteUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmazonFireTVRemoteUnityProfile>.NativeClassPtr);
			AmazonFireTVRemoteUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmazonFireTVRemoteUnityProfile>.NativeClassPtr, 100665284);
			AmazonFireTVRemoteUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmazonFireTVRemoteUnityProfile>.NativeClassPtr, 100665285);
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x0003B7EC File Offset: 0x000399EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816789, XrefRangeEnd = 816864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AmazonFireTVRemoteUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x0003B828 File Offset: 0x00039A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816864, XrefRangeEnd = 816868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmazonFireTVRemoteUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmazonFireTVRemoteUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmazonFireTVRemoteUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x00006947 File Offset: 0x00004B47
		public AmazonFireTVRemoteUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C00 RID: 3072
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C01 RID: 3073
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
