using System;
using Canis.actions.completions;
using Canis.actions.continuations;
using Canis.actions.responseparsers;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages;

namespace Canis.data
{
	// Token: 0x02000156 RID: 342
	public class PendingSelection : Object
	{
		// Token: 0x06000EFF RID: 3839 RVA: 0x0005832C File Offset: 0x0005652C
		// Note: this type is marked as 'beforefieldinit'.
		static PendingSelection()
		{
			Il2CppClassPointerStore<PendingSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.data", "PendingSelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PendingSelection>.NativeClassPtr);
			PendingSelection.NativeFieldInfoPtr_Selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingSelection>.NativeClassPtr, "Selection");
			PendingSelection.NativeFieldInfoPtr_OfferedAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingSelection>.NativeClassPtr, "OfferedAt");
			PendingSelection.NativeFieldInfoPtr_ResponseParser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingSelection>.NativeClassPtr, "ResponseParser");
			PendingSelection.NativeFieldInfoPtr_Continuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingSelection>.NativeClassPtr, "Continuation");
			PendingSelection.NativeFieldInfoPtr_Completion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingSelection>.NativeClassPtr, "Completion");
			PendingSelection.NativeMethodInfoPtr_get_Counter_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingSelection>.NativeClassPtr, 100666526);
			PendingSelection.NativeMethodInfoPtr_GenerateContinuationAction_Public_IEnumerable_1_ActionAcrossTargets_IEnumerable_PlayerEntity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingSelection>.NativeClassPtr, 100666527);
			PendingSelection.NativeMethodInfoPtr_ParseSelectionResponse_Public_IEnumerable_Match_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingSelection>.NativeClassPtr, 100666528);
			PendingSelection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingSelection>.NativeClassPtr, 100666529);
			PendingSelection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingSelection>.NativeClassPtr, 100666530);
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x00058424 File Offset: 0x00056624
		public unsafe int Counter
		{
			[CallerCount(34)]
			[CachedScanResults(RefRangeStart = 577910, RefRangeEnd = 577944, XrefRangeStart = 577910, XrefRangeEnd = 577910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingSelection.NativeMethodInfoPtr_get_Counter_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x00058460 File Offset: 0x00056660
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 577945, RefRangeEnd = 577946, XrefRangeStart = 577944, XrefRangeEnd = 577945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ActionAcrossTargets> GenerateContinuationAction(IEnumerable selectionResponse, PlayerEntity selectingPlayer, Match match)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingSelection.NativeMethodInfoPtr_GenerateContinuationAction_Public_IEnumerable_1_ActionAcrossTargets_IEnumerable_PlayerEntity_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ActionAcrossTargets>>(intPtr3) : null;
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x000584D4 File Offset: 0x000566D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 577947, RefRangeEnd = 577948, XrefRangeStart = 577946, XrefRangeEnd = 577947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable ParseSelectionResponse(Match match, Object responseMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responseMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingSelection.NativeMethodInfoPtr_ParseSelectionResponse_Public_IEnumerable_Match_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable>(intPtr3) : null;
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x00058538 File Offset: 0x00056738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577948, XrefRangeEnd = 577965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PendingSelection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x0005857C File Offset: 0x0005677C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PendingSelection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PendingSelection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingSelection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x0000795A File Offset: 0x00005B5A
		public PendingSelection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000F06 RID: 3846 RVA: 0x000585B8 File Offset: 0x000567B8
		// (set) Token: 0x06000F07 RID: 3847 RVA: 0x00007963 File Offset: 0x00005B63
		public unsafe SelectionMessage Selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingSelection.NativeFieldInfoPtr_Selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingSelection.NativeFieldInfoPtr_Selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000F08 RID: 3848 RVA: 0x000585E8 File Offset: 0x000567E8
		// (set) Token: 0x06000F09 RID: 3849 RVA: 0x00007982 File Offset: 0x00005B82
		public unsafe long OfferedAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingSelection.NativeFieldInfoPtr_OfferedAt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingSelection.NativeFieldInfoPtr_OfferedAt)) = value;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000F0A RID: 3850 RVA: 0x00058610 File Offset: 0x00056810
		// (set) Token: 0x06000F0B RID: 3851 RVA: 0x0000799D File Offset: 0x00005B9D
		public unsafe ResponseParser ResponseParser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingSelection.NativeFieldInfoPtr_ResponseParser);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResponseParser>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingSelection.NativeFieldInfoPtr_ResponseParser), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000F0C RID: 3852 RVA: 0x00058640 File Offset: 0x00056840
		// (set) Token: 0x06000F0D RID: 3853 RVA: 0x000079BC File Offset: 0x00005BBC
		public unsafe ActionContinuation Continuation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingSelection.NativeFieldInfoPtr_Continuation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionContinuation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingSelection.NativeFieldInfoPtr_Continuation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x00058670 File Offset: 0x00056870
		// (set) Token: 0x06000F0F RID: 3855 RVA: 0x000079DB File Offset: 0x00005BDB
		public unsafe SelectionCompletion Completion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingSelection.NativeFieldInfoPtr_Completion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionCompletion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingSelection.NativeFieldInfoPtr_Completion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeFieldInfoPtr_Selection;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeFieldInfoPtr_OfferedAt;

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeFieldInfoPtr_ResponseParser;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeFieldInfoPtr_Continuation;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeFieldInfoPtr_Completion;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeMethodInfoPtr_get_Counter_Public_get_Int32_0;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeMethodInfoPtr_GenerateContinuationAction_Public_IEnumerable_1_ActionAcrossTargets_IEnumerable_PlayerEntity_Match_0;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeMethodInfoPtr_ParseSelectionResponse_Public_IEnumerable_Match_Object_0;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
