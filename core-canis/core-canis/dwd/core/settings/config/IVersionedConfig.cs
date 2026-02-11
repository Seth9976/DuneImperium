using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.settings.config
{
	// Token: 0x020000ED RID: 237
	public class IVersionedConfig : Il2CppObjectBase
	{
		// Token: 0x06000E27 RID: 3623 RVA: 0x00006D2B File Offset: 0x00004F2B
		// Note: this type is marked as 'beforefieldinit'.
		static IVersionedConfig()
		{
			Il2CppClassPointerStore<IVersionedConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.config", "IVersionedConfig");
			IVersionedConfig.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVersionedConfig>.NativeClassPtr, 100665342);
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x0004B8B4 File Offset: 0x00049AB4
		[CallerCount(0)]
		public unsafe virtual bool Get(string key, out string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVersionedConfig.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			value = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x00006D5A File Offset: 0x00004F5A
		public IVersionedConfig(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_Boolean_String_byref_String_0;
	}
}
