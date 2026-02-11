using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x0200016C RID: 364
	public sealed class LinkedListNode<T> : Object
	{
		// Token: 0x0600160A RID: 5642 RVA: 0x00071F8C File Offset: 0x0007018C
		// Note: this type is marked as 'beforefieldinit'.
		static LinkedListNode()
		{
			Il2CppClassPointerStore<LinkedListNode<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Generic", "LinkedListNode`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinkedListNode<T>>.NativeClassPtr);
			LinkedListNode<T>.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedListNode<T>>.NativeClassPtr, "list");
			LinkedListNode<T>.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedListNode<T>>.NativeClassPtr, "next");
			LinkedListNode<T>.NativeFieldInfoPtr_prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedListNode<T>>.NativeClassPtr, "prev");
			LinkedListNode<T>.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedListNode<T>>.NativeClassPtr, "item");
			LinkedListNode<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedListNode<T>>.NativeClassPtr, 100666654);
			LinkedListNode<T>.NativeMethodInfoPtr__ctor_Internal_Void_LinkedList_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedListNode<T>>.NativeClassPtr, 100666655);
			LinkedListNode<T>.NativeMethodInfoPtr_get_List_Public_get_LinkedList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedListNode<T>>.NativeClassPtr, 100666656);
			LinkedListNode<T>.NativeMethodInfoPtr_get_Next_Public_get_LinkedListNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedListNode<T>>.NativeClassPtr, 100666657);
			LinkedListNode<T>.NativeMethodInfoPtr_get_Previous_Public_get_LinkedListNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedListNode<T>>.NativeClassPtr, 100666658);
			LinkedListNode<T>.NativeMethodInfoPtr_get_Value_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedListNode<T>>.NativeClassPtr, 100666659);
			LinkedListNode<T>.NativeMethodInfoPtr_set_Value_Public_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedListNode<T>>.NativeClassPtr, 100666660);
			LinkedListNode<T>.NativeMethodInfoPtr_Invalidate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedListNode<T>>.NativeClassPtr, 100666661);
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x000720E8 File Offset: 0x000702E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467881, XrefRangeEnd = 467892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LinkedListNode(T value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinkedListNode<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LinkedListNode<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x0007216C File Offset: 0x0007036C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467892, XrefRangeEnd = 467896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LinkedListNode(LinkedList<T> list, T value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinkedListNode<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LinkedListNode<T>.NativeMethodInfoPtr__ctor_Internal_Void_LinkedList_1_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x0600160D RID: 5645 RVA: 0x00072200 File Offset: 0x00070400
		public unsafe LinkedList<T> List
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedListNode<T>.NativeMethodInfoPtr_get_List_Public_get_LinkedList_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LinkedList<T>>(intPtr3) : null;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x0600160E RID: 5646 RVA: 0x00072240 File Offset: 0x00070440
		public unsafe LinkedListNode<T> Next
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 467896, RefRangeEnd = 467912, XrefRangeStart = 467896, XrefRangeEnd = 467896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedListNode<T>.NativeMethodInfoPtr_get_Next_Public_get_LinkedListNode_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LinkedListNode<T>>(intPtr3) : null;
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x0600160F RID: 5647 RVA: 0x00072280 File Offset: 0x00070480
		public unsafe LinkedListNode<T> Previous
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 467912, RefRangeEnd = 467915, XrefRangeStart = 467912, XrefRangeEnd = 467912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedListNode<T>.NativeMethodInfoPtr_get_Previous_Public_get_LinkedListNode_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LinkedListNode<T>>(intPtr3) : null;
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001610 RID: 5648 RVA: 0x000722C0 File Offset: 0x000704C0
		// (set) Token: 0x06001611 RID: 5649 RVA: 0x000722FC File Offset: 0x000704FC
		public unsafe T Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedListNode<T>.NativeMethodInfoPtr_get_Value_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467915, XrefRangeEnd = 467917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LinkedListNode<T>.NativeMethodInfoPtr_set_Value_Public_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x00072374 File Offset: 0x00070574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467917, XrefRangeEnd = 467932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invalidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedListNode<T>.NativeMethodInfoPtr_Invalidate_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x00009A21 File Offset: 0x00007C21
		public LinkedListNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001614 RID: 5652 RVA: 0x000723A8 File Offset: 0x000705A8
		// (set) Token: 0x06001615 RID: 5653 RVA: 0x00009A2A File Offset: 0x00007C2A
		public unsafe LinkedList<T> list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedListNode<T>.NativeFieldInfoPtr_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedListNode<T>.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001616 RID: 5654 RVA: 0x000723D8 File Offset: 0x000705D8
		// (set) Token: 0x06001617 RID: 5655 RVA: 0x00009A49 File Offset: 0x00007C49
		public unsafe LinkedListNode<T> next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedListNode<T>.NativeFieldInfoPtr_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedListNode<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedListNode<T>.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001618 RID: 5656 RVA: 0x00072408 File Offset: 0x00070608
		// (set) Token: 0x06001619 RID: 5657 RVA: 0x00009A68 File Offset: 0x00007C68
		public unsafe LinkedListNode<T> prev
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedListNode<T>.NativeFieldInfoPtr_prev);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedListNode<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedListNode<T>.NativeFieldInfoPtr_prev), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x0600161A RID: 5658 RVA: 0x00072438 File Offset: 0x00070638
		// (set) Token: 0x0600161B RID: 5659 RVA: 0x00072460 File Offset: 0x00070660
		public unsafe T item
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedListNode<T>.NativeFieldInfoPtr_item);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedListNode<T>.NativeFieldInfoPtr_item);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x04001139 RID: 4409
		private static readonly IntPtr NativeFieldInfoPtr_list;

		// Token: 0x0400113A RID: 4410
		private static readonly IntPtr NativeFieldInfoPtr_next;

		// Token: 0x0400113B RID: 4411
		private static readonly IntPtr NativeFieldInfoPtr_prev;

		// Token: 0x0400113C RID: 4412
		private static readonly IntPtr NativeFieldInfoPtr_item;

		// Token: 0x0400113D RID: 4413
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_0;

		// Token: 0x0400113E RID: 4414
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_LinkedList_1_T_T_0;

		// Token: 0x0400113F RID: 4415
		private static readonly IntPtr NativeMethodInfoPtr_get_List_Public_get_LinkedList_1_T_0;

		// Token: 0x04001140 RID: 4416
		private static readonly IntPtr NativeMethodInfoPtr_get_Next_Public_get_LinkedListNode_1_T_0;

		// Token: 0x04001141 RID: 4417
		private static readonly IntPtr NativeMethodInfoPtr_get_Previous_Public_get_LinkedListNode_1_T_0;

		// Token: 0x04001142 RID: 4418
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_T_0;

		// Token: 0x04001143 RID: 4419
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_T_0;

		// Token: 0x04001144 RID: 4420
		private static readonly IntPtr NativeMethodInfoPtr_Invalidate_Internal_Void_0;
	}
}
