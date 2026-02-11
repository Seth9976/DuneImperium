using System;
using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Logging;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
	// Token: 0x0200001A RID: 26
	public class PromptCodeReceiver : Object
	{
		// Token: 0x06000132 RID: 306 RVA: 0x0000B0D0 File Offset: 0x000092D0
		// Note: this type is marked as 'beforefieldinit'.
		static PromptCodeReceiver()
		{
			Il2CppClassPointerStore<PromptCodeReceiver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2", "PromptCodeReceiver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PromptCodeReceiver>.NativeClassPtr);
			PromptCodeReceiver.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptCodeReceiver>.NativeClassPtr, "Logger");
			PromptCodeReceiver.NativeMethodInfoPtr_get_RedirectUri_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptCodeReceiver>.NativeClassPtr, 100663603);
			PromptCodeReceiver.NativeMethodInfoPtr_ReceiveCodeAsync_Public_Virtual_Final_New_Task_1_AuthorizationCodeResponseUrl_AuthorizationCodeRequestUrl_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptCodeReceiver>.NativeClassPtr, 100663604);
			PromptCodeReceiver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptCodeReceiver>.NativeClassPtr, 100663605);
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0000B150 File Offset: 0x00009350
		public unsafe virtual string RedirectUri
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155148, XrefRangeEnd = 1155150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptCodeReceiver.NativeMethodInfoPtr_get_RedirectUri_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000B188 File Offset: 0x00009388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155150, XrefRangeEnd = 1155215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<AuthorizationCodeResponseUrl> ReceiveCodeAsync(AuthorizationCodeRequestUrl url, CancellationToken taskCancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(taskCancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptCodeReceiver.NativeMethodInfoPtr_ReceiveCodeAsync_Public_Virtual_Final_New_Task_1_AuthorizationCodeResponseUrl_AuthorizationCodeRequestUrl_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<AuthorizationCodeResponseUrl>>(intPtr3) : null;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000B1F0 File Offset: 0x000093F0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PromptCodeReceiver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PromptCodeReceiver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptCodeReceiver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002862 File Offset: 0x00000A62
		public PromptCodeReceiver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0000B22C File Offset: 0x0000942C
		// (set) Token: 0x06000138 RID: 312 RVA: 0x0000286B File Offset: 0x00000A6B
		public unsafe static ILogger Logger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PromptCodeReceiver.NativeFieldInfoPtr_Logger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PromptCodeReceiver.NativeFieldInfoPtr_Logger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeFieldInfoPtr_Logger;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_get_RedirectUri_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveCodeAsync_Public_Virtual_Final_New_Task_1_AuthorizationCodeResponseUrl_AuthorizationCodeRequestUrl_CancellationToken_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
