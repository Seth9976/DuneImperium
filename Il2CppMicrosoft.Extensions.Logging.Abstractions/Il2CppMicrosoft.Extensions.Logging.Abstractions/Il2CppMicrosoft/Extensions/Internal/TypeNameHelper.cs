using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;

namespace Il2CppMicrosoft.Extensions.Internal
{
	// Token: 0x0200000D RID: 13
	public static class TypeNameHelper : Object
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00003124 File Offset: 0x00001324
		// Note: this type is marked as 'beforefieldinit'.
		static TypeNameHelper()
		{
			Il2CppClassPointerStore<TypeNameHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.Abstractions.dll", "Microsoft.Extensions.Internal", "TypeNameHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeNameHelper>.NativeClassPtr);
			TypeNameHelper.NativeFieldInfoPtr__builtInTypeNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeNameHelper>.NativeClassPtr, "_builtInTypeNames");
			TypeNameHelper.NativeMethodInfoPtr_GetTypeDisplayName_Public_Static_String_Type_Boolean_Boolean_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNameHelper>.NativeClassPtr, 100663316);
			TypeNameHelper.NativeMethodInfoPtr_ProcessType_Private_Static_String_byref_StringBuilder_Type_byref_DisplayNameOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNameHelper>.NativeClassPtr, 100663317);
			TypeNameHelper.NativeMethodInfoPtr_ProcessArrayType_Private_Static_Void_StringBuilder_Type_byref_DisplayNameOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNameHelper>.NativeClassPtr, 100663318);
			TypeNameHelper.NativeMethodInfoPtr_ProcessGenericType_Private_Static_Void_StringBuilder_Type_Il2CppReferenceArray_1_Type_Int32_byref_DisplayNameOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNameHelper>.NativeClassPtr, 100663319);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000031B8 File Offset: 0x000013B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1264535, RefRangeEnd = 1264536, XrefRangeStart = 1264529, XrefRangeEnd = 1264535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetTypeDisplayName(Type type, bool fullName = true, bool includeGenericParameterNames = false, bool includeGenericParameters = true, char nestedTypeDelimiter = '+')
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fullName;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeGenericParameterNames;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeGenericParameters;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nestedTypeDelimiter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeNameHelper.NativeMethodInfoPtr_GetTypeDisplayName_Public_Static_String_Type_Boolean_Boolean_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000322C File Offset: 0x0000142C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1264550, RefRangeEnd = 1264553, XrefRangeStart = 1264536, XrefRangeEnd = 1264550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ProcessType(ref StringBuilder builder, Type type, [In] ref TypeNameHelper.DisplayNameOptions options)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &options;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TypeNameHelper.NativeMethodInfoPtr_ProcessType_Private_Static_String_byref_StringBuilder_Type_byref_DisplayNameOptions_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			builder = ((intPtr4 == 0) ? null : new StringBuilder(intPtr4));
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000032A0 File Offset: 0x000014A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264553, XrefRangeEnd = 1264564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ProcessArrayType(StringBuilder builder, Type type, [In] ref TypeNameHelper.DisplayNameOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeNameHelper.NativeMethodInfoPtr_ProcessArrayType_Private_Static_Void_StringBuilder_Type_byref_DisplayNameOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000032F8 File Offset: 0x000014F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1264583, RefRangeEnd = 1264584, XrefRangeStart = 1264564, XrefRangeEnd = 1264583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ProcessGenericType(StringBuilder builder, Type type, Il2CppReferenceArray<Type> genericArguments, int length, [In] ref TypeNameHelper.DisplayNameOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genericArguments);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeNameHelper.NativeMethodInfoPtr_ProcessGenericType_Private_Static_Void_StringBuilder_Type_Il2CppReferenceArray_1_Type_Int32_byref_DisplayNameOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002282 File Offset: 0x00000482
		public TypeNameHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00003370 File Offset: 0x00001570
		// (set) Token: 0x06000044 RID: 68 RVA: 0x0000228B File Offset: 0x0000048B
		public unsafe static Dictionary<Type, string> _builtInTypeNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeNameHelper.NativeFieldInfoPtr__builtInTypeNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeNameHelper.NativeFieldInfoPtr__builtInTypeNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeFieldInfoPtr__builtInTypeNames;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeDisplayName_Public_Static_String_Type_Boolean_Boolean_Boolean_Char_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_ProcessType_Private_Static_String_byref_StringBuilder_Type_byref_DisplayNameOptions_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_ProcessArrayType_Private_Static_Void_StringBuilder_Type_byref_DisplayNameOptions_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_ProcessGenericType_Private_Static_Void_StringBuilder_Type_Il2CppReferenceArray_1_Type_Int32_byref_DisplayNameOptions_0;

		// Token: 0x0200001B RID: 27
		[StructLayout(2)]
		public struct DisplayNameOptions
		{
			// Token: 0x060000A7 RID: 167 RVA: 0x000048D8 File Offset: 0x00002AD8
			// Note: this type is marked as 'beforefieldinit'.
			static DisplayNameOptions()
			{
				Il2CppClassPointerStore<TypeNameHelper.DisplayNameOptions>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeNameHelper>.NativeClassPtr, "DisplayNameOptions");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeNameHelper.DisplayNameOptions>.NativeClassPtr);
				TypeNameHelper.DisplayNameOptions.NativeFieldInfoPtr__FullName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeNameHelper.DisplayNameOptions>.NativeClassPtr, "<FullName>k__BackingField");
				TypeNameHelper.DisplayNameOptions.NativeFieldInfoPtr__IncludeGenericParameters_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeNameHelper.DisplayNameOptions>.NativeClassPtr, "<IncludeGenericParameters>k__BackingField");
				TypeNameHelper.DisplayNameOptions.NativeFieldInfoPtr__IncludeGenericParameterNames_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeNameHelper.DisplayNameOptions>.NativeClassPtr, "<IncludeGenericParameterNames>k__BackingField");
				TypeNameHelper.DisplayNameOptions.NativeFieldInfoPtr__NestedTypeDelimiter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeNameHelper.DisplayNameOptions>.NativeClassPtr, "<NestedTypeDelimiter>k__BackingField");
				TypeNameHelper.DisplayNameOptions.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNameHelper.DisplayNameOptions>.NativeClassPtr, 100663321);
				TypeNameHelper.DisplayNameOptions.NativeMethodInfoPtr_get_FullName_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNameHelper.DisplayNameOptions>.NativeClassPtr, 100663322);
				TypeNameHelper.DisplayNameOptions.NativeMethodInfoPtr_get_IncludeGenericParameters_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNameHelper.DisplayNameOptions>.NativeClassPtr, 100663323);
				TypeNameHelper.DisplayNameOptions.NativeMethodInfoPtr_get_IncludeGenericParameterNames_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNameHelper.DisplayNameOptions>.NativeClassPtr, 100663324);
				TypeNameHelper.DisplayNameOptions.NativeMethodInfoPtr_get_NestedTypeDelimiter_Public_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNameHelper.DisplayNameOptions>.NativeClassPtr, 100663325);
			}

			// Token: 0x060000A8 RID: 168 RVA: 0x000049B8 File Offset: 0x00002BB8
			[CallerCount(0)]
			public unsafe DisplayNameOptions(bool fullName, bool includeGenericParameterNames, bool includeGenericParameters, char nestedTypeDelimiter)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref fullName;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeGenericParameterNames;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeGenericParameters;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nestedTypeDelimiter;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeNameHelper.DisplayNameOptions.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Char_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060000A9 RID: 169 RVA: 0x00004A14 File Offset: 0x00002C14
			public unsafe bool FullName
			{
				[CallerCount(45)]
				[CachedScanResults(RefRangeStart = 441993, RefRangeEnd = 442038, XrefRangeStart = 441993, XrefRangeEnd = 442038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeNameHelper.DisplayNameOptions.NativeMethodInfoPtr_get_FullName_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060000AA RID: 170 RVA: 0x00004A44 File Offset: 0x00002C44
			public unsafe bool IncludeGenericParameters
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeNameHelper.DisplayNameOptions.NativeMethodInfoPtr_get_IncludeGenericParameters_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060000AB RID: 171 RVA: 0x00004A74 File Offset: 0x00002C74
			public unsafe bool IncludeGenericParameterNames
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1185388, RefRangeEnd = 1185389, XrefRangeStart = 1185388, XrefRangeEnd = 1185389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeNameHelper.DisplayNameOptions.NativeMethodInfoPtr_get_IncludeGenericParameterNames_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060000AC RID: 172 RVA: 0x00004AA4 File Offset: 0x00002CA4
			public unsafe char NestedTypeDelimiter
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeNameHelper.DisplayNameOptions.NativeMethodInfoPtr_get_NestedTypeDelimiter_Public_get_Char_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000AD RID: 173 RVA: 0x00002635 File Offset: 0x00000835
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TypeNameHelper.DisplayNameOptions>.NativeClassPtr, ref this));
			}

			// Token: 0x0400005E RID: 94
			private static readonly IntPtr NativeFieldInfoPtr__FullName_k__BackingField;

			// Token: 0x0400005F RID: 95
			private static readonly IntPtr NativeFieldInfoPtr__IncludeGenericParameters_k__BackingField;

			// Token: 0x04000060 RID: 96
			private static readonly IntPtr NativeFieldInfoPtr__IncludeGenericParameterNames_k__BackingField;

			// Token: 0x04000061 RID: 97
			private static readonly IntPtr NativeFieldInfoPtr__NestedTypeDelimiter_k__BackingField;

			// Token: 0x04000062 RID: 98
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Char_0;

			// Token: 0x04000063 RID: 99
			private static readonly IntPtr NativeMethodInfoPtr_get_FullName_Public_get_Boolean_0;

			// Token: 0x04000064 RID: 100
			private static readonly IntPtr NativeMethodInfoPtr_get_IncludeGenericParameters_Public_get_Boolean_0;

			// Token: 0x04000065 RID: 101
			private static readonly IntPtr NativeMethodInfoPtr_get_IncludeGenericParameterNames_Public_get_Boolean_0;

			// Token: 0x04000066 RID: 102
			private static readonly IntPtr NativeMethodInfoPtr_get_NestedTypeDelimiter_Public_get_Char_0;

			// Token: 0x04000067 RID: 103
			[FieldOffset(0)]
			[MarshalAs(4)]
			public readonly bool _FullName_k__BackingField;

			// Token: 0x04000068 RID: 104
			[FieldOffset(1)]
			[MarshalAs(4)]
			public readonly bool _IncludeGenericParameters_k__BackingField;

			// Token: 0x04000069 RID: 105
			[FieldOffset(2)]
			[MarshalAs(4)]
			public readonly bool _IncludeGenericParameterNames_k__BackingField;

			// Token: 0x0400006A RID: 106
			[FieldOffset(4)]
			public readonly char _NestedTypeDelimiter_k__BackingField;
		}
	}
}
