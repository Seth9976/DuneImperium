using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace Il2CppMono.Security.X509
{
	// Token: 0x0200000F RID: 15
	public class X509Extension : Object
	{
		// Token: 0x06000134 RID: 308 RVA: 0x00009060 File Offset: 0x00007260
		// Note: this type is marked as 'beforefieldinit'.
		static X509Extension()
		{
			Il2CppClassPointerStore<X509Extension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.X509", "X509Extension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Extension>.NativeClassPtr);
			X509Extension.NativeFieldInfoPtr_extnOid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, "extnOid");
			X509Extension.NativeFieldInfoPtr_extnCritical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, "extnCritical");
			X509Extension.NativeFieldInfoPtr_extnValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, "extnValue");
			X509Extension.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100663493);
			X509Extension.NativeMethodInfoPtr__ctor_Public_Void_X509Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100663494);
			X509Extension.NativeMethodInfoPtr_Decode_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100663495);
			X509Extension.NativeMethodInfoPtr_Encode_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100663496);
			X509Extension.NativeMethodInfoPtr_get_Oid_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100663497);
			X509Extension.NativeMethodInfoPtr_get_Critical_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100663498);
			X509Extension.NativeMethodInfoPtr_get_Value_Public_get_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100663499);
			X509Extension.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100663500);
			X509Extension.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100663501);
			X509Extension.NativeMethodInfoPtr_WriteLine_Private_Void_StringBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100663502);
			X509Extension.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100663503);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000091A8 File Offset: 0x000073A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1148015, RefRangeEnd = 1148016, XrefRangeStart = 1147977, XrefRangeEnd = 1148015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Extension(ASN1 asn1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Extension>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asn1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Extension.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000091F4 File Offset: 0x000073F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1148032, RefRangeEnd = 1148035, XrefRangeStart = 1148016, XrefRangeEnd = 1148032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Extension(X509Extension extension)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Extension>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extension);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Extension.NativeMethodInfoPtr__ctor_Public_Void_X509Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00009240 File Offset: 0x00007440
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Decode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Extension.NativeMethodInfoPtr_Decode_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000927C File Offset: 0x0000747C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Encode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Extension.NativeMethodInfoPtr_Encode_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000139 RID: 313 RVA: 0x000092B8 File Offset: 0x000074B8
		public unsafe string Oid
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Extension.NativeMethodInfoPtr_get_Oid_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600013A RID: 314 RVA: 0x000092F0 File Offset: 0x000074F0
		public unsafe bool Critical
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Extension.NativeMethodInfoPtr_get_Critical_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0000932C File Offset: 0x0000752C
		public unsafe ASN1 Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Extension.NativeMethodInfoPtr_get_Value_Public_get_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000936C File Offset: 0x0000756C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148035, XrefRangeEnd = 1148045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Extension.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000093C4 File Offset: 0x000075C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Extension.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000940C File Offset: 0x0000760C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1148076, RefRangeEnd = 1148078, XrefRangeStart = 1148045, XrefRangeEnd = 1148076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteLine(StringBuilder sb, int n, int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Extension.NativeMethodInfoPtr_WriteLine_Private_Void_StringBuilder_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000946C File Offset: 0x0000766C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148078, XrefRangeEnd = 1148086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Extension.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000284B File Offset: 0x00000A4B
		public X509Extension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000141 RID: 321 RVA: 0x000094B0 File Offset: 0x000076B0
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00002854 File Offset: 0x00000A54
		public unsafe string extnOid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Extension.NativeFieldInfoPtr_extnOid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Extension.NativeFieldInfoPtr_extnOid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000143 RID: 323 RVA: 0x000094D8 File Offset: 0x000076D8
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00002873 File Offset: 0x00000A73
		public unsafe bool extnCritical
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Extension.NativeFieldInfoPtr_extnCritical);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Extension.NativeFieldInfoPtr_extnCritical)) = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00009500 File Offset: 0x00007700
		// (set) Token: 0x06000146 RID: 326 RVA: 0x0000288E File Offset: 0x00000A8E
		public unsafe ASN1 extnValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Extension.NativeFieldInfoPtr_extnValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Extension.NativeFieldInfoPtr_extnValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr_extnOid;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_extnCritical;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr_extnValue;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ASN1_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_X509Extension_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Protected_Virtual_New_Void_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Protected_Virtual_New_Void_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_get_Oid_Public_get_String_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_get_Critical_Public_get_Boolean_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_ASN1_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Private_Void_StringBuilder_Int32_Int32_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
