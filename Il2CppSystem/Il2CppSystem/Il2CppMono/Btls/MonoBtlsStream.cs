using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Net.Security;
using Il2CppMono.Security.Interface;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Security;

namespace Il2CppMono.Btls
{
	// Token: 0x02000039 RID: 57
	public class MonoBtlsStream : MobileAuthenticatedStream
	{
		// Token: 0x06000394 RID: 916 RVA: 0x000295B8 File Offset: 0x000277B8
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBtlsStream()
		{
			Il2CppClassPointerStore<MonoBtlsStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsStream>.NativeClassPtr);
			MonoBtlsStream.NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_SslStream_MonoTlsSettings_MobileTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsStream>.NativeClassPtr, 100663939);
			MonoBtlsStream.NativeMethodInfoPtr_CreateContext_Protected_Virtual_MobileTlsContext_MonoSslAuthenticationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsStream>.NativeClassPtr, 100663940);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00029610 File Offset: 0x00027810
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431345, RefRangeEnd = 431346, XrefRangeStart = 431341, XrefRangeEnd = 431345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsStream(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveInnerStreamOpen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsStream.NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_SslStream_MonoTlsSettings_MobileTlsProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x000296A4 File Offset: 0x000278A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431346, XrefRangeEnd = 431350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MobileTlsContext CreateContext(MonoSslAuthenticationOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsStream.NativeMethodInfoPtr_CreateContext_Protected_Virtual_MobileTlsContext_MonoSslAuthenticationOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MobileTlsContext>(intPtr3) : null;
			}
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00003318 File Offset: 0x00001518
		public MonoBtlsStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_SslStream_MonoTlsSettings_MobileTlsProvider_0;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_CreateContext_Protected_Virtual_MobileTlsContext_MonoSslAuthenticationOptions_0;
	}
}
