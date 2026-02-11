using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

// Token: 0x02000009 RID: 9
public class DummyDBGGameResultsEntry : DBGGameResultsEntry
{
	// Token: 0x06000048 RID: 72 RVA: 0x000022C7 File Offset: 0x000004C7
	// Note: this type is marked as 'beforefieldinit'.
	static DummyDBGGameResultsEntry()
	{
		Il2CppClassPointerStore<DummyDBGGameResultsEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "", "DummyDBGGameResultsEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DummyDBGGameResultsEntry>.NativeClassPtr);
		DummyDBGGameResultsEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DummyDBGGameResultsEntry>.NativeClassPtr, 100663308);
	}

	// Token: 0x06000049 RID: 73 RVA: 0x0001A794 File Offset: 0x00018994
	[CallerCount(2676)]
	[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DummyDBGGameResultsEntry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DummyDBGGameResultsEntry>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DummyDBGGameResultsEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00002300 File Offset: 0x00000500
	public DummyDBGGameResultsEntry(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000023 RID: 35
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
