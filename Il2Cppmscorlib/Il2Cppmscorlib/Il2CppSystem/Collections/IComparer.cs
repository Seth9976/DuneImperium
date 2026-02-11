using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Collections
{
	// Token: 0x020004BB RID: 1211
	public class IComparer : Il2CppObjectBase
	{
		// Token: 0x06004A59 RID: 19033 RVA: 0x0001B470 File Offset: 0x00019670
		// Note: this type is marked as 'beforefieldinit'.
		static IComparer()
		{
			Il2CppClassPointerStore<IComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "IComparer");
			IComparer.NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IComparer>.NativeClassPtr, 100674102);
		}

		// Token: 0x06004A5A RID: 19034 RVA: 0x00157B1C File Offset: 0x00155D1C
		[CallerCount(0)]
		public unsafe virtual int Compare(Object x, Object y)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IComparer.NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A5B RID: 19035 RVA: 0x0001B49F File Offset: 0x0001969F
		public IComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003CEE RID: 15598
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_Object_Object_0;
	}
}
