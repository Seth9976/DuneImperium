using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Http
{
	// Token: 0x02000035 RID: 53
	public class IHttpUnsuccessfulResponseHandler : Il2CppObjectBase
	{
		// Token: 0x0600025F RID: 607 RVA: 0x00002F64 File Offset: 0x00001164
		// Note: this type is marked as 'beforefieldinit'.
		static IHttpUnsuccessfulResponseHandler()
		{
			Il2CppClassPointerStore<IHttpUnsuccessfulResponseHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Http", "IHttpUnsuccessfulResponseHandler");
			IHttpUnsuccessfulResponseHandler.NativeMethodInfoPtr_HandleResponseAsync_Public_Abstract_Virtual_New_Task_1_Boolean_HandleUnsuccessfulResponseArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHttpUnsuccessfulResponseHandler>.NativeClassPtr, 100663657);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000CBF0 File Offset: 0x0000ADF0
		[CallerCount(0)]
		public unsafe virtual Task<bool> HandleResponseAsync(HandleUnsuccessfulResponseArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHttpUnsuccessfulResponseHandler.NativeMethodInfoPtr_HandleResponseAsync_Public_Abstract_Virtual_New_Task_1_Boolean_HandleUnsuccessfulResponseArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002F93 File Offset: 0x00001193
		public IHttpUnsuccessfulResponseHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_HandleResponseAsync_Public_Abstract_Virtual_New_Task_1_Boolean_HandleUnsuccessfulResponseArgs_0;
	}
}
