using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Collections
{
	// Token: 0x020004C0 RID: 1216
	public class IEqualityComparer : Il2CppObjectBase
	{
		// Token: 0x06004A76 RID: 19062 RVA: 0x001582C0 File Offset: 0x001564C0
		// Note: this type is marked as 'beforefieldinit'.
		static IEqualityComparer()
		{
			Il2CppClassPointerStore<IEqualityComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "IEqualityComparer");
			IEqualityComparer.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEqualityComparer>.NativeClassPtr, 100674121);
			IEqualityComparer.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEqualityComparer>.NativeClassPtr, 100674122);
		}

		// Token: 0x06004A77 RID: 19063 RVA: 0x00158310 File Offset: 0x00156510
		[CallerCount(0)]
		public unsafe virtual bool Equals(Object x, Object y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEqualityComparer.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A78 RID: 19064 RVA: 0x0015837C File Offset: 0x0015657C
		[CallerCount(0)]
		public unsafe virtual int GetHashCode(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEqualityComparer.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004A79 RID: 19065 RVA: 0x0001B4FB File Offset: 0x000196FB
		public IEqualityComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003D01 RID: 15617
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_Object_Object_0;

		// Token: 0x04003D02 RID: 15618
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_Object_0;
	}
}
