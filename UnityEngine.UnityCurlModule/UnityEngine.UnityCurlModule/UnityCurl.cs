using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Unity.Curl
{
	// Token: 0x02000004 RID: 4
	public static class UnityCurl
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		public static IntPtr CreateMultiHandle()
		{
			return UnityCurl.CreateMultiHandleDelegateField();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000205C File Offset: 0x0000025C
		public static void DestroyMultiHandle(IntPtr handle)
		{
			UnityCurl.DestroyMultiHandleDelegateField(handle);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002069 File Offset: 0x00000269
		public unsafe static IntPtr CreateEasyHandle(byte* method, byte* url, out uint curlMethod)
		{
			return UnityCurl.CreateEasyHandleDelegateField(method, url, out curlMethod);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002078 File Offset: 0x00000278
		public static void SetupEasyHandle(IntPtr handle, uint curlMethod, IntPtr headers, ulong contentLen, uint flags)
		{
			UnityCurl.SetupEasyHandleDelegateField(handle, curlMethod, headers, contentLen, flags);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000208A File Offset: 0x0000028A
		public static void DestroyEasyHandle(IntPtr handle)
		{
			UnityCurl.DestroyEasyHandleDelegateField(handle);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002097 File Offset: 0x00000297
		public static void QueueRequest(IntPtr multiHandle, IntPtr easyHandle)
		{
			UnityCurl.QueueRequestDelegateField(multiHandle, easyHandle);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020A5 File Offset: 0x000002A5
		public unsafe static IntPtr AppendHeader(IntPtr headerList, byte* header)
		{
			return UnityCurl.AppendHeaderDelegateField(headerList, header);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020B3 File Offset: 0x000002B3
		public static void FreeHeaderList(IntPtr headerList)
		{
			UnityCurl.FreeHeaderListDelegateField(headerList);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020C0 File Offset: 0x000002C0
		public static int GetRequestErrorCode(IntPtr request)
		{
			return UnityCurl.GetRequestErrorCodeDelegateField(request);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020CD File Offset: 0x000002CD
		public static int GetRequestStatus(IntPtr request)
		{
			return UnityCurl.GetRequestStatusDelegateField(request);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020DA File Offset: 0x000002DA
		public static uint GetRequestStatusCode(IntPtr request)
		{
			return UnityCurl.GetRequestStatusCodeDelegateField(request);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020E7 File Offset: 0x000002E7
		public static void GetDownloadSize(IntPtr request, out ulong downloaded, out ulong expected)
		{
			UnityCurl.GetDownloadSizeDelegateField(request, out downloaded, out expected);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020F6 File Offset: 0x000002F6
		public unsafe static byte* GetResponseHeader(IntPtr request, uint index, out uint length)
		{
			return UnityCurl.GetResponseHeaderDelegateField(request, index, out length);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002105 File Offset: 0x00000305
		public unsafe static byte* GetMoreBody(IntPtr handle, out int length)
		{
			return UnityCurl.GetMoreBodyDelegateField(handle, out length);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002113 File Offset: 0x00000313
		public unsafe static void SendMoreBody(IntPtr handle, byte* chunk, uint length, BufferOwnership ownership)
		{
			UnityCurl.SendMoreBody(handle, chunk, length, (int)ownership);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002120 File Offset: 0x00000320
		public unsafe static void SendMoreBody(IntPtr handle, byte* chunk, uint length, int ownership)
		{
			UnityCurl.SendMoreBodyDelegateField(handle, chunk, length, ownership);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002130 File Offset: 0x00000330
		public static void AbortRequest(IntPtr handle)
		{
			UnityCurl.AbortRequestDelegateField(handle);
		}

		// Token: 0x0400000A RID: 10
		private static readonly UnityCurl.CreateMultiHandleDelegate CreateMultiHandleDelegateField = IL2CPP.ResolveICall<UnityCurl.CreateMultiHandleDelegate>("Unity.Curl.UnityCurl::CreateMultiHandle");

		// Token: 0x0400000B RID: 11
		private static readonly UnityCurl.DestroyMultiHandleDelegate DestroyMultiHandleDelegateField = IL2CPP.ResolveICall<UnityCurl.DestroyMultiHandleDelegate>("Unity.Curl.UnityCurl::DestroyMultiHandle");

		// Token: 0x0400000C RID: 12
		private static readonly UnityCurl.CreateEasyHandleDelegate CreateEasyHandleDelegateField = IL2CPP.ResolveICall<UnityCurl.CreateEasyHandleDelegate>("Unity.Curl.UnityCurl::CreateEasyHandle");

		// Token: 0x0400000D RID: 13
		private static readonly UnityCurl.SetupEasyHandleDelegate SetupEasyHandleDelegateField = IL2CPP.ResolveICall<UnityCurl.SetupEasyHandleDelegate>("Unity.Curl.UnityCurl::SetupEasyHandle");

		// Token: 0x0400000E RID: 14
		private static readonly UnityCurl.DestroyEasyHandleDelegate DestroyEasyHandleDelegateField = IL2CPP.ResolveICall<UnityCurl.DestroyEasyHandleDelegate>("Unity.Curl.UnityCurl::DestroyEasyHandle");

		// Token: 0x0400000F RID: 15
		private static readonly UnityCurl.QueueRequestDelegate QueueRequestDelegateField = IL2CPP.ResolveICall<UnityCurl.QueueRequestDelegate>("Unity.Curl.UnityCurl::QueueRequest");

		// Token: 0x04000010 RID: 16
		private static readonly UnityCurl.AppendHeaderDelegate AppendHeaderDelegateField = IL2CPP.ResolveICall<UnityCurl.AppendHeaderDelegate>("Unity.Curl.UnityCurl::AppendHeader");

		// Token: 0x04000011 RID: 17
		private static readonly UnityCurl.FreeHeaderListDelegate FreeHeaderListDelegateField = IL2CPP.ResolveICall<UnityCurl.FreeHeaderListDelegate>("Unity.Curl.UnityCurl::FreeHeaderList");

		// Token: 0x04000012 RID: 18
		private static readonly UnityCurl.GetRequestErrorCodeDelegate GetRequestErrorCodeDelegateField = IL2CPP.ResolveICall<UnityCurl.GetRequestErrorCodeDelegate>("Unity.Curl.UnityCurl::GetRequestErrorCode");

		// Token: 0x04000013 RID: 19
		private static readonly UnityCurl.GetRequestStatusDelegate GetRequestStatusDelegateField = IL2CPP.ResolveICall<UnityCurl.GetRequestStatusDelegate>("Unity.Curl.UnityCurl::GetRequestStatus");

		// Token: 0x04000014 RID: 20
		private static readonly UnityCurl.GetRequestStatusCodeDelegate GetRequestStatusCodeDelegateField = IL2CPP.ResolveICall<UnityCurl.GetRequestStatusCodeDelegate>("Unity.Curl.UnityCurl::GetRequestStatusCode");

		// Token: 0x04000015 RID: 21
		private static readonly UnityCurl.GetDownloadSizeDelegate GetDownloadSizeDelegateField = IL2CPP.ResolveICall<UnityCurl.GetDownloadSizeDelegate>("Unity.Curl.UnityCurl::GetDownloadSize");

		// Token: 0x04000016 RID: 22
		private static readonly UnityCurl.GetResponseHeaderDelegate GetResponseHeaderDelegateField = IL2CPP.ResolveICall<UnityCurl.GetResponseHeaderDelegate>("Unity.Curl.UnityCurl::GetResponseHeader");

		// Token: 0x04000017 RID: 23
		private static readonly UnityCurl.GetMoreBodyDelegate GetMoreBodyDelegateField = IL2CPP.ResolveICall<UnityCurl.GetMoreBodyDelegate>("Unity.Curl.UnityCurl::GetMoreBody");

		// Token: 0x04000018 RID: 24
		private static readonly UnityCurl.SendMoreBodyDelegate SendMoreBodyDelegateField = IL2CPP.ResolveICall<UnityCurl.SendMoreBodyDelegate>("Unity.Curl.UnityCurl::SendMoreBody");

		// Token: 0x04000019 RID: 25
		private static readonly UnityCurl.AbortRequestDelegate AbortRequestDelegateField = IL2CPP.ResolveICall<UnityCurl.AbortRequestDelegate>("Unity.Curl.UnityCurl::AbortRequest");

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x06000014 RID: 20
		private delegate IntPtr CreateMultiHandleDelegate();

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x06000016 RID: 22
		private delegate void DestroyMultiHandleDelegate(IntPtr handle);

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x06000018 RID: 24
		private delegate IntPtr CreateEasyHandleDelegate(IntPtr method, IntPtr url, [Out] IntPtr curlMethod);

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x0600001A RID: 26
		private delegate void SetupEasyHandleDelegate(IntPtr handle, uint curlMethod, IntPtr headers, ulong contentLen, uint flags);

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x0600001C RID: 28
		private delegate void DestroyEasyHandleDelegate(IntPtr handle);

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x0600001E RID: 30
		private delegate void QueueRequestDelegate(IntPtr multiHandle, IntPtr easyHandle);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x06000020 RID: 32
		private delegate IntPtr AppendHeaderDelegate(IntPtr headerList, IntPtr header);

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x06000022 RID: 34
		private delegate void FreeHeaderListDelegate(IntPtr headerList);

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x06000024 RID: 36
		private delegate int GetRequestErrorCodeDelegate(IntPtr request);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x06000026 RID: 38
		private delegate int GetRequestStatusDelegate(IntPtr request);

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x06000028 RID: 40
		private delegate uint GetRequestStatusCodeDelegate(IntPtr request);

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x0600002A RID: 42
		private delegate void GetDownloadSizeDelegate(IntPtr request, [Out] IntPtr downloaded, [Out] IntPtr expected);

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x0600002C RID: 44
		private delegate IntPtr GetResponseHeaderDelegate(IntPtr request, uint index, [Out] IntPtr length);

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x0600002E RID: 46
		private delegate IntPtr GetMoreBodyDelegate(IntPtr handle, [Out] IntPtr length);

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x06000030 RID: 48
		private delegate void SendMoreBodyDelegate(IntPtr handle, IntPtr chunk, uint length, int ownership);

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x06000032 RID: 50
		private delegate void AbortRequestDelegate(IntPtr handle);
	}
}
