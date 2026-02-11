using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.targetresponse;

namespace Networking.selection.messages.outgoing
{
	// Token: 0x0200008B RID: 139
	public class SelectionWithTargets : Object
	{
		// Token: 0x060004A8 RID: 1192 RVA: 0x00012740 File Offset: 0x00010940
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionWithTargets()
		{
			Il2CppClassPointerStore<SelectionWithTargets>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.messages.outgoing", "SelectionWithTargets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionWithTargets>.NativeClassPtr);
			SelectionWithTargets.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargets>.NativeClassPtr, "gameID");
			SelectionWithTargets.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargets>.NativeClassPtr, "selection");
			SelectionWithTargets.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargets>.NativeClassPtr, "counter");
			SelectionWithTargets.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargets>.NativeClassPtr, 100663604);
			SelectionWithTargets.NativeMethodInfoPtr__ctor_Public_Void_SelectionMessage_EntityID_IEnumerable_1_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargets>.NativeClassPtr, 100663605);
			SelectionWithTargets.NativeMethodInfoPtr_GetCounter_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargets>.NativeClassPtr, 100663606);
			SelectionWithTargets.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargets>.NativeClassPtr, 100663607);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x000127FC File Offset: 0x000109FC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionWithTargets()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionWithTargets>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargets.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00012838 File Offset: 0x00010A38
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1194945, RefRangeEnd = 1194960, XrefRangeStart = 1194924, XrefRangeEnd = 1194945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionWithTargets(SelectionMessage message, EntityID entityID, IEnumerable<TargetResponse> targetResponses)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionWithTargets>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetResponses);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargets.NativeMethodInfoPtr__ctor_Public_Void_SelectionMessage_EntityID_IEnumerable_1_TargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x000128A8 File Offset: 0x00010AA8
		[CallerCount(0)]
		public unsafe virtual int GetCounter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargets.NativeMethodInfoPtr_GetCounter_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x000128E4 File Offset: 0x00010AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194960, XrefRangeEnd = 1194966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionWithTargets.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00004DAF File Offset: 0x00002FAF
		public SelectionWithTargets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00012928 File Offset: 0x00010B28
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x00004DB8 File Offset: 0x00002FB8
		public unsafe GameID gameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargets.NativeFieldInfoPtr_gameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargets.NativeFieldInfoPtr_gameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00012958 File Offset: 0x00010B58
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00004DD7 File Offset: 0x00002FD7
		public unsafe EntityIDTargetResponses selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargets.NativeFieldInfoPtr_selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityIDTargetResponses>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargets.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00012988 File Offset: 0x00010B88
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x00004DF6 File Offset: 0x00002FF6
		public unsafe int counter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargets.NativeFieldInfoPtr_counter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargets.NativeFieldInfoPtr_counter)) = value;
			}
		}

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeFieldInfoPtr_gameID;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeFieldInfoPtr_selection;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeFieldInfoPtr_counter;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SelectionMessage_EntityID_IEnumerable_1_TargetResponse_0;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeMethodInfoPtr_GetCounter_Public_Virtual_Final_New_Int32_0;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
