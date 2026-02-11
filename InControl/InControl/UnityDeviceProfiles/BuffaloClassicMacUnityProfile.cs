using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001AC RID: 428
	public class BuffaloClassicMacUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000FE6 RID: 4070 RVA: 0x0003FB04 File Offset: 0x0003DD04
		// Note: this type is marked as 'beforefieldinit'.
		static BuffaloClassicMacUnityProfile()
		{
			Il2CppClassPointerStore<BuffaloClassicMacUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "BuffaloClassicMacUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffaloClassicMacUnityProfile>.NativeClassPtr);
			BuffaloClassicMacUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffaloClassicMacUnityProfile>.NativeClassPtr, 100665450);
			BuffaloClassicMacUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffaloClassicMacUnityProfile>.NativeClassPtr, 100665451);
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x0003FB5C File Offset: 0x0003DD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 831073, XrefRangeEnd = 831190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuffaloClassicMacUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x0003FB98 File Offset: 0x0003DD98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 831190, XrefRangeEnd = 831194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuffaloClassicMacUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffaloClassicMacUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffaloClassicMacUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x00006C32 File Offset: 0x00004E32
		public BuffaloClassicMacUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
