using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.settings
{
	// Token: 0x020000B2 RID: 178
	public class IWritableSetting<T> : Il2CppObjectBase
	{
		// Token: 0x06000B6F RID: 2927 RVA: 0x0003F074 File Offset: 0x0003D274
		// Note: this type is marked as 'beforefieldinit'.
		static IWritableSetting()
		{
			Il2CppClassPointerStore<IWritableSetting<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings", "IWritableSetting`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IWritableSetting<T>.NativeMethodInfoPtr_Set_Public_Abstract_Virtual_New_ISaveSettingRequest_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWritableSetting<T>>.NativeClassPtr, 100664887);
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x0003F0EC File Offset: 0x0003D2EC
		[CallerCount(0)]
		public unsafe virtual ISaveSettingRequest Set(T value)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IWritableSetting<T>.NativeMethodInfoPtr_Set_Public_Abstract_Virtual_New_ISaveSettingRequest_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr4) : null;
			}
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x000060B0 File Offset: 0x000042B0
		public IWritableSetting(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Abstract_Virtual_New_ISaveSettingRequest_T_0;
	}
}
