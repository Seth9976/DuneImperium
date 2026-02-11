using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.platform.providers
{
	// Token: 0x0200002C RID: 44
	public class IUserEntry : Il2CppObjectBase
	{
		// Token: 0x060001B9 RID: 441 RVA: 0x0000AFEC File Offset: 0x000091EC
		// Note: this type is marked as 'beforefieldinit'.
		static IUserEntry()
		{
			Il2CppClassPointerStore<IUserEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "dwd.core.platform.providers", "IUserEntry");
			IUserEntry.NativeMethodInfoPtr_get_AccountID_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserEntry>.NativeClassPtr, 100663551);
			IUserEntry.NativeMethodInfoPtr_get_Username_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserEntry>.NativeClassPtr, 100663552);
			IUserEntry.NativeMethodInfoPtr_get_ScreenName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserEntry>.NativeClassPtr, 100663553);
			IUserEntry.NativeMethodInfoPtr_get_ScreenNameID_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserEntry>.NativeClassPtr, 100663554);
			IUserEntry.NativeMethodInfoPtr_get_Online_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserEntry>.NativeClassPtr, 100663555);
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0000B078 File Offset: 0x00009278
		public unsafe virtual string AccountID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserEntry.NativeMethodInfoPtr_get_AccountID_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0000B0BC File Offset: 0x000092BC
		public unsafe virtual string Username
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserEntry.NativeMethodInfoPtr_get_Username_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001BC RID: 444 RVA: 0x0000B100 File Offset: 0x00009300
		public unsafe virtual string ScreenName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserEntry.NativeMethodInfoPtr_get_ScreenName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0000B144 File Offset: 0x00009344
		public unsafe virtual string ScreenNameID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserEntry.NativeMethodInfoPtr_get_ScreenNameID_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001BE RID: 446 RVA: 0x0000B188 File Offset: 0x00009388
		public unsafe virtual bool Online
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserEntry.NativeMethodInfoPtr_get_Online_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002870 File Offset: 0x00000A70
		public IUserEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_get_AccountID_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_get_Username_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_get_ScreenName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_get_ScreenNameID_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_get_Online_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
