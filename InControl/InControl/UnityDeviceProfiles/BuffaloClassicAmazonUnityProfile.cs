using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x0200015C RID: 348
	public class BuffaloClassicAmazonUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000EA6 RID: 3750 RVA: 0x0003BA04 File Offset: 0x00039C04
		// Note: this type is marked as 'beforefieldinit'.
		static BuffaloClassicAmazonUnityProfile()
		{
			Il2CppClassPointerStore<BuffaloClassicAmazonUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "BuffaloClassicAmazonUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffaloClassicAmazonUnityProfile>.NativeClassPtr);
			BuffaloClassicAmazonUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffaloClassicAmazonUnityProfile>.NativeClassPtr, 100665290);
			BuffaloClassicAmazonUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffaloClassicAmazonUnityProfile>.NativeClassPtr, 100665291);
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x0003BA5C File Offset: 0x00039C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 817224, XrefRangeEnd = 817314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuffaloClassicAmazonUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x0003BA98 File Offset: 0x00039C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 817314, XrefRangeEnd = 817318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuffaloClassicAmazonUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffaloClassicAmazonUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffaloClassicAmazonUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x00006962 File Offset: 0x00004B62
		public BuffaloClassicAmazonUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C06 RID: 3078
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C07 RID: 3079
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
