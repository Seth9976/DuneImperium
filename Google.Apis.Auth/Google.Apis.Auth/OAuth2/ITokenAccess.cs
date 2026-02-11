using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
	// Token: 0x02000015 RID: 21
	public class ITokenAccess : Il2CppObjectBase
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x000025D2 File Offset: 0x000007D2
		// Note: this type is marked as 'beforefieldinit'.
		static ITokenAccess()
		{
			Il2CppClassPointerStore<ITokenAccess>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2", "ITokenAccess");
			ITokenAccess.NativeMethodInfoPtr_GetAccessTokenForRequestAsync_Public_Abstract_Virtual_New_Task_1_String_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITokenAccess>.NativeClassPtr, 100663516);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000A148 File Offset: 0x00008348
		[CallerCount(0)]
		public unsafe virtual Task<string> GetAccessTokenForRequestAsync(string authUri = null, CancellationToken cancellationToken = null)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITokenAccess.NativeMethodInfoPtr_GetAccessTokenForRequestAsync_Public_Abstract_Virtual_New_Task_1_String_String_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<string>>(intPtr3) : null;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002601 File Offset: 0x00000801
		public ITokenAccess(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_GetAccessTokenForRequestAsync_Public_Abstract_Virtual_New_Task_1_String_String_CancellationToken_0;
	}
}
