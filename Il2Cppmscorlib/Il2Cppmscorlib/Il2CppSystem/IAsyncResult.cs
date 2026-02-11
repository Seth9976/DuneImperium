using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

namespace Il2CppSystem
{
	// Token: 0x020000A6 RID: 166
	public class IAsyncResult : Il2CppObjectBase
	{
		// Token: 0x06000B78 RID: 2936 RVA: 0x0005AC58 File Offset: 0x00058E58
		// Note: this type is marked as 'beforefieldinit'.
		static IAsyncResult()
		{
			Il2CppClassPointerStore<IAsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IAsyncResult");
			IAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncResult>.NativeClassPtr, 100665294);
			IAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Abstract_Virtual_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncResult>.NativeClassPtr, 100665295);
			IAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncResult>.NativeClassPtr, 100665296);
			IAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncResult>.NativeClassPtr, 100665297);
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x0005ACD0 File Offset: 0x00058ED0
		public unsafe virtual bool IsCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000B7A RID: 2938 RVA: 0x0005AD18 File Offset: 0x00058F18
		public unsafe virtual WaitHandle AsyncWaitHandle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Abstract_Virtual_New_get_WaitHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x0005AD64 File Offset: 0x00058F64
		public unsafe virtual Object AsyncState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000B7C RID: 2940 RVA: 0x0005ADB0 File Offset: 0x00058FB0
		public unsafe virtual bool CompletedSynchronously
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00004E33 File Offset: 0x00003033
		public IAsyncResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Abstract_Virtual_New_get_WaitHandle_0;

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncState_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedSynchronously_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
