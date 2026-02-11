using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000180 RID: 384
	public class IpegaPG9025AndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000F36 RID: 3894 RVA: 0x0003D744 File Offset: 0x0003B944
		// Note: this type is marked as 'beforefieldinit'.
		static IpegaPG9025AndroidUnityProfile()
		{
			Il2CppClassPointerStore<IpegaPG9025AndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "IpegaPG9025AndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IpegaPG9025AndroidUnityProfile>.NativeClassPtr);
			IpegaPG9025AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IpegaPG9025AndroidUnityProfile>.NativeClassPtr, 100665362);
			IpegaPG9025AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IpegaPG9025AndroidUnityProfile>.NativeClassPtr, 100665363);
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x0003D79C File Offset: 0x0003B99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 823276, XrefRangeEnd = 823453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IpegaPG9025AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x0003D7D8 File Offset: 0x0003B9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 823453, XrefRangeEnd = 823457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IpegaPG9025AndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IpegaPG9025AndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IpegaPG9025AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x00006AA6 File Offset: 0x00004CA6
		public IpegaPG9025AndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C4E RID: 3150
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C4F RID: 3151
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
