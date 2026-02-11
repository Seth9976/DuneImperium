using System;
using Canis.utils.ids;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x02000021 RID: 33
public class WormConflictRevealedPrompt : DismissablePrompt
{
	// Token: 0x06000165 RID: 357 RVA: 0x0001D37C File Offset: 0x0001B57C
	// Note: this type is marked as 'beforefieldinit'.
	static WormConflictRevealedPrompt()
	{
		Il2CppClassPointerStore<WormConflictRevealedPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormConflictRevealedPrompt");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictRevealedPrompt>.NativeClassPtr);
		WormConflictRevealedPrompt.NativeFieldInfoPtr__archID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictRevealedPrompt>.NativeClassPtr, "<archID>k__BackingField");
		WormConflictRevealedPrompt.NativeMethodInfoPtr_get_archID_Public_get_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictRevealedPrompt>.NativeClassPtr, 100663518);
		WormConflictRevealedPrompt.NativeMethodInfoPtr_set_archID_Private_set_Void_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictRevealedPrompt>.NativeClassPtr, 100663519);
		WormConflictRevealedPrompt.NativeMethodInfoPtr__ctor_Public_Void_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictRevealedPrompt>.NativeClassPtr, 100663520);
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x06000166 RID: 358 RVA: 0x0001D3FC File Offset: 0x0001B5FC
	// (set) Token: 0x06000167 RID: 359 RVA: 0x0001D43C File Offset: 0x0001B63C
	public unsafe ArchetypeID archID
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictRevealedPrompt.NativeMethodInfoPtr_get_archID_Public_get_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictRevealedPrompt.NativeMethodInfoPtr_set_archID_Private_set_Void_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x06000168 RID: 360 RVA: 0x0001D480 File Offset: 0x0001B680
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 502457, RefRangeEnd = 502462, XrefRangeStart = 502457, XrefRangeEnd = 502462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormConflictRevealedPrompt(ArchetypeID archID)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictRevealedPrompt>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(archID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictRevealedPrompt.NativeMethodInfoPtr__ctor_Public_Void_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000169 RID: 361 RVA: 0x00002A64 File Offset: 0x00000C64
	public WormConflictRevealedPrompt(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x0600016A RID: 362 RVA: 0x0001D4CC File Offset: 0x0001B6CC
	// (set) Token: 0x0600016B RID: 363 RVA: 0x00002A6D File Offset: 0x00000C6D
	public unsafe ArchetypeID _archID_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictRevealedPrompt.NativeFieldInfoPtr__archID_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictRevealedPrompt.NativeFieldInfoPtr__archID_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040000DC RID: 220
	private static readonly IntPtr NativeFieldInfoPtr__archID_k__BackingField;

	// Token: 0x040000DD RID: 221
	private static readonly IntPtr NativeMethodInfoPtr_get_archID_Public_get_ArchetypeID_0;

	// Token: 0x040000DE RID: 222
	private static readonly IntPtr NativeMethodInfoPtr_set_archID_Private_set_Void_ArchetypeID_0;

	// Token: 0x040000DF RID: 223
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArchetypeID_0;
}
