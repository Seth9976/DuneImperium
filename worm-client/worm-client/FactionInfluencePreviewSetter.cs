using System;
using boardgames.match.selection;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm;
using worm.canis.data.enums;
using worm.match.data;

// Token: 0x02000008 RID: 8
public class FactionInfluencePreviewSetter : Subscriber<WormInfluenceDeltaData>
{
	// Token: 0x06000024 RID: 36 RVA: 0x0001929C File Offset: 0x0001749C
	// Note: this type is marked as 'beforefieldinit'.
	static FactionInfluencePreviewSetter()
	{
		Il2CppClassPointerStore<FactionInfluencePreviewSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "FactionInfluencePreviewSetter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FactionInfluencePreviewSetter>.NativeClassPtr);
		FactionInfluencePreviewSetter.NativeFieldInfoPtr_view = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionInfluencePreviewSetter>.NativeClassPtr, "view");
		FactionInfluencePreviewSetter.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionInfluencePreviewSetter>.NativeClassPtr, "entities");
		FactionInfluencePreviewSetter.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionInfluencePreviewSetter>.NativeClassPtr, "selectionResponder");
		FactionInfluencePreviewSetter.NativeFieldInfoPtr_PreviewArrowParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionInfluencePreviewSetter>.NativeClassPtr, "PreviewArrowParam");
		FactionInfluencePreviewSetter.NativeFieldInfoPtr_PlayerColorParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionInfluencePreviewSetter>.NativeClassPtr, "PlayerColorParam");
		FactionInfluencePreviewSetter.NativeMethodInfoPtr_Event_SetPreview_Public_Void_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionInfluencePreviewSetter>.NativeClassPtr, 100663324);
		FactionInfluencePreviewSetter.NativeMethodInfoPtr_Event_ResetPreview_Public_Void_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionInfluencePreviewSetter>.NativeClassPtr, 100663325);
		FactionInfluencePreviewSetter.NativeMethodInfoPtr_Event_ResetAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionInfluencePreviewSetter>.NativeClassPtr, 100663326);
		FactionInfluencePreviewSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionInfluencePreviewSetter>.NativeClassPtr, 100663327);
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00019380 File Offset: 0x00017580
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 687032, RefRangeEnd = 687033, XrefRangeStart = 686938, XrefRangeEnd = 687032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_SetPreview(Factions faction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref faction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FactionInfluencePreviewSetter.NativeMethodInfoPtr_Event_SetPreview_Public_Void_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000026 RID: 38 RVA: 0x000193C0 File Offset: 0x000175C0
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 687062, RefRangeEnd = 687067, XrefRangeStart = 687033, XrefRangeEnd = 687062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_ResetPreview(Factions faction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref faction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FactionInfluencePreviewSetter.NativeMethodInfoPtr_Event_ResetPreview_Public_Void_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00019400 File Offset: 0x00017600
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 687071, RefRangeEnd = 687072, XrefRangeStart = 687067, XrefRangeEnd = 687071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_ResetAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FactionInfluencePreviewSetter.NativeMethodInfoPtr_Event_ResetAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00019434 File Offset: 0x00017634
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687072, XrefRangeEnd = 687075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FactionInfluencePreviewSetter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FactionInfluencePreviewSetter>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FactionInfluencePreviewSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002133 File Offset: 0x00000333
	public FactionInfluencePreviewSetter(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x0600002A RID: 42 RVA: 0x00019470 File Offset: 0x00017670
	// (set) Token: 0x0600002B RID: 43 RVA: 0x0000213C File Offset: 0x0000033C
	public unsafe WormAllFactionTracksEntityView view
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactionInfluencePreviewSetter.NativeFieldInfoPtr_view);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAllFactionTracksEntityView>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactionInfluencePreviewSetter.NativeFieldInfoPtr_view), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x0600002C RID: 44 RVA: 0x000194A0 File Offset: 0x000176A0
	// (set) Token: 0x0600002D RID: 45 RVA: 0x0000215B File Offset: 0x0000035B
	public unsafe WormEntities entities
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactionInfluencePreviewSetter.NativeFieldInfoPtr_entities);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntities>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactionInfluencePreviewSetter.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x0600002E RID: 46 RVA: 0x000194D0 File Offset: 0x000176D0
	// (set) Token: 0x0600002F RID: 47 RVA: 0x0000217A File Offset: 0x0000037A
	public unsafe DBGSelectionResponder selectionResponder
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactionInfluencePreviewSetter.NativeFieldInfoPtr_selectionResponder);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactionInfluencePreviewSetter.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000030 RID: 48 RVA: 0x00019500 File Offset: 0x00017700
	// (set) Token: 0x06000031 RID: 49 RVA: 0x00002199 File Offset: 0x00000399
	public unsafe static int PreviewArrowParam
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(FactionInfluencePreviewSetter.NativeFieldInfoPtr_PreviewArrowParam, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(FactionInfluencePreviewSetter.NativeFieldInfoPtr_PreviewArrowParam, (void*)(&value));
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000032 RID: 50 RVA: 0x0001951C File Offset: 0x0001771C
	// (set) Token: 0x06000033 RID: 51 RVA: 0x000021A7 File Offset: 0x000003A7
	public unsafe static int PlayerColorParam
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(FactionInfluencePreviewSetter.NativeFieldInfoPtr_PlayerColorParam, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(FactionInfluencePreviewSetter.NativeFieldInfoPtr_PlayerColorParam, (void*)(&value));
		}
	}

	// Token: 0x04000014 RID: 20
	private static readonly IntPtr NativeFieldInfoPtr_view;

	// Token: 0x04000015 RID: 21
	private static readonly IntPtr NativeFieldInfoPtr_entities;

	// Token: 0x04000016 RID: 22
	private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

	// Token: 0x04000017 RID: 23
	private static readonly IntPtr NativeFieldInfoPtr_PreviewArrowParam;

	// Token: 0x04000018 RID: 24
	private static readonly IntPtr NativeFieldInfoPtr_PlayerColorParam;

	// Token: 0x04000019 RID: 25
	private static readonly IntPtr NativeMethodInfoPtr_Event_SetPreview_Public_Void_Factions_0;

	// Token: 0x0400001A RID: 26
	private static readonly IntPtr NativeMethodInfoPtr_Event_ResetPreview_Public_Void_Factions_0;

	// Token: 0x0400001B RID: 27
	private static readonly IntPtr NativeMethodInfoPtr_Event_ResetAll_Public_Void_0;

	// Token: 0x0400001C RID: 28
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020002AC RID: 684
	[ObfuscatedName("FactionInfluencePreviewSetter+<>c__DisplayClass5_0")]
	public sealed class __c__DisplayClass5_0 : Object
	{
		// Token: 0x06001BE3 RID: 7139 RVA: 0x0006DE38 File Offset: 0x0006C038
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass5_0()
		{
			Il2CppClassPointerStore<FactionInfluencePreviewSetter.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FactionInfluencePreviewSetter>.NativeClassPtr, "<>c__DisplayClass5_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FactionInfluencePreviewSetter.__c__DisplayClass5_0>.NativeClassPtr);
			FactionInfluencePreviewSetter.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionInfluencePreviewSetter.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
			FactionInfluencePreviewSetter.__c__DisplayClass5_0.NativeFieldInfoPtr_faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionInfluencePreviewSetter.__c__DisplayClass5_0>.NativeClassPtr, "faction");
			FactionInfluencePreviewSetter.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionInfluencePreviewSetter.__c__DisplayClass5_0>.NativeClassPtr, 100663329);
			FactionInfluencePreviewSetter.__c__DisplayClass5_0.NativeMethodInfoPtr__Event_SetPreview_b__0_Internal_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionInfluencePreviewSetter.__c__DisplayClass5_0>.NativeClassPtr, 100663330);
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x0006DEB4 File Offset: 0x0006C0B4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass5_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FactionInfluencePreviewSetter.__c__DisplayClass5_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FactionInfluencePreviewSetter.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x0006DEF0 File Offset: 0x0006C0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686934, XrefRangeEnd = 686938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Event_SetPreview_b__0(EntityID s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FactionInfluencePreviewSetter.__c__DisplayClass5_0.NativeMethodInfoPtr__Event_SetPreview_b__0_Internal_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x000100D4 File Offset: 0x0000E2D4
		public __c__DisplayClass5_0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06001BE7 RID: 7143 RVA: 0x0006DF40 File Offset: 0x0006C140
		// (set) Token: 0x06001BE8 RID: 7144 RVA: 0x000100DD File Offset: 0x0000E2DD
		public unsafe FactionInfluencePreviewSetter __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactionInfluencePreviewSetter.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FactionInfluencePreviewSetter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactionInfluencePreviewSetter.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06001BE9 RID: 7145 RVA: 0x0006DF70 File Offset: 0x0006C170
		// (set) Token: 0x06001BEA RID: 7146 RVA: 0x000100FC File Offset: 0x0000E2FC
		public unsafe Factions faction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactionInfluencePreviewSetter.__c__DisplayClass5_0.NativeFieldInfoPtr_faction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactionInfluencePreviewSetter.__c__DisplayClass5_0.NativeFieldInfoPtr_faction)) = value;
			}
		}

		// Token: 0x0400101D RID: 4125
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400101E RID: 4126
		private static readonly IntPtr NativeFieldInfoPtr_faction;

		// Token: 0x0400101F RID: 4127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001020 RID: 4128
		private static readonly IntPtr NativeMethodInfoPtr__Event_SetPreview_b__0_Internal_Boolean_EntityID_0;
	}
}
