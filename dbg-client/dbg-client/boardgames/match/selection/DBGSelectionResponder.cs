using System;
using boardgames.match.behaviours;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.match;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.Events;

namespace boardgames.match.selection
{
	// Token: 0x0200026C RID: 620
	public class DBGSelectionResponder : MonoBehaviour
	{
		// Token: 0x06001CB5 RID: 7349 RVA: 0x0007C764 File Offset: 0x0007A964
		// Note: this type is marked as 'beforefieldinit'.
		static DBGSelectionResponder()
		{
			Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.selection", "DBGSelectionResponder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr);
			DBGSelectionResponder.NativeFieldInfoPtr__version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, "<version>k__BackingField");
			DBGSelectionResponder.NativeFieldInfoPtr_cachedHandlerVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, "cachedHandlerVersion");
			DBGSelectionResponder.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, "selection");
			DBGSelectionResponder.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, "entitiesProvider");
			DBGSelectionResponder.NativeFieldInfoPtr__currentSelectionHandler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, "<currentSelectionHandler>k__BackingField");
			DBGSelectionResponder.NativeFieldInfoPtr_cachedSelectionHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, "cachedSelectionHandler");
			DBGSelectionResponder.NativeFieldInfoPtr_OnAttemptSubmitSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, "OnAttemptSubmitSelection");
			DBGSelectionResponder.NativeFieldInfoPtr_OnLocalSelectionTimedOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, "OnLocalSelectionTimedOut");
			DBGSelectionResponder.NativeMethodInfoPtr_get_Version_Public_Virtual_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668013);
			DBGSelectionResponder.NativeMethodInfoPtr_get_version_Protected_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668014);
			DBGSelectionResponder.NativeMethodInfoPtr_set_version_Protected_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668015);
			DBGSelectionResponder.NativeMethodInfoPtr_get_currentSelectionHandler_Protected_Virtual_New_get_SelectionRootHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668016);
			DBGSelectionResponder.NativeMethodInfoPtr_set_currentSelectionHandler_Protected_Virtual_New_set_Void_SelectionRootHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668017);
			DBGSelectionResponder.NativeMethodInfoPtr_get_CurrentSelectionHandler_Public_get_SelectionRootHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668018);
			DBGSelectionResponder.NativeMethodInfoPtr_get_cachedChoice_Protected_get_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668019);
			DBGSelectionResponder.NativeMethodInfoPtr_get_selectionFilters_Protected_get_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668020);
			DBGSelectionResponder.NativeMethodInfoPtr_get_selectionCommand_Protected_get_DBGSelectionCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668021);
			DBGSelectionResponder.NativeMethodInfoPtr_get_interruptableCommand_Protected_get_InterruptableCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668022);
			DBGSelectionResponder.NativeMethodInfoPtr_get_HasSelection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668023);
			DBGSelectionResponder.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668024);
			DBGSelectionResponder.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668025);
			DBGSelectionResponder.NativeMethodInfoPtr_updateSelectionRootData_Protected_Void_SelectionRootHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668026);
			DBGSelectionResponder.NativeMethodInfoPtr_getDefaultSelectionCommand_Protected_Virtual_New_DBGSelectionCommand_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668027);
			DBGSelectionResponder.NativeMethodInfoPtr_FiltersActive_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668028);
			DBGSelectionResponder.NativeMethodInfoPtr_AttemptSubmitSelection_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668029);
			DBGSelectionResponder.NativeMethodInfoPtr_AttemptSubmitSelection_Public_Virtual_New_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668030);
			DBGSelectionResponder.NativeMethodInfoPtr_ValidateSelection_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668031);
			DBGSelectionResponder.NativeMethodInfoPtr_ValidateSelection_Public_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668032);
			DBGSelectionResponder.NativeMethodInfoPtr_ValidateAdvance_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668033);
			DBGSelectionResponder.NativeMethodInfoPtr_AttemptCancel_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668034);
			DBGSelectionResponder.NativeMethodInfoPtr_MayAdvance_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668035);
			DBGSelectionResponder.NativeMethodInfoPtr_ValidateCancel_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668036);
			DBGSelectionResponder.NativeMethodInfoPtr_MayCancel_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668037);
			DBGSelectionResponder.NativeMethodInfoPtr_GetOfferAttribute_Public_ReadOnlyAttribute_1_T_AttributeDefinition_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668038);
			DBGSelectionResponder.NativeMethodInfoPtr_AttemptAdvance_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668039);
			DBGSelectionResponder.NativeMethodInfoPtr_EntityIsSelectable_Public_Virtual_New_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668040);
			DBGSelectionResponder.NativeMethodInfoPtr_EntityIsPreviousSelection_Public_Virtual_New_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668041);
			DBGSelectionResponder.NativeMethodInfoPtr_HasUndo_Public_Boolean_EntityID_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668042);
			DBGSelectionResponder.NativeMethodInfoPtr_Kind_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668043);
			DBGSelectionResponder.NativeMethodInfoPtr_EntityIsSelectable_Public_Virtual_New_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668044);
			DBGSelectionResponder.NativeMethodInfoPtr_EntityHasLeafSelection_Public_Virtual_New_Boolean_EntityComponent_byref_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668045);
			DBGSelectionResponder.NativeMethodInfoPtr_MarkDirty_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668046);
			DBGSelectionResponder.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668047);
			DBGSelectionResponder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr, 100668048);
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06001CB6 RID: 7350 RVA: 0x0007CB04 File Offset: 0x0007AD04
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536008, XrefRangeEnd = 536010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionResponder.NativeMethodInfoPtr_get_Version_Public_Virtual_New_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06001CB7 RID: 7351 RVA: 0x0007CB4C File Offset: 0x0007AD4C
		// (set) Token: 0x06001CB8 RID: 7352 RVA: 0x0007CB88 File Offset: 0x0007AD88
		public unsafe ulong version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponder.NativeMethodInfoPtr_get_version_Protected_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponder.NativeMethodInfoPtr_set_version_Protected_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06001CB9 RID: 7353 RVA: 0x0007CBC8 File Offset: 0x0007ADC8
		// (set) Token: 0x06001CBA RID: 7354 RVA: 0x0007CC14 File Offset: 0x0007AE14
		public unsafe virtual SelectionRootHandler currentSelectionHandler
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionResponder.NativeMethodInfoPtr_get_currentSelectionHandler_Protected_Virtual_New_get_SelectionRootHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionRootHandler>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionResponder.NativeMethodInfoPtr_set_currentSelectionHandler_Protected_Virtual_New_set_Void_SelectionRootHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06001CBB RID: 7355 RVA: 0x0007CC64 File Offset: 0x0007AE64
		public unsafe SelectionRootHandler CurrentSelectionHandler
		{
			[CallerCount(55)]
			[CachedScanResults(RefRangeStart = 373745, RefRangeEnd = 373800, XrefRangeStart = 373745, XrefRangeEnd = 373800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponder.NativeMethodInfoPtr_get_CurrentSelectionHandler_Public_get_SelectionRootHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionRootHandler>(intPtr3) : null;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06001CBC RID: 7356 RVA: 0x0007CCA4 File Offset: 0x0007AEA4
		public unsafe ISelectionNode cachedChoice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponder.NativeMethodInfoPtr_get_cachedChoice_Protected_get_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06001CBD RID: 7357 RVA: 0x0007CCE4 File Offset: 0x0007AEE4
		public unsafe EntityComponent selectionFilters
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponder.NativeMethodInfoPtr_get_selectionFilters_Protected_get_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06001CBE RID: 7358 RVA: 0x0007CD24 File Offset: 0x0007AF24
		public unsafe DBGSelectionCommand selectionCommand
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponder.NativeMethodInfoPtr_get_selectionCommand_Protected_get_DBGSelectionCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DBGSelectionCommand>(intPtr3) : null;
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06001CBF RID: 7359 RVA: 0x0007CD64 File Offset: 0x0007AF64
		public unsafe InterruptableCommand interruptableCommand
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponder.NativeMethodInfoPtr_get_interruptableCommand_Protected_get_InterruptableCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InterruptableCommand>(intPtr3) : null;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06001CC0 RID: 7360 RVA: 0x0007CDA4 File Offset: 0x0007AFA4
		public unsafe bool HasSelection
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 536010, RefRangeEnd = 536017, XrefRangeStart = 536010, XrefRangeEnd = 536010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponder.NativeMethodInfoPtr_get_HasSelection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x0007CDE0 File Offset: 0x0007AFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536017, XrefRangeEnd = 536023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponder.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x0007CE14 File Offset: 0x0007B014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536023, XrefRangeEnd = 536035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionResponder.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x0007CE50 File Offset: 0x0007B050
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 536128, RefRangeEnd = 536130, XrefRangeStart = 536035, XrefRangeEnd = 536128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateSelectionRootData(SelectionRootHandler selectionRootHandler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectionRootHandler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponder.NativeMethodInfoPtr_updateSelectionRootData_Protected_Void_SelectionRootHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x0007CE94 File Offset: 0x0007B094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536130, XrefRangeEnd = 536143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DBGSelectionCommand getDefaultSelectionCommand(ISelectionNode selectionNode, bool wasCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectionNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wasCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionResponder.NativeMethodInfoPtr_getDefaultSelectionCommand_Protected_Virtual_New_DBGSelectionCommand_ISelectionNode_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DBGSelectionCommand>(intPtr3) : null;
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x0007CF00 File Offset: 0x0007B100
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 536146, RefRangeEnd = 536147, XrefRangeStart = 536143, XrefRangeEnd = 536146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FiltersActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponder.NativeMethodInfoPtr_FiltersActive_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x0007CF3C File Offset: 0x0007B13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536147, XrefRangeEnd = 536148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool AttemptSubmitSelection(int choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref choice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionResponder.NativeMethodInfoPtr_AttemptSubmitSelection_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x0007CF90 File Offset: 0x0007B190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536148, XrefRangeEnd = 536149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool AttemptSubmitSelection(EntityID entityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionResponder.NativeMethodInfoPtr_AttemptSubmitSelection_Public_Virtual_New_Boolean_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x0007CFE8 File Offset: 0x0007B1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536149, XrefRangeEnd = 536150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateSelection(int choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref choice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponder.NativeMethodInfoPtr_ValidateSelection_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x0007D034 File Offset: 0x0007B234
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 536151, RefRangeEnd = 536154, XrefRangeStart = 536150, XrefRangeEnd = 536151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateSelection(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponder.NativeMethodInfoPtr_ValidateSelection_Public_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x0007D084 File Offset: 0x0007B284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536154, XrefRangeEnd = 536155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ValidateAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionResponder.NativeMethodInfoPtr_ValidateAdvance_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x0007D0CC File Offset: 0x0007B2CC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 536155, RefRangeEnd = 536162, XrefRangeStart = 536155, XrefRangeEnd = 536155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AttemptCancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponder.NativeMethodInfoPtr_AttemptCancel_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x0007D108 File Offset: 0x0007B308
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 536163, RefRangeEnd = 536167, XrefRangeStart = 536162, XrefRangeEnd = 536163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MayAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponder.NativeMethodInfoPtr_MayAdvance_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x0007D144 File Offset: 0x0007B344
		[CallerCount(0)]
		public unsafe virtual bool ValidateCancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionResponder.NativeMethodInfoPtr_ValidateCancel_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x0007D18C File Offset: 0x0007B38C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 536168, RefRangeEnd = 536171, XrefRangeStart = 536167, XrefRangeEnd = 536168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MayCancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponder.NativeMethodInfoPtr_MayCancel_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x0007D1C8 File Offset: 0x0007B3C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 536173, RefRangeEnd = 536174, XrefRangeStart = 536171, XrefRangeEnd = 536173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyAttribute<T> GetOfferAttribute<T>(AttributeDefinition<T> attributeDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeDefinition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponder.MethodInfoStoreGeneric_GetOfferAttribute_Public_ReadOnlyAttribute_1_T_AttributeDefinition_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x0007D218 File Offset: 0x0007B418
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 536181, RefRangeEnd = 536191, XrefRangeStart = 536174, XrefRangeEnd = 536181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AttemptAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponder.NativeMethodInfoPtr_AttemptAdvance_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x0007D254 File Offset: 0x0007B454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536191, XrefRangeEnd = 536192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool EntityIsSelectable(EntityID entityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionResponder.NativeMethodInfoPtr_EntityIsSelectable_Public_Virtual_New_Boolean_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x0007D2AC File Offset: 0x0007B4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536192, XrefRangeEnd = 536193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool EntityIsPreviousSelection(EntityID entityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionResponder.NativeMethodInfoPtr_EntityIsPreviousSelection_Public_Virtual_New_Boolean_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x0007D304 File Offset: 0x0007B504
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 536194, RefRangeEnd = 536195, XrefRangeStart = 536193, XrefRangeEnd = 536194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasUndo(EntityID entityID, out int selectionCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &selectionCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponder.NativeMethodInfoPtr_HasUndo_Public_Boolean_EntityID_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x0007D360 File Offset: 0x0007B560
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 536201, RefRangeEnd = 536213, XrefRangeStart = 536195, XrefRangeEnd = 536201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Kind()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponder.NativeMethodInfoPtr_Kind_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x0007D398 File Offset: 0x0007B598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536213, XrefRangeEnd = 536219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool EntityIsSelectable(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionResponder.NativeMethodInfoPtr_EntityIsSelectable_Public_Virtual_New_Boolean_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x0007D3F0 File Offset: 0x0007B5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536219, XrefRangeEnd = 536234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool EntityHasLeafSelection(EntityComponent entity, out ISelectionNode leafNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectionResponder.NativeMethodInfoPtr_EntityHasLeafSelection_Public_Virtual_New_Boolean_EntityComponent_byref_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			leafNode = ((intPtr4 == 0) ? null : new ISelectionNode(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x0007D46C File Offset: 0x0007B66C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 536234, RefRangeEnd = 536235, XrefRangeStart = 536234, XrefRangeEnd = 536234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void MarkDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponder.NativeMethodInfoPtr_MarkDirty_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x0007D4A0 File Offset: 0x0007B6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536235, XrefRangeEnd = 536236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponder.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x0007D4D4 File Offset: 0x0007B6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536236, XrefRangeEnd = 536242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGSelectionResponder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectionResponder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x0000F5DA File Offset: 0x0000D7DA
		public DBGSelectionResponder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06001CDB RID: 7387 RVA: 0x0007D510 File Offset: 0x0007B710
		// (set) Token: 0x06001CDC RID: 7388 RVA: 0x0000F5E3 File Offset: 0x0000D7E3
		public unsafe ulong _version_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionResponder.NativeFieldInfoPtr__version_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionResponder.NativeFieldInfoPtr__version_k__BackingField)) = value;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06001CDD RID: 7389 RVA: 0x0007D538 File Offset: 0x0007B738
		// (set) Token: 0x06001CDE RID: 7390 RVA: 0x0000F5FE File Offset: 0x0000D7FE
		public unsafe ulong cachedHandlerVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionResponder.NativeFieldInfoPtr_cachedHandlerVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionResponder.NativeFieldInfoPtr_cachedHandlerVersion)) = value;
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06001CDF RID: 7391 RVA: 0x0007D560 File Offset: 0x0007B760
		// (set) Token: 0x06001CE0 RID: 7392 RVA: 0x0000F619 File Offset: 0x0000D819
		public unsafe Selection selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionResponder.NativeFieldInfoPtr_selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionResponder.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06001CE1 RID: 7393 RVA: 0x0007D590 File Offset: 0x0007B790
		// (set) Token: 0x06001CE2 RID: 7394 RVA: 0x0000F638 File Offset: 0x0000D838
		public unsafe DBGEntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionResponder.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionResponder.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x0007D5C0 File Offset: 0x0007B7C0
		// (set) Token: 0x06001CE4 RID: 7396 RVA: 0x0000F657 File Offset: 0x0000D857
		public unsafe SelectionRootHandler _currentSelectionHandler_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionResponder.NativeFieldInfoPtr__currentSelectionHandler_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionRootHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionResponder.NativeFieldInfoPtr__currentSelectionHandler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06001CE5 RID: 7397 RVA: 0x0007D5F0 File Offset: 0x0007B7F0
		// (set) Token: 0x06001CE6 RID: 7398 RVA: 0x0000F676 File Offset: 0x0000D876
		public unsafe SelectionRootHandler cachedSelectionHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionResponder.NativeFieldInfoPtr_cachedSelectionHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionRootHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionResponder.NativeFieldInfoPtr_cachedSelectionHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06001CE7 RID: 7399 RVA: 0x0007D620 File Offset: 0x0007B820
		// (set) Token: 0x06001CE8 RID: 7400 RVA: 0x0000F695 File Offset: 0x0000D895
		public unsafe UnityAction<EntityID> OnAttemptSubmitSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionResponder.NativeFieldInfoPtr_OnAttemptSubmitSelection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionResponder.NativeFieldInfoPtr_OnAttemptSubmitSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06001CE9 RID: 7401 RVA: 0x0007D650 File Offset: 0x0007B850
		// (set) Token: 0x06001CEA RID: 7402 RVA: 0x0000F6B4 File Offset: 0x0000D8B4
		public unsafe UnityEvent OnLocalSelectionTimedOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionResponder.NativeFieldInfoPtr_OnLocalSelectionTimedOut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectionResponder.NativeFieldInfoPtr_OnLocalSelectionTimedOut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400120B RID: 4619
		private static readonly IntPtr NativeFieldInfoPtr__version_k__BackingField;

		// Token: 0x0400120C RID: 4620
		private static readonly IntPtr NativeFieldInfoPtr_cachedHandlerVersion;

		// Token: 0x0400120D RID: 4621
		private static readonly IntPtr NativeFieldInfoPtr_selection;

		// Token: 0x0400120E RID: 4622
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x0400120F RID: 4623
		private static readonly IntPtr NativeFieldInfoPtr__currentSelectionHandler_k__BackingField;

		// Token: 0x04001210 RID: 4624
		private static readonly IntPtr NativeFieldInfoPtr_cachedSelectionHandler;

		// Token: 0x04001211 RID: 4625
		private static readonly IntPtr NativeFieldInfoPtr_OnAttemptSubmitSelection;

		// Token: 0x04001212 RID: 4626
		private static readonly IntPtr NativeFieldInfoPtr_OnLocalSelectionTimedOut;

		// Token: 0x04001213 RID: 4627
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_New_get_UInt64_0;

		// Token: 0x04001214 RID: 4628
		private static readonly IntPtr NativeMethodInfoPtr_get_version_Protected_get_UInt64_0;

		// Token: 0x04001215 RID: 4629
		private static readonly IntPtr NativeMethodInfoPtr_set_version_Protected_set_Void_UInt64_0;

		// Token: 0x04001216 RID: 4630
		private static readonly IntPtr NativeMethodInfoPtr_get_currentSelectionHandler_Protected_Virtual_New_get_SelectionRootHandler_0;

		// Token: 0x04001217 RID: 4631
		private static readonly IntPtr NativeMethodInfoPtr_set_currentSelectionHandler_Protected_Virtual_New_set_Void_SelectionRootHandler_0;

		// Token: 0x04001218 RID: 4632
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSelectionHandler_Public_get_SelectionRootHandler_0;

		// Token: 0x04001219 RID: 4633
		private static readonly IntPtr NativeMethodInfoPtr_get_cachedChoice_Protected_get_ISelectionNode_0;

		// Token: 0x0400121A RID: 4634
		private static readonly IntPtr NativeMethodInfoPtr_get_selectionFilters_Protected_get_EntityComponent_0;

		// Token: 0x0400121B RID: 4635
		private static readonly IntPtr NativeMethodInfoPtr_get_selectionCommand_Protected_get_DBGSelectionCommand_0;

		// Token: 0x0400121C RID: 4636
		private static readonly IntPtr NativeMethodInfoPtr_get_interruptableCommand_Protected_get_InterruptableCommand_0;

		// Token: 0x0400121D RID: 4637
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSelection_Public_get_Boolean_0;

		// Token: 0x0400121E RID: 4638
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400121F RID: 4639
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04001220 RID: 4640
		private static readonly IntPtr NativeMethodInfoPtr_updateSelectionRootData_Protected_Void_SelectionRootHandler_0;

		// Token: 0x04001221 RID: 4641
		private static readonly IntPtr NativeMethodInfoPtr_getDefaultSelectionCommand_Protected_Virtual_New_DBGSelectionCommand_ISelectionNode_Boolean_0;

		// Token: 0x04001222 RID: 4642
		private static readonly IntPtr NativeMethodInfoPtr_FiltersActive_Public_Boolean_0;

		// Token: 0x04001223 RID: 4643
		private static readonly IntPtr NativeMethodInfoPtr_AttemptSubmitSelection_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x04001224 RID: 4644
		private static readonly IntPtr NativeMethodInfoPtr_AttemptSubmitSelection_Public_Virtual_New_Boolean_EntityID_0;

		// Token: 0x04001225 RID: 4645
		private static readonly IntPtr NativeMethodInfoPtr_ValidateSelection_Public_Boolean_Int32_0;

		// Token: 0x04001226 RID: 4646
		private static readonly IntPtr NativeMethodInfoPtr_ValidateSelection_Public_Boolean_EntityID_0;

		// Token: 0x04001227 RID: 4647
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAdvance_Public_Virtual_New_Boolean_0;

		// Token: 0x04001228 RID: 4648
		private static readonly IntPtr NativeMethodInfoPtr_AttemptCancel_Public_Boolean_0;

		// Token: 0x04001229 RID: 4649
		private static readonly IntPtr NativeMethodInfoPtr_MayAdvance_Public_Boolean_0;

		// Token: 0x0400122A RID: 4650
		private static readonly IntPtr NativeMethodInfoPtr_ValidateCancel_Public_Virtual_New_Boolean_0;

		// Token: 0x0400122B RID: 4651
		private static readonly IntPtr NativeMethodInfoPtr_MayCancel_Public_Boolean_0;

		// Token: 0x0400122C RID: 4652
		private static readonly IntPtr NativeMethodInfoPtr_GetOfferAttribute_Public_ReadOnlyAttribute_1_T_AttributeDefinition_1_T_0;

		// Token: 0x0400122D RID: 4653
		private static readonly IntPtr NativeMethodInfoPtr_AttemptAdvance_Public_Boolean_0;

		// Token: 0x0400122E RID: 4654
		private static readonly IntPtr NativeMethodInfoPtr_EntityIsSelectable_Public_Virtual_New_Boolean_EntityID_0;

		// Token: 0x0400122F RID: 4655
		private static readonly IntPtr NativeMethodInfoPtr_EntityIsPreviousSelection_Public_Virtual_New_Boolean_EntityID_0;

		// Token: 0x04001230 RID: 4656
		private static readonly IntPtr NativeMethodInfoPtr_HasUndo_Public_Boolean_EntityID_byref_Int32_0;

		// Token: 0x04001231 RID: 4657
		private static readonly IntPtr NativeMethodInfoPtr_Kind_Public_String_0;

		// Token: 0x04001232 RID: 4658
		private static readonly IntPtr NativeMethodInfoPtr_EntityIsSelectable_Public_Virtual_New_Boolean_EntityComponent_0;

		// Token: 0x04001233 RID: 4659
		private static readonly IntPtr NativeMethodInfoPtr_EntityHasLeafSelection_Public_Virtual_New_Boolean_EntityComponent_byref_ISelectionNode_0;

		// Token: 0x04001234 RID: 4660
		private static readonly IntPtr NativeMethodInfoPtr_MarkDirty_Public_Void_0;

		// Token: 0x04001235 RID: 4661
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001236 RID: 4662
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000466 RID: 1126
		private sealed class MethodInfoStoreGeneric_GetOfferAttribute_Public_ReadOnlyAttribute_1_T_AttributeDefinition_1_T_0<T>
		{
			// Token: 0x040020FB RID: 8443
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DBGSelectionResponder.NativeMethodInfoPtr_GetOfferAttribute_Public_ReadOnlyAttribute_1_T_AttributeDefinition_1_T_0, Il2CppClassPointerStore<DBGSelectionResponder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
