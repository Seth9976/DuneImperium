using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.settings.playerPrefs
{
	// Token: 0x020000CB RID: 203
	public class IAccountPrefFormatter : Il2CppObjectBase
	{
		// Token: 0x06000C9A RID: 3226 RVA: 0x00043D50 File Offset: 0x00041F50
		// Note: this type is marked as 'beforefieldinit'.
		static IAccountPrefFormatter()
		{
			Il2CppClassPointerStore<IAccountPrefFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.playerPrefs", "IAccountPrefFormatter");
			IAccountPrefFormatter.NativeMethodInfoPtr_get_Initialized_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAccountPrefFormatter>.NativeClassPtr, 100665065);
			IAccountPrefFormatter.NativeMethodInfoPtr_AccountPrefKey_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAccountPrefFormatter>.NativeClassPtr, 100665066);
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x00043DA0 File Offset: 0x00041FA0
		public unsafe virtual bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAccountPrefFormatter.NativeMethodInfoPtr_get_Initialized_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00043DE8 File Offset: 0x00041FE8
		[CallerCount(0)]
		public unsafe virtual string AccountPrefKey(string baseKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAccountPrefFormatter.NativeMethodInfoPtr_AccountPrefKey_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x0000675F File Offset: 0x0000495F
		public IAccountPrefFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400090F RID: 2319
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000910 RID: 2320
		private static readonly IntPtr NativeMethodInfoPtr_AccountPrefKey_Public_Abstract_Virtual_New_String_String_0;
	}
}
