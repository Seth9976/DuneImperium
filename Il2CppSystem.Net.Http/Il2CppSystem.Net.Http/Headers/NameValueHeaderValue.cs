using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Net.Http.Headers
{
	// Token: 0x0200002D RID: 45
	public class NameValueHeaderValue : Object
	{
		// Token: 0x060002D9 RID: 729 RVA: 0x0000FF94 File Offset: 0x0000E194
		// Note: this type is marked as 'beforefieldinit'.
		static NameValueHeaderValue()
		{
			Il2CppClassPointerStore<NameValueHeaderValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http.Headers", "NameValueHeaderValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameValueHeaderValue>.NativeClassPtr);
			NameValueHeaderValue.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameValueHeaderValue>.NativeClassPtr, "value");
			NameValueHeaderValue.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameValueHeaderValue>.NativeClassPtr, "<Name>k__BackingField");
			NameValueHeaderValue.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueHeaderValue>.NativeClassPtr, 100663760);
			NameValueHeaderValue.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueHeaderValue>.NativeClassPtr, 100663761);
			NameValueHeaderValue.NativeMethodInfoPtr__ctor_FamOrAssem_Void_NameValueHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueHeaderValue>.NativeClassPtr, 100663762);
			NameValueHeaderValue.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueHeaderValue>.NativeClassPtr, 100663763);
			NameValueHeaderValue.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueHeaderValue>.NativeClassPtr, 100663764);
			NameValueHeaderValue.NativeMethodInfoPtr_set_Name_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueHeaderValue>.NativeClassPtr, 100663765);
			NameValueHeaderValue.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueHeaderValue>.NativeClassPtr, 100663766);
			NameValueHeaderValue.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueHeaderValue>.NativeClassPtr, 100663767);
			NameValueHeaderValue.NativeMethodInfoPtr_Create_Internal_Static_NameValueHeaderValue_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueHeaderValue>.NativeClassPtr, 100663768);
			NameValueHeaderValue.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueHeaderValue>.NativeClassPtr, 100663769);
			NameValueHeaderValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueHeaderValue>.NativeClassPtr, 100663770);
			NameValueHeaderValue.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueHeaderValue>.NativeClassPtr, 100663771);
			NameValueHeaderValue.NativeMethodInfoPtr_TryParsePragma_Internal_Static_Boolean_String_Int32_byref_List_1_NameValueHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueHeaderValue>.NativeClassPtr, 100663772);
			NameValueHeaderValue.NativeMethodInfoPtr_TryParseParameters_Internal_Static_Boolean_Lexer_byref_List_1_NameValueHeaderValue_byref_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueHeaderValue>.NativeClassPtr, 100663773);
			NameValueHeaderValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueHeaderValue>.NativeClassPtr, 100663774);
			NameValueHeaderValue.NativeMethodInfoPtr_TryParseElement_Private_Static_Boolean_Lexer_byref_NameValueHeaderValue_byref_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueHeaderValue>.NativeClassPtr, 100663775);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0001012C File Offset: 0x0000E32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175070, XrefRangeEnd = 1175074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameValueHeaderValue(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameValueHeaderValue>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueHeaderValue.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00010178 File Offset: 0x0000E378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1175078, RefRangeEnd = 1175079, XrefRangeStart = 1175074, XrefRangeEnd = 1175078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameValueHeaderValue(string name, string value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameValueHeaderValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueHeaderValue.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000101D8 File Offset: 0x0000E3D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1175083, RefRangeEnd = 1175084, XrefRangeStart = 1175079, XrefRangeEnd = 1175083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameValueHeaderValue(NameValueHeaderValue source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameValueHeaderValue>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueHeaderValue.NativeMethodInfoPtr__ctor_FamOrAssem_Void_NameValueHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00010224 File Offset: 0x0000E424
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameValueHeaderValue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameValueHeaderValue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueHeaderValue.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060002DE RID: 734 RVA: 0x00010260 File Offset: 0x0000E460
		// (set) Token: 0x060002DF RID: 735 RVA: 0x00010298 File Offset: 0x0000E498
		public unsafe string Name
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueHeaderValue.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueHeaderValue.NativeMethodInfoPtr_set_Name_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x000102DC File Offset: 0x0000E4DC
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x00010314 File Offset: 0x0000E514
		public unsafe string Value
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueHeaderValue.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1175110, RefRangeEnd = 1175116, XrefRangeStart = 1175084, XrefRangeEnd = 1175110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueHeaderValue.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00010358 File Offset: 0x0000E558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175116, XrefRangeEnd = 1175122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NameValueHeaderValue Create(string name, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueHeaderValue.NativeMethodInfoPtr_Create_Internal_Static_NameValueHeaderValue_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameValueHeaderValue>(intPtr3) : null;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x000103B0 File Offset: 0x0000E5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175122, XrefRangeEnd = 1175128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object System_ICloneable_Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueHeaderValue.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x000103F0 File Offset: 0x0000E5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameValueHeaderValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00010438 File Offset: 0x0000E638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175128, XrefRangeEnd = 1175135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameValueHeaderValue.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00010490 File Offset: 0x0000E690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175135, XrefRangeEnd = 1175144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParsePragma(string input, int minimalCount, out List<NameValueHeaderValue> result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minimalCount;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NameValueHeaderValue.NativeMethodInfoPtr_TryParsePragma_Internal_Static_Boolean_String_Int32_byref_List_1_NameValueHeaderValue_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new List<NameValueHeaderValue>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00010504 File Offset: 0x0000E704
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1175186, RefRangeEnd = 1175192, XrefRangeStart = 1175144, XrefRangeEnd = 1175186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseParameters(Lexer lexer, out List<NameValueHeaderValue> result, out Token t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lexer);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NameValueHeaderValue.NativeMethodInfoPtr_TryParseParameters_Internal_Static_Boolean_Lexer_byref_List_1_NameValueHeaderValue_byref_Token_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new List<NameValueHeaderValue>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00010578 File Offset: 0x0000E778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175192, XrefRangeEnd = 1175196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameValueHeaderValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x000105BC File Offset: 0x0000E7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175196, XrefRangeEnd = 1175225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseElement(Lexer lexer, out NameValueHeaderValue parsedValue, out Token t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lexer);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NameValueHeaderValue.NativeMethodInfoPtr_TryParseElement_Private_Static_Boolean_Lexer_byref_NameValueHeaderValue_byref_Token_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parsedValue = ((intPtr4 == 0) ? null : new NameValueHeaderValue(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00003046 File Offset: 0x00001246
		public NameValueHeaderValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00010630 File Offset: 0x0000E830
		// (set) Token: 0x060002EC RID: 748 RVA: 0x0000304F File Offset: 0x0000124F
		public unsafe string value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameValueHeaderValue.NativeFieldInfoPtr_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameValueHeaderValue.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00010658 File Offset: 0x0000E858
		// (set) Token: 0x060002EE RID: 750 RVA: 0x0000306E File Offset: 0x0000126E
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameValueHeaderValue.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameValueHeaderValue.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_NameValueHeaderValue_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Internal_set_Void_String_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_String_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_NameValueHeaderValue_String_String_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_TryParsePragma_Internal_Static_Boolean_String_Int32_byref_List_1_NameValueHeaderValue_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_TryParseParameters_Internal_Static_Boolean_Lexer_byref_List_1_NameValueHeaderValue_byref_Token_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_TryParseElement_Private_Static_Boolean_Lexer_byref_NameValueHeaderValue_byref_Token_0;
	}
}
