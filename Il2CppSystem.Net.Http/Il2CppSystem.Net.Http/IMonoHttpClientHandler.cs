using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net.Http
{
	// Token: 0x02000004 RID: 4
	public class IMonoHttpClientHandler : Il2CppObjectBase
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00004A38 File Offset: 0x00002C38
		// Note: this type is marked as 'beforefieldinit'.
		static IMonoHttpClientHandler()
		{
			Il2CppClassPointerStore<IMonoHttpClientHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http", "IMonoHttpClientHandler");
			IMonoHttpClientHandler.NativeMethodInfoPtr_get_SupportsAutomaticDecompression_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoHttpClientHandler>.NativeClassPtr, 100663317);
			IMonoHttpClientHandler.NativeMethodInfoPtr_get_SslOptions_Public_Abstract_Virtual_New_get_SslClientAuthenticationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoHttpClientHandler>.NativeClassPtr, 100663318);
			IMonoHttpClientHandler.NativeMethodInfoPtr_set_SslOptions_Public_Abstract_Virtual_New_set_Void_SslClientAuthenticationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoHttpClientHandler>.NativeClassPtr, 100663319);
			IMonoHttpClientHandler.NativeMethodInfoPtr_set_AutomaticDecompression_Public_Abstract_Virtual_New_set_Void_DecompressionMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoHttpClientHandler>.NativeClassPtr, 100663320);
			IMonoHttpClientHandler.NativeMethodInfoPtr_set_AllowAutoRedirect_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoHttpClientHandler>.NativeClassPtr, 100663321);
			IMonoHttpClientHandler.NativeMethodInfoPtr_SendAsync_Public_Abstract_Virtual_New_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoHttpClientHandler>.NativeClassPtr, 100663322);
			IMonoHttpClientHandler.NativeMethodInfoPtr_SetWebRequestTimeout_Public_Abstract_Virtual_New_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMonoHttpClientHandler>.NativeClassPtr, 100663323);
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00004AEC File Offset: 0x00002CEC
		public unsafe virtual bool SupportsAutomaticDecompression
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoHttpClientHandler.NativeMethodInfoPtr_get_SupportsAutomaticDecompression_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00004B34 File Offset: 0x00002D34
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00004B80 File Offset: 0x00002D80
		public unsafe virtual SslClientAuthenticationOptions SslOptions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoHttpClientHandler.NativeMethodInfoPtr_get_SslOptions_Public_Abstract_Virtual_New_get_SslClientAuthenticationOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SslClientAuthenticationOptions>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoHttpClientHandler.NativeMethodInfoPtr_set_SslOptions_Public_Abstract_Virtual_New_set_Void_SslClientAuthenticationOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000B RID: 11
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00004BD0 File Offset: 0x00002DD0
		public unsafe virtual DecompressionMethods AutomaticDecompression
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoHttpClientHandler.NativeMethodInfoPtr_set_AutomaticDecompression_Public_Abstract_Virtual_New_set_Void_DecompressionMethods_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00004C1C File Offset: 0x00002E1C
		public unsafe virtual bool AllowAutoRedirect
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoHttpClientHandler.NativeMethodInfoPtr_set_AllowAutoRedirect_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004C68 File Offset: 0x00002E68
		[CallerCount(0)]
		public unsafe virtual Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoHttpClientHandler.NativeMethodInfoPtr_SendAsync_Public_Abstract_Virtual_New_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<HttpResponseMessage>>(intPtr3) : null;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00004CDC File Offset: 0x00002EDC
		[CallerCount(0)]
		public unsafe virtual void SetWebRequestTimeout(TimeSpan timeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMonoHttpClientHandler.NativeMethodInfoPtr_SetWebRequestTimeout_Public_Abstract_Virtual_New_Void_TimeSpan_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000209C File Offset: 0x0000029C
		public IMonoHttpClientHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsAutomaticDecompression_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_get_SslOptions_Public_Abstract_Virtual_New_get_SslClientAuthenticationOptions_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_set_SslOptions_Public_Abstract_Virtual_New_set_Void_SslClientAuthenticationOptions_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_set_AutomaticDecompression_Public_Abstract_Virtual_New_set_Void_DecompressionMethods_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_set_AllowAutoRedirect_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_SendAsync_Public_Abstract_Virtual_New_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_SetWebRequestTimeout_Public_Abstract_Virtual_New_Void_TimeSpan_0;
	}
}
