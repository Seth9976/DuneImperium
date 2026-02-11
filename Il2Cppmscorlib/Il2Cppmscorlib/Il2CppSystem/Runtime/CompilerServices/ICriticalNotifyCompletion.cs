using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003B9 RID: 953
	public class ICriticalNotifyCompletion : Il2CppObjectBase
	{
		// Token: 0x0600391E RID: 14622 RVA: 0x00015123 File Offset: 0x00013323
		// Note: this type is marked as 'beforefieldinit'.
		static ICriticalNotifyCompletion()
		{
			Il2CppClassPointerStore<ICriticalNotifyCompletion>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "ICriticalNotifyCompletion");
			ICriticalNotifyCompletion.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Abstract_Virtual_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICriticalNotifyCompletion>.NativeClassPtr, 100671826);
		}

		// Token: 0x0600391F RID: 14623 RVA: 0x00115098 File Offset: 0x00113298
		[CallerCount(0)]
		public unsafe virtual void UnsafeOnCompleted(Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICriticalNotifyCompletion.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Abstract_Virtual_New_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003920 RID: 14624 RVA: 0x00015152 File Offset: 0x00013352
		public ICriticalNotifyCompletion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E83 RID: 11907
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeOnCompleted_Public_Abstract_Virtual_New_Void_Action_0;
	}
}
