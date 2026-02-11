using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Http
{
	// Token: 0x02000032 RID: 50
	public class IHttpExceptionHandler : Il2CppObjectBase
	{
		// Token: 0x06000241 RID: 577 RVA: 0x00002E49 File Offset: 0x00001049
		// Note: this type is marked as 'beforefieldinit'.
		static IHttpExceptionHandler()
		{
			Il2CppClassPointerStore<IHttpExceptionHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Http", "IHttpExceptionHandler");
			IHttpExceptionHandler.NativeMethodInfoPtr_HandleExceptionAsync_Public_Abstract_Virtual_New_Task_1_Boolean_HandleExceptionArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHttpExceptionHandler>.NativeClassPtr, 100663643);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000C5C4 File Offset: 0x0000A7C4
		[CallerCount(0)]
		public unsafe virtual Task<bool> HandleExceptionAsync(HandleExceptionArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHttpExceptionHandler.NativeMethodInfoPtr_HandleExceptionAsync_Public_Abstract_Virtual_New_Task_1_Boolean_HandleExceptionArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002E78 File Offset: 0x00001078
		public IHttpExceptionHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_HandleExceptionAsync_Public_Abstract_Virtual_New_Task_1_Boolean_HandleExceptionArgs_0;
	}
}
