using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Specialized;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Net
{
	// Token: 0x020001C6 RID: 454
	[DefaultMember("Item")]
	[Serializable]
	public class WebHeaderCollection : NameValueCollection
	{
		// Token: 0x06001B9D RID: 7069 RVA: 0x000881B4 File Offset: 0x000863B4
		// Note: this type is marked as 'beforefieldinit'.
		static WebHeaderCollection()
		{
			Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebHeaderCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr);
			WebHeaderCollection.NativeFieldInfoPtr_ApproxAveHeaderLineSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "ApproxAveHeaderLineSize");
			WebHeaderCollection.NativeFieldInfoPtr_ApproxHighAvgNumHeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "ApproxHighAvgNumHeaders");
			WebHeaderCollection.NativeFieldInfoPtr_HInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "HInfo");
			WebHeaderCollection.NativeFieldInfoPtr_m_CommonHeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "m_CommonHeaders");
			WebHeaderCollection.NativeFieldInfoPtr_m_NumCommonHeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "m_NumCommonHeaders");
			WebHeaderCollection.NativeFieldInfoPtr_s_CommonHeaderNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "s_CommonHeaderNames");
			WebHeaderCollection.NativeFieldInfoPtr_s_CommonHeaderHints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "s_CommonHeaderHints");
			WebHeaderCollection.NativeFieldInfoPtr_c_AcceptRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "c_AcceptRanges");
			WebHeaderCollection.NativeFieldInfoPtr_c_ContentLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "c_ContentLength");
			WebHeaderCollection.NativeFieldInfoPtr_c_CacheControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "c_CacheControl");
			WebHeaderCollection.NativeFieldInfoPtr_c_ContentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "c_ContentType");
			WebHeaderCollection.NativeFieldInfoPtr_c_Date = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "c_Date");
			WebHeaderCollection.NativeFieldInfoPtr_c_Expires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "c_Expires");
			WebHeaderCollection.NativeFieldInfoPtr_c_ETag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "c_ETag");
			WebHeaderCollection.NativeFieldInfoPtr_c_LastModified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "c_LastModified");
			WebHeaderCollection.NativeFieldInfoPtr_c_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "c_Location");
			WebHeaderCollection.NativeFieldInfoPtr_c_ProxyAuthenticate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "c_ProxyAuthenticate");
			WebHeaderCollection.NativeFieldInfoPtr_c_P3P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "c_P3P");
			WebHeaderCollection.NativeFieldInfoPtr_c_SetCookie2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "c_SetCookie2");
			WebHeaderCollection.NativeFieldInfoPtr_c_SetCookie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "c_SetCookie");
			WebHeaderCollection.NativeFieldInfoPtr_c_Server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "c_Server");
			WebHeaderCollection.NativeFieldInfoPtr_c_Via = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "c_Via");
			WebHeaderCollection.NativeFieldInfoPtr_c_WwwAuthenticate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "c_WwwAuthenticate");
			WebHeaderCollection.NativeFieldInfoPtr_c_XAspNetVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "c_XAspNetVersion");
			WebHeaderCollection.NativeFieldInfoPtr_c_XPoweredBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "c_XPoweredBy");
			WebHeaderCollection.NativeFieldInfoPtr_m_InnerCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "m_InnerCollection");
			WebHeaderCollection.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "m_Type");
			WebHeaderCollection.NativeFieldInfoPtr_HttpTrimCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "HttpTrimCharacters");
			WebHeaderCollection.NativeFieldInfoPtr_RfcCharMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "RfcCharMap");
			WebHeaderCollection.NativeMethodInfoPtr_NormalizeCommonHeaders_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667551);
			WebHeaderCollection.NativeMethodInfoPtr_get_InnerCollection_Private_get_NameValueCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667552);
			WebHeaderCollection.NativeMethodInfoPtr_AllowMultiValues_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667553);
			WebHeaderCollection.NativeMethodInfoPtr_get_AllowHttpRequestHeader_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667554);
			WebHeaderCollection.NativeMethodInfoPtr_Remove_Public_Void_HttpRequestHeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667555);
			WebHeaderCollection.NativeMethodInfoPtr_AddInternal_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667556);
			WebHeaderCollection.NativeMethodInfoPtr_ChangeInternal_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667557);
			WebHeaderCollection.NativeMethodInfoPtr_RemoveInternal_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667558);
			WebHeaderCollection.NativeMethodInfoPtr_CheckBadChars_Internal_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667559);
			WebHeaderCollection.NativeMethodInfoPtr_ContainsNonAsciiChars_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667560);
			WebHeaderCollection.NativeMethodInfoPtr_ThrowOnRestrictedHeader_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667561);
			WebHeaderCollection.NativeMethodInfoPtr_Add_Public_Virtual_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667562);
			WebHeaderCollection.NativeMethodInfoPtr_Add_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667563);
			WebHeaderCollection.NativeMethodInfoPtr_Set_Public_Virtual_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667564);
			WebHeaderCollection.NativeMethodInfoPtr_SetInternal_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667565);
			WebHeaderCollection.NativeMethodInfoPtr_Remove_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667566);
			WebHeaderCollection.NativeMethodInfoPtr_GetValues_Public_Virtual_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667567);
			WebHeaderCollection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667568);
			WebHeaderCollection.NativeMethodInfoPtr_GetAsString_Internal_Static_String_NameValueCollection_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667569);
			WebHeaderCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667570);
			WebHeaderCollection.NativeMethodInfoPtr__ctor_Internal_Void_WebHeaderCollectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667571);
			WebHeaderCollection.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667572);
			WebHeaderCollection.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667573);
			WebHeaderCollection.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667574);
			WebHeaderCollection.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667575);
			WebHeaderCollection.NativeMethodInfoPtr_Get_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667576);
			WebHeaderCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667577);
			WebHeaderCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667578);
			WebHeaderCollection.NativeMethodInfoPtr_Get_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667579);
			WebHeaderCollection.NativeMethodInfoPtr_GetValues_Public_Virtual_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667580);
			WebHeaderCollection.NativeMethodInfoPtr_GetKey_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667581);
			WebHeaderCollection.NativeMethodInfoPtr_get_AllKeys_Public_Virtual_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100667582);
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x000886A8 File Offset: 0x000868A8
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 474850, RefRangeEnd = 474867, XrefRangeStart = 474843, XrefRangeEnd = 474850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NormalizeCommonHeaders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_NormalizeCommonHeaders_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06001B9F RID: 7071 RVA: 0x000886DC File Offset: 0x000868DC
		public unsafe NameValueCollection InnerCollection
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 474876, RefRangeEnd = 474892, XrefRangeStart = 474867, XrefRangeEnd = 474876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_get_InnerCollection_Private_get_NameValueCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameValueCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x0008871C File Offset: 0x0008691C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 474898, RefRangeEnd = 474900, XrefRangeStart = 474892, XrefRangeEnd = 474898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AllowMultiValues(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_AllowMultiValues_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06001BA1 RID: 7073 RVA: 0x00088760 File Offset: 0x00086960
		public unsafe bool AllowHttpRequestHeader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_get_AllowHttpRequestHeader_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x0008879C File Offset: 0x0008699C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 474911, RefRangeEnd = 474913, XrefRangeStart = 474900, XrefRangeEnd = 474911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(HttpRequestHeader header)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref header;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_Remove_Public_Void_HttpRequestHeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x000887DC File Offset: 0x000869DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 474917, RefRangeEnd = 474920, XrefRangeStart = 474913, XrefRangeEnd = 474917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddInternal(string name, string value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_AddInternal_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x00088830 File Offset: 0x00086A30
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 474924, RefRangeEnd = 474929, XrefRangeStart = 474920, XrefRangeEnd = 474924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeInternal(string name, string value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_ChangeInternal_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x00088884 File Offset: 0x00086A84
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 474931, RefRangeEnd = 474941, XrefRangeStart = 474929, XrefRangeEnd = 474931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveInternal(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_RemoveInternal_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x000888C8 File Offset: 0x00086AC8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 474962, RefRangeEnd = 474971, XrefRangeStart = 474941, XrefRangeEnd = 474962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CheckBadChars(string name, bool isHeaderValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHeaderValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_CheckBadChars_Internal_Static_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x00088914 File Offset: 0x00086B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474971, XrefRangeEnd = 474974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ContainsNonAsciiChars(string token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_ContainsNonAsciiChars_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x00088958 File Offset: 0x00086B58
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 474984, RefRangeEnd = 474988, XrefRangeStart = 474974, XrefRangeEnd = 474984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowOnRestrictedHeader(string headerName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(headerName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_ThrowOnRestrictedHeader_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x0008899C File Offset: 0x00086B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474988, XrefRangeEnd = 475013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Add(string name, string value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_Add_Public_Virtual_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x000889FC File Offset: 0x00086BFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 475058, RefRangeEnd = 475059, XrefRangeStart = 475013, XrefRangeEnd = 475058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string header)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(header);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_Add_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x00088A40 File Offset: 0x00086C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475059, XrefRangeEnd = 475093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Set(string name, string value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_Set_Public_Virtual_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x00088AA0 File Offset: 0x00086CA0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 475126, RefRangeEnd = 475140, XrefRangeStart = 475093, XrefRangeEnd = 475126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInternal(string name, string value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_SetInternal_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x00088AF4 File Offset: 0x00086CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475140, XrefRangeEnd = 475150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Remove(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_Remove_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x00088B44 File Offset: 0x00086D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475150, XrefRangeEnd = 475164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStringArray GetValues(string header)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(header);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_GetValues_Public_Virtual_Il2CppStringArray_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x00088BA0 File Offset: 0x00086DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475164, XrefRangeEnd = 475268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x00088BE4 File Offset: 0x00086DE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 475293, RefRangeEnd = 475294, XrefRangeStart = 475268, XrefRangeEnd = 475293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref winInetCompat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forTrace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_GetAsString_Internal_Static_String_NameValueCollection_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x00088C3C File Offset: 0x00086E3C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 475299, RefRangeEnd = 475310, XrefRangeStart = 475294, XrefRangeEnd = 475299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebHeaderCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x00088C78 File Offset: 0x00086E78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 475323, RefRangeEnd = 475324, XrefRangeStart = 475310, XrefRangeEnd = 475323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebHeaderCollection(WebHeaderCollectionType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr__ctor_Internal_Void_WebHeaderCollectionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x00088CC0 File Offset: 0x00086EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475324, XrefRangeEnd = 475348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebHeaderCollection(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x00088D24 File Offset: 0x00086F24
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x00088D74 File Offset: 0x00086F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475348, XrefRangeEnd = 475358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x00088DD8 File Offset: 0x00086FD8
		[CallerCount(0)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x00088E34 File Offset: 0x00087034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475358, XrefRangeEnd = 475386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string Get(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_Get_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x00088E88 File Offset: 0x00087088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475386, XrefRangeEnd = 475392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x00088ED4 File Offset: 0x000870D4
		public unsafe override int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x00088F1C File Offset: 0x0008711C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475392, XrefRangeEnd = 475395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string Get(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_Get_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x00088F6C File Offset: 0x0008716C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475395, XrefRangeEnd = 475398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStringArray GetValues(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_GetValues_Public_Virtual_Il2CppStringArray_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x00088FC4 File Offset: 0x000871C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475398, XrefRangeEnd = 475401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetKey(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_GetKey_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06001BBD RID: 7101 RVA: 0x00089014 File Offset: 0x00087214
		public unsafe override Il2CppStringArray AllKeys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475401, XrefRangeEnd = 475404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_get_AllKeys_Public_Virtual_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x0000BD62 File Offset: 0x00009F62
		public WebHeaderCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06001BBF RID: 7103 RVA: 0x00089060 File Offset: 0x00087260
		// (set) Token: 0x06001BC0 RID: 7104 RVA: 0x0000BD6B File Offset: 0x00009F6B
		public unsafe static int ApproxAveHeaderLineSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_ApproxAveHeaderLineSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_ApproxAveHeaderLineSize, (void*)(&value));
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06001BC1 RID: 7105 RVA: 0x0008907C File Offset: 0x0008727C
		// (set) Token: 0x06001BC2 RID: 7106 RVA: 0x0000BD79 File Offset: 0x00009F79
		public unsafe static int ApproxHighAvgNumHeaders
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_ApproxHighAvgNumHeaders, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_ApproxHighAvgNumHeaders, (void*)(&value));
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001BC3 RID: 7107 RVA: 0x00089098 File Offset: 0x00087298
		// (set) Token: 0x06001BC4 RID: 7108 RVA: 0x0000BD87 File Offset: 0x00009F87
		public unsafe static HeaderInfoTable HInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_HInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeaderInfoTable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_HInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x000890C0 File Offset: 0x000872C0
		// (set) Token: 0x06001BC6 RID: 7110 RVA: 0x0000BD99 File Offset: 0x00009F99
		public unsafe Il2CppStringArray m_CommonHeaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebHeaderCollection.NativeFieldInfoPtr_m_CommonHeaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebHeaderCollection.NativeFieldInfoPtr_m_CommonHeaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06001BC7 RID: 7111 RVA: 0x000890F0 File Offset: 0x000872F0
		// (set) Token: 0x06001BC8 RID: 7112 RVA: 0x0000BDB8 File Offset: 0x00009FB8
		public unsafe int m_NumCommonHeaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebHeaderCollection.NativeFieldInfoPtr_m_NumCommonHeaders);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebHeaderCollection.NativeFieldInfoPtr_m_NumCommonHeaders)) = value;
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06001BC9 RID: 7113 RVA: 0x00089118 File Offset: 0x00087318
		// (set) Token: 0x06001BCA RID: 7114 RVA: 0x0000BDD3 File Offset: 0x00009FD3
		public unsafe static Il2CppStringArray s_CommonHeaderNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_s_CommonHeaderNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_s_CommonHeaderNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06001BCB RID: 7115 RVA: 0x00089140 File Offset: 0x00087340
		// (set) Token: 0x06001BCC RID: 7116 RVA: 0x0000BDE5 File Offset: 0x00009FE5
		public unsafe static Il2CppStructArray<sbyte> s_CommonHeaderHints
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_s_CommonHeaderHints, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_s_CommonHeaderHints, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06001BCD RID: 7117 RVA: 0x00089168 File Offset: 0x00087368
		// (set) Token: 0x06001BCE RID: 7118 RVA: 0x0000BDF7 File Offset: 0x00009FF7
		public unsafe static int c_AcceptRanges
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_c_AcceptRanges, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_c_AcceptRanges, (void*)(&value));
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06001BCF RID: 7119 RVA: 0x00089184 File Offset: 0x00087384
		// (set) Token: 0x06001BD0 RID: 7120 RVA: 0x0000BE05 File Offset: 0x0000A005
		public unsafe static int c_ContentLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_c_ContentLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_c_ContentLength, (void*)(&value));
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x000891A0 File Offset: 0x000873A0
		// (set) Token: 0x06001BD2 RID: 7122 RVA: 0x0000BE13 File Offset: 0x0000A013
		public unsafe static int c_CacheControl
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_c_CacheControl, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_c_CacheControl, (void*)(&value));
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06001BD3 RID: 7123 RVA: 0x000891BC File Offset: 0x000873BC
		// (set) Token: 0x06001BD4 RID: 7124 RVA: 0x0000BE21 File Offset: 0x0000A021
		public unsafe static int c_ContentType
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_c_ContentType, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_c_ContentType, (void*)(&value));
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06001BD5 RID: 7125 RVA: 0x000891D8 File Offset: 0x000873D8
		// (set) Token: 0x06001BD6 RID: 7126 RVA: 0x0000BE2F File Offset: 0x0000A02F
		public unsafe static int c_Date
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_c_Date, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_c_Date, (void*)(&value));
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06001BD7 RID: 7127 RVA: 0x000891F4 File Offset: 0x000873F4
		// (set) Token: 0x06001BD8 RID: 7128 RVA: 0x0000BE3D File Offset: 0x0000A03D
		public unsafe static int c_Expires
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_c_Expires, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_c_Expires, (void*)(&value));
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06001BD9 RID: 7129 RVA: 0x00089210 File Offset: 0x00087410
		// (set) Token: 0x06001BDA RID: 7130 RVA: 0x0000BE4B File Offset: 0x0000A04B
		public unsafe static int c_ETag
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_c_ETag, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_c_ETag, (void*)(&value));
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06001BDB RID: 7131 RVA: 0x0008922C File Offset: 0x0008742C
		// (set) Token: 0x06001BDC RID: 7132 RVA: 0x0000BE59 File Offset: 0x0000A059
		public unsafe static int c_LastModified
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_c_LastModified, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_c_LastModified, (void*)(&value));
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06001BDD RID: 7133 RVA: 0x00089248 File Offset: 0x00087448
		// (set) Token: 0x06001BDE RID: 7134 RVA: 0x0000BE67 File Offset: 0x0000A067
		public unsafe static int c_Location
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_c_Location, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_c_Location, (void*)(&value));
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06001BDF RID: 7135 RVA: 0x00089264 File Offset: 0x00087464
		// (set) Token: 0x06001BE0 RID: 7136 RVA: 0x0000BE75 File Offset: 0x0000A075
		public unsafe static int c_ProxyAuthenticate
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_c_ProxyAuthenticate, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_c_ProxyAuthenticate, (void*)(&value));
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x00089280 File Offset: 0x00087480
		// (set) Token: 0x06001BE2 RID: 7138 RVA: 0x0000BE83 File Offset: 0x0000A083
		public unsafe static int c_P3P
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_c_P3P, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_c_P3P, (void*)(&value));
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06001BE3 RID: 7139 RVA: 0x0008929C File Offset: 0x0008749C
		// (set) Token: 0x06001BE4 RID: 7140 RVA: 0x0000BE91 File Offset: 0x0000A091
		public unsafe static int c_SetCookie2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_c_SetCookie2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_c_SetCookie2, (void*)(&value));
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06001BE5 RID: 7141 RVA: 0x000892B8 File Offset: 0x000874B8
		// (set) Token: 0x06001BE6 RID: 7142 RVA: 0x0000BE9F File Offset: 0x0000A09F
		public unsafe static int c_SetCookie
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_c_SetCookie, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_c_SetCookie, (void*)(&value));
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06001BE7 RID: 7143 RVA: 0x000892D4 File Offset: 0x000874D4
		// (set) Token: 0x06001BE8 RID: 7144 RVA: 0x0000BEAD File Offset: 0x0000A0AD
		public unsafe static int c_Server
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_c_Server, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_c_Server, (void*)(&value));
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06001BE9 RID: 7145 RVA: 0x000892F0 File Offset: 0x000874F0
		// (set) Token: 0x06001BEA RID: 7146 RVA: 0x0000BEBB File Offset: 0x0000A0BB
		public unsafe static int c_Via
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_c_Via, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_c_Via, (void*)(&value));
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06001BEB RID: 7147 RVA: 0x0008930C File Offset: 0x0008750C
		// (set) Token: 0x06001BEC RID: 7148 RVA: 0x0000BEC9 File Offset: 0x0000A0C9
		public unsafe static int c_WwwAuthenticate
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_c_WwwAuthenticate, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_c_WwwAuthenticate, (void*)(&value));
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06001BED RID: 7149 RVA: 0x00089328 File Offset: 0x00087528
		// (set) Token: 0x06001BEE RID: 7150 RVA: 0x0000BED7 File Offset: 0x0000A0D7
		public unsafe static int c_XAspNetVersion
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_c_XAspNetVersion, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_c_XAspNetVersion, (void*)(&value));
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06001BEF RID: 7151 RVA: 0x00089344 File Offset: 0x00087544
		// (set) Token: 0x06001BF0 RID: 7152 RVA: 0x0000BEE5 File Offset: 0x0000A0E5
		public unsafe static int c_XPoweredBy
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_c_XPoweredBy, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_c_XPoweredBy, (void*)(&value));
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06001BF1 RID: 7153 RVA: 0x00089360 File Offset: 0x00087560
		// (set) Token: 0x06001BF2 RID: 7154 RVA: 0x0000BEF3 File Offset: 0x0000A0F3
		public unsafe NameValueCollection m_InnerCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebHeaderCollection.NativeFieldInfoPtr_m_InnerCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NameValueCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebHeaderCollection.NativeFieldInfoPtr_m_InnerCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06001BF3 RID: 7155 RVA: 0x00089390 File Offset: 0x00087590
		// (set) Token: 0x06001BF4 RID: 7156 RVA: 0x0000BF12 File Offset: 0x0000A112
		public unsafe WebHeaderCollectionType m_Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebHeaderCollection.NativeFieldInfoPtr_m_Type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebHeaderCollection.NativeFieldInfoPtr_m_Type)) = value;
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x000893B8 File Offset: 0x000875B8
		// (set) Token: 0x06001BF6 RID: 7158 RVA: 0x0000BF2D File Offset: 0x0000A12D
		public unsafe static Il2CppStructArray<char> HttpTrimCharacters
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_HttpTrimCharacters, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_HttpTrimCharacters, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06001BF7 RID: 7159 RVA: 0x000893E0 File Offset: 0x000875E0
		// (set) Token: 0x06001BF8 RID: 7160 RVA: 0x0000BF3F File Offset: 0x0000A13F
		public unsafe static Il2CppStructArray<WebHeaderCollection.RfcChar> RfcCharMap
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_RfcCharMap, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<WebHeaderCollection.RfcChar>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_RfcCharMap, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001610 RID: 5648
		private static readonly IntPtr NativeFieldInfoPtr_ApproxAveHeaderLineSize;

		// Token: 0x04001611 RID: 5649
		private static readonly IntPtr NativeFieldInfoPtr_ApproxHighAvgNumHeaders;

		// Token: 0x04001612 RID: 5650
		private static readonly IntPtr NativeFieldInfoPtr_HInfo;

		// Token: 0x04001613 RID: 5651
		private static readonly IntPtr NativeFieldInfoPtr_m_CommonHeaders;

		// Token: 0x04001614 RID: 5652
		private static readonly IntPtr NativeFieldInfoPtr_m_NumCommonHeaders;

		// Token: 0x04001615 RID: 5653
		private static readonly IntPtr NativeFieldInfoPtr_s_CommonHeaderNames;

		// Token: 0x04001616 RID: 5654
		private static readonly IntPtr NativeFieldInfoPtr_s_CommonHeaderHints;

		// Token: 0x04001617 RID: 5655
		private static readonly IntPtr NativeFieldInfoPtr_c_AcceptRanges;

		// Token: 0x04001618 RID: 5656
		private static readonly IntPtr NativeFieldInfoPtr_c_ContentLength;

		// Token: 0x04001619 RID: 5657
		private static readonly IntPtr NativeFieldInfoPtr_c_CacheControl;

		// Token: 0x0400161A RID: 5658
		private static readonly IntPtr NativeFieldInfoPtr_c_ContentType;

		// Token: 0x0400161B RID: 5659
		private static readonly IntPtr NativeFieldInfoPtr_c_Date;

		// Token: 0x0400161C RID: 5660
		private static readonly IntPtr NativeFieldInfoPtr_c_Expires;

		// Token: 0x0400161D RID: 5661
		private static readonly IntPtr NativeFieldInfoPtr_c_ETag;

		// Token: 0x0400161E RID: 5662
		private static readonly IntPtr NativeFieldInfoPtr_c_LastModified;

		// Token: 0x0400161F RID: 5663
		private static readonly IntPtr NativeFieldInfoPtr_c_Location;

		// Token: 0x04001620 RID: 5664
		private static readonly IntPtr NativeFieldInfoPtr_c_ProxyAuthenticate;

		// Token: 0x04001621 RID: 5665
		private static readonly IntPtr NativeFieldInfoPtr_c_P3P;

		// Token: 0x04001622 RID: 5666
		private static readonly IntPtr NativeFieldInfoPtr_c_SetCookie2;

		// Token: 0x04001623 RID: 5667
		private static readonly IntPtr NativeFieldInfoPtr_c_SetCookie;

		// Token: 0x04001624 RID: 5668
		private static readonly IntPtr NativeFieldInfoPtr_c_Server;

		// Token: 0x04001625 RID: 5669
		private static readonly IntPtr NativeFieldInfoPtr_c_Via;

		// Token: 0x04001626 RID: 5670
		private static readonly IntPtr NativeFieldInfoPtr_c_WwwAuthenticate;

		// Token: 0x04001627 RID: 5671
		private static readonly IntPtr NativeFieldInfoPtr_c_XAspNetVersion;

		// Token: 0x04001628 RID: 5672
		private static readonly IntPtr NativeFieldInfoPtr_c_XPoweredBy;

		// Token: 0x04001629 RID: 5673
		private static readonly IntPtr NativeFieldInfoPtr_m_InnerCollection;

		// Token: 0x0400162A RID: 5674
		private static readonly IntPtr NativeFieldInfoPtr_m_Type;

		// Token: 0x0400162B RID: 5675
		private static readonly IntPtr NativeFieldInfoPtr_HttpTrimCharacters;

		// Token: 0x0400162C RID: 5676
		private static readonly IntPtr NativeFieldInfoPtr_RfcCharMap;

		// Token: 0x0400162D RID: 5677
		private static readonly IntPtr NativeMethodInfoPtr_NormalizeCommonHeaders_Private_Void_0;

		// Token: 0x0400162E RID: 5678
		private static readonly IntPtr NativeMethodInfoPtr_get_InnerCollection_Private_get_NameValueCollection_0;

		// Token: 0x0400162F RID: 5679
		private static readonly IntPtr NativeMethodInfoPtr_AllowMultiValues_Internal_Static_Boolean_String_0;

		// Token: 0x04001630 RID: 5680
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowHttpRequestHeader_Private_get_Boolean_0;

		// Token: 0x04001631 RID: 5681
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_HttpRequestHeader_0;

		// Token: 0x04001632 RID: 5682
		private static readonly IntPtr NativeMethodInfoPtr_AddInternal_Internal_Void_String_String_0;

		// Token: 0x04001633 RID: 5683
		private static readonly IntPtr NativeMethodInfoPtr_ChangeInternal_Internal_Void_String_String_0;

		// Token: 0x04001634 RID: 5684
		private static readonly IntPtr NativeMethodInfoPtr_RemoveInternal_Internal_Void_String_0;

		// Token: 0x04001635 RID: 5685
		private static readonly IntPtr NativeMethodInfoPtr_CheckBadChars_Internal_Static_String_String_Boolean_0;

		// Token: 0x04001636 RID: 5686
		private static readonly IntPtr NativeMethodInfoPtr_ContainsNonAsciiChars_Internal_Static_Boolean_String_0;

		// Token: 0x04001637 RID: 5687
		private static readonly IntPtr NativeMethodInfoPtr_ThrowOnRestrictedHeader_Internal_Void_String_0;

		// Token: 0x04001638 RID: 5688
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Void_String_String_0;

		// Token: 0x04001639 RID: 5689
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_String_0;

		// Token: 0x0400163A RID: 5690
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Void_String_String_0;

		// Token: 0x0400163B RID: 5691
		private static readonly IntPtr NativeMethodInfoPtr_SetInternal_Internal_Void_String_String_0;

		// Token: 0x0400163C RID: 5692
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Void_String_0;

		// Token: 0x0400163D RID: 5693
		private static readonly IntPtr NativeMethodInfoPtr_GetValues_Public_Virtual_Il2CppStringArray_String_0;

		// Token: 0x0400163E RID: 5694
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400163F RID: 5695
		private static readonly IntPtr NativeMethodInfoPtr_GetAsString_Internal_Static_String_NameValueCollection_Boolean_Boolean_0;

		// Token: 0x04001640 RID: 5696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001641 RID: 5697
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_WebHeaderCollectionType_0;

		// Token: 0x04001642 RID: 5698
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001643 RID: 5699
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialization_Public_Virtual_Void_Object_0;

		// Token: 0x04001644 RID: 5700
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001645 RID: 5701
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001646 RID: 5702
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_String_String_0;

		// Token: 0x04001647 RID: 5703
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0;

		// Token: 0x04001648 RID: 5704
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0;

		// Token: 0x04001649 RID: 5705
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_String_Int32_0;

		// Token: 0x0400164A RID: 5706
		private static readonly IntPtr NativeMethodInfoPtr_GetValues_Public_Virtual_Il2CppStringArray_Int32_0;

		// Token: 0x0400164B RID: 5707
		private static readonly IntPtr NativeMethodInfoPtr_GetKey_Public_Virtual_String_Int32_0;

		// Token: 0x0400164C RID: 5708
		private static readonly IntPtr NativeMethodInfoPtr_get_AllKeys_Public_Virtual_get_Il2CppStringArray_0;

		// Token: 0x0200031E RID: 798
		public enum RfcChar : byte
		{
			// Token: 0x040024B7 RID: 9399
			High,
			// Token: 0x040024B8 RID: 9400
			Reg,
			// Token: 0x040024B9 RID: 9401
			Ctl,
			// Token: 0x040024BA RID: 9402
			CR,
			// Token: 0x040024BB RID: 9403
			LF,
			// Token: 0x040024BC RID: 9404
			WS,
			// Token: 0x040024BD RID: 9405
			Colon,
			// Token: 0x040024BE RID: 9406
			Delim
		}
	}
}
