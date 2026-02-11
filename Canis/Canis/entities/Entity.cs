using System;
using Canis.actions;
using canis.archetypes;
using Canis.attributes;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Utils;

namespace Canis.entities
{
	// Token: 0x020000D3 RID: 211
	public class Entity : ObjectAttributes
	{
		// Token: 0x060009B3 RID: 2483 RVA: 0x0004279C File Offset: 0x0004099C
		// Note: this type is marked as 'beforefieldinit'.
		static Entity()
		{
			Il2CppClassPointerStore<Entity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "Entity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity>.NativeClassPtr);
			Entity.NativeFieldInfoPtr_OwningPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "OwningPlayer");
			Entity.NativeFieldInfoPtr_entityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "entityName");
			Entity.NativeFieldInfoPtr_Match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "Match");
			Entity.NativeFieldInfoPtr__Parent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "<Parent>k__BackingField");
			Entity.NativeFieldInfoPtr_children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "children");
			Entity.NativeFieldInfoPtr_descendents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "descendents");
			Entity.NativeFieldInfoPtr_entityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "entityID");
			Entity.NativeMethodInfoPtr_GetArchetype_Public_Virtual_New_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665341);
			Entity.NativeMethodInfoPtr_get_Parent_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665342);
			Entity.NativeMethodInfoPtr_set_Parent_Private_set_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665343);
			Entity.NativeMethodInfoPtr_Canis_attributes_IEntity_get_Children_Private_Virtual_Final_New_get_IEnumerable_1_IEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665344);
			Entity.NativeMethodInfoPtr_Canis_attributes_IEntity_get_Parent_Private_Virtual_Final_New_get_IEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665345);
			Entity.NativeMethodInfoPtr_get_EntityName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665346);
			Entity.NativeMethodInfoPtr_get_EntityID_Public_Virtual_Final_New_get_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665347);
			Entity.NativeMethodInfoPtr_get_OwningPlayerID_Public_Virtual_Final_New_get_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665348);
			Entity.NativeMethodInfoPtr__ctor_Public_Void_Match_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665349);
			Entity.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665350);
			Entity.NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_Archetype_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665351);
			Entity.NativeMethodInfoPtr_ForceParent_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665352);
			Entity.NativeMethodInfoPtr_SetPlayer_Public_Void_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665353);
			Entity.NativeMethodInfoPtr_SetPlayerAndReturnChildren_Public_Void_PlayerEntity_List_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665354);
			Entity.NativeMethodInfoPtr_get_PositionInParent_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665355);
			Entity.NativeMethodInfoPtr_get_Children_Public_get_List_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665356);
			Entity.NativeMethodInfoPtr_get_Descendents_Public_get_List_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665357);
			Entity.NativeMethodInfoPtr_get_OrderedDescendents_Public_get_IEnumerable_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665358);
			Entity.NativeMethodInfoPtr_buildDescendents_Private_List_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665359);
			Entity.NativeMethodInfoPtr_AddDescendent_Protected_Virtual_New_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665360);
			Entity.NativeMethodInfoPtr_RemoveDescendent_Protected_Virtual_New_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665361);
			Entity.NativeMethodInfoPtr_MoveTo_Public_Virtual_New_Entity_Entity_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665362);
			Entity.NativeMethodInfoPtr_TreeDepth_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665363);
			Entity.NativeMethodInfoPtr_LowestCommonAncestor_Private_Entity_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665364);
			Entity.NativeMethodInfoPtr_AddChild_Private_Void_Entity_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665365);
			Entity.NativeMethodInfoPtr_RemoveChild_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665366);
			Entity.NativeMethodInfoPtr_Serialize_Public_Virtual_New_SerializedEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665367);
			Entity.NativeMethodInfoPtr_Shuffle_Public_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665368);
			Entity.NativeMethodInfoPtr_ShuffleNoAction_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665369);
			Entity.NativeMethodInfoPtr_ShuffleNoAction_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665370);
			Entity.NativeMethodInfoPtr_GetChild_Public_Entity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665371);
			Entity.NativeMethodInfoPtr_ChildAt_Public_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665372);
			Entity.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665373);
			Entity.NativeMethodInfoPtr_Is_Public_Virtual_New_Boolean_IEntityName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665374);
			Entity.NativeMethodInfoPtr_AncestorChain_Public_IEnumerable_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665375);
			Entity.NativeMethodInfoPtr_RawAncestorChain_Private_IEnumerable_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665376);
			Entity.NativeMethodInfoPtr_ToString_Public_Virtual_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100665377);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00042B3C File Offset: 0x00040D3C
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Archetype GetArchetype()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Entity.NativeMethodInfoPtr_GetArchetype_Public_Virtual_New_Archetype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr3) : null;
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x00042B88 File Offset: 0x00040D88
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x00042BC8 File Offset: 0x00040DC8
		public unsafe Entity Parent
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_Parent_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_set_Parent_Private_set_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x00042C0C File Offset: 0x00040E0C
		public unsafe virtual IEnumerable<IEntity> Canis.attributes.IEntity.Children
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_Canis_attributes_IEntity_get_Children_Private_Virtual_Final_New_get_IEnumerable_1_IEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060009B8 RID: 2488 RVA: 0x00042C4C File Offset: 0x00040E4C
		public unsafe virtual IEntity Canis.attributes.IEntity.Parent
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_Canis_attributes_IEntity_get_Parent_Private_Virtual_Final_New_get_IEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEntity>(intPtr3) : null;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x00042C8C File Offset: 0x00040E8C
		public unsafe virtual string EntityName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_EntityName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x00042CC4 File Offset: 0x00040EC4
		public unsafe virtual EntityID EntityID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_EntityID_Public_Virtual_Final_New_get_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x00042D04 File Offset: 0x00040F04
		public unsafe virtual AccountID OwningPlayerID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_OwningPlayerID_Public_Virtual_Final_New_get_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
			}
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x00042D44 File Offset: 0x00040F44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 564664, RefRangeEnd = 564665, XrefRangeStart = 564663, XrefRangeEnd = 564664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entity(Match m, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr__ctor_Public_Void_Match_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00042DA4 File Offset: 0x00040FA4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 564754, RefRangeEnd = 564768, XrefRangeStart = 564665, XrefRangeEnd = 564754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entity(SerializedEntity se, Match match, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00042E14 File Offset: 0x00041014
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 564819, RefRangeEnd = 564871, XrefRangeStart = 564768, XrefRangeEnd = 564819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entity(Match m, PlayerEntity owningPlayer = null, Archetype archetype = null, string entityName = "")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owningPlayer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(archetype);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(entityName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_Archetype_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00042E98 File Offset: 0x00041098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceParent(Entity parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_ForceParent_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00042EDC File Offset: 0x000410DC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 564887, RefRangeEnd = 564893, XrefRangeStart = 564871, XrefRangeEnd = 564887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayer(PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_SetPlayer_Public_Void_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00042F20 File Offset: 0x00041120
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 564921, RefRangeEnd = 564923, XrefRangeStart = 564893, XrefRangeEnd = 564921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerAndReturnChildren(PlayerEntity player, List<Entity> allUpdated)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allUpdated);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_SetPlayerAndReturnChildren_Public_Void_PlayerEntity_List_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x00042F74 File Offset: 0x00041174
		public unsafe int PositionInParent
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 564926, RefRangeEnd = 564927, XrefRangeStart = 564923, XrefRangeEnd = 564926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_PositionInParent_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x00042FB0 File Offset: 0x000411B0
		public unsafe List<Entity> Children
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_Children_Public_get_List_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x00042FF0 File Offset: 0x000411F0
		public unsafe List<Entity> Descendents
		{
			[CallerCount(47)]
			[CachedScanResults(RefRangeStart = 564931, RefRangeEnd = 564978, XrefRangeStart = 564927, XrefRangeEnd = 564931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_Descendents_Public_get_List_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x00043030 File Offset: 0x00041230
		public unsafe IEnumerable<Entity> OrderedDescendents
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 564978, XrefRangeEnd = 565005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_OrderedDescendents_Public_get_IEnumerable_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00043070 File Offset: 0x00041270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565005, XrefRangeEnd = 565034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Entity> buildDescendents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_buildDescendents_Private_List_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr3) : null;
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x000430B0 File Offset: 0x000412B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565034, XrefRangeEnd = 565038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddDescendent(Entity descendent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(descendent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Entity.NativeMethodInfoPtr_AddDescendent_Protected_Virtual_New_Void_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00043100 File Offset: 0x00041300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565038, XrefRangeEnd = 565042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveDescendent(Entity descendent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(descendent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Entity.NativeMethodInfoPtr_RemoveDescendent_Protected_Virtual_New_Void_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00043150 File Offset: 0x00041350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565042, XrefRangeEnd = 565064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Entity MoveTo(Entity newParent, Nullable<int> positionInParent = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newParent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(positionInParent));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Entity.NativeMethodInfoPtr_MoveTo_Public_Virtual_New_Entity_Entity_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x000431C4 File Offset: 0x000413C4
		[CallerCount(0)]
		public unsafe int TreeDepth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_TreeDepth_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00043200 File Offset: 0x00041400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565064, XrefRangeEnd = 565068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entity LowestCommonAncestor(Entity oldParent, Entity newParent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldParent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newParent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_LowestCommonAncestor_Private_Entity_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00043264 File Offset: 0x00041464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565068, XrefRangeEnd = 565080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChild(Entity child, Nullable<int> position = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(position));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_AddChild_Private_Void_Entity_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x000432C0 File Offset: 0x000414C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565080, XrefRangeEnd = 565084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveChild(Entity child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_RemoveChild_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00043304 File Offset: 0x00041504
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 565137, RefRangeEnd = 565140, XrefRangeStart = 565084, XrefRangeEnd = 565137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SerializedEntity Serialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Entity.NativeMethodInfoPtr_Serialize_Public_Virtual_New_SerializedEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedEntity>(intPtr3) : null;
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00043350 File Offset: 0x00041550
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 565152, RefRangeEnd = 565165, XrefRangeStart = 565140, XrefRangeEnd = 565152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action Shuffle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_Shuffle_Public_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00043390 File Offset: 0x00041590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565165, XrefRangeEnd = 565172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShuffleNoAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_ShuffleNoAction_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x000433C4 File Offset: 0x000415C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565172, XrefRangeEnd = 565182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShuffleNoAction(int seed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref seed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_ShuffleNoAction_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00043404 File Offset: 0x00041604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565182, XrefRangeEnd = 565193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entity GetChild(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_GetChild_Public_Entity_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00043454 File Offset: 0x00041654
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 565197, RefRangeEnd = 565198, XrefRangeStart = 565193, XrefRangeEnd = 565197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entity ChildAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_ChildAt_Public_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x000434A0 File Offset: 0x000416A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565198, XrefRangeEnd = 565259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Entity.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x000434E4 File Offset: 0x000416E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565259, XrefRangeEnd = 565264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Is(IEntityName entityNameOb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityNameOb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Entity.NativeMethodInfoPtr_Is_Public_Virtual_New_Boolean_IEntityName_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0004353C File Offset: 0x0004173C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 565270, RefRangeEnd = 565273, XrefRangeStart = 565264, XrefRangeEnd = 565270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Entity> AncestorChain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_AncestorChain_Public_IEnumerable_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x0004357C File Offset: 0x0004177C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 565279, RefRangeEnd = 565281, XrefRangeStart = 565273, XrefRangeEnd = 565279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Entity> RawAncestorChain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_RawAncestorChain_Private_IEnumerable_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x000435BC File Offset: 0x000417BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565281, XrefRangeEnd = 565293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToString(string format, IFormatProvider formatProvider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Entity.NativeMethodInfoPtr_ToString_Public_Virtual_New_String_String_IFormatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x000059E0 File Offset: 0x00003BE0
		public Entity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x00043624 File Offset: 0x00041824
		// (set) Token: 0x060009DB RID: 2523 RVA: 0x000059E9 File Offset: 0x00003BE9
		public unsafe PlayerEntity OwningPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_OwningPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_OwningPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x00043654 File Offset: 0x00041854
		// (set) Token: 0x060009DD RID: 2525 RVA: 0x00005A08 File Offset: 0x00003C08
		public unsafe string entityName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_entityName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_entityName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x0004367C File Offset: 0x0004187C
		// (set) Token: 0x060009DF RID: 2527 RVA: 0x00005A27 File Offset: 0x00003C27
		public unsafe Match Match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_Match);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_Match), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x000436AC File Offset: 0x000418AC
		// (set) Token: 0x060009E1 RID: 2529 RVA: 0x00005A46 File Offset: 0x00003C46
		public unsafe Entity _Parent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr__Parent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr__Parent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x000436DC File Offset: 0x000418DC
		// (set) Token: 0x060009E3 RID: 2531 RVA: 0x00005A65 File Offset: 0x00003C65
		public unsafe List<Entity> children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x0004370C File Offset: 0x0004190C
		// (set) Token: 0x060009E5 RID: 2533 RVA: 0x00005A84 File Offset: 0x00003C84
		public unsafe Cached<List<Entity>> descendents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_descendents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cached<List<Entity>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_descendents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x0004373C File Offset: 0x0004193C
		// (set) Token: 0x060009E7 RID: 2535 RVA: 0x00005AA3 File Offset: 0x00003CA3
		public unsafe EntityID entityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_entityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_entityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeFieldInfoPtr_OwningPlayer;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeFieldInfoPtr_entityName;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeFieldInfoPtr_Match;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeFieldInfoPtr__Parent_k__BackingField;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeFieldInfoPtr_children;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeFieldInfoPtr_descendents;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeFieldInfoPtr_entityID;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeMethodInfoPtr_GetArchetype_Public_Virtual_New_Archetype_0;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_get_Entity_0;

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeMethodInfoPtr_set_Parent_Private_set_Void_Entity_0;

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeMethodInfoPtr_Canis_attributes_IEntity_get_Children_Private_Virtual_Final_New_get_IEnumerable_1_IEntity_0;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeMethodInfoPtr_Canis_attributes_IEntity_get_Parent_Private_Virtual_Final_New_get_IEntity_0;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeMethodInfoPtr_get_EntityName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeMethodInfoPtr_get_EntityID_Public_Virtual_Final_New_get_EntityID_0;

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeMethodInfoPtr_get_OwningPlayerID_Public_Virtual_Final_New_get_AccountID_0;

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_String_0;

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x040006AD RID: 1709
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_Archetype_String_0;

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeMethodInfoPtr_ForceParent_Public_Void_Entity_0;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayer_Public_Void_PlayerEntity_0;

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerAndReturnChildren_Public_Void_PlayerEntity_List_1_Entity_0;

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeMethodInfoPtr_get_PositionInParent_Public_get_Int32_0;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeMethodInfoPtr_get_Children_Public_get_List_1_Entity_0;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeMethodInfoPtr_get_Descendents_Public_get_List_1_Entity_0;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeMethodInfoPtr_get_OrderedDescendents_Public_get_IEnumerable_1_Entity_0;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeMethodInfoPtr_buildDescendents_Private_List_1_Entity_0;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeMethodInfoPtr_AddDescendent_Protected_Virtual_New_Void_Entity_0;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDescendent_Protected_Virtual_New_Void_Entity_0;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeMethodInfoPtr_MoveTo_Public_Virtual_New_Entity_Entity_Nullable_1_Int32_0;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeMethodInfoPtr_TreeDepth_Private_Int32_0;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeMethodInfoPtr_LowestCommonAncestor_Private_Entity_Entity_Entity_0;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeMethodInfoPtr_AddChild_Private_Void_Entity_Nullable_1_Int32_0;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeMethodInfoPtr_RemoveChild_Private_Void_Entity_0;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_New_SerializedEntity_0;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeMethodInfoPtr_Shuffle_Public_Action_0;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeMethodInfoPtr_ShuffleNoAction_Public_Void_0;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeMethodInfoPtr_ShuffleNoAction_Public_Void_Int32_0;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeMethodInfoPtr_GetChild_Public_Entity_String_0;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeMethodInfoPtr_ChildAt_Public_Entity_Int32_0;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeMethodInfoPtr_Is_Public_Virtual_New_Boolean_IEntityName_0;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeMethodInfoPtr_AncestorChain_Public_IEnumerable_1_Entity_0;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeMethodInfoPtr_RawAncestorChain_Private_IEnumerable_1_Entity_0;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_New_String_String_IFormatProvider_0;

		// Token: 0x02000316 RID: 790
		[ObfuscatedName("Canis.entities.Entity+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060020F3 RID: 8435 RVA: 0x000961EC File Offset: 0x000943EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Entity.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr);
				Entity.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, "<>9");
				Entity.__c.NativeFieldInfoPtr___9__34_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, "<>9__34_0");
				Entity.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, 100665379);
				Entity.__c.NativeMethodInfoPtr__get_OrderedDescendents_b__34_0_Internal_IEnumerable_1_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, 100665380);
			}

			// Token: 0x060020F4 RID: 8436 RVA: 0x00096268 File Offset: 0x00094468
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020F5 RID: 8437 RVA: 0x000962A4 File Offset: 0x000944A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 564562, XrefRangeEnd = 564590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Entity> _get_OrderedDescendents_b__34_0(Entity child)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.__c.NativeMethodInfoPtr__get_OrderedDescendents_b__34_0_Internal_IEnumerable_1_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x060020F6 RID: 8438 RVA: 0x0000FD00 File Offset: 0x0000DF00
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007E5 RID: 2021
			// (get) Token: 0x060020F7 RID: 8439 RVA: 0x000962F4 File Offset: 0x000944F4
			// (set) Token: 0x060020F8 RID: 8440 RVA: 0x0000FD09 File Offset: 0x0000DF09
			public unsafe static Entity.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Entity.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Entity.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007E6 RID: 2022
			// (get) Token: 0x060020F9 RID: 8441 RVA: 0x0009631C File Offset: 0x0009451C
			// (set) Token: 0x060020FA RID: 8442 RVA: 0x0000FD1B File Offset: 0x0000DF1B
			public unsafe static Func<Entity, IEnumerable<Entity>> __9__34_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Entity.__c.NativeFieldInfoPtr___9__34_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, IEnumerable<Entity>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Entity.__c.NativeFieldInfoPtr___9__34_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014C0 RID: 5312
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040014C1 RID: 5313
			private static readonly IntPtr NativeFieldInfoPtr___9__34_0;

			// Token: 0x040014C2 RID: 5314
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040014C3 RID: 5315
			private static readonly IntPtr NativeMethodInfoPtr__get_OrderedDescendents_b__34_0_Internal_IEnumerable_1_Entity_Entity_0;
		}

		// Token: 0x02000317 RID: 791
		[ObfuscatedName("Canis.entities.Entity+<AncestorChain>d__51")]
		public sealed class _AncestorChain_d__51 : Object
		{
			// Token: 0x060020FB RID: 8443 RVA: 0x00096344 File Offset: 0x00094544
			// Note: this type is marked as 'beforefieldinit'.
			static _AncestorChain_d__51()
			{
				Il2CppClassPointerStore<Entity._AncestorChain_d__51>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity>.NativeClassPtr, "<AncestorChain>d__51");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity._AncestorChain_d__51>.NativeClassPtr);
				Entity._AncestorChain_d__51.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._AncestorChain_d__51>.NativeClassPtr, "<>1__state");
				Entity._AncestorChain_d__51.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._AncestorChain_d__51>.NativeClassPtr, "<>2__current");
				Entity._AncestorChain_d__51.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._AncestorChain_d__51>.NativeClassPtr, "<>l__initialThreadId");
				Entity._AncestorChain_d__51.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._AncestorChain_d__51>.NativeClassPtr, "<>4__this");
				Entity._AncestorChain_d__51.NativeFieldInfoPtr__twiceChain_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._AncestorChain_d__51>.NativeClassPtr, "<twiceChain>5__2");
				Entity._AncestorChain_d__51.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._AncestorChain_d__51>.NativeClassPtr, "<>7__wrap2");
				Entity._AncestorChain_d__51.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._AncestorChain_d__51>.NativeClassPtr, 100665381);
				Entity._AncestorChain_d__51.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._AncestorChain_d__51>.NativeClassPtr, 100665382);
				Entity._AncestorChain_d__51.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._AncestorChain_d__51>.NativeClassPtr, 100665383);
				Entity._AncestorChain_d__51.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._AncestorChain_d__51>.NativeClassPtr, 100665384);
				Entity._AncestorChain_d__51.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_Entity__get_Current_Private_Virtual_Final_New_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._AncestorChain_d__51>.NativeClassPtr, 100665385);
				Entity._AncestorChain_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._AncestorChain_d__51>.NativeClassPtr, 100665386);
				Entity._AncestorChain_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._AncestorChain_d__51>.NativeClassPtr, 100665387);
				Entity._AncestorChain_d__51.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_Entity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._AncestorChain_d__51>.NativeClassPtr, 100665388);
				Entity._AncestorChain_d__51.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._AncestorChain_d__51>.NativeClassPtr, 100665389);
			}

			// Token: 0x060020FC RID: 8444 RVA: 0x0009649C File Offset: 0x0009469C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AncestorChain_d__51(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity._AncestorChain_d__51>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._AncestorChain_d__51.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020FD RID: 8445 RVA: 0x000964E4 File Offset: 0x000946E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 564590, XrefRangeEnd = 564595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._AncestorChain_d__51.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020FE RID: 8446 RVA: 0x00096518 File Offset: 0x00094718
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 564595, XrefRangeEnd = 564643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._AncestorChain_d__51.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060020FF RID: 8447 RVA: 0x00096554 File Offset: 0x00094754
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 564643, XrefRangeEnd = 564646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._AncestorChain_d__51.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007ED RID: 2029
			// (get) Token: 0x06002100 RID: 8448 RVA: 0x00096588 File Offset: 0x00094788
			public unsafe Entity System.Collections.Generic.IEnumerator<Canis.entities.Entity>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._AncestorChain_d__51.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_Entity__get_Current_Private_Virtual_Final_New_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06002101 RID: 8449 RVA: 0x000965C8 File Offset: 0x000947C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 564646, XrefRangeEnd = 564651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._AncestorChain_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007EE RID: 2030
			// (get) Token: 0x06002102 RID: 8450 RVA: 0x000965FC File Offset: 0x000947FC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._AncestorChain_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002103 RID: 8451 RVA: 0x0009663C File Offset: 0x0009483C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 564651, XrefRangeEnd = 564653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Entity> System_Collections_Generic_IEnumerable_Canis_entities_Entity__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._AncestorChain_d__51.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_Entity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Entity>>(intPtr3) : null;
			}

			// Token: 0x06002104 RID: 8452 RVA: 0x0009667C File Offset: 0x0009487C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._AncestorChain_d__51.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002105 RID: 8453 RVA: 0x0000FD2D File Offset: 0x0000DF2D
			public _AncestorChain_d__51(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007E7 RID: 2023
			// (get) Token: 0x06002106 RID: 8454 RVA: 0x000966BC File Offset: 0x000948BC
			// (set) Token: 0x06002107 RID: 8455 RVA: 0x0000FD36 File Offset: 0x0000DF36
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._AncestorChain_d__51.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._AncestorChain_d__51.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007E8 RID: 2024
			// (get) Token: 0x06002108 RID: 8456 RVA: 0x000966E4 File Offset: 0x000948E4
			// (set) Token: 0x06002109 RID: 8457 RVA: 0x0000FD51 File Offset: 0x0000DF51
			public unsafe Entity __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._AncestorChain_d__51.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._AncestorChain_d__51.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007E9 RID: 2025
			// (get) Token: 0x0600210A RID: 8458 RVA: 0x00096714 File Offset: 0x00094914
			// (set) Token: 0x0600210B RID: 8459 RVA: 0x0000FD70 File Offset: 0x0000DF70
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._AncestorChain_d__51.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._AncestorChain_d__51.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170007EA RID: 2026
			// (get) Token: 0x0600210C RID: 8460 RVA: 0x0009673C File Offset: 0x0009493C
			// (set) Token: 0x0600210D RID: 8461 RVA: 0x0000FD8B File Offset: 0x0000DF8B
			public unsafe Entity __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._AncestorChain_d__51.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._AncestorChain_d__51.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007EB RID: 2027
			// (get) Token: 0x0600210E RID: 8462 RVA: 0x0009676C File Offset: 0x0009496C
			// (set) Token: 0x0600210F RID: 8463 RVA: 0x0000FDAA File Offset: 0x0000DFAA
			public unsafe IEnumerator<Entity> _twiceChain_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._AncestorChain_d__51.NativeFieldInfoPtr__twiceChain_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._AncestorChain_d__51.NativeFieldInfoPtr__twiceChain_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007EC RID: 2028
			// (get) Token: 0x06002110 RID: 8464 RVA: 0x0009679C File Offset: 0x0009499C
			// (set) Token: 0x06002111 RID: 8465 RVA: 0x0000FDC9 File Offset: 0x0000DFC9
			public unsafe IEnumerator<Entity> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._AncestorChain_d__51.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._AncestorChain_d__51.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014C4 RID: 5316
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014C5 RID: 5317
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040014C6 RID: 5318
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040014C7 RID: 5319
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014C8 RID: 5320
			private static readonly IntPtr NativeFieldInfoPtr__twiceChain_5__2;

			// Token: 0x040014C9 RID: 5321
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040014CA RID: 5322
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040014CB RID: 5323
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014CC RID: 5324
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040014CD RID: 5325
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040014CE RID: 5326
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_Entity__get_Current_Private_Virtual_Final_New_get_Entity_0;

			// Token: 0x040014CF RID: 5327
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014D0 RID: 5328
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040014D1 RID: 5329
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_Entity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Entity_0;

			// Token: 0x040014D2 RID: 5330
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000318 RID: 792
		[ObfuscatedName("Canis.entities.Entity+<RawAncestorChain>d__52")]
		public sealed class _RawAncestorChain_d__52 : Object
		{
			// Token: 0x06002112 RID: 8466 RVA: 0x000967CC File Offset: 0x000949CC
			// Note: this type is marked as 'beforefieldinit'.
			static _RawAncestorChain_d__52()
			{
				Il2CppClassPointerStore<Entity._RawAncestorChain_d__52>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity>.NativeClassPtr, "<RawAncestorChain>d__52");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity._RawAncestorChain_d__52>.NativeClassPtr);
				Entity._RawAncestorChain_d__52.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._RawAncestorChain_d__52>.NativeClassPtr, "<>1__state");
				Entity._RawAncestorChain_d__52.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._RawAncestorChain_d__52>.NativeClassPtr, "<>2__current");
				Entity._RawAncestorChain_d__52.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._RawAncestorChain_d__52>.NativeClassPtr, "<>l__initialThreadId");
				Entity._RawAncestorChain_d__52.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._RawAncestorChain_d__52>.NativeClassPtr, "<>4__this");
				Entity._RawAncestorChain_d__52.NativeFieldInfoPtr__cur_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._RawAncestorChain_d__52>.NativeClassPtr, "<cur>5__2");
				Entity._RawAncestorChain_d__52.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._RawAncestorChain_d__52>.NativeClassPtr, 100665390);
				Entity._RawAncestorChain_d__52.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._RawAncestorChain_d__52>.NativeClassPtr, 100665391);
				Entity._RawAncestorChain_d__52.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._RawAncestorChain_d__52>.NativeClassPtr, 100665392);
				Entity._RawAncestorChain_d__52.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_Entity__get_Current_Private_Virtual_Final_New_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._RawAncestorChain_d__52>.NativeClassPtr, 100665393);
				Entity._RawAncestorChain_d__52.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._RawAncestorChain_d__52>.NativeClassPtr, 100665394);
				Entity._RawAncestorChain_d__52.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._RawAncestorChain_d__52>.NativeClassPtr, 100665395);
				Entity._RawAncestorChain_d__52.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_Entity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._RawAncestorChain_d__52>.NativeClassPtr, 100665396);
				Entity._RawAncestorChain_d__52.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._RawAncestorChain_d__52>.NativeClassPtr, 100665397);
			}

			// Token: 0x06002113 RID: 8467 RVA: 0x000968FC File Offset: 0x00094AFC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RawAncestorChain_d__52(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity._RawAncestorChain_d__52>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._RawAncestorChain_d__52.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002114 RID: 8468 RVA: 0x00096944 File Offset: 0x00094B44
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._RawAncestorChain_d__52.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002115 RID: 8469 RVA: 0x00096978 File Offset: 0x00094B78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 564653, XrefRangeEnd = 564656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._RawAncestorChain_d__52.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170007F4 RID: 2036
			// (get) Token: 0x06002116 RID: 8470 RVA: 0x000969B4 File Offset: 0x00094BB4
			public unsafe Entity System.Collections.Generic.IEnumerator<Canis.entities.Entity>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._RawAncestorChain_d__52.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_Entity__get_Current_Private_Virtual_Final_New_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x06002117 RID: 8471 RVA: 0x000969F4 File Offset: 0x00094BF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 564656, XrefRangeEnd = 564661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._RawAncestorChain_d__52.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007F5 RID: 2037
			// (get) Token: 0x06002118 RID: 8472 RVA: 0x00096A28 File Offset: 0x00094C28
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._RawAncestorChain_d__52.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002119 RID: 8473 RVA: 0x00096A68 File Offset: 0x00094C68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 564661, XrefRangeEnd = 564663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Entity> System_Collections_Generic_IEnumerable_Canis_entities_Entity__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._RawAncestorChain_d__52.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_Entity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Entity>>(intPtr3) : null;
			}

			// Token: 0x0600211A RID: 8474 RVA: 0x00096AA8 File Offset: 0x00094CA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._RawAncestorChain_d__52.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600211B RID: 8475 RVA: 0x0000FDE8 File Offset: 0x0000DFE8
			public _RawAncestorChain_d__52(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007EF RID: 2031
			// (get) Token: 0x0600211C RID: 8476 RVA: 0x00096AE8 File Offset: 0x00094CE8
			// (set) Token: 0x0600211D RID: 8477 RVA: 0x0000FDF1 File Offset: 0x0000DFF1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._RawAncestorChain_d__52.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._RawAncestorChain_d__52.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007F0 RID: 2032
			// (get) Token: 0x0600211E RID: 8478 RVA: 0x00096B10 File Offset: 0x00094D10
			// (set) Token: 0x0600211F RID: 8479 RVA: 0x0000FE0C File Offset: 0x0000E00C
			public unsafe Entity __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._RawAncestorChain_d__52.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._RawAncestorChain_d__52.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007F1 RID: 2033
			// (get) Token: 0x06002120 RID: 8480 RVA: 0x00096B40 File Offset: 0x00094D40
			// (set) Token: 0x06002121 RID: 8481 RVA: 0x0000FE2B File Offset: 0x0000E02B
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._RawAncestorChain_d__52.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._RawAncestorChain_d__52.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170007F2 RID: 2034
			// (get) Token: 0x06002122 RID: 8482 RVA: 0x00096B68 File Offset: 0x00094D68
			// (set) Token: 0x06002123 RID: 8483 RVA: 0x0000FE46 File Offset: 0x0000E046
			public unsafe Entity __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._RawAncestorChain_d__52.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._RawAncestorChain_d__52.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007F3 RID: 2035
			// (get) Token: 0x06002124 RID: 8484 RVA: 0x00096B98 File Offset: 0x00094D98
			// (set) Token: 0x06002125 RID: 8485 RVA: 0x0000FE65 File Offset: 0x0000E065
			public unsafe Entity _cur_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._RawAncestorChain_d__52.NativeFieldInfoPtr__cur_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._RawAncestorChain_d__52.NativeFieldInfoPtr__cur_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014D3 RID: 5331
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014D4 RID: 5332
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040014D5 RID: 5333
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040014D6 RID: 5334
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014D7 RID: 5335
			private static readonly IntPtr NativeFieldInfoPtr__cur_5__2;

			// Token: 0x040014D8 RID: 5336
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040014D9 RID: 5337
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014DA RID: 5338
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040014DB RID: 5339
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_Entity__get_Current_Private_Virtual_Final_New_get_Entity_0;

			// Token: 0x040014DC RID: 5340
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014DD RID: 5341
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040014DE RID: 5342
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_Entity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Entity_0;

			// Token: 0x040014DF RID: 5343
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
