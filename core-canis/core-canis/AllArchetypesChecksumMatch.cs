using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

// Token: 0x0200001C RID: 28
public class AllArchetypesChecksumMatch : NetworkMessageEvent
{
	// Token: 0x060002E4 RID: 740 RVA: 0x00003400 File Offset: 0x00001600
	// Note: this type is marked as 'beforefieldinit'.
	static AllArchetypesChecksumMatch()
	{
		Il2CppClassPointerStore<AllArchetypesChecksumMatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "AllArchetypesChecksumMatch");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllArchetypesChecksumMatch>.NativeClassPtr);
		AllArchetypesChecksumMatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllArchetypesChecksumMatch>.NativeClassPtr, 100663675);
	}

	// Token: 0x060002E5 RID: 741 RVA: 0x0001DAC4 File Offset: 0x0001BCC4
	[CallerCount(114)]
	[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AllArchetypesChecksumMatch()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllArchetypesChecksumMatch>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllArchetypesChecksumMatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002E6 RID: 742 RVA: 0x00003439 File Offset: 0x00001639
	public AllArchetypesChecksumMatch(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000213 RID: 531
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
