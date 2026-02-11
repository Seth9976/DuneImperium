using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Canis.actions.continuations
{
	// Token: 0x02000229 RID: 553
	public class IResetsBetweenTargets : Il2CppObjectBase
	{
		// Token: 0x060016FD RID: 5885 RVA: 0x0000AFC7 File Offset: 0x000091C7
		// Note: this type is marked as 'beforefieldinit'.
		static IResetsBetweenTargets()
		{
			Il2CppClassPointerStore<IResetsBetweenTargets>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.continuations", "IResetsBetweenTargets");
			IResetsBetweenTargets.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResetsBetweenTargets>.NativeClassPtr, 100668507);
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x00075988 File Offset: 0x00073B88
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResetsBetweenTargets.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x0000AFF6 File Offset: 0x000091F6
		public IResetsBetweenTargets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EC1 RID: 3777
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0;
	}
}
