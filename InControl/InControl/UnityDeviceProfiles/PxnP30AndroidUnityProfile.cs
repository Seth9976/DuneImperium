using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000194 RID: 404
	public class PxnP30AndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000F86 RID: 3974 RVA: 0x0003E784 File Offset: 0x0003C984
		// Note: this type is marked as 'beforefieldinit'.
		static PxnP30AndroidUnityProfile()
		{
			Il2CppClassPointerStore<PxnP30AndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "PxnP30AndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PxnP30AndroidUnityProfile>.NativeClassPtr);
			PxnP30AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PxnP30AndroidUnityProfile>.NativeClassPtr, 100665402);
			PxnP30AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PxnP30AndroidUnityProfile>.NativeClassPtr, 100665403);
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x0003E7DC File Offset: 0x0003C9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 826656, XrefRangeEnd = 826833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PxnP30AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x0003E818 File Offset: 0x0003CA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 826833, XrefRangeEnd = 826837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PxnP30AndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PxnP30AndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PxnP30AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00006B5A File Offset: 0x00004D5A
		public PxnP30AndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C76 RID: 3190
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C77 RID: 3191
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
