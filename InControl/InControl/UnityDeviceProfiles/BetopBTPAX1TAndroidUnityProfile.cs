using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000168 RID: 360
	public class BetopBTPAX1TAndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000ED6 RID: 3798 RVA: 0x0003C3C4 File Offset: 0x0003A5C4
		// Note: this type is marked as 'beforefieldinit'.
		static BetopBTPAX1TAndroidUnityProfile()
		{
			Il2CppClassPointerStore<BetopBTPAX1TAndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "BetopBTPAX1TAndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BetopBTPAX1TAndroidUnityProfile>.NativeClassPtr);
			BetopBTPAX1TAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetopBTPAX1TAndroidUnityProfile>.NativeClassPtr, 100665314);
			BetopBTPAX1TAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetopBTPAX1TAndroidUnityProfile>.NativeClassPtr, 100665315);
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x0003C41C File Offset: 0x0003A61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 819097, XrefRangeEnd = 819256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BetopBTPAX1TAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x0003C458 File Offset: 0x0003A658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 819256, XrefRangeEnd = 819260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BetopBTPAX1TAndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BetopBTPAX1TAndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BetopBTPAX1TAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x000069CE File Offset: 0x00004BCE
		public BetopBTPAX1TAndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
