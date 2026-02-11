using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200008A RID: 138
	public class JsonFormatterConverter : Object
	{
		// Token: 0x06000B51 RID: 2897 RVA: 0x00045964 File Offset: 0x00043B64
		// Note: this type is marked as 'beforefieldinit'.
		static JsonFormatterConverter()
		{
			Il2CppClassPointerStore<JsonFormatterConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "JsonFormatterConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonFormatterConverter>.NativeClassPtr);
			JsonFormatterConverter.NativeFieldInfoPtr__reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonFormatterConverter>.NativeClassPtr, "_reader");
			JsonFormatterConverter.NativeFieldInfoPtr__contract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonFormatterConverter>.NativeClassPtr, "_contract");
			JsonFormatterConverter.NativeFieldInfoPtr__member = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonFormatterConverter>.NativeClassPtr, "_member");
			JsonFormatterConverter.NativeMethodInfoPtr__ctor_Public_Void_JsonSerializerInternalReader_JsonISerializableContract_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonFormatterConverter>.NativeClassPtr, 100665390);
			JsonFormatterConverter.NativeMethodInfoPtr_GetTokenValue_Private_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonFormatterConverter>.NativeClassPtr, 100665391);
			JsonFormatterConverter.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Object_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonFormatterConverter>.NativeClassPtr, 100665392);
			JsonFormatterConverter.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Object_Object_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonFormatterConverter>.NativeClassPtr, 100665393);
			JsonFormatterConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonFormatterConverter>.NativeClassPtr, 100665394);
			JsonFormatterConverter.NativeMethodInfoPtr_ToByte_Public_Virtual_Final_New_Byte_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonFormatterConverter>.NativeClassPtr, 100665395);
			JsonFormatterConverter.NativeMethodInfoPtr_ToChar_Public_Virtual_Final_New_Char_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonFormatterConverter>.NativeClassPtr, 100665396);
			JsonFormatterConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_Final_New_DateTime_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonFormatterConverter>.NativeClassPtr, 100665397);
			JsonFormatterConverter.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Final_New_Decimal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonFormatterConverter>.NativeClassPtr, 100665398);
			JsonFormatterConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Final_New_Double_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonFormatterConverter>.NativeClassPtr, 100665399);
			JsonFormatterConverter.NativeMethodInfoPtr_ToInt16_Public_Virtual_Final_New_Int16_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonFormatterConverter>.NativeClassPtr, 100665400);
			JsonFormatterConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonFormatterConverter>.NativeClassPtr, 100665401);
			JsonFormatterConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Final_New_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonFormatterConverter>.NativeClassPtr, 100665402);
			JsonFormatterConverter.NativeMethodInfoPtr_ToSByte_Public_Virtual_Final_New_SByte_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonFormatterConverter>.NativeClassPtr, 100665403);
			JsonFormatterConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Final_New_Single_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonFormatterConverter>.NativeClassPtr, 100665404);
			JsonFormatterConverter.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonFormatterConverter>.NativeClassPtr, 100665405);
			JsonFormatterConverter.NativeMethodInfoPtr_ToUInt16_Public_Virtual_Final_New_UInt16_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonFormatterConverter>.NativeClassPtr, 100665406);
			JsonFormatterConverter.NativeMethodInfoPtr_ToUInt32_Public_Virtual_Final_New_UInt32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonFormatterConverter>.NativeClassPtr, 100665407);
			JsonFormatterConverter.NativeMethodInfoPtr_ToUInt64_Public_Virtual_Final_New_UInt64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonFormatterConverter>.NativeClassPtr, 100665408);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00045B4C File Offset: 0x00043D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749799, XrefRangeEnd = 749817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonFormatterConverter(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonFormatterConverter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonFormatterConverter.NativeMethodInfoPtr__ctor_Public_Void_JsonSerializerInternalReader_JsonISerializableContract_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00045BBC File Offset: 0x00043DBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 749837, RefRangeEnd = 749840, XrefRangeStart = 749817, XrefRangeEnd = 749837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetTokenValue<T>(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonFormatterConverter.MethodInfoStoreGeneric_GetTokenValue_Private_T_Object_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00045C08 File Offset: 0x00043E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749840, XrefRangeEnd = 749845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Convert(Object value, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonFormatterConverter.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Object_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00045C6C File Offset: 0x00043E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749845, XrefRangeEnd = 749862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Convert(Object value, TypeCode typeCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref typeCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonFormatterConverter.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Object_Object_TypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00045CCC File Offset: 0x00043ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749862, XrefRangeEnd = 749865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ToBoolean(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonFormatterConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00045D1C File Offset: 0x00043F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749865, XrefRangeEnd = 749868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual byte ToByte(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonFormatterConverter.NativeMethodInfoPtr_ToByte_Public_Virtual_Final_New_Byte_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00045D6C File Offset: 0x00043F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749868, XrefRangeEnd = 749871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual char ToChar(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonFormatterConverter.NativeMethodInfoPtr_ToChar_Public_Virtual_Final_New_Char_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00045DBC File Offset: 0x00043FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749871, XrefRangeEnd = 749874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DateTime ToDateTime(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonFormatterConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_Final_New_DateTime_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00045E0C File Offset: 0x0004400C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749874, XrefRangeEnd = 749877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Decimal ToDecimal(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonFormatterConverter.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Final_New_Decimal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00045E5C File Offset: 0x0004405C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749877, XrefRangeEnd = 749880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual double ToDouble(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonFormatterConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Final_New_Double_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00045EAC File Offset: 0x000440AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749880, XrefRangeEnd = 749883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual short ToInt16(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonFormatterConverter.NativeMethodInfoPtr_ToInt16_Public_Virtual_Final_New_Int16_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x00045EFC File Offset: 0x000440FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749883, XrefRangeEnd = 749886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int ToInt32(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonFormatterConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x00045F4C File Offset: 0x0004414C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749886, XrefRangeEnd = 749889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual long ToInt64(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonFormatterConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Final_New_Int64_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x00045F9C File Offset: 0x0004419C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749889, XrefRangeEnd = 749892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual sbyte ToSByte(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonFormatterConverter.NativeMethodInfoPtr_ToSByte_Public_Virtual_Final_New_SByte_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00045FEC File Offset: 0x000441EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749892, XrefRangeEnd = 749895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float ToSingle(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonFormatterConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Final_New_Single_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x0004603C File Offset: 0x0004423C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749895, XrefRangeEnd = 749898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToString(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonFormatterConverter.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00046084 File Offset: 0x00044284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749898, XrefRangeEnd = 749901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ushort ToUInt16(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonFormatterConverter.NativeMethodInfoPtr_ToUInt16_Public_Virtual_Final_New_UInt16_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x000460D4 File Offset: 0x000442D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749901, XrefRangeEnd = 749904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual uint ToUInt32(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonFormatterConverter.NativeMethodInfoPtr_ToUInt32_Public_Virtual_Final_New_UInt32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00046124 File Offset: 0x00044324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749904, XrefRangeEnd = 749907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ulong ToUInt64(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonFormatterConverter.NativeMethodInfoPtr_ToUInt64_Public_Virtual_Final_New_UInt64_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x00005A5B File Offset: 0x00003C5B
		public JsonFormatterConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x00046174 File Offset: 0x00044374
		// (set) Token: 0x06000B67 RID: 2919 RVA: 0x00005A64 File Offset: 0x00003C64
		public unsafe JsonSerializerInternalReader _reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonFormatterConverter.NativeFieldInfoPtr__reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSerializerInternalReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonFormatterConverter.NativeFieldInfoPtr__reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x000461A4 File Offset: 0x000443A4
		// (set) Token: 0x06000B69 RID: 2921 RVA: 0x00005A83 File Offset: 0x00003C83
		public unsafe JsonISerializableContract _contract
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonFormatterConverter.NativeFieldInfoPtr__contract);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonISerializableContract>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonFormatterConverter.NativeFieldInfoPtr__contract), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x000461D4 File Offset: 0x000443D4
		// (set) Token: 0x06000B6B RID: 2923 RVA: 0x00005AA2 File Offset: 0x00003CA2
		public unsafe JsonProperty _member
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonFormatterConverter.NativeFieldInfoPtr__member);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonProperty>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonFormatterConverter.NativeFieldInfoPtr__member), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400093A RID: 2362
		private static readonly IntPtr NativeFieldInfoPtr__reader;

		// Token: 0x0400093B RID: 2363
		private static readonly IntPtr NativeFieldInfoPtr__contract;

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeFieldInfoPtr__member;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_JsonSerializerInternalReader_JsonISerializableContract_JsonProperty_0;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeMethodInfoPtr_GetTokenValue_Private_T_Object_0;

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Object_Object_Type_0;

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Object_Object_TypeCode_0;

		// Token: 0x04000941 RID: 2369
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x04000942 RID: 2370
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Virtual_Final_New_Byte_Object_0;

		// Token: 0x04000943 RID: 2371
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Virtual_Final_New_Char_Object_0;

		// Token: 0x04000944 RID: 2372
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_Final_New_DateTime_Object_0;

		// Token: 0x04000945 RID: 2373
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Virtual_Final_New_Decimal_Object_0;

		// Token: 0x04000946 RID: 2374
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Virtual_Final_New_Double_Object_0;

		// Token: 0x04000947 RID: 2375
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Virtual_Final_New_Int16_Object_0;

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Final_New_Int64_Object_0;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Virtual_Final_New_SByte_Object_0;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Virtual_Final_New_Single_Object_0;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_Object_0;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Virtual_Final_New_UInt16_Object_0;

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Virtual_Final_New_UInt32_Object_0;

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Virtual_Final_New_UInt64_Object_0;

		// Token: 0x020001CE RID: 462
		private sealed class MethodInfoStoreGeneric_GetTokenValue_Private_T_Object_0<T>
		{
			// Token: 0x0400164E RID: 5710
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonFormatterConverter.NativeMethodInfoPtr_GetTokenValue_Private_T_Object_0, Il2CppClassPointerStore<JsonFormatterConverter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
