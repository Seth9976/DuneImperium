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
	// Token: 0x0200052D RID: 1325
	[Serializable]
	public class StreamWriter : TextWriter
	{
		// Token: 0x060050CF RID: 20687 RVA: 0x00177F24 File Offset: 0x00176124
		// Note: this type is marked as 'beforefieldinit'.
		static StreamWriter()
		{
			Il2CppClassPointerStore<StreamWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "StreamWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr);
			StreamWriter.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "Null");
			StreamWriter.NativeFieldInfoPtr__stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "_stream");
			StreamWriter.NativeFieldInfoPtr__encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "_encoding");
			StreamWriter.NativeFieldInfoPtr__encoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "_encoder");
			StreamWriter.NativeFieldInfoPtr__byteBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "_byteBuffer");
			StreamWriter.NativeFieldInfoPtr__charBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "_charBuffer");
			StreamWriter.NativeFieldInfoPtr__charPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "_charPos");
			StreamWriter.NativeFieldInfoPtr__charLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "_charLen");
			StreamWriter.NativeFieldInfoPtr__autoFlush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "_autoFlush");
			StreamWriter.NativeFieldInfoPtr__haveWrittenPreamble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "_haveWrittenPreamble");
			StreamWriter.NativeFieldInfoPtr__closable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "_closable");
			StreamWriter.NativeFieldInfoPtr__asyncWriteTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "_asyncWriteTask");
			StreamWriter.NativeMethodInfoPtr_CheckAsyncTaskInProgress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675524);
			StreamWriter.NativeMethodInfoPtr_ThrowAsyncIOInProgress_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675525);
			StreamWriter.NativeMethodInfoPtr_get_UTF8NoBOM_Private_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675526);
			StreamWriter.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675527);
			StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675528);
			StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675529);
			StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675530);
			StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675531);
			StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675532);
			StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675533);
			StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Encoding_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675534);
			StreamWriter.NativeMethodInfoPtr_Init_Private_Void_Stream_Encoding_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675535);
			StreamWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675536);
			StreamWriter.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675537);
			StreamWriter.NativeMethodInfoPtr_DisposeAsync_Public_Virtual_ValueTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675538);
			StreamWriter.NativeMethodInfoPtr_DisposeAsyncCore_Private_ValueTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675539);
			StreamWriter.NativeMethodInfoPtr_CloseStreamFromDispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675540);
			StreamWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675541);
			StreamWriter.NativeMethodInfoPtr_Flush_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675542);
			StreamWriter.NativeMethodInfoPtr_set_AutoFlush_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675543);
			StreamWriter.NativeMethodInfoPtr_get_BaseStream_Public_Virtual_New_get_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675544);
			StreamWriter.NativeMethodInfoPtr_get_LeaveOpen_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675545);
			StreamWriter.NativeMethodInfoPtr_get_Encoding_Public_Virtual_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675546);
			StreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675547);
			StreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675548);
			StreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675549);
			StreamWriter.NativeMethodInfoPtr_WriteSpan_Private_Void_ReadOnlySpan_1_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675550);
			StreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675551);
			StreamWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675552);
			StreamWriter.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675553);
			StreamWriter.NativeMethodInfoPtr_WriteAsyncInternal_Private_Static_Task_StreamWriter_Char_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Char_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675554);
			StreamWriter.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675555);
			StreamWriter.NativeMethodInfoPtr_WriteAsyncInternal_Private_Static_Task_StreamWriter_String_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Char_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675556);
			StreamWriter.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675557);
			StreamWriter.NativeMethodInfoPtr_WriteAsyncInternal_Private_Static_Task_StreamWriter_ReadOnlyMemory_1_Char_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Char_Boolean_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675558);
			StreamWriter.NativeMethodInfoPtr_FlushAsync_Public_Virtual_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675559);
			StreamWriter.NativeMethodInfoPtr_set_CharPos_Prop_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675560);
			StreamWriter.NativeMethodInfoPtr_set_HaveWrittenPreamble_Prop_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675561);
			StreamWriter.NativeMethodInfoPtr_FlushAsyncInternal_Private_Task_Boolean_Boolean_Il2CppStructArray_1_Char_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675562);
			StreamWriter.NativeMethodInfoPtr_FlushAsyncInternal_Private_Static_Task_StreamWriter_Boolean_Boolean_Il2CppStructArray_1_Char_Int32_Boolean_Encoding_Encoder_Il2CppStructArray_1_Byte_Stream_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100675563);
		}

		// Token: 0x060050D0 RID: 20688 RVA: 0x00178364 File Offset: 0x00176564
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1428861, RefRangeEnd = 1428862, XrefRangeStart = 1428859, XrefRangeEnd = 1428861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAsyncTaskInProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr_CheckAsyncTaskInProgress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050D1 RID: 20689 RVA: 0x00178398 File Offset: 0x00176598
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1428868, RefRangeEnd = 1428869, XrefRangeStart = 1428862, XrefRangeEnd = 1428868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowAsyncIOInProgress()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr_ThrowAsyncIOInProgress_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x060050D2 RID: 20690 RVA: 0x001783C0 File Offset: 0x001765C0
		public unsafe static Encoding UTF8NoBOM
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428869, XrefRangeEnd = 1428873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr_get_UTF8NoBOM_Private_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x060050D3 RID: 20691 RVA: 0x001783F4 File Offset: 0x001765F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428873, XrefRangeEnd = 1428885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamWriter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050D4 RID: 20692 RVA: 0x00178430 File Offset: 0x00176630
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1428893, RefRangeEnd = 1428898, XrefRangeStart = 1428885, XrefRangeEnd = 1428893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamWriter(Stream stream)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060050D5 RID: 20693 RVA: 0x0017847C File Offset: 0x0017667C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1428899, RefRangeEnd = 1428903, XrefRangeStart = 1428898, XrefRangeEnd = 1428899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamWriter(Stream stream, Encoding encoding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050D6 RID: 20694 RVA: 0x001784DC File Offset: 0x001766DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1428904, RefRangeEnd = 1428905, XrefRangeStart = 1428903, XrefRangeEnd = 1428904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamWriter(Stream stream, Encoding encoding, int bufferSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050D7 RID: 20695 RVA: 0x00178548 File Offset: 0x00176748
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1428937, RefRangeEnd = 1428942, XrefRangeStart = 1428905, XrefRangeEnd = 1428937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamWriter(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050D8 RID: 20696 RVA: 0x001785C4 File Offset: 0x001767C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1428950, RefRangeEnd = 1428952, XrefRangeStart = 1428942, XrefRangeEnd = 1428950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamWriter(string path)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060050D9 RID: 20697 RVA: 0x00178610 File Offset: 0x00176810
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1428960, RefRangeEnd = 1428963, XrefRangeStart = 1428952, XrefRangeEnd = 1428960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamWriter(string path, bool append)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref append;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050DA RID: 20698 RVA: 0x0017866C File Offset: 0x0017686C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1429005, RefRangeEnd = 1429007, XrefRangeStart = 1428963, XrefRangeEnd = 1429005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamWriter(string path, bool append, Encoding encoding, int bufferSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref append;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Encoding_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050DB RID: 20699 RVA: 0x001786E8 File Offset: 0x001768E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1429018, RefRangeEnd = 1429020, XrefRangeStart = 1429007, XrefRangeEnd = 1429018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(streamArg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encodingArg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldLeaveOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr_Init_Private_Void_Stream_Encoding_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050DC RID: 20700 RVA: 0x00178758 File Offset: 0x00176958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429020, XrefRangeEnd = 1429024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050DD RID: 20701 RVA: 0x00178794 File Offset: 0x00176994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429024, XrefRangeEnd = 1429030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamWriter.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060050DE RID: 20702 RVA: 0x001787E0 File Offset: 0x001769E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429030, XrefRangeEnd = 1429051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ValueTask DisposeAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamWriter.NativeMethodInfoPtr_DisposeAsync_Public_Virtual_ValueTask_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTask(intPtr);
		}

		// Token: 0x060050DF RID: 20703 RVA: 0x00178824 File Offset: 0x00176A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429051, XrefRangeEnd = 1429062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTask DisposeAsyncCore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr_DisposeAsyncCore_Private_ValueTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTask(intPtr);
		}

		// Token: 0x060050E0 RID: 20704 RVA: 0x0017885C File Offset: 0x00176A5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1429065, RefRangeEnd = 1429068, XrefRangeStart = 1429062, XrefRangeEnd = 1429065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseStreamFromDispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr_CloseStreamFromDispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060050E1 RID: 20705 RVA: 0x0017889C File Offset: 0x00176A9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1429075, RefRangeEnd = 1429076, XrefRangeStart = 1429068, XrefRangeEnd = 1429075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050E2 RID: 20706 RVA: 0x001788D8 File Offset: 0x00176AD8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1429077, RefRangeEnd = 1429085, XrefRangeStart = 1429076, XrefRangeEnd = 1429077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flush(bool flushStream, bool flushEncoder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flushStream;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flushEncoder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr_Flush_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170014A1 RID: 5281
		// (set) Token: 0x060050E3 RID: 20707 RVA: 0x00178924 File Offset: 0x00176B24
		public unsafe virtual bool AutoFlush
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429085, XrefRangeEnd = 1429088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamWriter.NativeMethodInfoPtr_set_AutoFlush_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x060050E4 RID: 20708 RVA: 0x00178970 File Offset: 0x00176B70
		public unsafe virtual Stream BaseStream
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamWriter.NativeMethodInfoPtr_get_BaseStream_Public_Virtual_New_get_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x060050E5 RID: 20709 RVA: 0x001789BC File Offset: 0x00176BBC
		public unsafe bool LeaveOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr_get_LeaveOpen_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x060050E6 RID: 20710 RVA: 0x001789F8 File Offset: 0x00176BF8
		public unsafe override Encoding Encoding
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamWriter.NativeMethodInfoPtr_get_Encoding_Public_Virtual_get_Encoding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x060050E7 RID: 20711 RVA: 0x00178A44 File Offset: 0x00176C44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1429092, RefRangeEnd = 1429094, XrefRangeStart = 1429088, XrefRangeEnd = 1429092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060050E8 RID: 20712 RVA: 0x00178A90 File Offset: 0x00176C90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1429098, RefRangeEnd = 1429099, XrefRangeStart = 1429094, XrefRangeEnd = 1429098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Il2CppStructArray<char> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060050E9 RID: 20713 RVA: 0x00178AE0 File Offset: 0x00176CE0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1429107, RefRangeEnd = 1429112, XrefRangeStart = 1429099, XrefRangeEnd = 1429107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Il2CppStructArray<char> buffer, int index, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050EA RID: 20714 RVA: 0x00178B4C File Offset: 0x00176D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429112, XrefRangeEnd = 1429128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSpan(ReadOnlySpan<char> buffer, bool appendNewLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appendNewLine;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr_WriteSpan_Private_Void_ReadOnlySpan_1_Char_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050EB RID: 20715 RVA: 0x00178BA4 File Offset: 0x00176DA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1429132, RefRangeEnd = 1429135, XrefRangeStart = 1429128, XrefRangeEnd = 1429132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060050EC RID: 20716 RVA: 0x00178BF4 File Offset: 0x00176DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429135, XrefRangeEnd = 1429141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteLine(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060050ED RID: 20717 RVA: 0x00178C44 File Offset: 0x00176E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429141, XrefRangeEnd = 1429167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task WriteAsync(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamWriter.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x060050EE RID: 20718 RVA: 0x00178C9C File Offset: 0x00176E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429167, XrefRangeEnd = 1429179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task WriteAsyncInternal(StreamWriter _this, char value, Il2CppStructArray<char> charBuffer, int charPos, int charLen, Il2CppStructArray<char> coreNewLine, bool autoFlush, bool appendNewLine)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_this);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charPos;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charLen;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coreNewLine);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoFlush;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appendNewLine;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr_WriteAsyncInternal_Private_Static_Task_StreamWriter_Char_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Char_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060050EF RID: 20719 RVA: 0x00178D4C File Offset: 0x00176F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429179, XrefRangeEnd = 1429195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task WriteAsync(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamWriter.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x060050F0 RID: 20720 RVA: 0x00178DA8 File Offset: 0x00176FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429195, XrefRangeEnd = 1429208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task WriteAsyncInternal(StreamWriter _this, string value, Il2CppStructArray<char> charBuffer, int charPos, int charLen, Il2CppStructArray<char> coreNewLine, bool autoFlush, bool appendNewLine)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_this);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charPos;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charLen;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coreNewLine);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoFlush;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appendNewLine;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr_WriteAsyncInternal_Private_Static_Task_StreamWriter_String_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Char_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060050F1 RID: 20721 RVA: 0x00178E5C File Offset: 0x0017705C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429208, XrefRangeEnd = 1429238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task WriteAsync(Il2CppStructArray<char> buffer, int index, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamWriter.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060050F2 RID: 20722 RVA: 0x00178ED4 File Offset: 0x001770D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429238, XrefRangeEnd = 1429252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task WriteAsyncInternal(StreamWriter _this, ReadOnlyMemory<char> source, Il2CppStructArray<char> charBuffer, int charPos, int charLen, Il2CppStructArray<char> coreNewLine, bool autoFlush, bool appendNewLine, CancellationToken cancellationToken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_this);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(source));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charPos;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charLen;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coreNewLine);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoFlush;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appendNewLine;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr_WriteAsyncInternal_Private_Static_Task_StreamWriter_ReadOnlyMemory_1_Char_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Char_Boolean_Boolean_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060050F3 RID: 20723 RVA: 0x00178FA8 File Offset: 0x001771A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429252, XrefRangeEnd = 1429264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task FlushAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamWriter.NativeMethodInfoPtr_FlushAsync_Public_Virtual_Task_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x170014A5 RID: 5285
		// (set) Token: 0x060050F4 RID: 20724 RVA: 0x00178FF4 File Offset: 0x001771F4
		public unsafe int CharPos_Prop
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 403849, RefRangeEnd = 403852, XrefRangeStart = 403849, XrefRangeEnd = 403852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr_set_CharPos_Prop_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014A6 RID: 5286
		// (set) Token: 0x060050F5 RID: 20725 RVA: 0x00179034 File Offset: 0x00177234
		public unsafe bool HaveWrittenPreamble_Prop
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr_set_HaveWrittenPreamble_Prop_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060050F6 RID: 20726 RVA: 0x00179074 File Offset: 0x00177274
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1429273, RefRangeEnd = 1429283, XrefRangeStart = 1429264, XrefRangeEnd = 1429273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task FlushAsyncInternal(bool flushStream, bool flushEncoder, Il2CppStructArray<char> sCharBuffer, int sCharPos, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flushStream;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flushEncoder;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sCharBuffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sCharPos;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr_FlushAsyncInternal_Private_Task_Boolean_Boolean_Il2CppStructArray_1_Char_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060050F7 RID: 20727 RVA: 0x00179108 File Offset: 0x00177308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429283, XrefRangeEnd = 1429299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task FlushAsyncInternal(StreamWriter _this, bool flushStream, bool flushEncoder, Il2CppStructArray<char> charBuffer, int charPos, bool haveWrittenPreamble, Encoding encoding, Encoder encoder, Il2CppStructArray<byte> byteBuffer, Stream stream, CancellationToken cancellationToken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_this);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flushStream;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flushEncoder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charPos;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref haveWrittenPreamble;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoder);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(byteBuffer);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr_FlushAsyncInternal_Private_Static_Task_StreamWriter_Boolean_Boolean_Il2CppStructArray_1_Char_Int32_Boolean_Encoding_Encoder_Il2CppStructArray_1_Byte_Stream_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060050F8 RID: 20728 RVA: 0x0001CE38 File Offset: 0x0001B038
		public StreamWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x060050F9 RID: 20729 RVA: 0x00179200 File Offset: 0x00177400
		// (set) Token: 0x060050FA RID: 20730 RVA: 0x0001CE41 File Offset: 0x0001B041
		public new unsafe static StreamWriter Null
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StreamWriter.NativeFieldInfoPtr_Null, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamWriter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StreamWriter.NativeFieldInfoPtr_Null, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x060050FB RID: 20731 RVA: 0x00179228 File Offset: 0x00177428
		// (set) Token: 0x060050FC RID: 20732 RVA: 0x0001CE53 File Offset: 0x0001B053
		public unsafe Stream _stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr__stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr__stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x060050FD RID: 20733 RVA: 0x00179258 File Offset: 0x00177458
		// (set) Token: 0x060050FE RID: 20734 RVA: 0x0001CE72 File Offset: 0x0001B072
		public unsafe Encoding _encoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr__encoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr__encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x060050FF RID: 20735 RVA: 0x00179288 File Offset: 0x00177488
		// (set) Token: 0x06005100 RID: 20736 RVA: 0x0001CE91 File Offset: 0x0001B091
		public unsafe Encoder _encoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr__encoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr__encoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x06005101 RID: 20737 RVA: 0x001792B8 File Offset: 0x001774B8
		// (set) Token: 0x06005102 RID: 20738 RVA: 0x0001CEB0 File Offset: 0x0001B0B0
		public unsafe Il2CppStructArray<byte> _byteBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr__byteBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr__byteBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x06005103 RID: 20739 RVA: 0x001792E8 File Offset: 0x001774E8
		// (set) Token: 0x06005104 RID: 20740 RVA: 0x0001CECF File Offset: 0x0001B0CF
		public unsafe Il2CppStructArray<char> _charBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr__charBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr__charBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x06005105 RID: 20741 RVA: 0x00179318 File Offset: 0x00177518
		// (set) Token: 0x06005106 RID: 20742 RVA: 0x0001CEEE File Offset: 0x0001B0EE
		public unsafe int _charPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr__charPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr__charPos)) = value;
			}
		}

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x06005107 RID: 20743 RVA: 0x00179340 File Offset: 0x00177540
		// (set) Token: 0x06005108 RID: 20744 RVA: 0x0001CF09 File Offset: 0x0001B109
		public unsafe int _charLen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr__charLen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr__charLen)) = value;
			}
		}

		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x06005109 RID: 20745 RVA: 0x00179368 File Offset: 0x00177568
		// (set) Token: 0x0600510A RID: 20746 RVA: 0x0001CF24 File Offset: 0x0001B124
		public unsafe bool _autoFlush
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr__autoFlush);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr__autoFlush)) = value;
			}
		}

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x0600510B RID: 20747 RVA: 0x00179390 File Offset: 0x00177590
		// (set) Token: 0x0600510C RID: 20748 RVA: 0x0001CF3F File Offset: 0x0001B13F
		public unsafe bool _haveWrittenPreamble
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr__haveWrittenPreamble);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr__haveWrittenPreamble)) = value;
			}
		}

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x0600510D RID: 20749 RVA: 0x001793B8 File Offset: 0x001775B8
		// (set) Token: 0x0600510E RID: 20750 RVA: 0x0001CF5A File Offset: 0x0001B15A
		public unsafe bool _closable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr__closable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr__closable)) = value;
			}
		}

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x0600510F RID: 20751 RVA: 0x001793E0 File Offset: 0x001775E0
		// (set) Token: 0x06005110 RID: 20752 RVA: 0x0001CF75 File Offset: 0x0001B175
		public unsafe Task _asyncWriteTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr__asyncWriteTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr__asyncWriteTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040041EC RID: 16876
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x040041ED RID: 16877
		private static readonly IntPtr NativeFieldInfoPtr__stream;

		// Token: 0x040041EE RID: 16878
		private static readonly IntPtr NativeFieldInfoPtr__encoding;

		// Token: 0x040041EF RID: 16879
		private static readonly IntPtr NativeFieldInfoPtr__encoder;

		// Token: 0x040041F0 RID: 16880
		private static readonly IntPtr NativeFieldInfoPtr__byteBuffer;

		// Token: 0x040041F1 RID: 16881
		private static readonly IntPtr NativeFieldInfoPtr__charBuffer;

		// Token: 0x040041F2 RID: 16882
		private static readonly IntPtr NativeFieldInfoPtr__charPos;

		// Token: 0x040041F3 RID: 16883
		private static readonly IntPtr NativeFieldInfoPtr__charLen;

		// Token: 0x040041F4 RID: 16884
		private static readonly IntPtr NativeFieldInfoPtr__autoFlush;

		// Token: 0x040041F5 RID: 16885
		private static readonly IntPtr NativeFieldInfoPtr__haveWrittenPreamble;

		// Token: 0x040041F6 RID: 16886
		private static readonly IntPtr NativeFieldInfoPtr__closable;

		// Token: 0x040041F7 RID: 16887
		private static readonly IntPtr NativeFieldInfoPtr__asyncWriteTask;

		// Token: 0x040041F8 RID: 16888
		private static readonly IntPtr NativeMethodInfoPtr_CheckAsyncTaskInProgress_Private_Void_0;

		// Token: 0x040041F9 RID: 16889
		private static readonly IntPtr NativeMethodInfoPtr_ThrowAsyncIOInProgress_Private_Static_Void_0;

		// Token: 0x040041FA RID: 16890
		private static readonly IntPtr NativeMethodInfoPtr_get_UTF8NoBOM_Private_Static_get_Encoding_0;

		// Token: 0x040041FB RID: 16891
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040041FC RID: 16892
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_0;

		// Token: 0x040041FD RID: 16893
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0;

		// Token: 0x040041FE RID: 16894
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Int32_0;

		// Token: 0x040041FF RID: 16895
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Int32_Boolean_0;

		// Token: 0x04004200 RID: 16896
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04004201 RID: 16897
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x04004202 RID: 16898
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Encoding_Int32_0;

		// Token: 0x04004203 RID: 16899
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_Stream_Encoding_Int32_Boolean_0;

		// Token: 0x04004204 RID: 16900
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04004205 RID: 16901
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04004206 RID: 16902
		private static readonly IntPtr NativeMethodInfoPtr_DisposeAsync_Public_Virtual_ValueTask_0;

		// Token: 0x04004207 RID: 16903
		private static readonly IntPtr NativeMethodInfoPtr_DisposeAsyncCore_Private_ValueTask_0;

		// Token: 0x04004208 RID: 16904
		private static readonly IntPtr NativeMethodInfoPtr_CloseStreamFromDispose_Private_Void_Boolean_0;

		// Token: 0x04004209 RID: 16905
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x0400420A RID: 16906
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Private_Void_Boolean_Boolean_0;

		// Token: 0x0400420B RID: 16907
		private static readonly IntPtr NativeMethodInfoPtr_set_AutoFlush_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x0400420C RID: 16908
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseStream_Public_Virtual_New_get_Stream_0;

		// Token: 0x0400420D RID: 16909
		private static readonly IntPtr NativeMethodInfoPtr_get_LeaveOpen_Internal_get_Boolean_0;

		// Token: 0x0400420E RID: 16910
		private static readonly IntPtr NativeMethodInfoPtr_get_Encoding_Public_Virtual_get_Encoding_0;

		// Token: 0x0400420F RID: 16911
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0;

		// Token: 0x04004210 RID: 16912
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x04004211 RID: 16913
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04004212 RID: 16914
		private static readonly IntPtr NativeMethodInfoPtr_WriteSpan_Private_Void_ReadOnlySpan_1_Char_Boolean_0;

		// Token: 0x04004213 RID: 16915
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0;

		// Token: 0x04004214 RID: 16916
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_0;

		// Token: 0x04004215 RID: 16917
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Char_0;

		// Token: 0x04004216 RID: 16918
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsyncInternal_Private_Static_Task_StreamWriter_Char_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Char_Boolean_Boolean_0;

		// Token: 0x04004217 RID: 16919
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_String_0;

		// Token: 0x04004218 RID: 16920
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsyncInternal_Private_Static_Task_StreamWriter_String_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Char_Boolean_Boolean_0;

		// Token: 0x04004219 RID: 16921
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x0400421A RID: 16922
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsyncInternal_Private_Static_Task_StreamWriter_ReadOnlyMemory_1_Char_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Char_Boolean_Boolean_CancellationToken_0;

		// Token: 0x0400421B RID: 16923
		private static readonly IntPtr NativeMethodInfoPtr_FlushAsync_Public_Virtual_Task_0;

		// Token: 0x0400421C RID: 16924
		private static readonly IntPtr NativeMethodInfoPtr_set_CharPos_Prop_Private_set_Void_Int32_0;

		// Token: 0x0400421D RID: 16925
		private static readonly IntPtr NativeMethodInfoPtr_set_HaveWrittenPreamble_Prop_Private_set_Void_Boolean_0;

		// Token: 0x0400421E RID: 16926
		private static readonly IntPtr NativeMethodInfoPtr_FlushAsyncInternal_Private_Task_Boolean_Boolean_Il2CppStructArray_1_Char_Int32_CancellationToken_0;

		// Token: 0x0400421F RID: 16927
		private static readonly IntPtr NativeMethodInfoPtr_FlushAsyncInternal_Private_Static_Task_StreamWriter_Boolean_Boolean_Il2CppStructArray_1_Char_Int32_Boolean_Encoding_Encoder_Il2CppStructArray_1_Byte_Stream_CancellationToken_0;

		// Token: 0x02000718 RID: 1816
		[ObfuscatedName("System.IO.StreamWriter+<DisposeAsyncCore>d__33")]
		public sealed class _DisposeAsyncCore_d__33 : ValueType
		{
			// Token: 0x0600605E RID: 24670 RVA: 0x001B290C File Offset: 0x001B0B0C
			// Note: this type is marked as 'beforefieldinit'.
			static _DisposeAsyncCore_d__33()
			{
				Il2CppClassPointerStore<StreamWriter._DisposeAsyncCore_d__33>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "<DisposeAsyncCore>d__33");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamWriter._DisposeAsyncCore_d__33>.NativeClassPtr);
				StreamWriter._DisposeAsyncCore_d__33.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._DisposeAsyncCore_d__33>.NativeClassPtr, "<>1__state");
				StreamWriter._DisposeAsyncCore_d__33.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._DisposeAsyncCore_d__33>.NativeClassPtr, "<>t__builder");
				StreamWriter._DisposeAsyncCore_d__33.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._DisposeAsyncCore_d__33>.NativeClassPtr, "<>4__this");
				StreamWriter._DisposeAsyncCore_d__33.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._DisposeAsyncCore_d__33>.NativeClassPtr, "<>u__1");
				StreamWriter._DisposeAsyncCore_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter._DisposeAsyncCore_d__33>.NativeClassPtr, 100675565);
				StreamWriter._DisposeAsyncCore_d__33.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter._DisposeAsyncCore_d__33>.NativeClassPtr, 100675566);
			}

			// Token: 0x0600605F RID: 24671 RVA: 0x001B29B0 File Offset: 0x001B0BB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428660, XrefRangeEnd = 1428678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter._DisposeAsyncCore_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006060 RID: 24672 RVA: 0x001B29E8 File Offset: 0x001B0BE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter._DisposeAsyncCore_d__33.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006061 RID: 24673 RVA: 0x000234FC File Offset: 0x000216FC
			public _DisposeAsyncCore_d__33(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06006062 RID: 24674 RVA: 0x00023505 File Offset: 0x00021705
			public _DisposeAsyncCore_d__33()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamWriter._DisposeAsyncCore_d__33>.NativeClassPtr))
			{
			}

			// Token: 0x170018F2 RID: 6386
			// (get) Token: 0x06006063 RID: 24675 RVA: 0x001B2A30 File Offset: 0x001B0C30
			// (set) Token: 0x06006064 RID: 24676 RVA: 0x00023517 File Offset: 0x00021717
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._DisposeAsyncCore_d__33.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._DisposeAsyncCore_d__33.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170018F3 RID: 6387
			// (get) Token: 0x06006065 RID: 24677 RVA: 0x001B2A58 File Offset: 0x001B0C58
			// (set) Token: 0x06006066 RID: 24678 RVA: 0x00023532 File Offset: 0x00021732
			public AsyncValueTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._DisposeAsyncCore_d__33.NativeFieldInfoPtr___t__builder);
					return new AsyncValueTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._DisposeAsyncCore_d__33.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170018F4 RID: 6388
			// (get) Token: 0x06006067 RID: 24679 RVA: 0x001B2A88 File Offset: 0x001B0C88
			// (set) Token: 0x06006068 RID: 24680 RVA: 0x00023560 File Offset: 0x00021760
			public unsafe StreamWriter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._DisposeAsyncCore_d__33.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._DisposeAsyncCore_d__33.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018F5 RID: 6389
			// (get) Token: 0x06006069 RID: 24681 RVA: 0x001B2AB8 File Offset: 0x001B0CB8
			// (set) Token: 0x0600606A RID: 24682 RVA: 0x0002357F File Offset: 0x0002177F
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._DisposeAsyncCore_d__33.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._DisposeAsyncCore_d__33.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04004E37 RID: 20023
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004E38 RID: 20024
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04004E39 RID: 20025
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004E3A RID: 20026
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04004E3B RID: 20027
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004E3C RID: 20028
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000719 RID: 1817
		[ObfuscatedName("System.IO.StreamWriter+<WriteAsyncInternal>d__57")]
		public sealed class _WriteAsyncInternal_d__57 : ValueType
		{
			// Token: 0x0600606B RID: 24683 RVA: 0x001B2AE8 File Offset: 0x001B0CE8
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteAsyncInternal_d__57()
			{
				Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__57>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "<WriteAsyncInternal>d__57");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__57>.NativeClassPtr);
				StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__57>.NativeClassPtr, "<>1__state");
				StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__57>.NativeClassPtr, "<>t__builder");
				StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr_charPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__57>.NativeClassPtr, "charPos");
				StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr_charLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__57>.NativeClassPtr, "charLen");
				StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__57>.NativeClassPtr, "_this");
				StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr_charBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__57>.NativeClassPtr, "charBuffer");
				StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__57>.NativeClassPtr, "value");
				StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr_appendNewLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__57>.NativeClassPtr, "appendNewLine");
				StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr_coreNewLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__57>.NativeClassPtr, "coreNewLine");
				StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr_autoFlush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__57>.NativeClassPtr, "autoFlush");
				StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__57>.NativeClassPtr, "<>u__1");
				StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__57>.NativeClassPtr, "<i>5__2");
				StreamWriter._WriteAsyncInternal_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__57>.NativeClassPtr, 100675567);
				StreamWriter._WriteAsyncInternal_d__57.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__57>.NativeClassPtr, 100675568);
			}

			// Token: 0x0600606C RID: 24684 RVA: 0x001B2C2C File Offset: 0x001B0E2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428678, XrefRangeEnd = 1428711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter._WriteAsyncInternal_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600606D RID: 24685 RVA: 0x001B2C64 File Offset: 0x001B0E64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428711, XrefRangeEnd = 1428715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter._WriteAsyncInternal_d__57.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600606E RID: 24686 RVA: 0x000235AD File Offset: 0x000217AD
			public _WriteAsyncInternal_d__57(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600606F RID: 24687 RVA: 0x000235B6 File Offset: 0x000217B6
			public _WriteAsyncInternal_d__57()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__57>.NativeClassPtr))
			{
			}

			// Token: 0x170018F6 RID: 6390
			// (get) Token: 0x06006070 RID: 24688 RVA: 0x001B2CAC File Offset: 0x001B0EAC
			// (set) Token: 0x06006071 RID: 24689 RVA: 0x000235C8 File Offset: 0x000217C8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170018F7 RID: 6391
			// (get) Token: 0x06006072 RID: 24690 RVA: 0x001B2CD4 File Offset: 0x001B0ED4
			// (set) Token: 0x06006073 RID: 24691 RVA: 0x000235E3 File Offset: 0x000217E3
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170018F8 RID: 6392
			// (get) Token: 0x06006074 RID: 24692 RVA: 0x001B2D04 File Offset: 0x001B0F04
			// (set) Token: 0x06006075 RID: 24693 RVA: 0x00023611 File Offset: 0x00021811
			public unsafe int charPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr_charPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr_charPos)) = value;
				}
			}

			// Token: 0x170018F9 RID: 6393
			// (get) Token: 0x06006076 RID: 24694 RVA: 0x001B2D2C File Offset: 0x001B0F2C
			// (set) Token: 0x06006077 RID: 24695 RVA: 0x0002362C File Offset: 0x0002182C
			public unsafe int charLen
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr_charLen);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr_charLen)) = value;
				}
			}

			// Token: 0x170018FA RID: 6394
			// (get) Token: 0x06006078 RID: 24696 RVA: 0x001B2D54 File Offset: 0x001B0F54
			// (set) Token: 0x06006079 RID: 24697 RVA: 0x00023647 File Offset: 0x00021847
			public unsafe StreamWriter _this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018FB RID: 6395
			// (get) Token: 0x0600607A RID: 24698 RVA: 0x001B2D84 File Offset: 0x001B0F84
			// (set) Token: 0x0600607B RID: 24699 RVA: 0x00023666 File Offset: 0x00021866
			public unsafe Il2CppStructArray<char> charBuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr_charBuffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr_charBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018FC RID: 6396
			// (get) Token: 0x0600607C RID: 24700 RVA: 0x001B2DB4 File Offset: 0x001B0FB4
			// (set) Token: 0x0600607D RID: 24701 RVA: 0x00023685 File Offset: 0x00021885
			public unsafe char value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x170018FD RID: 6397
			// (get) Token: 0x0600607E RID: 24702 RVA: 0x001B2DDC File Offset: 0x001B0FDC
			// (set) Token: 0x0600607F RID: 24703 RVA: 0x000236A0 File Offset: 0x000218A0
			public unsafe bool appendNewLine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr_appendNewLine);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr_appendNewLine)) = value;
				}
			}

			// Token: 0x170018FE RID: 6398
			// (get) Token: 0x06006080 RID: 24704 RVA: 0x001B2E04 File Offset: 0x001B1004
			// (set) Token: 0x06006081 RID: 24705 RVA: 0x000236BB File Offset: 0x000218BB
			public unsafe Il2CppStructArray<char> coreNewLine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr_coreNewLine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr_coreNewLine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018FF RID: 6399
			// (get) Token: 0x06006082 RID: 24706 RVA: 0x001B2E34 File Offset: 0x001B1034
			// (set) Token: 0x06006083 RID: 24707 RVA: 0x000236DA File Offset: 0x000218DA
			public unsafe bool autoFlush
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr_autoFlush);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr_autoFlush)) = value;
				}
			}

			// Token: 0x17001900 RID: 6400
			// (get) Token: 0x06006084 RID: 24708 RVA: 0x001B2E5C File Offset: 0x001B105C
			// (set) Token: 0x06006085 RID: 24709 RVA: 0x000236F5 File Offset: 0x000218F5
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001901 RID: 6401
			// (get) Token: 0x06006086 RID: 24710 RVA: 0x001B2E8C File Offset: 0x001B108C
			// (set) Token: 0x06006087 RID: 24711 RVA: 0x00023723 File Offset: 0x00021923
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__57.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x04004E3D RID: 20029
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004E3E RID: 20030
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04004E3F RID: 20031
			private static readonly IntPtr NativeFieldInfoPtr_charPos;

			// Token: 0x04004E40 RID: 20032
			private static readonly IntPtr NativeFieldInfoPtr_charLen;

			// Token: 0x04004E41 RID: 20033
			private static readonly IntPtr NativeFieldInfoPtr__this;

			// Token: 0x04004E42 RID: 20034
			private static readonly IntPtr NativeFieldInfoPtr_charBuffer;

			// Token: 0x04004E43 RID: 20035
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04004E44 RID: 20036
			private static readonly IntPtr NativeFieldInfoPtr_appendNewLine;

			// Token: 0x04004E45 RID: 20037
			private static readonly IntPtr NativeFieldInfoPtr_coreNewLine;

			// Token: 0x04004E46 RID: 20038
			private static readonly IntPtr NativeFieldInfoPtr_autoFlush;

			// Token: 0x04004E47 RID: 20039
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04004E48 RID: 20040
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04004E49 RID: 20041
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004E4A RID: 20042
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200071A RID: 1818
		[ObfuscatedName("System.IO.StreamWriter+<WriteAsyncInternal>d__59")]
		public sealed class _WriteAsyncInternal_d__59 : ValueType
		{
			// Token: 0x06006088 RID: 24712 RVA: 0x001B2EB4 File Offset: 0x001B10B4
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteAsyncInternal_d__59()
			{
				Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__59>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "<WriteAsyncInternal>d__59");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__59>.NativeClassPtr);
				StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__59>.NativeClassPtr, "<>1__state");
				StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__59>.NativeClassPtr, "<>t__builder");
				StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__59>.NativeClassPtr, "value");
				StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr_charPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__59>.NativeClassPtr, "charPos");
				StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr_charLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__59>.NativeClassPtr, "charLen");
				StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__59>.NativeClassPtr, "_this");
				StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr_charBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__59>.NativeClassPtr, "charBuffer");
				StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr_appendNewLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__59>.NativeClassPtr, "appendNewLine");
				StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr_coreNewLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__59>.NativeClassPtr, "coreNewLine");
				StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr_autoFlush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__59>.NativeClassPtr, "autoFlush");
				StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr__count_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__59>.NativeClassPtr, "<count>5__2");
				StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr__index_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__59>.NativeClassPtr, "<index>5__3");
				StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__59>.NativeClassPtr, "<>u__1");
				StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__59>.NativeClassPtr, "<i>5__4");
				StreamWriter._WriteAsyncInternal_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__59>.NativeClassPtr, 100675569);
				StreamWriter._WriteAsyncInternal_d__59.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__59>.NativeClassPtr, 100675570);
			}

			// Token: 0x06006089 RID: 24713 RVA: 0x001B3020 File Offset: 0x001B1220
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428715, XrefRangeEnd = 1428750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter._WriteAsyncInternal_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600608A RID: 24714 RVA: 0x001B3058 File Offset: 0x001B1258
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428750, XrefRangeEnd = 1428754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter._WriteAsyncInternal_d__59.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600608B RID: 24715 RVA: 0x0002373E File Offset: 0x0002193E
			public _WriteAsyncInternal_d__59(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600608C RID: 24716 RVA: 0x00023747 File Offset: 0x00021947
			public _WriteAsyncInternal_d__59()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__59>.NativeClassPtr))
			{
			}

			// Token: 0x17001902 RID: 6402
			// (get) Token: 0x0600608D RID: 24717 RVA: 0x001B30A0 File Offset: 0x001B12A0
			// (set) Token: 0x0600608E RID: 24718 RVA: 0x00023759 File Offset: 0x00021959
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001903 RID: 6403
			// (get) Token: 0x0600608F RID: 24719 RVA: 0x001B30C8 File Offset: 0x001B12C8
			// (set) Token: 0x06006090 RID: 24720 RVA: 0x00023774 File Offset: 0x00021974
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001904 RID: 6404
			// (get) Token: 0x06006091 RID: 24721 RVA: 0x001B30F8 File Offset: 0x001B12F8
			// (set) Token: 0x06006092 RID: 24722 RVA: 0x000237A2 File Offset: 0x000219A2
			public unsafe string value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr_value);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001905 RID: 6405
			// (get) Token: 0x06006093 RID: 24723 RVA: 0x001B3120 File Offset: 0x001B1320
			// (set) Token: 0x06006094 RID: 24724 RVA: 0x000237C1 File Offset: 0x000219C1
			public unsafe int charPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr_charPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr_charPos)) = value;
				}
			}

			// Token: 0x17001906 RID: 6406
			// (get) Token: 0x06006095 RID: 24725 RVA: 0x001B3148 File Offset: 0x001B1348
			// (set) Token: 0x06006096 RID: 24726 RVA: 0x000237DC File Offset: 0x000219DC
			public unsafe int charLen
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr_charLen);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr_charLen)) = value;
				}
			}

			// Token: 0x17001907 RID: 6407
			// (get) Token: 0x06006097 RID: 24727 RVA: 0x001B3170 File Offset: 0x001B1370
			// (set) Token: 0x06006098 RID: 24728 RVA: 0x000237F7 File Offset: 0x000219F7
			public unsafe StreamWriter _this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001908 RID: 6408
			// (get) Token: 0x06006099 RID: 24729 RVA: 0x001B31A0 File Offset: 0x001B13A0
			// (set) Token: 0x0600609A RID: 24730 RVA: 0x00023816 File Offset: 0x00021A16
			public unsafe Il2CppStructArray<char> charBuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr_charBuffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr_charBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001909 RID: 6409
			// (get) Token: 0x0600609B RID: 24731 RVA: 0x001B31D0 File Offset: 0x001B13D0
			// (set) Token: 0x0600609C RID: 24732 RVA: 0x00023835 File Offset: 0x00021A35
			public unsafe bool appendNewLine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr_appendNewLine);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr_appendNewLine)) = value;
				}
			}

			// Token: 0x1700190A RID: 6410
			// (get) Token: 0x0600609D RID: 24733 RVA: 0x001B31F8 File Offset: 0x001B13F8
			// (set) Token: 0x0600609E RID: 24734 RVA: 0x00023850 File Offset: 0x00021A50
			public unsafe Il2CppStructArray<char> coreNewLine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr_coreNewLine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr_coreNewLine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700190B RID: 6411
			// (get) Token: 0x0600609F RID: 24735 RVA: 0x001B3228 File Offset: 0x001B1428
			// (set) Token: 0x060060A0 RID: 24736 RVA: 0x0002386F File Offset: 0x00021A6F
			public unsafe bool autoFlush
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr_autoFlush);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr_autoFlush)) = value;
				}
			}

			// Token: 0x1700190C RID: 6412
			// (get) Token: 0x060060A1 RID: 24737 RVA: 0x001B3250 File Offset: 0x001B1450
			// (set) Token: 0x060060A2 RID: 24738 RVA: 0x0002388A File Offset: 0x00021A8A
			public unsafe int _count_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr__count_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr__count_5__2)) = value;
				}
			}

			// Token: 0x1700190D RID: 6413
			// (get) Token: 0x060060A3 RID: 24739 RVA: 0x001B3278 File Offset: 0x001B1478
			// (set) Token: 0x060060A4 RID: 24740 RVA: 0x000238A5 File Offset: 0x00021AA5
			public unsafe int _index_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr__index_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr__index_5__3)) = value;
				}
			}

			// Token: 0x1700190E RID: 6414
			// (get) Token: 0x060060A5 RID: 24741 RVA: 0x001B32A0 File Offset: 0x001B14A0
			// (set) Token: 0x060060A6 RID: 24742 RVA: 0x000238C0 File Offset: 0x00021AC0
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700190F RID: 6415
			// (get) Token: 0x060060A7 RID: 24743 RVA: 0x001B32D0 File Offset: 0x001B14D0
			// (set) Token: 0x060060A8 RID: 24744 RVA: 0x000238EE File Offset: 0x00021AEE
			public unsafe int _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__59.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x04004E4B RID: 20043
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004E4C RID: 20044
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04004E4D RID: 20045
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04004E4E RID: 20046
			private static readonly IntPtr NativeFieldInfoPtr_charPos;

			// Token: 0x04004E4F RID: 20047
			private static readonly IntPtr NativeFieldInfoPtr_charLen;

			// Token: 0x04004E50 RID: 20048
			private static readonly IntPtr NativeFieldInfoPtr__this;

			// Token: 0x04004E51 RID: 20049
			private static readonly IntPtr NativeFieldInfoPtr_charBuffer;

			// Token: 0x04004E52 RID: 20050
			private static readonly IntPtr NativeFieldInfoPtr_appendNewLine;

			// Token: 0x04004E53 RID: 20051
			private static readonly IntPtr NativeFieldInfoPtr_coreNewLine;

			// Token: 0x04004E54 RID: 20052
			private static readonly IntPtr NativeFieldInfoPtr_autoFlush;

			// Token: 0x04004E55 RID: 20053
			private static readonly IntPtr NativeFieldInfoPtr__count_5__2;

			// Token: 0x04004E56 RID: 20054
			private static readonly IntPtr NativeFieldInfoPtr__index_5__3;

			// Token: 0x04004E57 RID: 20055
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04004E58 RID: 20056
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x04004E59 RID: 20057
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004E5A RID: 20058
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200071B RID: 1819
		[ObfuscatedName("System.IO.StreamWriter+<WriteAsyncInternal>d__62")]
		public sealed class _WriteAsyncInternal_d__62 : ValueType
		{
			// Token: 0x060060A9 RID: 24745 RVA: 0x001B32F8 File Offset: 0x001B14F8
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteAsyncInternal_d__62()
			{
				Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__62>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "<WriteAsyncInternal>d__62");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__62>.NativeClassPtr);
				StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__62>.NativeClassPtr, "<>1__state");
				StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__62>.NativeClassPtr, "<>t__builder");
				StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr_charPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__62>.NativeClassPtr, "charPos");
				StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr_charLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__62>.NativeClassPtr, "charLen");
				StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__62>.NativeClassPtr, "_this");
				StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr_charBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__62>.NativeClassPtr, "charBuffer");
				StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__62>.NativeClassPtr, "cancellationToken");
				StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__62>.NativeClassPtr, "source");
				StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr_appendNewLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__62>.NativeClassPtr, "appendNewLine");
				StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr_coreNewLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__62>.NativeClassPtr, "coreNewLine");
				StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr_autoFlush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__62>.NativeClassPtr, "autoFlush");
				StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr__copied_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__62>.NativeClassPtr, "<copied>5__2");
				StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__62>.NativeClassPtr, "<>u__1");
				StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__62>.NativeClassPtr, "<i>5__3");
				StreamWriter._WriteAsyncInternal_d__62.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__62>.NativeClassPtr, 100675571);
				StreamWriter._WriteAsyncInternal_d__62.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__62>.NativeClassPtr, 100675572);
			}

			// Token: 0x060060AA RID: 24746 RVA: 0x001B3464 File Offset: 0x001B1664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428754, XrefRangeEnd = 1428811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter._WriteAsyncInternal_d__62.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060060AB RID: 24747 RVA: 0x001B349C File Offset: 0x001B169C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428811, XrefRangeEnd = 1428815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter._WriteAsyncInternal_d__62.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060060AC RID: 24748 RVA: 0x00023909 File Offset: 0x00021B09
			public _WriteAsyncInternal_d__62(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060060AD RID: 24749 RVA: 0x00023912 File Offset: 0x00021B12
			public _WriteAsyncInternal_d__62()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamWriter._WriteAsyncInternal_d__62>.NativeClassPtr))
			{
			}

			// Token: 0x17001910 RID: 6416
			// (get) Token: 0x060060AE RID: 24750 RVA: 0x001B34E4 File Offset: 0x001B16E4
			// (set) Token: 0x060060AF RID: 24751 RVA: 0x00023924 File Offset: 0x00021B24
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001911 RID: 6417
			// (get) Token: 0x060060B0 RID: 24752 RVA: 0x001B350C File Offset: 0x001B170C
			// (set) Token: 0x060060B1 RID: 24753 RVA: 0x0002393F File Offset: 0x00021B3F
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001912 RID: 6418
			// (get) Token: 0x060060B2 RID: 24754 RVA: 0x001B353C File Offset: 0x001B173C
			// (set) Token: 0x060060B3 RID: 24755 RVA: 0x0002396D File Offset: 0x00021B6D
			public unsafe int charPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr_charPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr_charPos)) = value;
				}
			}

			// Token: 0x17001913 RID: 6419
			// (get) Token: 0x060060B4 RID: 24756 RVA: 0x001B3564 File Offset: 0x001B1764
			// (set) Token: 0x060060B5 RID: 24757 RVA: 0x00023988 File Offset: 0x00021B88
			public unsafe int charLen
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr_charLen);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr_charLen)) = value;
				}
			}

			// Token: 0x17001914 RID: 6420
			// (get) Token: 0x060060B6 RID: 24758 RVA: 0x001B358C File Offset: 0x001B178C
			// (set) Token: 0x060060B7 RID: 24759 RVA: 0x000239A3 File Offset: 0x00021BA3
			public unsafe StreamWriter _this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001915 RID: 6421
			// (get) Token: 0x060060B8 RID: 24760 RVA: 0x001B35BC File Offset: 0x001B17BC
			// (set) Token: 0x060060B9 RID: 24761 RVA: 0x000239C2 File Offset: 0x00021BC2
			public unsafe Il2CppStructArray<char> charBuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr_charBuffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr_charBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001916 RID: 6422
			// (get) Token: 0x060060BA RID: 24762 RVA: 0x001B35EC File Offset: 0x001B17EC
			// (set) Token: 0x060060BB RID: 24763 RVA: 0x000239E1 File Offset: 0x00021BE1
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001917 RID: 6423
			// (get) Token: 0x060060BC RID: 24764 RVA: 0x001B361C File Offset: 0x001B181C
			// (set) Token: 0x060060BD RID: 24765 RVA: 0x00023A0F File Offset: 0x00021C0F
			public ReadOnlyMemory<char> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr_source);
					return new ReadOnlyMemory<char>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadOnlyMemory<char>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr_source), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReadOnlyMemory<char>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001918 RID: 6424
			// (get) Token: 0x060060BE RID: 24766 RVA: 0x001B364C File Offset: 0x001B184C
			// (set) Token: 0x060060BF RID: 24767 RVA: 0x00023A3D File Offset: 0x00021C3D
			public unsafe bool appendNewLine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr_appendNewLine);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr_appendNewLine)) = value;
				}
			}

			// Token: 0x17001919 RID: 6425
			// (get) Token: 0x060060C0 RID: 24768 RVA: 0x001B3674 File Offset: 0x001B1874
			// (set) Token: 0x060060C1 RID: 24769 RVA: 0x00023A58 File Offset: 0x00021C58
			public unsafe Il2CppStructArray<char> coreNewLine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr_coreNewLine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr_coreNewLine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700191A RID: 6426
			// (get) Token: 0x060060C2 RID: 24770 RVA: 0x001B36A4 File Offset: 0x001B18A4
			// (set) Token: 0x060060C3 RID: 24771 RVA: 0x00023A77 File Offset: 0x00021C77
			public unsafe bool autoFlush
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr_autoFlush);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr_autoFlush)) = value;
				}
			}

			// Token: 0x1700191B RID: 6427
			// (get) Token: 0x060060C4 RID: 24772 RVA: 0x001B36CC File Offset: 0x001B18CC
			// (set) Token: 0x060060C5 RID: 24773 RVA: 0x00023A92 File Offset: 0x00021C92
			public unsafe int _copied_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr__copied_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr__copied_5__2)) = value;
				}
			}

			// Token: 0x1700191C RID: 6428
			// (get) Token: 0x060060C6 RID: 24774 RVA: 0x001B36F4 File Offset: 0x001B18F4
			// (set) Token: 0x060060C7 RID: 24775 RVA: 0x00023AAD File Offset: 0x00021CAD
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700191D RID: 6429
			// (get) Token: 0x060060C8 RID: 24776 RVA: 0x001B3724 File Offset: 0x001B1924
			// (set) Token: 0x060060C9 RID: 24777 RVA: 0x00023ADB File Offset: 0x00021CDB
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._WriteAsyncInternal_d__62.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04004E5B RID: 20059
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004E5C RID: 20060
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04004E5D RID: 20061
			private static readonly IntPtr NativeFieldInfoPtr_charPos;

			// Token: 0x04004E5E RID: 20062
			private static readonly IntPtr NativeFieldInfoPtr_charLen;

			// Token: 0x04004E5F RID: 20063
			private static readonly IntPtr NativeFieldInfoPtr__this;

			// Token: 0x04004E60 RID: 20064
			private static readonly IntPtr NativeFieldInfoPtr_charBuffer;

			// Token: 0x04004E61 RID: 20065
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04004E62 RID: 20066
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04004E63 RID: 20067
			private static readonly IntPtr NativeFieldInfoPtr_appendNewLine;

			// Token: 0x04004E64 RID: 20068
			private static readonly IntPtr NativeFieldInfoPtr_coreNewLine;

			// Token: 0x04004E65 RID: 20069
			private static readonly IntPtr NativeFieldInfoPtr_autoFlush;

			// Token: 0x04004E66 RID: 20070
			private static readonly IntPtr NativeFieldInfoPtr__copied_5__2;

			// Token: 0x04004E67 RID: 20071
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04004E68 RID: 20072
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04004E69 RID: 20073
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004E6A RID: 20074
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200071C RID: 1820
		[ObfuscatedName("System.IO.StreamWriter+<FlushAsyncInternal>d__74")]
		public sealed class _FlushAsyncInternal_d__74 : ValueType
		{
			// Token: 0x060060CA RID: 24778 RVA: 0x001B374C File Offset: 0x001B194C
			// Note: this type is marked as 'beforefieldinit'.
			static _FlushAsyncInternal_d__74()
			{
				Il2CppClassPointerStore<StreamWriter._FlushAsyncInternal_d__74>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "<FlushAsyncInternal>d__74");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamWriter._FlushAsyncInternal_d__74>.NativeClassPtr);
				StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._FlushAsyncInternal_d__74>.NativeClassPtr, "<>1__state");
				StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._FlushAsyncInternal_d__74>.NativeClassPtr, "<>t__builder");
				StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_haveWrittenPreamble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._FlushAsyncInternal_d__74>.NativeClassPtr, "haveWrittenPreamble");
				StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._FlushAsyncInternal_d__74>.NativeClassPtr, "_this");
				StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._FlushAsyncInternal_d__74>.NativeClassPtr, "encoding");
				StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._FlushAsyncInternal_d__74>.NativeClassPtr, "stream");
				StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._FlushAsyncInternal_d__74>.NativeClassPtr, "cancellationToken");
				StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_encoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._FlushAsyncInternal_d__74>.NativeClassPtr, "encoder");
				StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_charBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._FlushAsyncInternal_d__74>.NativeClassPtr, "charBuffer");
				StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_charPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._FlushAsyncInternal_d__74>.NativeClassPtr, "charPos");
				StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_byteBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._FlushAsyncInternal_d__74>.NativeClassPtr, "byteBuffer");
				StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_flushEncoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._FlushAsyncInternal_d__74>.NativeClassPtr, "flushEncoder");
				StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_flushStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._FlushAsyncInternal_d__74>.NativeClassPtr, "flushStream");
				StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._FlushAsyncInternal_d__74>.NativeClassPtr, "<>u__1");
				StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter._FlushAsyncInternal_d__74>.NativeClassPtr, "<>u__2");
				StreamWriter._FlushAsyncInternal_d__74.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter._FlushAsyncInternal_d__74>.NativeClassPtr, 100675573);
				StreamWriter._FlushAsyncInternal_d__74.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter._FlushAsyncInternal_d__74>.NativeClassPtr, 100675574);
			}

			// Token: 0x060060CB RID: 24779 RVA: 0x001B38CC File Offset: 0x001B1ACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428815, XrefRangeEnd = 1428855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter._FlushAsyncInternal_d__74.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060060CC RID: 24780 RVA: 0x001B3904 File Offset: 0x001B1B04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428855, XrefRangeEnd = 1428859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter._FlushAsyncInternal_d__74.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060060CD RID: 24781 RVA: 0x00023AF6 File Offset: 0x00021CF6
			public _FlushAsyncInternal_d__74(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060060CE RID: 24782 RVA: 0x00023AFF File Offset: 0x00021CFF
			public _FlushAsyncInternal_d__74()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamWriter._FlushAsyncInternal_d__74>.NativeClassPtr))
			{
			}

			// Token: 0x1700191E RID: 6430
			// (get) Token: 0x060060CF RID: 24783 RVA: 0x001B394C File Offset: 0x001B1B4C
			// (set) Token: 0x060060D0 RID: 24784 RVA: 0x00023B11 File Offset: 0x00021D11
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700191F RID: 6431
			// (get) Token: 0x060060D1 RID: 24785 RVA: 0x001B3974 File Offset: 0x001B1B74
			// (set) Token: 0x060060D2 RID: 24786 RVA: 0x00023B2C File Offset: 0x00021D2C
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001920 RID: 6432
			// (get) Token: 0x060060D3 RID: 24787 RVA: 0x001B39A4 File Offset: 0x001B1BA4
			// (set) Token: 0x060060D4 RID: 24788 RVA: 0x00023B5A File Offset: 0x00021D5A
			public unsafe bool haveWrittenPreamble
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_haveWrittenPreamble);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_haveWrittenPreamble)) = value;
				}
			}

			// Token: 0x17001921 RID: 6433
			// (get) Token: 0x060060D5 RID: 24789 RVA: 0x001B39CC File Offset: 0x001B1BCC
			// (set) Token: 0x060060D6 RID: 24790 RVA: 0x00023B75 File Offset: 0x00021D75
			public unsafe StreamWriter _this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001922 RID: 6434
			// (get) Token: 0x060060D7 RID: 24791 RVA: 0x001B39FC File Offset: 0x001B1BFC
			// (set) Token: 0x060060D8 RID: 24792 RVA: 0x00023B94 File Offset: 0x00021D94
			public unsafe Encoding encoding
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_encoding);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001923 RID: 6435
			// (get) Token: 0x060060D9 RID: 24793 RVA: 0x001B3A2C File Offset: 0x001B1C2C
			// (set) Token: 0x060060DA RID: 24794 RVA: 0x00023BB3 File Offset: 0x00021DB3
			public unsafe Stream stream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_stream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001924 RID: 6436
			// (get) Token: 0x060060DB RID: 24795 RVA: 0x001B3A5C File Offset: 0x001B1C5C
			// (set) Token: 0x060060DC RID: 24796 RVA: 0x00023BD2 File Offset: 0x00021DD2
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001925 RID: 6437
			// (get) Token: 0x060060DD RID: 24797 RVA: 0x001B3A8C File Offset: 0x001B1C8C
			// (set) Token: 0x060060DE RID: 24798 RVA: 0x00023C00 File Offset: 0x00021E00
			public unsafe Encoder encoder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_encoder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_encoder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001926 RID: 6438
			// (get) Token: 0x060060DF RID: 24799 RVA: 0x001B3ABC File Offset: 0x001B1CBC
			// (set) Token: 0x060060E0 RID: 24800 RVA: 0x00023C1F File Offset: 0x00021E1F
			public unsafe Il2CppStructArray<char> charBuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_charBuffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_charBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001927 RID: 6439
			// (get) Token: 0x060060E1 RID: 24801 RVA: 0x001B3AEC File Offset: 0x001B1CEC
			// (set) Token: 0x060060E2 RID: 24802 RVA: 0x00023C3E File Offset: 0x00021E3E
			public unsafe int charPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_charPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_charPos)) = value;
				}
			}

			// Token: 0x17001928 RID: 6440
			// (get) Token: 0x060060E3 RID: 24803 RVA: 0x001B3B14 File Offset: 0x001B1D14
			// (set) Token: 0x060060E4 RID: 24804 RVA: 0x00023C59 File Offset: 0x00021E59
			public unsafe Il2CppStructArray<byte> byteBuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_byteBuffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_byteBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001929 RID: 6441
			// (get) Token: 0x060060E5 RID: 24805 RVA: 0x001B3B44 File Offset: 0x001B1D44
			// (set) Token: 0x060060E6 RID: 24806 RVA: 0x00023C78 File Offset: 0x00021E78
			public unsafe bool flushEncoder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_flushEncoder);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_flushEncoder)) = value;
				}
			}

			// Token: 0x1700192A RID: 6442
			// (get) Token: 0x060060E7 RID: 24807 RVA: 0x001B3B6C File Offset: 0x001B1D6C
			// (set) Token: 0x060060E8 RID: 24808 RVA: 0x00023C93 File Offset: 0x00021E93
			public unsafe bool flushStream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_flushStream);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr_flushStream)) = value;
				}
			}

			// Token: 0x1700192B RID: 6443
			// (get) Token: 0x060060E9 RID: 24809 RVA: 0x001B3B94 File Offset: 0x001B1D94
			// (set) Token: 0x060060EA RID: 24810 RVA: 0x00023CAE File Offset: 0x00021EAE
			public ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr___u__1);
					return new ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700192C RID: 6444
			// (get) Token: 0x060060EB RID: 24811 RVA: 0x001B3BC4 File Offset: 0x001B1DC4
			// (set) Token: 0x060060EC RID: 24812 RVA: 0x00023CDC File Offset: 0x00021EDC
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter._FlushAsyncInternal_d__74.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04004E6B RID: 20075
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004E6C RID: 20076
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04004E6D RID: 20077
			private static readonly IntPtr NativeFieldInfoPtr_haveWrittenPreamble;

			// Token: 0x04004E6E RID: 20078
			private static readonly IntPtr NativeFieldInfoPtr__this;

			// Token: 0x04004E6F RID: 20079
			private static readonly IntPtr NativeFieldInfoPtr_encoding;

			// Token: 0x04004E70 RID: 20080
			private static readonly IntPtr NativeFieldInfoPtr_stream;

			// Token: 0x04004E71 RID: 20081
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04004E72 RID: 20082
			private static readonly IntPtr NativeFieldInfoPtr_encoder;

			// Token: 0x04004E73 RID: 20083
			private static readonly IntPtr NativeFieldInfoPtr_charBuffer;

			// Token: 0x04004E74 RID: 20084
			private static readonly IntPtr NativeFieldInfoPtr_charPos;

			// Token: 0x04004E75 RID: 20085
			private static readonly IntPtr NativeFieldInfoPtr_byteBuffer;

			// Token: 0x04004E76 RID: 20086
			private static readonly IntPtr NativeFieldInfoPtr_flushEncoder;

			// Token: 0x04004E77 RID: 20087
			private static readonly IntPtr NativeFieldInfoPtr_flushStream;

			// Token: 0x04004E78 RID: 20088
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04004E79 RID: 20089
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04004E7A RID: 20090
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004E7B RID: 20091
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
