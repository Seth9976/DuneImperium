using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001A4 RID: 420
	public class IStyleValue<T> : Il2CppObjectBase
	{
		// Token: 0x06002292 RID: 8850 RVA: 0x0009B3B0 File Offset: 0x000995B0
		// Note: this type is marked as 'beforefieldinit'.
		static IStyleValue()
		{
			Il2CppClassPointerStore<IStyleValue<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IStyleValue`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IStyleValue<T>.NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStyleValue<T>>.NativeClassPtr, 100668405);
			IStyleValue<T>.NativeMethodInfoPtr_get_keyword_Public_Abstract_Virtual_New_get_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStyleValue<T>>.NativeClassPtr, 100668406);
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06002293 RID: 8851 RVA: 0x0009B43C File Offset: 0x0009963C
		public unsafe virtual T value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStyleValue<T>.NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06002294 RID: 8852 RVA: 0x0009B480 File Offset: 0x00099680
		public unsafe virtual StyleKeyword keyword
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStyleValue<T>.NativeMethodInfoPtr_get_keyword_Public_Abstract_Virtual_New_get_StyleKeyword_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x0000E482 File Offset: 0x0000C682
		public IStyleValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001859 RID: 6233
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_T_0;

		// Token: 0x0400185A RID: 6234
		private static readonly IntPtr NativeMethodInfoPtr_get_keyword_Public_Abstract_Virtual_New_get_StyleKeyword_0;
	}
}
