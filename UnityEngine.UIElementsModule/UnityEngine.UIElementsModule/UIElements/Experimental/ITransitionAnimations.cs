using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements.Experimental
{
	// Token: 0x020002A6 RID: 678
	public class ITransitionAnimations : Il2CppObjectBase
	{
		// Token: 0x0600321F RID: 12831 RVA: 0x0001446C File Offset: 0x0001266C
		// Note: this type is marked as 'beforefieldinit'.
		static ITransitionAnimations()
		{
			Il2CppClassPointerStore<ITransitionAnimations>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.Experimental", "ITransitionAnimations");
			ITransitionAnimations.NativeMethodInfoPtr_Start_Public_Abstract_Virtual_New_ValueAnimation_1_StyleValues_StyleValues_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitionAnimations>.NativeClassPtr, 100670584);
		}

		// Token: 0x06003220 RID: 12832 RVA: 0x000D4594 File Offset: 0x000D2794
		[CallerCount(0)]
		public unsafe virtual ValueAnimation<StyleValues> Start(StyleValues to, int durationMs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(to));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitionAnimations.NativeMethodInfoPtr_Start_Public_Abstract_Virtual_New_ValueAnimation_1_StyleValues_StyleValues_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValueAnimation<StyleValues>>(intPtr3) : null;
		}

		// Token: 0x06003221 RID: 12833 RVA: 0x0001449B File Offset: 0x0001269B
		public ITransitionAnimations(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040024CB RID: 9419
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Abstract_Virtual_New_ValueAnimation_1_StyleValues_StyleValues_Int32_0;
	}
}
