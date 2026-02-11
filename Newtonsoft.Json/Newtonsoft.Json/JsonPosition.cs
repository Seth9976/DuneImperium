using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Newtonsoft.Json
{
	// Token: 0x02000025 RID: 37
	public sealed class JsonPosition : ValueType
	{
		// Token: 0x0600012D RID: 301 RVA: 0x000169C0 File Offset: 0x00014BC0
		// Note: this type is marked as 'beforefieldinit'.
		static JsonPosition()
		{
			Il2CppClassPointerStore<JsonPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json", "JsonPosition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonPosition>.NativeClassPtr);
			JsonPosition.NativeFieldInfoPtr_SpecialCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonPosition>.NativeClassPtr, "SpecialCharacters");
			JsonPosition.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonPosition>.NativeClassPtr, "Type");
			JsonPosition.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonPosition>.NativeClassPtr, "Position");
			JsonPosition.NativeFieldInfoPtr_PropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonPosition>.NativeClassPtr, "PropertyName");
			JsonPosition.NativeFieldInfoPtr_HasIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonPosition>.NativeClassPtr, "HasIndex");
			JsonPosition.NativeMethodInfoPtr__ctor_Public_Void_JsonContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPosition>.NativeClassPtr, 100663469);
			JsonPosition.NativeMethodInfoPtr_CalculateLength_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPosition>.NativeClassPtr, 100663470);
			JsonPosition.NativeMethodInfoPtr_WriteTo_Internal_Void_StringBuilder_byref_StringWriter_byref_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPosition>.NativeClassPtr, 100663471);
			JsonPosition.NativeMethodInfoPtr_TypeHasIndex_Internal_Static_Boolean_JsonContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPosition>.NativeClassPtr, 100663472);
			JsonPosition.NativeMethodInfoPtr_BuildPath_Internal_Static_String_List_1_JsonPosition_Nullable_1_JsonPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPosition>.NativeClassPtr, 100663473);
			JsonPosition.NativeMethodInfoPtr_FormatMessage_Internal_Static_String_IJsonLineInfo_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPosition>.NativeClassPtr, 100663474);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00016ACC File Offset: 0x00014CCC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 728010, RefRangeEnd = 728014, XrefRangeStart = 728005, XrefRangeEnd = 728010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonPosition(JsonContainerType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonPosition>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPosition.NativeMethodInfoPtr__ctor_Public_Void_JsonContainerType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00016B18 File Offset: 0x00014D18
		[CallerCount(0)]
		public unsafe int CalculateLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPosition.NativeMethodInfoPtr_CalculateLength_Internal_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00016B5C File Offset: 0x00014D5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 728026, RefRangeEnd = 728028, XrefRangeStart = 728014, XrefRangeEnd = 728026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteTo(StringBuilder sb, ref StringWriter writer, ref Il2CppStructArray<char> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(JsonPosition.NativeMethodInfoPtr_WriteTo_Internal_Void_StringBuilder_byref_StringWriter_byref_Il2CppStructArray_1_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			writer = ((intPtr5 == 0) ? null : new StringWriter(intPtr5));
			IntPtr intPtr6 = intPtr2;
			buffer = ((intPtr6 == 0) ? null : new Il2CppStructArray<char>(intPtr6));
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00016BF4 File Offset: 0x00014DF4
		[CallerCount(0)]
		public unsafe static bool TypeHasIndex(JsonContainerType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPosition.NativeMethodInfoPtr_TypeHasIndex_Internal_Static_Boolean_JsonContainerType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00016C34 File Offset: 0x00014E34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 728068, RefRangeEnd = 728072, XrefRangeStart = 728028, XrefRangeEnd = 728068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string BuildPath(List<JsonPosition> positions, Nullable<JsonPosition> currentPosition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(positions);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(currentPosition));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPosition.NativeMethodInfoPtr_BuildPath_Internal_Static_String_List_1_JsonPosition_Nullable_1_JsonPosition_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00016C88 File Offset: 0x00014E88
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 728111, RefRangeEnd = 728149, XrefRangeStart = 728072, XrefRangeEnd = 728111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatMessage(IJsonLineInfo lineInfo, string path, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lineInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPosition.NativeMethodInfoPtr_FormatMessage_Internal_Static_String_IJsonLineInfo_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002792 File Offset: 0x00000992
		public JsonPosition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000279B File Offset: 0x0000099B
		public JsonPosition()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonPosition>.NativeClassPtr))
		{
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00016CE8 File Offset: 0x00014EE8
		// (set) Token: 0x06000137 RID: 311 RVA: 0x000027AD File Offset: 0x000009AD
		public unsafe static Il2CppStructArray<char> SpecialCharacters
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonPosition.NativeFieldInfoPtr_SpecialCharacters, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonPosition.NativeFieldInfoPtr_SpecialCharacters, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00016D10 File Offset: 0x00014F10
		// (set) Token: 0x06000139 RID: 313 RVA: 0x000027BF File Offset: 0x000009BF
		public unsafe JsonContainerType Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPosition.NativeFieldInfoPtr_Type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPosition.NativeFieldInfoPtr_Type)) = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00016D38 File Offset: 0x00014F38
		// (set) Token: 0x0600013B RID: 315 RVA: 0x000027DA File Offset: 0x000009DA
		public unsafe int Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPosition.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPosition.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00016D60 File Offset: 0x00014F60
		// (set) Token: 0x0600013D RID: 317 RVA: 0x000027F5 File Offset: 0x000009F5
		public unsafe string PropertyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPosition.NativeFieldInfoPtr_PropertyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPosition.NativeFieldInfoPtr_PropertyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00016D88 File Offset: 0x00014F88
		// (set) Token: 0x0600013F RID: 319 RVA: 0x00002814 File Offset: 0x00000A14
		public unsafe bool HasIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPosition.NativeFieldInfoPtr_HasIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPosition.NativeFieldInfoPtr_HasIndex)) = value;
			}
		}

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeFieldInfoPtr_SpecialCharacters;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeFieldInfoPtr_PropertyName;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeFieldInfoPtr_HasIndex;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_JsonContainerType_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLength_Internal_Int32_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_WriteTo_Internal_Void_StringBuilder_byref_StringWriter_byref_Il2CppStructArray_1_Char_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_TypeHasIndex_Internal_Static_Boolean_JsonContainerType_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_BuildPath_Internal_Static_String_List_1_JsonPosition_Nullable_1_JsonPosition_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_FormatMessage_Internal_Static_String_IJsonLineInfo_String_String_0;
	}
}
