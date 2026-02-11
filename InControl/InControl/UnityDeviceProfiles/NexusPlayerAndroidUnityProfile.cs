using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x0200018A RID: 394
	public class NexusPlayerAndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000F5E RID: 3934 RVA: 0x0003DF64 File Offset: 0x0003C164
		// Note: this type is marked as 'beforefieldinit'.
		static NexusPlayerAndroidUnityProfile()
		{
			Il2CppClassPointerStore<NexusPlayerAndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "NexusPlayerAndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NexusPlayerAndroidUnityProfile>.NativeClassPtr);
			NexusPlayerAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NexusPlayerAndroidUnityProfile>.NativeClassPtr, 100665382);
			NexusPlayerAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NexusPlayerAndroidUnityProfile>.NativeClassPtr, 100665383);
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x0003DFBC File Offset: 0x0003C1BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 825062, XrefRangeEnd = 825239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NexusPlayerAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x0003DFF8 File Offset: 0x0003C1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 825239, XrefRangeEnd = 825243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NexusPlayerAndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NexusPlayerAndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NexusPlayerAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x00006B00 File Offset: 0x00004D00
		public NexusPlayerAndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C62 RID: 3170
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C63 RID: 3171
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
