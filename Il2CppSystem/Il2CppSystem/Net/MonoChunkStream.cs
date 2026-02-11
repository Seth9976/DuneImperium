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
	// Token: 0x02000208 RID: 520
	public class MonoChunkStream : WebReadStream
	{
		// Token: 0x060021F6 RID: 8694 RVA: 0x0009ED10 File Offset: 0x0009CF10
		// Note: this type is marked as 'beforefieldinit'.
		static MonoChunkStream()
		{
			Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "MonoChunkStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr);
			MonoChunkStream.NativeFieldInfoPtr__Headers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, "<Headers>k__BackingField");
			MonoChunkStream.NativeFieldInfoPtr__Decoder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, "<Decoder>k__BackingField");
			MonoChunkStream.NativeMethodInfoPtr_get_Decoder_Protected_get_MonoChunkParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100668342);
			MonoChunkStream.NativeMethodInfoPtr__ctor_Public_Void_WebOperation_Stream_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100668343);
			MonoChunkStream.NativeMethodInfoPtr_ProcessReadAsync_Protected_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100668344);
			MonoChunkStream.NativeMethodInfoPtr_FinishReading_Internal_Virtual_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100668345);
			MonoChunkStream.NativeMethodInfoPtr_ThrowExpectingChunkTrailer_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100668346);
			MonoChunkStream.NativeMethodInfoPtr___n__0_Private_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100668347);
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x060021F7 RID: 8695 RVA: 0x0009EDE0 File Offset: 0x0009CFE0
		public unsafe MonoChunkParser Decoder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_get_Decoder_Protected_get_MonoChunkParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoChunkParser>(intPtr3) : null;
			}
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x0009EE20 File Offset: 0x0009D020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 482916, RefRangeEnd = 482917, XrefRangeStart = 482893, XrefRangeEnd = 482916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoChunkStream(WebOperation operation, Stream innerStream, WebHeaderCollection headers)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerStream);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr__ctor_Public_Void_WebOperation_Stream_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x0009EE90 File Offset: 0x0009D090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482917, XrefRangeEnd = 482933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoChunkStream.NativeMethodInfoPtr_ProcessReadAsync_Protected_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x0009EF20 File Offset: 0x0009D120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482933, XrefRangeEnd = 482944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task FinishReading(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoChunkStream.NativeMethodInfoPtr_FinishReading_Internal_Virtual_Task_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x0009EF80 File Offset: 0x0009D180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482944, XrefRangeEnd = 482950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowExpectingChunkTrailer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_ThrowExpectingChunkTrailer_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021FC RID: 8700 RVA: 0x0009EFA8 File Offset: 0x0009D1A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482950, XrefRangeEnd = 482961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task __n__0(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr___n__0_Private_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x0000EB4B File Offset: 0x0000CD4B
		public MonoChunkStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x060021FE RID: 8702 RVA: 0x0009F000 File Offset: 0x0009D200
		// (set) Token: 0x060021FF RID: 8703 RVA: 0x0000EB54 File Offset: 0x0000CD54
		public unsafe WebHeaderCollection _Headers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr__Headers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr__Headers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06002200 RID: 8704 RVA: 0x0009F030 File Offset: 0x0009D230
		// (set) Token: 0x06002201 RID: 8705 RVA: 0x0000EB73 File Offset: 0x0000CD73
		public unsafe MonoChunkParser _Decoder_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr__Decoder_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoChunkParser>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr__Decoder_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A75 RID: 6773
		private static readonly IntPtr NativeFieldInfoPtr__Headers_k__BackingField;

		// Token: 0x04001A76 RID: 6774
		private static readonly IntPtr NativeFieldInfoPtr__Decoder_k__BackingField;

		// Token: 0x04001A77 RID: 6775
		private static readonly IntPtr NativeMethodInfoPtr_get_Decoder_Protected_get_MonoChunkParser_0;

		// Token: 0x04001A78 RID: 6776
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WebOperation_Stream_WebHeaderCollection_0;

		// Token: 0x04001A79 RID: 6777
		private static readonly IntPtr NativeMethodInfoPtr_ProcessReadAsync_Protected_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04001A7A RID: 6778
		private static readonly IntPtr NativeMethodInfoPtr_FinishReading_Internal_Virtual_Task_CancellationToken_0;

		// Token: 0x04001A7B RID: 6779
		private static readonly IntPtr NativeMethodInfoPtr_ThrowExpectingChunkTrailer_Private_Static_Void_0;

		// Token: 0x04001A7C RID: 6780
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_Task_CancellationToken_0;

		// Token: 0x02000346 RID: 838
		[ObfuscatedName("System.Net.MonoChunkStream+<ProcessReadAsync>d__7")]
		public sealed class _ProcessReadAsync_d__7 : ValueType
		{
			// Token: 0x0600302E RID: 12334 RVA: 0x000D06D8 File Offset: 0x000CE8D8
			// Note: this type is marked as 'beforefieldinit'.
			static _ProcessReadAsync_d__7()
			{
				Il2CppClassPointerStore<MonoChunkStream._ProcessReadAsync_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, "<ProcessReadAsync>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoChunkStream._ProcessReadAsync_d__7>.NativeClassPtr);
				MonoChunkStream._ProcessReadAsync_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream._ProcessReadAsync_d__7>.NativeClassPtr, "<>1__state");
				MonoChunkStream._ProcessReadAsync_d__7.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream._ProcessReadAsync_d__7>.NativeClassPtr, "<>t__builder");
				MonoChunkStream._ProcessReadAsync_d__7.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream._ProcessReadAsync_d__7>.NativeClassPtr, "cancellationToken");
				MonoChunkStream._ProcessReadAsync_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream._ProcessReadAsync_d__7>.NativeClassPtr, "<>4__this");
				MonoChunkStream._ProcessReadAsync_d__7.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream._ProcessReadAsync_d__7>.NativeClassPtr, "buffer");
				MonoChunkStream._ProcessReadAsync_d__7.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream._ProcessReadAsync_d__7>.NativeClassPtr, "offset");
				MonoChunkStream._ProcessReadAsync_d__7.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream._ProcessReadAsync_d__7>.NativeClassPtr, "size");
				MonoChunkStream._ProcessReadAsync_d__7.NativeFieldInfoPtr__moreBytes_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream._ProcessReadAsync_d__7>.NativeClassPtr, "<moreBytes>5__2");
				MonoChunkStream._ProcessReadAsync_d__7.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream._ProcessReadAsync_d__7>.NativeClassPtr, "<>u__1");
				MonoChunkStream._ProcessReadAsync_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream._ProcessReadAsync_d__7>.NativeClassPtr, 100668348);
				MonoChunkStream._ProcessReadAsync_d__7.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream._ProcessReadAsync_d__7>.NativeClassPtr, 100668349);
			}

			// Token: 0x0600302F RID: 12335 RVA: 0x000D07E0 File Offset: 0x000CE9E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482807, XrefRangeEnd = 482850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream._ProcessReadAsync_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003030 RID: 12336 RVA: 0x000D0818 File Offset: 0x000CEA18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482850, XrefRangeEnd = 482856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream._ProcessReadAsync_d__7.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003031 RID: 12337 RVA: 0x00015E3C File Offset: 0x0001403C
			public _ProcessReadAsync_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003032 RID: 12338 RVA: 0x00015E45 File Offset: 0x00014045
			public _ProcessReadAsync_d__7()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoChunkStream._ProcessReadAsync_d__7>.NativeClassPtr))
			{
			}

			// Token: 0x17000F18 RID: 3864
			// (get) Token: 0x06003033 RID: 12339 RVA: 0x000D0860 File Offset: 0x000CEA60
			// (set) Token: 0x06003034 RID: 12340 RVA: 0x00015E57 File Offset: 0x00014057
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._ProcessReadAsync_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._ProcessReadAsync_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F19 RID: 3865
			// (get) Token: 0x06003035 RID: 12341 RVA: 0x000D0888 File Offset: 0x000CEA88
			// (set) Token: 0x06003036 RID: 12342 RVA: 0x00015E72 File Offset: 0x00014072
			public AsyncTaskMethodBuilder<int> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._ProcessReadAsync_d__7.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._ProcessReadAsync_d__7.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F1A RID: 3866
			// (get) Token: 0x06003037 RID: 12343 RVA: 0x000D08B8 File Offset: 0x000CEAB8
			// (set) Token: 0x06003038 RID: 12344 RVA: 0x00015EA0 File Offset: 0x000140A0
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._ProcessReadAsync_d__7.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._ProcessReadAsync_d__7.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F1B RID: 3867
			// (get) Token: 0x06003039 RID: 12345 RVA: 0x000D08E8 File Offset: 0x000CEAE8
			// (set) Token: 0x0600303A RID: 12346 RVA: 0x00015ECE File Offset: 0x000140CE
			public unsafe MonoChunkStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._ProcessReadAsync_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoChunkStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._ProcessReadAsync_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F1C RID: 3868
			// (get) Token: 0x0600303B RID: 12347 RVA: 0x000D0918 File Offset: 0x000CEB18
			// (set) Token: 0x0600303C RID: 12348 RVA: 0x00015EED File Offset: 0x000140ED
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._ProcessReadAsync_d__7.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._ProcessReadAsync_d__7.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F1D RID: 3869
			// (get) Token: 0x0600303D RID: 12349 RVA: 0x000D0948 File Offset: 0x000CEB48
			// (set) Token: 0x0600303E RID: 12350 RVA: 0x00015F0C File Offset: 0x0001410C
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._ProcessReadAsync_d__7.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._ProcessReadAsync_d__7.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x17000F1E RID: 3870
			// (get) Token: 0x0600303F RID: 12351 RVA: 0x000D0970 File Offset: 0x000CEB70
			// (set) Token: 0x06003040 RID: 12352 RVA: 0x00015F27 File Offset: 0x00014127
			public unsafe int size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._ProcessReadAsync_d__7.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._ProcessReadAsync_d__7.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x17000F1F RID: 3871
			// (get) Token: 0x06003041 RID: 12353 RVA: 0x000D0998 File Offset: 0x000CEB98
			// (set) Token: 0x06003042 RID: 12354 RVA: 0x00015F42 File Offset: 0x00014142
			public unsafe Il2CppStructArray<byte> _moreBytes_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._ProcessReadAsync_d__7.NativeFieldInfoPtr__moreBytes_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._ProcessReadAsync_d__7.NativeFieldInfoPtr__moreBytes_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F20 RID: 3872
			// (get) Token: 0x06003043 RID: 12355 RVA: 0x000D09C8 File Offset: 0x000CEBC8
			// (set) Token: 0x06003044 RID: 12356 RVA: 0x00015F61 File Offset: 0x00014161
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._ProcessReadAsync_d__7.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._ProcessReadAsync_d__7.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002596 RID: 9622
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002597 RID: 9623
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002598 RID: 9624
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04002599 RID: 9625
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400259A RID: 9626
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x0400259B RID: 9627
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x0400259C RID: 9628
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x0400259D RID: 9629
			private static readonly IntPtr NativeFieldInfoPtr__moreBytes_5__2;

			// Token: 0x0400259E RID: 9630
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400259F RID: 9631
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040025A0 RID: 9632
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000347 RID: 839
		[ObfuscatedName("System.Net.MonoChunkStream+<FinishReading>d__8")]
		public sealed class _FinishReading_d__8 : ValueType
		{
			// Token: 0x06003045 RID: 12357 RVA: 0x000D09F8 File Offset: 0x000CEBF8
			// Note: this type is marked as 'beforefieldinit'.
			static _FinishReading_d__8()
			{
				Il2CppClassPointerStore<MonoChunkStream._FinishReading_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, "<FinishReading>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoChunkStream._FinishReading_d__8>.NativeClassPtr);
				MonoChunkStream._FinishReading_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream._FinishReading_d__8>.NativeClassPtr, "<>1__state");
				MonoChunkStream._FinishReading_d__8.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream._FinishReading_d__8>.NativeClassPtr, "<>t__builder");
				MonoChunkStream._FinishReading_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream._FinishReading_d__8>.NativeClassPtr, "<>4__this");
				MonoChunkStream._FinishReading_d__8.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream._FinishReading_d__8>.NativeClassPtr, "cancellationToken");
				MonoChunkStream._FinishReading_d__8.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream._FinishReading_d__8>.NativeClassPtr, "<>u__1");
				MonoChunkStream._FinishReading_d__8.NativeFieldInfoPtr__buffer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream._FinishReading_d__8>.NativeClassPtr, "<buffer>5__2");
				MonoChunkStream._FinishReading_d__8.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream._FinishReading_d__8>.NativeClassPtr, "<>u__2");
				MonoChunkStream._FinishReading_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream._FinishReading_d__8>.NativeClassPtr, 100668350);
				MonoChunkStream._FinishReading_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream._FinishReading_d__8>.NativeClassPtr, 100668351);
			}

			// Token: 0x06003046 RID: 12358 RVA: 0x000D0AD8 File Offset: 0x000CECD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482856, XrefRangeEnd = 482889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream._FinishReading_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003047 RID: 12359 RVA: 0x000D0B10 File Offset: 0x000CED10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482889, XrefRangeEnd = 482893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream._FinishReading_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003048 RID: 12360 RVA: 0x00015F8F File Offset: 0x0001418F
			public _FinishReading_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003049 RID: 12361 RVA: 0x00015F98 File Offset: 0x00014198
			public _FinishReading_d__8()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoChunkStream._FinishReading_d__8>.NativeClassPtr))
			{
			}

			// Token: 0x17000F21 RID: 3873
			// (get) Token: 0x0600304A RID: 12362 RVA: 0x000D0B58 File Offset: 0x000CED58
			// (set) Token: 0x0600304B RID: 12363 RVA: 0x00015FAA File Offset: 0x000141AA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._FinishReading_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._FinishReading_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F22 RID: 3874
			// (get) Token: 0x0600304C RID: 12364 RVA: 0x000D0B80 File Offset: 0x000CED80
			// (set) Token: 0x0600304D RID: 12365 RVA: 0x00015FC5 File Offset: 0x000141C5
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._FinishReading_d__8.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._FinishReading_d__8.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F23 RID: 3875
			// (get) Token: 0x0600304E RID: 12366 RVA: 0x000D0BB0 File Offset: 0x000CEDB0
			// (set) Token: 0x0600304F RID: 12367 RVA: 0x00015FF3 File Offset: 0x000141F3
			public unsafe MonoChunkStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._FinishReading_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoChunkStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._FinishReading_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F24 RID: 3876
			// (get) Token: 0x06003050 RID: 12368 RVA: 0x000D0BE0 File Offset: 0x000CEDE0
			// (set) Token: 0x06003051 RID: 12369 RVA: 0x00016012 File Offset: 0x00014212
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._FinishReading_d__8.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._FinishReading_d__8.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F25 RID: 3877
			// (get) Token: 0x06003052 RID: 12370 RVA: 0x000D0C10 File Offset: 0x000CEE10
			// (set) Token: 0x06003053 RID: 12371 RVA: 0x00016040 File Offset: 0x00014240
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._FinishReading_d__8.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._FinishReading_d__8.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F26 RID: 3878
			// (get) Token: 0x06003054 RID: 12372 RVA: 0x000D0C40 File Offset: 0x000CEE40
			// (set) Token: 0x06003055 RID: 12373 RVA: 0x0001606E File Offset: 0x0001426E
			public unsafe Il2CppStructArray<byte> _buffer_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._FinishReading_d__8.NativeFieldInfoPtr__buffer_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._FinishReading_d__8.NativeFieldInfoPtr__buffer_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F27 RID: 3879
			// (get) Token: 0x06003056 RID: 12374 RVA: 0x000D0C70 File Offset: 0x000CEE70
			// (set) Token: 0x06003057 RID: 12375 RVA: 0x0001608D File Offset: 0x0001428D
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._FinishReading_d__8.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream._FinishReading_d__8.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040025A1 RID: 9633
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040025A2 RID: 9634
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040025A3 RID: 9635
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040025A4 RID: 9636
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040025A5 RID: 9637
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040025A6 RID: 9638
			private static readonly IntPtr NativeFieldInfoPtr__buffer_5__2;

			// Token: 0x040025A7 RID: 9639
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040025A8 RID: 9640
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040025A9 RID: 9641
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
