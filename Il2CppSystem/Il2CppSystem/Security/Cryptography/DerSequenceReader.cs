using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Text;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020000B3 RID: 179
	public class DerSequenceReader : Object
	{
		// Token: 0x06000C87 RID: 3207 RVA: 0x0004A98C File Offset: 0x00048B8C
		// Note: this type is marked as 'beforefieldinit'.
		static DerSequenceReader()
		{
			Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography", "DerSequenceReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr);
			DerSequenceReader.NativeFieldInfoPtr_s_validityDateTimeFormatInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, "s_validityDateTimeFormatInfo");
			DerSequenceReader.NativeFieldInfoPtr_s_utf8EncodingWithExceptionFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, "s_utf8EncodingWithExceptionFallback");
			DerSequenceReader.NativeFieldInfoPtr_s_latin1Encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, "s_latin1Encoding");
			DerSequenceReader.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, "_data");
			DerSequenceReader.NativeFieldInfoPtr__end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, "_end");
			DerSequenceReader.NativeFieldInfoPtr__position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, "_position");
			DerSequenceReader.NativeFieldInfoPtr__ContentLength_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, "<ContentLength>k__BackingField");
			DerSequenceReader.NativeMethodInfoPtr_set_ContentLength_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665082);
			DerSequenceReader.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665083);
			DerSequenceReader.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665084);
			DerSequenceReader.NativeMethodInfoPtr__ctor_Private_Void_DerTag_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665085);
			DerSequenceReader.NativeMethodInfoPtr_get_HasData_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665086);
			DerSequenceReader.NativeMethodInfoPtr_PeekTag_Internal_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665087);
			DerSequenceReader.NativeMethodInfoPtr_SkipValue_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665088);
			DerSequenceReader.NativeMethodInfoPtr_ReadNextEncodedValue_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665089);
			DerSequenceReader.NativeMethodInfoPtr_ReadBoolean_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665090);
			DerSequenceReader.NativeMethodInfoPtr_ReadInteger_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665091);
			DerSequenceReader.NativeMethodInfoPtr_ReadIntegerBytes_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665092);
			DerSequenceReader.NativeMethodInfoPtr_ReadBitString_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665093);
			DerSequenceReader.NativeMethodInfoPtr_ReadOctetString_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665094);
			DerSequenceReader.NativeMethodInfoPtr_ReadOidAsString_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665095);
			DerSequenceReader.NativeMethodInfoPtr_ReadUtf8String_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665096);
			DerSequenceReader.NativeMethodInfoPtr_ReadCollectionWithTag_Private_DerSequenceReader_DerTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665097);
			DerSequenceReader.NativeMethodInfoPtr_ReadSequence_Internal_DerSequenceReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665098);
			DerSequenceReader.NativeMethodInfoPtr_ReadSet_Internal_DerSequenceReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665099);
			DerSequenceReader.NativeMethodInfoPtr_ReadPrintableString_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665100);
			DerSequenceReader.NativeMethodInfoPtr_ReadIA5String_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665101);
			DerSequenceReader.NativeMethodInfoPtr_ReadT61String_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665102);
			DerSequenceReader.NativeMethodInfoPtr_ReadX509Date_Internal_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665103);
			DerSequenceReader.NativeMethodInfoPtr_ReadUtcTime_Internal_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665104);
			DerSequenceReader.NativeMethodInfoPtr_ReadGeneralizedTime_Internal_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665105);
			DerSequenceReader.NativeMethodInfoPtr_ReadBMPString_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665106);
			DerSequenceReader.NativeMethodInfoPtr_TrimTrailingNulls_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665107);
			DerSequenceReader.NativeMethodInfoPtr_ReadTime_Private_DateTime_DerTag_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665108);
			DerSequenceReader.NativeMethodInfoPtr_ReadContentAsBytes_Private_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665109);
			DerSequenceReader.NativeMethodInfoPtr_EatTag_Private_Void_DerTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665110);
			DerSequenceReader.NativeMethodInfoPtr_CheckTag_Private_Static_Void_DerTag_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665111);
			DerSequenceReader.NativeMethodInfoPtr_EatLength_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665112);
			DerSequenceReader.NativeMethodInfoPtr_ScanContentLength_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, 100665113);
		}

		// Token: 0x170003C8 RID: 968
		// (set) Token: 0x06000C88 RID: 3208 RVA: 0x0004ACC8 File Offset: 0x00048EC8
		public unsafe int ContentLength
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_set_ContentLength_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x0004AD08 File Offset: 0x00048F08
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 452062, RefRangeEnd = 452066, XrefRangeStart = 452061, XrefRangeEnd = 452062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DerSequenceReader(Il2CppStructArray<byte> data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x0004AD54 File Offset: 0x00048F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452066, XrefRangeEnd = 452067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DerSequenceReader(Il2CppStructArray<byte> data, int offset, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x0004ADBC File Offset: 0x00048FBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 452071, RefRangeEnd = 452074, XrefRangeStart = 452067, XrefRangeEnd = 452071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DerSequenceReader(DerSequenceReader.DerTag tagToEat, Il2CppStructArray<byte> data, int offset, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tagToEat;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr__ctor_Private_Void_DerTag_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000C8C RID: 3212 RVA: 0x0004AE34 File Offset: 0x00049034
		public unsafe bool HasData
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 452074, RefRangeEnd = 452092, XrefRangeStart = 452074, XrefRangeEnd = 452074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_get_HasData_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x0004AE70 File Offset: 0x00049070
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 452092, RefRangeEnd = 452104, XrefRangeStart = 452092, XrefRangeEnd = 452092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte PeekTag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_PeekTag_Internal_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x0004AEAC File Offset: 0x000490AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452104, XrefRangeEnd = 452107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_SkipValue_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x0004AEE0 File Offset: 0x000490E0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 452113, RefRangeEnd = 452119, XrefRangeStart = 452107, XrefRangeEnd = 452113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> ReadNextEncodedValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_ReadNextEncodedValue_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x0004AF20 File Offset: 0x00049120
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 452121, RefRangeEnd = 452122, XrefRangeStart = 452119, XrefRangeEnd = 452121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadBoolean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_ReadBoolean_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x0004AF5C File Offset: 0x0004915C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 452132, RefRangeEnd = 452133, XrefRangeStart = 452122, XrefRangeEnd = 452132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadInteger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_ReadInteger_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x0004AF98 File Offset: 0x00049198
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 452135, RefRangeEnd = 452136, XrefRangeStart = 452133, XrefRangeEnd = 452135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> ReadIntegerBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_ReadIntegerBytes_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x0004AFD8 File Offset: 0x000491D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 452142, RefRangeEnd = 452146, XrefRangeStart = 452136, XrefRangeEnd = 452142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> ReadBitString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_ReadBitString_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x0004B018 File Offset: 0x00049218
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 452148, RefRangeEnd = 452149, XrefRangeStart = 452146, XrefRangeEnd = 452148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> ReadOctetString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_ReadOctetString_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x0004B058 File Offset: 0x00049258
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 452174, RefRangeEnd = 452180, XrefRangeStart = 452149, XrefRangeEnd = 452174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadOidAsString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_ReadOidAsString_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x0004B090 File Offset: 0x00049290
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 452185, RefRangeEnd = 452187, XrefRangeStart = 452180, XrefRangeEnd = 452185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadUtf8String()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_ReadUtf8String_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x0004B0C8 File Offset: 0x000492C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 452193, RefRangeEnd = 452195, XrefRangeStart = 452187, XrefRangeEnd = 452193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DerSequenceReader ReadCollectionWithTag(DerSequenceReader.DerTag expected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expected;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_ReadCollectionWithTag_Private_DerSequenceReader_DerTag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DerSequenceReader>(intPtr3) : null;
			}
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x0004B114 File Offset: 0x00049314
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 452196, RefRangeEnd = 452208, XrefRangeStart = 452195, XrefRangeEnd = 452196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DerSequenceReader ReadSequence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_ReadSequence_Internal_DerSequenceReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DerSequenceReader>(intPtr3) : null;
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x0004B154 File Offset: 0x00049354
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 452209, RefRangeEnd = 452210, XrefRangeStart = 452208, XrefRangeEnd = 452209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DerSequenceReader ReadSet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_ReadSet_Internal_DerSequenceReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DerSequenceReader>(intPtr3) : null;
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x0004B194 File Offset: 0x00049394
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 452215, RefRangeEnd = 452216, XrefRangeStart = 452210, XrefRangeEnd = 452215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadPrintableString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_ReadPrintableString_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x0004B1CC File Offset: 0x000493CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 452221, RefRangeEnd = 452222, XrefRangeStart = 452216, XrefRangeEnd = 452221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadIA5String()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_ReadIA5String_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x0004B204 File Offset: 0x00049404
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 452264, RefRangeEnd = 452265, XrefRangeStart = 452222, XrefRangeEnd = 452264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadT61String()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_ReadT61String_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x0004B23C File Offset: 0x0004943C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 452278, RefRangeEnd = 452280, XrefRangeStart = 452265, XrefRangeEnd = 452278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime ReadX509Date()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_ReadX509Date_Internal_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x0004B278 File Offset: 0x00049478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452280, XrefRangeEnd = 452283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime ReadUtcTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_ReadUtcTime_Internal_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x0004B2B4 File Offset: 0x000494B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452283, XrefRangeEnd = 452286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime ReadGeneralizedTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_ReadGeneralizedTime_Internal_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x0004B2F0 File Offset: 0x000494F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 452291, RefRangeEnd = 452292, XrefRangeStart = 452286, XrefRangeEnd = 452291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadBMPString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_ReadBMPString_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x0004B328 File Offset: 0x00049528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452292, XrefRangeEnd = 452294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TrimTrailingNulls(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_TrimTrailingNulls_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x0004B364 File Offset: 0x00049564
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 452321, RefRangeEnd = 452325, XrefRangeStart = 452294, XrefRangeEnd = 452321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime ReadTime(DerSequenceReader.DerTag timeTag, string formatString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeTag;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(formatString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_ReadTime_Private_DateTime_DerTag_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x0004B3C0 File Offset: 0x000495C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 452330, RefRangeEnd = 452333, XrefRangeStart = 452325, XrefRangeEnd = 452330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> ReadContentAsBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_ReadContentAsBytes_Private_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x0004B400 File Offset: 0x00049600
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 452334, RefRangeEnd = 452347, XrefRangeStart = 452333, XrefRangeEnd = 452334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EatTag(DerSequenceReader.DerTag expected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expected;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_EatTag_Private_Void_DerTag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x0004B440 File Offset: 0x00049640
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 452347, RefRangeEnd = 452350, XrefRangeStart = 452347, XrefRangeEnd = 452347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckTag(DerSequenceReader.DerTag expected, Il2CppStructArray<byte> data, int position)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expected;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_CheckTag_Private_Static_Void_DerTag_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x0004B494 File Offset: 0x00049694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452350, XrefRangeEnd = 452351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EatLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_EatLength_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x0004B4D0 File Offset: 0x000496D0
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 452351, RefRangeEnd = 452366, XrefRangeStart = 452351, XrefRangeEnd = 452351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ScanContentLength(Il2CppStructArray<byte> data, int offset, int end, out int bytesConsumed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bytesConsumed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.NativeMethodInfoPtr_ScanContentLength_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x00006AF7 File Offset: 0x00004CF7
		public DerSequenceReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x0004B53C File Offset: 0x0004973C
		// (set) Token: 0x06000CAA RID: 3242 RVA: 0x00006B00 File Offset: 0x00004D00
		public unsafe static DateTimeFormatInfo s_validityDateTimeFormatInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DerSequenceReader.NativeFieldInfoPtr_s_validityDateTimeFormatInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DerSequenceReader.NativeFieldInfoPtr_s_validityDateTimeFormatInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x0004B564 File Offset: 0x00049764
		// (set) Token: 0x06000CAC RID: 3244 RVA: 0x00006B12 File Offset: 0x00004D12
		public unsafe static Encoding s_utf8EncodingWithExceptionFallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DerSequenceReader.NativeFieldInfoPtr_s_utf8EncodingWithExceptionFallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DerSequenceReader.NativeFieldInfoPtr_s_utf8EncodingWithExceptionFallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x0004B58C File Offset: 0x0004978C
		// (set) Token: 0x06000CAE RID: 3246 RVA: 0x00006B24 File Offset: 0x00004D24
		public unsafe static Encoding s_latin1Encoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DerSequenceReader.NativeFieldInfoPtr_s_latin1Encoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DerSequenceReader.NativeFieldInfoPtr_s_latin1Encoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x0004B5B4 File Offset: 0x000497B4
		// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x00006B36 File Offset: 0x00004D36
		public unsafe Il2CppStructArray<byte> _data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DerSequenceReader.NativeFieldInfoPtr__data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DerSequenceReader.NativeFieldInfoPtr__data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x0004B5E4 File Offset: 0x000497E4
		// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x00006B55 File Offset: 0x00004D55
		public unsafe int _end
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DerSequenceReader.NativeFieldInfoPtr__end);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DerSequenceReader.NativeFieldInfoPtr__end)) = value;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x0004B60C File Offset: 0x0004980C
		// (set) Token: 0x06000CB4 RID: 3252 RVA: 0x00006B70 File Offset: 0x00004D70
		public unsafe int _position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DerSequenceReader.NativeFieldInfoPtr__position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DerSequenceReader.NativeFieldInfoPtr__position)) = value;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x0004B634 File Offset: 0x00049834
		// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x00006B8B File Offset: 0x00004D8B
		public unsafe int _ContentLength_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DerSequenceReader.NativeFieldInfoPtr__ContentLength_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DerSequenceReader.NativeFieldInfoPtr__ContentLength_k__BackingField)) = value;
			}
		}

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeFieldInfoPtr_s_validityDateTimeFormatInfo;

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeFieldInfoPtr_s_utf8EncodingWithExceptionFallback;

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeFieldInfoPtr_s_latin1Encoding;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeFieldInfoPtr__data;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeFieldInfoPtr__end;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeFieldInfoPtr__position;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeFieldInfoPtr__ContentLength_k__BackingField;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeMethodInfoPtr_set_ContentLength_Private_set_Void_Int32_0;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_DerTag_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeMethodInfoPtr_get_HasData_Internal_get_Boolean_0;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeMethodInfoPtr_PeekTag_Internal_Byte_0;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeMethodInfoPtr_SkipValue_Internal_Void_0;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeMethodInfoPtr_ReadNextEncodedValue_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeMethodInfoPtr_ReadBoolean_Internal_Boolean_0;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeMethodInfoPtr_ReadInteger_Internal_Int32_0;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeMethodInfoPtr_ReadIntegerBytes_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeMethodInfoPtr_ReadBitString_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeMethodInfoPtr_ReadOctetString_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeMethodInfoPtr_ReadOidAsString_Internal_String_0;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeMethodInfoPtr_ReadUtf8String_Internal_String_0;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeMethodInfoPtr_ReadCollectionWithTag_Private_DerSequenceReader_DerTag_0;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeMethodInfoPtr_ReadSequence_Internal_DerSequenceReader_0;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeMethodInfoPtr_ReadSet_Internal_DerSequenceReader_0;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeMethodInfoPtr_ReadPrintableString_Internal_String_0;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeMethodInfoPtr_ReadIA5String_Internal_String_0;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeMethodInfoPtr_ReadT61String_Internal_String_0;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeMethodInfoPtr_ReadX509Date_Internal_DateTime_0;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeMethodInfoPtr_ReadUtcTime_Internal_DateTime_0;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeMethodInfoPtr_ReadGeneralizedTime_Internal_DateTime_0;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeMethodInfoPtr_ReadBMPString_Internal_String_0;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeMethodInfoPtr_TrimTrailingNulls_Private_Static_String_String_0;

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeMethodInfoPtr_ReadTime_Private_DateTime_DerTag_String_0;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeMethodInfoPtr_ReadContentAsBytes_Private_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeMethodInfoPtr_EatTag_Private_Void_DerTag_0;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeMethodInfoPtr_CheckTag_Private_Static_Void_DerTag_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeMethodInfoPtr_EatLength_Private_Int32_0;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeMethodInfoPtr_ScanContentLength_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Int32_0;

		// Token: 0x020002D3 RID: 723
		public enum DerTag : byte
		{
			// Token: 0x040022AE RID: 8878
			Boolean = 1,
			// Token: 0x040022AF RID: 8879
			Integer,
			// Token: 0x040022B0 RID: 8880
			BitString,
			// Token: 0x040022B1 RID: 8881
			OctetString,
			// Token: 0x040022B2 RID: 8882
			Null,
			// Token: 0x040022B3 RID: 8883
			ObjectIdentifier,
			// Token: 0x040022B4 RID: 8884
			UTF8String = 12,
			// Token: 0x040022B5 RID: 8885
			Sequence = 16,
			// Token: 0x040022B6 RID: 8886
			Set,
			// Token: 0x040022B7 RID: 8887
			PrintableString = 19,
			// Token: 0x040022B8 RID: 8888
			T61String,
			// Token: 0x040022B9 RID: 8889
			IA5String = 22,
			// Token: 0x040022BA RID: 8890
			UTCTime,
			// Token: 0x040022BB RID: 8891
			GeneralizedTime,
			// Token: 0x040022BC RID: 8892
			BMPString = 30
		}

		// Token: 0x020002D4 RID: 724
		[ObfuscatedName("System.Security.Cryptography.DerSequenceReader+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002BDF RID: 11231 RVA: 0x000C1CA0 File Offset: 0x000BFEA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DerSequenceReader.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DerSequenceReader>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DerSequenceReader.__c>.NativeClassPtr);
				DerSequenceReader.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DerSequenceReader.__c>.NativeClassPtr, "<>9");
				DerSequenceReader.__c.NativeFieldInfoPtr___9__45_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DerSequenceReader.__c>.NativeClassPtr, "<>9__45_0");
				DerSequenceReader.__c.NativeFieldInfoPtr___9__45_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DerSequenceReader.__c>.NativeClassPtr, "<>9__45_1");
				DerSequenceReader.__c.NativeFieldInfoPtr___9__51_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DerSequenceReader.__c>.NativeClassPtr, "<>9__51_0");
				DerSequenceReader.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader.__c>.NativeClassPtr, 100665115);
				DerSequenceReader.__c.NativeMethodInfoPtr__ReadT61String_b__45_0_Internal_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader.__c>.NativeClassPtr, 100665116);
				DerSequenceReader.__c.NativeMethodInfoPtr__ReadT61String_b__45_1_Internal_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader.__c>.NativeClassPtr, 100665117);
				DerSequenceReader.__c.NativeMethodInfoPtr__ReadTime_b__51_0_Internal_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerSequenceReader.__c>.NativeClassPtr, 100665118);
			}

			// Token: 0x06002BE0 RID: 11232 RVA: 0x000C1D6C File Offset: 0x000BFF6C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DerSequenceReader.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002BE1 RID: 11233 RVA: 0x000C1DA8 File Offset: 0x000BFFA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452047, XrefRangeEnd = 452051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Encoding _ReadT61String_b__45_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.__c.NativeMethodInfoPtr__ReadT61String_b__45_0_Internal_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}

			// Token: 0x06002BE2 RID: 11234 RVA: 0x000C1DE8 File Offset: 0x000BFFE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452051, XrefRangeEnd = 452054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Encoding _ReadT61String_b__45_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.__c.NativeMethodInfoPtr__ReadT61String_b__45_1_Internal_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}

			// Token: 0x06002BE3 RID: 11235 RVA: 0x000C1E28 File Offset: 0x000C0028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452054, XrefRangeEnd = 452061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DateTimeFormatInfo _ReadTime_b__51_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DerSequenceReader.__c.NativeMethodInfoPtr__ReadTime_b__51_0_Internal_DateTimeFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr3) : null;
			}

			// Token: 0x06002BE4 RID: 11236 RVA: 0x00013C56 File Offset: 0x00011E56
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DC7 RID: 3527
			// (get) Token: 0x06002BE5 RID: 11237 RVA: 0x000C1E68 File Offset: 0x000C0068
			// (set) Token: 0x06002BE6 RID: 11238 RVA: 0x00013C5F File Offset: 0x00011E5F
			public unsafe static DerSequenceReader.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DerSequenceReader.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DerSequenceReader.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DerSequenceReader.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DC8 RID: 3528
			// (get) Token: 0x06002BE7 RID: 11239 RVA: 0x000C1E90 File Offset: 0x000C0090
			// (set) Token: 0x06002BE8 RID: 11240 RVA: 0x00013C71 File Offset: 0x00011E71
			public unsafe static Func<Encoding> __9__45_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DerSequenceReader.__c.NativeFieldInfoPtr___9__45_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Encoding>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DerSequenceReader.__c.NativeFieldInfoPtr___9__45_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DC9 RID: 3529
			// (get) Token: 0x06002BE9 RID: 11241 RVA: 0x000C1EB8 File Offset: 0x000C00B8
			// (set) Token: 0x06002BEA RID: 11242 RVA: 0x00013C83 File Offset: 0x00011E83
			public unsafe static Func<Encoding> __9__45_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DerSequenceReader.__c.NativeFieldInfoPtr___9__45_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Encoding>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DerSequenceReader.__c.NativeFieldInfoPtr___9__45_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DCA RID: 3530
			// (get) Token: 0x06002BEB RID: 11243 RVA: 0x000C1EE0 File Offset: 0x000C00E0
			// (set) Token: 0x06002BEC RID: 11244 RVA: 0x00013C95 File Offset: 0x00011E95
			public unsafe static Func<DateTimeFormatInfo> __9__51_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DerSequenceReader.__c.NativeFieldInfoPtr___9__51_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DateTimeFormatInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DerSequenceReader.__c.NativeFieldInfoPtr___9__51_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040022BD RID: 8893
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040022BE RID: 8894
			private static readonly IntPtr NativeFieldInfoPtr___9__45_0;

			// Token: 0x040022BF RID: 8895
			private static readonly IntPtr NativeFieldInfoPtr___9__45_1;

			// Token: 0x040022C0 RID: 8896
			private static readonly IntPtr NativeFieldInfoPtr___9__51_0;

			// Token: 0x040022C1 RID: 8897
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040022C2 RID: 8898
			private static readonly IntPtr NativeMethodInfoPtr__ReadT61String_b__45_0_Internal_Encoding_0;

			// Token: 0x040022C3 RID: 8899
			private static readonly IntPtr NativeMethodInfoPtr__ReadT61String_b__45_1_Internal_Encoding_0;

			// Token: 0x040022C4 RID: 8900
			private static readonly IntPtr NativeMethodInfoPtr__ReadTime_b__51_0_Internal_DateTimeFormatInfo_0;
		}
	}
}
