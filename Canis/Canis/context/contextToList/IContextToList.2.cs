using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.context.contextToList
{
	// Token: 0x0200012C RID: 300
	public class IContextToList<T> : Il2CppObjectBase
	{
		// Token: 0x06000DD3 RID: 3539 RVA: 0x00054314 File Offset: 0x00052514
		// Note: this type is marked as 'beforefieldinit'.
		static IContextToList()
		{
			Il2CppClassPointerStore<IContextToList<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.contextToList", "IContextToList`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IContextToList<T>.NativeMethodInfoPtr_Evaluate_Public_Abstract_Virtual_New_IEnumerable_1_T_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContextToList<T>>.NativeClassPtr, 100666357);
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x0005438C File Offset: 0x0005258C
		[CallerCount(0)]
		public unsafe virtual IEnumerable<T> Evaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContextToList<T>.NativeMethodInfoPtr_Evaluate_Public_Abstract_Virtual_New_IEnumerable_1_T_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x000070C7 File Offset: 0x000052C7
		public IContextToList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Abstract_Virtual_New_IEnumerable_1_T_Context_0;
	}
}
