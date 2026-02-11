using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Properties
{
	// Token: 0x02000007 RID: 7
	public class IProperty : Il2CppObjectBase
	{
		// Token: 0x0600001A RID: 26 RVA: 0x0000212F File Offset: 0x0000032F
		// Note: this type is marked as 'beforefieldinit'.
		static IProperty()
		{
			Il2CppClassPointerStore<IProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "IProperty");
			IProperty.NativeMethodInfoPtr_DeclaredValueType_Public_Abstract_Virtual_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IProperty>.NativeClassPtr, 100663303);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003B48 File Offset: 0x00001D48
		[CallerCount(0)]
		public unsafe virtual Type DeclaredValueType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IProperty.NativeMethodInfoPtr_DeclaredValueType_Public_Abstract_Virtual_New_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000215E File Offset: 0x0000035E
		public IProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_DeclaredValueType_Public_Abstract_Virtual_New_Type_0;
	}
}
