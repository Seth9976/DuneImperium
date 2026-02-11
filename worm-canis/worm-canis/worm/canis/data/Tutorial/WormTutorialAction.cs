using System;
using System.Runtime.InteropServices;
using Canis.attributes;
using Canis.context;
using Canis.entities;
using Canis.tutorialScripts;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.abilities;
using worm.canis.abilities.ActivatedAbilities;
using worm.canis.entities;

namespace worm.canis.data.Tutorial
{
	// Token: 0x02000045 RID: 69
	public class WormTutorialAction : TutorialAction
	{
		// Token: 0x060007EF RID: 2031 RVA: 0x00083E38 File Offset: 0x00082038
		// Note: this type is marked as 'beforefieldinit'.
		static WormTutorialAction()
		{
			Il2CppClassPointerStore<WormTutorialAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Tutorial", "WormTutorialAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialAction>.NativeClassPtr);
			WormTutorialAction.NativeFieldInfoPtr_contextualAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialAction>.NativeClassPtr, "contextualAttributes");
			WormTutorialAction.NativeMethodInfoPtr_AddEntity_Public_TutorialAction_Func_2_Context_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction>.NativeClassPtr, 100664733);
			WormTutorialAction.NativeMethodInfoPtr_AddEntity_Public_TutorialAction_Func_2_Context_Entity_AttributeDefinition_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction>.NativeClassPtr, 100664734);
			WormTutorialAction.NativeMethodInfoPtr_AddDeferredAbility_Public_TutorialAction_AbilityID_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction>.NativeClassPtr, 100664735);
			WormTutorialAction.NativeMethodInfoPtr_AddPlaymatEntity_Public_TutorialAction_Func_2_WormPlaymat_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction>.NativeClassPtr, 100664736);
			WormTutorialAction.NativeMethodInfoPtr_AddSpace_Public_TutorialAction_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction>.NativeClassPtr, 100664737);
			WormTutorialAction.NativeMethodInfoPtr_AddShippingAbility_Public_TutorialAction_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction>.NativeClassPtr, 100664738);
			WormTutorialAction.NativeMethodInfoPtr_AddEntities_Public_WormTutorialAction_Func_2_Context_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction>.NativeClassPtr, 100664739);
			WormTutorialAction.NativeMethodInfoPtr_AddSpaces_Public_WormTutorialAction_Il2CppReferenceArray_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction>.NativeClassPtr, 100664740);
			WormTutorialAction.NativeMethodInfoPtr_MakeSerializableAttributes_Public_Virtual_SerializableAttributes_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction>.NativeClassPtr, 100664741);
			WormTutorialAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction>.NativeClassPtr, 100664742);
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00083F44 File Offset: 0x00082144
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 51726, RefRangeEnd = 51786, XrefRangeStart = 51705, XrefRangeEnd = 51726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialAction AddEntity(Func<Context, Entity> entityGenerator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityGenerator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.NativeMethodInfoPtr_AddEntity_Public_TutorialAction_Func_2_Context_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
			}
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00083F94 File Offset: 0x00082194
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 51803, RefRangeEnd = 51805, XrefRangeStart = 51786, XrefRangeEnd = 51803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialAction AddEntity(Func<Context, Entity> entityGenerator, AttributeDefinition<EntityID> attributeDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityGenerator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.NativeMethodInfoPtr_AddEntity_Public_TutorialAction_Func_2_Context_Entity_AttributeDefinition_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00083FF8 File Offset: 0x000821F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 51819, RefRangeEnd = 51821, XrefRangeStart = 51805, XrefRangeEnd = 51819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialAction AddDeferredAbility(AbilityID abilityID, WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(abilityID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.NativeMethodInfoPtr_AddDeferredAbility_Public_TutorialAction_AbilityID_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x0008405C File Offset: 0x0008225C
		[CallerCount(57)]
		[CachedScanResults(RefRangeStart = 51834, RefRangeEnd = 51891, XrefRangeStart = 51821, XrefRangeEnd = 51834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialAction AddPlaymatEntity(Func<WormPlaymat, Entity> entityGenerator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityGenerator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.NativeMethodInfoPtr_AddPlaymatEntity_Public_TutorialAction_Func_2_WormPlaymat_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
			}
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x000840AC File Offset: 0x000822AC
		[CallerCount(102)]
		[CachedScanResults(RefRangeStart = 51904, RefRangeEnd = 52006, XrefRangeStart = 51891, XrefRangeEnd = 51904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialAction AddSpace(ArchetypeID archetypeID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archetypeID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.NativeMethodInfoPtr_AddSpace_Public_TutorialAction_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
			}
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x000840FC File Offset: 0x000822FC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 52019, RefRangeEnd = 52026, XrefRangeStart = 52006, XrefRangeEnd = 52019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialAction AddShippingAbility(AbilityID abilityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(abilityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.NativeMethodInfoPtr_AddShippingAbility_Public_TutorialAction_AbilityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
			}
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x0008414C File Offset: 0x0008234C
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 52042, RefRangeEnd = 52067, XrefRangeStart = 52026, XrefRangeEnd = 52042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTutorialAction AddEntities(Func<Context, Il2CppReferenceArray<Entity>> entityGenerator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityGenerator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.NativeMethodInfoPtr_AddEntities_Public_WormTutorialAction_Func_2_Context_Il2CppReferenceArray_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormTutorialAction>(intPtr3) : null;
			}
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x0008419C File Offset: 0x0008239C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 52080, RefRangeEnd = 52084, XrefRangeStart = 52067, XrefRangeEnd = 52080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTutorialAction AddSpaces([Optional] Il2CppReferenceArray<ArchetypeID> archetypeIDs)
		{
			if (archetypeIDs == null)
			{
				archetypeIDs = new Il2CppReferenceArray<ArchetypeID>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archetypeIDs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.NativeMethodInfoPtr_AddSpaces_Public_WormTutorialAction_Il2CppReferenceArray_1_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormTutorialAction>(intPtr3) : null;
			}
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x000841FC File Offset: 0x000823FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52084, XrefRangeEnd = 52129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializableAttributes MakeSerializableAttributes(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTutorialAction.NativeMethodInfoPtr_MakeSerializableAttributes_Public_Virtual_SerializableAttributes_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00084258 File Offset: 0x00082458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52129, XrefRangeEnd = 52371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTutorialAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x000056C0 File Offset: 0x000038C0
		public WormTutorialAction AddSpaces(params ArchetypeID[] archetypeIDs)
		{
			return this.AddSpaces(new Il2CppReferenceArray<ArchetypeID>(archetypeIDs));
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x000056CE File Offset: 0x000038CE
		public WormTutorialAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x00084294 File Offset: 0x00082494
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x000056D7 File Offset: 0x000038D7
		public unsafe List<Func<Context, IAttribute>> contextualAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialAction.NativeFieldInfoPtr_contextualAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Func<Context, IAttribute>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialAction.NativeFieldInfoPtr_contextualAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeFieldInfoPtr_contextualAttributes;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeMethodInfoPtr_AddEntity_Public_TutorialAction_Func_2_Context_Entity_0;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeMethodInfoPtr_AddEntity_Public_TutorialAction_Func_2_Context_Entity_AttributeDefinition_1_EntityID_0;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeMethodInfoPtr_AddDeferredAbility_Public_TutorialAction_AbilityID_WormPlayer_0;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeMethodInfoPtr_AddPlaymatEntity_Public_TutorialAction_Func_2_WormPlaymat_Entity_0;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeMethodInfoPtr_AddSpace_Public_TutorialAction_ArchetypeID_0;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeMethodInfoPtr_AddShippingAbility_Public_TutorialAction_AbilityID_0;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeMethodInfoPtr_AddEntities_Public_WormTutorialAction_Func_2_Context_Il2CppReferenceArray_1_Entity_0;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeMethodInfoPtr_AddSpaces_Public_WormTutorialAction_Il2CppReferenceArray_1_ArchetypeID_0;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializableAttributes_Public_Virtual_SerializableAttributes_Context_0;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020005DE RID: 1502
		[ObfuscatedName("worm.canis.data.Tutorial.WormTutorialAction+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06004932 RID: 18738 RVA: 0x00190C20 File Offset: 0x0018EE20
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormTutorialAction.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialAction>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialAction.__c>.NativeClassPtr);
				WormTutorialAction.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialAction.__c>.NativeClassPtr, "<>9");
				WormTutorialAction.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialAction.__c>.NativeClassPtr, "<>9__6_1");
				WormTutorialAction.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialAction.__c>.NativeClassPtr, "<>9__7_1");
				WormTutorialAction.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction.__c>.NativeClassPtr, 100664744);
				WormTutorialAction.__c.NativeMethodInfoPtr__AddShippingAbility_b__6_1_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction.__c>.NativeClassPtr, 100664745);
				WormTutorialAction.__c.NativeMethodInfoPtr__AddEntities_b__7_1_Internal_EntityID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction.__c>.NativeClassPtr, 100664746);
			}

			// Token: 0x06004933 RID: 18739 RVA: 0x00190CC4 File Offset: 0x0018EEC4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialAction.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004934 RID: 18740 RVA: 0x00190D00 File Offset: 0x0018EF00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51578, XrefRangeEnd = 51581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<DeferredAbility> _AddShippingAbility_b__6_1(IHasAbilities<WormMatch, WormAbilityDefinition> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.__c.NativeMethodInfoPtr__AddShippingAbility_b__6_1_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DeferredAbility>>(intPtr3) : null;
				}
			}

			// Token: 0x06004935 RID: 18741 RVA: 0x00190D50 File Offset: 0x0018EF50
			[CallerCount(0)]
			public unsafe EntityID _AddEntities_b__7_1(Entity e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.__c.NativeMethodInfoPtr__AddEntities_b__7_1_Internal_EntityID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06004936 RID: 18742 RVA: 0x00018F59 File Offset: 0x00017159
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011C9 RID: 4553
			// (get) Token: 0x06004937 RID: 18743 RVA: 0x00190DA0 File Offset: 0x0018EFA0
			// (set) Token: 0x06004938 RID: 18744 RVA: 0x00018F62 File Offset: 0x00017162
			public unsafe static WormTutorialAction.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialAction.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTutorialAction.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialAction.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011CA RID: 4554
			// (get) Token: 0x06004939 RID: 18745 RVA: 0x00190DC8 File Offset: 0x0018EFC8
			// (set) Token: 0x0600493A RID: 18746 RVA: 0x00018F74 File Offset: 0x00017174
			public unsafe static Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialAction.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialAction.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011CB RID: 4555
			// (get) Token: 0x0600493B RID: 18747 RVA: 0x00190DF0 File Offset: 0x0018EFF0
			// (set) Token: 0x0600493C RID: 18748 RVA: 0x00018F86 File Offset: 0x00017186
			public unsafe static Func<Entity, EntityID> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTutorialAction.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTutorialAction.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003010 RID: 12304
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003011 RID: 12305
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x04003012 RID: 12306
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x04003013 RID: 12307
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003014 RID: 12308
			private static readonly IntPtr NativeMethodInfoPtr__AddShippingAbility_b__6_1_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0;

			// Token: 0x04003015 RID: 12309
			private static readonly IntPtr NativeMethodInfoPtr__AddEntities_b__7_1_Internal_EntityID_Entity_0;
		}

		// Token: 0x020005DF RID: 1503
		[ObfuscatedName("worm.canis.data.Tutorial.WormTutorialAction+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600493D RID: 18749 RVA: 0x00190E18 File Offset: 0x0018F018
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialAction>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass2_0>.NativeClassPtr);
				WormTutorialAction.__c__DisplayClass2_0.NativeFieldInfoPtr_entityGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass2_0>.NativeClassPtr, "entityGenerator");
				WormTutorialAction.__c__DisplayClass2_0.NativeFieldInfoPtr_attributeDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass2_0>.NativeClassPtr, "attributeDefinition");
				WormTutorialAction.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass2_0>.NativeClassPtr, 100664747);
				WormTutorialAction.__c__DisplayClass2_0.NativeMethodInfoPtr__AddEntity_b__0_Internal_IAttribute_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass2_0>.NativeClassPtr, 100664748);
			}

			// Token: 0x0600493E RID: 18750 RVA: 0x00190E94 File Offset: 0x0018F094
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600493F RID: 18751 RVA: 0x00190ED0 File Offset: 0x0018F0D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51581, XrefRangeEnd = 51584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAttribute _AddEntity_b__0(Context context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.__c__DisplayClass2_0.NativeMethodInfoPtr__AddEntity_b__0_Internal_IAttribute_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr3) : null;
				}
			}

			// Token: 0x06004940 RID: 18752 RVA: 0x00018F98 File Offset: 0x00017198
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011CC RID: 4556
			// (get) Token: 0x06004941 RID: 18753 RVA: 0x00190F20 File Offset: 0x0018F120
			// (set) Token: 0x06004942 RID: 18754 RVA: 0x00018FA1 File Offset: 0x000171A1
			public unsafe Func<Context, Entity> entityGenerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialAction.__c__DisplayClass2_0.NativeFieldInfoPtr_entityGenerator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Context, Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialAction.__c__DisplayClass2_0.NativeFieldInfoPtr_entityGenerator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011CD RID: 4557
			// (get) Token: 0x06004943 RID: 18755 RVA: 0x00190F50 File Offset: 0x0018F150
			// (set) Token: 0x06004944 RID: 18756 RVA: 0x00018FC0 File Offset: 0x000171C0
			public unsafe AttributeDefinition<EntityID> attributeDefinition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialAction.__c__DisplayClass2_0.NativeFieldInfoPtr_attributeDefinition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<EntityID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialAction.__c__DisplayClass2_0.NativeFieldInfoPtr_attributeDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003016 RID: 12310
			private static readonly IntPtr NativeFieldInfoPtr_entityGenerator;

			// Token: 0x04003017 RID: 12311
			private static readonly IntPtr NativeFieldInfoPtr_attributeDefinition;

			// Token: 0x04003018 RID: 12312
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003019 RID: 12313
			private static readonly IntPtr NativeMethodInfoPtr__AddEntity_b__0_Internal_IAttribute_Context_0;
		}

		// Token: 0x020005E0 RID: 1504
		[ObfuscatedName("worm.canis.data.Tutorial.WormTutorialAction+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06004945 RID: 18757 RVA: 0x00190F80 File Offset: 0x0018F180
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialAction>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass3_0>.NativeClassPtr);
				WormTutorialAction.__c__DisplayClass3_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass3_0>.NativeClassPtr, "player");
				WormTutorialAction.__c__DisplayClass3_0.NativeFieldInfoPtr_abilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass3_0>.NativeClassPtr, "abilityID");
				WormTutorialAction.__c__DisplayClass3_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass3_0>.NativeClassPtr, "<>9__1");
				WormTutorialAction.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass3_0>.NativeClassPtr, 100664749);
				WormTutorialAction.__c__DisplayClass3_0.NativeMethodInfoPtr__AddDeferredAbility_b__0_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass3_0>.NativeClassPtr, 100664750);
				WormTutorialAction.__c__DisplayClass3_0.NativeMethodInfoPtr__AddDeferredAbility_b__1_Internal_Boolean_AbilityDefinitionForGame_1_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass3_0>.NativeClassPtr, 100664751);
			}

			// Token: 0x06004946 RID: 18758 RVA: 0x00191024 File Offset: 0x0018F224
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004947 RID: 18759 RVA: 0x00191060 File Offset: 0x0018F260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51584, XrefRangeEnd = 51596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _AddDeferredAbility_b__0(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.__c__DisplayClass3_0.NativeMethodInfoPtr__AddDeferredAbility_b__0_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004948 RID: 18760 RVA: 0x001910B0 File Offset: 0x0018F2B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51596, XrefRangeEnd = 51601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddDeferredAbility_b__1(AbilityDefinitionForGame<WormMatch> ability)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.__c__DisplayClass3_0.NativeMethodInfoPtr__AddDeferredAbility_b__1_Internal_Boolean_AbilityDefinitionForGame_1_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004949 RID: 18761 RVA: 0x00018FDF File Offset: 0x000171DF
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011CE RID: 4558
			// (get) Token: 0x0600494A RID: 18762 RVA: 0x00191100 File Offset: 0x0018F300
			// (set) Token: 0x0600494B RID: 18763 RVA: 0x00018FE8 File Offset: 0x000171E8
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialAction.__c__DisplayClass3_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialAction.__c__DisplayClass3_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011CF RID: 4559
			// (get) Token: 0x0600494C RID: 18764 RVA: 0x00191130 File Offset: 0x0018F330
			// (set) Token: 0x0600494D RID: 18765 RVA: 0x00019007 File Offset: 0x00017207
			public unsafe AbilityID abilityID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialAction.__c__DisplayClass3_0.NativeFieldInfoPtr_abilityID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialAction.__c__DisplayClass3_0.NativeFieldInfoPtr_abilityID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011D0 RID: 4560
			// (get) Token: 0x0600494E RID: 18766 RVA: 0x00191160 File Offset: 0x0018F360
			// (set) Token: 0x0600494F RID: 18767 RVA: 0x00019026 File Offset: 0x00017226
			public unsafe Func<AbilityDefinitionForGame<WormMatch>, bool> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialAction.__c__DisplayClass3_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AbilityDefinitionForGame<WormMatch>, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialAction.__c__DisplayClass3_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400301A RID: 12314
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x0400301B RID: 12315
			private static readonly IntPtr NativeFieldInfoPtr_abilityID;

			// Token: 0x0400301C RID: 12316
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x0400301D RID: 12317
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400301E RID: 12318
			private static readonly IntPtr NativeMethodInfoPtr__AddDeferredAbility_b__0_Internal_Entity_WormPlaymat_0;

			// Token: 0x0400301F RID: 12319
			private static readonly IntPtr NativeMethodInfoPtr__AddDeferredAbility_b__1_Internal_Boolean_AbilityDefinitionForGame_1_WormMatch_0;
		}

		// Token: 0x020005E1 RID: 1505
		[ObfuscatedName("worm.canis.data.Tutorial.WormTutorialAction+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06004950 RID: 18768 RVA: 0x00191190 File Offset: 0x0018F390
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialAction>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass4_0>.NativeClassPtr);
				WormTutorialAction.__c__DisplayClass4_0.NativeFieldInfoPtr_entityGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass4_0>.NativeClassPtr, "entityGenerator");
				WormTutorialAction.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass4_0>.NativeClassPtr, 100664752);
				WormTutorialAction.__c__DisplayClass4_0.NativeMethodInfoPtr__AddPlaymatEntity_b__0_Internal_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass4_0>.NativeClassPtr, 100664753);
			}

			// Token: 0x06004951 RID: 18769 RVA: 0x001911F8 File Offset: 0x0018F3F8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004952 RID: 18770 RVA: 0x00191234 File Offset: 0x0018F434
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51601, XrefRangeEnd = 51606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _AddPlaymatEntity_b__0(Context context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.__c__DisplayClass4_0.NativeMethodInfoPtr__AddPlaymatEntity_b__0_Internal_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004953 RID: 18771 RVA: 0x00019045 File Offset: 0x00017245
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011D1 RID: 4561
			// (get) Token: 0x06004954 RID: 18772 RVA: 0x00191284 File Offset: 0x0018F484
			// (set) Token: 0x06004955 RID: 18773 RVA: 0x0001904E File Offset: 0x0001724E
			public unsafe Func<WormPlaymat, Entity> entityGenerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialAction.__c__DisplayClass4_0.NativeFieldInfoPtr_entityGenerator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlaymat, Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialAction.__c__DisplayClass4_0.NativeFieldInfoPtr_entityGenerator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003020 RID: 12320
			private static readonly IntPtr NativeFieldInfoPtr_entityGenerator;

			// Token: 0x04003021 RID: 12321
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003022 RID: 12322
			private static readonly IntPtr NativeMethodInfoPtr__AddPlaymatEntity_b__0_Internal_Entity_Context_0;
		}

		// Token: 0x020005E2 RID: 1506
		[ObfuscatedName("worm.canis.data.Tutorial.WormTutorialAction+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06004956 RID: 18774 RVA: 0x001912B4 File Offset: 0x0018F4B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialAction>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass5_0>.NativeClassPtr);
				WormTutorialAction.__c__DisplayClass5_0.NativeFieldInfoPtr_archetypeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass5_0>.NativeClassPtr, "archetypeID");
				WormTutorialAction.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass5_0>.NativeClassPtr, 100664754);
				WormTutorialAction.__c__DisplayClass5_0.NativeMethodInfoPtr__AddSpace_b__0_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass5_0>.NativeClassPtr, 100664755);
			}

			// Token: 0x06004957 RID: 18775 RVA: 0x0019131C File Offset: 0x0018F51C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004958 RID: 18776 RVA: 0x00191358 File Offset: 0x0018F558
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51606, XrefRangeEnd = 51608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _AddSpace_b__0(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.__c__DisplayClass5_0.NativeMethodInfoPtr__AddSpace_b__0_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06004959 RID: 18777 RVA: 0x0001906D File Offset: 0x0001726D
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011D2 RID: 4562
			// (get) Token: 0x0600495A RID: 18778 RVA: 0x001913A8 File Offset: 0x0018F5A8
			// (set) Token: 0x0600495B RID: 18779 RVA: 0x00019076 File Offset: 0x00017276
			public unsafe ArchetypeID archetypeID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialAction.__c__DisplayClass5_0.NativeFieldInfoPtr_archetypeID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialAction.__c__DisplayClass5_0.NativeFieldInfoPtr_archetypeID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003023 RID: 12323
			private static readonly IntPtr NativeFieldInfoPtr_archetypeID;

			// Token: 0x04003024 RID: 12324
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003025 RID: 12325
			private static readonly IntPtr NativeMethodInfoPtr__AddSpace_b__0_Internal_Entity_WormPlaymat_0;
		}

		// Token: 0x020005E3 RID: 1507
		[ObfuscatedName("worm.canis.data.Tutorial.WormTutorialAction+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x0600495C RID: 18780 RVA: 0x001913D8 File Offset: 0x0018F5D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialAction>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass6_0>.NativeClassPtr);
				WormTutorialAction.__c__DisplayClass6_0.NativeFieldInfoPtr_abilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass6_0>.NativeClassPtr, "abilityID");
				WormTutorialAction.__c__DisplayClass6_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass6_0>.NativeClassPtr, "<>9__2");
				WormTutorialAction.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass6_0>.NativeClassPtr, 100664756);
				WormTutorialAction.__c__DisplayClass6_0.NativeMethodInfoPtr__AddShippingAbility_b__0_Internal_Entity_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass6_0>.NativeClassPtr, 100664757);
				WormTutorialAction.__c__DisplayClass6_0.NativeMethodInfoPtr__AddShippingAbility_b__2_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass6_0>.NativeClassPtr, 100664758);
			}

			// Token: 0x0600495D RID: 18781 RVA: 0x00191468 File Offset: 0x0018F668
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600495E RID: 18782 RVA: 0x001914A4 File Offset: 0x0018F6A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51608, XrefRangeEnd = 51640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _AddShippingAbility_b__0(WormPlaymat playmat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.__c__DisplayClass6_0.NativeMethodInfoPtr__AddShippingAbility_b__0_Internal_Entity_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x0600495F RID: 18783 RVA: 0x001914F4 File Offset: 0x0018F6F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51640, XrefRangeEnd = 51645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddShippingAbility_b__2(DeferredAbility ability)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.__c__DisplayClass6_0.NativeMethodInfoPtr__AddShippingAbility_b__2_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004960 RID: 18784 RVA: 0x00019095 File Offset: 0x00017295
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011D3 RID: 4563
			// (get) Token: 0x06004961 RID: 18785 RVA: 0x00191544 File Offset: 0x0018F744
			// (set) Token: 0x06004962 RID: 18786 RVA: 0x0001909E File Offset: 0x0001729E
			public unsafe AbilityID abilityID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialAction.__c__DisplayClass6_0.NativeFieldInfoPtr_abilityID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialAction.__c__DisplayClass6_0.NativeFieldInfoPtr_abilityID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011D4 RID: 4564
			// (get) Token: 0x06004963 RID: 18787 RVA: 0x00191574 File Offset: 0x0018F774
			// (set) Token: 0x06004964 RID: 18788 RVA: 0x000190BD File Offset: 0x000172BD
			public unsafe Func<DeferredAbility, bool> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialAction.__c__DisplayClass6_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DeferredAbility, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialAction.__c__DisplayClass6_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003026 RID: 12326
			private static readonly IntPtr NativeFieldInfoPtr_abilityID;

			// Token: 0x04003027 RID: 12327
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x04003028 RID: 12328
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003029 RID: 12329
			private static readonly IntPtr NativeMethodInfoPtr__AddShippingAbility_b__0_Internal_Entity_WormPlaymat_0;

			// Token: 0x0400302A RID: 12330
			private static readonly IntPtr NativeMethodInfoPtr__AddShippingAbility_b__2_Internal_Boolean_DeferredAbility_0;
		}

		// Token: 0x020005E4 RID: 1508
		[ObfuscatedName("worm.canis.data.Tutorial.WormTutorialAction+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x06004965 RID: 18789 RVA: 0x001915A4 File Offset: 0x0018F7A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialAction>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass7_0>.NativeClassPtr);
				WormTutorialAction.__c__DisplayClass7_0.NativeFieldInfoPtr_entityGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass7_0>.NativeClassPtr, "entityGenerator");
				WormTutorialAction.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass7_0>.NativeClassPtr, 100664759);
				WormTutorialAction.__c__DisplayClass7_0.NativeMethodInfoPtr__AddEntities_b__0_Internal_IAttribute_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass7_0>.NativeClassPtr, 100664760);
			}

			// Token: 0x06004966 RID: 18790 RVA: 0x0019160C File Offset: 0x0018F80C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004967 RID: 18791 RVA: 0x00191648 File Offset: 0x0018F848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51645, XrefRangeEnd = 51673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAttribute _AddEntities_b__0(Context context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.__c__DisplayClass7_0.NativeMethodInfoPtr__AddEntities_b__0_Internal_IAttribute_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr3) : null;
				}
			}

			// Token: 0x06004968 RID: 18792 RVA: 0x000190DC File Offset: 0x000172DC
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011D5 RID: 4565
			// (get) Token: 0x06004969 RID: 18793 RVA: 0x00191698 File Offset: 0x0018F898
			// (set) Token: 0x0600496A RID: 18794 RVA: 0x000190E5 File Offset: 0x000172E5
			public unsafe Func<Context, Il2CppReferenceArray<Entity>> entityGenerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialAction.__c__DisplayClass7_0.NativeFieldInfoPtr_entityGenerator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Context, Il2CppReferenceArray<Entity>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialAction.__c__DisplayClass7_0.NativeFieldInfoPtr_entityGenerator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400302B RID: 12331
			private static readonly IntPtr NativeFieldInfoPtr_entityGenerator;

			// Token: 0x0400302C RID: 12332
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400302D RID: 12333
			private static readonly IntPtr NativeMethodInfoPtr__AddEntities_b__0_Internal_IAttribute_Context_0;
		}

		// Token: 0x020005E5 RID: 1509
		[ObfuscatedName("worm.canis.data.Tutorial.WormTutorialAction+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x0600496B RID: 18795 RVA: 0x001916C8 File Offset: 0x0018F8C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialAction>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass8_0>.NativeClassPtr);
				WormTutorialAction.__c__DisplayClass8_0.NativeFieldInfoPtr_archetypeIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass8_0>.NativeClassPtr, "archetypeIDs");
				WormTutorialAction.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass8_0>.NativeClassPtr, 100664761);
				WormTutorialAction.__c__DisplayClass8_0.NativeMethodInfoPtr__AddSpaces_b__0_Internal_Il2CppReferenceArray_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass8_0>.NativeClassPtr, 100664762);
			}

			// Token: 0x0600496C RID: 18796 RVA: 0x00191730 File Offset: 0x0018F930
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600496D RID: 18797 RVA: 0x0019176C File Offset: 0x0018F96C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51673, XrefRangeEnd = 51693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Entity> _AddSpaces_b__0(Context context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.__c__DisplayClass8_0.NativeMethodInfoPtr__AddSpaces_b__0_Internal_Il2CppReferenceArray_1_Entity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x0600496E RID: 18798 RVA: 0x00019104 File Offset: 0x00017304
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011D6 RID: 4566
			// (get) Token: 0x0600496F RID: 18799 RVA: 0x001917BC File Offset: 0x0018F9BC
			// (set) Token: 0x06004970 RID: 18800 RVA: 0x0001910D File Offset: 0x0001730D
			public unsafe Il2CppReferenceArray<ArchetypeID> archetypeIDs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialAction.__c__DisplayClass8_0.NativeFieldInfoPtr_archetypeIDs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialAction.__c__DisplayClass8_0.NativeFieldInfoPtr_archetypeIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400302E RID: 12334
			private static readonly IntPtr NativeFieldInfoPtr_archetypeIDs;

			// Token: 0x0400302F RID: 12335
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003030 RID: 12336
			private static readonly IntPtr NativeMethodInfoPtr__AddSpaces_b__0_Internal_Il2CppReferenceArray_1_Entity_Context_0;
		}

		// Token: 0x020005E6 RID: 1510
		[ObfuscatedName("worm.canis.data.Tutorial.WormTutorialAction+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x06004971 RID: 18801 RVA: 0x001917EC File Offset: 0x0018F9EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTutorialAction>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass9_0>.NativeClassPtr);
				WormTutorialAction.__c__DisplayClass9_0.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass9_0>.NativeClassPtr, "context");
				WormTutorialAction.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass9_0>.NativeClassPtr, 100664763);
				WormTutorialAction.__c__DisplayClass9_0.NativeMethodInfoPtr__MakeSerializableAttributes_b__0_Internal_IEnumerable_1_IAttribute_Func_2_Context_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass9_0>.NativeClassPtr, 100664764);
			}

			// Token: 0x06004972 RID: 18802 RVA: 0x00191854 File Offset: 0x0018FA54
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTutorialAction.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004973 RID: 18803 RVA: 0x00191890 File Offset: 0x0018FA90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51693, XrefRangeEnd = 51705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<IAttribute> _MakeSerializableAttributes_b__0(Func<Context, IAttribute> gen)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(gen);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTutorialAction.__c__DisplayClass9_0.NativeMethodInfoPtr__MakeSerializableAttributes_b__0_Internal_IEnumerable_1_IAttribute_Func_2_Context_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
				}
			}

			// Token: 0x06004974 RID: 18804 RVA: 0x0001912C File Offset: 0x0001732C
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011D7 RID: 4567
			// (get) Token: 0x06004975 RID: 18805 RVA: 0x001918E0 File Offset: 0x0018FAE0
			// (set) Token: 0x06004976 RID: 18806 RVA: 0x00019135 File Offset: 0x00017335
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialAction.__c__DisplayClass9_0.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTutorialAction.__c__DisplayClass9_0.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003031 RID: 12337
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04003032 RID: 12338
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003033 RID: 12339
			private static readonly IntPtr NativeMethodInfoPtr__MakeSerializableAttributes_b__0_Internal_IEnumerable_1_IAttribute_Func_2_Context_IAttribute_0;
		}
	}
}
