using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.match.selection
{
	// Token: 0x02000144 RID: 324
	public class MultipleSelectionWithTargetsNode : RootSelection
	{
		// Token: 0x06001206 RID: 4614 RVA: 0x0005BBBC File Offset: 0x00059DBC
		// Note: this type is marked as 'beforefieldinit'.
		static MultipleSelectionWithTargetsNode()
		{
			Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "MultipleSelectionWithTargetsNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr);
			MultipleSelectionWithTargetsNode.NativeFieldInfoPtr_SelectedEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr, "SelectedEntity");
			MultipleSelectionWithTargetsNode.NativeFieldInfoPtr_available = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr, "available");
			MultipleSelectionWithTargetsNode.NativeFieldInfoPtr_previous = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr, "previous");
			MultipleSelectionWithTargetsNode.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr, "message");
			MultipleSelectionWithTargetsNode.NativeFieldInfoPtr_targetSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr, "targetSelections");
			MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_get_CommitedSelections_Public_get_IDictionary_2_EntityID_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr, 100665949);
			MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_get_finishedSelections_Private_get_IEnumerable_1_MultipleTargetInformationNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr, 100665950);
			MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_get_pendingSelections_Private_get_IEnumerable_1_MultipleTargetInformationNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr, 100665951);
			MultipleSelectionWithTargetsNode.NativeMethodInfoPtr__ctor_Public_Void_MultipleSelectionWithTargetsRequired_ISelectionNodeFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr, 100665952);
			MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr, 100665953);
			MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_get_MayCancel_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr, 100665954);
			MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr, 100665955);
			MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_getResponseMessage_Protected_Virtual_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr, 100665956);
			MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr, 100665957);
			MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr, 100665958);
			MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_get_AvailableSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr, 100665959);
			MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_get_PreviousSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr, 100665960);
			MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_get_ForcedSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr, 100665961);
			MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr, 100665962);
			MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr, 100665963);
			MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_get_MaxToSelect_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr, 100665964);
			MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_get_MinToSelect_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr, 100665965);
			MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr, 100665966);
			MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr, 100665967);
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06001207 RID: 4615 RVA: 0x0005BDCC File Offset: 0x00059FCC
		public unsafe IDictionary<EntityID, IList<EntityID>> CommitedSelections
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871144, XrefRangeEnd = 871177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_get_CommitedSelections_Public_get_IDictionary_2_EntityID_IList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<EntityID, IList<EntityID>>>(intPtr3) : null;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001208 RID: 4616 RVA: 0x0005BE0C File Offset: 0x0005A00C
		public unsafe IEnumerable<MultipleTargetInformationNode> finishedSelections
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 871182, RefRangeEnd = 871185, XrefRangeStart = 871177, XrefRangeEnd = 871182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_get_finishedSelections_Private_get_IEnumerable_1_MultipleTargetInformationNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<MultipleTargetInformationNode>>(intPtr3) : null;
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x0005BE4C File Offset: 0x0005A04C
		public unsafe IEnumerable<MultipleTargetInformationNode> pendingSelections
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871185, XrefRangeEnd = 871190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_get_pendingSelections_Private_get_IEnumerable_1_MultipleTargetInformationNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<MultipleTargetInformationNode>>(intPtr3) : null;
			}
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x0005BE8C File Offset: 0x0005A08C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 871239, RefRangeEnd = 871240, XrefRangeStart = 871190, XrefRangeEnd = 871239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultipleSelectionWithTargetsNode(MultipleSelectionWithTargetsRequired message, ISelectionNodeFactory factory)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(factory);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode.NativeMethodInfoPtr__ctor_Public_Void_MultipleSelectionWithTargetsRequired_ISelectionNodeFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x0600120B RID: 4619 RVA: 0x0005BEEC File Offset: 0x0005A0EC
		public unsafe override bool MayAdvance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871240, XrefRangeEnd = 871249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x0600120C RID: 4620 RVA: 0x0005BF34 File Offset: 0x0005A134
		public unsafe override bool MayCancel
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_get_MayCancel_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x0005BF7C File Offset: 0x0005A17C
		public unsafe virtual bool Forced
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x0005BFB8 File Offset: 0x0005A1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871249, XrefRangeEnd = 871289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object getResponseMessage(bool cancelled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cancelled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_getResponseMessage_Protected_Virtual_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x0005C010 File Offset: 0x0005A210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871289, XrefRangeEnd = 871296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ISelectionNode NodeToAdvanceTo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x0005C05C File Offset: 0x0005A25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871296, XrefRangeEnd = 871300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISelectionNode PeekNode(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x0005C0AC File Offset: 0x0005A2AC
		public unsafe virtual IList<EntityID> AvailableSelections
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 871332, RefRangeEnd = 871333, XrefRangeStart = 871300, XrefRangeEnd = 871332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_get_AvailableSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06001212 RID: 4626 RVA: 0x0005C0EC File Offset: 0x0005A2EC
		public unsafe virtual IList<EntityID> PreviousSelections
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 871363, RefRangeEnd = 871365, XrefRangeStart = 871333, XrefRangeEnd = 871363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_get_PreviousSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x0005C12C File Offset: 0x0005A32C
		public unsafe virtual IList<EntityID> ForcedSelections
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_get_ForcedSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x0005C16C File Offset: 0x0005A36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871365, XrefRangeEnd = 871377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Select(EntityID entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x0005C1B0 File Offset: 0x0005A3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871377, XrefRangeEnd = 871396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unselect(EntityID entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06001216 RID: 4630 RVA: 0x0005C1F4 File Offset: 0x0005A3F4
		public unsafe virtual int MaxToSelect
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_get_MaxToSelect_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x0005C230 File Offset: 0x0005A430
		public unsafe virtual int MinToSelect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_get_MinToSelect_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06001218 RID: 4632 RVA: 0x0005C26C File Offset: 0x0005A46C
		public unsafe override bool HasClearableState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871396, XrefRangeEnd = 871400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x0005C2B4 File Offset: 0x0005A4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871400, XrefRangeEnd = 871401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleSelectionWithTargetsNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x000082F4 File Offset: 0x000064F4
		public MultipleSelectionWithTargetsNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x0005C2F0 File Offset: 0x0005A4F0
		// (set) Token: 0x0600121C RID: 4636 RVA: 0x000082FD File Offset: 0x000064FD
		public unsafe EntityID SelectedEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode.NativeFieldInfoPtr_SelectedEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode.NativeFieldInfoPtr_SelectedEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x0600121D RID: 4637 RVA: 0x0005C320 File Offset: 0x0005A520
		// (set) Token: 0x0600121E RID: 4638 RVA: 0x0000831C File Offset: 0x0000651C
		public unsafe IList<EntityID> available
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode.NativeFieldInfoPtr_available);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode.NativeFieldInfoPtr_available), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x0600121F RID: 4639 RVA: 0x0005C350 File Offset: 0x0005A550
		// (set) Token: 0x06001220 RID: 4640 RVA: 0x0000833B File Offset: 0x0000653B
		public unsafe IList<EntityID> previous
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode.NativeFieldInfoPtr_previous);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode.NativeFieldInfoPtr_previous), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06001221 RID: 4641 RVA: 0x0005C380 File Offset: 0x0005A580
		// (set) Token: 0x06001222 RID: 4642 RVA: 0x0000835A File Offset: 0x0000655A
		public new unsafe MultipleSelectionWithTargetsRequired message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultipleSelectionWithTargetsRequired>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06001223 RID: 4643 RVA: 0x0005C3B0 File Offset: 0x0005A5B0
		// (set) Token: 0x06001224 RID: 4644 RVA: 0x00008379 File Offset: 0x00006579
		public unsafe Dictionary<EntityID, MultipleTargetInformationNode> targetSelections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode.NativeFieldInfoPtr_targetSelections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, MultipleTargetInformationNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode.NativeFieldInfoPtr_targetSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeFieldInfoPtr_SelectedEntity;

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeFieldInfoPtr_available;

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeFieldInfoPtr_previous;

		// Token: 0x04000CD6 RID: 3286
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x04000CD7 RID: 3287
		private static readonly IntPtr NativeFieldInfoPtr_targetSelections;

		// Token: 0x04000CD8 RID: 3288
		private static readonly IntPtr NativeMethodInfoPtr_get_CommitedSelections_Public_get_IDictionary_2_EntityID_IList_1_EntityID_0;

		// Token: 0x04000CD9 RID: 3289
		private static readonly IntPtr NativeMethodInfoPtr_get_finishedSelections_Private_get_IEnumerable_1_MultipleTargetInformationNode_0;

		// Token: 0x04000CDA RID: 3290
		private static readonly IntPtr NativeMethodInfoPtr_get_pendingSelections_Private_get_IEnumerable_1_MultipleTargetInformationNode_0;

		// Token: 0x04000CDB RID: 3291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MultipleSelectionWithTargetsRequired_ISelectionNodeFactory_0;

		// Token: 0x04000CDC RID: 3292
		private static readonly IntPtr NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0;

		// Token: 0x04000CDD RID: 3293
		private static readonly IntPtr NativeMethodInfoPtr_get_MayCancel_Public_Virtual_get_Boolean_0;

		// Token: 0x04000CDE RID: 3294
		private static readonly IntPtr NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000CDF RID: 3295
		private static readonly IntPtr NativeMethodInfoPtr_getResponseMessage_Protected_Virtual_Object_Boolean_0;

		// Token: 0x04000CE0 RID: 3296
		private static readonly IntPtr NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0;

		// Token: 0x04000CE1 RID: 3297
		private static readonly IntPtr NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_EntityID_0;

		// Token: 0x04000CE2 RID: 3298
		private static readonly IntPtr NativeMethodInfoPtr_get_AvailableSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0;

		// Token: 0x04000CE3 RID: 3299
		private static readonly IntPtr NativeMethodInfoPtr_get_PreviousSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0;

		// Token: 0x04000CE4 RID: 3300
		private static readonly IntPtr NativeMethodInfoPtr_get_ForcedSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0;

		// Token: 0x04000CE5 RID: 3301
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_EntityID_0;

		// Token: 0x04000CE6 RID: 3302
		private static readonly IntPtr NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_EntityID_0;

		// Token: 0x04000CE7 RID: 3303
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxToSelect_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000CE8 RID: 3304
		private static readonly IntPtr NativeMethodInfoPtr_get_MinToSelect_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000CE9 RID: 3305
		private static readonly IntPtr NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0;

		// Token: 0x04000CEA RID: 3306
		private static readonly IntPtr NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0;

		// Token: 0x020002D1 RID: 721
		[ObfuscatedName("dwd.core.match.selection.MultipleSelectionWithTargetsNode+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002177 RID: 8567 RVA: 0x00095D04 File Offset: 0x00093F04
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MultipleSelectionWithTargetsNode.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode.__c>.NativeClassPtr);
				MultipleSelectionWithTargetsNode.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode.__c>.NativeClassPtr, "<>9");
				MultipleSelectionWithTargetsNode.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode.__c>.NativeClassPtr, "<>9__6_0");
				MultipleSelectionWithTargetsNode.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode.__c>.NativeClassPtr, "<>9__6_1");
				MultipleSelectionWithTargetsNode.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode.__c>.NativeClassPtr, 100665969);
				MultipleSelectionWithTargetsNode.__c.NativeMethodInfoPtr__get_CommitedSelections_b__6_0_Internal_EntityID_MultipleTargetInformationNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode.__c>.NativeClassPtr, 100665970);
				MultipleSelectionWithTargetsNode.__c.NativeMethodInfoPtr__get_CommitedSelections_b__6_1_Internal_IList_1_EntityID_MultipleTargetInformationNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode.__c>.NativeClassPtr, 100665971);
			}

			// Token: 0x06002178 RID: 8568 RVA: 0x00095DA8 File Offset: 0x00093FA8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002179 RID: 8569 RVA: 0x00095DE4 File Offset: 0x00093FE4
			[CallerCount(0)]
			public unsafe EntityID _get_CommitedSelections_b__6_0(MultipleTargetInformationNode x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode.__c.NativeMethodInfoPtr__get_CommitedSelections_b__6_0_Internal_EntityID_MultipleTargetInformationNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x0600217A RID: 8570 RVA: 0x00095E34 File Offset: 0x00094034
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871073, XrefRangeEnd = 871080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IList<EntityID> _get_CommitedSelections_b__6_1(MultipleTargetInformationNode y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode.__c.NativeMethodInfoPtr__get_CommitedSelections_b__6_1_Internal_IList_1_EntityID_MultipleTargetInformationNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
				}
			}

			// Token: 0x0600217B RID: 8571 RVA: 0x0000E568 File Offset: 0x0000C768
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000922 RID: 2338
			// (get) Token: 0x0600217C RID: 8572 RVA: 0x00095E84 File Offset: 0x00094084
			// (set) Token: 0x0600217D RID: 8573 RVA: 0x0000E571 File Offset: 0x0000C771
			public unsafe static MultipleSelectionWithTargetsNode.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MultipleSelectionWithTargetsNode.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultipleSelectionWithTargetsNode.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MultipleSelectionWithTargetsNode.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000923 RID: 2339
			// (get) Token: 0x0600217E RID: 8574 RVA: 0x00095EAC File Offset: 0x000940AC
			// (set) Token: 0x0600217F RID: 8575 RVA: 0x0000E583 File Offset: 0x0000C783
			public unsafe static Func<MultipleTargetInformationNode, EntityID> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MultipleSelectionWithTargetsNode.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MultipleTargetInformationNode, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MultipleSelectionWithTargetsNode.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000924 RID: 2340
			// (get) Token: 0x06002180 RID: 8576 RVA: 0x00095ED4 File Offset: 0x000940D4
			// (set) Token: 0x06002181 RID: 8577 RVA: 0x0000E595 File Offset: 0x0000C795
			public unsafe static Func<MultipleTargetInformationNode, IList<EntityID>> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MultipleSelectionWithTargetsNode.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MultipleTargetInformationNode, IList<EntityID>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MultipleSelectionWithTargetsNode.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400173B RID: 5947
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400173C RID: 5948
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400173D RID: 5949
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x0400173E RID: 5950
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400173F RID: 5951
			private static readonly IntPtr NativeMethodInfoPtr__get_CommitedSelections_b__6_0_Internal_EntityID_MultipleTargetInformationNode_0;

			// Token: 0x04001740 RID: 5952
			private static readonly IntPtr NativeMethodInfoPtr__get_CommitedSelections_b__6_1_Internal_IList_1_EntityID_MultipleTargetInformationNode_0;
		}

		// Token: 0x020002D2 RID: 722
		[ObfuscatedName("dwd.core.match.selection.MultipleSelectionWithTargetsNode+<get_finishedSelections>d__8")]
		public sealed class _get_finishedSelections_d__8 : Object
		{
			// Token: 0x06002182 RID: 8578 RVA: 0x00095EFC File Offset: 0x000940FC
			// Note: this type is marked as 'beforefieldinit'.
			static _get_finishedSelections_d__8()
			{
				Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_finishedSelections_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr, "<get_finishedSelections>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_finishedSelections_d__8>.NativeClassPtr);
				MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_finishedSelections_d__8>.NativeClassPtr, "<>1__state");
				MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_finishedSelections_d__8>.NativeClassPtr, "<>2__current");
				MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_finishedSelections_d__8>.NativeClassPtr, "<>l__initialThreadId");
				MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_finishedSelections_d__8>.NativeClassPtr, "<>4__this");
				MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_finishedSelections_d__8>.NativeClassPtr, "<>7__wrap1");
				MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_finishedSelections_d__8>.NativeClassPtr, 100665972);
				MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_finishedSelections_d__8>.NativeClassPtr, 100665973);
				MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_finishedSelections_d__8>.NativeClassPtr, 100665974);
				MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_finishedSelections_d__8>.NativeClassPtr, 100665975);
				MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_core_match_selection_MultipleTargetInformationNode__get_Current_Private_Virtual_Final_New_get_MultipleTargetInformationNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_finishedSelections_d__8>.NativeClassPtr, 100665976);
				MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_finishedSelections_d__8>.NativeClassPtr, 100665977);
				MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_finishedSelections_d__8>.NativeClassPtr, 100665978);
				MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_match_selection_MultipleTargetInformationNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_MultipleTargetInformationNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_finishedSelections_d__8>.NativeClassPtr, 100665979);
				MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_finishedSelections_d__8>.NativeClassPtr, 100665980);
			}

			// Token: 0x06002183 RID: 8579 RVA: 0x00096040 File Offset: 0x00094240
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_finishedSelections_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_finishedSelections_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002184 RID: 8580 RVA: 0x00096088 File Offset: 0x00094288
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871080, XrefRangeEnd = 871085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002185 RID: 8581 RVA: 0x000960BC File Offset: 0x000942BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871085, XrefRangeEnd = 871102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002186 RID: 8582 RVA: 0x000960F8 File Offset: 0x000942F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871102, XrefRangeEnd = 871105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700092A RID: 2346
			// (get) Token: 0x06002187 RID: 8583 RVA: 0x0009612C File Offset: 0x0009432C
			public unsafe MultipleTargetInformationNode System.Collections.Generic.IEnumerator<dwd.core.match.selection.MultipleTargetInformationNode>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_core_match_selection_MultipleTargetInformationNode__get_Current_Private_Virtual_Final_New_get_MultipleTargetInformationNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MultipleTargetInformationNode>(intPtr3) : null;
				}
			}

			// Token: 0x06002188 RID: 8584 RVA: 0x0009616C File Offset: 0x0009436C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871105, XrefRangeEnd = 871110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700092B RID: 2347
			// (get) Token: 0x06002189 RID: 8585 RVA: 0x000961A0 File Offset: 0x000943A0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600218A RID: 8586 RVA: 0x000961E0 File Offset: 0x000943E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871110, XrefRangeEnd = 871112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<MultipleTargetInformationNode> System_Collections_Generic_IEnumerable_dwd_core_match_selection_MultipleTargetInformationNode__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_match_selection_MultipleTargetInformationNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_MultipleTargetInformationNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<MultipleTargetInformationNode>>(intPtr3) : null;
			}

			// Token: 0x0600218B RID: 8587 RVA: 0x00096220 File Offset: 0x00094420
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600218C RID: 8588 RVA: 0x0000E5A7 File Offset: 0x0000C7A7
			public _get_finishedSelections_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000925 RID: 2341
			// (get) Token: 0x0600218D RID: 8589 RVA: 0x00096260 File Offset: 0x00094460
			// (set) Token: 0x0600218E RID: 8590 RVA: 0x0000E5B0 File Offset: 0x0000C7B0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000926 RID: 2342
			// (get) Token: 0x0600218F RID: 8591 RVA: 0x00096288 File Offset: 0x00094488
			// (set) Token: 0x06002190 RID: 8592 RVA: 0x0000E5CB File Offset: 0x0000C7CB
			public unsafe MultipleTargetInformationNode __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultipleTargetInformationNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000927 RID: 2343
			// (get) Token: 0x06002191 RID: 8593 RVA: 0x000962B8 File Offset: 0x000944B8
			// (set) Token: 0x06002192 RID: 8594 RVA: 0x0000E5EA File Offset: 0x0000C7EA
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000928 RID: 2344
			// (get) Token: 0x06002193 RID: 8595 RVA: 0x000962E0 File Offset: 0x000944E0
			// (set) Token: 0x06002194 RID: 8596 RVA: 0x0000E605 File Offset: 0x0000C805
			public unsafe MultipleSelectionWithTargetsNode __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultipleSelectionWithTargetsNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000929 RID: 2345
			// (get) Token: 0x06002195 RID: 8597 RVA: 0x00096310 File Offset: 0x00094510
			// (set) Token: 0x06002196 RID: 8598 RVA: 0x0000E624 File Offset: 0x0000C824
			public Dictionary<EntityID, MultipleTargetInformationNode>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeFieldInfoPtr___7__wrap1);
					return new Dictionary<EntityID, MultipleTargetInformationNode>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<EntityID, MultipleTargetInformationNode>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode._get_finishedSelections_d__8.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<EntityID, MultipleTargetInformationNode>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001741 RID: 5953
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001742 RID: 5954
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001743 RID: 5955
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001744 RID: 5956
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001745 RID: 5957
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001746 RID: 5958
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001747 RID: 5959
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001748 RID: 5960
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001749 RID: 5961
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400174A RID: 5962
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_core_match_selection_MultipleTargetInformationNode__get_Current_Private_Virtual_Final_New_get_MultipleTargetInformationNode_0;

			// Token: 0x0400174B RID: 5963
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400174C RID: 5964
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400174D RID: 5965
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_match_selection_MultipleTargetInformationNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_MultipleTargetInformationNode_0;

			// Token: 0x0400174E RID: 5966
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020002D3 RID: 723
		[ObfuscatedName("dwd.core.match.selection.MultipleSelectionWithTargetsNode+<get_pendingSelections>d__10")]
		public sealed class _get_pendingSelections_d__10 : Object
		{
			// Token: 0x06002197 RID: 8599 RVA: 0x00096340 File Offset: 0x00094540
			// Note: this type is marked as 'beforefieldinit'.
			static _get_pendingSelections_d__10()
			{
				Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_pendingSelections_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode>.NativeClassPtr, "<get_pendingSelections>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_pendingSelections_d__10>.NativeClassPtr);
				MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_pendingSelections_d__10>.NativeClassPtr, "<>1__state");
				MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_pendingSelections_d__10>.NativeClassPtr, "<>2__current");
				MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_pendingSelections_d__10>.NativeClassPtr, "<>l__initialThreadId");
				MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_pendingSelections_d__10>.NativeClassPtr, "<>4__this");
				MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_pendingSelections_d__10>.NativeClassPtr, "<>7__wrap1");
				MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_pendingSelections_d__10>.NativeClassPtr, 100665981);
				MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_pendingSelections_d__10>.NativeClassPtr, 100665982);
				MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_pendingSelections_d__10>.NativeClassPtr, 100665983);
				MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_pendingSelections_d__10>.NativeClassPtr, 100665984);
				MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_core_match_selection_MultipleTargetInformationNode__get_Current_Private_Virtual_Final_New_get_MultipleTargetInformationNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_pendingSelections_d__10>.NativeClassPtr, 100665985);
				MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_pendingSelections_d__10>.NativeClassPtr, 100665986);
				MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_pendingSelections_d__10>.NativeClassPtr, 100665987);
				MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_match_selection_MultipleTargetInformationNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_MultipleTargetInformationNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_pendingSelections_d__10>.NativeClassPtr, 100665988);
				MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_pendingSelections_d__10>.NativeClassPtr, 100665989);
			}

			// Token: 0x06002198 RID: 8600 RVA: 0x00096484 File Offset: 0x00094684
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_pendingSelections_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleSelectionWithTargetsNode._get_pendingSelections_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002199 RID: 8601 RVA: 0x000964CC File Offset: 0x000946CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871112, XrefRangeEnd = 871117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600219A RID: 8602 RVA: 0x00096500 File Offset: 0x00094700
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871117, XrefRangeEnd = 871134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600219B RID: 8603 RVA: 0x0009653C File Offset: 0x0009473C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871134, XrefRangeEnd = 871137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000931 RID: 2353
			// (get) Token: 0x0600219C RID: 8604 RVA: 0x00096570 File Offset: 0x00094770
			public unsafe MultipleTargetInformationNode System.Collections.Generic.IEnumerator<dwd.core.match.selection.MultipleTargetInformationNode>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_core_match_selection_MultipleTargetInformationNode__get_Current_Private_Virtual_Final_New_get_MultipleTargetInformationNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MultipleTargetInformationNode>(intPtr3) : null;
				}
			}

			// Token: 0x0600219D RID: 8605 RVA: 0x000965B0 File Offset: 0x000947B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871137, XrefRangeEnd = 871142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000932 RID: 2354
			// (get) Token: 0x0600219E RID: 8606 RVA: 0x000965E4 File Offset: 0x000947E4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600219F RID: 8607 RVA: 0x00096624 File Offset: 0x00094824
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871142, XrefRangeEnd = 871144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<MultipleTargetInformationNode> System_Collections_Generic_IEnumerable_dwd_core_match_selection_MultipleTargetInformationNode__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_match_selection_MultipleTargetInformationNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_MultipleTargetInformationNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<MultipleTargetInformationNode>>(intPtr3) : null;
			}

			// Token: 0x060021A0 RID: 8608 RVA: 0x00096664 File Offset: 0x00094864
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060021A1 RID: 8609 RVA: 0x0000E652 File Offset: 0x0000C852
			public _get_pendingSelections_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700092C RID: 2348
			// (get) Token: 0x060021A2 RID: 8610 RVA: 0x000966A4 File Offset: 0x000948A4
			// (set) Token: 0x060021A3 RID: 8611 RVA: 0x0000E65B File Offset: 0x0000C85B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700092D RID: 2349
			// (get) Token: 0x060021A4 RID: 8612 RVA: 0x000966CC File Offset: 0x000948CC
			// (set) Token: 0x060021A5 RID: 8613 RVA: 0x0000E676 File Offset: 0x0000C876
			public unsafe MultipleTargetInformationNode __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultipleTargetInformationNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700092E RID: 2350
			// (get) Token: 0x060021A6 RID: 8614 RVA: 0x000966FC File Offset: 0x000948FC
			// (set) Token: 0x060021A7 RID: 8615 RVA: 0x0000E695 File Offset: 0x0000C895
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700092F RID: 2351
			// (get) Token: 0x060021A8 RID: 8616 RVA: 0x00096724 File Offset: 0x00094924
			// (set) Token: 0x060021A9 RID: 8617 RVA: 0x0000E6B0 File Offset: 0x0000C8B0
			public unsafe MultipleSelectionWithTargetsNode __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultipleSelectionWithTargetsNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000930 RID: 2352
			// (get) Token: 0x060021AA RID: 8618 RVA: 0x00096754 File Offset: 0x00094954
			// (set) Token: 0x060021AB RID: 8619 RVA: 0x0000E6CF File Offset: 0x0000C8CF
			public Dictionary<EntityID, MultipleTargetInformationNode>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeFieldInfoPtr___7__wrap1);
					return new Dictionary<EntityID, MultipleTargetInformationNode>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<EntityID, MultipleTargetInformationNode>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargetsNode._get_pendingSelections_d__10.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<EntityID, MultipleTargetInformationNode>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400174F RID: 5967
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001750 RID: 5968
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001751 RID: 5969
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001752 RID: 5970
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001753 RID: 5971
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001754 RID: 5972
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001755 RID: 5973
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001756 RID: 5974
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001757 RID: 5975
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001758 RID: 5976
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_core_match_selection_MultipleTargetInformationNode__get_Current_Private_Virtual_Final_New_get_MultipleTargetInformationNode_0;

			// Token: 0x04001759 RID: 5977
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400175A RID: 5978
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400175B RID: 5979
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_match_selection_MultipleTargetInformationNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_MultipleTargetInformationNode_0;

			// Token: 0x0400175C RID: 5980
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
