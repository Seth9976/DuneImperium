using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace JsonFx.IO
{
	// Token: 0x0200002E RID: 46
	public sealed class ListStream<T> : Stream<T>
	{
		// Token: 0x06000257 RID: 599 RVA: 0x0000C1A4 File Offset: 0x0000A3A4
		// Note: this type is marked as 'beforefieldinit'.
		static ListStream()
		{
			Il2CppClassPointerStore<ListStream<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.IO", "ListStream`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListStream<T>>.NativeClassPtr);
			ListStream<T>.NativeFieldInfoPtr_isCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListStream<T>>.NativeClassPtr, "isCompleted");
			ListStream<T>.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListStream<T>>.NativeClassPtr, "current");
			ListStream<T>.NativeFieldInfoPtr_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListStream<T>>.NativeClassPtr, "Buffer");
			ListStream<T>.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListStream<T>>.NativeClassPtr, "index");
			ListStream<T>.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListStream<T>>.NativeClassPtr, "start");
			ListStream<T>.NativeMethodInfoPtr__ctor_Public_Void_IList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListStream<T>>.NativeClassPtr, 100663644);
			ListStream<T>.NativeMethodInfoPtr_get_ChunkSize_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListStream<T>>.NativeClassPtr, 100663645);
			ListStream<T>.NativeMethodInfoPtr_get_IsChunking_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListStream<T>>.NativeClassPtr, 100663646);
			ListStream<T>.NativeMethodInfoPtr_BeginChunk_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListStream<T>>.NativeClassPtr, 100663647);
			ListStream<T>.NativeMethodInfoPtr_EndChunk_Public_Virtual_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListStream<T>>.NativeClassPtr, 100663648);
			ListStream<T>.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListStream<T>>.NativeClassPtr, 100663649);
			ListStream<T>.NativeMethodInfoPtr_Peek_Public_Virtual_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListStream<T>>.NativeClassPtr, 100663650);
			ListStream<T>.NativeMethodInfoPtr_Pop_Public_Virtual_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListStream<T>>.NativeClassPtr, 100663651);
			ListStream<T>.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListStream<T>>.NativeClassPtr, 100663652);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000C328 File Offset: 0x0000A528
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1193029, RefRangeEnd = 1193031, XrefRangeStart = 1193023, XrefRangeEnd = 1193029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListStream(IList<T> value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListStream<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListStream<T>.NativeMethodInfoPtr__ctor_Public_Void_IList_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000259 RID: 601 RVA: 0x0000C374 File Offset: 0x0000A574
		public unsafe override int ChunkSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListStream<T>.NativeMethodInfoPtr_get_ChunkSize_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600025A RID: 602 RVA: 0x0000C3B0 File Offset: 0x0000A5B0
		public unsafe override bool IsChunking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListStream<T>.NativeMethodInfoPtr_get_IsChunking_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000C3EC File Offset: 0x0000A5EC
		[CallerCount(0)]
		public unsafe override void BeginChunk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListStream<T>.NativeMethodInfoPtr_BeginChunk_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000C420 File Offset: 0x0000A620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193031, XrefRangeEnd = 1193034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<T> EndChunk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListStream<T>.NativeMethodInfoPtr_EndChunk_Public_Virtual_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600025D RID: 605 RVA: 0x0000C460 File Offset: 0x0000A660
		public unsafe override bool IsCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListStream<T>.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000C49C File Offset: 0x0000A69C
		[CallerCount(0)]
		public unsafe override T Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListStream<T>.NativeMethodInfoPtr_Peek_Public_Virtual_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000C4D8 File Offset: 0x0000A6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193034, XrefRangeEnd = 1193037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override T Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListStream<T>.NativeMethodInfoPtr_Pop_Public_Virtual_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000C514 File Offset: 0x0000A714
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListStream<T>.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002EB6 File Offset: 0x000010B6
		public ListStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0000C554 File Offset: 0x0000A754
		// (set) Token: 0x06000263 RID: 611 RVA: 0x00002EBF File Offset: 0x000010BF
		public unsafe bool isCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListStream<T>.NativeFieldInfoPtr_isCompleted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListStream<T>.NativeFieldInfoPtr_isCompleted)) = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0000C57C File Offset: 0x0000A77C
		// (set) Token: 0x06000265 RID: 613 RVA: 0x0000C5A4 File Offset: 0x0000A7A4
		public unsafe T current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListStream<T>.NativeFieldInfoPtr_current);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListStream<T>.NativeFieldInfoPtr_current);
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

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0000C64C File Offset: 0x0000A84C
		// (set) Token: 0x06000267 RID: 615 RVA: 0x00002EDA File Offset: 0x000010DA
		public unsafe IList<T> Buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListStream<T>.NativeFieldInfoPtr_Buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListStream<T>.NativeFieldInfoPtr_Buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0000C67C File Offset: 0x0000A87C
		// (set) Token: 0x06000269 RID: 617 RVA: 0x00002EF9 File Offset: 0x000010F9
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListStream<T>.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListStream<T>.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0000C6A4 File Offset: 0x0000A8A4
		// (set) Token: 0x0600026B RID: 619 RVA: 0x00002F14 File Offset: 0x00001114
		public unsafe int start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListStream<T>.NativeFieldInfoPtr_start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListStream<T>.NativeFieldInfoPtr_start)) = value;
			}
		}

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeFieldInfoPtr_isCompleted;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeFieldInfoPtr_Buffer;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeFieldInfoPtr_start;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IList_1_T_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_get_ChunkSize_Public_Virtual_get_Int32_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_get_IsChunking_Public_Virtual_get_Boolean_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_BeginChunk_Public_Virtual_Void_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_EndChunk_Public_Virtual_IEnumerable_1_T_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_get_Boolean_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_T_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_Virtual_T_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;
	}
}
