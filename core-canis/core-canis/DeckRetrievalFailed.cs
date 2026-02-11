using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

// Token: 0x0200001D RID: 29
public class DeckRetrievalFailed : NetworkMessageEvent
{
	// Token: 0x060002E7 RID: 743 RVA: 0x00003442 File Offset: 0x00001642
	// Note: this type is marked as 'beforefieldinit'.
	static DeckRetrievalFailed()
	{
		Il2CppClassPointerStore<DeckRetrievalFailed>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "DeckRetrievalFailed");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeckRetrievalFailed>.NativeClassPtr);
		DeckRetrievalFailed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckRetrievalFailed>.NativeClassPtr, 100663676);
	}

	// Token: 0x060002E8 RID: 744 RVA: 0x0001DB00 File Offset: 0x0001BD00
	[CallerCount(114)]
	[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DeckRetrievalFailed()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeckRetrievalFailed>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckRetrievalFailed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002E9 RID: 745 RVA: 0x0000347B File Offset: 0x0000167B
	public DeckRetrievalFailed(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000214 RID: 532
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
