using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000163 RID: 355
	public class Xbox360AmazonUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000EC2 RID: 3778 RVA: 0x0003BFB4 File Offset: 0x0003A1B4
		// Note: this type is marked as 'beforefieldinit'.
		static Xbox360AmazonUnityProfile()
		{
			Il2CppClassPointerStore<Xbox360AmazonUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "Xbox360AmazonUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Xbox360AmazonUnityProfile>.NativeClassPtr);
			Xbox360AmazonUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Xbox360AmazonUnityProfile>.NativeClassPtr, 100665304);
			Xbox360AmazonUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Xbox360AmazonUnityProfile>.NativeClassPtr, 100665305);
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x0003C00C File Offset: 0x0003A20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 818400, XrefRangeEnd = 818584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Xbox360AmazonUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x0003C048 File Offset: 0x0003A248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 818584, XrefRangeEnd = 818588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Xbox360AmazonUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Xbox360AmazonUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Xbox360AmazonUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x000069A1 File Offset: 0x00004BA1
		public Xbox360AmazonUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C14 RID: 3092
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C15 RID: 3093
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
