using System;
using Canis.actions;
using Canis.actions.completions;
using Canis.actions.continuations;
using Canis.context;
using Canis.data;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Networking.selection.targetinformation;

namespace Canis.entities
{
	// Token: 0x020000F0 RID: 240
	public class UndoAbility<TMatchWithUndos> : AbilityDefinitionForGame<TMatchWithUndos> where TMatchWithUndos : Match
	{
		// Token: 0x06000AA3 RID: 2723 RVA: 0x00046CEC File Offset: 0x00044EEC
		// Note: this type is marked as 'beforefieldinit'.
		static UndoAbility()
		{
			Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "UndoAbility`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatchWithUndos>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>>.NativeClassPtr);
			UndoAbility<TMatchWithUndos>.NativeFieldInfoPtr_matchWithUndos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>>.NativeClassPtr, "matchWithUndos");
			UndoAbility<TMatchWithUndos>.NativeFieldInfoPtr_ABILITY_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>>.NativeClassPtr, "ABILITY_NAME");
			UndoAbility<TMatchWithUndos>.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>>.NativeClassPtr, "AbilityID");
			UndoAbility<TMatchWithUndos>.NativeMethodInfoPtr__ctor_Public_Void_TMatchWithUndos_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>>.NativeClassPtr, 100665604);
			UndoAbility<TMatchWithUndos>.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_TMatchWithUndos_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>>.NativeClassPtr, 100665605);
			UndoAbility<TMatchWithUndos>.NativeMethodInfoPtr_GetAbilityKind_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>>.NativeClassPtr, 100665606);
			UndoAbility<TMatchWithUndos>.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>>.NativeClassPtr, 100665607);
			UndoAbility<TMatchWithUndos>.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>>.NativeClassPtr, 100665608);
			UndoAbility<TMatchWithUndos>.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>>.NativeClassPtr, 100665609);
			UndoAbility<TMatchWithUndos>.NativeMethodInfoPtr_AddUndoToSelection_Public_Virtual_Final_New_Void_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>>.NativeClassPtr, 100665610);
			UndoAbility<TMatchWithUndos>.NativeMethodInfoPtr_GetUndoForSelection_Public_IEnumerable_1_UndoAbility_1_TMatchWithUndos_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>>.NativeClassPtr, 100665611);
			UndoAbility<TMatchWithUndos>.NativeMethodInfoPtr_Canis_entities_IUndoableSelection_GetUndoForSelection_Private_Virtual_Final_New_IEnumerable_1_AbilityDefinition_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>>.NativeClassPtr, 100665612);
			UndoAbility<TMatchWithUndos>.NativeMethodInfoPtr_Action_Public_Virtual_IEnumerable_1_Action_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>>.NativeClassPtr, 100665613);
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00046E5C File Offset: 0x0004505C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 567487, RefRangeEnd = 567488, XrefRangeStart = 567483, XrefRangeEnd = 567487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UndoAbility(TMatchWithUndos match)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TMatchWithUndos).IsValueType)
				{
					TMatchWithUndos tmatchWithUndos = match;
					intPtr = ((tmatchWithUndos is string) ? IL2CPP.ManagedStringToIl2Cpp(tmatchWithUndos as string) : IL2CPP.Il2CppObjectBaseToPtr(tmatchWithUndos as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref match;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UndoAbility<TMatchWithUndos>.NativeMethodInfoPtr__ctor_Public_Void_TMatchWithUndos_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00046EE0 File Offset: 0x000450E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 567490, RefRangeEnd = 567492, XrefRangeStart = 567488, XrefRangeEnd = 567490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UndoAbility(SerializedEntity se, TMatchWithUndos m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TMatchWithUndos).IsValueType)
			{
				TMatchWithUndos tmatchWithUndos = m;
				intPtr = ((tmatchWithUndos is string) ? IL2CPP.ManagedStringToIl2Cpp(tmatchWithUndos as string) : IL2CPP.Il2CppObjectBaseToPtr(tmatchWithUndos as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref m;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UndoAbility<TMatchWithUndos>.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_TMatchWithUndos_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00046F88 File Offset: 0x00045188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567492, XrefRangeEnd = 567494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetAbilityKind()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UndoAbility<TMatchWithUndos>.NativeMethodInfoPtr_GetAbilityKind_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x00046FCC File Offset: 0x000451CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567494, XrefRangeEnd = 567496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UndoAbility<TMatchWithUndos>.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00047018 File Offset: 0x00045218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567496, XrefRangeEnd = 567520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<TargetInformation> Targets(Match match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UndoAbility<TMatchWithUndos>.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetInformation>>(intPtr3) : null;
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00047088 File Offset: 0x00045288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567520, XrefRangeEnd = 567525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override CostAction Cost(Match match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UndoAbility<TMatchWithUndos>.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x000470F8 File Offset: 0x000452F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567525, XrefRangeEnd = 567536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddUndoToSelection(Dictionary<EntityID, Il2CppReferenceArray<TargetInformation>> targets, PlayerEntity selectingPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoAbility<TMatchWithUndos>.NativeMethodInfoPtr_AddUndoToSelection_Public_Virtual_Final_New_Void_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0004714C File Offset: 0x0004534C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 567541, RefRangeEnd = 567544, XrefRangeStart = 567536, XrefRangeEnd = 567541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<UndoAbility<TMatchWithUndos>> GetUndoForSelection(PlayerEntity selectingPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoAbility<TMatchWithUndos>.NativeMethodInfoPtr_GetUndoForSelection_Public_IEnumerable_1_UndoAbility_1_TMatchWithUndos_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<UndoAbility<TMatchWithUndos>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x0004719C File Offset: 0x0004539C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567544, XrefRangeEnd = 567549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<AbilityDefinition> Canis_entities_IUndoableSelection_GetUndoForSelection(PlayerEntity selectingPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoAbility<TMatchWithUndos>.NativeMethodInfoPtr_Canis_entities_IUndoableSelection_GetUndoForSelection_Private_Virtual_Final_New_IEnumerable_1_AbilityDefinition_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AbilityDefinition>>(intPtr3) : null;
			}
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x000471EC File Offset: 0x000453EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567549, XrefRangeEnd = 567554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Canis.actions.Action> Action(Match match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UndoAbility<TMatchWithUndos>.NativeMethodInfoPtr_Action_Public_Virtual_IEnumerable_1_Action_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00005E17 File Offset: 0x00004017
		public UndoAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x0004725C File Offset: 0x0004545C
		// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x00047284 File Offset: 0x00045484
		public unsafe TMatchWithUndos matchWithUndos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>.NativeFieldInfoPtr_matchWithUndos);
				return IL2CPP.PointerToValueGeneric<TMatchWithUndos>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>.NativeFieldInfoPtr_matchWithUndos);
				Type typeFromHandle = typeof(TMatchWithUndos);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x0004732C File Offset: 0x0004552C
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x00005E20 File Offset: 0x00004020
		public unsafe static string ABILITY_NAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UndoAbility<TMatchWithUndos>.NativeFieldInfoPtr_ABILITY_NAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UndoAbility<TMatchWithUndos>.NativeFieldInfoPtr_ABILITY_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0004734C File Offset: 0x0004554C
		// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x00005E32 File Offset: 0x00004032
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UndoAbility<TMatchWithUndos>.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UndoAbility<TMatchWithUndos>.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeFieldInfoPtr_matchWithUndos;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeFieldInfoPtr_ABILITY_NAME;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TMatchWithUndos_0;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_TMatchWithUndos_Entity_0;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityKind_Public_Virtual_String_0;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeMethodInfoPtr_AddUndoToSelection_Public_Virtual_Final_New_Void_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_PlayerEntity_0;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeMethodInfoPtr_GetUndoForSelection_Public_IEnumerable_1_UndoAbility_1_TMatchWithUndos_PlayerEntity_0;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeMethodInfoPtr_Canis_entities_IUndoableSelection_GetUndoForSelection_Private_Virtual_Final_New_IEnumerable_1_AbilityDefinition_PlayerEntity_0;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeMethodInfoPtr_Action_Public_Virtual_IEnumerable_1_Action_Match_Context_0;

		// Token: 0x02000336 RID: 822
		[ObfuscatedName("Canis.entities.UndoAbility`1+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x06002247 RID: 8775 RVA: 0x0009A8B0 File Offset: 0x00098AB0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>>.NativeClassPtr, "<>c__DisplayClass12_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatchWithUndos>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>.__c__DisplayClass12_0>.NativeClassPtr);
				UndoAbility<TMatchWithUndos>.__c__DisplayClass12_0.NativeFieldInfoPtr_preUndoSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>.__c__DisplayClass12_0>.NativeClassPtr, "preUndoSelection");
				UndoAbility<TMatchWithUndos>.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>.__c__DisplayClass12_0>.NativeClassPtr, 100665615);
				UndoAbility<TMatchWithUndos>.__c__DisplayClass12_0.NativeMethodInfoPtr__Action_b__0_Internal_ActionContinuation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>.__c__DisplayClass12_0>.NativeClassPtr, 100665616);
				UndoAbility<TMatchWithUndos>.__c__DisplayClass12_0.NativeMethodInfoPtr__Action_b__1_Internal_SelectionCompletion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>.__c__DisplayClass12_0>.NativeClassPtr, 100665617);
			}

			// Token: 0x06002248 RID: 8776 RVA: 0x0009A968 File Offset: 0x00098B68
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoAbility<TMatchWithUndos>.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002249 RID: 8777 RVA: 0x0009A9A4 File Offset: 0x00098BA4
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 567366, RefRangeEnd = 567370, XrefRangeStart = 567366, XrefRangeEnd = 567366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ActionContinuation _Action_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoAbility<TMatchWithUndos>.__c__DisplayClass12_0.NativeMethodInfoPtr__Action_b__0_Internal_ActionContinuation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionContinuation>(intPtr3) : null;
			}

			// Token: 0x0600224A RID: 8778 RVA: 0x0009A9E4 File Offset: 0x00098BE4
			[CallerCount(0)]
			public unsafe SelectionCompletion _Action_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoAbility<TMatchWithUndos>.__c__DisplayClass12_0.NativeMethodInfoPtr__Action_b__1_Internal_SelectionCompletion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionCompletion>(intPtr3) : null;
			}

			// Token: 0x0600224B RID: 8779 RVA: 0x0001071C File Offset: 0x0000E91C
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700084E RID: 2126
			// (get) Token: 0x0600224C RID: 8780 RVA: 0x0009AA24 File Offset: 0x00098C24
			// (set) Token: 0x0600224D RID: 8781 RVA: 0x00010725 File Offset: 0x0000E925
			public unsafe PendingSelection preUndoSelection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>.__c__DisplayClass12_0.NativeFieldInfoPtr_preUndoSelection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PendingSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>.__c__DisplayClass12_0.NativeFieldInfoPtr_preUndoSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400158D RID: 5517
			private static readonly IntPtr NativeFieldInfoPtr_preUndoSelection;

			// Token: 0x0400158E RID: 5518
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400158F RID: 5519
			private static readonly IntPtr NativeMethodInfoPtr__Action_b__0_Internal_ActionContinuation_0;

			// Token: 0x04001590 RID: 5520
			private static readonly IntPtr NativeMethodInfoPtr__Action_b__1_Internal_SelectionCompletion_0;
		}

		// Token: 0x02000337 RID: 823
		[ObfuscatedName("Canis.entities.UndoAbility`1+<Action>d__12")]
		public sealed class _Action_d__12 : Object
		{
			// Token: 0x0600224E RID: 8782 RVA: 0x0009AA54 File Offset: 0x00098C54
			// Note: this type is marked as 'beforefieldinit'.
			static _Action_d__12()
			{
				Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._Action_d__12>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>>.NativeClassPtr, "<Action>d__12"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatchWithUndos>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._Action_d__12>.NativeClassPtr);
				UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._Action_d__12>.NativeClassPtr, "<>1__state");
				UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._Action_d__12>.NativeClassPtr, "<>2__current");
				UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._Action_d__12>.NativeClassPtr, "<>l__initialThreadId");
				UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._Action_d__12>.NativeClassPtr, "<>4__this");
				UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._Action_d__12>.NativeClassPtr, "context");
				UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._Action_d__12>.NativeClassPtr, "<>3__context");
				UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._Action_d__12>.NativeClassPtr, "<>8__1");
				UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr__undoNode_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._Action_d__12>.NativeClassPtr, "<undoNode>5__2");
				UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr__player_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._Action_d__12>.NativeClassPtr, "<player>5__3");
				UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._Action_d__12>.NativeClassPtr, "<>7__wrap3");
				UndoAbility<TMatchWithUndos>._Action_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._Action_d__12>.NativeClassPtr, 100665618);
				UndoAbility<TMatchWithUndos>._Action_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._Action_d__12>.NativeClassPtr, 100665619);
				UndoAbility<TMatchWithUndos>._Action_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._Action_d__12>.NativeClassPtr, 100665620);
				UndoAbility<TMatchWithUndos>._Action_d__12.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._Action_d__12>.NativeClassPtr, 100665621);
				UndoAbility<TMatchWithUndos>._Action_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._Action_d__12>.NativeClassPtr, 100665622);
				UndoAbility<TMatchWithUndos>._Action_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._Action_d__12>.NativeClassPtr, 100665623);
				UndoAbility<TMatchWithUndos>._Action_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._Action_d__12>.NativeClassPtr, 100665624);
				UndoAbility<TMatchWithUndos>._Action_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._Action_d__12>.NativeClassPtr, 100665625);
				UndoAbility<TMatchWithUndos>._Action_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._Action_d__12>.NativeClassPtr, 100665626);
			}

			// Token: 0x0600224F RID: 8783 RVA: 0x0009AC38 File Offset: 0x00098E38
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Action_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._Action_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoAbility<TMatchWithUndos>._Action_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002250 RID: 8784 RVA: 0x0009AC80 File Offset: 0x00098E80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567370, XrefRangeEnd = 567375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoAbility<TMatchWithUndos>._Action_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002251 RID: 8785 RVA: 0x0009ACB4 File Offset: 0x00098EB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567375, XrefRangeEnd = 567470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoAbility<TMatchWithUndos>._Action_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002252 RID: 8786 RVA: 0x0009ACF0 File Offset: 0x00098EF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567470, XrefRangeEnd = 567473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoAbility<TMatchWithUndos>._Action_d__12.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000859 RID: 2137
			// (get) Token: 0x06002253 RID: 8787 RVA: 0x0009AD24 File Offset: 0x00098F24
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoAbility<TMatchWithUndos>._Action_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002254 RID: 8788 RVA: 0x0009AD64 File Offset: 0x00098F64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoAbility<TMatchWithUndos>._Action_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700085A RID: 2138
			// (get) Token: 0x06002255 RID: 8789 RVA: 0x0009AD98 File Offset: 0x00098F98
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoAbility<TMatchWithUndos>._Action_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002256 RID: 8790 RVA: 0x0009ADD8 File Offset: 0x00098FD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoAbility<TMatchWithUndos>._Action_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06002257 RID: 8791 RVA: 0x0009AE18 File Offset: 0x00099018
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567473, XrefRangeEnd = 567481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoAbility<TMatchWithUndos>._Action_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002258 RID: 8792 RVA: 0x00010744 File Offset: 0x0000E944
			public _Action_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700084F RID: 2127
			// (get) Token: 0x06002259 RID: 8793 RVA: 0x0009AE58 File Offset: 0x00099058
			// (set) Token: 0x0600225A RID: 8794 RVA: 0x0001074D File Offset: 0x0000E94D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000850 RID: 2128
			// (get) Token: 0x0600225B RID: 8795 RVA: 0x0009AE80 File Offset: 0x00099080
			// (set) Token: 0x0600225C RID: 8796 RVA: 0x00010768 File Offset: 0x0000E968
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000851 RID: 2129
			// (get) Token: 0x0600225D RID: 8797 RVA: 0x0009AEB0 File Offset: 0x000990B0
			// (set) Token: 0x0600225E RID: 8798 RVA: 0x00010787 File Offset: 0x0000E987
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000852 RID: 2130
			// (get) Token: 0x0600225F RID: 8799 RVA: 0x0009AED8 File Offset: 0x000990D8
			// (set) Token: 0x06002260 RID: 8800 RVA: 0x000107A2 File Offset: 0x0000E9A2
			public unsafe UndoAbility<TMatchWithUndos> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoAbility<TMatchWithUndos>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000853 RID: 2131
			// (get) Token: 0x06002261 RID: 8801 RVA: 0x0009AF08 File Offset: 0x00099108
			// (set) Token: 0x06002262 RID: 8802 RVA: 0x000107C1 File Offset: 0x0000E9C1
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000854 RID: 2132
			// (get) Token: 0x06002263 RID: 8803 RVA: 0x0009AF38 File Offset: 0x00099138
			// (set) Token: 0x06002264 RID: 8804 RVA: 0x000107E0 File Offset: 0x0000E9E0
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000855 RID: 2133
			// (get) Token: 0x06002265 RID: 8805 RVA: 0x0009AF68 File Offset: 0x00099168
			// (set) Token: 0x06002266 RID: 8806 RVA: 0x000107FF File Offset: 0x0000E9FF
			public unsafe UndoAbility<TMatchWithUndos>.__c__DisplayClass12_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoAbility<TMatchWithUndos>.__c__DisplayClass12_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000856 RID: 2134
			// (get) Token: 0x06002267 RID: 8807 RVA: 0x0009AF98 File Offset: 0x00099198
			// (set) Token: 0x06002268 RID: 8808 RVA: 0x0001081E File Offset: 0x0000EA1E
			public unsafe UndoNode _undoNode_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr__undoNode_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr__undoNode_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000857 RID: 2135
			// (get) Token: 0x06002269 RID: 8809 RVA: 0x0009AFC8 File Offset: 0x000991C8
			// (set) Token: 0x0600226A RID: 8810 RVA: 0x0001083D File Offset: 0x0000EA3D
			public unsafe PlayerEntity _player_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr__player_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr__player_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000858 RID: 2136
			// (get) Token: 0x0600226B RID: 8811 RVA: 0x0009AFF8 File Offset: 0x000991F8
			// (set) Token: 0x0600226C RID: 8812 RVA: 0x0001085C File Offset: 0x0000EA5C
			public unsafe IEnumerator<Canis.actions.Action> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._Action_d__12.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001591 RID: 5521
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001592 RID: 5522
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001593 RID: 5523
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001594 RID: 5524
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001595 RID: 5525
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04001596 RID: 5526
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04001597 RID: 5527
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04001598 RID: 5528
			private static readonly IntPtr NativeFieldInfoPtr__undoNode_5__2;

			// Token: 0x04001599 RID: 5529
			private static readonly IntPtr NativeFieldInfoPtr__player_5__3;

			// Token: 0x0400159A RID: 5530
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x0400159B RID: 5531
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400159C RID: 5532
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400159D RID: 5533
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400159E RID: 5534
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400159F RID: 5535
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040015A0 RID: 5536
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015A1 RID: 5537
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040015A2 RID: 5538
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040015A3 RID: 5539
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000338 RID: 824
		[ObfuscatedName("Canis.entities.UndoAbility`1+<GetUndoForSelection>d__10")]
		public sealed class _GetUndoForSelection_d__10 : Object
		{
			// Token: 0x0600226D RID: 8813 RVA: 0x0009B028 File Offset: 0x00099228
			// Note: this type is marked as 'beforefieldinit'.
			static _GetUndoForSelection_d__10()
			{
				Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>>.NativeClassPtr, "<GetUndoForSelection>d__10"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatchWithUndos>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10>.NativeClassPtr);
				UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10>.NativeClassPtr, "<>1__state");
				UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10>.NativeClassPtr, "<>2__current");
				UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10>.NativeClassPtr, "<>l__initialThreadId");
				UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10>.NativeClassPtr, "<>4__this");
				UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeFieldInfoPtr_selectingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10>.NativeClassPtr, "selectingPlayer");
				UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeFieldInfoPtr___3__selectingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10>.NativeClassPtr, "<>3__selectingPlayer");
				UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10>.NativeClassPtr, 100665627);
				UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10>.NativeClassPtr, 100665628);
				UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10>.NativeClassPtr, 100665629);
				UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_UndoAbility_TMatchWithUndos___get_Current_Private_Virtual_Final_New_get_UndoAbility_1_TMatchWithUndos_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10>.NativeClassPtr, 100665630);
				UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10>.NativeClassPtr, 100665631);
				UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10>.NativeClassPtr, 100665632);
				UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_UndoAbility_TMatchWithUndos___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_UndoAbility_1_TMatchWithUndos_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10>.NativeClassPtr, 100665633);
				UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10>.NativeClassPtr, 100665634);
			}

			// Token: 0x0600226E RID: 8814 RVA: 0x0009B1A8 File Offset: 0x000993A8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetUndoForSelection_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600226F RID: 8815 RVA: 0x0009B1F0 File Offset: 0x000993F0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002270 RID: 8816 RVA: 0x0009B224 File Offset: 0x00099424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567481, XrefRangeEnd = 567483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000861 RID: 2145
			// (get) Token: 0x06002271 RID: 8817 RVA: 0x0009B260 File Offset: 0x00099460
			public unsafe UndoAbility<TMatchWithUndos> System.Collections.Generic.IEnumerator<Canis.entities.UndoAbility<TMatchWithUndos>>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_UndoAbility_TMatchWithUndos___get_Current_Private_Virtual_Final_New_get_UndoAbility_1_TMatchWithUndos_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<UndoAbility<TMatchWithUndos>>(intPtr3) : null;
				}
			}

			// Token: 0x06002272 RID: 8818 RVA: 0x0009B2A0 File Offset: 0x000994A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000862 RID: 2146
			// (get) Token: 0x06002273 RID: 8819 RVA: 0x0009B2D4 File Offset: 0x000994D4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002274 RID: 8820 RVA: 0x0009B314 File Offset: 0x00099514
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<UndoAbility<TMatchWithUndos>> System_Collections_Generic_IEnumerable_Canis_entities_UndoAbility_TMatchWithUndos___GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_UndoAbility_TMatchWithUndos___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_UndoAbility_1_TMatchWithUndos_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<UndoAbility<TMatchWithUndos>>>(intPtr3) : null;
			}

			// Token: 0x06002275 RID: 8821 RVA: 0x0009B354 File Offset: 0x00099554
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002276 RID: 8822 RVA: 0x0001087B File Offset: 0x0000EA7B
			public _GetUndoForSelection_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700085B RID: 2139
			// (get) Token: 0x06002277 RID: 8823 RVA: 0x0009B394 File Offset: 0x00099594
			// (set) Token: 0x06002278 RID: 8824 RVA: 0x00010884 File Offset: 0x0000EA84
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700085C RID: 2140
			// (get) Token: 0x06002279 RID: 8825 RVA: 0x0009B3BC File Offset: 0x000995BC
			// (set) Token: 0x0600227A RID: 8826 RVA: 0x0001089F File Offset: 0x0000EA9F
			public unsafe UndoAbility<TMatchWithUndos> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoAbility<TMatchWithUndos>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700085D RID: 2141
			// (get) Token: 0x0600227B RID: 8827 RVA: 0x0009B3EC File Offset: 0x000995EC
			// (set) Token: 0x0600227C RID: 8828 RVA: 0x000108BE File Offset: 0x0000EABE
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700085E RID: 2142
			// (get) Token: 0x0600227D RID: 8829 RVA: 0x0009B414 File Offset: 0x00099614
			// (set) Token: 0x0600227E RID: 8830 RVA: 0x000108D9 File Offset: 0x0000EAD9
			public unsafe UndoAbility<TMatchWithUndos> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoAbility<TMatchWithUndos>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700085F RID: 2143
			// (get) Token: 0x0600227F RID: 8831 RVA: 0x0009B444 File Offset: 0x00099644
			// (set) Token: 0x06002280 RID: 8832 RVA: 0x000108F8 File Offset: 0x0000EAF8
			public unsafe PlayerEntity selectingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeFieldInfoPtr_selectingPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeFieldInfoPtr_selectingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000860 RID: 2144
			// (get) Token: 0x06002281 RID: 8833 RVA: 0x0009B474 File Offset: 0x00099674
			// (set) Token: 0x06002282 RID: 8834 RVA: 0x00010917 File Offset: 0x0000EB17
			public unsafe PlayerEntity __3__selectingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeFieldInfoPtr___3__selectingPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoAbility<TMatchWithUndos>._GetUndoForSelection_d__10.NativeFieldInfoPtr___3__selectingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015A4 RID: 5540
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040015A5 RID: 5541
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040015A6 RID: 5542
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040015A7 RID: 5543
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040015A8 RID: 5544
			private static readonly IntPtr NativeFieldInfoPtr_selectingPlayer;

			// Token: 0x040015A9 RID: 5545
			private static readonly IntPtr NativeFieldInfoPtr___3__selectingPlayer;

			// Token: 0x040015AA RID: 5546
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040015AB RID: 5547
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015AC RID: 5548
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040015AD RID: 5549
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_UndoAbility_TMatchWithUndos___get_Current_Private_Virtual_Final_New_get_UndoAbility_1_TMatchWithUndos_0;

			// Token: 0x040015AE RID: 5550
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015AF RID: 5551
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040015B0 RID: 5552
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_UndoAbility_TMatchWithUndos___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_UndoAbility_1_TMatchWithUndos_0;

			// Token: 0x040015B1 RID: 5553
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
