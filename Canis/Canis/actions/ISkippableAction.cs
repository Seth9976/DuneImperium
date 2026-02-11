using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x02000181 RID: 385
	public class ISkippableAction : Il2CppObjectBase
	{
		// Token: 0x060010EF RID: 4335 RVA: 0x00008805 File Offset: 0x00006A05
		// Note: this type is marked as 'beforefieldinit'.
		static ISkippableAction()
		{
			Il2CppClassPointerStore<ISkippableAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "ISkippableAction");
			ISkippableAction.NativeMethodInfoPtr_OnSkip_Public_Abstract_Virtual_New_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISkippableAction>.NativeClassPtr, 100666817);
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x0005E2B4 File Offset: 0x0005C4B4
		[CallerCount(0)]
		public unsafe virtual Action OnSkip(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISkippableAction.NativeMethodInfoPtr_OnSkip_Public_Abstract_Virtual_New_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x00008834 File Offset: 0x00006A34
		public ISkippableAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B23 RID: 2851
		private static readonly IntPtr NativeMethodInfoPtr_OnSkip_Public_Abstract_Virtual_New_Action_Match_0;
	}
}
