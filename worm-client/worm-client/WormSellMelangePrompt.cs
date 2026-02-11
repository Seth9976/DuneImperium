using System;
using Canis.attributes;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

// Token: 0x02000022 RID: 34
public class WormSellMelangePrompt : ResolvablePrompt<int>
{
	// Token: 0x0600016C RID: 364 RVA: 0x0001D4FC File Offset: 0x0001B6FC
	// Note: this type is marked as 'beforefieldinit'.
	static WormSellMelangePrompt()
	{
		Il2CppClassPointerStore<WormSellMelangePrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormSellMelangePrompt");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSellMelangePrompt>.NativeClassPtr);
		WormSellMelangePrompt.NativeFieldInfoPtr__MaxSpice_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSellMelangePrompt>.NativeClassPtr, "<MaxSpice>k__BackingField");
		WormSellMelangePrompt.NativeMethodInfoPtr_get_MaxSpice_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSellMelangePrompt>.NativeClassPtr, 100663521);
		WormSellMelangePrompt.NativeMethodInfoPtr__ctor_Public_Void_IList_1_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSellMelangePrompt>.NativeClassPtr, 100663522);
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x0600016D RID: 365 RVA: 0x0001D568 File Offset: 0x0001B768
	public unsafe int MaxSpice
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSellMelangePrompt.NativeMethodInfoPtr_get_MaxSpice_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600016E RID: 366 RVA: 0x0001D5A4 File Offset: 0x0001B7A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688914, XrefRangeEnd = 688920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormSellMelangePrompt(IList<ReadOnlyAttributes> choices)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSellMelangePrompt>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(choices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSellMelangePrompt.NativeMethodInfoPtr__ctor_Public_Void_IList_1_ReadOnlyAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600016F RID: 367 RVA: 0x00002A8C File Offset: 0x00000C8C
	public WormSellMelangePrompt(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x06000170 RID: 368 RVA: 0x0001D5F0 File Offset: 0x0001B7F0
	// (set) Token: 0x06000171 RID: 369 RVA: 0x00002A95 File Offset: 0x00000C95
	public unsafe int _MaxSpice_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSellMelangePrompt.NativeFieldInfoPtr__MaxSpice_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSellMelangePrompt.NativeFieldInfoPtr__MaxSpice_k__BackingField)) = value;
		}
	}

	// Token: 0x040000E0 RID: 224
	private static readonly IntPtr NativeFieldInfoPtr__MaxSpice_k__BackingField;

	// Token: 0x040000E1 RID: 225
	private static readonly IntPtr NativeMethodInfoPtr_get_MaxSpice_Public_get_Int32_0;

	// Token: 0x040000E2 RID: 226
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IList_1_ReadOnlyAttributes_0;
}
