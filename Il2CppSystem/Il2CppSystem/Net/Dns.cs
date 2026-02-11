using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x020001F5 RID: 501
	public static class Dns : Object
	{
		// Token: 0x06001EFE RID: 7934 RVA: 0x00094738 File Offset: 0x00092938
		// Note: this type is marked as 'beforefieldinit'.
		static Dns()
		{
			Il2CppClassPointerStore<Dns>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "Dns");
			Dns.NativeMethodInfoPtr_BeginGetHostAddresses_Public_Static_IAsyncResult_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100668008);
			Dns.NativeMethodInfoPtr_EndGetHostAddresses_Public_Static_Il2CppReferenceArray_1_IPAddress_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100668009);
			Dns.NativeMethodInfoPtr_GetHostByName_icall_Private_Static_Boolean_String_byref_String_byref_Il2CppStringArray_byref_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100668010);
			Dns.NativeMethodInfoPtr_GetHostByAddr_icall_Private_Static_Boolean_String_byref_String_byref_Il2CppStringArray_byref_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100668011);
			Dns.NativeMethodInfoPtr_GetHostName_icall_Private_Static_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100668012);
			Dns.NativeMethodInfoPtr_Error_11001_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100668013);
			Dns.NativeMethodInfoPtr_hostent_to_IPHostEntry_Private_Static_IPHostEntry_String_String_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100668014);
			Dns.NativeMethodInfoPtr_GetHostByAddressFromString_Private_Static_IPHostEntry_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100668015);
			Dns.NativeMethodInfoPtr_GetHostEntry_Public_Static_IPHostEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100668016);
			Dns.NativeMethodInfoPtr_GetHostEntry_Public_Static_IPHostEntry_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100668017);
			Dns.NativeMethodInfoPtr_GetHostAddresses_Public_Static_Il2CppReferenceArray_1_IPAddress_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100668018);
			Dns.NativeMethodInfoPtr_GetHostByName_Public_Static_IPHostEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100668019);
			Dns.NativeMethodInfoPtr_GetHostName_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100668020);
			Dns.NativeMethodInfoPtr_GetHostAddressesAsync_Public_Static_Task_1_Il2CppReferenceArray_1_IPAddress_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100668021);
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x00094878 File Offset: 0x00092A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479322, XrefRangeEnd = 479338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, Object state)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hostNameOrAddress);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requestCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_BeginGetHostAddresses_Public_Static_IAsyncResult_String_AsyncCallback_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x000948E0 File Offset: 0x00092AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479338, XrefRangeEnd = 479352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<IPAddress> EndGetHostAddresses(IAsyncResult asyncResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_EndGetHostAddresses_Public_Static_Il2CppReferenceArray_1_IPAddress_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr3) : null;
			}
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x00094924 File Offset: 0x00092B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479352, XrefRangeEnd = 479353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetHostByName_icall(string host, out string h_name, out Il2CppStringArray h_aliases, out Il2CppStringArray h_addr_list, int hint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(host);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hint;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_GetHostByName_icall_Private_Static_Boolean_String_byref_String_byref_Il2CppStringArray_byref_Il2CppStringArray_Int32_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			h_name = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr6 = intPtr2;
			h_aliases = ((intPtr6 == 0) ? null : new Il2CppStringArray(intPtr6));
			IntPtr intPtr7 = intPtr3;
			h_addr_list = ((intPtr7 == 0) ? null : new Il2CppStringArray(intPtr7));
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x000949D4 File Offset: 0x00092BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479353, XrefRangeEnd = 479354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetHostByAddr_icall(string addr, out string h_name, out Il2CppStringArray h_aliases, out Il2CppStringArray h_addr_list, int hint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(addr);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hint;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_GetHostByAddr_icall_Private_Static_Boolean_String_byref_String_byref_Il2CppStringArray_byref_Il2CppStringArray_Int32_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			h_name = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr6 = intPtr2;
			h_aliases = ((intPtr6 == 0) ? null : new Il2CppStringArray(intPtr6));
			IntPtr intPtr7 = intPtr3;
			h_addr_list = ((intPtr7 == 0) ? null : new Il2CppStringArray(intPtr7));
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x00094A84 File Offset: 0x00092C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479354, XrefRangeEnd = 479355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetHostName_icall(out string h_name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_GetHostName_icall_Private_Static_Boolean_byref_String_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				h_name = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x00094AD0 File Offset: 0x00092CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479355, XrefRangeEnd = 479362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Error_11001(string hostName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hostName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_Error_11001_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x00094B08 File Offset: 0x00092D08
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 479397, RefRangeEnd = 479401, XrefRangeStart = 479362, XrefRangeEnd = 479397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, Il2CppStringArray h_aliases, Il2CppStringArray h_addrlist)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(originalHostName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(h_name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(h_aliases);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(h_addrlist);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_hostent_to_IPHostEntry_Private_Static_IPHostEntry_String_String_Il2CppStringArray_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr3) : null;
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x00094B84 File Offset: 0x00092D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479401, XrefRangeEnd = 479416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPHostEntry GetHostByAddressFromString(string address, bool parse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_GetHostByAddressFromString_Private_Static_IPHostEntry_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr3) : null;
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x00094BD8 File Offset: 0x00092DD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 479438, RefRangeEnd = 479439, XrefRangeStart = 479416, XrefRangeEnd = 479438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPHostEntry GetHostEntry(string hostNameOrAddress)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hostNameOrAddress);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_GetHostEntry_Public_Static_IPHostEntry_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x00094C1C File Offset: 0x00092E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479439, XrefRangeEnd = 479451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPHostEntry GetHostEntry(IPAddress address)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_GetHostEntry_Public_Static_IPHostEntry_IPAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x00094C60 File Offset: 0x00092E60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 479466, RefRangeEnd = 479467, XrefRangeStart = 479451, XrefRangeEnd = 479466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<IPAddress> GetHostAddresses(string hostNameOrAddress)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hostNameOrAddress);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_GetHostAddresses_Public_Static_Il2CppReferenceArray_1_IPAddress_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr3) : null;
			}
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x00094CA4 File Offset: 0x00092EA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 479473, RefRangeEnd = 479476, XrefRangeStart = 479467, XrefRangeEnd = 479473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPHostEntry GetHostByName(string hostName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hostName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_GetHostByName_Public_Static_IPHostEntry_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x00094CE8 File Offset: 0x00092EE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 479477, RefRangeEnd = 479479, XrefRangeStart = 479476, XrefRangeEnd = 479477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetHostName()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_GetHostName_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001F0C RID: 7948 RVA: 0x00094D14 File Offset: 0x00092F14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 479497, RefRangeEnd = 479499, XrefRangeStart = 479479, XrefRangeEnd = 479497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Il2CppReferenceArray<IPAddress>> GetHostAddressesAsync(string hostNameOrAddress)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hostNameOrAddress);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_GetHostAddressesAsync_Public_Static_Task_1_Il2CppReferenceArray_1_IPAddress_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Il2CppReferenceArray<IPAddress>>>(intPtr3) : null;
			}
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x0000D2A6 File Offset: 0x0000B4A6
		public Dns(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001875 RID: 6261
		private static readonly IntPtr NativeMethodInfoPtr_BeginGetHostAddresses_Public_Static_IAsyncResult_String_AsyncCallback_Object_0;

		// Token: 0x04001876 RID: 6262
		private static readonly IntPtr NativeMethodInfoPtr_EndGetHostAddresses_Public_Static_Il2CppReferenceArray_1_IPAddress_IAsyncResult_0;

		// Token: 0x04001877 RID: 6263
		private static readonly IntPtr NativeMethodInfoPtr_GetHostByName_icall_Private_Static_Boolean_String_byref_String_byref_Il2CppStringArray_byref_Il2CppStringArray_Int32_0;

		// Token: 0x04001878 RID: 6264
		private static readonly IntPtr NativeMethodInfoPtr_GetHostByAddr_icall_Private_Static_Boolean_String_byref_String_byref_Il2CppStringArray_byref_Il2CppStringArray_Int32_0;

		// Token: 0x04001879 RID: 6265
		private static readonly IntPtr NativeMethodInfoPtr_GetHostName_icall_Private_Static_Boolean_byref_String_0;

		// Token: 0x0400187A RID: 6266
		private static readonly IntPtr NativeMethodInfoPtr_Error_11001_Private_Static_Void_String_0;

		// Token: 0x0400187B RID: 6267
		private static readonly IntPtr NativeMethodInfoPtr_hostent_to_IPHostEntry_Private_Static_IPHostEntry_String_String_Il2CppStringArray_Il2CppStringArray_0;

		// Token: 0x0400187C RID: 6268
		private static readonly IntPtr NativeMethodInfoPtr_GetHostByAddressFromString_Private_Static_IPHostEntry_String_Boolean_0;

		// Token: 0x0400187D RID: 6269
		private static readonly IntPtr NativeMethodInfoPtr_GetHostEntry_Public_Static_IPHostEntry_String_0;

		// Token: 0x0400187E RID: 6270
		private static readonly IntPtr NativeMethodInfoPtr_GetHostEntry_Public_Static_IPHostEntry_IPAddress_0;

		// Token: 0x0400187F RID: 6271
		private static readonly IntPtr NativeMethodInfoPtr_GetHostAddresses_Public_Static_Il2CppReferenceArray_1_IPAddress_String_0;

		// Token: 0x04001880 RID: 6272
		private static readonly IntPtr NativeMethodInfoPtr_GetHostByName_Public_Static_IPHostEntry_String_0;

		// Token: 0x04001881 RID: 6273
		private static readonly IntPtr NativeMethodInfoPtr_GetHostName_Public_Static_String_0;

		// Token: 0x04001882 RID: 6274
		private static readonly IntPtr NativeMethodInfoPtr_GetHostAddressesAsync_Public_Static_Task_1_Il2CppReferenceArray_1_IPAddress_String_0;

		// Token: 0x02000335 RID: 821
		public sealed class GetHostAddressesCallback : MulticastDelegate
		{
			// Token: 0x06002F84 RID: 12164 RVA: 0x000CEBD8 File Offset: 0x000CCDD8
			// Note: this type is marked as 'beforefieldinit'.
			static GetHostAddressesCallback()
			{
				Il2CppClassPointerStore<Dns.GetHostAddressesCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dns>.NativeClassPtr, "GetHostAddressesCallback");
				Dns.GetHostAddressesCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns.GetHostAddressesCallback>.NativeClassPtr, 100668022);
				Dns.GetHostAddressesCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppReferenceArray_1_IPAddress_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns.GetHostAddressesCallback>.NativeClassPtr, 100668023);
				Dns.GetHostAddressesCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns.GetHostAddressesCallback>.NativeClassPtr, 100668024);
				Dns.GetHostAddressesCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppReferenceArray_1_IPAddress_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns.GetHostAddressesCallback>.NativeClassPtr, 100668025);
			}

			// Token: 0x06002F85 RID: 12165 RVA: 0x000CEC4C File Offset: 0x000CCE4C
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 427006, RefRangeEnd = 427011, XrefRangeStart = 427006, XrefRangeEnd = 427011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetHostAddressesCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dns.GetHostAddressesCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.GetHostAddressesCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F86 RID: 12166 RVA: 0x000CECA8 File Offset: 0x000CCEA8
			[CallerCount(0)]
			public unsafe Il2CppReferenceArray<IPAddress> Invoke(string hostName)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(hostName);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.GetHostAddressesCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppReferenceArray_1_IPAddress_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr3) : null;
				}
			}

			// Token: 0x06002F87 RID: 12167 RVA: 0x000CECF8 File Offset: 0x000CCEF8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 479320, RefRangeEnd = 479322, XrefRangeStart = 479319, XrefRangeEnd = 479320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string hostName, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(hostName);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.GetHostAddressesCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002F88 RID: 12168 RVA: 0x000CED6C File Offset: 0x000CCF6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<IPAddress> EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.GetHostAddressesCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppReferenceArray_1_IPAddress_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr3) : null;
				}
			}

			// Token: 0x06002F89 RID: 12169 RVA: 0x000155CC File Offset: 0x000137CC
			public GetHostAddressesCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F8A RID: 12170 RVA: 0x000155D5 File Offset: 0x000137D5
			public static implicit operator Dns.GetHostAddressesCallback(Func<string, Il2CppReferenceArray<IPAddress>> A_0)
			{
				return DelegateSupport.ConvertDelegate<Dns.GetHostAddressesCallback>(A_0);
			}

			// Token: 0x06002F8B RID: 12171 RVA: 0x000155DD File Offset: 0x000137DD
			public static Dns.GetHostAddressesCallback operator +(Dns.GetHostAddressesCallback A_0, Dns.GetHostAddressesCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Dns.GetHostAddressesCallback>();
			}

			// Token: 0x06002F8C RID: 12172 RVA: 0x000155EB File Offset: 0x000137EB
			public static Dns.GetHostAddressesCallback operator -(Dns.GetHostAddressesCallback A_0, Dns.GetHostAddressesCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Dns.GetHostAddressesCallback>();
				}
				return delegate2;
			}

			// Token: 0x0400252F RID: 9519
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002530 RID: 9520
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppReferenceArray_1_IPAddress_String_0;

			// Token: 0x04002531 RID: 9521
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0;

			// Token: 0x04002532 RID: 9522
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppReferenceArray_1_IPAddress_IAsyncResult_0;
		}
	}
}
