using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001B8 RID: 440
	public class NexusPlayerMacUnityProfile : InputDeviceProfile
	{
		// Token: 0x06001016 RID: 4118 RVA: 0x000404C4 File Offset: 0x0003E6C4
		// Note: this type is marked as 'beforefieldinit'.
		static NexusPlayerMacUnityProfile()
		{
			Il2CppClassPointerStore<NexusPlayerMacUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "NexusPlayerMacUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NexusPlayerMacUnityProfile>.NativeClassPtr);
			NexusPlayerMacUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NexusPlayerMacUnityProfile>.NativeClassPtr, 100665474);
			NexusPlayerMacUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NexusPlayerMacUnityProfile>.NativeClassPtr, 100665475);
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x0004051C File Offset: 0x0003E71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 833349, XrefRangeEnd = 833517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NexusPlayerMacUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00040558 File Offset: 0x0003E758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 833517, XrefRangeEnd = 833521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NexusPlayerMacUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NexusPlayerMacUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NexusPlayerMacUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x00006C9E File Offset: 0x00004E9E
		public NexusPlayerMacUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CBE RID: 3262
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CBF RID: 3263
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
