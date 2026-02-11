using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Networking.selection.messages.outgoing
{
	// Token: 0x02000088 RID: 136
	public class MultipleSelectionWithTargets : Object
	{
		// Token: 0x0600048F RID: 1167 RVA: 0x0001216C File Offset: 0x0001036C
		// Note: this type is marked as 'beforefieldinit'.
		static MultipleSelectionWithTargets()
		{
			Il2CppClassPointerStore<MultipleSelectionWithTargets>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.messages.outgoing", "MultipleSelectionWithTargets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleSelectionWithTargets>.NativeClassPtr);
			MultipleSelectionWithTargets.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSelectionWithTargets>.NativeClassPtr, "gameID");
			MultipleSelectionWithTargets.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSelectionWithTargets>.NativeClassPtr, "selection");
			MultipleSelectionWithTargets.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSelectionWithTargets>.NativeClassPtr, "counter");
			MultipleSelectionWithTargets.NativeMethodInfoPtr_GetCounter_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargets>.NativeClassPtr, 100663593);
			MultipleSelectionWithTargets.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargets>.NativeClassPtr, 100663594);
			MultipleSelectionWithTargets.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleSelectionWithTargets>.NativeClassPtr, 100663595);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00012214 File Offset: 0x00010414
		[CallerCount(0)]
		public unsafe virtual int GetCounter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargets.NativeMethodInfoPtr_GetCounter_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00012250 File Offset: 0x00010450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194697, XrefRangeEnd = 1194703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleSelectionWithTargets.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00012294 File Offset: 0x00010494
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultipleSelectionWithTargets()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleSelectionWithTargets>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleSelectionWithTargets.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00004D1C File Offset: 0x00002F1C
		public MultipleSelectionWithTargets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x000122D0 File Offset: 0x000104D0
		// (set) Token: 0x06000495 RID: 1173 RVA: 0x00004D25 File Offset: 0x00002F25
		public unsafe GameID gameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargets.NativeFieldInfoPtr_gameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargets.NativeFieldInfoPtr_gameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x00012300 File Offset: 0x00010500
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x00004D44 File Offset: 0x00002F44
		public unsafe List<EntityIDEntityTargetsResponse> selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargets.NativeFieldInfoPtr_selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityIDEntityTargetsResponse>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargets.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x00012330 File Offset: 0x00010530
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x00004D63 File Offset: 0x00002F63
		public unsafe int counter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargets.NativeFieldInfoPtr_counter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSelectionWithTargets.NativeFieldInfoPtr_counter)) = value;
			}
		}

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeFieldInfoPtr_gameID;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeFieldInfoPtr_selection;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeFieldInfoPtr_counter;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeMethodInfoPtr_GetCounter_Public_Virtual_Final_New_Int32_0;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
