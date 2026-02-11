using System;
using System.Runtime.InteropServices;
using Canis;
using canis.archetypes;
using Canis.attributes;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.abilities;
using worm.canis.entities;

namespace worm.canis.archetypes
{
	// Token: 0x020000E6 RID: 230
	public class WormArchetype : Archetype
	{
		// Token: 0x06000FAB RID: 4011 RVA: 0x0009AE64 File Offset: 0x00099064
		// Note: this type is marked as 'beforefieldinit'.
		static WormArchetype()
		{
			Il2CppClassPointerStore<WormArchetype>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes", "WormArchetype");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormArchetype>.NativeClassPtr);
			WormArchetype.NativeFieldInfoPtr_archetypeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetype>.NativeClassPtr, "archetypeID");
			WormArchetype.NativeFieldInfoPtr_archetypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetype>.NativeClassPtr, "archetypes");
			WormArchetype.NativeMethodInfoPtr_get_ArchetypeID_Public_Virtual_get_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetype>.NativeClassPtr, 100666038);
			WormArchetype.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetype>.NativeClassPtr, 100666039);
			WormArchetype.NativeMethodInfoPtr_get_AbilityIDsAttribute_Public_Virtual_get_AttributeDefinition_1_List_1_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetype>.NativeClassPtr, 100666040);
			WormArchetype.NativeMethodInfoPtr_ConstructAbilities_Public_Void_WormMatch_WormPlayer_IHasAbilities_2_WormMatch_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetype>.NativeClassPtr, 100666041);
			WormArchetype.NativeMethodInfoPtr_MatchConstructor_Private_Entity_Il2CppReferenceArray_1_Object_Func_4_WormMatch_PlayerEntity_Entity_Entity_Func_4_SerializedEntity_WormMatch_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetype>.NativeClassPtr, 100666042);
			WormArchetype.NativeMethodInfoPtr_Make_Private_Entity_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetype>.NativeClassPtr, 100666043);
			WormArchetype.NativeMethodInfoPtr_Build_Public_Virtual_Entity_Match_PlayerEntity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetype>.NativeClassPtr, 100666044);
			WormArchetype.NativeMethodInfoPtr_Deserialize_Public_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetype>.NativeClassPtr, 100666045);
			WormArchetype.NativeMethodInfoPtr__Make_b__9_0_Private_Entity_WormMatch_PlayerEntity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetype>.NativeClassPtr, 100666046);
			WormArchetype.NativeMethodInfoPtr__Make_b__9_2_Private_Entity_WormMatch_PlayerEntity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetype>.NativeClassPtr, 100666047);
			WormArchetype.NativeMethodInfoPtr__Make_b__9_4_Private_Entity_WormMatch_PlayerEntity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetype>.NativeClassPtr, 100666048);
			WormArchetype.NativeMethodInfoPtr__Make_b__9_6_Private_Entity_WormMatch_PlayerEntity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetype>.NativeClassPtr, 100666049);
			WormArchetype.NativeMethodInfoPtr__Make_b__9_8_Private_Entity_WormMatch_PlayerEntity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetype>.NativeClassPtr, 100666050);
			WormArchetype.NativeMethodInfoPtr__Make_b__9_10_Private_Entity_WormMatch_PlayerEntity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetype>.NativeClassPtr, 100666051);
			WormArchetype.NativeMethodInfoPtr__Make_b__9_12_Private_Entity_WormMatch_PlayerEntity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetype>.NativeClassPtr, 100666052);
			WormArchetype.NativeMethodInfoPtr__Make_b__9_14_Private_Entity_WormMatch_PlayerEntity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetype>.NativeClassPtr, 100666053);
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x0009AFFC File Offset: 0x000991FC
		public unsafe override ArchetypeID ArchetypeID
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77318, XrefRangeEnd = 77322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormArchetype.NativeMethodInfoPtr_get_ArchetypeID_Public_Virtual_get_ArchetypeID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
			}
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x0009B048 File Offset: 0x00099248
		[CallerCount(272)]
		[CachedScanResults(RefRangeStart = 77323, RefRangeEnd = 77595, XrefRangeStart = 77322, XrefRangeEnd = 77323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormArchetype()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormArchetype>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetype.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x0009B084 File Offset: 0x00099284
		public unsafe override AttributeDefinition<List<AbilityID>> AbilityIDsAttribute
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77595, XrefRangeEnd = 77599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormArchetype.NativeMethodInfoPtr_get_AbilityIDsAttribute_Public_Virtual_get_AttributeDefinition_1_List_1_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<AbilityID>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x0009B0D0 File Offset: 0x000992D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77599, XrefRangeEnd = 77635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConstructAbilities(WormMatch wormMatch, WormPlayer owner, IHasAbilities<WormMatch, WormAbilityDefinition> hasAbilities)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hasAbilities);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetype.NativeMethodInfoPtr_ConstructAbilities_Public_Void_WormMatch_WormPlayer_IHasAbilities_2_WormMatch_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x0009B138 File Offset: 0x00099338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77635, XrefRangeEnd = 77648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entity MatchConstructor(Il2CppReferenceArray<Object> parameters, Func<WormMatch, PlayerEntity, Entity, Entity> build, Func<SerializedEntity, WormMatch, Entity, Entity> deserialize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(build);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deserialize);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetype.NativeMethodInfoPtr_MatchConstructor_Private_Entity_Il2CppReferenceArray_1_Object_Func_4_WormMatch_PlayerEntity_Entity_Entity_Func_4_SerializedEntity_WormMatch_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x0009B1AC File Offset: 0x000993AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 77785, RefRangeEnd = 77788, XrefRangeStart = 77648, XrefRangeEnd = 77785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entity Make([Optional] Il2CppReferenceArray<Object> parameters)
		{
			if (parameters == null)
			{
				parameters = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetype.NativeMethodInfoPtr_Make_Private_Entity_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x0009B20C File Offset: 0x0009940C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77788, XrefRangeEnd = 77806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Entity Build(Match m, PlayerEntity owner, Entity parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormArchetype.NativeMethodInfoPtr_Build_Public_Virtual_Entity_Match_PlayerEntity_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x0009B28C File Offset: 0x0009948C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77806, XrefRangeEnd = 77824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entity Deserialize(SerializedEntity se, Match m, Entity parent)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetype.NativeMethodInfoPtr_Deserialize_Public_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x0009B300 File Offset: 0x00099500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77824, XrefRangeEnd = 77828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entity _Make_b__9_0(WormMatch m, PlayerEntity player, Entity parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetype.NativeMethodInfoPtr__Make_b__9_0_Private_Entity_WormMatch_PlayerEntity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x0009B374 File Offset: 0x00099574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77828, XrefRangeEnd = 77832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entity _Make_b__9_2(WormMatch m, PlayerEntity player, Entity parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetype.NativeMethodInfoPtr__Make_b__9_2_Private_Entity_WormMatch_PlayerEntity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x0009B3E8 File Offset: 0x000995E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77832, XrefRangeEnd = 77836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entity _Make_b__9_4(WormMatch m, PlayerEntity player, Entity parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetype.NativeMethodInfoPtr__Make_b__9_4_Private_Entity_WormMatch_PlayerEntity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x0009B45C File Offset: 0x0009965C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77836, XrefRangeEnd = 77840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entity _Make_b__9_6(WormMatch m, PlayerEntity player, Entity parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetype.NativeMethodInfoPtr__Make_b__9_6_Private_Entity_WormMatch_PlayerEntity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x0009B4D0 File Offset: 0x000996D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77840, XrefRangeEnd = 77844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entity _Make_b__9_8(WormMatch m, PlayerEntity player, Entity parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetype.NativeMethodInfoPtr__Make_b__9_8_Private_Entity_WormMatch_PlayerEntity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x0009B544 File Offset: 0x00099744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77844, XrefRangeEnd = 77848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entity _Make_b__9_10(WormMatch m, PlayerEntity player, Entity parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetype.NativeMethodInfoPtr__Make_b__9_10_Private_Entity_WormMatch_PlayerEntity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x0009B5B8 File Offset: 0x000997B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77848, XrefRangeEnd = 77852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entity _Make_b__9_12(WormMatch m, PlayerEntity player, Entity parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetype.NativeMethodInfoPtr__Make_b__9_12_Private_Entity_WormMatch_PlayerEntity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x0009B62C File Offset: 0x0009982C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77852, XrefRangeEnd = 77856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entity _Make_b__9_14(WormMatch m, PlayerEntity player, Entity parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetype.NativeMethodInfoPtr__Make_b__9_14_Private_Entity_WormMatch_PlayerEntity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x0000845D File Offset: 0x0000665D
		public Entity Make(params Object[] parameters)
		{
			return this.Make(new Il2CppReferenceArray<Object>(parameters));
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x0000846B File Offset: 0x0000666B
		public WormArchetype(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06000FBE RID: 4030 RVA: 0x0009B6A0 File Offset: 0x000998A0
		// (set) Token: 0x06000FBF RID: 4031 RVA: 0x00008474 File Offset: 0x00006674
		public unsafe ArchetypeID archetypeID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetype.NativeFieldInfoPtr_archetypeID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetype.NativeFieldInfoPtr_archetypeID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x0009B6D0 File Offset: 0x000998D0
		// (set) Token: 0x06000FC1 RID: 4033 RVA: 0x00008493 File Offset: 0x00006693
		public unsafe WormArchetypes archetypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetype.NativeFieldInfoPtr_archetypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormArchetypes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetype.NativeFieldInfoPtr_archetypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeFieldInfoPtr_archetypeID;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeFieldInfoPtr_archetypes;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeMethodInfoPtr_get_ArchetypeID_Public_Virtual_get_ArchetypeID_0;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeMethodInfoPtr_get_AbilityIDsAttribute_Public_Virtual_get_AttributeDefinition_1_List_1_AbilityID_0;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeMethodInfoPtr_ConstructAbilities_Public_Void_WormMatch_WormPlayer_IHasAbilities_2_WormMatch_WormAbilityDefinition_0;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeMethodInfoPtr_MatchConstructor_Private_Entity_Il2CppReferenceArray_1_Object_Func_4_WormMatch_PlayerEntity_Entity_Entity_Func_4_SerializedEntity_WormMatch_Entity_Entity_0;

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeMethodInfoPtr_Make_Private_Entity_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Virtual_Entity_Match_PlayerEntity_Entity_0;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Entity_SerializedEntity_Match_Entity_0;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeMethodInfoPtr__Make_b__9_0_Private_Entity_WormMatch_PlayerEntity_Entity_0;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeMethodInfoPtr__Make_b__9_2_Private_Entity_WormMatch_PlayerEntity_Entity_0;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeMethodInfoPtr__Make_b__9_4_Private_Entity_WormMatch_PlayerEntity_Entity_0;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeMethodInfoPtr__Make_b__9_6_Private_Entity_WormMatch_PlayerEntity_Entity_0;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeMethodInfoPtr__Make_b__9_8_Private_Entity_WormMatch_PlayerEntity_Entity_0;

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeMethodInfoPtr__Make_b__9_10_Private_Entity_WormMatch_PlayerEntity_Entity_0;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeMethodInfoPtr__Make_b__9_12_Private_Entity_WormMatch_PlayerEntity_Entity_0;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeMethodInfoPtr__Make_b__9_14_Private_Entity_WormMatch_PlayerEntity_Entity_0;

		// Token: 0x02000636 RID: 1590
		[ObfuscatedName("worm.canis.archetypes.WormArchetype+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005018 RID: 20504 RVA: 0x001A8F6C File Offset: 0x001A716C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormArchetype.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormArchetype>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormArchetype.__c>.NativeClassPtr);
				WormArchetype.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetype.__c>.NativeClassPtr, "<>9");
				WormArchetype.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetype.__c>.NativeClassPtr, "<>9__9_1");
				WormArchetype.__c.NativeFieldInfoPtr___9__9_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetype.__c>.NativeClassPtr, "<>9__9_3");
				WormArchetype.__c.NativeFieldInfoPtr___9__9_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetype.__c>.NativeClassPtr, "<>9__9_5");
				WormArchetype.__c.NativeFieldInfoPtr___9__9_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetype.__c>.NativeClassPtr, "<>9__9_7");
				WormArchetype.__c.NativeFieldInfoPtr___9__9_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetype.__c>.NativeClassPtr, "<>9__9_9");
				WormArchetype.__c.NativeFieldInfoPtr___9__9_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetype.__c>.NativeClassPtr, "<>9__9_11");
				WormArchetype.__c.NativeFieldInfoPtr___9__9_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetype.__c>.NativeClassPtr, "<>9__9_13");
				WormArchetype.__c.NativeFieldInfoPtr___9__9_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetype.__c>.NativeClassPtr, "<>9__9_15");
				WormArchetype.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetype.__c>.NativeClassPtr, 100666055);
				WormArchetype.__c.NativeMethodInfoPtr__Make_b__9_1_Internal_Entity_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetype.__c>.NativeClassPtr, 100666056);
				WormArchetype.__c.NativeMethodInfoPtr__Make_b__9_3_Internal_Entity_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetype.__c>.NativeClassPtr, 100666057);
				WormArchetype.__c.NativeMethodInfoPtr__Make_b__9_5_Internal_Entity_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetype.__c>.NativeClassPtr, 100666058);
				WormArchetype.__c.NativeMethodInfoPtr__Make_b__9_7_Internal_Entity_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetype.__c>.NativeClassPtr, 100666059);
				WormArchetype.__c.NativeMethodInfoPtr__Make_b__9_9_Internal_Entity_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetype.__c>.NativeClassPtr, 100666060);
				WormArchetype.__c.NativeMethodInfoPtr__Make_b__9_11_Internal_Entity_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetype.__c>.NativeClassPtr, 100666061);
				WormArchetype.__c.NativeMethodInfoPtr__Make_b__9_13_Internal_Entity_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetype.__c>.NativeClassPtr, 100666062);
				WormArchetype.__c.NativeMethodInfoPtr__Make_b__9_15_Internal_Entity_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetype.__c>.NativeClassPtr, 100666063);
			}

			// Token: 0x06005019 RID: 20505 RVA: 0x001A9100 File Offset: 0x001A7300
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormArchetype.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetype.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600501A RID: 20506 RVA: 0x001A913C File Offset: 0x001A733C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77286, XrefRangeEnd = 77290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _Make_b__9_1(SerializedEntity se, WormMatch m, Entity parent)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetype.__c.NativeMethodInfoPtr__Make_b__9_1_Internal_Entity_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x0600501B RID: 20507 RVA: 0x001A91B0 File Offset: 0x001A73B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77290, XrefRangeEnd = 77294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _Make_b__9_3(SerializedEntity se, WormMatch m, Entity parent)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetype.__c.NativeMethodInfoPtr__Make_b__9_3_Internal_Entity_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x0600501C RID: 20508 RVA: 0x001A9224 File Offset: 0x001A7424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77294, XrefRangeEnd = 77298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _Make_b__9_5(SerializedEntity se, WormMatch m, Entity parent)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetype.__c.NativeMethodInfoPtr__Make_b__9_5_Internal_Entity_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x0600501D RID: 20509 RVA: 0x001A9298 File Offset: 0x001A7498
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77298, XrefRangeEnd = 77302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _Make_b__9_7(SerializedEntity se, WormMatch m, Entity parent)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetype.__c.NativeMethodInfoPtr__Make_b__9_7_Internal_Entity_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x0600501E RID: 20510 RVA: 0x001A930C File Offset: 0x001A750C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77302, XrefRangeEnd = 77306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _Make_b__9_9(SerializedEntity se, WormMatch m, Entity parent)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetype.__c.NativeMethodInfoPtr__Make_b__9_9_Internal_Entity_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x0600501F RID: 20511 RVA: 0x001A9380 File Offset: 0x001A7580
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77306, XrefRangeEnd = 77310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _Make_b__9_11(SerializedEntity se, WormMatch m, Entity parent)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetype.__c.NativeMethodInfoPtr__Make_b__9_11_Internal_Entity_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06005020 RID: 20512 RVA: 0x001A93F4 File Offset: 0x001A75F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77310, XrefRangeEnd = 77314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _Make_b__9_13(SerializedEntity se, WormMatch m, Entity parent)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetype.__c.NativeMethodInfoPtr__Make_b__9_13_Internal_Entity_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06005021 RID: 20513 RVA: 0x001A9468 File Offset: 0x001A7668
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77314, XrefRangeEnd = 77318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _Make_b__9_15(SerializedEntity se, WormMatch m, Entity parent)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetype.__c.NativeMethodInfoPtr__Make_b__9_15_Internal_Entity_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06005022 RID: 20514 RVA: 0x0001BB55 File Offset: 0x00019D55
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013B4 RID: 5044
			// (get) Token: 0x06005023 RID: 20515 RVA: 0x001A94DC File Offset: 0x001A76DC
			// (set) Token: 0x06005024 RID: 20516 RVA: 0x0001BB5E File Offset: 0x00019D5E
			public unsafe static WormArchetype.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormArchetype.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormArchetype.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormArchetype.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013B5 RID: 5045
			// (get) Token: 0x06005025 RID: 20517 RVA: 0x001A9504 File Offset: 0x001A7704
			// (set) Token: 0x06005026 RID: 20518 RVA: 0x0001BB70 File Offset: 0x00019D70
			public unsafe static Func<SerializedEntity, WormMatch, Entity, Entity> __9__9_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormArchetype.__c.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SerializedEntity, WormMatch, Entity, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormArchetype.__c.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013B6 RID: 5046
			// (get) Token: 0x06005027 RID: 20519 RVA: 0x001A952C File Offset: 0x001A772C
			// (set) Token: 0x06005028 RID: 20520 RVA: 0x0001BB82 File Offset: 0x00019D82
			public unsafe static Func<SerializedEntity, WormMatch, Entity, Entity> __9__9_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormArchetype.__c.NativeFieldInfoPtr___9__9_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SerializedEntity, WormMatch, Entity, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormArchetype.__c.NativeFieldInfoPtr___9__9_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013B7 RID: 5047
			// (get) Token: 0x06005029 RID: 20521 RVA: 0x001A9554 File Offset: 0x001A7754
			// (set) Token: 0x0600502A RID: 20522 RVA: 0x0001BB94 File Offset: 0x00019D94
			public unsafe static Func<SerializedEntity, WormMatch, Entity, Entity> __9__9_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormArchetype.__c.NativeFieldInfoPtr___9__9_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SerializedEntity, WormMatch, Entity, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormArchetype.__c.NativeFieldInfoPtr___9__9_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013B8 RID: 5048
			// (get) Token: 0x0600502B RID: 20523 RVA: 0x001A957C File Offset: 0x001A777C
			// (set) Token: 0x0600502C RID: 20524 RVA: 0x0001BBA6 File Offset: 0x00019DA6
			public unsafe static Func<SerializedEntity, WormMatch, Entity, Entity> __9__9_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormArchetype.__c.NativeFieldInfoPtr___9__9_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SerializedEntity, WormMatch, Entity, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormArchetype.__c.NativeFieldInfoPtr___9__9_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013B9 RID: 5049
			// (get) Token: 0x0600502D RID: 20525 RVA: 0x001A95A4 File Offset: 0x001A77A4
			// (set) Token: 0x0600502E RID: 20526 RVA: 0x0001BBB8 File Offset: 0x00019DB8
			public unsafe static Func<SerializedEntity, WormMatch, Entity, Entity> __9__9_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormArchetype.__c.NativeFieldInfoPtr___9__9_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SerializedEntity, WormMatch, Entity, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormArchetype.__c.NativeFieldInfoPtr___9__9_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013BA RID: 5050
			// (get) Token: 0x0600502F RID: 20527 RVA: 0x001A95CC File Offset: 0x001A77CC
			// (set) Token: 0x06005030 RID: 20528 RVA: 0x0001BBCA File Offset: 0x00019DCA
			public unsafe static Func<SerializedEntity, WormMatch, Entity, Entity> __9__9_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormArchetype.__c.NativeFieldInfoPtr___9__9_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SerializedEntity, WormMatch, Entity, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormArchetype.__c.NativeFieldInfoPtr___9__9_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013BB RID: 5051
			// (get) Token: 0x06005031 RID: 20529 RVA: 0x001A95F4 File Offset: 0x001A77F4
			// (set) Token: 0x06005032 RID: 20530 RVA: 0x0001BBDC File Offset: 0x00019DDC
			public unsafe static Func<SerializedEntity, WormMatch, Entity, Entity> __9__9_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormArchetype.__c.NativeFieldInfoPtr___9__9_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SerializedEntity, WormMatch, Entity, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormArchetype.__c.NativeFieldInfoPtr___9__9_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013BC RID: 5052
			// (get) Token: 0x06005033 RID: 20531 RVA: 0x001A961C File Offset: 0x001A781C
			// (set) Token: 0x06005034 RID: 20532 RVA: 0x0001BBEE File Offset: 0x00019DEE
			public unsafe static Func<SerializedEntity, WormMatch, Entity, Entity> __9__9_15
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormArchetype.__c.NativeFieldInfoPtr___9__9_15, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SerializedEntity, WormMatch, Entity, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormArchetype.__c.NativeFieldInfoPtr___9__9_15, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400348F RID: 13455
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003490 RID: 13456
			private static readonly IntPtr NativeFieldInfoPtr___9__9_1;

			// Token: 0x04003491 RID: 13457
			private static readonly IntPtr NativeFieldInfoPtr___9__9_3;

			// Token: 0x04003492 RID: 13458
			private static readonly IntPtr NativeFieldInfoPtr___9__9_5;

			// Token: 0x04003493 RID: 13459
			private static readonly IntPtr NativeFieldInfoPtr___9__9_7;

			// Token: 0x04003494 RID: 13460
			private static readonly IntPtr NativeFieldInfoPtr___9__9_9;

			// Token: 0x04003495 RID: 13461
			private static readonly IntPtr NativeFieldInfoPtr___9__9_11;

			// Token: 0x04003496 RID: 13462
			private static readonly IntPtr NativeFieldInfoPtr___9__9_13;

			// Token: 0x04003497 RID: 13463
			private static readonly IntPtr NativeFieldInfoPtr___9__9_15;

			// Token: 0x04003498 RID: 13464
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003499 RID: 13465
			private static readonly IntPtr NativeMethodInfoPtr__Make_b__9_1_Internal_Entity_SerializedEntity_WormMatch_Entity_0;

			// Token: 0x0400349A RID: 13466
			private static readonly IntPtr NativeMethodInfoPtr__Make_b__9_3_Internal_Entity_SerializedEntity_WormMatch_Entity_0;

			// Token: 0x0400349B RID: 13467
			private static readonly IntPtr NativeMethodInfoPtr__Make_b__9_5_Internal_Entity_SerializedEntity_WormMatch_Entity_0;

			// Token: 0x0400349C RID: 13468
			private static readonly IntPtr NativeMethodInfoPtr__Make_b__9_7_Internal_Entity_SerializedEntity_WormMatch_Entity_0;

			// Token: 0x0400349D RID: 13469
			private static readonly IntPtr NativeMethodInfoPtr__Make_b__9_9_Internal_Entity_SerializedEntity_WormMatch_Entity_0;

			// Token: 0x0400349E RID: 13470
			private static readonly IntPtr NativeMethodInfoPtr__Make_b__9_11_Internal_Entity_SerializedEntity_WormMatch_Entity_0;

			// Token: 0x0400349F RID: 13471
			private static readonly IntPtr NativeMethodInfoPtr__Make_b__9_13_Internal_Entity_SerializedEntity_WormMatch_Entity_0;

			// Token: 0x040034A0 RID: 13472
			private static readonly IntPtr NativeMethodInfoPtr__Make_b__9_15_Internal_Entity_SerializedEntity_WormMatch_Entity_0;
		}
	}
}
