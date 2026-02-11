using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Canis.context.contextToList
{
	// Token: 0x0200012B RID: 299
	public class IContextToList : Il2CppObjectBase
	{
		// Token: 0x06000DD0 RID: 3536 RVA: 0x0000708F File Offset: 0x0000528F
		// Note: this type is marked as 'beforefieldinit'.
		static IContextToList()
		{
			Il2CppClassPointerStore<IContextToList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.contextToList", "IContextToList");
			IContextToList.NativeMethodInfoPtr_ErasedEvaluate_Public_Abstract_Virtual_New_IEnumerable_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContextToList>.NativeClassPtr, 100666356);
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x000542B8 File Offset: 0x000524B8
		[CallerCount(0)]
		public unsafe virtual IEnumerable ErasedEvaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContextToList.NativeMethodInfoPtr_ErasedEvaluate_Public_Abstract_Virtual_New_IEnumerable_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable>(intPtr3) : null;
			}
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x000070BE File Offset: 0x000052BE
		public IContextToList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeMethodInfoPtr_ErasedEvaluate_Public_Abstract_Virtual_New_IEnumerable_Context_0;
	}
}
