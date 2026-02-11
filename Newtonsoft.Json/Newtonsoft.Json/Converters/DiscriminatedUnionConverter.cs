using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000E2 RID: 226
	public class DiscriminatedUnionConverter : JsonConverter
	{
		// Token: 0x060013A9 RID: 5033 RVA: 0x0006C5C0 File Offset: 0x0006A7C0
		// Note: this type is marked as 'beforefieldinit'.
		static DiscriminatedUnionConverter()
		{
			Il2CppClassPointerStore<DiscriminatedUnionConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "DiscriminatedUnionConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiscriminatedUnionConverter>.NativeClassPtr);
			DiscriminatedUnionConverter.NativeFieldInfoPtr_CasePropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscriminatedUnionConverter>.NativeClassPtr, "CasePropertyName");
			DiscriminatedUnionConverter.NativeFieldInfoPtr_FieldsPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscriminatedUnionConverter>.NativeClassPtr, "FieldsPropertyName");
			DiscriminatedUnionConverter.NativeFieldInfoPtr_UnionCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscriminatedUnionConverter>.NativeClassPtr, "UnionCache");
			DiscriminatedUnionConverter.NativeFieldInfoPtr_UnionTypeLookupCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscriminatedUnionConverter>.NativeClassPtr, "UnionTypeLookupCache");
			DiscriminatedUnionConverter.NativeMethodInfoPtr_CreateUnionTypeLookup_Private_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscriminatedUnionConverter>.NativeClassPtr, 100667058);
			DiscriminatedUnionConverter.NativeMethodInfoPtr_CreateUnion_Private_Static_Union_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscriminatedUnionConverter>.NativeClassPtr, 100667059);
			DiscriminatedUnionConverter.NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscriminatedUnionConverter>.NativeClassPtr, 100667060);
			DiscriminatedUnionConverter.NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscriminatedUnionConverter>.NativeClassPtr, 100667061);
			DiscriminatedUnionConverter.NativeMethodInfoPtr_CanConvert_Public_Virtual_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscriminatedUnionConverter>.NativeClassPtr, 100667062);
			DiscriminatedUnionConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscriminatedUnionConverter>.NativeClassPtr, 100667063);
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x0006C6B8 File Offset: 0x0006A8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764141, XrefRangeEnd = 764165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type CreateUnionTypeLookup(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscriminatedUnionConverter.NativeMethodInfoPtr_CreateUnionTypeLookup_Private_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x0006C6FC File Offset: 0x0006A8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764165, XrefRangeEnd = 764261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DiscriminatedUnionConverter.Union CreateUnion(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscriminatedUnionConverter.NativeMethodInfoPtr_CreateUnion_Private_Static_Union_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DiscriminatedUnionConverter.Union>(intPtr3) : null;
			}
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x0006C740 File Offset: 0x0006A940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764261, XrefRangeEnd = 764319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteJson(JsonWriter writer, Object value, JsonSerializer serializer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serializer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DiscriminatedUnionConverter.NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x0006C7B4 File Offset: 0x0006A9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764319, XrefRangeEnd = 764375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ReadJson(JsonReader reader, Type objectType, Object existingValue, JsonSerializer serializer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(existingValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serializer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DiscriminatedUnionConverter.NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x0006C848 File Offset: 0x0006AA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764375, XrefRangeEnd = 764402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanConvert(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DiscriminatedUnionConverter.NativeMethodInfoPtr_CanConvert_Public_Virtual_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x0006C8A0 File Offset: 0x0006AAA0
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DiscriminatedUnionConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiscriminatedUnionConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscriminatedUnionConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x000080AC File Offset: 0x000062AC
		public DiscriminatedUnionConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x060013B1 RID: 5041 RVA: 0x0006C8DC File Offset: 0x0006AADC
		// (set) Token: 0x060013B2 RID: 5042 RVA: 0x000080B5 File Offset: 0x000062B5
		public unsafe static string CasePropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DiscriminatedUnionConverter.NativeFieldInfoPtr_CasePropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DiscriminatedUnionConverter.NativeFieldInfoPtr_CasePropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x060013B3 RID: 5043 RVA: 0x0006C8FC File Offset: 0x0006AAFC
		// (set) Token: 0x060013B4 RID: 5044 RVA: 0x000080C7 File Offset: 0x000062C7
		public unsafe static string FieldsPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DiscriminatedUnionConverter.NativeFieldInfoPtr_FieldsPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DiscriminatedUnionConverter.NativeFieldInfoPtr_FieldsPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x060013B5 RID: 5045 RVA: 0x0006C91C File Offset: 0x0006AB1C
		// (set) Token: 0x060013B6 RID: 5046 RVA: 0x000080D9 File Offset: 0x000062D9
		public unsafe static ThreadSafeStore<Type, DiscriminatedUnionConverter.Union> UnionCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DiscriminatedUnionConverter.NativeFieldInfoPtr_UnionCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadSafeStore<Type, DiscriminatedUnionConverter.Union>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DiscriminatedUnionConverter.NativeFieldInfoPtr_UnionCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x060013B7 RID: 5047 RVA: 0x0006C944 File Offset: 0x0006AB44
		// (set) Token: 0x060013B8 RID: 5048 RVA: 0x000080EB File Offset: 0x000062EB
		public unsafe static ThreadSafeStore<Type, Type> UnionTypeLookupCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DiscriminatedUnionConverter.NativeFieldInfoPtr_UnionTypeLookupCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadSafeStore<Type, Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DiscriminatedUnionConverter.NativeFieldInfoPtr_UnionTypeLookupCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FFB RID: 4091
		private static readonly IntPtr NativeFieldInfoPtr_CasePropertyName;

		// Token: 0x04000FFC RID: 4092
		private static readonly IntPtr NativeFieldInfoPtr_FieldsPropertyName;

		// Token: 0x04000FFD RID: 4093
		private static readonly IntPtr NativeFieldInfoPtr_UnionCache;

		// Token: 0x04000FFE RID: 4094
		private static readonly IntPtr NativeFieldInfoPtr_UnionTypeLookupCache;

		// Token: 0x04000FFF RID: 4095
		private static readonly IntPtr NativeMethodInfoPtr_CreateUnionTypeLookup_Private_Static_Type_Type_0;

		// Token: 0x04001000 RID: 4096
		private static readonly IntPtr NativeMethodInfoPtr_CreateUnion_Private_Static_Union_Type_0;

		// Token: 0x04001001 RID: 4097
		private static readonly IntPtr NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0;

		// Token: 0x04001002 RID: 4098
		private static readonly IntPtr NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0;

		// Token: 0x04001003 RID: 4099
		private static readonly IntPtr NativeMethodInfoPtr_CanConvert_Public_Virtual_Boolean_Type_0;

		// Token: 0x04001004 RID: 4100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000223 RID: 547
		public class Union : Object
		{
			// Token: 0x06002298 RID: 8856 RVA: 0x00098C30 File Offset: 0x00096E30
			// Note: this type is marked as 'beforefieldinit'.
			static Union()
			{
				Il2CppClassPointerStore<DiscriminatedUnionConverter.Union>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DiscriminatedUnionConverter>.NativeClassPtr, "Union");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiscriminatedUnionConverter.Union>.NativeClassPtr);
				DiscriminatedUnionConverter.Union.NativeFieldInfoPtr_TagReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscriminatedUnionConverter.Union>.NativeClassPtr, "TagReader");
				DiscriminatedUnionConverter.Union.NativeFieldInfoPtr_Cases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscriminatedUnionConverter.Union>.NativeClassPtr, "Cases");
				DiscriminatedUnionConverter.Union.NativeMethodInfoPtr__ctor_Public_Void_FSharpFunction_List_1_UnionCase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscriminatedUnionConverter.Union>.NativeClassPtr, 100667065);
			}

			// Token: 0x06002299 RID: 8857 RVA: 0x00098C98 File Offset: 0x00096E98
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Union(FSharpFunction tagReader, List<DiscriminatedUnionConverter.UnionCase> cases)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiscriminatedUnionConverter.Union>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tagReader);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cases);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscriminatedUnionConverter.Union.NativeMethodInfoPtr__ctor_Public_Void_FSharpFunction_List_1_UnionCase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600229A RID: 8858 RVA: 0x000119F7 File Offset: 0x0000FBF7
			public Union(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009F1 RID: 2545
			// (get) Token: 0x0600229B RID: 8859 RVA: 0x00098CF8 File Offset: 0x00096EF8
			// (set) Token: 0x0600229C RID: 8860 RVA: 0x00011A00 File Offset: 0x0000FC00
			public unsafe FSharpFunction TagReader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiscriminatedUnionConverter.Union.NativeFieldInfoPtr_TagReader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FSharpFunction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiscriminatedUnionConverter.Union.NativeFieldInfoPtr_TagReader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009F2 RID: 2546
			// (get) Token: 0x0600229D RID: 8861 RVA: 0x00098D28 File Offset: 0x00096F28
			// (set) Token: 0x0600229E RID: 8862 RVA: 0x00011A1F File Offset: 0x0000FC1F
			public unsafe List<DiscriminatedUnionConverter.UnionCase> Cases
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiscriminatedUnionConverter.Union.NativeFieldInfoPtr_Cases);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DiscriminatedUnionConverter.UnionCase>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiscriminatedUnionConverter.Union.NativeFieldInfoPtr_Cases), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018A8 RID: 6312
			private static readonly IntPtr NativeFieldInfoPtr_TagReader;

			// Token: 0x040018A9 RID: 6313
			private static readonly IntPtr NativeFieldInfoPtr_Cases;

			// Token: 0x040018AA RID: 6314
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FSharpFunction_List_1_UnionCase_0;
		}

		// Token: 0x02000224 RID: 548
		public class UnionCase : Object
		{
			// Token: 0x0600229F RID: 8863 RVA: 0x00098D58 File Offset: 0x00096F58
			// Note: this type is marked as 'beforefieldinit'.
			static UnionCase()
			{
				Il2CppClassPointerStore<DiscriminatedUnionConverter.UnionCase>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DiscriminatedUnionConverter>.NativeClassPtr, "UnionCase");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiscriminatedUnionConverter.UnionCase>.NativeClassPtr);
				DiscriminatedUnionConverter.UnionCase.NativeFieldInfoPtr_Tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscriminatedUnionConverter.UnionCase>.NativeClassPtr, "Tag");
				DiscriminatedUnionConverter.UnionCase.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscriminatedUnionConverter.UnionCase>.NativeClassPtr, "Name");
				DiscriminatedUnionConverter.UnionCase.NativeFieldInfoPtr_Fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscriminatedUnionConverter.UnionCase>.NativeClassPtr, "Fields");
				DiscriminatedUnionConverter.UnionCase.NativeFieldInfoPtr_FieldReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscriminatedUnionConverter.UnionCase>.NativeClassPtr, "FieldReader");
				DiscriminatedUnionConverter.UnionCase.NativeFieldInfoPtr_Constructor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscriminatedUnionConverter.UnionCase>.NativeClassPtr, "Constructor");
				DiscriminatedUnionConverter.UnionCase.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_Il2CppReferenceArray_1_PropertyInfo_FSharpFunction_FSharpFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscriminatedUnionConverter.UnionCase>.NativeClassPtr, 100667066);
			}

			// Token: 0x060022A0 RID: 8864 RVA: 0x00098DFC File Offset: 0x00096FFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764127, XrefRangeEnd = 764132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UnionCase(int tag, string name, Il2CppReferenceArray<PropertyInfo> fields, FSharpFunction fieldReader, FSharpFunction constructor)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiscriminatedUnionConverter.UnionCase>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref tag;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fields);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fieldReader);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(constructor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscriminatedUnionConverter.UnionCase.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_Il2CppReferenceArray_1_PropertyInfo_FSharpFunction_FSharpFunction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022A1 RID: 8865 RVA: 0x00011A3E File Offset: 0x0000FC3E
			public UnionCase(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009F3 RID: 2547
			// (get) Token: 0x060022A2 RID: 8866 RVA: 0x00098E90 File Offset: 0x00097090
			// (set) Token: 0x060022A3 RID: 8867 RVA: 0x00011A47 File Offset: 0x0000FC47
			public unsafe int Tag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiscriminatedUnionConverter.UnionCase.NativeFieldInfoPtr_Tag);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiscriminatedUnionConverter.UnionCase.NativeFieldInfoPtr_Tag)) = value;
				}
			}

			// Token: 0x170009F4 RID: 2548
			// (get) Token: 0x060022A4 RID: 8868 RVA: 0x00098EB8 File Offset: 0x000970B8
			// (set) Token: 0x060022A5 RID: 8869 RVA: 0x00011A62 File Offset: 0x0000FC62
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiscriminatedUnionConverter.UnionCase.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiscriminatedUnionConverter.UnionCase.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009F5 RID: 2549
			// (get) Token: 0x060022A6 RID: 8870 RVA: 0x00098EE0 File Offset: 0x000970E0
			// (set) Token: 0x060022A7 RID: 8871 RVA: 0x00011A81 File Offset: 0x0000FC81
			public unsafe Il2CppReferenceArray<PropertyInfo> Fields
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiscriminatedUnionConverter.UnionCase.NativeFieldInfoPtr_Fields);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PropertyInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiscriminatedUnionConverter.UnionCase.NativeFieldInfoPtr_Fields), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009F6 RID: 2550
			// (get) Token: 0x060022A8 RID: 8872 RVA: 0x00098F10 File Offset: 0x00097110
			// (set) Token: 0x060022A9 RID: 8873 RVA: 0x00011AA0 File Offset: 0x0000FCA0
			public unsafe FSharpFunction FieldReader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiscriminatedUnionConverter.UnionCase.NativeFieldInfoPtr_FieldReader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FSharpFunction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiscriminatedUnionConverter.UnionCase.NativeFieldInfoPtr_FieldReader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009F7 RID: 2551
			// (get) Token: 0x060022AA RID: 8874 RVA: 0x00098F40 File Offset: 0x00097140
			// (set) Token: 0x060022AB RID: 8875 RVA: 0x00011ABF File Offset: 0x0000FCBF
			public unsafe FSharpFunction Constructor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiscriminatedUnionConverter.UnionCase.NativeFieldInfoPtr_Constructor);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FSharpFunction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiscriminatedUnionConverter.UnionCase.NativeFieldInfoPtr_Constructor), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018AB RID: 6315
			private static readonly IntPtr NativeFieldInfoPtr_Tag;

			// Token: 0x040018AC RID: 6316
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x040018AD RID: 6317
			private static readonly IntPtr NativeFieldInfoPtr_Fields;

			// Token: 0x040018AE RID: 6318
			private static readonly IntPtr NativeFieldInfoPtr_FieldReader;

			// Token: 0x040018AF RID: 6319
			private static readonly IntPtr NativeFieldInfoPtr_Constructor;

			// Token: 0x040018B0 RID: 6320
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_Il2CppReferenceArray_1_PropertyInfo_FSharpFunction_FSharpFunction_0;
		}

		// Token: 0x02000225 RID: 549
		[ObfuscatedName("Newtonsoft.Json.Converters.DiscriminatedUnionConverter+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x060022AC RID: 8876 RVA: 0x00098F70 File Offset: 0x00097170
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<DiscriminatedUnionConverter.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DiscriminatedUnionConverter>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiscriminatedUnionConverter.__c__DisplayClass8_0>.NativeClassPtr);
				DiscriminatedUnionConverter.__c__DisplayClass8_0.NativeFieldInfoPtr_tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscriminatedUnionConverter.__c__DisplayClass8_0>.NativeClassPtr, "tag");
				DiscriminatedUnionConverter.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscriminatedUnionConverter.__c__DisplayClass8_0>.NativeClassPtr, 100667067);
				DiscriminatedUnionConverter.__c__DisplayClass8_0.NativeMethodInfoPtr__WriteJson_b__0_Internal_Boolean_UnionCase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscriminatedUnionConverter.__c__DisplayClass8_0>.NativeClassPtr, 100667068);
			}

			// Token: 0x060022AD RID: 8877 RVA: 0x00098FD8 File Offset: 0x000971D8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiscriminatedUnionConverter.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscriminatedUnionConverter.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022AE RID: 8878 RVA: 0x00099014 File Offset: 0x00097214
			[CallerCount(0)]
			public unsafe bool _WriteJson_b__0(DiscriminatedUnionConverter.UnionCase c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscriminatedUnionConverter.__c__DisplayClass8_0.NativeMethodInfoPtr__WriteJson_b__0_Internal_Boolean_UnionCase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060022AF RID: 8879 RVA: 0x00011ADE File Offset: 0x0000FCDE
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009F8 RID: 2552
			// (get) Token: 0x060022B0 RID: 8880 RVA: 0x00099064 File Offset: 0x00097264
			// (set) Token: 0x060022B1 RID: 8881 RVA: 0x00011AE7 File Offset: 0x0000FCE7
			public unsafe int tag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiscriminatedUnionConverter.__c__DisplayClass8_0.NativeFieldInfoPtr_tag);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiscriminatedUnionConverter.__c__DisplayClass8_0.NativeFieldInfoPtr_tag)) = value;
				}
			}

			// Token: 0x040018B1 RID: 6321
			private static readonly IntPtr NativeFieldInfoPtr_tag;

			// Token: 0x040018B2 RID: 6322
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040018B3 RID: 6323
			private static readonly IntPtr NativeMethodInfoPtr__WriteJson_b__0_Internal_Boolean_UnionCase_0;
		}

		// Token: 0x02000226 RID: 550
		[ObfuscatedName("Newtonsoft.Json.Converters.DiscriminatedUnionConverter+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x060022B2 RID: 8882 RVA: 0x0009908C File Offset: 0x0009728C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<DiscriminatedUnionConverter.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DiscriminatedUnionConverter>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiscriminatedUnionConverter.__c__DisplayClass9_0>.NativeClassPtr);
				DiscriminatedUnionConverter.__c__DisplayClass9_0.NativeFieldInfoPtr_caseName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscriminatedUnionConverter.__c__DisplayClass9_0>.NativeClassPtr, "caseName");
				DiscriminatedUnionConverter.__c__DisplayClass9_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscriminatedUnionConverter.__c__DisplayClass9_0>.NativeClassPtr, "<>9__0");
				DiscriminatedUnionConverter.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscriminatedUnionConverter.__c__DisplayClass9_0>.NativeClassPtr, 100667069);
				DiscriminatedUnionConverter.__c__DisplayClass9_0.NativeMethodInfoPtr__ReadJson_b__0_Internal_Boolean_UnionCase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscriminatedUnionConverter.__c__DisplayClass9_0>.NativeClassPtr, 100667070);
			}

			// Token: 0x060022B3 RID: 8883 RVA: 0x00099108 File Offset: 0x00097308
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiscriminatedUnionConverter.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscriminatedUnionConverter.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022B4 RID: 8884 RVA: 0x00099144 File Offset: 0x00097344
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764132, XrefRangeEnd = 764141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ReadJson_b__0(DiscriminatedUnionConverter.UnionCase c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscriminatedUnionConverter.__c__DisplayClass9_0.NativeMethodInfoPtr__ReadJson_b__0_Internal_Boolean_UnionCase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060022B5 RID: 8885 RVA: 0x00011B02 File Offset: 0x0000FD02
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009F9 RID: 2553
			// (get) Token: 0x060022B6 RID: 8886 RVA: 0x00099194 File Offset: 0x00097394
			// (set) Token: 0x060022B7 RID: 8887 RVA: 0x00011B0B File Offset: 0x0000FD0B
			public unsafe string caseName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiscriminatedUnionConverter.__c__DisplayClass9_0.NativeFieldInfoPtr_caseName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiscriminatedUnionConverter.__c__DisplayClass9_0.NativeFieldInfoPtr_caseName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170009FA RID: 2554
			// (get) Token: 0x060022B8 RID: 8888 RVA: 0x000991BC File Offset: 0x000973BC
			// (set) Token: 0x060022B9 RID: 8889 RVA: 0x00011B2A File Offset: 0x0000FD2A
			public unsafe Func<DiscriminatedUnionConverter.UnionCase, bool> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiscriminatedUnionConverter.__c__DisplayClass9_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DiscriminatedUnionConverter.UnionCase, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiscriminatedUnionConverter.__c__DisplayClass9_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018B4 RID: 6324
			private static readonly IntPtr NativeFieldInfoPtr_caseName;

			// Token: 0x040018B5 RID: 6325
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x040018B6 RID: 6326
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040018B7 RID: 6327
			private static readonly IntPtr NativeMethodInfoPtr__ReadJson_b__0_Internal_Boolean_UnionCase_0;
		}
	}
}
