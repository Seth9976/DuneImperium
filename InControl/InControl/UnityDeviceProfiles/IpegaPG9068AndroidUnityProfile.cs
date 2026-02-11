using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000183 RID: 387
	public class IpegaPG9068AndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000F42 RID: 3906 RVA: 0x0003D9B4 File Offset: 0x0003BBB4
		// Note: this type is marked as 'beforefieldinit'.
		static IpegaPG9068AndroidUnityProfile()
		{
			Il2CppClassPointerStore<IpegaPG9068AndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "IpegaPG9068AndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IpegaPG9068AndroidUnityProfile>.NativeClassPtr);
			IpegaPG9068AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IpegaPG9068AndroidUnityProfile>.NativeClassPtr, 100665368);
			IpegaPG9068AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IpegaPG9068AndroidUnityProfile>.NativeClassPtr, 100665369);
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x0003DA0C File Offset: 0x0003BC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 823819, XrefRangeEnd = 823996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IpegaPG9068AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x0003DA48 File Offset: 0x0003BC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 823996, XrefRangeEnd = 824000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IpegaPG9068AndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IpegaPG9068AndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IpegaPG9068AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x00006AC1 File Offset: 0x00004CC1
		public IpegaPG9068AndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C54 RID: 3156
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C55 RID: 3157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
