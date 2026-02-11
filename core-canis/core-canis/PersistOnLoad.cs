using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x02000055 RID: 85
public sealed class PersistOnLoad : MonoBehaviour
{
	// Token: 0x06000652 RID: 1618 RVA: 0x0002D3E8 File Offset: 0x0002B5E8
	// Note: this type is marked as 'beforefieldinit'.
	static PersistOnLoad()
	{
		Il2CppClassPointerStore<PersistOnLoad>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "PersistOnLoad");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistOnLoad>.NativeClassPtr);
		PersistOnLoad.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistOnLoad>.NativeClassPtr, 100664260);
		PersistOnLoad.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistOnLoad>.NativeClassPtr, 100664261);
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x0002D440 File Offset: 0x0002B640
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859538, XrefRangeEnd = 859548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistOnLoad.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x0002D474 File Offset: 0x0002B674
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PersistOnLoad()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistOnLoad>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistOnLoad.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000655 RID: 1621 RVA: 0x0000414B File Offset: 0x0000234B
	public PersistOnLoad(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x040004C4 RID: 1220
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040004C5 RID: 1221
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
