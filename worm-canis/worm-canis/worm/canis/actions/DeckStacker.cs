using System;
using Canis;
using Canis.actions;
using canis.archetypes;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x02000234 RID: 564
	public class DeckStacker : global::Canis.actions.Action
	{
		// Token: 0x060018A7 RID: 6311 RVA: 0x000B8E18 File Offset: 0x000B7018
		// Note: this type is marked as 'beforefieldinit'.
		static DeckStacker()
		{
			Il2CppClassPointerStore<DeckStacker>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "DeckStacker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeckStacker>.NativeClassPtr);
			DeckStacker.NativeFieldInfoPtr_archetypeIDList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckStacker>.NativeClassPtr, "archetypeIDList");
			DeckStacker.NativeMethodInfoPtr__ctor_Public_Void_Match_List_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckStacker>.NativeClassPtr, 100667599);
			DeckStacker.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckStacker>.NativeClassPtr, 100667600);
			DeckStacker.NativeMethodInfoPtr_Stack_Public_Static_Void_WormPlayArea_List_1_ArchetypeID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckStacker>.NativeClassPtr, 100667601);
			DeckStacker.NativeMethodInfoPtr_StackTechTiles_Public_Static_List_1_Archetype_List_1_Archetype_List_1_List_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckStacker>.NativeClassPtr, 100667602);
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x000B8EAC File Offset: 0x000B70AC
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 133020, RefRangeEnd = 133047, XrefRangeStart = 133018, XrefRangeEnd = 133020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeckStacker(Match m, List<ArchetypeID> archetypeIDList)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeckStacker>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(archetypeIDList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckStacker.NativeMethodInfoPtr__ctor_Public_Void_Match_List_1_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x000B8F0C File Offset: 0x000B710C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133047, XrefRangeEnd = 133053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeckStacker.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x000B8F58 File Offset: 0x000B7158
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 133079, RefRangeEnd = 133087, XrefRangeStart = 133053, XrefRangeEnd = 133079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Stack(WormPlayArea wpa, List<ArchetypeID> archetypeIDList, int offset = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wpa);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(archetypeIDList);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckStacker.NativeMethodInfoPtr_Stack_Public_Static_Void_WormPlayArea_List_1_ArchetypeID_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x000B8FB0 File Offset: 0x000B71B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 133167, RefRangeEnd = 133168, XrefRangeStart = 133087, XrefRangeEnd = 133167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Archetype> StackTechTiles(List<Archetype> allArchetypes, List<List<ArchetypeID>> stacks)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(allArchetypes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stacks);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckStacker.NativeMethodInfoPtr_StackTechTiles_Public_Static_List_1_Archetype_List_1_Archetype_List_1_List_1_ArchetypeID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Archetype>>(intPtr3) : null;
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x0000AA03 File Offset: 0x00008C03
		public DeckStacker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x060018AD RID: 6317 RVA: 0x000B9008 File Offset: 0x000B7208
		// (set) Token: 0x060018AE RID: 6318 RVA: 0x0000AA0C File Offset: 0x00008C0C
		public unsafe List<ArchetypeID> archetypeIDList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckStacker.NativeFieldInfoPtr_archetypeIDList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckStacker.NativeFieldInfoPtr_archetypeIDList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F3F RID: 3903
		private static readonly IntPtr NativeFieldInfoPtr_archetypeIDList;

		// Token: 0x04000F40 RID: 3904
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_List_1_ArchetypeID_0;

		// Token: 0x04000F41 RID: 3905
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000F42 RID: 3906
		private static readonly IntPtr NativeMethodInfoPtr_Stack_Public_Static_Void_WormPlayArea_List_1_ArchetypeID_Int32_0;

		// Token: 0x04000F43 RID: 3907
		private static readonly IntPtr NativeMethodInfoPtr_StackTechTiles_Public_Static_List_1_Archetype_List_1_Archetype_List_1_List_1_ArchetypeID_0;

		// Token: 0x02000665 RID: 1637
		[ObfuscatedName("worm.canis.actions.DeckStacker+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600539A RID: 21402 RVA: 0x001B400C File Offset: 0x001B220C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DeckStacker.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeckStacker>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeckStacker.__c>.NativeClassPtr);
				DeckStacker.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckStacker.__c>.NativeClassPtr, "<>9");
				DeckStacker.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckStacker.__c>.NativeClassPtr, "<>9__4_0");
				DeckStacker.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckStacker.__c>.NativeClassPtr, 100667604);
				DeckStacker.__c.NativeMethodInfoPtr__StackTechTiles_b__4_0_Internal_ArchetypeID_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckStacker.__c>.NativeClassPtr, 100667605);
			}

			// Token: 0x0600539B RID: 21403 RVA: 0x001B4088 File Offset: 0x001B2288
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeckStacker.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckStacker.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600539C RID: 21404 RVA: 0x001B40C4 File Offset: 0x001B22C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeID _StackTechTiles_b__4_0(Archetype _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckStacker.__c.NativeMethodInfoPtr__StackTechTiles_b__4_0_Internal_ArchetypeID_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
				}
			}

			// Token: 0x0600539D RID: 21405 RVA: 0x0001D59F File Offset: 0x0001B79F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014D0 RID: 5328
			// (get) Token: 0x0600539E RID: 21406 RVA: 0x001B4114 File Offset: 0x001B2314
			// (set) Token: 0x0600539F RID: 21407 RVA: 0x0001D5A8 File Offset: 0x0001B7A8
			public unsafe static DeckStacker.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeckStacker.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeckStacker.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeckStacker.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014D1 RID: 5329
			// (get) Token: 0x060053A0 RID: 21408 RVA: 0x001B413C File Offset: 0x001B233C
			// (set) Token: 0x060053A1 RID: 21409 RVA: 0x0001D5BA File Offset: 0x0001B7BA
			public unsafe static Func<Archetype, ArchetypeID> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeckStacker.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Archetype, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeckStacker.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040036B9 RID: 14009
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040036BA RID: 14010
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x040036BB RID: 14011
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040036BC RID: 14012
			private static readonly IntPtr NativeMethodInfoPtr__StackTechTiles_b__4_0_Internal_ArchetypeID_Archetype_0;
		}

		// Token: 0x02000666 RID: 1638
		[ObfuscatedName("worm.canis.actions.DeckStacker+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x060053A2 RID: 21410 RVA: 0x001B4164 File Offset: 0x001B2364
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<DeckStacker.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeckStacker>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeckStacker.__c__DisplayClass3_0>.NativeClassPtr);
				DeckStacker.__c__DisplayClass3_0.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckStacker.__c__DisplayClass3_0>.NativeClassPtr, "archID");
				DeckStacker.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckStacker.__c__DisplayClass3_0>.NativeClassPtr, 100667606);
				DeckStacker.__c__DisplayClass3_0.NativeMethodInfoPtr__Stack_b__0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckStacker.__c__DisplayClass3_0>.NativeClassPtr, 100667607);
			}

			// Token: 0x060053A3 RID: 21411 RVA: 0x001B41CC File Offset: 0x001B23CC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeckStacker.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckStacker.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053A4 RID: 21412 RVA: 0x001B4208 File Offset: 0x001B2408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132961, XrefRangeEnd = 132966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Stack_b__0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckStacker.__c__DisplayClass3_0.NativeMethodInfoPtr__Stack_b__0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060053A5 RID: 21413 RVA: 0x0001D5CC File Offset: 0x0001B7CC
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014D2 RID: 5330
			// (get) Token: 0x060053A6 RID: 21414 RVA: 0x001B4258 File Offset: 0x001B2458
			// (set) Token: 0x060053A7 RID: 21415 RVA: 0x0001D5D5 File Offset: 0x0001B7D5
			public unsafe ArchetypeID archID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckStacker.__c__DisplayClass3_0.NativeFieldInfoPtr_archID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckStacker.__c__DisplayClass3_0.NativeFieldInfoPtr_archID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040036BD RID: 14013
			private static readonly IntPtr NativeFieldInfoPtr_archID;

			// Token: 0x040036BE RID: 14014
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040036BF RID: 14015
			private static readonly IntPtr NativeMethodInfoPtr__Stack_b__0_Internal_Boolean_Entity_0;
		}

		// Token: 0x02000667 RID: 1639
		[ObfuscatedName("worm.canis.actions.DeckStacker+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x060053A8 RID: 21416 RVA: 0x001B4288 File Offset: 0x001B2488
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<DeckStacker.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeckStacker>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeckStacker.__c__DisplayClass4_0>.NativeClassPtr);
				DeckStacker.__c__DisplayClass4_0.NativeFieldInfoPtr_stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckStacker.__c__DisplayClass4_0>.NativeClassPtr, "stacks");
				DeckStacker.__c__DisplayClass4_0.NativeFieldInfoPtr_allArchetypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckStacker.__c__DisplayClass4_0>.NativeClassPtr, "allArchetypes");
				DeckStacker.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckStacker.__c__DisplayClass4_0>.NativeClassPtr, 100667608);
				DeckStacker.__c__DisplayClass4_0.NativeMethodInfoPtr__StackTechTiles_b__1_Internal_Boolean_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckStacker.__c__DisplayClass4_0>.NativeClassPtr, 100667609);
				DeckStacker.__c__DisplayClass4_0.NativeMethodInfoPtr__StackTechTiles_b__2_Internal_Archetype_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckStacker.__c__DisplayClass4_0>.NativeClassPtr, 100667610);
			}

			// Token: 0x060053A9 RID: 21417 RVA: 0x001B4318 File Offset: 0x001B2518
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeckStacker.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckStacker.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053AA RID: 21418 RVA: 0x001B4354 File Offset: 0x001B2554
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132966, XrefRangeEnd = 132981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StackTechTiles_b__1(ArchetypeID _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckStacker.__c__DisplayClass4_0.NativeMethodInfoPtr__StackTechTiles_b__1_Internal_Boolean_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060053AB RID: 21419 RVA: 0x001B43A4 File Offset: 0x001B25A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132981, XrefRangeEnd = 132996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Archetype _StackTechTiles_b__2(ArchetypeID archID)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(archID);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckStacker.__c__DisplayClass4_0.NativeMethodInfoPtr__StackTechTiles_b__2_Internal_Archetype_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr3) : null;
				}
			}

			// Token: 0x060053AC RID: 21420 RVA: 0x0001D5F4 File Offset: 0x0001B7F4
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014D3 RID: 5331
			// (get) Token: 0x060053AD RID: 21421 RVA: 0x001B43F4 File Offset: 0x001B25F4
			// (set) Token: 0x060053AE RID: 21422 RVA: 0x0001D5FD File Offset: 0x0001B7FD
			public unsafe List<List<ArchetypeID>> stacks
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckStacker.__c__DisplayClass4_0.NativeFieldInfoPtr_stacks);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<List<ArchetypeID>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckStacker.__c__DisplayClass4_0.NativeFieldInfoPtr_stacks), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014D4 RID: 5332
			// (get) Token: 0x060053AF RID: 21423 RVA: 0x001B4424 File Offset: 0x001B2624
			// (set) Token: 0x060053B0 RID: 21424 RVA: 0x0001D61C File Offset: 0x0001B81C
			public unsafe List<Archetype> allArchetypes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckStacker.__c__DisplayClass4_0.NativeFieldInfoPtr_allArchetypes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Archetype>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckStacker.__c__DisplayClass4_0.NativeFieldInfoPtr_allArchetypes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040036C0 RID: 14016
			private static readonly IntPtr NativeFieldInfoPtr_stacks;

			// Token: 0x040036C1 RID: 14017
			private static readonly IntPtr NativeFieldInfoPtr_allArchetypes;

			// Token: 0x040036C2 RID: 14018
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040036C3 RID: 14019
			private static readonly IntPtr NativeMethodInfoPtr__StackTechTiles_b__1_Internal_Boolean_ArchetypeID_0;

			// Token: 0x040036C4 RID: 14020
			private static readonly IntPtr NativeMethodInfoPtr__StackTechTiles_b__2_Internal_Archetype_ArchetypeID_0;
		}

		// Token: 0x02000668 RID: 1640
		[ObfuscatedName("worm.canis.actions.DeckStacker+<>c__DisplayClass4_1")]
		public sealed class __c__DisplayClass4_1 : Object
		{
			// Token: 0x060053B1 RID: 21425 RVA: 0x001B4454 File Offset: 0x001B2654
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_1()
			{
				Il2CppClassPointerStore<DeckStacker.__c__DisplayClass4_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeckStacker>.NativeClassPtr, "<>c__DisplayClass4_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeckStacker.__c__DisplayClass4_1>.NativeClassPtr);
				DeckStacker.__c__DisplayClass4_1.NativeFieldInfoPtr__ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckStacker.__c__DisplayClass4_1>.NativeClassPtr, "_");
				DeckStacker.__c__DisplayClass4_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckStacker.__c__DisplayClass4_1>.NativeClassPtr, 100667611);
				DeckStacker.__c__DisplayClass4_1.NativeMethodInfoPtr__StackTechTiles_b__3_Internal_Boolean_List_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckStacker.__c__DisplayClass4_1>.NativeClassPtr, 100667612);
			}

			// Token: 0x060053B2 RID: 21426 RVA: 0x001B44BC File Offset: 0x001B26BC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeckStacker.__c__DisplayClass4_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckStacker.__c__DisplayClass4_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053B3 RID: 21427 RVA: 0x001B44F8 File Offset: 0x001B26F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132996, XrefRangeEnd = 133000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StackTechTiles_b__3(List<ArchetypeID> stack)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stack);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckStacker.__c__DisplayClass4_1.NativeMethodInfoPtr__StackTechTiles_b__3_Internal_Boolean_List_1_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060053B4 RID: 21428 RVA: 0x0001D63B File Offset: 0x0001B83B
			public __c__DisplayClass4_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014D5 RID: 5333
			// (get) Token: 0x060053B5 RID: 21429 RVA: 0x001B4548 File Offset: 0x001B2748
			// (set) Token: 0x060053B6 RID: 21430 RVA: 0x0001D644 File Offset: 0x0001B844
			public unsafe ArchetypeID _
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckStacker.__c__DisplayClass4_1.NativeFieldInfoPtr__);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckStacker.__c__DisplayClass4_1.NativeFieldInfoPtr__), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040036C5 RID: 14021
			private static readonly IntPtr NativeFieldInfoPtr__;

			// Token: 0x040036C6 RID: 14022
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040036C7 RID: 14023
			private static readonly IntPtr NativeMethodInfoPtr__StackTechTiles_b__3_Internal_Boolean_List_1_ArchetypeID_0;
		}

		// Token: 0x02000669 RID: 1641
		[ObfuscatedName("worm.canis.actions.DeckStacker+<>c__DisplayClass4_2")]
		public sealed class __c__DisplayClass4_2 : Object
		{
			// Token: 0x060053B7 RID: 21431 RVA: 0x001B4578 File Offset: 0x001B2778
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_2()
			{
				Il2CppClassPointerStore<DeckStacker.__c__DisplayClass4_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeckStacker>.NativeClassPtr, "<>c__DisplayClass4_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeckStacker.__c__DisplayClass4_2>.NativeClassPtr);
				DeckStacker.__c__DisplayClass4_2.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckStacker.__c__DisplayClass4_2>.NativeClassPtr, "archID");
				DeckStacker.__c__DisplayClass4_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckStacker.__c__DisplayClass4_2>.NativeClassPtr, 100667613);
				DeckStacker.__c__DisplayClass4_2.NativeMethodInfoPtr__StackTechTiles_b__4_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckStacker.__c__DisplayClass4_2>.NativeClassPtr, 100667614);
			}

			// Token: 0x060053B8 RID: 21432 RVA: 0x001B45E0 File Offset: 0x001B27E0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_2()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeckStacker.__c__DisplayClass4_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckStacker.__c__DisplayClass4_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053B9 RID: 21433 RVA: 0x001B461C File Offset: 0x001B281C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133000, XrefRangeEnd = 133005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StackTechTiles_b__4(Archetype a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckStacker.__c__DisplayClass4_2.NativeMethodInfoPtr__StackTechTiles_b__4_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060053BA RID: 21434 RVA: 0x0001D663 File Offset: 0x0001B863
			public __c__DisplayClass4_2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014D6 RID: 5334
			// (get) Token: 0x060053BB RID: 21435 RVA: 0x001B466C File Offset: 0x001B286C
			// (set) Token: 0x060053BC RID: 21436 RVA: 0x0001D66C File Offset: 0x0001B86C
			public unsafe ArchetypeID archID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckStacker.__c__DisplayClass4_2.NativeFieldInfoPtr_archID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckStacker.__c__DisplayClass4_2.NativeFieldInfoPtr_archID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040036C8 RID: 14024
			private static readonly IntPtr NativeFieldInfoPtr_archID;

			// Token: 0x040036C9 RID: 14025
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040036CA RID: 14026
			private static readonly IntPtr NativeMethodInfoPtr__StackTechTiles_b__4_Internal_Boolean_Archetype_0;
		}

		// Token: 0x0200066A RID: 1642
		[ObfuscatedName("worm.canis.actions.DeckStacker+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x060053BD RID: 21437 RVA: 0x001B469C File Offset: 0x001B289C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<DeckStacker._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeckStacker>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeckStacker._execute_d__2>.NativeClassPtr);
				DeckStacker._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckStacker._execute_d__2>.NativeClassPtr, "<>1__state");
				DeckStacker._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckStacker._execute_d__2>.NativeClassPtr, "<>2__current");
				DeckStacker._execute_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckStacker._execute_d__2>.NativeClassPtr, "<>l__initialThreadId");
				DeckStacker._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckStacker._execute_d__2>.NativeClassPtr, "<>4__this");
				DeckStacker._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckStacker._execute_d__2>.NativeClassPtr, 100667615);
				DeckStacker._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckStacker._execute_d__2>.NativeClassPtr, 100667616);
				DeckStacker._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckStacker._execute_d__2>.NativeClassPtr, 100667617);
				DeckStacker._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckStacker._execute_d__2>.NativeClassPtr, 100667618);
				DeckStacker._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckStacker._execute_d__2>.NativeClassPtr, 100667619);
				DeckStacker._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckStacker._execute_d__2>.NativeClassPtr, 100667620);
				DeckStacker._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckStacker._execute_d__2>.NativeClassPtr, 100667621);
				DeckStacker._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckStacker._execute_d__2>.NativeClassPtr, 100667622);
			}

			// Token: 0x060053BE RID: 21438 RVA: 0x001B47B8 File Offset: 0x001B29B8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeckStacker._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckStacker._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053BF RID: 21439 RVA: 0x001B4800 File Offset: 0x001B2A00
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckStacker._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053C0 RID: 21440 RVA: 0x001B4834 File Offset: 0x001B2A34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133005, XrefRangeEnd = 133011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckStacker._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170014DB RID: 5339
			// (get) Token: 0x060053C1 RID: 21441 RVA: 0x001B4870 File Offset: 0x001B2A70
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckStacker._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060053C2 RID: 21442 RVA: 0x001B48B0 File Offset: 0x001B2AB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133011, XrefRangeEnd = 133016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckStacker._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170014DC RID: 5340
			// (get) Token: 0x060053C3 RID: 21443 RVA: 0x001B48E4 File Offset: 0x001B2AE4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckStacker._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060053C4 RID: 21444 RVA: 0x001B4924 File Offset: 0x001B2B24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133016, XrefRangeEnd = 133018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckStacker._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060053C5 RID: 21445 RVA: 0x001B4964 File Offset: 0x001B2B64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckStacker._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060053C6 RID: 21446 RVA: 0x0001D68B File Offset: 0x0001B88B
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014D7 RID: 5335
			// (get) Token: 0x060053C7 RID: 21447 RVA: 0x001B49A4 File Offset: 0x001B2BA4
			// (set) Token: 0x060053C8 RID: 21448 RVA: 0x0001D694 File Offset: 0x0001B894
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckStacker._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckStacker._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170014D8 RID: 5336
			// (get) Token: 0x060053C9 RID: 21449 RVA: 0x001B49CC File Offset: 0x001B2BCC
			// (set) Token: 0x060053CA RID: 21450 RVA: 0x0001D6AF File Offset: 0x0001B8AF
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckStacker._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckStacker._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014D9 RID: 5337
			// (get) Token: 0x060053CB RID: 21451 RVA: 0x001B49FC File Offset: 0x001B2BFC
			// (set) Token: 0x060053CC RID: 21452 RVA: 0x0001D6CE File Offset: 0x0001B8CE
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckStacker._execute_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckStacker._execute_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170014DA RID: 5338
			// (get) Token: 0x060053CD RID: 21453 RVA: 0x001B4A24 File Offset: 0x001B2C24
			// (set) Token: 0x060053CE RID: 21454 RVA: 0x0001D6E9 File Offset: 0x0001B8E9
			public unsafe DeckStacker __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckStacker._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeckStacker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckStacker._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040036CB RID: 14027
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040036CC RID: 14028
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040036CD RID: 14029
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040036CE RID: 14030
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040036CF RID: 14031
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040036D0 RID: 14032
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040036D1 RID: 14033
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040036D2 RID: 14034
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040036D3 RID: 14035
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040036D4 RID: 14036
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040036D5 RID: 14037
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040036D6 RID: 14038
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
