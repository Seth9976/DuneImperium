using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Text;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.IO
{
	// Token: 0x0200052C RID: 1324
	[Serializable]
	public class StreamReader : TextReader
	{
		// Token: 0x06005089 RID: 20617 RVA: 0x00176C80 File Offset: 0x00174E80
		// Note: this type is marked as 'beforefieldinit'.
		static StreamReader()
		{
			Il2CppClassPointerStore<StreamReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "StreamReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamReader>.NativeClassPtr);
			StreamReader.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "Null");
			StreamReader.NativeFieldInfoPtr__stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_stream");
			StreamReader.NativeFieldInfoPtr__encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_encoding");
			StreamReader.NativeFieldInfoPtr__decoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_decoder");
			StreamReader.NativeFieldInfoPtr__byteBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_byteBuffer");
			StreamReader.NativeFieldInfoPtr__charBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_charBuffer");
			StreamReader.NativeFieldInfoPtr__charPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_charPos");
			StreamReader.NativeFieldInfoPtr__charLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_charLen");
			StreamReader.NativeFieldInfoPtr__byteLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_byteLen");
			StreamReader.NativeFieldInfoPtr__bytePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_bytePos");
			StreamReader.NativeFieldInfoPtr__maxCharsPerBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_maxCharsPerBuffer");
			StreamReader.NativeFieldInfoPtr__detectEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_detectEncoding");
			StreamReader.NativeFieldInfoPtr__checkPreamble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_checkPreamble");
			StreamReader.NativeFieldInfoPtr__isBlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_isBlocked");
			StreamReader.NativeFieldInfoPtr__closable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_closable");
			StreamReader.NativeFieldInfoPtr__asyncReadTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_asyncReadTask");
			StreamReader.NativeMethodInfoPtr_CheckAsyncTaskInProgress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675473);
			StreamReader.NativeMethodInfoPtr_ThrowAsyncIOInProgress_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675474);
			StreamReader.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675475);
			StreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675476);
			StreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675477);
			StreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675478);
			StreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675479);
			StreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675480);
			StreamReader.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675481);
			StreamReader.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675482);
			StreamReader.NativeMethodInfoPtr__ctor_Public_Void_String_Encoding_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675483);
			StreamReader.NativeMethodInfoPtr__ctor_Public_Void_String_Encoding_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675484);
			StreamReader.NativeMethodInfoPtr_Init_Private_Void_Stream_Encoding_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675485);
			StreamReader.NativeMethodInfoPtr_Init_Internal_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675486);
			StreamReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675487);
			StreamReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675488);
			StreamReader.NativeMethodInfoPtr_get_CurrentEncoding_Public_Virtual_New_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675489);
			StreamReader.NativeMethodInfoPtr_get_BaseStream_Public_Virtual_New_get_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675490);
			StreamReader.NativeMethodInfoPtr_get_LeaveOpen_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675491);
			StreamReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675492);
			StreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675493);
			StreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675494);
			StreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Span_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675495);
			StreamReader.NativeMethodInfoPtr_ReadSpan_Private_Int32_Span_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675496);
			StreamReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675497);
			StreamReader.NativeMethodInfoPtr_ReadBlock_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675498);
			StreamReader.NativeMethodInfoPtr_CompressBuffer_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675499);
			StreamReader.NativeMethodInfoPtr_DetectEncoding_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675500);
			StreamReader.NativeMethodInfoPtr_IsPreamble_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675501);
			StreamReader.NativeMethodInfoPtr_ReadBuffer_Internal_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675502);
			StreamReader.NativeMethodInfoPtr_ReadBuffer_Private_Int32_Span_1_Char_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675503);
			StreamReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675504);
			StreamReader.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675505);
			StreamReader.NativeMethodInfoPtr_ReadAsyncInternal_Internal_Virtual_ValueTask_1_Int32_Memory_1_Char_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675506);
			StreamReader.NativeMethodInfoPtr_ReadBufferAsync_Private_Task_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675507);
			StreamReader.NativeMethodInfoPtr_DataAvailable_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100675508);
		}

		// Token: 0x0600508A RID: 20618 RVA: 0x001770C0 File Offset: 0x001752C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1428307, RefRangeEnd = 1428309, XrefRangeStart = 1428305, XrefRangeEnd = 1428307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAsyncTaskInProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_CheckAsyncTaskInProgress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600508B RID: 20619 RVA: 0x001770F4 File Offset: 0x001752F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1428342, RefRangeEnd = 1428343, XrefRangeStart = 1428309, XrefRangeEnd = 1428342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowAsyncIOInProgress()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_ThrowAsyncIOInProgress_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600508C RID: 20620 RVA: 0x0017711C File Offset: 0x0017531C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428343, XrefRangeEnd = 1428355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600508D RID: 20621 RVA: 0x00177158 File Offset: 0x00175358
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1428357, RefRangeEnd = 1428360, XrefRangeStart = 1428355, XrefRangeEnd = 1428357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader(Stream stream)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600508E RID: 20622 RVA: 0x001771A4 File Offset: 0x001753A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428360, XrefRangeEnd = 1428362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader(Stream stream, bool detectEncodingFromByteOrderMarks)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref detectEncodingFromByteOrderMarks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600508F RID: 20623 RVA: 0x00177200 File Offset: 0x00175400
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1428363, RefRangeEnd = 1428366, XrefRangeStart = 1428362, XrefRangeEnd = 1428363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader(Stream stream, Encoding encoding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005090 RID: 20624 RVA: 0x00177260 File Offset: 0x00175460
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1428367, RefRangeEnd = 1428369, XrefRangeStart = 1428366, XrefRangeEnd = 1428367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref detectEncodingFromByteOrderMarks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005091 RID: 20625 RVA: 0x001772CC File Offset: 0x001754CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1428401, RefRangeEnd = 1428405, XrefRangeStart = 1428369, XrefRangeEnd = 1428401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref detectEncodingFromByteOrderMarks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005092 RID: 20626 RVA: 0x00177354 File Offset: 0x00175554
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1428407, RefRangeEnd = 1428411, XrefRangeStart = 1428405, XrefRangeEnd = 1428407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader(string path)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005093 RID: 20627 RVA: 0x001773A0 File Offset: 0x001755A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428411, XrefRangeEnd = 1428413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader(string path, bool detectEncodingFromByteOrderMarks)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref detectEncodingFromByteOrderMarks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005094 RID: 20628 RVA: 0x001773FC File Offset: 0x001755FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1428414, RefRangeEnd = 1428416, XrefRangeStart = 1428413, XrefRangeEnd = 1428414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref detectEncodingFromByteOrderMarks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Public_Void_String_Encoding_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005095 RID: 20629 RVA: 0x00177468 File Offset: 0x00175668
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1428433, RefRangeEnd = 1428436, XrefRangeStart = 1428416, XrefRangeEnd = 1428433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref detectEncodingFromByteOrderMarks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Public_Void_String_Encoding_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005096 RID: 20630 RVA: 0x001774E4 File Offset: 0x001756E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1428448, RefRangeEnd = 1428450, XrefRangeStart = 1428436, XrefRangeEnd = 1428448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref detectEncodingFromByteOrderMarks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_Init_Private_Void_Stream_Encoding_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005097 RID: 20631 RVA: 0x00177564 File Offset: 0x00175764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428450, XrefRangeEnd = 1428451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(Stream stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_Init_Internal_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005098 RID: 20632 RVA: 0x001775A8 File Offset: 0x001757A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 862874, RefRangeEnd = 862879, XrefRangeStart = 862874, XrefRangeEnd = 862879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005099 RID: 20633 RVA: 0x001775E4 File Offset: 0x001757E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428451, XrefRangeEnd = 1428454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x0600509A RID: 20634 RVA: 0x00177630 File Offset: 0x00175830
		public unsafe virtual Encoding CurrentEncoding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_get_CurrentEncoding_Public_Virtual_New_get_Encoding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x0600509B RID: 20635 RVA: 0x0017767C File Offset: 0x0017587C
		public unsafe virtual Stream BaseStream
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_get_BaseStream_Public_Virtual_New_get_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x0600509C RID: 20636 RVA: 0x001776C8 File Offset: 0x001758C8
		public unsafe bool LeaveOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_get_LeaveOpen_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600509D RID: 20637 RVA: 0x00177704 File Offset: 0x00175904
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1428456, RefRangeEnd = 1428458, XrefRangeStart = 1428454, XrefRangeEnd = 1428456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600509E RID: 20638 RVA: 0x0017774C File Offset: 0x0017594C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1428460, RefRangeEnd = 1428462, XrefRangeStart = 1428458, XrefRangeEnd = 1428460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600509F RID: 20639 RVA: 0x00177794 File Offset: 0x00175994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428462, XrefRangeEnd = 1428465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read(Il2CppStructArray<char> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060050A0 RID: 20640 RVA: 0x00177808 File Offset: 0x00175A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428465, XrefRangeEnd = 1428476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read(Span<char> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Span_1_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060050A1 RID: 20641 RVA: 0x00177868 File Offset: 0x00175A68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1428492, RefRangeEnd = 1428494, XrefRangeStart = 1428476, XrefRangeEnd = 1428492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadSpan(Span<char> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_ReadSpan_Private_Int32_Span_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060050A2 RID: 20642 RVA: 0x001778BC File Offset: 0x00175ABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1428511, RefRangeEnd = 1428512, XrefRangeStart = 1428494, XrefRangeEnd = 1428511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ReadToEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060050A3 RID: 20643 RVA: 0x00177900 File Offset: 0x00175B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428512, XrefRangeEnd = 1428540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ReadBlock(Il2CppStructArray<char> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_ReadBlock_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060050A4 RID: 20644 RVA: 0x00177974 File Offset: 0x00175B74
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1428541, RefRangeEnd = 1428550, XrefRangeStart = 1428540, XrefRangeEnd = 1428541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompressBuffer(int n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_CompressBuffer_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060050A5 RID: 20645 RVA: 0x001779B4 File Offset: 0x00175BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428550, XrefRangeEnd = 1428572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DetectEncoding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_DetectEncoding_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050A6 RID: 20646 RVA: 0x001779E8 File Offset: 0x00175BE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1428574, RefRangeEnd = 1428577, XrefRangeStart = 1428572, XrefRangeEnd = 1428574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPreamble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_IsPreamble_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060050A7 RID: 20647 RVA: 0x00177A24 File Offset: 0x00175C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428577, XrefRangeEnd = 1428602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int ReadBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_ReadBuffer_Internal_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060050A8 RID: 20648 RVA: 0x00177A6C File Offset: 0x00175C6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1428605, RefRangeEnd = 1428606, XrefRangeStart = 1428602, XrefRangeEnd = 1428605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadBuffer(Span<char> userBuffer, out bool readToUserBuffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(userBuffer));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &readToUserBuffer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_ReadBuffer_Private_Int32_Span_1_Char_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060050A9 RID: 20649 RVA: 0x00177ACC File Offset: 0x00175CCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1428609, RefRangeEnd = 1428610, XrefRangeStart = 1428606, XrefRangeEnd = 1428609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ReadLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060050AA RID: 20650 RVA: 0x00177B10 File Offset: 0x00175D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428610, XrefRangeEnd = 1428626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<int> ReadAsync(Il2CppStructArray<char> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x060050AB RID: 20651 RVA: 0x00177B88 File Offset: 0x00175D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428626, XrefRangeEnd = 1428643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ValueTask<int> ReadAsyncInternal(Memory<char> buffer, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_ReadAsyncInternal_Internal_Virtual_ValueTask_1_Int32_Memory_1_Char_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTask<int>(intPtr);
		}

		// Token: 0x060050AC RID: 20652 RVA: 0x00177BF8 File Offset: 0x00175DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428643, XrefRangeEnd = 1428657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<int> ReadBufferAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_ReadBufferAsync_Private_Task_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x060050AD RID: 20653 RVA: 0x00177C38 File Offset: 0x00175E38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1428657, RefRangeEnd = 1428660, XrefRangeStart = 1428657, XrefRangeEnd = 1428657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DataAvailable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_DataAvailable_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060050AE RID: 20654 RVA: 0x0001CC70 File Offset: 0x0001AE70
		public StreamReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x060050AF RID: 20655 RVA: 0x00177C74 File Offset: 0x00175E74
		// (set) Token: 0x060050B0 RID: 20656 RVA: 0x0001CC79 File Offset: 0x0001AE79
		public new unsafe static StreamReader Null
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StreamReader.NativeFieldInfoPtr_Null, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamReader>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StreamReader.NativeFieldInfoPtr_Null, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x060050B1 RID: 20657 RVA: 0x00177C9C File Offset: 0x00175E9C
		// (set) Token: 0x060050B2 RID: 20658 RVA: 0x0001CC8B File Offset: 0x0001AE8B
		public unsafe Stream _stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x060050B3 RID: 20659 RVA: 0x00177CCC File Offset: 0x00175ECC
		// (set) Token: 0x060050B4 RID: 20660 RVA: 0x0001CCAA File Offset: 0x0001AEAA
		public unsafe Encoding _encoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__encoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x060050B5 RID: 20661 RVA: 0x00177CFC File Offset: 0x00175EFC
		// (set) Token: 0x060050B6 RID: 20662 RVA: 0x0001CCC9 File Offset: 0x0001AEC9
		public unsafe Decoder _decoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__decoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Decoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__decoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001485 RID: 5253
		// (get) Token: 0x060050B7 RID: 20663 RVA: 0x00177D2C File Offset: 0x00175F2C
		// (set) Token: 0x060050B8 RID: 20664 RVA: 0x0001CCE8 File Offset: 0x0001AEE8
		public unsafe Il2CppStructArray<byte> _byteBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__byteBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__byteBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001486 RID: 5254
		// (get) Token: 0x060050B9 RID: 20665 RVA: 0x00177D5C File Offset: 0x00175F5C
		// (set) Token: 0x060050BA RID: 20666 RVA: 0x0001CD07 File Offset: 0x0001AF07
		public unsafe Il2CppStructArray<char> _charBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__charBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__charBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001487 RID: 5255
		// (get) Token: 0x060050BB RID: 20667 RVA: 0x00177D8C File Offset: 0x00175F8C
		// (set) Token: 0x060050BC RID: 20668 RVA: 0x0001CD26 File Offset: 0x0001AF26
		public unsafe int _charPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__charPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__charPos)) = value;
			}
		}

		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x060050BD RID: 20669 RVA: 0x00177DB4 File Offset: 0x00175FB4
		// (set) Token: 0x060050BE RID: 20670 RVA: 0x0001CD41 File Offset: 0x0001AF41
		public unsafe int _charLen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__charLen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__charLen)) = value;
			}
		}

		// Token: 0x17001489 RID: 5257
		// (get) Token: 0x060050BF RID: 20671 RVA: 0x00177DDC File Offset: 0x00175FDC
		// (set) Token: 0x060050C0 RID: 20672 RVA: 0x0001CD5C File Offset: 0x0001AF5C
		public unsafe int _byteLen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__byteLen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__byteLen)) = value;
			}
		}

		// Token: 0x1700148A RID: 5258
		// (get) Token: 0x060050C1 RID: 20673 RVA: 0x00177E04 File Offset: 0x00176004
		// (set) Token: 0x060050C2 RID: 20674 RVA: 0x0001CD77 File Offset: 0x0001AF77
		public unsafe int _bytePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__bytePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__bytePos)) = value;
			}
		}

		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x060050C3 RID: 20675 RVA: 0x00177E2C File Offset: 0x0017602C
		// (set) Token: 0x060050C4 RID: 20676 RVA: 0x0001CD92 File Offset: 0x0001AF92
		public unsafe int _maxCharsPerBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__maxCharsPerBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__maxCharsPerBuffer)) = value;
			}
		}

		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x060050C5 RID: 20677 RVA: 0x00177E54 File Offset: 0x00176054
		// (set) Token: 0x060050C6 RID: 20678 RVA: 0x0001CDAD File Offset: 0x0001AFAD
		public unsafe bool _detectEncoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__detectEncoding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__detectEncoding)) = value;
			}
		}

		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x060050C7 RID: 20679 RVA: 0x00177E7C File Offset: 0x0017607C
		// (set) Token: 0x060050C8 RID: 20680 RVA: 0x0001CDC8 File Offset: 0x0001AFC8
		public unsafe bool _checkPreamble
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__checkPreamble);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__checkPreamble)) = value;
			}
		}

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x060050C9 RID: 20681 RVA: 0x00177EA4 File Offset: 0x001760A4
		// (set) Token: 0x060050CA RID: 20682 RVA: 0x0001CDE3 File Offset: 0x0001AFE3
		public unsafe bool _isBlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__isBlocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__isBlocked)) = value;
			}
		}

		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x060050CB RID: 20683 RVA: 0x00177ECC File Offset: 0x001760CC
		// (set) Token: 0x060050CC RID: 20684 RVA: 0x0001CDFE File Offset: 0x0001AFFE
		public unsafe bool _closable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__closable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__closable)) = value;
			}
		}

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x060050CD RID: 20685 RVA: 0x00177EF4 File Offset: 0x001760F4
		// (set) Token: 0x060050CE RID: 20686 RVA: 0x0001CE19 File Offset: 0x0001B019
		public unsafe Task _asyncReadTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__asyncReadTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__asyncReadTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040041B8 RID: 16824
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x040041B9 RID: 16825
		private static readonly IntPtr NativeFieldInfoPtr__stream;

		// Token: 0x040041BA RID: 16826
		private static readonly IntPtr NativeFieldInfoPtr__encoding;

		// Token: 0x040041BB RID: 16827
		private static readonly IntPtr NativeFieldInfoPtr__decoder;

		// Token: 0x040041BC RID: 16828
		private static readonly IntPtr NativeFieldInfoPtr__byteBuffer;

		// Token: 0x040041BD RID: 16829
		private static readonly IntPtr NativeFieldInfoPtr__charBuffer;

		// Token: 0x040041BE RID: 16830
		private static readonly IntPtr NativeFieldInfoPtr__charPos;

		// Token: 0x040041BF RID: 16831
		private static readonly IntPtr NativeFieldInfoPtr__charLen;

		// Token: 0x040041C0 RID: 16832
		private static readonly IntPtr NativeFieldInfoPtr__byteLen;

		// Token: 0x040041C1 RID: 16833
		private static readonly IntPtr NativeFieldInfoPtr__bytePos;

		// Token: 0x040041C2 RID: 16834
		private static readonly IntPtr NativeFieldInfoPtr__maxCharsPerBuffer;

		// Token: 0x040041C3 RID: 16835
		private static readonly IntPtr NativeFieldInfoPtr__detectEncoding;

		// Token: 0x040041C4 RID: 16836
		private static readonly IntPtr NativeFieldInfoPtr__checkPreamble;

		// Token: 0x040041C5 RID: 16837
		private static readonly IntPtr NativeFieldInfoPtr__isBlocked;

		// Token: 0x040041C6 RID: 16838
		private static readonly IntPtr NativeFieldInfoPtr__closable;

		// Token: 0x040041C7 RID: 16839
		private static readonly IntPtr NativeFieldInfoPtr__asyncReadTask;

		// Token: 0x040041C8 RID: 16840
		private static readonly IntPtr NativeMethodInfoPtr_CheckAsyncTaskInProgress_Private_Void_0;

		// Token: 0x040041C9 RID: 16841
		private static readonly IntPtr NativeMethodInfoPtr_ThrowAsyncIOInProgress_Private_Static_Void_0;

		// Token: 0x040041CA RID: 16842
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040041CB RID: 16843
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_0;

		// Token: 0x040041CC RID: 16844
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_0;

		// Token: 0x040041CD RID: 16845
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0;

		// Token: 0x040041CE RID: 16846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_0;

		// Token: 0x040041CF RID: 16847
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_Int32_Boolean_0;

		// Token: 0x040041D0 RID: 16848
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040041D1 RID: 16849
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x040041D2 RID: 16850
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Encoding_Boolean_0;

		// Token: 0x040041D3 RID: 16851
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Encoding_Boolean_Int32_0;

		// Token: 0x040041D4 RID: 16852
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_Stream_Encoding_Boolean_Int32_Boolean_0;

		// Token: 0x040041D5 RID: 16853
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_Stream_0;

		// Token: 0x040041D6 RID: 16854
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x040041D7 RID: 16855
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040041D8 RID: 16856
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentEncoding_Public_Virtual_New_get_Encoding_0;

		// Token: 0x040041D9 RID: 16857
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseStream_Public_Virtual_New_get_Stream_0;

		// Token: 0x040041DA RID: 16858
		private static readonly IntPtr NativeMethodInfoPtr_get_LeaveOpen_Internal_get_Boolean_0;

		// Token: 0x040041DB RID: 16859
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0;

		// Token: 0x040041DC RID: 16860
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_0;

		// Token: 0x040041DD RID: 16861
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040041DE RID: 16862
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Span_1_Char_0;

		// Token: 0x040041DF RID: 16863
		private static readonly IntPtr NativeMethodInfoPtr_ReadSpan_Private_Int32_Span_1_Char_0;

		// Token: 0x040041E0 RID: 16864
		private static readonly IntPtr NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0;

		// Token: 0x040041E1 RID: 16865
		private static readonly IntPtr NativeMethodInfoPtr_ReadBlock_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040041E2 RID: 16866
		private static readonly IntPtr NativeMethodInfoPtr_CompressBuffer_Private_Void_Int32_0;

		// Token: 0x040041E3 RID: 16867
		private static readonly IntPtr NativeMethodInfoPtr_DetectEncoding_Private_Void_0;

		// Token: 0x040041E4 RID: 16868
		private static readonly IntPtr NativeMethodInfoPtr_IsPreamble_Private_Boolean_0;

		// Token: 0x040041E5 RID: 16869
		private static readonly IntPtr NativeMethodInfoPtr_ReadBuffer_Internal_Virtual_New_Int32_0;

		// Token: 0x040041E6 RID: 16870
		private static readonly IntPtr NativeMethodInfoPtr_ReadBuffer_Private_Int32_Span_1_Char_byref_Boolean_0;

		// Token: 0x040041E7 RID: 16871
		private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0;

		// Token: 0x040041E8 RID: 16872
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040041E9 RID: 16873
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsyncInternal_Internal_Virtual_ValueTask_1_Int32_Memory_1_Char_CancellationToken_0;

		// Token: 0x040041EA RID: 16874
		private static readonly IntPtr NativeMethodInfoPtr_ReadBufferAsync_Private_Task_1_Int32_0;

		// Token: 0x040041EB RID: 16875
		private static readonly IntPtr NativeMethodInfoPtr_DataAvailable_Internal_Boolean_0;

		// Token: 0x02000715 RID: 1813
		public class NullStreamReader : StreamReader
		{
			// Token: 0x06006022 RID: 24610 RVA: 0x001B1EA0 File Offset: 0x001B00A0
			// Note: this type is marked as 'beforefieldinit'.
			static NullStreamReader()
			{
				Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "NullStreamReader");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr);
				StreamReader.NullStreamReader.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100675510);
				StreamReader.NullStreamReader.NativeMethodInfoPtr_get_BaseStream_Public_Virtual_get_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100675511);
				StreamReader.NullStreamReader.NativeMethodInfoPtr_get_CurrentEncoding_Public_Virtual_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100675512);
				StreamReader.NullStreamReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100675513);
				StreamReader.NullStreamReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100675514);
				StreamReader.NullStreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100675515);
				StreamReader.NullStreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100675516);
				StreamReader.NullStreamReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100675517);
				StreamReader.NullStreamReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100675518);
				StreamReader.NullStreamReader.NativeMethodInfoPtr_ReadBuffer_Internal_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100675519);
			}

			// Token: 0x06006023 RID: 24611 RVA: 0x001B1F94 File Offset: 0x001B0194
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428008, XrefRangeEnd = 1428028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NullStreamReader()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NullStreamReader.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018DD RID: 6365
			// (get) Token: 0x06006024 RID: 24612 RVA: 0x001B1FD0 File Offset: 0x001B01D0
			public unsafe override Stream BaseStream
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428028, XrefRangeEnd = 1428032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NullStreamReader.NativeMethodInfoPtr_get_BaseStream_Public_Virtual_get_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
				}
			}

			// Token: 0x170018DE RID: 6366
			// (get) Token: 0x06006025 RID: 24613 RVA: 0x001B201C File Offset: 0x001B021C
			public unsafe override Encoding CurrentEncoding
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428032, XrefRangeEnd = 1428033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NullStreamReader.NativeMethodInfoPtr_get_CurrentEncoding_Public_Virtual_get_Encoding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
				}
			}

			// Token: 0x06006026 RID: 24614 RVA: 0x001B2068 File Offset: 0x001B0268
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Dispose(bool disposing)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref disposing;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NullStreamReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006027 RID: 24615 RVA: 0x001B20B4 File Offset: 0x001B02B4
			[CallerCount(0)]
			public unsafe override int Peek()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NullStreamReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006028 RID: 24616 RVA: 0x001B20FC File Offset: 0x001B02FC
			[CallerCount(0)]
			public unsafe override int Read()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NullStreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006029 RID: 24617 RVA: 0x001B2144 File Offset: 0x001B0344
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Read(Il2CppStructArray<char> buffer, int index, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NullStreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600602A RID: 24618 RVA: 0x001B21B8 File Offset: 0x001B03B8
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ReadLine()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NullStreamReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600602B RID: 24619 RVA: 0x001B21FC File Offset: 0x001B03FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428033, XrefRangeEnd = 1428035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ReadToEnd()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NullStreamReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600602C RID: 24620 RVA: 0x001B2240 File Offset: 0x001B0440
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int ReadBuffer()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NullStreamReader.NativeMethodInfoPtr_ReadBuffer_Internal_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600602D RID: 24621 RVA: 0x0002321F File Offset: 0x0002141F
			public NullStreamReader(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04004E16 RID: 19990
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x04004E17 RID: 19991
			private static readonly IntPtr NativeMethodInfoPtr_get_BaseStream_Public_Virtual_get_Stream_0;

			// Token: 0x04004E18 RID: 19992
			private static readonly IntPtr NativeMethodInfoPtr_get_CurrentEncoding_Public_Virtual_get_Encoding_0;

			// Token: 0x04004E19 RID: 19993
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

			// Token: 0x04004E1A RID: 19994
			private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0;

			// Token: 0x04004E1B RID: 19995
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_0;

			// Token: 0x04004E1C RID: 19996
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x04004E1D RID: 19997
			private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0;

			// Token: 0x04004E1E RID: 19998
			private static readonly IntPtr NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0;

			// Token: 0x04004E1F RID: 19999
			private static readonly IntPtr NativeMethodInfoPtr_ReadBuffer_Internal_Virtual_Int32_0;
		}

		// Token: 0x02000716 RID: 1814
		[ObfuscatedName("System.IO.StreamReader+<ReadAsyncInternal>d__66")]
		public sealed class _ReadAsyncInternal_d__66 : ValueType
		{
			// Token: 0x0600602E RID: 24622 RVA: 0x001B2288 File Offset: 0x001B0488
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadAsyncInternal_d__66()
			{
				Il2CppClassPointerStore<StreamReader._ReadAsyncInternal_d__66>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "<ReadAsyncInternal>d__66");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamReader._ReadAsyncInternal_d__66>.NativeClassPtr);
				StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader._ReadAsyncInternal_d__66>.NativeClassPtr, "<>1__state");
				StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader._ReadAsyncInternal_d__66>.NativeClassPtr, "<>t__builder");
				StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader._ReadAsyncInternal_d__66>.NativeClassPtr, "<>4__this");
				StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader._ReadAsyncInternal_d__66>.NativeClassPtr, "buffer");
				StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader._ReadAsyncInternal_d__66>.NativeClassPtr, "cancellationToken");
				StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr__charsRead_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader._ReadAsyncInternal_d__66>.NativeClassPtr, "<charsRead>5__2");
				StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr__readToUserBuffer_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader._ReadAsyncInternal_d__66>.NativeClassPtr, "<readToUserBuffer>5__3");
				StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr__tmpByteBuffer_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader._ReadAsyncInternal_d__66>.NativeClassPtr, "<tmpByteBuffer>5__4");
				StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr__tmpStream_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader._ReadAsyncInternal_d__66>.NativeClassPtr, "<tmpStream>5__5");
				StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr__count_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader._ReadAsyncInternal_d__66>.NativeClassPtr, "<count>5__6");
				StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader._ReadAsyncInternal_d__66>.NativeClassPtr, "<>u__1");
				StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr__n_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader._ReadAsyncInternal_d__66>.NativeClassPtr, "<n>5__7");
				StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader._ReadAsyncInternal_d__66>.NativeClassPtr, "<>u__2");
				StreamReader._ReadAsyncInternal_d__66.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader._ReadAsyncInternal_d__66>.NativeClassPtr, 100675520);
				StreamReader._ReadAsyncInternal_d__66.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader._ReadAsyncInternal_d__66>.NativeClassPtr, 100675521);
			}

			// Token: 0x0600602F RID: 24623 RVA: 0x001B23E0 File Offset: 0x001B05E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428035, XrefRangeEnd = 1428182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader._ReadAsyncInternal_d__66.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006030 RID: 24624 RVA: 0x001B2418 File Offset: 0x001B0618
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428182, XrefRangeEnd = 1428185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader._ReadAsyncInternal_d__66.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006031 RID: 24625 RVA: 0x00023228 File Offset: 0x00021428
			public _ReadAsyncInternal_d__66(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06006032 RID: 24626 RVA: 0x00023231 File Offset: 0x00021431
			public _ReadAsyncInternal_d__66()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader._ReadAsyncInternal_d__66>.NativeClassPtr))
			{
			}

			// Token: 0x170018DF RID: 6367
			// (get) Token: 0x06006033 RID: 24627 RVA: 0x001B2460 File Offset: 0x001B0660
			// (set) Token: 0x06006034 RID: 24628 RVA: 0x00023243 File Offset: 0x00021443
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170018E0 RID: 6368
			// (get) Token: 0x06006035 RID: 24629 RVA: 0x001B2488 File Offset: 0x001B0688
			// (set) Token: 0x06006036 RID: 24630 RVA: 0x0002325E File Offset: 0x0002145E
			public AsyncValueTaskMethodBuilder<int> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr___t__builder);
					return new AsyncValueTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170018E1 RID: 6369
			// (get) Token: 0x06006037 RID: 24631 RVA: 0x001B24B8 File Offset: 0x001B06B8
			// (set) Token: 0x06006038 RID: 24632 RVA: 0x0002328C File Offset: 0x0002148C
			public unsafe StreamReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018E2 RID: 6370
			// (get) Token: 0x06006039 RID: 24633 RVA: 0x001B24E8 File Offset: 0x001B06E8
			// (set) Token: 0x0600603A RID: 24634 RVA: 0x000232AB File Offset: 0x000214AB
			public Memory<char> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr_buffer);
					return new Memory<char>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Memory<char>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr_buffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Memory<char>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170018E3 RID: 6371
			// (get) Token: 0x0600603B RID: 24635 RVA: 0x001B2518 File Offset: 0x001B0718
			// (set) Token: 0x0600603C RID: 24636 RVA: 0x000232D9 File Offset: 0x000214D9
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170018E4 RID: 6372
			// (get) Token: 0x0600603D RID: 24637 RVA: 0x001B2548 File Offset: 0x001B0748
			// (set) Token: 0x0600603E RID: 24638 RVA: 0x00023307 File Offset: 0x00021507
			public unsafe int _charsRead_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr__charsRead_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr__charsRead_5__2)) = value;
				}
			}

			// Token: 0x170018E5 RID: 6373
			// (get) Token: 0x0600603F RID: 24639 RVA: 0x001B2570 File Offset: 0x001B0770
			// (set) Token: 0x06006040 RID: 24640 RVA: 0x00023322 File Offset: 0x00021522
			public unsafe bool _readToUserBuffer_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr__readToUserBuffer_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr__readToUserBuffer_5__3)) = value;
				}
			}

			// Token: 0x170018E6 RID: 6374
			// (get) Token: 0x06006041 RID: 24641 RVA: 0x001B2598 File Offset: 0x001B0798
			// (set) Token: 0x06006042 RID: 24642 RVA: 0x0002333D File Offset: 0x0002153D
			public unsafe Il2CppStructArray<byte> _tmpByteBuffer_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr__tmpByteBuffer_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr__tmpByteBuffer_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018E7 RID: 6375
			// (get) Token: 0x06006043 RID: 24643 RVA: 0x001B25C8 File Offset: 0x001B07C8
			// (set) Token: 0x06006044 RID: 24644 RVA: 0x0002335C File Offset: 0x0002155C
			public unsafe Stream _tmpStream_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr__tmpStream_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr__tmpStream_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018E8 RID: 6376
			// (get) Token: 0x06006045 RID: 24645 RVA: 0x001B25F8 File Offset: 0x001B07F8
			// (set) Token: 0x06006046 RID: 24646 RVA: 0x0002337B File Offset: 0x0002157B
			public unsafe int _count_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr__count_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr__count_5__6)) = value;
				}
			}

			// Token: 0x170018E9 RID: 6377
			// (get) Token: 0x06006047 RID: 24647 RVA: 0x001B2620 File Offset: 0x001B0820
			// (set) Token: 0x06006048 RID: 24648 RVA: 0x00023396 File Offset: 0x00021596
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170018EA RID: 6378
			// (get) Token: 0x06006049 RID: 24649 RVA: 0x001B2650 File Offset: 0x001B0850
			// (set) Token: 0x0600604A RID: 24650 RVA: 0x000233C4 File Offset: 0x000215C4
			public unsafe int _n_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr__n_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr__n_5__7)) = value;
				}
			}

			// Token: 0x170018EB RID: 6379
			// (get) Token: 0x0600604B RID: 24651 RVA: 0x001B2678 File Offset: 0x001B0878
			// (set) Token: 0x0600604C RID: 24652 RVA: 0x000233DF File Offset: 0x000215DF
			public ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr___u__2);
					return new ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadAsyncInternal_d__66.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04004E20 RID: 20000
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004E21 RID: 20001
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04004E22 RID: 20002
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004E23 RID: 20003
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x04004E24 RID: 20004
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04004E25 RID: 20005
			private static readonly IntPtr NativeFieldInfoPtr__charsRead_5__2;

			// Token: 0x04004E26 RID: 20006
			private static readonly IntPtr NativeFieldInfoPtr__readToUserBuffer_5__3;

			// Token: 0x04004E27 RID: 20007
			private static readonly IntPtr NativeFieldInfoPtr__tmpByteBuffer_5__4;

			// Token: 0x04004E28 RID: 20008
			private static readonly IntPtr NativeFieldInfoPtr__tmpStream_5__5;

			// Token: 0x04004E29 RID: 20009
			private static readonly IntPtr NativeFieldInfoPtr__count_5__6;

			// Token: 0x04004E2A RID: 20010
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04004E2B RID: 20011
			private static readonly IntPtr NativeFieldInfoPtr__n_5__7;

			// Token: 0x04004E2C RID: 20012
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04004E2D RID: 20013
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004E2E RID: 20014
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000717 RID: 1815
		[ObfuscatedName("System.IO.StreamReader+<ReadBufferAsync>d__69")]
		public sealed class _ReadBufferAsync_d__69 : ValueType
		{
			// Token: 0x0600604D RID: 24653 RVA: 0x001B26A8 File Offset: 0x001B08A8
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadBufferAsync_d__69()
			{
				Il2CppClassPointerStore<StreamReader._ReadBufferAsync_d__69>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "<ReadBufferAsync>d__69");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamReader._ReadBufferAsync_d__69>.NativeClassPtr);
				StreamReader._ReadBufferAsync_d__69.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader._ReadBufferAsync_d__69>.NativeClassPtr, "<>1__state");
				StreamReader._ReadBufferAsync_d__69.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader._ReadBufferAsync_d__69>.NativeClassPtr, "<>t__builder");
				StreamReader._ReadBufferAsync_d__69.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader._ReadBufferAsync_d__69>.NativeClassPtr, "<>4__this");
				StreamReader._ReadBufferAsync_d__69.NativeFieldInfoPtr__tmpByteBuffer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader._ReadBufferAsync_d__69>.NativeClassPtr, "<tmpByteBuffer>5__2");
				StreamReader._ReadBufferAsync_d__69.NativeFieldInfoPtr__tmpStream_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader._ReadBufferAsync_d__69>.NativeClassPtr, "<tmpStream>5__3");
				StreamReader._ReadBufferAsync_d__69.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader._ReadBufferAsync_d__69>.NativeClassPtr, "<>u__1");
				StreamReader._ReadBufferAsync_d__69.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader._ReadBufferAsync_d__69>.NativeClassPtr, 100675522);
				StreamReader._ReadBufferAsync_d__69.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader._ReadBufferAsync_d__69>.NativeClassPtr, 100675523);
			}

			// Token: 0x0600604E RID: 24654 RVA: 0x001B2774 File Offset: 0x001B0974
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428185, XrefRangeEnd = 1428299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader._ReadBufferAsync_d__69.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600604F RID: 24655 RVA: 0x001B27AC File Offset: 0x001B09AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428299, XrefRangeEnd = 1428305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader._ReadBufferAsync_d__69.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006050 RID: 24656 RVA: 0x0002340D File Offset: 0x0002160D
			public _ReadBufferAsync_d__69(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06006051 RID: 24657 RVA: 0x00023416 File Offset: 0x00021616
			public _ReadBufferAsync_d__69()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader._ReadBufferAsync_d__69>.NativeClassPtr))
			{
			}

			// Token: 0x170018EC RID: 6380
			// (get) Token: 0x06006052 RID: 24658 RVA: 0x001B27F4 File Offset: 0x001B09F4
			// (set) Token: 0x06006053 RID: 24659 RVA: 0x00023428 File Offset: 0x00021628
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadBufferAsync_d__69.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadBufferAsync_d__69.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170018ED RID: 6381
			// (get) Token: 0x06006054 RID: 24660 RVA: 0x001B281C File Offset: 0x001B0A1C
			// (set) Token: 0x06006055 RID: 24661 RVA: 0x00023443 File Offset: 0x00021643
			public AsyncTaskMethodBuilder<int> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadBufferAsync_d__69.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadBufferAsync_d__69.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170018EE RID: 6382
			// (get) Token: 0x06006056 RID: 24662 RVA: 0x001B284C File Offset: 0x001B0A4C
			// (set) Token: 0x06006057 RID: 24663 RVA: 0x00023471 File Offset: 0x00021671
			public unsafe StreamReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadBufferAsync_d__69.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadBufferAsync_d__69.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018EF RID: 6383
			// (get) Token: 0x06006058 RID: 24664 RVA: 0x001B287C File Offset: 0x001B0A7C
			// (set) Token: 0x06006059 RID: 24665 RVA: 0x00023490 File Offset: 0x00021690
			public unsafe Il2CppStructArray<byte> _tmpByteBuffer_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadBufferAsync_d__69.NativeFieldInfoPtr__tmpByteBuffer_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadBufferAsync_d__69.NativeFieldInfoPtr__tmpByteBuffer_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018F0 RID: 6384
			// (get) Token: 0x0600605A RID: 24666 RVA: 0x001B28AC File Offset: 0x001B0AAC
			// (set) Token: 0x0600605B RID: 24667 RVA: 0x000234AF File Offset: 0x000216AF
			public unsafe Stream _tmpStream_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadBufferAsync_d__69.NativeFieldInfoPtr__tmpStream_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadBufferAsync_d__69.NativeFieldInfoPtr__tmpStream_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018F1 RID: 6385
			// (get) Token: 0x0600605C RID: 24668 RVA: 0x001B28DC File Offset: 0x001B0ADC
			// (set) Token: 0x0600605D RID: 24669 RVA: 0x000234CE File Offset: 0x000216CE
			public ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadBufferAsync_d__69.NativeFieldInfoPtr___u__1);
					return new ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader._ReadBufferAsync_d__69.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04004E2F RID: 20015
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004E30 RID: 20016
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04004E31 RID: 20017
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004E32 RID: 20018
			private static readonly IntPtr NativeFieldInfoPtr__tmpByteBuffer_5__2;

			// Token: 0x04004E33 RID: 20019
			private static readonly IntPtr NativeFieldInfoPtr__tmpStream_5__3;

			// Token: 0x04004E34 RID: 20020
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04004E35 RID: 20021
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004E36 RID: 20022
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
