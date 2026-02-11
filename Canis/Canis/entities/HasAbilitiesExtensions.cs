using System;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Networking.selection.targetinformation;

namespace Canis.entities
{
	// Token: 0x020000E3 RID: 227
	public static class HasAbilitiesExtensions : Object
	{
		// Token: 0x06000A46 RID: 2630 RVA: 0x00045058 File Offset: 0x00043258
		// Note: this type is marked as 'beforefieldinit'.
		static HasAbilitiesExtensions()
		{
			Il2CppClassPointerStore<HasAbilitiesExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "HasAbilitiesExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasAbilitiesExtensions>.NativeClassPtr);
			HasAbilitiesExtensions.NativeMethodInfoPtr_ConstructAbilityDefinitions_Public_Static_IEnumerable_1_TAbilityDefinition_IHasAbilities_2_TMatch_TAbilityDefinition_TMatch_EntityFactory_2_AbilityID_AbilityDefinitionForGame_1_TMatch_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasAbilitiesExtensions>.NativeClassPtr, 100665458);
			HasAbilitiesExtensions.NativeMethodInfoPtr_ConstructAllAbilityDefinitions_Public_Static_Void_IHasAbilities_2_TMatch_TAbilityDefinition_TMatch_EntityFactory_2_AbilityID_AbilityDefinitionForGame_1_TMatch_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasAbilitiesExtensions>.NativeClassPtr, 100665459);
			HasAbilitiesExtensions.NativeMethodInfoPtr_GetUsableAbilities_Public_Static_IEnumerable_1_TAbilityType_IHasAbilities_2_TMatch_TAbilityDefinition_PlayerEntity_Func_2_TAbilityType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasAbilitiesExtensions>.NativeClassPtr, 100665460);
			HasAbilitiesExtensions.NativeMethodInfoPtr_GetUsableAbilities_Public_Static_IEnumerable_1_TAbilityType_IHasAbilities_2_TMatch_TAbilityDefinition_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasAbilitiesExtensions>.NativeClassPtr, 100665461);
			HasAbilitiesExtensions.NativeMethodInfoPtr_GetAbilities_Public_Static_IEnumerable_1_TAbilityType_IHasAbilities_2_TMatch_TAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasAbilitiesExtensions>.NativeClassPtr, 100665462);
			HasAbilitiesExtensions.NativeMethodInfoPtr_GetFlattenedTargetMap_Public_Static_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_IEnumerable_1_AbilityDefinitionForGame_1_TMatch_TPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasAbilitiesExtensions>.NativeClassPtr, 100665463);
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00045100 File Offset: 0x00043300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565758, XrefRangeEnd = 565766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TAbilityDefinition> ConstructAbilityDefinitions<TMatch, TAbilityDefinition>(this IHasAbilities<TMatch, TAbilityDefinition> hasAbilities, TMatch match, EntityFactory<AbilityID, AbilityDefinitionForGame<TMatch>> factory, PlayerEntity owner = null) where TMatch : Match where TAbilityDefinition : AbilityDefinitionForGame<TMatch>
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasAbilities);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TMatch).IsValueType)
			{
				TMatch tmatch = match;
				intPtr = ((tmatch is string) ? IL2CPP.ManagedStringToIl2Cpp(tmatch as string) : IL2CPP.Il2CppObjectBaseToPtr(tmatch as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref match;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(factory);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HasAbilitiesExtensions.MethodInfoStoreGeneric_ConstructAbilityDefinitions_Public_Static_IEnumerable_1_TAbilityDefinition_IHasAbilities_2_TMatch_TAbilityDefinition_TMatch_EntityFactory_2_AbilityID_AbilityDefinitionForGame_1_TMatch_PlayerEntity_0<TMatch, TAbilityDefinition>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<TAbilityDefinition>>(intPtr4) : null;
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x000451B0 File Offset: 0x000433B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 565790, RefRangeEnd = 565791, XrefRangeStart = 565766, XrefRangeEnd = 565790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConstructAllAbilityDefinitions<TMatch, TAbilityDefinition>(this IHasAbilities<TMatch, TAbilityDefinition> hasAbilities, TMatch match, EntityFactory<AbilityID, AbilityDefinitionForGame<TMatch>> factory, PlayerEntity owner = null) where TMatch : Match where TAbilityDefinition : AbilityDefinitionForGame<TMatch>
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasAbilities);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TMatch).IsValueType)
			{
				TMatch tmatch = match;
				intPtr = ((tmatch is string) ? IL2CPP.ManagedStringToIl2Cpp(tmatch as string) : IL2CPP.Il2CppObjectBaseToPtr(tmatch as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref match;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(factory);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HasAbilitiesExtensions.MethodInfoStoreGeneric_ConstructAllAbilityDefinitions_Public_Static_Void_IHasAbilities_2_TMatch_TAbilityDefinition_TMatch_EntityFactory_2_AbilityID_AbilityDefinitionForGame_1_TMatch_PlayerEntity_0<TMatch, TAbilityDefinition>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00045254 File Offset: 0x00043454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565791, XrefRangeEnd = 565799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TAbilityType> GetUsableAbilities<TMatch, TAbilityDefinition, TAbilityType>(this IHasAbilities<TMatch, TAbilityDefinition> hasAbilities, PlayerEntity player, Func<TAbilityType, bool> predicate) where TMatch : Match where TAbilityDefinition : AbilityDefinitionForGame<TMatch> where TAbilityType : TAbilityDefinition
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasAbilities);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasAbilitiesExtensions.MethodInfoStoreGeneric_GetUsableAbilities_Public_Static_IEnumerable_1_TAbilityType_IHasAbilities_2_TMatch_TAbilityDefinition_PlayerEntity_Func_2_TAbilityType_Boolean_0<TMatch, TAbilityDefinition, TAbilityType>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TAbilityType>>(intPtr3) : null;
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x000452BC File Offset: 0x000434BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565799, XrefRangeEnd = 565831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TAbilityType> GetUsableAbilities<TMatch, TAbilityDefinition, TAbilityType>(this IHasAbilities<TMatch, TAbilityDefinition> hasAbilities, PlayerEntity player) where TMatch : Match where TAbilityDefinition : AbilityDefinitionForGame<TMatch> where TAbilityType : TAbilityDefinition
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasAbilities);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasAbilitiesExtensions.MethodInfoStoreGeneric_GetUsableAbilities_Public_Static_IEnumerable_1_TAbilityType_IHasAbilities_2_TMatch_TAbilityDefinition_PlayerEntity_0<TMatch, TAbilityDefinition, TAbilityType>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TAbilityType>>(intPtr3) : null;
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00045314 File Offset: 0x00043514
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 565836, RefRangeEnd = 565838, XrefRangeStart = 565831, XrefRangeEnd = 565836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TAbilityType> GetAbilities<TMatch, TAbilityDefinition, TAbilityType>(this IHasAbilities<TMatch, TAbilityDefinition> hasAbilities) where TMatch : Match where TAbilityDefinition : AbilityDefinitionForGame<TMatch> where TAbilityType : TAbilityDefinition
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasAbilities);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasAbilitiesExtensions.MethodInfoStoreGeneric_GetAbilities_Public_Static_IEnumerable_1_TAbilityType_IHasAbilities_2_TMatch_TAbilityDefinition_0<TMatch, TAbilityDefinition, TAbilityType>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TAbilityType>>(intPtr3) : null;
			}
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00045358 File Offset: 0x00043558
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 565854, RefRangeEnd = 565860, XrefRangeStart = 565838, XrefRangeEnd = 565854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<EntityID, Il2CppReferenceArray<TargetInformation>> GetFlattenedTargetMap<TMatch, TPlayer>(this IEnumerable<AbilityDefinitionForGame<TMatch>> abilities, TPlayer player) where TMatch : Match where TPlayer : PlayerEntity
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(abilities);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TPlayer).IsValueType)
			{
				TPlayer tplayer = player;
				intPtr = ((tplayer is string) ? IL2CPP.ManagedStringToIl2Cpp(tplayer as string) : IL2CPP.Il2CppObjectBaseToPtr(tplayer as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref player;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HasAbilitiesExtensions.MethodInfoStoreGeneric_GetFlattenedTargetMap_Public_Static_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_IEnumerable_1_AbilityDefinitionForGame_1_TMatch_TPlayer_0<TMatch, TPlayer>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, Il2CppReferenceArray<TargetInformation>>>(intPtr4) : null;
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00005CF4 File Offset: 0x00003EF4
		public HasAbilitiesExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeMethodInfoPtr_ConstructAbilityDefinitions_Public_Static_IEnumerable_1_TAbilityDefinition_IHasAbilities_2_TMatch_TAbilityDefinition_TMatch_EntityFactory_2_AbilityID_AbilityDefinitionForGame_1_TMatch_PlayerEntity_0;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeMethodInfoPtr_ConstructAllAbilityDefinitions_Public_Static_Void_IHasAbilities_2_TMatch_TAbilityDefinition_TMatch_EntityFactory_2_AbilityID_AbilityDefinitionForGame_1_TMatch_PlayerEntity_0;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeMethodInfoPtr_GetUsableAbilities_Public_Static_IEnumerable_1_TAbilityType_IHasAbilities_2_TMatch_TAbilityDefinition_PlayerEntity_Func_2_TAbilityType_Boolean_0;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeMethodInfoPtr_GetUsableAbilities_Public_Static_IEnumerable_1_TAbilityType_IHasAbilities_2_TMatch_TAbilityDefinition_PlayerEntity_0;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilities_Public_Static_IEnumerable_1_TAbilityType_IHasAbilities_2_TMatch_TAbilityDefinition_0;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeMethodInfoPtr_GetFlattenedTargetMap_Public_Static_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_IEnumerable_1_AbilityDefinitionForGame_1_TMatch_TPlayer_0;

		// Token: 0x0200031C RID: 796
		[ObfuscatedName("Canis.entities.HasAbilitiesExtensions+<>c__DisplayClass2_0`3")]
		public sealed class __c__DisplayClass2_0<TMatch, TAbilityDefinition, TAbilityType> : Object where TMatch : Match where TAbilityDefinition : AbilityDefinitionForGame<TMatch> where TAbilityType : TAbilityDefinition
		{
			// Token: 0x06002141 RID: 8513 RVA: 0x00097140 File Offset: 0x00095340
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<HasAbilitiesExtensions.__c__DisplayClass2_0<TMatch, TAbilityDefinition, TAbilityType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HasAbilitiesExtensions>.NativeClassPtr, "<>c__DisplayClass2_0`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityType>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasAbilitiesExtensions.__c__DisplayClass2_0<TMatch, TAbilityDefinition, TAbilityType>>.NativeClassPtr);
				HasAbilitiesExtensions.__c__DisplayClass2_0<TMatch, TAbilityDefinition, TAbilityType>.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasAbilitiesExtensions.__c__DisplayClass2_0<TMatch, TAbilityDefinition, TAbilityType>>.NativeClassPtr, "player");
				HasAbilitiesExtensions.__c__DisplayClass2_0<TMatch, TAbilityDefinition, TAbilityType>.NativeFieldInfoPtr_predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasAbilitiesExtensions.__c__DisplayClass2_0<TMatch, TAbilityDefinition, TAbilityType>>.NativeClassPtr, "predicate");
				HasAbilitiesExtensions.__c__DisplayClass2_0<TMatch, TAbilityDefinition, TAbilityType>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasAbilitiesExtensions.__c__DisplayClass2_0<TMatch, TAbilityDefinition, TAbilityType>>.NativeClassPtr, 100665464);
				HasAbilitiesExtensions.__c__DisplayClass2_0<TMatch, TAbilityDefinition, TAbilityType>.NativeMethodInfoPtr__GetUsableAbilities_b__0_Internal_Boolean_TAbilityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasAbilitiesExtensions.__c__DisplayClass2_0<TMatch, TAbilityDefinition, TAbilityType>>.NativeClassPtr, 100665465);
			}

			// Token: 0x06002142 RID: 8514 RVA: 0x0009721C File Offset: 0x0009541C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasAbilitiesExtensions.__c__DisplayClass2_0<TMatch, TAbilityDefinition, TAbilityType>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasAbilitiesExtensions.__c__DisplayClass2_0<TMatch, TAbilityDefinition, TAbilityType>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002143 RID: 8515 RVA: 0x00097258 File Offset: 0x00095458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565633, XrefRangeEnd = 565638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUsableAbilities_b__0(TAbilityType ability)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TAbilityType).IsValueType)
					{
						TAbilityType tabilityType = ability;
						intPtr = ((tabilityType is string) ? IL2CPP.ManagedStringToIl2Cpp(tabilityType as string) : IL2CPP.Il2CppObjectBaseToPtr(tabilityType as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref ability;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HasAbilitiesExtensions.__c__DisplayClass2_0<TMatch, TAbilityDefinition, TAbilityType>.NativeMethodInfoPtr__GetUsableAbilities_b__0_Internal_Boolean_TAbilityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06002144 RID: 8516 RVA: 0x0000FF37 File Offset: 0x0000E137
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007FD RID: 2045
			// (get) Token: 0x06002145 RID: 8517 RVA: 0x000972DC File Offset: 0x000954DC
			// (set) Token: 0x06002146 RID: 8518 RVA: 0x0000FF40 File Offset: 0x0000E140
			public unsafe PlayerEntity player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions.__c__DisplayClass2_0<TMatch, TAbilityDefinition, TAbilityType>.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions.__c__DisplayClass2_0<TMatch, TAbilityDefinition, TAbilityType>.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007FE RID: 2046
			// (get) Token: 0x06002147 RID: 8519 RVA: 0x0009730C File Offset: 0x0009550C
			// (set) Token: 0x06002148 RID: 8520 RVA: 0x0000FF5F File Offset: 0x0000E15F
			public unsafe Func<TAbilityType, bool> predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions.__c__DisplayClass2_0<TMatch, TAbilityDefinition, TAbilityType>.NativeFieldInfoPtr_predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TAbilityType, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions.__c__DisplayClass2_0<TMatch, TAbilityDefinition, TAbilityType>.NativeFieldInfoPtr_predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014EE RID: 5358
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040014EF RID: 5359
			private static readonly IntPtr NativeFieldInfoPtr_predicate;

			// Token: 0x040014F0 RID: 5360
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040014F1 RID: 5361
			private static readonly IntPtr NativeMethodInfoPtr__GetUsableAbilities_b__0_Internal_Boolean_TAbilityType_0;
		}

		// Token: 0x0200031D RID: 797
		[ObfuscatedName("Canis.entities.HasAbilitiesExtensions+<>c__DisplayClass3_0`3")]
		public sealed class __c__DisplayClass3_0<TMatch, TAbilityDefinition, TAbilityType> : Object where TMatch : Match where TAbilityDefinition : AbilityDefinitionForGame<TMatch> where TAbilityType : TAbilityDefinition
		{
			// Token: 0x06002149 RID: 8521 RVA: 0x0009733C File Offset: 0x0009553C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<HasAbilitiesExtensions.__c__DisplayClass3_0<TMatch, TAbilityDefinition, TAbilityType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HasAbilitiesExtensions>.NativeClassPtr, "<>c__DisplayClass3_0`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityType>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasAbilitiesExtensions.__c__DisplayClass3_0<TMatch, TAbilityDefinition, TAbilityType>>.NativeClassPtr);
				HasAbilitiesExtensions.__c__DisplayClass3_0<TMatch, TAbilityDefinition, TAbilityType>.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasAbilitiesExtensions.__c__DisplayClass3_0<TMatch, TAbilityDefinition, TAbilityType>>.NativeClassPtr, "player");
				HasAbilitiesExtensions.__c__DisplayClass3_0<TMatch, TAbilityDefinition, TAbilityType>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasAbilitiesExtensions.__c__DisplayClass3_0<TMatch, TAbilityDefinition, TAbilityType>>.NativeClassPtr, 100665466);
				HasAbilitiesExtensions.__c__DisplayClass3_0<TMatch, TAbilityDefinition, TAbilityType>.NativeMethodInfoPtr__GetUsableAbilities_b__0_Internal_Boolean_TAbilityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasAbilitiesExtensions.__c__DisplayClass3_0<TMatch, TAbilityDefinition, TAbilityType>>.NativeClassPtr, 100665467);
			}

			// Token: 0x0600214A RID: 8522 RVA: 0x00097404 File Offset: 0x00095604
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasAbilitiesExtensions.__c__DisplayClass3_0<TMatch, TAbilityDefinition, TAbilityType>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasAbilitiesExtensions.__c__DisplayClass3_0<TMatch, TAbilityDefinition, TAbilityType>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600214B RID: 8523 RVA: 0x00097440 File Offset: 0x00095640
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565638, XrefRangeEnd = 565641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUsableAbilities_b__0(TAbilityType ability)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TAbilityType).IsValueType)
					{
						TAbilityType tabilityType = ability;
						intPtr = ((tabilityType is string) ? IL2CPP.ManagedStringToIl2Cpp(tabilityType as string) : IL2CPP.Il2CppObjectBaseToPtr(tabilityType as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref ability;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HasAbilitiesExtensions.__c__DisplayClass3_0<TMatch, TAbilityDefinition, TAbilityType>.NativeMethodInfoPtr__GetUsableAbilities_b__0_Internal_Boolean_TAbilityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x0600214C RID: 8524 RVA: 0x0000FF7E File Offset: 0x0000E17E
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007FF RID: 2047
			// (get) Token: 0x0600214D RID: 8525 RVA: 0x000974C4 File Offset: 0x000956C4
			// (set) Token: 0x0600214E RID: 8526 RVA: 0x0000FF87 File Offset: 0x0000E187
			public unsafe PlayerEntity player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions.__c__DisplayClass3_0<TMatch, TAbilityDefinition, TAbilityType>.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions.__c__DisplayClass3_0<TMatch, TAbilityDefinition, TAbilityType>.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014F2 RID: 5362
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040014F3 RID: 5363
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040014F4 RID: 5364
			private static readonly IntPtr NativeMethodInfoPtr__GetUsableAbilities_b__0_Internal_Boolean_TAbilityType_0;
		}

		// Token: 0x0200031E RID: 798
		[ObfuscatedName("Canis.entities.HasAbilitiesExtensions+<>c__DisplayClass5_0`2")]
		public sealed class __c__DisplayClass5_0<TMatch, TPlayer> : Object where TMatch : Match where TPlayer : PlayerEntity
		{
			// Token: 0x0600214F RID: 8527 RVA: 0x000974F4 File Offset: 0x000956F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<HasAbilitiesExtensions.__c__DisplayClass5_0<TMatch, TPlayer>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HasAbilitiesExtensions>.NativeClassPtr, "<>c__DisplayClass5_0`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlayer>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasAbilitiesExtensions.__c__DisplayClass5_0<TMatch, TPlayer>>.NativeClassPtr);
				HasAbilitiesExtensions.__c__DisplayClass5_0<TMatch, TPlayer>.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasAbilitiesExtensions.__c__DisplayClass5_0<TMatch, TPlayer>>.NativeClassPtr, "player");
				HasAbilitiesExtensions.__c__DisplayClass5_0<TMatch, TPlayer>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasAbilitiesExtensions.__c__DisplayClass5_0<TMatch, TPlayer>>.NativeClassPtr, 100665468);
				HasAbilitiesExtensions.__c__DisplayClass5_0<TMatch, TPlayer>.NativeMethodInfoPtr__GetFlattenedTargetMap_b__0_Internal_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_AbilityDefinitionForGame_1_TMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasAbilitiesExtensions.__c__DisplayClass5_0<TMatch, TPlayer>>.NativeClassPtr, 100665469);
			}

			// Token: 0x06002150 RID: 8528 RVA: 0x000975A8 File Offset: 0x000957A8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasAbilitiesExtensions.__c__DisplayClass5_0<TMatch, TPlayer>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasAbilitiesExtensions.__c__DisplayClass5_0<TMatch, TPlayer>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002151 RID: 8529 RVA: 0x000975E4 File Offset: 0x000957E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565641, XrefRangeEnd = 565658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dictionary<EntityID, Il2CppReferenceArray<TargetInformation>> _GetFlattenedTargetMap_b__0(Dictionary<EntityID, Il2CppReferenceArray<TargetInformation>> agg, AbilityDefinitionForGame<TMatch> ability)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(agg);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ability);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasAbilitiesExtensions.__c__DisplayClass5_0<TMatch, TPlayer>.NativeMethodInfoPtr__GetFlattenedTargetMap_b__0_Internal_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_AbilityDefinitionForGame_1_TMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, Il2CppReferenceArray<TargetInformation>>>(intPtr3) : null;
			}

			// Token: 0x06002152 RID: 8530 RVA: 0x0000FFA6 File Offset: 0x0000E1A6
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000800 RID: 2048
			// (get) Token: 0x06002153 RID: 8531 RVA: 0x00097648 File Offset: 0x00095848
			// (set) Token: 0x06002154 RID: 8532 RVA: 0x00097670 File Offset: 0x00095870
			public unsafe TPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions.__c__DisplayClass5_0<TMatch, TPlayer>.NativeFieldInfoPtr_player);
					return IL2CPP.PointerToValueGeneric<TPlayer>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions.__c__DisplayClass5_0<TMatch, TPlayer>.NativeFieldInfoPtr_player);
					Type typeFromHandle = typeof(TPlayer);
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

			// Token: 0x040014F5 RID: 5365
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040014F6 RID: 5366
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040014F7 RID: 5367
			private static readonly IntPtr NativeMethodInfoPtr__GetFlattenedTargetMap_b__0_Internal_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_AbilityDefinitionForGame_1_TMatch_0;
		}

		// Token: 0x0200031F RID: 799
		[ObfuscatedName("Canis.entities.HasAbilitiesExtensions+<ConstructAbilityDefinitions>d__0`2")]
		public sealed class _ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition> : Object where TMatch : Match where TAbilityDefinition : AbilityDefinitionForGame<TMatch>
		{
			// Token: 0x06002155 RID: 8533 RVA: 0x00097718 File Offset: 0x00095918
			// Note: this type is marked as 'beforefieldinit'.
			static _ConstructAbilityDefinitions_d__0()
			{
				Il2CppClassPointerStore<HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HasAbilitiesExtensions>.NativeClassPtr, "<ConstructAbilityDefinitions>d__0`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>>.NativeClassPtr);
				HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>>.NativeClassPtr, "<>1__state");
				HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>>.NativeClassPtr, "<>2__current");
				HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>>.NativeClassPtr, "<>l__initialThreadId");
				HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr_hasAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>>.NativeClassPtr, "hasAbilities");
				HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr___3__hasAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>>.NativeClassPtr, "<>3__hasAbilities");
				HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr_factory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>>.NativeClassPtr, "factory");
				HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr___3__factory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>>.NativeClassPtr, "<>3__factory");
				HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>>.NativeClassPtr, "match");
				HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>>.NativeClassPtr, "<>3__match");
				HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>>.NativeClassPtr, "owner");
				HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr___3__owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>>.NativeClassPtr, "<>3__owner");
				HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr__withAttributes_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>>.NativeClassPtr, "<withAttributes>5__2");
				HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>>.NativeClassPtr, "<>7__wrap2");
				HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>>.NativeClassPtr, 100665470);
				HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>>.NativeClassPtr, 100665471);
				HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>>.NativeClassPtr, 100665472);
				HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>>.NativeClassPtr, 100665473);
				HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TAbilityDefinition__get_Current_Private_Virtual_Final_New_get_TAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>>.NativeClassPtr, 100665474);
				HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>>.NativeClassPtr, 100665475);
				HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>>.NativeClassPtr, 100665476);
				HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TAbilityDefinition__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>>.NativeClassPtr, 100665477);
				HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>>.NativeClassPtr, 100665478);
			}

			// Token: 0x06002156 RID: 8534 RVA: 0x00097948 File Offset: 0x00095B48
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ConstructAbilityDefinitions_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002157 RID: 8535 RVA: 0x00097990 File Offset: 0x00095B90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565658, XrefRangeEnd = 565663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002158 RID: 8536 RVA: 0x000979C4 File Offset: 0x00095BC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565663, XrefRangeEnd = 565735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002159 RID: 8537 RVA: 0x00097A00 File Offset: 0x00095C00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565735, XrefRangeEnd = 565738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700080E RID: 2062
			// (get) Token: 0x0600215A RID: 8538 RVA: 0x00097A34 File Offset: 0x00095C34
			public unsafe TAbilityDefinition System.Collections.Generic.IEnumerator<TAbilityDefinition>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TAbilityDefinition__get_Current_Private_Virtual_Final_New_get_TAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TAbilityDefinition>(intPtr, false, true);
				}
			}

			// Token: 0x0600215B RID: 8539 RVA: 0x00097A70 File Offset: 0x00095C70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700080F RID: 2063
			// (get) Token: 0x0600215C RID: 8540 RVA: 0x00097AA4 File Offset: 0x00095CA4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600215D RID: 8541 RVA: 0x00097AE4 File Offset: 0x00095CE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565738, XrefRangeEnd = 565748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TAbilityDefinition> System_Collections_Generic_IEnumerable_TAbilityDefinition__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TAbilityDefinition__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TAbilityDefinition>>(intPtr3) : null;
			}

			// Token: 0x0600215E RID: 8542 RVA: 0x00097B24 File Offset: 0x00095D24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565748, XrefRangeEnd = 565758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600215F RID: 8543 RVA: 0x0000FFAF File Offset: 0x0000E1AF
			public _ConstructAbilityDefinitions_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000801 RID: 2049
			// (get) Token: 0x06002160 RID: 8544 RVA: 0x00097B64 File Offset: 0x00095D64
			// (set) Token: 0x06002161 RID: 8545 RVA: 0x0000FFB8 File Offset: 0x0000E1B8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000802 RID: 2050
			// (get) Token: 0x06002162 RID: 8546 RVA: 0x00097B8C File Offset: 0x00095D8C
			// (set) Token: 0x06002163 RID: 8547 RVA: 0x00097BB4 File Offset: 0x00095DB4
			public unsafe TAbilityDefinition __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TAbilityDefinition>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TAbilityDefinition);
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

			// Token: 0x17000803 RID: 2051
			// (get) Token: 0x06002164 RID: 8548 RVA: 0x00097C5C File Offset: 0x00095E5C
			// (set) Token: 0x06002165 RID: 8549 RVA: 0x0000FFD3 File Offset: 0x0000E1D3
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000804 RID: 2052
			// (get) Token: 0x06002166 RID: 8550 RVA: 0x00097C84 File Offset: 0x00095E84
			// (set) Token: 0x06002167 RID: 8551 RVA: 0x0000FFEE File Offset: 0x0000E1EE
			public unsafe IHasAbilities<TMatch, TAbilityDefinition> hasAbilities
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr_hasAbilities);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHasAbilities<TMatch, TAbilityDefinition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr_hasAbilities), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000805 RID: 2053
			// (get) Token: 0x06002168 RID: 8552 RVA: 0x00097CB4 File Offset: 0x00095EB4
			// (set) Token: 0x06002169 RID: 8553 RVA: 0x0001000D File Offset: 0x0000E20D
			public unsafe IHasAbilities<TMatch, TAbilityDefinition> __3__hasAbilities
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr___3__hasAbilities);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHasAbilities<TMatch, TAbilityDefinition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr___3__hasAbilities), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000806 RID: 2054
			// (get) Token: 0x0600216A RID: 8554 RVA: 0x00097CE4 File Offset: 0x00095EE4
			// (set) Token: 0x0600216B RID: 8555 RVA: 0x0001002C File Offset: 0x0000E22C
			public unsafe EntityFactory<AbilityID, AbilityDefinitionForGame<TMatch>> factory
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr_factory);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityFactory<AbilityID, AbilityDefinitionForGame<TMatch>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr_factory), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000807 RID: 2055
			// (get) Token: 0x0600216C RID: 8556 RVA: 0x00097D14 File Offset: 0x00095F14
			// (set) Token: 0x0600216D RID: 8557 RVA: 0x0001004B File Offset: 0x0000E24B
			public unsafe EntityFactory<AbilityID, AbilityDefinitionForGame<TMatch>> __3__factory
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr___3__factory);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityFactory<AbilityID, AbilityDefinitionForGame<TMatch>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr___3__factory), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000808 RID: 2056
			// (get) Token: 0x0600216E RID: 8558 RVA: 0x00097D44 File Offset: 0x00095F44
			// (set) Token: 0x0600216F RID: 8559 RVA: 0x00097D6C File Offset: 0x00095F6C
			public unsafe TMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr_match);
					return IL2CPP.PointerToValueGeneric<TMatch>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr_match);
					Type typeFromHandle = typeof(TMatch);
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

			// Token: 0x17000809 RID: 2057
			// (get) Token: 0x06002170 RID: 8560 RVA: 0x00097E14 File Offset: 0x00096014
			// (set) Token: 0x06002171 RID: 8561 RVA: 0x00097E3C File Offset: 0x0009603C
			public unsafe TMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr___3__match);
					return IL2CPP.PointerToValueGeneric<TMatch>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr___3__match);
					Type typeFromHandle = typeof(TMatch);
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

			// Token: 0x1700080A RID: 2058
			// (get) Token: 0x06002172 RID: 8562 RVA: 0x00097EE4 File Offset: 0x000960E4
			// (set) Token: 0x06002173 RID: 8563 RVA: 0x0001006A File Offset: 0x0000E26A
			public unsafe PlayerEntity owner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr_owner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700080B RID: 2059
			// (get) Token: 0x06002174 RID: 8564 RVA: 0x00097F14 File Offset: 0x00096114
			// (set) Token: 0x06002175 RID: 8565 RVA: 0x00010089 File Offset: 0x0000E289
			public unsafe PlayerEntity __3__owner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr___3__owner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr___3__owner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700080C RID: 2060
			// (get) Token: 0x06002176 RID: 8566 RVA: 0x00097F44 File Offset: 0x00096144
			// (set) Token: 0x06002177 RID: 8567 RVA: 0x000100A8 File Offset: 0x0000E2A8
			public unsafe ObjectAttributes _withAttributes_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr__withAttributes_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectAttributes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr__withAttributes_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700080D RID: 2061
			// (get) Token: 0x06002178 RID: 8568 RVA: 0x00097F74 File Offset: 0x00096174
			// (set) Token: 0x06002179 RID: 8569 RVA: 0x000100C7 File Offset: 0x0000E2C7
			public List<AbilityID>.Enumerator __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr___7__wrap2);
					return new List<AbilityID>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<AbilityID>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAbilitiesExtensions._ConstructAbilityDefinitions_d__0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr___7__wrap2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<AbilityID>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040014F8 RID: 5368
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014F9 RID: 5369
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040014FA RID: 5370
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040014FB RID: 5371
			private static readonly IntPtr NativeFieldInfoPtr_hasAbilities;

			// Token: 0x040014FC RID: 5372
			private static readonly IntPtr NativeFieldInfoPtr___3__hasAbilities;

			// Token: 0x040014FD RID: 5373
			private static readonly IntPtr NativeFieldInfoPtr_factory;

			// Token: 0x040014FE RID: 5374
			private static readonly IntPtr NativeFieldInfoPtr___3__factory;

			// Token: 0x040014FF RID: 5375
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04001500 RID: 5376
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04001501 RID: 5377
			private static readonly IntPtr NativeFieldInfoPtr_owner;

			// Token: 0x04001502 RID: 5378
			private static readonly IntPtr NativeFieldInfoPtr___3__owner;

			// Token: 0x04001503 RID: 5379
			private static readonly IntPtr NativeFieldInfoPtr__withAttributes_5__2;

			// Token: 0x04001504 RID: 5380
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04001505 RID: 5381
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001506 RID: 5382
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001507 RID: 5383
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001508 RID: 5384
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001509 RID: 5385
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TAbilityDefinition__get_Current_Private_Virtual_Final_New_get_TAbilityDefinition_0;

			// Token: 0x0400150A RID: 5386
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400150B RID: 5387
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400150C RID: 5388
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TAbilityDefinition__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TAbilityDefinition_0;

			// Token: 0x0400150D RID: 5389
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000320 RID: 800
		private sealed class MethodInfoStoreGeneric_ConstructAbilityDefinitions_Public_Static_IEnumerable_1_TAbilityDefinition_IHasAbilities_2_TMatch_TAbilityDefinition_TMatch_EntityFactory_2_AbilityID_AbilityDefinitionForGame_1_TMatch_PlayerEntity_0<TMatch, TAbilityDefinition>
		{
			// Token: 0x0400150E RID: 5390
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HasAbilitiesExtensions.NativeMethodInfoPtr_ConstructAbilityDefinitions_Public_Static_IEnumerable_1_TAbilityDefinition_IHasAbilities_2_TMatch_TAbilityDefinition_TMatch_EntityFactory_2_AbilityID_AbilityDefinitionForGame_1_TMatch_PlayerEntity_0, Il2CppClassPointerStore<HasAbilitiesExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000321 RID: 801
		private sealed class MethodInfoStoreGeneric_ConstructAllAbilityDefinitions_Public_Static_Void_IHasAbilities_2_TMatch_TAbilityDefinition_TMatch_EntityFactory_2_AbilityID_AbilityDefinitionForGame_1_TMatch_PlayerEntity_0<TMatch, TAbilityDefinition>
		{
			// Token: 0x0400150F RID: 5391
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HasAbilitiesExtensions.NativeMethodInfoPtr_ConstructAllAbilityDefinitions_Public_Static_Void_IHasAbilities_2_TMatch_TAbilityDefinition_TMatch_EntityFactory_2_AbilityID_AbilityDefinitionForGame_1_TMatch_PlayerEntity_0, Il2CppClassPointerStore<HasAbilitiesExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000322 RID: 802
		private sealed class MethodInfoStoreGeneric_GetUsableAbilities_Public_Static_IEnumerable_1_TAbilityType_IHasAbilities_2_TMatch_TAbilityDefinition_PlayerEntity_Func_2_TAbilityType_Boolean_0<TMatch, TAbilityDefinition, TAbilityType>
		{
			// Token: 0x04001510 RID: 5392
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HasAbilitiesExtensions.NativeMethodInfoPtr_GetUsableAbilities_Public_Static_IEnumerable_1_TAbilityType_IHasAbilities_2_TMatch_TAbilityDefinition_PlayerEntity_Func_2_TAbilityType_Boolean_0, Il2CppClassPointerStore<HasAbilitiesExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityType>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000323 RID: 803
		private sealed class MethodInfoStoreGeneric_GetUsableAbilities_Public_Static_IEnumerable_1_TAbilityType_IHasAbilities_2_TMatch_TAbilityDefinition_PlayerEntity_0<TMatch, TAbilityDefinition, TAbilityType>
		{
			// Token: 0x04001511 RID: 5393
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HasAbilitiesExtensions.NativeMethodInfoPtr_GetUsableAbilities_Public_Static_IEnumerable_1_TAbilityType_IHasAbilities_2_TMatch_TAbilityDefinition_PlayerEntity_0, Il2CppClassPointerStore<HasAbilitiesExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityType>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000324 RID: 804
		private sealed class MethodInfoStoreGeneric_GetAbilities_Public_Static_IEnumerable_1_TAbilityType_IHasAbilities_2_TMatch_TAbilityDefinition_0<TMatch, TAbilityDefinition, TAbilityType>
		{
			// Token: 0x04001512 RID: 5394
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HasAbilitiesExtensions.NativeMethodInfoPtr_GetAbilities_Public_Static_IEnumerable_1_TAbilityType_IHasAbilities_2_TMatch_TAbilityDefinition_0, Il2CppClassPointerStore<HasAbilitiesExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityType>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000325 RID: 805
		private sealed class MethodInfoStoreGeneric_GetFlattenedTargetMap_Public_Static_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_IEnumerable_1_AbilityDefinitionForGame_1_TMatch_TPlayer_0<TMatch, TPlayer>
		{
			// Token: 0x04001513 RID: 5395
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HasAbilitiesExtensions.NativeMethodInfoPtr_GetFlattenedTargetMap_Public_Static_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_IEnumerable_1_AbilityDefinitionForGame_1_TMatch_TPlayer_0, Il2CppClassPointerStore<HasAbilitiesExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlayer>.NativeClassPtr))
			}))));
		}
	}
}
