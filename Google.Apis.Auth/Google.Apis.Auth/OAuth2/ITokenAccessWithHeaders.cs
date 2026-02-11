using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
	// Token: 0x02000016 RID: 22
	public class ITokenAccessWithHeaders : Il2CppObjectBase
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x0000260A File Offset: 0x0000080A
		// Note: this type is marked as 'beforefieldinit'.
		static ITokenAccessWithHeaders()
		{
			Il2CppClassPointerStore<ITokenAccessWithHeaders>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2", "ITokenAccessWithHeaders");
			ITokenAccessWithHeaders.NativeMethodInfoPtr_GetAccessTokenWithHeadersForRequestAsync_Public_Abstract_Virtual_New_Task_1_AccessTokenWithHeaders_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITokenAccessWithHeaders>.NativeClassPtr, 100663517);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000A1BC File Offset: 0x000083BC
		[CallerCount(0)]
		public unsafe virtual Task<AccessTokenWithHeaders> GetAccessTokenWithHeadersForRequestAsync(string authUri = null, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(authUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITokenAccessWithHeaders.NativeMethodInfoPtr_GetAccessTokenWithHeadersForRequestAsync_Public_Abstract_Virtual_New_Task_1_AccessTokenWithHeaders_String_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<AccessTokenWithHeaders>>(intPtr3) : null;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002639 File Offset: 0x00000839
		public ITokenAccessWithHeaders(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_GetAccessTokenWithHeadersForRequestAsync_Public_Abstract_Virtual_New_Task_1_AccessTokenWithHeaders_String_CancellationToken_0;
	}
}
