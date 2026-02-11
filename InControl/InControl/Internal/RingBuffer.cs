using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace InControl.Internal
{
	// Token: 0x02000076 RID: 118
	public class RingBuffer<T> : Object
	{
		// Token: 0x06000ADE RID: 2782 RVA: 0x0002F1B4 File Offset: 0x0002D3B4
		// Note: this type is marked as 'beforefieldinit'.
		static RingBuffer()
		{
			Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("InControl.dll", "InControl.Internal", "RingBuffer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr);
			RingBuffer<T>.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, "size");
			RingBuffer<T>.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, "data");
			RingBuffer<T>.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, "head");
			RingBuffer<T>.NativeFieldInfoPtr_tail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, "tail");
			RingBuffer<T>.NativeFieldInfoPtr_sync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, "sync");
			RingBuffer<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100664792);
			RingBuffer<T>.NativeMethodInfoPtr_Enqueue_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100664793);
			RingBuffer<T>.NativeMethodInfoPtr_Dequeue_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100664794);
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x0002F2C0 File Offset: 0x0002D4C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 792206, RefRangeEnd = 792207, XrefRangeStart = 792178, XrefRangeEnd = 792206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RingBuffer(int size)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0002F308 File Offset: 0x0002D508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 792211, RefRangeEnd = 792212, XrefRangeStart = 792207, XrefRangeEnd = 792211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enqueue(T value)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_Enqueue_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0002F380 File Offset: 0x0002D580
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 792216, RefRangeEnd = 792218, XrefRangeStart = 792212, XrefRangeEnd = 792216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Dequeue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_Dequeue_Public_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x000060BD File Offset: 0x000042BD
		public RingBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x0002F3BC File Offset: 0x0002D5BC
		// (set) Token: 0x06000AE4 RID: 2788 RVA: 0x000060C6 File Offset: 0x000042C6
		public unsafe int size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.NativeFieldInfoPtr_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.NativeFieldInfoPtr_size)) = value;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x0002F3E4 File Offset: 0x0002D5E4
		// (set) Token: 0x06000AE6 RID: 2790 RVA: 0x000060E1 File Offset: 0x000042E1
		public unsafe Il2CppArrayBase<T> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.NativeFieldInfoPtr_data);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x0002F40C File Offset: 0x0002D60C
		// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x00006100 File Offset: 0x00004300
		public unsafe int head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.NativeFieldInfoPtr_head);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.NativeFieldInfoPtr_head)) = value;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x0002F434 File Offset: 0x0002D634
		// (set) Token: 0x06000AEA RID: 2794 RVA: 0x0000611B File Offset: 0x0000431B
		public unsafe int tail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.NativeFieldInfoPtr_tail);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.NativeFieldInfoPtr_tail)) = value;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x0002F45C File Offset: 0x0002D65C
		// (set) Token: 0x06000AEC RID: 2796 RVA: 0x00006136 File Offset: 0x00004336
		public unsafe Object sync
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.NativeFieldInfoPtr_sync);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.NativeFieldInfoPtr_sync), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeFieldInfoPtr_head;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeFieldInfoPtr_tail;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeFieldInfoPtr_sync;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Void_T_0;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeMethodInfoPtr_Dequeue_Public_T_0;
	}
}
