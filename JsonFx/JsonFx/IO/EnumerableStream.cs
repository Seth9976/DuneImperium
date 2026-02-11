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
	// Token: 0x0200002D RID: 45
	public sealed class EnumerableStream<T> : Stream<T>
	{
		// Token: 0x06000244 RID: 580 RVA: 0x0000BCB0 File Offset: 0x00009EB0
		// Note: this type is marked as 'beforefieldinit'.
		static EnumerableStream()
		{
			Il2CppClassPointerStore<EnumerableStream<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.IO", "EnumerableStream`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumerableStream<T>>.NativeClassPtr);
			EnumerableStream<T>.NativeFieldInfoPtr_Enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerableStream<T>>.NativeClassPtr, "Enumerator");
			EnumerableStream<T>.NativeFieldInfoPtr_isCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerableStream<T>>.NativeClassPtr, "isCompleted");
			EnumerableStream<T>.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerableStream<T>>.NativeClassPtr, "current");
			EnumerableStream<T>.NativeFieldInfoPtr_chunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerableStream<T>>.NativeClassPtr, "chunk");
			EnumerableStream<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableStream<T>>.NativeClassPtr, 100663635);
			EnumerableStream<T>.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableStream<T>>.NativeClassPtr, 100663636);
			EnumerableStream<T>.NativeMethodInfoPtr_Peek_Public_Virtual_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableStream<T>>.NativeClassPtr, 100663637);
			EnumerableStream<T>.NativeMethodInfoPtr_Pop_Public_Virtual_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableStream<T>>.NativeClassPtr, 100663638);
			EnumerableStream<T>.NativeMethodInfoPtr_get_IsChunking_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableStream<T>>.NativeClassPtr, 100663639);
			EnumerableStream<T>.NativeMethodInfoPtr_get_ChunkSize_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableStream<T>>.NativeClassPtr, 100663640);
			EnumerableStream<T>.NativeMethodInfoPtr_BeginChunk_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableStream<T>>.NativeClassPtr, 100663641);
			EnumerableStream<T>.NativeMethodInfoPtr_EndChunk_Public_Virtual_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableStream<T>>.NativeClassPtr, 100663642);
			EnumerableStream<T>.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableStream<T>>.NativeClassPtr, 100663643);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000BE20 File Offset: 0x0000A020
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1193007, RefRangeEnd = 1193009, XrefRangeStart = 1192998, XrefRangeEnd = 1193007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnumerableStream(IEnumerable<T> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumerableStream<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableStream<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000246 RID: 582 RVA: 0x0000BE6C File Offset: 0x0000A06C
		public unsafe override bool IsCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableStream<T>.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000BEA8 File Offset: 0x0000A0A8
		[CallerCount(0)]
		public unsafe override T Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableStream<T>.NativeMethodInfoPtr_Peek_Public_Virtual_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000BEE4 File Offset: 0x0000A0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193009, XrefRangeEnd = 1193012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override T Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableStream<T>.NativeMethodInfoPtr_Pop_Public_Virtual_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000249 RID: 585 RVA: 0x0000BF20 File Offset: 0x0000A120
		public unsafe override bool IsChunking
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1193012, RefRangeEnd = 1193014, XrefRangeStart = 1193012, XrefRangeEnd = 1193012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableStream<T>.NativeMethodInfoPtr_get_IsChunking_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600024A RID: 586 RVA: 0x0000BF5C File Offset: 0x0000A15C
		public unsafe override int ChunkSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableStream<T>.NativeMethodInfoPtr_get_ChunkSize_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000BF98 File Offset: 0x0000A198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193014, XrefRangeEnd = 1193019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BeginChunk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableStream<T>.NativeMethodInfoPtr_BeginChunk_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000BFCC File Offset: 0x0000A1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193019, XrefRangeEnd = 1193020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<T> EndChunk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableStream<T>.NativeMethodInfoPtr_EndChunk_Public_Virtual_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0000C00C File Offset: 0x0000A20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193020, XrefRangeEnd = 1193023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableStream<T>.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002E54 File Offset: 0x00001054
		public EnumerableStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600024F RID: 591 RVA: 0x0000C04C File Offset: 0x0000A24C
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00002E5D File Offset: 0x0000105D
		public unsafe IEnumerator<T> Enumerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableStream<T>.NativeFieldInfoPtr_Enumerator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableStream<T>.NativeFieldInfoPtr_Enumerator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000251 RID: 593 RVA: 0x0000C07C File Offset: 0x0000A27C
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00002E7C File Offset: 0x0000107C
		public unsafe bool isCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableStream<T>.NativeFieldInfoPtr_isCompleted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableStream<T>.NativeFieldInfoPtr_isCompleted)) = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000253 RID: 595 RVA: 0x0000C0A4 File Offset: 0x0000A2A4
		// (set) Token: 0x06000254 RID: 596 RVA: 0x0000C0CC File Offset: 0x0000A2CC
		public unsafe T current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableStream<T>.NativeFieldInfoPtr_current);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableStream<T>.NativeFieldInfoPtr_current);
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

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000255 RID: 597 RVA: 0x0000C174 File Offset: 0x0000A374
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00002E97 File Offset: 0x00001097
		public unsafe List<T> chunk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableStream<T>.NativeFieldInfoPtr_chunk);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableStream<T>.NativeFieldInfoPtr_chunk), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeFieldInfoPtr_Enumerator;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeFieldInfoPtr_isCompleted;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeFieldInfoPtr_chunk;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_get_Boolean_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_T_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_Virtual_T_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_get_IsChunking_Public_Virtual_get_Boolean_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_get_ChunkSize_Public_Virtual_get_Int32_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_BeginChunk_Public_Virtual_Void_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_EndChunk_Public_Virtual_IEnumerable_1_T_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;
	}
}
