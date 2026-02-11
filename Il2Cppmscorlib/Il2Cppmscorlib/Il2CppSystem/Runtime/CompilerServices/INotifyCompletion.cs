using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003B8 RID: 952
	public class INotifyCompletion : Il2CppObjectBase
	{
		// Token: 0x0600391B RID: 14619 RVA: 0x000150EB File Offset: 0x000132EB
		// Note: this type is marked as 'beforefieldinit'.
		static INotifyCompletion()
		{
			Il2CppClassPointerStore<INotifyCompletion>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "INotifyCompletion");
			INotifyCompletion.NativeMethodInfoPtr_OnCompleted_Public_Abstract_Virtual_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INotifyCompletion>.NativeClassPtr, 100671825);
		}

		// Token: 0x0600391C RID: 14620 RVA: 0x00115048 File Offset: 0x00113248
		[CallerCount(0)]
		public unsafe virtual void OnCompleted(Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INotifyCompletion.NativeMethodInfoPtr_OnCompleted_Public_Abstract_Virtual_New_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600391D RID: 14621 RVA: 0x0001511A File Offset: 0x0001331A
		public INotifyCompletion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E82 RID: 11906
		private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Public_Abstract_Virtual_New_Void_Action_0;
	}
}
