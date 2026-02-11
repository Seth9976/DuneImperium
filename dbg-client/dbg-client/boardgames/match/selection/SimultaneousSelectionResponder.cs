using System;
using Canis.utils.ids;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace boardgames.match.selection
{
	// Token: 0x02000271 RID: 625
	public class SimultaneousSelectionResponder : DBGSelectionResponder
	{
		// Token: 0x06001D31 RID: 7473 RVA: 0x0007E790 File Offset: 0x0007C990
		// Note: this type is marked as 'beforefieldinit'.
		static SimultaneousSelectionResponder()
		{
			Il2CppClassPointerStore<SimultaneousSelectionResponder>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.selection", "SimultaneousSelectionResponder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimultaneousSelectionResponder>.NativeClassPtr);
			SimultaneousSelectionResponder.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimultaneousSelectionResponder>.NativeClassPtr, "selection");
			SimultaneousSelectionResponder.NativeFieldInfoPtr_playerSelectionDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimultaneousSelectionResponder>.NativeClassPtr, "playerSelectionDatas");
			SimultaneousSelectionResponder.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelectionResponder>.NativeClassPtr, 100668091);
			SimultaneousSelectionResponder.NativeMethodInfoPtr_getSelectionVersions_Private_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelectionResponder>.NativeClassPtr, 100668092);
			SimultaneousSelectionResponder.NativeMethodInfoPtr_get_currentSelectionHandler_Protected_Virtual_get_SelectionRootHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelectionResponder>.NativeClassPtr, 100668093);
			SimultaneousSelectionResponder.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelectionResponder>.NativeClassPtr, 100668094);
			SimultaneousSelectionResponder.NativeMethodInfoPtr_startSelection_Private_Void_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelectionResponder>.NativeClassPtr, 100668095);
			SimultaneousSelectionResponder.NativeMethodInfoPtr_EntityIsSelectable_Public_Virtual_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelectionResponder>.NativeClassPtr, 100668096);
			SimultaneousSelectionResponder.NativeMethodInfoPtr_AttemptSubmitSelection_Public_Virtual_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelectionResponder>.NativeClassPtr, 100668097);
			SimultaneousSelectionResponder.NativeMethodInfoPtr_GetSelectionHandlerForPlayer_Public_SelectionRootHandler_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelectionResponder>.NativeClassPtr, 100668098);
			SimultaneousSelectionResponder.NativeMethodInfoPtr_GetSelectionHandlerForSelectionRoot_Public_SelectionRootHandler_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelectionResponder>.NativeClassPtr, 100668099);
			SimultaneousSelectionResponder.NativeMethodInfoPtr_GetAccountIDForSelectionRoot_Public_AccountID_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelectionResponder>.NativeClassPtr, 100668100);
			SimultaneousSelectionResponder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelectionResponder>.NativeClassPtr, 100668101);
			SimultaneousSelectionResponder.NativeMethodInfoPtr__LateUpdate_b__7_0_Private_Boolean_KeyValuePair_2_AccountID_SelectionRootHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelectionResponder>.NativeClassPtr, 100668102);
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06001D32 RID: 7474 RVA: 0x0007E8D8 File Offset: 0x0007CAD8
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536606, XrefRangeEnd = 536607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SimultaneousSelectionResponder.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x0007E920 File Offset: 0x0007CB20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 536622, RefRangeEnd = 536623, XrefRangeStart = 536607, XrefRangeEnd = 536622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong getSelectionVersions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousSelectionResponder.NativeMethodInfoPtr_getSelectionVersions_Private_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06001D34 RID: 7476 RVA: 0x0007E95C File Offset: 0x0007CB5C
		public unsafe override SelectionRootHandler currentSelectionHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536623, XrefRangeEnd = 536630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SimultaneousSelectionResponder.NativeMethodInfoPtr_get_currentSelectionHandler_Protected_Virtual_get_SelectionRootHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionRootHandler>(intPtr3) : null;
			}
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x0007E9A8 File Offset: 0x0007CBA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536630, XrefRangeEnd = 536717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SimultaneousSelectionResponder.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x0007E9E4 File Offset: 0x0007CBE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 536727, RefRangeEnd = 536728, XrefRangeStart = 536717, XrefRangeEnd = 536727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void startSelection(ISelectionRoot selectionRoot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectionRoot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousSelectionResponder.NativeMethodInfoPtr_startSelection_Private_Void_ISelectionRoot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x0007EA28 File Offset: 0x0007CC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536728, XrefRangeEnd = 536740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool EntityIsSelectable(EntityID entityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SimultaneousSelectionResponder.NativeMethodInfoPtr_EntityIsSelectable_Public_Virtual_Boolean_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x0007EA80 File Offset: 0x0007CC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536740, XrefRangeEnd = 536752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool AttemptSubmitSelection(EntityID entityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SimultaneousSelectionResponder.NativeMethodInfoPtr_AttemptSubmitSelection_Public_Virtual_Boolean_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x0007EAD8 File Offset: 0x0007CCD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536752, XrefRangeEnd = 536755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionRootHandler GetSelectionHandlerForPlayer(AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousSelectionResponder.NativeMethodInfoPtr_GetSelectionHandlerForPlayer_Public_SelectionRootHandler_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionRootHandler>(intPtr3) : null;
			}
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x0007EB28 File Offset: 0x0007CD28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536755, XrefRangeEnd = 536770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionRootHandler GetSelectionHandlerForSelectionRoot(ISelectionRoot selectionRoot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectionRoot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousSelectionResponder.NativeMethodInfoPtr_GetSelectionHandlerForSelectionRoot_Public_SelectionRootHandler_ISelectionRoot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionRootHandler>(intPtr3) : null;
			}
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x0007EB78 File Offset: 0x0007CD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536770, XrefRangeEnd = 536785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccountID GetAccountIDForSelectionRoot(ISelectionRoot selectionRoot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectionRoot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousSelectionResponder.NativeMethodInfoPtr_GetAccountIDForSelectionRoot_Public_AccountID_ISelectionRoot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
			}
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x0007EBC8 File Offset: 0x0007CDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536785, XrefRangeEnd = 536798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimultaneousSelectionResponder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimultaneousSelectionResponder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousSelectionResponder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x0007EC04 File Offset: 0x0007CE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536798, XrefRangeEnd = 536802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _LateUpdate_b__7_0(KeyValuePair<AccountID, SelectionRootHandler> sd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sd));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousSelectionResponder.NativeMethodInfoPtr__LateUpdate_b__7_0_Private_Boolean_KeyValuePair_2_AccountID_SelectionRootHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x0000F848 File Offset: 0x0000DA48
		public SimultaneousSelectionResponder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06001D3F RID: 7487 RVA: 0x0007EC58 File Offset: 0x0007CE58
		// (set) Token: 0x06001D40 RID: 7488 RVA: 0x0000F851 File Offset: 0x0000DA51
		public new unsafe SimultaneousSelection selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousSelectionResponder.NativeFieldInfoPtr_selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimultaneousSelection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousSelectionResponder.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06001D41 RID: 7489 RVA: 0x0007EC88 File Offset: 0x0007CE88
		// (set) Token: 0x06001D42 RID: 7490 RVA: 0x0000F870 File Offset: 0x0000DA70
		public unsafe Dictionary<AccountID, SelectionRootHandler> playerSelectionDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousSelectionResponder.NativeFieldInfoPtr_playerSelectionDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, SelectionRootHandler>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousSelectionResponder.NativeFieldInfoPtr_playerSelectionDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400126A RID: 4714
		private static readonly IntPtr NativeFieldInfoPtr_selection;

		// Token: 0x0400126B RID: 4715
		private static readonly IntPtr NativeFieldInfoPtr_playerSelectionDatas;

		// Token: 0x0400126C RID: 4716
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x0400126D RID: 4717
		private static readonly IntPtr NativeMethodInfoPtr_getSelectionVersions_Private_UInt64_0;

		// Token: 0x0400126E RID: 4718
		private static readonly IntPtr NativeMethodInfoPtr_get_currentSelectionHandler_Protected_Virtual_get_SelectionRootHandler_0;

		// Token: 0x0400126F RID: 4719
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0;

		// Token: 0x04001270 RID: 4720
		private static readonly IntPtr NativeMethodInfoPtr_startSelection_Private_Void_ISelectionRoot_0;

		// Token: 0x04001271 RID: 4721
		private static readonly IntPtr NativeMethodInfoPtr_EntityIsSelectable_Public_Virtual_Boolean_EntityID_0;

		// Token: 0x04001272 RID: 4722
		private static readonly IntPtr NativeMethodInfoPtr_AttemptSubmitSelection_Public_Virtual_Boolean_EntityID_0;

		// Token: 0x04001273 RID: 4723
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectionHandlerForPlayer_Public_SelectionRootHandler_AccountID_0;

		// Token: 0x04001274 RID: 4724
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectionHandlerForSelectionRoot_Public_SelectionRootHandler_ISelectionRoot_0;

		// Token: 0x04001275 RID: 4725
		private static readonly IntPtr NativeMethodInfoPtr_GetAccountIDForSelectionRoot_Public_AccountID_ISelectionRoot_0;

		// Token: 0x04001276 RID: 4726
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001277 RID: 4727
		private static readonly IntPtr NativeMethodInfoPtr__LateUpdate_b__7_0_Private_Boolean_KeyValuePair_2_AccountID_SelectionRootHandler_0;

		// Token: 0x02000469 RID: 1129
		[ObfuscatedName("boardgames.match.selection.SimultaneousSelectionResponder+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600358E RID: 13710 RVA: 0x000C8784 File Offset: 0x000C6984
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SimultaneousSelectionResponder.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimultaneousSelectionResponder>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimultaneousSelectionResponder.__c>.NativeClassPtr);
				SimultaneousSelectionResponder.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimultaneousSelectionResponder.__c>.NativeClassPtr, "<>9");
				SimultaneousSelectionResponder.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimultaneousSelectionResponder.__c>.NativeClassPtr, "<>9__7_1");
				SimultaneousSelectionResponder.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelectionResponder.__c>.NativeClassPtr, 100668104);
				SimultaneousSelectionResponder.__c.NativeMethodInfoPtr__LateUpdate_b__7_1_Internal_AccountID_KeyValuePair_2_AccountID_SelectionRootHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelectionResponder.__c>.NativeClassPtr, 100668105);
			}

			// Token: 0x0600358F RID: 13711 RVA: 0x000C8800 File Offset: 0x000C6A00
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimultaneousSelectionResponder.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousSelectionResponder.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003590 RID: 13712 RVA: 0x000C883C File Offset: 0x000C6A3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536603, XrefRangeEnd = 536604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AccountID _LateUpdate_b__7_1(KeyValuePair<AccountID, SelectionRootHandler> sd)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sd));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousSelectionResponder.__c.NativeMethodInfoPtr__LateUpdate_b__7_1_Internal_AccountID_KeyValuePair_2_AccountID_SelectionRootHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x06003591 RID: 13713 RVA: 0x0001BA1F File Offset: 0x00019C1F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FBB RID: 4027
			// (get) Token: 0x06003592 RID: 13714 RVA: 0x000C8894 File Offset: 0x000C6A94
			// (set) Token: 0x06003593 RID: 13715 RVA: 0x0001BA28 File Offset: 0x00019C28
			public unsafe static SimultaneousSelectionResponder.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SimultaneousSelectionResponder.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimultaneousSelectionResponder.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SimultaneousSelectionResponder.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FBC RID: 4028
			// (get) Token: 0x06003594 RID: 13716 RVA: 0x000C88BC File Offset: 0x000C6ABC
			// (set) Token: 0x06003595 RID: 13717 RVA: 0x0001BA3A File Offset: 0x00019C3A
			public unsafe static Func<KeyValuePair<AccountID, SelectionRootHandler>, AccountID> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SimultaneousSelectionResponder.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<AccountID, SelectionRootHandler>, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SimultaneousSelectionResponder.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002100 RID: 8448
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002101 RID: 8449
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x04002102 RID: 8450
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002103 RID: 8451
			private static readonly IntPtr NativeMethodInfoPtr__LateUpdate_b__7_1_Internal_AccountID_KeyValuePair_2_AccountID_SelectionRootHandler_0;
		}

		// Token: 0x0200046A RID: 1130
		[ObfuscatedName("boardgames.match.selection.SimultaneousSelectionResponder+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x06003596 RID: 13718 RVA: 0x000C88E4 File Offset: 0x000C6AE4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<SimultaneousSelectionResponder.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimultaneousSelectionResponder>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimultaneousSelectionResponder.__c__DisplayClass12_0>.NativeClassPtr);
				SimultaneousSelectionResponder.__c__DisplayClass12_0.NativeFieldInfoPtr_selectionRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimultaneousSelectionResponder.__c__DisplayClass12_0>.NativeClassPtr, "selectionRoot");
				SimultaneousSelectionResponder.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelectionResponder.__c__DisplayClass12_0>.NativeClassPtr, 100668106);
				SimultaneousSelectionResponder.__c__DisplayClass12_0.NativeMethodInfoPtr__GetSelectionHandlerForSelectionRoot_b__0_Internal_Boolean_KeyValuePair_2_AccountID_SelectionRootHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelectionResponder.__c__DisplayClass12_0>.NativeClassPtr, 100668107);
			}

			// Token: 0x06003597 RID: 13719 RVA: 0x000C894C File Offset: 0x000C6B4C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimultaneousSelectionResponder.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousSelectionResponder.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003598 RID: 13720 RVA: 0x000C8988 File Offset: 0x000C6B88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536604, XrefRangeEnd = 536605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetSelectionHandlerForSelectionRoot_b__0(KeyValuePair<AccountID, SelectionRootHandler> p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(p));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousSelectionResponder.__c__DisplayClass12_0.NativeMethodInfoPtr__GetSelectionHandlerForSelectionRoot_b__0_Internal_Boolean_KeyValuePair_2_AccountID_SelectionRootHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003599 RID: 13721 RVA: 0x0001BA4C File Offset: 0x00019C4C
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FBD RID: 4029
			// (get) Token: 0x0600359A RID: 13722 RVA: 0x000C89DC File Offset: 0x000C6BDC
			// (set) Token: 0x0600359B RID: 13723 RVA: 0x0001BA55 File Offset: 0x00019C55
			public unsafe ISelectionRoot selectionRoot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousSelectionResponder.__c__DisplayClass12_0.NativeFieldInfoPtr_selectionRoot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectionRoot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousSelectionResponder.__c__DisplayClass12_0.NativeFieldInfoPtr_selectionRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002104 RID: 8452
			private static readonly IntPtr NativeFieldInfoPtr_selectionRoot;

			// Token: 0x04002105 RID: 8453
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002106 RID: 8454
			private static readonly IntPtr NativeMethodInfoPtr__GetSelectionHandlerForSelectionRoot_b__0_Internal_Boolean_KeyValuePair_2_AccountID_SelectionRootHandler_0;
		}

		// Token: 0x0200046B RID: 1131
		[ObfuscatedName("boardgames.match.selection.SimultaneousSelectionResponder+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x0600359C RID: 13724 RVA: 0x000C8A0C File Offset: 0x000C6C0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<SimultaneousSelectionResponder.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimultaneousSelectionResponder>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimultaneousSelectionResponder.__c__DisplayClass13_0>.NativeClassPtr);
				SimultaneousSelectionResponder.__c__DisplayClass13_0.NativeFieldInfoPtr_selectionRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimultaneousSelectionResponder.__c__DisplayClass13_0>.NativeClassPtr, "selectionRoot");
				SimultaneousSelectionResponder.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelectionResponder.__c__DisplayClass13_0>.NativeClassPtr, 100668108);
				SimultaneousSelectionResponder.__c__DisplayClass13_0.NativeMethodInfoPtr__GetAccountIDForSelectionRoot_b__0_Internal_Boolean_KeyValuePair_2_AccountID_SelectionRootHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelectionResponder.__c__DisplayClass13_0>.NativeClassPtr, 100668109);
			}

			// Token: 0x0600359D RID: 13725 RVA: 0x000C8A74 File Offset: 0x000C6C74
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimultaneousSelectionResponder.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousSelectionResponder.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600359E RID: 13726 RVA: 0x000C8AB0 File Offset: 0x000C6CB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536605, XrefRangeEnd = 536606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAccountIDForSelectionRoot_b__0(KeyValuePair<AccountID, SelectionRootHandler> p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(p));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousSelectionResponder.__c__DisplayClass13_0.NativeMethodInfoPtr__GetAccountIDForSelectionRoot_b__0_Internal_Boolean_KeyValuePair_2_AccountID_SelectionRootHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600359F RID: 13727 RVA: 0x0001BA74 File Offset: 0x00019C74
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FBE RID: 4030
			// (get) Token: 0x060035A0 RID: 13728 RVA: 0x000C8B04 File Offset: 0x000C6D04
			// (set) Token: 0x060035A1 RID: 13729 RVA: 0x0001BA7D File Offset: 0x00019C7D
			public unsafe ISelectionRoot selectionRoot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousSelectionResponder.__c__DisplayClass13_0.NativeFieldInfoPtr_selectionRoot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectionRoot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousSelectionResponder.__c__DisplayClass13_0.NativeFieldInfoPtr_selectionRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002107 RID: 8455
			private static readonly IntPtr NativeFieldInfoPtr_selectionRoot;

			// Token: 0x04002108 RID: 8456
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002109 RID: 8457
			private static readonly IntPtr NativeMethodInfoPtr__GetAccountIDForSelectionRoot_b__0_Internal_Boolean_KeyValuePair_2_AccountID_SelectionRootHandler_0;
		}
	}
}
