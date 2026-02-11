using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001F2 RID: 498
	public class DigestHeaderParser : Object
	{
		// Token: 0x06001EC2 RID: 7874 RVA: 0x00093968 File Offset: 0x00091B68
		// Note: this type is marked as 'beforefieldinit'.
		static DigestHeaderParser()
		{
			Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "DigestHeaderParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr);
			DigestHeaderParser.NativeFieldInfoPtr_header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, "header");
			DigestHeaderParser.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, "length");
			DigestHeaderParser.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, "pos");
			DigestHeaderParser.NativeFieldInfoPtr_keywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, "keywords");
			DigestHeaderParser.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, "values");
			DigestHeaderParser.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, 100667975);
			DigestHeaderParser.NativeMethodInfoPtr_get_Realm_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, 100667976);
			DigestHeaderParser.NativeMethodInfoPtr_get_Opaque_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, 100667977);
			DigestHeaderParser.NativeMethodInfoPtr_get_Nonce_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, 100667978);
			DigestHeaderParser.NativeMethodInfoPtr_get_Algorithm_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, 100667979);
			DigestHeaderParser.NativeMethodInfoPtr_get_QOP_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, 100667980);
			DigestHeaderParser.NativeMethodInfoPtr_Parse_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, 100667981);
			DigestHeaderParser.NativeMethodInfoPtr_SkipWhitespace_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, 100667982);
			DigestHeaderParser.NativeMethodInfoPtr_GetKey_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, 100667983);
			DigestHeaderParser.NativeMethodInfoPtr_GetKeywordAndValue_Private_Boolean_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr, 100667984);
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x00093AC4 File Offset: 0x00091CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478917, XrefRangeEnd = 478929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DigestHeaderParser(string header)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DigestHeaderParser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(header);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestHeaderParser.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06001EC4 RID: 7876 RVA: 0x00093B10 File Offset: 0x00091D10
		public unsafe string Realm
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 478929, RefRangeEnd = 478930, XrefRangeStart = 478929, XrefRangeEnd = 478929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestHeaderParser.NativeMethodInfoPtr_get_Realm_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06001EC5 RID: 7877 RVA: 0x00093B48 File Offset: 0x00091D48
		public unsafe string Opaque
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 478930, RefRangeEnd = 478931, XrefRangeStart = 478930, XrefRangeEnd = 478930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestHeaderParser.NativeMethodInfoPtr_get_Opaque_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06001EC6 RID: 7878 RVA: 0x00093B80 File Offset: 0x00091D80
		public unsafe string Nonce
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 478931, RefRangeEnd = 478932, XrefRangeStart = 478931, XrefRangeEnd = 478931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestHeaderParser.NativeMethodInfoPtr_get_Nonce_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06001EC7 RID: 7879 RVA: 0x00093BB8 File Offset: 0x00091DB8
		public unsafe string Algorithm
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 478932, RefRangeEnd = 478933, XrefRangeStart = 478932, XrefRangeEnd = 478932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestHeaderParser.NativeMethodInfoPtr_get_Algorithm_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06001EC8 RID: 7880 RVA: 0x00093BF0 File Offset: 0x00091DF0
		public unsafe string QOP
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 478933, RefRangeEnd = 478935, XrefRangeStart = 478933, XrefRangeEnd = 478933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestHeaderParser.NativeMethodInfoPtr_get_QOP_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x00093C28 File Offset: 0x00091E28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478950, RefRangeEnd = 478951, XrefRangeStart = 478935, XrefRangeEnd = 478950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Parse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestHeaderParser.NativeMethodInfoPtr_Parse_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x00093C64 File Offset: 0x00091E64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 478952, RefRangeEnd = 478955, XrefRangeStart = 478951, XrefRangeEnd = 478952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipWhitespace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestHeaderParser.NativeMethodInfoPtr_SkipWhitespace_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x00093C98 File Offset: 0x00091E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478955, XrefRangeEnd = 478961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestHeaderParser.NativeMethodInfoPtr_GetKey_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x00093CD0 File Offset: 0x00091ED0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478978, RefRangeEnd = 478979, XrefRangeStart = 478961, XrefRangeEnd = 478978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetKeywordAndValue(out string key, out string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DigestHeaderParser.NativeMethodInfoPtr_GetKeywordAndValue_Private_Boolean_byref_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			key = IL2CPP.Il2CppStringToManaged(intPtr);
			value = IL2CPP.Il2CppStringToManaged(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x0000D14E File Offset: 0x0000B34E
		public DigestHeaderParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06001ECE RID: 7886 RVA: 0x00093D44 File Offset: 0x00091F44
		// (set) Token: 0x06001ECF RID: 7887 RVA: 0x0000D157 File Offset: 0x0000B357
		public unsafe string header
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestHeaderParser.NativeFieldInfoPtr_header);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestHeaderParser.NativeFieldInfoPtr_header), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06001ED0 RID: 7888 RVA: 0x00093D6C File Offset: 0x00091F6C
		// (set) Token: 0x06001ED1 RID: 7889 RVA: 0x0000D176 File Offset: 0x0000B376
		public unsafe int length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestHeaderParser.NativeFieldInfoPtr_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestHeaderParser.NativeFieldInfoPtr_length)) = value;
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06001ED2 RID: 7890 RVA: 0x00093D94 File Offset: 0x00091F94
		// (set) Token: 0x06001ED3 RID: 7891 RVA: 0x0000D191 File Offset: 0x0000B391
		public unsafe int pos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestHeaderParser.NativeFieldInfoPtr_pos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestHeaderParser.NativeFieldInfoPtr_pos)) = value;
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06001ED4 RID: 7892 RVA: 0x00093DBC File Offset: 0x00091FBC
		// (set) Token: 0x06001ED5 RID: 7893 RVA: 0x0000D1AC File Offset: 0x0000B3AC
		public unsafe static Il2CppStringArray keywords
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DigestHeaderParser.NativeFieldInfoPtr_keywords, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DigestHeaderParser.NativeFieldInfoPtr_keywords, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06001ED6 RID: 7894 RVA: 0x00093DE4 File Offset: 0x00091FE4
		// (set) Token: 0x06001ED7 RID: 7895 RVA: 0x0000D1BE File Offset: 0x0000B3BE
		public unsafe Il2CppStringArray values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestHeaderParser.NativeFieldInfoPtr_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestHeaderParser.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400184B RID: 6219
		private static readonly IntPtr NativeFieldInfoPtr_header;

		// Token: 0x0400184C RID: 6220
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x0400184D RID: 6221
		private static readonly IntPtr NativeFieldInfoPtr_pos;

		// Token: 0x0400184E RID: 6222
		private static readonly IntPtr NativeFieldInfoPtr_keywords;

		// Token: 0x0400184F RID: 6223
		private static readonly IntPtr NativeFieldInfoPtr_values;

		// Token: 0x04001850 RID: 6224
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001851 RID: 6225
		private static readonly IntPtr NativeMethodInfoPtr_get_Realm_Public_get_String_0;

		// Token: 0x04001852 RID: 6226
		private static readonly IntPtr NativeMethodInfoPtr_get_Opaque_Public_get_String_0;

		// Token: 0x04001853 RID: 6227
		private static readonly IntPtr NativeMethodInfoPtr_get_Nonce_Public_get_String_0;

		// Token: 0x04001854 RID: 6228
		private static readonly IntPtr NativeMethodInfoPtr_get_Algorithm_Public_get_String_0;

		// Token: 0x04001855 RID: 6229
		private static readonly IntPtr NativeMethodInfoPtr_get_QOP_Public_get_String_0;

		// Token: 0x04001856 RID: 6230
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Boolean_0;

		// Token: 0x04001857 RID: 6231
		private static readonly IntPtr NativeMethodInfoPtr_SkipWhitespace_Private_Void_0;

		// Token: 0x04001858 RID: 6232
		private static readonly IntPtr NativeMethodInfoPtr_GetKey_Private_String_0;

		// Token: 0x04001859 RID: 6233
		private static readonly IntPtr NativeMethodInfoPtr_GetKeywordAndValue_Private_Boolean_byref_String_byref_String_0;
	}
}
