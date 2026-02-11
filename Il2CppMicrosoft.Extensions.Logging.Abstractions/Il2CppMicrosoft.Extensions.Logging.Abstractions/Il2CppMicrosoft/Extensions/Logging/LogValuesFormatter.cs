using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppMicrosoft.Extensions.Logging
{
	// Token: 0x0200001A RID: 26
	public sealed class LogValuesFormatter : Object
	{
		// Token: 0x06000093 RID: 147 RVA: 0x00004380 File Offset: 0x00002580
		// Note: this type is marked as 'beforefieldinit'.
		static LogValuesFormatter()
		{
			Il2CppClassPointerStore<LogValuesFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.Abstractions.dll", "Microsoft.Extensions.Logging", "LogValuesFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogValuesFormatter>.NativeClassPtr);
			LogValuesFormatter.NativeFieldInfoPtr_FormatDelimiters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogValuesFormatter>.NativeClassPtr, "FormatDelimiters");
			LogValuesFormatter.NativeFieldInfoPtr__valueNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogValuesFormatter>.NativeClassPtr, "_valueNames");
			LogValuesFormatter.NativeFieldInfoPtr__format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogValuesFormatter>.NativeClassPtr, "_format");
			LogValuesFormatter.NativeFieldInfoPtr__OriginalFormat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogValuesFormatter>.NativeClassPtr, "<OriginalFormat>k__BackingField");
			LogValuesFormatter.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogValuesFormatter>.NativeClassPtr, 100663366);
			LogValuesFormatter.NativeMethodInfoPtr_get_OriginalFormat_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogValuesFormatter>.NativeClassPtr, 100663367);
			LogValuesFormatter.NativeMethodInfoPtr_set_OriginalFormat_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogValuesFormatter>.NativeClassPtr, 100663368);
			LogValuesFormatter.NativeMethodInfoPtr_get_ValueNames_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogValuesFormatter>.NativeClassPtr, 100663369);
			LogValuesFormatter.NativeMethodInfoPtr_FindBraceIndex_Private_Static_Int32_String_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogValuesFormatter>.NativeClassPtr, 100663370);
			LogValuesFormatter.NativeMethodInfoPtr_FindIndexOfAny_Private_Static_Int32_String_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogValuesFormatter>.NativeClassPtr, 100663371);
			LogValuesFormatter.NativeMethodInfoPtr_Format_Public_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogValuesFormatter>.NativeClassPtr, 100663372);
			LogValuesFormatter.NativeMethodInfoPtr_GetValue_Public_KeyValuePair_2_String_Object_Il2CppReferenceArray_1_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogValuesFormatter>.NativeClassPtr, 100663373);
			LogValuesFormatter.NativeMethodInfoPtr_FormatArgument_Private_Static_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogValuesFormatter>.NativeClassPtr, 100663374);
			LogValuesFormatter.NativeMethodInfoPtr_TryFormatArgumentIfNullOrEnumerable_Private_Static_Boolean_T_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogValuesFormatter>.NativeClassPtr, 100663375);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000044C8 File Offset: 0x000026C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1264823, RefRangeEnd = 1264825, XrefRangeStart = 1264775, XrefRangeEnd = 1264823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogValuesFormatter(string format)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogValuesFormatter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogValuesFormatter.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00004514 File Offset: 0x00002714
		// (set) Token: 0x06000096 RID: 150 RVA: 0x0000454C File Offset: 0x0000274C
		public unsafe string OriginalFormat
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogValuesFormatter.NativeMethodInfoPtr_get_OriginalFormat_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogValuesFormatter.NativeMethodInfoPtr_set_OriginalFormat_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00004590 File Offset: 0x00002790
		public unsafe List<string> ValueNames
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogValuesFormatter.NativeMethodInfoPtr_get_ValueNames_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000045D0 File Offset: 0x000027D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264825, XrefRangeEnd = 1264829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindBraceIndex(string format, char brace, int startIndex, int endIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref brace;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogValuesFormatter.NativeMethodInfoPtr_FindBraceIndex_Private_Static_Int32_String_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000463C File Offset: 0x0000283C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264829, XrefRangeEnd = 1264830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindIndexOfAny(string format, Il2CppStructArray<char> chars, int startIndex, int endIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chars);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogValuesFormatter.NativeMethodInfoPtr_FindIndexOfAny_Private_Static_Int32_String_Il2CppStructArray_1_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000046AC File Offset: 0x000028AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1264864, RefRangeEnd = 1264866, XrefRangeStart = 1264830, XrefRangeEnd = 1264864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Format(Il2CppReferenceArray<Object> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogValuesFormatter.NativeMethodInfoPtr_Format_Public_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000046F4 File Offset: 0x000028F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264866, XrefRangeEnd = 1264873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyValuePair<string, Object> GetValue(Il2CppReferenceArray<Object> values, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogValuesFormatter.NativeMethodInfoPtr_GetValue_Public_KeyValuePair_2_String_Object_Il2CppReferenceArray_1_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new KeyValuePair<string, Object>(intPtr);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000474C File Offset: 0x0000294C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1264879, RefRangeEnd = 1264881, XrefRangeStart = 1264873, XrefRangeEnd = 1264879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object FormatArgument(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogValuesFormatter.NativeMethodInfoPtr_FormatArgument_Private_Static_Object_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00004790 File Offset: 0x00002990
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1264920, RefRangeEnd = 1264921, XrefRangeStart = 1264881, XrefRangeEnd = 1264920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryFormatArgumentIfNullOrEnumerable<T>(T value, ref Object stringValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
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
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(stringValue);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LogValuesFormatter.MethodInfoStoreGeneric_TryFormatArgumentIfNullOrEnumerable_Private_Static_Boolean_T_byref_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr2;
			stringValue = ((intPtr5 == 0) ? null : new Object(intPtr5));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000025BD File Offset: 0x000007BD
		public LogValuesFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00004830 File Offset: 0x00002A30
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x000025C6 File Offset: 0x000007C6
		public unsafe static Il2CppStructArray<char> FormatDelimiters
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LogValuesFormatter.NativeFieldInfoPtr_FormatDelimiters, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LogValuesFormatter.NativeFieldInfoPtr_FormatDelimiters, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00004858 File Offset: 0x00002A58
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x000025D8 File Offset: 0x000007D8
		public unsafe List<string> _valueNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogValuesFormatter.NativeFieldInfoPtr__valueNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogValuesFormatter.NativeFieldInfoPtr__valueNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00004888 File Offset: 0x00002A88
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x000025F7 File Offset: 0x000007F7
		public unsafe string _format
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogValuesFormatter.NativeFieldInfoPtr__format);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogValuesFormatter.NativeFieldInfoPtr__format), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x000048B0 File Offset: 0x00002AB0
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00002616 File Offset: 0x00000816
		public unsafe string _OriginalFormat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogValuesFormatter.NativeFieldInfoPtr__OriginalFormat_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogValuesFormatter.NativeFieldInfoPtr__OriginalFormat_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_FormatDelimiters;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr__valueNames;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr__format;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeFieldInfoPtr__OriginalFormat_k__BackingField;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginalFormat_Public_get_String_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_set_OriginalFormat_Private_set_Void_String_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueNames_Public_get_List_1_String_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_FindBraceIndex_Private_Static_Int32_String_Char_Int32_Int32_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_FindIndexOfAny_Private_Static_Int32_String_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_KeyValuePair_2_String_Object_Il2CppReferenceArray_1_Object_Int32_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_FormatArgument_Private_Static_Object_Object_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_TryFormatArgumentIfNullOrEnumerable_Private_Static_Boolean_T_byref_Object_0;

		// Token: 0x02000020 RID: 32
		private sealed class MethodInfoStoreGeneric_TryFormatArgumentIfNullOrEnumerable_Private_Static_Boolean_T_byref_Object_0<T>
		{
			// Token: 0x0400007B RID: 123
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LogValuesFormatter.NativeMethodInfoPtr_TryFormatArgumentIfNullOrEnumerable_Private_Static_Boolean_T_byref_Object_0, Il2CppClassPointerStore<LogValuesFormatter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
