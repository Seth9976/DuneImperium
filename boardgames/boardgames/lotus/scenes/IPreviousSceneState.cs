using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace lotus.scenes
{
	// Token: 0x020000E1 RID: 225
	public class IPreviousSceneState : Il2CppObjectBase
	{
		// Token: 0x06000B23 RID: 2851 RVA: 0x000347E8 File Offset: 0x000329E8
		// Note: this type is marked as 'beforefieldinit'.
		static IPreviousSceneState()
		{
			Il2CppClassPointerStore<IPreviousSceneState>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.scenes", "IPreviousSceneState");
			IPreviousSceneState.NativeMethodInfoPtr_get_ResetStack_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPreviousSceneState>.NativeClassPtr, 100665071);
			IPreviousSceneState.NativeMethodInfoPtr_RestoreState_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPreviousSceneState>.NativeClassPtr, 100665072);
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000B24 RID: 2852 RVA: 0x00034838 File Offset: 0x00032A38
		public unsafe virtual bool ResetStack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPreviousSceneState.NativeMethodInfoPtr_get_ResetStack_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00034880 File Offset: 0x00032A80
		[CallerCount(0)]
		public unsafe virtual IEnumerator RestoreState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPreviousSceneState.NativeMethodInfoPtr_RestoreState_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x0000718B File Offset: 0x0000538B
		public IPreviousSceneState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeMethodInfoPtr_get_ResetStack_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeMethodInfoPtr_RestoreState_Public_Abstract_Virtual_New_IEnumerator_0;
	}
}
