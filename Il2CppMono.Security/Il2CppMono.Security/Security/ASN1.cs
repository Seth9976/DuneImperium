using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppMono.Security
{
	// Token: 0x02000003 RID: 3
	public class ASN1 : Object
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00004878 File Offset: 0x00002A78
		// Note: this type is marked as 'beforefieldinit'.
		static ASN1()
		{
			Il2CppClassPointerStore<ASN1>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security", "ASN1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ASN1>.NativeClassPtr);
			ASN1.NativeFieldInfoPtr_m_nTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASN1>.NativeClassPtr, "m_nTag");
			ASN1.NativeFieldInfoPtr_m_aValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASN1>.NativeClassPtr, "m_aValue");
			ASN1.NativeFieldInfoPtr_elist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ASN1>.NativeClassPtr, "elist");
			ASN1.NativeMethodInfoPtr__ctor_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663299);
			ASN1.NativeMethodInfoPtr__ctor_Public_Void_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663300);
			ASN1.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663301);
			ASN1.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663302);
			ASN1.NativeMethodInfoPtr_get_Tag_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663303);
			ASN1.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663304);
			ASN1.NativeMethodInfoPtr_get_Value_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663305);
			ASN1.NativeMethodInfoPtr_set_Value_Public_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663306);
			ASN1.NativeMethodInfoPtr_CompareArray_Private_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663307);
			ASN1.NativeMethodInfoPtr_CompareValue_Public_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663308);
			ASN1.NativeMethodInfoPtr_Add_Public_ASN1_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663309);
			ASN1.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663310);
			ASN1.NativeMethodInfoPtr_Decode_Protected_Void_Il2CppStructArray_1_Byte_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663311);
			ASN1.NativeMethodInfoPtr_DecodeTLV_Protected_Void_Il2CppStructArray_1_Byte_byref_Int32_byref_Byte_byref_Int32_byref_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663312);
			ASN1.NativeMethodInfoPtr_get_Item_Public_get_ASN1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663313);
			ASN1.NativeMethodInfoPtr_Element_Public_ASN1_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663314);
			ASN1.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1>.NativeClassPtr, 100663315);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00004A38 File Offset: 0x00002C38
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1143805, RefRangeEnd = 1143828, XrefRangeStart = 1143803, XrefRangeEnd = 1143805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000008 RID: 8 RVA: 0x00004A80 File Offset: 0x00002C80
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1143830, RefRangeEnd = 1143849, XrefRangeStart = 1143828, XrefRangeEnd = 1143830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000009 RID: 9 RVA: 0x00004ADC File Offset: 0x00002CDC
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 1143857, RefRangeEnd = 1143900, XrefRangeStart = 1143849, XrefRangeEnd = 1143857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00004B28 File Offset: 0x00002D28
		public unsafe int Count
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1143900, RefRangeEnd = 1143910, XrefRangeStart = 1143900, XrefRangeEnd = 1143900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00004B64 File Offset: 0x00002D64
		public unsafe byte Tag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr_get_Tag_Public_get_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00004BA0 File Offset: 0x00002DA0
		public unsafe int Length
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1138831, RefRangeEnd = 1138833, XrefRangeStart = 1138831, XrefRangeEnd = 1138833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00004BDC File Offset: 0x00002DDC
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00004C1C File Offset: 0x00002E1C
		public unsafe Il2CppStructArray<byte> Value
		{
			[CallerCount(91)]
			[CachedScanResults(RefRangeStart = 1143913, RefRangeEnd = 1144004, XrefRangeStart = 1143910, XrefRangeEnd = 1143913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1144012, RefRangeEnd = 1144016, XrefRangeStart = 1144004, XrefRangeEnd = 1144012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr_set_Value_Public_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00004C60 File Offset: 0x00002E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144016, XrefRangeEnd = 1144017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CompareArray(Il2CppStructArray<byte> array1, Il2CppStructArray<byte> array2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr_CompareArray_Private_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00004CC0 File Offset: 0x00002EC0
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1144018, RefRangeEnd = 1144037, XrefRangeStart = 1144017, XrefRangeEnd = 1144018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CompareValue(Il2CppStructArray<byte> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr_CompareValue_Public_Boolean_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00004D10 File Offset: 0x00002F10
		[CallerCount(66)]
		[CachedScanResults(RefRangeStart = 1144042, RefRangeEnd = 1144108, XrefRangeStart = 1144037, XrefRangeEnd = 1144042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000012 RID: 18 RVA: 0x00004D60 File Offset: 0x00002F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144108, XrefRangeEnd = 1144154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000013 RID: 19 RVA: 0x00004DAC File Offset: 0x00002FAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1144166, RefRangeEnd = 1144168, XrefRangeStart = 1144154, XrefRangeEnd = 1144166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000014 RID: 20 RVA: 0x00004E0C File Offset: 0x0000300C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144168, XrefRangeEnd = 1144175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x17000008 RID: 8
		public unsafe ASN1 this[int index]
		{
			[CallerCount(218)]
			[CachedScanResults(RefRangeStart = 1144179, RefRangeEnd = 1144397, XrefRangeStart = 1144175, XrefRangeEnd = 1144179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr_get_Item_Public_get_ASN1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00004EE8 File Offset: 0x000030E8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1144402, RefRangeEnd = 1144413, XrefRangeStart = 1144397, XrefRangeEnd = 1144402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ASN1 Element(int index, byte anTag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anTag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1.NativeMethodInfoPtr_Element_Public_ASN1_Int32_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00004F44 File Offset: 0x00003144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144413, XrefRangeEnd = 1144456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASN1.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002067 File Offset: 0x00000267
		public ASN1(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00004F88 File Offset: 0x00003188
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002070 File Offset: 0x00000270
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

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00004FB0 File Offset: 0x000031B0
		// (set) Token: 0x0600001C RID: 28 RVA: 0x0000208B File Offset: 0x0000028B
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

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00004FE0 File Offset: 0x000031E0
		// (set) Token: 0x0600001E RID: 30 RVA: 0x000020AA File Offset: 0x000002AA
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

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_m_nTag;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr_m_aValue;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr_elist;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_get_Tag_Public_get_Byte_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_CompareArray_Private_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_CompareValue_Public_Boolean_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_ASN1_ASN1_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Protected_Void_Il2CppStructArray_1_Byte_byref_Int32_Int32_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_DecodeTLV_Protected_Void_Il2CppStructArray_1_Byte_byref_Int32_byref_Byte_byref_Int32_byref_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_ASN1_Int32_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_Element_Public_ASN1_Int32_Byte_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
