using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection;
using Networking.selection.messages;
using Networking.selection.targetinformation;

namespace dwd.core.match.selection
{
	// Token: 0x02000147 RID: 327
	public class SelectionWithTargetsNode : RootSelection
	{
		// Token: 0x06001270 RID: 4720 RVA: 0x0005D6EC File Offset: 0x0005B8EC
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionWithTargetsNode()
		{
			Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "SelectionWithTargetsNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr);
			SelectionWithTargetsNode.NativeFieldInfoPtr_none = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, "none");
			SelectionWithTargetsNode.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, "message");
			SelectionWithTargetsNode.NativeFieldInfoPtr_selectionMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, "selectionMap");
			SelectionWithTargetsNode.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, "selection");
			SelectionWithTargetsNode.NativeFieldInfoPtr_available = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, "available");
			SelectionWithTargetsNode.NativeFieldInfoPtr_previous = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, "previous");
			SelectionWithTargetsNode.NativeFieldInfoPtr_cachedHints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, "cachedHints");
			SelectionWithTargetsNode.NativeMethodInfoPtr__ctor_Public_Void_SelectionWithTargetsRequired_ISelectionNodeFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, 100666034);
			SelectionWithTargetsNode.NativeMethodInfoPtr_get_SourceID_Public_get_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, 100666035);
			SelectionWithTargetsNode.NativeMethodInfoPtr_get_IgnoreFirst_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, 100666036);
			SelectionWithTargetsNode.NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, 100666037);
			SelectionWithTargetsNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, 100666038);
			SelectionWithTargetsNode.NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, 100666039);
			SelectionWithTargetsNode.NativeMethodInfoPtr_get_Params_Public_get_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, 100666040);
			SelectionWithTargetsNode.NativeMethodInfoPtr_SelectionKey_Public_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, 100666041);
			SelectionWithTargetsNode.NativeMethodInfoPtr_get_AllSelectionsInMap_Public_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, 100666042);
			SelectionWithTargetsNode.NativeMethodInfoPtr_get_AvailableSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, 100666043);
			SelectionWithTargetsNode.NativeMethodInfoPtr_get_PreviousSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, 100666044);
			SelectionWithTargetsNode.NativeMethodInfoPtr_get_ForcedSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, 100666045);
			SelectionWithTargetsNode.NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, 100666046);
			SelectionWithTargetsNode.NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, 100666047);
			SelectionWithTargetsNode.NativeMethodInfoPtr_get_MayCancel_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, 100666048);
			SelectionWithTargetsNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, 100666049);
			SelectionWithTargetsNode.NativeMethodInfoPtr_get_MaxToSelect_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, 100666050);
			SelectionWithTargetsNode.NativeMethodInfoPtr_get_MinToSelect_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, 100666051);
			SelectionWithTargetsNode.NativeMethodInfoPtr_HintStrength_Public_Virtual_Final_New_TargetStrength_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, 100666052);
			SelectionWithTargetsNode.NativeMethodInfoPtr_HintStrengths_Public_Virtual_Final_New_List_1_TargetStrength_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, 100666053);
			SelectionWithTargetsNode.NativeMethodInfoPtr_AllHintStrengths_Public_Virtual_Final_New_Dictionary_2_EntityID_List_1_TargetStrength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, 100666054);
			SelectionWithTargetsNode.NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, 100666055);
			SelectionWithTargetsNode.NativeMethodInfoPtr_getResponseMessage_Protected_Virtual_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, 100666056);
			SelectionWithTargetsNode.NativeMethodInfoPtr_enter_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, 100666057);
			SelectionWithTargetsNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, 100666058);
			SelectionWithTargetsNode.NativeMethodInfoPtr_GetKind_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, 100666059);
			SelectionWithTargetsNode.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, 100666060);
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x0005D9C4 File Offset: 0x0005BBC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 871823, RefRangeEnd = 871824, XrefRangeStart = 871739, XrefRangeEnd = 871823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionWithTargetsNode(SelectionWithTargetsRequired message, ISelectionNodeFactory factory)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(factory);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsNode.NativeMethodInfoPtr__ctor_Public_Void_SelectionWithTargetsRequired_ISelectionNodeFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001272 RID: 4722 RVA: 0x0005DA24 File Offset: 0x0005BC24
		public unsafe EntityID SourceID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsNode.NativeMethodInfoPtr_get_SourceID_Public_get_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06001273 RID: 4723 RVA: 0x0005DA64 File Offset: 0x0005BC64
		public unsafe virtual bool IgnoreFirst
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsNode.NativeMethodInfoPtr_get_IgnoreFirst_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06001274 RID: 4724 RVA: 0x0005DAA0 File Offset: 0x0005BCA0
		public unsafe virtual bool Forced
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsNode.NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06001275 RID: 4725 RVA: 0x0005DADC File Offset: 0x0005BCDC
		public unsafe override bool HasClearableState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871824, XrefRangeEnd = 871828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionWithTargetsNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001276 RID: 4726 RVA: 0x0005DB24 File Offset: 0x0005BD24
		public unsafe override bool MayAdvance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871828, XrefRangeEnd = 871829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionWithTargetsNode.NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001277 RID: 4727 RVA: 0x0005DB6C File Offset: 0x0005BD6C
		public unsafe Dictionary<string, Object> Params
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsNode.NativeMethodInfoPtr_get_Params_Public_get_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x0005DBAC File Offset: 0x0005BDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871829, XrefRangeEnd = 871836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityID SelectionKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsNode.NativeMethodInfoPtr_SelectionKey_Public_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001279 RID: 4729 RVA: 0x0005DBEC File Offset: 0x0005BDEC
		public unsafe IList<EntityID> AllSelectionsInMap
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 871857, RefRangeEnd = 871860, XrefRangeStart = 871836, XrefRangeEnd = 871857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsNode.NativeMethodInfoPtr_get_AllSelectionsInMap_Public_get_IList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x0600127A RID: 4730 RVA: 0x0005DC2C File Offset: 0x0005BE2C
		public unsafe virtual IList<EntityID> AvailableSelections
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 871887, RefRangeEnd = 871890, XrefRangeStart = 871860, XrefRangeEnd = 871887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsNode.NativeMethodInfoPtr_get_AvailableSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x0600127B RID: 4731 RVA: 0x0005DC6C File Offset: 0x0005BE6C
		public unsafe virtual IList<EntityID> PreviousSelections
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871890, XrefRangeEnd = 871899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsNode.NativeMethodInfoPtr_get_PreviousSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x0600127C RID: 4732 RVA: 0x0005DCAC File Offset: 0x0005BEAC
		public unsafe virtual IList<EntityID> ForcedSelections
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871899, XrefRangeEnd = 871903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsNode.NativeMethodInfoPtr_get_ForcedSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x0005DCEC File Offset: 0x0005BEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871903, XrefRangeEnd = 871914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Select(EntityID entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsNode.NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x0005DD30 File Offset: 0x0005BF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871914, XrefRangeEnd = 871932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unselect(EntityID entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsNode.NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x0600127F RID: 4735 RVA: 0x0005DD74 File Offset: 0x0005BF74
		public unsafe override bool MayCancel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionWithTargetsNode.NativeMethodInfoPtr_get_MayCancel_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x0005DDBC File Offset: 0x0005BFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871932, XrefRangeEnd = 871939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ISelectionNode NodeToAdvanceTo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionWithTargetsNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06001281 RID: 4737 RVA: 0x0005DE08 File Offset: 0x0005C008
		public unsafe virtual int MaxToSelect
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsNode.NativeMethodInfoPtr_get_MaxToSelect_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001282 RID: 4738 RVA: 0x0005DE44 File Offset: 0x0005C044
		public unsafe virtual int MinToSelect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsNode.NativeMethodInfoPtr_get_MinToSelect_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x0005DE80 File Offset: 0x0005C080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871939, XrefRangeEnd = 871947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TargetStrength HintStrength(EntityID entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsNode.NativeMethodInfoPtr_HintStrength_Public_Virtual_Final_New_TargetStrength_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x0005DED0 File Offset: 0x0005C0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871947, XrefRangeEnd = 871970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<TargetStrength> HintStrengths(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsNode.NativeMethodInfoPtr_HintStrengths_Public_Virtual_Final_New_List_1_TargetStrength_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TargetStrength>>(intPtr3) : null;
			}
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x0005DF20 File Offset: 0x0005C120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871970, XrefRangeEnd = 872005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Dictionary<EntityID, List<TargetStrength>> AllHintStrengths()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsNode.NativeMethodInfoPtr_AllHintStrengths_Public_Virtual_Final_New_Dictionary_2_EntityID_List_1_TargetStrength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, List<TargetStrength>>>(intPtr3) : null;
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x0005DF60 File Offset: 0x0005C160
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 872009, RefRangeEnd = 872013, XrefRangeStart = 872005, XrefRangeEnd = 872009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISelectionNode PeekNode(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsNode.NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x0005DFB0 File Offset: 0x0005C1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872013, XrefRangeEnd = 872018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object getResponseMessage(bool cancelled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cancelled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionWithTargetsNode.NativeMethodInfoPtr_getResponseMessage_Protected_Virtual_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x0005E008 File Offset: 0x0005C208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872018, XrefRangeEnd = 872021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void enter(bool fromCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromCancel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionWithTargetsNode.NativeMethodInfoPtr_enter_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x0005E054 File Offset: 0x0005C254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionWithTargetsNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x0005E090 File Offset: 0x0005C290
		[CallerCount(0)]
		public unsafe override string GetKind()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionWithTargetsNode.NativeMethodInfoPtr_GetKind_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x0005E0D4 File Offset: 0x0005C2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872021, XrefRangeEnd = 872030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionWithTargetsNode.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x0000854B File Offset: 0x0000674B
		public SelectionWithTargetsNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x0005E118 File Offset: 0x0005C318
		// (set) Token: 0x0600128E RID: 4750 RVA: 0x00008554 File Offset: 0x00006754
		public unsafe static IList<EntityID> none
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SelectionWithTargetsNode.NativeFieldInfoPtr_none, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SelectionWithTargetsNode.NativeFieldInfoPtr_none, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x0005E140 File Offset: 0x0005C340
		// (set) Token: 0x06001290 RID: 4752 RVA: 0x00008566 File Offset: 0x00006766
		public new unsafe SelectionWithTargetsRequired message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsNode.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionWithTargetsRequired>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsNode.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x0005E170 File Offset: 0x0005C370
		// (set) Token: 0x06001292 RID: 4754 RVA: 0x00008585 File Offset: 0x00006785
		public unsafe Dictionary<EntityID, TargetInfoNode> selectionMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsNode.NativeFieldInfoPtr_selectionMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, TargetInfoNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsNode.NativeFieldInfoPtr_selectionMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x0005E1A0 File Offset: 0x0005C3A0
		// (set) Token: 0x06001294 RID: 4756 RVA: 0x000085A4 File Offset: 0x000067A4
		public unsafe EntityID selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsNode.NativeFieldInfoPtr_selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsNode.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001295 RID: 4757 RVA: 0x0005E1D0 File Offset: 0x0005C3D0
		// (set) Token: 0x06001296 RID: 4758 RVA: 0x000085C3 File Offset: 0x000067C3
		public unsafe IList<EntityID> available
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsNode.NativeFieldInfoPtr_available);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsNode.NativeFieldInfoPtr_available), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001297 RID: 4759 RVA: 0x0005E200 File Offset: 0x0005C400
		// (set) Token: 0x06001298 RID: 4760 RVA: 0x000085E2 File Offset: 0x000067E2
		public unsafe IList<EntityID> previous
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsNode.NativeFieldInfoPtr_previous);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsNode.NativeFieldInfoPtr_previous), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001299 RID: 4761 RVA: 0x0005E230 File Offset: 0x0005C430
		// (set) Token: 0x0600129A RID: 4762 RVA: 0x00008601 File Offset: 0x00006801
		public unsafe Dictionary<EntityID, List<TargetStrength>> cachedHints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsNode.NativeFieldInfoPtr_cachedHints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, List<TargetStrength>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsNode.NativeFieldInfoPtr_cachedHints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D24 RID: 3364
		private static readonly IntPtr NativeFieldInfoPtr_none;

		// Token: 0x04000D25 RID: 3365
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x04000D26 RID: 3366
		private static readonly IntPtr NativeFieldInfoPtr_selectionMap;

		// Token: 0x04000D27 RID: 3367
		private static readonly IntPtr NativeFieldInfoPtr_selection;

		// Token: 0x04000D28 RID: 3368
		private static readonly IntPtr NativeFieldInfoPtr_available;

		// Token: 0x04000D29 RID: 3369
		private static readonly IntPtr NativeFieldInfoPtr_previous;

		// Token: 0x04000D2A RID: 3370
		private static readonly IntPtr NativeFieldInfoPtr_cachedHints;

		// Token: 0x04000D2B RID: 3371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SelectionWithTargetsRequired_ISelectionNodeFactory_0;

		// Token: 0x04000D2C RID: 3372
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceID_Public_get_EntityID_0;

		// Token: 0x04000D2D RID: 3373
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreFirst_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000D2E RID: 3374
		private static readonly IntPtr NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0;

		// Token: 0x04000D30 RID: 3376
		private static readonly IntPtr NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0;

		// Token: 0x04000D31 RID: 3377
		private static readonly IntPtr NativeMethodInfoPtr_get_Params_Public_get_Dictionary_2_String_Object_0;

		// Token: 0x04000D32 RID: 3378
		private static readonly IntPtr NativeMethodInfoPtr_SelectionKey_Public_EntityID_0;

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeMethodInfoPtr_get_AllSelectionsInMap_Public_get_IList_1_EntityID_0;

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeMethodInfoPtr_get_AvailableSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeMethodInfoPtr_get_PreviousSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0;

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeMethodInfoPtr_get_ForcedSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0;

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_EntityID_0;

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_EntityID_0;

		// Token: 0x04000D39 RID: 3385
		private static readonly IntPtr NativeMethodInfoPtr_get_MayCancel_Public_Virtual_get_Boolean_0;

		// Token: 0x04000D3A RID: 3386
		private static readonly IntPtr NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0;

		// Token: 0x04000D3B RID: 3387
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxToSelect_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeMethodInfoPtr_get_MinToSelect_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000D3D RID: 3389
		private static readonly IntPtr NativeMethodInfoPtr_HintStrength_Public_Virtual_Final_New_TargetStrength_EntityID_0;

		// Token: 0x04000D3E RID: 3390
		private static readonly IntPtr NativeMethodInfoPtr_HintStrengths_Public_Virtual_Final_New_List_1_TargetStrength_EntityID_0;

		// Token: 0x04000D3F RID: 3391
		private static readonly IntPtr NativeMethodInfoPtr_AllHintStrengths_Public_Virtual_Final_New_Dictionary_2_EntityID_List_1_TargetStrength_0;

		// Token: 0x04000D40 RID: 3392
		private static readonly IntPtr NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_EntityID_0;

		// Token: 0x04000D41 RID: 3393
		private static readonly IntPtr NativeMethodInfoPtr_getResponseMessage_Protected_Virtual_Object_Boolean_0;

		// Token: 0x04000D42 RID: 3394
		private static readonly IntPtr NativeMethodInfoPtr_enter_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000D43 RID: 3395
		private static readonly IntPtr NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0;

		// Token: 0x04000D44 RID: 3396
		private static readonly IntPtr NativeMethodInfoPtr_GetKind_Protected_Virtual_String_0;

		// Token: 0x04000D45 RID: 3397
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x020002D4 RID: 724
		[ObfuscatedName("dwd.core.match.selection.SelectionWithTargetsNode+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060021AC RID: 8620 RVA: 0x00096784 File Offset: 0x00094984
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SelectionWithTargetsNode.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectionWithTargetsNode>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionWithTargetsNode.__c>.NativeClassPtr);
				SelectionWithTargetsNode.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsNode.__c>.NativeClassPtr, "<>9");
				SelectionWithTargetsNode.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsNode.__c>.NativeClassPtr, "<>9__7_0");
				SelectionWithTargetsNode.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsNode.__c>.NativeClassPtr, "<>9__22_0");
				SelectionWithTargetsNode.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode.__c>.NativeClassPtr, 100666063);
				SelectionWithTargetsNode.__c.NativeMethodInfoPtr___ctor_b__7_0_Internal_Boolean_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode.__c>.NativeClassPtr, 100666064);
				SelectionWithTargetsNode.__c.NativeMethodInfoPtr__get_AllSelectionsInMap_b__22_0_Internal_EntityID_KeyValuePair_2_EntityID_TargetInfoNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsNode.__c>.NativeClassPtr, 100666065);
			}

			// Token: 0x060021AD RID: 8621 RVA: 0x00096828 File Offset: 0x00094A28
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionWithTargetsNode.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsNode.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021AE RID: 8622 RVA: 0x00096864 File Offset: 0x00094A64
			[CallerCount(0)]
			public unsafe bool __ctor_b__7_0(TargetInformation x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsNode.__c.NativeMethodInfoPtr___ctor_b__7_0_Internal_Boolean_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060021AF RID: 8623 RVA: 0x000968B4 File Offset: 0x00094AB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871738, XrefRangeEnd = 871739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EntityID _get_AllSelectionsInMap_b__22_0(KeyValuePair<EntityID, TargetInfoNode> sm)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sm));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsNode.__c.NativeMethodInfoPtr__get_AllSelectionsInMap_b__22_0_Internal_EntityID_KeyValuePair_2_EntityID_TargetInfoNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060021B0 RID: 8624 RVA: 0x0000E6FD File Offset: 0x0000C8FD
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000933 RID: 2355
			// (get) Token: 0x060021B1 RID: 8625 RVA: 0x0009690C File Offset: 0x00094B0C
			// (set) Token: 0x060021B2 RID: 8626 RVA: 0x0000E706 File Offset: 0x0000C906
			public unsafe static SelectionWithTargetsNode.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectionWithTargetsNode.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionWithTargetsNode.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectionWithTargetsNode.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000934 RID: 2356
			// (get) Token: 0x060021B3 RID: 8627 RVA: 0x00096934 File Offset: 0x00094B34
			// (set) Token: 0x060021B4 RID: 8628 RVA: 0x0000E718 File Offset: 0x0000C918
			public unsafe static Func<TargetInformation, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectionWithTargetsNode.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TargetInformation, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectionWithTargetsNode.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000935 RID: 2357
			// (get) Token: 0x060021B5 RID: 8629 RVA: 0x0009695C File Offset: 0x00094B5C
			// (set) Token: 0x060021B6 RID: 8630 RVA: 0x0000E72A File Offset: 0x0000C92A
			public unsafe static Func<KeyValuePair<EntityID, TargetInfoNode>, EntityID> __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectionWithTargetsNode.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<EntityID, TargetInfoNode>, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectionWithTargetsNode.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400175D RID: 5981
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400175E RID: 5982
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x0400175F RID: 5983
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x04001760 RID: 5984
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001761 RID: 5985
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__7_0_Internal_Boolean_TargetInformation_0;

			// Token: 0x04001762 RID: 5986
			private static readonly IntPtr NativeMethodInfoPtr__get_AllSelectionsInMap_b__22_0_Internal_EntityID_KeyValuePair_2_EntityID_TargetInfoNode_0;
		}
	}
}
