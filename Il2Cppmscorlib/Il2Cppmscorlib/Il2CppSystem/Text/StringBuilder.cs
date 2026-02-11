using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Text
{
	// Token: 0x0200020E RID: 526
	[Serializable]
	public sealed class StringBuilder : Object
	{
		// Token: 0x060021AE RID: 8622 RVA: 0x000BF440 File Offset: 0x000BD640
		// Note: this type is marked as 'beforefieldinit'.
		static StringBuilder()
		{
			Il2CppClassPointerStore<StringBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "StringBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr);
			StringBuilder.NativeFieldInfoPtr_m_ChunkChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, "m_ChunkChars");
			StringBuilder.NativeFieldInfoPtr_m_ChunkPrevious = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, "m_ChunkPrevious");
			StringBuilder.NativeFieldInfoPtr_m_ChunkLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, "m_ChunkLength");
			StringBuilder.NativeFieldInfoPtr_m_ChunkOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, "m_ChunkOffset");
			StringBuilder.NativeFieldInfoPtr_m_MaxCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, "m_MaxCapacity");
			StringBuilder.NativeFieldInfoPtr_DefaultCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, "DefaultCapacity");
			StringBuilder.NativeFieldInfoPtr_CapacityField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, "CapacityField");
			StringBuilder.NativeFieldInfoPtr_MaxCapacityField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, "MaxCapacityField");
			StringBuilder.NativeFieldInfoPtr_StringValueField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, "StringValueField");
			StringBuilder.NativeFieldInfoPtr_ThreadIDField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, "ThreadIDField");
			StringBuilder.NativeFieldInfoPtr_MaxChunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, "MaxChunkSize");
			StringBuilder.NativeFieldInfoPtr_IndexLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, "IndexLimit");
			StringBuilder.NativeFieldInfoPtr_WidthLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, "WidthLimit");
			StringBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100668978);
			StringBuilder.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100668979);
			StringBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100668980);
			StringBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100668981);
			StringBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100668982);
			StringBuilder.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100668983);
			StringBuilder.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100668984);
			StringBuilder.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100668985);
			StringBuilder.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100668986);
			StringBuilder.NativeMethodInfoPtr_set_Capacity_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100668987);
			StringBuilder.NativeMethodInfoPtr_get_MaxCapacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100668988);
			StringBuilder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100668989);
			StringBuilder.NativeMethodInfoPtr_ToString_Public_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100668990);
			StringBuilder.NativeMethodInfoPtr_Clear_Public_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100668991);
			StringBuilder.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100668992);
			StringBuilder.NativeMethodInfoPtr_set_Length_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100668993);
			StringBuilder.NativeMethodInfoPtr_get_Chars_Public_get_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100668994);
			StringBuilder.NativeMethodInfoPtr_set_Chars_Public_set_Void_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100668995);
			StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100668996);
			StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100668997);
			StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100668998);
			StringBuilder.NativeMethodInfoPtr_AppendHelper_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100668999);
			StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669000);
			StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669001);
			StringBuilder.NativeMethodInfoPtr_AppendCore_Private_StringBuilder_StringBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669002);
			StringBuilder.NativeMethodInfoPtr_AppendLine_Public_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669003);
			StringBuilder.NativeMethodInfoPtr_AppendLine_Public_StringBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669004);
			StringBuilder.NativeMethodInfoPtr_CopyTo_Public_Void_Int32_Span_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669005);
			StringBuilder.NativeMethodInfoPtr_Remove_Public_StringBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669006);
			StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669007);
			StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669008);
			StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669009);
			StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669010);
			StringBuilder.NativeMethodInfoPtr_AppendSpanFormattable_Private_StringBuilder_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669011);
			StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669012);
			StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669013);
			StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669014);
			StringBuilder.NativeMethodInfoPtr_Insert_Public_StringBuilder_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669015);
			StringBuilder.NativeMethodInfoPtr_Insert_Public_StringBuilder_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669016);
			StringBuilder.NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669017);
			StringBuilder.NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669018);
			StringBuilder.NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669019);
			StringBuilder.NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_IFormatProvider_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669020);
			StringBuilder.NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_IFormatProvider_String_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669021);
			StringBuilder.NativeMethodInfoPtr_FormatError_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669022);
			StringBuilder.NativeMethodInfoPtr_AppendFormatHelper_Internal_StringBuilder_IFormatProvider_String_ParamsArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669023);
			StringBuilder.NativeMethodInfoPtr_Replace_Public_StringBuilder_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669024);
			StringBuilder.NativeMethodInfoPtr_Replace_Public_StringBuilder_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669025);
			StringBuilder.NativeMethodInfoPtr_Replace_Public_StringBuilder_Char_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669026);
			StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669027);
			StringBuilder.NativeMethodInfoPtr_Insert_Private_Void_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669028);
			StringBuilder.NativeMethodInfoPtr_ReplaceAllInChunk_Private_Void_Il2CppStructArray_1_Int32_Int32_StringBuilder_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669029);
			StringBuilder.NativeMethodInfoPtr_StartsWith_Private_Boolean_StringBuilder_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669030);
			StringBuilder.NativeMethodInfoPtr_ReplaceInPlaceAtChunk_Private_Void_byref_StringBuilder_byref_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669031);
			StringBuilder.NativeMethodInfoPtr_ThreadSafeCopy_Private_Static_Void_ptr_Char_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669032);
			StringBuilder.NativeMethodInfoPtr_ThreadSafeCopy_Private_Static_Void_Il2CppStructArray_1_Char_Int32_Span_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669033);
			StringBuilder.NativeMethodInfoPtr_FindChunkForIndex_Private_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669034);
			StringBuilder.NativeMethodInfoPtr_get_RemainingCurrentChunk_Private_get_Span_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669035);
			StringBuilder.NativeMethodInfoPtr_Next_Private_StringBuilder_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669036);
			StringBuilder.NativeMethodInfoPtr_ExpandByABlock_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669037);
			StringBuilder.NativeMethodInfoPtr__ctor_Private_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669038);
			StringBuilder.NativeMethodInfoPtr_MakeRoom_Private_Void_Int32_Int32_byref_StringBuilder_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669039);
			StringBuilder.NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669040);
			StringBuilder.NativeMethodInfoPtr_Remove_Private_Void_Int32_Int32_byref_StringBuilder_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr, 100669041);
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x000BFA74 File Offset: 0x000BDC74
		[CallerCount(257)]
		[CachedScanResults(RefRangeStart = 1363201, RefRangeEnd = 1363458, XrefRangeStart = 1363196, XrefRangeEnd = 1363201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x000BFAB0 File Offset: 0x000BDCB0
		[CallerCount(81)]
		[CachedScanResults(RefRangeStart = 1363459, RefRangeEnd = 1363540, XrefRangeStart = 1363458, XrefRangeEnd = 1363459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x000BFAF8 File Offset: 0x000BDCF8
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 1363542, RefRangeEnd = 1363575, XrefRangeStart = 1363540, XrefRangeEnd = 1363542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder(string value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x000BFB44 File Offset: 0x000BDD44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1363577, RefRangeEnd = 1363578, XrefRangeStart = 1363575, XrefRangeEnd = 1363577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder(string value, int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x000BFBA0 File Offset: 0x000BDDA0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1363624, RefRangeEnd = 1363628, XrefRangeStart = 1363578, XrefRangeEnd = 1363624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder(string value, int startIndex, int length, int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x000BFC18 File Offset: 0x000BDE18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1363660, RefRangeEnd = 1363661, XrefRangeStart = 1363628, XrefRangeEnd = 1363660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder(int capacity, int maxCapacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxCapacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x000BFC70 File Offset: 0x000BDE70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363661, XrefRangeEnd = 1363715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x000BFCD4 File Offset: 0x000BDED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363715, XrefRangeEnd = 1363734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x060021B7 RID: 8631 RVA: 0x000BFD30 File Offset: 0x000BDF30
		// (set) Token: 0x060021B8 RID: 8632 RVA: 0x000BFD6C File Offset: 0x000BDF6C
		public unsafe int Capacity
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1363734, RefRangeEnd = 1363742, XrefRangeStart = 1363734, XrefRangeEnd = 1363734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1363747, RefRangeEnd = 1363750, XrefRangeStart = 1363742, XrefRangeEnd = 1363747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_set_Capacity_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x060021B9 RID: 8633 RVA: 0x000BFDAC File Offset: 0x000BDFAC
		public unsafe int MaxCapacity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_get_MaxCapacity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x000BFDE8 File Offset: 0x000BDFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363750, XrefRangeEnd = 1363754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x000BFE20 File Offset: 0x000BE020
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1363758, RefRangeEnd = 1363761, XrefRangeStart = 1363754, XrefRangeEnd = 1363758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_ToString_Public_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x000BFE74 File Offset: 0x000BE074
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1363762, RefRangeEnd = 1363788, XrefRangeStart = 1363761, XrefRangeEnd = 1363762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Clear_Public_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x060021BD RID: 8637 RVA: 0x000BFEB4 File Offset: 0x000BE0B4
		// (set) Token: 0x060021BE RID: 8638 RVA: 0x000BFEF0 File Offset: 0x000BE0F0
		public unsafe int Length
		{
			[CallerCount(178)]
			[CachedScanResults(RefRangeStart = 1363788, RefRangeEnd = 1363966, XrefRangeStart = 1363788, XrefRangeEnd = 1363788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(68)]
			[CachedScanResults(RefRangeStart = 1363968, RefRangeEnd = 1364036, XrefRangeStart = 1363966, XrefRangeEnd = 1363968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_set_Length_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000696 RID: 1686
		[IndexerName("Chars")]
		public unsafe char this[int index]
		{
			[CallerCount(59)]
			[CachedScanResults(RefRangeStart = 1364037, RefRangeEnd = 1364096, XrefRangeStart = 1364036, XrefRangeEnd = 1364037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_get_Chars_Public_get_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 1364097, RefRangeEnd = 1364110, XrefRangeStart = 1364096, XrefRangeEnd = 1364097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_set_Chars_Public_set_Void_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x000BFFC8 File Offset: 0x000BE1C8
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1364112, RefRangeEnd = 1364125, XrefRangeStart = 1364110, XrefRangeEnd = 1364112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Append(char value, int repeatCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref repeatCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x000C0024 File Offset: 0x000BE224
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 1364126, RefRangeEnd = 1364162, XrefRangeStart = 1364125, XrefRangeEnd = 1364126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Append(Il2CppStructArray<char> value, int startIndex, int charCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x000C0090 File Offset: 0x000BE290
		[CallerCount(1219)]
		[CachedScanResults(RefRangeStart = 1364164, RefRangeEnd = 1365383, XrefRangeStart = 1364162, XrefRangeEnd = 1364164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Append(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x000C00E0 File Offset: 0x000BE2E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365383, XrefRangeEnd = 1365386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendHelper(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_AppendHelper_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x000C0124 File Offset: 0x000BE324
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 1365388, RefRangeEnd = 1365425, XrefRangeStart = 1365386, XrefRangeEnd = 1365388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Append(string value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x000C0190 File Offset: 0x000BE390
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1365426, RefRangeEnd = 1365428, XrefRangeStart = 1365425, XrefRangeEnd = 1365426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Append(StringBuilder value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x000C01E0 File Offset: 0x000BE3E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1365441, RefRangeEnd = 1365442, XrefRangeStart = 1365428, XrefRangeEnd = 1365441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder AppendCore(StringBuilder value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_AppendCore_Private_StringBuilder_StringBuilder_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x000C024C File Offset: 0x000BE44C
		[CallerCount(68)]
		[CachedScanResults(RefRangeStart = 1365444, RefRangeEnd = 1365512, XrefRangeStart = 1365442, XrefRangeEnd = 1365444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder AppendLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_AppendLine_Public_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x000C028C File Offset: 0x000BE48C
		[CallerCount(111)]
		[CachedScanResults(RefRangeStart = 1365515, RefRangeEnd = 1365626, XrefRangeStart = 1365512, XrefRangeEnd = 1365515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder AppendLine(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_AppendLine_Public_StringBuilder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x000C02DC File Offset: 0x000BE4DC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1365631, RefRangeEnd = 1365637, XrefRangeStart = 1365626, XrefRangeEnd = 1365631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(int sourceIndex, Span<char> destination, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sourceIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_CopyTo_Public_Void_Int32_Span_1_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x000C0340 File Offset: 0x000BE540
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1365638, RefRangeEnd = 1365648, XrefRangeStart = 1365637, XrefRangeEnd = 1365638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Remove(int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Remove_Public_StringBuilder_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x000C039C File Offset: 0x000BE59C
		[CallerCount(487)]
		[CachedScanResults(RefRangeStart = 1365649, RefRangeEnd = 1366136, XrefRangeStart = 1365648, XrefRangeEnd = 1365649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Append(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x000C03E8 File Offset: 0x000BE5E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1366139, RefRangeEnd = 1366142, XrefRangeStart = 1366136, XrefRangeEnd = 1366139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Append(byte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x000C0434 File Offset: 0x000BE634
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 1366145, RefRangeEnd = 1366172, XrefRangeStart = 1366142, XrefRangeEnd = 1366145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Append(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x000C0480 File Offset: 0x000BE680
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1366175, RefRangeEnd = 1366176, XrefRangeStart = 1366172, XrefRangeEnd = 1366175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Append(uint value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x000C04CC File Offset: 0x000BE6CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1366183, RefRangeEnd = 1366184, XrefRangeStart = 1366176, XrefRangeEnd = 1366183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder AppendSpanFormattable<T>(T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StringBuilder.MethodInfoStoreGeneric_AppendSpanFormattable_Private_StringBuilder_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr4) : null;
			}
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x000C0554 File Offset: 0x000BE754
		[CallerCount(59)]
		[CachedScanResults(RefRangeStart = 1366184, RefRangeEnd = 1366243, XrefRangeStart = 1366184, XrefRangeEnd = 1366184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Append(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x000C05A4 File Offset: 0x000BE7A4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1366244, RefRangeEnd = 1366253, XrefRangeStart = 1366243, XrefRangeEnd = 1366244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Append(Il2CppStructArray<char> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x000C05F4 File Offset: 0x000BE7F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1366258, RefRangeEnd = 1366260, XrefRangeStart = 1366253, XrefRangeEnd = 1366258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Append(ReadOnlySpan<char> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_ReadOnlySpan_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x000C064C File Offset: 0x000BE84C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1366262, RefRangeEnd = 1366268, XrefRangeStart = 1366260, XrefRangeEnd = 1366262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Insert(int index, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Insert_Public_StringBuilder_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x000C06AC File Offset: 0x000BE8AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1366269, RefRangeEnd = 1366271, XrefRangeStart = 1366268, XrefRangeEnd = 1366269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Insert(int index, char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Insert_Public_StringBuilder_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x000C0708 File Offset: 0x000BE908
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 1366273, RefRangeEnd = 1366306, XrefRangeStart = 1366271, XrefRangeEnd = 1366273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder AppendFormat(string format, Object arg0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x000C076C File Offset: 0x000BE96C
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1366308, RefRangeEnd = 1366327, XrefRangeStart = 1366306, XrefRangeEnd = 1366308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder AppendFormat(string format, Object arg0, Object arg1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_String_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x000C07E0 File Offset: 0x000BE9E0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1366329, RefRangeEnd = 1366338, XrefRangeStart = 1366327, XrefRangeEnd = 1366329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder AppendFormat(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x000C0850 File Offset: 0x000BEA50
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1366340, RefRangeEnd = 1366344, XrefRangeStart = 1366338, XrefRangeEnd = 1366340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder AppendFormat(IFormatProvider provider, string format, Object arg0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_IFormatProvider_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x000C08C4 File Offset: 0x000BEAC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1366346, RefRangeEnd = 1366347, XrefRangeStart = 1366344, XrefRangeEnd = 1366346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder AppendFormat(IFormatProvider provider, string format, Object arg0, Object arg1, Object arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_IFormatProvider_String_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x000C0960 File Offset: 0x000BEB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366347, XrefRangeEnd = 1366353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatError()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_FormatError_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x000C0988 File Offset: 0x000BEB88
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1366435, RefRangeEnd = 1366449, XrefRangeStart = 1366353, XrefRangeEnd = 1366435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder AppendFormatHelper(IFormatProvider provider, string format, ParamsArray args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_AppendFormatHelper_Internal_StringBuilder_IFormatProvider_String_ParamsArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x000C0A04 File Offset: 0x000BEC04
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1366450, RefRangeEnd = 1366459, XrefRangeStart = 1366449, XrefRangeEnd = 1366450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Replace(string oldValue, string newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Replace_Public_StringBuilder_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x000C0A68 File Offset: 0x000BEC68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1366475, RefRangeEnd = 1366476, XrefRangeStart = 1366459, XrefRangeEnd = 1366475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Replace(string oldValue, string newValue, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Replace_Public_StringBuilder_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x000C0AE8 File Offset: 0x000BECE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1366482, RefRangeEnd = 1366484, XrefRangeStart = 1366476, XrefRangeEnd = 1366482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Replace(char oldChar, char newChar, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newChar;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Replace_Public_StringBuilder_Char_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x000C0B60 File Offset: 0x000BED60
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1366488, RefRangeEnd = 1366499, XrefRangeStart = 1366484, XrefRangeEnd = 1366488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder Append(char* value, int valueCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Append_Public_StringBuilder_ptr_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x000C0BBC File Offset: 0x000BEDBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1366530, RefRangeEnd = 1366532, XrefRangeStart = 1366499, XrefRangeEnd = 1366530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert(int index, char* value, int valueCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Insert_Private_Void_Int32_ptr_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x000C0C18 File Offset: 0x000BEE18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1366539, RefRangeEnd = 1366540, XrefRangeStart = 1366532, XrefRangeEnd = 1366539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplaceAllInChunk(Il2CppStructArray<int> replacements, int replacementsCount, StringBuilder sourceChunk, int removeCount, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(replacements);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref replacementsCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceChunk);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref removeCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_ReplaceAllInChunk_Private_Void_Il2CppStructArray_1_Int32_Int32_StringBuilder_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x000C0C9C File Offset: 0x000BEE9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366540, XrefRangeEnd = 1366543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartsWith(StringBuilder chunk, int indexInChunk, int count, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chunk);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexInChunk;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_StartsWith_Private_Boolean_StringBuilder_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x000C0D18 File Offset: 0x000BEF18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1366551, RefRangeEnd = 1366553, XrefRangeStart = 1366543, XrefRangeEnd = 1366551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplaceInPlaceAtChunk(ref StringBuilder chunk, ref int indexInChunk, char* value, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(chunk);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &indexInChunk;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = value;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_ReplaceInPlaceAtChunk_Private_Void_byref_StringBuilder_byref_Int32_ptr_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			chunk = ((intPtr4 == 0) ? null : new StringBuilder(intPtr4));
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x000C0D98 File Offset: 0x000BEF98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1366554, RefRangeEnd = 1366557, XrefRangeStart = 1366553, XrefRangeEnd = 1366554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThreadSafeCopy(char* sourcePtr, Il2CppStructArray<char> destination, int destinationIndex, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = sourcePtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_ThreadSafeCopy_Private_Static_Void_ptr_Char_Il2CppStructArray_1_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x000C0DF8 File Offset: 0x000BEFF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1366562, RefRangeEnd = 1366564, XrefRangeStart = 1366557, XrefRangeEnd = 1366562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThreadSafeCopy(Il2CppStructArray<char> source, int sourceIndex, Span<char> destination, int destinationIndex, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_ThreadSafeCopy_Private_Static_Void_Il2CppStructArray_1_Char_Int32_Span_1_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x000C0E70 File Offset: 0x000BF070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366564, XrefRangeEnd = 1366565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder FindChunkForIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_FindChunkForIndex_Private_StringBuilder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x060021E8 RID: 8680 RVA: 0x000C0EBC File Offset: 0x000BF0BC
		public unsafe Span<char> RemainingCurrentChunk
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366565, XrefRangeEnd = 1366567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_get_RemainingCurrentChunk_Private_get_Span_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Span<char>(intPtr);
			}
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x000C0EF4 File Offset: 0x000BF0F4
		[CallerCount(0)]
		public unsafe StringBuilder Next(StringBuilder chunk)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chunk);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Next_Private_StringBuilder_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x000C0F44 File Offset: 0x000BF144
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1366596, RefRangeEnd = 1366599, XrefRangeStart = 1366567, XrefRangeEnd = 1366596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpandByABlock(int minBlockCharCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minBlockCharCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_ExpandByABlock_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x000C0F84 File Offset: 0x000BF184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366599, XrefRangeEnd = 1366602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder(StringBuilder from)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr__ctor_Private_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x000C0FD0 File Offset: 0x000BF1D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1366607, RefRangeEnd = 1366608, XrefRangeStart = 1366602, XrefRangeEnd = 1366607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MakeRoom(int index, int count, out StringBuilder chunk, out int indexInChunk, bool doNotMoveFollowingChars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &indexInChunk;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doNotMoveFollowingChars;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_MakeRoom_Private_Void_Int32_Int32_byref_StringBuilder_byref_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			chunk = ((intPtr4 == 0) ? null : new StringBuilder(intPtr4));
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x000C105C File Offset: 0x000BF25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366608, XrefRangeEnd = 1366614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder(int size, int maxCapacity, StringBuilder previousBlock)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringBuilder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxCapacity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(previousBlock);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x000C10C4 File Offset: 0x000BF2C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1366626, RefRangeEnd = 1366627, XrefRangeStart = 1366614, XrefRangeEnd = 1366626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(int startIndex, int count, out StringBuilder chunk, out int indexInChunk)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &indexInChunk;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StringBuilder.NativeMethodInfoPtr_Remove_Private_Void_Int32_Int32_byref_StringBuilder_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			chunk = ((intPtr4 == 0) ? null : new StringBuilder(intPtr4));
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x0000AE19 File Offset: 0x00009019
		public StringBuilder AppendFormat(string format, params Object[] args)
		{
			return this.AppendFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x0000AE28 File Offset: 0x00009028
		public StringBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x060021F1 RID: 8689 RVA: 0x000C1140 File Offset: 0x000BF340
		// (set) Token: 0x060021F2 RID: 8690 RVA: 0x0000AE31 File Offset: 0x00009031
		public unsafe Il2CppStructArray<char> m_ChunkChars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBuilder.NativeFieldInfoPtr_m_ChunkChars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBuilder.NativeFieldInfoPtr_m_ChunkChars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x060021F3 RID: 8691 RVA: 0x000C1170 File Offset: 0x000BF370
		// (set) Token: 0x060021F4 RID: 8692 RVA: 0x0000AE50 File Offset: 0x00009050
		public unsafe StringBuilder m_ChunkPrevious
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBuilder.NativeFieldInfoPtr_m_ChunkPrevious);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBuilder.NativeFieldInfoPtr_m_ChunkPrevious), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x060021F5 RID: 8693 RVA: 0x000C11A0 File Offset: 0x000BF3A0
		// (set) Token: 0x060021F6 RID: 8694 RVA: 0x0000AE6F File Offset: 0x0000906F
		public unsafe int m_ChunkLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBuilder.NativeFieldInfoPtr_m_ChunkLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBuilder.NativeFieldInfoPtr_m_ChunkLength)) = value;
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x060021F7 RID: 8695 RVA: 0x000C11C8 File Offset: 0x000BF3C8
		// (set) Token: 0x060021F8 RID: 8696 RVA: 0x0000AE8A File Offset: 0x0000908A
		public unsafe int m_ChunkOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBuilder.NativeFieldInfoPtr_m_ChunkOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBuilder.NativeFieldInfoPtr_m_ChunkOffset)) = value;
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x060021F9 RID: 8697 RVA: 0x000C11F0 File Offset: 0x000BF3F0
		// (set) Token: 0x060021FA RID: 8698 RVA: 0x0000AEA5 File Offset: 0x000090A5
		public unsafe int m_MaxCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBuilder.NativeFieldInfoPtr_m_MaxCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBuilder.NativeFieldInfoPtr_m_MaxCapacity)) = value;
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x060021FB RID: 8699 RVA: 0x000C1218 File Offset: 0x000BF418
		// (set) Token: 0x060021FC RID: 8700 RVA: 0x0000AEC0 File Offset: 0x000090C0
		public unsafe static int DefaultCapacity
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StringBuilder.NativeFieldInfoPtr_DefaultCapacity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringBuilder.NativeFieldInfoPtr_DefaultCapacity, (void*)(&value));
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x060021FD RID: 8701 RVA: 0x000C1234 File Offset: 0x000BF434
		// (set) Token: 0x060021FE RID: 8702 RVA: 0x0000AECE File Offset: 0x000090CE
		public unsafe static string CapacityField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringBuilder.NativeFieldInfoPtr_CapacityField, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringBuilder.NativeFieldInfoPtr_CapacityField, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x060021FF RID: 8703 RVA: 0x000C1254 File Offset: 0x000BF454
		// (set) Token: 0x06002200 RID: 8704 RVA: 0x0000AEE0 File Offset: 0x000090E0
		public unsafe static string MaxCapacityField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringBuilder.NativeFieldInfoPtr_MaxCapacityField, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringBuilder.NativeFieldInfoPtr_MaxCapacityField, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06002201 RID: 8705 RVA: 0x000C1274 File Offset: 0x000BF474
		// (set) Token: 0x06002202 RID: 8706 RVA: 0x0000AEF2 File Offset: 0x000090F2
		public unsafe static string StringValueField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringBuilder.NativeFieldInfoPtr_StringValueField, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringBuilder.NativeFieldInfoPtr_StringValueField, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06002203 RID: 8707 RVA: 0x000C1294 File Offset: 0x000BF494
		// (set) Token: 0x06002204 RID: 8708 RVA: 0x0000AF04 File Offset: 0x00009104
		public unsafe static string ThreadIDField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringBuilder.NativeFieldInfoPtr_ThreadIDField, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringBuilder.NativeFieldInfoPtr_ThreadIDField, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06002205 RID: 8709 RVA: 0x000C12B4 File Offset: 0x000BF4B4
		// (set) Token: 0x06002206 RID: 8710 RVA: 0x0000AF16 File Offset: 0x00009116
		public unsafe static int MaxChunkSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StringBuilder.NativeFieldInfoPtr_MaxChunkSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringBuilder.NativeFieldInfoPtr_MaxChunkSize, (void*)(&value));
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06002207 RID: 8711 RVA: 0x000C12D0 File Offset: 0x000BF4D0
		// (set) Token: 0x06002208 RID: 8712 RVA: 0x0000AF24 File Offset: 0x00009124
		public unsafe static int IndexLimit
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StringBuilder.NativeFieldInfoPtr_IndexLimit, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringBuilder.NativeFieldInfoPtr_IndexLimit, (void*)(&value));
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06002209 RID: 8713 RVA: 0x000C12EC File Offset: 0x000BF4EC
		// (set) Token: 0x0600220A RID: 8714 RVA: 0x0000AF32 File Offset: 0x00009132
		public unsafe static int WidthLimit
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StringBuilder.NativeFieldInfoPtr_WidthLimit, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringBuilder.NativeFieldInfoPtr_WidthLimit, (void*)(&value));
			}
		}

		// Token: 0x04001DC2 RID: 7618
		private static readonly IntPtr NativeFieldInfoPtr_m_ChunkChars;

		// Token: 0x04001DC3 RID: 7619
		private static readonly IntPtr NativeFieldInfoPtr_m_ChunkPrevious;

		// Token: 0x04001DC4 RID: 7620
		private static readonly IntPtr NativeFieldInfoPtr_m_ChunkLength;

		// Token: 0x04001DC5 RID: 7621
		private static readonly IntPtr NativeFieldInfoPtr_m_ChunkOffset;

		// Token: 0x04001DC6 RID: 7622
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxCapacity;

		// Token: 0x04001DC7 RID: 7623
		private static readonly IntPtr NativeFieldInfoPtr_DefaultCapacity;

		// Token: 0x04001DC8 RID: 7624
		private static readonly IntPtr NativeFieldInfoPtr_CapacityField;

		// Token: 0x04001DC9 RID: 7625
		private static readonly IntPtr NativeFieldInfoPtr_MaxCapacityField;

		// Token: 0x04001DCA RID: 7626
		private static readonly IntPtr NativeFieldInfoPtr_StringValueField;

		// Token: 0x04001DCB RID: 7627
		private static readonly IntPtr NativeFieldInfoPtr_ThreadIDField;

		// Token: 0x04001DCC RID: 7628
		private static readonly IntPtr NativeFieldInfoPtr_MaxChunkSize;

		// Token: 0x04001DCD RID: 7629
		private static readonly IntPtr NativeFieldInfoPtr_IndexLimit;

		// Token: 0x04001DCE RID: 7630
		private static readonly IntPtr NativeFieldInfoPtr_WidthLimit;

		// Token: 0x04001DCF RID: 7631
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001DD0 RID: 7632
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001DD1 RID: 7633
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001DD2 RID: 7634
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

		// Token: 0x04001DD3 RID: 7635
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_0;

		// Token: 0x04001DD4 RID: 7636
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04001DD5 RID: 7637
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001DD6 RID: 7638
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001DD7 RID: 7639
		private static readonly IntPtr NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0;

		// Token: 0x04001DD8 RID: 7640
		private static readonly IntPtr NativeMethodInfoPtr_set_Capacity_Public_set_Void_Int32_0;

		// Token: 0x04001DD9 RID: 7641
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxCapacity_Public_get_Int32_0;

		// Token: 0x04001DDA RID: 7642
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001DDB RID: 7643
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_Int32_Int32_0;

		// Token: 0x04001DDC RID: 7644
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_StringBuilder_0;

		// Token: 0x04001DDD RID: 7645
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x04001DDE RID: 7646
		private static readonly IntPtr NativeMethodInfoPtr_set_Length_Public_set_Void_Int32_0;

		// Token: 0x04001DDF RID: 7647
		private static readonly IntPtr NativeMethodInfoPtr_get_Chars_Public_get_Char_Int32_0;

		// Token: 0x04001DE0 RID: 7648
		private static readonly IntPtr NativeMethodInfoPtr_set_Chars_Public_set_Void_Int32_Char_0;

		// Token: 0x04001DE1 RID: 7649
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_StringBuilder_Char_Int32_0;

		// Token: 0x04001DE2 RID: 7650
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_StringBuilder_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04001DE3 RID: 7651
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_StringBuilder_String_0;

		// Token: 0x04001DE4 RID: 7652
		private static readonly IntPtr NativeMethodInfoPtr_AppendHelper_Private_Void_String_0;

		// Token: 0x04001DE5 RID: 7653
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_StringBuilder_String_Int32_Int32_0;

		// Token: 0x04001DE6 RID: 7654
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_StringBuilder_StringBuilder_0;

		// Token: 0x04001DE7 RID: 7655
		private static readonly IntPtr NativeMethodInfoPtr_AppendCore_Private_StringBuilder_StringBuilder_Int32_Int32_0;

		// Token: 0x04001DE8 RID: 7656
		private static readonly IntPtr NativeMethodInfoPtr_AppendLine_Public_StringBuilder_0;

		// Token: 0x04001DE9 RID: 7657
		private static readonly IntPtr NativeMethodInfoPtr_AppendLine_Public_StringBuilder_String_0;

		// Token: 0x04001DEA RID: 7658
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Int32_Span_1_Char_Int32_0;

		// Token: 0x04001DEB RID: 7659
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_StringBuilder_Int32_Int32_0;

		// Token: 0x04001DEC RID: 7660
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_StringBuilder_Char_0;

		// Token: 0x04001DED RID: 7661
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_StringBuilder_Byte_0;

		// Token: 0x04001DEE RID: 7662
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_StringBuilder_Int32_0;

		// Token: 0x04001DEF RID: 7663
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_StringBuilder_UInt32_0;

		// Token: 0x04001DF0 RID: 7664
		private static readonly IntPtr NativeMethodInfoPtr_AppendSpanFormattable_Private_StringBuilder_T_0;

		// Token: 0x04001DF1 RID: 7665
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_StringBuilder_Object_0;

		// Token: 0x04001DF2 RID: 7666
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_StringBuilder_Il2CppStructArray_1_Char_0;

		// Token: 0x04001DF3 RID: 7667
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_StringBuilder_ReadOnlySpan_1_Char_0;

		// Token: 0x04001DF4 RID: 7668
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_StringBuilder_Int32_String_0;

		// Token: 0x04001DF5 RID: 7669
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_StringBuilder_Int32_Char_0;

		// Token: 0x04001DF6 RID: 7670
		private static readonly IntPtr NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_String_Object_0;

		// Token: 0x04001DF7 RID: 7671
		private static readonly IntPtr NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_String_Object_Object_0;

		// Token: 0x04001DF8 RID: 7672
		private static readonly IntPtr NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001DF9 RID: 7673
		private static readonly IntPtr NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_IFormatProvider_String_Object_0;

		// Token: 0x04001DFA RID: 7674
		private static readonly IntPtr NativeMethodInfoPtr_AppendFormat_Public_StringBuilder_IFormatProvider_String_Object_Object_Object_0;

		// Token: 0x04001DFB RID: 7675
		private static readonly IntPtr NativeMethodInfoPtr_FormatError_Private_Static_Void_0;

		// Token: 0x04001DFC RID: 7676
		private static readonly IntPtr NativeMethodInfoPtr_AppendFormatHelper_Internal_StringBuilder_IFormatProvider_String_ParamsArray_0;

		// Token: 0x04001DFD RID: 7677
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_StringBuilder_String_String_0;

		// Token: 0x04001DFE RID: 7678
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_StringBuilder_String_String_Int32_Int32_0;

		// Token: 0x04001DFF RID: 7679
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_StringBuilder_Char_Char_Int32_Int32_0;

		// Token: 0x04001E00 RID: 7680
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_StringBuilder_ptr_Char_Int32_0;

		// Token: 0x04001E01 RID: 7681
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Private_Void_Int32_ptr_Char_Int32_0;

		// Token: 0x04001E02 RID: 7682
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceAllInChunk_Private_Void_Il2CppStructArray_1_Int32_Int32_StringBuilder_Int32_String_0;

		// Token: 0x04001E03 RID: 7683
		private static readonly IntPtr NativeMethodInfoPtr_StartsWith_Private_Boolean_StringBuilder_Int32_Int32_String_0;

		// Token: 0x04001E04 RID: 7684
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceInPlaceAtChunk_Private_Void_byref_StringBuilder_byref_Int32_ptr_Char_Int32_0;

		// Token: 0x04001E05 RID: 7685
		private static readonly IntPtr NativeMethodInfoPtr_ThreadSafeCopy_Private_Static_Void_ptr_Char_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04001E06 RID: 7686
		private static readonly IntPtr NativeMethodInfoPtr_ThreadSafeCopy_Private_Static_Void_Il2CppStructArray_1_Char_Int32_Span_1_Char_Int32_Int32_0;

		// Token: 0x04001E07 RID: 7687
		private static readonly IntPtr NativeMethodInfoPtr_FindChunkForIndex_Private_StringBuilder_Int32_0;

		// Token: 0x04001E08 RID: 7688
		private static readonly IntPtr NativeMethodInfoPtr_get_RemainingCurrentChunk_Private_get_Span_1_Char_0;

		// Token: 0x04001E09 RID: 7689
		private static readonly IntPtr NativeMethodInfoPtr_Next_Private_StringBuilder_StringBuilder_0;

		// Token: 0x04001E0A RID: 7690
		private static readonly IntPtr NativeMethodInfoPtr_ExpandByABlock_Private_Void_Int32_0;

		// Token: 0x04001E0B RID: 7691
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_StringBuilder_0;

		// Token: 0x04001E0C RID: 7692
		private static readonly IntPtr NativeMethodInfoPtr_MakeRoom_Private_Void_Int32_Int32_byref_StringBuilder_byref_Int32_Boolean_0;

		// Token: 0x04001E0D RID: 7693
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_StringBuilder_0;

		// Token: 0x04001E0E RID: 7694
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Private_Void_Int32_Int32_byref_StringBuilder_byref_Int32_0;

		// Token: 0x0200064C RID: 1612
		private sealed class MethodInfoStoreGeneric_AppendSpanFormattable_Private_StringBuilder_T_0<T>
		{
			// Token: 0x04004972 RID: 18802
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StringBuilder.NativeMethodInfoPtr_AppendSpanFormattable_Private_StringBuilder_T_0, Il2CppClassPointerStore<StringBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
