using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Http
{
	// Token: 0x02000033 RID: 51
	public class IHttpExecuteInterceptor : Il2CppObjectBase
	{
		// Token: 0x06000244 RID: 580 RVA: 0x00002E81 File Offset: 0x00001081
		// Note: this type is marked as 'beforefieldinit'.
		static IHttpExecuteInterceptor()
		{
			Il2CppClassPointerStore<IHttpExecuteInterceptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Http", "IHttpExecuteInterceptor");
			IHttpExecuteInterceptor.NativeMethodInfoPtr_InterceptAsync_Public_Abstract_Virtual_New_Task_HttpRequestMessage_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHttpExecuteInterceptor>.NativeClassPtr, 100663644);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000C620 File Offset: 0x0000A820
		[CallerCount(0)]
		public unsafe virtual Task InterceptAsync(HttpRequestMessage request, CancellationToken cancellationToken)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHttpExecuteInterceptor.NativeMethodInfoPtr_InterceptAsync_Public_Abstract_Virtual_New_Task_HttpRequestMessage_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002EB0 File Offset: 0x000010B0
		public IHttpExecuteInterceptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_InterceptAsync_Public_Abstract_Virtual_New_Task_HttpRequestMessage_CancellationToken_0;
	}
}
