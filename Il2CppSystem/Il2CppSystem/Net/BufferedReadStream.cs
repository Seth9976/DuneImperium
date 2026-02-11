using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x020001ED RID: 493
	public class BufferedReadStream : WebReadStream
	{
		// Token: 0x06001EA0 RID: 7840 RVA: 0x00093030 File Offset: 0x00091230
		// Note: this type is marked as 'beforefieldinit'.
		static BufferedReadStream()
		{
			Il2CppClassPointerStore<BufferedReadStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "BufferedReadStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BufferedReadStream>.NativeClassPtr);
			BufferedReadStream.NativeFieldInfoPtr_readBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferedReadStream>.NativeClassPtr, "readBuffer");
			BufferedReadStream.NativeMethodInfoPtr__ctor_Public_Void_WebOperation_Stream_BufferOffsetSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferedReadStream>.NativeClassPtr, 100667958);
			BufferedReadStream.NativeMethodInfoPtr_ProcessReadAsync_Protected_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferedReadStream>.NativeClassPtr, 100667959);
			BufferedReadStream.NativeMethodInfoPtr_TryReadFromBuffer_Internal_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferedReadStream>.NativeClassPtr, 100667960);
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x000930B0 File Offset: 0x000912B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 478789, RefRangeEnd = 478793, XrefRangeStart = 478787, XrefRangeEnd = 478789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BufferedReadStream(WebOperation operation, Stream innerStream, BufferOffsetSize readBuffer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BufferedReadStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerStream);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(readBuffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferedReadStream.NativeMethodInfoPtr__ctor_Public_Void_WebOperation_Stream_BufferOffsetSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x00093120 File Offset: 0x00091320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478793, XrefRangeEnd = 478809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<int> ProcessReadAsync(Il2CppStructArray<byte> buffer, int offset, int size, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BufferedReadStream.NativeMethodInfoPtr_ProcessReadAsync_Protected_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x000931B0 File Offset: 0x000913B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478810, RefRangeEnd = 478811, XrefRangeStart = 478809, XrefRangeEnd = 478810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryReadFromBuffer(Il2CppStructArray<byte> buffer, int offset, int size, out int result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferedReadStream.NativeMethodInfoPtr_TryReadFromBuffer_Internal_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x0000D053 File Offset: 0x0000B253
		public BufferedReadStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06001EA5 RID: 7845 RVA: 0x00093228 File Offset: 0x00091428
		// (set) Token: 0x06001EA6 RID: 7846 RVA: 0x0000D05C File Offset: 0x0000B25C
		public unsafe BufferOffsetSize readBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferedReadStream.NativeFieldInfoPtr_readBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferedReadStream.NativeFieldInfoPtr_readBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001833 RID: 6195
		private static readonly IntPtr NativeFieldInfoPtr_readBuffer;

		// Token: 0x04001834 RID: 6196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WebOperation_Stream_BufferOffsetSize_0;

		// Token: 0x04001835 RID: 6197
		private static readonly IntPtr NativeMethodInfoPtr_ProcessReadAsync_Protected_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04001836 RID: 6198
		private static readonly IntPtr NativeMethodInfoPtr_TryReadFromBuffer_Internal_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_byref_Int32_0;

		// Token: 0x02000332 RID: 818
		[ObfuscatedName("System.Net.BufferedReadStream+<ProcessReadAsync>d__2")]
		public sealed class _ProcessReadAsync_d__2 : ValueType
		{
			// Token: 0x06002F62 RID: 12130 RVA: 0x000CE704 File Offset: 0x000CC904
			// Note: this type is marked as 'beforefieldinit'.
			static _ProcessReadAsync_d__2()
			{
				Il2CppClassPointerStore<BufferedReadStream._ProcessReadAsync_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BufferedReadStream>.NativeClassPtr, "<ProcessReadAsync>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BufferedReadStream._ProcessReadAsync_d__2>.NativeClassPtr);
				BufferedReadStream._ProcessReadAsync_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferedReadStream._ProcessReadAsync_d__2>.NativeClassPtr, "<>1__state");
				BufferedReadStream._ProcessReadAsync_d__2.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferedReadStream._ProcessReadAsync_d__2>.NativeClassPtr, "<>t__builder");
				BufferedReadStream._ProcessReadAsync_d__2.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferedReadStream._ProcessReadAsync_d__2>.NativeClassPtr, "cancellationToken");
				BufferedReadStream._ProcessReadAsync_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferedReadStream._ProcessReadAsync_d__2>.NativeClassPtr, "<>4__this");
				BufferedReadStream._ProcessReadAsync_d__2.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferedReadStream._ProcessReadAsync_d__2>.NativeClassPtr, "size");
				BufferedReadStream._ProcessReadAsync_d__2.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferedReadStream._ProcessReadAsync_d__2>.NativeClassPtr, "buffer");
				BufferedReadStream._ProcessReadAsync_d__2.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferedReadStream._ProcessReadAsync_d__2>.NativeClassPtr, "offset");
				BufferedReadStream._ProcessReadAsync_d__2.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferedReadStream._ProcessReadAsync_d__2>.NativeClassPtr, "<>u__1");
				BufferedReadStream._ProcessReadAsync_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferedReadStream._ProcessReadAsync_d__2>.NativeClassPtr, 100667961);
				BufferedReadStream._ProcessReadAsync_d__2.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferedReadStream._ProcessReadAsync_d__2>.NativeClassPtr, 100667962);
			}

			// Token: 0x06002F63 RID: 12131 RVA: 0x000CE7F8 File Offset: 0x000CC9F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478749, XrefRangeEnd = 478781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferedReadStream._ProcessReadAsync_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F64 RID: 12132 RVA: 0x000CE830 File Offset: 0x000CCA30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478781, XrefRangeEnd = 478787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferedReadStream._ProcessReadAsync_d__2.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F65 RID: 12133 RVA: 0x00015400 File Offset: 0x00013600
			public _ProcessReadAsync_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F66 RID: 12134 RVA: 0x00015409 File Offset: 0x00013609
			public _ProcessReadAsync_d__2()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BufferedReadStream._ProcessReadAsync_d__2>.NativeClassPtr))
			{
			}

			// Token: 0x17000ECF RID: 3791
			// (get) Token: 0x06002F67 RID: 12135 RVA: 0x000CE878 File Offset: 0x000CCA78
			// (set) Token: 0x06002F68 RID: 12136 RVA: 0x0001541B File Offset: 0x0001361B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferedReadStream._ProcessReadAsync_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferedReadStream._ProcessReadAsync_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000ED0 RID: 3792
			// (get) Token: 0x06002F69 RID: 12137 RVA: 0x000CE8A0 File Offset: 0x000CCAA0
			// (set) Token: 0x06002F6A RID: 12138 RVA: 0x00015436 File Offset: 0x00013636
			public AsyncTaskMethodBuilder<int> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferedReadStream._ProcessReadAsync_d__2.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferedReadStream._ProcessReadAsync_d__2.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000ED1 RID: 3793
			// (get) Token: 0x06002F6B RID: 12139 RVA: 0x000CE8D0 File Offset: 0x000CCAD0
			// (set) Token: 0x06002F6C RID: 12140 RVA: 0x00015464 File Offset: 0x00013664
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferedReadStream._ProcessReadAsync_d__2.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferedReadStream._ProcessReadAsync_d__2.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000ED2 RID: 3794
			// (get) Token: 0x06002F6D RID: 12141 RVA: 0x000CE900 File Offset: 0x000CCB00
			// (set) Token: 0x06002F6E RID: 12142 RVA: 0x00015492 File Offset: 0x00013692
			public unsafe BufferedReadStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferedReadStream._ProcessReadAsync_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferedReadStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferedReadStream._ProcessReadAsync_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ED3 RID: 3795
			// (get) Token: 0x06002F6F RID: 12143 RVA: 0x000CE930 File Offset: 0x000CCB30
			// (set) Token: 0x06002F70 RID: 12144 RVA: 0x000154B1 File Offset: 0x000136B1
			public unsafe int size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferedReadStream._ProcessReadAsync_d__2.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferedReadStream._ProcessReadAsync_d__2.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x17000ED4 RID: 3796
			// (get) Token: 0x06002F71 RID: 12145 RVA: 0x000CE958 File Offset: 0x000CCB58
			// (set) Token: 0x06002F72 RID: 12146 RVA: 0x000154CC File Offset: 0x000136CC
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferedReadStream._ProcessReadAsync_d__2.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferedReadStream._ProcessReadAsync_d__2.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ED5 RID: 3797
			// (get) Token: 0x06002F73 RID: 12147 RVA: 0x000CE988 File Offset: 0x000CCB88
			// (set) Token: 0x06002F74 RID: 12148 RVA: 0x000154EB File Offset: 0x000136EB
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferedReadStream._ProcessReadAsync_d__2.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferedReadStream._ProcessReadAsync_d__2.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x17000ED6 RID: 3798
			// (get) Token: 0x06002F75 RID: 12149 RVA: 0x000CE9B0 File Offset: 0x000CCBB0
			// (set) Token: 0x06002F76 RID: 12150 RVA: 0x00015506 File Offset: 0x00013706
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferedReadStream._ProcessReadAsync_d__2.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferedReadStream._ProcessReadAsync_d__2.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400251C RID: 9500
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400251D RID: 9501
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400251E RID: 9502
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400251F RID: 9503
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002520 RID: 9504
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x04002521 RID: 9505
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x04002522 RID: 9506
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x04002523 RID: 9507
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002524 RID: 9508
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002525 RID: 9509
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
