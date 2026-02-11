using System;
using Canis.attributes;
using Canis.context;
using Canis.context.targetpickers;
using Canis.entities.ai;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Networking.selection.targetinformation;

namespace Canis.entities
{
	// Token: 0x020000BE RID: 190
	public static class AbilityDefinitionUtils : Object
	{
		// Token: 0x060008C5 RID: 2245 RVA: 0x0003D3AC File Offset: 0x0003B5AC
		// Note: this type is marked as 'beforefieldinit'.
		static AbilityDefinitionUtils()
		{
			Il2CppClassPointerStore<AbilityDefinitionUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "AbilityDefinitionUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityDefinitionUtils>.NativeClassPtr);
			AbilityDefinitionUtils.NativeMethodInfoPtr_GetTargetsFromQueue_Public_Static_IEnumerable_1_TargetType_AbilityDefinitionForGame_1_TMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinitionUtils>.NativeClassPtr, 100665105);
			AbilityDefinitionUtils.NativeMethodInfoPtr_GetTargetsFromQueue_Public_Static_IEnumerable_1_TargetType_AbilityDefinitionForGame_1_TMatch_TargetResponseQueue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinitionUtils>.NativeClassPtr, 100665106);
			AbilityDefinitionUtils.NativeMethodInfoPtr_GetTargetFromQueue_Public_Static_TargetType_AbilityDefinitionForGame_1_TMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinitionUtils>.NativeClassPtr, 100665107);
			AbilityDefinitionUtils.NativeMethodInfoPtr_GetTargetFromQueue_Public_Static_TargetType_AbilityDefinitionForGame_1_TMatch_TargetResponseQueue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinitionUtils>.NativeClassPtr, 100665108);
			AbilityDefinitionUtils.NativeMethodInfoPtr_MakeEvaluatorAttribute_Public_Static_MutableAttribute_1_AIEvaluator_AbilityDefinitionForGame_1_TMatch_AIEvaluateSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinitionUtils>.NativeClassPtr, 100665109);
			AbilityDefinitionUtils.NativeMethodInfoPtr_AppendAttribute_Public_Static_IEnumerable_1_IAttribute_IEnumerable_1_IAttribute_MutableAttribute_1_TAttrValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinitionUtils>.NativeClassPtr, 100665110);
			AbilityDefinitionUtils.NativeMethodInfoPtr_MakeEntityListTargetInformation_Public_Static_EntityListTargetInformation_AbilityDefinitionForGame_1_TMatch_IEnumerable_1_Entity_PlayerEntity_LocalizableTextVariables_AIEvaluateSelection_String_Boolean_Boolean_Int32_Int32_IEnumerable_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinitionUtils>.NativeClassPtr, 100665111);
			AbilityDefinitionUtils.NativeMethodInfoPtr_MakeArchetypeCustomChoiceTargetInformation_Public_Static_ArchetypeCustomChoiceTargetInformation_AbilityDefinitionForGame_1_TMatch_IEnumerable_1_SerializableAttributes_PlayerEntity_LocalizableTextVariables_AIEvaluateSelection_String_Boolean_Boolean_Int32_Int32_IEnumerable_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinitionUtils>.NativeClassPtr, 100665112);
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x0003D47C File Offset: 0x0003B67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561289, XrefRangeEnd = 561297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TargetType> GetTargetsFromQueue<TargetType, TMatch>(AbilityDefinitionForGame<TMatch> ability, Context context) where TargetType : Entity where TMatch : Match
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinitionUtils.MethodInfoStoreGeneric_GetTargetsFromQueue_Public_Static_IEnumerable_1_TargetType_AbilityDefinitionForGame_1_TMatch_Context_0<TargetType, TMatch>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetType>>(intPtr3) : null;
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x0003D4D4 File Offset: 0x0003B6D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 561314, RefRangeEnd = 561317, XrefRangeStart = 561297, XrefRangeEnd = 561314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TargetType> GetTargetsFromQueue<TargetType, TMatch>(AbilityDefinitionForGame<TMatch> ability, TargetResponseQueue trq) where TargetType : Entity where TMatch : Match
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trq);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinitionUtils.MethodInfoStoreGeneric_GetTargetsFromQueue_Public_Static_IEnumerable_1_TargetType_AbilityDefinitionForGame_1_TMatch_TargetResponseQueue_0<TargetType, TMatch>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetType>>(intPtr3) : null;
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x0003D52C File Offset: 0x0003B72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561317, XrefRangeEnd = 561327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TargetType GetTargetFromQueue<TargetType, TMatch>(AbilityDefinitionForGame<TMatch> ability, Context context) where TargetType : Entity where TMatch : Match
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinitionUtils.MethodInfoStoreGeneric_GetTargetFromQueue_Public_Static_TargetType_AbilityDefinitionForGame_1_TMatch_Context_0<TargetType, TMatch>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TargetType>(intPtr, false, true);
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x0003D57C File Offset: 0x0003B77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561327, XrefRangeEnd = 561330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TargetType GetTargetFromQueue<TargetType, TMatch>(AbilityDefinitionForGame<TMatch> ability, TargetResponseQueue trq) where TargetType : Entity where TMatch : Match
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trq);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinitionUtils.MethodInfoStoreGeneric_GetTargetFromQueue_Public_Static_TargetType_AbilityDefinitionForGame_1_TMatch_TargetResponseQueue_0<TargetType, TMatch>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TargetType>(intPtr, false, true);
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x0003D5CC File Offset: 0x0003B7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561330, XrefRangeEnd = 561334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MutableAttribute<AIEvaluator> MakeEvaluatorAttribute<TMatch>(AbilityDefinitionForGame<TMatch> ability, AIEvaluateSelection abilityEvaluator) where TMatch : Match
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(abilityEvaluator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinitionUtils.MethodInfoStoreGeneric_MakeEvaluatorAttribute_Public_Static_MutableAttribute_1_AIEvaluator_AbilityDefinitionForGame_1_TMatch_AIEvaluateSelection_0<TMatch>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MutableAttribute<AIEvaluator>>(intPtr3) : null;
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x0003D624 File Offset: 0x0003B824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561334, XrefRangeEnd = 561337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<IAttribute> AppendAttribute<TAttrValue>(this IEnumerable<IAttribute> attributes, MutableAttribute<TAttrValue> attr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinitionUtils.MethodInfoStoreGeneric_AppendAttribute_Public_Static_IEnumerable_1_IAttribute_IEnumerable_1_IAttribute_MutableAttribute_1_TAttrValue_0<TAttrValue>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0003D67C File Offset: 0x0003B87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561337, XrefRangeEnd = 561405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EntityListTargetInformation MakeEntityListTargetInformation<TMatch>(AbilityDefinitionForGame<TMatch> ability, IEnumerable<Entity> targets, PlayerEntity player, LocalizableTextVariables prompt, AIEvaluateSelection evaluator = null, string kind = null, bool forced = true, bool deferDrag = false, int max = 1, int min = -1, IEnumerable<IAttribute> attributes = null) where TMatch : Match
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targets);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prompt);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evaluator);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(kind);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forced;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deferDrag;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinitionUtils.MethodInfoStoreGeneric_MakeEntityListTargetInformation_Public_Static_EntityListTargetInformation_AbilityDefinitionForGame_1_TMatch_IEnumerable_1_Entity_PlayerEntity_LocalizableTextVariables_AIEvaluateSelection_String_Boolean_Boolean_Int32_Int32_IEnumerable_1_IAttribute_0<TMatch>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityListTargetInformation>(intPtr3) : null;
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x0003D76C File Offset: 0x0003B96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561405, XrefRangeEnd = 561457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArchetypeCustomChoiceTargetInformation MakeArchetypeCustomChoiceTargetInformation<TMatch>(AbilityDefinitionForGame<TMatch> ability, IEnumerable<SerializableAttributes> choices, PlayerEntity player, LocalizableTextVariables prompt, AIEvaluateSelection evaluator = null, string kind = null, bool forced = true, bool deferDrag = false, int max = 1, int min = -1, IEnumerable<IAttribute> attributes = null) where TMatch : Match
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(choices);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prompt);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evaluator);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(kind);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forced;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deferDrag;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinitionUtils.MethodInfoStoreGeneric_MakeArchetypeCustomChoiceTargetInformation_Public_Static_ArchetypeCustomChoiceTargetInformation_AbilityDefinitionForGame_1_TMatch_IEnumerable_1_SerializableAttributes_PlayerEntity_LocalizableTextVariables_AIEvaluateSelection_String_Boolean_Boolean_Int32_Int32_IEnumerable_1_IAttribute_0<TMatch>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeCustomChoiceTargetInformation>(intPtr3) : null;
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00005690 File Offset: 0x00003890
		public AbilityDefinitionUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetsFromQueue_Public_Static_IEnumerable_1_TargetType_AbilityDefinitionForGame_1_TMatch_Context_0;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetsFromQueue_Public_Static_IEnumerable_1_TargetType_AbilityDefinitionForGame_1_TMatch_TargetResponseQueue_0;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetFromQueue_Public_Static_TargetType_AbilityDefinitionForGame_1_TMatch_Context_0;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetFromQueue_Public_Static_TargetType_AbilityDefinitionForGame_1_TMatch_TargetResponseQueue_0;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeMethodInfoPtr_MakeEvaluatorAttribute_Public_Static_MutableAttribute_1_AIEvaluator_AbilityDefinitionForGame_1_TMatch_AIEvaluateSelection_0;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeMethodInfoPtr_AppendAttribute_Public_Static_IEnumerable_1_IAttribute_IEnumerable_1_IAttribute_MutableAttribute_1_TAttrValue_0;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeMethodInfoPtr_MakeEntityListTargetInformation_Public_Static_EntityListTargetInformation_AbilityDefinitionForGame_1_TMatch_IEnumerable_1_Entity_PlayerEntity_LocalizableTextVariables_AIEvaluateSelection_String_Boolean_Boolean_Int32_Int32_IEnumerable_1_IAttribute_0;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeMethodInfoPtr_MakeArchetypeCustomChoiceTargetInformation_Public_Static_ArchetypeCustomChoiceTargetInformation_AbilityDefinitionForGame_1_TMatch_IEnumerable_1_SerializableAttributes_PlayerEntity_LocalizableTextVariables_AIEvaluateSelection_String_Boolean_Boolean_Int32_Int32_IEnumerable_1_IAttribute_0;

		// Token: 0x020002F9 RID: 761
		[ObfuscatedName("Canis.entities.AbilityDefinitionUtils+<>c__6`1")]
		[Serializable]
		public sealed class __c__6<TMatch> : Object where TMatch : Match
		{
			// Token: 0x06001FBB RID: 8123 RVA: 0x0009184C File Offset: 0x0008FA4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__6()
			{
				Il2CppClassPointerStore<AbilityDefinitionUtils.__c__6<TMatch>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityDefinitionUtils>.NativeClassPtr, "<>c__6`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityDefinitionUtils.__c__6<TMatch>>.NativeClassPtr);
				AbilityDefinitionUtils.__c__6<TMatch>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDefinitionUtils.__c__6<TMatch>>.NativeClassPtr, "<>9");
				AbilityDefinitionUtils.__c__6<TMatch>.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDefinitionUtils.__c__6<TMatch>>.NativeClassPtr, "<>9__6_0");
				AbilityDefinitionUtils.__c__6<TMatch>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinitionUtils.__c__6<TMatch>>.NativeClassPtr, 100665114);
				AbilityDefinitionUtils.__c__6<TMatch>.NativeMethodInfoPtr__MakeEntityListTargetInformation_b__6_0_Internal_EntityID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinitionUtils.__c__6<TMatch>>.NativeClassPtr, 100665115);
			}

			// Token: 0x06001FBC RID: 8124 RVA: 0x00091904 File Offset: 0x0008FB04
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__6()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityDefinitionUtils.__c__6<TMatch>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinitionUtils.__c__6<TMatch>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FBD RID: 8125 RVA: 0x00091940 File Offset: 0x0008FB40
			[CallerCount(0)]
			public unsafe EntityID _MakeEntityListTargetInformation_b__6_0(Entity t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinitionUtils.__c__6<TMatch>.NativeMethodInfoPtr__MakeEntityListTargetInformation_b__6_0_Internal_EntityID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06001FBE RID: 8126 RVA: 0x0000F46B File Offset: 0x0000D66B
			public __c__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700077C RID: 1916
			// (get) Token: 0x06001FBF RID: 8127 RVA: 0x00091990 File Offset: 0x0008FB90
			// (set) Token: 0x06001FC0 RID: 8128 RVA: 0x0000F474 File Offset: 0x0000D674
			public unsafe static AbilityDefinitionUtils.__c__6<TMatch> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AbilityDefinitionUtils.__c__6<TMatch>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityDefinitionUtils.__c__6<TMatch>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AbilityDefinitionUtils.__c__6<TMatch>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700077D RID: 1917
			// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x000919B8 File Offset: 0x0008FBB8
			// (set) Token: 0x06001FC2 RID: 8130 RVA: 0x0000F486 File Offset: 0x0000D686
			public unsafe static Func<Entity, EntityID> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AbilityDefinitionUtils.__c__6<TMatch>.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AbilityDefinitionUtils.__c__6<TMatch>.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013FF RID: 5119
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001400 RID: 5120
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04001401 RID: 5121
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001402 RID: 5122
			private static readonly IntPtr NativeMethodInfoPtr__MakeEntityListTargetInformation_b__6_0_Internal_EntityID_Entity_0;
		}

		// Token: 0x020002FA RID: 762
		[ObfuscatedName("Canis.entities.AbilityDefinitionUtils+<>c__DisplayClass1_0`2")]
		public sealed class __c__DisplayClass1_0<TargetType, TMatch> : Object where TargetType : Entity where TMatch : Match
		{
			// Token: 0x06001FC3 RID: 8131 RVA: 0x000919E0 File Offset: 0x0008FBE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<AbilityDefinitionUtils.__c__DisplayClass1_0<TargetType, TMatch>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityDefinitionUtils>.NativeClassPtr, "<>c__DisplayClass1_0`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TargetType>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityDefinitionUtils.__c__DisplayClass1_0<TargetType, TMatch>>.NativeClassPtr);
				AbilityDefinitionUtils.__c__DisplayClass1_0<TargetType, TMatch>.NativeFieldInfoPtr_ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDefinitionUtils.__c__DisplayClass1_0<TargetType, TMatch>>.NativeClassPtr, "ability");
				AbilityDefinitionUtils.__c__DisplayClass1_0<TargetType, TMatch>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinitionUtils.__c__DisplayClass1_0<TargetType, TMatch>>.NativeClassPtr, 100665116);
				AbilityDefinitionUtils.__c__DisplayClass1_0<TargetType, TMatch>.NativeMethodInfoPtr__GetTargetsFromQueue_b__0_Internal_IEnumerable_1_TargetType_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinitionUtils.__c__DisplayClass1_0<TargetType, TMatch>>.NativeClassPtr, 100665117);
			}

			// Token: 0x06001FC4 RID: 8132 RVA: 0x00091A94 File Offset: 0x0008FC94
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityDefinitionUtils.__c__DisplayClass1_0<TargetType, TMatch>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinitionUtils.__c__DisplayClass1_0<TargetType, TMatch>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FC5 RID: 8133 RVA: 0x00091AD0 File Offset: 0x0008FCD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561278, XrefRangeEnd = 561289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<TargetType> _GetTargetsFromQueue_b__0(EntityID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinitionUtils.__c__DisplayClass1_0<TargetType, TMatch>.NativeMethodInfoPtr__GetTargetsFromQueue_b__0_Internal_IEnumerable_1_TargetType_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetType>>(intPtr3) : null;
				}
			}

			// Token: 0x06001FC6 RID: 8134 RVA: 0x0000F498 File Offset: 0x0000D698
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700077E RID: 1918
			// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x00091B20 File Offset: 0x0008FD20
			// (set) Token: 0x06001FC8 RID: 8136 RVA: 0x0000F4A1 File Offset: 0x0000D6A1
			public unsafe AbilityDefinitionForGame<TMatch> ability
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityDefinitionUtils.__c__DisplayClass1_0<TargetType, TMatch>.NativeFieldInfoPtr_ability);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityDefinitionForGame<TMatch>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityDefinitionUtils.__c__DisplayClass1_0<TargetType, TMatch>.NativeFieldInfoPtr_ability), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001403 RID: 5123
			private static readonly IntPtr NativeFieldInfoPtr_ability;

			// Token: 0x04001404 RID: 5124
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001405 RID: 5125
			private static readonly IntPtr NativeMethodInfoPtr__GetTargetsFromQueue_b__0_Internal_IEnumerable_1_TargetType_EntityID_0;
		}

		// Token: 0x020002FB RID: 763
		private sealed class MethodInfoStoreGeneric_GetTargetsFromQueue_Public_Static_IEnumerable_1_TargetType_AbilityDefinitionForGame_1_TMatch_Context_0<TargetType, TMatch>
		{
			// Token: 0x04001406 RID: 5126
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AbilityDefinitionUtils.NativeMethodInfoPtr_GetTargetsFromQueue_Public_Static_IEnumerable_1_TargetType_AbilityDefinitionForGame_1_TMatch_Context_0, Il2CppClassPointerStore<AbilityDefinitionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TargetType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002FC RID: 764
		private sealed class MethodInfoStoreGeneric_GetTargetsFromQueue_Public_Static_IEnumerable_1_TargetType_AbilityDefinitionForGame_1_TMatch_TargetResponseQueue_0<TargetType, TMatch>
		{
			// Token: 0x04001407 RID: 5127
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AbilityDefinitionUtils.NativeMethodInfoPtr_GetTargetsFromQueue_Public_Static_IEnumerable_1_TargetType_AbilityDefinitionForGame_1_TMatch_TargetResponseQueue_0, Il2CppClassPointerStore<AbilityDefinitionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TargetType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002FD RID: 765
		private sealed class MethodInfoStoreGeneric_GetTargetFromQueue_Public_Static_TargetType_AbilityDefinitionForGame_1_TMatch_Context_0<TargetType, TMatch>
		{
			// Token: 0x04001408 RID: 5128
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AbilityDefinitionUtils.NativeMethodInfoPtr_GetTargetFromQueue_Public_Static_TargetType_AbilityDefinitionForGame_1_TMatch_Context_0, Il2CppClassPointerStore<AbilityDefinitionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TargetType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002FE RID: 766
		private sealed class MethodInfoStoreGeneric_GetTargetFromQueue_Public_Static_TargetType_AbilityDefinitionForGame_1_TMatch_TargetResponseQueue_0<TargetType, TMatch>
		{
			// Token: 0x04001409 RID: 5129
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AbilityDefinitionUtils.NativeMethodInfoPtr_GetTargetFromQueue_Public_Static_TargetType_AbilityDefinitionForGame_1_TMatch_TargetResponseQueue_0, Il2CppClassPointerStore<AbilityDefinitionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TargetType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002FF RID: 767
		private sealed class MethodInfoStoreGeneric_MakeEvaluatorAttribute_Public_Static_MutableAttribute_1_AIEvaluator_AbilityDefinitionForGame_1_TMatch_AIEvaluateSelection_0<TMatch>
		{
			// Token: 0x0400140A RID: 5130
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AbilityDefinitionUtils.NativeMethodInfoPtr_MakeEvaluatorAttribute_Public_Static_MutableAttribute_1_AIEvaluator_AbilityDefinitionForGame_1_TMatch_AIEvaluateSelection_0, Il2CppClassPointerStore<AbilityDefinitionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)) }))));
		}

		// Token: 0x02000300 RID: 768
		private sealed class MethodInfoStoreGeneric_AppendAttribute_Public_Static_IEnumerable_1_IAttribute_IEnumerable_1_IAttribute_MutableAttribute_1_TAttrValue_0<TAttrValue>
		{
			// Token: 0x0400140B RID: 5131
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AbilityDefinitionUtils.NativeMethodInfoPtr_AppendAttribute_Public_Static_IEnumerable_1_IAttribute_IEnumerable_1_IAttribute_MutableAttribute_1_TAttrValue_0, Il2CppClassPointerStore<AbilityDefinitionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAttrValue>.NativeClassPtr)) }))));
		}

		// Token: 0x02000301 RID: 769
		private sealed class MethodInfoStoreGeneric_MakeEntityListTargetInformation_Public_Static_EntityListTargetInformation_AbilityDefinitionForGame_1_TMatch_IEnumerable_1_Entity_PlayerEntity_LocalizableTextVariables_AIEvaluateSelection_String_Boolean_Boolean_Int32_Int32_IEnumerable_1_IAttribute_0<TMatch>
		{
			// Token: 0x0400140C RID: 5132
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AbilityDefinitionUtils.NativeMethodInfoPtr_MakeEntityListTargetInformation_Public_Static_EntityListTargetInformation_AbilityDefinitionForGame_1_TMatch_IEnumerable_1_Entity_PlayerEntity_LocalizableTextVariables_AIEvaluateSelection_String_Boolean_Boolean_Int32_Int32_IEnumerable_1_IAttribute_0, Il2CppClassPointerStore<AbilityDefinitionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)) }))));
		}

		// Token: 0x02000302 RID: 770
		private sealed class MethodInfoStoreGeneric_MakeArchetypeCustomChoiceTargetInformation_Public_Static_ArchetypeCustomChoiceTargetInformation_AbilityDefinitionForGame_1_TMatch_IEnumerable_1_SerializableAttributes_PlayerEntity_LocalizableTextVariables_AIEvaluateSelection_String_Boolean_Boolean_Int32_Int32_IEnumerable_1_IAttribute_0<TMatch>
		{
			// Token: 0x0400140D RID: 5133
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AbilityDefinitionUtils.NativeMethodInfoPtr_MakeArchetypeCustomChoiceTargetInformation_Public_Static_ArchetypeCustomChoiceTargetInformation_AbilityDefinitionForGame_1_TMatch_IEnumerable_1_SerializableAttributes_PlayerEntity_LocalizableTextVariables_AIEvaluateSelection_String_Boolean_Boolean_Int32_Int32_IEnumerable_1_IAttribute_0, Il2CppClassPointerStore<AbilityDefinitionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)) }))));
		}
	}
}
