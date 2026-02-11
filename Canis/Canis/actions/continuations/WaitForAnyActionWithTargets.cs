using System;
using Canis.actions.serialized;
using Canis.context;
using Canis.data;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions.continuations
{
	// Token: 0x0200022D RID: 557
	public class WaitForAnyActionWithTargets : ActionContinuation
	{
		// Token: 0x0600172E RID: 5934 RVA: 0x0007650C File Offset: 0x0007470C
		// Note: this type is marked as 'beforefieldinit'.
		static WaitForAnyActionWithTargets()
		{
			Il2CppClassPointerStore<WaitForAnyActionWithTargets>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.continuations", "WaitForAnyActionWithTargets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForAnyActionWithTargets>.NativeClassPtr);
			WaitForAnyActionWithTargets.NativeFieldInfoPtr_ResolutionGen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAnyActionWithTargets>.NativeClassPtr, "ResolutionGen");
			WaitForAnyActionWithTargets.NativeFieldInfoPtr_ParentContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAnyActionWithTargets>.NativeClassPtr, "ParentContext");
			WaitForAnyActionWithTargets.NativeFieldInfoPtr_SkippedResolutionGen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAnyActionWithTargets>.NativeClassPtr, "SkippedResolutionGen");
			WaitForAnyActionWithTargets.NativeFieldInfoPtr_SelectingPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAnyActionWithTargets>.NativeClassPtr, "SelectingPlayers");
			WaitForAnyActionWithTargets.NativeFieldInfoPtr_ActiveWaitForSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAnyActionWithTargets>.NativeClassPtr, "ActiveWaitForSkip");
			WaitForAnyActionWithTargets.NativeMethodInfoPtr_Instance_Public_Static_WaitForAnyActionWithTargets_Action_Context_List_1_AccountID_Boolean_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAnyActionWithTargets>.NativeClassPtr, 100668565);
			WaitForAnyActionWithTargets.NativeMethodInfoPtr__ctor_Public_Void_SerializedAction_SerializedContext_SerializedAction_List_1_AccountID_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAnyActionWithTargets>.NativeClassPtr, 100668566);
			WaitForAnyActionWithTargets.NativeMethodInfoPtr_MakeActionsFromTypedResponses_Private_IEnumerable_1_ActionAcrossTargets_Il2CppReferenceArray_1_Object_PlayerEntity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAnyActionWithTargets>.NativeClassPtr, 100668567);
			WaitForAnyActionWithTargets.NativeMethodInfoPtr_MakeContinuationActions_Public_Virtual_IEnumerable_1_ActionAcrossTargets_IEnumerable_PlayerEntity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAnyActionWithTargets>.NativeClassPtr, 100668568);
			WaitForAnyActionWithTargets.NativeMethodInfoPtr_HandleOtherSelection_Public_Virtual_Final_New_Void_PlayerEntity_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAnyActionWithTargets>.NativeClassPtr, 100668569);
			WaitForAnyActionWithTargets.NativeMethodInfoPtr_RemainingSelectors_Public_IEnumerable_1_PlayerEntity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAnyActionWithTargets>.NativeClassPtr, 100668570);
			WaitForAnyActionWithTargets.NativeMethodInfoPtr_GenResolution_Protected_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAnyActionWithTargets>.NativeClassPtr, 100668571);
			WaitForAnyActionWithTargets.NativeMethodInfoPtr_GenParentContext_Protected_Context_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAnyActionWithTargets>.NativeClassPtr, 100668572);
			WaitForAnyActionWithTargets.NativeMethodInfoPtr_GenSkippedResolution_Protected_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAnyActionWithTargets>.NativeClassPtr, 100668573);
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00076654 File Offset: 0x00074854
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 594856, RefRangeEnd = 594857, XrefRangeStart = 594836, XrefRangeEnd = 594856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WaitForAnyActionWithTargets Instance(Action resolutionGen, Context parentContext, List<AccountID> selectingPlayers, bool activeWaitForSkip, Match match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resolutionGen);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentContext);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayers);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activeWaitForSkip;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAnyActionWithTargets.NativeMethodInfoPtr_Instance_Public_Static_WaitForAnyActionWithTargets_Action_Context_List_1_AccountID_Boolean_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitForAnyActionWithTargets>(intPtr3) : null;
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x000766E0 File Offset: 0x000748E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594857, XrefRangeEnd = 594865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitForAnyActionWithTargets(SerializedAction resolutionGen, SerializedContext parentContext, SerializedAction skippedResolutionGen, List<AccountID> selectingPlayers, bool activeWaitForSkip)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForAnyActionWithTargets>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resolutionGen);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentContext);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(skippedResolutionGen);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayers);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activeWaitForSkip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAnyActionWithTargets.NativeMethodInfoPtr__ctor_Public_Void_SerializedAction_SerializedContext_SerializedAction_List_1_AccountID_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x00076770 File Offset: 0x00074970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594865, XrefRangeEnd = 594874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ActionAcrossTargets> MakeActionsFromTypedResponses(Il2CppReferenceArray<Object> typedResponses, PlayerEntity selectingPlayer, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typedResponses);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAnyActionWithTargets.NativeMethodInfoPtr_MakeActionsFromTypedResponses_Private_IEnumerable_1_ActionAcrossTargets_Il2CppReferenceArray_1_Object_PlayerEntity_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ActionAcrossTargets>>(intPtr3) : null;
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x000767E4 File Offset: 0x000749E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594874, XrefRangeEnd = 594908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<ActionAcrossTargets> MakeContinuationActions(IEnumerable selectionResponse, PlayerEntity selectingPlayer, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectionResponse);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitForAnyActionWithTargets.NativeMethodInfoPtr_MakeContinuationActions_Public_Virtual_IEnumerable_1_ActionAcrossTargets_IEnumerable_PlayerEntity_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ActionAcrossTargets>>(intPtr3) : null;
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x00076864 File Offset: 0x00074A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594908, XrefRangeEnd = 594912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HandleOtherSelection(PlayerEntity selectingPlayer, PendingSelection otherSelection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(otherSelection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAnyActionWithTargets.NativeMethodInfoPtr_HandleOtherSelection_Public_Virtual_Final_New_Void_PlayerEntity_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x000768B8 File Offset: 0x00074AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594912, XrefRangeEnd = 594927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<PlayerEntity> RemainingSelectors(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAnyActionWithTargets.NativeMethodInfoPtr_RemainingSelectors_Public_IEnumerable_1_PlayerEntity_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x00076908 File Offset: 0x00074B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action GenResolution(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAnyActionWithTargets.NativeMethodInfoPtr_GenResolution_Protected_Action_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x00076958 File Offset: 0x00074B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Context GenParentContext(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAnyActionWithTargets.NativeMethodInfoPtr_GenParentContext_Protected_Context_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x000769A8 File Offset: 0x00074BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action GenSkippedResolution(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAnyActionWithTargets.NativeMethodInfoPtr_GenSkippedResolution_Protected_Action_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x0000B167 File Offset: 0x00009367
		public WaitForAnyActionWithTargets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001739 RID: 5945 RVA: 0x000769F8 File Offset: 0x00074BF8
		// (set) Token: 0x0600173A RID: 5946 RVA: 0x0000B170 File Offset: 0x00009370
		public unsafe SerializedAction ResolutionGen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets.NativeFieldInfoPtr_ResolutionGen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets.NativeFieldInfoPtr_ResolutionGen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x0600173B RID: 5947 RVA: 0x00076A28 File Offset: 0x00074C28
		// (set) Token: 0x0600173C RID: 5948 RVA: 0x0000B18F File Offset: 0x0000938F
		public unsafe SerializedContext ParentContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets.NativeFieldInfoPtr_ParentContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets.NativeFieldInfoPtr_ParentContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x0600173D RID: 5949 RVA: 0x00076A58 File Offset: 0x00074C58
		// (set) Token: 0x0600173E RID: 5950 RVA: 0x0000B1AE File Offset: 0x000093AE
		public unsafe SerializedAction SkippedResolutionGen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets.NativeFieldInfoPtr_SkippedResolutionGen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets.NativeFieldInfoPtr_SkippedResolutionGen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x0600173F RID: 5951 RVA: 0x00076A88 File Offset: 0x00074C88
		// (set) Token: 0x06001740 RID: 5952 RVA: 0x0000B1CD File Offset: 0x000093CD
		public unsafe List<AccountID> SelectingPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets.NativeFieldInfoPtr_SelectingPlayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AccountID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets.NativeFieldInfoPtr_SelectingPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001741 RID: 5953 RVA: 0x00076AB8 File Offset: 0x00074CB8
		// (set) Token: 0x06001742 RID: 5954 RVA: 0x0000B1EC File Offset: 0x000093EC
		public unsafe bool ActiveWaitForSkip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets.NativeFieldInfoPtr_ActiveWaitForSkip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets.NativeFieldInfoPtr_ActiveWaitForSkip)) = value;
			}
		}

		// Token: 0x04000EDF RID: 3807
		private static readonly IntPtr NativeFieldInfoPtr_ResolutionGen;

		// Token: 0x04000EE0 RID: 3808
		private static readonly IntPtr NativeFieldInfoPtr_ParentContext;

		// Token: 0x04000EE1 RID: 3809
		private static readonly IntPtr NativeFieldInfoPtr_SkippedResolutionGen;

		// Token: 0x04000EE2 RID: 3810
		private static readonly IntPtr NativeFieldInfoPtr_SelectingPlayers;

		// Token: 0x04000EE3 RID: 3811
		private static readonly IntPtr NativeFieldInfoPtr_ActiveWaitForSkip;

		// Token: 0x04000EE4 RID: 3812
		private static readonly IntPtr NativeMethodInfoPtr_Instance_Public_Static_WaitForAnyActionWithTargets_Action_Context_List_1_AccountID_Boolean_Match_0;

		// Token: 0x04000EE5 RID: 3813
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedAction_SerializedContext_SerializedAction_List_1_AccountID_Boolean_0;

		// Token: 0x04000EE6 RID: 3814
		private static readonly IntPtr NativeMethodInfoPtr_MakeActionsFromTypedResponses_Private_IEnumerable_1_ActionAcrossTargets_Il2CppReferenceArray_1_Object_PlayerEntity_Match_0;

		// Token: 0x04000EE7 RID: 3815
		private static readonly IntPtr NativeMethodInfoPtr_MakeContinuationActions_Public_Virtual_IEnumerable_1_ActionAcrossTargets_IEnumerable_PlayerEntity_Match_0;

		// Token: 0x04000EE8 RID: 3816
		private static readonly IntPtr NativeMethodInfoPtr_HandleOtherSelection_Public_Virtual_Final_New_Void_PlayerEntity_PendingSelection_0;

		// Token: 0x04000EE9 RID: 3817
		private static readonly IntPtr NativeMethodInfoPtr_RemainingSelectors_Public_IEnumerable_1_PlayerEntity_Match_0;

		// Token: 0x04000EEA RID: 3818
		private static readonly IntPtr NativeMethodInfoPtr_GenResolution_Protected_Action_Match_0;

		// Token: 0x04000EEB RID: 3819
		private static readonly IntPtr NativeMethodInfoPtr_GenParentContext_Protected_Context_Match_0;

		// Token: 0x04000EEC RID: 3820
		private static readonly IntPtr NativeMethodInfoPtr_GenSkippedResolution_Protected_Action_Match_0;

		// Token: 0x02000473 RID: 1139
		[ObfuscatedName("Canis.actions.continuations.WaitForAnyActionWithTargets+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x060032F3 RID: 13043 RVA: 0x000D0DA4 File Offset: 0x000CEFA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<WaitForAnyActionWithTargets.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaitForAnyActionWithTargets>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForAnyActionWithTargets.__c__DisplayClass10_0>.NativeClassPtr);
				WaitForAnyActionWithTargets.__c__DisplayClass10_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAnyActionWithTargets.__c__DisplayClass10_0>.NativeClassPtr, "match");
				WaitForAnyActionWithTargets.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAnyActionWithTargets.__c__DisplayClass10_0>.NativeClassPtr, 100668574);
				WaitForAnyActionWithTargets.__c__DisplayClass10_0.NativeMethodInfoPtr__RemainingSelectors_b__0_Internal_IEnumerable_1_PlayerEntity_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAnyActionWithTargets.__c__DisplayClass10_0>.NativeClassPtr, 100668575);
			}

			// Token: 0x060032F4 RID: 13044 RVA: 0x000D0E0C File Offset: 0x000CF00C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForAnyActionWithTargets.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAnyActionWithTargets.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032F5 RID: 13045 RVA: 0x000D0E48 File Offset: 0x000CF048
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594802, XrefRangeEnd = 594812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<PlayerEntity> _RemainingSelectors_b__0(AccountID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAnyActionWithTargets.__c__DisplayClass10_0.NativeMethodInfoPtr__RemainingSelectors_b__0_Internal_IEnumerable_1_PlayerEntity_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
				}
			}

			// Token: 0x060032F6 RID: 13046 RVA: 0x0001871D File Offset: 0x0001691D
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D84 RID: 3460
			// (get) Token: 0x060032F7 RID: 13047 RVA: 0x000D0E98 File Offset: 0x000CF098
			// (set) Token: 0x060032F8 RID: 13048 RVA: 0x00018726 File Offset: 0x00016926
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets.__c__DisplayClass10_0.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets.__c__DisplayClass10_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FD5 RID: 8149
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04001FD6 RID: 8150
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001FD7 RID: 8151
			private static readonly IntPtr NativeMethodInfoPtr__RemainingSelectors_b__0_Internal_IEnumerable_1_PlayerEntity_AccountID_0;
		}

		// Token: 0x02000474 RID: 1140
		[ObfuscatedName("Canis.actions.continuations.WaitForAnyActionWithTargets+<MakeActionsFromTypedResponses>d__7")]
		public sealed class _MakeActionsFromTypedResponses_d__7 : Object
		{
			// Token: 0x060032F9 RID: 13049 RVA: 0x000D0EC8 File Offset: 0x000CF0C8
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeActionsFromTypedResponses_d__7()
			{
				Il2CppClassPointerStore<WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaitForAnyActionWithTargets>.NativeClassPtr, "<MakeActionsFromTypedResponses>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7>.NativeClassPtr);
				WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7>.NativeClassPtr, "<>1__state");
				WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7>.NativeClassPtr, "<>2__current");
				WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7>.NativeClassPtr, "<>l__initialThreadId");
				WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7>.NativeClassPtr, "<>4__this");
				WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7>.NativeClassPtr, "match");
				WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7>.NativeClassPtr, "<>3__match");
				WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr_selectingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7>.NativeClassPtr, "selectingPlayer");
				WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr___3__selectingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7>.NativeClassPtr, "<>3__selectingPlayer");
				WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr_typedResponses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7>.NativeClassPtr, "typedResponses");
				WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr___3__typedResponses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7>.NativeClassPtr, "<>3__typedResponses");
				WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7>.NativeClassPtr, 100668576);
				WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7>.NativeClassPtr, 100668577);
				WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7>.NativeClassPtr, 100668578);
				WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_continuations_ActionAcrossTargets__get_Current_Private_Virtual_Final_New_get_ActionAcrossTargets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7>.NativeClassPtr, 100668579);
				WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7>.NativeClassPtr, 100668580);
				WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7>.NativeClassPtr, 100668581);
				WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_continuations_ActionAcrossTargets__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ActionAcrossTargets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7>.NativeClassPtr, 100668582);
				WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7>.NativeClassPtr, 100668583);
			}

			// Token: 0x060032FA RID: 13050 RVA: 0x000D105C File Offset: 0x000CF25C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeActionsFromTypedResponses_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032FB RID: 13051 RVA: 0x000D10A4 File Offset: 0x000CF2A4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032FC RID: 13052 RVA: 0x000D10D8 File Offset: 0x000CF2D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594812, XrefRangeEnd = 594820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D8F RID: 3471
			// (get) Token: 0x060032FD RID: 13053 RVA: 0x000D1114 File Offset: 0x000CF314
			public unsafe ActionAcrossTargets System.Collections.Generic.IEnumerator<Canis.actions.continuations.ActionAcrossTargets>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_continuations_ActionAcrossTargets__get_Current_Private_Virtual_Final_New_get_ActionAcrossTargets_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionAcrossTargets>(intPtr3) : null;
				}
			}

			// Token: 0x060032FE RID: 13054 RVA: 0x000D1154 File Offset: 0x000CF354
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594820, XrefRangeEnd = 594825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D90 RID: 3472
			// (get) Token: 0x060032FF RID: 13055 RVA: 0x000D1188 File Offset: 0x000CF388
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003300 RID: 13056 RVA: 0x000D11C8 File Offset: 0x000CF3C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594825, XrefRangeEnd = 594836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ActionAcrossTargets> System_Collections_Generic_IEnumerable_Canis_actions_continuations_ActionAcrossTargets__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_continuations_ActionAcrossTargets__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ActionAcrossTargets_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ActionAcrossTargets>>(intPtr3) : null;
			}

			// Token: 0x06003301 RID: 13057 RVA: 0x000D1208 File Offset: 0x000CF408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06003302 RID: 13058 RVA: 0x00018745 File Offset: 0x00016945
			public _MakeActionsFromTypedResponses_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D85 RID: 3461
			// (get) Token: 0x06003303 RID: 13059 RVA: 0x000D1248 File Offset: 0x000CF448
			// (set) Token: 0x06003304 RID: 13060 RVA: 0x0001874E File Offset: 0x0001694E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D86 RID: 3462
			// (get) Token: 0x06003305 RID: 13061 RVA: 0x000D1270 File Offset: 0x000CF470
			// (set) Token: 0x06003306 RID: 13062 RVA: 0x00018769 File Offset: 0x00016969
			public unsafe ActionAcrossTargets __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionAcrossTargets>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D87 RID: 3463
			// (get) Token: 0x06003307 RID: 13063 RVA: 0x000D12A0 File Offset: 0x000CF4A0
			// (set) Token: 0x06003308 RID: 13064 RVA: 0x00018788 File Offset: 0x00016988
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000D88 RID: 3464
			// (get) Token: 0x06003309 RID: 13065 RVA: 0x000D12C8 File Offset: 0x000CF4C8
			// (set) Token: 0x0600330A RID: 13066 RVA: 0x000187A3 File Offset: 0x000169A3
			public unsafe WaitForAnyActionWithTargets __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForAnyActionWithTargets>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D89 RID: 3465
			// (get) Token: 0x0600330B RID: 13067 RVA: 0x000D12F8 File Offset: 0x000CF4F8
			// (set) Token: 0x0600330C RID: 13068 RVA: 0x000187C2 File Offset: 0x000169C2
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D8A RID: 3466
			// (get) Token: 0x0600330D RID: 13069 RVA: 0x000D1328 File Offset: 0x000CF528
			// (set) Token: 0x0600330E RID: 13070 RVA: 0x000187E1 File Offset: 0x000169E1
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D8B RID: 3467
			// (get) Token: 0x0600330F RID: 13071 RVA: 0x000D1358 File Offset: 0x000CF558
			// (set) Token: 0x06003310 RID: 13072 RVA: 0x00018800 File Offset: 0x00016A00
			public unsafe PlayerEntity selectingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr_selectingPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr_selectingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D8C RID: 3468
			// (get) Token: 0x06003311 RID: 13073 RVA: 0x000D1388 File Offset: 0x000CF588
			// (set) Token: 0x06003312 RID: 13074 RVA: 0x0001881F File Offset: 0x00016A1F
			public unsafe PlayerEntity __3__selectingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr___3__selectingPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr___3__selectingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D8D RID: 3469
			// (get) Token: 0x06003313 RID: 13075 RVA: 0x000D13B8 File Offset: 0x000CF5B8
			// (set) Token: 0x06003314 RID: 13076 RVA: 0x0001883E File Offset: 0x00016A3E
			public unsafe Il2CppReferenceArray<Object> typedResponses
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr_typedResponses);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr_typedResponses), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D8E RID: 3470
			// (get) Token: 0x06003315 RID: 13077 RVA: 0x000D13E8 File Offset: 0x000CF5E8
			// (set) Token: 0x06003316 RID: 13078 RVA: 0x0001885D File Offset: 0x00016A5D
			public unsafe Il2CppReferenceArray<Object> __3__typedResponses
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr___3__typedResponses);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAnyActionWithTargets._MakeActionsFromTypedResponses_d__7.NativeFieldInfoPtr___3__typedResponses), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FD8 RID: 8152
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001FD9 RID: 8153
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001FDA RID: 8154
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001FDB RID: 8155
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001FDC RID: 8156
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04001FDD RID: 8157
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04001FDE RID: 8158
			private static readonly IntPtr NativeFieldInfoPtr_selectingPlayer;

			// Token: 0x04001FDF RID: 8159
			private static readonly IntPtr NativeFieldInfoPtr___3__selectingPlayer;

			// Token: 0x04001FE0 RID: 8160
			private static readonly IntPtr NativeFieldInfoPtr_typedResponses;

			// Token: 0x04001FE1 RID: 8161
			private static readonly IntPtr NativeFieldInfoPtr___3__typedResponses;

			// Token: 0x04001FE2 RID: 8162
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001FE3 RID: 8163
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FE4 RID: 8164
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001FE5 RID: 8165
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_continuations_ActionAcrossTargets__get_Current_Private_Virtual_Final_New_get_ActionAcrossTargets_0;

			// Token: 0x04001FE6 RID: 8166
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FE7 RID: 8167
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001FE8 RID: 8168
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_continuations_ActionAcrossTargets__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ActionAcrossTargets_0;

			// Token: 0x04001FE9 RID: 8169
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
