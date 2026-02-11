using System;
using Canis.actions;
using canis.archetypes;
using Canis.attributes;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.actions.phases
{
	// Token: 0x020002BC RID: 700
	public class DraftDeckSetup : DeckSetupPhase
	{
		// Token: 0x06001CF9 RID: 7417 RVA: 0x000C9830 File Offset: 0x000C7A30
		// Note: this type is marked as 'beforefieldinit'.
		static DraftDeckSetup()
		{
			Il2CppClassPointerStore<DraftDeckSetup>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "DraftDeckSetup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DraftDeckSetup>.NativeClassPtr);
			DraftDeckSetup.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup>.NativeClassPtr, 100669463);
			DraftDeckSetup.NativeMethodInfoPtr__ctor_Public_Void_SerializedDeckSetupPhase_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup>.NativeClassPtr, 100669464);
			DraftDeckSetup.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_DeckSetupState_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup>.NativeClassPtr, 100669465);
			DraftDeckSetup.NativeMethodInfoPtr_get_ExcludedCards_Protected_Abstract_Virtual_New_get_List_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup>.NativeClassPtr, 100669466);
			DraftDeckSetup.NativeMethodInfoPtr_get_DraftRoundCosts_Protected_Abstract_Virtual_New_get_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup>.NativeClassPtr, 100669467);
			DraftDeckSetup.NativeMethodInfoPtr_get_AIDraftSets_Protected_Abstract_Virtual_New_get_List_1_List_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup>.NativeClassPtr, 100669468);
			DraftDeckSetup.NativeMethodInfoPtr_get_ValidArchetypes_Private_get_IEnumerable_1_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup>.NativeClassPtr, 100669469);
			DraftDeckSetup.NativeMethodInfoPtr_Selection_Protected_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup>.NativeClassPtr, 100669470);
			DraftDeckSetup.NativeMethodInfoPtr__get_ValidArchetypes_b__10_0_Private_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup>.NativeClassPtr, 100669471);
			DraftDeckSetup.NativeMethodInfoPtr__Selection_b__11_0_Private_Boolean_List_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup>.NativeClassPtr, 100669472);
			DraftDeckSetup.NativeMethodInfoPtr__Selection_b__11_1_Private_Boolean_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup>.NativeClassPtr, 100669473);
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x000C993C File Offset: 0x000C7B3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 155526, RefRangeEnd = 155528, XrefRangeStart = 155526, XrefRangeEnd = 155528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DraftDeckSetup(WormPlayer p, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DraftDeckSetup>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraftDeckSetup.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x000C999C File Offset: 0x000C7B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155851, XrefRangeEnd = 155852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DraftDeckSetup(SerializedDeckSetupPhase serialized, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DraftDeckSetup>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraftDeckSetup.NativeMethodInfoPtr__ctor_Public_Void_SerializedDeckSetupPhase_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x000C99FC File Offset: 0x000C7BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155852, XrefRangeEnd = 155859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<DeckSetupState> DetermineNextTypedState(Canis.actions.Action lastAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraftDeckSetup.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_DeckSetupState_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<DeckSetupState>(intPtr);
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06001CFD RID: 7421 RVA: 0x000C9A50 File Offset: 0x000C7C50
		public unsafe virtual List<ArchetypeID> ExcludedCards
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraftDeckSetup.NativeMethodInfoPtr_get_ExcludedCards_Protected_Abstract_Virtual_New_get_List_1_ArchetypeID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr3) : null;
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06001CFE RID: 7422 RVA: 0x000C9A9C File Offset: 0x000C7C9C
		public unsafe virtual Dictionary<int, int> DraftRoundCosts
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraftDeckSetup.NativeMethodInfoPtr_get_DraftRoundCosts_Protected_Abstract_Virtual_New_get_Dictionary_2_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06001CFF RID: 7423 RVA: 0x000C9AE8 File Offset: 0x000C7CE8
		public unsafe virtual List<List<ArchetypeID>> AIDraftSets
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraftDeckSetup.NativeMethodInfoPtr_get_AIDraftSets_Protected_Abstract_Virtual_New_get_List_1_List_1_ArchetypeID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<List<ArchetypeID>>>(intPtr3) : null;
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06001D00 RID: 7424 RVA: 0x000C9B34 File Offset: 0x000C7D34
		public unsafe IEnumerable<Archetype> ValidArchetypes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155859, XrefRangeEnd = 155869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraftDeckSetup.NativeMethodInfoPtr_get_ValidArchetypes_Private_get_IEnumerable_1_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Archetype>>(intPtr3) : null;
			}
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x000C9B74 File Offset: 0x000C7D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155869, XrefRangeEnd = 155875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Canis.actions.Action> Selection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraftDeckSetup.NativeMethodInfoPtr_Selection_Protected_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x000C9BC0 File Offset: 0x000C7DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155875, XrefRangeEnd = 155894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_ValidArchetypes_b__10_0(Archetype _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraftDeckSetup.NativeMethodInfoPtr__get_ValidArchetypes_b__10_0_Private_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x000C9C10 File Offset: 0x000C7E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155894, XrefRangeEnd = 155903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Selection_b__11_0(List<ArchetypeID> set)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(set);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraftDeckSetup.NativeMethodInfoPtr__Selection_b__11_0_Private_Boolean_List_1_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x000C9C60 File Offset: 0x000C7E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155903, XrefRangeEnd = 155919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Selection_b__11_1(ArchetypeID archID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraftDeckSetup.NativeMethodInfoPtr__Selection_b__11_1_Private_Boolean_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x0000C49A File Offset: 0x0000A69A
		public DraftDeckSetup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040011FE RID: 4606
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0;

		// Token: 0x040011FF RID: 4607
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedDeckSetupPhase_WormMatch_0;

		// Token: 0x04001200 RID: 4608
		private static readonly IntPtr NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_DeckSetupState_Action_0;

		// Token: 0x04001201 RID: 4609
		private static readonly IntPtr NativeMethodInfoPtr_get_ExcludedCards_Protected_Abstract_Virtual_New_get_List_1_ArchetypeID_0;

		// Token: 0x04001202 RID: 4610
		private static readonly IntPtr NativeMethodInfoPtr_get_DraftRoundCosts_Protected_Abstract_Virtual_New_get_Dictionary_2_Int32_Int32_0;

		// Token: 0x04001203 RID: 4611
		private static readonly IntPtr NativeMethodInfoPtr_get_AIDraftSets_Protected_Abstract_Virtual_New_get_List_1_List_1_ArchetypeID_0;

		// Token: 0x04001204 RID: 4612
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidArchetypes_Private_get_IEnumerable_1_Archetype_0;

		// Token: 0x04001205 RID: 4613
		private static readonly IntPtr NativeMethodInfoPtr_Selection_Protected_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04001206 RID: 4614
		private static readonly IntPtr NativeMethodInfoPtr__get_ValidArchetypes_b__10_0_Private_Boolean_Archetype_0;

		// Token: 0x04001207 RID: 4615
		private static readonly IntPtr NativeMethodInfoPtr__Selection_b__11_0_Private_Boolean_List_1_ArchetypeID_0;

		// Token: 0x04001208 RID: 4616
		private static readonly IntPtr NativeMethodInfoPtr__Selection_b__11_1_Private_Boolean_ArchetypeID_0;

		// Token: 0x02000723 RID: 1827
		[ObfuscatedName("worm.canis.actions.phases.DraftDeckSetup+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600644D RID: 25677 RVA: 0x001E57C4 File Offset: 0x001E39C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DraftDeckSetup.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DraftDeckSetup>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DraftDeckSetup.__c>.NativeClassPtr);
				DraftDeckSetup.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraftDeckSetup.__c>.NativeClassPtr, "<>9");
				DraftDeckSetup.__c.NativeFieldInfoPtr___9__11_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraftDeckSetup.__c>.NativeClassPtr, "<>9__11_5");
				DraftDeckSetup.__c.NativeFieldInfoPtr___9__11_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraftDeckSetup.__c>.NativeClassPtr, "<>9__11_6");
				DraftDeckSetup.__c.NativeFieldInfoPtr___9__11_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraftDeckSetup.__c>.NativeClassPtr, "<>9__11_7");
				DraftDeckSetup.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup.__c>.NativeClassPtr, 100669475);
				DraftDeckSetup.__c.NativeMethodInfoPtr__Selection_b__11_5_Internal_ArchetypeID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup.__c>.NativeClassPtr, 100669476);
				DraftDeckSetup.__c.NativeMethodInfoPtr__Selection_b__11_6_Internal_SerializableAttributes_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup.__c>.NativeClassPtr, 100669477);
				DraftDeckSetup.__c.NativeMethodInfoPtr__Selection_b__11_7_Internal_ArchetypeID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup.__c>.NativeClassPtr, 100669478);
			}

			// Token: 0x0600644E RID: 25678 RVA: 0x001E5890 File Offset: 0x001E3A90
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DraftDeckSetup.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraftDeckSetup.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600644F RID: 25679 RVA: 0x001E58CC File Offset: 0x001E3ACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeID _Selection_b__11_5(Entity card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraftDeckSetup.__c.NativeMethodInfoPtr__Selection_b__11_5_Internal_ArchetypeID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
				}
			}

			// Token: 0x06006450 RID: 25680 RVA: 0x001E591C File Offset: 0x001E3B1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155591, XrefRangeEnd = 155595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SerializableAttributes _Selection_b__11_6(Entity wa)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(wa);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraftDeckSetup.__c.NativeMethodInfoPtr__Selection_b__11_6_Internal_SerializableAttributes_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableAttributes>(intPtr3) : null;
				}
			}

			// Token: 0x06006451 RID: 25681 RVA: 0x001E596C File Offset: 0x001E3B6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeID _Selection_b__11_7(Entity card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraftDeckSetup.__c.NativeMethodInfoPtr__Selection_b__11_7_Internal_ArchetypeID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
				}
			}

			// Token: 0x06006452 RID: 25682 RVA: 0x00026D8B File Offset: 0x00024F8B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001ADF RID: 6879
			// (get) Token: 0x06006453 RID: 25683 RVA: 0x001E59BC File Offset: 0x001E3BBC
			// (set) Token: 0x06006454 RID: 25684 RVA: 0x00026D94 File Offset: 0x00024F94
			public unsafe static DraftDeckSetup.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DraftDeckSetup.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DraftDeckSetup.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DraftDeckSetup.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AE0 RID: 6880
			// (get) Token: 0x06006455 RID: 25685 RVA: 0x001E59E4 File Offset: 0x001E3BE4
			// (set) Token: 0x06006456 RID: 25686 RVA: 0x00026DA6 File Offset: 0x00024FA6
			public unsafe static Func<Entity, ArchetypeID> __9__11_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DraftDeckSetup.__c.NativeFieldInfoPtr___9__11_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DraftDeckSetup.__c.NativeFieldInfoPtr___9__11_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AE1 RID: 6881
			// (get) Token: 0x06006457 RID: 25687 RVA: 0x001E5A0C File Offset: 0x001E3C0C
			// (set) Token: 0x06006458 RID: 25688 RVA: 0x00026DB8 File Offset: 0x00024FB8
			public unsafe static Func<Entity, SerializableAttributes> __9__11_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DraftDeckSetup.__c.NativeFieldInfoPtr___9__11_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, SerializableAttributes>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DraftDeckSetup.__c.NativeFieldInfoPtr___9__11_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AE2 RID: 6882
			// (get) Token: 0x06006459 RID: 25689 RVA: 0x001E5A34 File Offset: 0x001E3C34
			// (set) Token: 0x0600645A RID: 25690 RVA: 0x00026DCA File Offset: 0x00024FCA
			public unsafe static Func<Entity, ArchetypeID> __9__11_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DraftDeckSetup.__c.NativeFieldInfoPtr___9__11_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DraftDeckSetup.__c.NativeFieldInfoPtr___9__11_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040040F3 RID: 16627
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040040F4 RID: 16628
			private static readonly IntPtr NativeFieldInfoPtr___9__11_5;

			// Token: 0x040040F5 RID: 16629
			private static readonly IntPtr NativeFieldInfoPtr___9__11_6;

			// Token: 0x040040F6 RID: 16630
			private static readonly IntPtr NativeFieldInfoPtr___9__11_7;

			// Token: 0x040040F7 RID: 16631
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040040F8 RID: 16632
			private static readonly IntPtr NativeMethodInfoPtr__Selection_b__11_5_Internal_ArchetypeID_Entity_0;

			// Token: 0x040040F9 RID: 16633
			private static readonly IntPtr NativeMethodInfoPtr__Selection_b__11_6_Internal_SerializableAttributes_Entity_0;

			// Token: 0x040040FA RID: 16634
			private static readonly IntPtr NativeMethodInfoPtr__Selection_b__11_7_Internal_ArchetypeID_Entity_0;
		}

		// Token: 0x02000724 RID: 1828
		[ObfuscatedName("worm.canis.actions.phases.DraftDeckSetup+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x0600645B RID: 25691 RVA: 0x001E5A5C File Offset: 0x001E3C5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<DraftDeckSetup.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DraftDeckSetup>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DraftDeckSetup.__c__DisplayClass11_0>.NativeClassPtr);
				DraftDeckSetup.__c__DisplayClass11_0.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraftDeckSetup.__c__DisplayClass11_0>.NativeClassPtr, "archID");
				DraftDeckSetup.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup.__c__DisplayClass11_0>.NativeClassPtr, 100669479);
				DraftDeckSetup.__c__DisplayClass11_0.NativeMethodInfoPtr__Selection_b__2_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup.__c__DisplayClass11_0>.NativeClassPtr, 100669480);
			}

			// Token: 0x0600645C RID: 25692 RVA: 0x001E5AC4 File Offset: 0x001E3CC4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DraftDeckSetup.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraftDeckSetup.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600645D RID: 25693 RVA: 0x001E5B00 File Offset: 0x001E3D00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155595, XrefRangeEnd = 155600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Selection_b__2(Entity card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraftDeckSetup.__c__DisplayClass11_0.NativeMethodInfoPtr__Selection_b__2_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600645E RID: 25694 RVA: 0x00026DDC File Offset: 0x00024FDC
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AE3 RID: 6883
			// (get) Token: 0x0600645F RID: 25695 RVA: 0x001E5B50 File Offset: 0x001E3D50
			// (set) Token: 0x06006460 RID: 25696 RVA: 0x00026DE5 File Offset: 0x00024FE5
			public unsafe ArchetypeID archID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraftDeckSetup.__c__DisplayClass11_0.NativeFieldInfoPtr_archID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraftDeckSetup.__c__DisplayClass11_0.NativeFieldInfoPtr_archID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040040FB RID: 16635
			private static readonly IntPtr NativeFieldInfoPtr_archID;

			// Token: 0x040040FC RID: 16636
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040040FD RID: 16637
			private static readonly IntPtr NativeMethodInfoPtr__Selection_b__2_Internal_Boolean_Entity_0;
		}

		// Token: 0x02000725 RID: 1829
		[ObfuscatedName("worm.canis.actions.phases.DraftDeckSetup+<>c__DisplayClass11_1")]
		public sealed class __c__DisplayClass11_1 : Object
		{
			// Token: 0x06006461 RID: 25697 RVA: 0x001E5B80 File Offset: 0x001E3D80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_1()
			{
				Il2CppClassPointerStore<DraftDeckSetup.__c__DisplayClass11_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DraftDeckSetup>.NativeClassPtr, "<>c__DisplayClass11_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DraftDeckSetup.__c__DisplayClass11_1>.NativeClassPtr);
				DraftDeckSetup.__c__DisplayClass11_1.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraftDeckSetup.__c__DisplayClass11_1>.NativeClassPtr, "archID");
				DraftDeckSetup.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup.__c__DisplayClass11_1>.NativeClassPtr, 100669481);
				DraftDeckSetup.__c__DisplayClass11_1.NativeMethodInfoPtr__Selection_b__3_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup.__c__DisplayClass11_1>.NativeClassPtr, 100669482);
			}

			// Token: 0x06006462 RID: 25698 RVA: 0x001E5BE8 File Offset: 0x001E3DE8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DraftDeckSetup.__c__DisplayClass11_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraftDeckSetup.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006463 RID: 25699 RVA: 0x001E5C24 File Offset: 0x001E3E24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155600, XrefRangeEnd = 155605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Selection_b__3(Entity card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraftDeckSetup.__c__DisplayClass11_1.NativeMethodInfoPtr__Selection_b__3_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006464 RID: 25700 RVA: 0x00026E04 File Offset: 0x00025004
			public __c__DisplayClass11_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AE4 RID: 6884
			// (get) Token: 0x06006465 RID: 25701 RVA: 0x001E5C74 File Offset: 0x001E3E74
			// (set) Token: 0x06006466 RID: 25702 RVA: 0x00026E0D File Offset: 0x0002500D
			public unsafe ArchetypeID archID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraftDeckSetup.__c__DisplayClass11_1.NativeFieldInfoPtr_archID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraftDeckSetup.__c__DisplayClass11_1.NativeFieldInfoPtr_archID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040040FE RID: 16638
			private static readonly IntPtr NativeFieldInfoPtr_archID;

			// Token: 0x040040FF RID: 16639
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004100 RID: 16640
			private static readonly IntPtr NativeMethodInfoPtr__Selection_b__3_Internal_Boolean_Entity_0;
		}

		// Token: 0x02000726 RID: 1830
		[ObfuscatedName("worm.canis.actions.phases.DraftDeckSetup+<>c__DisplayClass11_2")]
		public sealed class __c__DisplayClass11_2 : Object
		{
			// Token: 0x06006467 RID: 25703 RVA: 0x001E5CA4 File Offset: 0x001E3EA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_2()
			{
				Il2CppClassPointerStore<DraftDeckSetup.__c__DisplayClass11_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DraftDeckSetup>.NativeClassPtr, "<>c__DisplayClass11_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DraftDeckSetup.__c__DisplayClass11_2>.NativeClassPtr);
				DraftDeckSetup.__c__DisplayClass11_2.NativeFieldInfoPtr_cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraftDeckSetup.__c__DisplayClass11_2>.NativeClassPtr, "cost");
				DraftDeckSetup.__c__DisplayClass11_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup.__c__DisplayClass11_2>.NativeClassPtr, 100669483);
				DraftDeckSetup.__c__DisplayClass11_2.NativeMethodInfoPtr__Selection_b__4_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup.__c__DisplayClass11_2>.NativeClassPtr, 100669484);
			}

			// Token: 0x06006468 RID: 25704 RVA: 0x001E5D0C File Offset: 0x001E3F0C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_2()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DraftDeckSetup.__c__DisplayClass11_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraftDeckSetup.__c__DisplayClass11_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006469 RID: 25705 RVA: 0x001E5D48 File Offset: 0x001E3F48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155605, XrefRangeEnd = 155612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Selection_b__4(Entity card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraftDeckSetup.__c__DisplayClass11_2.NativeMethodInfoPtr__Selection_b__4_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600646A RID: 25706 RVA: 0x00026E2C File Offset: 0x0002502C
			public __c__DisplayClass11_2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AE5 RID: 6885
			// (get) Token: 0x0600646B RID: 25707 RVA: 0x001E5D98 File Offset: 0x001E3F98
			// (set) Token: 0x0600646C RID: 25708 RVA: 0x00026E35 File Offset: 0x00025035
			public unsafe int cost
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraftDeckSetup.__c__DisplayClass11_2.NativeFieldInfoPtr_cost);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraftDeckSetup.__c__DisplayClass11_2.NativeFieldInfoPtr_cost)) = value;
				}
			}

			// Token: 0x04004101 RID: 16641
			private static readonly IntPtr NativeFieldInfoPtr_cost;

			// Token: 0x04004102 RID: 16642
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004103 RID: 16643
			private static readonly IntPtr NativeMethodInfoPtr__Selection_b__4_Internal_Boolean_Entity_0;
		}

		// Token: 0x02000727 RID: 1831
		[ObfuscatedName("worm.canis.actions.phases.DraftDeckSetup+<Selection>d__11")]
		public sealed class _Selection_d__11 : Object
		{
			// Token: 0x0600646D RID: 25709 RVA: 0x001E5DC0 File Offset: 0x001E3FC0
			// Note: this type is marked as 'beforefieldinit'.
			static _Selection_d__11()
			{
				Il2CppClassPointerStore<DraftDeckSetup._Selection_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DraftDeckSetup>.NativeClassPtr, "<Selection>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DraftDeckSetup._Selection_d__11>.NativeClassPtr);
				DraftDeckSetup._Selection_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraftDeckSetup._Selection_d__11>.NativeClassPtr, "<>1__state");
				DraftDeckSetup._Selection_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraftDeckSetup._Selection_d__11>.NativeClassPtr, "<>2__current");
				DraftDeckSetup._Selection_d__11.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraftDeckSetup._Selection_d__11>.NativeClassPtr, "<>l__initialThreadId");
				DraftDeckSetup._Selection_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraftDeckSetup._Selection_d__11>.NativeClassPtr, "<>4__this");
				DraftDeckSetup._Selection_d__11.NativeFieldInfoPtr__staticDraft_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraftDeckSetup._Selection_d__11>.NativeClassPtr, "<staticDraft>5__2");
				DraftDeckSetup._Selection_d__11.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraftDeckSetup._Selection_d__11>.NativeClassPtr, "<>7__wrap2");
				DraftDeckSetup._Selection_d__11.NativeFieldInfoPtr__poolCard_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraftDeckSetup._Selection_d__11>.NativeClassPtr, "<poolCard>5__4");
				DraftDeckSetup._Selection_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup._Selection_d__11>.NativeClassPtr, 100669485);
				DraftDeckSetup._Selection_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup._Selection_d__11>.NativeClassPtr, 100669486);
				DraftDeckSetup._Selection_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup._Selection_d__11>.NativeClassPtr, 100669487);
				DraftDeckSetup._Selection_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup._Selection_d__11>.NativeClassPtr, 100669488);
				DraftDeckSetup._Selection_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup._Selection_d__11>.NativeClassPtr, 100669489);
				DraftDeckSetup._Selection_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup._Selection_d__11>.NativeClassPtr, 100669490);
				DraftDeckSetup._Selection_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup._Selection_d__11>.NativeClassPtr, 100669491);
				DraftDeckSetup._Selection_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup._Selection_d__11>.NativeClassPtr, 100669492);
				DraftDeckSetup._Selection_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraftDeckSetup._Selection_d__11>.NativeClassPtr, 100669493);
			}

			// Token: 0x0600646E RID: 25710 RVA: 0x001E5F2C File Offset: 0x001E412C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Selection_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DraftDeckSetup._Selection_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraftDeckSetup._Selection_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600646F RID: 25711 RVA: 0x001E5F74 File Offset: 0x001E4174
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155612, XrefRangeEnd = 155617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraftDeckSetup._Selection_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006470 RID: 25712 RVA: 0x001E5FA8 File Offset: 0x001E41A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155617, XrefRangeEnd = 155841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraftDeckSetup._Selection_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006471 RID: 25713 RVA: 0x001E5FE4 File Offset: 0x001E41E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155841, XrefRangeEnd = 155844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraftDeckSetup._Selection_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001AED RID: 6893
			// (get) Token: 0x06006472 RID: 25714 RVA: 0x001E6018 File Offset: 0x001E4218
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraftDeckSetup._Selection_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006473 RID: 25715 RVA: 0x001E6058 File Offset: 0x001E4258
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155844, XrefRangeEnd = 155849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraftDeckSetup._Selection_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001AEE RID: 6894
			// (get) Token: 0x06006474 RID: 25716 RVA: 0x001E608C File Offset: 0x001E428C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraftDeckSetup._Selection_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006475 RID: 25717 RVA: 0x001E60CC File Offset: 0x001E42CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155849, XrefRangeEnd = 155851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraftDeckSetup._Selection_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006476 RID: 25718 RVA: 0x001E610C File Offset: 0x001E430C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraftDeckSetup._Selection_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006477 RID: 25719 RVA: 0x00026E50 File Offset: 0x00025050
			public _Selection_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AE6 RID: 6886
			// (get) Token: 0x06006478 RID: 25720 RVA: 0x001E614C File Offset: 0x001E434C
			// (set) Token: 0x06006479 RID: 25721 RVA: 0x00026E59 File Offset: 0x00025059
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraftDeckSetup._Selection_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraftDeckSetup._Selection_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001AE7 RID: 6887
			// (get) Token: 0x0600647A RID: 25722 RVA: 0x001E6174 File Offset: 0x001E4374
			// (set) Token: 0x0600647B RID: 25723 RVA: 0x00026E74 File Offset: 0x00025074
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraftDeckSetup._Selection_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraftDeckSetup._Selection_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AE8 RID: 6888
			// (get) Token: 0x0600647C RID: 25724 RVA: 0x001E61A4 File Offset: 0x001E43A4
			// (set) Token: 0x0600647D RID: 25725 RVA: 0x00026E93 File Offset: 0x00025093
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraftDeckSetup._Selection_d__11.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraftDeckSetup._Selection_d__11.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001AE9 RID: 6889
			// (get) Token: 0x0600647E RID: 25726 RVA: 0x001E61CC File Offset: 0x001E43CC
			// (set) Token: 0x0600647F RID: 25727 RVA: 0x00026EAE File Offset: 0x000250AE
			public unsafe DraftDeckSetup __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraftDeckSetup._Selection_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DraftDeckSetup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraftDeckSetup._Selection_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AEA RID: 6890
			// (get) Token: 0x06006480 RID: 25728 RVA: 0x001E61FC File Offset: 0x001E43FC
			// (set) Token: 0x06006481 RID: 25729 RVA: 0x00026ECD File Offset: 0x000250CD
			public unsafe List<ArchetypeID> _staticDraft_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraftDeckSetup._Selection_d__11.NativeFieldInfoPtr__staticDraft_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraftDeckSetup._Selection_d__11.NativeFieldInfoPtr__staticDraft_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AEB RID: 6891
			// (get) Token: 0x06006482 RID: 25730 RVA: 0x001E622C File Offset: 0x001E442C
			// (set) Token: 0x06006483 RID: 25731 RVA: 0x00026EEC File Offset: 0x000250EC
			public List<ArchetypeID>.Enumerator __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraftDeckSetup._Selection_d__11.NativeFieldInfoPtr___7__wrap2);
					return new List<ArchetypeID>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<ArchetypeID>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraftDeckSetup._Selection_d__11.NativeFieldInfoPtr___7__wrap2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<ArchetypeID>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001AEC RID: 6892
			// (get) Token: 0x06006484 RID: 25732 RVA: 0x001E625C File Offset: 0x001E445C
			// (set) Token: 0x06006485 RID: 25733 RVA: 0x00026F1A File Offset: 0x0002511A
			public unsafe Entity _poolCard_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraftDeckSetup._Selection_d__11.NativeFieldInfoPtr__poolCard_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraftDeckSetup._Selection_d__11.NativeFieldInfoPtr__poolCard_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004104 RID: 16644
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004105 RID: 16645
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004106 RID: 16646
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004107 RID: 16647
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004108 RID: 16648
			private static readonly IntPtr NativeFieldInfoPtr__staticDraft_5__2;

			// Token: 0x04004109 RID: 16649
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x0400410A RID: 16650
			private static readonly IntPtr NativeFieldInfoPtr__poolCard_5__4;

			// Token: 0x0400410B RID: 16651
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400410C RID: 16652
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400410D RID: 16653
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400410E RID: 16654
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400410F RID: 16655
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004110 RID: 16656
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004111 RID: 16657
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004112 RID: 16658
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004113 RID: 16659
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
