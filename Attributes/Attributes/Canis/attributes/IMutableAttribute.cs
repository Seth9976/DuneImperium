using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Canis.attributes
{
	// Token: 0x02000016 RID: 22
	public class IMutableAttribute : Il2CppObjectBase
	{
		// Token: 0x06000164 RID: 356 RVA: 0x000070F8 File Offset: 0x000052F8
		// Note: this type is marked as 'beforefieldinit'.
		static IMutableAttribute()
		{
			Il2CppClassPointerStore<IMutableAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes", "IMutableAttribute");
			IMutableAttribute.NativeMethodInfoPtr_Set_Public_Abstract_Virtual_New_Void_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMutableAttribute>.NativeClassPtr, 100663369);
			IMutableAttribute.NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMutableAttribute>.NativeClassPtr, 100663370);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00007148 File Offset: 0x00005348
		[CallerCount(0)]
		public unsafe virtual void Set(IAttribute other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMutableAttribute.NativeMethodInfoPtr_Set_Public_Abstract_Virtual_New_Void_IAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00007198 File Offset: 0x00005398
		[CallerCount(0)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMutableAttribute.NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002AA4 File Offset: 0x00000CA4
		public IMutableAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Abstract_Virtual_New_Void_IAttribute_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0;
	}
}
