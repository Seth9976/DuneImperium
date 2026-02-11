using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Networking.selection.messages;

// Token: 0x02000039 RID: 57
public class MulliganChoiceRequired : SelectionMessage
{
	// Token: 0x060004A9 RID: 1193 RVA: 0x00003BC9 File Offset: 0x00001DC9
	// Note: this type is marked as 'beforefieldinit'.
	static MulliganChoiceRequired()
	{
		Il2CppClassPointerStore<MulliganChoiceRequired>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "MulliganChoiceRequired");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MulliganChoiceRequired>.NativeClassPtr);
		MulliganChoiceRequired.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulliganChoiceRequired>.NativeClassPtr, 100663975);
	}

	// Token: 0x060004AA RID: 1194 RVA: 0x00025C6C File Offset: 0x00023E6C
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 542958, RefRangeEnd = 542962, XrefRangeStart = 542958, XrefRangeEnd = 542962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MulliganChoiceRequired()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulliganChoiceRequired>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulliganChoiceRequired.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004AB RID: 1195 RVA: 0x00003C02 File Offset: 0x00001E02
	public MulliganChoiceRequired(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000367 RID: 871
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
