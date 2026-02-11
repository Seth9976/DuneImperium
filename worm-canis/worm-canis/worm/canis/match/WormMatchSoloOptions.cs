using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.enums;

namespace worm.canis.match
{
	// Token: 0x02000019 RID: 25
	[Serializable]
	public class WormMatchSoloOptions : Object
	{
		// Token: 0x060001E3 RID: 483 RVA: 0x0007052C File Offset: 0x0006E72C
		// Note: this type is marked as 'beforefieldinit'.
		static WormMatchSoloOptions()
		{
			Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.match", "WormMatchSoloOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr);
			WormMatchSoloOptions.NativeFieldInfoPtr_ConflictDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, "ConflictDeck");
			WormMatchSoloOptions.NativeFieldInfoPtr_ConflictDeckOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, "ConflictDeckOrder");
			WormMatchSoloOptions.NativeFieldInfoPtr_ConflictRepeatLast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, "ConflictRepeatLast");
			WormMatchSoloOptions.NativeFieldInfoPtr_ConflictShuffleRepeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, "ConflictShuffleRepeat");
			WormMatchSoloOptions.NativeFieldInfoPtr_SecondConflictDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, "SecondConflictDeck");
			WormMatchSoloOptions.NativeFieldInfoPtr_SecondConflictDeckOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, "SecondConflictDeckOrder");
			WormMatchSoloOptions.NativeFieldInfoPtr_SecondConflictRepeatLast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, "SecondConflictRepeatLast");
			WormMatchSoloOptions.NativeFieldInfoPtr_SecondConflictShuffleRepeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, "SecondConflictShuffleRepeat");
			WormMatchSoloOptions.NativeFieldInfoPtr_ImperiumDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, "ImperiumDeck");
			WormMatchSoloOptions.NativeFieldInfoPtr_ImperiumDeckOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, "ImperiumDeckOrder");
			WormMatchSoloOptions.NativeFieldInfoPtr_ImperiumDeckExclusions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, "ImperiumDeckExclusions");
			WormMatchSoloOptions.NativeFieldInfoPtr_IntrigueDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, "IntrigueDeck");
			WormMatchSoloOptions.NativeFieldInfoPtr_IntrigueDeckOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, "IntrigueDeckOrder");
			WormMatchSoloOptions.NativeFieldInfoPtr_IntrigueDeckExclusions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, "IntrigueDeckExclusions");
			WormMatchSoloOptions.NativeFieldInfoPtr_Spaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, "Spaces");
			WormMatchSoloOptions.NativeFieldInfoPtr_HagalChurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, "HagalChurn");
			WormMatchSoloOptions.NativeFieldInfoPtr_HagalBrutalEscalation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, "HagalBrutalEscalation");
			WormMatchSoloOptions.NativeFieldInfoPtr_DoubleImperiumSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, "DoubleImperiumSets");
			WormMatchSoloOptions.NativeFieldInfoPtr_DoubleIntrigueSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, "DoubleIntrigueSets");
			WormMatchSoloOptions.NativeFieldInfoPtr_ExtraInfiltrateImperium = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, "ExtraInfiltrateImperium");
			WormMatchSoloOptions.NativeFieldInfoPtr_TechTileStack1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, "TechTileStack1");
			WormMatchSoloOptions.NativeFieldInfoPtr_TechTileStack2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, "TechTileStack2");
			WormMatchSoloOptions.NativeFieldInfoPtr_TechTileStack3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, "TechTileStack3");
			WormMatchSoloOptions.NativeFieldInfoPtr_TleilaxuDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, "TleilaxuDeck");
			WormMatchSoloOptions.NativeFieldInfoPtr_TleilaxuDeckOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, "TleilaxuDeckOrder");
			WormMatchSoloOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, 100663791);
			WormMatchSoloOptions.NativeMethodInfoPtr__ctor_Public_Void_WormMatchSoloOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, 100663792);
			WormMatchSoloOptions.NativeMethodInfoPtr_Clone_Public_WormMatchSoloOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr, 100663793);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0007078C File Offset: 0x0006E98C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 31809, RefRangeEnd = 31811, XrefRangeStart = 31796, XrefRangeEnd = 31809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormMatchSoloOptions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatchSoloOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000707C8 File Offset: 0x0006E9C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31905, RefRangeEnd = 31906, XrefRangeStart = 31811, XrefRangeEnd = 31905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormMatchSoloOptions(WormMatchSoloOptions other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatchSoloOptions>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatchSoloOptions.NativeMethodInfoPtr__ctor_Public_Void_WormMatchSoloOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00070814 File Offset: 0x0006EA14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31910, RefRangeEnd = 31911, XrefRangeStart = 31906, XrefRangeEnd = 31910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormMatchSoloOptions Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatchSoloOptions.NativeMethodInfoPtr_Clone_Public_WormMatchSoloOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormMatchSoloOptions>(intPtr3) : null;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002E40 File Offset: 0x00001040
		public WormMatchSoloOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00070854 File Offset: 0x0006EA54
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x00002E49 File Offset: 0x00001049
		public unsafe List<ArchetypeID> ConflictDeck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_ConflictDeck);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_ConflictDeck), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00070884 File Offset: 0x0006EA84
		// (set) Token: 0x060001EB RID: 491 RVA: 0x00002E68 File Offset: 0x00001068
		public unsafe List<ArchetypeID> ConflictDeckOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_ConflictDeckOrder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_ConflictDeckOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001EC RID: 492 RVA: 0x000708B4 File Offset: 0x0006EAB4
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00002E87 File Offset: 0x00001087
		public unsafe int ConflictRepeatLast
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_ConflictRepeatLast);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_ConflictRepeatLast)) = value;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001EE RID: 494 RVA: 0x000708DC File Offset: 0x0006EADC
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00002EA2 File Offset: 0x000010A2
		public unsafe bool ConflictShuffleRepeat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_ConflictShuffleRepeat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_ConflictShuffleRepeat)) = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00070904 File Offset: 0x0006EB04
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00002EBD File Offset: 0x000010BD
		public unsafe List<ArchetypeID> SecondConflictDeck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_SecondConflictDeck);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_SecondConflictDeck), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00070934 File Offset: 0x0006EB34
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00002EDC File Offset: 0x000010DC
		public unsafe List<ArchetypeID> SecondConflictDeckOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_SecondConflictDeckOrder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_SecondConflictDeckOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00070964 File Offset: 0x0006EB64
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00002EFB File Offset: 0x000010FB
		public unsafe int SecondConflictRepeatLast
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_SecondConflictRepeatLast);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_SecondConflictRepeatLast)) = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x0007098C File Offset: 0x0006EB8C
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00002F16 File Offset: 0x00001116
		public unsafe bool SecondConflictShuffleRepeat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_SecondConflictShuffleRepeat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_SecondConflictShuffleRepeat)) = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x000709B4 File Offset: 0x0006EBB4
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00002F31 File Offset: 0x00001131
		public unsafe List<ArchetypeID> ImperiumDeck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_ImperiumDeck);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_ImperiumDeck), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001FA RID: 506 RVA: 0x000709E4 File Offset: 0x0006EBE4
		// (set) Token: 0x060001FB RID: 507 RVA: 0x00002F50 File Offset: 0x00001150
		public unsafe List<ArchetypeID> ImperiumDeckOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_ImperiumDeckOrder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_ImperiumDeckOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00070A14 File Offset: 0x0006EC14
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00002F6F File Offset: 0x0000116F
		public unsafe List<ArchetypeID> ImperiumDeckExclusions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_ImperiumDeckExclusions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_ImperiumDeckExclusions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00070A44 File Offset: 0x0006EC44
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00002F8E File Offset: 0x0000118E
		public unsafe List<ArchetypeID> IntrigueDeck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_IntrigueDeck);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_IntrigueDeck), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00070A74 File Offset: 0x0006EC74
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00002FAD File Offset: 0x000011AD
		public unsafe List<ArchetypeID> IntrigueDeckOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_IntrigueDeckOrder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_IntrigueDeckOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00070AA4 File Offset: 0x0006ECA4
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00002FCC File Offset: 0x000011CC
		public unsafe List<ArchetypeID> IntrigueDeckExclusions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_IntrigueDeckExclusions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_IntrigueDeckExclusions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00070AD4 File Offset: 0x0006ECD4
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00002FEB File Offset: 0x000011EB
		public unsafe List<ArchetypeID> Spaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_Spaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_Spaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00070B04 File Offset: 0x0006ED04
		// (set) Token: 0x06000207 RID: 519 RVA: 0x0000300A File Offset: 0x0000120A
		public unsafe bool HagalChurn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_HagalChurn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_HagalChurn)) = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00070B2C File Offset: 0x0006ED2C
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00003025 File Offset: 0x00001225
		public unsafe bool HagalBrutalEscalation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_HagalBrutalEscalation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_HagalBrutalEscalation)) = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00070B54 File Offset: 0x0006ED54
		// (set) Token: 0x0600020B RID: 523 RVA: 0x00003040 File Offset: 0x00001240
		public unsafe List<Set> DoubleImperiumSets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_DoubleImperiumSets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Set>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_DoubleImperiumSets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00070B84 File Offset: 0x0006ED84
		// (set) Token: 0x0600020D RID: 525 RVA: 0x0000305F File Offset: 0x0000125F
		public unsafe List<Set> DoubleIntrigueSets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_DoubleIntrigueSets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Set>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_DoubleIntrigueSets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00070BB4 File Offset: 0x0006EDB4
		// (set) Token: 0x0600020F RID: 527 RVA: 0x0000307E File Offset: 0x0000127E
		public unsafe bool ExtraInfiltrateImperium
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_ExtraInfiltrateImperium);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_ExtraInfiltrateImperium)) = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00070BDC File Offset: 0x0006EDDC
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00003099 File Offset: 0x00001299
		public unsafe List<ArchetypeID> TechTileStack1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_TechTileStack1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_TechTileStack1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00070C0C File Offset: 0x0006EE0C
		// (set) Token: 0x06000213 RID: 531 RVA: 0x000030B8 File Offset: 0x000012B8
		public unsafe List<ArchetypeID> TechTileStack2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_TechTileStack2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_TechTileStack2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00070C3C File Offset: 0x0006EE3C
		// (set) Token: 0x06000215 RID: 533 RVA: 0x000030D7 File Offset: 0x000012D7
		public unsafe List<ArchetypeID> TechTileStack3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_TechTileStack3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_TechTileStack3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00070C6C File Offset: 0x0006EE6C
		// (set) Token: 0x06000217 RID: 535 RVA: 0x000030F6 File Offset: 0x000012F6
		public unsafe List<ArchetypeID> TleilaxuDeck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_TleilaxuDeck);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_TleilaxuDeck), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00070C9C File Offset: 0x0006EE9C
		// (set) Token: 0x06000219 RID: 537 RVA: 0x00003115 File Offset: 0x00001315
		public unsafe List<ArchetypeID> TleilaxuDeckOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_TleilaxuDeckOrder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchSoloOptions.NativeFieldInfoPtr_TleilaxuDeckOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeFieldInfoPtr_ConflictDeck;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeFieldInfoPtr_ConflictDeckOrder;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeFieldInfoPtr_ConflictRepeatLast;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeFieldInfoPtr_ConflictShuffleRepeat;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeFieldInfoPtr_SecondConflictDeck;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeFieldInfoPtr_SecondConflictDeckOrder;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeFieldInfoPtr_SecondConflictRepeatLast;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeFieldInfoPtr_SecondConflictShuffleRepeat;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeFieldInfoPtr_ImperiumDeck;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeFieldInfoPtr_ImperiumDeckOrder;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeFieldInfoPtr_ImperiumDeckExclusions;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeFieldInfoPtr_IntrigueDeck;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeFieldInfoPtr_IntrigueDeckOrder;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeFieldInfoPtr_IntrigueDeckExclusions;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeFieldInfoPtr_Spaces;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeFieldInfoPtr_HagalChurn;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeFieldInfoPtr_HagalBrutalEscalation;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeFieldInfoPtr_DoubleImperiumSets;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeFieldInfoPtr_DoubleIntrigueSets;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeFieldInfoPtr_ExtraInfiltrateImperium;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeFieldInfoPtr_TechTileStack1;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeFieldInfoPtr_TechTileStack2;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeFieldInfoPtr_TechTileStack3;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeFieldInfoPtr_TleilaxuDeck;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeFieldInfoPtr_TleilaxuDeckOrder;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatchSoloOptions_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_WormMatchSoloOptions_0;
	}
}
