using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.attributes
{
	// Token: 0x0200015F RID: 351
	public class ISanitizedAttributeValue : Il2CppObjectBase
	{
		// Token: 0x06000F71 RID: 3953 RVA: 0x00007DB8 File Offset: 0x00005FB8
		// Note: this type is marked as 'beforefieldinit'.
		static ISanitizedAttributeValue()
		{
			Il2CppClassPointerStore<ISanitizedAttributeValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.attributes", "ISanitizedAttributeValue");
			ISanitizedAttributeValue.NativeMethodInfoPtr_Sanitize_Public_Abstract_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISanitizedAttributeValue>.NativeClassPtr, 100666538);
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x0005931C File Offset: 0x0005751C
		[CallerCount(0)]
		public unsafe virtual Object Sanitize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISanitizedAttributeValue.NativeMethodInfoPtr_Sanitize_Public_Abstract_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x00007DE7 File Offset: 0x00005FE7
		public ISanitizedAttributeValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeMethodInfoPtr_Sanitize_Public_Abstract_Virtual_New_Object_0;
	}
}
