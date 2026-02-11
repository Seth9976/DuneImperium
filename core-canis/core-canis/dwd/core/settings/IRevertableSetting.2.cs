using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace dwd.core.settings
{
	// Token: 0x020000A9 RID: 169
	public class IRevertableSetting<T> : Il2CppObjectBase
	{
		// Token: 0x06000B51 RID: 2897 RVA: 0x0003E9B0 File Offset: 0x0003CBB0
		// Note: this type is marked as 'beforefieldinit'.
		static IRevertableSetting()
		{
			Il2CppClassPointerStore<IRevertableSetting<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings", "IRevertableSetting`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IRevertableSetting<T>.NativeMethodInfoPtr_SetWithoutSave_Public_Abstract_Virtual_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRevertableSetting<T>>.NativeClassPtr, 100664875);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0003EA28 File Offset: 0x0003CC28
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRevertableSetting<T>.NativeMethodInfoPtr_SetWithoutSave_Public_Abstract_Virtual_New_Void_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00006001 File Offset: 0x00004201
		public IRevertableSetting(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeMethodInfoPtr_SetWithoutSave_Public_Abstract_Virtual_New_Void_T_0;
	}
}
