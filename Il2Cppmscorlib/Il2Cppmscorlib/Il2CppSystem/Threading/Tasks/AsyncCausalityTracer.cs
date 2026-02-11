using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001EE RID: 494
	public static class AsyncCausalityTracer : Object
	{
		// Token: 0x06002016 RID: 8214 RVA: 0x000B7D58 File Offset: 0x000B5F58
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncCausalityTracer()
		{
			Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "AsyncCausalityTracer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr);
			AsyncCausalityTracer.NativeMethodInfoPtr_get_LoggingOn_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr, 100668744);
			AsyncCausalityTracer.NativeMethodInfoPtr_TraceOperationCreation_Internal_Static_Void_CausalityTraceLevel_Int32_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr, 100668745);
			AsyncCausalityTracer.NativeMethodInfoPtr_TraceOperationCompletion_Internal_Static_Void_CausalityTraceLevel_Int32_AsyncCausalityStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr, 100668746);
			AsyncCausalityTracer.NativeMethodInfoPtr_TraceSynchronousWorkStart_Internal_Static_Void_CausalityTraceLevel_Int32_CausalitySynchronousWork_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr, 100668747);
			AsyncCausalityTracer.NativeMethodInfoPtr_TraceSynchronousWorkCompletion_Internal_Static_Void_CausalityTraceLevel_CausalitySynchronousWork_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr, 100668748);
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06002017 RID: 8215 RVA: 0x000B7DEC File Offset: 0x000B5FEC
		public unsafe static bool LoggingOn
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncCausalityTracer.NativeMethodInfoPtr_get_LoggingOn_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x000B7E1C File Offset: 0x000B601C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TraceOperationCreation(CausalityTraceLevel traceLevel, int taskId, string operationName, ulong relatedContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref traceLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref taskId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(operationName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relatedContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncCausalityTracer.NativeMethodInfoPtr_TraceOperationCreation_Internal_Static_Void_CausalityTraceLevel_Int32_String_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x000B7E7C File Offset: 0x000B607C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TraceOperationCompletion(CausalityTraceLevel traceLevel, int taskId, AsyncCausalityStatus status)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref traceLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref taskId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncCausalityTracer.NativeMethodInfoPtr_TraceOperationCompletion_Internal_Static_Void_CausalityTraceLevel_Int32_AsyncCausalityStatus_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x000B7ECC File Offset: 0x000B60CC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, int taskId, CausalitySynchronousWork work)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref traceLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref taskId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref work;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncCausalityTracer.NativeMethodInfoPtr_TraceSynchronousWorkStart_Internal_Static_Void_CausalityTraceLevel_Int32_CausalitySynchronousWork_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x000B7F1C File Offset: 0x000B611C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref traceLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref work;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncCausalityTracer.NativeMethodInfoPtr_TraceSynchronousWorkCompletion_Internal_Static_Void_CausalityTraceLevel_CausalitySynchronousWork_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x0000A6DB File Offset: 0x000088DB
		public AsyncCausalityTracer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C92 RID: 7314
		private static readonly IntPtr NativeMethodInfoPtr_get_LoggingOn_Internal_Static_get_Boolean_0;

		// Token: 0x04001C93 RID: 7315
		private static readonly IntPtr NativeMethodInfoPtr_TraceOperationCreation_Internal_Static_Void_CausalityTraceLevel_Int32_String_UInt64_0;

		// Token: 0x04001C94 RID: 7316
		private static readonly IntPtr NativeMethodInfoPtr_TraceOperationCompletion_Internal_Static_Void_CausalityTraceLevel_Int32_AsyncCausalityStatus_0;

		// Token: 0x04001C95 RID: 7317
		private static readonly IntPtr NativeMethodInfoPtr_TraceSynchronousWorkStart_Internal_Static_Void_CausalityTraceLevel_Int32_CausalitySynchronousWork_0;

		// Token: 0x04001C96 RID: 7318
		private static readonly IntPtr NativeMethodInfoPtr_TraceSynchronousWorkCompletion_Internal_Static_Void_CausalityTraceLevel_CausalitySynchronousWork_0;
	}
}
