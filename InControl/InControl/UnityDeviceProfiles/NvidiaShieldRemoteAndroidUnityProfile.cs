using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000190 RID: 400
	public class NvidiaShieldRemoteAndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000F76 RID: 3958 RVA: 0x0003E444 File Offset: 0x0003C644
		// Note: this type is marked as 'beforefieldinit'.
		static NvidiaShieldRemoteAndroidUnityProfile()
		{
			Il2CppClassPointerStore<NvidiaShieldRemoteAndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "NvidiaShieldRemoteAndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NvidiaShieldRemoteAndroidUnityProfile>.NativeClassPtr);
			NvidiaShieldRemoteAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NvidiaShieldRemoteAndroidUnityProfile>.NativeClassPtr, 100665394);
			NvidiaShieldRemoteAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NvidiaShieldRemoteAndroidUnityProfile>.NativeClassPtr, 100665395);
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x0003E49C File Offset: 0x0003C69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 826012, XrefRangeEnd = 826069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NvidiaShieldRemoteAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x0003E4D8 File Offset: 0x0003C6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 826069, XrefRangeEnd = 826073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NvidiaShieldRemoteAndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NvidiaShieldRemoteAndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NvidiaShieldRemoteAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00006B36 File Offset: 0x00004D36
		public NvidiaShieldRemoteAndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
