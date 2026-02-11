using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000203 RID: 515
	public class ValveStreamingWindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x06001142 RID: 4418 RVA: 0x000441B4 File Offset: 0x000423B4
		// Note: this type is marked as 'beforefieldinit'.
		static ValveStreamingWindowsUnityProfile()
		{
			Il2CppClassPointerStore<ValveStreamingWindowsUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "ValveStreamingWindowsUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValveStreamingWindowsUnityProfile>.NativeClassPtr);
			ValveStreamingWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValveStreamingWindowsUnityProfile>.NativeClassPtr, 100665624);
			ValveStreamingWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValveStreamingWindowsUnityProfile>.NativeClassPtr, 100665625);
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x0004420C File Offset: 0x0004240C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 848827, XrefRangeEnd = 849004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ValveStreamingWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x00044248 File Offset: 0x00042448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 849004, XrefRangeEnd = 849008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValveStreamingWindowsUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValveStreamingWindowsUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValveStreamingWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x00006F41 File Offset: 0x00005141
		public ValveStreamingWindowsUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D54 RID: 3412
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D55 RID: 3413
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
