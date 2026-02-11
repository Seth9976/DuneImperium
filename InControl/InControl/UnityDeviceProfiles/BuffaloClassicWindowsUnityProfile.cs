using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001E1 RID: 481
	public class BuffaloClassicWindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x060010BA RID: 4282 RVA: 0x00042614 File Offset: 0x00040814
		// Note: this type is marked as 'beforefieldinit'.
		static BuffaloClassicWindowsUnityProfile()
		{
			Il2CppClassPointerStore<BuffaloClassicWindowsUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "BuffaloClassicWindowsUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffaloClassicWindowsUnityProfile>.NativeClassPtr);
			BuffaloClassicWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffaloClassicWindowsUnityProfile>.NativeClassPtr, 100665556);
			BuffaloClassicWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffaloClassicWindowsUnityProfile>.NativeClassPtr, 100665557);
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x0004266C File Offset: 0x0004086C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 842280, XrefRangeEnd = 842397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuffaloClassicWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x000426A8 File Offset: 0x000408A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 842397, XrefRangeEnd = 842401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuffaloClassicWindowsUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffaloClassicWindowsUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffaloClassicWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x00006E0F File Offset: 0x0000500F
		public BuffaloClassicWindowsUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D10 RID: 3344
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D11 RID: 3345
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
