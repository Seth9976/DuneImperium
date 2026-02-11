using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace lotus.sequences
{
	// Token: 0x0200008C RID: 140
	public class IAnimationSequence : Il2CppObjectBase
	{
		// Token: 0x06000887 RID: 2183 RVA: 0x00025DB8 File Offset: 0x00023FB8
		// Note: this type is marked as 'beforefieldinit'.
		static IAnimationSequence()
		{
			Il2CppClassPointerStore<IAnimationSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus.sequences", "IAnimationSequence");
			IAnimationSequence.NativeMethodInfoPtr_get_RunAnimations_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAnimationSequence>.NativeClassPtr, 100664540);
			IAnimationSequence.NativeMethodInfoPtr_set_RunAnimations_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAnimationSequence>.NativeClassPtr, 100664541);
			IAnimationSequence.NativeMethodInfoPtr_runAnimations_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAnimationSequence>.NativeClassPtr, 100664542);
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x00025E1C File Offset: 0x0002401C
		// (set) Token: 0x06000889 RID: 2185 RVA: 0x00025E64 File Offset: 0x00024064
		public unsafe virtual bool RunAnimations
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAnimationSequence.NativeMethodInfoPtr_get_RunAnimations_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAnimationSequence.NativeMethodInfoPtr_set_RunAnimations_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00025EB0 File Offset: 0x000240B0
		[CallerCount(0)]
		public unsafe virtual IEnumerator runAnimations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAnimationSequence.NativeMethodInfoPtr_runAnimations_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00006279 File Offset: 0x00004479
		public IAnimationSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeMethodInfoPtr_get_RunAnimations_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeMethodInfoPtr_set_RunAnimations_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeMethodInfoPtr_runAnimations_Public_Abstract_Virtual_New_IEnumerator_0;
	}
}
