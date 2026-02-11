using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppSystem.Net.Security
{
	// Token: 0x02000268 RID: 616
	public sealed class ServerCertSelectionCallback : MulticastDelegate
	{
		// Token: 0x060028E4 RID: 10468 RVA: 0x000B9E94 File Offset: 0x000B8094
		// Note: this type is marked as 'beforefieldinit'.
		static ServerCertSelectionCallback()
		{
			Il2CppClassPointerStore<ServerCertSelectionCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Security", "ServerCertSelectionCallback");
			ServerCertSelectionCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerCertSelectionCallback>.NativeClassPtr, 100669393);
			ServerCertSelectionCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_X509Certificate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerCertSelectionCallback>.NativeClassPtr, 100669394);
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x000B9EE4 File Offset: 0x000B80E4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 427006, RefRangeEnd = 427011, XrefRangeStart = 427006, XrefRangeEnd = 427011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerCertSelectionCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerCertSelectionCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerCertSelectionCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x000B9F40 File Offset: 0x000B8140
		[CallerCount(0)]
		public unsafe X509Certificate Invoke(string hostName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hostName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerCertSelectionCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_X509Certificate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x000119CA File Offset: 0x0000FBCA
		public ServerCertSelectionCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x000119D3 File Offset: 0x0000FBD3
		public static implicit operator ServerCertSelectionCallback(Func<string, X509Certificate> A_0)
		{
			return DelegateSupport.ConvertDelegate<ServerCertSelectionCallback>(A_0);
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x000119DB File Offset: 0x0000FBDB
		public static ServerCertSelectionCallback operator +(ServerCertSelectionCallback A_0, ServerCertSelectionCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ServerCertSelectionCallback>();
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x000119E9 File Offset: 0x0000FBE9
		public static ServerCertSelectionCallback operator -(ServerCertSelectionCallback A_0, ServerCertSelectionCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ServerCertSelectionCallback>();
			}
			return delegate2;
		}

		// Token: 0x04002085 RID: 8325
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04002086 RID: 8326
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_X509Certificate_String_0;
	}
}
