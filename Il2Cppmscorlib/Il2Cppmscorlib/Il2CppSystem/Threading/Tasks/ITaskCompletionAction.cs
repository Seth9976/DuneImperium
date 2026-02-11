using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001DB RID: 475
	public class ITaskCompletionAction : Il2CppObjectBase
	{
		// Token: 0x06001F62 RID: 8034 RVA: 0x000B4EF0 File Offset: 0x000B30F0
		// Note: this type is marked as 'beforefieldinit'.
		static ITaskCompletionAction()
		{
			Il2CppClassPointerStore<ITaskCompletionAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "ITaskCompletionAction");
			ITaskCompletionAction.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITaskCompletionAction>.NativeClassPtr, 100668641);
			ITaskCompletionAction.NativeMethodInfoPtr_get_InvokeMayRunArbitraryCode_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITaskCompletionAction>.NativeClassPtr, 100668642);
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x000B4F40 File Offset: 0x000B3140
		[CallerCount(0)]
		public unsafe virtual void Invoke(Task completingTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(completingTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITaskCompletionAction.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_Task_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001F64 RID: 8036 RVA: 0x000B4F90 File Offset: 0x000B3190
		public unsafe virtual bool InvokeMayRunArbitraryCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITaskCompletionAction.NativeMethodInfoPtr_get_InvokeMayRunArbitraryCode_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x0000A2F0 File Offset: 0x000084F0
		public ITaskCompletionAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C0A RID: 7178
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_Task_0;

		// Token: 0x04001C0B RID: 7179
		private static readonly IntPtr NativeMethodInfoPtr_get_InvokeMayRunArbitraryCode_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
