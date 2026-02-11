using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x020000B0 RID: 176
	public class IProgress<T> : Il2CppObjectBase
	{
		// Token: 0x06000BA9 RID: 2985 RVA: 0x0005B97C File Offset: 0x00059B7C
		// Note: this type is marked as 'beforefieldinit'.
		static IProgress()
		{
			Il2CppClassPointerStore<IProgress<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IProgress`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IProgress<T>.NativeMethodInfoPtr_Report_Public_Abstract_Virtual_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IProgress<T>>.NativeClassPtr, 100665323);
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x0005B9F4 File Offset: 0x00059BF4
		[CallerCount(0)]
		public unsafe virtual void Report(T value)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IProgress<T>.NativeMethodInfoPtr_Report_Public_Abstract_Virtual_New_Void_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00004FA7 File Offset: 0x000031A7
		public IProgress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeMethodInfoPtr_Report_Public_Abstract_Virtual_New_Void_T_0;
	}
}
