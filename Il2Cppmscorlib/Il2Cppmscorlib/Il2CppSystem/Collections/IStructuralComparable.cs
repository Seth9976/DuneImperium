using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Collections
{
	// Token: 0x020004C2 RID: 1218
	public class IStructuralComparable : Il2CppObjectBase
	{
		// Token: 0x06004A87 RID: 19079 RVA: 0x0001B50D File Offset: 0x0001970D
		// Note: this type is marked as 'beforefieldinit'.
		static IStructuralComparable()
		{
			Il2CppClassPointerStore<IStructuralComparable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "IStructuralComparable");
			IStructuralComparable.NativeMethodInfoPtr_CompareTo_Public_Abstract_Virtual_New_Int32_Object_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStructuralComparable>.NativeClassPtr, 100674134);
		}

		// Token: 0x06004A88 RID: 19080 RVA: 0x00158858 File Offset: 0x00156A58
		[CallerCount(0)]
		public unsafe virtual int CompareTo(Object other, IComparer comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStructuralComparable.NativeMethodInfoPtr_CompareTo_Public_Abstract_Virtual_New_Int32_Object_IComparer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A89 RID: 19081 RVA: 0x0001B53C File Offset: 0x0001973C
		public IStructuralComparable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003D0E RID: 15630
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Abstract_Virtual_New_Int32_Object_IComparer_0;
	}
}
