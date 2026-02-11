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
	// Token: 0x020001F8 RID: 504
	public class FixedSizeReadStream : WebReadStream
	{
		// Token: 0x06001F3E RID: 7998 RVA: 0x000959D0 File Offset: 0x00093BD0
		// Note: this type is marked as 'beforefieldinit'.
		static FixedSizeReadStream()
		{
			Il2CppClassPointerStore<FixedSizeReadStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "FixedSizeReadStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixedSizeReadStream>.NativeClassPtr);
			FixedSizeReadStream.NativeFieldInfoPtr__ContentLength_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedSizeReadStream>.NativeClassPtr, "<ContentLength>k__BackingField");
			FixedSizeReadStream.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedSizeReadStream>.NativeClassPtr, "position");
			FixedSizeReadStream.NativeMethodInfoPtr_get_ContentLength_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedSizeReadStream>.NativeClassPtr, 100668051);
			FixedSizeReadStream.NativeMethodInfoPtr__ctor_Public_Void_WebOperation_Stream_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedSizeReadStream>.NativeClassPtr, 100668052);
			FixedSizeReadStream.NativeMethodInfoPtr_ProcessReadAsync_Protected_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedSizeReadStream>.NativeClassPtr, 100668053);
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06001F3F RID: 7999 RVA: 0x00095A64 File Offset: 0x00093C64
		public unsafe long ContentLength
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedSizeReadStream.NativeMethodInfoPtr_get_ContentLength_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x00095AA0 File Offset: 0x00093CA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 480021, RefRangeEnd = 480022, XrefRangeStart = 480020, XrefRangeEnd = 480021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FixedSizeReadStream(WebOperation operation, Stream innerStream, long contentLength)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FixedSizeReadStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerStream);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contentLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedSizeReadStream.NativeMethodInfoPtr__ctor_Public_Void_WebOperation_Stream_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F41 RID: 8001 RVA: 0x00095B0C File Offset: 0x00093D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480022, XrefRangeEnd = 480038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FixedSizeReadStream.NativeMethodInfoPtr_ProcessReadAsync_Protected_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x0000D3E6 File Offset: 0x0000B5E6
		public FixedSizeReadStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06001F43 RID: 8003 RVA: 0x00095B9C File Offset: 0x00093D9C
		// (set) Token: 0x06001F44 RID: 8004 RVA: 0x0000D3EF File Offset: 0x0000B5EF
		public unsafe long _ContentLength_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSizeReadStream.NativeFieldInfoPtr__ContentLength_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSizeReadStream.NativeFieldInfoPtr__ContentLength_k__BackingField)) = value;
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06001F45 RID: 8005 RVA: 0x00095BC4 File Offset: 0x00093DC4
		// (set) Token: 0x06001F46 RID: 8006 RVA: 0x0000D40A File Offset: 0x0000B60A
		public unsafe long position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSizeReadStream.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSizeReadStream.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x040018A5 RID: 6309
		private static readonly IntPtr NativeFieldInfoPtr__ContentLength_k__BackingField;

		// Token: 0x040018A6 RID: 6310
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040018A7 RID: 6311
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentLength_Public_get_Int64_0;

		// Token: 0x040018A8 RID: 6312
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WebOperation_Stream_Int64_0;

		// Token: 0x040018A9 RID: 6313
		private static readonly IntPtr NativeMethodInfoPtr_ProcessReadAsync_Protected_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x02000336 RID: 822
		[ObfuscatedName("System.Net.FixedSizeReadStream+<ProcessReadAsync>d__5")]
		public sealed class _ProcessReadAsync_d__5 : ValueType
		{
			// Token: 0x06002F8D RID: 12173 RVA: 0x000CEDBC File Offset: 0x000CCFBC
			// Note: this type is marked as 'beforefieldinit'.
			static _ProcessReadAsync_d__5()
			{
				Il2CppClassPointerStore<FixedSizeReadStream._ProcessReadAsync_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FixedSizeReadStream>.NativeClassPtr, "<ProcessReadAsync>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixedSizeReadStream._ProcessReadAsync_d__5>.NativeClassPtr);
				FixedSizeReadStream._ProcessReadAsync_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedSizeReadStream._ProcessReadAsync_d__5>.NativeClassPtr, "<>1__state");
				FixedSizeReadStream._ProcessReadAsync_d__5.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedSizeReadStream._ProcessReadAsync_d__5>.NativeClassPtr, "<>t__builder");
				FixedSizeReadStream._ProcessReadAsync_d__5.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedSizeReadStream._ProcessReadAsync_d__5>.NativeClassPtr, "cancellationToken");
				FixedSizeReadStream._ProcessReadAsync_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedSizeReadStream._ProcessReadAsync_d__5>.NativeClassPtr, "<>4__this");
				FixedSizeReadStream._ProcessReadAsync_d__5.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedSizeReadStream._ProcessReadAsync_d__5>.NativeClassPtr, "size");
				FixedSizeReadStream._ProcessReadAsync_d__5.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedSizeReadStream._ProcessReadAsync_d__5>.NativeClassPtr, "buffer");
				FixedSizeReadStream._ProcessReadAsync_d__5.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedSizeReadStream._ProcessReadAsync_d__5>.NativeClassPtr, "offset");
				FixedSizeReadStream._ProcessReadAsync_d__5.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedSizeReadStream._ProcessReadAsync_d__5>.NativeClassPtr, "<>u__1");
				FixedSizeReadStream._ProcessReadAsync_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedSizeReadStream._ProcessReadAsync_d__5>.NativeClassPtr, 100668054);
				FixedSizeReadStream._ProcessReadAsync_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedSizeReadStream._ProcessReadAsync_d__5>.NativeClassPtr, 100668055);
			}

			// Token: 0x06002F8E RID: 12174 RVA: 0x000CEEB0 File Offset: 0x000CD0B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479978, XrefRangeEnd = 480012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedSizeReadStream._ProcessReadAsync_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F8F RID: 12175 RVA: 0x000CEEE8 File Offset: 0x000CD0E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480012, XrefRangeEnd = 480020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedSizeReadStream._ProcessReadAsync_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F90 RID: 12176 RVA: 0x000155FC File Offset: 0x000137FC
			public _ProcessReadAsync_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F91 RID: 12177 RVA: 0x00015605 File Offset: 0x00013805
			public _ProcessReadAsync_d__5()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FixedSizeReadStream._ProcessReadAsync_d__5>.NativeClassPtr))
			{
			}

			// Token: 0x17000EDC RID: 3804
			// (get) Token: 0x06002F92 RID: 12178 RVA: 0x000CEF30 File Offset: 0x000CD130
			// (set) Token: 0x06002F93 RID: 12179 RVA: 0x00015617 File Offset: 0x00013817
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSizeReadStream._ProcessReadAsync_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSizeReadStream._ProcessReadAsync_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000EDD RID: 3805
			// (get) Token: 0x06002F94 RID: 12180 RVA: 0x000CEF58 File Offset: 0x000CD158
			// (set) Token: 0x06002F95 RID: 12181 RVA: 0x00015632 File Offset: 0x00013832
			public AsyncTaskMethodBuilder<int> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSizeReadStream._ProcessReadAsync_d__5.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSizeReadStream._ProcessReadAsync_d__5.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000EDE RID: 3806
			// (get) Token: 0x06002F96 RID: 12182 RVA: 0x000CEF88 File Offset: 0x000CD188
			// (set) Token: 0x06002F97 RID: 12183 RVA: 0x00015660 File Offset: 0x00013860
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSizeReadStream._ProcessReadAsync_d__5.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSizeReadStream._ProcessReadAsync_d__5.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000EDF RID: 3807
			// (get) Token: 0x06002F98 RID: 12184 RVA: 0x000CEFB8 File Offset: 0x000CD1B8
			// (set) Token: 0x06002F99 RID: 12185 RVA: 0x0001568E File Offset: 0x0001388E
			public unsafe FixedSizeReadStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSizeReadStream._ProcessReadAsync_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FixedSizeReadStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSizeReadStream._ProcessReadAsync_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EE0 RID: 3808
			// (get) Token: 0x06002F9A RID: 12186 RVA: 0x000CEFE8 File Offset: 0x000CD1E8
			// (set) Token: 0x06002F9B RID: 12187 RVA: 0x000156AD File Offset: 0x000138AD
			public unsafe int size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSizeReadStream._ProcessReadAsync_d__5.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSizeReadStream._ProcessReadAsync_d__5.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x17000EE1 RID: 3809
			// (get) Token: 0x06002F9C RID: 12188 RVA: 0x000CF010 File Offset: 0x000CD210
			// (set) Token: 0x06002F9D RID: 12189 RVA: 0x000156C8 File Offset: 0x000138C8
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSizeReadStream._ProcessReadAsync_d__5.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSizeReadStream._ProcessReadAsync_d__5.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EE2 RID: 3810
			// (get) Token: 0x06002F9E RID: 12190 RVA: 0x000CF040 File Offset: 0x000CD240
			// (set) Token: 0x06002F9F RID: 12191 RVA: 0x000156E7 File Offset: 0x000138E7
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSizeReadStream._ProcessReadAsync_d__5.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSizeReadStream._ProcessReadAsync_d__5.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x17000EE3 RID: 3811
			// (get) Token: 0x06002FA0 RID: 12192 RVA: 0x000CF068 File Offset: 0x000CD268
			// (set) Token: 0x06002FA1 RID: 12193 RVA: 0x00015702 File Offset: 0x00013902
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSizeReadStream._ProcessReadAsync_d__5.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedSizeReadStream._ProcessReadAsync_d__5.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002533 RID: 9523
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002534 RID: 9524
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002535 RID: 9525
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04002536 RID: 9526
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002537 RID: 9527
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x04002538 RID: 9528
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x04002539 RID: 9529
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x0400253A RID: 9530
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400253B RID: 9531
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400253C RID: 9532
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
