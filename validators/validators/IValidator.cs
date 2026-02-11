using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace validators
{
	// Token: 0x02000010 RID: 16
	public class IValidator : Il2CppObjectBase
	{
		// Token: 0x06000068 RID: 104 RVA: 0x00003C40 File Offset: 0x00001E40
		// Note: this type is marked as 'beforefieldinit'.
		static IValidator()
		{
			Il2CppClassPointerStore<IValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("validators.dll", "validators", "IValidator");
			IValidator.NativeMethodInfoPtr_get_Valid_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValidator>.NativeClassPtr, 100663341);
			IValidator.NativeMethodInfoPtr_set_Valid_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValidator>.NativeClassPtr, 100663342);
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00003C90 File Offset: 0x00001E90
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00003CD8 File Offset: 0x00001ED8
		public unsafe virtual bool Valid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IValidator.NativeMethodInfoPtr_get_Valid_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IValidator.NativeMethodInfoPtr_set_Valid_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002323 File Offset: 0x00000523
		public IValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_get_Valid_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_set_Valid_Public_Abstract_Virtual_New_set_Void_Boolean_0;
	}
}
