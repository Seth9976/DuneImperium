using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Net.Security;
using Il2CppMono.Security.Interface;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Security;

namespace Il2CppMono.Unity
{
	// Token: 0x0200000E RID: 14
	public class UnityTlsStream : MobileAuthenticatedStream
	{
		// Token: 0x0600009B RID: 155 RVA: 0x0001CEFC File Offset: 0x0001B0FC
		// Note: this type is marked as 'beforefieldinit'.
		static UnityTlsStream()
		{
			Il2CppClassPointerStore<UnityTlsStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Unity", "UnityTlsStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTlsStream>.NativeClassPtr);
			UnityTlsStream.NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_SslStream_MonoTlsSettings_MobileTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsStream>.NativeClassPtr, 100663451);
			UnityTlsStream.NativeMethodInfoPtr_CreateContext_Protected_Virtual_MobileTlsContext_MonoSslAuthenticationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsStream>.NativeClassPtr, 100663452);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0001CF54 File Offset: 0x0001B154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427496, XrefRangeEnd = 427521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityTlsStream(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTlsStream>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsStream.NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_SslStream_MonoTlsSettings_MobileTlsProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0001CFE8 File Offset: 0x0001B1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427521, XrefRangeEnd = 427525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MobileTlsContext CreateContext(MonoSslAuthenticationOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsStream.NativeMethodInfoPtr_CreateContext_Protected_Virtual_MobileTlsContext_MonoSslAuthenticationOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MobileTlsContext>(intPtr3) : null;
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000023CC File Offset: 0x000005CC
		public UnityTlsStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_SslStream_MonoTlsSettings_MobileTlsProvider_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_CreateContext_Protected_Virtual_MobileTlsContext_MonoSslAuthenticationOptions_0;
	}
}
