using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x020000AD RID: 173
	public class IEquatable<T> : Il2CppObjectBase
	{
		// Token: 0x06000BA0 RID: 2976 RVA: 0x0005B7B0 File Offset: 0x000599B0
		// Note: this type is marked as 'beforefieldinit'.
		static IEquatable()
		{
			Il2CppClassPointerStore<IEquatable<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IEquatable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IEquatable<T>.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEquatable<T>>.NativeClassPtr, 100665320);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0005B828 File Offset: 0x00059A28
		[CallerCount(0)]
		public unsafe virtual bool Equals(T other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = other;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref other;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEquatable<T>.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00004F2E File Offset: 0x0000312E
		public IEquatable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_T_0;
	}
}
