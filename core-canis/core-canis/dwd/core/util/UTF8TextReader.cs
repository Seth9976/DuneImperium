using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace dwd.core.util
{
	// Token: 0x0200009A RID: 154
	public sealed class UTF8TextReader : TextReader
	{
		// Token: 0x06000A84 RID: 2692 RVA: 0x0003B7A4 File Offset: 0x000399A4
		// Note: this type is marked as 'beforefieldinit'.
		static UTF8TextReader()
		{
			Il2CppClassPointerStore<UTF8TextReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.util", "UTF8TextReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UTF8TextReader>.NativeClassPtr);
			UTF8TextReader.NativeFieldInfoPtr_utfDecoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF8TextReader>.NativeClassPtr, "utfDecoder");
			UTF8TextReader.NativeFieldInfoPtr_bufferLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF8TextReader>.NativeClassPtr, "bufferLen");
			UTF8TextReader.NativeFieldInfoPtr_byteBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF8TextReader>.NativeClassPtr, "byteBuffer");
			UTF8TextReader.NativeFieldInfoPtr_charBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF8TextReader>.NativeClassPtr, "charBuffer");
			UTF8TextReader.NativeFieldInfoPtr_charPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF8TextReader>.NativeClassPtr, "charPos");
			UTF8TextReader.NativeFieldInfoPtr_charLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF8TextReader>.NativeClassPtr, "charLen");
			UTF8TextReader.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF8TextReader>.NativeClassPtr, "stream");
			UTF8TextReader.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8TextReader>.NativeClassPtr, 100664757);
			UTF8TextReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8TextReader>.NativeClassPtr, 100664758);
			UTF8TextReader.NativeMethodInfoPtr_SetStream_Public_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8TextReader>.NativeClassPtr, 100664759);
			UTF8TextReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8TextReader>.NativeClassPtr, 100664760);
			UTF8TextReader.NativeMethodInfoPtr_ReadBuffer_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8TextReader>.NativeClassPtr, 100664761);
			UTF8TextReader.NativeMethodInfoPtr_DiscardBufferedData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8TextReader>.NativeClassPtr, 100664762);
			UTF8TextReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8TextReader>.NativeClassPtr, 100664763);
			UTF8TextReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8TextReader>.NativeClassPtr, 100664764);
			UTF8TextReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8TextReader>.NativeClassPtr, 100664765);
			UTF8TextReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8TextReader>.NativeClassPtr, 100664766);
			UTF8TextReader.NativeMethodInfoPtr_ReadBlock_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8TextReader>.NativeClassPtr, 100664767);
			UTF8TextReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8TextReader>.NativeClassPtr, 100664768);
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x0003B950 File Offset: 0x00039B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862858, XrefRangeEnd = 862874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UTF8TextReader(int bufferSize = 8192)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UTF8TextReader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bufferSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF8TextReader.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x0003B998 File Offset: 0x00039B98
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 862874, RefRangeEnd = 862879, XrefRangeStart = 862874, XrefRangeEnd = 862874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF8TextReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x0003B9CC File Offset: 0x00039BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862879, XrefRangeEnd = 862880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStream(Stream newStream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newStream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF8TextReader.NativeMethodInfoPtr_SetStream_Public_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x0003BA10 File Offset: 0x00039C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862880, XrefRangeEnd = 862884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF8TextReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x0003BA50 File Offset: 0x00039C50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 862884, RefRangeEnd = 862887, XrefRangeStart = 862884, XrefRangeEnd = 862884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF8TextReader.NativeMethodInfoPtr_ReadBuffer_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x0003BA8C File Offset: 0x00039C8C
		[CallerCount(0)]
		public unsafe void DiscardBufferedData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF8TextReader.NativeMethodInfoPtr_DiscardBufferedData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0003BAC0 File Offset: 0x00039CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862887, XrefRangeEnd = 862888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF8TextReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x0003BAFC File Offset: 0x00039CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862888, XrefRangeEnd = 862889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF8TextReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x0003BB38 File Offset: 0x00039D38
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF8TextReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x0003BBA4 File Offset: 0x00039DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862889, XrefRangeEnd = 862895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ReadToEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF8TextReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x0003BBDC File Offset: 0x00039DDC
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF8TextReader.NativeMethodInfoPtr_ReadBlock_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x0003BC48 File Offset: 0x00039E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862895, XrefRangeEnd = 862897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ReadLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF8TextReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00005C01 File Offset: 0x00003E01
		public UTF8TextReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x0003BC80 File Offset: 0x00039E80
		// (set) Token: 0x06000A93 RID: 2707 RVA: 0x00005C0A File Offset: 0x00003E0A
		public unsafe Decoder utfDecoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF8TextReader.NativeFieldInfoPtr_utfDecoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Decoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF8TextReader.NativeFieldInfoPtr_utfDecoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x0003BCB0 File Offset: 0x00039EB0
		// (set) Token: 0x06000A95 RID: 2709 RVA: 0x00005C29 File Offset: 0x00003E29
		public unsafe int bufferLen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF8TextReader.NativeFieldInfoPtr_bufferLen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF8TextReader.NativeFieldInfoPtr_bufferLen)) = value;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x0003BCD8 File Offset: 0x00039ED8
		// (set) Token: 0x06000A97 RID: 2711 RVA: 0x00005C44 File Offset: 0x00003E44
		public unsafe Il2CppStructArray<byte> byteBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF8TextReader.NativeFieldInfoPtr_byteBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF8TextReader.NativeFieldInfoPtr_byteBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x0003BD08 File Offset: 0x00039F08
		// (set) Token: 0x06000A99 RID: 2713 RVA: 0x00005C63 File Offset: 0x00003E63
		public unsafe Il2CppStructArray<char> charBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF8TextReader.NativeFieldInfoPtr_charBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF8TextReader.NativeFieldInfoPtr_charBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x0003BD38 File Offset: 0x00039F38
		// (set) Token: 0x06000A9B RID: 2715 RVA: 0x00005C82 File Offset: 0x00003E82
		public unsafe int charPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF8TextReader.NativeFieldInfoPtr_charPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF8TextReader.NativeFieldInfoPtr_charPos)) = value;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x0003BD60 File Offset: 0x00039F60
		// (set) Token: 0x06000A9D RID: 2717 RVA: 0x00005C9D File Offset: 0x00003E9D
		public unsafe int charLen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF8TextReader.NativeFieldInfoPtr_charLen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF8TextReader.NativeFieldInfoPtr_charLen)) = value;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x0003BD88 File Offset: 0x00039F88
		// (set) Token: 0x06000A9F RID: 2719 RVA: 0x00005CB8 File Offset: 0x00003EB8
		public unsafe Stream stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF8TextReader.NativeFieldInfoPtr_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF8TextReader.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeFieldInfoPtr_utfDecoder;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeFieldInfoPtr_bufferLen;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeFieldInfoPtr_byteBuffer;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeFieldInfoPtr_charBuffer;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeFieldInfoPtr_charPos;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeFieldInfoPtr_charLen;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeFieldInfoPtr_stream;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeMethodInfoPtr_SetStream_Public_Void_Stream_0;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeMethodInfoPtr_ReadBuffer_Private_Int32_0;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeMethodInfoPtr_DiscardBufferedData_Public_Void_0;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_0;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeMethodInfoPtr_ReadBlock_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0;
	}
}
