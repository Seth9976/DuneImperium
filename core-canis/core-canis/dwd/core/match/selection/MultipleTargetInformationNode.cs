using System;
using Canis.attributes;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.match.selection
{
	// Token: 0x02000154 RID: 340
	public class MultipleTargetInformationNode : SelectionNode
	{
		// Token: 0x060013D5 RID: 5077 RVA: 0x00063DE4 File Offset: 0x00061FE4
		// Note: this type is marked as 'beforefieldinit'.
		static MultipleTargetInformationNode()
		{
			Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "MultipleTargetInformationNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr);
			MultipleTargetInformationNode.NativeFieldInfoPtr_none = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, "none");
			MultipleTargetInformationNode.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, "Source");
			MultipleTargetInformationNode.NativeFieldInfoPtr_targetInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, "targetInfo");
			MultipleTargetInformationNode.NativeFieldInfoPtr_selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, "selected");
			MultipleTargetInformationNode.NativeFieldInfoPtr_available = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, "available");
			MultipleTargetInformationNode.NativeFieldInfoPtr_previous = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, "previous");
			MultipleTargetInformationNode.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, "attributes");
			MultipleTargetInformationNode.NativeMethodInfoPtr_get_SelectionMade_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, 100666308);
			MultipleTargetInformationNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_ISelectionRoot_ISelectionNode_MultipleTargetInformation_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, 100666309);
			MultipleTargetInformationNode.NativeMethodInfoPtr_Enter_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, 100666310);
			MultipleTargetInformationNode.NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, 100666311);
			MultipleTargetInformationNode.NativeMethodInfoPtr_get_MayCancel_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, 100666312);
			MultipleTargetInformationNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, 100666313);
			MultipleTargetInformationNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, 100666314);
			MultipleTargetInformationNode.NativeMethodInfoPtr_get_AvailableSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, 100666315);
			MultipleTargetInformationNode.NativeMethodInfoPtr_get_PreviousSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, 100666316);
			MultipleTargetInformationNode.NativeMethodInfoPtr_get_ForcedSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, 100666317);
			MultipleTargetInformationNode.NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, 100666318);
			MultipleTargetInformationNode.NativeMethodInfoPtr_select_Protected_Virtual_New_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, 100666319);
			MultipleTargetInformationNode.NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, 100666320);
			MultipleTargetInformationNode.NativeMethodInfoPtr_unselect_Protected_Virtual_New_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, 100666321);
			MultipleTargetInformationNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, 100666322);
			MultipleTargetInformationNode.NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, 100666323);
			MultipleTargetInformationNode.NativeMethodInfoPtr_get_MaxToSelect_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, 100666324);
			MultipleTargetInformationNode.NativeMethodInfoPtr_get_MinToSelect_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, 100666325);
			MultipleTargetInformationNode.NativeMethodInfoPtr_get_Prompt_Public_Virtual_get_LocalizableTextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, 100666326);
			MultipleTargetInformationNode.NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, 100666327);
			MultipleTargetInformationNode.NativeMethodInfoPtr_get_TargetInfos_Public_get_IEnumerable_1_MultiTargetEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr, 100666328);
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x060013D6 RID: 5078 RVA: 0x00064044 File Offset: 0x00062244
		public unsafe bool SelectionMade
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874388, XrefRangeEnd = 874392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleTargetInformationNode.NativeMethodInfoPtr_get_SelectionMade_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x00064080 File Offset: 0x00062280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874392, XrefRangeEnd = 874414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultipleTargetInformationNode(ISelectionNodeFactory factory, ISelectionRoot root, ISelectionNode parent, MultipleTargetInformation targetInfo, EntityID source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleTargetInformationNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetInfo);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleTargetInformationNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_ISelectionRoot_ISelectionNode_MultipleTargetInformation_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x00064118 File Offset: 0x00062318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874414, XrefRangeEnd = 874418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Enter(bool fromCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromCancel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleTargetInformationNode.NativeMethodInfoPtr_Enter_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x060013D9 RID: 5081 RVA: 0x00064164 File Offset: 0x00062364
		public unsafe override bool MayAdvance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874418, XrefRangeEnd = 874419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleTargetInformationNode.NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x060013DA RID: 5082 RVA: 0x000641AC File Offset: 0x000623AC
		public unsafe override bool MayCancel
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleTargetInformationNode.NativeMethodInfoPtr_get_MayCancel_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x060013DB RID: 5083 RVA: 0x000641F4 File Offset: 0x000623F4
		public unsafe override bool HasClearableState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874419, XrefRangeEnd = 874420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleTargetInformationNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x0006423C File Offset: 0x0006243C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874420, XrefRangeEnd = 874440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleTargetInformationNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x060013DD RID: 5085 RVA: 0x00064278 File Offset: 0x00062478
		public unsafe virtual IList<EntityID> AvailableSelections
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874440, XrefRangeEnd = 874451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleTargetInformationNode.NativeMethodInfoPtr_get_AvailableSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x060013DE RID: 5086 RVA: 0x000642B8 File Offset: 0x000624B8
		public unsafe virtual IList<EntityID> PreviousSelections
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 874471, RefRangeEnd = 874473, XrefRangeStart = 874451, XrefRangeEnd = 874471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleTargetInformationNode.NativeMethodInfoPtr_get_PreviousSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x000642F8 File Offset: 0x000624F8
		public unsafe virtual IList<EntityID> ForcedSelections
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874473, XrefRangeEnd = 874477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleTargetInformationNode.NativeMethodInfoPtr_get_ForcedSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00064338 File Offset: 0x00062538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874477, XrefRangeEnd = 874489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Select(EntityID entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleTargetInformationNode.NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x0006437C File Offset: 0x0006257C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void select(EntityID selection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleTargetInformationNode.NativeMethodInfoPtr_select_Protected_Virtual_New_Void_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x000643CC File Offset: 0x000625CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874489, XrefRangeEnd = 874500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unselect(EntityID entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleTargetInformationNode.NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x00064410 File Offset: 0x00062610
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void unselect(EntityID selection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleTargetInformationNode.NativeMethodInfoPtr_unselect_Protected_Virtual_New_Void_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x00064460 File Offset: 0x00062660
		[CallerCount(0)]
		public unsafe override ISelectionNode NodeToAdvanceTo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleTargetInformationNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x000644AC File Offset: 0x000626AC
		[CallerCount(0)]
		public unsafe virtual ISelectionNode PeekNode(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleTargetInformationNode.NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x000644FC File Offset: 0x000626FC
		public unsafe virtual int MaxToSelect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleTargetInformationNode.NativeMethodInfoPtr_get_MaxToSelect_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x060013E7 RID: 5095 RVA: 0x00064538 File Offset: 0x00062738
		public unsafe virtual int MinToSelect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleTargetInformationNode.NativeMethodInfoPtr_get_MinToSelect_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x00064574 File Offset: 0x00062774
		public unsafe override LocalizableTextVariables Prompt
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 372752, RefRangeEnd = 372755, XrefRangeStart = 372752, XrefRangeEnd = 372755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleTargetInformationNode.NativeMethodInfoPtr_get_Prompt_Public_Virtual_get_LocalizableTextVariables_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr3) : null;
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x060013E9 RID: 5097 RVA: 0x000645C0 File Offset: 0x000627C0
		public unsafe override ReadOnlyAttributes Attributes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874500, XrefRangeEnd = 874505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleTargetInformationNode.NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_ReadOnlyAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x0006460C File Offset: 0x0006280C
		public unsafe IEnumerable<MultiTargetEntity> TargetInfos
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleTargetInformationNode.NativeMethodInfoPtr_get_TargetInfos_Public_get_IEnumerable_1_MultiTargetEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<MultiTargetEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x00008C28 File Offset: 0x00006E28
		public MultipleTargetInformationNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x060013EC RID: 5100 RVA: 0x0006464C File Offset: 0x0006284C
		// (set) Token: 0x060013ED RID: 5101 RVA: 0x00008C31 File Offset: 0x00006E31
		public unsafe static IList<EntityID> none
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultipleTargetInformationNode.NativeFieldInfoPtr_none, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultipleTargetInformationNode.NativeFieldInfoPtr_none, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x00064674 File Offset: 0x00062874
		// (set) Token: 0x060013EF RID: 5103 RVA: 0x00008C43 File Offset: 0x00006E43
		public unsafe EntityID Source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleTargetInformationNode.NativeFieldInfoPtr_Source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleTargetInformationNode.NativeFieldInfoPtr_Source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x000646A4 File Offset: 0x000628A4
		// (set) Token: 0x060013F1 RID: 5105 RVA: 0x00008C62 File Offset: 0x00006E62
		public unsafe MultipleTargetInformation targetInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleTargetInformationNode.NativeFieldInfoPtr_targetInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultipleTargetInformation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleTargetInformationNode.NativeFieldInfoPtr_targetInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x000646D4 File Offset: 0x000628D4
		// (set) Token: 0x060013F3 RID: 5107 RVA: 0x00008C81 File Offset: 0x00006E81
		public unsafe HashSet<EntityID> selected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleTargetInformationNode.NativeFieldInfoPtr_selected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleTargetInformationNode.NativeFieldInfoPtr_selected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x00064704 File Offset: 0x00062904
		// (set) Token: 0x060013F5 RID: 5109 RVA: 0x00008CA0 File Offset: 0x00006EA0
		public unsafe IList<EntityID> available
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleTargetInformationNode.NativeFieldInfoPtr_available);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleTargetInformationNode.NativeFieldInfoPtr_available), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x00064734 File Offset: 0x00062934
		// (set) Token: 0x060013F7 RID: 5111 RVA: 0x00008CBF File Offset: 0x00006EBF
		public unsafe IList<EntityID> previous
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleTargetInformationNode.NativeFieldInfoPtr_previous);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleTargetInformationNode.NativeFieldInfoPtr_previous), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x00064764 File Offset: 0x00062964
		// (set) Token: 0x060013F9 RID: 5113 RVA: 0x00008CDE File Offset: 0x00006EDE
		public unsafe ReadOnlyAttributes attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleTargetInformationNode.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleTargetInformationNode.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E39 RID: 3641
		private static readonly IntPtr NativeFieldInfoPtr_none;

		// Token: 0x04000E3A RID: 3642
		private static readonly IntPtr NativeFieldInfoPtr_Source;

		// Token: 0x04000E3B RID: 3643
		private static readonly IntPtr NativeFieldInfoPtr_targetInfo;

		// Token: 0x04000E3C RID: 3644
		private static readonly IntPtr NativeFieldInfoPtr_selected;

		// Token: 0x04000E3D RID: 3645
		private static readonly IntPtr NativeFieldInfoPtr_available;

		// Token: 0x04000E3E RID: 3646
		private static readonly IntPtr NativeFieldInfoPtr_previous;

		// Token: 0x04000E3F RID: 3647
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04000E40 RID: 3648
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectionMade_Public_get_Boolean_0;

		// Token: 0x04000E41 RID: 3649
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_ISelectionRoot_ISelectionNode_MultipleTargetInformation_EntityID_0;

		// Token: 0x04000E42 RID: 3650
		private static readonly IntPtr NativeMethodInfoPtr_Enter_Public_Virtual_Void_Boolean_0;

		// Token: 0x04000E43 RID: 3651
		private static readonly IntPtr NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0;

		// Token: 0x04000E44 RID: 3652
		private static readonly IntPtr NativeMethodInfoPtr_get_MayCancel_Public_Virtual_get_Boolean_0;

		// Token: 0x04000E45 RID: 3653
		private static readonly IntPtr NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0;

		// Token: 0x04000E46 RID: 3654
		private static readonly IntPtr NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0;

		// Token: 0x04000E47 RID: 3655
		private static readonly IntPtr NativeMethodInfoPtr_get_AvailableSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0;

		// Token: 0x04000E48 RID: 3656
		private static readonly IntPtr NativeMethodInfoPtr_get_PreviousSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0;

		// Token: 0x04000E49 RID: 3657
		private static readonly IntPtr NativeMethodInfoPtr_get_ForcedSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0;

		// Token: 0x04000E4A RID: 3658
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_EntityID_0;

		// Token: 0x04000E4B RID: 3659
		private static readonly IntPtr NativeMethodInfoPtr_select_Protected_Virtual_New_Void_EntityID_0;

		// Token: 0x04000E4C RID: 3660
		private static readonly IntPtr NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_EntityID_0;

		// Token: 0x04000E4D RID: 3661
		private static readonly IntPtr NativeMethodInfoPtr_unselect_Protected_Virtual_New_Void_EntityID_0;

		// Token: 0x04000E4E RID: 3662
		private static readonly IntPtr NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0;

		// Token: 0x04000E4F RID: 3663
		private static readonly IntPtr NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_EntityID_0;

		// Token: 0x04000E50 RID: 3664
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxToSelect_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000E51 RID: 3665
		private static readonly IntPtr NativeMethodInfoPtr_get_MinToSelect_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000E52 RID: 3666
		private static readonly IntPtr NativeMethodInfoPtr_get_Prompt_Public_Virtual_get_LocalizableTextVariables_0;

		// Token: 0x04000E53 RID: 3667
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_ReadOnlyAttributes_0;

		// Token: 0x04000E54 RID: 3668
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetInfos_Public_get_IEnumerable_1_MultiTargetEntity_0;
	}
}
