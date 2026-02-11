using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x0200001B RID: 27
public class WormAlwaysClearUndoRenderer : MonoBehaviour
{
	// Token: 0x06000104 RID: 260 RVA: 0x0001BE3C File Offset: 0x0001A03C
	// Note: this type is marked as 'beforefieldinit'.
	static WormAlwaysClearUndoRenderer()
	{
		Il2CppClassPointerStore<WormAlwaysClearUndoRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormAlwaysClearUndoRenderer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAlwaysClearUndoRenderer>.NativeClassPtr);
		WormAlwaysClearUndoRenderer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAlwaysClearUndoRenderer>.NativeClassPtr, 100663444);
		WormAlwaysClearUndoRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAlwaysClearUndoRenderer>.NativeClassPtr, 100663445);
	}

	// Token: 0x06000105 RID: 261 RVA: 0x0001BE94 File Offset: 0x0001A094
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687736, XrefRangeEnd = 687739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAlwaysClearUndoRenderer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000106 RID: 262 RVA: 0x0001BEC8 File Offset: 0x0001A0C8
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormAlwaysClearUndoRenderer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAlwaysClearUndoRenderer>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAlwaysClearUndoRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000107 RID: 263 RVA: 0x000027EC File Offset: 0x000009EC
	public WormAlwaysClearUndoRenderer(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x0400009B RID: 155
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x0400009C RID: 156
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
