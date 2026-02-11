using System;
using boardgames.hints;
using boardgames.match.data;
using boardgames.match.tutorial;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.match.selection
{
	// Token: 0x02000264 RID: 612
	public class DBGSelectionCommand : Command
	{
		// Token: 0x06001C11 RID: 7185 RVA: 0x00079DE8 File Offset: 0x00077FE8
		// Note: this type is marked as 'beforefieldinit'.
		static DBGSelectionCommand()
		{
			Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.selection", "DBGSelectionCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr);
			DBGSelectionCommand.NativeFieldInfoPtr__Node_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, "<Node>k__BackingField");
			DBGSelectionCommand.NativeFieldInfoPtr__Idling_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, "<Idling>k__BackingField");
			DBGSelectionCommand.NativeFieldInfoPtr_fromCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, "fromCancel");
			DBGSelectionCommand.NativeFieldInfoPtr_hinter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, "hinter");
			DBGSelectionCommand.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, "entities");
			DBGSelectionCommand.NativeFieldInfoPtr_responder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, "responder");
			DBGSelectionCommand.NativeFieldInfoPtr_filters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, "filters");
			DBGSelectionCommand.NativeFieldInfoPtr_tutorialEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, "tutorialEffects");
			DBGSelectionCommand.NativeFieldInfoPtr_selectionAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, "selectionAllowed");
			DBGSelectionCommand.NativeFieldInfoPtr_nodeCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, "nodeCompleted");
			DBGSelectionCommand.NativeMethodInfoPtr_get_Node_Protected_get_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, 100667865);
			DBGSelectionCommand.NativeMethodInfoPtr_get_Idling_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, 100667866);
			DBGSelectionCommand.NativeMethodInfoPtr_set_Idling_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, 100667867);
			DBGSelectionCommand.NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, 100667868);
			DBGSelectionCommand.NativeMethodInfoPtr_execute_Protected_Virtual_Final_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, 100667869);
			DBGSelectionCommand.NativeMethodInfoPtr_moveCamera_Protected_Virtual_New_IEnumerator_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, 100667870);
			DBGSelectionCommand.NativeMethodInfoPtr_showTutorialActions_Protected_Virtual_New_IEnumerator_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, 100667871);
			DBGSelectionCommand.NativeMethodInfoPtr_hideTutorialActions_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, 100667872);
			DBGSelectionCommand.NativeMethodInfoPtr_idle_Protected_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, 100667873);
			DBGSelectionCommand.NativeMethodInfoPtr_SubmitSelection_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, 100667874);
			DBGSelectionCommand.NativeMethodInfoPtr_submitSelection_Protected_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, 100667875);
			DBGSelectionCommand.NativeMethodInfoPtr_SubmitSelection_Public_Virtual_New_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, 100667876);
			DBGSelectionCommand.NativeMethodInfoPtr_submitSelection_Protected_Virtual_New_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, 100667877);
			DBGSelectionCommand.NativeMethodInfoPtr_EntityIsSelectable_Public_Virtual_New_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, 100667878);
			DBGSelectionCommand.NativeMethodInfoPtr_EntityIsPreviousSelection_Public_Virtual_New_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, 100667879);
			DBGSelectionCommand.NativeMethodInfoPtr_CancelSelection_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, 100667880);
			DBGSelectionCommand.NativeMethodInfoPtr_autoAdvance_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, 100667881);
			DBGSelectionCommand.NativeMethodInfoPtr_enterNode_Protected_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, 100667882);
			DBGSelectionCommand.NativeMethodInfoPtr_exitNode_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, 100667883);
			DBGSelectionCommand.NativeMethodInfoPtr_Interrupted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, 100667884);
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06001C12 RID: 7186 RVA: 0x0007A070 File Offset: 0x00078270
		public unsafe ISelectionNode Node
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionCommand.NativeMethodInfoPtr_get_Node_Protected_get_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06001C13 RID: 7187 RVA: 0x0007A0B0 File Offset: 0x000782B0
		// (set) Token: 0x06001C14 RID: 7188 RVA: 0x0007A0EC File Offset: 0x000782EC
		public unsafe bool Idling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionCommand.NativeMethodInfoPtr_get_Idling_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 287297, RefRangeEnd = 287316, XrefRangeStart = 287297, XrefRangeEnd = 287316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionCommand.NativeMethodInfoPtr_set_Idling_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x0007A12C File Offset: 0x0007832C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 534903, RefRangeEnd = 534907, XrefRangeStart = 534877, XrefRangeEnd = 534903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGSelectionCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionCommand.NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x0007A188 File Offset: 0x00078388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534907, XrefRangeEnd = 534912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionCommand.NativeMethodInfoPtr_execute_Protected_Virtual_Final_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x0007A1C8 File Offset: 0x000783C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534912, XrefRangeEnd = 534917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator moveCamera(AccountID activeLocalPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeLocalPlayer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionCommand.NativeMethodInfoPtr_moveCamera_Protected_Virtual_New_IEnumerator_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x0007A224 File Offset: 0x00078424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534917, XrefRangeEnd = 534922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator showTutorialActions(Nullable<int> overrideStage = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideStage));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionCommand.NativeMethodInfoPtr_showTutorialActions_Protected_Virtual_New_IEnumerator_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x0007A284 File Offset: 0x00078484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534922, XrefRangeEnd = 534927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator hideTutorialActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionCommand.NativeMethodInfoPtr_hideTutorialActions_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x0007A2D0 File Offset: 0x000784D0
		[CallerCount(0)]
		public unsafe virtual IEnumerator idle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionCommand.NativeMethodInfoPtr_idle_Protected_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x0007A31C File Offset: 0x0007851C
		[CallerCount(0)]
		public unsafe virtual bool SubmitSelection(int choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref choice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionCommand.NativeMethodInfoPtr_SubmitSelection_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x0007A370 File Offset: 0x00078570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534927, XrefRangeEnd = 534933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool submitSelection(int choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref choice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionCommand.NativeMethodInfoPtr_submitSelection_Protected_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x0007A3C4 File Offset: 0x000785C4
		[CallerCount(0)]
		public unsafe virtual bool SubmitSelection(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionCommand.NativeMethodInfoPtr_SubmitSelection_Public_Virtual_New_Boolean_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x0007A41C File Offset: 0x0007861C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534933, XrefRangeEnd = 534939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool submitSelection(EntityID entityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionCommand.NativeMethodInfoPtr_submitSelection_Protected_Virtual_New_Boolean_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x0007A474 File Offset: 0x00078674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534939, XrefRangeEnd = 534943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool EntityIsSelectable(EntityID entityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionCommand.NativeMethodInfoPtr_EntityIsSelectable_Public_Virtual_New_Boolean_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x0007A4CC File Offset: 0x000786CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534943, XrefRangeEnd = 534947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool EntityIsPreviousSelection(EntityID entityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionCommand.NativeMethodInfoPtr_EntityIsPreviousSelection_Public_Virtual_New_Boolean_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x0007A524 File Offset: 0x00078724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534947, XrefRangeEnd = 534955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CancelSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionCommand.NativeMethodInfoPtr_CancelSelection_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x0007A56C File Offset: 0x0007876C
		[CallerCount(0)]
		public unsafe virtual bool autoAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionCommand.NativeMethodInfoPtr_autoAdvance_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x0007A5B4 File Offset: 0x000787B4
		[CallerCount(0)]
		public unsafe virtual void enterNode(bool fromCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromCancel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionCommand.NativeMethodInfoPtr_enterNode_Protected_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x0007A600 File Offset: 0x00078800
		[CallerCount(0)]
		public unsafe virtual void exitNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionCommand.NativeMethodInfoPtr_exitNode_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x0007A63C File Offset: 0x0007883C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534955, XrefRangeEnd = 534964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Interrupted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionCommand.NativeMethodInfoPtr_Interrupted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x0000F1E6 File Offset: 0x0000D3E6
		public DBGSelectionCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x0007A678 File Offset: 0x00078878
		// (set) Token: 0x06001C28 RID: 7208 RVA: 0x0000F1EF File Offset: 0x0000D3EF
		public unsafe ISelectionNode _Node_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand.NativeFieldInfoPtr__Node_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand.NativeFieldInfoPtr__Node_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06001C29 RID: 7209 RVA: 0x0007A6A8 File Offset: 0x000788A8
		// (set) Token: 0x06001C2A RID: 7210 RVA: 0x0000F20E File Offset: 0x0000D40E
		public unsafe bool _Idling_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand.NativeFieldInfoPtr__Idling_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand.NativeFieldInfoPtr__Idling_k__BackingField)) = value;
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06001C2B RID: 7211 RVA: 0x0007A6D0 File Offset: 0x000788D0
		// (set) Token: 0x06001C2C RID: 7212 RVA: 0x0000F229 File Offset: 0x0000D429
		public unsafe bool fromCancel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand.NativeFieldInfoPtr_fromCancel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand.NativeFieldInfoPtr_fromCancel)) = value;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06001C2D RID: 7213 RVA: 0x0007A6F8 File Offset: 0x000788F8
		// (set) Token: 0x06001C2E RID: 7214 RVA: 0x0000F244 File Offset: 0x0000D444
		public unsafe DBGHintManager hinter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand.NativeFieldInfoPtr_hinter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGHintManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand.NativeFieldInfoPtr_hinter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06001C2F RID: 7215 RVA: 0x0007A728 File Offset: 0x00078928
		// (set) Token: 0x06001C30 RID: 7216 RVA: 0x0000F263 File Offset: 0x0000D463
		public unsafe DBGEntities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06001C31 RID: 7217 RVA: 0x0007A758 File Offset: 0x00078958
		// (set) Token: 0x06001C32 RID: 7218 RVA: 0x0000F282 File Offset: 0x0000D482
		public unsafe DBGSelectionResponder responder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand.NativeFieldInfoPtr_responder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand.NativeFieldInfoPtr_responder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001C33 RID: 7219 RVA: 0x0007A788 File Offset: 0x00078988
		// (set) Token: 0x06001C34 RID: 7220 RVA: 0x0000F2A1 File Offset: 0x0000D4A1
		public unsafe SelectionFiltersData filters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand.NativeFieldInfoPtr_filters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionFiltersData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand.NativeFieldInfoPtr_filters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001C35 RID: 7221 RVA: 0x0007A7B8 File Offset: 0x000789B8
		// (set) Token: 0x06001C36 RID: 7222 RVA: 0x0000F2C0 File Offset: 0x0000D4C0
		public unsafe TutorialEffects tutorialEffects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand.NativeFieldInfoPtr_tutorialEffects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialEffects>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand.NativeFieldInfoPtr_tutorialEffects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001C37 RID: 7223 RVA: 0x0007A7E8 File Offset: 0x000789E8
		// (set) Token: 0x06001C38 RID: 7224 RVA: 0x0000F2DF File Offset: 0x0000D4DF
		public unsafe bool selectionAllowed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand.NativeFieldInfoPtr_selectionAllowed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand.NativeFieldInfoPtr_selectionAllowed)) = value;
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06001C39 RID: 7225 RVA: 0x0007A810 File Offset: 0x00078A10
		// (set) Token: 0x06001C3A RID: 7226 RVA: 0x0000F2FA File Offset: 0x0000D4FA
		public unsafe bool nodeCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand.NativeFieldInfoPtr_nodeCompleted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand.NativeFieldInfoPtr_nodeCompleted)) = value;
			}
		}

		// Token: 0x04001196 RID: 4502
		private static readonly IntPtr NativeFieldInfoPtr__Node_k__BackingField;

		// Token: 0x04001197 RID: 4503
		private static readonly IntPtr NativeFieldInfoPtr__Idling_k__BackingField;

		// Token: 0x04001198 RID: 4504
		private static readonly IntPtr NativeFieldInfoPtr_fromCancel;

		// Token: 0x04001199 RID: 4505
		private static readonly IntPtr NativeFieldInfoPtr_hinter;

		// Token: 0x0400119A RID: 4506
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x0400119B RID: 4507
		private static readonly IntPtr NativeFieldInfoPtr_responder;

		// Token: 0x0400119C RID: 4508
		private static readonly IntPtr NativeFieldInfoPtr_filters;

		// Token: 0x0400119D RID: 4509
		private static readonly IntPtr NativeFieldInfoPtr_tutorialEffects;

		// Token: 0x0400119E RID: 4510
		private static readonly IntPtr NativeFieldInfoPtr_selectionAllowed;

		// Token: 0x0400119F RID: 4511
		private static readonly IntPtr NativeFieldInfoPtr_nodeCompleted;

		// Token: 0x040011A0 RID: 4512
		private static readonly IntPtr NativeMethodInfoPtr_get_Node_Protected_get_ISelectionNode_0;

		// Token: 0x040011A1 RID: 4513
		private static readonly IntPtr NativeMethodInfoPtr_get_Idling_Protected_get_Boolean_0;

		// Token: 0x040011A2 RID: 4514
		private static readonly IntPtr NativeMethodInfoPtr_set_Idling_Private_set_Void_Boolean_0;

		// Token: 0x040011A3 RID: 4515
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNode_Boolean_0;

		// Token: 0x040011A4 RID: 4516
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_Final_IEnumerator_0;

		// Token: 0x040011A5 RID: 4517
		private static readonly IntPtr NativeMethodInfoPtr_moveCamera_Protected_Virtual_New_IEnumerator_AccountID_0;

		// Token: 0x040011A6 RID: 4518
		private static readonly IntPtr NativeMethodInfoPtr_showTutorialActions_Protected_Virtual_New_IEnumerator_Nullable_1_Int32_0;

		// Token: 0x040011A7 RID: 4519
		private static readonly IntPtr NativeMethodInfoPtr_hideTutorialActions_Protected_Virtual_New_IEnumerator_0;

		// Token: 0x040011A8 RID: 4520
		private static readonly IntPtr NativeMethodInfoPtr_idle_Protected_Abstract_Virtual_New_IEnumerator_0;

		// Token: 0x040011A9 RID: 4521
		private static readonly IntPtr NativeMethodInfoPtr_SubmitSelection_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x040011AA RID: 4522
		private static readonly IntPtr NativeMethodInfoPtr_submitSelection_Protected_Virtual_New_Boolean_Int32_0;

		// Token: 0x040011AB RID: 4523
		private static readonly IntPtr NativeMethodInfoPtr_SubmitSelection_Public_Virtual_New_Boolean_EntityID_0;

		// Token: 0x040011AC RID: 4524
		private static readonly IntPtr NativeMethodInfoPtr_submitSelection_Protected_Virtual_New_Boolean_EntityID_0;

		// Token: 0x040011AD RID: 4525
		private static readonly IntPtr NativeMethodInfoPtr_EntityIsSelectable_Public_Virtual_New_Boolean_EntityID_0;

		// Token: 0x040011AE RID: 4526
		private static readonly IntPtr NativeMethodInfoPtr_EntityIsPreviousSelection_Public_Virtual_New_Boolean_EntityID_0;

		// Token: 0x040011AF RID: 4527
		private static readonly IntPtr NativeMethodInfoPtr_CancelSelection_Public_Virtual_New_Boolean_0;

		// Token: 0x040011B0 RID: 4528
		private static readonly IntPtr NativeMethodInfoPtr_autoAdvance_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040011B1 RID: 4529
		private static readonly IntPtr NativeMethodInfoPtr_enterNode_Protected_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x040011B2 RID: 4530
		private static readonly IntPtr NativeMethodInfoPtr_exitNode_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040011B3 RID: 4531
		private static readonly IntPtr NativeMethodInfoPtr_Interrupted_Public_Virtual_New_Void_0;

		// Token: 0x02000458 RID: 1112
		[ObfuscatedName("boardgames.match.selection.DBGSelectionCommand+<execute>d__16")]
		public sealed class _execute_d__16 : Object
		{
			// Token: 0x060034E7 RID: 13543 RVA: 0x000C6578 File Offset: 0x000C4778
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__16()
			{
				Il2CppClassPointerStore<DBGSelectionCommand._execute_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, "<execute>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGSelectionCommand._execute_d__16>.NativeClassPtr);
				DBGSelectionCommand._execute_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionCommand._execute_d__16>.NativeClassPtr, "<>1__state");
				DBGSelectionCommand._execute_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionCommand._execute_d__16>.NativeClassPtr, "<>2__current");
				DBGSelectionCommand._execute_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionCommand._execute_d__16>.NativeClassPtr, "<>4__this");
				DBGSelectionCommand._execute_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand._execute_d__16>.NativeClassPtr, 100667885);
				DBGSelectionCommand._execute_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand._execute_d__16>.NativeClassPtr, 100667886);
				DBGSelectionCommand._execute_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand._execute_d__16>.NativeClassPtr, 100667887);
				DBGSelectionCommand._execute_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand._execute_d__16>.NativeClassPtr, 100667888);
				DBGSelectionCommand._execute_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand._execute_d__16>.NativeClassPtr, 100667889);
				DBGSelectionCommand._execute_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand._execute_d__16>.NativeClassPtr, 100667890);
			}

			// Token: 0x060034E8 RID: 13544 RVA: 0x000C6658 File Offset: 0x000C4858
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__16(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGSelectionCommand._execute_d__16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionCommand._execute_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060034E9 RID: 13545 RVA: 0x000C66A0 File Offset: 0x000C48A0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionCommand._execute_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060034EA RID: 13546 RVA: 0x000C66D4 File Offset: 0x000C48D4
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionCommand._execute_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000F8A RID: 3978
			// (get) Token: 0x060034EB RID: 13547 RVA: 0x000C6710 File Offset: 0x000C4910
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionCommand._execute_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060034EC RID: 13548 RVA: 0x000C6750 File Offset: 0x000C4950
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534853, XrefRangeEnd = 534858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionCommand._execute_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F8B RID: 3979
			// (get) Token: 0x060034ED RID: 13549 RVA: 0x000C6784 File Offset: 0x000C4984
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionCommand._execute_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060034EE RID: 13550 RVA: 0x0001B56B File Offset: 0x0001976B
			public _execute_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F87 RID: 3975
			// (get) Token: 0x060034EF RID: 13551 RVA: 0x000C67C4 File Offset: 0x000C49C4
			// (set) Token: 0x060034F0 RID: 13552 RVA: 0x0001B574 File Offset: 0x00019774
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand._execute_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand._execute_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F88 RID: 3976
			// (get) Token: 0x060034F1 RID: 13553 RVA: 0x000C67EC File Offset: 0x000C49EC
			// (set) Token: 0x060034F2 RID: 13554 RVA: 0x0001B58F File Offset: 0x0001978F
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand._execute_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand._execute_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F89 RID: 3977
			// (get) Token: 0x060034F3 RID: 13555 RVA: 0x000C681C File Offset: 0x000C4A1C
			// (set) Token: 0x060034F4 RID: 13556 RVA: 0x0001B5AE File Offset: 0x000197AE
			public unsafe DBGSelectionCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand._execute_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand._execute_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400209B RID: 8347
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400209C RID: 8348
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400209D RID: 8349
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400209E RID: 8350
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400209F RID: 8351
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020A0 RID: 8352
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040020A1 RID: 8353
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040020A2 RID: 8354
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020A3 RID: 8355
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000459 RID: 1113
		[ObfuscatedName("boardgames.match.selection.DBGSelectionCommand+<hideTutorialActions>d__19")]
		public sealed class _hideTutorialActions_d__19 : Object
		{
			// Token: 0x060034F5 RID: 13557 RVA: 0x000C684C File Offset: 0x000C4A4C
			// Note: this type is marked as 'beforefieldinit'.
			static _hideTutorialActions_d__19()
			{
				Il2CppClassPointerStore<DBGSelectionCommand._hideTutorialActions_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, "<hideTutorialActions>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGSelectionCommand._hideTutorialActions_d__19>.NativeClassPtr);
				DBGSelectionCommand._hideTutorialActions_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionCommand._hideTutorialActions_d__19>.NativeClassPtr, "<>1__state");
				DBGSelectionCommand._hideTutorialActions_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionCommand._hideTutorialActions_d__19>.NativeClassPtr, "<>2__current");
				DBGSelectionCommand._hideTutorialActions_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionCommand._hideTutorialActions_d__19>.NativeClassPtr, "<>4__this");
				DBGSelectionCommand._hideTutorialActions_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand._hideTutorialActions_d__19>.NativeClassPtr, 100667891);
				DBGSelectionCommand._hideTutorialActions_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand._hideTutorialActions_d__19>.NativeClassPtr, 100667892);
				DBGSelectionCommand._hideTutorialActions_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand._hideTutorialActions_d__19>.NativeClassPtr, 100667893);
				DBGSelectionCommand._hideTutorialActions_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand._hideTutorialActions_d__19>.NativeClassPtr, 100667894);
				DBGSelectionCommand._hideTutorialActions_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand._hideTutorialActions_d__19>.NativeClassPtr, 100667895);
				DBGSelectionCommand._hideTutorialActions_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand._hideTutorialActions_d__19>.NativeClassPtr, 100667896);
			}

			// Token: 0x060034F6 RID: 13558 RVA: 0x000C692C File Offset: 0x000C4B2C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _hideTutorialActions_d__19(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGSelectionCommand._hideTutorialActions_d__19>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionCommand._hideTutorialActions_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060034F7 RID: 13559 RVA: 0x000C6974 File Offset: 0x000C4B74
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionCommand._hideTutorialActions_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060034F8 RID: 13560 RVA: 0x000C69A8 File Offset: 0x000C4BA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534858, XrefRangeEnd = 534859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionCommand._hideTutorialActions_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000F8F RID: 3983
			// (get) Token: 0x060034F9 RID: 13561 RVA: 0x000C69E4 File Offset: 0x000C4BE4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionCommand._hideTutorialActions_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060034FA RID: 13562 RVA: 0x000C6A24 File Offset: 0x000C4C24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534859, XrefRangeEnd = 534864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionCommand._hideTutorialActions_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F90 RID: 3984
			// (get) Token: 0x060034FB RID: 13563 RVA: 0x000C6A58 File Offset: 0x000C4C58
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionCommand._hideTutorialActions_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060034FC RID: 13564 RVA: 0x0001B5CD File Offset: 0x000197CD
			public _hideTutorialActions_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F8C RID: 3980
			// (get) Token: 0x060034FD RID: 13565 RVA: 0x000C6A98 File Offset: 0x000C4C98
			// (set) Token: 0x060034FE RID: 13566 RVA: 0x0001B5D6 File Offset: 0x000197D6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand._hideTutorialActions_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand._hideTutorialActions_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F8D RID: 3981
			// (get) Token: 0x060034FF RID: 13567 RVA: 0x000C6AC0 File Offset: 0x000C4CC0
			// (set) Token: 0x06003500 RID: 13568 RVA: 0x0001B5F1 File Offset: 0x000197F1
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand._hideTutorialActions_d__19.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand._hideTutorialActions_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F8E RID: 3982
			// (get) Token: 0x06003501 RID: 13569 RVA: 0x000C6AF0 File Offset: 0x000C4CF0
			// (set) Token: 0x06003502 RID: 13570 RVA: 0x0001B610 File Offset: 0x00019810
			public unsafe DBGSelectionCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand._hideTutorialActions_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand._hideTutorialActions_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040020A4 RID: 8356
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040020A5 RID: 8357
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040020A6 RID: 8358
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040020A7 RID: 8359
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040020A8 RID: 8360
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020A9 RID: 8361
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040020AA RID: 8362
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040020AB RID: 8363
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020AC RID: 8364
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200045A RID: 1114
		[ObfuscatedName("boardgames.match.selection.DBGSelectionCommand+<showTutorialActions>d__18")]
		public sealed class _showTutorialActions_d__18 : Object
		{
			// Token: 0x06003503 RID: 13571 RVA: 0x000C6B20 File Offset: 0x000C4D20
			// Note: this type is marked as 'beforefieldinit'.
			static _showTutorialActions_d__18()
			{
				Il2CppClassPointerStore<DBGSelectionCommand._showTutorialActions_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGSelectionCommand>.NativeClassPtr, "<showTutorialActions>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGSelectionCommand._showTutorialActions_d__18>.NativeClassPtr);
				DBGSelectionCommand._showTutorialActions_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionCommand._showTutorialActions_d__18>.NativeClassPtr, "<>1__state");
				DBGSelectionCommand._showTutorialActions_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionCommand._showTutorialActions_d__18>.NativeClassPtr, "<>2__current");
				DBGSelectionCommand._showTutorialActions_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionCommand._showTutorialActions_d__18>.NativeClassPtr, "<>4__this");
				DBGSelectionCommand._showTutorialActions_d__18.NativeFieldInfoPtr_overrideStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionCommand._showTutorialActions_d__18>.NativeClassPtr, "overrideStage");
				DBGSelectionCommand._showTutorialActions_d__18.NativeFieldInfoPtr__context_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionCommand._showTutorialActions_d__18>.NativeClassPtr, "<context>5__2");
				DBGSelectionCommand._showTutorialActions_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand._showTutorialActions_d__18>.NativeClassPtr, 100667897);
				DBGSelectionCommand._showTutorialActions_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand._showTutorialActions_d__18>.NativeClassPtr, 100667898);
				DBGSelectionCommand._showTutorialActions_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand._showTutorialActions_d__18>.NativeClassPtr, 100667899);
				DBGSelectionCommand._showTutorialActions_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand._showTutorialActions_d__18>.NativeClassPtr, 100667900);
				DBGSelectionCommand._showTutorialActions_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand._showTutorialActions_d__18>.NativeClassPtr, 100667901);
				DBGSelectionCommand._showTutorialActions_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionCommand._showTutorialActions_d__18>.NativeClassPtr, 100667902);
			}

			// Token: 0x06003504 RID: 13572 RVA: 0x000C6C28 File Offset: 0x000C4E28
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _showTutorialActions_d__18(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGSelectionCommand._showTutorialActions_d__18>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionCommand._showTutorialActions_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003505 RID: 13573 RVA: 0x000C6C70 File Offset: 0x000C4E70
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionCommand._showTutorialActions_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003506 RID: 13574 RVA: 0x000C6CA4 File Offset: 0x000C4EA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534864, XrefRangeEnd = 534872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionCommand._showTutorialActions_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000F96 RID: 3990
			// (get) Token: 0x06003507 RID: 13575 RVA: 0x000C6CE0 File Offset: 0x000C4EE0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionCommand._showTutorialActions_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003508 RID: 13576 RVA: 0x000C6D20 File Offset: 0x000C4F20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534872, XrefRangeEnd = 534877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionCommand._showTutorialActions_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F97 RID: 3991
			// (get) Token: 0x06003509 RID: 13577 RVA: 0x000C6D54 File Offset: 0x000C4F54
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionCommand._showTutorialActions_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600350A RID: 13578 RVA: 0x0001B62F File Offset: 0x0001982F
			public _showTutorialActions_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F91 RID: 3985
			// (get) Token: 0x0600350B RID: 13579 RVA: 0x000C6D94 File Offset: 0x000C4F94
			// (set) Token: 0x0600350C RID: 13580 RVA: 0x0001B638 File Offset: 0x00019838
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand._showTutorialActions_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand._showTutorialActions_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F92 RID: 3986
			// (get) Token: 0x0600350D RID: 13581 RVA: 0x000C6DBC File Offset: 0x000C4FBC
			// (set) Token: 0x0600350E RID: 13582 RVA: 0x0001B653 File Offset: 0x00019853
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand._showTutorialActions_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand._showTutorialActions_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F93 RID: 3987
			// (get) Token: 0x0600350F RID: 13583 RVA: 0x000C6DEC File Offset: 0x000C4FEC
			// (set) Token: 0x06003510 RID: 13584 RVA: 0x0001B672 File Offset: 0x00019872
			public unsafe DBGSelectionCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand._showTutorialActions_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand._showTutorialActions_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F94 RID: 3988
			// (get) Token: 0x06003511 RID: 13585 RVA: 0x000C6E1C File Offset: 0x000C501C
			// (set) Token: 0x06003512 RID: 13586 RVA: 0x0001B691 File Offset: 0x00019891
			public Nullable<int> overrideStage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand._showTutorialActions_d__18.NativeFieldInfoPtr_overrideStage);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand._showTutorialActions_d__18.NativeFieldInfoPtr_overrideStage), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F95 RID: 3989
			// (get) Token: 0x06003513 RID: 13587 RVA: 0x000C6E4C File Offset: 0x000C504C
			// (set) Token: 0x06003514 RID: 13588 RVA: 0x0001B6BF File Offset: 0x000198BF
			public unsafe IEnumerator _context_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand._showTutorialActions_d__18.NativeFieldInfoPtr__context_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionCommand._showTutorialActions_d__18.NativeFieldInfoPtr__context_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040020AD RID: 8365
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040020AE RID: 8366
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040020AF RID: 8367
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040020B0 RID: 8368
			private static readonly IntPtr NativeFieldInfoPtr_overrideStage;

			// Token: 0x040020B1 RID: 8369
			private static readonly IntPtr NativeFieldInfoPtr__context_5__2;

			// Token: 0x040020B2 RID: 8370
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040020B3 RID: 8371
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020B4 RID: 8372
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040020B5 RID: 8373
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040020B6 RID: 8374
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020B7 RID: 8375
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
