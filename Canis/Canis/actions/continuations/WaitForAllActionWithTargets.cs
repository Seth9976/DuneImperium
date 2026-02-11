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
	// Token: 0x0200022C RID: 556
	public class WaitForAllActionWithTargets : ActionContinuation
	{
		// Token: 0x0600171A RID: 5914 RVA: 0x00075FC0 File Offset: 0x000741C0
		// Note: this type is marked as 'beforefieldinit'.
		static WaitForAllActionWithTargets()
		{
			Il2CppClassPointerStore<WaitForAllActionWithTargets>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.continuations", "WaitForAllActionWithTargets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForAllActionWithTargets>.NativeClassPtr);
			WaitForAllActionWithTargets.NativeFieldInfoPtr_ResolutionGen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAllActionWithTargets>.NativeClassPtr, "ResolutionGen");
			WaitForAllActionWithTargets.NativeFieldInfoPtr_ParentContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAllActionWithTargets>.NativeClassPtr, "ParentContext");
			WaitForAllActionWithTargets.NativeFieldInfoPtr_SkippedResolutionGen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAllActionWithTargets>.NativeClassPtr, "SkippedResolutionGen");
			WaitForAllActionWithTargets.NativeFieldInfoPtr_RequiredSelectorIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAllActionWithTargets>.NativeClassPtr, "RequiredSelectorIDs");
			WaitForAllActionWithTargets.NativeFieldInfoPtr_CurrentResponses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAllActionWithTargets>.NativeClassPtr, "CurrentResponses");
			WaitForAllActionWithTargets.NativeMethodInfoPtr_Instance_Public_Static_WaitForAllActionWithTargets_Action_IEnumerable_1_PlayerEntity_Context_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAllActionWithTargets>.NativeClassPtr, 100668541);
			WaitForAllActionWithTargets.NativeMethodInfoPtr__ctor_Public_Void_SerializedAction_SerializedContext_SerializedAction_List_1_EntityID_Dictionary_2_EntityID_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAllActionWithTargets>.NativeClassPtr, 100668542);
			WaitForAllActionWithTargets.NativeMethodInfoPtr_MakeContinuationActions_Public_Virtual_IEnumerable_1_ActionAcrossTargets_IEnumerable_PlayerEntity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAllActionWithTargets>.NativeClassPtr, 100668543);
			WaitForAllActionWithTargets.NativeMethodInfoPtr_HandleOtherSelection_Public_Virtual_Final_New_Void_PlayerEntity_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAllActionWithTargets>.NativeClassPtr, 100668544);
			WaitForAllActionWithTargets.NativeMethodInfoPtr_GetResponsesForPlayer_Public_Il2CppReferenceArray_1_Object_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAllActionWithTargets>.NativeClassPtr, 100668545);
			WaitForAllActionWithTargets.NativeMethodInfoPtr_GenResolution_Protected_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAllActionWithTargets>.NativeClassPtr, 100668546);
			WaitForAllActionWithTargets.NativeMethodInfoPtr_GenParentContext_Protected_Context_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAllActionWithTargets>.NativeClassPtr, 100668547);
			WaitForAllActionWithTargets.NativeMethodInfoPtr_GenSkippedResolution_Protected_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAllActionWithTargets>.NativeClassPtr, 100668548);
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x000760F4 File Offset: 0x000742F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 594729, RefRangeEnd = 594730, XrefRangeStart = 594684, XrefRangeEnd = 594729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WaitForAllActionWithTargets Instance(Action resolutionGen, IEnumerable<PlayerEntity> requiredSelectors, Context parentContext, Match match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resolutionGen);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requiredSelectors);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentContext);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAllActionWithTargets.NativeMethodInfoPtr_Instance_Public_Static_WaitForAllActionWithTargets_Action_IEnumerable_1_PlayerEntity_Context_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitForAllActionWithTargets>(intPtr3) : null;
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x00076170 File Offset: 0x00074370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594730, XrefRangeEnd = 594742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitForAllActionWithTargets(SerializedAction resolutionGen, SerializedContext parentContext, SerializedAction skippedResolutionGen, List<EntityID> requiredSelectors, Dictionary<EntityID, Il2CppStringArray> currentResponses = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForAllActionWithTargets>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resolutionGen);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentContext);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(skippedResolutionGen);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requiredSelectors);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentResponses);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAllActionWithTargets.NativeMethodInfoPtr__ctor_Public_Void_SerializedAction_SerializedContext_SerializedAction_List_1_EntityID_Dictionary_2_EntityID_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x00076208 File Offset: 0x00074408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594742, XrefRangeEnd = 594751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitForAllActionWithTargets.NativeMethodInfoPtr_MakeContinuationActions_Public_Virtual_IEnumerable_1_ActionAcrossTargets_IEnumerable_PlayerEntity_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ActionAcrossTargets>>(intPtr3) : null;
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x00076288 File Offset: 0x00074488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594751, XrefRangeEnd = 594782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAllActionWithTargets.NativeMethodInfoPtr_HandleOtherSelection_Public_Virtual_Final_New_Void_PlayerEntity_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x000762DC File Offset: 0x000744DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594782, XrefRangeEnd = 594802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> GetResponsesForPlayer(PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAllActionWithTargets.NativeMethodInfoPtr_GetResponsesForPlayer_Public_Il2CppReferenceArray_1_Object_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x0007632C File Offset: 0x0007452C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAllActionWithTargets.NativeMethodInfoPtr_GenResolution_Protected_Action_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x0007637C File Offset: 0x0007457C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAllActionWithTargets.NativeMethodInfoPtr_GenParentContext_Protected_Context_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x000763CC File Offset: 0x000745CC
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAllActionWithTargets.NativeMethodInfoPtr_GenSkippedResolution_Protected_Action_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x0000B0C3 File Offset: 0x000092C3
		public WaitForAllActionWithTargets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x0007641C File Offset: 0x0007461C
		// (set) Token: 0x06001725 RID: 5925 RVA: 0x0000B0CC File Offset: 0x000092CC
		public unsafe SerializedAction ResolutionGen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets.NativeFieldInfoPtr_ResolutionGen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets.NativeFieldInfoPtr_ResolutionGen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001726 RID: 5926 RVA: 0x0007644C File Offset: 0x0007464C
		// (set) Token: 0x06001727 RID: 5927 RVA: 0x0000B0EB File Offset: 0x000092EB
		public unsafe SerializedContext ParentContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets.NativeFieldInfoPtr_ParentContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets.NativeFieldInfoPtr_ParentContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001728 RID: 5928 RVA: 0x0007647C File Offset: 0x0007467C
		// (set) Token: 0x06001729 RID: 5929 RVA: 0x0000B10A File Offset: 0x0000930A
		public unsafe SerializedAction SkippedResolutionGen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets.NativeFieldInfoPtr_SkippedResolutionGen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets.NativeFieldInfoPtr_SkippedResolutionGen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x0600172A RID: 5930 RVA: 0x000764AC File Offset: 0x000746AC
		// (set) Token: 0x0600172B RID: 5931 RVA: 0x0000B129 File Offset: 0x00009329
		public unsafe List<EntityID> RequiredSelectorIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets.NativeFieldInfoPtr_RequiredSelectorIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets.NativeFieldInfoPtr_RequiredSelectorIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x0600172C RID: 5932 RVA: 0x000764DC File Offset: 0x000746DC
		// (set) Token: 0x0600172D RID: 5933 RVA: 0x0000B148 File Offset: 0x00009348
		public unsafe Dictionary<EntityID, Il2CppStringArray> CurrentResponses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets.NativeFieldInfoPtr_CurrentResponses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, Il2CppStringArray>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets.NativeFieldInfoPtr_CurrentResponses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000ED2 RID: 3794
		private static readonly IntPtr NativeFieldInfoPtr_ResolutionGen;

		// Token: 0x04000ED3 RID: 3795
		private static readonly IntPtr NativeFieldInfoPtr_ParentContext;

		// Token: 0x04000ED4 RID: 3796
		private static readonly IntPtr NativeFieldInfoPtr_SkippedResolutionGen;

		// Token: 0x04000ED5 RID: 3797
		private static readonly IntPtr NativeFieldInfoPtr_RequiredSelectorIDs;

		// Token: 0x04000ED6 RID: 3798
		private static readonly IntPtr NativeFieldInfoPtr_CurrentResponses;

		// Token: 0x04000ED7 RID: 3799
		private static readonly IntPtr NativeMethodInfoPtr_Instance_Public_Static_WaitForAllActionWithTargets_Action_IEnumerable_1_PlayerEntity_Context_Match_0;

		// Token: 0x04000ED8 RID: 3800
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedAction_SerializedContext_SerializedAction_List_1_EntityID_Dictionary_2_EntityID_Il2CppStringArray_0;

		// Token: 0x04000ED9 RID: 3801
		private static readonly IntPtr NativeMethodInfoPtr_MakeContinuationActions_Public_Virtual_IEnumerable_1_ActionAcrossTargets_IEnumerable_PlayerEntity_Match_0;

		// Token: 0x04000EDA RID: 3802
		private static readonly IntPtr NativeMethodInfoPtr_HandleOtherSelection_Public_Virtual_Final_New_Void_PlayerEntity_PendingSelection_0;

		// Token: 0x04000EDB RID: 3803
		private static readonly IntPtr NativeMethodInfoPtr_GetResponsesForPlayer_Public_Il2CppReferenceArray_1_Object_PlayerEntity_0;

		// Token: 0x04000EDC RID: 3804
		private static readonly IntPtr NativeMethodInfoPtr_GenResolution_Protected_Action_Match_0;

		// Token: 0x04000EDD RID: 3805
		private static readonly IntPtr NativeMethodInfoPtr_GenParentContext_Protected_Context_Match_0;

		// Token: 0x04000EDE RID: 3806
		private static readonly IntPtr NativeMethodInfoPtr_GenSkippedResolution_Protected_Action_Match_0;

		// Token: 0x0200046F RID: 1135
		[ObfuscatedName("Canis.actions.continuations.WaitForAllActionWithTargets+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060032BA RID: 12986 RVA: 0x000D03A8 File Offset: 0x000CE5A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WaitForAllActionWithTargets.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaitForAllActionWithTargets>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForAllActionWithTargets.__c>.NativeClassPtr);
				WaitForAllActionWithTargets.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAllActionWithTargets.__c>.NativeClassPtr, "<>9");
				WaitForAllActionWithTargets.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAllActionWithTargets.__c>.NativeClassPtr, "<>9__5_0");
				WaitForAllActionWithTargets.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAllActionWithTargets.__c>.NativeClassPtr, 100668550);
				WaitForAllActionWithTargets.__c.NativeMethodInfoPtr__Instance_b__5_0_Internal_EntityID_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAllActionWithTargets.__c>.NativeClassPtr, 100668551);
			}

			// Token: 0x060032BB RID: 12987 RVA: 0x000D0424 File Offset: 0x000CE624
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForAllActionWithTargets.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAllActionWithTargets.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032BC RID: 12988 RVA: 0x000D0460 File Offset: 0x000CE660
			[CallerCount(0)]
			public unsafe EntityID _Instance_b__5_0(PlayerEntity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAllActionWithTargets.__c.NativeMethodInfoPtr__Instance_b__5_0_Internal_EntityID_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060032BD RID: 12989 RVA: 0x0001850C File Offset: 0x0001670C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D71 RID: 3441
			// (get) Token: 0x060032BE RID: 12990 RVA: 0x000D04B0 File Offset: 0x000CE6B0
			// (set) Token: 0x060032BF RID: 12991 RVA: 0x00018515 File Offset: 0x00016715
			public unsafe static WaitForAllActionWithTargets.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WaitForAllActionWithTargets.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForAllActionWithTargets.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WaitForAllActionWithTargets.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D72 RID: 3442
			// (get) Token: 0x060032C0 RID: 12992 RVA: 0x000D04D8 File Offset: 0x000CE6D8
			// (set) Token: 0x060032C1 RID: 12993 RVA: 0x00018527 File Offset: 0x00016727
			public unsafe static Func<PlayerEntity, EntityID> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WaitForAllActionWithTargets.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WaitForAllActionWithTargets.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FB5 RID: 8117
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001FB6 RID: 8118
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04001FB7 RID: 8119
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001FB8 RID: 8120
			private static readonly IntPtr NativeMethodInfoPtr__Instance_b__5_0_Internal_EntityID_PlayerEntity_0;
		}

		// Token: 0x02000470 RID: 1136
		[ObfuscatedName("Canis.actions.continuations.WaitForAllActionWithTargets+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x060032C2 RID: 12994 RVA: 0x000D0500 File Offset: 0x000CE700
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<WaitForAllActionWithTargets.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaitForAllActionWithTargets>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForAllActionWithTargets.__c__DisplayClass7_0>.NativeClassPtr);
				WaitForAllActionWithTargets.__c__DisplayClass7_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAllActionWithTargets.__c__DisplayClass7_0>.NativeClassPtr, "match");
				WaitForAllActionWithTargets.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAllActionWithTargets.__c__DisplayClass7_0>.NativeClassPtr, 100668552);
				WaitForAllActionWithTargets.__c__DisplayClass7_0.NativeMethodInfoPtr__MakeContinuationActions_b__0_Internal_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAllActionWithTargets.__c__DisplayClass7_0>.NativeClassPtr, 100668553);
			}

			// Token: 0x060032C3 RID: 12995 RVA: 0x000D0568 File Offset: 0x000CE768
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForAllActionWithTargets.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAllActionWithTargets.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032C4 RID: 12996 RVA: 0x000D05A4 File Offset: 0x000CE7A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594428, XrefRangeEnd = 594429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _MakeContinuationActions_b__0(Object unknown)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(unknown);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAllActionWithTargets.__c__DisplayClass7_0.NativeMethodInfoPtr__MakeContinuationActions_b__0_Internal_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060032C5 RID: 12997 RVA: 0x00018539 File Offset: 0x00016739
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D73 RID: 3443
			// (get) Token: 0x060032C6 RID: 12998 RVA: 0x000D05EC File Offset: 0x000CE7EC
			// (set) Token: 0x060032C7 RID: 12999 RVA: 0x00018542 File Offset: 0x00016742
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets.__c__DisplayClass7_0.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets.__c__DisplayClass7_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FB9 RID: 8121
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04001FBA RID: 8122
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001FBB RID: 8123
			private static readonly IntPtr NativeMethodInfoPtr__MakeContinuationActions_b__0_Internal_String_Object_0;
		}

		// Token: 0x02000471 RID: 1137
		[ObfuscatedName("Canis.actions.continuations.WaitForAllActionWithTargets+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x060032C8 RID: 13000 RVA: 0x000D061C File Offset: 0x000CE81C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<WaitForAllActionWithTargets.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaitForAllActionWithTargets>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForAllActionWithTargets.__c__DisplayClass9_0>.NativeClassPtr);
				WaitForAllActionWithTargets.__c__DisplayClass9_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAllActionWithTargets.__c__DisplayClass9_0>.NativeClassPtr, "player");
				WaitForAllActionWithTargets.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAllActionWithTargets.__c__DisplayClass9_0>.NativeClassPtr, 100668554);
				WaitForAllActionWithTargets.__c__DisplayClass9_0.NativeMethodInfoPtr__GetResponsesForPlayer_b__0_Internal_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAllActionWithTargets.__c__DisplayClass9_0>.NativeClassPtr, 100668555);
			}

			// Token: 0x060032C9 RID: 13001 RVA: 0x000D0684 File Offset: 0x000CE884
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForAllActionWithTargets.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAllActionWithTargets.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032CA RID: 13002 RVA: 0x000D06C0 File Offset: 0x000CE8C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594429, XrefRangeEnd = 594494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _GetResponsesForPlayer_b__0(string response)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(response);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAllActionWithTargets.__c__DisplayClass9_0.NativeMethodInfoPtr__GetResponsesForPlayer_b__0_Internal_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060032CB RID: 13003 RVA: 0x00018561 File Offset: 0x00016761
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D74 RID: 3444
			// (get) Token: 0x060032CC RID: 13004 RVA: 0x000D0710 File Offset: 0x000CE910
			// (set) Token: 0x060032CD RID: 13005 RVA: 0x0001856A File Offset: 0x0001676A
			public unsafe PlayerEntity player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets.__c__DisplayClass9_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets.__c__DisplayClass9_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FBC RID: 8124
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04001FBD RID: 8125
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001FBE RID: 8126
			private static readonly IntPtr NativeMethodInfoPtr__GetResponsesForPlayer_b__0_Internal_Object_String_0;
		}

		// Token: 0x02000472 RID: 1138
		[ObfuscatedName("Canis.actions.continuations.WaitForAllActionWithTargets+<MakeContinuationActions>d__7")]
		public sealed class _MakeContinuationActions_d__7 : Object
		{
			// Token: 0x060032CE RID: 13006 RVA: 0x000D0740 File Offset: 0x000CE940
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeContinuationActions_d__7()
			{
				Il2CppClassPointerStore<WaitForAllActionWithTargets._MakeContinuationActions_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaitForAllActionWithTargets>.NativeClassPtr, "<MakeContinuationActions>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForAllActionWithTargets._MakeContinuationActions_d__7>.NativeClassPtr);
				WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAllActionWithTargets._MakeContinuationActions_d__7>.NativeClassPtr, "<>1__state");
				WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAllActionWithTargets._MakeContinuationActions_d__7>.NativeClassPtr, "<>2__current");
				WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAllActionWithTargets._MakeContinuationActions_d__7>.NativeClassPtr, "<>l__initialThreadId");
				WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAllActionWithTargets._MakeContinuationActions_d__7>.NativeClassPtr, "match");
				WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAllActionWithTargets._MakeContinuationActions_d__7>.NativeClassPtr, "<>3__match");
				WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr_selectionResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAllActionWithTargets._MakeContinuationActions_d__7>.NativeClassPtr, "selectionResponse");
				WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr___3__selectionResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAllActionWithTargets._MakeContinuationActions_d__7>.NativeClassPtr, "<>3__selectionResponse");
				WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAllActionWithTargets._MakeContinuationActions_d__7>.NativeClassPtr, "<>4__this");
				WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr_selectingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAllActionWithTargets._MakeContinuationActions_d__7>.NativeClassPtr, "selectingPlayer");
				WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr___3__selectingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAllActionWithTargets._MakeContinuationActions_d__7>.NativeClassPtr, "<>3__selectingPlayer");
				WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAllActionWithTargets._MakeContinuationActions_d__7>.NativeClassPtr, "<>8__1");
				WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr__typedResponses_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAllActionWithTargets._MakeContinuationActions_d__7>.NativeClassPtr, "<typedResponses>5__2");
				WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForAllActionWithTargets._MakeContinuationActions_d__7>.NativeClassPtr, "<>7__wrap2");
				WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAllActionWithTargets._MakeContinuationActions_d__7>.NativeClassPtr, 100668556);
				WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAllActionWithTargets._MakeContinuationActions_d__7>.NativeClassPtr, 100668557);
				WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAllActionWithTargets._MakeContinuationActions_d__7>.NativeClassPtr, 100668558);
				WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAllActionWithTargets._MakeContinuationActions_d__7>.NativeClassPtr, 100668559);
				WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_continuations_ActionAcrossTargets__get_Current_Private_Virtual_Final_New_get_ActionAcrossTargets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAllActionWithTargets._MakeContinuationActions_d__7>.NativeClassPtr, 100668560);
				WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAllActionWithTargets._MakeContinuationActions_d__7>.NativeClassPtr, 100668561);
				WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAllActionWithTargets._MakeContinuationActions_d__7>.NativeClassPtr, 100668562);
				WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_continuations_ActionAcrossTargets__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ActionAcrossTargets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAllActionWithTargets._MakeContinuationActions_d__7>.NativeClassPtr, 100668563);
				WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForAllActionWithTargets._MakeContinuationActions_d__7>.NativeClassPtr, 100668564);
			}

			// Token: 0x060032CF RID: 13007 RVA: 0x000D0924 File Offset: 0x000CEB24
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeContinuationActions_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForAllActionWithTargets._MakeContinuationActions_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032D0 RID: 13008 RVA: 0x000D096C File Offset: 0x000CEB6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594494, XrefRangeEnd = 594499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032D1 RID: 13009 RVA: 0x000D09A0 File Offset: 0x000CEBA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594499, XrefRangeEnd = 594665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060032D2 RID: 13010 RVA: 0x000D09DC File Offset: 0x000CEBDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594665, XrefRangeEnd = 594668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D82 RID: 3458
			// (get) Token: 0x060032D3 RID: 13011 RVA: 0x000D0A10 File Offset: 0x000CEC10
			public unsafe ActionAcrossTargets System.Collections.Generic.IEnumerator<Canis.actions.continuations.ActionAcrossTargets>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_continuations_ActionAcrossTargets__get_Current_Private_Virtual_Final_New_get_ActionAcrossTargets_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionAcrossTargets>(intPtr3) : null;
				}
			}

			// Token: 0x060032D4 RID: 13012 RVA: 0x000D0A50 File Offset: 0x000CEC50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594668, XrefRangeEnd = 594673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D83 RID: 3459
			// (get) Token: 0x060032D5 RID: 13013 RVA: 0x000D0A84 File Offset: 0x000CEC84
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060032D6 RID: 13014 RVA: 0x000D0AC4 File Offset: 0x000CECC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594673, XrefRangeEnd = 594684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ActionAcrossTargets> System_Collections_Generic_IEnumerable_Canis_actions_continuations_ActionAcrossTargets__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_continuations_ActionAcrossTargets__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ActionAcrossTargets_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ActionAcrossTargets>>(intPtr3) : null;
			}

			// Token: 0x060032D7 RID: 13015 RVA: 0x000D0B04 File Offset: 0x000CED04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060032D8 RID: 13016 RVA: 0x00018589 File Offset: 0x00016789
			public _MakeContinuationActions_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D75 RID: 3445
			// (get) Token: 0x060032D9 RID: 13017 RVA: 0x000D0B44 File Offset: 0x000CED44
			// (set) Token: 0x060032DA RID: 13018 RVA: 0x00018592 File Offset: 0x00016792
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D76 RID: 3446
			// (get) Token: 0x060032DB RID: 13019 RVA: 0x000D0B6C File Offset: 0x000CED6C
			// (set) Token: 0x060032DC RID: 13020 RVA: 0x000185AD File Offset: 0x000167AD
			public unsafe ActionAcrossTargets __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionAcrossTargets>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D77 RID: 3447
			// (get) Token: 0x060032DD RID: 13021 RVA: 0x000D0B9C File Offset: 0x000CED9C
			// (set) Token: 0x060032DE RID: 13022 RVA: 0x000185CC File Offset: 0x000167CC
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000D78 RID: 3448
			// (get) Token: 0x060032DF RID: 13023 RVA: 0x000D0BC4 File Offset: 0x000CEDC4
			// (set) Token: 0x060032E0 RID: 13024 RVA: 0x000185E7 File Offset: 0x000167E7
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D79 RID: 3449
			// (get) Token: 0x060032E1 RID: 13025 RVA: 0x000D0BF4 File Offset: 0x000CEDF4
			// (set) Token: 0x060032E2 RID: 13026 RVA: 0x00018606 File Offset: 0x00016806
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D7A RID: 3450
			// (get) Token: 0x060032E3 RID: 13027 RVA: 0x000D0C24 File Offset: 0x000CEE24
			// (set) Token: 0x060032E4 RID: 13028 RVA: 0x00018625 File Offset: 0x00016825
			public unsafe IEnumerable selectionResponse
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr_selectionResponse);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr_selectionResponse), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D7B RID: 3451
			// (get) Token: 0x060032E5 RID: 13029 RVA: 0x000D0C54 File Offset: 0x000CEE54
			// (set) Token: 0x060032E6 RID: 13030 RVA: 0x00018644 File Offset: 0x00016844
			public unsafe IEnumerable __3__selectionResponse
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr___3__selectionResponse);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr___3__selectionResponse), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D7C RID: 3452
			// (get) Token: 0x060032E7 RID: 13031 RVA: 0x000D0C84 File Offset: 0x000CEE84
			// (set) Token: 0x060032E8 RID: 13032 RVA: 0x00018663 File Offset: 0x00016863
			public unsafe WaitForAllActionWithTargets __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForAllActionWithTargets>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D7D RID: 3453
			// (get) Token: 0x060032E9 RID: 13033 RVA: 0x000D0CB4 File Offset: 0x000CEEB4
			// (set) Token: 0x060032EA RID: 13034 RVA: 0x00018682 File Offset: 0x00016882
			public unsafe PlayerEntity selectingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr_selectingPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr_selectingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D7E RID: 3454
			// (get) Token: 0x060032EB RID: 13035 RVA: 0x000D0CE4 File Offset: 0x000CEEE4
			// (set) Token: 0x060032EC RID: 13036 RVA: 0x000186A1 File Offset: 0x000168A1
			public unsafe PlayerEntity __3__selectingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr___3__selectingPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr___3__selectingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D7F RID: 3455
			// (get) Token: 0x060032ED RID: 13037 RVA: 0x000D0D14 File Offset: 0x000CEF14
			// (set) Token: 0x060032EE RID: 13038 RVA: 0x000186C0 File Offset: 0x000168C0
			public unsafe WaitForAllActionWithTargets.__c__DisplayClass7_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForAllActionWithTargets.__c__DisplayClass7_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D80 RID: 3456
			// (get) Token: 0x060032EF RID: 13039 RVA: 0x000D0D44 File Offset: 0x000CEF44
			// (set) Token: 0x060032F0 RID: 13040 RVA: 0x000186DF File Offset: 0x000168DF
			public unsafe Il2CppReferenceArray<Object> _typedResponses_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr__typedResponses_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr__typedResponses_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D81 RID: 3457
			// (get) Token: 0x060032F1 RID: 13041 RVA: 0x000D0D74 File Offset: 0x000CEF74
			// (set) Token: 0x060032F2 RID: 13042 RVA: 0x000186FE File Offset: 0x000168FE
			public unsafe IEnumerator<PlayerEntity> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForAllActionWithTargets._MakeContinuationActions_d__7.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FBF RID: 8127
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001FC0 RID: 8128
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001FC1 RID: 8129
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001FC2 RID: 8130
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04001FC3 RID: 8131
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04001FC4 RID: 8132
			private static readonly IntPtr NativeFieldInfoPtr_selectionResponse;

			// Token: 0x04001FC5 RID: 8133
			private static readonly IntPtr NativeFieldInfoPtr___3__selectionResponse;

			// Token: 0x04001FC6 RID: 8134
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001FC7 RID: 8135
			private static readonly IntPtr NativeFieldInfoPtr_selectingPlayer;

			// Token: 0x04001FC8 RID: 8136
			private static readonly IntPtr NativeFieldInfoPtr___3__selectingPlayer;

			// Token: 0x04001FC9 RID: 8137
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04001FCA RID: 8138
			private static readonly IntPtr NativeFieldInfoPtr__typedResponses_5__2;

			// Token: 0x04001FCB RID: 8139
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04001FCC RID: 8140
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001FCD RID: 8141
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FCE RID: 8142
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001FCF RID: 8143
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001FD0 RID: 8144
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_continuations_ActionAcrossTargets__get_Current_Private_Virtual_Final_New_get_ActionAcrossTargets_0;

			// Token: 0x04001FD1 RID: 8145
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FD2 RID: 8146
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001FD3 RID: 8147
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_continuations_ActionAcrossTargets__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ActionAcrossTargets_0;

			// Token: 0x04001FD4 RID: 8148
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
