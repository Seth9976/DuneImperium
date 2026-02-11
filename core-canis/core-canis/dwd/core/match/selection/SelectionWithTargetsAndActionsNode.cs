using System;
using Canis.utils.ids;
using dwd.core.match.selection.messages.incoming;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection;

namespace dwd.core.match.selection
{
	// Token: 0x02000146 RID: 326
	public class SelectionWithTargetsAndActionsNode : RootSelection
	{
		// Token: 0x0600124A RID: 4682 RVA: 0x0005CD34 File Offset: 0x0005AF34
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionWithTargetsAndActionsNode()
		{
			Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "SelectionWithTargetsAndActionsNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr);
			SelectionWithTargetsAndActionsNode.NativeFieldInfoPtr_none = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, "none");
			SelectionWithTargetsAndActionsNode.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, "selection");
			SelectionWithTargetsAndActionsNode.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, "message");
			SelectionWithTargetsAndActionsNode.NativeFieldInfoPtr_SelectionsMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, "SelectionsMap");
			SelectionWithTargetsAndActionsNode.NativeFieldInfoPtr_available = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, "available");
			SelectionWithTargetsAndActionsNode.NativeFieldInfoPtr_previous = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, "previous");
			SelectionWithTargetsAndActionsNode.NativeFieldInfoPtr_cachedHints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, "cachedHints");
			SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr__ctor_Public_Void_SelectionWithTargetsAndActionsRequired_ISelectionNodeFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, 100666011);
			SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, 100666012);
			SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, 100666013);
			SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_get_MayCancel_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, 100666014);
			SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_get_StackEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, 100666015);
			SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_getResponseMessage_Protected_Virtual_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, 100666016);
			SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, 100666017);
			SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, 100666018);
			SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_get_AvailableSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, 100666019);
			SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_get_PreviousSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, 100666020);
			SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_get_ForcedSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, 100666021);
			SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_get_TargetMap_Public_get_IList_1_TargetsAndActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, 100666022);
			SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, 100666023);
			SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, 100666024);
			SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_get_SingleSelection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, 100666025);
			SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_get_MaxToSelect_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, 100666026);
			SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_get_MinToSelect_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, 100666027);
			SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, 100666028);
			SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, 100666029);
			SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_HintStrength_Public_Virtual_Final_New_TargetStrength_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, 100666030);
			SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_HintStrengths_Public_Virtual_Final_New_List_1_TargetStrength_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, 100666031);
			SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_AllHintStrengths_Public_Virtual_Final_New_Dictionary_2_EntityID_List_1_TargetStrength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr, 100666032);
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x0005CFA8 File Offset: 0x0005B1A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 871576, RefRangeEnd = 871577, XrefRangeStart = 871519, XrefRangeEnd = 871576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionWithTargetsAndActionsNode(SelectionWithTargetsAndActionsRequired message, ISelectionNodeFactory factory)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionWithTargetsAndActionsNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(factory);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr__ctor_Public_Void_SelectionWithTargetsAndActionsRequired_ISelectionNodeFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x0005D008 File Offset: 0x0005B208
		public unsafe virtual bool Forced
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x0600124D RID: 4685 RVA: 0x0005D044 File Offset: 0x0005B244
		public unsafe override bool MayAdvance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871577, XrefRangeEnd = 871578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x0005D08C File Offset: 0x0005B28C
		public unsafe override bool MayCancel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_get_MayCancel_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x0600124F RID: 4687 RVA: 0x0005D0D4 File Offset: 0x0005B2D4
		public unsafe bool StackEmpty
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871578, XrefRangeEnd = 871586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_get_StackEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x0005D110 File Offset: 0x0005B310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871586, XrefRangeEnd = 871599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object getResponseMessage(bool cancelled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cancelled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_getResponseMessage_Protected_Virtual_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x0005D168 File Offset: 0x0005B368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871599, XrefRangeEnd = 871606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ISelectionNode NodeToAdvanceTo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x0005D1B4 File Offset: 0x0005B3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871606, XrefRangeEnd = 871610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISelectionNode PeekNode(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001253 RID: 4691 RVA: 0x0005D204 File Offset: 0x0005B404
		public unsafe virtual IList<EntityID> AvailableSelections
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_get_AvailableSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001254 RID: 4692 RVA: 0x0005D244 File Offset: 0x0005B444
		public unsafe virtual IList<EntityID> PreviousSelections
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_get_PreviousSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06001255 RID: 4693 RVA: 0x0005D284 File Offset: 0x0005B484
		public unsafe virtual IList<EntityID> ForcedSelections
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871610, XrefRangeEnd = 871614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_get_ForcedSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x0005D2C4 File Offset: 0x0005B4C4
		public unsafe IList<SelectionWithTargetsAndActionsRequired.TargetsAndActions> TargetMap
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871614, XrefRangeEnd = 871620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_get_TargetMap_Public_get_IList_1_TargetsAndActions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<SelectionWithTargetsAndActionsRequired.TargetsAndActions>>(intPtr3) : null;
			}
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x0005D304 File Offset: 0x0005B504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871620, XrefRangeEnd = 871627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Select(EntityID entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x0005D348 File Offset: 0x0005B548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871627, XrefRangeEnd = 871644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unselect(EntityID entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x0005D38C File Offset: 0x0005B58C
		public unsafe bool SingleSelection
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_get_SingleSelection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x0600125A RID: 4698 RVA: 0x0005D3C8 File Offset: 0x0005B5C8
		public unsafe virtual int MaxToSelect
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_get_MaxToSelect_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x0600125B RID: 4699 RVA: 0x0005D404 File Offset: 0x0005B604
		public unsafe virtual int MinToSelect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_get_MinToSelect_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x0600125C RID: 4700 RVA: 0x0005D440 File Offset: 0x0005B640
		public unsafe override bool HasClearableState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871644, XrefRangeEnd = 871648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x0005D488 File Offset: 0x0005B688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871648, XrefRangeEnd = 871672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x0005D4C4 File Offset: 0x0005B6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871672, XrefRangeEnd = 871680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TargetStrength HintStrength(EntityID entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_HintStrength_Public_Virtual_Final_New_TargetStrength_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x0005D514 File Offset: 0x0005B714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871680, XrefRangeEnd = 871703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<TargetStrength> HintStrengths(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_HintStrengths_Public_Virtual_Final_New_List_1_TargetStrength_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TargetStrength>>(intPtr3) : null;
			}
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x0005D564 File Offset: 0x0005B764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871703, XrefRangeEnd = 871738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Dictionary<EntityID, List<TargetStrength>> AllHintStrengths()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsAndActionsNode.NativeMethodInfoPtr_AllHintStrengths_Public_Virtual_Final_New_Dictionary_2_EntityID_List_1_TargetStrength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, List<TargetStrength>>>(intPtr3) : null;
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x00008476 File Offset: 0x00006676
		public SelectionWithTargetsAndActionsNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001262 RID: 4706 RVA: 0x0005D5A4 File Offset: 0x0005B7A4
		// (set) Token: 0x06001263 RID: 4707 RVA: 0x0000847F File Offset: 0x0000667F
		public unsafe static IList<EntityID> none
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SelectionWithTargetsAndActionsNode.NativeFieldInfoPtr_none, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SelectionWithTargetsAndActionsNode.NativeFieldInfoPtr_none, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001264 RID: 4708 RVA: 0x0005D5CC File Offset: 0x0005B7CC
		// (set) Token: 0x06001265 RID: 4709 RVA: 0x00008491 File Offset: 0x00006691
		public unsafe EntityID selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsNode.NativeFieldInfoPtr_selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsNode.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001266 RID: 4710 RVA: 0x0005D5FC File Offset: 0x0005B7FC
		// (set) Token: 0x06001267 RID: 4711 RVA: 0x000084B0 File Offset: 0x000066B0
		public new unsafe SelectionWithTargetsAndActionsRequired message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsNode.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionWithTargetsAndActionsRequired>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsNode.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001268 RID: 4712 RVA: 0x0005D62C File Offset: 0x0005B82C
		// (set) Token: 0x06001269 RID: 4713 RVA: 0x000084CF File Offset: 0x000066CF
		public unsafe Dictionary<EntityID, IActionSelection> SelectionsMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsNode.NativeFieldInfoPtr_SelectionsMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, IActionSelection>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsNode.NativeFieldInfoPtr_SelectionsMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x0600126A RID: 4714 RVA: 0x0005D65C File Offset: 0x0005B85C
		// (set) Token: 0x0600126B RID: 4715 RVA: 0x000084EE File Offset: 0x000066EE
		public unsafe IList<EntityID> available
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsNode.NativeFieldInfoPtr_available);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsNode.NativeFieldInfoPtr_available), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x0005D68C File Offset: 0x0005B88C
		// (set) Token: 0x0600126D RID: 4717 RVA: 0x0000850D File Offset: 0x0000670D
		public unsafe IList<EntityID> previous
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsNode.NativeFieldInfoPtr_previous);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsNode.NativeFieldInfoPtr_previous), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x0600126E RID: 4718 RVA: 0x0005D6BC File Offset: 0x0005B8BC
		// (set) Token: 0x0600126F RID: 4719 RVA: 0x0000852C File Offset: 0x0000672C
		public unsafe Dictionary<EntityID, List<TargetStrength>> cachedHints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsNode.NativeFieldInfoPtr_cachedHints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, List<TargetStrength>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsNode.NativeFieldInfoPtr_cachedHints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D07 RID: 3335
		private static readonly IntPtr NativeFieldInfoPtr_none;

		// Token: 0x04000D08 RID: 3336
		private static readonly IntPtr NativeFieldInfoPtr_selection;

		// Token: 0x04000D09 RID: 3337
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x04000D0A RID: 3338
		private static readonly IntPtr NativeFieldInfoPtr_SelectionsMap;

		// Token: 0x04000D0B RID: 3339
		private static readonly IntPtr NativeFieldInfoPtr_available;

		// Token: 0x04000D0C RID: 3340
		private static readonly IntPtr NativeFieldInfoPtr_previous;

		// Token: 0x04000D0D RID: 3341
		private static readonly IntPtr NativeFieldInfoPtr_cachedHints;

		// Token: 0x04000D0E RID: 3342
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SelectionWithTargetsAndActionsRequired_ISelectionNodeFactory_0;

		// Token: 0x04000D0F RID: 3343
		private static readonly IntPtr NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000D10 RID: 3344
		private static readonly IntPtr NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0;

		// Token: 0x04000D11 RID: 3345
		private static readonly IntPtr NativeMethodInfoPtr_get_MayCancel_Public_Virtual_get_Boolean_0;

		// Token: 0x04000D12 RID: 3346
		private static readonly IntPtr NativeMethodInfoPtr_get_StackEmpty_Public_get_Boolean_0;

		// Token: 0x04000D13 RID: 3347
		private static readonly IntPtr NativeMethodInfoPtr_getResponseMessage_Protected_Virtual_Object_Boolean_0;

		// Token: 0x04000D14 RID: 3348
		private static readonly IntPtr NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0;

		// Token: 0x04000D15 RID: 3349
		private static readonly IntPtr NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_EntityID_0;

		// Token: 0x04000D16 RID: 3350
		private static readonly IntPtr NativeMethodInfoPtr_get_AvailableSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0;

		// Token: 0x04000D17 RID: 3351
		private static readonly IntPtr NativeMethodInfoPtr_get_PreviousSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0;

		// Token: 0x04000D18 RID: 3352
		private static readonly IntPtr NativeMethodInfoPtr_get_ForcedSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0;

		// Token: 0x04000D19 RID: 3353
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetMap_Public_get_IList_1_TargetsAndActions_0;

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_EntityID_0;

		// Token: 0x04000D1B RID: 3355
		private static readonly IntPtr NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_EntityID_0;

		// Token: 0x04000D1C RID: 3356
		private static readonly IntPtr NativeMethodInfoPtr_get_SingleSelection_Public_get_Boolean_0;

		// Token: 0x04000D1D RID: 3357
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxToSelect_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000D1E RID: 3358
		private static readonly IntPtr NativeMethodInfoPtr_get_MinToSelect_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000D1F RID: 3359
		private static readonly IntPtr NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0;

		// Token: 0x04000D20 RID: 3360
		private static readonly IntPtr NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0;

		// Token: 0x04000D21 RID: 3361
		private static readonly IntPtr NativeMethodInfoPtr_HintStrength_Public_Virtual_Final_New_TargetStrength_EntityID_0;

		// Token: 0x04000D22 RID: 3362
		private static readonly IntPtr NativeMethodInfoPtr_HintStrengths_Public_Virtual_Final_New_List_1_TargetStrength_EntityID_0;

		// Token: 0x04000D23 RID: 3363
		private static readonly IntPtr NativeMethodInfoPtr_AllHintStrengths_Public_Virtual_Final_New_Dictionary_2_EntityID_List_1_TargetStrength_0;
	}
}
