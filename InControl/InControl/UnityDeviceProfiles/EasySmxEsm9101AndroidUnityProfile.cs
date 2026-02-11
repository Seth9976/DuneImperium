using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x0200016D RID: 365
	public class EasySmxEsm9101AndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000EEA RID: 3818 RVA: 0x0003C7D4 File Offset: 0x0003A9D4
		// Note: this type is marked as 'beforefieldinit'.
		static EasySmxEsm9101AndroidUnityProfile()
		{
			Il2CppClassPointerStore<EasySmxEsm9101AndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "EasySmxEsm9101AndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EasySmxEsm9101AndroidUnityProfile>.NativeClassPtr);
			EasySmxEsm9101AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EasySmxEsm9101AndroidUnityProfile>.NativeClassPtr, 100665324);
			EasySmxEsm9101AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EasySmxEsm9101AndroidUnityProfile>.NativeClassPtr, 100665325);
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x0003C82C File Offset: 0x0003AA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 819999, XrefRangeEnd = 820185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EasySmxEsm9101AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x0003C868 File Offset: 0x0003AA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820185, XrefRangeEnd = 820189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EasySmxEsm9101AndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EasySmxEsm9101AndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EasySmxEsm9101AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x000069FB File Offset: 0x00004BFB
		public EasySmxEsm9101AndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C28 RID: 3112
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C29 RID: 3113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
