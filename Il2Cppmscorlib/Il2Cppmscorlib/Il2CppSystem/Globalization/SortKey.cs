using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200048C RID: 1164
	[Serializable]
	public class SortKey : Object
	{
		// Token: 0x060047A3 RID: 18339 RVA: 0x0014E72C File Offset: 0x0014C92C
		// Note: this type is marked as 'beforefieldinit'.
		static SortKey()
		{
			Il2CppClassPointerStore<SortKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "SortKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortKey>.NativeClassPtr);
			SortKey.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKey>.NativeClassPtr, "source");
			SortKey.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKey>.NativeClassPtr, "key");
			SortKey.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKey>.NativeClassPtr, "options");
			SortKey.NativeFieldInfoPtr_lcid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKey>.NativeClassPtr, "lcid");
			SortKey.NativeMethodInfoPtr_Compare_Public_Static_Int32_SortKey_SortKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKey>.NativeClassPtr, 100673811);
			SortKey.NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKey>.NativeClassPtr, 100673812);
			SortKey.NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_Il2CppStructArray_1_Byte_CompareOptions_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKey>.NativeClassPtr, 100673813);
			SortKey.NativeMethodInfoPtr__ctor_Internal_Void_String_String_CompareOptions_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKey>.NativeClassPtr, 100673814);
			SortKey.NativeMethodInfoPtr_get_OriginalString_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKey>.NativeClassPtr, 100673815);
			SortKey.NativeMethodInfoPtr_get_KeyData_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKey>.NativeClassPtr, 100673816);
			SortKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKey>.NativeClassPtr, 100673817);
			SortKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKey>.NativeClassPtr, 100673818);
			SortKey.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKey>.NativeClassPtr, 100673819);
			SortKey.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKey>.NativeClassPtr, 100673820);
		}

		// Token: 0x060047A4 RID: 18340 RVA: 0x0014E874 File Offset: 0x0014CA74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1411531, RefRangeEnd = 1411532, XrefRangeStart = 1411531, XrefRangeEnd = 1411531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(SortKey sortkey1, SortKey sortkey2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sortkey1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sortkey2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKey.NativeMethodInfoPtr_Compare_Public_Static_Int32_SortKey_SortKey_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047A5 RID: 18341 RVA: 0x0014E8C8 File Offset: 0x0014CAC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1411541, RefRangeEnd = 1411543, XrefRangeStart = 1411532, XrefRangeEnd = 1411541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortKey(int lcid, string source, CompareOptions opt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortKey>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lcid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKey.NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047A6 RID: 18342 RVA: 0x0014E930 File Offset: 0x0014CB30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1411546, RefRangeEnd = 1411547, XrefRangeStart = 1411543, XrefRangeEnd = 1411546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortKey(int lcid, string source, Il2CppStructArray<byte> buffer, CompareOptions opt, int lv1Length, int lv2Length, int lv3Length, int kanaSmallLength, int markTypeLength, int katakanaLength, int kanaWidthLength, int identLength)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortKey>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lcid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lv1Length;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lv2Length;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lv3Length;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kanaSmallLength;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref markTypeLength;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref katakanaLength;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kanaWidthLength;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref identLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKey.NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_Il2CppStructArray_1_Byte_CompareOptions_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047A7 RID: 18343 RVA: 0x0014EA20 File Offset: 0x0014CC20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1411553, RefRangeEnd = 1411554, XrefRangeStart = 1411547, XrefRangeEnd = 1411553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortKey(string localeName, string str, CompareOptions options, Il2CppStructArray<byte> keyData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortKey>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKey.NativeMethodInfoPtr__ctor_Internal_Void_String_String_CompareOptions_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x060047A8 RID: 18344 RVA: 0x0014EAA0 File Offset: 0x0014CCA0
		public unsafe virtual string OriginalString
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortKey.NativeMethodInfoPtr_get_OriginalString_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x060047A9 RID: 18345 RVA: 0x0014EAE4 File Offset: 0x0014CCE4
		public unsafe virtual Il2CppStructArray<byte> KeyData
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortKey.NativeMethodInfoPtr_get_KeyData_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060047AA RID: 18346 RVA: 0x0014EB30 File Offset: 0x0014CD30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411554, XrefRangeEnd = 1411558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060047AB RID: 18347 RVA: 0x0014EB88 File Offset: 0x0014CD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411558, XrefRangeEnd = 1411559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047AC RID: 18348 RVA: 0x0014EBD0 File Offset: 0x0014CDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411559, XrefRangeEnd = 1411578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortKey.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060047AD RID: 18349 RVA: 0x0014EC14 File Offset: 0x0014CE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411578, XrefRangeEnd = 1411581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortKey()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortKey>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKey.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047AE RID: 18350 RVA: 0x00019FF5 File Offset: 0x000181F5
		public SortKey(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x060047AF RID: 18351 RVA: 0x0014EC50 File Offset: 0x0014CE50
		// (set) Token: 0x060047B0 RID: 18352 RVA: 0x00019FFE File Offset: 0x000181FE
		public unsafe string source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKey.NativeFieldInfoPtr_source);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKey.NativeFieldInfoPtr_source), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x060047B1 RID: 18353 RVA: 0x0014EC78 File Offset: 0x0014CE78
		// (set) Token: 0x060047B2 RID: 18354 RVA: 0x0001A01D File Offset: 0x0001821D
		public unsafe Il2CppStructArray<byte> key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKey.NativeFieldInfoPtr_key);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKey.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x060047B3 RID: 18355 RVA: 0x0014ECA8 File Offset: 0x0014CEA8
		// (set) Token: 0x060047B4 RID: 18356 RVA: 0x0001A03C File Offset: 0x0001823C
		public unsafe CompareOptions options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKey.NativeFieldInfoPtr_options);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKey.NativeFieldInfoPtr_options)) = value;
			}
		}

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x060047B5 RID: 18357 RVA: 0x0014ECD0 File Offset: 0x0014CED0
		// (set) Token: 0x060047B6 RID: 18358 RVA: 0x0001A057 File Offset: 0x00018257
		public unsafe int lcid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKey.NativeFieldInfoPtr_lcid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKey.NativeFieldInfoPtr_lcid)) = value;
			}
		}

		// Token: 0x04003B0D RID: 15117
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04003B0E RID: 15118
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x04003B0F RID: 15119
		private static readonly IntPtr NativeFieldInfoPtr_options;

		// Token: 0x04003B10 RID: 15120
		private static readonly IntPtr NativeFieldInfoPtr_lcid;

		// Token: 0x04003B11 RID: 15121
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_SortKey_SortKey_0;

		// Token: 0x04003B12 RID: 15122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_CompareOptions_0;

		// Token: 0x04003B13 RID: 15123
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_Il2CppStructArray_1_Byte_CompareOptions_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04003B14 RID: 15124
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_CompareOptions_Il2CppStructArray_1_Byte_0;

		// Token: 0x04003B15 RID: 15125
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginalString_Public_Virtual_New_get_String_0;

		// Token: 0x04003B16 RID: 15126
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyData_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04003B17 RID: 15127
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04003B18 RID: 15128
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04003B19 RID: 15129
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04003B1A RID: 15130
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
