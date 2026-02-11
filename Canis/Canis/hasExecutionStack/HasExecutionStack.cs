using System;
using Canis.actions;
using Canis.actions.continuations;
using Canis.data;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.hasExecutionStack
{
	// Token: 0x0200008A RID: 138
	public class HasExecutionStack : Object
	{
		// Token: 0x06000731 RID: 1841 RVA: 0x00036B68 File Offset: 0x00034D68
		// Note: this type is marked as 'beforefieldinit'.
		static HasExecutionStack()
		{
			Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.hasExecutionStack", "HasExecutionStack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr);
			HasExecutionStack.NativeFieldInfoPtr_MAIN_EXECUTION_STACK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, "MAIN_EXECUTION_STACK");
			HasExecutionStack.NativeFieldInfoPtr_CHEATS_EXECUTION_STACK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, "CHEATS_EXECUTION_STACK");
			HasExecutionStack.NativeFieldInfoPtr_TIMER_EXECUTION_STACK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, "TIMER_EXECUTION_STACK");
			HasExecutionStack.NativeFieldInfoPtr_RESIGN_EXECUTION_STACK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, "RESIGN_EXECUTION_STACK");
			HasExecutionStack.NativeFieldInfoPtr_CONNECTION_EXECUTION_STACK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, "CONNECTION_EXECUTION_STACK");
			HasExecutionStack.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, "Name");
			HasExecutionStack.NativeFieldInfoPtr_Match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, "Match");
			HasExecutionStack.NativeFieldInfoPtr_LatestRespondedPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, "LatestRespondedPlayer");
			HasExecutionStack.NativeFieldInfoPtr__Stack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, "<Stack>k__BackingField");
			HasExecutionStack.NativeFieldInfoPtr_MaxRunIterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, "MaxRunIterations");
			HasExecutionStack.NativeFieldInfoPtr_selectionsSinceBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, "selectionsSinceBase");
			HasExecutionStack.NativeFieldInfoPtr_SaveOnPause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, "SaveOnPause");
			HasExecutionStack.NativeMethodInfoPtr_get_Stack_Public_get_ExecuteStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, 100664778);
			HasExecutionStack.NativeMethodInfoPtr_set_Stack_Private_set_Void_ExecuteStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, 100664779);
			HasExecutionStack.NativeMethodInfoPtr__ctor_Public_Void_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, 100664780);
			HasExecutionStack.NativeMethodInfoPtr_PushAction_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, 100664781);
			HasExecutionStack.NativeMethodInfoPtr_PushStack_Private_Void_ExecuteStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, 100664782);
			HasExecutionStack.NativeMethodInfoPtr_Run_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, 100664783);
			HasExecutionStack.NativeMethodInfoPtr_AllPendingResponses_Private_IEnumerable_1_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, 100664784);
			HasExecutionStack.NativeMethodInfoPtr_AllPlayerPendingResponses_Private_IEnumerable_1_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, 100664785);
			HasExecutionStack.NativeMethodInfoPtr_HasPendingResponses_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, 100664786);
			HasExecutionStack.NativeMethodInfoPtr_HasPendingResponse_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, 100664787);
			HasExecutionStack.NativeMethodInfoPtr_CountPlayerPendingResponsesForCounter_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, 100664788);
			HasExecutionStack.NativeMethodInfoPtr_GetPlayerPendingResponse_Private_PendingSelection_PlayerEntity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, 100664789);
			HasExecutionStack.NativeMethodInfoPtr_DumpPendingResponses_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, 100664790);
			HasExecutionStack.NativeMethodInfoPtr_GetPlayerEntityForCounter_Public_Virtual_Final_New_PlayerEntity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, 100664791);
			HasExecutionStack.NativeMethodInfoPtr_GetCounterForPlayerEntity_Public_Virtual_Final_New_Int32_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, 100664792);
			HasExecutionStack.NativeMethodInfoPtr_GetLatestSelectionCounter_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, 100664793);
			HasExecutionStack.NativeMethodInfoPtr_IsValidSelection_Private_Boolean_Int32_PlayerEntity_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, 100664794);
			HasExecutionStack.NativeMethodInfoPtr_ConsumeCounter_Public_Virtual_Final_New_Boolean_Int32_Object_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, 100664795);
			HasExecutionStack.NativeMethodInfoPtr_CancelPendingResponse_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, 100664796);
			HasExecutionStack.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, 100664797);
			HasExecutionStack.NativeMethodInfoPtr_IsInSelectionLoop_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, 100664798);
			HasExecutionStack.NativeMethodInfoPtr_DebugInfo_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, 100664799);
			HasExecutionStack.NativeMethodInfoPtr__DebugInfo_b__34_0_Private_String_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, 100664800);
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x00036E54 File Offset: 0x00035054
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x00036E94 File Offset: 0x00035094
		public unsafe ExecuteStack Stack
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.NativeMethodInfoPtr_get_Stack_Public_get_ExecuteStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteStack>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.NativeMethodInfoPtr_set_Stack_Private_set_Void_ExecuteStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00036ED8 File Offset: 0x000350D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557256, XrefRangeEnd = 557261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HasExecutionStack(string name, Match match)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.NativeMethodInfoPtr__ctor_Public_Void_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00036F38 File Offset: 0x00035138
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 557265, RefRangeEnd = 557267, XrefRangeStart = 557261, XrefRangeEnd = 557265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PushAction(Canis.actions.Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.NativeMethodInfoPtr_PushAction_Public_Virtual_Final_New_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00036F7C File Offset: 0x0003517C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushStack(ExecuteStack continuedStack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuedStack);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.NativeMethodInfoPtr_PushStack_Private_Void_ExecuteStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00036FC0 File Offset: 0x000351C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 557298, RefRangeEnd = 557299, XrefRangeStart = 557267, XrefRangeEnd = 557298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Run(bool allowSaves = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allowSaves;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.NativeMethodInfoPtr_Run_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00037000 File Offset: 0x00035200
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 557318, RefRangeEnd = 557322, XrefRangeStart = 557299, XrefRangeEnd = 557318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<PendingSelection> AllPendingResponses()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.NativeMethodInfoPtr_AllPendingResponses_Private_IEnumerable_1_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PendingSelection>>(intPtr3) : null;
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00037040 File Offset: 0x00035240
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 557341, RefRangeEnd = 557349, XrefRangeStart = 557322, XrefRangeEnd = 557341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ValueTuple<PlayerEntity, IReadOnlyCollection<PendingSelection>>> AllPlayerPendingResponses()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.NativeMethodInfoPtr_AllPlayerPendingResponses_Private_IEnumerable_1_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<PlayerEntity, IReadOnlyCollection<PendingSelection>>>>(intPtr3) : null;
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00037080 File Offset: 0x00035280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557349, XrefRangeEnd = 557353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HasPendingResponses()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.NativeMethodInfoPtr_HasPendingResponses_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x000370BC File Offset: 0x000352BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557353, XrefRangeEnd = 557368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HasPendingResponse(int selectionCounter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref selectionCounter;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.NativeMethodInfoPtr_HasPendingResponse_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00037108 File Offset: 0x00035308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557368, XrefRangeEnd = 557401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CountPlayerPendingResponsesForCounter(int selectionCounter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref selectionCounter;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.NativeMethodInfoPtr_CountPlayerPendingResponsesForCounter_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00037154 File Offset: 0x00035354
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 557429, RefRangeEnd = 557431, XrefRangeStart = 557401, XrefRangeEnd = 557429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PendingSelection GetPlayerPendingResponse(PlayerEntity selectingPlayer, int selectionCounter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectionCounter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.NativeMethodInfoPtr_GetPlayerPendingResponse_Private_PendingSelection_PlayerEntity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PendingSelection>(intPtr3) : null;
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x000371B4 File Offset: 0x000353B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557431, XrefRangeEnd = 557475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string DumpPendingResponses()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.NativeMethodInfoPtr_DumpPendingResponses_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x000371EC File Offset: 0x000353EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557475, XrefRangeEnd = 557502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PlayerEntity GetPlayerEntityForCounter(int selectionCounter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref selectionCounter;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.NativeMethodInfoPtr_GetPlayerEntityForCounter_Public_Virtual_Final_New_PlayerEntity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
			}
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00037238 File Offset: 0x00035438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557502, XrefRangeEnd = 557507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetCounterForPlayerEntity(PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.NativeMethodInfoPtr_GetCounterForPlayerEntity_Public_Virtual_Final_New_Int32_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00037288 File Offset: 0x00035488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557507, XrefRangeEnd = 557546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLatestSelectionCounter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.NativeMethodInfoPtr_GetLatestSelectionCounter_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x000372C4 File Offset: 0x000354C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 557550, RefRangeEnd = 557551, XrefRangeStart = 557546, XrefRangeEnd = 557550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValidSelection(int counter, PlayerEntity selectingPlayer, PendingSelection pendingSelection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref counter;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pendingSelection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.NativeMethodInfoPtr_IsValidSelection_Private_Boolean_Int32_PlayerEntity_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00037334 File Offset: 0x00035534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557551, XrefRangeEnd = 557703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ConsumeCounter(int counter, Object message, PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref counter;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.NativeMethodInfoPtr_ConsumeCounter_Public_Virtual_Final_New_Boolean_Int32_Object_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x000373A4 File Offset: 0x000355A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557703, XrefRangeEnd = 557736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CancelPendingResponse(int counter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref counter;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.NativeMethodInfoPtr_CancelPendingResponse_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x000373F0 File Offset: 0x000355F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557736, XrefRangeEnd = 557783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00037424 File Offset: 0x00035624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557783, XrefRangeEnd = 557787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsInSelectionLoop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.NativeMethodInfoPtr_IsInSelectionLoop_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00037460 File Offset: 0x00035660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557787, XrefRangeEnd = 557858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string DebugInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.NativeMethodInfoPtr_DebugInfo_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00037498 File Offset: 0x00035698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557858, XrefRangeEnd = 557865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _DebugInfo_b__34_0(PendingSelection ps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ps);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.NativeMethodInfoPtr__DebugInfo_b__34_0_Private_String_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00004BD5 File Offset: 0x00002DD5
		public HasExecutionStack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x000374E0 File Offset: 0x000356E0
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x00004BDE File Offset: 0x00002DDE
		public unsafe static string MAIN_EXECUTION_STACK
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HasExecutionStack.NativeFieldInfoPtr_MAIN_EXECUTION_STACK, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HasExecutionStack.NativeFieldInfoPtr_MAIN_EXECUTION_STACK, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x00037500 File Offset: 0x00035700
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x00004BF0 File Offset: 0x00002DF0
		public unsafe static string CHEATS_EXECUTION_STACK
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HasExecutionStack.NativeFieldInfoPtr_CHEATS_EXECUTION_STACK, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HasExecutionStack.NativeFieldInfoPtr_CHEATS_EXECUTION_STACK, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x00037520 File Offset: 0x00035720
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x00004C02 File Offset: 0x00002E02
		public unsafe static string TIMER_EXECUTION_STACK
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HasExecutionStack.NativeFieldInfoPtr_TIMER_EXECUTION_STACK, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HasExecutionStack.NativeFieldInfoPtr_TIMER_EXECUTION_STACK, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x00037540 File Offset: 0x00035740
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x00004C14 File Offset: 0x00002E14
		public unsafe static string RESIGN_EXECUTION_STACK
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HasExecutionStack.NativeFieldInfoPtr_RESIGN_EXECUTION_STACK, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HasExecutionStack.NativeFieldInfoPtr_RESIGN_EXECUTION_STACK, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x00037560 File Offset: 0x00035760
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x00004C26 File Offset: 0x00002E26
		public unsafe static string CONNECTION_EXECUTION_STACK
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HasExecutionStack.NativeFieldInfoPtr_CONNECTION_EXECUTION_STACK, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HasExecutionStack.NativeFieldInfoPtr_CONNECTION_EXECUTION_STACK, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x00037580 File Offset: 0x00035780
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x00004C38 File Offset: 0x00002E38
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x000375A8 File Offset: 0x000357A8
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x00004C57 File Offset: 0x00002E57
		public unsafe Match Match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.NativeFieldInfoPtr_Match);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.NativeFieldInfoPtr_Match), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x000375D8 File Offset: 0x000357D8
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x00004C76 File Offset: 0x00002E76
		public unsafe PlayerEntity LatestRespondedPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.NativeFieldInfoPtr_LatestRespondedPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.NativeFieldInfoPtr_LatestRespondedPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x00037608 File Offset: 0x00035808
		// (set) Token: 0x0600075B RID: 1883 RVA: 0x00004C95 File Offset: 0x00002E95
		public unsafe ExecuteStack _Stack_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.NativeFieldInfoPtr__Stack_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.NativeFieldInfoPtr__Stack_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x00037638 File Offset: 0x00035838
		// (set) Token: 0x0600075D RID: 1885 RVA: 0x00004CB4 File Offset: 0x00002EB4
		public unsafe static int MaxRunIterations
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HasExecutionStack.NativeFieldInfoPtr_MaxRunIterations, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HasExecutionStack.NativeFieldInfoPtr_MaxRunIterations, (void*)(&value));
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x00037654 File Offset: 0x00035854
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x00004CC2 File Offset: 0x00002EC2
		public unsafe int selectionsSinceBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.NativeFieldInfoPtr_selectionsSinceBase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.NativeFieldInfoPtr_selectionsSinceBase)) = value;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x0003767C File Offset: 0x0003587C
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x00004CDD File Offset: 0x00002EDD
		public unsafe bool SaveOnPause
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.NativeFieldInfoPtr_SaveOnPause);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.NativeFieldInfoPtr_SaveOnPause)) = value;
			}
		}

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeFieldInfoPtr_MAIN_EXECUTION_STACK;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeFieldInfoPtr_CHEATS_EXECUTION_STACK;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeFieldInfoPtr_TIMER_EXECUTION_STACK;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeFieldInfoPtr_RESIGN_EXECUTION_STACK;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeFieldInfoPtr_CONNECTION_EXECUTION_STACK;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeFieldInfoPtr_Match;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeFieldInfoPtr_LatestRespondedPlayer;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeFieldInfoPtr__Stack_k__BackingField;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeFieldInfoPtr_MaxRunIterations;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeFieldInfoPtr_selectionsSinceBase;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeFieldInfoPtr_SaveOnPause;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeMethodInfoPtr_get_Stack_Public_get_ExecuteStack_0;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr_set_Stack_Private_set_Void_ExecuteStack_0;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Match_0;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeMethodInfoPtr_PushAction_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeMethodInfoPtr_PushStack_Private_Void_ExecuteStack_0;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Final_New_Void_Boolean_0;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeMethodInfoPtr_AllPendingResponses_Private_IEnumerable_1_PendingSelection_0;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr_AllPlayerPendingResponses_Private_IEnumerable_1_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_0;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeMethodInfoPtr_HasPendingResponses_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeMethodInfoPtr_HasPendingResponse_Public_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeMethodInfoPtr_CountPlayerPendingResponsesForCounter_Private_Int32_Int32_0;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerPendingResponse_Private_PendingSelection_PlayerEntity_Int32_0;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr_DumpPendingResponses_Public_Virtual_Final_New_String_0;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerEntityForCounter_Public_Virtual_Final_New_PlayerEntity_Int32_0;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr_GetCounterForPlayerEntity_Public_Virtual_Final_New_Int32_PlayerEntity_0;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeMethodInfoPtr_GetLatestSelectionCounter_Private_Int32_0;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeMethodInfoPtr_IsValidSelection_Private_Boolean_Int32_PlayerEntity_PendingSelection_0;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeCounter_Public_Virtual_Final_New_Boolean_Int32_Object_PlayerEntity_0;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeMethodInfoPtr_CancelPendingResponse_Public_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeMethodInfoPtr_IsInSelectionLoop_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeMethodInfoPtr_DebugInfo_Public_Virtual_Final_New_String_0;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeMethodInfoPtr__DebugInfo_b__34_0_Private_String_PendingSelection_0;

		// Token: 0x020002D5 RID: 725
		[ObfuscatedName("Canis.hasExecutionStack.HasExecutionStack+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001E61 RID: 7777 RVA: 0x0008D500 File Offset: 0x0008B700
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<HasExecutionStack.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasExecutionStack.__c>.NativeClassPtr);
				HasExecutionStack.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack.__c>.NativeClassPtr, "<>9");
				HasExecutionStack.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack.__c>.NativeClassPtr, "<>9__18_0");
				HasExecutionStack.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack.__c>.NativeClassPtr, "<>9__19_0");
				HasExecutionStack.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack.__c>.NativeClassPtr, "<>9__20_0");
				HasExecutionStack.__c.NativeFieldInfoPtr___9__23_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack.__c>.NativeClassPtr, "<>9__23_1");
				HasExecutionStack.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack.__c>.NativeClassPtr, "<>9__28_0");
				HasExecutionStack.__c.NativeFieldInfoPtr___9__28_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack.__c>.NativeClassPtr, "<>9__28_1");
				HasExecutionStack.__c.NativeFieldInfoPtr___9__30_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack.__c>.NativeClassPtr, "<>9__30_0");
				HasExecutionStack.__c.NativeFieldInfoPtr___9__31_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack.__c>.NativeClassPtr, "<>9__31_1");
				HasExecutionStack.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack.__c>.NativeClassPtr, 100664802);
				HasExecutionStack.__c.NativeMethodInfoPtr__Run_b__18_0_Internal_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack.__c>.NativeClassPtr, 100664803);
				HasExecutionStack.__c.NativeMethodInfoPtr__AllPendingResponses_b__19_0_Internal_IEnumerable_1_PendingSelection_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack.__c>.NativeClassPtr, 100664804);
				HasExecutionStack.__c.NativeMethodInfoPtr__AllPlayerPendingResponses_b__20_0_Internal_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack.__c>.NativeClassPtr, 100664805);
				HasExecutionStack.__c.NativeMethodInfoPtr__CountPlayerPendingResponsesForCounter_b__23_1_Internal_Boolean_ValueTuple_2_PlayerEntity_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack.__c>.NativeClassPtr, 100664806);
				HasExecutionStack.__c.NativeMethodInfoPtr__GetLatestSelectionCounter_b__28_0_Internal_Int32_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack.__c>.NativeClassPtr, 100664807);
				HasExecutionStack.__c.NativeMethodInfoPtr__GetLatestSelectionCounter_b__28_1_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack.__c>.NativeClassPtr, 100664808);
				HasExecutionStack.__c.NativeMethodInfoPtr__ConsumeCounter_b__30_0_Internal_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack.__c>.NativeClassPtr, 100664809);
				HasExecutionStack.__c.NativeMethodInfoPtr__CancelPendingResponse_b__31_1_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack.__c>.NativeClassPtr, 100664810);
			}

			// Token: 0x06001E62 RID: 7778 RVA: 0x0008D694 File Offset: 0x0008B894
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasExecutionStack.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E63 RID: 7779 RVA: 0x0008D6D0 File Offset: 0x0008B8D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557198, XrefRangeEnd = 557202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Run_b__18_0(PlayerEntity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.__c.NativeMethodInfoPtr__Run_b__18_0_Internal_Boolean_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E64 RID: 7780 RVA: 0x0008D720 File Offset: 0x0008B920
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557202, XrefRangeEnd = 557203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<PendingSelection> _AllPendingResponses_b__19_0(PlayerEntity p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.__c.NativeMethodInfoPtr__AllPendingResponses_b__19_0_Internal_IEnumerable_1_PendingSelection_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PendingSelection>>(intPtr3) : null;
				}
			}

			// Token: 0x06001E65 RID: 7781 RVA: 0x0008D770 File Offset: 0x0008B970
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557203, XrefRangeEnd = 557207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<PlayerEntity, IReadOnlyCollection<PendingSelection>> _AllPlayerPendingResponses_b__20_0(PlayerEntity p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.__c.NativeMethodInfoPtr__AllPlayerPendingResponses_b__20_0_Internal_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<PlayerEntity, IReadOnlyCollection<PendingSelection>>(intPtr);
				}
			}

			// Token: 0x06001E66 RID: 7782 RVA: 0x0008D7B8 File Offset: 0x0008B9B8
			[CallerCount(0)]
			public unsafe bool _CountPlayerPendingResponsesForCounter_b__23_1(ValueTuple<PlayerEntity, PendingSelection> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.__c.NativeMethodInfoPtr__CountPlayerPendingResponsesForCounter_b__23_1_Internal_Boolean_ValueTuple_2_PlayerEntity_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E67 RID: 7783 RVA: 0x0008D80C File Offset: 0x0008BA0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetLatestSelectionCounter_b__28_0(PendingSelection ps)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ps);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.__c.NativeMethodInfoPtr__GetLatestSelectionCounter_b__28_0_Internal_Int32_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E68 RID: 7784 RVA: 0x0008D85C File Offset: 0x0008BA5C
			[CallerCount(0)]
			public unsafe int _GetLatestSelectionCounter_b__28_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.__c.NativeMethodInfoPtr__GetLatestSelectionCounter_b__28_1_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001E69 RID: 7785 RVA: 0x0008D898 File Offset: 0x0008BA98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ConsumeCounter_b__30_0(PlayerEntity bp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bp);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.__c.NativeMethodInfoPtr__ConsumeCounter_b__30_0_Internal_Boolean_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E6A RID: 7786 RVA: 0x0008D8E8 File Offset: 0x0008BAE8
			[CallerCount(0)]
			public unsafe bool _CancelPendingResponse_b__31_1(bool _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.__c.NativeMethodInfoPtr__CancelPendingResponse_b__31_1_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E6B RID: 7787 RVA: 0x0000E9C4 File Offset: 0x0000CBC4
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700071B RID: 1819
			// (get) Token: 0x06001E6C RID: 7788 RVA: 0x0008D934 File Offset: 0x0008BB34
			// (set) Token: 0x06001E6D RID: 7789 RVA: 0x0000E9CD File Offset: 0x0000CBCD
			public unsafe static HasExecutionStack.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasExecutionStack.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HasExecutionStack.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasExecutionStack.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700071C RID: 1820
			// (get) Token: 0x06001E6E RID: 7790 RVA: 0x0008D95C File Offset: 0x0008BB5C
			// (set) Token: 0x06001E6F RID: 7791 RVA: 0x0000E9DF File Offset: 0x0000CBDF
			public unsafe static Func<PlayerEntity, bool> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasExecutionStack.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasExecutionStack.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700071D RID: 1821
			// (get) Token: 0x06001E70 RID: 7792 RVA: 0x0008D984 File Offset: 0x0008BB84
			// (set) Token: 0x06001E71 RID: 7793 RVA: 0x0000E9F1 File Offset: 0x0000CBF1
			public unsafe static Func<PlayerEntity, IEnumerable<PendingSelection>> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasExecutionStack.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, IEnumerable<PendingSelection>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasExecutionStack.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700071E RID: 1822
			// (get) Token: 0x06001E72 RID: 7794 RVA: 0x0008D9AC File Offset: 0x0008BBAC
			// (set) Token: 0x06001E73 RID: 7795 RVA: 0x0000EA03 File Offset: 0x0000CC03
			public unsafe static Func<PlayerEntity, ValueTuple<PlayerEntity, IReadOnlyCollection<PendingSelection>>> __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasExecutionStack.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, ValueTuple<PlayerEntity, IReadOnlyCollection<PendingSelection>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasExecutionStack.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700071F RID: 1823
			// (get) Token: 0x06001E74 RID: 7796 RVA: 0x0008D9D4 File Offset: 0x0008BBD4
			// (set) Token: 0x06001E75 RID: 7797 RVA: 0x0000EA15 File Offset: 0x0000CC15
			public unsafe static Func<ValueTuple<PlayerEntity, PendingSelection>, bool> __9__23_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasExecutionStack.__c.NativeFieldInfoPtr___9__23_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<PlayerEntity, PendingSelection>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasExecutionStack.__c.NativeFieldInfoPtr___9__23_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000720 RID: 1824
			// (get) Token: 0x06001E76 RID: 7798 RVA: 0x0008D9FC File Offset: 0x0008BBFC
			// (set) Token: 0x06001E77 RID: 7799 RVA: 0x0000EA27 File Offset: 0x0000CC27
			public unsafe static Func<PendingSelection, int> __9__28_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasExecutionStack.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PendingSelection, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasExecutionStack.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000721 RID: 1825
			// (get) Token: 0x06001E78 RID: 7800 RVA: 0x0008DA24 File Offset: 0x0008BC24
			// (set) Token: 0x06001E79 RID: 7801 RVA: 0x0000EA39 File Offset: 0x0000CC39
			public unsafe static Func<int> __9__28_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasExecutionStack.__c.NativeFieldInfoPtr___9__28_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasExecutionStack.__c.NativeFieldInfoPtr___9__28_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000722 RID: 1826
			// (get) Token: 0x06001E7A RID: 7802 RVA: 0x0008DA4C File Offset: 0x0008BC4C
			// (set) Token: 0x06001E7B RID: 7803 RVA: 0x0000EA4B File Offset: 0x0000CC4B
			public unsafe static Func<PlayerEntity, bool> __9__30_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasExecutionStack.__c.NativeFieldInfoPtr___9__30_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasExecutionStack.__c.NativeFieldInfoPtr___9__30_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000723 RID: 1827
			// (get) Token: 0x06001E7C RID: 7804 RVA: 0x0008DA74 File Offset: 0x0008BC74
			// (set) Token: 0x06001E7D RID: 7805 RVA: 0x0000EA5D File Offset: 0x0000CC5D
			public unsafe static Func<bool, bool> __9__31_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HasExecutionStack.__c.NativeFieldInfoPtr___9__31_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HasExecutionStack.__c.NativeFieldInfoPtr___9__31_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001338 RID: 4920
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001339 RID: 4921
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x0400133A RID: 4922
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x0400133B RID: 4923
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x0400133C RID: 4924
			private static readonly IntPtr NativeFieldInfoPtr___9__23_1;

			// Token: 0x0400133D RID: 4925
			private static readonly IntPtr NativeFieldInfoPtr___9__28_0;

			// Token: 0x0400133E RID: 4926
			private static readonly IntPtr NativeFieldInfoPtr___9__28_1;

			// Token: 0x0400133F RID: 4927
			private static readonly IntPtr NativeFieldInfoPtr___9__30_0;

			// Token: 0x04001340 RID: 4928
			private static readonly IntPtr NativeFieldInfoPtr___9__31_1;

			// Token: 0x04001341 RID: 4929
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001342 RID: 4930
			private static readonly IntPtr NativeMethodInfoPtr__Run_b__18_0_Internal_Boolean_PlayerEntity_0;

			// Token: 0x04001343 RID: 4931
			private static readonly IntPtr NativeMethodInfoPtr__AllPendingResponses_b__19_0_Internal_IEnumerable_1_PendingSelection_PlayerEntity_0;

			// Token: 0x04001344 RID: 4932
			private static readonly IntPtr NativeMethodInfoPtr__AllPlayerPendingResponses_b__20_0_Internal_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_PlayerEntity_0;

			// Token: 0x04001345 RID: 4933
			private static readonly IntPtr NativeMethodInfoPtr__CountPlayerPendingResponsesForCounter_b__23_1_Internal_Boolean_ValueTuple_2_PlayerEntity_PendingSelection_0;

			// Token: 0x04001346 RID: 4934
			private static readonly IntPtr NativeMethodInfoPtr__GetLatestSelectionCounter_b__28_0_Internal_Int32_PendingSelection_0;

			// Token: 0x04001347 RID: 4935
			private static readonly IntPtr NativeMethodInfoPtr__GetLatestSelectionCounter_b__28_1_Internal_Int32_0;

			// Token: 0x04001348 RID: 4936
			private static readonly IntPtr NativeMethodInfoPtr__ConsumeCounter_b__30_0_Internal_Boolean_PlayerEntity_0;

			// Token: 0x04001349 RID: 4937
			private static readonly IntPtr NativeMethodInfoPtr__CancelPendingResponse_b__31_1_Internal_Boolean_Boolean_0;
		}

		// Token: 0x020002D6 RID: 726
		[ObfuscatedName("Canis.hasExecutionStack.HasExecutionStack+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Object
		{
			// Token: 0x06001E7E RID: 7806 RVA: 0x0008DA9C File Offset: 0x0008BC9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass22_0>.NativeClassPtr);
				HasExecutionStack.__c__DisplayClass22_0.NativeFieldInfoPtr_selectionCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass22_0>.NativeClassPtr, "selectionCounter");
				HasExecutionStack.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass22_0>.NativeClassPtr, 100664811);
				HasExecutionStack.__c__DisplayClass22_0.NativeMethodInfoPtr__HasPendingResponse_b__0_Internal_Boolean_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass22_0>.NativeClassPtr, 100664812);
			}

			// Token: 0x06001E7F RID: 7807 RVA: 0x0008DB04 File Offset: 0x0008BD04
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E80 RID: 7808 RVA: 0x0008DB40 File Offset: 0x0008BD40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557207, XrefRangeEnd = 557208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HasPendingResponse_b__0(PendingSelection ps)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ps);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.__c__DisplayClass22_0.NativeMethodInfoPtr__HasPendingResponse_b__0_Internal_Boolean_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E81 RID: 7809 RVA: 0x0000EA6F File Offset: 0x0000CC6F
			public __c__DisplayClass22_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000724 RID: 1828
			// (get) Token: 0x06001E82 RID: 7810 RVA: 0x0008DB90 File Offset: 0x0008BD90
			// (set) Token: 0x06001E83 RID: 7811 RVA: 0x0000EA78 File Offset: 0x0000CC78
			public unsafe int selectionCounter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.__c__DisplayClass22_0.NativeFieldInfoPtr_selectionCounter);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.__c__DisplayClass22_0.NativeFieldInfoPtr_selectionCounter)) = value;
				}
			}

			// Token: 0x0400134A RID: 4938
			private static readonly IntPtr NativeFieldInfoPtr_selectionCounter;

			// Token: 0x0400134B RID: 4939
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400134C RID: 4940
			private static readonly IntPtr NativeMethodInfoPtr__HasPendingResponse_b__0_Internal_Boolean_PendingSelection_0;
		}

		// Token: 0x020002D7 RID: 727
		[ObfuscatedName("Canis.hasExecutionStack.HasExecutionStack+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Object
		{
			// Token: 0x06001E84 RID: 7812 RVA: 0x0008DBB8 File Offset: 0x0008BDB8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass23_0>.NativeClassPtr);
				HasExecutionStack.__c__DisplayClass23_0.NativeFieldInfoPtr_selectionCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass23_0>.NativeClassPtr, "selectionCounter");
				HasExecutionStack.__c__DisplayClass23_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass23_0>.NativeClassPtr, "<>9__2");
				HasExecutionStack.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass23_0>.NativeClassPtr, 100664813);
				HasExecutionStack.__c__DisplayClass23_0.NativeMethodInfoPtr__CountPlayerPendingResponsesForCounter_b__0_Internal_ValueTuple_2_PlayerEntity_PendingSelection_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass23_0>.NativeClassPtr, 100664814);
				HasExecutionStack.__c__DisplayClass23_0.NativeMethodInfoPtr__CountPlayerPendingResponsesForCounter_b__2_Internal_Boolean_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass23_0>.NativeClassPtr, 100664815);
			}

			// Token: 0x06001E85 RID: 7813 RVA: 0x0008DC48 File Offset: 0x0008BE48
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E86 RID: 7814 RVA: 0x0008DC84 File Offset: 0x0008BE84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557208, XrefRangeEnd = 557221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<PlayerEntity, PendingSelection> _CountPlayerPendingResponsesForCounter_b__0(ValueTuple<PlayerEntity, IReadOnlyCollection<PendingSelection>> tup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tup));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.__c__DisplayClass23_0.NativeMethodInfoPtr__CountPlayerPendingResponsesForCounter_b__0_Internal_ValueTuple_2_PlayerEntity_PendingSelection_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<PlayerEntity, PendingSelection>(intPtr);
				}
			}

			// Token: 0x06001E87 RID: 7815 RVA: 0x0008DCD4 File Offset: 0x0008BED4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CountPlayerPendingResponsesForCounter_b__2(PendingSelection ps)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ps);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.__c__DisplayClass23_0.NativeMethodInfoPtr__CountPlayerPendingResponsesForCounter_b__2_Internal_Boolean_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E88 RID: 7816 RVA: 0x0000EA93 File Offset: 0x0000CC93
			public __c__DisplayClass23_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000725 RID: 1829
			// (get) Token: 0x06001E89 RID: 7817 RVA: 0x0008DD24 File Offset: 0x0008BF24
			// (set) Token: 0x06001E8A RID: 7818 RVA: 0x0000EA9C File Offset: 0x0000CC9C
			public unsafe int selectionCounter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.__c__DisplayClass23_0.NativeFieldInfoPtr_selectionCounter);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.__c__DisplayClass23_0.NativeFieldInfoPtr_selectionCounter)) = value;
				}
			}

			// Token: 0x17000726 RID: 1830
			// (get) Token: 0x06001E8B RID: 7819 RVA: 0x0008DD4C File Offset: 0x0008BF4C
			// (set) Token: 0x06001E8C RID: 7820 RVA: 0x0000EAB7 File Offset: 0x0000CCB7
			public unsafe Func<PendingSelection, bool> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.__c__DisplayClass23_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PendingSelection, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.__c__DisplayClass23_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400134D RID: 4941
			private static readonly IntPtr NativeFieldInfoPtr_selectionCounter;

			// Token: 0x0400134E RID: 4942
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x0400134F RID: 4943
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001350 RID: 4944
			private static readonly IntPtr NativeMethodInfoPtr__CountPlayerPendingResponsesForCounter_b__0_Internal_ValueTuple_2_PlayerEntity_PendingSelection_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_0;

			// Token: 0x04001351 RID: 4945
			private static readonly IntPtr NativeMethodInfoPtr__CountPlayerPendingResponsesForCounter_b__2_Internal_Boolean_PendingSelection_0;
		}

		// Token: 0x020002D8 RID: 728
		[ObfuscatedName("Canis.hasExecutionStack.HasExecutionStack+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : Object
		{
			// Token: 0x06001E8D RID: 7821 RVA: 0x0008DD7C File Offset: 0x0008BF7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass24_0>.NativeClassPtr);
				HasExecutionStack.__c__DisplayClass24_0.NativeFieldInfoPtr_selectingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass24_0>.NativeClassPtr, "selectingPlayer");
				HasExecutionStack.__c__DisplayClass24_0.NativeFieldInfoPtr_selectionCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass24_0>.NativeClassPtr, "selectionCounter");
				HasExecutionStack.__c__DisplayClass24_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass24_0>.NativeClassPtr, "<>9__2");
				HasExecutionStack.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass24_0>.NativeClassPtr, 100664816);
				HasExecutionStack.__c__DisplayClass24_0.NativeMethodInfoPtr__GetPlayerPendingResponse_b__0_Internal_Boolean_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass24_0>.NativeClassPtr, 100664817);
				HasExecutionStack.__c__DisplayClass24_0.NativeMethodInfoPtr__GetPlayerPendingResponse_b__1_Internal_PendingSelection_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass24_0>.NativeClassPtr, 100664818);
				HasExecutionStack.__c__DisplayClass24_0.NativeMethodInfoPtr__GetPlayerPendingResponse_b__2_Internal_Boolean_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass24_0>.NativeClassPtr, 100664819);
			}

			// Token: 0x06001E8E RID: 7822 RVA: 0x0008DE34 File Offset: 0x0008C034
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E8F RID: 7823 RVA: 0x0008DE70 File Offset: 0x0008C070
			[CallerCount(0)]
			public unsafe bool _GetPlayerPendingResponse_b__0(ValueTuple<PlayerEntity, IReadOnlyCollection<PendingSelection>> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.__c__DisplayClass24_0.NativeMethodInfoPtr__GetPlayerPendingResponse_b__0_Internal_Boolean_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E90 RID: 7824 RVA: 0x0008DEC4 File Offset: 0x0008C0C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557221, XrefRangeEnd = 557231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PendingSelection _GetPlayerPendingResponse_b__1(ValueTuple<PlayerEntity, IReadOnlyCollection<PendingSelection>> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.__c__DisplayClass24_0.NativeMethodInfoPtr__GetPlayerPendingResponse_b__1_Internal_PendingSelection_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PendingSelection>(intPtr3) : null;
				}
			}

			// Token: 0x06001E91 RID: 7825 RVA: 0x0008DF1C File Offset: 0x0008C11C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557231, XrefRangeEnd = 557232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetPlayerPendingResponse_b__2(PendingSelection ps)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ps);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.__c__DisplayClass24_0.NativeMethodInfoPtr__GetPlayerPendingResponse_b__2_Internal_Boolean_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E92 RID: 7826 RVA: 0x0000EAD6 File Offset: 0x0000CCD6
			public __c__DisplayClass24_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000727 RID: 1831
			// (get) Token: 0x06001E93 RID: 7827 RVA: 0x0008DF6C File Offset: 0x0008C16C
			// (set) Token: 0x06001E94 RID: 7828 RVA: 0x0000EADF File Offset: 0x0000CCDF
			public unsafe PlayerEntity selectingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.__c__DisplayClass24_0.NativeFieldInfoPtr_selectingPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.__c__DisplayClass24_0.NativeFieldInfoPtr_selectingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000728 RID: 1832
			// (get) Token: 0x06001E95 RID: 7829 RVA: 0x0008DF9C File Offset: 0x0008C19C
			// (set) Token: 0x06001E96 RID: 7830 RVA: 0x0000EAFE File Offset: 0x0000CCFE
			public unsafe int selectionCounter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.__c__DisplayClass24_0.NativeFieldInfoPtr_selectionCounter);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.__c__DisplayClass24_0.NativeFieldInfoPtr_selectionCounter)) = value;
				}
			}

			// Token: 0x17000729 RID: 1833
			// (get) Token: 0x06001E97 RID: 7831 RVA: 0x0008DFC4 File Offset: 0x0008C1C4
			// (set) Token: 0x06001E98 RID: 7832 RVA: 0x0000EB19 File Offset: 0x0000CD19
			public unsafe Func<PendingSelection, bool> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.__c__DisplayClass24_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PendingSelection, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.__c__DisplayClass24_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001352 RID: 4946
			private static readonly IntPtr NativeFieldInfoPtr_selectingPlayer;

			// Token: 0x04001353 RID: 4947
			private static readonly IntPtr NativeFieldInfoPtr_selectionCounter;

			// Token: 0x04001354 RID: 4948
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x04001355 RID: 4949
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001356 RID: 4950
			private static readonly IntPtr NativeMethodInfoPtr__GetPlayerPendingResponse_b__0_Internal_Boolean_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_0;

			// Token: 0x04001357 RID: 4951
			private static readonly IntPtr NativeMethodInfoPtr__GetPlayerPendingResponse_b__1_Internal_PendingSelection_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_0;

			// Token: 0x04001358 RID: 4952
			private static readonly IntPtr NativeMethodInfoPtr__GetPlayerPendingResponse_b__2_Internal_Boolean_PendingSelection_0;
		}

		// Token: 0x020002D9 RID: 729
		[ObfuscatedName("Canis.hasExecutionStack.HasExecutionStack+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Object
		{
			// Token: 0x06001E99 RID: 7833 RVA: 0x0008DFF4 File Offset: 0x0008C1F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass26_0>.NativeClassPtr);
				HasExecutionStack.__c__DisplayClass26_0.NativeFieldInfoPtr_selectionCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass26_0>.NativeClassPtr, "selectionCounter");
				HasExecutionStack.__c__DisplayClass26_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass26_0>.NativeClassPtr, "<>9__0");
				HasExecutionStack.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass26_0>.NativeClassPtr, 100664820);
				HasExecutionStack.__c__DisplayClass26_0.NativeMethodInfoPtr__GetPlayerEntityForCounter_b__0_Internal_Boolean_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass26_0>.NativeClassPtr, 100664821);
			}

			// Token: 0x06001E9A RID: 7834 RVA: 0x0008E070 File Offset: 0x0008C270
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E9B RID: 7835 RVA: 0x0008E0AC File Offset: 0x0008C2AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetPlayerEntityForCounter_b__0(PendingSelection pr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.__c__DisplayClass26_0.NativeMethodInfoPtr__GetPlayerEntityForCounter_b__0_Internal_Boolean_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E9C RID: 7836 RVA: 0x0000EB38 File Offset: 0x0000CD38
			public __c__DisplayClass26_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700072A RID: 1834
			// (get) Token: 0x06001E9D RID: 7837 RVA: 0x0008E0FC File Offset: 0x0008C2FC
			// (set) Token: 0x06001E9E RID: 7838 RVA: 0x0000EB41 File Offset: 0x0000CD41
			public unsafe int selectionCounter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.__c__DisplayClass26_0.NativeFieldInfoPtr_selectionCounter);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.__c__DisplayClass26_0.NativeFieldInfoPtr_selectionCounter)) = value;
				}
			}

			// Token: 0x1700072B RID: 1835
			// (get) Token: 0x06001E9F RID: 7839 RVA: 0x0008E124 File Offset: 0x0008C324
			// (set) Token: 0x06001EA0 RID: 7840 RVA: 0x0000EB5C File Offset: 0x0000CD5C
			public unsafe Func<PendingSelection, bool> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.__c__DisplayClass26_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PendingSelection, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.__c__DisplayClass26_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001359 RID: 4953
			private static readonly IntPtr NativeFieldInfoPtr_selectionCounter;

			// Token: 0x0400135A RID: 4954
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x0400135B RID: 4955
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400135C RID: 4956
			private static readonly IntPtr NativeMethodInfoPtr__GetPlayerEntityForCounter_b__0_Internal_Boolean_PendingSelection_0;
		}

		// Token: 0x020002DA RID: 730
		[ObfuscatedName("Canis.hasExecutionStack.HasExecutionStack+<>c__DisplayClass31_0")]
		public sealed class __c__DisplayClass31_0 : Object
		{
			// Token: 0x06001EA1 RID: 7841 RVA: 0x0008E154 File Offset: 0x0008C354
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HasExecutionStack>.NativeClassPtr, "<>c__DisplayClass31_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass31_0>.NativeClassPtr);
				HasExecutionStack.__c__DisplayClass31_0.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass31_0>.NativeClassPtr, "counter");
				HasExecutionStack.__c__DisplayClass31_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass31_0>.NativeClassPtr, "<>9__2");
				HasExecutionStack.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass31_0>.NativeClassPtr, 100664822);
				HasExecutionStack.__c__DisplayClass31_0.NativeMethodInfoPtr__CancelPendingResponse_b__0_Internal_Boolean_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass31_0>.NativeClassPtr, 100664823);
				HasExecutionStack.__c__DisplayClass31_0.NativeMethodInfoPtr__CancelPendingResponse_b__2_Internal_Boolean_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass31_0>.NativeClassPtr, 100664824);
			}

			// Token: 0x06001EA2 RID: 7842 RVA: 0x0008E1E4 File Offset: 0x0008C3E4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasExecutionStack.__c__DisplayClass31_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EA3 RID: 7843 RVA: 0x0008E220 File Offset: 0x0008C420
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557232, XrefRangeEnd = 557256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CancelPendingResponse_b__0(ValueTuple<PlayerEntity, IReadOnlyCollection<PendingSelection>> tup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tup));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.__c__DisplayClass31_0.NativeMethodInfoPtr__CancelPendingResponse_b__0_Internal_Boolean_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001EA4 RID: 7844 RVA: 0x0008E274 File Offset: 0x0008C474
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CancelPendingResponse_b__2(PendingSelection _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HasExecutionStack.__c__DisplayClass31_0.NativeMethodInfoPtr__CancelPendingResponse_b__2_Internal_Boolean_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001EA5 RID: 7845 RVA: 0x0000EB7B File Offset: 0x0000CD7B
			public __c__DisplayClass31_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700072C RID: 1836
			// (get) Token: 0x06001EA6 RID: 7846 RVA: 0x0008E2C4 File Offset: 0x0008C4C4
			// (set) Token: 0x06001EA7 RID: 7847 RVA: 0x0000EB84 File Offset: 0x0000CD84
			public unsafe int counter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.__c__DisplayClass31_0.NativeFieldInfoPtr_counter);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.__c__DisplayClass31_0.NativeFieldInfoPtr_counter)) = value;
				}
			}

			// Token: 0x1700072D RID: 1837
			// (get) Token: 0x06001EA8 RID: 7848 RVA: 0x0008E2EC File Offset: 0x0008C4EC
			// (set) Token: 0x06001EA9 RID: 7849 RVA: 0x0000EB9F File Offset: 0x0000CD9F
			public unsafe Func<PendingSelection, bool> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.__c__DisplayClass31_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PendingSelection, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasExecutionStack.__c__DisplayClass31_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400135D RID: 4957
			private static readonly IntPtr NativeFieldInfoPtr_counter;

			// Token: 0x0400135E RID: 4958
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x0400135F RID: 4959
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001360 RID: 4960
			private static readonly IntPtr NativeMethodInfoPtr__CancelPendingResponse_b__0_Internal_Boolean_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_0;

			// Token: 0x04001361 RID: 4961
			private static readonly IntPtr NativeMethodInfoPtr__CancelPendingResponse_b__2_Internal_Boolean_PendingSelection_0;
		}
	}
}
