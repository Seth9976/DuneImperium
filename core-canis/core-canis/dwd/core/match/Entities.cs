using System;
using Canis.attributes;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.match
{
	// Token: 0x0200012E RID: 302
	public class Entities : Object
	{
		// Token: 0x060010FD RID: 4349 RVA: 0x00056DE4 File Offset: 0x00054FE4
		// Note: this type is marked as 'beforefieldinit'.
		static Entities()
		{
			Il2CppClassPointerStore<Entities>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match", "Entities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entities>.NativeClassPtr);
			Entities.NativeFieldInfoPtr_all = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entities>.NativeClassPtr, "all");
			Entities.NativeFieldInfoPtr_All = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entities>.NativeClassPtr, "All");
			Entities.NativeFieldInfoPtr__Playmat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entities>.NativeClassPtr, "<Playmat>k__BackingField");
			Entities.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665765);
			Entities.NativeMethodInfoPtr_get_Item_Public_get_EntityComponent_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665766);
			Entities.NativeMethodInfoPtr_get_Playmat_Public_get_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665767);
			Entities.NativeMethodInfoPtr_set_Playmat_Private_set_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665768);
			Entities.NativeMethodInfoPtr_TryGetValue_Public_Boolean_EntityID_byref_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665769);
			Entities.NativeMethodInfoPtr_initialize_Protected_EntityComponent_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665770);
			Entities.NativeMethodInfoPtr_initialize_Protected_Void_SerializedEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665771);
			Entities.NativeMethodInfoPtr_initialize_Protected_EntityComponent_EntityID_AccountID_EntityID_Boolean_String_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665772);
			Entities.NativeMethodInfoPtr_Add_Public_EntityComponent_EntityID_AccountID_EntityID_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665773);
			Entities.NativeMethodInfoPtr_Remove_Public_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665774);
			Entities.NativeMethodInfoPtr_removeChildren_Private_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665775);
			Entities.NativeMethodInfoPtr_MapEntityID_Public_Void_EntityID_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665776);
			Entities.NativeMethodInfoPtr_Introduce_Public_EntityComponent_EntityID_String_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665777);
			Entities.NativeMethodInfoPtr_ModifyAttribute_Public_Void_EntityID_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665778);
			Entities.NativeMethodInfoPtr_RemoveAttribute_Public_Void_EntityID_IAttributeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665779);
			Entities.NativeMethodInfoPtr_RemoveAttribute_Public_Void_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665780);
			Entities.NativeMethodInfoPtr_ResetAttributes_Public_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665781);
			Entities.NativeMethodInfoPtr_ChangeEntityOwner_Public_Virtual_New_Void_EntityID_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665782);
			Entities.NativeMethodInfoPtr_createEntity_Protected_Abstract_Virtual_New_EntityComponent_EntityID_AccountID_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665783);
			Entities.NativeMethodInfoPtr_add_Protected_Abstract_Virtual_New_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665784);
			Entities.NativeMethodInfoPtr_remove_Protected_Virtual_New_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665785);
			Entities.NativeMethodInfoPtr_introduce_Protected_Abstract_Virtual_New_Void_EntityComponent_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665786);
			Entities.NativeMethodInfoPtr_GetPlayerByIndex_Public_Abstract_Virtual_New_EntityComponent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665787);
			Entities.NativeMethodInfoPtr_GetActiveLocalPlayer_Public_Abstract_Virtual_New_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665788);
			Entities.NativeMethodInfoPtr_GetPlayerIndexForAccountID_Public_Abstract_Virtual_New_Int32_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665789);
			Entities.NativeMethodInfoPtr_GetActiveLocalPlayerID_Public_Abstract_Virtual_New_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665790);
			Entities.NativeMethodInfoPtr_GetObservedPlayerID_Public_Abstract_Virtual_New_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665791);
			Entities.NativeMethodInfoPtr_GetPlayerPile_Public_Abstract_Virtual_New_EntityComponent_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665792);
			Entities.NativeMethodInfoPtr_GetPlaymatPile_Public_Abstract_Virtual_New_EntityComponent_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665793);
			Entities.NativeMethodInfoPtr_CreateTemporaryEntity_Public_Abstract_Virtual_New_EntityComponent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665794);
			Entities.NativeMethodInfoPtr_CreateTemporaryEntity_Public_Abstract_Virtual_New_EntityComponent_String_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665795);
			Entities.NativeMethodInfoPtr_CreateTemporaryEntity_Public_Abstract_Virtual_New_EntityComponent_String_ReadOnlyAttributes_AccountID_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665796);
			Entities.NativeMethodInfoPtr_GetPlaymatPileFromPath_Public_Virtual_New_EntityComponent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665797);
			Entities.NativeMethodInfoPtr_GetPlayerByAccount_Public_EntityComponent_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entities>.NativeClassPtr, 100665798);
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x000570F8 File Offset: 0x000552F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 870408, RefRangeEnd = 870409, XrefRangeStart = 870395, XrefRangeEnd = 870408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entities()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entities>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entities.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000483 RID: 1155
		public unsafe EntityComponent this[EntityID id]
		{
			[CallerCount(37)]
			[CachedScanResults(RefRangeStart = 870413, RefRangeEnd = 870450, XrefRangeStart = 870409, XrefRangeEnd = 870413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entities.NativeMethodInfoPtr_get_Item_Public_get_EntityComponent_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
				}
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x00057184 File Offset: 0x00055384
		// (set) Token: 0x06001101 RID: 4353 RVA: 0x000571C4 File Offset: 0x000553C4
		public unsafe EntityComponent Playmat
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entities.NativeMethodInfoPtr_get_Playmat_Public_get_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entities.NativeMethodInfoPtr_set_Playmat_Private_set_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x00057208 File Offset: 0x00055408
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 870458, RefRangeEnd = 870505, XrefRangeStart = 870450, XrefRangeEnd = 870458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValue(EntityID id, out EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Entities.NativeMethodInfoPtr_TryGetValue_Public_Boolean_EntityID_byref_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			entity = ((intPtr4 == 0) ? null : new EntityComponent(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x00057278 File Offset: 0x00055478
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 870526, RefRangeEnd = 870527, XrefRangeStart = 870505, XrefRangeEnd = 870526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityComponent initialize(EntityComponent serializedEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedEntity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entities.NativeMethodInfoPtr_initialize_Protected_EntityComponent_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
			}
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x000572C8 File Offset: 0x000554C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 870545, RefRangeEnd = 870546, XrefRangeStart = 870527, XrefRangeEnd = 870545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void initialize(SerializedEntity serializedEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedEntity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entities.NativeMethodInfoPtr_initialize_Protected_Void_SerializedEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x0005730C File Offset: 0x0005550C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870546, XrefRangeEnd = 870549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityComponent initialize(EntityID entityID, AccountID owningPlayerID, EntityID parentEntityID, bool introduced, string entityName, ReadOnlyAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owningPlayerID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentEntityID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref introduced;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(entityName);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entities.NativeMethodInfoPtr_initialize_Protected_EntityComponent_EntityID_AccountID_EntityID_Boolean_String_ReadOnlyAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x000573B4 File Offset: 0x000555B4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 870564, RefRangeEnd = 870572, XrefRangeStart = 870549, XrefRangeEnd = 870564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityComponent Add(EntityID entityID, AccountID owningPlayerID, EntityID parentEntityID, Nullable<int> positionInParent = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owningPlayerID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentEntityID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(positionInParent));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entities.NativeMethodInfoPtr_Add_Public_EntityComponent_EntityID_AccountID_EntityID_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x00057440 File Offset: 0x00055640
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 870583, RefRangeEnd = 870617, XrefRangeStart = 870572, XrefRangeEnd = 870583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entities.NativeMethodInfoPtr_Remove_Public_Void_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x00057484 File Offset: 0x00055684
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 870639, RefRangeEnd = 870642, XrefRangeStart = 870617, XrefRangeEnd = 870639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void removeChildren(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entities.NativeMethodInfoPtr_removeChildren_Private_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x000574C8 File Offset: 0x000556C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870642, XrefRangeEnd = 870673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MapEntityID(EntityID oldID, EntityID newID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entities.NativeMethodInfoPtr_MapEntityID_Public_Void_EntityID_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x0005751C File Offset: 0x0005571C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 870683, RefRangeEnd = 870691, XrefRangeStart = 870673, XrefRangeEnd = 870683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityComponent Introduce(EntityID entityID, string entityName, ReadOnlyAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(entityName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entities.NativeMethodInfoPtr_Introduce_Public_EntityComponent_EntityID_String_ReadOnlyAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x00057590 File Offset: 0x00055790
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 870699, RefRangeEnd = 870700, XrefRangeStart = 870691, XrefRangeEnd = 870699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ModifyAttribute(EntityID entityID, IAttribute attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attribute);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entities.NativeMethodInfoPtr_ModifyAttribute_Public_Void_EntityID_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x000575E4 File Offset: 0x000557E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870700, XrefRangeEnd = 870705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAttribute(EntityID entityID, IAttributeDefinition attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attribute);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entities.NativeMethodInfoPtr_RemoveAttribute_Public_Void_EntityID_IAttributeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x00057638 File Offset: 0x00055838
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 870737, RefRangeEnd = 870739, XrefRangeStart = 870705, XrefRangeEnd = 870737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAttribute(EntityID entityID, int attributeKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref attributeKey;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entities.NativeMethodInfoPtr_RemoveAttribute_Public_Void_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x00057688 File Offset: 0x00055888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870739, XrefRangeEnd = 870742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAttributes(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entities.NativeMethodInfoPtr_ResetAttributes_Public_Void_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x000576CC File Offset: 0x000558CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870742, XrefRangeEnd = 870746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ChangeEntityOwner(EntityID entityID, AccountID newAccountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newAccountID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Entities.NativeMethodInfoPtr_ChangeEntityOwner_Public_Virtual_New_Void_EntityID_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x0005772C File Offset: 0x0005592C
		[CallerCount(0)]
		public unsafe virtual EntityComponent createEntity(EntityID id, AccountID owningPlayerID, EntityComponent parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owningPlayerID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Entities.NativeMethodInfoPtr_createEntity_Protected_Abstract_Virtual_New_EntityComponent_EntityID_AccountID_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x000577AC File Offset: 0x000559AC
		[CallerCount(0)]
		public unsafe virtual void add(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Entities.NativeMethodInfoPtr_add_Protected_Abstract_Virtual_New_Void_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x000577FC File Offset: 0x000559FC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove(EntityID entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Entities.NativeMethodInfoPtr_remove_Protected_Virtual_New_Void_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x0005784C File Offset: 0x00055A4C
		[CallerCount(0)]
		public unsafe virtual void introduce(EntityComponent entity, ReadOnlyAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Entities.NativeMethodInfoPtr_introduce_Protected_Abstract_Virtual_New_Void_EntityComponent_ReadOnlyAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x000578AC File Offset: 0x00055AAC
		[CallerCount(0)]
		public unsafe virtual EntityComponent GetPlayerByIndex(int playerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Entities.NativeMethodInfoPtr_GetPlayerByIndex_Public_Abstract_Virtual_New_EntityComponent_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
			}
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x00057904 File Offset: 0x00055B04
		[CallerCount(0)]
		public unsafe virtual EntityComponent GetActiveLocalPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Entities.NativeMethodInfoPtr_GetActiveLocalPlayer_Public_Abstract_Virtual_New_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x00057950 File Offset: 0x00055B50
		[CallerCount(0)]
		public unsafe virtual int GetPlayerIndexForAccountID(AccountID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Entities.NativeMethodInfoPtr_GetPlayerIndexForAccountID_Public_Abstract_Virtual_New_Int32_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x000579A8 File Offset: 0x00055BA8
		[CallerCount(0)]
		public unsafe virtual AccountID GetActiveLocalPlayerID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Entities.NativeMethodInfoPtr_GetActiveLocalPlayerID_Public_Abstract_Virtual_New_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x000579F4 File Offset: 0x00055BF4
		[CallerCount(0)]
		public unsafe virtual AccountID GetObservedPlayerID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Entities.NativeMethodInfoPtr_GetObservedPlayerID_Public_Abstract_Virtual_New_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x00057A40 File Offset: 0x00055C40
		[CallerCount(0)]
		public unsafe virtual EntityComponent GetPlayerPile(int playerIndex, string pile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Entities.NativeMethodInfoPtr_GetPlayerPile_Public_Abstract_Virtual_New_EntityComponent_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x00057AAC File Offset: 0x00055CAC
		[CallerCount(0)]
		public unsafe virtual EntityComponent GetPlaymatPile(string pile, bool failSilently = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref failSilently;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Entities.NativeMethodInfoPtr_GetPlaymatPile_Public_Abstract_Virtual_New_EntityComponent_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x00057B18 File Offset: 0x00055D18
		[CallerCount(0)]
		public unsafe virtual EntityComponent CreateTemporaryEntity(string entityName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(entityName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Entities.NativeMethodInfoPtr_CreateTemporaryEntity_Public_Abstract_Virtual_New_EntityComponent_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
			}
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x00057B74 File Offset: 0x00055D74
		[CallerCount(0)]
		public unsafe virtual EntityComponent CreateTemporaryEntity(string entityName, EntityComponent other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(entityName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Entities.NativeMethodInfoPtr_CreateTemporaryEntity_Public_Abstract_Virtual_New_EntityComponent_String_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x00057BE4 File Offset: 0x00055DE4
		[CallerCount(0)]
		public unsafe virtual EntityComponent CreateTemporaryEntity(string entityName, ReadOnlyAttributes attributes, AccountID owner = null, EntityID parent = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(entityName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Entities.NativeMethodInfoPtr_CreateTemporaryEntity_Public_Abstract_Virtual_New_EntityComponent_String_ReadOnlyAttributes_AccountID_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x00057C78 File Offset: 0x00055E78
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 531765, RefRangeEnd = 531782, XrefRangeStart = 531765, XrefRangeEnd = 531782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual EntityComponent GetPlaymatPileFromPath(string pilePath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pilePath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Entities.NativeMethodInfoPtr_GetPlaymatPileFromPath_Public_Virtual_New_EntityComponent_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
			}
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x00057CD4 File Offset: 0x00055ED4
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 870746, RefRangeEnd = 870764, XrefRangeStart = 870746, XrefRangeEnd = 870746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityComponent GetPlayerByAccount(AccountID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entities.NativeMethodInfoPtr_GetPlayerByAccount_Public_EntityComponent_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
			}
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x00007F14 File Offset: 0x00006114
		public Entities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06001121 RID: 4385 RVA: 0x00057D24 File Offset: 0x00055F24
		// (set) Token: 0x06001122 RID: 4386 RVA: 0x00007F1D File Offset: 0x0000611D
		public unsafe VersionedMap<EntityID, EntityComponent> all
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entities.NativeFieldInfoPtr_all);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedMap<EntityID, EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entities.NativeFieldInfoPtr_all), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06001123 RID: 4387 RVA: 0x00057D54 File Offset: 0x00055F54
		// (set) Token: 0x06001124 RID: 4388 RVA: 0x00007F3C File Offset: 0x0000613C
		public unsafe ReadOnlyVersionedMap<EntityID, EntityComponent> All
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entities.NativeFieldInfoPtr_All);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyVersionedMap<EntityID, EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entities.NativeFieldInfoPtr_All), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x00057D84 File Offset: 0x00055F84
		// (set) Token: 0x06001126 RID: 4390 RVA: 0x00007F5B File Offset: 0x0000615B
		public unsafe EntityComponent _Playmat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entities.NativeFieldInfoPtr__Playmat_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entities.NativeFieldInfoPtr__Playmat_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C0A RID: 3082
		private static readonly IntPtr NativeFieldInfoPtr_all;

		// Token: 0x04000C0B RID: 3083
		private static readonly IntPtr NativeFieldInfoPtr_All;

		// Token: 0x04000C0C RID: 3084
		private static readonly IntPtr NativeFieldInfoPtr__Playmat_k__BackingField;

		// Token: 0x04000C0D RID: 3085
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000C0E RID: 3086
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_EntityComponent_EntityID_0;

		// Token: 0x04000C0F RID: 3087
		private static readonly IntPtr NativeMethodInfoPtr_get_Playmat_Public_get_EntityComponent_0;

		// Token: 0x04000C10 RID: 3088
		private static readonly IntPtr NativeMethodInfoPtr_set_Playmat_Private_set_Void_EntityComponent_0;

		// Token: 0x04000C11 RID: 3089
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Boolean_EntityID_byref_EntityComponent_0;

		// Token: 0x04000C12 RID: 3090
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_EntityComponent_EntityComponent_0;

		// Token: 0x04000C13 RID: 3091
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Void_SerializedEntity_0;

		// Token: 0x04000C14 RID: 3092
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_EntityComponent_EntityID_AccountID_EntityID_Boolean_String_ReadOnlyAttributes_0;

		// Token: 0x04000C15 RID: 3093
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_EntityComponent_EntityID_AccountID_EntityID_Nullable_1_Int32_0;

		// Token: 0x04000C16 RID: 3094
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_EntityID_0;

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeMethodInfoPtr_removeChildren_Private_Void_EntityComponent_0;

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeMethodInfoPtr_MapEntityID_Public_Void_EntityID_EntityID_0;

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeMethodInfoPtr_Introduce_Public_EntityComponent_EntityID_String_ReadOnlyAttributes_0;

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeMethodInfoPtr_ModifyAttribute_Public_Void_EntityID_IAttribute_0;

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAttribute_Public_Void_EntityID_IAttributeDefinition_0;

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAttribute_Public_Void_EntityID_Int32_0;

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeMethodInfoPtr_ResetAttributes_Public_Void_EntityID_0;

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeMethodInfoPtr_ChangeEntityOwner_Public_Virtual_New_Void_EntityID_AccountID_0;

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeMethodInfoPtr_createEntity_Protected_Abstract_Virtual_New_EntityComponent_EntityID_AccountID_EntityComponent_0;

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeMethodInfoPtr_add_Protected_Abstract_Virtual_New_Void_EntityComponent_0;

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeMethodInfoPtr_remove_Protected_Virtual_New_Void_EntityID_0;

		// Token: 0x04000C22 RID: 3106
		private static readonly IntPtr NativeMethodInfoPtr_introduce_Protected_Abstract_Virtual_New_Void_EntityComponent_ReadOnlyAttributes_0;

		// Token: 0x04000C23 RID: 3107
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerByIndex_Public_Abstract_Virtual_New_EntityComponent_Int32_0;

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveLocalPlayer_Public_Abstract_Virtual_New_EntityComponent_0;

		// Token: 0x04000C25 RID: 3109
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerIndexForAccountID_Public_Abstract_Virtual_New_Int32_AccountID_0;

		// Token: 0x04000C26 RID: 3110
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveLocalPlayerID_Public_Abstract_Virtual_New_AccountID_0;

		// Token: 0x04000C27 RID: 3111
		private static readonly IntPtr NativeMethodInfoPtr_GetObservedPlayerID_Public_Abstract_Virtual_New_AccountID_0;

		// Token: 0x04000C28 RID: 3112
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerPile_Public_Abstract_Virtual_New_EntityComponent_Int32_String_0;

		// Token: 0x04000C29 RID: 3113
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaymatPile_Public_Abstract_Virtual_New_EntityComponent_String_Boolean_0;

		// Token: 0x04000C2A RID: 3114
		private static readonly IntPtr NativeMethodInfoPtr_CreateTemporaryEntity_Public_Abstract_Virtual_New_EntityComponent_String_0;

		// Token: 0x04000C2B RID: 3115
		private static readonly IntPtr NativeMethodInfoPtr_CreateTemporaryEntity_Public_Abstract_Virtual_New_EntityComponent_String_EntityComponent_0;

		// Token: 0x04000C2C RID: 3116
		private static readonly IntPtr NativeMethodInfoPtr_CreateTemporaryEntity_Public_Abstract_Virtual_New_EntityComponent_String_ReadOnlyAttributes_AccountID_EntityID_0;

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaymatPileFromPath_Public_Virtual_New_EntityComponent_String_0;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerByAccount_Public_EntityComponent_AccountID_0;
	}
}
