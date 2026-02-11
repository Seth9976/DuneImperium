using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020000D8 RID: 216
	public class EventCallbackList : Object
	{
		// Token: 0x060012AC RID: 4780 RVA: 0x0005EBBC File Offset: 0x0005CDBC
		// Note: this type is marked as 'beforefieldinit'.
		static EventCallbackList()
		{
			Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventCallbackList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr);
			EventCallbackList.NativeFieldInfoPtr_m_List = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, "m_List");
			EventCallbackList.NativeFieldInfoPtr__trickleDownCallbackCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, "<trickleDownCallbackCount>k__BackingField");
			EventCallbackList.NativeFieldInfoPtr__bubbleUpCallbackCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, "<bubbleUpCallbackCount>k__BackingField");
			EventCallbackList.NativeMethodInfoPtr_get_trickleDownCallbackCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100665949);
			EventCallbackList.NativeMethodInfoPtr_set_trickleDownCallbackCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100665950);
			EventCallbackList.NativeMethodInfoPtr_get_bubbleUpCallbackCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100665951);
			EventCallbackList.NativeMethodInfoPtr_set_bubbleUpCallbackCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100665952);
			EventCallbackList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100665953);
			EventCallbackList.NativeMethodInfoPtr__ctor_Public_Void_EventCallbackList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100665954);
			EventCallbackList.NativeMethodInfoPtr_Contains_Public_Boolean_Int64_Delegate_CallbackPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100665955);
			EventCallbackList.NativeMethodInfoPtr_Find_Public_EventCallbackFunctorBase_Int64_Delegate_CallbackPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100665956);
			EventCallbackList.NativeMethodInfoPtr_Remove_Public_Boolean_Int64_Delegate_CallbackPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100665957);
			EventCallbackList.NativeMethodInfoPtr_Add_Public_Void_EventCallbackFunctorBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100665958);
			EventCallbackList.NativeMethodInfoPtr_AddRange_Public_Void_EventCallbackList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100665959);
			EventCallbackList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100665960);
			EventCallbackList.NativeMethodInfoPtr_get_Item_Public_get_EventCallbackFunctorBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100665961);
			EventCallbackList.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr, 100665962);
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x0005ED40 File Offset: 0x0005CF40
		// (set) Token: 0x060012AE RID: 4782 RVA: 0x0005ED7C File Offset: 0x0005CF7C
		public unsafe int trickleDownCallbackCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr_get_trickleDownCallbackCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr_set_trickleDownCallbackCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x060012AF RID: 4783 RVA: 0x0005EDBC File Offset: 0x0005CFBC
		// (set) Token: 0x060012B0 RID: 4784 RVA: 0x0005EDF8 File Offset: 0x0005CFF8
		public unsafe int bubbleUpCallbackCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr_get_bubbleUpCallbackCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr_set_bubbleUpCallbackCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x0005EE38 File Offset: 0x0005D038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313279, XrefRangeEnd = 313287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCallbackList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x0005EE74 File Offset: 0x0005D074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313287, XrefRangeEnd = 313295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCallbackList(EventCallbackList source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventCallbackList>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr__ctor_Public_Void_EventCallbackList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x0005EEC0 File Offset: 0x0005D0C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313302, RefRangeEnd = 313303, XrefRangeStart = 313295, XrefRangeEnd = 313302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(long eventTypeId, Delegate callback, CallbackPhase phase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventTypeId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr_Contains_Public_Boolean_Int64_Delegate_CallbackPhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x0005EF2C File Offset: 0x0005D12C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313310, RefRangeEnd = 313311, XrefRangeStart = 313303, XrefRangeEnd = 313310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCallbackFunctorBase Find(long eventTypeId, Delegate callback, CallbackPhase phase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventTypeId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr_Find_Public_EventCallbackFunctorBase_Int64_Delegate_CallbackPhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventCallbackFunctorBase>(intPtr3) : null;
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x0005EF98 File Offset: 0x0005D198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313311, XrefRangeEnd = 313320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Remove(long eventTypeId, Delegate callback, CallbackPhase phase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventTypeId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr_Remove_Public_Boolean_Int64_Delegate_CallbackPhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x0005F004 File Offset: 0x0005D204
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313325, RefRangeEnd = 313326, XrefRangeStart = 313320, XrefRangeEnd = 313325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(EventCallbackFunctorBase item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr_Add_Public_Void_EventCallbackFunctorBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x0005F048 File Offset: 0x0005D248
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 313344, RefRangeEnd = 313346, XrefRangeStart = 313326, XrefRangeEnd = 313344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRange(EventCallbackList list)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr_AddRange_Public_Void_EventCallbackList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x060012B8 RID: 4792 RVA: 0x0005F08C File Offset: 0x0005D28C
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313346, XrefRangeEnd = 313347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005CB RID: 1483
		public unsafe EventCallbackFunctorBase this[int i]
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 313351, RefRangeEnd = 313353, XrefRangeStart = 313347, XrefRangeEnd = 313351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr_get_Item_Public_get_EventCallbackFunctorBase_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventCallbackFunctorBase>(intPtr3) : null;
				}
			}
			set
			{
				this.m_List[i] = value;
			}
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x0005F114 File Offset: 0x0005D314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313353, XrefRangeEnd = 313355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackList.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x0000935D File Offset: 0x0000755D
		public EventCallbackList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x0005F148 File Offset: 0x0005D348
		// (set) Token: 0x060012BD RID: 4797 RVA: 0x00009366 File Offset: 0x00007566
		public unsafe List<EventCallbackFunctorBase> m_List
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackList.NativeFieldInfoPtr_m_List);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EventCallbackFunctorBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackList.NativeFieldInfoPtr_m_List), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x060012BE RID: 4798 RVA: 0x0005F178 File Offset: 0x0005D378
		// (set) Token: 0x060012BF RID: 4799 RVA: 0x00009385 File Offset: 0x00007585
		public unsafe int _trickleDownCallbackCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackList.NativeFieldInfoPtr__trickleDownCallbackCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackList.NativeFieldInfoPtr__trickleDownCallbackCount_k__BackingField)) = value;
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x060012C0 RID: 4800 RVA: 0x0005F1A0 File Offset: 0x0005D3A0
		// (set) Token: 0x060012C1 RID: 4801 RVA: 0x000093A0 File Offset: 0x000075A0
		public unsafe int _bubbleUpCallbackCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackList.NativeFieldInfoPtr__bubbleUpCallbackCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackList.NativeFieldInfoPtr__bubbleUpCallbackCount_k__BackingField)) = value;
			}
		}

		// Token: 0x04000CD1 RID: 3281
		private static readonly IntPtr NativeFieldInfoPtr_m_List;

		// Token: 0x04000CD2 RID: 3282
		private static readonly IntPtr NativeFieldInfoPtr__trickleDownCallbackCount_k__BackingField;

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeFieldInfoPtr__bubbleUpCallbackCount_k__BackingField;

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeMethodInfoPtr_get_trickleDownCallbackCount_Public_get_Int32_0;

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeMethodInfoPtr_set_trickleDownCallbackCount_Private_set_Void_Int32_0;

		// Token: 0x04000CD6 RID: 3286
		private static readonly IntPtr NativeMethodInfoPtr_get_bubbleUpCallbackCount_Public_get_Int32_0;

		// Token: 0x04000CD7 RID: 3287
		private static readonly IntPtr NativeMethodInfoPtr_set_bubbleUpCallbackCount_Private_set_Void_Int32_0;

		// Token: 0x04000CD8 RID: 3288
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000CD9 RID: 3289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventCallbackList_0;

		// Token: 0x04000CDA RID: 3290
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Int64_Delegate_CallbackPhase_0;

		// Token: 0x04000CDB RID: 3291
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_EventCallbackFunctorBase_Int64_Delegate_CallbackPhase_0;

		// Token: 0x04000CDC RID: 3292
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_Int64_Delegate_CallbackPhase_0;

		// Token: 0x04000CDD RID: 3293
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_EventCallbackFunctorBase_0;

		// Token: 0x04000CDE RID: 3294
		private static readonly IntPtr NativeMethodInfoPtr_AddRange_Public_Void_EventCallbackList_0;

		// Token: 0x04000CDF RID: 3295
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04000CE0 RID: 3296
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_EventCallbackFunctorBase_Int32_0;

		// Token: 0x04000CE1 RID: 3297
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
	}
}
