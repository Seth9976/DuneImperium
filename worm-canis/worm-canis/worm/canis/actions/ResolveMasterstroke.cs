using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.context;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.abilities;
using worm.canis.abilities.ActivatedAbilities;
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x02000276 RID: 630
	public class ResolveMasterstroke : global::Canis.actions.Action
	{
		// Token: 0x06001A87 RID: 6791 RVA: 0x000BFF58 File Offset: 0x000BE158
		// Note: this type is marked as 'beforefieldinit'.
		static ResolveMasterstroke()
		{
			Il2CppClassPointerStore<ResolveMasterstroke>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "ResolveMasterstroke");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveMasterstroke>.NativeClassPtr);
			ResolveMasterstroke.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMasterstroke>.NativeClassPtr, "wormMatch");
			ResolveMasterstroke.NativeFieldInfoPtr_masterstrokeEntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMasterstroke>.NativeClassPtr, "masterstrokeEntityID");
			ResolveMasterstroke.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMasterstroke>.NativeClassPtr, 100668395);
			ResolveMasterstroke.NativeMethodInfoPtr__ctor_Public_Void_SerializedResolveMasterstroke_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMasterstroke>.NativeClassPtr, 100668396);
			ResolveMasterstroke.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMasterstroke>.NativeClassPtr, 100668397);
			ResolveMasterstroke.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMasterstroke>.NativeClassPtr, 100668398);
			ResolveMasterstroke.NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMasterstroke>.NativeClassPtr, 100668399);
			ResolveMasterstroke.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMasterstroke>.NativeClassPtr, 100668400);
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x000C0028 File Offset: 0x000BE228
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143338, RefRangeEnd = 143339, XrefRangeStart = 143335, XrefRangeEnd = 143338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResolveMasterstroke(WormMatch m, EntityID entityID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveMasterstroke>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveMasterstroke.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x000C0088 File Offset: 0x000BE288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143339, XrefRangeEnd = 143361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResolveMasterstroke(SerializedResolveMasterstroke serialized, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveMasterstroke>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveMasterstroke.NativeMethodInfoPtr__ctor_Public_Void_SerializedResolveMasterstroke_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x000C00E8 File Offset: 0x000BE2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143361, XrefRangeEnd = 143367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResolveMasterstroke.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x000C0134 File Offset: 0x000BE334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143367, XrefRangeEnd = 143374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> undo(Context undoContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResolveMasterstroke.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x000C0190 File Offset: 0x000BE390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143374, XrefRangeEnd = 143376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HandleReturningAction(global::Canis.actions.Action returningAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(returningAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResolveMasterstroke.NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x000C01E0 File Offset: 0x000BE3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143376, XrefRangeEnd = 143381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResolveMasterstroke.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x0000B6A0 File Offset: 0x000098A0
		public ResolveMasterstroke(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06001A8F RID: 6799 RVA: 0x000C023C File Offset: 0x000BE43C
		// (set) Token: 0x06001A90 RID: 6800 RVA: 0x0000B6A9 File Offset: 0x000098A9
		public unsafe WormMatch wormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke.NativeFieldInfoPtr_wormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06001A91 RID: 6801 RVA: 0x000C026C File Offset: 0x000BE46C
		// (set) Token: 0x06001A92 RID: 6802 RVA: 0x0000B6C8 File Offset: 0x000098C8
		public unsafe EntityID masterstrokeEntityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke.NativeFieldInfoPtr_masterstrokeEntityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke.NativeFieldInfoPtr_masterstrokeEntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400105C RID: 4188
		private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

		// Token: 0x0400105D RID: 4189
		private static readonly IntPtr NativeFieldInfoPtr_masterstrokeEntityID;

		// Token: 0x0400105E RID: 4190
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_EntityID_0;

		// Token: 0x0400105F RID: 4191
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedResolveMasterstroke_Match_0;

		// Token: 0x04001060 RID: 4192
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04001061 RID: 4193
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0;

		// Token: 0x04001062 RID: 4194
		private static readonly IntPtr NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0;

		// Token: 0x04001063 RID: 4195
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x020006B8 RID: 1720
		[ObfuscatedName("worm.canis.actions.ResolveMasterstroke+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005AE7 RID: 23271 RVA: 0x001C9674 File Offset: 0x001C7874
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ResolveMasterstroke.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResolveMasterstroke>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveMasterstroke.__c>.NativeClassPtr);
				ResolveMasterstroke.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMasterstroke.__c>.NativeClassPtr, "<>9");
				ResolveMasterstroke.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMasterstroke.__c>.NativeClassPtr, "<>9__4_0");
				ResolveMasterstroke.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMasterstroke.__c>.NativeClassPtr, "<>9__4_1");
				ResolveMasterstroke.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMasterstroke.__c>.NativeClassPtr, 100668402);
				ResolveMasterstroke.__c.NativeMethodInfoPtr__execute_b__4_0_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMasterstroke.__c>.NativeClassPtr, 100668403);
				ResolveMasterstroke.__c.NativeMethodInfoPtr__execute_b__4_1_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMasterstroke.__c>.NativeClassPtr, 100668404);
			}

			// Token: 0x06005AE8 RID: 23272 RVA: 0x001C9718 File Offset: 0x001C7918
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveMasterstroke.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveMasterstroke.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005AE9 RID: 23273 RVA: 0x001C9754 File Offset: 0x001C7954
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143030, XrefRangeEnd = 143033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<DeferredAbility> _execute_b__4_0(IHasAbilities<WormMatch, WormAbilityDefinition> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveMasterstroke.__c.NativeMethodInfoPtr__execute_b__4_0_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DeferredAbility>>(intPtr3) : null;
				}
			}

			// Token: 0x06005AEA RID: 23274 RVA: 0x001C97A4 File Offset: 0x001C79A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143033, XrefRangeEnd = 143036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__4_1(DeferredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveMasterstroke.__c.NativeMethodInfoPtr__execute_b__4_1_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005AEB RID: 23275 RVA: 0x0002194F File Offset: 0x0001FB4F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001780 RID: 6016
			// (get) Token: 0x06005AEC RID: 23276 RVA: 0x001C97F4 File Offset: 0x001C79F4
			// (set) Token: 0x06005AED RID: 23277 RVA: 0x00021958 File Offset: 0x0001FB58
			public unsafe static ResolveMasterstroke.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResolveMasterstroke.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveMasterstroke.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResolveMasterstroke.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001781 RID: 6017
			// (get) Token: 0x06005AEE RID: 23278 RVA: 0x001C981C File Offset: 0x001C7A1C
			// (set) Token: 0x06005AEF RID: 23279 RVA: 0x0002196A File Offset: 0x0001FB6A
			public unsafe static Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResolveMasterstroke.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResolveMasterstroke.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001782 RID: 6018
			// (get) Token: 0x06005AF0 RID: 23280 RVA: 0x001C9844 File Offset: 0x001C7A44
			// (set) Token: 0x06005AF1 RID: 23281 RVA: 0x0002197C File Offset: 0x0001FB7C
			public unsafe static Func<DeferredAbility, bool> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResolveMasterstroke.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DeferredAbility, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResolveMasterstroke.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B2C RID: 15148
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003B2D RID: 15149
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04003B2E RID: 15150
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x04003B2F RID: 15151
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003B30 RID: 15152
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__4_0_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0;

			// Token: 0x04003B31 RID: 15153
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__4_1_Internal_Boolean_DeferredAbility_0;
		}

		// Token: 0x020006B9 RID: 1721
		[ObfuscatedName("worm.canis.actions.ResolveMasterstroke+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x06005AF2 RID: 23282 RVA: 0x001C986C File Offset: 0x001C7A6C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<ResolveMasterstroke._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResolveMasterstroke>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveMasterstroke._execute_d__4>.NativeClassPtr);
				ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMasterstroke._execute_d__4>.NativeClassPtr, "<>1__state");
				ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMasterstroke._execute_d__4>.NativeClassPtr, "<>2__current");
				ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMasterstroke._execute_d__4>.NativeClassPtr, "<>l__initialThreadId");
				ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMasterstroke._execute_d__4>.NativeClassPtr, "<>4__this");
				ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMasterstroke._execute_d__4>.NativeClassPtr, "<player>5__2");
				ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr__selectedFactions_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMasterstroke._execute_d__4>.NativeClassPtr, "<selectedFactions>5__3");
				ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr__sequenceHelper_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMasterstroke._execute_d__4>.NativeClassPtr, "<sequenceHelper>5__4");
				ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr__skipAdded_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMasterstroke._execute_d__4>.NativeClassPtr, "<skipAdded>5__5");
				ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr__abilityEntityID_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMasterstroke._execute_d__4>.NativeClassPtr, "<abilityEntityID>5__6");
				ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr___7__wrap6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMasterstroke._execute_d__4>.NativeClassPtr, "<>7__wrap6");
				ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr__faction_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMasterstroke._execute_d__4>.NativeClassPtr, "<faction>5__8");
				ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr__childUndo_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMasterstroke._execute_d__4>.NativeClassPtr, "<childUndo>5__9");
				ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr___7__wrap9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMasterstroke._execute_d__4>.NativeClassPtr, "<>7__wrap9");
				ResolveMasterstroke._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMasterstroke._execute_d__4>.NativeClassPtr, 100668405);
				ResolveMasterstroke._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMasterstroke._execute_d__4>.NativeClassPtr, 100668406);
				ResolveMasterstroke._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMasterstroke._execute_d__4>.NativeClassPtr, 100668407);
				ResolveMasterstroke._execute_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMasterstroke._execute_d__4>.NativeClassPtr, 100668408);
				ResolveMasterstroke._execute_d__4.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMasterstroke._execute_d__4>.NativeClassPtr, 100668409);
				ResolveMasterstroke._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMasterstroke._execute_d__4>.NativeClassPtr, 100668410);
				ResolveMasterstroke._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMasterstroke._execute_d__4>.NativeClassPtr, 100668411);
				ResolveMasterstroke._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMasterstroke._execute_d__4>.NativeClassPtr, 100668412);
				ResolveMasterstroke._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMasterstroke._execute_d__4>.NativeClassPtr, 100668413);
				ResolveMasterstroke._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMasterstroke._execute_d__4>.NativeClassPtr, 100668414);
			}

			// Token: 0x06005AF3 RID: 23283 RVA: 0x001C9A64 File Offset: 0x001C7C64
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveMasterstroke._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveMasterstroke._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005AF4 RID: 23284 RVA: 0x001C9AAC File Offset: 0x001C7CAC
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveMasterstroke._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005AF5 RID: 23285 RVA: 0x001C9AE0 File Offset: 0x001C7CE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143036, XrefRangeEnd = 143280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveMasterstroke._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005AF6 RID: 23286 RVA: 0x001C9B1C File Offset: 0x001C7D1C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 143283, RefRangeEnd = 143284, XrefRangeStart = 143280, XrefRangeEnd = 143283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveMasterstroke._execute_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005AF7 RID: 23287 RVA: 0x001C9B50 File Offset: 0x001C7D50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143284, XrefRangeEnd = 143287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveMasterstroke._execute_d__4.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001790 RID: 6032
			// (get) Token: 0x06005AF8 RID: 23288 RVA: 0x001C9B84 File Offset: 0x001C7D84
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveMasterstroke._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005AF9 RID: 23289 RVA: 0x001C9BC4 File Offset: 0x001C7DC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143287, XrefRangeEnd = 143292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveMasterstroke._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001791 RID: 6033
			// (get) Token: 0x06005AFA RID: 23290 RVA: 0x001C9BF8 File Offset: 0x001C7DF8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveMasterstroke._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005AFB RID: 23291 RVA: 0x001C9C38 File Offset: 0x001C7E38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143292, XrefRangeEnd = 143294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveMasterstroke._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005AFC RID: 23292 RVA: 0x001C9C78 File Offset: 0x001C7E78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveMasterstroke._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005AFD RID: 23293 RVA: 0x0002198E File Offset: 0x0001FB8E
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001783 RID: 6019
			// (get) Token: 0x06005AFE RID: 23294 RVA: 0x001C9CB8 File Offset: 0x001C7EB8
			// (set) Token: 0x06005AFF RID: 23295 RVA: 0x00021997 File Offset: 0x0001FB97
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001784 RID: 6020
			// (get) Token: 0x06005B00 RID: 23296 RVA: 0x001C9CE0 File Offset: 0x001C7EE0
			// (set) Token: 0x06005B01 RID: 23297 RVA: 0x000219B2 File Offset: 0x0001FBB2
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001785 RID: 6021
			// (get) Token: 0x06005B02 RID: 23298 RVA: 0x001C9D10 File Offset: 0x001C7F10
			// (set) Token: 0x06005B03 RID: 23299 RVA: 0x000219D1 File Offset: 0x0001FBD1
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001786 RID: 6022
			// (get) Token: 0x06005B04 RID: 23300 RVA: 0x001C9D38 File Offset: 0x001C7F38
			// (set) Token: 0x06005B05 RID: 23301 RVA: 0x000219EC File Offset: 0x0001FBEC
			public unsafe ResolveMasterstroke __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveMasterstroke>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001787 RID: 6023
			// (get) Token: 0x06005B06 RID: 23302 RVA: 0x001C9D68 File Offset: 0x001C7F68
			// (set) Token: 0x06005B07 RID: 23303 RVA: 0x00021A0B File Offset: 0x0001FC0B
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001788 RID: 6024
			// (get) Token: 0x06005B08 RID: 23304 RVA: 0x001C9D98 File Offset: 0x001C7F98
			// (set) Token: 0x06005B09 RID: 23305 RVA: 0x00021A2A File Offset: 0x0001FC2A
			public unsafe List<Factions> _selectedFactions_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr__selectedFactions_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Factions>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr__selectedFactions_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001789 RID: 6025
			// (get) Token: 0x06005B0A RID: 23306 RVA: 0x001C9DC8 File Offset: 0x001C7FC8
			// (set) Token: 0x06005B0B RID: 23307 RVA: 0x00021A49 File Offset: 0x0001FC49
			public unsafe SequenceHelper _sequenceHelper_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr__sequenceHelper_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr__sequenceHelper_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700178A RID: 6026
			// (get) Token: 0x06005B0C RID: 23308 RVA: 0x001C9DF8 File Offset: 0x001C7FF8
			// (set) Token: 0x06005B0D RID: 23309 RVA: 0x00021A68 File Offset: 0x0001FC68
			public unsafe bool _skipAdded_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr__skipAdded_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr__skipAdded_5__5)) = value;
				}
			}

			// Token: 0x1700178B RID: 6027
			// (get) Token: 0x06005B0E RID: 23310 RVA: 0x001C9E20 File Offset: 0x001C8020
			// (set) Token: 0x06005B0F RID: 23311 RVA: 0x00021A83 File Offset: 0x0001FC83
			public unsafe EntityID _abilityEntityID_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr__abilityEntityID_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr__abilityEntityID_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700178C RID: 6028
			// (get) Token: 0x06005B10 RID: 23312 RVA: 0x001C9E50 File Offset: 0x001C8050
			// (set) Token: 0x06005B11 RID: 23313 RVA: 0x00021AA2 File Offset: 0x0001FCA2
			public List<Factions>.Enumerator __7__wrap6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr___7__wrap6);
					return new List<Factions>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<Factions>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr___7__wrap6), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<Factions>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700178D RID: 6029
			// (get) Token: 0x06005B12 RID: 23314 RVA: 0x001C9E80 File Offset: 0x001C8080
			// (set) Token: 0x06005B13 RID: 23315 RVA: 0x00021AD0 File Offset: 0x0001FCD0
			public unsafe Factions _faction_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr__faction_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr__faction_5__8)) = value;
				}
			}

			// Token: 0x1700178E RID: 6030
			// (get) Token: 0x06005B14 RID: 23316 RVA: 0x001C9EA8 File Offset: 0x001C80A8
			// (set) Token: 0x06005B15 RID: 23317 RVA: 0x00021AEB File Offset: 0x0001FCEB
			public unsafe UndoNode _childUndo_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr__childUndo_5__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr__childUndo_5__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700178F RID: 6031
			// (get) Token: 0x06005B16 RID: 23318 RVA: 0x001C9ED8 File Offset: 0x001C80D8
			// (set) Token: 0x06005B17 RID: 23319 RVA: 0x00021B0A File Offset: 0x0001FD0A
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr___7__wrap9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._execute_d__4.NativeFieldInfoPtr___7__wrap9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B32 RID: 15154
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003B33 RID: 15155
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003B34 RID: 15156
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003B35 RID: 15157
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003B36 RID: 15158
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04003B37 RID: 15159
			private static readonly IntPtr NativeFieldInfoPtr__selectedFactions_5__3;

			// Token: 0x04003B38 RID: 15160
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__4;

			// Token: 0x04003B39 RID: 15161
			private static readonly IntPtr NativeFieldInfoPtr__skipAdded_5__5;

			// Token: 0x04003B3A RID: 15162
			private static readonly IntPtr NativeFieldInfoPtr__abilityEntityID_5__6;

			// Token: 0x04003B3B RID: 15163
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap6;

			// Token: 0x04003B3C RID: 15164
			private static readonly IntPtr NativeFieldInfoPtr__faction_5__8;

			// Token: 0x04003B3D RID: 15165
			private static readonly IntPtr NativeFieldInfoPtr__childUndo_5__9;

			// Token: 0x04003B3E RID: 15166
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap9;

			// Token: 0x04003B3F RID: 15167
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003B40 RID: 15168
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003B41 RID: 15169
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003B42 RID: 15170
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003B43 RID: 15171
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04003B44 RID: 15172
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003B45 RID: 15173
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003B46 RID: 15174
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003B47 RID: 15175
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003B48 RID: 15176
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020006BA RID: 1722
		[ObfuscatedName("worm.canis.actions.ResolveMasterstroke+<undo>d__5")]
		public sealed class _undo_d__5 : Object
		{
			// Token: 0x06005B18 RID: 23320 RVA: 0x001C9F08 File Offset: 0x001C8108
			// Note: this type is marked as 'beforefieldinit'.
			static _undo_d__5()
			{
				Il2CppClassPointerStore<ResolveMasterstroke._undo_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResolveMasterstroke>.NativeClassPtr, "<undo>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveMasterstroke._undo_d__5>.NativeClassPtr);
				ResolveMasterstroke._undo_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMasterstroke._undo_d__5>.NativeClassPtr, "<>1__state");
				ResolveMasterstroke._undo_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMasterstroke._undo_d__5>.NativeClassPtr, "<>2__current");
				ResolveMasterstroke._undo_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMasterstroke._undo_d__5>.NativeClassPtr, "<>l__initialThreadId");
				ResolveMasterstroke._undo_d__5.NativeFieldInfoPtr_undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMasterstroke._undo_d__5>.NativeClassPtr, "undoContext");
				ResolveMasterstroke._undo_d__5.NativeFieldInfoPtr___3__undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMasterstroke._undo_d__5>.NativeClassPtr, "<>3__undoContext");
				ResolveMasterstroke._undo_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMasterstroke._undo_d__5>.NativeClassPtr, "<>4__this");
				ResolveMasterstroke._undo_d__5.NativeFieldInfoPtr__undoNode_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMasterstroke._undo_d__5>.NativeClassPtr, "<undoNode>5__2");
				ResolveMasterstroke._undo_d__5.NativeFieldInfoPtr__player_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMasterstroke._undo_d__5>.NativeClassPtr, "<player>5__3");
				ResolveMasterstroke._undo_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMasterstroke._undo_d__5>.NativeClassPtr, 100668415);
				ResolveMasterstroke._undo_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMasterstroke._undo_d__5>.NativeClassPtr, 100668416);
				ResolveMasterstroke._undo_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMasterstroke._undo_d__5>.NativeClassPtr, 100668417);
				ResolveMasterstroke._undo_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMasterstroke._undo_d__5>.NativeClassPtr, 100668418);
				ResolveMasterstroke._undo_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMasterstroke._undo_d__5>.NativeClassPtr, 100668419);
				ResolveMasterstroke._undo_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMasterstroke._undo_d__5>.NativeClassPtr, 100668420);
				ResolveMasterstroke._undo_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMasterstroke._undo_d__5>.NativeClassPtr, 100668421);
				ResolveMasterstroke._undo_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMasterstroke._undo_d__5>.NativeClassPtr, 100668422);
			}

			// Token: 0x06005B19 RID: 23321 RVA: 0x001CA074 File Offset: 0x001C8274
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _undo_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveMasterstroke._undo_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveMasterstroke._undo_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005B1A RID: 23322 RVA: 0x001CA0BC File Offset: 0x001C82BC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveMasterstroke._undo_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B1B RID: 23323 RVA: 0x001CA0F0 File Offset: 0x001C82F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143294, XrefRangeEnd = 143321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveMasterstroke._undo_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700179A RID: 6042
			// (get) Token: 0x06005B1C RID: 23324 RVA: 0x001CA12C File Offset: 0x001C832C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveMasterstroke._undo_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005B1D RID: 23325 RVA: 0x001CA16C File Offset: 0x001C836C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143321, XrefRangeEnd = 143326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveMasterstroke._undo_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700179B RID: 6043
			// (get) Token: 0x06005B1E RID: 23326 RVA: 0x001CA1A0 File Offset: 0x001C83A0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveMasterstroke._undo_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005B1F RID: 23327 RVA: 0x001CA1E0 File Offset: 0x001C83E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143326, XrefRangeEnd = 143335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveMasterstroke._undo_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005B20 RID: 23328 RVA: 0x001CA220 File Offset: 0x001C8420
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveMasterstroke._undo_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005B21 RID: 23329 RVA: 0x00021B29 File Offset: 0x0001FD29
			public _undo_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001792 RID: 6034
			// (get) Token: 0x06005B22 RID: 23330 RVA: 0x001CA260 File Offset: 0x001C8460
			// (set) Token: 0x06005B23 RID: 23331 RVA: 0x00021B32 File Offset: 0x0001FD32
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._undo_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._undo_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001793 RID: 6035
			// (get) Token: 0x06005B24 RID: 23332 RVA: 0x001CA288 File Offset: 0x001C8488
			// (set) Token: 0x06005B25 RID: 23333 RVA: 0x00021B4D File Offset: 0x0001FD4D
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._undo_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._undo_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001794 RID: 6036
			// (get) Token: 0x06005B26 RID: 23334 RVA: 0x001CA2B8 File Offset: 0x001C84B8
			// (set) Token: 0x06005B27 RID: 23335 RVA: 0x00021B6C File Offset: 0x0001FD6C
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._undo_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._undo_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001795 RID: 6037
			// (get) Token: 0x06005B28 RID: 23336 RVA: 0x001CA2E0 File Offset: 0x001C84E0
			// (set) Token: 0x06005B29 RID: 23337 RVA: 0x00021B87 File Offset: 0x0001FD87
			public unsafe Context undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._undo_d__5.NativeFieldInfoPtr_undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._undo_d__5.NativeFieldInfoPtr_undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001796 RID: 6038
			// (get) Token: 0x06005B2A RID: 23338 RVA: 0x001CA310 File Offset: 0x001C8510
			// (set) Token: 0x06005B2B RID: 23339 RVA: 0x00021BA6 File Offset: 0x0001FDA6
			public unsafe Context __3__undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._undo_d__5.NativeFieldInfoPtr___3__undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._undo_d__5.NativeFieldInfoPtr___3__undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001797 RID: 6039
			// (get) Token: 0x06005B2C RID: 23340 RVA: 0x001CA340 File Offset: 0x001C8540
			// (set) Token: 0x06005B2D RID: 23341 RVA: 0x00021BC5 File Offset: 0x0001FDC5
			public unsafe ResolveMasterstroke __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._undo_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveMasterstroke>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._undo_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001798 RID: 6040
			// (get) Token: 0x06005B2E RID: 23342 RVA: 0x001CA370 File Offset: 0x001C8570
			// (set) Token: 0x06005B2F RID: 23343 RVA: 0x00021BE4 File Offset: 0x0001FDE4
			public unsafe UndoNode _undoNode_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._undo_d__5.NativeFieldInfoPtr__undoNode_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._undo_d__5.NativeFieldInfoPtr__undoNode_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001799 RID: 6041
			// (get) Token: 0x06005B30 RID: 23344 RVA: 0x001CA3A0 File Offset: 0x001C85A0
			// (set) Token: 0x06005B31 RID: 23345 RVA: 0x00021C03 File Offset: 0x0001FE03
			public unsafe WormPlayer _player_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._undo_d__5.NativeFieldInfoPtr__player_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveMasterstroke._undo_d__5.NativeFieldInfoPtr__player_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B49 RID: 15177
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003B4A RID: 15178
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003B4B RID: 15179
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003B4C RID: 15180
			private static readonly IntPtr NativeFieldInfoPtr_undoContext;

			// Token: 0x04003B4D RID: 15181
			private static readonly IntPtr NativeFieldInfoPtr___3__undoContext;

			// Token: 0x04003B4E RID: 15182
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003B4F RID: 15183
			private static readonly IntPtr NativeFieldInfoPtr__undoNode_5__2;

			// Token: 0x04003B50 RID: 15184
			private static readonly IntPtr NativeFieldInfoPtr__player_5__3;

			// Token: 0x04003B51 RID: 15185
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003B52 RID: 15186
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003B53 RID: 15187
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003B54 RID: 15188
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003B55 RID: 15189
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003B56 RID: 15190
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003B57 RID: 15191
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003B58 RID: 15192
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
