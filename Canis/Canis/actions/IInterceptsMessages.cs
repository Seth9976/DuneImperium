using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x020001AE RID: 430
	public class IInterceptsMessages : Il2CppObjectBase
	{
		// Token: 0x0600126E RID: 4718 RVA: 0x0000918B File Offset: 0x0000738B
		// Note: this type is marked as 'beforefieldinit'.
		static IInterceptsMessages()
		{
			Il2CppClassPointerStore<IInterceptsMessages>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "IInterceptsMessages");
			IInterceptsMessages.NativeMethodInfoPtr_Intercept_Public_Abstract_Virtual_New_MessageAction_MessageAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInterceptsMessages>.NativeClassPtr, 100667242);
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x00063F14 File Offset: 0x00062114
		[CallerCount(0)]
		public unsafe virtual MessageAction Intercept(MessageAction message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInterceptsMessages.NativeMethodInfoPtr_Intercept_Public_Abstract_Virtual_New_MessageAction_MessageAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MessageAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x000091BA File Offset: 0x000073BA
		public IInterceptsMessages(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C01 RID: 3073
		private static readonly IntPtr NativeMethodInfoPtr_Intercept_Public_Abstract_Virtual_New_MessageAction_MessageAction_0;
	}
}
