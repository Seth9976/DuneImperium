using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000119 RID: 281
	public class XboxSeriesXBluetoothMacNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000D75 RID: 3445 RVA: 0x0003782C File Offset: 0x00035A2C
		// Note: this type is marked as 'beforefieldinit'.
		static XboxSeriesXBluetoothMacNativeProfile()
		{
			Il2CppClassPointerStore<XboxSeriesXBluetoothMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "XboxSeriesXBluetoothMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XboxSeriesXBluetoothMacNativeProfile>.NativeClassPtr);
			XboxSeriesXBluetoothMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxSeriesXBluetoothMacNativeProfile>.NativeClassPtr, 100665119);
			XboxSeriesXBluetoothMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxSeriesXBluetoothMacNativeProfile>.NativeClassPtr, 100665120);
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x00037884 File Offset: 0x00035A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800292, XrefRangeEnd = 800510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XboxSeriesXBluetoothMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x000378C0 File Offset: 0x00035AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800510, XrefRangeEnd = 800514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XboxSeriesXBluetoothMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XboxSeriesXBluetoothMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxSeriesXBluetoothMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x00006707 File Offset: 0x00004907
		public XboxSeriesXBluetoothMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
