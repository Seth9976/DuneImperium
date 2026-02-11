using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000164 RID: 356
	public class AndroidTVMiBoxRemoteUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000EC6 RID: 3782 RVA: 0x0003C084 File Offset: 0x0003A284
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidTVMiBoxRemoteUnityProfile()
		{
			Il2CppClassPointerStore<AndroidTVMiBoxRemoteUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "AndroidTVMiBoxRemoteUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidTVMiBoxRemoteUnityProfile>.NativeClassPtr);
			AndroidTVMiBoxRemoteUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTVMiBoxRemoteUnityProfile>.NativeClassPtr, 100665306);
			AndroidTVMiBoxRemoteUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTVMiBoxRemoteUnityProfile>.NativeClassPtr, 100665307);
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x0003C0DC File Offset: 0x0003A2DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 818588, XrefRangeEnd = 818650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AndroidTVMiBoxRemoteUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x0003C118 File Offset: 0x0003A318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 818650, XrefRangeEnd = 818654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AndroidTVMiBoxRemoteUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidTVMiBoxRemoteUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTVMiBoxRemoteUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x000069AA File Offset: 0x00004BAA
		public AndroidTVMiBoxRemoteUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C16 RID: 3094
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
