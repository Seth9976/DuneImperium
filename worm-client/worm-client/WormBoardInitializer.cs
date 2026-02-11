using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x0200000B RID: 11
public class WormBoardInitializer : MonoBehaviour
{
	// Token: 0x0600003F RID: 63 RVA: 0x00019758 File Offset: 0x00017958
	// Note: this type is marked as 'beforefieldinit'.
	static WormBoardInitializer()
	{
		Il2CppClassPointerStore<WormBoardInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormBoardInitializer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormBoardInitializer>.NativeClassPtr);
		WormBoardInitializer.NativeMethodInfoPtr_Event_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoardInitializer>.NativeClassPtr, 100663336);
		WormBoardInitializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoardInitializer>.NativeClassPtr, 100663337);
	}

	// Token: 0x06000040 RID: 64 RVA: 0x000197B0 File Offset: 0x000179B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687095, XrefRangeEnd = 687107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoardInitializer.NativeMethodInfoPtr_Event_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000041 RID: 65 RVA: 0x000197E4 File Offset: 0x000179E4
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormBoardInitializer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormBoardInitializer>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoardInitializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000042 RID: 66 RVA: 0x000021E6 File Offset: 0x000003E6
	public WormBoardInitializer(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000023 RID: 35
	private static readonly IntPtr NativeMethodInfoPtr_Event_Initialize_Public_Void_0;

	// Token: 0x04000024 RID: 36
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
