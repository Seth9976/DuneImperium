using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Diagnostics.Tracing;

namespace Il2CppSystem.Buffers
{
	// Token: 0x02000512 RID: 1298
	public sealed class ArrayPoolEventSource : EventSource
	{
		// Token: 0x06004F7C RID: 20348 RVA: 0x001721B0 File Offset: 0x001703B0
		// Note: this type is marked as 'beforefieldinit'.
		static ArrayPoolEventSource()
		{
			Il2CppClassPointerStore<ArrayPoolEventSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Buffers", "ArrayPoolEventSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayPoolEventSource>.NativeClassPtr);
			ArrayPoolEventSource.NativeFieldInfoPtr_Log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayPoolEventSource>.NativeClassPtr, "Log");
			ArrayPoolEventSource.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayPoolEventSource>.NativeClassPtr, 100675288);
			ArrayPoolEventSource.NativeMethodInfoPtr_BufferRented_Internal_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayPoolEventSource>.NativeClassPtr, 100675289);
			ArrayPoolEventSource.NativeMethodInfoPtr_BufferAllocated_Internal_Void_Int32_Int32_Int32_Int32_BufferAllocatedReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayPoolEventSource>.NativeClassPtr, 100675290);
			ArrayPoolEventSource.NativeMethodInfoPtr_BufferReturned_Internal_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayPoolEventSource>.NativeClassPtr, 100675291);
			ArrayPoolEventSource.NativeMethodInfoPtr_BufferTrimmed_Internal_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayPoolEventSource>.NativeClassPtr, 100675292);
			ArrayPoolEventSource.NativeMethodInfoPtr_BufferTrimPoll_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayPoolEventSource>.NativeClassPtr, 100675293);
		}

		// Token: 0x06004F7D RID: 20349 RVA: 0x0017226C File Offset: 0x0017046C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426499, XrefRangeEnd = 1426503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayPoolEventSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayPoolEventSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayPoolEventSource.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F7E RID: 20350 RVA: 0x001722A8 File Offset: 0x001704A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1426509, RefRangeEnd = 1426510, XrefRangeStart = 1426503, XrefRangeEnd = 1426509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BufferRented(int bufferId, int bufferSize, int poolId, int bucketId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bufferId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref poolId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bucketId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayPoolEventSource.NativeMethodInfoPtr_BufferRented_Internal_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F7F RID: 20351 RVA: 0x00172310 File Offset: 0x00170510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426510, XrefRangeEnd = 1426517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BufferAllocated(int bufferId, int bufferSize, int poolId, int bucketId, ArrayPoolEventSource.BufferAllocatedReason reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bufferId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref poolId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bucketId;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reason;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayPoolEventSource.NativeMethodInfoPtr_BufferAllocated_Internal_Void_Int32_Int32_Int32_Int32_BufferAllocatedReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F80 RID: 20352 RVA: 0x00172388 File Offset: 0x00170588
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1426518, RefRangeEnd = 1426519, XrefRangeStart = 1426517, XrefRangeEnd = 1426518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BufferReturned(int bufferId, int bufferSize, int poolId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bufferId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref poolId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayPoolEventSource.NativeMethodInfoPtr_BufferReturned_Internal_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F81 RID: 20353 RVA: 0x001723E4 File Offset: 0x001705E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1426520, RefRangeEnd = 1426522, XrefRangeStart = 1426519, XrefRangeEnd = 1426520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BufferTrimmed(int bufferId, int bufferSize, int poolId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bufferId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref poolId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayPoolEventSource.NativeMethodInfoPtr_BufferTrimmed_Internal_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F82 RID: 20354 RVA: 0x00172440 File Offset: 0x00170640
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1426523, RefRangeEnd = 1426524, XrefRangeStart = 1426522, XrefRangeEnd = 1426523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BufferTrimPoll(int milliseconds, int pressure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref milliseconds;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pressure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayPoolEventSource.NativeMethodInfoPtr_BufferTrimPoll_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F83 RID: 20355 RVA: 0x0001C856 File Offset: 0x0001AA56
		public ArrayPoolEventSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001456 RID: 5206
		// (get) Token: 0x06004F84 RID: 20356 RVA: 0x0017248C File Offset: 0x0017068C
		// (set) Token: 0x06004F85 RID: 20357 RVA: 0x0001C85F File Offset: 0x0001AA5F
		public unsafe static ArrayPoolEventSource Log
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ArrayPoolEventSource.NativeFieldInfoPtr_Log, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayPoolEventSource>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ArrayPoolEventSource.NativeFieldInfoPtr_Log, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040040D0 RID: 16592
		private static readonly IntPtr NativeFieldInfoPtr_Log;

		// Token: 0x040040D1 RID: 16593
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040040D2 RID: 16594
		private static readonly IntPtr NativeMethodInfoPtr_BufferRented_Internal_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x040040D3 RID: 16595
		private static readonly IntPtr NativeMethodInfoPtr_BufferAllocated_Internal_Void_Int32_Int32_Int32_Int32_BufferAllocatedReason_0;

		// Token: 0x040040D4 RID: 16596
		private static readonly IntPtr NativeMethodInfoPtr_BufferReturned_Internal_Void_Int32_Int32_Int32_0;

		// Token: 0x040040D5 RID: 16597
		private static readonly IntPtr NativeMethodInfoPtr_BufferTrimmed_Internal_Void_Int32_Int32_Int32_0;

		// Token: 0x040040D6 RID: 16598
		private static readonly IntPtr NativeMethodInfoPtr_BufferTrimPoll_Internal_Void_Int32_Int32_0;

		// Token: 0x02000710 RID: 1808
		public enum BufferAllocatedReason
		{
			// Token: 0x04004DFF RID: 19967
			Pooled,
			// Token: 0x04004E00 RID: 19968
			OverMaximumSize,
			// Token: 0x04004E01 RID: 19969
			PoolExhausted
		}
	}
}
