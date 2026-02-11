using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001BA RID: 442
	public class PlayStation4MacBluetoothUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600101E RID: 4126 RVA: 0x00040664 File Offset: 0x0003E864
		// Note: this type is marked as 'beforefieldinit'.
		static PlayStation4MacBluetoothUnityProfile()
		{
			Il2CppClassPointerStore<PlayStation4MacBluetoothUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "PlayStation4MacBluetoothUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayStation4MacBluetoothUnityProfile>.NativeClassPtr);
			PlayStation4MacBluetoothUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayStation4MacBluetoothUnityProfile>.NativeClassPtr, 100665478);
			PlayStation4MacBluetoothUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayStation4MacBluetoothUnityProfile>.NativeClassPtr, 100665479);
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x000406BC File Offset: 0x0003E8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 833747, XrefRangeEnd = 833898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayStation4MacBluetoothUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x000406F8 File Offset: 0x0003E8F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 833898, XrefRangeEnd = 833902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayStation4MacBluetoothUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayStation4MacBluetoothUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayStation4MacBluetoothUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x00006CB0 File Offset: 0x00004EB0
		public PlayStation4MacBluetoothUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CC2 RID: 3266
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CC3 RID: 3267
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
