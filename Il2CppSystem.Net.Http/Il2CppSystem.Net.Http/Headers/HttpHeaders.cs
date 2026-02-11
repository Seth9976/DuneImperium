using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Net.Http.Headers
{
	// Token: 0x02000026 RID: 38
	public class HttpHeaders : Object
	{
		// Token: 0x06000255 RID: 597 RVA: 0x0000D954 File Offset: 0x0000BB54
		// Note: this type is marked as 'beforefieldinit'.
		static HttpHeaders()
		{
			Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http.Headers", "HttpHeaders");
			HttpHeaders.NativeFieldInfoPtr_known_headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, "known_headers");
			HttpHeaders.NativeFieldInfoPtr_headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, "headers");
			HttpHeaders.NativeFieldInfoPtr_HeaderKind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, "HeaderKind");
			HttpHeaders.NativeFieldInfoPtr_connectionclose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, "connectionclose");
			HttpHeaders.NativeFieldInfoPtr_transferEncodingChunked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, "transferEncodingChunked");
			HttpHeaders.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, 100663647);
			HttpHeaders.NativeMethodInfoPtr__ctor_Internal_Void_HttpHeaderKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, 100663648);
			HttpHeaders.NativeMethodInfoPtr_Add_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, 100663649);
			HttpHeaders.NativeMethodInfoPtr_Add_Public_Void_String_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, 100663650);
			HttpHeaders.NativeMethodInfoPtr_AddInternal_Private_Boolean_String_IEnumerable_1_String_HeaderInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, 100663651);
			HttpHeaders.NativeMethodInfoPtr_TryAddWithoutValidation_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, 100663652);
			HttpHeaders.NativeMethodInfoPtr_TryAddWithoutValidation_Public_Boolean_String_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, 100663653);
			HttpHeaders.NativeMethodInfoPtr_CheckName_Private_HeaderInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, 100663654);
			HttpHeaders.NativeMethodInfoPtr_TryCheckName_Private_Boolean_String_byref_HeaderInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, 100663655);
			HttpHeaders.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, 100663656);
			HttpHeaders.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, 100663657);
			HttpHeaders.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, 100663658);
			HttpHeaders.NativeMethodInfoPtr_GetValues_Public_IEnumerable_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, 100663659);
			HttpHeaders.NativeMethodInfoPtr_Remove_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, 100663660);
			HttpHeaders.NativeMethodInfoPtr_TryGetValues_Public_Boolean_String_byref_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, 100663661);
			HttpHeaders.NativeMethodInfoPtr_GetSingleHeaderString_Internal_Static_String_String_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, 100663662);
			HttpHeaders.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, 100663663);
			HttpHeaders.NativeMethodInfoPtr_AddOrRemove_Internal_Void_String_T_Func_2_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, 100663664);
			HttpHeaders.NativeMethodInfoPtr_AddOrRemove_Internal_Void_String_Nullable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, 100663665);
			HttpHeaders.NativeMethodInfoPtr_AddOrRemove_Internal_Void_String_Nullable_1_T_Func_2_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, 100663666);
			HttpHeaders.NativeMethodInfoPtr_GetAllHeaderValues_Private_List_1_String_HeaderBucket_HeaderInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, 100663667);
			HttpHeaders.NativeMethodInfoPtr_GetKnownHeaderKind_Internal_Static_HttpHeaderKind_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, 100663668);
			HttpHeaders.NativeMethodInfoPtr_GetValue_Internal_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, 100663669);
			HttpHeaders.NativeMethodInfoPtr_GetValues_Internal_HttpHeaderValueCollection_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, 100663670);
			HttpHeaders.NativeMethodInfoPtr_SetValue_Internal_Void_String_T_Func_2_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, 100663671);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000DBD4 File Offset: 0x0000BDD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173823, XrefRangeEnd = 1173838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpHeaders()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000DC10 File Offset: 0x0000BE10
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1173853, RefRangeEnd = 1173860, XrefRangeStart = 1173838, XrefRangeEnd = 1173853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpHeaders(HttpHeaderKind headerKind)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref headerKind;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.NativeMethodInfoPtr__ctor_Internal_Void_HttpHeaderKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000DC58 File Offset: 0x0000BE58
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1173866, RefRangeEnd = 1173876, XrefRangeStart = 1173860, XrefRangeEnd = 1173866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.NativeMethodInfoPtr_Add_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000DCAC File Offset: 0x0000BEAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1173878, RefRangeEnd = 1173880, XrefRangeStart = 1173876, XrefRangeEnd = 1173878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string name, IEnumerable<string> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.NativeMethodInfoPtr_Add_Public_Void_String_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000DD00 File Offset: 0x0000BF00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1173921, RefRangeEnd = 1173924, XrefRangeStart = 1173880, XrefRangeEnd = 1173921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddInternal(string name, IEnumerable<string> values, HeaderInfo headerInfo, bool ignoreInvalid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headerInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreInvalid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.NativeMethodInfoPtr_AddInternal_Private_Boolean_String_IEnumerable_1_String_HeaderInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000DD80 File Offset: 0x0000BF80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1173931, RefRangeEnd = 1173933, XrefRangeStart = 1173924, XrefRangeEnd = 1173931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAddWithoutValidation(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.NativeMethodInfoPtr_TryAddWithoutValidation_Public_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000DDE0 File Offset: 0x0000BFE0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1173945, RefRangeEnd = 1173949, XrefRangeStart = 1173933, XrefRangeEnd = 1173945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAddWithoutValidation(string name, IEnumerable<string> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.NativeMethodInfoPtr_TryAddWithoutValidation_Public_Boolean_String_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000DE40 File Offset: 0x0000C040
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1173958, RefRangeEnd = 1173962, XrefRangeStart = 1173949, XrefRangeEnd = 1173958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeaderInfo CheckName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.NativeMethodInfoPtr_CheckName_Private_HeaderInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HeaderInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000DE90 File Offset: 0x0000C090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173962, XrefRangeEnd = 1173973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryCheckName(string name, out HeaderInfo headerInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.NativeMethodInfoPtr_TryCheckName_Private_Boolean_String_byref_HeaderInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			headerInfo = ((intPtr4 == 0) ? null : new HeaderInfo(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000DF00 File Offset: 0x0000C100
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1173977, RefRangeEnd = 1173978, XrefRangeStart = 1173973, XrefRangeEnd = 1173977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000DF34 File Offset: 0x0000C134
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1173983, RefRangeEnd = 1173987, XrefRangeStart = 1173978, XrefRangeEnd = 1173983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<KeyValuePair<string, IEnumerable<string>>> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<string, IEnumerable<string>>>>(intPtr3) : null;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000DF74 File Offset: 0x0000C174
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1173983, RefRangeEnd = 1173987, XrefRangeStart = 1173983, XrefRangeEnd = 1173987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000DFB4 File Offset: 0x0000C1B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1173989, RefRangeEnd = 1173990, XrefRangeStart = 1173987, XrefRangeEnd = 1173989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<string> GetValues(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.NativeMethodInfoPtr_GetValues_Public_IEnumerable_1_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000E004 File Offset: 0x0000C204
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1173995, RefRangeEnd = 1174001, XrefRangeStart = 1173990, XrefRangeEnd = 1173995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Remove(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.NativeMethodInfoPtr_Remove_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000E054 File Offset: 0x0000C254
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1174040, RefRangeEnd = 1174042, XrefRangeStart = 1174001, XrefRangeEnd = 1174040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValues(string name, out IEnumerable<string> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.NativeMethodInfoPtr_TryGetValues_Public_Boolean_String_byref_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			values = ((intPtr4 == 0) ? null : new IEnumerable<string>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000E0C4 File Offset: 0x0000C2C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1174080, RefRangeEnd = 1174082, XrefRangeStart = 1174042, XrefRangeEnd = 1174080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSingleHeaderString(string key, IEnumerable<string> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.NativeMethodInfoPtr_GetSingleHeaderString_Internal_Static_String_String_IEnumerable_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000E114 File Offset: 0x0000C314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174082, XrefRangeEnd = 1174119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpHeaders.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000E158 File Offset: 0x0000C358
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1174127, RefRangeEnd = 1174136, XrefRangeStart = 1174119, XrefRangeEnd = 1174127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOrRemove<T>(string name, T value, Func<Object, string> converter = null) where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.MethodInfoStoreGeneric_AddOrRemove_Internal_Void_String_T_Func_2_Object_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000E1F4 File Offset: 0x0000C3F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174149, RefRangeEnd = 1174150, XrefRangeStart = 1174136, XrefRangeEnd = 1174149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOrRemove<T>(string name, Nullable<T> value) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.MethodInfoStoreGeneric_AddOrRemove_Internal_Void_String_Nullable_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000E250 File Offset: 0x0000C450
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1174162, RefRangeEnd = 1174166, XrefRangeStart = 1174150, XrefRangeEnd = 1174162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOrRemove<T>(string name, Nullable<T> value, Func<Object, string> converter) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.MethodInfoStoreGeneric_AddOrRemove_Internal_Void_String_Nullable_1_T_Func_2_Object_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000E2BC File Offset: 0x0000C4BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174187, RefRangeEnd = 1174188, XrefRangeStart = 1174166, XrefRangeEnd = 1174187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<string> GetAllHeaderValues(HttpHeaders.HeaderBucket bucket, HeaderInfo headerInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bucket);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headerInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.NativeMethodInfoPtr_GetAllHeaderValues_Private_List_1_String_HeaderBucket_HeaderInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000E320 File Offset: 0x0000C520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174188, XrefRangeEnd = 1174196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HttpHeaderKind GetKnownHeaderKind(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.NativeMethodInfoPtr_GetKnownHeaderKind_Internal_Static_HttpHeaderKind_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000E364 File Offset: 0x0000C564
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1174229, RefRangeEnd = 1174231, XrefRangeStart = 1174196, XrefRangeEnd = 1174229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetValue<T>(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.MethodInfoStoreGeneric_GetValue_Internal_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000E3B0 File Offset: 0x0000C5B0
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1174275, RefRangeEnd = 1174294, XrefRangeStart = 1174231, XrefRangeEnd = 1174275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpHeaderValueCollection<T> GetValues<T>(string name) where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.MethodInfoStoreGeneric_GetValues_Internal_HttpHeaderValueCollection_1_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpHeaderValueCollection<T>>(intPtr3) : null;
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000E400 File Offset: 0x0000C600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174294, XrefRangeEnd = 1174303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue<T>(string name, T value, Func<Object, string> toStringConverter = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toStringConverter);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.MethodInfoStoreGeneric_SetValue_Internal_Void_String_T_Func_2_Object_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002E70 File Offset: 0x00001070
		public HttpHeaders(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0000E49C File Offset: 0x0000C69C
		// (set) Token: 0x06000271 RID: 625 RVA: 0x00002E79 File Offset: 0x00001079
		public unsafe static Dictionary<string, HeaderInfo> known_headers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpHeaders.NativeFieldInfoPtr_known_headers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, HeaderInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpHeaders.NativeFieldInfoPtr_known_headers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0000E4C4 File Offset: 0x0000C6C4
		// (set) Token: 0x06000273 RID: 627 RVA: 0x00002E8B File Offset: 0x0000108B
		public unsafe Dictionary<string, HttpHeaders.HeaderBucket> headers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpHeaders.NativeFieldInfoPtr_headers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, HttpHeaders.HeaderBucket>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpHeaders.NativeFieldInfoPtr_headers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0000E4F4 File Offset: 0x0000C6F4
		// (set) Token: 0x06000275 RID: 629 RVA: 0x00002EAA File Offset: 0x000010AA
		public unsafe HttpHeaderKind HeaderKind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpHeaders.NativeFieldInfoPtr_HeaderKind);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpHeaders.NativeFieldInfoPtr_HeaderKind)) = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000276 RID: 630 RVA: 0x0000E51C File Offset: 0x0000C71C
		// (set) Token: 0x06000277 RID: 631 RVA: 0x00002EC5 File Offset: 0x000010C5
		public Nullable<bool> connectionclose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpHeaders.NativeFieldInfoPtr_connectionclose);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpHeaders.NativeFieldInfoPtr_connectionclose), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0000E54C File Offset: 0x0000C74C
		// (set) Token: 0x06000279 RID: 633 RVA: 0x00002EF3 File Offset: 0x000010F3
		public Nullable<bool> transferEncodingChunked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpHeaders.NativeFieldInfoPtr_transferEncodingChunked);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpHeaders.NativeFieldInfoPtr_transferEncodingChunked), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeFieldInfoPtr_known_headers;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeFieldInfoPtr_headers;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeFieldInfoPtr_HeaderKind;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeFieldInfoPtr_connectionclose;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeFieldInfoPtr_transferEncodingChunked;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_HttpHeaderKind_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_String_String_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_String_IEnumerable_1_String_0;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_AddInternal_Private_Boolean_String_IEnumerable_1_String_HeaderInfo_Boolean_0;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_TryAddWithoutValidation_Public_Boolean_String_String_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_TryAddWithoutValidation_Public_Boolean_String_IEnumerable_1_String_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr_CheckName_Private_HeaderInfo_String_0;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_TryCheckName_Private_Boolean_String_byref_HeaderInfo_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_IEnumerable_1_String_0;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeMethodInfoPtr_GetValues_Public_IEnumerable_1_String_String_0;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_String_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValues_Public_Boolean_String_byref_IEnumerable_1_String_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_GetSingleHeaderString_Internal_Static_String_String_IEnumerable_1_String_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_AddOrRemove_Internal_Void_String_T_Func_2_Object_String_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_AddOrRemove_Internal_Void_String_Nullable_1_T_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_AddOrRemove_Internal_Void_String_Nullable_1_T_Func_2_Object_String_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_GetAllHeaderValues_Private_List_1_String_HeaderBucket_HeaderInfo_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_GetKnownHeaderKind_Internal_Static_HttpHeaderKind_String_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Internal_T_String_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_GetValues_Internal_HttpHeaderValueCollection_1_T_String_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Internal_Void_String_T_Func_2_Object_String_0;

		// Token: 0x02000051 RID: 81
		public class HeaderBucket : Object
		{
			// Token: 0x060004A1 RID: 1185 RVA: 0x000164F8 File Offset: 0x000146F8
			// Note: this type is marked as 'beforefieldinit'.
			static HeaderBucket()
			{
				Il2CppClassPointerStore<HttpHeaders.HeaderBucket>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, "HeaderBucket");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpHeaders.HeaderBucket>.NativeClassPtr);
				HttpHeaders.HeaderBucket.NativeFieldInfoPtr_Parsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpHeaders.HeaderBucket>.NativeClassPtr, "Parsed");
				HttpHeaders.HeaderBucket.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpHeaders.HeaderBucket>.NativeClassPtr, "values");
				HttpHeaders.HeaderBucket.NativeFieldInfoPtr_CustomToString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpHeaders.HeaderBucket>.NativeClassPtr, "CustomToString");
				HttpHeaders.HeaderBucket.NativeMethodInfoPtr__ctor_Public_Void_Object_Func_2_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders.HeaderBucket>.NativeClassPtr, 100663672);
				HttpHeaders.HeaderBucket.NativeMethodInfoPtr_get_HasStringValues_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders.HeaderBucket>.NativeClassPtr, 100663673);
				HttpHeaders.HeaderBucket.NativeMethodInfoPtr_get_Values_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders.HeaderBucket>.NativeClassPtr, 100663674);
				HttpHeaders.HeaderBucket.NativeMethodInfoPtr_set_Values_Public_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders.HeaderBucket>.NativeClassPtr, 100663675);
				HttpHeaders.HeaderBucket.NativeMethodInfoPtr_ParsedToString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders.HeaderBucket>.NativeClassPtr, 100663676);
			}

			// Token: 0x060004A2 RID: 1186 RVA: 0x000165C4 File Offset: 0x000147C4
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1173749, RefRangeEnd = 1173757, XrefRangeStart = 1173746, XrefRangeEnd = 1173749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HeaderBucket(Object parsed, Func<Object, string> converter)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpHeaders.HeaderBucket>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parsed);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.HeaderBucket.NativeMethodInfoPtr__ctor_Public_Void_Object_Func_2_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000167 RID: 359
			// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00016624 File Offset: 0x00014824
			public unsafe bool HasStringValues
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 1173758, RefRangeEnd = 1173760, XrefRangeStart = 1173757, XrefRangeEnd = 1173758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.HeaderBucket.NativeMethodInfoPtr_get_HasStringValues_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000168 RID: 360
			// (get) Token: 0x060004A4 RID: 1188 RVA: 0x00016660 File Offset: 0x00014860
			// (set) Token: 0x060004A5 RID: 1189 RVA: 0x000166A0 File Offset: 0x000148A0
			public unsafe List<string> Values
			{
				[CallerCount(8)]
				[CachedScanResults(RefRangeStart = 1173767, RefRangeEnd = 1173775, XrefRangeStart = 1173760, XrefRangeEnd = 1173767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.HeaderBucket.NativeMethodInfoPtr_get_Values_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.HeaderBucket.NativeMethodInfoPtr_set_Values_Public_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060004A6 RID: 1190 RVA: 0x000166E4 File Offset: 0x000148E4
			[CallerCount(0)]
			public unsafe string ParsedToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders.HeaderBucket.NativeMethodInfoPtr_ParsedToString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060004A7 RID: 1191 RVA: 0x00003F82 File Offset: 0x00002182
			public HeaderBucket(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000164 RID: 356
			// (get) Token: 0x060004A8 RID: 1192 RVA: 0x0001671C File Offset: 0x0001491C
			// (set) Token: 0x060004A9 RID: 1193 RVA: 0x00003F8B File Offset: 0x0000218B
			public unsafe Object Parsed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpHeaders.HeaderBucket.NativeFieldInfoPtr_Parsed);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpHeaders.HeaderBucket.NativeFieldInfoPtr_Parsed), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000165 RID: 357
			// (get) Token: 0x060004AA RID: 1194 RVA: 0x0001674C File Offset: 0x0001494C
			// (set) Token: 0x060004AB RID: 1195 RVA: 0x00003FAA File Offset: 0x000021AA
			public unsafe List<string> values
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpHeaders.HeaderBucket.NativeFieldInfoPtr_values);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpHeaders.HeaderBucket.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000166 RID: 358
			// (get) Token: 0x060004AC RID: 1196 RVA: 0x0001677C File Offset: 0x0001497C
			// (set) Token: 0x060004AD RID: 1197 RVA: 0x00003FC9 File Offset: 0x000021C9
			public unsafe Func<Object, string> CustomToString
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpHeaders.HeaderBucket.NativeFieldInfoPtr_CustomToString);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpHeaders.HeaderBucket.NativeFieldInfoPtr_CustomToString), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400033E RID: 830
			private static readonly IntPtr NativeFieldInfoPtr_Parsed;

			// Token: 0x0400033F RID: 831
			private static readonly IntPtr NativeFieldInfoPtr_values;

			// Token: 0x04000340 RID: 832
			private static readonly IntPtr NativeFieldInfoPtr_CustomToString;

			// Token: 0x04000341 RID: 833
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Func_2_Object_String_0;

			// Token: 0x04000342 RID: 834
			private static readonly IntPtr NativeMethodInfoPtr_get_HasStringValues_Public_get_Boolean_0;

			// Token: 0x04000343 RID: 835
			private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_get_List_1_String_0;

			// Token: 0x04000344 RID: 836
			private static readonly IntPtr NativeMethodInfoPtr_set_Values_Public_set_Void_List_1_String_0;

			// Token: 0x04000345 RID: 837
			private static readonly IntPtr NativeMethodInfoPtr_ParsedToString_Public_String_0;
		}

		// Token: 0x02000052 RID: 82
		[ObfuscatedName("System.Net.Http.Headers.HttpHeaders+<GetEnumerator>d__19")]
		public sealed class _GetEnumerator_d__19 : Object
		{
			// Token: 0x060004AE RID: 1198 RVA: 0x000167AC File Offset: 0x000149AC
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEnumerator_d__19()
			{
				Il2CppClassPointerStore<HttpHeaders._GetEnumerator_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr, "<GetEnumerator>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpHeaders._GetEnumerator_d__19>.NativeClassPtr);
				HttpHeaders._GetEnumerator_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpHeaders._GetEnumerator_d__19>.NativeClassPtr, "<>1__state");
				HttpHeaders._GetEnumerator_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpHeaders._GetEnumerator_d__19>.NativeClassPtr, "<>2__current");
				HttpHeaders._GetEnumerator_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpHeaders._GetEnumerator_d__19>.NativeClassPtr, "<>4__this");
				HttpHeaders._GetEnumerator_d__19.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpHeaders._GetEnumerator_d__19>.NativeClassPtr, "<>7__wrap1");
				HttpHeaders._GetEnumerator_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders._GetEnumerator_d__19>.NativeClassPtr, 100663677);
				HttpHeaders._GetEnumerator_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders._GetEnumerator_d__19>.NativeClassPtr, 100663678);
				HttpHeaders._GetEnumerator_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders._GetEnumerator_d__19>.NativeClassPtr, 100663679);
				HttpHeaders._GetEnumerator_d__19.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders._GetEnumerator_d__19>.NativeClassPtr, 100663680);
				HttpHeaders._GetEnumerator_d__19.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders._GetEnumerator_d__19>.NativeClassPtr, 100663681);
				HttpHeaders._GetEnumerator_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders._GetEnumerator_d__19>.NativeClassPtr, 100663682);
				HttpHeaders._GetEnumerator_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpHeaders._GetEnumerator_d__19>.NativeClassPtr, 100663683);
			}

			// Token: 0x060004AF RID: 1199 RVA: 0x000168B4 File Offset: 0x00014AB4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetEnumerator_d__19(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpHeaders._GetEnumerator_d__19>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders._GetEnumerator_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060004B0 RID: 1200 RVA: 0x000168FC File Offset: 0x00014AFC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1173780, RefRangeEnd = 1173781, XrefRangeStart = 1173775, XrefRangeEnd = 1173780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders._GetEnumerator_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004B1 RID: 1201 RVA: 0x00016930 File Offset: 0x00014B30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173781, XrefRangeEnd = 1173812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders._GetEnumerator_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060004B2 RID: 1202 RVA: 0x0001696C File Offset: 0x00014B6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173812, XrefRangeEnd = 1173815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders._GetEnumerator_d__19.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700016D RID: 365
			// (get) Token: 0x060004B3 RID: 1203 RVA: 0x000169A0 File Offset: 0x00014BA0
			public unsafe KeyValuePair<string, IEnumerable<string>> prop_KeyValuePair_2_String_IEnumerable_1_String_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders._GetEnumerator_d__19.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<string, IEnumerable<string>>(intPtr);
				}
			}

			// Token: 0x060004B4 RID: 1204 RVA: 0x000169D8 File Offset: 0x00014BD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173815, XrefRangeEnd = 1173820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders._GetEnumerator_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700016E RID: 366
			// (get) Token: 0x060004B5 RID: 1205 RVA: 0x00016A0C File Offset: 0x00014C0C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173820, XrefRangeEnd = 1173823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpHeaders._GetEnumerator_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060004B6 RID: 1206 RVA: 0x00003FE8 File Offset: 0x000021E8
			public _GetEnumerator_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000169 RID: 361
			// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00016A4C File Offset: 0x00014C4C
			// (set) Token: 0x060004B8 RID: 1208 RVA: 0x00003FF1 File Offset: 0x000021F1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpHeaders._GetEnumerator_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpHeaders._GetEnumerator_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700016A RID: 362
			// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00016A74 File Offset: 0x00014C74
			// (set) Token: 0x060004BA RID: 1210 RVA: 0x0000400C File Offset: 0x0000220C
			public KeyValuePair<string, IEnumerable<string>> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpHeaders._GetEnumerator_d__19.NativeFieldInfoPtr___2__current);
					return new KeyValuePair<string, IEnumerable<string>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<string, IEnumerable<string>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpHeaders._GetEnumerator_d__19.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<string, IEnumerable<string>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700016B RID: 363
			// (get) Token: 0x060004BB RID: 1211 RVA: 0x00016AA4 File Offset: 0x00014CA4
			// (set) Token: 0x060004BC RID: 1212 RVA: 0x0000403A File Offset: 0x0000223A
			public unsafe HttpHeaders __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpHeaders._GetEnumerator_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpHeaders>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpHeaders._GetEnumerator_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700016C RID: 364
			// (get) Token: 0x060004BD RID: 1213 RVA: 0x00016AD4 File Offset: 0x00014CD4
			// (set) Token: 0x060004BE RID: 1214 RVA: 0x00004059 File Offset: 0x00002259
			public Dictionary<string, HttpHeaders.HeaderBucket>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpHeaders._GetEnumerator_d__19.NativeFieldInfoPtr___7__wrap1);
					return new Dictionary<string, HttpHeaders.HeaderBucket>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<string, HttpHeaders.HeaderBucket>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpHeaders._GetEnumerator_d__19.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<string, HttpHeaders.HeaderBucket>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000346 RID: 838
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000347 RID: 839
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000348 RID: 840
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000349 RID: 841
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400034A RID: 842
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400034B RID: 843
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400034C RID: 844
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400034D RID: 845
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400034E RID: 846
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_IEnumerable_1_String_0;

			// Token: 0x0400034F RID: 847
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000350 RID: 848
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000053 RID: 83
		private sealed class MethodInfoStoreGeneric_AddOrRemove_Internal_Void_String_T_Func_2_Object_String_0<T>
		{
			// Token: 0x04000351 RID: 849
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HttpHeaders.NativeMethodInfoPtr_AddOrRemove_Internal_Void_String_T_Func_2_Object_String_0, Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000054 RID: 84
		private sealed class MethodInfoStoreGeneric_AddOrRemove_Internal_Void_String_Nullable_1_T_0<T>
		{
			// Token: 0x04000352 RID: 850
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HttpHeaders.NativeMethodInfoPtr_AddOrRemove_Internal_Void_String_Nullable_1_T_0, Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000055 RID: 85
		private sealed class MethodInfoStoreGeneric_AddOrRemove_Internal_Void_String_Nullable_1_T_Func_2_Object_String_0<T>
		{
			// Token: 0x04000353 RID: 851
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HttpHeaders.NativeMethodInfoPtr_AddOrRemove_Internal_Void_String_Nullable_1_T_Func_2_Object_String_0, Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000056 RID: 86
		private sealed class MethodInfoStoreGeneric_GetValue_Internal_T_String_0<T>
		{
			// Token: 0x04000354 RID: 852
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HttpHeaders.NativeMethodInfoPtr_GetValue_Internal_T_String_0, Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000057 RID: 87
		private sealed class MethodInfoStoreGeneric_GetValues_Internal_HttpHeaderValueCollection_1_T_String_0<T>
		{
			// Token: 0x04000355 RID: 853
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HttpHeaders.NativeMethodInfoPtr_GetValues_Internal_HttpHeaderValueCollection_1_T_String_0, Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000058 RID: 88
		private sealed class MethodInfoStoreGeneric_SetValue_Internal_Void_String_T_Func_2_Object_String_0<T>
		{
			// Token: 0x04000356 RID: 854
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HttpHeaders.NativeMethodInfoPtr_SetValue_Internal_Void_String_T_Func_2_Object_String_0, Il2CppClassPointerStore<HttpHeaders>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
