using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppSystem.Dynamic.Utils
{
	// Token: 0x02000129 RID: 297
	public static class EmptyReadOnlyCollection<T> : Object
	{
		// Token: 0x06001161 RID: 4449 RVA: 0x0005AE84 File Offset: 0x00059084
		// Note: this type is marked as 'beforefieldinit'.
		static EmptyReadOnlyCollection()
		{
			Il2CppClassPointerStore<EmptyReadOnlyCollection<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Dynamic.Utils", "EmptyReadOnlyCollection`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmptyReadOnlyCollection<T>>.NativeClassPtr);
			EmptyReadOnlyCollection<T>.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyReadOnlyCollection<T>>.NativeClassPtr, "Instance");
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x0000752E File Offset: 0x0000572E
		public EmptyReadOnlyCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001163 RID: 4451 RVA: 0x0005AF04 File Offset: 0x00059104
		// (set) Token: 0x06001164 RID: 4452 RVA: 0x00007537 File Offset: 0x00005737
		public unsafe static ReadOnlyCollection<T> Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EmptyReadOnlyCollection<T>.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<T>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EmptyReadOnlyCollection<T>.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C79 RID: 3193
		private static readonly IntPtr NativeFieldInfoPtr_Instance;
	}
}
