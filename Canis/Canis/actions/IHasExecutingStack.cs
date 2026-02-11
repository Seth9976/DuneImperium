using System;
using Canis.hasExecutionStack;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x0200017E RID: 382
	public class IHasExecutingStack : Il2CppObjectBase
	{
		// Token: 0x060010E5 RID: 4325 RVA: 0x0005E0F0 File Offset: 0x0005C2F0
		// Note: this type is marked as 'beforefieldinit'.
		static IHasExecutingStack()
		{
			Il2CppClassPointerStore<IHasExecutingStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "IHasExecutingStack");
			IHasExecutingStack.NativeMethodInfoPtr_get_ExecutingStack_Public_Abstract_Virtual_New_get_IHasExecutionStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasExecutingStack>.NativeClassPtr, 100666813);
			IHasExecutingStack.NativeMethodInfoPtr_set_ExecutingStack_Public_Abstract_Virtual_New_set_Void_IHasExecutionStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasExecutingStack>.NativeClassPtr, 100666814);
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x0005E140 File Offset: 0x0005C340
		// (set) Token: 0x060010E7 RID: 4327 RVA: 0x0005E18C File Offset: 0x0005C38C
		public unsafe virtual IHasExecutionStack ExecutingStack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasExecutingStack.NativeMethodInfoPtr_get_ExecutingStack_Public_Abstract_Virtual_New_get_IHasExecutionStack_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHasExecutionStack>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasExecutingStack.NativeMethodInfoPtr_set_ExecutingStack_Public_Abstract_Virtual_New_set_Void_IHasExecutionStack_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x0000878C File Offset: 0x0000698C
		public IHasExecutingStack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B1F RID: 2847
		private static readonly IntPtr NativeMethodInfoPtr_get_ExecutingStack_Public_Abstract_Virtual_New_get_IHasExecutionStack_0;

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeMethodInfoPtr_set_ExecutingStack_Public_Abstract_Virtual_New_set_Void_IHasExecutionStack_0;
	}
}
