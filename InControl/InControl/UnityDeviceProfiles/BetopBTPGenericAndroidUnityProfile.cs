using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000169 RID: 361
	public class BetopBTPGenericAndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000EDA RID: 3802 RVA: 0x0003C494 File Offset: 0x0003A694
		// Note: this type is marked as 'beforefieldinit'.
		static BetopBTPGenericAndroidUnityProfile()
		{
			Il2CppClassPointerStore<BetopBTPGenericAndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "BetopBTPGenericAndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BetopBTPGenericAndroidUnityProfile>.NativeClassPtr);
			BetopBTPGenericAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetopBTPGenericAndroidUnityProfile>.NativeClassPtr, 100665316);
			BetopBTPGenericAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetopBTPGenericAndroidUnityProfile>.NativeClassPtr, 100665317);
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x0003C4EC File Offset: 0x0003A6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 819260, XrefRangeEnd = 819453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BetopBTPGenericAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x0003C528 File Offset: 0x0003A728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 819453, XrefRangeEnd = 819457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BetopBTPGenericAndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BetopBTPGenericAndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BetopBTPGenericAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x000069D7 File Offset: 0x00004BD7
		public BetopBTPGenericAndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
