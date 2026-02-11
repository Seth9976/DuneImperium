using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000410 RID: 1040
	public class IReflectableType : Il2CppObjectBase
	{
		// Token: 0x06003C0A RID: 15370 RVA: 0x000164BC File Offset: 0x000146BC
		// Note: this type is marked as 'beforefieldinit'.
		static IReflectableType()
		{
			Il2CppClassPointerStore<IReflectableType>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "IReflectableType");
			IReflectableType.NativeMethodInfoPtr_GetTypeInfo_Public_Abstract_Virtual_New_TypeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IReflectableType>.NativeClassPtr, 100672254);
		}

		// Token: 0x06003C0B RID: 15371 RVA: 0x00120028 File Offset: 0x0011E228
		[CallerCount(0)]
		public unsafe virtual TypeInfo GetTypeInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IReflectableType.NativeMethodInfoPtr_GetTypeInfo_Public_Abstract_Virtual_New_TypeInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeInfo>(intPtr3) : null;
		}

		// Token: 0x06003C0C RID: 15372 RVA: 0x000164EB File Offset: 0x000146EB
		public IReflectableType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040030BE RID: 12478
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeInfo_Public_Abstract_Virtual_New_TypeInfo_0;
	}
}
