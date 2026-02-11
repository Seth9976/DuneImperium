using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace DG.Tweening
{
	// Token: 0x0200000C RID: 12
	public class IDOTweenInit : Il2CppObjectBase
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x000022A0 File Offset: 0x000004A0
		// Note: this type is marked as 'beforefieldinit'.
		static IDOTweenInit()
		{
			Il2CppClassPointerStore<IDOTweenInit>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening", "IDOTweenInit");
			IDOTweenInit.NativeMethodInfoPtr_SetCapacity_Public_Abstract_Virtual_New_IDOTweenInit_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDOTweenInit>.NativeClassPtr, 100663409);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000085F0 File Offset: 0x000067F0
		[CallerCount(0)]
		public unsafe virtual IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tweenersCapacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sequencesCapacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDOTweenInit.NativeMethodInfoPtr_SetCapacity_Public_Abstract_Virtual_New_IDOTweenInit_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDOTweenInit>(intPtr3) : null;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000022CF File Offset: 0x000004CF
		public IDOTweenInit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_SetCapacity_Public_Abstract_Virtual_New_IDOTweenInit_Int32_Int32_0;
	}
}
