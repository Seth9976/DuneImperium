using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Networking.selection.targetresponse;

namespace dwd.core.match.selection.messages.outgoing
{
	// Token: 0x0200015F RID: 351
	public class CustomChoiceWithTargets : Object
	{
		// Token: 0x060014A6 RID: 5286 RVA: 0x0006700C File Offset: 0x0006520C
		// Note: this type is marked as 'beforefieldinit'.
		static CustomChoiceWithTargets()
		{
			Il2CppClassPointerStore<CustomChoiceWithTargets>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection.messages.outgoing", "CustomChoiceWithTargets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomChoiceWithTargets>.NativeClassPtr);
			CustomChoiceWithTargets.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceWithTargets>.NativeClassPtr, "GameID");
			CustomChoiceWithTargets.NativeFieldInfoPtr_Counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceWithTargets>.NativeClassPtr, "Counter");
			CustomChoiceWithTargets.NativeFieldInfoPtr_Selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceWithTargets>.NativeClassPtr, "Selection");
			CustomChoiceWithTargets.NativeMethodInfoPtr__ctor_Public_Void_GameID_Int32_Tuple_2_Int32_Il2CppReferenceArray_1_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceWithTargets>.NativeClassPtr, 100666412);
			CustomChoiceWithTargets.NativeMethodInfoPtr_GetCounter_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceWithTargets>.NativeClassPtr, 100666413);
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x000670A0 File Offset: 0x000652A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 376295, RefRangeEnd = 376296, XrefRangeStart = 376295, XrefRangeEnd = 376296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomChoiceWithTargets(GameID gameID, int counter, Tuple<int, Il2CppReferenceArray<TargetResponse>> selection)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomChoiceWithTargets>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref counter;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceWithTargets.NativeMethodInfoPtr__ctor_Public_Void_GameID_Int32_Tuple_2_Int32_Il2CppReferenceArray_1_TargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x0006710C File Offset: 0x0006530C
		[CallerCount(0)]
		public unsafe virtual int GetCounter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceWithTargets.NativeMethodInfoPtr_GetCounter_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x00009218 File Offset: 0x00007418
		public CustomChoiceWithTargets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x060014AA RID: 5290 RVA: 0x00067148 File Offset: 0x00065348
		// (set) Token: 0x060014AB RID: 5291 RVA: 0x00009221 File Offset: 0x00007421
		public unsafe GameID GameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargets.NativeFieldInfoPtr_GameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargets.NativeFieldInfoPtr_GameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x060014AC RID: 5292 RVA: 0x00067178 File Offset: 0x00065378
		// (set) Token: 0x060014AD RID: 5293 RVA: 0x00009240 File Offset: 0x00007440
		public unsafe int Counter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargets.NativeFieldInfoPtr_Counter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargets.NativeFieldInfoPtr_Counter)) = value;
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x060014AE RID: 5294 RVA: 0x000671A0 File Offset: 0x000653A0
		// (set) Token: 0x060014AF RID: 5295 RVA: 0x0000925B File Offset: 0x0000745B
		public unsafe Tuple<int, Il2CppReferenceArray<TargetResponse>> Selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargets.NativeFieldInfoPtr_Selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tuple<int, Il2CppReferenceArray<TargetResponse>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargets.NativeFieldInfoPtr_Selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EC8 RID: 3784
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x04000EC9 RID: 3785
		private static readonly IntPtr NativeFieldInfoPtr_Counter;

		// Token: 0x04000ECA RID: 3786
		private static readonly IntPtr NativeFieldInfoPtr_Selection;

		// Token: 0x04000ECB RID: 3787
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameID_Int32_Tuple_2_Int32_Il2CppReferenceArray_1_TargetResponse_0;

		// Token: 0x04000ECC RID: 3788
		private static readonly IntPtr NativeMethodInfoPtr_GetCounter_Public_Virtual_Final_New_Int32_0;
	}
}
