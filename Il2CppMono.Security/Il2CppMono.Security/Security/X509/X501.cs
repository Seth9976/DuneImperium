using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace Il2CppMono.Security.X509
{
	// Token: 0x02000009 RID: 9
	public sealed class X501 : Object
	{
		// Token: 0x06000075 RID: 117 RVA: 0x0000670C File Offset: 0x0000490C
		// Note: this type is marked as 'beforefieldinit'.
		static X501()
		{
			Il2CppClassPointerStore<X501>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.X509", "X501");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X501>.NativeClassPtr);
			X501.NativeFieldInfoPtr_countryName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "countryName");
			X501.NativeFieldInfoPtr_organizationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "organizationName");
			X501.NativeFieldInfoPtr_organizationalUnitName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "organizationalUnitName");
			X501.NativeFieldInfoPtr_commonName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "commonName");
			X501.NativeFieldInfoPtr_localityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "localityName");
			X501.NativeFieldInfoPtr_stateOrProvinceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "stateOrProvinceName");
			X501.NativeFieldInfoPtr_streetAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "streetAddress");
			X501.NativeFieldInfoPtr_serialNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "serialNumber");
			X501.NativeFieldInfoPtr_domainComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "domainComponent");
			X501.NativeFieldInfoPtr_userid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "userid");
			X501.NativeFieldInfoPtr_email = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "email");
			X501.NativeFieldInfoPtr_dnQualifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "dnQualifier");
			X501.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "title");
			X501.NativeFieldInfoPtr_surname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "surname");
			X501.NativeFieldInfoPtr_givenName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "givenName");
			X501.NativeFieldInfoPtr_initial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X501>.NativeClassPtr, "initial");
			X501.NativeMethodInfoPtr_ToString_Public_Static_String_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X501>.NativeClassPtr, 100663408);
			X501.NativeMethodInfoPtr_ToString_Public_Static_String_ASN1_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X501>.NativeClassPtr, 100663409);
			X501.NativeMethodInfoPtr_AppendEntry_Private_Static_Void_StringBuilder_ASN1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X501>.NativeClassPtr, 100663410);
			X501.NativeMethodInfoPtr_GetAttributeFromOid_Private_Static_AttributeTypeAndValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X501>.NativeClassPtr, 100663411);
			X501.NativeMethodInfoPtr_IsOid_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X501>.NativeClassPtr, 100663412);
			X501.NativeMethodInfoPtr_ReadAttribute_Private_Static_AttributeTypeAndValue_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X501>.NativeClassPtr, 100663413);
			X501.NativeMethodInfoPtr_IsHex_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X501>.NativeClassPtr, 100663414);
			X501.NativeMethodInfoPtr_ReadHex_Private_Static_String_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X501>.NativeClassPtr, 100663415);
			X501.NativeMethodInfoPtr_ReadEscaped_Private_Static_Int32_StringBuilder_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X501>.NativeClassPtr, 100663416);
			X501.NativeMethodInfoPtr_ReadQuoted_Private_Static_Int32_StringBuilder_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X501>.NativeClassPtr, 100663417);
			X501.NativeMethodInfoPtr_ReadValue_Private_Static_String_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X501>.NativeClassPtr, 100663418);
			X501.NativeMethodInfoPtr_FromString_Public_Static_ASN1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X501>.NativeClassPtr, 100663419);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000696C File Offset: 0x00004B6C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1146763, RefRangeEnd = 1146767, XrefRangeStart = 1146617, XrefRangeEnd = 1146763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(ASN1 seq)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(seq);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X501.NativeMethodInfoPtr_ToString_Public_Static_String_ASN1_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000069A8 File Offset: 0x00004BA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1146786, RefRangeEnd = 1146789, XrefRangeStart = 1146767, XrefRangeEnd = 1146786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(ASN1 seq, bool reversed, string separator, bool quotes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(seq);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reversed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(separator);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quotes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X501.NativeMethodInfoPtr_ToString_Public_Static_String_ASN1_Boolean_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00006A14 File Offset: 0x00004C14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1146952, RefRangeEnd = 1146955, XrefRangeStart = 1146789, XrefRangeEnd = 1146952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendEntry(StringBuilder sb, ASN1 entry, bool quotes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entry);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quotes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X501.NativeMethodInfoPtr_AppendEntry_Private_Static_Void_StringBuilder_ASN1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00006A6C File Offset: 0x00004C6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1147004, RefRangeEnd = 1147005, XrefRangeStart = 1146955, XrefRangeEnd = 1147004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X520.AttributeTypeAndValue GetAttributeFromOid(string attributeType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(attributeType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X501.NativeMethodInfoPtr_GetAttributeFromOid_Private_Static_AttributeTypeAndValue_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X520.AttributeTypeAndValue>(intPtr3) : null;
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00006AB0 File Offset: 0x00004CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147005, XrefRangeEnd = 1147014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsOid(string oid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X501.NativeMethodInfoPtr_IsOid_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00006AF4 File Offset: 0x00004CF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1147022, RefRangeEnd = 1147023, XrefRangeStart = 1147014, XrefRangeEnd = 1147022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X520.AttributeTypeAndValue ReadAttribute(string value, ref int pos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X501.NativeMethodInfoPtr_ReadAttribute_Private_Static_AttributeTypeAndValue_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X520.AttributeTypeAndValue>(intPtr3) : null;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00006B48 File Offset: 0x00004D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147023, XrefRangeEnd = 1147034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsHex(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X501.NativeMethodInfoPtr_IsHex_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00006B88 File Offset: 0x00004D88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1147065, RefRangeEnd = 1147066, XrefRangeStart = 1147034, XrefRangeEnd = 1147065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReadHex(string value, ref int pos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X501.NativeMethodInfoPtr_ReadHex_Private_Static_String_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00006BD4 File Offset: 0x00004DD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1147072, RefRangeEnd = 1147074, XrefRangeStart = 1147066, XrefRangeEnd = 1147072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReadEscaped(StringBuilder sb, string value, int pos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X501.NativeMethodInfoPtr_ReadEscaped_Private_Static_Int32_StringBuilder_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00006C38 File Offset: 0x00004E38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1147082, RefRangeEnd = 1147083, XrefRangeStart = 1147074, XrefRangeEnd = 1147082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReadQuoted(StringBuilder sb, string value, int pos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X501.NativeMethodInfoPtr_ReadQuoted_Private_Static_Int32_StringBuilder_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00006C9C File Offset: 0x00004E9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1147120, RefRangeEnd = 1147121, XrefRangeStart = 1147083, XrefRangeEnd = 1147120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReadValue(string value, ref int pos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X501.NativeMethodInfoPtr_ReadValue_Private_Static_String_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00006CE8 File Offset: 0x00004EE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1147148, RefRangeEnd = 1147149, XrefRangeStart = 1147121, XrefRangeEnd = 1147148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ASN1 FromString(string rdn)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(rdn);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X501.NativeMethodInfoPtr_FromString_Public_Static_ASN1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000228D File Offset: 0x0000048D
		public X501(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00006D2C File Offset: 0x00004F2C
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00002296 File Offset: 0x00000496
		public unsafe static Il2CppStructArray<byte> countryName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_countryName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_countryName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00006D54 File Offset: 0x00004F54
		// (set) Token: 0x06000086 RID: 134 RVA: 0x000022A8 File Offset: 0x000004A8
		public unsafe static Il2CppStructArray<byte> organizationName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_organizationName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_organizationName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00006D7C File Offset: 0x00004F7C
		// (set) Token: 0x06000088 RID: 136 RVA: 0x000022BA File Offset: 0x000004BA
		public unsafe static Il2CppStructArray<byte> organizationalUnitName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_organizationalUnitName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_organizationalUnitName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00006DA4 File Offset: 0x00004FA4
		// (set) Token: 0x0600008A RID: 138 RVA: 0x000022CC File Offset: 0x000004CC
		public unsafe static Il2CppStructArray<byte> commonName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_commonName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_commonName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00006DCC File Offset: 0x00004FCC
		// (set) Token: 0x0600008C RID: 140 RVA: 0x000022DE File Offset: 0x000004DE
		public unsafe static Il2CppStructArray<byte> localityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_localityName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_localityName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00006DF4 File Offset: 0x00004FF4
		// (set) Token: 0x0600008E RID: 142 RVA: 0x000022F0 File Offset: 0x000004F0
		public unsafe static Il2CppStructArray<byte> stateOrProvinceName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_stateOrProvinceName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_stateOrProvinceName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00006E1C File Offset: 0x0000501C
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00002302 File Offset: 0x00000502
		public unsafe static Il2CppStructArray<byte> streetAddress
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_streetAddress, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_streetAddress, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00006E44 File Offset: 0x00005044
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002314 File Offset: 0x00000514
		public unsafe static Il2CppStructArray<byte> serialNumber
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_serialNumber, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_serialNumber, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00006E6C File Offset: 0x0000506C
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00002326 File Offset: 0x00000526
		public unsafe static Il2CppStructArray<byte> domainComponent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_domainComponent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_domainComponent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00006E94 File Offset: 0x00005094
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00002338 File Offset: 0x00000538
		public unsafe static Il2CppStructArray<byte> userid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_userid, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_userid, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00006EBC File Offset: 0x000050BC
		// (set) Token: 0x06000098 RID: 152 RVA: 0x0000234A File Offset: 0x0000054A
		public unsafe static Il2CppStructArray<byte> email
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_email, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_email, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00006EE4 File Offset: 0x000050E4
		// (set) Token: 0x0600009A RID: 154 RVA: 0x0000235C File Offset: 0x0000055C
		public unsafe static Il2CppStructArray<byte> dnQualifier
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_dnQualifier, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_dnQualifier, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00006F0C File Offset: 0x0000510C
		// (set) Token: 0x0600009C RID: 156 RVA: 0x0000236E File Offset: 0x0000056E
		public unsafe static Il2CppStructArray<byte> title
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_title, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_title, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00006F34 File Offset: 0x00005134
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00002380 File Offset: 0x00000580
		public unsafe static Il2CppStructArray<byte> surname
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_surname, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_surname, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00006F5C File Offset: 0x0000515C
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x00002392 File Offset: 0x00000592
		public unsafe static Il2CppStructArray<byte> givenName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_givenName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_givenName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00006F84 File Offset: 0x00005184
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x000023A4 File Offset: 0x000005A4
		public unsafe static Il2CppStructArray<byte> initial
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X501.NativeFieldInfoPtr_initial, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X501.NativeFieldInfoPtr_initial, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeFieldInfoPtr_countryName;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeFieldInfoPtr_organizationName;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr_organizationalUnitName;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr_commonName;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeFieldInfoPtr_localityName;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr_stateOrProvinceName;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr_streetAddress;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr_serialNumber;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr_domainComponent;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr_userid;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr_email;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_dnQualifier;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_surname;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr_givenName;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeFieldInfoPtr_initial;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_ASN1_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_ASN1_Boolean_String_Boolean_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_AppendEntry_Private_Static_Void_StringBuilder_ASN1_Boolean_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeFromOid_Private_Static_AttributeTypeAndValue_String_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_IsOid_Private_Static_Boolean_String_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_ReadAttribute_Private_Static_AttributeTypeAndValue_String_byref_Int32_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_IsHex_Private_Static_Boolean_Char_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_ReadHex_Private_Static_String_String_byref_Int32_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_ReadEscaped_Private_Static_Int32_StringBuilder_String_Int32_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_ReadQuoted_Private_Static_Int32_StringBuilder_String_Int32_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_ReadValue_Private_Static_String_String_byref_Int32_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_FromString_Public_Static_ASN1_String_0;
	}
}
