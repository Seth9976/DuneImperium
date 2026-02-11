using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000166 RID: 358
	public class AndroidTVUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000ECE RID: 3790 RVA: 0x0003C224 File Offset: 0x0003A424
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidTVUnityProfile()
		{
			Il2CppClassPointerStore<AndroidTVUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "AndroidTVUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidTVUnityProfile>.NativeClassPtr);
			AndroidTVUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTVUnityProfile>.NativeClassPtr, 100665310);
			AndroidTVUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTVUnityProfile>.NativeClassPtr, 100665311);
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x0003C27C File Offset: 0x0003A47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 818729, XrefRangeEnd = 818912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AndroidTVUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x0003C2B8 File Offset: 0x0003A4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 818912, XrefRangeEnd = 818916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AndroidTVUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidTVUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTVUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x000069BC File Offset: 0x00004BBC
		public AndroidTVUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
