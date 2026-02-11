using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x0200018B RID: 395
	public class NexusPlayerRemoteAndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000F62 RID: 3938 RVA: 0x0003E034 File Offset: 0x0003C234
		// Note: this type is marked as 'beforefieldinit'.
		static NexusPlayerRemoteAndroidUnityProfile()
		{
			Il2CppClassPointerStore<NexusPlayerRemoteAndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "NexusPlayerRemoteAndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NexusPlayerRemoteAndroidUnityProfile>.NativeClassPtr);
			NexusPlayerRemoteAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NexusPlayerRemoteAndroidUnityProfile>.NativeClassPtr, 100665384);
			NexusPlayerRemoteAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NexusPlayerRemoteAndroidUnityProfile>.NativeClassPtr, 100665385);
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x0003E08C File Offset: 0x0003C28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 825243, XrefRangeEnd = 825305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NexusPlayerRemoteAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x0003E0C8 File Offset: 0x0003C2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 825305, XrefRangeEnd = 825309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NexusPlayerRemoteAndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NexusPlayerRemoteAndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NexusPlayerRemoteAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00006B09 File Offset: 0x00004D09
		public NexusPlayerRemoteAndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C64 RID: 3172
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C65 RID: 3173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
