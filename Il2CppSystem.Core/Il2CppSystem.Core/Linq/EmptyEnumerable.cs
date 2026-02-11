using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Linq
{
	// Token: 0x02000019 RID: 25
	public class EmptyEnumerable<TElement> : Object
	{
		// Token: 0x0600010F RID: 271 RVA: 0x00014DCC File Offset: 0x00012FCC
		// Note: this type is marked as 'beforefieldinit'.
		static EmptyEnumerable()
		{
			Il2CppClassPointerStore<EmptyEnumerable<TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "EmptyEnumerable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmptyEnumerable<TElement>>.NativeClassPtr);
			EmptyEnumerable<TElement>.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyEnumerable<TElement>>.NativeClassPtr, "Instance");
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000022A0 File Offset: 0x000004A0
		public EmptyEnumerable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00014E4C File Offset: 0x0001304C
		// (set) Token: 0x06000112 RID: 274 RVA: 0x000022A9 File Offset: 0x000004A9
		public unsafe static Il2CppArrayBase<TElement> Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EmptyEnumerable<TElement>.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				return Il2CppArrayBase<TElement>.WrapNativeGenericArrayPointer(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EmptyEnumerable<TElement>.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr_Instance;
	}
}
