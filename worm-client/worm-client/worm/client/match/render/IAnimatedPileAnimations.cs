using System;
using dwd.core.animation;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace worm.client.match.render
{
	// Token: 0x0200029A RID: 666
	public class IAnimatedPileAnimations : Il2CppObjectBase
	{
		// Token: 0x06001B28 RID: 6952 RVA: 0x0006B734 File Offset: 0x00069934
		// Note: this type is marked as 'beforefieldinit'.
		static IAnimatedPileAnimations()
		{
			Il2CppClassPointerStore<IAnimatedPileAnimations>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.client.match.render", "IAnimatedPileAnimations");
			IAnimatedPileAnimations.NativeMethodInfoPtr_get_Intro_Public_Abstract_Virtual_New_get_TriggeredBlockingAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAnimatedPileAnimations>.NativeClassPtr, 100667251);
			IAnimatedPileAnimations.NativeMethodInfoPtr_get_Outro_Public_Abstract_Virtual_New_get_TriggeredBlockingAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAnimatedPileAnimations>.NativeClassPtr, 100667252);
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001B29 RID: 6953 RVA: 0x0006B784 File Offset: 0x00069984
		public unsafe virtual TriggeredBlockingAnimation Intro
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAnimatedPileAnimations.NativeMethodInfoPtr_get_Intro_Public_Abstract_Virtual_New_get_TriggeredBlockingAnimation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TriggeredBlockingAnimation>(intPtr3) : null;
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06001B2A RID: 6954 RVA: 0x0006B7D0 File Offset: 0x000699D0
		public unsafe virtual TriggeredBlockingAnimation Outro
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAnimatedPileAnimations.NativeMethodInfoPtr_get_Outro_Public_Abstract_Virtual_New_get_TriggeredBlockingAnimation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TriggeredBlockingAnimation>(intPtr3) : null;
			}
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x0000FC11 File Offset: 0x0000DE11
		public IAnimatedPileAnimations(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FAC RID: 4012
		private static readonly IntPtr NativeMethodInfoPtr_get_Intro_Public_Abstract_Virtual_New_get_TriggeredBlockingAnimation_0;

		// Token: 0x04000FAD RID: 4013
		private static readonly IntPtr NativeMethodInfoPtr_get_Outro_Public_Abstract_Virtual_New_get_TriggeredBlockingAnimation_0;
	}
}
