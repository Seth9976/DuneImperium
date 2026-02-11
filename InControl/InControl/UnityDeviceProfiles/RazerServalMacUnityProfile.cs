using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001BE RID: 446
	public class RazerServalMacUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600102E RID: 4142 RVA: 0x000409A4 File Offset: 0x0003EBA4
		// Note: this type is marked as 'beforefieldinit'.
		static RazerServalMacUnityProfile()
		{
			Il2CppClassPointerStore<RazerServalMacUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "RazerServalMacUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RazerServalMacUnityProfile>.NativeClassPtr);
			RazerServalMacUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RazerServalMacUnityProfile>.NativeClassPtr, 100665486);
			RazerServalMacUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RazerServalMacUnityProfile>.NativeClassPtr, 100665487);
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x000409FC File Offset: 0x0003EBFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 834512, XrefRangeEnd = 834702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RazerServalMacUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x00040A38 File Offset: 0x0003EC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 834702, XrefRangeEnd = 834706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RazerServalMacUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RazerServalMacUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RazerServalMacUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x00006CD4 File Offset: 0x00004ED4
		public RazerServalMacUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CCA RID: 3274
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CCB RID: 3275
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
