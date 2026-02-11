using System;
using canis.archetypes;
using Canis.entities;
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
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;

namespace Canis.data
{
	// Token: 0x0200014C RID: 332
	public static class CanisReflection : Object
	{
		// Token: 0x06000EB2 RID: 3762 RVA: 0x000576EC File Offset: 0x000558EC
		// Note: this type is marked as 'beforefieldinit'.
		static CanisReflection()
		{
			Il2CppClassPointerStore<CanisReflection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.data", "CanisReflection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanisReflection>.NativeClassPtr);
			CanisReflection.NativeMethodInfoPtr_FindCanisAssembly_Public_Static_Assembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection>.NativeClassPtr, 100666457);
			CanisReflection.NativeMethodInfoPtr_MakeArchetypes_Public_Static_IEnumerable_1_TArchetype_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection>.NativeClassPtr, 100666458);
			CanisReflection.NativeMethodInfoPtr_GetAbilities_Public_Static_IEnumerable_1_AbilityTypeInfo_Assembly_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection>.NativeClassPtr, 100666459);
			CanisReflection.NativeMethodInfoPtr_AddAbilityDefinitionFactories_Public_Static_Void_String_EntityFactory_2_AbilityID_TAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection>.NativeClassPtr, 100666460);
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x0005776C File Offset: 0x0005596C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 577784, RefRangeEnd = 577791, XrefRangeStart = 577767, XrefRangeEnd = 577784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly FindCanisAssembly(string project)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(project);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection.NativeMethodInfoPtr_FindCanisAssembly_Public_Static_Assembly_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x000577B0 File Offset: 0x000559B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 43475, RefRangeEnd = 43477, XrefRangeStart = 43475, XrefRangeEnd = 43477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TArchetype> MakeArchetypes<TArchetype>(string project) where TArchetype : Archetype
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(project);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection.MethodInfoStoreGeneric_MakeArchetypes_Public_Static_IEnumerable_1_TArchetype_String_0<TArchetype>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TArchetype>>(intPtr3) : null;
			}
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x000577F4 File Offset: 0x000559F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 577798, RefRangeEnd = 577799, XrefRangeStart = 577791, XrefRangeEnd = 577798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<CanisReflection.AbilityTypeInfo> GetAbilities(Assembly canisAssembly, Type abilityDefType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canisAssembly);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(abilityDefType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection.NativeMethodInfoPtr_GetAbilities_Public_Static_IEnumerable_1_AbilityTypeInfo_Assembly_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<CanisReflection.AbilityTypeInfo>>(intPtr3) : null;
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x0005784C File Offset: 0x00055A4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 577853, RefRangeEnd = 577854, XrefRangeStart = 577799, XrefRangeEnd = 577853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddAbilityDefinitionFactories<TMatch, TAbilityDefinition>(string project, EntityFactory<AbilityID, TAbilityDefinition> factory) where TMatch : Match where TAbilityDefinition : AbilityDefinitionForGame<TMatch>
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(project);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(factory);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection.MethodInfoStoreGeneric_AddAbilityDefinitionFactories_Public_Static_Void_String_EntityFactory_2_AbilityID_TAbilityDefinition_0<TMatch, TAbilityDefinition>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x00007642 File Offset: 0x00005842
		public CanisReflection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeMethodInfoPtr_FindCanisAssembly_Public_Static_Assembly_String_0;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeMethodInfoPtr_MakeArchetypes_Public_Static_IEnumerable_1_TArchetype_String_0;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilities_Public_Static_IEnumerable_1_AbilityTypeInfo_Assembly_Type_0;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeMethodInfoPtr_AddAbilityDefinitionFactories_Public_Static_Void_String_EntityFactory_2_AbilityID_TAbilityDefinition_0;

		// Token: 0x02000395 RID: 917
		public class AbilityDefinitionReflectionFactory<TMatch, TAbilityDefinition> : Object where TMatch : Match where TAbilityDefinition : AbilityDefinitionForGame<TMatch>
		{
			// Token: 0x06002615 RID: 9749 RVA: 0x000A81F4 File Offset: 0x000A63F4
			// Note: this type is marked as 'beforefieldinit'.
			static AbilityDefinitionReflectionFactory()
			{
				Il2CppClassPointerStore<CanisReflection.AbilityDefinitionReflectionFactory<TMatch, TAbilityDefinition>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanisReflection>.NativeClassPtr, "AbilityDefinitionReflectionFactory`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanisReflection.AbilityDefinitionReflectionFactory<TMatch, TAbilityDefinition>>.NativeClassPtr);
				CanisReflection.AbilityDefinitionReflectionFactory<TMatch, TAbilityDefinition>.NativeFieldInfoPtr_newAbilityConstructorInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisReflection.AbilityDefinitionReflectionFactory<TMatch, TAbilityDefinition>>.NativeClassPtr, "newAbilityConstructorInfo");
				CanisReflection.AbilityDefinitionReflectionFactory<TMatch, TAbilityDefinition>.NativeFieldInfoPtr_deserializeConstructorInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisReflection.AbilityDefinitionReflectionFactory<TMatch, TAbilityDefinition>>.NativeClassPtr, "deserializeConstructorInfo");
				CanisReflection.AbilityDefinitionReflectionFactory<TMatch, TAbilityDefinition>.NativeMethodInfoPtr__ctor_Public_Void_ConstructorInfo_ConstructorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection.AbilityDefinitionReflectionFactory<TMatch, TAbilityDefinition>>.NativeClassPtr, 100666461);
				CanisReflection.AbilityDefinitionReflectionFactory<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_NewAbilityFactory_Public_TAbilityDefinition_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection.AbilityDefinitionReflectionFactory<TMatch, TAbilityDefinition>>.NativeClassPtr, 100666462);
				CanisReflection.AbilityDefinitionReflectionFactory<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_DeserializeFactory_Public_TAbilityDefinition_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection.AbilityDefinitionReflectionFactory<TMatch, TAbilityDefinition>>.NativeClassPtr, 100666463);
				CanisReflection.AbilityDefinitionReflectionFactory<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_IsNewAbilityConstructor_Public_Static_Boolean_ConstructorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection.AbilityDefinitionReflectionFactory<TMatch, TAbilityDefinition>>.NativeClassPtr, 100666464);
				CanisReflection.AbilityDefinitionReflectionFactory<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_IsDeserializeConstructor_Public_Static_Boolean_ConstructorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection.AbilityDefinitionReflectionFactory<TMatch, TAbilityDefinition>>.NativeClassPtr, 100666465);
			}

			// Token: 0x06002616 RID: 9750 RVA: 0x000A82F8 File Offset: 0x000A64F8
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AbilityDefinitionReflectionFactory(ConstructorInfo newAbilityConstructorInfo, ConstructorInfo deserializeConstructorInfo)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanisReflection.AbilityDefinitionReflectionFactory<TMatch, TAbilityDefinition>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(newAbilityConstructorInfo);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deserializeConstructorInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection.AbilityDefinitionReflectionFactory<TMatch, TAbilityDefinition>.NativeMethodInfoPtr__ctor_Public_Void_ConstructorInfo_ConstructorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002617 RID: 9751 RVA: 0x000A8358 File Offset: 0x000A6558
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577518, XrefRangeEnd = 577542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TAbilityDefinition NewAbilityFactory(Match m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection.AbilityDefinitionReflectionFactory<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_NewAbilityFactory_Public_TAbilityDefinition_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TAbilityDefinition>(intPtr, false, true);
				}
			}

			// Token: 0x06002618 RID: 9752 RVA: 0x000A83A4 File Offset: 0x000A65A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577542, XrefRangeEnd = 577559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TAbilityDefinition DeserializeFactory(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection.AbilityDefinitionReflectionFactory<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_DeserializeFactory_Public_TAbilityDefinition_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TAbilityDefinition>(intPtr, false, true);
			}

			// Token: 0x06002619 RID: 9753 RVA: 0x000A8414 File Offset: 0x000A6614
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577559, XrefRangeEnd = 577564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool IsNewAbilityConstructor(ConstructorInfo constructorInfo)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(constructorInfo);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection.AbilityDefinitionReflectionFactory<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_IsNewAbilityConstructor_Public_Static_Boolean_ConstructorInfo_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600261A RID: 9754 RVA: 0x000A8458 File Offset: 0x000A6658
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577564, XrefRangeEnd = 577575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool IsDeserializeConstructor(ConstructorInfo constructorInfo)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(constructorInfo);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection.AbilityDefinitionReflectionFactory<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_IsDeserializeConstructor_Public_Static_Boolean_ConstructorInfo_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600261B RID: 9755 RVA: 0x00012279 File Offset: 0x00010479
			public AbilityDefinitionReflectionFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700095D RID: 2397
			// (get) Token: 0x0600261C RID: 9756 RVA: 0x000A849C File Offset: 0x000A669C
			// (set) Token: 0x0600261D RID: 9757 RVA: 0x00012282 File Offset: 0x00010482
			public unsafe ConstructorInfo newAbilityConstructorInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection.AbilityDefinitionReflectionFactory<TMatch, TAbilityDefinition>.NativeFieldInfoPtr_newAbilityConstructorInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection.AbilityDefinitionReflectionFactory<TMatch, TAbilityDefinition>.NativeFieldInfoPtr_newAbilityConstructorInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700095E RID: 2398
			// (get) Token: 0x0600261E RID: 9758 RVA: 0x000A84CC File Offset: 0x000A66CC
			// (set) Token: 0x0600261F RID: 9759 RVA: 0x000122A1 File Offset: 0x000104A1
			public unsafe ConstructorInfo deserializeConstructorInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection.AbilityDefinitionReflectionFactory<TMatch, TAbilityDefinition>.NativeFieldInfoPtr_deserializeConstructorInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection.AbilityDefinitionReflectionFactory<TMatch, TAbilityDefinition>.NativeFieldInfoPtr_deserializeConstructorInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017C5 RID: 6085
			private static readonly IntPtr NativeFieldInfoPtr_newAbilityConstructorInfo;

			// Token: 0x040017C6 RID: 6086
			private static readonly IntPtr NativeFieldInfoPtr_deserializeConstructorInfo;

			// Token: 0x040017C7 RID: 6087
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConstructorInfo_ConstructorInfo_0;

			// Token: 0x040017C8 RID: 6088
			private static readonly IntPtr NativeMethodInfoPtr_NewAbilityFactory_Public_TAbilityDefinition_Match_0;

			// Token: 0x040017C9 RID: 6089
			private static readonly IntPtr NativeMethodInfoPtr_DeserializeFactory_Public_TAbilityDefinition_SerializedEntity_Match_Entity_0;

			// Token: 0x040017CA RID: 6090
			private static readonly IntPtr NativeMethodInfoPtr_IsNewAbilityConstructor_Public_Static_Boolean_ConstructorInfo_0;

			// Token: 0x040017CB RID: 6091
			private static readonly IntPtr NativeMethodInfoPtr_IsDeserializeConstructor_Public_Static_Boolean_ConstructorInfo_0;
		}

		// Token: 0x02000396 RID: 918
		public sealed class AbilityTypeInfo : ValueType
		{
			// Token: 0x06002620 RID: 9760 RVA: 0x000A84FC File Offset: 0x000A66FC
			// Note: this type is marked as 'beforefieldinit'.
			static AbilityTypeInfo()
			{
				Il2CppClassPointerStore<CanisReflection.AbilityTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanisReflection>.NativeClassPtr, "AbilityTypeInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanisReflection.AbilityTypeInfo>.NativeClassPtr);
				CanisReflection.AbilityTypeInfo.NativeFieldInfoPtr__AbilityID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisReflection.AbilityTypeInfo>.NativeClassPtr, "<AbilityID>k__BackingField");
				CanisReflection.AbilityTypeInfo.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisReflection.AbilityTypeInfo>.NativeClassPtr, "<Type>k__BackingField");
				CanisReflection.AbilityTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_AbilityID_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection.AbilityTypeInfo>.NativeClassPtr, 100666466);
				CanisReflection.AbilityTypeInfo.NativeMethodInfoPtr_get_AbilityID_Public_get_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection.AbilityTypeInfo>.NativeClassPtr, 100666467);
				CanisReflection.AbilityTypeInfo.NativeMethodInfoPtr_set_AbilityID_Public_set_Void_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection.AbilityTypeInfo>.NativeClassPtr, 100666468);
				CanisReflection.AbilityTypeInfo.NativeMethodInfoPtr_get_Type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection.AbilityTypeInfo>.NativeClassPtr, 100666469);
				CanisReflection.AbilityTypeInfo.NativeMethodInfoPtr_set_Type_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection.AbilityTypeInfo>.NativeClassPtr, 100666470);
				CanisReflection.AbilityTypeInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection.AbilityTypeInfo>.NativeClassPtr, 100666471);
				CanisReflection.AbilityTypeInfo.NativeMethodInfoPtr_PrintMembers_Private_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection.AbilityTypeInfo>.NativeClassPtr, 100666472);
				CanisReflection.AbilityTypeInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AbilityTypeInfo_AbilityTypeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection.AbilityTypeInfo>.NativeClassPtr, 100666473);
				CanisReflection.AbilityTypeInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AbilityTypeInfo_AbilityTypeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection.AbilityTypeInfo>.NativeClassPtr, 100666474);
				CanisReflection.AbilityTypeInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection.AbilityTypeInfo>.NativeClassPtr, 100666475);
				CanisReflection.AbilityTypeInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection.AbilityTypeInfo>.NativeClassPtr, 100666476);
				CanisReflection.AbilityTypeInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AbilityTypeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection.AbilityTypeInfo>.NativeClassPtr, 100666477);
				CanisReflection.AbilityTypeInfo.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_AbilityID_byref_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection.AbilityTypeInfo>.NativeClassPtr, 100666478);
			}

			// Token: 0x06002621 RID: 9761 RVA: 0x000A8654 File Offset: 0x000A6854
			[CallerCount(238)]
			[CachedScanResults(RefRangeStart = 342357, RefRangeEnd = 342595, XrefRangeStart = 342357, XrefRangeEnd = 342595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AbilityTypeInfo(AbilityID AbilityID, Type Type)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanisReflection.AbilityTypeInfo>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(AbilityID);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(Type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection.AbilityTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_AbilityID_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000961 RID: 2401
			// (get) Token: 0x06002622 RID: 9762 RVA: 0x000A86B8 File Offset: 0x000A68B8
			// (set) Token: 0x06002623 RID: 9763 RVA: 0x000A86FC File Offset: 0x000A68FC
			public unsafe AbilityID AbilityID
			{
				[CallerCount(99)]
				[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection.AbilityTypeInfo.NativeMethodInfoPtr_get_AbilityID_Public_get_AbilityID_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
				}
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection.AbilityTypeInfo.NativeMethodInfoPtr_set_AbilityID_Public_set_Void_AbilityID_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000962 RID: 2402
			// (get) Token: 0x06002624 RID: 9764 RVA: 0x000A8744 File Offset: 0x000A6944
			// (set) Token: 0x06002625 RID: 9765 RVA: 0x000A8788 File Offset: 0x000A6988
			public unsafe Type Type
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection.AbilityTypeInfo.NativeMethodInfoPtr_get_Type_Public_get_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 315685, RefRangeEnd = 315686, XrefRangeStart = 315685, XrefRangeEnd = 315686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection.AbilityTypeInfo.NativeMethodInfoPtr_set_Type_Public_set_Void_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06002626 RID: 9766 RVA: 0x000A87D0 File Offset: 0x000A69D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577575, XrefRangeEnd = 577596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection.AbilityTypeInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06002627 RID: 9767 RVA: 0x000A880C File Offset: 0x000A6A0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577596, XrefRangeEnd = 577604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool PrintMembers(StringBuilder builder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection.AbilityTypeInfo.NativeMethodInfoPtr_PrintMembers_Private_Boolean_StringBuilder_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002628 RID: 9768 RVA: 0x000A8860 File Offset: 0x000A6A60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577604, XrefRangeEnd = 577608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool operator !=(CanisReflection.AbilityTypeInfo left, CanisReflection.AbilityTypeInfo right)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection.AbilityTypeInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AbilityTypeInfo_AbilityTypeInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002629 RID: 9769 RVA: 0x000A88C0 File Offset: 0x000A6AC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577608, XrefRangeEnd = 577609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool operator ==(CanisReflection.AbilityTypeInfo left, CanisReflection.AbilityTypeInfo right)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection.AbilityTypeInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AbilityTypeInfo_AbilityTypeInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600262A RID: 9770 RVA: 0x000A8920 File Offset: 0x000A6B20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577609, XrefRangeEnd = 577615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection.AbilityTypeInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600262B RID: 9771 RVA: 0x000A8964 File Offset: 0x000A6B64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577615, XrefRangeEnd = 577619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection.AbilityTypeInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600262C RID: 9772 RVA: 0x000A89B8 File Offset: 0x000A6BB8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 577623, RefRangeEnd = 577625, XrefRangeStart = 577619, XrefRangeEnd = 577623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Equals(CanisReflection.AbilityTypeInfo other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection.AbilityTypeInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AbilityTypeInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600262D RID: 9773 RVA: 0x000A8A10 File Offset: 0x000A6C10
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 577627, RefRangeEnd = 577628, XrefRangeStart = 577625, XrefRangeEnd = 577627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Deconstruct(out AbilityID AbilityID, out Type Type)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = 0;
					ptr2 = &intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(CanisReflection.AbilityTypeInfo.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_AbilityID_byref_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				IntPtr intPtr5 = intPtr;
				AbilityID = ((intPtr5 == 0) ? null : new AbilityID(intPtr5));
				IntPtr intPtr6 = intPtr2;
				Type = ((intPtr6 == 0) ? null : new Type(intPtr6));
			}

			// Token: 0x0600262E RID: 9774 RVA: 0x000122C0 File Offset: 0x000104C0
			public AbilityTypeInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600262F RID: 9775 RVA: 0x000122C9 File Offset: 0x000104C9
			public AbilityTypeInfo()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanisReflection.AbilityTypeInfo>.NativeClassPtr))
			{
			}

			// Token: 0x1700095F RID: 2399
			// (get) Token: 0x06002630 RID: 9776 RVA: 0x000A8A8C File Offset: 0x000A6C8C
			// (set) Token: 0x06002631 RID: 9777 RVA: 0x000122DB File Offset: 0x000104DB
			public unsafe AbilityID _AbilityID_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection.AbilityTypeInfo.NativeFieldInfoPtr__AbilityID_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection.AbilityTypeInfo.NativeFieldInfoPtr__AbilityID_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000960 RID: 2400
			// (get) Token: 0x06002632 RID: 9778 RVA: 0x000A8ABC File Offset: 0x000A6CBC
			// (set) Token: 0x06002633 RID: 9779 RVA: 0x000122FA File Offset: 0x000104FA
			public unsafe Type _Type_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection.AbilityTypeInfo.NativeFieldInfoPtr__Type_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection.AbilityTypeInfo.NativeFieldInfoPtr__Type_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017CC RID: 6092
			private static readonly IntPtr NativeFieldInfoPtr__AbilityID_k__BackingField;

			// Token: 0x040017CD RID: 6093
			private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

			// Token: 0x040017CE RID: 6094
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AbilityID_Type_0;

			// Token: 0x040017CF RID: 6095
			private static readonly IntPtr NativeMethodInfoPtr_get_AbilityID_Public_get_AbilityID_0;

			// Token: 0x040017D0 RID: 6096
			private static readonly IntPtr NativeMethodInfoPtr_set_AbilityID_Public_set_Void_AbilityID_0;

			// Token: 0x040017D1 RID: 6097
			private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_Type_0;

			// Token: 0x040017D2 RID: 6098
			private static readonly IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_Type_0;

			// Token: 0x040017D3 RID: 6099
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x040017D4 RID: 6100
			private static readonly IntPtr NativeMethodInfoPtr_PrintMembers_Private_Boolean_StringBuilder_0;

			// Token: 0x040017D5 RID: 6101
			private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AbilityTypeInfo_AbilityTypeInfo_0;

			// Token: 0x040017D6 RID: 6102
			private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AbilityTypeInfo_AbilityTypeInfo_0;

			// Token: 0x040017D7 RID: 6103
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x040017D8 RID: 6104
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x040017D9 RID: 6105
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AbilityTypeInfo_0;

			// Token: 0x040017DA RID: 6106
			private static readonly IntPtr NativeMethodInfoPtr_Deconstruct_Public_Void_byref_AbilityID_byref_Type_0;
		}

		// Token: 0x02000397 RID: 919
		[ObfuscatedName("Canis.data.CanisReflection+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x06002634 RID: 9780 RVA: 0x000A8AEC File Offset: 0x000A6CEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<CanisReflection.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanisReflection>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanisReflection.__c__DisplayClass0_0>.NativeClassPtr);
				CanisReflection.__c__DisplayClass0_0.NativeFieldInfoPtr_project = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisReflection.__c__DisplayClass0_0>.NativeClassPtr, "project");
				CanisReflection.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection.__c__DisplayClass0_0>.NativeClassPtr, 100666479);
				CanisReflection.__c__DisplayClass0_0.NativeMethodInfoPtr__FindCanisAssembly_b__0_Internal_Boolean_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection.__c__DisplayClass0_0>.NativeClassPtr, 100666480);
			}

			// Token: 0x06002635 RID: 9781 RVA: 0x000A8B54 File Offset: 0x000A6D54
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanisReflection.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002636 RID: 9782 RVA: 0x000A8B90 File Offset: 0x000A6D90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577628, XrefRangeEnd = 577633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FindCanisAssembly_b__0(Assembly _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection.__c__DisplayClass0_0.NativeMethodInfoPtr__FindCanisAssembly_b__0_Internal_Boolean_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002637 RID: 9783 RVA: 0x00012319 File Offset: 0x00010519
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000963 RID: 2403
			// (get) Token: 0x06002638 RID: 9784 RVA: 0x000A8BE0 File Offset: 0x000A6DE0
			// (set) Token: 0x06002639 RID: 9785 RVA: 0x00012322 File Offset: 0x00010522
			public unsafe string project
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection.__c__DisplayClass0_0.NativeFieldInfoPtr_project);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection.__c__DisplayClass0_0.NativeFieldInfoPtr_project), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040017DB RID: 6107
			private static readonly IntPtr NativeFieldInfoPtr_project;

			// Token: 0x040017DC RID: 6108
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040017DD RID: 6109
			private static readonly IntPtr NativeMethodInfoPtr__FindCanisAssembly_b__0_Internal_Boolean_Assembly_0;
		}

		// Token: 0x02000398 RID: 920
		[ObfuscatedName("Canis.data.CanisReflection+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x0600263A RID: 9786 RVA: 0x000A8C08 File Offset: 0x000A6E08
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<CanisReflection.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanisReflection>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanisReflection.__c__DisplayClass4_0>.NativeClassPtr);
				CanisReflection.__c__DisplayClass4_0.NativeFieldInfoPtr_abilityIDType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisReflection.__c__DisplayClass4_0>.NativeClassPtr, "abilityIDType");
				CanisReflection.__c__DisplayClass4_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisReflection.__c__DisplayClass4_0>.NativeClassPtr, "<>9__0");
				CanisReflection.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection.__c__DisplayClass4_0>.NativeClassPtr, 100666481);
				CanisReflection.__c__DisplayClass4_0.NativeMethodInfoPtr__GetAbilities_b__0_Internal_Boolean_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection.__c__DisplayClass4_0>.NativeClassPtr, 100666482);
			}

			// Token: 0x0600263B RID: 9787 RVA: 0x000A8C84 File Offset: 0x000A6E84
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanisReflection.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600263C RID: 9788 RVA: 0x000A8CC0 File Offset: 0x000A6EC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577633, XrefRangeEnd = 577634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAbilities_b__0(FieldInfo f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection.__c__DisplayClass4_0.NativeMethodInfoPtr__GetAbilities_b__0_Internal_Boolean_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600263D RID: 9789 RVA: 0x00012341 File Offset: 0x00010541
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000964 RID: 2404
			// (get) Token: 0x0600263E RID: 9790 RVA: 0x000A8D10 File Offset: 0x000A6F10
			// (set) Token: 0x0600263F RID: 9791 RVA: 0x0001234A File Offset: 0x0001054A
			public unsafe Type abilityIDType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection.__c__DisplayClass4_0.NativeFieldInfoPtr_abilityIDType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection.__c__DisplayClass4_0.NativeFieldInfoPtr_abilityIDType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000965 RID: 2405
			// (get) Token: 0x06002640 RID: 9792 RVA: 0x000A8D40 File Offset: 0x000A6F40
			// (set) Token: 0x06002641 RID: 9793 RVA: 0x00012369 File Offset: 0x00010569
			public unsafe Func<FieldInfo, bool> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection.__c__DisplayClass4_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection.__c__DisplayClass4_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017DE RID: 6110
			private static readonly IntPtr NativeFieldInfoPtr_abilityIDType;

			// Token: 0x040017DF RID: 6111
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x040017E0 RID: 6112
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040017E1 RID: 6113
			private static readonly IntPtr NativeMethodInfoPtr__GetAbilities_b__0_Internal_Boolean_FieldInfo_0;
		}

		// Token: 0x02000399 RID: 921
		[ObfuscatedName("Canis.data.CanisReflection+<AddAbilityDefinitionFactories>O__5_0`2")]
		public static class _AddAbilityDefinitionFactories_O__5_0<TMatch, TAbilityDefinition> : Object where TMatch : Match where TAbilityDefinition : AbilityDefinitionForGame<TMatch>
		{
			// Token: 0x06002642 RID: 9794 RVA: 0x000A8D70 File Offset: 0x000A6F70
			// Note: this type is marked as 'beforefieldinit'.
			static _AddAbilityDefinitionFactories_O__5_0()
			{
				Il2CppClassPointerStore<CanisReflection._AddAbilityDefinitionFactories_O__5_0<TMatch, TAbilityDefinition>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanisReflection>.NativeClassPtr, "<AddAbilityDefinitionFactories>O__5_0`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanisReflection._AddAbilityDefinitionFactories_O__5_0<TMatch, TAbilityDefinition>>.NativeClassPtr);
				CanisReflection._AddAbilityDefinitionFactories_O__5_0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr__0___IsNewAbilityConstructor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisReflection._AddAbilityDefinitionFactories_O__5_0<TMatch, TAbilityDefinition>>.NativeClassPtr, "<0>__IsNewAbilityConstructor");
				CanisReflection._AddAbilityDefinitionFactories_O__5_0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr__1___IsDeserializeConstructor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisReflection._AddAbilityDefinitionFactories_O__5_0<TMatch, TAbilityDefinition>>.NativeClassPtr, "<1>__IsDeserializeConstructor");
			}

			// Token: 0x06002643 RID: 9795 RVA: 0x00012388 File Offset: 0x00010588
			public _AddAbilityDefinitionFactories_O__5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000966 RID: 2406
			// (get) Token: 0x06002644 RID: 9796 RVA: 0x000A8E10 File Offset: 0x000A7010
			// (set) Token: 0x06002645 RID: 9797 RVA: 0x00012391 File Offset: 0x00010591
			public unsafe static Func<ConstructorInfo, bool> _0___IsNewAbilityConstructor
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CanisReflection._AddAbilityDefinitionFactories_O__5_0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr__0___IsNewAbilityConstructor, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ConstructorInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CanisReflection._AddAbilityDefinitionFactories_O__5_0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr__0___IsNewAbilityConstructor, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000967 RID: 2407
			// (get) Token: 0x06002646 RID: 9798 RVA: 0x000A8E38 File Offset: 0x000A7038
			// (set) Token: 0x06002647 RID: 9799 RVA: 0x000123A3 File Offset: 0x000105A3
			public unsafe static Func<ConstructorInfo, bool> _1___IsDeserializeConstructor
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CanisReflection._AddAbilityDefinitionFactories_O__5_0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr__1___IsDeserializeConstructor, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ConstructorInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CanisReflection._AddAbilityDefinitionFactories_O__5_0<TMatch, TAbilityDefinition>.NativeFieldInfoPtr__1___IsDeserializeConstructor, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017E2 RID: 6114
			private static readonly IntPtr NativeFieldInfoPtr__0___IsNewAbilityConstructor;

			// Token: 0x040017E3 RID: 6115
			private static readonly IntPtr NativeFieldInfoPtr__1___IsDeserializeConstructor;
		}

		// Token: 0x0200039A RID: 922
		[ObfuscatedName("Canis.data.CanisReflection+<GetAbilities>d__4")]
		public sealed class _GetAbilities_d__4 : Object
		{
			// Token: 0x06002648 RID: 9800 RVA: 0x000A8E60 File Offset: 0x000A7060
			// Note: this type is marked as 'beforefieldinit'.
			static _GetAbilities_d__4()
			{
				Il2CppClassPointerStore<CanisReflection._GetAbilities_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanisReflection>.NativeClassPtr, "<GetAbilities>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanisReflection._GetAbilities_d__4>.NativeClassPtr);
				CanisReflection._GetAbilities_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisReflection._GetAbilities_d__4>.NativeClassPtr, "<>1__state");
				CanisReflection._GetAbilities_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisReflection._GetAbilities_d__4>.NativeClassPtr, "<>2__current");
				CanisReflection._GetAbilities_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisReflection._GetAbilities_d__4>.NativeClassPtr, "<>l__initialThreadId");
				CanisReflection._GetAbilities_d__4.NativeFieldInfoPtr_canisAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisReflection._GetAbilities_d__4>.NativeClassPtr, "canisAssembly");
				CanisReflection._GetAbilities_d__4.NativeFieldInfoPtr___3__canisAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisReflection._GetAbilities_d__4>.NativeClassPtr, "<>3__canisAssembly");
				CanisReflection._GetAbilities_d__4.NativeFieldInfoPtr_abilityDefType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisReflection._GetAbilities_d__4>.NativeClassPtr, "abilityDefType");
				CanisReflection._GetAbilities_d__4.NativeFieldInfoPtr___3__abilityDefType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisReflection._GetAbilities_d__4>.NativeClassPtr, "<>3__abilityDefType");
				CanisReflection._GetAbilities_d__4.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisReflection._GetAbilities_d__4>.NativeClassPtr, "<>8__1");
				CanisReflection._GetAbilities_d__4.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisReflection._GetAbilities_d__4>.NativeClassPtr, "<>7__wrap1");
				CanisReflection._GetAbilities_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection._GetAbilities_d__4>.NativeClassPtr, 100666483);
				CanisReflection._GetAbilities_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection._GetAbilities_d__4>.NativeClassPtr, 100666484);
				CanisReflection._GetAbilities_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection._GetAbilities_d__4>.NativeClassPtr, 100666485);
				CanisReflection._GetAbilities_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection._GetAbilities_d__4>.NativeClassPtr, 100666486);
				CanisReflection._GetAbilities_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_data_CanisReflection_AbilityTypeInfo__get_Current_Private_Virtual_Final_New_get_AbilityTypeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection._GetAbilities_d__4>.NativeClassPtr, 100666487);
				CanisReflection._GetAbilities_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection._GetAbilities_d__4>.NativeClassPtr, 100666488);
				CanisReflection._GetAbilities_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection._GetAbilities_d__4>.NativeClassPtr, 100666489);
				CanisReflection._GetAbilities_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_data_CanisReflection_AbilityTypeInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_AbilityTypeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection._GetAbilities_d__4>.NativeClassPtr, 100666490);
				CanisReflection._GetAbilities_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection._GetAbilities_d__4>.NativeClassPtr, 100666491);
			}

			// Token: 0x06002649 RID: 9801 RVA: 0x000A8FF4 File Offset: 0x000A71F4
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetAbilities_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanisReflection._GetAbilities_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection._GetAbilities_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600264A RID: 9802 RVA: 0x000A903C File Offset: 0x000A723C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577634, XrefRangeEnd = 577639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection._GetAbilities_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600264B RID: 9803 RVA: 0x000A9070 File Offset: 0x000A7270
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577639, XrefRangeEnd = 577689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection._GetAbilities_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600264C RID: 9804 RVA: 0x000A90AC File Offset: 0x000A72AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577689, XrefRangeEnd = 577692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection._GetAbilities_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000971 RID: 2417
			// (get) Token: 0x0600264D RID: 9805 RVA: 0x000A90E0 File Offset: 0x000A72E0
			public unsafe CanisReflection.AbilityTypeInfo System.Collections.Generic.IEnumerator<Canis.data.CanisReflection.AbilityTypeInfo>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection._GetAbilities_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_data_CanisReflection_AbilityTypeInfo__get_Current_Private_Virtual_Final_New_get_AbilityTypeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new CanisReflection.AbilityTypeInfo(intPtr);
				}
			}

			// Token: 0x0600264E RID: 9806 RVA: 0x000A9118 File Offset: 0x000A7318
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577692, XrefRangeEnd = 577697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection._GetAbilities_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000972 RID: 2418
			// (get) Token: 0x0600264F RID: 9807 RVA: 0x000A914C File Offset: 0x000A734C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577697, XrefRangeEnd = 577700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection._GetAbilities_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002650 RID: 9808 RVA: 0x000A918C File Offset: 0x000A738C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577700, XrefRangeEnd = 577709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<CanisReflection.AbilityTypeInfo> System_Collections_Generic_IEnumerable_Canis_data_CanisReflection_AbilityTypeInfo__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection._GetAbilities_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_data_CanisReflection_AbilityTypeInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_AbilityTypeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<CanisReflection.AbilityTypeInfo>>(intPtr3) : null;
			}

			// Token: 0x06002651 RID: 9809 RVA: 0x000A91CC File Offset: 0x000A73CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection._GetAbilities_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002652 RID: 9810 RVA: 0x000123B5 File Offset: 0x000105B5
			public _GetAbilities_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000968 RID: 2408
			// (get) Token: 0x06002653 RID: 9811 RVA: 0x000A920C File Offset: 0x000A740C
			// (set) Token: 0x06002654 RID: 9812 RVA: 0x000123BE File Offset: 0x000105BE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._GetAbilities_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._GetAbilities_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000969 RID: 2409
			// (get) Token: 0x06002655 RID: 9813 RVA: 0x000A9234 File Offset: 0x000A7434
			// (set) Token: 0x06002656 RID: 9814 RVA: 0x000123D9 File Offset: 0x000105D9
			public CanisReflection.AbilityTypeInfo __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._GetAbilities_d__4.NativeFieldInfoPtr___2__current);
					return new CanisReflection.AbilityTypeInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CanisReflection.AbilityTypeInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._GetAbilities_d__4.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CanisReflection.AbilityTypeInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700096A RID: 2410
			// (get) Token: 0x06002657 RID: 9815 RVA: 0x000A9264 File Offset: 0x000A7464
			// (set) Token: 0x06002658 RID: 9816 RVA: 0x00012407 File Offset: 0x00010607
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._GetAbilities_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._GetAbilities_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700096B RID: 2411
			// (get) Token: 0x06002659 RID: 9817 RVA: 0x000A928C File Offset: 0x000A748C
			// (set) Token: 0x0600265A RID: 9818 RVA: 0x00012422 File Offset: 0x00010622
			public unsafe Assembly canisAssembly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._GetAbilities_d__4.NativeFieldInfoPtr_canisAssembly);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._GetAbilities_d__4.NativeFieldInfoPtr_canisAssembly), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700096C RID: 2412
			// (get) Token: 0x0600265B RID: 9819 RVA: 0x000A92BC File Offset: 0x000A74BC
			// (set) Token: 0x0600265C RID: 9820 RVA: 0x00012441 File Offset: 0x00010641
			public unsafe Assembly __3__canisAssembly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._GetAbilities_d__4.NativeFieldInfoPtr___3__canisAssembly);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._GetAbilities_d__4.NativeFieldInfoPtr___3__canisAssembly), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700096D RID: 2413
			// (get) Token: 0x0600265D RID: 9821 RVA: 0x000A92EC File Offset: 0x000A74EC
			// (set) Token: 0x0600265E RID: 9822 RVA: 0x00012460 File Offset: 0x00010660
			public unsafe Type abilityDefType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._GetAbilities_d__4.NativeFieldInfoPtr_abilityDefType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._GetAbilities_d__4.NativeFieldInfoPtr_abilityDefType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700096E RID: 2414
			// (get) Token: 0x0600265F RID: 9823 RVA: 0x000A931C File Offset: 0x000A751C
			// (set) Token: 0x06002660 RID: 9824 RVA: 0x0001247F File Offset: 0x0001067F
			public unsafe Type __3__abilityDefType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._GetAbilities_d__4.NativeFieldInfoPtr___3__abilityDefType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._GetAbilities_d__4.NativeFieldInfoPtr___3__abilityDefType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700096F RID: 2415
			// (get) Token: 0x06002661 RID: 9825 RVA: 0x000A934C File Offset: 0x000A754C
			// (set) Token: 0x06002662 RID: 9826 RVA: 0x0001249E File Offset: 0x0001069E
			public unsafe CanisReflection.__c__DisplayClass4_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._GetAbilities_d__4.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanisReflection.__c__DisplayClass4_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._GetAbilities_d__4.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000970 RID: 2416
			// (get) Token: 0x06002663 RID: 9827 RVA: 0x000A937C File Offset: 0x000A757C
			// (set) Token: 0x06002664 RID: 9828 RVA: 0x000124BD File Offset: 0x000106BD
			public unsafe IEnumerator<Type> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._GetAbilities_d__4.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Type>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._GetAbilities_d__4.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017E4 RID: 6116
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017E5 RID: 6117
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040017E6 RID: 6118
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040017E7 RID: 6119
			private static readonly IntPtr NativeFieldInfoPtr_canisAssembly;

			// Token: 0x040017E8 RID: 6120
			private static readonly IntPtr NativeFieldInfoPtr___3__canisAssembly;

			// Token: 0x040017E9 RID: 6121
			private static readonly IntPtr NativeFieldInfoPtr_abilityDefType;

			// Token: 0x040017EA RID: 6122
			private static readonly IntPtr NativeFieldInfoPtr___3__abilityDefType;

			// Token: 0x040017EB RID: 6123
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040017EC RID: 6124
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040017ED RID: 6125
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040017EE RID: 6126
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017EF RID: 6127
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040017F0 RID: 6128
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040017F1 RID: 6129
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_data_CanisReflection_AbilityTypeInfo__get_Current_Private_Virtual_Final_New_get_AbilityTypeInfo_0;

			// Token: 0x040017F2 RID: 6130
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017F3 RID: 6131
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040017F4 RID: 6132
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_data_CanisReflection_AbilityTypeInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_AbilityTypeInfo_0;

			// Token: 0x040017F5 RID: 6133
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200039B RID: 923
		[ObfuscatedName("Canis.data.CanisReflection+<MakeArchetypes>d__1`1")]
		public sealed class _MakeArchetypes_d__1<TArchetype> : Object where TArchetype : Archetype
		{
			// Token: 0x06002665 RID: 9829 RVA: 0x000A93AC File Offset: 0x000A75AC
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeArchetypes_d__1()
			{
				Il2CppClassPointerStore<CanisReflection._MakeArchetypes_d__1<TArchetype>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanisReflection>.NativeClassPtr, "<MakeArchetypes>d__1`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArchetype>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanisReflection._MakeArchetypes_d__1<TArchetype>>.NativeClassPtr);
				CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisReflection._MakeArchetypes_d__1<TArchetype>>.NativeClassPtr, "<>1__state");
				CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisReflection._MakeArchetypes_d__1<TArchetype>>.NativeClassPtr, "<>2__current");
				CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisReflection._MakeArchetypes_d__1<TArchetype>>.NativeClassPtr, "<>l__initialThreadId");
				CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeFieldInfoPtr_project = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisReflection._MakeArchetypes_d__1<TArchetype>>.NativeClassPtr, "project");
				CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeFieldInfoPtr___3__project = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisReflection._MakeArchetypes_d__1<TArchetype>>.NativeClassPtr, "<>3__project");
				CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeFieldInfoPtr__archetypeType_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisReflection._MakeArchetypes_d__1<TArchetype>>.NativeClassPtr, "<archetypeType>5__2");
				CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisReflection._MakeArchetypes_d__1<TArchetype>>.NativeClassPtr, "<>7__wrap2");
				CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection._MakeArchetypes_d__1<TArchetype>>.NativeClassPtr, 100666492);
				CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection._MakeArchetypes_d__1<TArchetype>>.NativeClassPtr, 100666493);
				CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection._MakeArchetypes_d__1<TArchetype>>.NativeClassPtr, 100666494);
				CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection._MakeArchetypes_d__1<TArchetype>>.NativeClassPtr, 100666495);
				CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TArchetype__get_Current_Private_Virtual_Final_New_get_TArchetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection._MakeArchetypes_d__1<TArchetype>>.NativeClassPtr, 100666496);
				CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection._MakeArchetypes_d__1<TArchetype>>.NativeClassPtr, 100666497);
				CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection._MakeArchetypes_d__1<TArchetype>>.NativeClassPtr, 100666498);
				CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TArchetype__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TArchetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection._MakeArchetypes_d__1<TArchetype>>.NativeClassPtr, 100666499);
				CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisReflection._MakeArchetypes_d__1<TArchetype>>.NativeClassPtr, 100666500);
			}

			// Token: 0x06002666 RID: 9830 RVA: 0x000A9554 File Offset: 0x000A7754
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeArchetypes_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanisReflection._MakeArchetypes_d__1<TArchetype>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002667 RID: 9831 RVA: 0x000A959C File Offset: 0x000A779C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577709, XrefRangeEnd = 577714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002668 RID: 9832 RVA: 0x000A95D0 File Offset: 0x000A77D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577714, XrefRangeEnd = 577757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002669 RID: 9833 RVA: 0x000A960C File Offset: 0x000A780C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577757, XrefRangeEnd = 577760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700097A RID: 2426
			// (get) Token: 0x0600266A RID: 9834 RVA: 0x000A9640 File Offset: 0x000A7840
			public unsafe TArchetype System.Collections.Generic.IEnumerator<TArchetype>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TArchetype__get_Current_Private_Virtual_Final_New_get_TArchetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TArchetype>(intPtr, false, true);
				}
			}

			// Token: 0x0600266B RID: 9835 RVA: 0x000A967C File Offset: 0x000A787C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700097B RID: 2427
			// (get) Token: 0x0600266C RID: 9836 RVA: 0x000A96B0 File Offset: 0x000A78B0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600266D RID: 9837 RVA: 0x000A96F0 File Offset: 0x000A78F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TArchetype> System_Collections_Generic_IEnumerable_TArchetype__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TArchetype__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TArchetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TArchetype>>(intPtr3) : null;
			}

			// Token: 0x0600266E RID: 9838 RVA: 0x000A9730 File Offset: 0x000A7930
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577760, XrefRangeEnd = 577767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600266F RID: 9839 RVA: 0x000124DC File Offset: 0x000106DC
			public _MakeArchetypes_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000973 RID: 2419
			// (get) Token: 0x06002670 RID: 9840 RVA: 0x000A9770 File Offset: 0x000A7970
			// (set) Token: 0x06002671 RID: 9841 RVA: 0x000124E5 File Offset: 0x000106E5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000974 RID: 2420
			// (get) Token: 0x06002672 RID: 9842 RVA: 0x000A9798 File Offset: 0x000A7998
			// (set) Token: 0x06002673 RID: 9843 RVA: 0x000A97C0 File Offset: 0x000A79C0
			public unsafe TArchetype __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TArchetype>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TArchetype);
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

			// Token: 0x17000975 RID: 2421
			// (get) Token: 0x06002674 RID: 9844 RVA: 0x000A9868 File Offset: 0x000A7A68
			// (set) Token: 0x06002675 RID: 9845 RVA: 0x00012500 File Offset: 0x00010700
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000976 RID: 2422
			// (get) Token: 0x06002676 RID: 9846 RVA: 0x000A9890 File Offset: 0x000A7A90
			// (set) Token: 0x06002677 RID: 9847 RVA: 0x0001251B File Offset: 0x0001071B
			public unsafe string project
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeFieldInfoPtr_project);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeFieldInfoPtr_project), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000977 RID: 2423
			// (get) Token: 0x06002678 RID: 9848 RVA: 0x000A98B8 File Offset: 0x000A7AB8
			// (set) Token: 0x06002679 RID: 9849 RVA: 0x0001253A File Offset: 0x0001073A
			public unsafe string __3__project
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeFieldInfoPtr___3__project);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeFieldInfoPtr___3__project), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000978 RID: 2424
			// (get) Token: 0x0600267A RID: 9850 RVA: 0x000A98E0 File Offset: 0x000A7AE0
			// (set) Token: 0x0600267B RID: 9851 RVA: 0x00012559 File Offset: 0x00010759
			public unsafe Type _archetypeType_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeFieldInfoPtr__archetypeType_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeFieldInfoPtr__archetypeType_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000979 RID: 2425
			// (get) Token: 0x0600267C RID: 9852 RVA: 0x000A9910 File Offset: 0x000A7B10
			// (set) Token: 0x0600267D RID: 9853 RVA: 0x00012578 File Offset: 0x00010778
			public unsafe IEnumerator<Type> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Type>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisReflection._MakeArchetypes_d__1<TArchetype>.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017F6 RID: 6134
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017F7 RID: 6135
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040017F8 RID: 6136
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040017F9 RID: 6137
			private static readonly IntPtr NativeFieldInfoPtr_project;

			// Token: 0x040017FA RID: 6138
			private static readonly IntPtr NativeFieldInfoPtr___3__project;

			// Token: 0x040017FB RID: 6139
			private static readonly IntPtr NativeFieldInfoPtr__archetypeType_5__2;

			// Token: 0x040017FC RID: 6140
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040017FD RID: 6141
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040017FE RID: 6142
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017FF RID: 6143
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001800 RID: 6144
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001801 RID: 6145
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TArchetype__get_Current_Private_Virtual_Final_New_get_TArchetype_0;

			// Token: 0x04001802 RID: 6146
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001803 RID: 6147
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001804 RID: 6148
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TArchetype__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TArchetype_0;

			// Token: 0x04001805 RID: 6149
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200039C RID: 924
		private sealed class MethodInfoStoreGeneric_MakeArchetypes_Public_Static_IEnumerable_1_TArchetype_String_0<TArchetype>
		{
			// Token: 0x04001806 RID: 6150
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CanisReflection.NativeMethodInfoPtr_MakeArchetypes_Public_Static_IEnumerable_1_TArchetype_String_0, Il2CppClassPointerStore<CanisReflection>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArchetype>.NativeClassPtr)) }))));
		}

		// Token: 0x0200039D RID: 925
		private sealed class MethodInfoStoreGeneric_AddAbilityDefinitionFactories_Public_Static_Void_String_EntityFactory_2_AbilityID_TAbilityDefinition_0<TMatch, TAbilityDefinition>
		{
			// Token: 0x04001807 RID: 6151
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CanisReflection.NativeMethodInfoPtr_AddAbilityDefinitionFactories_Public_Static_Void_String_EntityFactory_2_AbilityID_TAbilityDefinition_0, Il2CppClassPointerStore<CanisReflection>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr))
			}))));
		}
	}
}
