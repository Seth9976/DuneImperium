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
using Networking.selection.targetinformation;
using Networking.selection.targetresponse;
using worm.canis.abilities.ActivatedAbilities;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x02000292 RID: 658
	public class RunDeferredAbilities : global::Canis.actions.Action
	{
		// Token: 0x06001B73 RID: 7027 RVA: 0x000C38F4 File Offset: 0x000C1AF4
		// Note: this type is marked as 'beforefieldinit'.
		static RunDeferredAbilities()
		{
			Il2CppClassPointerStore<RunDeferredAbilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "RunDeferredAbilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunDeferredAbilities>.NativeClassPtr);
			RunDeferredAbilities.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDeferredAbilities>.NativeClassPtr, "wormMatch");
			RunDeferredAbilities.NativeFieldInfoPtr_deferredAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDeferredAbilities>.NativeClassPtr, "deferredAbilities");
			RunDeferredAbilities.NativeFieldInfoPtr_parentUndo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDeferredAbilities>.NativeClassPtr, "parentUndo");
			RunDeferredAbilities.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_DeferredAbility_UndoNode_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeferredAbilities>.NativeClassPtr, 100668743);
			RunDeferredAbilities.NativeMethodInfoPtr__ctor_Public_Void_SerializedRunDeferredAbilities_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeferredAbilities>.NativeClassPtr, 100668744);
			RunDeferredAbilities.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeferredAbilities>.NativeClassPtr, 100668745);
			RunDeferredAbilities.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeferredAbilities>.NativeClassPtr, 100668746);
			RunDeferredAbilities.NativeMethodInfoPtr___ctor_b__4_0_Private_IEnumerable_1_DeferredAbility_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeferredAbilities>.NativeClassPtr, 100668747);
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x000C39C4 File Offset: 0x000C1BC4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 146535, RefRangeEnd = 146539, XrefRangeStart = 146528, XrefRangeEnd = 146535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunDeferredAbilities(IEnumerable<DeferredAbility> deferredAbilities, UndoNode parentUndo, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunDeferredAbilities>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deferredAbilities);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentUndo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeferredAbilities.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_DeferredAbility_UndoNode_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x000C3A34 File Offset: 0x000C1C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146539, XrefRangeEnd = 146565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunDeferredAbilities(SerializedRunDeferredAbilities serialized, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunDeferredAbilities>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeferredAbilities.NativeMethodInfoPtr__ctor_Public_Void_SerializedRunDeferredAbilities_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x000C3A94 File Offset: 0x000C1C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146565, XrefRangeEnd = 146571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunDeferredAbilities.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x000C3AE0 File Offset: 0x000C1CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146571, XrefRangeEnd = 146598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunDeferredAbilities.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x000C3B3C File Offset: 0x000C1D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146598, XrefRangeEnd = 146608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<DeferredAbility> __ctor_b__4_0(EntityID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeferredAbilities.NativeMethodInfoPtr___ctor_b__4_0_Private_IEnumerable_1_DeferredAbility_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DeferredAbility>>(intPtr3) : null;
			}
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x0000BB89 File Offset: 0x00009D89
		public RunDeferredAbilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06001B7A RID: 7034 RVA: 0x000C3B8C File Offset: 0x000C1D8C
		// (set) Token: 0x06001B7B RID: 7035 RVA: 0x0000BB92 File Offset: 0x00009D92
		public unsafe WormMatch wormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeferredAbilities.NativeFieldInfoPtr_wormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeferredAbilities.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06001B7C RID: 7036 RVA: 0x000C3BBC File Offset: 0x000C1DBC
		// (set) Token: 0x06001B7D RID: 7037 RVA: 0x0000BBB1 File Offset: 0x00009DB1
		public unsafe List<DeferredAbility> deferredAbilities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeferredAbilities.NativeFieldInfoPtr_deferredAbilities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DeferredAbility>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeferredAbilities.NativeFieldInfoPtr_deferredAbilities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06001B7E RID: 7038 RVA: 0x000C3BEC File Offset: 0x000C1DEC
		// (set) Token: 0x06001B7F RID: 7039 RVA: 0x0000BBD0 File Offset: 0x00009DD0
		public unsafe UndoNode parentUndo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeferredAbilities.NativeFieldInfoPtr_parentUndo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeferredAbilities.NativeFieldInfoPtr_parentUndo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010ED RID: 4333
		private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

		// Token: 0x040010EE RID: 4334
		private static readonly IntPtr NativeFieldInfoPtr_deferredAbilities;

		// Token: 0x040010EF RID: 4335
		private static readonly IntPtr NativeFieldInfoPtr_parentUndo;

		// Token: 0x040010F0 RID: 4336
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_DeferredAbility_UndoNode_WormMatch_0;

		// Token: 0x040010F1 RID: 4337
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedRunDeferredAbilities_WormMatch_0;

		// Token: 0x040010F2 RID: 4338
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x040010F3 RID: 4339
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x040010F4 RID: 4340
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__4_0_Private_IEnumerable_1_DeferredAbility_EntityID_0;

		// Token: 0x020006DC RID: 1756
		[ObfuscatedName("worm.canis.actions.RunDeferredAbilities+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005DE4 RID: 24036 RVA: 0x001D221C File Offset: 0x001D041C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RunDeferredAbilities.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunDeferredAbilities>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunDeferredAbilities.__c>.NativeClassPtr);
				RunDeferredAbilities.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDeferredAbilities.__c>.NativeClassPtr, "<>9");
				RunDeferredAbilities.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDeferredAbilities.__c>.NativeClassPtr, "<>9__5_0");
				RunDeferredAbilities.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDeferredAbilities.__c>.NativeClassPtr, "<>9__5_1");
				RunDeferredAbilities.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDeferredAbilities.__c>.NativeClassPtr, "<>9__6_0");
				RunDeferredAbilities.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeferredAbilities.__c>.NativeClassPtr, 100668749);
				RunDeferredAbilities.__c.NativeMethodInfoPtr__execute_b__5_0_Internal_Boolean_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeferredAbilities.__c>.NativeClassPtr, 100668750);
				RunDeferredAbilities.__c.NativeMethodInfoPtr__execute_b__5_1_Internal_EntityListTargetResponse_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeferredAbilities.__c>.NativeClassPtr, 100668751);
				RunDeferredAbilities.__c.NativeMethodInfoPtr__MakeSerializedAction_b__6_0_Internal_EntityID_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeferredAbilities.__c>.NativeClassPtr, 100668752);
			}

			// Token: 0x06005DE5 RID: 24037 RVA: 0x001D22E8 File Offset: 0x001D04E8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunDeferredAbilities.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeferredAbilities.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005DE6 RID: 24038 RVA: 0x001D2324 File Offset: 0x001D0524
			[CallerCount(0)]
			public unsafe bool _execute_b__5_0(TargetInformation _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeferredAbilities.__c.NativeMethodInfoPtr__execute_b__5_0_Internal_Boolean_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005DE7 RID: 24039 RVA: 0x001D2374 File Offset: 0x001D0574
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146469, XrefRangeEnd = 146479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EntityListTargetResponse _execute_b__5_1(TargetInformation ti)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ti);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeferredAbilities.__c.NativeMethodInfoPtr__execute_b__5_1_Internal_EntityListTargetResponse_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityListTargetResponse>(intPtr3) : null;
				}
			}

			// Token: 0x06005DE8 RID: 24040 RVA: 0x001D23C4 File Offset: 0x001D05C4
			[CallerCount(0)]
			public unsafe EntityID _MakeSerializedAction_b__6_0(DeferredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeferredAbilities.__c.NativeMethodInfoPtr__MakeSerializedAction_b__6_0_Internal_EntityID_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06005DE9 RID: 24041 RVA: 0x00023517 File Offset: 0x00021717
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001895 RID: 6293
			// (get) Token: 0x06005DEA RID: 24042 RVA: 0x001D2414 File Offset: 0x001D0614
			// (set) Token: 0x06005DEB RID: 24043 RVA: 0x00023520 File Offset: 0x00021720
			public unsafe static RunDeferredAbilities.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunDeferredAbilities.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunDeferredAbilities.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunDeferredAbilities.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001896 RID: 6294
			// (get) Token: 0x06005DEC RID: 24044 RVA: 0x001D243C File Offset: 0x001D063C
			// (set) Token: 0x06005DED RID: 24045 RVA: 0x00023532 File Offset: 0x00021732
			public unsafe static Func<TargetInformation, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunDeferredAbilities.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TargetInformation, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunDeferredAbilities.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001897 RID: 6295
			// (get) Token: 0x06005DEE RID: 24046 RVA: 0x001D2464 File Offset: 0x001D0664
			// (set) Token: 0x06005DEF RID: 24047 RVA: 0x00023544 File Offset: 0x00021744
			public unsafe static Func<TargetInformation, EntityListTargetResponse> __9__5_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunDeferredAbilities.__c.NativeFieldInfoPtr___9__5_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TargetInformation, EntityListTargetResponse>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunDeferredAbilities.__c.NativeFieldInfoPtr___9__5_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001898 RID: 6296
			// (get) Token: 0x06005DF0 RID: 24048 RVA: 0x001D248C File Offset: 0x001D068C
			// (set) Token: 0x06005DF1 RID: 24049 RVA: 0x00023556 File Offset: 0x00021756
			public unsafe static Func<DeferredAbility, EntityID> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunDeferredAbilities.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DeferredAbility, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunDeferredAbilities.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003CFA RID: 15610
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003CFB RID: 15611
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04003CFC RID: 15612
			private static readonly IntPtr NativeFieldInfoPtr___9__5_1;

			// Token: 0x04003CFD RID: 15613
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04003CFE RID: 15614
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003CFF RID: 15615
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__5_0_Internal_Boolean_TargetInformation_0;

			// Token: 0x04003D00 RID: 15616
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__5_1_Internal_EntityListTargetResponse_TargetInformation_0;

			// Token: 0x04003D01 RID: 15617
			private static readonly IntPtr NativeMethodInfoPtr__MakeSerializedAction_b__6_0_Internal_EntityID_DeferredAbility_0;
		}

		// Token: 0x020006DD RID: 1757
		[ObfuscatedName("worm.canis.actions.RunDeferredAbilities+<execute>d__5")]
		public sealed class _execute_d__5 : Object
		{
			// Token: 0x06005DF2 RID: 24050 RVA: 0x001D24B4 File Offset: 0x001D06B4
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__5()
			{
				Il2CppClassPointerStore<RunDeferredAbilities._execute_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunDeferredAbilities>.NativeClassPtr, "<execute>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunDeferredAbilities._execute_d__5>.NativeClassPtr);
				RunDeferredAbilities._execute_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDeferredAbilities._execute_d__5>.NativeClassPtr, "<>1__state");
				RunDeferredAbilities._execute_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDeferredAbilities._execute_d__5>.NativeClassPtr, "<>2__current");
				RunDeferredAbilities._execute_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDeferredAbilities._execute_d__5>.NativeClassPtr, "<>l__initialThreadId");
				RunDeferredAbilities._execute_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDeferredAbilities._execute_d__5>.NativeClassPtr, "<>4__this");
				RunDeferredAbilities._execute_d__5.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDeferredAbilities._execute_d__5>.NativeClassPtr, "<player>5__2");
				RunDeferredAbilities._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeferredAbilities._execute_d__5>.NativeClassPtr, 100668753);
				RunDeferredAbilities._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeferredAbilities._execute_d__5>.NativeClassPtr, 100668754);
				RunDeferredAbilities._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeferredAbilities._execute_d__5>.NativeClassPtr, 100668755);
				RunDeferredAbilities._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeferredAbilities._execute_d__5>.NativeClassPtr, 100668756);
				RunDeferredAbilities._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeferredAbilities._execute_d__5>.NativeClassPtr, 100668757);
				RunDeferredAbilities._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeferredAbilities._execute_d__5>.NativeClassPtr, 100668758);
				RunDeferredAbilities._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeferredAbilities._execute_d__5>.NativeClassPtr, 100668759);
				RunDeferredAbilities._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeferredAbilities._execute_d__5>.NativeClassPtr, 100668760);
			}

			// Token: 0x06005DF3 RID: 24051 RVA: 0x001D25E4 File Offset: 0x001D07E4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunDeferredAbilities._execute_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeferredAbilities._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005DF4 RID: 24052 RVA: 0x001D262C File Offset: 0x001D082C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeferredAbilities._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005DF5 RID: 24053 RVA: 0x001D2660 File Offset: 0x001D0860
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146479, XrefRangeEnd = 146521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeferredAbilities._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700189E RID: 6302
			// (get) Token: 0x06005DF6 RID: 24054 RVA: 0x001D269C File Offset: 0x001D089C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeferredAbilities._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005DF7 RID: 24055 RVA: 0x001D26DC File Offset: 0x001D08DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146521, XrefRangeEnd = 146526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeferredAbilities._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700189F RID: 6303
			// (get) Token: 0x06005DF8 RID: 24056 RVA: 0x001D2710 File Offset: 0x001D0910
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeferredAbilities._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005DF9 RID: 24057 RVA: 0x001D2750 File Offset: 0x001D0950
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146526, XrefRangeEnd = 146528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeferredAbilities._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005DFA RID: 24058 RVA: 0x001D2790 File Offset: 0x001D0990
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeferredAbilities._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005DFB RID: 24059 RVA: 0x00023568 File Offset: 0x00021768
			public _execute_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001899 RID: 6297
			// (get) Token: 0x06005DFC RID: 24060 RVA: 0x001D27D0 File Offset: 0x001D09D0
			// (set) Token: 0x06005DFD RID: 24061 RVA: 0x00023571 File Offset: 0x00021771
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeferredAbilities._execute_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeferredAbilities._execute_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700189A RID: 6298
			// (get) Token: 0x06005DFE RID: 24062 RVA: 0x001D27F8 File Offset: 0x001D09F8
			// (set) Token: 0x06005DFF RID: 24063 RVA: 0x0002358C File Offset: 0x0002178C
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeferredAbilities._execute_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeferredAbilities._execute_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700189B RID: 6299
			// (get) Token: 0x06005E00 RID: 24064 RVA: 0x001D2828 File Offset: 0x001D0A28
			// (set) Token: 0x06005E01 RID: 24065 RVA: 0x000235AB File Offset: 0x000217AB
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeferredAbilities._execute_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeferredAbilities._execute_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700189C RID: 6300
			// (get) Token: 0x06005E02 RID: 24066 RVA: 0x001D2850 File Offset: 0x001D0A50
			// (set) Token: 0x06005E03 RID: 24067 RVA: 0x000235C6 File Offset: 0x000217C6
			public unsafe RunDeferredAbilities __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeferredAbilities._execute_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunDeferredAbilities>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeferredAbilities._execute_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700189D RID: 6301
			// (get) Token: 0x06005E04 RID: 24068 RVA: 0x001D2880 File Offset: 0x001D0A80
			// (set) Token: 0x06005E05 RID: 24069 RVA: 0x000235E5 File Offset: 0x000217E5
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeferredAbilities._execute_d__5.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeferredAbilities._execute_d__5.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003D02 RID: 15618
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003D03 RID: 15619
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003D04 RID: 15620
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003D05 RID: 15621
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003D06 RID: 15622
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04003D07 RID: 15623
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003D08 RID: 15624
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003D09 RID: 15625
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003D0A RID: 15626
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003D0B RID: 15627
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003D0C RID: 15628
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003D0D RID: 15629
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003D0E RID: 15630
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
