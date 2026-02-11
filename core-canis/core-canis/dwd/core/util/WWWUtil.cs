using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Networking;

namespace dwd.core.util
{
	// Token: 0x0200009B RID: 155
	public static class WWWUtil : Object
	{
		// Token: 0x06000AA0 RID: 2720 RVA: 0x0003BDB8 File Offset: 0x00039FB8
		// Note: this type is marked as 'beforefieldinit'.
		static WWWUtil()
		{
			Il2CppClassPointerStore<WWWUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.util", "WWWUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WWWUtil>.NativeClassPtr);
			WWWUtil.NativeFieldInfoPtr_STATUS_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWUtil>.NativeClassPtr, "STATUS_KEY");
			WWWUtil.NativeMethodInfoPtr_GetStatusCode_Public_Static_Boolean_UnityWebRequest_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWUtil>.NativeClassPtr, 100664769);
			WWWUtil.NativeMethodInfoPtr_GetStatusCode_Public_Static_Int32_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWUtil>.NativeClassPtr, 100664770);
			WWWUtil.NativeMethodInfoPtr_ParseStatusCode_Private_Static_Boolean_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWUtil>.NativeClassPtr, 100664771);
			WWWUtil.NativeMethodInfoPtr_BuildGetQueryURL_Public_Static_String_String_Il2CppReferenceArray_1_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWUtil>.NativeClassPtr, 100664772);
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0003BE4C File Offset: 0x0003A04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862897, XrefRangeEnd = 862905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetStatusCode(this UnityWebRequest www, out int statusCode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(www);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &statusCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWUtil.NativeMethodInfoPtr_GetStatusCode_Public_Static_Boolean_UnityWebRequest_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0003BE9C File Offset: 0x0003A09C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 862913, RefRangeEnd = 862915, XrefRangeStart = 862905, XrefRangeEnd = 862913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetStatusCode(this UnityWebRequest www)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(www);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWUtil.NativeMethodInfoPtr_GetStatusCode_Public_Static_Int32_UnityWebRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x0003BEE0 File Offset: 0x0003A0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862915, XrefRangeEnd = 862916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseStatusCode(string status, out int code)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(status);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &code;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWUtil.NativeMethodInfoPtr_ParseStatusCode_Private_Static_Boolean_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0003BF30 File Offset: 0x0003A130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862916, XrefRangeEnd = 862935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string BuildGetQueryURL(string baseURL, [Optional] Il2CppReferenceArray<KeyValuePair<string, string>> getQueryParams)
		{
			if (getQueryParams == null)
			{
				getQueryParams = new Il2CppStructArray<KeyValuePair<string, string>>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseURL);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getQueryParams);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWUtil.NativeMethodInfoPtr_BuildGetQueryURL_Public_Static_String_String_Il2CppReferenceArray_1_KeyValuePair_2_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00005CD7 File Offset: 0x00003ED7
		public static string BuildGetQueryURL(string baseURL, params KeyValuePair<string, string>[] getQueryParams)
		{
			return WWWUtil.BuildGetQueryURL(baseURL, new Il2CppReferenceArray<KeyValuePair<string, string>>(getQueryParams));
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00005CE5 File Offset: 0x00003EE5
		public WWWUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x0003BF8C File Offset: 0x0003A18C
		// (set) Token: 0x06000AA8 RID: 2728 RVA: 0x00005CEE File Offset: 0x00003EEE
		public unsafe static string STATUS_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WWWUtil.NativeFieldInfoPtr_STATUS_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WWWUtil.NativeFieldInfoPtr_STATUS_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeFieldInfoPtr_STATUS_KEY;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeMethodInfoPtr_GetStatusCode_Public_Static_Boolean_UnityWebRequest_byref_Int32_0;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeMethodInfoPtr_GetStatusCode_Public_Static_Int32_UnityWebRequest_0;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeMethodInfoPtr_ParseStatusCode_Private_Static_Boolean_String_byref_Int32_0;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeMethodInfoPtr_BuildGetQueryURL_Public_Static_String_String_Il2CppReferenceArray_1_KeyValuePair_2_String_String_0;
	}
}
