using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.actions.cost.RiseOfIx
{
	// Token: 0x0200030E RID: 782
	public class ResolveIntelligence : global::Canis.actions.Action
	{
		// Token: 0x06001FF9 RID: 8185 RVA: 0x000D6048 File Offset: 0x000D4248
		// Note: this type is marked as 'beforefieldinit'.
		static ResolveIntelligence()
		{
			Il2CppClassPointerStore<ResolveIntelligence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.cost.RiseOfIx", "ResolveIntelligence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveIntelligence>.NativeClassPtr);
			ResolveIntelligence.NativeFieldInfoPtr_targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveIntelligence>.NativeClassPtr, "targets");
			ResolveIntelligence.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Entity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveIntelligence>.NativeClassPtr, 100671058);
			ResolveIntelligence.NativeMethodInfoPtr__ctor_Public_Void_SerializedResolveIntelligence_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveIntelligence>.NativeClassPtr, 100671059);
			ResolveIntelligence.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveIntelligence>.NativeClassPtr, 100671060);
			ResolveIntelligence.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveIntelligence>.NativeClassPtr, 100671061);
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x000D60DC File Offset: 0x000D42DC
		[CallerCount(106)]
		[CachedScanResults(RefRangeStart = 139275, RefRangeEnd = 139381, XrefRangeStart = 139275, XrefRangeEnd = 139381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResolveIntelligence(IEnumerable<Entity> targets, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveIntelligence>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveIntelligence.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Entity_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x000D613C File Offset: 0x000D433C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174661, XrefRangeEnd = 174687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResolveIntelligence(SerializedResolveIntelligence serialized, WormMatch wormMatch)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveIntelligence>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveIntelligence.NativeMethodInfoPtr__ctor_Public_Void_SerializedResolveIntelligence_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x000D619C File Offset: 0x000D439C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174687, XrefRangeEnd = 174693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResolveIntelligence.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x000D61E8 File Offset: 0x000D43E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174693, XrefRangeEnd = 174719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResolveIntelligence.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x0000D45E File Offset: 0x0000B65E
		public ResolveIntelligence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06001FFF RID: 8191 RVA: 0x000D6244 File Offset: 0x000D4444
		// (set) Token: 0x06002000 RID: 8192 RVA: 0x0000D467 File Offset: 0x0000B667
		public unsafe IEnumerable<Entity> targets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveIntelligence.NativeFieldInfoPtr_targets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveIntelligence.NativeFieldInfoPtr_targets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001427 RID: 5159
		private static readonly IntPtr NativeFieldInfoPtr_targets;

		// Token: 0x04001428 RID: 5160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Entity_Match_0;

		// Token: 0x04001429 RID: 5161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedResolveIntelligence_WormMatch_0;

		// Token: 0x0400142A RID: 5162
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x0400142B RID: 5163
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x020007C7 RID: 1991
		[ObfuscatedName("worm.canis.actions.cost.RiseOfIx.ResolveIntelligence+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060070B6 RID: 28854 RVA: 0x0020CC3C File Offset: 0x0020AE3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ResolveIntelligence.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResolveIntelligence>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveIntelligence.__c>.NativeClassPtr);
				ResolveIntelligence.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveIntelligence.__c>.NativeClassPtr, "<>9");
				ResolveIntelligence.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveIntelligence.__c>.NativeClassPtr, "<>9__4_0");
				ResolveIntelligence.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveIntelligence.__c>.NativeClassPtr, 100671063);
				ResolveIntelligence.__c.NativeMethodInfoPtr__MakeSerializedAction_b__4_0_Internal_EntityID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveIntelligence.__c>.NativeClassPtr, 100671064);
			}

			// Token: 0x060070B7 RID: 28855 RVA: 0x0020CCB8 File Offset: 0x0020AEB8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveIntelligence.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveIntelligence.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060070B8 RID: 28856 RVA: 0x0020CCF4 File Offset: 0x0020AEF4
			[CallerCount(0)]
			public unsafe EntityID _MakeSerializedAction_b__4_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveIntelligence.__c.NativeMethodInfoPtr__MakeSerializedAction_b__4_0_Internal_EntityID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060070B9 RID: 28857 RVA: 0x0002CC6B File Offset: 0x0002AE6B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001EF7 RID: 7927
			// (get) Token: 0x060070BA RID: 28858 RVA: 0x0020CD44 File Offset: 0x0020AF44
			// (set) Token: 0x060070BB RID: 28859 RVA: 0x0002CC74 File Offset: 0x0002AE74
			public unsafe static ResolveIntelligence.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResolveIntelligence.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveIntelligence.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResolveIntelligence.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001EF8 RID: 7928
			// (get) Token: 0x060070BC RID: 28860 RVA: 0x0020CD6C File Offset: 0x0020AF6C
			// (set) Token: 0x060070BD RID: 28861 RVA: 0x0002CC86 File Offset: 0x0002AE86
			public unsafe static Func<Entity, EntityID> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResolveIntelligence.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResolveIntelligence.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040048D0 RID: 18640
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040048D1 RID: 18641
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x040048D2 RID: 18642
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040048D3 RID: 18643
			private static readonly IntPtr NativeMethodInfoPtr__MakeSerializedAction_b__4_0_Internal_EntityID_Entity_0;
		}

		// Token: 0x020007C8 RID: 1992
		[ObfuscatedName("worm.canis.actions.cost.RiseOfIx.ResolveIntelligence+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x060070BE RID: 28862 RVA: 0x0020CD94 File Offset: 0x0020AF94
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<ResolveIntelligence.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResolveIntelligence>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveIntelligence.__c__DisplayClass2_0>.NativeClassPtr);
				ResolveIntelligence.__c__DisplayClass2_0.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveIntelligence.__c__DisplayClass2_0>.NativeClassPtr, "wormMatch");
				ResolveIntelligence.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveIntelligence.__c__DisplayClass2_0>.NativeClassPtr, 100671065);
				ResolveIntelligence.__c__DisplayClass2_0.NativeMethodInfoPtr___ctor_b__0_Internal_IEnumerable_1_Entity_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveIntelligence.__c__DisplayClass2_0>.NativeClassPtr, 100671066);
			}

			// Token: 0x060070BF RID: 28863 RVA: 0x0020CDFC File Offset: 0x0020AFFC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveIntelligence.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveIntelligence.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060070C0 RID: 28864 RVA: 0x0020CE38 File Offset: 0x0020B038
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174595, XrefRangeEnd = 174605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Entity> __ctor_b__0(EntityID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveIntelligence.__c__DisplayClass2_0.NativeMethodInfoPtr___ctor_b__0_Internal_IEnumerable_1_Entity_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x060070C1 RID: 28865 RVA: 0x0002CC98 File Offset: 0x0002AE98
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001EF9 RID: 7929
			// (get) Token: 0x060070C2 RID: 28866 RVA: 0x0020CE88 File Offset: 0x0020B088
			// (set) Token: 0x060070C3 RID: 28867 RVA: 0x0002CCA1 File Offset: 0x0002AEA1
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveIntelligence.__c__DisplayClass2_0.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveIntelligence.__c__DisplayClass2_0.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040048D4 RID: 18644
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x040048D5 RID: 18645
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040048D6 RID: 18646
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_Internal_IEnumerable_1_Entity_EntityID_0;
		}

		// Token: 0x020007C9 RID: 1993
		[ObfuscatedName("worm.canis.actions.cost.RiseOfIx.ResolveIntelligence+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x060070C4 RID: 28868 RVA: 0x0020CEB8 File Offset: 0x0020B0B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<ResolveIntelligence.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResolveIntelligence>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveIntelligence.__c__DisplayClass3_0>.NativeClassPtr);
				ResolveIntelligence.__c__DisplayClass3_0.NativeFieldInfoPtr_intrigueCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveIntelligence.__c__DisplayClass3_0>.NativeClassPtr, "intrigueCard");
				ResolveIntelligence.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveIntelligence.__c__DisplayClass3_0>.NativeClassPtr, 100671067);
				ResolveIntelligence.__c__DisplayClass3_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveIntelligence.__c__DisplayClass3_0>.NativeClassPtr, 100671068);
			}

			// Token: 0x060070C5 RID: 28869 RVA: 0x0020CF20 File Offset: 0x0020B120
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveIntelligence.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveIntelligence.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060070C6 RID: 28870 RVA: 0x0020CF5C File Offset: 0x0020B15C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174605, XrefRangeEnd = 174610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveIntelligence.__c__DisplayClass3_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060070C7 RID: 28871 RVA: 0x0002CCC0 File Offset: 0x0002AEC0
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001EFA RID: 7930
			// (get) Token: 0x060070C8 RID: 28872 RVA: 0x0020CFAC File Offset: 0x0020B1AC
			// (set) Token: 0x060070C9 RID: 28873 RVA: 0x0002CCC9 File Offset: 0x0002AEC9
			public unsafe WormIntriguePlayable intrigueCard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveIntelligence.__c__DisplayClass3_0.NativeFieldInfoPtr_intrigueCard);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormIntriguePlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveIntelligence.__c__DisplayClass3_0.NativeFieldInfoPtr_intrigueCard), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040048D7 RID: 18647
			private static readonly IntPtr NativeFieldInfoPtr_intrigueCard;

			// Token: 0x040048D8 RID: 18648
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040048D9 RID: 18649
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_Internal_Boolean_Entity_0;
		}

		// Token: 0x020007CA RID: 1994
		[ObfuscatedName("worm.canis.actions.cost.RiseOfIx.ResolveIntelligence+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x060070CA RID: 28874 RVA: 0x0020CFDC File Offset: 0x0020B1DC
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<ResolveIntelligence._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResolveIntelligence>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveIntelligence._execute_d__3>.NativeClassPtr);
				ResolveIntelligence._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveIntelligence._execute_d__3>.NativeClassPtr, "<>1__state");
				ResolveIntelligence._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveIntelligence._execute_d__3>.NativeClassPtr, "<>2__current");
				ResolveIntelligence._execute_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveIntelligence._execute_d__3>.NativeClassPtr, "<>l__initialThreadId");
				ResolveIntelligence._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveIntelligence._execute_d__3>.NativeClassPtr, "<>4__this");
				ResolveIntelligence._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveIntelligence._execute_d__3>.NativeClassPtr, 100671069);
				ResolveIntelligence._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveIntelligence._execute_d__3>.NativeClassPtr, 100671070);
				ResolveIntelligence._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveIntelligence._execute_d__3>.NativeClassPtr, 100671071);
				ResolveIntelligence._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveIntelligence._execute_d__3>.NativeClassPtr, 100671072);
				ResolveIntelligence._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveIntelligence._execute_d__3>.NativeClassPtr, 100671073);
				ResolveIntelligence._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveIntelligence._execute_d__3>.NativeClassPtr, 100671074);
				ResolveIntelligence._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveIntelligence._execute_d__3>.NativeClassPtr, 100671075);
				ResolveIntelligence._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveIntelligence._execute_d__3>.NativeClassPtr, 100671076);
			}

			// Token: 0x060070CB RID: 28875 RVA: 0x0020D0F8 File Offset: 0x0020B2F8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveIntelligence._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveIntelligence._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060070CC RID: 28876 RVA: 0x0020D140 File Offset: 0x0020B340
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveIntelligence._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060070CD RID: 28877 RVA: 0x0020D174 File Offset: 0x0020B374
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174610, XrefRangeEnd = 174654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveIntelligence._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001EFF RID: 7935
			// (get) Token: 0x060070CE RID: 28878 RVA: 0x0020D1B0 File Offset: 0x0020B3B0
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveIntelligence._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060070CF RID: 28879 RVA: 0x0020D1F0 File Offset: 0x0020B3F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174654, XrefRangeEnd = 174659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveIntelligence._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001F00 RID: 7936
			// (get) Token: 0x060070D0 RID: 28880 RVA: 0x0020D224 File Offset: 0x0020B424
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveIntelligence._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060070D1 RID: 28881 RVA: 0x0020D264 File Offset: 0x0020B464
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174659, XrefRangeEnd = 174661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveIntelligence._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060070D2 RID: 28882 RVA: 0x0020D2A4 File Offset: 0x0020B4A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveIntelligence._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060070D3 RID: 28883 RVA: 0x0002CCE8 File Offset: 0x0002AEE8
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001EFB RID: 7931
			// (get) Token: 0x060070D4 RID: 28884 RVA: 0x0020D2E4 File Offset: 0x0020B4E4
			// (set) Token: 0x060070D5 RID: 28885 RVA: 0x0002CCF1 File Offset: 0x0002AEF1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveIntelligence._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveIntelligence._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001EFC RID: 7932
			// (get) Token: 0x060070D6 RID: 28886 RVA: 0x0020D30C File Offset: 0x0020B50C
			// (set) Token: 0x060070D7 RID: 28887 RVA: 0x0002CD0C File Offset: 0x0002AF0C
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveIntelligence._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveIntelligence._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001EFD RID: 7933
			// (get) Token: 0x060070D8 RID: 28888 RVA: 0x0020D33C File Offset: 0x0020B53C
			// (set) Token: 0x060070D9 RID: 28889 RVA: 0x0002CD2B File Offset: 0x0002AF2B
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveIntelligence._execute_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveIntelligence._execute_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001EFE RID: 7934
			// (get) Token: 0x060070DA RID: 28890 RVA: 0x0020D364 File Offset: 0x0020B564
			// (set) Token: 0x060070DB RID: 28891 RVA: 0x0002CD46 File Offset: 0x0002AF46
			public unsafe ResolveIntelligence __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveIntelligence._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveIntelligence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveIntelligence._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040048DA RID: 18650
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040048DB RID: 18651
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040048DC RID: 18652
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040048DD RID: 18653
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040048DE RID: 18654
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040048DF RID: 18655
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040048E0 RID: 18656
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040048E1 RID: 18657
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040048E2 RID: 18658
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040048E3 RID: 18659
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040048E4 RID: 18660
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040048E5 RID: 18661
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
