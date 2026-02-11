using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Requests
{
	// Token: 0x02000013 RID: 19
	public class IClientServiceRequest<TResponse> : Il2CppObjectBase
	{
		// Token: 0x06000161 RID: 353 RVA: 0x0000A538 File Offset: 0x00008738
		// Note: this type is marked as 'beforefieldinit'.
		static IClientServiceRequest()
		{
			Il2CppClassPointerStore<IClientServiceRequest<TResponse>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Google.Apis.dll", "Google.Apis.Requests", "IClientServiceRequest`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResponse>.NativeClassPtr)) })).TypeHandle.value);
			IClientServiceRequest<TResponse>.NativeMethodInfoPtr_ExecuteAsync_Public_Abstract_Virtual_New_Task_1_TResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientServiceRequest<TResponse>>.NativeClassPtr, 100663600);
			IClientServiceRequest<TResponse>.NativeMethodInfoPtr_ExecuteAsync_Public_Abstract_Virtual_New_Task_1_TResponse_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientServiceRequest<TResponse>>.NativeClassPtr, 100663601);
			IClientServiceRequest<TResponse>.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_TResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientServiceRequest<TResponse>>.NativeClassPtr, 100663602);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000A5D8 File Offset: 0x000087D8
		[CallerCount(0)]
		public unsafe virtual Task<TResponse> ExecuteAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientServiceRequest<TResponse>.NativeMethodInfoPtr_ExecuteAsync_Public_Abstract_Virtual_New_Task_1_TResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResponse>>(intPtr3) : null;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000A624 File Offset: 0x00008824
		[CallerCount(0)]
		public unsafe virtual Task<TResponse> ExecuteAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientServiceRequest<TResponse>.NativeMethodInfoPtr_ExecuteAsync_Public_Abstract_Virtual_New_Task_1_TResponse_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResponse>>(intPtr3) : null;
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000A684 File Offset: 0x00008884
		[CallerCount(0)]
		public unsafe virtual TResponse Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientServiceRequest<TResponse>.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_TResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TResponse>(intPtr, false, true);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002748 File Offset: 0x00000948
		public IClientServiceRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteAsync_Public_Abstract_Virtual_New_Task_1_TResponse_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteAsync_Public_Abstract_Virtual_New_Task_1_TResponse_CancellationToken_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_TResponse_0;
	}
}
