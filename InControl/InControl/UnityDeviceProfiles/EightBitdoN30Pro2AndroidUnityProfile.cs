using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000170 RID: 368
	public class EightBitdoN30Pro2AndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000EF6 RID: 3830 RVA: 0x0003CA44 File Offset: 0x0003AC44
		// Note: this type is marked as 'beforefieldinit'.
		static EightBitdoN30Pro2AndroidUnityProfile()
		{
			Il2CppClassPointerStore<EightBitdoN30Pro2AndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "EightBitdoN30Pro2AndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EightBitdoN30Pro2AndroidUnityProfile>.NativeClassPtr);
			EightBitdoN30Pro2AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EightBitdoN30Pro2AndroidUnityProfile>.NativeClassPtr, 100665330);
			EightBitdoN30Pro2AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EightBitdoN30Pro2AndroidUnityProfile>.NativeClassPtr, 100665331);
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x0003CA9C File Offset: 0x0003AC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820532, XrefRangeEnd = 820691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EightBitdoN30Pro2AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x0003CAD8 File Offset: 0x0003ACD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820691, XrefRangeEnd = 820695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EightBitdoN30Pro2AndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EightBitdoN30Pro2AndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EightBitdoN30Pro2AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x00006A16 File Offset: 0x00004C16
		public EightBitdoN30Pro2AndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
