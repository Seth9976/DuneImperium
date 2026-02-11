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
	// Token: 0x02000030 RID: 48
	public static class TypeNameHelper : Object
	{
		// Token: 0x06000228 RID: 552 RVA: 0x0000BECC File Offset: 0x0000A0CC
		// Note: this type is marked as 'beforefieldinit'.
		static TypeNameHelper()
		{
			Il2CppClassPointerStore<TypeNameHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.Internal", "TypeNameHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeNameHelper>.NativeClassPtr);
			TypeNameHelper.NativeFieldInfoPtr__builtInTypeNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeNameHelper>.NativeClassPtr, "_builtInTypeNames");
			TypeNameHelper.NativeMethodInfoPtr_GetTypeDisplayName_Public_Static_String_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNameHelper>.NativeClassPtr, 100663637);
			TypeNameHelper.NativeMethodInfoPtr_GetTypeDisplayName_Public_Static_String_Type_Boolean_Boolean_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNameHelper>.NativeClassPtr, 100663638);
			TypeNameHelper.NativeMethodInfoPtr_ProcessType_Private_Static_String_byref_StringBuilder_Type_byref_DisplayNameOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNameHelper>.NativeClassPtr, 100663639);
			TypeNameHelper.NativeMethodInfoPtr_ProcessArrayType_Private_Static_Void_StringBuilder_Type_byref_DisplayNameOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNameHelper>.NativeClassPtr, 100663640);
			TypeNameHelper.NativeMethodInfoPtr_ProcessGenericType_Private_Static_Void_StringBuilder_Type_Il2CppReferenceArray_1_Type_Int32_byref_DisplayNameOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNameHelper>.NativeClassPtr, 100663641);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000BF74 File Offset: 0x0000A174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205664, XrefRangeEnd = 1205665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetTypeDisplayName(Object item, bool fullName = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fullName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeNameHelper.NativeMethodInfoPtr_GetTypeDisplayName_Public_Static_String_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000BFC0 File Offset: 0x0000A1C0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1205671, RefRangeEnd = 1205676, XrefRangeStart = 1205665, XrefRangeEnd = 1205671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600022B RID: 555 RVA: 0x0000C034 File Offset: 0x0000A234
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1205690, RefRangeEnd = 1205693, XrefRangeStart = 1205676, XrefRangeEnd = 1205690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600022C RID: 556 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205693, XrefRangeEnd = 1205704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600022D RID: 557 RVA: 0x0000C100 File Offset: 0x0000A300
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1205723, RefRangeEnd = 1205724, XrefRangeStart = 1205704, XrefRangeEnd = 1205723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600022E RID: 558 RVA: 0x00002C81 File Offset: 0x00000E81
		public TypeNameHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600022F RID: 559 RVA: 0x0000C178 File Offset: 0x0000A378
		// (set) Token: 0x06000230 RID: 560 RVA: 0x00002C8A File Offset: 0x00000E8A
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

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeFieldInfoPtr__builtInTypeNames;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeDisplayName_Public_Static_String_Object_Boolean_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeDisplayName_Public_Static_String_Type_Boolean_Boolean_Boolean_Char_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_ProcessType_Private_Static_String_byref_StringBuilder_Type_byref_DisplayNameOptions_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_ProcessArrayType_Private_Static_Void_StringBuilder_Type_byref_DisplayNameOptions_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_ProcessGenericType_Private_Static_Void_StringBuilder_Type_Il2CppReferenceArray_1_Type_Int32_byref_DisplayNameOptions_0;

		// Token: 0x02000049 RID: 73
		[StructLayout(2)]
		public struct DisplayNameOptions
		{
			// Token: 0x060002F1 RID: 753 RVA: 0x0000E32C File Offset: 0x0000C52C
			// Note: this type is marked as 'beforefieldinit'.
			static DisplayNameOptions()
			{
				Il2CppClassPointerStore<TypeNameHelper.DisplayNameOptions>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeNameHelper>.NativeClassPtr, "DisplayNameOptions");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeNameHelper.DisplayNameOptions>.NativeClassPtr);
				TypeNameHelper.DisplayNameOptions.NativeFieldInfoPtr__FullName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeNameHelper.DisplayNameOptions>.NativeClassPtr, "<FullName>k__BackingField");
				TypeNameHelper.DisplayNameOptions.NativeFieldInfoPtr__IncludeGenericParameters_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeNameHelper.DisplayNameOptions>.NativeClassPtr, "<IncludeGenericParameters>k__BackingField");
				TypeNameHelper.DisplayNameOptions.NativeFieldInfoPtr__IncludeGenericParameterNames_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeNameHelper.DisplayNameOptions>.NativeClassPtr, "<IncludeGenericParameterNames>k__BackingField");
				TypeNameHelper.DisplayNameOptions.NativeFieldInfoPtr__NestedTypeDelimiter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeNameHelper.DisplayNameOptions>.NativeClassPtr, "<NestedTypeDelimiter>k__BackingField");
				TypeNameHelper.DisplayNameOptions.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNameHelper.DisplayNameOptions>.NativeClassPtr, 100663643);
				TypeNameHelper.DisplayNameOptions.NativeMethodInfoPtr_get_FullName_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNameHelper.DisplayNameOptions>.NativeClassPtr, 100663644);
				TypeNameHelper.DisplayNameOptions.NativeMethodInfoPtr_get_IncludeGenericParameters_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNameHelper.DisplayNameOptions>.NativeClassPtr, 100663645);
				TypeNameHelper.DisplayNameOptions.NativeMethodInfoPtr_get_IncludeGenericParameterNames_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNameHelper.DisplayNameOptions>.NativeClassPtr, 100663646);
				TypeNameHelper.DisplayNameOptions.NativeMethodInfoPtr_get_NestedTypeDelimiter_Public_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNameHelper.DisplayNameOptions>.NativeClassPtr, 100663647);
			}

			// Token: 0x060002F2 RID: 754 RVA: 0x0000E40C File Offset: 0x0000C60C
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

			// Token: 0x170000E4 RID: 228
			// (get) Token: 0x060002F3 RID: 755 RVA: 0x0000E468 File Offset: 0x0000C668
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

			// Token: 0x170000E5 RID: 229
			// (get) Token: 0x060002F4 RID: 756 RVA: 0x0000E498 File Offset: 0x0000C698
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

			// Token: 0x170000E6 RID: 230
			// (get) Token: 0x060002F5 RID: 757 RVA: 0x0000E4C8 File Offset: 0x0000C6C8
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

			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x060002F6 RID: 758 RVA: 0x0000E4F8 File Offset: 0x0000C6F8
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

			// Token: 0x060002F7 RID: 759 RVA: 0x00003363 File Offset: 0x00001563
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TypeNameHelper.DisplayNameOptions>.NativeClassPtr, ref this));
			}

			// Token: 0x040001FA RID: 506
			private static readonly IntPtr NativeFieldInfoPtr__FullName_k__BackingField;

			// Token: 0x040001FB RID: 507
			private static readonly IntPtr NativeFieldInfoPtr__IncludeGenericParameters_k__BackingField;

			// Token: 0x040001FC RID: 508
			private static readonly IntPtr NativeFieldInfoPtr__IncludeGenericParameterNames_k__BackingField;

			// Token: 0x040001FD RID: 509
			private static readonly IntPtr NativeFieldInfoPtr__NestedTypeDelimiter_k__BackingField;

			// Token: 0x040001FE RID: 510
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Char_0;

			// Token: 0x040001FF RID: 511
			private static readonly IntPtr NativeMethodInfoPtr_get_FullName_Public_get_Boolean_0;

			// Token: 0x04000200 RID: 512
			private static readonly IntPtr NativeMethodInfoPtr_get_IncludeGenericParameters_Public_get_Boolean_0;

			// Token: 0x04000201 RID: 513
			private static readonly IntPtr NativeMethodInfoPtr_get_IncludeGenericParameterNames_Public_get_Boolean_0;

			// Token: 0x04000202 RID: 514
			private static readonly IntPtr NativeMethodInfoPtr_get_NestedTypeDelimiter_Public_get_Char_0;

			// Token: 0x04000203 RID: 515
			[FieldOffset(0)]
			[MarshalAs(4)]
			public readonly bool _FullName_k__BackingField;

			// Token: 0x04000204 RID: 516
			[FieldOffset(1)]
			[MarshalAs(4)]
			public readonly bool _IncludeGenericParameters_k__BackingField;

			// Token: 0x04000205 RID: 517
			[FieldOffset(2)]
			[MarshalAs(4)]
			public readonly bool _IncludeGenericParameterNames_k__BackingField;

			// Token: 0x04000206 RID: 518
			[FieldOffset(4)]
			public readonly char _NestedTypeDelimiter_k__BackingField;
		}
	}
}
