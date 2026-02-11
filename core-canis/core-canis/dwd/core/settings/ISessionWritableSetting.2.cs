using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace dwd.core.settings
{
	// Token: 0x020000AC RID: 172
	public class ISessionWritableSetting<T> : Il2CppObjectBase
	{
		// Token: 0x06000B5C RID: 2908 RVA: 0x0003EC68 File Offset: 0x0003CE68
		// Note: this type is marked as 'beforefieldinit'.
		static ISessionWritableSetting()
		{
			Il2CppClassPointerStore<ISessionWritableSetting<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings", "ISessionWritableSetting`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			ISessionWritableSetting<T>.NativeMethodInfoPtr_SetWithoutSave_Public_Abstract_Virtual_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISessionWritableSetting<T>>.NativeClassPtr, 100664880);
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x0003ECE0 File Offset: 0x0003CEE0
		[CallerCount(0)]
		public unsafe virtual void SetWithoutSave(T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISessionWritableSetting<T>.NativeMethodInfoPtr_SetWithoutSave_Public_Abstract_Virtual_New_Void_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0000601C File Offset: 0x0000421C
		public ISessionWritableSetting(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeMethodInfoPtr_SetWithoutSave_Public_Abstract_Virtual_New_Void_T_0;
	}
}
