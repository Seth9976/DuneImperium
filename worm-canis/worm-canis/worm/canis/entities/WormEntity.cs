using System;
using Canis;
using canis.archetypes;
using Canis.attributes;
using Canis.entities;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.abilities;
using worm.canis.abilities.ActivatedAbilities;
using worm.canis.abilities.PlayAbilities;
using worm.canis.abilities.SpaceAbilities;

namespace worm.canis.entities
{
	// Token: 0x02000027 RID: 39
	public class WormEntity : Entity
	{
		// Token: 0x06000346 RID: 838 RVA: 0x00075E98 File Offset: 0x00074098
		// Note: this type is marked as 'beforefieldinit'.
		static WormEntity()
		{
			Il2CppClassPointerStore<WormEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormEntity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEntity>.NativeClassPtr);
			WormEntity.NativeFieldInfoPtr_archetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEntity>.NativeClassPtr, "archetype");
			WormEntity.NativeMethodInfoPtr_GetArchetype_Public_Virtual_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntity>.NativeClassPtr, 100664003);
			WormEntity.NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_Archetype_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntity>.NativeClassPtr, 100664004);
			WormEntity.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntity>.NativeClassPtr, 100664005);
			WormEntity.NativeMethodInfoPtr_InitializeAttrs_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntity>.NativeClassPtr, 100664006);
			WormEntity.NativeMethodInfoPtr_CopyAttributes_Public_Void_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntity>.NativeClassPtr, 100664007);
			WormEntity.NativeMethodInfoPtr_CopyAttributes_Public_Void_IEnumerable_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntity>.NativeClassPtr, 100664008);
			WormEntity.NativeMethodInfoPtr_get_ClearUndoStackHinting_Public_get_Func_2_WormEntity_IEnumerable_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntity>.NativeClassPtr, 100664009);
			WormEntity.NativeMethodInfoPtr__get_ClearUndoStackHinting_b__8_0_Private_IEnumerable_1_IAttribute_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntity>.NativeClassPtr, 100664010);
			WormEntity.NativeMethodInfoPtr__get_ClearUndoStackHinting_b__8_3_Private_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntity>.NativeClassPtr, 100664011);
			WormEntity.NativeMethodInfoPtr__get_ClearUndoStackHinting_b__8_6_Private_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntity>.NativeClassPtr, 100664012);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00075FA4 File Offset: 0x000741A4
		[CallerCount(0)]
		public unsafe override Archetype GetArchetype()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEntity.NativeMethodInfoPtr_GetArchetype_Public_Virtual_Archetype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr3) : null;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00075FF0 File Offset: 0x000741F0
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 35740, RefRangeEnd = 35756, XrefRangeStart = 35738, XrefRangeEnd = 35740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEntity(Match m, PlayerEntity owner, Archetype arch, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEntity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arch);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntity.NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_Archetype_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00076074 File Offset: 0x00074274
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 35780, RefRangeEnd = 35811, XrefRangeStart = 35756, XrefRangeEnd = 35780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEntity(SerializedEntity se, Match m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEntity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntity.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x000760E4 File Offset: 0x000742E4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeAttrs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEntity.NativeMethodInfoPtr_InitializeAttrs_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00076120 File Offset: 0x00074320
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35834, RefRangeEnd = 35835, XrefRangeStart = 35811, XrefRangeEnd = 35834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyAttributes(WormEntity other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntity.NativeMethodInfoPtr_CopyAttributes_Public_Void_WormEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00076164 File Offset: 0x00074364
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35860, RefRangeEnd = 35861, XrefRangeStart = 35835, XrefRangeEnd = 35860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyAttributes(IEnumerable<IAttribute> attrList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntity.NativeMethodInfoPtr_CopyAttributes_Public_Void_IEnumerable_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600034D RID: 845 RVA: 0x000761A8 File Offset: 0x000743A8
		public unsafe Func<WormEntity, IEnumerable<IAttribute>> ClearUndoStackHinting
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35867, RefRangeEnd = 35868, XrefRangeStart = 35861, XrefRangeEnd = 35867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntity.NativeMethodInfoPtr_get_ClearUndoStackHinting_Public_get_Func_2_WormEntity_IEnumerable_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<WormEntity, IEnumerable<IAttribute>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x000761E8 File Offset: 0x000743E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35868, XrefRangeEnd = 35971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<IAttribute> _get_ClearUndoStackHinting_b__8_0(WormEntity ent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntity.NativeMethodInfoPtr__get_ClearUndoStackHinting_b__8_0_Private_IEnumerable_1_IAttribute_WormEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00076238 File Offset: 0x00074438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35971, XrefRangeEnd = 35982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_ClearUndoStackHinting_b__8_3(DeferredAbility _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntity.NativeMethodInfoPtr__get_ClearUndoStackHinting_b__8_3_Private_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00076288 File Offset: 0x00074488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35982, XrefRangeEnd = 35993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_ClearUndoStackHinting_b__8_6(DeferredAbility _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntity.NativeMethodInfoPtr__get_ClearUndoStackHinting_b__8_6_Private_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00003693 File Offset: 0x00001893
		public WormEntity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000352 RID: 850 RVA: 0x000762D8 File Offset: 0x000744D8
		// (set) Token: 0x06000353 RID: 851 RVA: 0x0000369C File Offset: 0x0000189C
		public unsafe Archetype archetype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntity.NativeFieldInfoPtr_archetype);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntity.NativeFieldInfoPtr_archetype), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeFieldInfoPtr_archetype;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_GetArchetype_Public_Virtual_Archetype_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_Archetype_String_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAttrs_Public_Virtual_New_Void_0;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr_CopyAttributes_Public_Void_WormEntity_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr_CopyAttributes_Public_Void_IEnumerable_1_IAttribute_0;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr_get_ClearUndoStackHinting_Public_get_Func_2_WormEntity_IEnumerable_1_IAttribute_0;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr__get_ClearUndoStackHinting_b__8_0_Private_IEnumerable_1_IAttribute_WormEntity_0;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr__get_ClearUndoStackHinting_b__8_3_Private_Boolean_DeferredAbility_0;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeMethodInfoPtr__get_ClearUndoStackHinting_b__8_6_Private_Boolean_DeferredAbility_0;

		// Token: 0x02000595 RID: 1429
		[ObfuscatedName("worm.canis.entities.WormEntity+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06004463 RID: 17507 RVA: 0x0018217C File Offset: 0x0018037C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormEntity.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEntity>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEntity.__c>.NativeClassPtr);
				WormEntity.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEntity.__c>.NativeClassPtr, "<>9");
				WormEntity.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEntity.__c>.NativeClassPtr, "<>9__8_1");
				WormEntity.__c.NativeFieldInfoPtr___9__8_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEntity.__c>.NativeClassPtr, "<>9__8_2");
				WormEntity.__c.NativeFieldInfoPtr___9__8_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEntity.__c>.NativeClassPtr, "<>9__8_4");
				WormEntity.__c.NativeFieldInfoPtr___9__8_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEntity.__c>.NativeClassPtr, "<>9__8_5");
				WormEntity.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntity.__c>.NativeClassPtr, 100664014);
				WormEntity.__c.NativeMethodInfoPtr__get_ClearUndoStackHinting_b__8_1_Internal_Boolean_PlayAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntity.__c>.NativeClassPtr, 100664015);
				WormEntity.__c.NativeMethodInfoPtr__get_ClearUndoStackHinting_b__8_2_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntity.__c>.NativeClassPtr, 100664016);
				WormEntity.__c.NativeMethodInfoPtr__get_ClearUndoStackHinting_b__8_4_Internal_Boolean_SpaceAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntity.__c>.NativeClassPtr, 100664017);
				WormEntity.__c.NativeMethodInfoPtr__get_ClearUndoStackHinting_b__8_5_Internal_Boolean_PlayAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntity.__c>.NativeClassPtr, 100664018);
			}

			// Token: 0x06004464 RID: 17508 RVA: 0x00182270 File Offset: 0x00180470
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEntity.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntity.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004465 RID: 17509 RVA: 0x001822AC File Offset: 0x001804AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35692, XrefRangeEnd = 35700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_ClearUndoStackHinting_b__8_1(PlayAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntity.__c.NativeMethodInfoPtr__get_ClearUndoStackHinting_b__8_1_Internal_Boolean_PlayAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004466 RID: 17510 RVA: 0x001822FC File Offset: 0x001804FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35700, XrefRangeEnd = 35707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_ClearUndoStackHinting_b__8_2(DeferredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntity.__c.NativeMethodInfoPtr__get_ClearUndoStackHinting_b__8_2_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004467 RID: 17511 RVA: 0x0018234C File Offset: 0x0018054C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35707, XrefRangeEnd = 35715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_ClearUndoStackHinting_b__8_4(SpaceAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntity.__c.NativeMethodInfoPtr__get_ClearUndoStackHinting_b__8_4_Internal_Boolean_SpaceAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004468 RID: 17512 RVA: 0x0018239C File Offset: 0x0018059C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35715, XrefRangeEnd = 35723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_ClearUndoStackHinting_b__8_5(PlayAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntity.__c.NativeMethodInfoPtr__get_ClearUndoStackHinting_b__8_5_Internal_Boolean_PlayAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004469 RID: 17513 RVA: 0x0001681E File Offset: 0x00014A1E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700103B RID: 4155
			// (get) Token: 0x0600446A RID: 17514 RVA: 0x001823EC File Offset: 0x001805EC
			// (set) Token: 0x0600446B RID: 17515 RVA: 0x00016827 File Offset: 0x00014A27
			public unsafe static WormEntity.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormEntity.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntity.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormEntity.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700103C RID: 4156
			// (get) Token: 0x0600446C RID: 17516 RVA: 0x00182414 File Offset: 0x00180614
			// (set) Token: 0x0600446D RID: 17517 RVA: 0x00016839 File Offset: 0x00014A39
			public unsafe static Func<PlayAbility, bool> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormEntity.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayAbility, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormEntity.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700103D RID: 4157
			// (get) Token: 0x0600446E RID: 17518 RVA: 0x0018243C File Offset: 0x0018063C
			// (set) Token: 0x0600446F RID: 17519 RVA: 0x0001684B File Offset: 0x00014A4B
			public unsafe static Func<DeferredAbility, bool> __9__8_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormEntity.__c.NativeFieldInfoPtr___9__8_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DeferredAbility, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormEntity.__c.NativeFieldInfoPtr___9__8_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700103E RID: 4158
			// (get) Token: 0x06004470 RID: 17520 RVA: 0x00182464 File Offset: 0x00180664
			// (set) Token: 0x06004471 RID: 17521 RVA: 0x0001685D File Offset: 0x00014A5D
			public unsafe static Func<SpaceAbility, bool> __9__8_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormEntity.__c.NativeFieldInfoPtr___9__8_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpaceAbility, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormEntity.__c.NativeFieldInfoPtr___9__8_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700103F RID: 4159
			// (get) Token: 0x06004472 RID: 17522 RVA: 0x0018248C File Offset: 0x0018068C
			// (set) Token: 0x06004473 RID: 17523 RVA: 0x0001686F File Offset: 0x00014A6F
			public unsafe static Func<PlayAbility, bool> __9__8_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormEntity.__c.NativeFieldInfoPtr___9__8_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayAbility, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormEntity.__c.NativeFieldInfoPtr___9__8_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D27 RID: 11559
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002D28 RID: 11560
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x04002D29 RID: 11561
			private static readonly IntPtr NativeFieldInfoPtr___9__8_2;

			// Token: 0x04002D2A RID: 11562
			private static readonly IntPtr NativeFieldInfoPtr___9__8_4;

			// Token: 0x04002D2B RID: 11563
			private static readonly IntPtr NativeFieldInfoPtr___9__8_5;

			// Token: 0x04002D2C RID: 11564
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D2D RID: 11565
			private static readonly IntPtr NativeMethodInfoPtr__get_ClearUndoStackHinting_b__8_1_Internal_Boolean_PlayAbility_0;

			// Token: 0x04002D2E RID: 11566
			private static readonly IntPtr NativeMethodInfoPtr__get_ClearUndoStackHinting_b__8_2_Internal_Boolean_DeferredAbility_0;

			// Token: 0x04002D2F RID: 11567
			private static readonly IntPtr NativeMethodInfoPtr__get_ClearUndoStackHinting_b__8_4_Internal_Boolean_SpaceAbility_0;

			// Token: 0x04002D30 RID: 11568
			private static readonly IntPtr NativeMethodInfoPtr__get_ClearUndoStackHinting_b__8_5_Internal_Boolean_PlayAbility_0;
		}

		// Token: 0x02000596 RID: 1430
		[ObfuscatedName("worm.canis.entities.WormEntity+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x06004474 RID: 17524 RVA: 0x001824B4 File Offset: 0x001806B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<WormEntity.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEntity>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEntity.__c__DisplayClass8_0>.NativeClassPtr);
				WormEntity.__c__DisplayClass8_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEntity.__c__DisplayClass8_0>.NativeClassPtr, "player");
				WormEntity.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEntity.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				WormEntity.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntity.__c__DisplayClass8_0>.NativeClassPtr, 100664019);
				WormEntity.__c__DisplayClass8_0.NativeMethodInfoPtr__get_ClearUndoStackHinting_b__7_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntity.__c__DisplayClass8_0>.NativeClassPtr, 100664020);
				WormEntity.__c__DisplayClass8_0.NativeMethodInfoPtr__get_ClearUndoStackHinting_b__8_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntity.__c__DisplayClass8_0>.NativeClassPtr, 100664021);
				WormEntity.__c__DisplayClass8_0.NativeMethodInfoPtr__get_ClearUndoStackHinting_b__9_Internal_Boolean_SignetAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntity.__c__DisplayClass8_0>.NativeClassPtr, 100664022);
			}

			// Token: 0x06004475 RID: 17525 RVA: 0x00182558 File Offset: 0x00180758
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEntity.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntity.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004476 RID: 17526 RVA: 0x00182594 File Offset: 0x00180794
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35723, XrefRangeEnd = 35738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_ClearUndoStackHinting_b__7(WormAbilityDefinition ab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntity.__c__DisplayClass8_0.NativeMethodInfoPtr__get_ClearUndoStackHinting_b__7_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004477 RID: 17527 RVA: 0x001825E4 File Offset: 0x001807E4
			[CallerCount(0)]
			public unsafe bool _get_ClearUndoStackHinting_b__8(DeferredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntity.__c__DisplayClass8_0.NativeMethodInfoPtr__get_ClearUndoStackHinting_b__8_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004478 RID: 17528 RVA: 0x00182634 File Offset: 0x00180834
			[CallerCount(0)]
			public unsafe bool _get_ClearUndoStackHinting_b__9(SignetAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntity.__c__DisplayClass8_0.NativeMethodInfoPtr__get_ClearUndoStackHinting_b__9_Internal_Boolean_SignetAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004479 RID: 17529 RVA: 0x00016881 File Offset: 0x00014A81
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001040 RID: 4160
			// (get) Token: 0x0600447A RID: 17530 RVA: 0x00182684 File Offset: 0x00180884
			// (set) Token: 0x0600447B RID: 17531 RVA: 0x0001688A File Offset: 0x00014A8A
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntity.__c__DisplayClass8_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntity.__c__DisplayClass8_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001041 RID: 4161
			// (get) Token: 0x0600447C RID: 17532 RVA: 0x001826B4 File Offset: 0x001808B4
			// (set) Token: 0x0600447D RID: 17533 RVA: 0x000168A9 File Offset: 0x00014AA9
			public unsafe WormEntity __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntity.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntity.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D31 RID: 11569
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002D32 RID: 11570
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002D33 RID: 11571
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D34 RID: 11572
			private static readonly IntPtr NativeMethodInfoPtr__get_ClearUndoStackHinting_b__7_Internal_Boolean_WormAbilityDefinition_0;

			// Token: 0x04002D35 RID: 11573
			private static readonly IntPtr NativeMethodInfoPtr__get_ClearUndoStackHinting_b__8_Internal_Boolean_DeferredAbility_0;

			// Token: 0x04002D36 RID: 11574
			private static readonly IntPtr NativeMethodInfoPtr__get_ClearUndoStackHinting_b__9_Internal_Boolean_SignetAbility_0;
		}
	}
}
