using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x020001AD RID: 429
	public class IInterceptsHalts : Il2CppObjectBase
	{
		// Token: 0x0600126B RID: 4715 RVA: 0x00009153 File Offset: 0x00007353
		// Note: this type is marked as 'beforefieldinit'.
		static IInterceptsHalts()
		{
			Il2CppClassPointerStore<IInterceptsHalts>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "IInterceptsHalts");
			IInterceptsHalts.NativeMethodInfoPtr_Intercept_Public_Abstract_Virtual_New_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInterceptsHalts>.NativeClassPtr, 100667241);
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x00063EB8 File Offset: 0x000620B8
		[CallerCount(0)]
		public unsafe virtual Action Intercept(Action lastAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInterceptsHalts.NativeMethodInfoPtr_Intercept_Public_Abstract_Virtual_New_Action_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x00009182 File Offset: 0x00007382
		public IInterceptsHalts(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C00 RID: 3072
		private static readonly IntPtr NativeMethodInfoPtr_Intercept_Public_Abstract_Virtual_New_Action_Action_0;
	}
}
