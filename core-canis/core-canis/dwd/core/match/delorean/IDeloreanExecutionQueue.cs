using System;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.match.delorean
{
	// Token: 0x02000166 RID: 358
	public class IDeloreanExecutionQueue : Il2CppObjectBase
	{
		// Token: 0x060014E9 RID: 5353 RVA: 0x00067DE8 File Offset: 0x00065FE8
		// Note: this type is marked as 'beforefieldinit'.
		static IDeloreanExecutionQueue()
		{
			Il2CppClassPointerStore<IDeloreanExecutionQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.delorean", "IDeloreanExecutionQueue");
			IDeloreanExecutionQueue.NativeMethodInfoPtr_get_Blocking_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDeloreanExecutionQueue>.NativeClassPtr, 100666452);
			IDeloreanExecutionQueue.NativeMethodInfoPtr_Enqueue_Public_Abstract_Virtual_New_Void_IGameMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDeloreanExecutionQueue>.NativeClassPtr, 100666453);
			IDeloreanExecutionQueue.NativeMethodInfoPtr_Enqueue_Public_Abstract_Virtual_New_Void_IGameMessage_byref_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDeloreanExecutionQueue>.NativeClassPtr, 100666454);
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x060014EA RID: 5354 RVA: 0x00067E4C File Offset: 0x0006604C
		public unsafe virtual bool Blocking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDeloreanExecutionQueue.NativeMethodInfoPtr_get_Blocking_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x00067E94 File Offset: 0x00066094
		[CallerCount(0)]
		public unsafe virtual void Enqueue(IGameMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDeloreanExecutionQueue.NativeMethodInfoPtr_Enqueue_Public_Abstract_Virtual_New_Void_IGameMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x00067EE4 File Offset: 0x000660E4
		[CallerCount(0)]
		public unsafe virtual void Enqueue(IGameMessage message, out ErrorInfo error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDeloreanExecutionQueue.NativeMethodInfoPtr_Enqueue_Public_Abstract_Virtual_New_Void_IGameMessage_byref_ErrorInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			error = ((intPtr4 == 0) ? null : new ErrorInfo(intPtr4));
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x00009430 File Offset: 0x00007630
		public IDeloreanExecutionQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EEF RID: 3823
		private static readonly IntPtr NativeMethodInfoPtr_get_Blocking_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000EF0 RID: 3824
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Abstract_Virtual_New_Void_IGameMessage_0;

		// Token: 0x04000EF1 RID: 3825
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Abstract_Virtual_New_Void_IGameMessage_byref_ErrorInfo_0;
	}
}
