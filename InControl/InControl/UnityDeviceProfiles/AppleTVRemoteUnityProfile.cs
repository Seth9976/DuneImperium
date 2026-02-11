using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x0200019D RID: 413
	public class AppleTVRemoteUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000FAA RID: 4010 RVA: 0x0003EED4 File Offset: 0x0003D0D4
		// Note: this type is marked as 'beforefieldinit'.
		static AppleTVRemoteUnityProfile()
		{
			Il2CppClassPointerStore<AppleTVRemoteUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "AppleTVRemoteUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppleTVRemoteUnityProfile>.NativeClassPtr);
			AppleTVRemoteUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleTVRemoteUnityProfile>.NativeClassPtr, 100665420);
			AppleTVRemoteUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleTVRemoteUnityProfile>.NativeClassPtr, 100665421);
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x0003EF2C File Offset: 0x0003D12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 828283, XrefRangeEnd = 828420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppleTVRemoteUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x0003EF68 File Offset: 0x0003D168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 828420, XrefRangeEnd = 828424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppleTVRemoteUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppleTVRemoteUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleTVRemoteUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x00006BAB File Offset: 0x00004DAB
		public AppleTVRemoteUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C88 RID: 3208
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C89 RID: 3209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
