using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Unity.Properties
{
	// Token: 0x0200001F RID: 31
	public class IConstructor : Il2CppObjectBase
	{
		// Token: 0x0600011C RID: 284 RVA: 0x00002840 File Offset: 0x00000A40
		// Note: this type is marked as 'beforefieldinit'.
		static IConstructor()
		{
			Il2CppClassPointerStore<IConstructor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "IConstructor");
			IConstructor.NativeMethodInfoPtr_get_InstantiationKind_Public_Abstract_Virtual_New_get_InstantiationKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructor>.NativeClassPtr, 100663398);
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600011D RID: 285 RVA: 0x000067A0 File Offset: 0x000049A0
		public unsafe virtual InstantiationKind InstantiationKind
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConstructor.NativeMethodInfoPtr_get_InstantiationKind_Public_Abstract_Virtual_New_get_InstantiationKind_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000286F File Offset: 0x00000A6F
		public IConstructor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_get_InstantiationKind_Public_Abstract_Virtual_New_get_InstantiationKind_0;
	}
}
