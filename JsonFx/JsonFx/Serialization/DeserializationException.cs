using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.Serialization;

namespace JsonFx.Serialization
{
	// Token: 0x0200000E RID: 14
	public class DeserializationException : SerializationException
	{
		// Token: 0x0600008A RID: 138 RVA: 0x0000588C File Offset: 0x00003A8C
		// Note: this type is marked as 'beforefieldinit'.
		static DeserializationException()
		{
			Il2CppClassPointerStore<DeserializationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Serialization", "DeserializationException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeserializationException>.NativeClassPtr);
			DeserializationException.NativeFieldInfoPtr_column = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializationException>.NativeClassPtr, "column");
			DeserializationException.NativeFieldInfoPtr_line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializationException>.NativeClassPtr, "line");
			DeserializationException.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializationException>.NativeClassPtr, "index");
			DeserializationException.NativeMethodInfoPtr__ctor_Public_Void_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializationException>.NativeClassPtr, 100663351);
			DeserializationException.NativeMethodInfoPtr__ctor_Public_Void_String_Int64_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializationException>.NativeClassPtr, 100663352);
			DeserializationException.NativeMethodInfoPtr__ctor_Public_Void_String_Int64_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializationException>.NativeClassPtr, 100663353);
			DeserializationException.NativeMethodInfoPtr__ctor_Public_Void_String_Int64_Int32_Int32_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializationException>.NativeClassPtr, 100663354);
			DeserializationException.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializationException>.NativeClassPtr, 100663355);
			DeserializationException.NativeMethodInfoPtr_get_Column_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializationException>.NativeClassPtr, 100663356);
			DeserializationException.NativeMethodInfoPtr_get_Index_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializationException>.NativeClassPtr, 100663357);
			DeserializationException.NativeMethodInfoPtr_get_Line_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializationException>.NativeClassPtr, 100663358);
			DeserializationException.NativeMethodInfoPtr_GetLineAndColumn_Public_Void_String_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializationException>.NativeClassPtr, 100663359);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000059AC File Offset: 0x00003BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189792, XrefRangeEnd = 1189793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeserializationException(string message, long index)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeserializationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeserializationException.NativeMethodInfoPtr__ctor_Public_Void_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00005A08 File Offset: 0x00003C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189793, XrefRangeEnd = 1189794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeserializationException(string message, long index, int line, int column)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeserializationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref column;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeserializationException.NativeMethodInfoPtr__ctor_Public_Void_String_Int64_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00005A80 File Offset: 0x00003C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189794, XrefRangeEnd = 1189795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeserializationException(string message, long index, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeserializationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeserializationException.NativeMethodInfoPtr__ctor_Public_Void_String_Int64_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00005AEC File Offset: 0x00003CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189795, XrefRangeEnd = 1189796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeserializationException(string message, long index, int line, int column, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeserializationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref column;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeserializationException.NativeMethodInfoPtr__ctor_Public_Void_String_Int64_Int32_Int32_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00005B74 File Offset: 0x00003D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189796, XrefRangeEnd = 1189797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeserializationException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeserializationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeserializationException.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00005BD8 File Offset: 0x00003DD8
		public unsafe int Column
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 311826, RefRangeEnd = 311839, XrefRangeStart = 311826, XrefRangeEnd = 311839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeserializationException.NativeMethodInfoPtr_get_Column_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00005C14 File Offset: 0x00003E14
		public unsafe long Index
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeserializationException.NativeMethodInfoPtr_get_Index_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00005C50 File Offset: 0x00003E50
		public unsafe int Line
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeserializationException.NativeMethodInfoPtr_get_Line_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00005C8C File Offset: 0x00003E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189797, XrefRangeEnd = 1189802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetLineAndColumn(string source, out int line, out int col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &line;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeserializationException.NativeMethodInfoPtr_GetLineAndColumn_Public_Void_String_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000239B File Offset: 0x0000059B
		public DeserializationException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00005CEC File Offset: 0x00003EEC
		// (set) Token: 0x06000096 RID: 150 RVA: 0x000023A4 File Offset: 0x000005A4
		public unsafe int column
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeserializationException.NativeFieldInfoPtr_column);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeserializationException.NativeFieldInfoPtr_column)) = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00005D14 File Offset: 0x00003F14
		// (set) Token: 0x06000098 RID: 152 RVA: 0x000023BF File Offset: 0x000005BF
		public unsafe int line
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeserializationException.NativeFieldInfoPtr_line);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeserializationException.NativeFieldInfoPtr_line)) = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00005D3C File Offset: 0x00003F3C
		// (set) Token: 0x0600009A RID: 154 RVA: 0x000023DA File Offset: 0x000005DA
		public unsafe long index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeserializationException.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeserializationException.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeFieldInfoPtr_column;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeFieldInfoPtr_line;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int64_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int64_Int32_Int32_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int64_Exception_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int64_Int32_Int32_Exception_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_get_Column_Public_get_Int32_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_get_Index_Public_get_Int64_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_get_Line_Public_get_Int32_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_GetLineAndColumn_Public_Void_String_byref_Int32_byref_Int32_0;
	}
}
