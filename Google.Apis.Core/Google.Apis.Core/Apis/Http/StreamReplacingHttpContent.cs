using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Net;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Http
{
	// Token: 0x0200003A RID: 58
	public sealed class StreamReplacingHttpContent : HttpContent
	{
		// Token: 0x0600028A RID: 650 RVA: 0x0000D494 File Offset: 0x0000B694
		// Note: this type is marked as 'beforefieldinit'.
		static StreamReplacingHttpContent()
		{
			Il2CppClassPointerStore<StreamReplacingHttpContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Http", "StreamReplacingHttpContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamReplacingHttpContent>.NativeClassPtr);
			StreamReplacingHttpContent.NativeFieldInfoPtr__originalContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReplacingHttpContent>.NativeClassPtr, "_originalContent");
			StreamReplacingHttpContent.NativeFieldInfoPtr__replacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReplacingHttpContent>.NativeClassPtr, "_replacement");
			StreamReplacingHttpContent.NativeFieldInfoPtr__streamCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReplacingHttpContent>.NativeClassPtr, "_streamCreated");
			StreamReplacingHttpContent.NativeMethodInfoPtr__ctor_Internal_Void_HttpContent_Func_2_Stream_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReplacingHttpContent>.NativeClassPtr, 100663699);
			StreamReplacingHttpContent.NativeMethodInfoPtr_TryComputeLength_Protected_Virtual_Boolean_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReplacingHttpContent>.NativeClassPtr, 100663700);
			StreamReplacingHttpContent.NativeMethodInfoPtr_CreateContentReadStreamAsync_Protected_Virtual_Task_1_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReplacingHttpContent>.NativeClassPtr, 100663701);
			StreamReplacingHttpContent.NativeMethodInfoPtr_SerializeToStreamAsync_Protected_Virtual_Task_Stream_TransportContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReplacingHttpContent>.NativeClassPtr, 100663702);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000D550 File Offset: 0x0000B750
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1212869, RefRangeEnd = 1212871, XrefRangeStart = 1212846, XrefRangeEnd = 1212869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReplacingHttpContent(HttpContent originalContent, Func<Stream, Stream> replacement)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReplacingHttpContent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(originalContent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replacement);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReplacingHttpContent.NativeMethodInfoPtr__ctor_Internal_Void_HttpContent_Func_2_Stream_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000D5B0 File Offset: 0x0000B7B0
		[CallerCount(0)]
		public unsafe override bool TryComputeLength(out long length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReplacingHttpContent.NativeMethodInfoPtr_TryComputeLength_Protected_Virtual_Boolean_byref_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000D5FC File Offset: 0x0000B7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212871, XrefRangeEnd = 1212885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<Stream> CreateContentReadStreamAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReplacingHttpContent.NativeMethodInfoPtr_CreateContentReadStreamAsync_Protected_Virtual_Task_1_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Stream>>(intPtr3) : null;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000D63C File Offset: 0x0000B83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212885, XrefRangeEnd = 1212896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task SerializeToStreamAsync(Stream stream, TransportContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReplacingHttpContent.NativeMethodInfoPtr_SerializeToStreamAsync_Protected_Virtual_Task_Stream_TransportContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x000030A0 File Offset: 0x000012A0
		public StreamReplacingHttpContent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0000D6A0 File Offset: 0x0000B8A0
		// (set) Token: 0x06000291 RID: 657 RVA: 0x000030A9 File Offset: 0x000012A9
		public unsafe HttpContent _originalContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent.NativeFieldInfoPtr__originalContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent.NativeFieldInfoPtr__originalContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0000D6D0 File Offset: 0x0000B8D0
		// (set) Token: 0x06000293 RID: 659 RVA: 0x000030C8 File Offset: 0x000012C8
		public unsafe Func<Stream, Stream> _replacement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent.NativeFieldInfoPtr__replacement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Stream, Stream>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent.NativeFieldInfoPtr__replacement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0000D700 File Offset: 0x0000B900
		// (set) Token: 0x06000295 RID: 661 RVA: 0x000030E7 File Offset: 0x000012E7
		public unsafe bool _streamCreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent.NativeFieldInfoPtr__streamCreated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent.NativeFieldInfoPtr__streamCreated)) = value;
			}
		}

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeFieldInfoPtr__originalContent;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeFieldInfoPtr__replacement;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeFieldInfoPtr__streamCreated;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_HttpContent_Func_2_Stream_Stream_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_TryComputeLength_Protected_Virtual_Boolean_byref_Int64_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_CreateContentReadStreamAsync_Protected_Virtual_Task_1_Stream_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_SerializeToStreamAsync_Protected_Virtual_Task_Stream_TransportContext_0;

		// Token: 0x02000065 RID: 101
		[ObfuscatedName("Google.Apis.Http.StreamReplacingHttpContent+<CreateContentReadStreamAsync>d__5")]
		public sealed class _CreateContentReadStreamAsync_d__5 : ValueType
		{
			// Token: 0x060003F7 RID: 1015 RVA: 0x00011A98 File Offset: 0x0000FC98
			// Note: this type is marked as 'beforefieldinit'.
			static _CreateContentReadStreamAsync_d__5()
			{
				Il2CppClassPointerStore<StreamReplacingHttpContent._CreateContentReadStreamAsync_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StreamReplacingHttpContent>.NativeClassPtr, "<CreateContentReadStreamAsync>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamReplacingHttpContent._CreateContentReadStreamAsync_d__5>.NativeClassPtr);
				StreamReplacingHttpContent._CreateContentReadStreamAsync_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReplacingHttpContent._CreateContentReadStreamAsync_d__5>.NativeClassPtr, "<>1__state");
				StreamReplacingHttpContent._CreateContentReadStreamAsync_d__5.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReplacingHttpContent._CreateContentReadStreamAsync_d__5>.NativeClassPtr, "<>t__builder");
				StreamReplacingHttpContent._CreateContentReadStreamAsync_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReplacingHttpContent._CreateContentReadStreamAsync_d__5>.NativeClassPtr, "<>4__this");
				StreamReplacingHttpContent._CreateContentReadStreamAsync_d__5.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReplacingHttpContent._CreateContentReadStreamAsync_d__5>.NativeClassPtr, "<>u__1");
				StreamReplacingHttpContent._CreateContentReadStreamAsync_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReplacingHttpContent._CreateContentReadStreamAsync_d__5>.NativeClassPtr, 100663703);
				StreamReplacingHttpContent._CreateContentReadStreamAsync_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReplacingHttpContent._CreateContentReadStreamAsync_d__5>.NativeClassPtr, 100663704);
			}

			// Token: 0x060003F8 RID: 1016 RVA: 0x00011B3C File Offset: 0x0000FD3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212773, XrefRangeEnd = 1212792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReplacingHttpContent._CreateContentReadStreamAsync_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003F9 RID: 1017 RVA: 0x00011B74 File Offset: 0x0000FD74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212792, XrefRangeEnd = 1212798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReplacingHttpContent._CreateContentReadStreamAsync_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003FA RID: 1018 RVA: 0x00003E87 File Offset: 0x00002087
			public _CreateContentReadStreamAsync_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060003FB RID: 1019 RVA: 0x00003E90 File Offset: 0x00002090
			public _CreateContentReadStreamAsync_d__5()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReplacingHttpContent._CreateContentReadStreamAsync_d__5>.NativeClassPtr))
			{
			}

			// Token: 0x17000138 RID: 312
			// (get) Token: 0x060003FC RID: 1020 RVA: 0x00011BBC File Offset: 0x0000FDBC
			// (set) Token: 0x060003FD RID: 1021 RVA: 0x00003EA2 File Offset: 0x000020A2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent._CreateContentReadStreamAsync_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent._CreateContentReadStreamAsync_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000139 RID: 313
			// (get) Token: 0x060003FE RID: 1022 RVA: 0x00011BE4 File Offset: 0x0000FDE4
			// (set) Token: 0x060003FF RID: 1023 RVA: 0x00003EBD File Offset: 0x000020BD
			public AsyncTaskMethodBuilder<Stream> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent._CreateContentReadStreamAsync_d__5.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Stream>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Stream>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent._CreateContentReadStreamAsync_d__5.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Stream>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700013A RID: 314
			// (get) Token: 0x06000400 RID: 1024 RVA: 0x00011C14 File Offset: 0x0000FE14
			// (set) Token: 0x06000401 RID: 1025 RVA: 0x00003EEB File Offset: 0x000020EB
			public unsafe StreamReplacingHttpContent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent._CreateContentReadStreamAsync_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamReplacingHttpContent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent._CreateContentReadStreamAsync_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013B RID: 315
			// (get) Token: 0x06000402 RID: 1026 RVA: 0x00011C44 File Offset: 0x0000FE44
			// (set) Token: 0x06000403 RID: 1027 RVA: 0x00003F0A File Offset: 0x0000210A
			public ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent._CreateContentReadStreamAsync_d__5.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent._CreateContentReadStreamAsync_d__5.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400028F RID: 655
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000290 RID: 656
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000291 RID: 657
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000292 RID: 658
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000293 RID: 659
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000294 RID: 660
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000066 RID: 102
		[ObfuscatedName("Google.Apis.Http.StreamReplacingHttpContent+<SerializeToStreamAsync>d__6")]
		public sealed class _SerializeToStreamAsync_d__6 : ValueType
		{
			// Token: 0x06000404 RID: 1028 RVA: 0x00011C74 File Offset: 0x0000FE74
			// Note: this type is marked as 'beforefieldinit'.
			static _SerializeToStreamAsync_d__6()
			{
				Il2CppClassPointerStore<StreamReplacingHttpContent._SerializeToStreamAsync_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StreamReplacingHttpContent>.NativeClassPtr, "<SerializeToStreamAsync>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamReplacingHttpContent._SerializeToStreamAsync_d__6>.NativeClassPtr);
				StreamReplacingHttpContent._SerializeToStreamAsync_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReplacingHttpContent._SerializeToStreamAsync_d__6>.NativeClassPtr, "<>1__state");
				StreamReplacingHttpContent._SerializeToStreamAsync_d__6.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReplacingHttpContent._SerializeToStreamAsync_d__6>.NativeClassPtr, "<>t__builder");
				StreamReplacingHttpContent._SerializeToStreamAsync_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReplacingHttpContent._SerializeToStreamAsync_d__6>.NativeClassPtr, "<>4__this");
				StreamReplacingHttpContent._SerializeToStreamAsync_d__6.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReplacingHttpContent._SerializeToStreamAsync_d__6>.NativeClassPtr, "stream");
				StreamReplacingHttpContent._SerializeToStreamAsync_d__6.NativeFieldInfoPtr__contentStream_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReplacingHttpContent._SerializeToStreamAsync_d__6>.NativeClassPtr, "<contentStream>5__2");
				StreamReplacingHttpContent._SerializeToStreamAsync_d__6.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReplacingHttpContent._SerializeToStreamAsync_d__6>.NativeClassPtr, "<>u__1");
				StreamReplacingHttpContent._SerializeToStreamAsync_d__6.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReplacingHttpContent._SerializeToStreamAsync_d__6>.NativeClassPtr, "<>u__2");
				StreamReplacingHttpContent._SerializeToStreamAsync_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReplacingHttpContent._SerializeToStreamAsync_d__6>.NativeClassPtr, 100663705);
				StreamReplacingHttpContent._SerializeToStreamAsync_d__6.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReplacingHttpContent._SerializeToStreamAsync_d__6>.NativeClassPtr, 100663706);
			}

			// Token: 0x06000405 RID: 1029 RVA: 0x00011D54 File Offset: 0x0000FF54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212798, XrefRangeEnd = 1212842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReplacingHttpContent._SerializeToStreamAsync_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000406 RID: 1030 RVA: 0x00011D8C File Offset: 0x0000FF8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212842, XrefRangeEnd = 1212846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReplacingHttpContent._SerializeToStreamAsync_d__6.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000407 RID: 1031 RVA: 0x00003F38 File Offset: 0x00002138
			public _SerializeToStreamAsync_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000408 RID: 1032 RVA: 0x00003F41 File Offset: 0x00002141
			public _SerializeToStreamAsync_d__6()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReplacingHttpContent._SerializeToStreamAsync_d__6>.NativeClassPtr))
			{
			}

			// Token: 0x1700013C RID: 316
			// (get) Token: 0x06000409 RID: 1033 RVA: 0x00011DD4 File Offset: 0x0000FFD4
			// (set) Token: 0x0600040A RID: 1034 RVA: 0x00003F53 File Offset: 0x00002153
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent._SerializeToStreamAsync_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent._SerializeToStreamAsync_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700013D RID: 317
			// (get) Token: 0x0600040B RID: 1035 RVA: 0x00011DFC File Offset: 0x0000FFFC
			// (set) Token: 0x0600040C RID: 1036 RVA: 0x00003F6E File Offset: 0x0000216E
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent._SerializeToStreamAsync_d__6.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent._SerializeToStreamAsync_d__6.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700013E RID: 318
			// (get) Token: 0x0600040D RID: 1037 RVA: 0x00011E2C File Offset: 0x0001002C
			// (set) Token: 0x0600040E RID: 1038 RVA: 0x00003F9C File Offset: 0x0000219C
			public unsafe StreamReplacingHttpContent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent._SerializeToStreamAsync_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamReplacingHttpContent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent._SerializeToStreamAsync_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013F RID: 319
			// (get) Token: 0x0600040F RID: 1039 RVA: 0x00011E5C File Offset: 0x0001005C
			// (set) Token: 0x06000410 RID: 1040 RVA: 0x00003FBB File Offset: 0x000021BB
			public unsafe Stream stream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent._SerializeToStreamAsync_d__6.NativeFieldInfoPtr_stream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent._SerializeToStreamAsync_d__6.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000140 RID: 320
			// (get) Token: 0x06000411 RID: 1041 RVA: 0x00011E8C File Offset: 0x0001008C
			// (set) Token: 0x06000412 RID: 1042 RVA: 0x00003FDA File Offset: 0x000021DA
			public unsafe Stream _contentStream_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent._SerializeToStreamAsync_d__6.NativeFieldInfoPtr__contentStream_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent._SerializeToStreamAsync_d__6.NativeFieldInfoPtr__contentStream_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000141 RID: 321
			// (get) Token: 0x06000413 RID: 1043 RVA: 0x00011EBC File Offset: 0x000100BC
			// (set) Token: 0x06000414 RID: 1044 RVA: 0x00003FF9 File Offset: 0x000021F9
			public ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent._SerializeToStreamAsync_d__6.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent._SerializeToStreamAsync_d__6.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000142 RID: 322
			// (get) Token: 0x06000415 RID: 1045 RVA: 0x00011EEC File Offset: 0x000100EC
			// (set) Token: 0x06000416 RID: 1046 RVA: 0x00004027 File Offset: 0x00002227
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent._SerializeToStreamAsync_d__6.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReplacingHttpContent._SerializeToStreamAsync_d__6.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000295 RID: 661
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000296 RID: 662
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000297 RID: 663
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000298 RID: 664
			private static readonly IntPtr NativeFieldInfoPtr_stream;

			// Token: 0x04000299 RID: 665
			private static readonly IntPtr NativeFieldInfoPtr__contentStream_5__2;

			// Token: 0x0400029A RID: 666
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400029B RID: 667
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400029C RID: 668
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400029D RID: 669
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
