using System;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions.continuations
{
	// Token: 0x02000227 RID: 551
	[Serializable]
	public class ContinueExecuteStack : ActionContinuation
	{
		// Token: 0x060016F0 RID: 5872 RVA: 0x000756A4 File Offset: 0x000738A4
		// Note: this type is marked as 'beforefieldinit'.
		static ContinueExecuteStack()
		{
			Il2CppClassPointerStore<ContinueExecuteStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.continuations", "ContinueExecuteStack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinueExecuteStack>.NativeClassPtr);
			ContinueExecuteStack.NativeFieldInfoPtr_Continuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueExecuteStack>.NativeClassPtr, "Continuation");
			ContinueExecuteStack.NativeFieldInfoPtr_SerializedStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueExecuteStack>.NativeClassPtr, "SerializedStack");
			ContinueExecuteStack.NativeMethodInfoPtr__ctor_Public_Void_ActionContinuation_SerializedExecuteStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueExecuteStack>.NativeClassPtr, 100668502);
			ContinueExecuteStack.NativeMethodInfoPtr_Instance_Public_Static_ContinueExecuteStack_ActionContinuation_ExecuteStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueExecuteStack>.NativeClassPtr, 100668503);
			ContinueExecuteStack.NativeMethodInfoPtr_MakeContinuationActions_Public_Virtual_IEnumerable_1_ActionAcrossTargets_IEnumerable_PlayerEntity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueExecuteStack>.NativeClassPtr, 100668504);
			ContinueExecuteStack.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueExecuteStack>.NativeClassPtr, 100668505);
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x0007574C File Offset: 0x0007394C
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContinueExecuteStack(ActionContinuation continuation, SerializedExecuteStack serializedStack)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContinueExecuteStack>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serializedStack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueExecuteStack.NativeMethodInfoPtr__ctor_Public_Void_ActionContinuation_SerializedExecuteStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x000757AC File Offset: 0x000739AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594222, XrefRangeEnd = 594229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ContinueExecuteStack Instance(ActionContinuation continuation, ExecuteStack stack)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueExecuteStack.NativeMethodInfoPtr_Instance_Public_Static_ContinueExecuteStack_ActionContinuation_ExecuteStack_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContinueExecuteStack>(intPtr3) : null;
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x00075804 File Offset: 0x00073A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContinueExecuteStack.NativeMethodInfoPtr_MakeContinuationActions_Public_Virtual_IEnumerable_1_ActionAcrossTargets_IEnumerable_PlayerEntity_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ActionAcrossTargets>>(intPtr3) : null;
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x00075884 File Offset: 0x00073A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594229, XrefRangeEnd = 594232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContinueExecuteStack.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x0000AF48 File Offset: 0x00009148
		public ContinueExecuteStack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060016F6 RID: 5878 RVA: 0x000758C8 File Offset: 0x00073AC8
		// (set) Token: 0x060016F7 RID: 5879 RVA: 0x0000AF51 File Offset: 0x00009151
		public unsafe ActionContinuation Continuation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueExecuteStack.NativeFieldInfoPtr_Continuation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionContinuation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueExecuteStack.NativeFieldInfoPtr_Continuation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060016F8 RID: 5880 RVA: 0x000758F8 File Offset: 0x00073AF8
		// (set) Token: 0x060016F9 RID: 5881 RVA: 0x0000AF70 File Offset: 0x00009170
		public unsafe SerializedExecuteStack SerializedStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueExecuteStack.NativeFieldInfoPtr_SerializedStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedExecuteStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueExecuteStack.NativeFieldInfoPtr_SerializedStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EBA RID: 3770
		private static readonly IntPtr NativeFieldInfoPtr_Continuation;

		// Token: 0x04000EBB RID: 3771
		private static readonly IntPtr NativeFieldInfoPtr_SerializedStack;

		// Token: 0x04000EBC RID: 3772
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ActionContinuation_SerializedExecuteStack_0;

		// Token: 0x04000EBD RID: 3773
		private static readonly IntPtr NativeMethodInfoPtr_Instance_Public_Static_ContinueExecuteStack_ActionContinuation_ExecuteStack_0;

		// Token: 0x04000EBE RID: 3774
		private static readonly IntPtr NativeMethodInfoPtr_MakeContinuationActions_Public_Virtual_IEnumerable_1_ActionAcrossTargets_IEnumerable_PlayerEntity_Match_0;

		// Token: 0x04000EBF RID: 3775
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
