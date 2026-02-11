using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Canis.attributes
{
	// Token: 0x02000160 RID: 352
	public class ISanitizedAttributeValue<T> : Il2CppObjectBase
	{
		// Token: 0x06000F74 RID: 3956 RVA: 0x00059368 File Offset: 0x00057568
		// Note: this type is marked as 'beforefieldinit'.
		static ISanitizedAttributeValue()
		{
			Il2CppClassPointerStore<ISanitizedAttributeValue<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.attributes", "ISanitizedAttributeValue`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			ISanitizedAttributeValue<T>.NativeMethodInfoPtr_Sanitize_Public_Abstract_Virtual_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISanitizedAttributeValue<T>>.NativeClassPtr, 100666539);
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x000593E0 File Offset: 0x000575E0
		[CallerCount(0)]
		public unsafe virtual T Sanitize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISanitizedAttributeValue<T>.NativeMethodInfoPtr_Sanitize_Public_Abstract_Virtual_New_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00007DF0 File Offset: 0x00005FF0
		public ISanitizedAttributeValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeMethodInfoPtr_Sanitize_Public_Abstract_Virtual_New_T_0;
	}
}
