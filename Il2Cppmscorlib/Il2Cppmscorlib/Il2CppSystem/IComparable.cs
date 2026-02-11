using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem
{
	// Token: 0x020000A8 RID: 168
	public class IComparable : Il2CppObjectBase
	{
		// Token: 0x06000B81 RID: 2945 RVA: 0x00004E74 File Offset: 0x00003074
		// Note: this type is marked as 'beforefieldinit'.
		static IComparable()
		{
			Il2CppClassPointerStore<IComparable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IComparable");
			IComparable.NativeMethodInfoPtr_CompareTo_Public_Abstract_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IComparable>.NativeClassPtr, 100665299);
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0005AE44 File Offset: 0x00059044
		[CallerCount(0)]
		public unsafe virtual int CompareTo(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IComparable.NativeMethodInfoPtr_CompareTo_Public_Abstract_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00004EA3 File Offset: 0x000030A3
		public IComparable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Abstract_Virtual_New_Int32_Object_0;
	}
}
