using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x0200014C RID: 332
	public static class EmptyArray<T> : Object
	{
		// Token: 0x06001741 RID: 5953 RVA: 0x00094E80 File Offset: 0x00093080
		// Note: this type is marked as 'beforefieldinit'.
		static EmptyArray()
		{
			Il2CppClassPointerStore<EmptyArray<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "EmptyArray`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmptyArray<T>>.NativeClassPtr);
			EmptyArray<T>.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyArray<T>>.NativeClassPtr, "Value");
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x00007632 File Offset: 0x00005832
		public EmptyArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x00094F00 File Offset: 0x00093100
		// (set) Token: 0x06001744 RID: 5956 RVA: 0x0000763B File Offset: 0x0000583B
		public unsafe static Il2CppArrayBase<T> Value
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EmptyArray<T>.NativeFieldInfoPtr_Value, (void*)(&intPtr));
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EmptyArray<T>.NativeFieldInfoPtr_Value, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013FA RID: 5114
		private static readonly IntPtr NativeFieldInfoPtr_Value;
	}
}
