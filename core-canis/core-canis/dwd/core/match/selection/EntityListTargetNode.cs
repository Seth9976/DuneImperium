using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Networking.selection;
using Networking.selection.targetinformation;
using Networking.selection.targetresponse;

namespace dwd.core.match.selection
{
	// Token: 0x02000152 RID: 338
	public class EntityListTargetNode : TargetInfoNode
	{
		// Token: 0x0600138B RID: 5003 RVA: 0x00062A2C File Offset: 0x00060C2C
		// Note: this type is marked as 'beforefieldinit'.
		static EntityListTargetNode()
		{
			Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "EntityListTargetNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr);
			EntityListTargetNode.NativeFieldInfoPtr_none = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr, "none");
			EntityListTargetNode.NativeFieldInfoPtr_availableSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr, "availableSelections");
			EntityListTargetNode.NativeFieldInfoPtr_previousSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr, "previousSelections");
			EntityListTargetNode.NativeFieldInfoPtr_targetInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr, "targetInfo");
			EntityListTargetNode.NativeFieldInfoPtr_cachedHints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr, "cachedHints");
			EntityListTargetNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_EntityListTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr, 100666252);
			EntityListTargetNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_EntityListTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr, 100666253);
			EntityListTargetNode.NativeMethodInfoPtr_get_satisfied_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr, 100666254);
			EntityListTargetNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr, 100666255);
			EntityListTargetNode.NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr, 100666256);
			EntityListTargetNode.NativeMethodInfoPtr_get_AvailableSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr, 100666257);
			EntityListTargetNode.NativeMethodInfoPtr_get_AllAvailableSelections_Public_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr, 100666258);
			EntityListTargetNode.NativeMethodInfoPtr_get_PreviousSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr, 100666259);
			EntityListTargetNode.NativeMethodInfoPtr_get_ForcedSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr, 100666260);
			EntityListTargetNode.NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr, 100666261);
			EntityListTargetNode.NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr, 100666262);
			EntityListTargetNode.NativeMethodInfoPtr_get_MaxToSelect_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr, 100666263);
			EntityListTargetNode.NativeMethodInfoPtr_get_MinToSelect_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr, 100666264);
			EntityListTargetNode.NativeMethodInfoPtr_HintStrength_Public_Virtual_Final_New_TargetStrength_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr, 100666265);
			EntityListTargetNode.NativeMethodInfoPtr_HintStrengths_Public_Virtual_Final_New_List_1_TargetStrength_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr, 100666266);
			EntityListTargetNode.NativeMethodInfoPtr_AllHintStrengths_Public_Virtual_Final_New_Dictionary_2_EntityID_List_1_TargetStrength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr, 100666267);
			EntityListTargetNode.NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr, 100666268);
			EntityListTargetNode.NativeMethodInfoPtr_getResponse_Protected_Virtual_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr, 100666269);
			EntityListTargetNode.NativeMethodInfoPtr_setAvailableSelections_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr, 100666270);
			EntityListTargetNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr, 100666271);
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x00062C50 File Offset: 0x00060E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873797, XrefRangeEnd = 873800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityListTargetNode(ISelectionNodeFactory factory, EntityListTargetInformation targetInfo, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> subsequent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subsequent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityListTargetNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_EntityListTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x00062CF4 File Offset: 0x00060EF4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 873822, RefRangeEnd = 873828, XrefRangeStart = 873800, XrefRangeEnd = 873822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityListTargetNode(ISelectionNodeFactory factory, EntityListTargetInformation targetInfo, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> subsequent, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityListTargetNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subsequent);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityListTargetNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_EntityListTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x0600138E RID: 5006 RVA: 0x00062DAC File Offset: 0x00060FAC
		public unsafe override bool satisfied
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873828, XrefRangeEnd = 873833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityListTargetNode.NativeMethodInfoPtr_get_satisfied_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x0600138F RID: 5007 RVA: 0x00062DF4 File Offset: 0x00060FF4
		public unsafe override bool HasClearableState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873833, XrefRangeEnd = 873836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityListTargetNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001390 RID: 5008 RVA: 0x00062E3C File Offset: 0x0006103C
		public unsafe virtual bool Forced
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityListTargetNode.NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001391 RID: 5009 RVA: 0x00062E78 File Offset: 0x00061078
		public unsafe virtual IList<EntityID> AvailableSelections
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 873843, RefRangeEnd = 873849, XrefRangeStart = 873836, XrefRangeEnd = 873843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityListTargetNode.NativeMethodInfoPtr_get_AvailableSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001392 RID: 5010 RVA: 0x00062EB8 File Offset: 0x000610B8
		public unsafe IList<EntityID> AllAvailableSelections
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityListTargetNode.NativeMethodInfoPtr_get_AllAvailableSelections_Public_get_IList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001393 RID: 5011 RVA: 0x00062EF8 File Offset: 0x000610F8
		public unsafe virtual IList<EntityID> PreviousSelections
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityListTargetNode.NativeMethodInfoPtr_get_PreviousSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001394 RID: 5012 RVA: 0x00062F38 File Offset: 0x00061138
		public unsafe virtual IList<EntityID> ForcedSelections
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873849, XrefRangeEnd = 873853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityListTargetNode.NativeMethodInfoPtr_get_ForcedSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x00062F78 File Offset: 0x00061178
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 873867, RefRangeEnd = 873869, XrefRangeStart = 873853, XrefRangeEnd = 873867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Select(EntityID entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityListTargetNode.NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x00062FBC File Offset: 0x000611BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873869, XrefRangeEnd = 873890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unselect(EntityID entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityListTargetNode.NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001397 RID: 5015 RVA: 0x00063000 File Offset: 0x00061200
		public unsafe virtual int MaxToSelect
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 873890, RefRangeEnd = 873892, XrefRangeStart = 873890, XrefRangeEnd = 873890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityListTargetNode.NativeMethodInfoPtr_get_MaxToSelect_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x0006303C File Offset: 0x0006123C
		public unsafe virtual int MinToSelect
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 873892, RefRangeEnd = 873893, XrefRangeStart = 873892, XrefRangeEnd = 873892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityListTargetNode.NativeMethodInfoPtr_get_MinToSelect_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x00063078 File Offset: 0x00061278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873893, XrefRangeEnd = 873908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TargetStrength HintStrength(EntityID entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityListTargetNode.NativeMethodInfoPtr_HintStrength_Public_Virtual_Final_New_TargetStrength_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x000630C8 File Offset: 0x000612C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873908, XrefRangeEnd = 873943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<TargetStrength> HintStrengths(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityListTargetNode.NativeMethodInfoPtr_HintStrengths_Public_Virtual_Final_New_List_1_TargetStrength_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TargetStrength>>(intPtr3) : null;
			}
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x00063118 File Offset: 0x00061318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873943, XrefRangeEnd = 873987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Dictionary<EntityID, List<TargetStrength>> AllHintStrengths()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityListTargetNode.NativeMethodInfoPtr_AllHintStrengths_Public_Virtual_Final_New_Dictionary_2_EntityID_List_1_TargetStrength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, List<TargetStrength>>>(intPtr3) : null;
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x00063158 File Offset: 0x00061358
		[CallerCount(0)]
		public unsafe virtual ISelectionNode PeekNode(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityListTargetNode.NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x000631A8 File Offset: 0x000613A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873987, XrefRangeEnd = 873991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TargetResponse getResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityListTargetNode.NativeMethodInfoPtr_getResponse_Protected_Virtual_TargetResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetResponse>(intPtr3) : null;
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x000631F4 File Offset: 0x000613F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 873996, RefRangeEnd = 873998, XrefRangeStart = 873991, XrefRangeEnd = 873996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void setAvailableSelections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityListTargetNode.NativeMethodInfoPtr_setAvailableSelections_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x00063228 File Offset: 0x00061428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873998, XrefRangeEnd = 874005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityListTargetNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x00008A86 File Offset: 0x00006C86
		public EntityListTargetNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x060013A1 RID: 5025 RVA: 0x00063264 File Offset: 0x00061464
		// (set) Token: 0x060013A2 RID: 5026 RVA: 0x00008A8F File Offset: 0x00006C8F
		public unsafe static IList<EntityID> none
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityListTargetNode.NativeFieldInfoPtr_none, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityListTargetNode.NativeFieldInfoPtr_none, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x060013A3 RID: 5027 RVA: 0x0006328C File Offset: 0x0006148C
		// (set) Token: 0x060013A4 RID: 5028 RVA: 0x00008AA1 File Offset: 0x00006CA1
		public unsafe IList<EntityID> availableSelections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityListTargetNode.NativeFieldInfoPtr_availableSelections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityListTargetNode.NativeFieldInfoPtr_availableSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x060013A5 RID: 5029 RVA: 0x000632BC File Offset: 0x000614BC
		// (set) Token: 0x060013A6 RID: 5030 RVA: 0x00008AC0 File Offset: 0x00006CC0
		public unsafe IList<EntityID> previousSelections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityListTargetNode.NativeFieldInfoPtr_previousSelections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityListTargetNode.NativeFieldInfoPtr_previousSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x060013A7 RID: 5031 RVA: 0x000632EC File Offset: 0x000614EC
		// (set) Token: 0x060013A8 RID: 5032 RVA: 0x00008ADF File Offset: 0x00006CDF
		public new unsafe EntityListTargetInformation targetInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityListTargetNode.NativeFieldInfoPtr_targetInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityListTargetInformation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityListTargetNode.NativeFieldInfoPtr_targetInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x060013A9 RID: 5033 RVA: 0x0006331C File Offset: 0x0006151C
		// (set) Token: 0x060013AA RID: 5034 RVA: 0x00008AFE File Offset: 0x00006CFE
		public unsafe Dictionary<EntityID, List<TargetStrength>> cachedHints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityListTargetNode.NativeFieldInfoPtr_cachedHints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, List<TargetStrength>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityListTargetNode.NativeFieldInfoPtr_cachedHints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E01 RID: 3585
		private static readonly IntPtr NativeFieldInfoPtr_none;

		// Token: 0x04000E02 RID: 3586
		private static readonly IntPtr NativeFieldInfoPtr_availableSelections;

		// Token: 0x04000E03 RID: 3587
		private static readonly IntPtr NativeFieldInfoPtr_previousSelections;

		// Token: 0x04000E04 RID: 3588
		private static readonly IntPtr NativeFieldInfoPtr_targetInfo;

		// Token: 0x04000E05 RID: 3589
		private static readonly IntPtr NativeFieldInfoPtr_cachedHints;

		// Token: 0x04000E06 RID: 3590
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_EntityListTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0;

		// Token: 0x04000E07 RID: 3591
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_EntityListTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_String_0;

		// Token: 0x04000E08 RID: 3592
		private static readonly IntPtr NativeMethodInfoPtr_get_satisfied_Protected_Virtual_get_Boolean_0;

		// Token: 0x04000E09 RID: 3593
		private static readonly IntPtr NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0;

		// Token: 0x04000E0A RID: 3594
		private static readonly IntPtr NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000E0B RID: 3595
		private static readonly IntPtr NativeMethodInfoPtr_get_AvailableSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0;

		// Token: 0x04000E0C RID: 3596
		private static readonly IntPtr NativeMethodInfoPtr_get_AllAvailableSelections_Public_get_IList_1_EntityID_0;

		// Token: 0x04000E0D RID: 3597
		private static readonly IntPtr NativeMethodInfoPtr_get_PreviousSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0;

		// Token: 0x04000E0E RID: 3598
		private static readonly IntPtr NativeMethodInfoPtr_get_ForcedSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0;

		// Token: 0x04000E0F RID: 3599
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_EntityID_0;

		// Token: 0x04000E10 RID: 3600
		private static readonly IntPtr NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_EntityID_0;

		// Token: 0x04000E11 RID: 3601
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxToSelect_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000E12 RID: 3602
		private static readonly IntPtr NativeMethodInfoPtr_get_MinToSelect_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000E13 RID: 3603
		private static readonly IntPtr NativeMethodInfoPtr_HintStrength_Public_Virtual_Final_New_TargetStrength_EntityID_0;

		// Token: 0x04000E14 RID: 3604
		private static readonly IntPtr NativeMethodInfoPtr_HintStrengths_Public_Virtual_Final_New_List_1_TargetStrength_EntityID_0;

		// Token: 0x04000E15 RID: 3605
		private static readonly IntPtr NativeMethodInfoPtr_AllHintStrengths_Public_Virtual_Final_New_Dictionary_2_EntityID_List_1_TargetStrength_0;

		// Token: 0x04000E16 RID: 3606
		private static readonly IntPtr NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_EntityID_0;

		// Token: 0x04000E17 RID: 3607
		private static readonly IntPtr NativeMethodInfoPtr_getResponse_Protected_Virtual_TargetResponse_0;

		// Token: 0x04000E18 RID: 3608
		private static readonly IntPtr NativeMethodInfoPtr_setAvailableSelections_Private_Void_0;

		// Token: 0x04000E19 RID: 3609
		private static readonly IntPtr NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0;
	}
}
