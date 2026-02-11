using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003B7 RID: 951
	public class IAsyncStateMachine : Il2CppObjectBase
	{
		// Token: 0x06003917 RID: 14615 RVA: 0x00114F6C File Offset: 0x0011316C
		// Note: this type is marked as 'beforefieldinit'.
		static IAsyncStateMachine()
		{
			Il2CppClassPointerStore<IAsyncStateMachine>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "IAsyncStateMachine");
			IAsyncStateMachine.NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncStateMachine>.NativeClassPtr, 100671823);
			IAsyncStateMachine.NativeMethodInfoPtr_SetStateMachine_Public_Abstract_Virtual_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncStateMachine>.NativeClassPtr, 100671824);
		}

		// Token: 0x06003918 RID: 14616 RVA: 0x00114FBC File Offset: 0x001131BC
		[CallerCount(0)]
		public unsafe virtual void MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncStateMachine.NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003919 RID: 14617 RVA: 0x00114FF8 File Offset: 0x001131F8
		[CallerCount(0)]
		public unsafe virtual void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncStateMachine.NativeMethodInfoPtr_SetStateMachine_Public_Abstract_Virtual_New_Void_IAsyncStateMachine_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600391A RID: 14618 RVA: 0x000150E2 File Offset: 0x000132E2
		public IAsyncStateMachine(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E80 RID: 11904
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04002E81 RID: 11905
		private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Public_Abstract_Virtual_New_Void_IAsyncStateMachine_0;
	}
}
