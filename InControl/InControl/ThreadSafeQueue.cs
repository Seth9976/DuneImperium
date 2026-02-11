using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace InControl
{
	// Token: 0x0200006F RID: 111
	public class ThreadSafeQueue<T> : Object
	{
		// Token: 0x06000A37 RID: 2615 RVA: 0x0002C56C File Offset: 0x0002A76C
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadSafeQueue()
		{
			Il2CppClassPointerStore<ThreadSafeQueue<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "ThreadSafeQueue`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadSafeQueue<T>>.NativeClassPtr);
			ThreadSafeQueue<T>.NativeFieldInfoPtr_sync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeQueue<T>>.NativeClassPtr, "sync");
			ThreadSafeQueue<T>.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeQueue<T>>.NativeClassPtr, "data");
			ThreadSafeQueue<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeQueue<T>>.NativeClassPtr, 100664679);
			ThreadSafeQueue<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeQueue<T>>.NativeClassPtr, 100664680);
			ThreadSafeQueue<T>.NativeMethodInfoPtr_Enqueue_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeQueue<T>>.NativeClassPtr, 100664681);
			ThreadSafeQueue<T>.NativeMethodInfoPtr_Dequeue_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeQueue<T>>.NativeClassPtr, 100664682);
			ThreadSafeQueue<T>.NativeMethodInfoPtr_Dequeue_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeQueue<T>>.NativeClassPtr, 100664683);
			ThreadSafeQueue<T>.NativeMethodInfoPtr_Dequeue_Public_Int32_byref_IList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeQueue<T>>.NativeClassPtr, 100664684);
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x0002C678 File Offset: 0x0002A878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790694, XrefRangeEnd = 790709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadSafeQueue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadSafeQueue<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeQueue<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x0002C6B4 File Offset: 0x0002A8B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790709, XrefRangeEnd = 790718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadSafeQueue(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadSafeQueue<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeQueue<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0002C6FC File Offset: 0x0002A8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790718, XrefRangeEnd = 790724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enqueue(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ThreadSafeQueue<T>.NativeMethodInfoPtr_Enqueue_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x0002C774 File Offset: 0x0002A974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790724, XrefRangeEnd = 790732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Dequeue(out T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref item;
				}
				ptr2 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ThreadSafeQueue<T>.NativeMethodInfoPtr_Dequeue_Public_Boolean_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					item = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x0002C800 File Offset: 0x0002AA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790732, XrefRangeEnd = 790748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Dequeue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeQueue<T>.NativeMethodInfoPtr_Dequeue_Public_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x0002C83C File Offset: 0x0002AA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790748, XrefRangeEnd = 790756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Dequeue(ref IList<T> list)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(list);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ThreadSafeQueue<T>.NativeMethodInfoPtr_Dequeue_Public_Int32_byref_IList_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				list = ((intPtr4 == 0) ? null : new IList<T>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00005E27 File Offset: 0x00004027
		public ThreadSafeQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0002C8A0 File Offset: 0x0002AAA0
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x00005E30 File Offset: 0x00004030
		public unsafe Object sync
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeQueue<T>.NativeFieldInfoPtr_sync);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeQueue<T>.NativeFieldInfoPtr_sync), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x0002C8D0 File Offset: 0x0002AAD0
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x00005E4F File Offset: 0x0000404F
		public unsafe Queue<T> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeQueue<T>.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeQueue<T>.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000986 RID: 2438
		private static readonly IntPtr NativeFieldInfoPtr_sync;

		// Token: 0x04000987 RID: 2439
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Void_T_0;

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeMethodInfoPtr_Dequeue_Public_Boolean_byref_T_0;

		// Token: 0x0400098C RID: 2444
		private static readonly IntPtr NativeMethodInfoPtr_Dequeue_Public_T_0;

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeMethodInfoPtr_Dequeue_Public_Int32_byref_IList_1_T_0;
	}
}
