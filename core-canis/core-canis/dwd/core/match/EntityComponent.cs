using System;
using Canis.attributes;
using Canis.utils.ids;
using Canis.utils.localization;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace dwd.core.match
{
	// Token: 0x0200012F RID: 303
	public class EntityComponent : AttributeDataComponent
	{
		// Token: 0x06001127 RID: 4391 RVA: 0x00057DB4 File Offset: 0x00055FB4
		// Note: this type is marked as 'beforefieldinit'.
		static EntityComponent()
		{
			Il2CppClassPointerStore<EntityComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match", "EntityComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr);
			EntityComponent.NativeFieldInfoPtr__EntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, "_EntityID");
			EntityComponent.NativeFieldInfoPtr__OwningPlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, "_OwningPlayerID");
			EntityComponent.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, "attributes");
			EntityComponent.NativeFieldInfoPtr_materializeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, "materializeCount");
			EntityComponent.NativeFieldInfoPtr__EntityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, "_EntityName");
			EntityComponent.NativeFieldInfoPtr__Introduced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, "_Introduced");
			EntityComponent.NativeFieldInfoPtr__Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, "_Parent");
			EntityComponent.NativeFieldInfoPtr_children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, "children");
			EntityComponent.NativeFieldInfoPtr_Children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, "Children");
			EntityComponent.NativeFieldInfoPtr__Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, "_Version");
			EntityComponent.NativeMethodInfoPtr_get_EntityID_Public_Virtual_Final_New_get_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665799);
			EntityComponent.NativeMethodInfoPtr_get_OwningPlayerID_Public_Virtual_Final_New_get_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665800);
			EntityComponent.NativeMethodInfoPtr_get_EntityName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665801);
			EntityComponent.NativeMethodInfoPtr_set_EntityName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665802);
			EntityComponent.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665803);
			EntityComponent.NativeMethodInfoPtr_get_Introduced_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665804);
			EntityComponent.NativeMethodInfoPtr_set_Introduced_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665805);
			EntityComponent.NativeMethodInfoPtr_get_Parent_Public_get_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665806);
			EntityComponent.NativeMethodInfoPtr_set_Parent_Private_set_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665807);
			EntityComponent.NativeMethodInfoPtr_Canis_attributes_IEntity_get_Children_Private_Virtual_Final_New_get_IEnumerable_1_IEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665808);
			EntityComponent.NativeMethodInfoPtr_Canis_attributes_IEntity_get_Parent_Private_Virtual_Final_New_get_IEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665809);
			EntityComponent.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665810);
			EntityComponent.NativeMethodInfoPtr__ctor_Public_Void_EntityID_AccountID_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665811);
			EntityComponent.NativeMethodInfoPtr__ctor_Private_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665812);
			EntityComponent.NativeMethodInfoPtr__ctor_Private_Void_EntityID_AccountID_MutableAttributes_VersionedList_1_EntityComponent_ReadOnlyVersionedList_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665813);
			EntityComponent.NativeMethodInfoPtr_SortChildren_Public_Void_Comparison_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665814);
			EntityComponent.NativeMethodInfoPtr_AddChild_Public_Void_EntityComponent_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665815);
			EntityComponent.NativeMethodInfoPtr_RemoveChild_Public_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665816);
			EntityComponent.NativeMethodInfoPtr_RemoveAllChildren_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665817);
			EntityComponent.NativeMethodInfoPtr_Introduce_Public_Void_String_IEnumerable_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665818);
			EntityComponent.NativeMethodInfoPtr_ResetAttributes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665819);
			EntityComponent.NativeMethodInfoPtr_ModifyAttribute_Public_Void_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665820);
			EntityComponent.NativeMethodInfoPtr_RemoveAttribute_Public_Void_IAttributeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665821);
			EntityComponent.NativeMethodInfoPtr_RemoveAttribute_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665822);
			EntityComponent.NativeMethodInfoPtr_UpdateOwningPlayer_Public_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665823);
			EntityComponent.NativeMethodInfoPtr_IsDirectParentOf_Public_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665824);
			EntityComponent.NativeMethodInfoPtr_IsDirectChildOf_Public_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665825);
			EntityComponent.NativeMethodInfoPtr_HasAncestor_Public_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665826);
			EntityComponent.NativeMethodInfoPtr_HasDescendant_Public_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665827);
			EntityComponent.NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlyAttributes_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665828);
			EntityComponent.NativeMethodInfoPtr_op_Implicit_Public_Static_DataComposition_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665829);
			EntityComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665830);
			EntityComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Nullable_1_Int32_AttributeDefinition_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665831);
			EntityComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Nullable_1_Single_AttributeDefinition_1_Nullable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665832);
			EntityComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_String_AttributeDefinition_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665833);
			EntityComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Il2CppStringArray_AttributeDefinition_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665834);
			EntityComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_LocalizableText_AttributeDefinition_1_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665835);
			EntityComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Nullable_1_Boolean_AttributeDefinition_1_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665836);
			EntityComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_V_AttributeDefinition_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665837);
			EntityComponent.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665838);
			EntityComponent.NativeMethodInfoPtr_GetPath_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665839);
			EntityComponent.NativeMethodInfoPtr_Clone_Public_Virtual_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, 100665840);
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06001128 RID: 4392 RVA: 0x000581F4 File Offset: 0x000563F4
		public unsafe virtual EntityID EntityID
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_get_EntityID_Public_Virtual_Final_New_get_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x00058234 File Offset: 0x00056434
		public unsafe virtual AccountID OwningPlayerID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_get_OwningPlayerID_Public_Virtual_Final_New_get_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x0600112A RID: 4394 RVA: 0x00058274 File Offset: 0x00056474
		// (set) Token: 0x0600112B RID: 4395 RVA: 0x000582AC File Offset: 0x000564AC
		public unsafe virtual string EntityName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_get_EntityName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870765, XrefRangeEnd = 870767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_set_EntityName_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x0600112C RID: 4396 RVA: 0x000582F0 File Offset: 0x000564F0
		public unsafe string Name
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x0600112D RID: 4397 RVA: 0x00058328 File Offset: 0x00056528
		// (set) Token: 0x0600112E RID: 4398 RVA: 0x00058364 File Offset: 0x00056564
		public unsafe bool Introduced
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_get_Introduced_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_set_Introduced_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x0600112F RID: 4399 RVA: 0x000583A4 File Offset: 0x000565A4
		// (set) Token: 0x06001130 RID: 4400 RVA: 0x000583E4 File Offset: 0x000565E4
		public unsafe EntityComponent Parent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_get_Parent_Public_get_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870767, XrefRangeEnd = 870768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_set_Parent_Private_set_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x00058428 File Offset: 0x00056628
		public unsafe virtual IEnumerable<IEntity> Canis.attributes.IEntity.Children
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_Canis_attributes_IEntity_get_Children_Private_Virtual_Final_New_get_IEnumerable_1_IEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x00058468 File Offset: 0x00056668
		public unsafe virtual IEntity Canis.attributes.IEntity.Parent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_Canis_attributes_IEntity_get_Parent_Private_Virtual_Final_New_get_IEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEntity>(intPtr3) : null;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001133 RID: 4403 RVA: 0x000584A8 File Offset: 0x000566A8
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityComponent.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x000584F0 File Offset: 0x000566F0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 870784, RefRangeEnd = 870792, XrefRangeStart = 870768, XrefRangeEnd = 870784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityComponent(EntityID id, AccountID owningPlayerID, MutableAttributes attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owningPlayerID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr__ctor_Public_Void_EntityID_AccountID_MutableAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x00058560 File Offset: 0x00056760
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 870832, RefRangeEnd = 870833, XrefRangeStart = 870792, XrefRangeEnd = 870832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityComponent(EntityComponent other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr__ctor_Private_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x000585AC File Offset: 0x000567AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870833, XrefRangeEnd = 870843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityComponent(EntityID id, AccountID owningPlayerID, MutableAttributes attributes, VersionedList<EntityComponent> children, ReadOnlyVersionedList<EntityComponent> readonlyChildren = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owningPlayerID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(children);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(readonlyChildren);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr__ctor_Private_Void_EntityID_AccountID_MutableAttributes_VersionedList_1_EntityComponent_ReadOnlyVersionedList_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x00058644 File Offset: 0x00056844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870843, XrefRangeEnd = 870847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortChildren(Comparison<EntityComponent> comparison)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparison);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_SortChildren_Public_Void_Comparison_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x00058688 File Offset: 0x00056888
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 870872, RefRangeEnd = 870877, XrefRangeStart = 870847, XrefRangeEnd = 870872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChild(EntityComponent childEntity, Nullable<int> positionInParent = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(childEntity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(positionInParent));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_AddChild_Public_Void_EntityComponent_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x000586E4 File Offset: 0x000568E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870877, XrefRangeEnd = 870878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveChild(EntityComponent childEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(childEntity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_RemoveChild_Public_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x00058728 File Offset: 0x00056928
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 870893, RefRangeEnd = 870894, XrefRangeStart = 870878, XrefRangeEnd = 870893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAllChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_RemoveAllChildren_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x0005875C File Offset: 0x0005695C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 870897, RefRangeEnd = 870899, XrefRangeStart = 870894, XrefRangeEnd = 870897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Introduce(string entityName, IEnumerable<IAttribute> entityAttributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(entityName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entityAttributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_Introduce_Public_Void_String_IEnumerable_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x000587B0 File Offset: 0x000569B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 870900, RefRangeEnd = 870902, XrefRangeStart = 870899, XrefRangeEnd = 870900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_ResetAttributes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x000587E4 File Offset: 0x000569E4
		[CallerCount(0)]
		public unsafe void ModifyAttribute(IAttribute attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_ModifyAttribute_Public_Void_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x00058828 File Offset: 0x00056A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870902, XrefRangeEnd = 870904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAttribute(IAttributeDefinition attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_RemoveAttribute_Public_Void_IAttributeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x0005886C File Offset: 0x00056A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870904, XrefRangeEnd = 870906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAttribute(int attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref attribute;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_RemoveAttribute_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x000588AC File Offset: 0x00056AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateOwningPlayer(AccountID newOwningPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newOwningPlayer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_UpdateOwningPlayer_Public_Void_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x000588F0 File Offset: 0x00056AF0
		[CallerCount(0)]
		public unsafe bool IsDirectParentOf(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_IsDirectParentOf_Public_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x00058940 File Offset: 0x00056B40
		[CallerCount(0)]
		public unsafe bool IsDirectChildOf(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_IsDirectChildOf_Public_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x00058990 File Offset: 0x00056B90
		[CallerCount(0)]
		public unsafe bool HasAncestor(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_HasAncestor_Public_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x000589E0 File Offset: 0x00056BE0
		[CallerCount(0)]
		public unsafe bool HasDescendant(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_HasDescendant_Public_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x00058A30 File Offset: 0x00056C30
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 870907, RefRangeEnd = 870911, XrefRangeStart = 870906, XrefRangeEnd = 870907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ReadOnlyAttributes(EntityComponent entity)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlyAttributes_EntityComponent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x00058A74 File Offset: 0x00056C74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 870911, RefRangeEnd = 870914, XrefRangeStart = 870911, XrefRangeEnd = 870911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator DataComposition(EntityComponent entity)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_op_Implicit_Public_Static_DataComposition_EntityComponent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x00058AB8 File Offset: 0x00056CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870914, XrefRangeEnd = 870920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyAttribute GetAttribute(int key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x00058B10 File Offset: 0x00056D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870920, XrefRangeEnd = 870925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyAttribute<Nullable<int>> GetAttribute(AttributeDefinition<Nullable<int>> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Nullable_1_Int32_AttributeDefinition_1_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<Nullable<int>>>(intPtr3) : null;
			}
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x00058B6C File Offset: 0x00056D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870925, XrefRangeEnd = 870930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyAttribute<Nullable<float>> GetAttribute(AttributeDefinition<Nullable<float>> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Nullable_1_Single_AttributeDefinition_1_Nullable_1_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<Nullable<float>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x00058BC8 File Offset: 0x00056DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870930, XrefRangeEnd = 870935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyAttribute<string> GetAttribute(AttributeDefinition<string> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_String_AttributeDefinition_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<string>>(intPtr3) : null;
			}
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x00058C24 File Offset: 0x00056E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870935, XrefRangeEnd = 870940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyAttribute<Il2CppStringArray> GetAttribute(AttributeDefinition<Il2CppStringArray> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Il2CppStringArray_AttributeDefinition_1_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<Il2CppStringArray>>(intPtr3) : null;
			}
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x00058C80 File Offset: 0x00056E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870940, XrefRangeEnd = 870945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyAttribute<LocalizableText> GetAttribute(AttributeDefinition<LocalizableText> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_LocalizableText_AttributeDefinition_1_LocalizableText_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<LocalizableText>>(intPtr3) : null;
			}
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x00058CDC File Offset: 0x00056EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870945, XrefRangeEnd = 870950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyAttribute<Nullable<bool>> GetAttribute(AttributeDefinition<Nullable<bool>> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Nullable_1_Boolean_AttributeDefinition_1_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<Nullable<bool>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x00058D38 File Offset: 0x00056F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870950, XrefRangeEnd = 870958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyAttribute<V> GetAttribute<V>(AttributeDefinition<V> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityComponent.MethodInfoStoreGeneric_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_V_AttributeDefinition_1_V_0<V>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<V>>(intPtr3) : null;
			}
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x00058D94 File Offset: 0x00056F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870958, XrefRangeEnd = 870960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator<IAttribute> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityComponent.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_1_IAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAttribute>>(intPtr3) : null;
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x00058DE0 File Offset: 0x00056FE0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 870965, RefRangeEnd = 870971, XrefRangeStart = 870960, XrefRangeEnd = 870965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.NativeMethodInfoPtr_GetPath_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x00058E18 File Offset: 0x00057018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870971, XrefRangeEnd = 870975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DataComponent Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityComponent.NativeMethodInfoPtr_Clone_Public_Virtual_DataComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComponent>(intPtr3) : null;
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x00007F7A File Offset: 0x0000617A
		public EntityComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06001153 RID: 4435 RVA: 0x00058E64 File Offset: 0x00057064
		// (set) Token: 0x06001154 RID: 4436 RVA: 0x00007F83 File Offset: 0x00006183
		public unsafe EntityID _EntityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponent.NativeFieldInfoPtr__EntityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponent.NativeFieldInfoPtr__EntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06001155 RID: 4437 RVA: 0x00058E94 File Offset: 0x00057094
		// (set) Token: 0x06001156 RID: 4438 RVA: 0x00007FA2 File Offset: 0x000061A2
		public unsafe AccountID _OwningPlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponent.NativeFieldInfoPtr__OwningPlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponent.NativeFieldInfoPtr__OwningPlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x00058EC4 File Offset: 0x000570C4
		// (set) Token: 0x06001158 RID: 4440 RVA: 0x00007FC1 File Offset: 0x000061C1
		public unsafe MutableAttributes attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponent.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponent.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06001159 RID: 4441 RVA: 0x00058EF4 File Offset: 0x000570F4
		// (set) Token: 0x0600115A RID: 4442 RVA: 0x00007FE0 File Offset: 0x000061E0
		public unsafe int materializeCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponent.NativeFieldInfoPtr_materializeCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponent.NativeFieldInfoPtr_materializeCount)) = value;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x0600115B RID: 4443 RVA: 0x00058F1C File Offset: 0x0005711C
		// (set) Token: 0x0600115C RID: 4444 RVA: 0x00007FFB File Offset: 0x000061FB
		public unsafe string _EntityName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponent.NativeFieldInfoPtr__EntityName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponent.NativeFieldInfoPtr__EntityName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x0600115D RID: 4445 RVA: 0x00058F44 File Offset: 0x00057144
		// (set) Token: 0x0600115E RID: 4446 RVA: 0x0000801A File Offset: 0x0000621A
		public unsafe bool _Introduced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponent.NativeFieldInfoPtr__Introduced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponent.NativeFieldInfoPtr__Introduced)) = value;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x0600115F RID: 4447 RVA: 0x00058F6C File Offset: 0x0005716C
		// (set) Token: 0x06001160 RID: 4448 RVA: 0x00008035 File Offset: 0x00006235
		public unsafe EntityComponent _Parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponent.NativeFieldInfoPtr__Parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponent.NativeFieldInfoPtr__Parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06001161 RID: 4449 RVA: 0x00058F9C File Offset: 0x0005719C
		// (set) Token: 0x06001162 RID: 4450 RVA: 0x00008054 File Offset: 0x00006254
		public unsafe VersionedList<EntityComponent> children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponent.NativeFieldInfoPtr_children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedList<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponent.NativeFieldInfoPtr_children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06001163 RID: 4451 RVA: 0x00058FCC File Offset: 0x000571CC
		// (set) Token: 0x06001164 RID: 4452 RVA: 0x00008073 File Offset: 0x00006273
		public unsafe ReadOnlyVersionedList<EntityComponent> Children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponent.NativeFieldInfoPtr_Children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyVersionedList<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponent.NativeFieldInfoPtr_Children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06001165 RID: 4453 RVA: 0x00058FFC File Offset: 0x000571FC
		// (set) Token: 0x06001166 RID: 4454 RVA: 0x00008092 File Offset: 0x00006292
		public unsafe ulong _Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponent.NativeFieldInfoPtr__Version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityComponent.NativeFieldInfoPtr__Version)) = value;
			}
		}

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeFieldInfoPtr__EntityID;

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeFieldInfoPtr__OwningPlayerID;

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04000C32 RID: 3122
		private static readonly IntPtr NativeFieldInfoPtr_materializeCount;

		// Token: 0x04000C33 RID: 3123
		private static readonly IntPtr NativeFieldInfoPtr__EntityName;

		// Token: 0x04000C34 RID: 3124
		private static readonly IntPtr NativeFieldInfoPtr__Introduced;

		// Token: 0x04000C35 RID: 3125
		private static readonly IntPtr NativeFieldInfoPtr__Parent;

		// Token: 0x04000C36 RID: 3126
		private static readonly IntPtr NativeFieldInfoPtr_children;

		// Token: 0x04000C37 RID: 3127
		private static readonly IntPtr NativeFieldInfoPtr_Children;

		// Token: 0x04000C38 RID: 3128
		private static readonly IntPtr NativeFieldInfoPtr__Version;

		// Token: 0x04000C39 RID: 3129
		private static readonly IntPtr NativeMethodInfoPtr_get_EntityID_Public_Virtual_Final_New_get_EntityID_0;

		// Token: 0x04000C3A RID: 3130
		private static readonly IntPtr NativeMethodInfoPtr_get_OwningPlayerID_Public_Virtual_Final_New_get_AccountID_0;

		// Token: 0x04000C3B RID: 3131
		private static readonly IntPtr NativeMethodInfoPtr_get_EntityName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000C3C RID: 3132
		private static readonly IntPtr NativeMethodInfoPtr_set_EntityName_Private_set_Void_String_0;

		// Token: 0x04000C3D RID: 3133
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000C3E RID: 3134
		private static readonly IntPtr NativeMethodInfoPtr_get_Introduced_Public_get_Boolean_0;

		// Token: 0x04000C3F RID: 3135
		private static readonly IntPtr NativeMethodInfoPtr_set_Introduced_Private_set_Void_Boolean_0;

		// Token: 0x04000C40 RID: 3136
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_get_EntityComponent_0;

		// Token: 0x04000C41 RID: 3137
		private static readonly IntPtr NativeMethodInfoPtr_set_Parent_Private_set_Void_EntityComponent_0;

		// Token: 0x04000C42 RID: 3138
		private static readonly IntPtr NativeMethodInfoPtr_Canis_attributes_IEntity_get_Children_Private_Virtual_Final_New_get_IEnumerable_1_IEntity_0;

		// Token: 0x04000C43 RID: 3139
		private static readonly IntPtr NativeMethodInfoPtr_Canis_attributes_IEntity_get_Parent_Private_Virtual_Final_New_get_IEntity_0;

		// Token: 0x04000C44 RID: 3140
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04000C45 RID: 3141
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityID_AccountID_MutableAttributes_0;

		// Token: 0x04000C46 RID: 3142
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_EntityComponent_0;

		// Token: 0x04000C47 RID: 3143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_EntityID_AccountID_MutableAttributes_VersionedList_1_EntityComponent_ReadOnlyVersionedList_1_EntityComponent_0;

		// Token: 0x04000C48 RID: 3144
		private static readonly IntPtr NativeMethodInfoPtr_SortChildren_Public_Void_Comparison_1_EntityComponent_0;

		// Token: 0x04000C49 RID: 3145
		private static readonly IntPtr NativeMethodInfoPtr_AddChild_Public_Void_EntityComponent_Nullable_1_Int32_0;

		// Token: 0x04000C4A RID: 3146
		private static readonly IntPtr NativeMethodInfoPtr_RemoveChild_Public_Void_EntityComponent_0;

		// Token: 0x04000C4B RID: 3147
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAllChildren_Public_Void_0;

		// Token: 0x04000C4C RID: 3148
		private static readonly IntPtr NativeMethodInfoPtr_Introduce_Public_Void_String_IEnumerable_1_IAttribute_0;

		// Token: 0x04000C4D RID: 3149
		private static readonly IntPtr NativeMethodInfoPtr_ResetAttributes_Public_Void_0;

		// Token: 0x04000C4E RID: 3150
		private static readonly IntPtr NativeMethodInfoPtr_ModifyAttribute_Public_Void_IAttribute_0;

		// Token: 0x04000C4F RID: 3151
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAttribute_Public_Void_IAttributeDefinition_0;

		// Token: 0x04000C50 RID: 3152
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAttribute_Public_Void_Int32_0;

		// Token: 0x04000C51 RID: 3153
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOwningPlayer_Public_Void_AccountID_0;

		// Token: 0x04000C52 RID: 3154
		private static readonly IntPtr NativeMethodInfoPtr_IsDirectParentOf_Public_Boolean_EntityComponent_0;

		// Token: 0x04000C53 RID: 3155
		private static readonly IntPtr NativeMethodInfoPtr_IsDirectChildOf_Public_Boolean_EntityComponent_0;

		// Token: 0x04000C54 RID: 3156
		private static readonly IntPtr NativeMethodInfoPtr_HasAncestor_Public_Boolean_EntityComponent_0;

		// Token: 0x04000C55 RID: 3157
		private static readonly IntPtr NativeMethodInfoPtr_HasDescendant_Public_Boolean_EntityComponent_0;

		// Token: 0x04000C56 RID: 3158
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlyAttributes_EntityComponent_0;

		// Token: 0x04000C57 RID: 3159
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_DataComposition_EntityComponent_0;

		// Token: 0x04000C58 RID: 3160
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_Int32_0;

		// Token: 0x04000C59 RID: 3161
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Nullable_1_Int32_AttributeDefinition_1_Nullable_1_Int32_0;

		// Token: 0x04000C5A RID: 3162
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Nullable_1_Single_AttributeDefinition_1_Nullable_1_Single_0;

		// Token: 0x04000C5B RID: 3163
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_String_AttributeDefinition_1_String_0;

		// Token: 0x04000C5C RID: 3164
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Il2CppStringArray_AttributeDefinition_1_Il2CppStringArray_0;

		// Token: 0x04000C5D RID: 3165
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_LocalizableText_AttributeDefinition_1_LocalizableText_0;

		// Token: 0x04000C5E RID: 3166
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Nullable_1_Boolean_AttributeDefinition_1_Nullable_1_Boolean_0;

		// Token: 0x04000C5F RID: 3167
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_V_AttributeDefinition_1_V_0;

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_1_IAttribute_0;

		// Token: 0x04000C61 RID: 3169
		private static readonly IntPtr NativeMethodInfoPtr_GetPath_Public_String_0;

		// Token: 0x04000C62 RID: 3170
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_DataComponent_0;

		// Token: 0x020002CF RID: 719
		[ObfuscatedName("dwd.core.match.EntityComponent+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600216E RID: 8558 RVA: 0x00095B58 File Offset: 0x00093D58
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EntityComponent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityComponent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityComponent.__c>.NativeClassPtr);
				EntityComponent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityComponent.__c>.NativeClassPtr, "<>9");
				EntityComponent.__c.NativeFieldInfoPtr___9__32_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityComponent.__c>.NativeClassPtr, "<>9__32_0");
				EntityComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent.__c>.NativeClassPtr, 100665842);
				EntityComponent.__c.NativeMethodInfoPtr___ctor_b__32_0_Internal_EntityComponent_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityComponent.__c>.NativeClassPtr, 100665843);
			}

			// Token: 0x0600216F RID: 8559 RVA: 0x00095BD4 File Offset: 0x00093DD4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityComponent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002170 RID: 8560 RVA: 0x00095C10 File Offset: 0x00093E10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870764, XrefRangeEnd = 870765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EntityComponent __ctor_b__32_0(EntityComponent child)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityComponent.__c.NativeMethodInfoPtr___ctor_b__32_0_Internal_EntityComponent_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
				}
			}

			// Token: 0x06002171 RID: 8561 RVA: 0x0000E53B File Offset: 0x0000C73B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000920 RID: 2336
			// (get) Token: 0x06002172 RID: 8562 RVA: 0x00095C60 File Offset: 0x00093E60
			// (set) Token: 0x06002173 RID: 8563 RVA: 0x0000E544 File Offset: 0x0000C744
			public unsafe static EntityComponent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EntityComponent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EntityComponent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000921 RID: 2337
			// (get) Token: 0x06002174 RID: 8564 RVA: 0x00095C88 File Offset: 0x00093E88
			// (set) Token: 0x06002175 RID: 8565 RVA: 0x0000E556 File Offset: 0x0000C756
			public unsafe static Func<EntityComponent, EntityComponent> __9__32_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EntityComponent.__c.NativeFieldInfoPtr___9__32_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, EntityComponent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EntityComponent.__c.NativeFieldInfoPtr___9__32_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001736 RID: 5942
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001737 RID: 5943
			private static readonly IntPtr NativeFieldInfoPtr___9__32_0;

			// Token: 0x04001738 RID: 5944
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001739 RID: 5945
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__32_0_Internal_EntityComponent_EntityComponent_0;
		}

		// Token: 0x020002D0 RID: 720
		private sealed class MethodInfoStoreGeneric_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_V_AttributeDefinition_1_V_0<V>
		{
			// Token: 0x0400173A RID: 5946
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EntityComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_V_AttributeDefinition_1_V_0, Il2CppClassPointerStore<EntityComponent>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr)) }))));
		}
	}
}
