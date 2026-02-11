using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppMono.Security
{
	// Token: 0x02000029 RID: 41
	[DefaultMember("Item")]
	public class ASN1 : Object
	{
		// Token: 0x060001F2 RID: 498 RVA: 0x0002CF88 File Offset: 0x0002B188
		// Note: this type is marked as 'beforefieldinit'.
		static ASN1()
		{
			Il2CppClassPointerStore<ASN1>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security", "ASN1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ASN1>.NativeClassPtr);
			ASN1.NativeFieldInfoPtr_m_nTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASN1>.NativeClassPtr, "m_nTag");
			ASN1.NativeFieldInfoPtr_m_aValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASN1>.NativeClassPtr, "m_aValue");
			ASN1.NativeFieldInfoPtr_elist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASN1>.NativeClassPtr, "elist");
			ASN1.NativeMethodInfoPtr__ctor_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663583);
			ASN1.NativeMethodInfoPtr__ctor_Public_Void_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663584);
			ASN1.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663585);
			ASN1.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663586);
			ASN1.NativeMethodInfoPtr_get_Value_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663587);
			ASN1.NativeMethodInfoPtr_Add_Public_ASN1_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663588);
			ASN1.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663589);
			ASN1.NativeMethodInfoPtr_Decode_Protected_Void_Il2CppStructArray_1_Byte_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663590);
			ASN1.NativeMethodInfoPtr_DecodeTLV_Protected_Void_Il2CppStructArray_1_Byte_byref_Int32_byref_Byte_byref_Int32_byref_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663591);
			ASN1.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663592);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0002D0BC File Offset: 0x0002B2BC
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1143805, RefRangeEnd = 1143828, XrefRangeStart = 1143805, XrefRangeEnd = 1143828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ASN1(byte tag)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ASN1>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tag;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr__ctor_Public_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0002D104 File Offset: 0x0002B304
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1143830, RefRangeEnd = 1143849, XrefRangeStart = 1143830, XrefRangeEnd = 1143849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ASN1(byte tag, Il2CppStructArray<byte> data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ASN1>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tag;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr__ctor_Public_Void_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0002D160 File Offset: 0x0002B360
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1277600, RefRangeEnd = 1277601, XrefRangeStart = 1277592, XrefRangeEnd = 1277600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ASN1(Il2CppStructArray<byte> data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ASN1>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x0002D1AC File Offset: 0x0002B3AC
		public unsafe int Count
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1143900, RefRangeEnd = 1143910, XrefRangeStart = 1143900, XrefRangeEnd = 1143910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x0002D1E8 File Offset: 0x0002B3E8
		public unsafe Il2CppStructArray<byte> Value
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1277604, RefRangeEnd = 1277605, XrefRangeStart = 1277601, XrefRangeEnd = 1277604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr_get_Value_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0002D228 File Offset: 0x0002B428
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1277610, RefRangeEnd = 1277615, XrefRangeStart = 1277605, XrefRangeEnd = 1277610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ASN1 Add(ASN1 asn1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asn1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr_Add_Public_ASN1_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
			}
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0002D278 File Offset: 0x0002B478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277615, XrefRangeEnd = 1277662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> GetBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASN1.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0002D2C4 File Offset: 0x0002B4C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1277674, RefRangeEnd = 1277676, XrefRangeStart = 1277662, XrefRangeEnd = 1277674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Decode(Il2CppStructArray<byte> asn1, ref int anPos, int anLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asn1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &anPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr_Decode_Protected_Void_Il2CppStructArray_1_Byte_byref_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0002D324 File Offset: 0x0002B524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277676, XrefRangeEnd = 1277683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DecodeTLV(Il2CppStructArray<byte> asn1, ref int pos, out byte tag, out int length, out Il2CppStructArray<byte> content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asn1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tag;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &length;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr_DecodeTLV_Protected_Void_Il2CppStructArray_1_Byte_byref_Int32_byref_Byte_byref_Int32_byref_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			content = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0002D3B4 File Offset: 0x0002B5B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277683, XrefRangeEnd = 1277726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASN1.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002D6C File Offset: 0x00000F6C
		public ASN1(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001FE RID: 510 RVA: 0x0002D3F8 File Offset: 0x0002B5F8
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00002D75 File Offset: 0x00000F75
		public unsafe byte m_nTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASN1.NativeFieldInfoPtr_m_nTag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASN1.NativeFieldInfoPtr_m_nTag)) = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000200 RID: 512 RVA: 0x0002D420 File Offset: 0x0002B620
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00002D90 File Offset: 0x00000F90
		public unsafe Il2CppStructArray<byte> m_aValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASN1.NativeFieldInfoPtr_m_aValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASN1.NativeFieldInfoPtr_m_aValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000202 RID: 514 RVA: 0x0002D450 File Offset: 0x0002B650
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00002DAF File Offset: 0x00000FAF
		public unsafe ArrayList elist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASN1.NativeFieldInfoPtr_elist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ASN1.NativeFieldInfoPtr_elist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeFieldInfoPtr_m_nTag;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeFieldInfoPtr_m_aValue;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeFieldInfoPtr_elist;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_ASN1_ASN1_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Protected_Void_Il2CppStructArray_1_Byte_byref_Int32_Int32_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_DecodeTLV_Protected_Void_Il2CppStructArray_1_Byte_byref_Int32_byref_Byte_byref_Int32_byref_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
