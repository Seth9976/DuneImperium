using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Net
{
	// Token: 0x020001F7 RID: 503
	public sealed class EndPointManager : Object
	{
		// Token: 0x06001F32 RID: 7986 RVA: 0x00095678 File Offset: 0x00093878
		// Note: this type is marked as 'beforefieldinit'.
		static EndPointManager()
		{
			Il2CppClassPointerStore<EndPointManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "EndPointManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndPointManager>.NativeClassPtr);
			EndPointManager.NativeFieldInfoPtr_ip_to_endpoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndPointManager>.NativeClassPtr, "ip_to_endpoints");
			EndPointManager.NativeMethodInfoPtr_AddListener_Public_Static_Void_HttpListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPointManager>.NativeClassPtr, 100668042);
			EndPointManager.NativeMethodInfoPtr_AddPrefix_Public_Static_Void_String_HttpListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPointManager>.NativeClassPtr, 100668043);
			EndPointManager.NativeMethodInfoPtr_AddPrefixInternal_Private_Static_Void_String_HttpListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPointManager>.NativeClassPtr, 100668044);
			EndPointManager.NativeMethodInfoPtr_GetEPListener_Private_Static_EndPointListener_String_Int32_HttpListener_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPointManager>.NativeClassPtr, 100668045);
			EndPointManager.NativeMethodInfoPtr_RemoveEndPoint_Public_Static_Void_EndPointListener_IPEndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPointManager>.NativeClassPtr, 100668046);
			EndPointManager.NativeMethodInfoPtr_RemoveListener_Public_Static_Void_HttpListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPointManager>.NativeClassPtr, 100668047);
			EndPointManager.NativeMethodInfoPtr_RemovePrefix_Public_Static_Void_String_HttpListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPointManager>.NativeClassPtr, 100668048);
			EndPointManager.NativeMethodInfoPtr_RemovePrefixInternal_Private_Static_Void_String_HttpListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPointManager>.NativeClassPtr, 100668049);
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x0009575C File Offset: 0x0009395C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 479812, RefRangeEnd = 479813, XrefRangeStart = 479764, XrefRangeEnd = 479812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddListener(HttpListener listener)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndPointManager.NativeMethodInfoPtr_AddListener_Public_Static_Void_HttpListener_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x00095794 File Offset: 0x00093994
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 479824, RefRangeEnd = 479825, XrefRangeStart = 479813, XrefRangeEnd = 479824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddPrefix(string prefix, HttpListener listener)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndPointManager.NativeMethodInfoPtr_AddPrefix_Public_Static_Void_String_HttpListener_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x000957DC File Offset: 0x000939DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 479851, RefRangeEnd = 479853, XrefRangeStart = 479825, XrefRangeEnd = 479851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddPrefixInternal(string p, HttpListener listener)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(p);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndPointManager.NativeMethodInfoPtr_AddPrefixInternal_Private_Static_Void_String_HttpListener_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x00095824 File Offset: 0x00093A24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 479898, RefRangeEnd = 479900, XrefRangeStart = 479853, XrefRangeEnd = 479898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EndPointListener GetEPListener(string host, int port, HttpListener listener, bool secure)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(host);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndPointManager.NativeMethodInfoPtr_GetEPListener_Private_Static_EndPointListener_String_Int32_HttpListener_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EndPointListener>(intPtr3) : null;
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x00095898 File Offset: 0x00093A98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 479920, RefRangeEnd = 479921, XrefRangeStart = 479900, XrefRangeEnd = 479920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveEndPoint(EndPointListener epl, IPEndPoint ep)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(epl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ep);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndPointManager.NativeMethodInfoPtr_RemoveEndPoint_Public_Static_Void_EndPointListener_IPEndPoint_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x000958E0 File Offset: 0x00093AE0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 479947, RefRangeEnd = 479951, XrefRangeStart = 479921, XrefRangeEnd = 479947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveListener(HttpListener listener)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndPointManager.NativeMethodInfoPtr_RemoveListener_Public_Static_Void_HttpListener_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x00095918 File Offset: 0x00093B18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 479962, RefRangeEnd = 479963, XrefRangeStart = 479951, XrefRangeEnd = 479962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemovePrefix(string prefix, HttpListener listener)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndPointManager.NativeMethodInfoPtr_RemovePrefix_Public_Static_Void_String_HttpListener_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x00095960 File Offset: 0x00093B60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 479976, RefRangeEnd = 479978, XrefRangeStart = 479963, XrefRangeEnd = 479976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemovePrefixInternal(string prefix, HttpListener listener)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndPointManager.NativeMethodInfoPtr_RemovePrefixInternal_Private_Static_Void_String_HttpListener_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x0000D3CB File Offset: 0x0000B5CB
		public EndPointManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06001F3C RID: 7996 RVA: 0x000959A8 File Offset: 0x00093BA8
		// (set) Token: 0x06001F3D RID: 7997 RVA: 0x0000D3D4 File Offset: 0x0000B5D4
		public unsafe static Hashtable ip_to_endpoints
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EndPointManager.NativeFieldInfoPtr_ip_to_endpoints, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EndPointManager.NativeFieldInfoPtr_ip_to_endpoints, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400189C RID: 6300
		private static readonly IntPtr NativeFieldInfoPtr_ip_to_endpoints;

		// Token: 0x0400189D RID: 6301
		private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Static_Void_HttpListener_0;

		// Token: 0x0400189E RID: 6302
		private static readonly IntPtr NativeMethodInfoPtr_AddPrefix_Public_Static_Void_String_HttpListener_0;

		// Token: 0x0400189F RID: 6303
		private static readonly IntPtr NativeMethodInfoPtr_AddPrefixInternal_Private_Static_Void_String_HttpListener_0;

		// Token: 0x040018A0 RID: 6304
		private static readonly IntPtr NativeMethodInfoPtr_GetEPListener_Private_Static_EndPointListener_String_Int32_HttpListener_Boolean_0;

		// Token: 0x040018A1 RID: 6305
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEndPoint_Public_Static_Void_EndPointListener_IPEndPoint_0;

		// Token: 0x040018A2 RID: 6306
		private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Public_Static_Void_HttpListener_0;

		// Token: 0x040018A3 RID: 6307
		private static readonly IntPtr NativeMethodInfoPtr_RemovePrefix_Public_Static_Void_String_HttpListener_0;

		// Token: 0x040018A4 RID: 6308
		private static readonly IntPtr NativeMethodInfoPtr_RemovePrefixInternal_Private_Static_Void_String_HttpListener_0;
	}
}
