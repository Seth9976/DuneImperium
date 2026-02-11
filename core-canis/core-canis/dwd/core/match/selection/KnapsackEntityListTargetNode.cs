using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Networking.selection;
using Networking.selection.targetinformation;
using Networking.selection.targetresponse;

namespace dwd.core.match.selection
{
	// Token: 0x02000153 RID: 339
	public class KnapsackEntityListTargetNode : TargetInfoNode
	{
		// Token: 0x060013AB RID: 5035 RVA: 0x0006334C File Offset: 0x0006154C
		// Note: this type is marked as 'beforefieldinit'.
		static KnapsackEntityListTargetNode()
		{
			Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "KnapsackEntityListTargetNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr);
			KnapsackEntityListTargetNode.NativeFieldInfoPtr_none = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, "none");
			KnapsackEntityListTargetNode.NativeFieldInfoPtr_unselectedEnts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, "unselectedEnts");
			KnapsackEntityListTargetNode.NativeFieldInfoPtr_unselectedSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, "unselectedSelections");
			KnapsackEntityListTargetNode.NativeFieldInfoPtr_selectedEnts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, "selectedEnts");
			KnapsackEntityListTargetNode.NativeFieldInfoPtr_selectedSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, "selectedSelections");
			KnapsackEntityListTargetNode.NativeFieldInfoPtr_minAvailableWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, "minAvailableWeight");
			KnapsackEntityListTargetNode.NativeFieldInfoPtr_maxAvailableWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, "maxAvailableWeight");
			KnapsackEntityListTargetNode.NativeFieldInfoPtr_targetInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, "targetInfo");
			KnapsackEntityListTargetNode.NativeFieldInfoPtr_cachedHints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, "cachedHints");
			KnapsackEntityListTargetNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_KnapsackEntityListTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, 100666273);
			KnapsackEntityListTargetNode.NativeMethodInfoPtr_get_satisfied_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, 100666274);
			KnapsackEntityListTargetNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, 100666275);
			KnapsackEntityListTargetNode.NativeMethodInfoPtr_get_AvailableSelections_Public_Virtual_New_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, 100666276);
			KnapsackEntityListTargetNode.NativeMethodInfoPtr_get_PreviousSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, 100666277);
			KnapsackEntityListTargetNode.NativeMethodInfoPtr_get_ForcedSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, 100666278);
			KnapsackEntityListTargetNode.NativeMethodInfoPtr_Select_Public_Virtual_New_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, 100666279);
			KnapsackEntityListTargetNode.NativeMethodInfoPtr_Unselect_Public_Virtual_New_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, 100666280);
			KnapsackEntityListTargetNode.NativeMethodInfoPtr_get_MaxToSelect_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, 100666281);
			KnapsackEntityListTargetNode.NativeMethodInfoPtr_get_MinToSelect_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, 100666282);
			KnapsackEntityListTargetNode.NativeMethodInfoPtr_HintStrength_Public_Virtual_Final_New_TargetStrength_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, 100666283);
			KnapsackEntityListTargetNode.NativeMethodInfoPtr_HintStrengths_Public_Virtual_Final_New_List_1_TargetStrength_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, 100666284);
			KnapsackEntityListTargetNode.NativeMethodInfoPtr_AllHintStrengths_Public_Virtual_Final_New_Dictionary_2_EntityID_List_1_TargetStrength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, 100666285);
			KnapsackEntityListTargetNode.NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, 100666286);
			KnapsackEntityListTargetNode.NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, 100666287);
			KnapsackEntityListTargetNode.NativeMethodInfoPtr_getResponse_Protected_Virtual_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, 100666288);
			KnapsackEntityListTargetNode.NativeMethodInfoPtr_EntitiesSatisfyingSelectionMode_Private_IEnumerable_1_EntityID_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, 100666289);
			KnapsackEntityListTargetNode.NativeMethodInfoPtr_CurrentlySelectedWeight_Protected_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, 100666290);
			KnapsackEntityListTargetNode.NativeMethodInfoPtr_get_TargetWeight_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, 100666291);
			KnapsackEntityListTargetNode.NativeMethodInfoPtr_get_Weights_Public_get_Dictionary_2_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, 100666292);
			KnapsackEntityListTargetNode.NativeMethodInfoPtr_setAvailableSelections_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, 100666293);
			KnapsackEntityListTargetNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, 100666294);
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x000635E8 File Offset: 0x000617E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874110, XrefRangeEnd = 874144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KnapsackEntityListTargetNode(ISelectionNodeFactory factory, KnapsackEntityListTargetInformation targetInfo, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> subsequent, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_KnapsackEntityListTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x060013AD RID: 5037 RVA: 0x000636A0 File Offset: 0x000618A0
		public unsafe override bool satisfied
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874144, XrefRangeEnd = 874148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KnapsackEntityListTargetNode.NativeMethodInfoPtr_get_satisfied_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x060013AE RID: 5038 RVA: 0x000636E8 File Offset: 0x000618E8
		public unsafe override bool HasClearableState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874148, XrefRangeEnd = 874151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KnapsackEntityListTargetNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x060013AF RID: 5039 RVA: 0x00063730 File Offset: 0x00061930
		public unsafe virtual IList<EntityID> AvailableSelections
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874151, XrefRangeEnd = 874180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KnapsackEntityListTargetNode.NativeMethodInfoPtr_get_AvailableSelections_Public_Virtual_New_get_IList_1_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x060013B0 RID: 5040 RVA: 0x0006377C File Offset: 0x0006197C
		public unsafe virtual IList<EntityID> PreviousSelections
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetNode.NativeMethodInfoPtr_get_PreviousSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x060013B1 RID: 5041 RVA: 0x000637BC File Offset: 0x000619BC
		public unsafe virtual IList<EntityID> ForcedSelections
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874180, XrefRangeEnd = 874184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetNode.NativeMethodInfoPtr_get_ForcedSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x000637FC File Offset: 0x000619FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874184, XrefRangeEnd = 874199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Select(EntityID entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KnapsackEntityListTargetNode.NativeMethodInfoPtr_Select_Public_Virtual_New_Void_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x0006384C File Offset: 0x00061A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874199, XrefRangeEnd = 874214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unselect(EntityID entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KnapsackEntityListTargetNode.NativeMethodInfoPtr_Unselect_Public_Virtual_New_Void_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x060013B4 RID: 5044 RVA: 0x0006389C File Offset: 0x00061A9C
		public unsafe virtual int MaxToSelect
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874214, XrefRangeEnd = 874220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetNode.NativeMethodInfoPtr_get_MaxToSelect_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x060013B5 RID: 5045 RVA: 0x000638D8 File Offset: 0x00061AD8
		public unsafe virtual int MinToSelect
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874220, XrefRangeEnd = 874224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetNode.NativeMethodInfoPtr_get_MinToSelect_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x00063914 File Offset: 0x00061B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874224, XrefRangeEnd = 874240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TargetStrength HintStrength(EntityID entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetNode.NativeMethodInfoPtr_HintStrength_Public_Virtual_Final_New_TargetStrength_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x00063964 File Offset: 0x00061B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874240, XrefRangeEnd = 874276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<TargetStrength> HintStrengths(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetNode.NativeMethodInfoPtr_HintStrengths_Public_Virtual_Final_New_List_1_TargetStrength_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TargetStrength>>(intPtr3) : null;
			}
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x000639B4 File Offset: 0x00061BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874276, XrefRangeEnd = 874320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Dictionary<EntityID, List<TargetStrength>> AllHintStrengths()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetNode.NativeMethodInfoPtr_AllHintStrengths_Public_Virtual_Final_New_Dictionary_2_EntityID_List_1_TargetStrength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, List<TargetStrength>>>(intPtr3) : null;
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x000639F4 File Offset: 0x00061BF4
		[CallerCount(0)]
		public unsafe virtual ISelectionNode PeekNode(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetNode.NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x060013BA RID: 5050 RVA: 0x00063A44 File Offset: 0x00061C44
		public unsafe virtual bool Forced
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetNode.NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x00063A80 File Offset: 0x00061C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874320, XrefRangeEnd = 874324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TargetResponse getResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KnapsackEntityListTargetNode.NativeMethodInfoPtr_getResponse_Protected_Virtual_TargetResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetResponse>(intPtr3) : null;
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x00063ACC File Offset: 0x00061CCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 874330, RefRangeEnd = 874331, XrefRangeStart = 874324, XrefRangeEnd = 874330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<EntityID> EntitiesSatisfyingSelectionMode(bool withSelectedRemoval = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref withSelectedRemoval;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetNode.NativeMethodInfoPtr_EntitiesSatisfyingSelectionMode_Private_IEnumerable_1_EntityID_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x00063B18 File Offset: 0x00061D18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 874348, RefRangeEnd = 874349, XrefRangeStart = 874331, XrefRangeEnd = 874348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CurrentlySelectedWeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetNode.NativeMethodInfoPtr_CurrentlySelectedWeight_Protected_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x060013BE RID: 5054 RVA: 0x00063B54 File Offset: 0x00061D54
		public unsafe int TargetWeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetNode.NativeMethodInfoPtr_get_TargetWeight_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x060013BF RID: 5055 RVA: 0x00063B90 File Offset: 0x00061D90
		public unsafe Dictionary<EntityID, int> Weights
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetNode.NativeMethodInfoPtr_get_Weights_Public_get_Dictionary_2_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, int>>(intPtr3) : null;
			}
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x00063BD0 File Offset: 0x00061DD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 874375, RefRangeEnd = 874378, XrefRangeStart = 874349, XrefRangeEnd = 874375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void setAvailableSelections(bool setTotalTargetWeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref setTotalTargetWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetNode.NativeMethodInfoPtr_setAvailableSelections_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x00063C10 File Offset: 0x00061E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874378, XrefRangeEnd = 874388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KnapsackEntityListTargetNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x00008B1D File Offset: 0x00006D1D
		public KnapsackEntityListTargetNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x00063C4C File Offset: 0x00061E4C
		// (set) Token: 0x060013C4 RID: 5060 RVA: 0x00008B26 File Offset: 0x00006D26
		public unsafe static IList<EntityID> none
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KnapsackEntityListTargetNode.NativeFieldInfoPtr_none, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KnapsackEntityListTargetNode.NativeFieldInfoPtr_none, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x060013C5 RID: 5061 RVA: 0x00063C74 File Offset: 0x00061E74
		// (set) Token: 0x060013C6 RID: 5062 RVA: 0x00008B38 File Offset: 0x00006D38
		public unsafe List<EntityID> unselectedEnts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode.NativeFieldInfoPtr_unselectedEnts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode.NativeFieldInfoPtr_unselectedEnts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x060013C7 RID: 5063 RVA: 0x00063CA4 File Offset: 0x00061EA4
		// (set) Token: 0x060013C8 RID: 5064 RVA: 0x00008B57 File Offset: 0x00006D57
		public unsafe Dictionary<EntityID, int> unselectedSelections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode.NativeFieldInfoPtr_unselectedSelections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode.NativeFieldInfoPtr_unselectedSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x060013C9 RID: 5065 RVA: 0x00063CD4 File Offset: 0x00061ED4
		// (set) Token: 0x060013CA RID: 5066 RVA: 0x00008B76 File Offset: 0x00006D76
		public unsafe List<EntityID> selectedEnts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode.NativeFieldInfoPtr_selectedEnts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode.NativeFieldInfoPtr_selectedEnts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x060013CB RID: 5067 RVA: 0x00063D04 File Offset: 0x00061F04
		// (set) Token: 0x060013CC RID: 5068 RVA: 0x00008B95 File Offset: 0x00006D95
		public unsafe Dictionary<EntityID, int> selectedSelections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode.NativeFieldInfoPtr_selectedSelections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode.NativeFieldInfoPtr_selectedSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x060013CD RID: 5069 RVA: 0x00063D34 File Offset: 0x00061F34
		// (set) Token: 0x060013CE RID: 5070 RVA: 0x00008BB4 File Offset: 0x00006DB4
		public unsafe int minAvailableWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode.NativeFieldInfoPtr_minAvailableWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode.NativeFieldInfoPtr_minAvailableWeight)) = value;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x060013CF RID: 5071 RVA: 0x00063D5C File Offset: 0x00061F5C
		// (set) Token: 0x060013D0 RID: 5072 RVA: 0x00008BCF File Offset: 0x00006DCF
		public unsafe int maxAvailableWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode.NativeFieldInfoPtr_maxAvailableWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode.NativeFieldInfoPtr_maxAvailableWeight)) = value;
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x00063D84 File Offset: 0x00061F84
		// (set) Token: 0x060013D2 RID: 5074 RVA: 0x00008BEA File Offset: 0x00006DEA
		public new unsafe KnapsackEntityListTargetInformation targetInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode.NativeFieldInfoPtr_targetInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KnapsackEntityListTargetInformation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode.NativeFieldInfoPtr_targetInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x00063DB4 File Offset: 0x00061FB4
		// (set) Token: 0x060013D4 RID: 5076 RVA: 0x00008C09 File Offset: 0x00006E09
		public unsafe Dictionary<EntityID, List<TargetStrength>> cachedHints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode.NativeFieldInfoPtr_cachedHints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, List<TargetStrength>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode.NativeFieldInfoPtr_cachedHints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E1A RID: 3610
		private static readonly IntPtr NativeFieldInfoPtr_none;

		// Token: 0x04000E1B RID: 3611
		private static readonly IntPtr NativeFieldInfoPtr_unselectedEnts;

		// Token: 0x04000E1C RID: 3612
		private static readonly IntPtr NativeFieldInfoPtr_unselectedSelections;

		// Token: 0x04000E1D RID: 3613
		private static readonly IntPtr NativeFieldInfoPtr_selectedEnts;

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeFieldInfoPtr_selectedSelections;

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeFieldInfoPtr_minAvailableWeight;

		// Token: 0x04000E20 RID: 3616
		private static readonly IntPtr NativeFieldInfoPtr_maxAvailableWeight;

		// Token: 0x04000E21 RID: 3617
		private static readonly IntPtr NativeFieldInfoPtr_targetInfo;

		// Token: 0x04000E22 RID: 3618
		private static readonly IntPtr NativeFieldInfoPtr_cachedHints;

		// Token: 0x04000E23 RID: 3619
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_KnapsackEntityListTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_String_0;

		// Token: 0x04000E24 RID: 3620
		private static readonly IntPtr NativeMethodInfoPtr_get_satisfied_Protected_Virtual_get_Boolean_0;

		// Token: 0x04000E25 RID: 3621
		private static readonly IntPtr NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0;

		// Token: 0x04000E26 RID: 3622
		private static readonly IntPtr NativeMethodInfoPtr_get_AvailableSelections_Public_Virtual_New_get_IList_1_EntityID_0;

		// Token: 0x04000E27 RID: 3623
		private static readonly IntPtr NativeMethodInfoPtr_get_PreviousSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0;

		// Token: 0x04000E28 RID: 3624
		private static readonly IntPtr NativeMethodInfoPtr_get_ForcedSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0;

		// Token: 0x04000E29 RID: 3625
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_New_Void_EntityID_0;

		// Token: 0x04000E2A RID: 3626
		private static readonly IntPtr NativeMethodInfoPtr_Unselect_Public_Virtual_New_Void_EntityID_0;

		// Token: 0x04000E2B RID: 3627
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxToSelect_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000E2C RID: 3628
		private static readonly IntPtr NativeMethodInfoPtr_get_MinToSelect_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000E2D RID: 3629
		private static readonly IntPtr NativeMethodInfoPtr_HintStrength_Public_Virtual_Final_New_TargetStrength_EntityID_0;

		// Token: 0x04000E2E RID: 3630
		private static readonly IntPtr NativeMethodInfoPtr_HintStrengths_Public_Virtual_Final_New_List_1_TargetStrength_EntityID_0;

		// Token: 0x04000E2F RID: 3631
		private static readonly IntPtr NativeMethodInfoPtr_AllHintStrengths_Public_Virtual_Final_New_Dictionary_2_EntityID_List_1_TargetStrength_0;

		// Token: 0x04000E30 RID: 3632
		private static readonly IntPtr NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_EntityID_0;

		// Token: 0x04000E31 RID: 3633
		private static readonly IntPtr NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000E32 RID: 3634
		private static readonly IntPtr NativeMethodInfoPtr_getResponse_Protected_Virtual_TargetResponse_0;

		// Token: 0x04000E33 RID: 3635
		private static readonly IntPtr NativeMethodInfoPtr_EntitiesSatisfyingSelectionMode_Private_IEnumerable_1_EntityID_Boolean_0;

		// Token: 0x04000E34 RID: 3636
		private static readonly IntPtr NativeMethodInfoPtr_CurrentlySelectedWeight_Protected_Int32_0;

		// Token: 0x04000E35 RID: 3637
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetWeight_Protected_get_Int32_0;

		// Token: 0x04000E36 RID: 3638
		private static readonly IntPtr NativeMethodInfoPtr_get_Weights_Public_get_Dictionary_2_EntityID_Int32_0;

		// Token: 0x04000E37 RID: 3639
		private static readonly IntPtr NativeMethodInfoPtr_setAvailableSelections_Private_Void_Boolean_0;

		// Token: 0x04000E38 RID: 3640
		private static readonly IntPtr NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0;

		// Token: 0x020002E1 RID: 737
		[ObfuscatedName("dwd.core.match.selection.KnapsackEntityListTargetNode+<EntitiesSatisfyingSelectionMode>d__33")]
		public sealed class _EntitiesSatisfyingSelectionMode_d__33 : Object
		{
			// Token: 0x0600220C RID: 8716 RVA: 0x00097A18 File Offset: 0x00095C18
			// Note: this type is marked as 'beforefieldinit'.
			static _EntitiesSatisfyingSelectionMode_d__33()
			{
				Il2CppClassPointerStore<KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KnapsackEntityListTargetNode>.NativeClassPtr, "<EntitiesSatisfyingSelectionMode>d__33");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33>.NativeClassPtr);
				KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33>.NativeClassPtr, "<>1__state");
				KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33>.NativeClassPtr, "<>2__current");
				KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33>.NativeClassPtr, "<>l__initialThreadId");
				KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33>.NativeClassPtr, "<>4__this");
				KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeFieldInfoPtr_withSelectedRemoval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33>.NativeClassPtr, "withSelectedRemoval");
				KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeFieldInfoPtr___3__withSelectedRemoval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33>.NativeClassPtr, "<>3__withSelectedRemoval");
				KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeFieldInfoPtr__remainingDiff_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33>.NativeClassPtr, "<remainingDiff>5__2");
				KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33>.NativeClassPtr, "<>7__wrap2");
				KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33>.NativeClassPtr, 100666296);
				KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33>.NativeClassPtr, 100666297);
				KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33>.NativeClassPtr, 100666298);
				KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33>.NativeClassPtr, 100666299);
				KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33>.NativeClassPtr, 100666300);
				KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33>.NativeClassPtr, 100666301);
				KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeMethodInfoPtr___m__Finally4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33>.NativeClassPtr, 100666302);
				KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_utils_ids_EntityID__get_Current_Private_Virtual_Final_New_get_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33>.NativeClassPtr, 100666303);
				KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33>.NativeClassPtr, 100666304);
				KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33>.NativeClassPtr, 100666305);
				KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_utils_ids_EntityID__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33>.NativeClassPtr, 100666306);
				KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33>.NativeClassPtr, 100666307);
			}

			// Token: 0x0600220D RID: 8717 RVA: 0x00097BD4 File Offset: 0x00095DD4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _EntitiesSatisfyingSelectionMode_d__33(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600220E RID: 8718 RVA: 0x00097C1C File Offset: 0x00095E1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874005, XrefRangeEnd = 874025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600220F RID: 8719 RVA: 0x00097C50 File Offset: 0x00095E50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874025, XrefRangeEnd = 874085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002210 RID: 8720 RVA: 0x00097C8C File Offset: 0x00095E8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874085, XrefRangeEnd = 874088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002211 RID: 8721 RVA: 0x00097CC0 File Offset: 0x00095EC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874088, XrefRangeEnd = 874091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002212 RID: 8722 RVA: 0x00097CF4 File Offset: 0x00095EF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874091, XrefRangeEnd = 874094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002213 RID: 8723 RVA: 0x00097D28 File Offset: 0x00095F28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874094, XrefRangeEnd = 874097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeMethodInfoPtr___m__Finally4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000951 RID: 2385
			// (get) Token: 0x06002214 RID: 8724 RVA: 0x00097D5C File Offset: 0x00095F5C
			public unsafe EntityID System.Collections.Generic.IEnumerator<Canis.utils.ids.EntityID>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_utils_ids_EntityID__get_Current_Private_Virtual_Final_New_get_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06002215 RID: 8725 RVA: 0x00097D9C File Offset: 0x00095F9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874097, XrefRangeEnd = 874102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000952 RID: 2386
			// (get) Token: 0x06002216 RID: 8726 RVA: 0x00097DD0 File Offset: 0x00095FD0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002217 RID: 8727 RVA: 0x00097E10 File Offset: 0x00096010
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874102, XrefRangeEnd = 874110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<EntityID> System_Collections_Generic_IEnumerable_Canis_utils_ids_EntityID__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_utils_ids_EntityID__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<EntityID>>(intPtr3) : null;
			}

			// Token: 0x06002218 RID: 8728 RVA: 0x00097E50 File Offset: 0x00096050
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002219 RID: 8729 RVA: 0x0000E957 File Offset: 0x0000CB57
			public _EntitiesSatisfyingSelectionMode_d__33(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000949 RID: 2377
			// (get) Token: 0x0600221A RID: 8730 RVA: 0x00097E90 File Offset: 0x00096090
			// (set) Token: 0x0600221B RID: 8731 RVA: 0x0000E960 File Offset: 0x0000CB60
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700094A RID: 2378
			// (get) Token: 0x0600221C RID: 8732 RVA: 0x00097EB8 File Offset: 0x000960B8
			// (set) Token: 0x0600221D RID: 8733 RVA: 0x0000E97B File Offset: 0x0000CB7B
			public unsafe EntityID __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700094B RID: 2379
			// (get) Token: 0x0600221E RID: 8734 RVA: 0x00097EE8 File Offset: 0x000960E8
			// (set) Token: 0x0600221F RID: 8735 RVA: 0x0000E99A File Offset: 0x0000CB9A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700094C RID: 2380
			// (get) Token: 0x06002220 RID: 8736 RVA: 0x00097F10 File Offset: 0x00096110
			// (set) Token: 0x06002221 RID: 8737 RVA: 0x0000E9B5 File Offset: 0x0000CBB5
			public unsafe KnapsackEntityListTargetNode __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KnapsackEntityListTargetNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700094D RID: 2381
			// (get) Token: 0x06002222 RID: 8738 RVA: 0x00097F40 File Offset: 0x00096140
			// (set) Token: 0x06002223 RID: 8739 RVA: 0x0000E9D4 File Offset: 0x0000CBD4
			public unsafe bool withSelectedRemoval
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeFieldInfoPtr_withSelectedRemoval);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeFieldInfoPtr_withSelectedRemoval)) = value;
				}
			}

			// Token: 0x1700094E RID: 2382
			// (get) Token: 0x06002224 RID: 8740 RVA: 0x00097F68 File Offset: 0x00096168
			// (set) Token: 0x06002225 RID: 8741 RVA: 0x0000E9EF File Offset: 0x0000CBEF
			public unsafe bool __3__withSelectedRemoval
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeFieldInfoPtr___3__withSelectedRemoval);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeFieldInfoPtr___3__withSelectedRemoval)) = value;
				}
			}

			// Token: 0x1700094F RID: 2383
			// (get) Token: 0x06002226 RID: 8742 RVA: 0x00097F90 File Offset: 0x00096190
			// (set) Token: 0x06002227 RID: 8743 RVA: 0x0000EA0A File Offset: 0x0000CC0A
			public unsafe int _remainingDiff_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeFieldInfoPtr__remainingDiff_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeFieldInfoPtr__remainingDiff_5__2)) = value;
				}
			}

			// Token: 0x17000950 RID: 2384
			// (get) Token: 0x06002228 RID: 8744 RVA: 0x00097FB8 File Offset: 0x000961B8
			// (set) Token: 0x06002229 RID: 8745 RVA: 0x0000EA25 File Offset: 0x0000CC25
			public Dictionary<EntityID, int>.Enumerator __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeFieldInfoPtr___7__wrap2);
					return new Dictionary<EntityID, int>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<EntityID, int>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackEntityListTargetNode._EntitiesSatisfyingSelectionMode_d__33.NativeFieldInfoPtr___7__wrap2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<EntityID, int>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001792 RID: 6034
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001793 RID: 6035
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001794 RID: 6036
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001795 RID: 6037
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001796 RID: 6038
			private static readonly IntPtr NativeFieldInfoPtr_withSelectedRemoval;

			// Token: 0x04001797 RID: 6039
			private static readonly IntPtr NativeFieldInfoPtr___3__withSelectedRemoval;

			// Token: 0x04001798 RID: 6040
			private static readonly IntPtr NativeFieldInfoPtr__remainingDiff_5__2;

			// Token: 0x04001799 RID: 6041
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x0400179A RID: 6042
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400179B RID: 6043
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400179C RID: 6044
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400179D RID: 6045
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400179E RID: 6046
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x0400179F RID: 6047
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x040017A0 RID: 6048
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally4_Private_Void_0;

			// Token: 0x040017A1 RID: 6049
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_utils_ids_EntityID__get_Current_Private_Virtual_Final_New_get_EntityID_0;

			// Token: 0x040017A2 RID: 6050
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017A3 RID: 6051
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040017A4 RID: 6052
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_utils_ids_EntityID__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_EntityID_0;

			// Token: 0x040017A5 RID: 6053
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
