using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net.Http
{
	// Token: 0x02000015 RID: 21
	public class StreamContent : HttpContent
	{
		// Token: 0x0600014B RID: 331 RVA: 0x000091FC File Offset: 0x000073FC
		// Note: this type is marked as 'beforefieldinit'.
		static StreamContent()
		{
			Il2CppClassPointerStore<StreamContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http", "StreamContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamContent>.NativeClassPtr);
			StreamContent.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamContent>.NativeClassPtr, "content");
			StreamContent.NativeFieldInfoPtr_bufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamContent>.NativeClassPtr, "bufferSize");
			StreamContent.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamContent>.NativeClassPtr, "cancellationToken");
			StreamContent.NativeFieldInfoPtr_startPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamContent>.NativeClassPtr, "startPosition");
			StreamContent.NativeFieldInfoPtr_contentCopied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamContent>.NativeClassPtr, "contentCopied");
			StreamContent.NativeMethodInfoPtr__ctor_Public_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamContent>.NativeClassPtr, 100663485);
			StreamContent.NativeMethodInfoPtr__ctor_Public_Void_Stream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamContent>.NativeClassPtr, 100663486);
			StreamContent.NativeMethodInfoPtr__ctor_Internal_Void_Stream_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamContent>.NativeClassPtr, 100663487);
			StreamContent.NativeMethodInfoPtr_CreateContentReadStreamAsync_Protected_Virtual_Task_1_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamContent>.NativeClassPtr, 100663488);
			StreamContent.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamContent>.NativeClassPtr, 100663489);
			StreamContent.NativeMethodInfoPtr_SerializeToStreamAsync_Protected_Virtual_Task_Stream_TransportContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamContent>.NativeClassPtr, 100663490);
			StreamContent.NativeMethodInfoPtr_TryComputeLength_FamOrAssem_Virtual_Boolean_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamContent>.NativeClassPtr, 100663491);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000931C File Offset: 0x0000751C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1172385, RefRangeEnd = 1172387, XrefRangeStart = 1172383, XrefRangeEnd = 1172385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamContent(Stream content)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamContent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamContent.NativeMethodInfoPtr__ctor_Public_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00009368 File Offset: 0x00007568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172387, XrefRangeEnd = 1172389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamContent(Stream content, int bufferSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamContent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamContent.NativeMethodInfoPtr__ctor_Public_Void_Stream_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000093C4 File Offset: 0x000075C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172389, XrefRangeEnd = 1172398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamContent(Stream content, CancellationToken cancellationToken)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamContent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamContent.NativeMethodInfoPtr__ctor_Internal_Void_Stream_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00009428 File Offset: 0x00007628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172398, XrefRangeEnd = 1172404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<Stream> CreateContentReadStreamAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamContent.NativeMethodInfoPtr_CreateContentReadStreamAsync_Protected_Virtual_Task_1_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Stream>>(intPtr3) : null;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00009474 File Offset: 0x00007674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172404, XrefRangeEnd = 1172406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamContent.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000094C0 File Offset: 0x000076C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172406, XrefRangeEnd = 1172407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamContent.NativeMethodInfoPtr_SerializeToStreamAsync_Protected_Virtual_Task_Stream_TransportContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00009530 File Offset: 0x00007730
		[CallerCount(0)]
		public unsafe override bool TryComputeLength(out long length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamContent.NativeMethodInfoPtr_TryComputeLength_FamOrAssem_Virtual_Boolean_byref_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002881 File Offset: 0x00000A81
		public StreamContent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00009584 File Offset: 0x00007784
		// (set) Token: 0x06000155 RID: 341 RVA: 0x0000288A File Offset: 0x00000A8A
		public unsafe Stream content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamContent.NativeFieldInfoPtr_content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamContent.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000156 RID: 342 RVA: 0x000095B4 File Offset: 0x000077B4
		// (set) Token: 0x06000157 RID: 343 RVA: 0x000028A9 File Offset: 0x00000AA9
		public unsafe int bufferSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamContent.NativeFieldInfoPtr_bufferSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamContent.NativeFieldInfoPtr_bufferSize)) = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000158 RID: 344 RVA: 0x000095DC File Offset: 0x000077DC
		// (set) Token: 0x06000159 RID: 345 RVA: 0x000028C4 File Offset: 0x00000AC4
		public CancellationToken cancellationToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamContent.NativeFieldInfoPtr_cancellationToken);
				return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamContent.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0000960C File Offset: 0x0000780C
		// (set) Token: 0x0600015B RID: 347 RVA: 0x000028F2 File Offset: 0x00000AF2
		public unsafe long startPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamContent.NativeFieldInfoPtr_startPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamContent.NativeFieldInfoPtr_startPosition)) = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00009634 File Offset: 0x00007834
		// (set) Token: 0x0600015D RID: 349 RVA: 0x0000290D File Offset: 0x00000B0D
		public unsafe bool contentCopied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamContent.NativeFieldInfoPtr_contentCopied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamContent.NativeFieldInfoPtr_contentCopied)) = value;
			}
		}

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeFieldInfoPtr_content;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeFieldInfoPtr_bufferSize;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeFieldInfoPtr_startPosition;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeFieldInfoPtr_contentCopied;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Int32_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stream_CancellationToken_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_CreateContentReadStreamAsync_Protected_Virtual_Task_1_Stream_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_SerializeToStreamAsync_Protected_Virtual_Task_Stream_TransportContext_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_TryComputeLength_FamOrAssem_Virtual_Boolean_byref_Int64_0;
	}
}
