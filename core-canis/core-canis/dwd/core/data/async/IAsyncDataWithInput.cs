using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace dwd.core.data.async
{
	// Token: 0x020001E7 RID: 487
	public class IAsyncDataWithInput<T> : Il2CppObjectBase
	{
		// Token: 0x06001A99 RID: 6809 RVA: 0x0007DEB8 File Offset: 0x0007C0B8
		// Note: this type is marked as 'beforefieldinit'.
		static IAsyncDataWithInput()
		{
			Il2CppClassPointerStore<IAsyncDataWithInput<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data.async", "IAsyncDataWithInput`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IAsyncDataWithInput<T>.NativeMethodInfoPtr_Request_Public_Abstract_Virtual_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncDataWithInput<T>>.NativeClassPtr, 100667516);
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x0007DF30 File Offset: 0x0007C130
		[CallerCount(0)]
		public unsafe virtual void Request(T inputData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = inputData;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref inputData;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncDataWithInput<T>.NativeMethodInfoPtr_Request_Public_Abstract_Virtual_New_Void_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x0000B75E File Offset: 0x0000995E
		public IAsyncDataWithInput(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040012AC RID: 4780
		private static readonly IntPtr NativeMethodInfoPtr_Request_Public_Abstract_Virtual_New_Void_T_0;
	}
}
