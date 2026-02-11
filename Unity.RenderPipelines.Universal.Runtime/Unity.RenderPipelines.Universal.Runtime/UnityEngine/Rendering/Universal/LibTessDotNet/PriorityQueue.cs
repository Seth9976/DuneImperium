using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal.LibTessDotNet
{
	// Token: 0x0200010F RID: 271
	public class PriorityQueue<TValue> : Object where TValue : class
	{
		// Token: 0x06001692 RID: 5778 RVA: 0x00060BE4 File Offset: 0x0005EDE4
		// Note: this type is marked as 'beforefieldinit'.
		static PriorityQueue()
		{
			Il2CppClassPointerStore<PriorityQueue<TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.LibTessDotNet", "PriorityQueue`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PriorityQueue<TValue>>.NativeClassPtr);
			PriorityQueue<TValue>.NativeFieldInfoPtr__leq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityQueue<TValue>>.NativeClassPtr, "_leq");
			PriorityQueue<TValue>.NativeFieldInfoPtr__heap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityQueue<TValue>>.NativeClassPtr, "_heap");
			PriorityQueue<TValue>.NativeFieldInfoPtr__keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityQueue<TValue>>.NativeClassPtr, "_keys");
			PriorityQueue<TValue>.NativeFieldInfoPtr__order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityQueue<TValue>>.NativeClassPtr, "_order");
			PriorityQueue<TValue>.NativeFieldInfoPtr__size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityQueue<TValue>>.NativeClassPtr, "_size");
			PriorityQueue<TValue>.NativeFieldInfoPtr__max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityQueue<TValue>>.NativeClassPtr, "_max");
			PriorityQueue<TValue>.NativeFieldInfoPtr__initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityQueue<TValue>>.NativeClassPtr, "_initialized");
			PriorityQueue<TValue>.NativeMethodInfoPtr_get_Empty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue<TValue>>.NativeClassPtr, 100665954);
			PriorityQueue<TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_LessOrEqual_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue<TValue>>.NativeClassPtr, 100665955);
			PriorityQueue<TValue>.NativeMethodInfoPtr_Swap_Private_Static_Void_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue<TValue>>.NativeClassPtr, 100665956);
			PriorityQueue<TValue>.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue<TValue>>.NativeClassPtr, 100665957);
			PriorityQueue<TValue>.NativeMethodInfoPtr_Insert_Public_PQHandle_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue<TValue>>.NativeClassPtr, 100665958);
			PriorityQueue<TValue>.NativeMethodInfoPtr_ExtractMin_Public_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue<TValue>>.NativeClassPtr, 100665959);
			PriorityQueue<TValue>.NativeMethodInfoPtr_Minimum_Public_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue<TValue>>.NativeClassPtr, 100665960);
			PriorityQueue<TValue>.NativeMethodInfoPtr_Remove_Public_Void_PQHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue<TValue>>.NativeClassPtr, 100665961);
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06001693 RID: 5779 RVA: 0x00060D7C File Offset: 0x0005EF7C
		public unsafe bool Empty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityQueue<TValue>.NativeMethodInfoPtr_get_Empty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x00060DB8 File Offset: 0x0005EFB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 623614, RefRangeEnd = 623615, XrefRangeStart = 623605, XrefRangeEnd = 623614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PriorityQueue(int initialSize, PriorityHeap<TValue>.LessOrEqual leq)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PriorityQueue<TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(leq);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityQueue<TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_LessOrEqual_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x00060E14 File Offset: 0x0005F014
		[CallerCount(0)]
		public unsafe static void Swap(ref int a, ref int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityQueue<TValue>.NativeMethodInfoPtr_Swap_Private_Static_Void_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x00060E54 File Offset: 0x0005F054
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 623638, RefRangeEnd = 623639, XrefRangeStart = 623615, XrefRangeEnd = 623638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityQueue<TValue>.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x00060E88 File Offset: 0x0005F088
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 623641, RefRangeEnd = 623642, XrefRangeStart = 623639, XrefRangeEnd = 623641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PQHandle Insert(TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TValue).IsValueType)
				{
					TValue tvalue = value;
					intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PriorityQueue<TValue>.NativeMethodInfoPtr_Insert_Public_PQHandle_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x00060F0C File Offset: 0x0005F10C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 623643, RefRangeEnd = 623645, XrefRangeStart = 623642, XrefRangeEnd = 623643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TValue ExtractMin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityQueue<TValue>.NativeMethodInfoPtr_ExtractMin_Public_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x00060F48 File Offset: 0x0005F148
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 623645, RefRangeEnd = 623646, XrefRangeStart = 623645, XrefRangeEnd = 623645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TValue Minimum()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityQueue<TValue>.NativeMethodInfoPtr_Minimum_Public_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x00060F84 File Offset: 0x0005F184
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 623647, RefRangeEnd = 623648, XrefRangeStart = 623646, XrefRangeEnd = 623647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(PQHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityQueue<TValue>.NativeMethodInfoPtr_Remove_Public_Void_PQHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x0000D060 File Offset: 0x0000B260
		public PriorityQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x0600169C RID: 5788 RVA: 0x00060FC4 File Offset: 0x0005F1C4
		// (set) Token: 0x0600169D RID: 5789 RVA: 0x0000D069 File Offset: 0x0000B269
		public unsafe PriorityHeap<TValue>.LessOrEqual _leq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue<TValue>.NativeFieldInfoPtr__leq);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PriorityHeap<TValue>.LessOrEqual>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue<TValue>.NativeFieldInfoPtr__leq), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x0600169E RID: 5790 RVA: 0x00060FF4 File Offset: 0x0005F1F4
		// (set) Token: 0x0600169F RID: 5791 RVA: 0x0000D088 File Offset: 0x0000B288
		public unsafe PriorityHeap<TValue> _heap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue<TValue>.NativeFieldInfoPtr__heap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PriorityHeap<TValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue<TValue>.NativeFieldInfoPtr__heap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x060016A0 RID: 5792 RVA: 0x00061024 File Offset: 0x0005F224
		// (set) Token: 0x060016A1 RID: 5793 RVA: 0x0000D0A7 File Offset: 0x0000B2A7
		public unsafe Il2CppArrayBase<TValue> _keys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue<TValue>.NativeFieldInfoPtr__keys);
				return Il2CppArrayBase<TValue>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue<TValue>.NativeFieldInfoPtr__keys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x060016A2 RID: 5794 RVA: 0x0006104C File Offset: 0x0005F24C
		// (set) Token: 0x060016A3 RID: 5795 RVA: 0x0000D0C6 File Offset: 0x0000B2C6
		public unsafe Il2CppStructArray<int> _order
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue<TValue>.NativeFieldInfoPtr__order);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue<TValue>.NativeFieldInfoPtr__order), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x060016A4 RID: 5796 RVA: 0x0006107C File Offset: 0x0005F27C
		// (set) Token: 0x060016A5 RID: 5797 RVA: 0x0000D0E5 File Offset: 0x0000B2E5
		public unsafe int _size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue<TValue>.NativeFieldInfoPtr__size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue<TValue>.NativeFieldInfoPtr__size)) = value;
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x060016A6 RID: 5798 RVA: 0x000610A4 File Offset: 0x0005F2A4
		// (set) Token: 0x060016A7 RID: 5799 RVA: 0x0000D100 File Offset: 0x0000B300
		public unsafe int _max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue<TValue>.NativeFieldInfoPtr__max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue<TValue>.NativeFieldInfoPtr__max)) = value;
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x060016A8 RID: 5800 RVA: 0x000610CC File Offset: 0x0005F2CC
		// (set) Token: 0x060016A9 RID: 5801 RVA: 0x0000D11B File Offset: 0x0000B31B
		public unsafe bool _initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue<TValue>.NativeFieldInfoPtr__initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue<TValue>.NativeFieldInfoPtr__initialized)) = value;
			}
		}

		// Token: 0x0400106A RID: 4202
		private static readonly IntPtr NativeFieldInfoPtr__leq;

		// Token: 0x0400106B RID: 4203
		private static readonly IntPtr NativeFieldInfoPtr__heap;

		// Token: 0x0400106C RID: 4204
		private static readonly IntPtr NativeFieldInfoPtr__keys;

		// Token: 0x0400106D RID: 4205
		private static readonly IntPtr NativeFieldInfoPtr__order;

		// Token: 0x0400106E RID: 4206
		private static readonly IntPtr NativeFieldInfoPtr__size;

		// Token: 0x0400106F RID: 4207
		private static readonly IntPtr NativeFieldInfoPtr__max;

		// Token: 0x04001070 RID: 4208
		private static readonly IntPtr NativeFieldInfoPtr__initialized;

		// Token: 0x04001071 RID: 4209
		private static readonly IntPtr NativeMethodInfoPtr_get_Empty_Public_get_Boolean_0;

		// Token: 0x04001072 RID: 4210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_LessOrEqual_TValue_0;

		// Token: 0x04001073 RID: 4211
		private static readonly IntPtr NativeMethodInfoPtr_Swap_Private_Static_Void_byref_Int32_byref_Int32_0;

		// Token: 0x04001074 RID: 4212
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

		// Token: 0x04001075 RID: 4213
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_PQHandle_TValue_0;

		// Token: 0x04001076 RID: 4214
		private static readonly IntPtr NativeMethodInfoPtr_ExtractMin_Public_TValue_0;

		// Token: 0x04001077 RID: 4215
		private static readonly IntPtr NativeMethodInfoPtr_Minimum_Public_TValue_0;

		// Token: 0x04001078 RID: 4216
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_PQHandle_0;

		// Token: 0x020001E0 RID: 480
		public class StackItem : Object
		{
			// Token: 0x06002174 RID: 8564 RVA: 0x000819DC File Offset: 0x0007FBDC
			// Note: this type is marked as 'beforefieldinit'.
			static StackItem()
			{
				Il2CppClassPointerStore<PriorityQueue<TValue>.StackItem>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PriorityQueue<TValue>>.NativeClassPtr, "StackItem"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PriorityQueue<TValue>.StackItem>.NativeClassPtr);
				PriorityQueue<TValue>.StackItem.NativeFieldInfoPtr_p = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityQueue<TValue>.StackItem>.NativeClassPtr, "p");
				PriorityQueue<TValue>.StackItem.NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PriorityQueue<TValue>.StackItem>.NativeClassPtr, "r");
				PriorityQueue<TValue>.StackItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PriorityQueue<TValue>.StackItem>.NativeClassPtr, 100665962);
			}

			// Token: 0x06002175 RID: 8565 RVA: 0x00081A80 File Offset: 0x0007FC80
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StackItem()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PriorityQueue<TValue>.StackItem>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PriorityQueue<TValue>.StackItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002176 RID: 8566 RVA: 0x0001326B File Offset: 0x0001146B
			public StackItem(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C07 RID: 3079
			// (get) Token: 0x06002177 RID: 8567 RVA: 0x00081ABC File Offset: 0x0007FCBC
			// (set) Token: 0x06002178 RID: 8568 RVA: 0x00013274 File Offset: 0x00011474
			public unsafe int p
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue<TValue>.StackItem.NativeFieldInfoPtr_p);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue<TValue>.StackItem.NativeFieldInfoPtr_p)) = value;
				}
			}

			// Token: 0x17000C08 RID: 3080
			// (get) Token: 0x06002179 RID: 8569 RVA: 0x00081AE4 File Offset: 0x0007FCE4
			// (set) Token: 0x0600217A RID: 8570 RVA: 0x0001328F File Offset: 0x0001148F
			public unsafe int r
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue<TValue>.StackItem.NativeFieldInfoPtr_r);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PriorityQueue<TValue>.StackItem.NativeFieldInfoPtr_r)) = value;
				}
			}

			// Token: 0x040017B5 RID: 6069
			private static readonly IntPtr NativeFieldInfoPtr_p;

			// Token: 0x040017B6 RID: 6070
			private static readonly IntPtr NativeFieldInfoPtr_r;

			// Token: 0x040017B7 RID: 6071
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
