using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.IO;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000364 RID: 868
	public sealed class __BinaryWriter : Object
	{
		// Token: 0x0600347C RID: 13436 RVA: 0x001052CC File Offset: 0x001034CC
		// Note: this type is marked as 'beforefieldinit'.
		static __BinaryWriter()
		{
			Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "__BinaryWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr);
			__BinaryWriter.NativeFieldInfoPtr_sout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "sout");
			__BinaryWriter.NativeFieldInfoPtr_formatterTypeStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "formatterTypeStyle");
			__BinaryWriter.NativeFieldInfoPtr_objectMapTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "objectMapTable");
			__BinaryWriter.NativeFieldInfoPtr_objectWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "objectWriter");
			__BinaryWriter.NativeFieldInfoPtr_dataWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "dataWriter");
			__BinaryWriter.NativeFieldInfoPtr_m_nestedObjectCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "m_nestedObjectCount");
			__BinaryWriter.NativeFieldInfoPtr_nullCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "nullCount");
			__BinaryWriter.NativeFieldInfoPtr_binaryMethodCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "binaryMethodCall");
			__BinaryWriter.NativeFieldInfoPtr_binaryMethodReturn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "binaryMethodReturn");
			__BinaryWriter.NativeFieldInfoPtr_binaryObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "binaryObject");
			__BinaryWriter.NativeFieldInfoPtr_binaryObjectWithMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "binaryObjectWithMap");
			__BinaryWriter.NativeFieldInfoPtr_binaryObjectWithMapTyped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "binaryObjectWithMapTyped");
			__BinaryWriter.NativeFieldInfoPtr_binaryObjectString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "binaryObjectString");
			__BinaryWriter.NativeFieldInfoPtr_binaryArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "binaryArray");
			__BinaryWriter.NativeFieldInfoPtr_byteBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "byteBuffer");
			__BinaryWriter.NativeFieldInfoPtr_chunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "chunkSize");
			__BinaryWriter.NativeFieldInfoPtr_memberPrimitiveUnTyped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "memberPrimitiveUnTyped");
			__BinaryWriter.NativeFieldInfoPtr_memberPrimitiveTyped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "memberPrimitiveTyped");
			__BinaryWriter.NativeFieldInfoPtr_objectNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "objectNull");
			__BinaryWriter.NativeFieldInfoPtr_memberReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "memberReference");
			__BinaryWriter.NativeFieldInfoPtr_binaryAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "binaryAssembly");
			__BinaryWriter.NativeMethodInfoPtr__ctor_Internal_Void_Stream_ObjectWriter_FormatterTypeStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671347);
			__BinaryWriter.NativeMethodInfoPtr_WriteBegin_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671348);
			__BinaryWriter.NativeMethodInfoPtr_WriteEnd_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671349);
			__BinaryWriter.NativeMethodInfoPtr_WriteBoolean_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671350);
			__BinaryWriter.NativeMethodInfoPtr_WriteByte_Internal_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671351);
			__BinaryWriter.NativeMethodInfoPtr_WriteBytes_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671352);
			__BinaryWriter.NativeMethodInfoPtr_WriteBytes_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671353);
			__BinaryWriter.NativeMethodInfoPtr_WriteChar_Internal_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671354);
			__BinaryWriter.NativeMethodInfoPtr_WriteChars_Internal_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671355);
			__BinaryWriter.NativeMethodInfoPtr_WriteDecimal_Internal_Void_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671356);
			__BinaryWriter.NativeMethodInfoPtr_WriteSingle_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671357);
			__BinaryWriter.NativeMethodInfoPtr_WriteDouble_Internal_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671358);
			__BinaryWriter.NativeMethodInfoPtr_WriteInt16_Internal_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671359);
			__BinaryWriter.NativeMethodInfoPtr_WriteInt32_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671360);
			__BinaryWriter.NativeMethodInfoPtr_WriteInt64_Internal_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671361);
			__BinaryWriter.NativeMethodInfoPtr_WriteSByte_Internal_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671362);
			__BinaryWriter.NativeMethodInfoPtr_WriteString_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671363);
			__BinaryWriter.NativeMethodInfoPtr_WriteTimeSpan_Internal_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671364);
			__BinaryWriter.NativeMethodInfoPtr_WriteDateTime_Internal_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671365);
			__BinaryWriter.NativeMethodInfoPtr_WriteUInt16_Internal_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671366);
			__BinaryWriter.NativeMethodInfoPtr_WriteUInt32_Internal_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671367);
			__BinaryWriter.NativeMethodInfoPtr_WriteUInt64_Internal_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671368);
			__BinaryWriter.NativeMethodInfoPtr_WriteObjectEnd_Internal_Void_NameInfo_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671369);
			__BinaryWriter.NativeMethodInfoPtr_WriteSerializationHeaderEnd_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671370);
			__BinaryWriter.NativeMethodInfoPtr_WriteSerializationHeader_Internal_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671371);
			__BinaryWriter.NativeMethodInfoPtr_WriteMethodCall_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671372);
			__BinaryWriter.NativeMethodInfoPtr_WriteMethodReturn_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671373);
			__BinaryWriter.NativeMethodInfoPtr_WriteObject_Internal_Void_NameInfo_NameInfo_Int32_Il2CppStringArray_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_WriteObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671374);
			__BinaryWriter.NativeMethodInfoPtr_WriteObjectString_Internal_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671375);
			__BinaryWriter.NativeMethodInfoPtr_WriteSingleArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Int32_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671376);
			__BinaryWriter.NativeMethodInfoPtr_WriteArrayAsBytes_Private_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671377);
			__BinaryWriter.NativeMethodInfoPtr_WriteJaggedArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671378);
			__BinaryWriter.NativeMethodInfoPtr_WriteRectangleArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671379);
			__BinaryWriter.NativeMethodInfoPtr_WriteObjectByteArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671380);
			__BinaryWriter.NativeMethodInfoPtr_WriteMember_Internal_Void_NameInfo_NameInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671381);
			__BinaryWriter.NativeMethodInfoPtr_WriteNullMember_Internal_Void_NameInfo_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671382);
			__BinaryWriter.NativeMethodInfoPtr_WriteMemberObjectRef_Internal_Void_NameInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671383);
			__BinaryWriter.NativeMethodInfoPtr_WriteMemberNested_Internal_Void_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671384);
			__BinaryWriter.NativeMethodInfoPtr_WriteMemberString_Internal_Void_NameInfo_NameInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671385);
			__BinaryWriter.NativeMethodInfoPtr_WriteItem_Internal_Void_NameInfo_NameInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671386);
			__BinaryWriter.NativeMethodInfoPtr_WriteNullItem_Internal_Void_NameInfo_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671387);
			__BinaryWriter.NativeMethodInfoPtr_WriteDelayedNullItem_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671388);
			__BinaryWriter.NativeMethodInfoPtr_WriteItemEnd_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671389);
			__BinaryWriter.NativeMethodInfoPtr_InternalWriteItemNull_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671390);
			__BinaryWriter.NativeMethodInfoPtr_WriteItemObjectRef_Internal_Void_NameInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671391);
			__BinaryWriter.NativeMethodInfoPtr_WriteAssembly_Internal_Void_Type_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671392);
			__BinaryWriter.NativeMethodInfoPtr_WriteValue_Internal_Void_InternalPrimitiveTypeE_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671393);
		}

		// Token: 0x0600347D RID: 13437 RVA: 0x0010584C File Offset: 0x00103A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388136, XrefRangeEnd = 1388152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __BinaryWriter(Stream sout, ObjectWriter objectWriter, FormatterTypeStyle formatterTypeStyle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectWriter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatterTypeStyle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr__ctor_Internal_Void_Stream_ObjectWriter_FormatterTypeStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600347E RID: 13438 RVA: 0x001058B8 File Offset: 0x00103AB8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteBegin_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600347F RID: 13439 RVA: 0x001058EC File Offset: 0x00103AEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1388153, RefRangeEnd = 1388154, XrefRangeStart = 1388152, XrefRangeEnd = 1388153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteEnd_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003480 RID: 13440 RVA: 0x00105920 File Offset: 0x00103B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388154, XrefRangeEnd = 1388155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteBoolean(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteBoolean_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x00105960 File Offset: 0x00103B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388155, XrefRangeEnd = 1388156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteByte(byte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteByte_Internal_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003482 RID: 13442 RVA: 0x001059A0 File Offset: 0x00103BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388156, XrefRangeEnd = 1388157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteBytes(Il2CppStructArray<byte> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteBytes_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003483 RID: 13443 RVA: 0x001059E4 File Offset: 0x00103BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388157, XrefRangeEnd = 1388158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteBytes(Il2CppStructArray<byte> byteA, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(byteA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteBytes_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003484 RID: 13444 RVA: 0x00105A44 File Offset: 0x00103C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388158, XrefRangeEnd = 1388159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteChar(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteChar_Internal_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003485 RID: 13445 RVA: 0x00105A84 File Offset: 0x00103C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteChars(Il2CppStructArray<char> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteChars_Internal_Void_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003486 RID: 13446 RVA: 0x00105AC8 File Offset: 0x00103CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388159, XrefRangeEnd = 1388167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteDecimal(Decimal value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteDecimal_Internal_Void_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003487 RID: 13447 RVA: 0x00105B08 File Offset: 0x00103D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388167, XrefRangeEnd = 1388168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSingle(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteSingle_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003488 RID: 13448 RVA: 0x00105B48 File Offset: 0x00103D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388168, XrefRangeEnd = 1388169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteDouble(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteDouble_Internal_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003489 RID: 13449 RVA: 0x00105B88 File Offset: 0x00103D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteInt16(short value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteInt16_Internal_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600348A RID: 13450 RVA: 0x00105BC8 File Offset: 0x00103DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388169, XrefRangeEnd = 1388170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteInt32(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteInt32_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600348B RID: 13451 RVA: 0x00105C08 File Offset: 0x00103E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388170, XrefRangeEnd = 1388171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteInt64(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteInt64_Internal_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600348C RID: 13452 RVA: 0x00105C48 File Offset: 0x00103E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSByte(sbyte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteSByte_Internal_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600348D RID: 13453 RVA: 0x00105C88 File Offset: 0x00103E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388171, XrefRangeEnd = 1388172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteString(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteString_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600348E RID: 13454 RVA: 0x00105CCC File Offset: 0x00103ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388172, XrefRangeEnd = 1388176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteTimeSpan(TimeSpan value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteTimeSpan_Internal_Void_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600348F RID: 13455 RVA: 0x00105D0C File Offset: 0x00103F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388176, XrefRangeEnd = 1388180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteDateTime(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteDateTime_Internal_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003490 RID: 13456 RVA: 0x00105D4C File Offset: 0x00103F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388180, XrefRangeEnd = 1388181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteUInt16(ushort value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteUInt16_Internal_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003491 RID: 13457 RVA: 0x00105D8C File Offset: 0x00103F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388181, XrefRangeEnd = 1388182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteUInt32(uint value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteUInt32_Internal_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003492 RID: 13458 RVA: 0x00105DCC File Offset: 0x00103FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388182, XrefRangeEnd = 1388183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteUInt64(ulong value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteUInt64_Internal_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003493 RID: 13459 RVA: 0x00105E0C File Offset: 0x0010400C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteObjectEnd(NameInfo memberNameInfo, NameInfo typeNameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteObjectEnd_Internal_Void_NameInfo_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003494 RID: 13460 RVA: 0x00105E60 File Offset: 0x00104060
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1388188, RefRangeEnd = 1388189, XrefRangeStart = 1388183, XrefRangeEnd = 1388188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSerializationHeaderEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteSerializationHeaderEnd_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003495 RID: 13461 RVA: 0x00105E94 File Offset: 0x00104094
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1388194, RefRangeEnd = 1388196, XrefRangeStart = 1388189, XrefRangeEnd = 1388194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSerializationHeader(int topId, int headerId, int minorVersion, int majorVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref topId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headerId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minorVersion;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref majorVersion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteSerializationHeader_Internal_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003496 RID: 13462 RVA: 0x00105EFC File Offset: 0x001040FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388196, XrefRangeEnd = 1388203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMethodCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteMethodCall_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003497 RID: 13463 RVA: 0x00105F30 File Offset: 0x00104130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388203, XrefRangeEnd = 1388210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMethodReturn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteMethodReturn_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003498 RID: 13464 RVA: 0x00105F64 File Offset: 0x00104164
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1388235, RefRangeEnd = 1388237, XrefRangeStart = 1388210, XrefRangeEnd = 1388235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteObject(NameInfo nameInfo, NameInfo typeNameInfo, int numMembers, Il2CppStringArray memberNames, Il2CppReferenceArray<Type> memberTypes, Il2CppReferenceArray<WriteObjectInfo> memberObjectInfos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numMembers;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberTypes);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberObjectInfos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteObject_Internal_Void_NameInfo_NameInfo_Int32_Il2CppStringArray_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_WriteObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003499 RID: 13465 RVA: 0x00106000 File Offset: 0x00104200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388237, XrefRangeEnd = 1388245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteObjectString(int objectId, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteObjectString_Internal_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600349A RID: 13466 RVA: 0x00106050 File Offset: 0x00104250
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1388287, RefRangeEnd = 1388288, XrefRangeStart = 1388245, XrefRangeEnd = 1388287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSingleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Array array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayElemTypeNameInfo);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowerBound;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteSingleArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Int32_Array_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600349B RID: 13467 RVA: 0x001060F8 File Offset: 0x001042F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388288, XrefRangeEnd = 1388302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteArrayAsBytes(Array array, int typeLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref typeLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteArrayAsBytes_Private_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600349C RID: 13468 RVA: 0x00106148 File Offset: 0x00104348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388302, XrefRangeEnd = 1388318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteJaggedArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayElemTypeNameInfo);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowerBound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteJaggedArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600349D RID: 13469 RVA: 0x001061E0 File Offset: 0x001043E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388318, XrefRangeEnd = 1388328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteRectangleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int rank, Il2CppStructArray<int> lengthA, Il2CppStructArray<int> lowerBoundA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayElemTypeNameInfo);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lengthA);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lowerBoundA);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteRectangleArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600349E RID: 13470 RVA: 0x00106290 File Offset: 0x00104490
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1388330, RefRangeEnd = 1388331, XrefRangeStart = 1388328, XrefRangeEnd = 1388330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteObjectByteArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Il2CppStructArray<byte> byteA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayElemTypeNameInfo);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowerBound;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(byteA);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteObjectByteArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600349F RID: 13471 RVA: 0x00106338 File Offset: 0x00104538
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1388347, RefRangeEnd = 1388349, XrefRangeStart = 1388331, XrefRangeEnd = 1388347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMember(NameInfo memberNameInfo, NameInfo typeNameInfo, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteMember_Internal_Void_NameInfo_NameInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034A0 RID: 13472 RVA: 0x001063A0 File Offset: 0x001045A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1388356, RefRangeEnd = 1388359, XrefRangeStart = 1388349, XrefRangeEnd = 1388356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteNullMember(NameInfo memberNameInfo, NameInfo typeNameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteNullMember_Internal_Void_NameInfo_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034A1 RID: 13473 RVA: 0x001063F4 File Offset: 0x001045F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1388366, RefRangeEnd = 1388368, XrefRangeStart = 1388359, XrefRangeEnd = 1388366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMemberObjectRef(NameInfo memberNameInfo, int idRef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idRef;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteMemberObjectRef_Internal_Void_NameInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x00106444 File Offset: 0x00104644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1388369, RefRangeEnd = 1388370, XrefRangeStart = 1388368, XrefRangeEnd = 1388369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMemberNested(NameInfo memberNameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteMemberNested_Internal_Void_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034A3 RID: 13475 RVA: 0x00106488 File Offset: 0x00104688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388370, XrefRangeEnd = 1388379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMemberString(NameInfo memberNameInfo, NameInfo typeNameInfo, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteMemberString_Internal_Void_NameInfo_NameInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034A4 RID: 13476 RVA: 0x001064F0 File Offset: 0x001046F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1388381, RefRangeEnd = 1388382, XrefRangeStart = 1388379, XrefRangeEnd = 1388381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteItem(NameInfo itemNameInfo, NameInfo typeNameInfo, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteItem_Internal_Void_NameInfo_NameInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034A5 RID: 13477 RVA: 0x00106558 File Offset: 0x00104758
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1388383, RefRangeEnd = 1388384, XrefRangeStart = 1388382, XrefRangeEnd = 1388383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteNullItem(NameInfo itemNameInfo, NameInfo typeNameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteNullItem_Internal_Void_NameInfo_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034A6 RID: 13478 RVA: 0x001065AC File Offset: 0x001047AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1388384, RefRangeEnd = 1388385, XrefRangeStart = 1388384, XrefRangeEnd = 1388384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteDelayedNullItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteDelayedNullItem_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034A7 RID: 13479 RVA: 0x001065E0 File Offset: 0x001047E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388385, XrefRangeEnd = 1388386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteItemEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteItemEnd_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034A8 RID: 13480 RVA: 0x00106614 File Offset: 0x00104814
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1388392, RefRangeEnd = 1388412, XrefRangeStart = 1388386, XrefRangeEnd = 1388392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalWriteItemNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_InternalWriteItemNull_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034A9 RID: 13481 RVA: 0x00106648 File Offset: 0x00104848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388412, XrefRangeEnd = 1388420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteItemObjectRef(NameInfo nameInfo, int idRef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idRef;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteItemObjectRef_Internal_Void_NameInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034AA RID: 13482 RVA: 0x00106698 File Offset: 0x00104898
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1388429, RefRangeEnd = 1388430, XrefRangeStart = 1388420, XrefRangeEnd = 1388429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteAssembly(Type type, string assemblyString, int assemId, bool isNew)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assemId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNew;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteAssembly_Internal_Void_Type_String_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034AB RID: 13483 RVA: 0x00106708 File Offset: 0x00104908
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1388466, RefRangeEnd = 1388473, XrefRangeStart = 1388430, XrefRangeEnd = 1388466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteValue(InternalPrimitiveTypeE code, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteValue_Internal_Void_InternalPrimitiveTypeE_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034AC RID: 13484 RVA: 0x000128D0 File Offset: 0x00010AD0
		public __BinaryWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x060034AD RID: 13485 RVA: 0x00106758 File Offset: 0x00104958
		// (set) Token: 0x060034AE RID: 13486 RVA: 0x000128D9 File Offset: 0x00010AD9
		public unsafe Stream sout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_sout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_sout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x060034AF RID: 13487 RVA: 0x00106788 File Offset: 0x00104988
		// (set) Token: 0x060034B0 RID: 13488 RVA: 0x000128F8 File Offset: 0x00010AF8
		public unsafe FormatterTypeStyle formatterTypeStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_formatterTypeStyle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_formatterTypeStyle)) = value;
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x060034B1 RID: 13489 RVA: 0x001067B0 File Offset: 0x001049B0
		// (set) Token: 0x060034B2 RID: 13490 RVA: 0x00012913 File Offset: 0x00010B13
		public unsafe Hashtable objectMapTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_objectMapTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_objectMapTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x060034B3 RID: 13491 RVA: 0x001067E0 File Offset: 0x001049E0
		// (set) Token: 0x060034B4 RID: 13492 RVA: 0x00012932 File Offset: 0x00010B32
		public unsafe ObjectWriter objectWriter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_objectWriter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_objectWriter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x060034B5 RID: 13493 RVA: 0x00106810 File Offset: 0x00104A10
		// (set) Token: 0x060034B6 RID: 13494 RVA: 0x00012951 File Offset: 0x00010B51
		public unsafe BinaryWriter dataWriter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_dataWriter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_dataWriter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x060034B7 RID: 13495 RVA: 0x00106840 File Offset: 0x00104A40
		// (set) Token: 0x060034B8 RID: 13496 RVA: 0x00012970 File Offset: 0x00010B70
		public unsafe int m_nestedObjectCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_m_nestedObjectCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_m_nestedObjectCount)) = value;
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x060034B9 RID: 13497 RVA: 0x00106868 File Offset: 0x00104A68
		// (set) Token: 0x060034BA RID: 13498 RVA: 0x0001298B File Offset: 0x00010B8B
		public unsafe int nullCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_nullCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_nullCount)) = value;
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x060034BB RID: 13499 RVA: 0x00106890 File Offset: 0x00104A90
		// (set) Token: 0x060034BC RID: 13500 RVA: 0x000129A6 File Offset: 0x00010BA6
		public unsafe BinaryMethodCall binaryMethodCall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryMethodCall);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryMethodCall>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryMethodCall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x060034BD RID: 13501 RVA: 0x001068C0 File Offset: 0x00104AC0
		// (set) Token: 0x060034BE RID: 13502 RVA: 0x000129C5 File Offset: 0x00010BC5
		public unsafe BinaryMethodReturn binaryMethodReturn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryMethodReturn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryMethodReturn>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryMethodReturn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x060034BF RID: 13503 RVA: 0x001068F0 File Offset: 0x00104AF0
		// (set) Token: 0x060034C0 RID: 13504 RVA: 0x000129E4 File Offset: 0x00010BE4
		public unsafe BinaryObject binaryObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x060034C1 RID: 13505 RVA: 0x00106920 File Offset: 0x00104B20
		// (set) Token: 0x060034C2 RID: 13506 RVA: 0x00012A03 File Offset: 0x00010C03
		public unsafe BinaryObjectWithMap binaryObjectWithMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryObjectWithMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryObjectWithMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryObjectWithMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x060034C3 RID: 13507 RVA: 0x00106950 File Offset: 0x00104B50
		// (set) Token: 0x060034C4 RID: 13508 RVA: 0x00012A22 File Offset: 0x00010C22
		public unsafe BinaryObjectWithMapTyped binaryObjectWithMapTyped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryObjectWithMapTyped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryObjectWithMapTyped>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryObjectWithMapTyped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x060034C5 RID: 13509 RVA: 0x00106980 File Offset: 0x00104B80
		// (set) Token: 0x060034C6 RID: 13510 RVA: 0x00012A41 File Offset: 0x00010C41
		public unsafe BinaryObjectString binaryObjectString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryObjectString);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryObjectString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryObjectString), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x060034C7 RID: 13511 RVA: 0x001069B0 File Offset: 0x00104BB0
		// (set) Token: 0x060034C8 RID: 13512 RVA: 0x00012A60 File Offset: 0x00010C60
		public unsafe BinaryArray binaryArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x060034C9 RID: 13513 RVA: 0x001069E0 File Offset: 0x00104BE0
		// (set) Token: 0x060034CA RID: 13514 RVA: 0x00012A7F File Offset: 0x00010C7F
		public unsafe Il2CppStructArray<byte> byteBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_byteBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_byteBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x060034CB RID: 13515 RVA: 0x00106A10 File Offset: 0x00104C10
		// (set) Token: 0x060034CC RID: 13516 RVA: 0x00012A9E File Offset: 0x00010C9E
		public unsafe int chunkSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_chunkSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_chunkSize)) = value;
			}
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x060034CD RID: 13517 RVA: 0x00106A38 File Offset: 0x00104C38
		// (set) Token: 0x060034CE RID: 13518 RVA: 0x00012AB9 File Offset: 0x00010CB9
		public unsafe MemberPrimitiveUnTyped memberPrimitiveUnTyped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_memberPrimitiveUnTyped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberPrimitiveUnTyped>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_memberPrimitiveUnTyped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x060034CF RID: 13519 RVA: 0x00106A68 File Offset: 0x00104C68
		// (set) Token: 0x060034D0 RID: 13520 RVA: 0x00012AD8 File Offset: 0x00010CD8
		public unsafe MemberPrimitiveTyped memberPrimitiveTyped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_memberPrimitiveTyped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberPrimitiveTyped>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_memberPrimitiveTyped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x060034D1 RID: 13521 RVA: 0x00106A98 File Offset: 0x00104C98
		// (set) Token: 0x060034D2 RID: 13522 RVA: 0x00012AF7 File Offset: 0x00010CF7
		public unsafe ObjectNull objectNull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_objectNull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectNull>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_objectNull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x060034D3 RID: 13523 RVA: 0x00106AC8 File Offset: 0x00104CC8
		// (set) Token: 0x060034D4 RID: 13524 RVA: 0x00012B16 File Offset: 0x00010D16
		public unsafe MemberReference memberReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_memberReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_memberReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x060034D5 RID: 13525 RVA: 0x00106AF8 File Offset: 0x00104CF8
		// (set) Token: 0x060034D6 RID: 13526 RVA: 0x00012B35 File Offset: 0x00010D35
		public unsafe BinaryAssembly binaryAssembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryAssembly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryAssembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryAssembly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002B10 RID: 11024
		private static readonly IntPtr NativeFieldInfoPtr_sout;

		// Token: 0x04002B11 RID: 11025
		private static readonly IntPtr NativeFieldInfoPtr_formatterTypeStyle;

		// Token: 0x04002B12 RID: 11026
		private static readonly IntPtr NativeFieldInfoPtr_objectMapTable;

		// Token: 0x04002B13 RID: 11027
		private static readonly IntPtr NativeFieldInfoPtr_objectWriter;

		// Token: 0x04002B14 RID: 11028
		private static readonly IntPtr NativeFieldInfoPtr_dataWriter;

		// Token: 0x04002B15 RID: 11029
		private static readonly IntPtr NativeFieldInfoPtr_m_nestedObjectCount;

		// Token: 0x04002B16 RID: 11030
		private static readonly IntPtr NativeFieldInfoPtr_nullCount;

		// Token: 0x04002B17 RID: 11031
		private static readonly IntPtr NativeFieldInfoPtr_binaryMethodCall;

		// Token: 0x04002B18 RID: 11032
		private static readonly IntPtr NativeFieldInfoPtr_binaryMethodReturn;

		// Token: 0x04002B19 RID: 11033
		private static readonly IntPtr NativeFieldInfoPtr_binaryObject;

		// Token: 0x04002B1A RID: 11034
		private static readonly IntPtr NativeFieldInfoPtr_binaryObjectWithMap;

		// Token: 0x04002B1B RID: 11035
		private static readonly IntPtr NativeFieldInfoPtr_binaryObjectWithMapTyped;

		// Token: 0x04002B1C RID: 11036
		private static readonly IntPtr NativeFieldInfoPtr_binaryObjectString;

		// Token: 0x04002B1D RID: 11037
		private static readonly IntPtr NativeFieldInfoPtr_binaryArray;

		// Token: 0x04002B1E RID: 11038
		private static readonly IntPtr NativeFieldInfoPtr_byteBuffer;

		// Token: 0x04002B1F RID: 11039
		private static readonly IntPtr NativeFieldInfoPtr_chunkSize;

		// Token: 0x04002B20 RID: 11040
		private static readonly IntPtr NativeFieldInfoPtr_memberPrimitiveUnTyped;

		// Token: 0x04002B21 RID: 11041
		private static readonly IntPtr NativeFieldInfoPtr_memberPrimitiveTyped;

		// Token: 0x04002B22 RID: 11042
		private static readonly IntPtr NativeFieldInfoPtr_objectNull;

		// Token: 0x04002B23 RID: 11043
		private static readonly IntPtr NativeFieldInfoPtr_memberReference;

		// Token: 0x04002B24 RID: 11044
		private static readonly IntPtr NativeFieldInfoPtr_binaryAssembly;

		// Token: 0x04002B25 RID: 11045
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stream_ObjectWriter_FormatterTypeStyle_0;

		// Token: 0x04002B26 RID: 11046
		private static readonly IntPtr NativeMethodInfoPtr_WriteBegin_Internal_Void_0;

		// Token: 0x04002B27 RID: 11047
		private static readonly IntPtr NativeMethodInfoPtr_WriteEnd_Internal_Void_0;

		// Token: 0x04002B28 RID: 11048
		private static readonly IntPtr NativeMethodInfoPtr_WriteBoolean_Internal_Void_Boolean_0;

		// Token: 0x04002B29 RID: 11049
		private static readonly IntPtr NativeMethodInfoPtr_WriteByte_Internal_Void_Byte_0;

		// Token: 0x04002B2A RID: 11050
		private static readonly IntPtr NativeMethodInfoPtr_WriteBytes_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002B2B RID: 11051
		private static readonly IntPtr NativeMethodInfoPtr_WriteBytes_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002B2C RID: 11052
		private static readonly IntPtr NativeMethodInfoPtr_WriteChar_Internal_Void_Char_0;

		// Token: 0x04002B2D RID: 11053
		private static readonly IntPtr NativeMethodInfoPtr_WriteChars_Internal_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x04002B2E RID: 11054
		private static readonly IntPtr NativeMethodInfoPtr_WriteDecimal_Internal_Void_Decimal_0;

		// Token: 0x04002B2F RID: 11055
		private static readonly IntPtr NativeMethodInfoPtr_WriteSingle_Internal_Void_Single_0;

		// Token: 0x04002B30 RID: 11056
		private static readonly IntPtr NativeMethodInfoPtr_WriteDouble_Internal_Void_Double_0;

		// Token: 0x04002B31 RID: 11057
		private static readonly IntPtr NativeMethodInfoPtr_WriteInt16_Internal_Void_Int16_0;

		// Token: 0x04002B32 RID: 11058
		private static readonly IntPtr NativeMethodInfoPtr_WriteInt32_Internal_Void_Int32_0;

		// Token: 0x04002B33 RID: 11059
		private static readonly IntPtr NativeMethodInfoPtr_WriteInt64_Internal_Void_Int64_0;

		// Token: 0x04002B34 RID: 11060
		private static readonly IntPtr NativeMethodInfoPtr_WriteSByte_Internal_Void_SByte_0;

		// Token: 0x04002B35 RID: 11061
		private static readonly IntPtr NativeMethodInfoPtr_WriteString_Internal_Void_String_0;

		// Token: 0x04002B36 RID: 11062
		private static readonly IntPtr NativeMethodInfoPtr_WriteTimeSpan_Internal_Void_TimeSpan_0;

		// Token: 0x04002B37 RID: 11063
		private static readonly IntPtr NativeMethodInfoPtr_WriteDateTime_Internal_Void_DateTime_0;

		// Token: 0x04002B38 RID: 11064
		private static readonly IntPtr NativeMethodInfoPtr_WriteUInt16_Internal_Void_UInt16_0;

		// Token: 0x04002B39 RID: 11065
		private static readonly IntPtr NativeMethodInfoPtr_WriteUInt32_Internal_Void_UInt32_0;

		// Token: 0x04002B3A RID: 11066
		private static readonly IntPtr NativeMethodInfoPtr_WriteUInt64_Internal_Void_UInt64_0;

		// Token: 0x04002B3B RID: 11067
		private static readonly IntPtr NativeMethodInfoPtr_WriteObjectEnd_Internal_Void_NameInfo_NameInfo_0;

		// Token: 0x04002B3C RID: 11068
		private static readonly IntPtr NativeMethodInfoPtr_WriteSerializationHeaderEnd_Internal_Void_0;

		// Token: 0x04002B3D RID: 11069
		private static readonly IntPtr NativeMethodInfoPtr_WriteSerializationHeader_Internal_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002B3E RID: 11070
		private static readonly IntPtr NativeMethodInfoPtr_WriteMethodCall_Internal_Void_0;

		// Token: 0x04002B3F RID: 11071
		private static readonly IntPtr NativeMethodInfoPtr_WriteMethodReturn_Internal_Void_0;

		// Token: 0x04002B40 RID: 11072
		private static readonly IntPtr NativeMethodInfoPtr_WriteObject_Internal_Void_NameInfo_NameInfo_Int32_Il2CppStringArray_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_WriteObjectInfo_0;

		// Token: 0x04002B41 RID: 11073
		private static readonly IntPtr NativeMethodInfoPtr_WriteObjectString_Internal_Void_Int32_String_0;

		// Token: 0x04002B42 RID: 11074
		private static readonly IntPtr NativeMethodInfoPtr_WriteSingleArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Int32_Array_0;

		// Token: 0x04002B43 RID: 11075
		private static readonly IntPtr NativeMethodInfoPtr_WriteArrayAsBytes_Private_Void_Array_Int32_0;

		// Token: 0x04002B44 RID: 11076
		private static readonly IntPtr NativeMethodInfoPtr_WriteJaggedArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Int32_0;

		// Token: 0x04002B45 RID: 11077
		private static readonly IntPtr NativeMethodInfoPtr_WriteRectangleArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002B46 RID: 11078
		private static readonly IntPtr NativeMethodInfoPtr_WriteObjectByteArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002B47 RID: 11079
		private static readonly IntPtr NativeMethodInfoPtr_WriteMember_Internal_Void_NameInfo_NameInfo_Object_0;

		// Token: 0x04002B48 RID: 11080
		private static readonly IntPtr NativeMethodInfoPtr_WriteNullMember_Internal_Void_NameInfo_NameInfo_0;

		// Token: 0x04002B49 RID: 11081
		private static readonly IntPtr NativeMethodInfoPtr_WriteMemberObjectRef_Internal_Void_NameInfo_Int32_0;

		// Token: 0x04002B4A RID: 11082
		private static readonly IntPtr NativeMethodInfoPtr_WriteMemberNested_Internal_Void_NameInfo_0;

		// Token: 0x04002B4B RID: 11083
		private static readonly IntPtr NativeMethodInfoPtr_WriteMemberString_Internal_Void_NameInfo_NameInfo_String_0;

		// Token: 0x04002B4C RID: 11084
		private static readonly IntPtr NativeMethodInfoPtr_WriteItem_Internal_Void_NameInfo_NameInfo_Object_0;

		// Token: 0x04002B4D RID: 11085
		private static readonly IntPtr NativeMethodInfoPtr_WriteNullItem_Internal_Void_NameInfo_NameInfo_0;

		// Token: 0x04002B4E RID: 11086
		private static readonly IntPtr NativeMethodInfoPtr_WriteDelayedNullItem_Internal_Void_0;

		// Token: 0x04002B4F RID: 11087
		private static readonly IntPtr NativeMethodInfoPtr_WriteItemEnd_Internal_Void_0;

		// Token: 0x04002B50 RID: 11088
		private static readonly IntPtr NativeMethodInfoPtr_InternalWriteItemNull_Private_Void_0;

		// Token: 0x04002B51 RID: 11089
		private static readonly IntPtr NativeMethodInfoPtr_WriteItemObjectRef_Internal_Void_NameInfo_Int32_0;

		// Token: 0x04002B52 RID: 11090
		private static readonly IntPtr NativeMethodInfoPtr_WriteAssembly_Internal_Void_Type_String_Int32_Boolean_0;

		// Token: 0x04002B53 RID: 11091
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Internal_Void_InternalPrimitiveTypeE_Object_0;
	}
}
