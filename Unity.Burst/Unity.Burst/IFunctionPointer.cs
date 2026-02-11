using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Unity.Burst
{
	// Token: 0x02000013 RID: 19
	public class IFunctionPointer : Il2CppObjectBase
	{
		// Token: 0x060001CD RID: 461 RVA: 0x00002BB0 File Offset: 0x00000DB0
		// Note: this type is marked as 'beforefieldinit'.
		static IFunctionPointer()
		{
			Il2CppClassPointerStore<IFunctionPointer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst", "IFunctionPointer");
			IFunctionPointer.NativeMethodInfoPtr_FromIntPtr_Public_Abstract_Virtual_New_IFunctionPointer_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFunctionPointer>.NativeClassPtr, 100663507);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00008F4C File Offset: 0x0000714C
		[CallerCount(0)]
		public unsafe virtual IFunctionPointer FromIntPtr(IntPtr ptr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFunctionPointer.NativeMethodInfoPtr_FromIntPtr_Public_Abstract_Virtual_New_IFunctionPointer_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFunctionPointer>(intPtr3) : null;
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002BDF File Offset: 0x00000DDF
		public IFunctionPointer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_FromIntPtr_Public_Abstract_Virtual_New_IFunctionPointer_IntPtr_0;
	}
}
