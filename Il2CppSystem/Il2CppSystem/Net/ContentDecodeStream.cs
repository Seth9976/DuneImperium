using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x020001EF RID: 495
	public class ContentDecodeStream : WebReadStream
	{
		// Token: 0x06001EB7 RID: 7863 RVA: 0x0009368C File Offset: 0x0009188C
		// Note: this type is marked as 'beforefieldinit'.
		static ContentDecodeStream()
		{
			Il2CppClassPointerStore<ContentDecodeStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ContentDecodeStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContentDecodeStream>.NativeClassPtr);
			ContentDecodeStream.NativeFieldInfoPtr__OriginalInnerStream_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentDecodeStream>.NativeClassPtr, "<OriginalInnerStream>k__BackingField");
			ContentDecodeStream.NativeMethodInfoPtr_Create_Public_Static_ContentDecodeStream_WebOperation_Stream_Mode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentDecodeStream>.NativeClassPtr, 100667970);
			ContentDecodeStream.NativeMethodInfoPtr_get_OriginalInnerStream_Private_get_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentDecodeStream>.NativeClassPtr, 100667971);
			ContentDecodeStream.NativeMethodInfoPtr__ctor_Private_Void_WebOperation_Stream_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentDecodeStream>.NativeClassPtr, 100667972);
			ContentDecodeStream.NativeMethodInfoPtr_ProcessReadAsync_Protected_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentDecodeStream>.NativeClassPtr, 100667973);
			ContentDecodeStream.NativeMethodInfoPtr_FinishReading_Internal_Virtual_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentDecodeStream>.NativeClassPtr, 100667974);
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x00093734 File Offset: 0x00091934
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478906, RefRangeEnd = 478907, XrefRangeStart = 478892, XrefRangeEnd = 478906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ContentDecodeStream Create(WebOperation operation, Stream innerStream, ContentDecodeStream.Mode mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerStream);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentDecodeStream.NativeMethodInfoPtr_Create_Public_Static_ContentDecodeStream_WebOperation_Stream_Mode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContentDecodeStream>(intPtr3) : null;
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06001EB9 RID: 7865 RVA: 0x00093798 File Offset: 0x00091998
		public unsafe Stream OriginalInnerStream
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentDecodeStream.NativeMethodInfoPtr_get_OriginalInnerStream_Private_get_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x000937D8 File Offset: 0x000919D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 478789, RefRangeEnd = 478793, XrefRangeStart = 478789, XrefRangeEnd = 478793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContentDecodeStream(WebOperation operation, Stream decodeStream, Stream originalInnerStream)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContentDecodeStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decodeStream);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(originalInnerStream);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentDecodeStream.NativeMethodInfoPtr__ctor_Private_Void_WebOperation_Stream_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x00093848 File Offset: 0x00091A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentDecodeStream.NativeMethodInfoPtr_ProcessReadAsync_Protected_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x000938D8 File Offset: 0x00091AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478907, XrefRangeEnd = 478917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task FinishReading(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentDecodeStream.NativeMethodInfoPtr_FinishReading_Internal_Virtual_Task_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x0000D0F8 File Offset: 0x0000B2F8
		public ContentDecodeStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06001EBE RID: 7870 RVA: 0x00093938 File Offset: 0x00091B38
		// (set) Token: 0x06001EBF RID: 7871 RVA: 0x0000D101 File Offset: 0x0000B301
		public unsafe Stream _OriginalInnerStream_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentDecodeStream.NativeFieldInfoPtr__OriginalInnerStream_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentDecodeStream.NativeFieldInfoPtr__OriginalInnerStream_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001841 RID: 6209
		private static readonly IntPtr NativeFieldInfoPtr__OriginalInnerStream_k__BackingField;

		// Token: 0x04001842 RID: 6210
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ContentDecodeStream_WebOperation_Stream_Mode_0;

		// Token: 0x04001843 RID: 6211
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginalInnerStream_Private_get_Stream_0;

		// Token: 0x04001844 RID: 6212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_WebOperation_Stream_Stream_0;

		// Token: 0x04001845 RID: 6213
		private static readonly IntPtr NativeMethodInfoPtr_ProcessReadAsync_Protected_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04001846 RID: 6214
		private static readonly IntPtr NativeMethodInfoPtr_FinishReading_Internal_Virtual_Task_CancellationToken_0;

		// Token: 0x02000334 RID: 820
		public enum Mode
		{
			// Token: 0x0400252D RID: 9517
			GZip,
			// Token: 0x0400252E RID: 9518
			Deflate
		}
	}
}
