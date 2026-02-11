using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x0200016C RID: 364
	public class DroidBoxXboxAndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000EE6 RID: 3814 RVA: 0x0003C704 File Offset: 0x0003A904
		// Note: this type is marked as 'beforefieldinit'.
		static DroidBoxXboxAndroidUnityProfile()
		{
			Il2CppClassPointerStore<DroidBoxXboxAndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "DroidBoxXboxAndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DroidBoxXboxAndroidUnityProfile>.NativeClassPtr);
			DroidBoxXboxAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroidBoxXboxAndroidUnityProfile>.NativeClassPtr, 100665322);
			DroidBoxXboxAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroidBoxXboxAndroidUnityProfile>.NativeClassPtr, 100665323);
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x0003C75C File Offset: 0x0003A95C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 819818, XrefRangeEnd = 819995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DroidBoxXboxAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x0003C798 File Offset: 0x0003A998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 819995, XrefRangeEnd = 819999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DroidBoxXboxAndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DroidBoxXboxAndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DroidBoxXboxAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x000069F2 File Offset: 0x00004BF2
		public DroidBoxXboxAndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C26 RID: 3110
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C27 RID: 3111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
