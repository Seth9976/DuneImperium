using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001DF RID: 479
	public class AirFloWiredPS3WindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x060010B2 RID: 4274 RVA: 0x00042474 File Offset: 0x00040674
		// Note: this type is marked as 'beforefieldinit'.
		static AirFloWiredPS3WindowsUnityProfile()
		{
			Il2CppClassPointerStore<AirFloWiredPS3WindowsUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "AirFloWiredPS3WindowsUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AirFloWiredPS3WindowsUnityProfile>.NativeClassPtr);
			AirFloWiredPS3WindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirFloWiredPS3WindowsUnityProfile>.NativeClassPtr, 100665552);
			AirFloWiredPS3WindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirFloWiredPS3WindowsUnityProfile>.NativeClassPtr, 100665553);
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x000424CC File Offset: 0x000406CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 841893, XrefRangeEnd = 842079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AirFloWiredPS3WindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x00042508 File Offset: 0x00040708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 842079, XrefRangeEnd = 842083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AirFloWiredPS3WindowsUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AirFloWiredPS3WindowsUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirFloWiredPS3WindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x00006DFD File Offset: 0x00004FFD
		public AirFloWiredPS3WindowsUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D0C RID: 3340
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D0D RID: 3341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
