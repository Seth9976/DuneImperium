using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Collections
{
	// Token: 0x020004C3 RID: 1219
	public class IStructuralEquatable : Il2CppObjectBase
	{
		// Token: 0x06004A8A RID: 19082 RVA: 0x001588C4 File Offset: 0x00156AC4
		// Note: this type is marked as 'beforefieldinit'.
		static IStructuralEquatable()
		{
			Il2CppClassPointerStore<IStructuralEquatable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "IStructuralEquatable");
			IStructuralEquatable.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_Object_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStructuralEquatable>.NativeClassPtr, 100674135);
			IStructuralEquatable.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStructuralEquatable>.NativeClassPtr, 100674136);
		}

		// Token: 0x06004A8B RID: 19083 RVA: 0x00158914 File Offset: 0x00156B14
		[CallerCount(0)]
		public unsafe virtual bool Equals(Object other, IEqualityComparer comparer)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStructuralEquatable.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_Object_IEqualityComparer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A8C RID: 19084 RVA: 0x00158980 File Offset: 0x00156B80
		[CallerCount(0)]
		public unsafe virtual int GetHashCode(IEqualityComparer comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStructuralEquatable.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_IEqualityComparer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004A8D RID: 19085 RVA: 0x0001B545 File Offset: 0x00019745
		public IStructuralEquatable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003D0F RID: 15631
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_Object_IEqualityComparer_0;

		// Token: 0x04003D10 RID: 15632
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_IEqualityComparer_0;
	}
}
