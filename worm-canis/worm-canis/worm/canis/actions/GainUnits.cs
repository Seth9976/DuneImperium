using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.context;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.abilities;
using worm.canis.abilities.ActivatedAbilities;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x0200024F RID: 591
	public class GainUnits<T> : global::Canis.actions.Action where T : WormUnit
	{
		// Token: 0x06001989 RID: 6537 RVA: 0x000BC1D8 File Offset: 0x000BA3D8
		// Note: this type is marked as 'beforefieldinit'.
		static GainUnits()
		{
			Il2CppClassPointerStore<GainUnits<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "GainUnits`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainUnits<T>>.NativeClassPtr);
			GainUnits<T>.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>>.NativeClassPtr, "amount");
			GainUnits<T>.NativeFieldInfoPtr__LogMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>>.NativeClassPtr, "<LogMode>k__BackingField");
			GainUnits<T>.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>>.NativeClassPtr, 100667931);
			GainUnits<T>.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>>.NativeClassPtr, 100667932);
			GainUnits<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>>.NativeClassPtr, 100667933);
			GainUnits<T>.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>>.NativeClassPtr, 100667934);
			GainUnits<T>.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>>.NativeClassPtr, 100667935);
			GainUnits<T>.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>>.NativeClassPtr, 100667936);
			GainUnits<T>.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>>.NativeClassPtr, 100667937);
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x0600198A RID: 6538 RVA: 0x000BC2F8 File Offset: 0x000BA4F8
		// (set) Token: 0x0600198B RID: 6539 RVA: 0x000BC334 File Offset: 0x000BA534
		public unsafe virtual ActionLogModes LogMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>.NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>.NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x000BC374 File Offset: 0x000BA574
		[CallerCount(56)]
		[CachedScanResults(RefRangeStart = 137491, RefRangeEnd = 137547, XrefRangeStart = 137490, XrefRangeEnd = 137491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainUnits(int amt, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainUnits<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x000BC3D0 File Offset: 0x000BA5D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137553, RefRangeEnd = 137554, XrefRangeStart = 137547, XrefRangeEnd = 137553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ValueTuple<string, Object>> MakeAnalyticsData(WormMatch wormMatch, WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<string, Object>>>(intPtr3) : null;
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x000BC434 File Offset: 0x000BA634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137554, XrefRangeEnd = 137558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainUnits<T>.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x000BC480 File Offset: 0x000BA680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137558, XrefRangeEnd = 137563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> undo(Context undoContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainUnits<T>.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x000BC4DC File Offset: 0x000BA6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137563, XrefRangeEnd = 137580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainUnits<T>.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x0000B067 File Offset: 0x00009267
		public GainUnits(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06001992 RID: 6546 RVA: 0x000BC538 File Offset: 0x000BA738
		// (set) Token: 0x06001993 RID: 6547 RVA: 0x0000B070 File Offset: 0x00009270
		public unsafe int amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>.NativeFieldInfoPtr_amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>.NativeFieldInfoPtr_amount)) = value;
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06001994 RID: 6548 RVA: 0x000BC560 File Offset: 0x000BA760
		// (set) Token: 0x06001995 RID: 6549 RVA: 0x0000B08B File Offset: 0x0000928B
		public unsafe ActionLogModes _LogMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>.NativeFieldInfoPtr__LogMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>.NativeFieldInfoPtr__LogMode_k__BackingField)) = value;
			}
		}

		// Token: 0x04000FC4 RID: 4036
		private static readonly IntPtr NativeFieldInfoPtr_amount;

		// Token: 0x04000FC5 RID: 4037
		private static readonly IntPtr NativeFieldInfoPtr__LogMode_k__BackingField;

		// Token: 0x04000FC6 RID: 4038
		private static readonly IntPtr NativeMethodInfoPtr_get_LogMode_Public_Virtual_Final_New_get_ActionLogModes_0;

		// Token: 0x04000FC7 RID: 4039
		private static readonly IntPtr NativeMethodInfoPtr_set_LogMode_Public_Virtual_Final_New_set_Void_ActionLogModes_0;

		// Token: 0x04000FC8 RID: 4040
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0;

		// Token: 0x04000FC9 RID: 4041
		private static readonly IntPtr NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormMatch_WormPlayer_0;

		// Token: 0x04000FCA RID: 4042
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000FCB RID: 4043
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0;

		// Token: 0x04000FCC RID: 4044
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x02000688 RID: 1672
		[ObfuscatedName("worm.canis.actions.GainUnits`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060056A0 RID: 22176 RVA: 0x001BCC6C File Offset: 0x001BAE6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GainUnits<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainUnits<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainUnits<T>.__c>.NativeClassPtr);
				GainUnits<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>.__c>.NativeClassPtr, "<>9");
				GainUnits<T>.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>.__c>.NativeClassPtr, "<>9__6_0");
				GainUnits<T>.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>.__c>.NativeClassPtr, "<>9__6_1");
				GainUnits<T>.__c.NativeFieldInfoPtr___9__7_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>.__c>.NativeClassPtr, "<>9__7_2");
				GainUnits<T>.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>.__c>.NativeClassPtr, "<>9__7_0");
				GainUnits<T>.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>.__c>.NativeClassPtr, "<>9__7_1");
				GainUnits<T>.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>.__c>.NativeClassPtr, "<>9__8_0");
				GainUnits<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>.__c>.NativeClassPtr, 100667939);
				GainUnits<T>.__c.NativeMethodInfoPtr__MakeAnalyticsData_b__6_0_Internal_Int32_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>.__c>.NativeClassPtr, 100667940);
				GainUnits<T>.__c.NativeMethodInfoPtr__MakeAnalyticsData_b__6_1_Internal_Int32_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>.__c>.NativeClassPtr, 100667941);
				GainUnits<T>.__c.NativeMethodInfoPtr__execute_b__7_2_Internal_EntityID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>.__c>.NativeClassPtr, 100667942);
				GainUnits<T>.__c.NativeMethodInfoPtr__execute_b__7_0_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>.__c>.NativeClassPtr, 100667943);
				GainUnits<T>.__c.NativeMethodInfoPtr__execute_b__7_1_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>.__c>.NativeClassPtr, 100667944);
				GainUnits<T>.__c.NativeMethodInfoPtr__undo_b__8_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>.__c>.NativeClassPtr, 100667945);
			}

			// Token: 0x060056A1 RID: 22177 RVA: 0x001BCDEC File Offset: 0x001BAFEC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainUnits<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056A2 RID: 22178 RVA: 0x001BCE28 File Offset: 0x001BB028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _MakeAnalyticsData_b__6_0(WormUnit wt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(wt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>.__c.NativeMethodInfoPtr__MakeAnalyticsData_b__6_0_Internal_Int32_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060056A3 RID: 22179 RVA: 0x001BCE78 File Offset: 0x001BB078
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _MakeAnalyticsData_b__6_1(WormUnit wt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(wt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>.__c.NativeMethodInfoPtr__MakeAnalyticsData_b__6_1_Internal_Int32_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060056A4 RID: 22180 RVA: 0x001BCEC8 File Offset: 0x001BB0C8
			[CallerCount(0)]
			public unsafe EntityID _execute_b__7_2(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>.__c.NativeMethodInfoPtr__execute_b__7_2_Internal_EntityID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060056A5 RID: 22181 RVA: 0x001BCF18 File Offset: 0x001BB118
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136803, XrefRangeEnd = 136806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<DeferredAbility> _execute_b__7_0(IHasAbilities<WormMatch, WormAbilityDefinition> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>.__c.NativeMethodInfoPtr__execute_b__7_0_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DeferredAbility>>(intPtr3) : null;
				}
			}

			// Token: 0x060056A6 RID: 22182 RVA: 0x001BCF68 File Offset: 0x001BB168
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136806, XrefRangeEnd = 136809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__7_1(DeferredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>.__c.NativeMethodInfoPtr__execute_b__7_1_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060056A7 RID: 22183 RVA: 0x001BCFB8 File Offset: 0x001BB1B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136809, XrefRangeEnd = 136810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _undo_b__8_0(Entity u)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(u);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>.__c.NativeMethodInfoPtr__undo_b__8_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060056A8 RID: 22184 RVA: 0x0001F20B File Offset: 0x0001D40B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015EC RID: 5612
			// (get) Token: 0x060056A9 RID: 22185 RVA: 0x001BD008 File Offset: 0x001BB208
			// (set) Token: 0x060056AA RID: 22186 RVA: 0x0001F214 File Offset: 0x0001D414
			public unsafe static GainUnits<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GainUnits<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainUnits<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GainUnits<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015ED RID: 5613
			// (get) Token: 0x060056AB RID: 22187 RVA: 0x001BD030 File Offset: 0x001BB230
			// (set) Token: 0x060056AC RID: 22188 RVA: 0x0001F226 File Offset: 0x0001D426
			public unsafe static Func<WormUnit, int> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GainUnits<T>.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormUnit, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GainUnits<T>.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015EE RID: 5614
			// (get) Token: 0x060056AD RID: 22189 RVA: 0x001BD058 File Offset: 0x001BB258
			// (set) Token: 0x060056AE RID: 22190 RVA: 0x0001F238 File Offset: 0x0001D438
			public unsafe static Func<WormUnit, int> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GainUnits<T>.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormUnit, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GainUnits<T>.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015EF RID: 5615
			// (get) Token: 0x060056AF RID: 22191 RVA: 0x001BD080 File Offset: 0x001BB280
			// (set) Token: 0x060056B0 RID: 22192 RVA: 0x0001F24A File Offset: 0x0001D44A
			public unsafe static Func<Entity, EntityID> __9__7_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GainUnits<T>.__c.NativeFieldInfoPtr___9__7_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GainUnits<T>.__c.NativeFieldInfoPtr___9__7_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015F0 RID: 5616
			// (get) Token: 0x060056B1 RID: 22193 RVA: 0x001BD0A8 File Offset: 0x001BB2A8
			// (set) Token: 0x060056B2 RID: 22194 RVA: 0x0001F25C File Offset: 0x0001D45C
			public unsafe static Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GainUnits<T>.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GainUnits<T>.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015F1 RID: 5617
			// (get) Token: 0x060056B3 RID: 22195 RVA: 0x001BD0D0 File Offset: 0x001BB2D0
			// (set) Token: 0x060056B4 RID: 22196 RVA: 0x0001F26E File Offset: 0x0001D46E
			public unsafe static Func<DeferredAbility, bool> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GainUnits<T>.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DeferredAbility, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GainUnits<T>.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015F2 RID: 5618
			// (get) Token: 0x060056B5 RID: 22197 RVA: 0x001BD0F8 File Offset: 0x001BB2F8
			// (set) Token: 0x060056B6 RID: 22198 RVA: 0x0001F280 File Offset: 0x0001D480
			public unsafe static Func<Entity, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GainUnits<T>.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GainUnits<T>.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400388D RID: 14477
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400388E RID: 14478
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400388F RID: 14479
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x04003890 RID: 14480
			private static readonly IntPtr NativeFieldInfoPtr___9__7_2;

			// Token: 0x04003891 RID: 14481
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04003892 RID: 14482
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x04003893 RID: 14483
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04003894 RID: 14484
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003895 RID: 14485
			private static readonly IntPtr NativeMethodInfoPtr__MakeAnalyticsData_b__6_0_Internal_Int32_WormUnit_0;

			// Token: 0x04003896 RID: 14486
			private static readonly IntPtr NativeMethodInfoPtr__MakeAnalyticsData_b__6_1_Internal_Int32_WormUnit_0;

			// Token: 0x04003897 RID: 14487
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__7_2_Internal_EntityID_Entity_0;

			// Token: 0x04003898 RID: 14488
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__7_0_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0;

			// Token: 0x04003899 RID: 14489
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__7_1_Internal_Boolean_DeferredAbility_0;

			// Token: 0x0400389A RID: 14490
			private static readonly IntPtr NativeMethodInfoPtr__undo_b__8_0_Internal_Boolean_Entity_0;
		}

		// Token: 0x02000689 RID: 1673
		[ObfuscatedName("worm.canis.actions.GainUnits`1+<MakeAnalyticsData>d__6")]
		public sealed class _MakeAnalyticsData_d__6 : Object
		{
			// Token: 0x060056B7 RID: 22199 RVA: 0x001BD120 File Offset: 0x001BB320
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeAnalyticsData_d__6()
			{
				Il2CppClassPointerStore<GainUnits<T>._MakeAnalyticsData_d__6>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainUnits<T>>.NativeClassPtr, "<MakeAnalyticsData>d__6"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainUnits<T>._MakeAnalyticsData_d__6>.NativeClassPtr);
				GainUnits<T>._MakeAnalyticsData_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._MakeAnalyticsData_d__6>.NativeClassPtr, "<>1__state");
				GainUnits<T>._MakeAnalyticsData_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._MakeAnalyticsData_d__6>.NativeClassPtr, "<>2__current");
				GainUnits<T>._MakeAnalyticsData_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._MakeAnalyticsData_d__6>.NativeClassPtr, "<>l__initialThreadId");
				GainUnits<T>._MakeAnalyticsData_d__6.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._MakeAnalyticsData_d__6>.NativeClassPtr, "wormMatch");
				GainUnits<T>._MakeAnalyticsData_d__6.NativeFieldInfoPtr___3__wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._MakeAnalyticsData_d__6>.NativeClassPtr, "<>3__wormMatch");
				GainUnits<T>._MakeAnalyticsData_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._MakeAnalyticsData_d__6>.NativeClassPtr, "<>4__this");
				GainUnits<T>._MakeAnalyticsData_d__6.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._MakeAnalyticsData_d__6>.NativeClassPtr, "player");
				GainUnits<T>._MakeAnalyticsData_d__6.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._MakeAnalyticsData_d__6>.NativeClassPtr, "<>3__player");
				GainUnits<T>._MakeAnalyticsData_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>._MakeAnalyticsData_d__6>.NativeClassPtr, 100667946);
				GainUnits<T>._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>._MakeAnalyticsData_d__6>.NativeClassPtr, 100667947);
				GainUnits<T>._MakeAnalyticsData_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>._MakeAnalyticsData_d__6>.NativeClassPtr, 100667948);
				GainUnits<T>._MakeAnalyticsData_d__6.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>._MakeAnalyticsData_d__6>.NativeClassPtr, 100667949);
				GainUnits<T>._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>._MakeAnalyticsData_d__6>.NativeClassPtr, 100667950);
				GainUnits<T>._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>._MakeAnalyticsData_d__6>.NativeClassPtr, 100667951);
				GainUnits<T>._MakeAnalyticsData_d__6.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>._MakeAnalyticsData_d__6>.NativeClassPtr, 100667952);
				GainUnits<T>._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>._MakeAnalyticsData_d__6>.NativeClassPtr, 100667953);
			}

			// Token: 0x060056B8 RID: 22200 RVA: 0x001BD2C8 File Offset: 0x001BB4C8
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeAnalyticsData_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainUnits<T>._MakeAnalyticsData_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>._MakeAnalyticsData_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060056B9 RID: 22201 RVA: 0x001BD310 File Offset: 0x001BB510
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056BA RID: 22202 RVA: 0x001BD344 File Offset: 0x001BB544
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136810, XrefRangeEnd = 136926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>._MakeAnalyticsData_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170015FB RID: 5627
			// (get) Token: 0x060056BB RID: 22203 RVA: 0x001BD380 File Offset: 0x001BB580
			public unsafe ValueTuple<string, Object> prop_ValueTuple_2_String_Object_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>._MakeAnalyticsData_d__6.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, Object>(intPtr);
				}
			}

			// Token: 0x060056BC RID: 22204 RVA: 0x001BD3B8 File Offset: 0x001BB5B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170015FC RID: 5628
			// (get) Token: 0x060056BD RID: 22205 RVA: 0x001BD3EC File Offset: 0x001BB5EC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136926, XrefRangeEnd = 136929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060056BE RID: 22206 RVA: 0x001BD42C File Offset: 0x001BB62C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136929, XrefRangeEnd = 136938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<string, Object>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>._MakeAnalyticsData_d__6.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<string, Object>>>(intPtr3) : null;
			}

			// Token: 0x060056BF RID: 22207 RVA: 0x001BD46C File Offset: 0x001BB66C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136938, XrefRangeEnd = 136947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>._MakeAnalyticsData_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060056C0 RID: 22208 RVA: 0x0001F292 File Offset: 0x0001D492
			public _MakeAnalyticsData_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015F3 RID: 5619
			// (get) Token: 0x060056C1 RID: 22209 RVA: 0x001BD4AC File Offset: 0x001BB6AC
			// (set) Token: 0x060056C2 RID: 22210 RVA: 0x0001F29B File Offset: 0x0001D49B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._MakeAnalyticsData_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._MakeAnalyticsData_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170015F4 RID: 5620
			// (get) Token: 0x060056C3 RID: 22211 RVA: 0x001BD4D4 File Offset: 0x001BB6D4
			// (set) Token: 0x060056C4 RID: 22212 RVA: 0x0001F2B6 File Offset: 0x0001D4B6
			public ValueTuple<string, Object> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._MakeAnalyticsData_d__6.NativeFieldInfoPtr___2__current);
					return new ValueTuple<string, Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._MakeAnalyticsData_d__6.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170015F5 RID: 5621
			// (get) Token: 0x060056C5 RID: 22213 RVA: 0x001BD504 File Offset: 0x001BB704
			// (set) Token: 0x060056C6 RID: 22214 RVA: 0x0001F2E4 File Offset: 0x0001D4E4
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._MakeAnalyticsData_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._MakeAnalyticsData_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170015F6 RID: 5622
			// (get) Token: 0x060056C7 RID: 22215 RVA: 0x001BD52C File Offset: 0x001BB72C
			// (set) Token: 0x060056C8 RID: 22216 RVA: 0x0001F2FF File Offset: 0x0001D4FF
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._MakeAnalyticsData_d__6.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._MakeAnalyticsData_d__6.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015F7 RID: 5623
			// (get) Token: 0x060056C9 RID: 22217 RVA: 0x001BD55C File Offset: 0x001BB75C
			// (set) Token: 0x060056CA RID: 22218 RVA: 0x0001F31E File Offset: 0x0001D51E
			public unsafe WormMatch __3__wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._MakeAnalyticsData_d__6.NativeFieldInfoPtr___3__wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._MakeAnalyticsData_d__6.NativeFieldInfoPtr___3__wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015F8 RID: 5624
			// (get) Token: 0x060056CB RID: 22219 RVA: 0x001BD58C File Offset: 0x001BB78C
			// (set) Token: 0x060056CC RID: 22220 RVA: 0x0001F33D File Offset: 0x0001D53D
			public unsafe GainUnits<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._MakeAnalyticsData_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainUnits<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._MakeAnalyticsData_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015F9 RID: 5625
			// (get) Token: 0x060056CD RID: 22221 RVA: 0x001BD5BC File Offset: 0x001BB7BC
			// (set) Token: 0x060056CE RID: 22222 RVA: 0x0001F35C File Offset: 0x0001D55C
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._MakeAnalyticsData_d__6.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._MakeAnalyticsData_d__6.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015FA RID: 5626
			// (get) Token: 0x060056CF RID: 22223 RVA: 0x001BD5EC File Offset: 0x001BB7EC
			// (set) Token: 0x060056D0 RID: 22224 RVA: 0x0001F37B File Offset: 0x0001D57B
			public unsafe WormPlayer __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._MakeAnalyticsData_d__6.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._MakeAnalyticsData_d__6.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400389B RID: 14491
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400389C RID: 14492
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400389D RID: 14493
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400389E RID: 14494
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x0400389F RID: 14495
			private static readonly IntPtr NativeFieldInfoPtr___3__wormMatch;

			// Token: 0x040038A0 RID: 14496
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040038A1 RID: 14497
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040038A2 RID: 14498
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x040038A3 RID: 14499
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040038A4 RID: 14500
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040038A5 RID: 14501
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040038A6 RID: 14502
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0;

			// Token: 0x040038A7 RID: 14503
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040038A8 RID: 14504
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040038A9 RID: 14505
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0;

			// Token: 0x040038AA RID: 14506
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200068A RID: 1674
		[ObfuscatedName("worm.canis.actions.GainUnits`1+<execute>d__7")]
		public sealed class _execute_d__7 : Object
		{
			// Token: 0x060056D1 RID: 22225 RVA: 0x001BD61C File Offset: 0x001BB81C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__7()
			{
				Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainUnits<T>>.NativeClassPtr, "<execute>d__7"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr);
				GainUnits<T>._execute_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr, "<>1__state");
				GainUnits<T>._execute_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr, "<>2__current");
				GainUnits<T>._execute_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr, "<>l__initialThreadId");
				GainUnits<T>._execute_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr, "<>4__this");
				GainUnits<T>._execute_d__7.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr, "<player>5__2");
				GainUnits<T>._execute_d__7.NativeFieldInfoPtr__wm_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr, "<wm>5__3");
				GainUnits<T>._execute_d__7.NativeFieldInfoPtr__unitsToMove_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr, "<unitsToMove>5__4");
				GainUnits<T>._execute_d__7.NativeFieldInfoPtr__amountToMove_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr, "<amountToMove>5__5");
				GainUnits<T>._execute_d__7.NativeFieldInfoPtr__playerGarrison_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr, "<playerGarrison>5__6");
				GainUnits<T>._execute_d__7.NativeFieldInfoPtr__ungainedTroops_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr, "<ungainedTroops>5__7");
				GainUnits<T>._execute_d__7.NativeFieldInfoPtr__isDreadnought_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr, "<isDreadnought>5__8");
				GainUnits<T>._execute_d__7.NativeFieldInfoPtr__logKey_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr, "<logKey>5__9");
				GainUnits<T>._execute_d__7.NativeFieldInfoPtr__logImage_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr, "<logImage>5__10");
				GainUnits<T>._execute_d__7.NativeFieldInfoPtr__childUndo_5__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr, "<childUndo>5__11");
				GainUnits<T>._execute_d__7.NativeFieldInfoPtr___7__wrap11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr, "<>7__wrap11");
				GainUnits<T>._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr, 100667954);
				GainUnits<T>._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr, 100667955);
				GainUnits<T>._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr, 100667956);
				GainUnits<T>._execute_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr, 100667957);
				GainUnits<T>._execute_d__7.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr, 100667958);
				GainUnits<T>._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr, 100667959);
				GainUnits<T>._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr, 100667960);
				GainUnits<T>._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr, 100667961);
				GainUnits<T>._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr, 100667962);
				GainUnits<T>._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr, 100667963);
			}

			// Token: 0x060056D2 RID: 22226 RVA: 0x001BD878 File Offset: 0x001BBA78
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainUnits<T>._execute_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060056D3 RID: 22227 RVA: 0x001BD8C0 File Offset: 0x001BBAC0
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056D4 RID: 22228 RVA: 0x001BD8F4 File Offset: 0x001BBAF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136947, XrefRangeEnd = 137316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060056D5 RID: 22229 RVA: 0x001BD930 File Offset: 0x001BBB30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137316, XrefRangeEnd = 137319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>._execute_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056D6 RID: 22230 RVA: 0x001BD964 File Offset: 0x001BBB64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137319, XrefRangeEnd = 137322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>._execute_d__7.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700160C RID: 5644
			// (get) Token: 0x060056D7 RID: 22231 RVA: 0x001BD998 File Offset: 0x001BBB98
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060056D8 RID: 22232 RVA: 0x001BD9D8 File Offset: 0x001BBBD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700160D RID: 5645
			// (get) Token: 0x060056D9 RID: 22233 RVA: 0x001BDA0C File Offset: 0x001BBC0C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060056DA RID: 22234 RVA: 0x001BDA4C File Offset: 0x001BBC4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137322, XrefRangeEnd = 137323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060056DB RID: 22235 RVA: 0x001BDA8C File Offset: 0x001BBC8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137323, XrefRangeEnd = 137324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060056DC RID: 22236 RVA: 0x0001F39A File Offset: 0x0001D59A
			public _execute_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015FD RID: 5629
			// (get) Token: 0x060056DD RID: 22237 RVA: 0x001BDACC File Offset: 0x001BBCCC
			// (set) Token: 0x060056DE RID: 22238 RVA: 0x0001F3A3 File Offset: 0x0001D5A3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170015FE RID: 5630
			// (get) Token: 0x060056DF RID: 22239 RVA: 0x001BDAF4 File Offset: 0x001BBCF4
			// (set) Token: 0x060056E0 RID: 22240 RVA: 0x0001F3BE File Offset: 0x0001D5BE
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015FF RID: 5631
			// (get) Token: 0x060056E1 RID: 22241 RVA: 0x001BDB24 File Offset: 0x001BBD24
			// (set) Token: 0x060056E2 RID: 22242 RVA: 0x0001F3DD File Offset: 0x0001D5DD
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001600 RID: 5632
			// (get) Token: 0x060056E3 RID: 22243 RVA: 0x001BDB4C File Offset: 0x001BBD4C
			// (set) Token: 0x060056E4 RID: 22244 RVA: 0x0001F3F8 File Offset: 0x0001D5F8
			public unsafe GainUnits<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainUnits<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001601 RID: 5633
			// (get) Token: 0x060056E5 RID: 22245 RVA: 0x001BDB7C File Offset: 0x001BBD7C
			// (set) Token: 0x060056E6 RID: 22246 RVA: 0x0001F417 File Offset: 0x0001D617
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001602 RID: 5634
			// (get) Token: 0x060056E7 RID: 22247 RVA: 0x001BDBAC File Offset: 0x001BBDAC
			// (set) Token: 0x060056E8 RID: 22248 RVA: 0x0001F436 File Offset: 0x0001D636
			public unsafe WormMatch _wm_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr__wm_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr__wm_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001603 RID: 5635
			// (get) Token: 0x060056E9 RID: 22249 RVA: 0x001BDBDC File Offset: 0x001BBDDC
			// (set) Token: 0x060056EA RID: 22250 RVA: 0x0001F455 File Offset: 0x0001D655
			public unsafe Il2CppReferenceArray<Entity> _unitsToMove_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr__unitsToMove_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr__unitsToMove_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001604 RID: 5636
			// (get) Token: 0x060056EB RID: 22251 RVA: 0x001BDC0C File Offset: 0x001BBE0C
			// (set) Token: 0x060056EC RID: 22252 RVA: 0x0001F474 File Offset: 0x0001D674
			public unsafe int _amountToMove_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr__amountToMove_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr__amountToMove_5__5)) = value;
				}
			}

			// Token: 0x17001605 RID: 5637
			// (get) Token: 0x060056ED RID: 22253 RVA: 0x001BDC34 File Offset: 0x001BBE34
			// (set) Token: 0x060056EE RID: 22254 RVA: 0x0001F48F File Offset: 0x0001D68F
			public unsafe WormPlayArea _playerGarrison_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr__playerGarrison_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr__playerGarrison_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001606 RID: 5638
			// (get) Token: 0x060056EF RID: 22255 RVA: 0x001BDC64 File Offset: 0x001BBE64
			// (set) Token: 0x060056F0 RID: 22256 RVA: 0x0001F4AE File Offset: 0x0001D6AE
			public unsafe int _ungainedTroops_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr__ungainedTroops_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr__ungainedTroops_5__7)) = value;
				}
			}

			// Token: 0x17001607 RID: 5639
			// (get) Token: 0x060056F1 RID: 22257 RVA: 0x001BDC8C File Offset: 0x001BBE8C
			// (set) Token: 0x060056F2 RID: 22258 RVA: 0x0001F4C9 File Offset: 0x0001D6C9
			public unsafe bool _isDreadnought_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr__isDreadnought_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr__isDreadnought_5__8)) = value;
				}
			}

			// Token: 0x17001608 RID: 5640
			// (get) Token: 0x060056F3 RID: 22259 RVA: 0x001BDCB4 File Offset: 0x001BBEB4
			// (set) Token: 0x060056F4 RID: 22260 RVA: 0x0001F4E4 File Offset: 0x0001D6E4
			public unsafe string _logKey_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr__logKey_5__9);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr__logKey_5__9), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001609 RID: 5641
			// (get) Token: 0x060056F5 RID: 22261 RVA: 0x001BDCDC File Offset: 0x001BBEDC
			// (set) Token: 0x060056F6 RID: 22262 RVA: 0x0001F503 File Offset: 0x0001D703
			public unsafe string _logImage_5__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr__logImage_5__10);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr__logImage_5__10), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700160A RID: 5642
			// (get) Token: 0x060056F7 RID: 22263 RVA: 0x001BDD04 File Offset: 0x001BBF04
			// (set) Token: 0x060056F8 RID: 22264 RVA: 0x0001F522 File Offset: 0x0001D722
			public unsafe UndoNode _childUndo_5__11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr__childUndo_5__11);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr__childUndo_5__11), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700160B RID: 5643
			// (get) Token: 0x060056F9 RID: 22265 RVA: 0x001BDD34 File Offset: 0x001BBF34
			// (set) Token: 0x060056FA RID: 22266 RVA: 0x0001F541 File Offset: 0x0001D741
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr___7__wrap11);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._execute_d__7.NativeFieldInfoPtr___7__wrap11), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040038AB RID: 14507
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040038AC RID: 14508
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040038AD RID: 14509
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040038AE RID: 14510
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040038AF RID: 14511
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x040038B0 RID: 14512
			private static readonly IntPtr NativeFieldInfoPtr__wm_5__3;

			// Token: 0x040038B1 RID: 14513
			private static readonly IntPtr NativeFieldInfoPtr__unitsToMove_5__4;

			// Token: 0x040038B2 RID: 14514
			private static readonly IntPtr NativeFieldInfoPtr__amountToMove_5__5;

			// Token: 0x040038B3 RID: 14515
			private static readonly IntPtr NativeFieldInfoPtr__playerGarrison_5__6;

			// Token: 0x040038B4 RID: 14516
			private static readonly IntPtr NativeFieldInfoPtr__ungainedTroops_5__7;

			// Token: 0x040038B5 RID: 14517
			private static readonly IntPtr NativeFieldInfoPtr__isDreadnought_5__8;

			// Token: 0x040038B6 RID: 14518
			private static readonly IntPtr NativeFieldInfoPtr__logKey_5__9;

			// Token: 0x040038B7 RID: 14519
			private static readonly IntPtr NativeFieldInfoPtr__logImage_5__10;

			// Token: 0x040038B8 RID: 14520
			private static readonly IntPtr NativeFieldInfoPtr__childUndo_5__11;

			// Token: 0x040038B9 RID: 14521
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap11;

			// Token: 0x040038BA RID: 14522
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040038BB RID: 14523
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040038BC RID: 14524
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040038BD RID: 14525
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040038BE RID: 14526
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x040038BF RID: 14527
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040038C0 RID: 14528
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040038C1 RID: 14529
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040038C2 RID: 14530
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040038C3 RID: 14531
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200068B RID: 1675
		[ObfuscatedName("worm.canis.actions.GainUnits`1+<undo>d__8")]
		public sealed class _undo_d__8 : Object
		{
			// Token: 0x060056FB RID: 22267 RVA: 0x001BDD64 File Offset: 0x001BBF64
			// Note: this type is marked as 'beforefieldinit'.
			static _undo_d__8()
			{
				Il2CppClassPointerStore<GainUnits<T>._undo_d__8>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainUnits<T>>.NativeClassPtr, "<undo>d__8"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainUnits<T>._undo_d__8>.NativeClassPtr);
				GainUnits<T>._undo_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._undo_d__8>.NativeClassPtr, "<>1__state");
				GainUnits<T>._undo_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._undo_d__8>.NativeClassPtr, "<>2__current");
				GainUnits<T>._undo_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._undo_d__8>.NativeClassPtr, "<>l__initialThreadId");
				GainUnits<T>._undo_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._undo_d__8>.NativeClassPtr, "<>4__this");
				GainUnits<T>._undo_d__8.NativeFieldInfoPtr_undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._undo_d__8>.NativeClassPtr, "undoContext");
				GainUnits<T>._undo_d__8.NativeFieldInfoPtr___3__undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._undo_d__8>.NativeClassPtr, "<>3__undoContext");
				GainUnits<T>._undo_d__8.NativeFieldInfoPtr__wm_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._undo_d__8>.NativeClassPtr, "<wm>5__2");
				GainUnits<T>._undo_d__8.NativeFieldInfoPtr__player_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._undo_d__8>.NativeClassPtr, "<player>5__3");
				GainUnits<T>._undo_d__8.NativeFieldInfoPtr__undoNode_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._undo_d__8>.NativeClassPtr, "<undoNode>5__4");
				GainUnits<T>._undo_d__8.NativeFieldInfoPtr__gainedUnits_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnits<T>._undo_d__8>.NativeClassPtr, "<gainedUnits>5__5");
				GainUnits<T>._undo_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>._undo_d__8>.NativeClassPtr, 100667964);
				GainUnits<T>._undo_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>._undo_d__8>.NativeClassPtr, 100667965);
				GainUnits<T>._undo_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>._undo_d__8>.NativeClassPtr, 100667966);
				GainUnits<T>._undo_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>._undo_d__8>.NativeClassPtr, 100667967);
				GainUnits<T>._undo_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>._undo_d__8>.NativeClassPtr, 100667968);
				GainUnits<T>._undo_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>._undo_d__8>.NativeClassPtr, 100667969);
				GainUnits<T>._undo_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>._undo_d__8>.NativeClassPtr, 100667970);
				GainUnits<T>._undo_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnits<T>._undo_d__8>.NativeClassPtr, 100667971);
			}

			// Token: 0x060056FC RID: 22268 RVA: 0x001BDF34 File Offset: 0x001BC134
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _undo_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainUnits<T>._undo_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>._undo_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060056FD RID: 22269 RVA: 0x001BDF7C File Offset: 0x001BC17C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>._undo_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056FE RID: 22270 RVA: 0x001BDFB0 File Offset: 0x001BC1B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137324, XrefRangeEnd = 137474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>._undo_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001618 RID: 5656
			// (get) Token: 0x060056FF RID: 22271 RVA: 0x001BDFEC File Offset: 0x001BC1EC
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>._undo_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005700 RID: 22272 RVA: 0x001BE02C File Offset: 0x001BC22C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>._undo_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001619 RID: 5657
			// (get) Token: 0x06005701 RID: 22273 RVA: 0x001BE060 File Offset: 0x001BC260
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>._undo_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005702 RID: 22274 RVA: 0x001BE0A0 File Offset: 0x001BC2A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137474, XrefRangeEnd = 137482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>._undo_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005703 RID: 22275 RVA: 0x001BE0E0 File Offset: 0x001BC2E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137482, XrefRangeEnd = 137490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainUnits<T>._undo_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005704 RID: 22276 RVA: 0x0001F560 File Offset: 0x0001D760
			public _undo_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700160E RID: 5646
			// (get) Token: 0x06005705 RID: 22277 RVA: 0x001BE120 File Offset: 0x001BC320
			// (set) Token: 0x06005706 RID: 22278 RVA: 0x0001F569 File Offset: 0x0001D769
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._undo_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._undo_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700160F RID: 5647
			// (get) Token: 0x06005707 RID: 22279 RVA: 0x001BE148 File Offset: 0x001BC348
			// (set) Token: 0x06005708 RID: 22280 RVA: 0x0001F584 File Offset: 0x0001D784
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._undo_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._undo_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001610 RID: 5648
			// (get) Token: 0x06005709 RID: 22281 RVA: 0x001BE178 File Offset: 0x001BC378
			// (set) Token: 0x0600570A RID: 22282 RVA: 0x0001F5A3 File Offset: 0x0001D7A3
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._undo_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._undo_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001611 RID: 5649
			// (get) Token: 0x0600570B RID: 22283 RVA: 0x001BE1A0 File Offset: 0x001BC3A0
			// (set) Token: 0x0600570C RID: 22284 RVA: 0x0001F5BE File Offset: 0x0001D7BE
			public unsafe GainUnits<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._undo_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainUnits<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._undo_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001612 RID: 5650
			// (get) Token: 0x0600570D RID: 22285 RVA: 0x001BE1D0 File Offset: 0x001BC3D0
			// (set) Token: 0x0600570E RID: 22286 RVA: 0x0001F5DD File Offset: 0x0001D7DD
			public unsafe Context undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._undo_d__8.NativeFieldInfoPtr_undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._undo_d__8.NativeFieldInfoPtr_undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001613 RID: 5651
			// (get) Token: 0x0600570F RID: 22287 RVA: 0x001BE200 File Offset: 0x001BC400
			// (set) Token: 0x06005710 RID: 22288 RVA: 0x0001F5FC File Offset: 0x0001D7FC
			public unsafe Context __3__undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._undo_d__8.NativeFieldInfoPtr___3__undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._undo_d__8.NativeFieldInfoPtr___3__undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001614 RID: 5652
			// (get) Token: 0x06005711 RID: 22289 RVA: 0x001BE230 File Offset: 0x001BC430
			// (set) Token: 0x06005712 RID: 22290 RVA: 0x0001F61B File Offset: 0x0001D81B
			public unsafe WormMatch _wm_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._undo_d__8.NativeFieldInfoPtr__wm_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._undo_d__8.NativeFieldInfoPtr__wm_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001615 RID: 5653
			// (get) Token: 0x06005713 RID: 22291 RVA: 0x001BE260 File Offset: 0x001BC460
			// (set) Token: 0x06005714 RID: 22292 RVA: 0x0001F63A File Offset: 0x0001D83A
			public unsafe WormPlayer _player_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._undo_d__8.NativeFieldInfoPtr__player_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._undo_d__8.NativeFieldInfoPtr__player_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001616 RID: 5654
			// (get) Token: 0x06005715 RID: 22293 RVA: 0x001BE290 File Offset: 0x001BC490
			// (set) Token: 0x06005716 RID: 22294 RVA: 0x0001F659 File Offset: 0x0001D859
			public unsafe UndoNode _undoNode_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._undo_d__8.NativeFieldInfoPtr__undoNode_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._undo_d__8.NativeFieldInfoPtr__undoNode_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001617 RID: 5655
			// (get) Token: 0x06005717 RID: 22295 RVA: 0x001BE2C0 File Offset: 0x001BC4C0
			// (set) Token: 0x06005718 RID: 22296 RVA: 0x0001F678 File Offset: 0x0001D878
			public unsafe Il2CppReferenceArray<Entity> _gainedUnits_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._undo_d__8.NativeFieldInfoPtr__gainedUnits_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainUnits<T>._undo_d__8.NativeFieldInfoPtr__gainedUnits_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040038C4 RID: 14532
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040038C5 RID: 14533
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040038C6 RID: 14534
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040038C7 RID: 14535
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040038C8 RID: 14536
			private static readonly IntPtr NativeFieldInfoPtr_undoContext;

			// Token: 0x040038C9 RID: 14537
			private static readonly IntPtr NativeFieldInfoPtr___3__undoContext;

			// Token: 0x040038CA RID: 14538
			private static readonly IntPtr NativeFieldInfoPtr__wm_5__2;

			// Token: 0x040038CB RID: 14539
			private static readonly IntPtr NativeFieldInfoPtr__player_5__3;

			// Token: 0x040038CC RID: 14540
			private static readonly IntPtr NativeFieldInfoPtr__undoNode_5__4;

			// Token: 0x040038CD RID: 14541
			private static readonly IntPtr NativeFieldInfoPtr__gainedUnits_5__5;

			// Token: 0x040038CE RID: 14542
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040038CF RID: 14543
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040038D0 RID: 14544
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040038D1 RID: 14545
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040038D2 RID: 14546
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040038D3 RID: 14547
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040038D4 RID: 14548
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040038D5 RID: 14549
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
