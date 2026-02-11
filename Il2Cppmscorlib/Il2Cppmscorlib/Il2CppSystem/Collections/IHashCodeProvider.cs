using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Collections
{
	// Token: 0x020004D0 RID: 1232
	public class IHashCodeProvider : Il2CppObjectBase
	{
		// Token: 0x06004BFF RID: 19455 RVA: 0x0001BC1E File Offset: 0x00019E1E
		// Note: this type is marked as 'beforefieldinit'.
		static IHashCodeProvider()
		{
			Il2CppClassPointerStore<IHashCodeProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "IHashCodeProvider");
			IHashCodeProvider.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHashCodeProvider>.NativeClassPtr, 100674557);
		}

		// Token: 0x06004C00 RID: 19456 RVA: 0x0015EE40 File Offset: 0x0015D040
		[CallerCount(0)]
		public unsafe virtual int GetHashCode(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHashCodeProvider.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004C01 RID: 19457 RVA: 0x0001BC4D File Offset: 0x00019E4D
		public IHashCodeProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003E2C RID: 15916
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_Object_0;
	}
}
