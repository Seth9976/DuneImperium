using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Steamworks
{
	// Token: 0x0200000C RID: 12
	public static class CallbackTypeFactory : Object
	{
		// Token: 0x06000056 RID: 86 RVA: 0x0000227F File Offset: 0x0000047F
		// Note: this type is marked as 'beforefieldinit'.
		static CallbackTypeFactory()
		{
			Il2CppClassPointerStore<CallbackTypeFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "CallbackTypeFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackTypeFactory>.NativeClassPtr);
			CallbackTypeFactory.NativeFieldInfoPtr_All = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackTypeFactory>.NativeClassPtr, "All");
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000022B8 File Offset: 0x000004B8
		public CallbackTypeFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000FA44 File Offset: 0x0000DC44
		// (set) Token: 0x06000059 RID: 89 RVA: 0x000022C1 File Offset: 0x000004C1
		public unsafe static Dictionary<CallbackType, Type> All
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CallbackTypeFactory.NativeFieldInfoPtr_All, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<CallbackType, Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CallbackTypeFactory.NativeFieldInfoPtr_All, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeFieldInfoPtr_All;
	}
}
