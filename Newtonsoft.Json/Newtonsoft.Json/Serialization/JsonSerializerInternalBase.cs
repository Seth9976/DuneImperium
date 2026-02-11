using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000091 RID: 145
	public class JsonSerializerInternalBase : Object
	{
		// Token: 0x06000C45 RID: 3141 RVA: 0x000492AC File Offset: 0x000474AC
		// Note: this type is marked as 'beforefieldinit'.
		static JsonSerializerInternalBase()
		{
			Il2CppClassPointerStore<JsonSerializerInternalBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "JsonSerializerInternalBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSerializerInternalBase>.NativeClassPtr);
			JsonSerializerInternalBase.NativeFieldInfoPtr__currentErrorContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerInternalBase>.NativeClassPtr, "_currentErrorContext");
			JsonSerializerInternalBase.NativeFieldInfoPtr__mappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerInternalBase>.NativeClassPtr, "_mappings");
			JsonSerializerInternalBase.NativeFieldInfoPtr_Serializer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerInternalBase>.NativeClassPtr, "Serializer");
			JsonSerializerInternalBase.NativeFieldInfoPtr_TraceWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerInternalBase>.NativeClassPtr, "TraceWriter");
			JsonSerializerInternalBase.NativeFieldInfoPtr_InternalSerializer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerInternalBase>.NativeClassPtr, "InternalSerializer");
			JsonSerializerInternalBase.NativeMethodInfoPtr__ctor_Protected_Void_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalBase>.NativeClassPtr, 100665513);
			JsonSerializerInternalBase.NativeMethodInfoPtr_get_DefaultReferenceMappings_Internal_get_BidirectionalDictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalBase>.NativeClassPtr, 100665514);
			JsonSerializerInternalBase.NativeMethodInfoPtr_ResolvedNullValueHandling_Protected_NullValueHandling_JsonObjectContract_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalBase>.NativeClassPtr, 100665515);
			JsonSerializerInternalBase.NativeMethodInfoPtr_GetErrorContext_Private_ErrorContext_Object_Object_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalBase>.NativeClassPtr, 100665516);
			JsonSerializerInternalBase.NativeMethodInfoPtr_ClearErrorContext_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalBase>.NativeClassPtr, 100665517);
			JsonSerializerInternalBase.NativeMethodInfoPtr_IsErrorHandled_Protected_Boolean_Object_JsonContract_Object_IJsonLineInfo_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalBase>.NativeClassPtr, 100665518);
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x000493B8 File Offset: 0x000475B8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 750158, RefRangeEnd = 750163, XrefRangeStart = 750148, XrefRangeEnd = 750158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSerializerInternalBase(JsonSerializer serializer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSerializerInternalBase>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalBase.NativeMethodInfoPtr__ctor_Protected_Void_JsonSerializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000C47 RID: 3143 RVA: 0x00049404 File Offset: 0x00047604
		public unsafe BidirectionalDictionary<string, Object> DefaultReferenceMappings
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 750191, RefRangeEnd = 750192, XrefRangeStart = 750163, XrefRangeEnd = 750191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalBase.NativeMethodInfoPtr_get_DefaultReferenceMappings_Internal_get_BidirectionalDictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BidirectionalDictionary<string, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x00049444 File Offset: 0x00047644
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 750195, RefRangeEnd = 750197, XrefRangeStart = 750192, XrefRangeEnd = 750195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NullValueHandling ResolvedNullValueHandling(JsonObjectContract containerContract, JsonProperty property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(containerContract);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalBase.NativeMethodInfoPtr_ResolvedNullValueHandling_Protected_NullValueHandling_JsonObjectContract_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x000494A4 File Offset: 0x000476A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750197, XrefRangeEnd = 750206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ErrorContext GetErrorContext(Object currentObject, Object member, string path, Exception error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalBase.NativeMethodInfoPtr_GetErrorContext_Private_ErrorContext_Object_Object_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ErrorContext>(intPtr3) : null;
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x0004952C File Offset: 0x0004772C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 750213, RefRangeEnd = 750229, XrefRangeStart = 750206, XrefRangeEnd = 750213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearErrorContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalBase.NativeMethodInfoPtr_ClearErrorContext_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00049560 File Offset: 0x00047760
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 750279, RefRangeEnd = 750293, XrefRangeStart = 750229, XrefRangeEnd = 750279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsErrorHandled(Object currentObject, JsonContract contract, Object keyValue, IJsonLineInfo lineInfo, string path, Exception ex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lineInfo);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalBase.NativeMethodInfoPtr_IsErrorHandled_Protected_Boolean_Object_JsonContract_Object_IJsonLineInfo_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x00006209 File Offset: 0x00004409
		public JsonSerializerInternalBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000C4D RID: 3149 RVA: 0x0004960C File Offset: 0x0004780C
		// (set) Token: 0x06000C4E RID: 3150 RVA: 0x00006212 File Offset: 0x00004412
		public unsafe ErrorContext _currentErrorContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalBase.NativeFieldInfoPtr__currentErrorContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ErrorContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalBase.NativeFieldInfoPtr__currentErrorContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x0004963C File Offset: 0x0004783C
		// (set) Token: 0x06000C50 RID: 3152 RVA: 0x00006231 File Offset: 0x00004431
		public unsafe BidirectionalDictionary<string, Object> _mappings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalBase.NativeFieldInfoPtr__mappings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BidirectionalDictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalBase.NativeFieldInfoPtr__mappings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000C51 RID: 3153 RVA: 0x0004966C File Offset: 0x0004786C
		// (set) Token: 0x06000C52 RID: 3154 RVA: 0x00006250 File Offset: 0x00004450
		public unsafe JsonSerializer Serializer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalBase.NativeFieldInfoPtr_Serializer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSerializer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalBase.NativeFieldInfoPtr_Serializer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x0004969C File Offset: 0x0004789C
		// (set) Token: 0x06000C54 RID: 3156 RVA: 0x0000626F File Offset: 0x0000446F
		public unsafe ITraceWriter TraceWriter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalBase.NativeFieldInfoPtr_TraceWriter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITraceWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalBase.NativeFieldInfoPtr_TraceWriter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x000496CC File Offset: 0x000478CC
		// (set) Token: 0x06000C56 RID: 3158 RVA: 0x0000628E File Offset: 0x0000448E
		public unsafe JsonSerializerProxy InternalSerializer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalBase.NativeFieldInfoPtr_InternalSerializer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSerializerProxy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalBase.NativeFieldInfoPtr_InternalSerializer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeFieldInfoPtr__currentErrorContext;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeFieldInfoPtr__mappings;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeFieldInfoPtr_Serializer;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeFieldInfoPtr_TraceWriter;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeFieldInfoPtr_InternalSerializer;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_JsonSerializer_0;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultReferenceMappings_Internal_get_BidirectionalDictionary_2_String_Object_0;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeMethodInfoPtr_ResolvedNullValueHandling_Protected_NullValueHandling_JsonObjectContract_JsonProperty_0;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeMethodInfoPtr_GetErrorContext_Private_ErrorContext_Object_Object_String_Exception_0;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeMethodInfoPtr_ClearErrorContext_Protected_Void_0;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeMethodInfoPtr_IsErrorHandled_Protected_Boolean_Object_JsonContract_Object_IJsonLineInfo_String_Exception_0;

		// Token: 0x020001CF RID: 463
		public class ReferenceEqualsEqualityComparer : Object
		{
			// Token: 0x06001E93 RID: 7827 RVA: 0x0008CF00 File Offset: 0x0008B100
			// Note: this type is marked as 'beforefieldinit'.
			static ReferenceEqualsEqualityComparer()
			{
				Il2CppClassPointerStore<JsonSerializerInternalBase.ReferenceEqualsEqualityComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonSerializerInternalBase>.NativeClassPtr, "ReferenceEqualsEqualityComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSerializerInternalBase.ReferenceEqualsEqualityComparer>.NativeClassPtr);
				JsonSerializerInternalBase.ReferenceEqualsEqualityComparer.NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_System_Object__Equals_Private_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalBase.ReferenceEqualsEqualityComparer>.NativeClassPtr, 100665519);
				JsonSerializerInternalBase.ReferenceEqualsEqualityComparer.NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_System_Object__GetHashCode_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalBase.ReferenceEqualsEqualityComparer>.NativeClassPtr, 100665520);
				JsonSerializerInternalBase.ReferenceEqualsEqualityComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalBase.ReferenceEqualsEqualityComparer>.NativeClassPtr, 100665521);
			}

			// Token: 0x06001E94 RID: 7828 RVA: 0x0008CF68 File Offset: 0x0008B168
			[CallerCount(0)]
			public unsafe virtual bool System_Collections_Generic_IEqualityComparer_System_Object__Equals(Object x, Object y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalBase.ReferenceEqualsEqualityComparer.NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_System_Object__Equals_Private_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001E95 RID: 7829 RVA: 0x0008CFC8 File Offset: 0x0008B1C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750147, XrefRangeEnd = 750148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_Collections_Generic_IEqualityComparer_System_Object__GetHashCode(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalBase.ReferenceEqualsEqualityComparer.NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_System_Object__GetHashCode_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E96 RID: 7830 RVA: 0x0008D018 File Offset: 0x0008B218
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReferenceEqualsEqualityComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSerializerInternalBase.ReferenceEqualsEqualityComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalBase.ReferenceEqualsEqualityComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E97 RID: 7831 RVA: 0x0000F1AF File Offset: 0x0000D3AF
			public ReferenceEqualsEqualityComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400164F RID: 5711
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_System_Object__Equals_Private_Virtual_Final_New_Boolean_Object_Object_0;

			// Token: 0x04001650 RID: 5712
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_System_Object__GetHashCode_Private_Virtual_Final_New_Int32_Object_0;

			// Token: 0x04001651 RID: 5713
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
