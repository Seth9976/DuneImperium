using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000041 RID: 65
	public static class AsyncUtils : Object
	{
		// Token: 0x0600061D RID: 1565 RVA: 0x0002F670 File Offset: 0x0002D870
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncUtils()
		{
			Il2CppClassPointerStore<AsyncUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "AsyncUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncUtils>.NativeClassPtr);
			AsyncUtils.NativeFieldInfoPtr_False = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncUtils>.NativeClassPtr, "False");
			AsyncUtils.NativeFieldInfoPtr_True = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncUtils>.NativeClassPtr, "True");
			AsyncUtils.NativeFieldInfoPtr_CompletedTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncUtils>.NativeClassPtr, "CompletedTask");
			AsyncUtils.NativeMethodInfoPtr_ToAsync_Internal_Static_Task_1_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncUtils>.NativeClassPtr, 100664540);
			AsyncUtils.NativeMethodInfoPtr_CancelIfRequestedAsync_Public_Static_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncUtils>.NativeClassPtr, 100664541);
			AsyncUtils.NativeMethodInfoPtr_CancelIfRequestedAsync_Public_Static_Task_1_T_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncUtils>.NativeClassPtr, 100664542);
			AsyncUtils.NativeMethodInfoPtr_FromCanceled_Public_Static_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncUtils>.NativeClassPtr, 100664543);
			AsyncUtils.NativeMethodInfoPtr_FromCanceled_Public_Static_Task_1_T_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncUtils>.NativeClassPtr, 100664544);
			AsyncUtils.NativeMethodInfoPtr_WriteAsync_Public_Static_Task_TextWriter_Char_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncUtils>.NativeClassPtr, 100664545);
			AsyncUtils.NativeMethodInfoPtr_WriteAsync_Public_Static_Task_TextWriter_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncUtils>.NativeClassPtr, 100664546);
			AsyncUtils.NativeMethodInfoPtr_WriteAsync_Public_Static_Task_TextWriter_Il2CppStructArray_1_Char_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncUtils>.NativeClassPtr, 100664547);
			AsyncUtils.NativeMethodInfoPtr_ReadAsync_Public_Static_Task_1_Int32_TextReader_Il2CppStructArray_1_Char_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncUtils>.NativeClassPtr, 100664548);
			AsyncUtils.NativeMethodInfoPtr_IsCompletedSuccessfully_Public_Static_Boolean_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncUtils>.NativeClassPtr, 100664549);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x0002F7A4 File Offset: 0x0002D9A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 738993, RefRangeEnd = 738995, XrefRangeStart = 738989, XrefRangeEnd = 738993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<bool> ToAsync(this bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncUtils.NativeMethodInfoPtr_ToAsync_Internal_Static_Task_1_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0002F7E4 File Offset: 0x0002D9E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 739003, RefRangeEnd = 739005, XrefRangeStart = 738995, XrefRangeEnd = 739003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task CancelIfRequestedAsync(this CancellationToken cancellationToken)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncUtils.NativeMethodInfoPtr_CancelIfRequestedAsync_Public_Static_Task_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0002F830 File Offset: 0x0002DA30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 739014, RefRangeEnd = 739015, XrefRangeStart = 739005, XrefRangeEnd = 739014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<T> CancelIfRequestedAsync<T>(this CancellationToken cancellationToken)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncUtils.MethodInfoStoreGeneric_CancelIfRequestedAsync_Public_Static_Task_1_T_CancellationToken_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0002F87C File Offset: 0x0002DA7C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 739034, RefRangeEnd = 739041, XrefRangeStart = 739015, XrefRangeEnd = 739034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task FromCanceled(this CancellationToken cancellationToken)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncUtils.NativeMethodInfoPtr_FromCanceled_Public_Static_Task_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0002F8C8 File Offset: 0x0002DAC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 739057, RefRangeEnd = 739058, XrefRangeStart = 739041, XrefRangeEnd = 739057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<T> FromCanceled<T>(this CancellationToken cancellationToken)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncUtils.MethodInfoStoreGeneric_FromCanceled_Public_Static_Task_1_T_CancellationToken_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0002F914 File Offset: 0x0002DB14
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 739066, RefRangeEnd = 739086, XrefRangeStart = 739058, XrefRangeEnd = 739066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task WriteAsync(this TextWriter writer, char value, CancellationToken cancellationToken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncUtils.NativeMethodInfoPtr_WriteAsync_Public_Static_Task_TextWriter_Char_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0002F980 File Offset: 0x0002DB80
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 739094, RefRangeEnd = 739116, XrefRangeStart = 739086, XrefRangeEnd = 739094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task WriteAsync(this TextWriter writer, string value, CancellationToken cancellationToken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncUtils.NativeMethodInfoPtr_WriteAsync_Public_Static_Task_TextWriter_String_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0002F9F0 File Offset: 0x0002DBF0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 739124, RefRangeEnd = 739137, XrefRangeStart = 739116, XrefRangeEnd = 739124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task WriteAsync(this TextWriter writer, Il2CppStructArray<char> value, int start, int count, CancellationToken cancellationToken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncUtils.NativeMethodInfoPtr_WriteAsync_Public_Static_Task_TextWriter_Il2CppStructArray_1_Char_Int32_Int32_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0002FA7C File Offset: 0x0002DC7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 739147, RefRangeEnd = 739148, XrefRangeStart = 739137, XrefRangeEnd = 739147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<int> ReadAsync(this TextReader reader, Il2CppStructArray<char> buffer, int index, int count, CancellationToken cancellationToken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncUtils.NativeMethodInfoPtr_ReadAsync_Public_Static_Task_1_Int32_TextReader_Il2CppStructArray_1_Char_Int32_Int32_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0002FB08 File Offset: 0x0002DD08
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 739149, RefRangeEnd = 739173, XrefRangeStart = 739148, XrefRangeEnd = 739149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCompletedSuccessfully(this Task task)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncUtils.NativeMethodInfoPtr_IsCompletedSuccessfully_Public_Static_Boolean_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00003DAB File Offset: 0x00001FAB
		public AsyncUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x0002FB4C File Offset: 0x0002DD4C
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x00003DB4 File Offset: 0x00001FB4
		public unsafe static Task<bool> False
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AsyncUtils.NativeFieldInfoPtr_False, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AsyncUtils.NativeFieldInfoPtr_False, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x0002FB74 File Offset: 0x0002DD74
		// (set) Token: 0x0600062C RID: 1580 RVA: 0x00003DC6 File Offset: 0x00001FC6
		public unsafe static Task<bool> True
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AsyncUtils.NativeFieldInfoPtr_True, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AsyncUtils.NativeFieldInfoPtr_True, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x0002FB9C File Offset: 0x0002DD9C
		// (set) Token: 0x0600062E RID: 1582 RVA: 0x00003DD8 File Offset: 0x00001FD8
		public unsafe static Task CompletedTask
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AsyncUtils.NativeFieldInfoPtr_CompletedTask, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AsyncUtils.NativeFieldInfoPtr_CompletedTask, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeFieldInfoPtr_False;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeFieldInfoPtr_True;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeFieldInfoPtr_CompletedTask;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeMethodInfoPtr_ToAsync_Internal_Static_Task_1_Boolean_Boolean_0;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeMethodInfoPtr_CancelIfRequestedAsync_Public_Static_Task_CancellationToken_0;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeMethodInfoPtr_CancelIfRequestedAsync_Public_Static_Task_1_T_CancellationToken_0;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeMethodInfoPtr_FromCanceled_Public_Static_Task_CancellationToken_0;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeMethodInfoPtr_FromCanceled_Public_Static_Task_1_T_CancellationToken_0;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Static_Task_TextWriter_Char_CancellationToken_0;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Static_Task_TextWriter_String_CancellationToken_0;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Static_Task_TextWriter_Il2CppStructArray_1_Char_Int32_Int32_CancellationToken_0;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Static_Task_1_Int32_TextReader_Il2CppStructArray_1_Char_Int32_Int32_CancellationToken_0;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeMethodInfoPtr_IsCompletedSuccessfully_Public_Static_Boolean_Task_0;

		// Token: 0x0200016C RID: 364
		[ObfuscatedName("Newtonsoft.Json.Utilities.AsyncUtils+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001C0A RID: 7178 RVA: 0x00084FF0 File Offset: 0x000831F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AsyncUtils.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncUtils>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncUtils.__c>.NativeClassPtr);
				AsyncUtils.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncUtils.__c>.NativeClassPtr, "<>9");
				AsyncUtils.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncUtils.__c>.NativeClassPtr, "<>9__5_0");
				AsyncUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncUtils.__c>.NativeClassPtr, 100664552);
				AsyncUtils.__c.NativeMethodInfoPtr__FromCanceled_b__5_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncUtils.__c>.NativeClassPtr, 100664553);
			}

			// Token: 0x06001C0B RID: 7179 RVA: 0x0008506C File Offset: 0x0008326C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncUtils.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C0C RID: 7180 RVA: 0x000850A8 File Offset: 0x000832A8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _FromCanceled_b__5_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncUtils.__c.NativeMethodInfoPtr__FromCanceled_b__5_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C0D RID: 7181 RVA: 0x0000DCC1 File Offset: 0x0000BEC1
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007EA RID: 2026
			// (get) Token: 0x06001C0E RID: 7182 RVA: 0x000850DC File Offset: 0x000832DC
			// (set) Token: 0x06001C0F RID: 7183 RVA: 0x0000DCCA File Offset: 0x0000BECA
			public unsafe static AsyncUtils.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AsyncUtils.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncUtils.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AsyncUtils.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007EB RID: 2027
			// (get) Token: 0x06001C10 RID: 7184 RVA: 0x00085104 File Offset: 0x00083304
			// (set) Token: 0x06001C11 RID: 7185 RVA: 0x0000DCDC File Offset: 0x0000BEDC
			public unsafe static Action __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AsyncUtils.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AsyncUtils.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014E6 RID: 5350
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040014E7 RID: 5351
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040014E8 RID: 5352
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040014E9 RID: 5353
			private static readonly IntPtr NativeMethodInfoPtr__FromCanceled_b__5_0_Internal_Void_0;
		}

		// Token: 0x0200016D RID: 365
		[ObfuscatedName("Newtonsoft.Json.Utilities.AsyncUtils+<>c__6`1")]
		[Serializable]
		public sealed class __c__6<T> : Object
		{
			// Token: 0x06001C12 RID: 7186 RVA: 0x0008512C File Offset: 0x0008332C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__6()
			{
				Il2CppClassPointerStore<AsyncUtils.__c__6<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncUtils>.NativeClassPtr, "<>c__6`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncUtils.__c__6<T>>.NativeClassPtr);
				AsyncUtils.__c__6<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncUtils.__c__6<T>>.NativeClassPtr, "<>9");
				AsyncUtils.__c__6<T>.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncUtils.__c__6<T>>.NativeClassPtr, "<>9__6_0");
				AsyncUtils.__c__6<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncUtils.__c__6<T>>.NativeClassPtr, 100664555);
				AsyncUtils.__c__6<T>.NativeMethodInfoPtr__FromCanceled_b__6_0_Internal_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncUtils.__c__6<T>>.NativeClassPtr, 100664556);
			}

			// Token: 0x06001C13 RID: 7187 RVA: 0x000851E4 File Offset: 0x000833E4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__6()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncUtils.__c__6<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncUtils.__c__6<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C14 RID: 7188 RVA: 0x00085220 File Offset: 0x00083420
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _FromCanceled_b__6_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncUtils.__c__6<T>.NativeMethodInfoPtr__FromCanceled_b__6_0_Internal_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}

			// Token: 0x06001C15 RID: 7189 RVA: 0x0000DCEE File Offset: 0x0000BEEE
			public __c__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007EC RID: 2028
			// (get) Token: 0x06001C16 RID: 7190 RVA: 0x0008525C File Offset: 0x0008345C
			// (set) Token: 0x06001C17 RID: 7191 RVA: 0x0000DCF7 File Offset: 0x0000BEF7
			public unsafe static AsyncUtils.__c__6<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AsyncUtils.__c__6<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncUtils.__c__6<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AsyncUtils.__c__6<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007ED RID: 2029
			// (get) Token: 0x06001C18 RID: 7192 RVA: 0x00085284 File Offset: 0x00083484
			// (set) Token: 0x06001C19 RID: 7193 RVA: 0x0000DD09 File Offset: 0x0000BF09
			public unsafe static Func<T> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AsyncUtils.__c__6<T>.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AsyncUtils.__c__6<T>.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014EA RID: 5354
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040014EB RID: 5355
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x040014EC RID: 5356
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040014ED RID: 5357
			private static readonly IntPtr NativeMethodInfoPtr__FromCanceled_b__6_0_Internal_T_0;
		}

		// Token: 0x0200016E RID: 366
		private sealed class MethodInfoStoreGeneric_CancelIfRequestedAsync_Public_Static_Task_1_T_CancellationToken_0<T>
		{
			// Token: 0x040014EE RID: 5358
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncUtils.NativeMethodInfoPtr_CancelIfRequestedAsync_Public_Static_Task_1_T_CancellationToken_0, Il2CppClassPointerStore<AsyncUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200016F RID: 367
		private sealed class MethodInfoStoreGeneric_FromCanceled_Public_Static_Task_1_T_CancellationToken_0<T>
		{
			// Token: 0x040014EF RID: 5359
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncUtils.NativeMethodInfoPtr_FromCanceled_Public_Static_Task_1_T_CancellationToken_0, Il2CppClassPointerStore<AsyncUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
