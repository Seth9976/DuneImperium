using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Text;

namespace Il2CppSystem.Net
{
	// Token: 0x02000207 RID: 519
	public class MonoChunkParser : Object
	{
		// Token: 0x060021D2 RID: 8658 RVA: 0x0009E49C File Offset: 0x0009C69C
		// Note: this type is marked as 'beforefieldinit'.
		static MonoChunkParser()
		{
			Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "MonoChunkParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr);
			MonoChunkParser.NativeFieldInfoPtr_headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr, "headers");
			MonoChunkParser.NativeFieldInfoPtr_chunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr, "chunkSize");
			MonoChunkParser.NativeFieldInfoPtr_chunkRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr, "chunkRead");
			MonoChunkParser.NativeFieldInfoPtr_totalWritten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr, "totalWritten");
			MonoChunkParser.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr, "state");
			MonoChunkParser.NativeFieldInfoPtr_saved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr, "saved");
			MonoChunkParser.NativeFieldInfoPtr_sawCR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr, "sawCR");
			MonoChunkParser.NativeFieldInfoPtr_gotit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr, "gotit");
			MonoChunkParser.NativeFieldInfoPtr_trailerState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr, "trailerState");
			MonoChunkParser.NativeFieldInfoPtr_chunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr, "chunks");
			MonoChunkParser.NativeMethodInfoPtr__ctor_Public_Void_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr, 100668326);
			MonoChunkParser.NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr, 100668327);
			MonoChunkParser.NativeMethodInfoPtr_ReadFromChunks_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr, 100668328);
			MonoChunkParser.NativeMethodInfoPtr_Write_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr, 100668329);
			MonoChunkParser.NativeMethodInfoPtr_InternalWrite_Private_Void_Il2CppStructArray_1_Byte_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr, 100668330);
			MonoChunkParser.NativeMethodInfoPtr_get_WantMore_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr, 100668331);
			MonoChunkParser.NativeMethodInfoPtr_get_DataAvailable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr, 100668332);
			MonoChunkParser.NativeMethodInfoPtr_get_ChunkLeft_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr, 100668333);
			MonoChunkParser.NativeMethodInfoPtr_ReadBody_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr, 100668334);
			MonoChunkParser.NativeMethodInfoPtr_GetChunkSize_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr, 100668335);
			MonoChunkParser.NativeMethodInfoPtr_RemoveChunkExtension_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr, 100668336);
			MonoChunkParser.NativeMethodInfoPtr_ReadCRLF_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr, 100668337);
			MonoChunkParser.NativeMethodInfoPtr_ReadTrailer_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr, 100668338);
			MonoChunkParser.NativeMethodInfoPtr_ThrowProtocolViolation_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr, 100668339);
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x0009E6AC File Offset: 0x0009C8AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 482710, RefRangeEnd = 482711, XrefRangeStart = 482698, XrefRangeEnd = 482710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoChunkParser(WebHeaderCollection headers)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(headers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkParser.NativeMethodInfoPtr__ctor_Public_Void_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x0009E6F8 File Offset: 0x0009C8F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 482712, RefRangeEnd = 482714, XrefRangeStart = 482711, XrefRangeEnd = 482712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Read(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkParser.NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x0009E764 File Offset: 0x0009C964
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 482741, RefRangeEnd = 482744, XrefRangeStart = 482714, XrefRangeEnd = 482741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadFromChunks(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkParser.NativeMethodInfoPtr_ReadFromChunks_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x0009E7D0 File Offset: 0x0009C9D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 482745, RefRangeEnd = 482746, XrefRangeStart = 482744, XrefRangeEnd = 482745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkParser.NativeMethodInfoPtr_Write_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x0009E830 File Offset: 0x0009CA30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 482761, RefRangeEnd = 482763, XrefRangeStart = 482746, XrefRangeEnd = 482761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalWrite(Il2CppStructArray<byte> buffer, ref int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkParser.NativeMethodInfoPtr_InternalWrite_Private_Void_Il2CppStructArray_1_Byte_byref_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x060021D8 RID: 8664 RVA: 0x0009E890 File Offset: 0x0009CA90
		public unsafe bool WantMore
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 482763, RefRangeEnd = 482766, XrefRangeStart = 482763, XrefRangeEnd = 482763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkParser.NativeMethodInfoPtr_get_WantMore_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x060021D9 RID: 8665 RVA: 0x0009E8CC File Offset: 0x0009CACC
		public unsafe bool DataAvailable
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 482768, RefRangeEnd = 482770, XrefRangeStart = 482766, XrefRangeEnd = 482768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkParser.NativeMethodInfoPtr_get_DataAvailable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x060021DA RID: 8666 RVA: 0x0009E908 File Offset: 0x0009CB08
		public unsafe int ChunkLeft
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 482770, RefRangeEnd = 482771, XrefRangeStart = 482770, XrefRangeEnd = 482770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkParser.NativeMethodInfoPtr_get_ChunkLeft_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x0009E944 File Offset: 0x0009CB44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482771, XrefRangeEnd = 482780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoChunkParser.State ReadBody(Il2CppStructArray<byte> buffer, ref int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkParser.NativeMethodInfoPtr_ReadBody_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x0009E9B0 File Offset: 0x0009CBB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 482790, RefRangeEnd = 482791, XrefRangeStart = 482780, XrefRangeEnd = 482790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoChunkParser.State GetChunkSize(Il2CppStructArray<byte> buffer, ref int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkParser.NativeMethodInfoPtr_GetChunkSize_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x0009EA1C File Offset: 0x0009CC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482791, XrefRangeEnd = 482793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string RemoveChunkExtension(string input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkParser.NativeMethodInfoPtr_RemoveChunkExtension_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x0009EA58 File Offset: 0x0009CC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482793, XrefRangeEnd = 482796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoChunkParser.State ReadCRLF(Il2CppStructArray<byte> buffer, ref int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkParser.NativeMethodInfoPtr_ReadCRLF_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x0009EAC4 File Offset: 0x0009CCC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 482801, RefRangeEnd = 482802, XrefRangeStart = 482796, XrefRangeEnd = 482801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoChunkParser.State ReadTrailer(Il2CppStructArray<byte> buffer, ref int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkParser.NativeMethodInfoPtr_ReadTrailer_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x0009EB30 File Offset: 0x0009CD30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482802, XrefRangeEnd = 482807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowProtocolViolation(string message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkParser.NativeMethodInfoPtr_ThrowProtocolViolation_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x0000EA28 File Offset: 0x0000CC28
		public MonoChunkParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x060021E2 RID: 8674 RVA: 0x0009EB68 File Offset: 0x0009CD68
		// (set) Token: 0x060021E3 RID: 8675 RVA: 0x0000EA31 File Offset: 0x0000CC31
		public unsafe WebHeaderCollection headers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkParser.NativeFieldInfoPtr_headers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkParser.NativeFieldInfoPtr_headers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x060021E4 RID: 8676 RVA: 0x0009EB98 File Offset: 0x0009CD98
		// (set) Token: 0x060021E5 RID: 8677 RVA: 0x0000EA50 File Offset: 0x0000CC50
		public unsafe int chunkSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkParser.NativeFieldInfoPtr_chunkSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkParser.NativeFieldInfoPtr_chunkSize)) = value;
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x060021E6 RID: 8678 RVA: 0x0009EBC0 File Offset: 0x0009CDC0
		// (set) Token: 0x060021E7 RID: 8679 RVA: 0x0000EA6B File Offset: 0x0000CC6B
		public unsafe int chunkRead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkParser.NativeFieldInfoPtr_chunkRead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkParser.NativeFieldInfoPtr_chunkRead)) = value;
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x060021E8 RID: 8680 RVA: 0x0009EBE8 File Offset: 0x0009CDE8
		// (set) Token: 0x060021E9 RID: 8681 RVA: 0x0000EA86 File Offset: 0x0000CC86
		public unsafe int totalWritten
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkParser.NativeFieldInfoPtr_totalWritten);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkParser.NativeFieldInfoPtr_totalWritten)) = value;
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x060021EA RID: 8682 RVA: 0x0009EC10 File Offset: 0x0009CE10
		// (set) Token: 0x060021EB RID: 8683 RVA: 0x0000EAA1 File Offset: 0x0000CCA1
		public unsafe MonoChunkParser.State state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkParser.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkParser.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x060021EC RID: 8684 RVA: 0x0009EC38 File Offset: 0x0009CE38
		// (set) Token: 0x060021ED RID: 8685 RVA: 0x0000EABC File Offset: 0x0000CCBC
		public unsafe StringBuilder saved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkParser.NativeFieldInfoPtr_saved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkParser.NativeFieldInfoPtr_saved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x060021EE RID: 8686 RVA: 0x0009EC68 File Offset: 0x0009CE68
		// (set) Token: 0x060021EF RID: 8687 RVA: 0x0000EADB File Offset: 0x0000CCDB
		public unsafe bool sawCR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkParser.NativeFieldInfoPtr_sawCR);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkParser.NativeFieldInfoPtr_sawCR)) = value;
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x060021F0 RID: 8688 RVA: 0x0009EC90 File Offset: 0x0009CE90
		// (set) Token: 0x060021F1 RID: 8689 RVA: 0x0000EAF6 File Offset: 0x0000CCF6
		public unsafe bool gotit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkParser.NativeFieldInfoPtr_gotit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkParser.NativeFieldInfoPtr_gotit)) = value;
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x060021F2 RID: 8690 RVA: 0x0009ECB8 File Offset: 0x0009CEB8
		// (set) Token: 0x060021F3 RID: 8691 RVA: 0x0000EB11 File Offset: 0x0000CD11
		public unsafe int trailerState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkParser.NativeFieldInfoPtr_trailerState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkParser.NativeFieldInfoPtr_trailerState)) = value;
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x060021F4 RID: 8692 RVA: 0x0009ECE0 File Offset: 0x0009CEE0
		// (set) Token: 0x060021F5 RID: 8693 RVA: 0x0000EB2C File Offset: 0x0000CD2C
		public unsafe ArrayList chunks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkParser.NativeFieldInfoPtr_chunks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkParser.NativeFieldInfoPtr_chunks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A5D RID: 6749
		private static readonly IntPtr NativeFieldInfoPtr_headers;

		// Token: 0x04001A5E RID: 6750
		private static readonly IntPtr NativeFieldInfoPtr_chunkSize;

		// Token: 0x04001A5F RID: 6751
		private static readonly IntPtr NativeFieldInfoPtr_chunkRead;

		// Token: 0x04001A60 RID: 6752
		private static readonly IntPtr NativeFieldInfoPtr_totalWritten;

		// Token: 0x04001A61 RID: 6753
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04001A62 RID: 6754
		private static readonly IntPtr NativeFieldInfoPtr_saved;

		// Token: 0x04001A63 RID: 6755
		private static readonly IntPtr NativeFieldInfoPtr_sawCR;

		// Token: 0x04001A64 RID: 6756
		private static readonly IntPtr NativeFieldInfoPtr_gotit;

		// Token: 0x04001A65 RID: 6757
		private static readonly IntPtr NativeFieldInfoPtr_trailerState;

		// Token: 0x04001A66 RID: 6758
		private static readonly IntPtr NativeFieldInfoPtr_chunks;

		// Token: 0x04001A67 RID: 6759
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WebHeaderCollection_0;

		// Token: 0x04001A68 RID: 6760
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001A69 RID: 6761
		private static readonly IntPtr NativeMethodInfoPtr_ReadFromChunks_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001A6A RID: 6762
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001A6B RID: 6763
		private static readonly IntPtr NativeMethodInfoPtr_InternalWrite_Private_Void_Il2CppStructArray_1_Byte_byref_Int32_Int32_0;

		// Token: 0x04001A6C RID: 6764
		private static readonly IntPtr NativeMethodInfoPtr_get_WantMore_Public_get_Boolean_0;

		// Token: 0x04001A6D RID: 6765
		private static readonly IntPtr NativeMethodInfoPtr_get_DataAvailable_Public_get_Boolean_0;

		// Token: 0x04001A6E RID: 6766
		private static readonly IntPtr NativeMethodInfoPtr_get_ChunkLeft_Public_get_Int32_0;

		// Token: 0x04001A6F RID: 6767
		private static readonly IntPtr NativeMethodInfoPtr_ReadBody_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0;

		// Token: 0x04001A70 RID: 6768
		private static readonly IntPtr NativeMethodInfoPtr_GetChunkSize_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0;

		// Token: 0x04001A71 RID: 6769
		private static readonly IntPtr NativeMethodInfoPtr_RemoveChunkExtension_Private_Static_String_String_0;

		// Token: 0x04001A72 RID: 6770
		private static readonly IntPtr NativeMethodInfoPtr_ReadCRLF_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0;

		// Token: 0x04001A73 RID: 6771
		private static readonly IntPtr NativeMethodInfoPtr_ReadTrailer_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0;

		// Token: 0x04001A74 RID: 6772
		private static readonly IntPtr NativeMethodInfoPtr_ThrowProtocolViolation_Private_Static_Void_String_0;

		// Token: 0x02000344 RID: 836
		public enum State
		{
			// Token: 0x0400258D RID: 9613
			None,
			// Token: 0x0400258E RID: 9614
			PartialSize,
			// Token: 0x0400258F RID: 9615
			Body,
			// Token: 0x04002590 RID: 9616
			BodyFinished,
			// Token: 0x04002591 RID: 9617
			Trailer
		}

		// Token: 0x02000345 RID: 837
		public class Chunk : Object
		{
			// Token: 0x06003026 RID: 12326 RVA: 0x000D054C File Offset: 0x000CE74C
			// Note: this type is marked as 'beforefieldinit'.
			static Chunk()
			{
				Il2CppClassPointerStore<MonoChunkParser.Chunk>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoChunkParser>.NativeClassPtr, "Chunk");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoChunkParser.Chunk>.NativeClassPtr);
				MonoChunkParser.Chunk.NativeFieldInfoPtr_Bytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkParser.Chunk>.NativeClassPtr, "Bytes");
				MonoChunkParser.Chunk.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkParser.Chunk>.NativeClassPtr, "Offset");
				MonoChunkParser.Chunk.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkParser.Chunk>.NativeClassPtr, 100668340);
				MonoChunkParser.Chunk.NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkParser.Chunk>.NativeClassPtr, 100668341);
			}

			// Token: 0x06003027 RID: 12327 RVA: 0x000D05C8 File Offset: 0x000CE7C8
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Chunk(Il2CppStructArray<byte> chunk)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoChunkParser.Chunk>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(chunk);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkParser.Chunk.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003028 RID: 12328 RVA: 0x000D0614 File Offset: 0x000CE814
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482697, XrefRangeEnd = 482698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Read(Il2CppStructArray<byte> buffer, int offset, int size)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkParser.Chunk.NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003029 RID: 12329 RVA: 0x00015DF9 File Offset: 0x00013FF9
			public Chunk(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F16 RID: 3862
			// (get) Token: 0x0600302A RID: 12330 RVA: 0x000D0680 File Offset: 0x000CE880
			// (set) Token: 0x0600302B RID: 12331 RVA: 0x00015E02 File Offset: 0x00014002
			public unsafe Il2CppStructArray<byte> Bytes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkParser.Chunk.NativeFieldInfoPtr_Bytes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkParser.Chunk.NativeFieldInfoPtr_Bytes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F17 RID: 3863
			// (get) Token: 0x0600302C RID: 12332 RVA: 0x000D06B0 File Offset: 0x000CE8B0
			// (set) Token: 0x0600302D RID: 12333 RVA: 0x00015E21 File Offset: 0x00014021
			public unsafe int Offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkParser.Chunk.NativeFieldInfoPtr_Offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkParser.Chunk.NativeFieldInfoPtr_Offset)) = value;
				}
			}

			// Token: 0x04002592 RID: 9618
			private static readonly IntPtr NativeFieldInfoPtr_Bytes;

			// Token: 0x04002593 RID: 9619
			private static readonly IntPtr NativeFieldInfoPtr_Offset;

			// Token: 0x04002594 RID: 9620
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04002595 RID: 9621
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;
		}
	}
}
