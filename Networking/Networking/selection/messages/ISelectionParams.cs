using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Networking.selection.messages
{
	// Token: 0x02000081 RID: 129
	public class ISelectionParams : Il2CppObjectBase
	{
		// Token: 0x06000451 RID: 1105 RVA: 0x00004A9F File Offset: 0x00002C9F
		// Note: this type is marked as 'beforefieldinit'.
		static ISelectionParams()
		{
			Il2CppClassPointerStore<ISelectionParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.messages", "ISelectionParams");
			ISelectionParams.NativeMethodInfoPtr_get_Params_Public_Abstract_Virtual_New_get_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionParams>.NativeClassPtr, 100663574);
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x000116DC File Offset: 0x0000F8DC
		public unsafe virtual Dictionary<string, Object> Params
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionParams.NativeMethodInfoPtr_get_Params_Public_Abstract_Virtual_New_get_Dictionary_2_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00004ACE File Offset: 0x00002CCE
		public ISelectionParams(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_get_Params_Public_Abstract_Virtual_New_get_Dictionary_2_String_Object_0;
	}
}
