using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001AB RID: 427
	public class AirFloWiredPS3MacUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000FE2 RID: 4066 RVA: 0x0003FA34 File Offset: 0x0003DC34
		// Note: this type is marked as 'beforefieldinit'.
		static AirFloWiredPS3MacUnityProfile()
		{
			Il2CppClassPointerStore<AirFloWiredPS3MacUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "AirFloWiredPS3MacUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AirFloWiredPS3MacUnityProfile>.NativeClassPtr);
			AirFloWiredPS3MacUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirFloWiredPS3MacUnityProfile>.NativeClassPtr, 100665448);
			AirFloWiredPS3MacUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirFloWiredPS3MacUnityProfile>.NativeClassPtr, 100665449);
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x0003FA8C File Offset: 0x0003DC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 830883, XrefRangeEnd = 831069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AirFloWiredPS3MacUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x0003FAC8 File Offset: 0x0003DCC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 831069, XrefRangeEnd = 831073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AirFloWiredPS3MacUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AirFloWiredPS3MacUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirFloWiredPS3MacUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x00006C29 File Offset: 0x00004E29
		public AirFloWiredPS3MacUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CA5 RID: 3237
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
