using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001F4 RID: 500
	public class NatecGenesisP44WindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x06001106 RID: 4358 RVA: 0x00043584 File Offset: 0x00041784
		// Note: this type is marked as 'beforefieldinit'.
		static NatecGenesisP44WindowsUnityProfile()
		{
			Il2CppClassPointerStore<NatecGenesisP44WindowsUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "NatecGenesisP44WindowsUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NatecGenesisP44WindowsUnityProfile>.NativeClassPtr);
			NatecGenesisP44WindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NatecGenesisP44WindowsUnityProfile>.NativeClassPtr, 100665594);
			NatecGenesisP44WindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NatecGenesisP44WindowsUnityProfile>.NativeClassPtr, 100665595);
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x000435DC File Offset: 0x000417DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 845822, XrefRangeEnd = 846008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NatecGenesisP44WindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x00043618 File Offset: 0x00041818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 846008, XrefRangeEnd = 846012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NatecGenesisP44WindowsUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NatecGenesisP44WindowsUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NatecGenesisP44WindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x00006EBA File Offset: 0x000050BA
		public NatecGenesisP44WindowsUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
