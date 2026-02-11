using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x020000EE RID: 238
	public class ISite : Il2CppObjectBase
	{
		// Token: 0x06000F88 RID: 3976 RVA: 0x00056818 File Offset: 0x00054A18
		// Note: this type is marked as 'beforefieldinit'.
		static ISite()
		{
			Il2CppClassPointerStore<ISite>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "ISite");
			ISite.NativeMethodInfoPtr_get_Container_Public_Abstract_Virtual_New_get_IContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISite>.NativeClassPtr, 100665537);
			ISite.NativeMethodInfoPtr_get_DesignMode_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISite>.NativeClassPtr, 100665538);
			ISite.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISite>.NativeClassPtr, 100665539);
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000F89 RID: 3977 RVA: 0x0005687C File Offset: 0x00054A7C
		public unsafe virtual IContainer Container
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISite.NativeMethodInfoPtr_get_Container_Public_Abstract_Virtual_New_get_IContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IContainer>(intPtr3) : null;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x000568C8 File Offset: 0x00054AC8
		public unsafe virtual bool DesignMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISite.NativeMethodInfoPtr_get_DesignMode_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000F8B RID: 3979 RVA: 0x00056910 File Offset: 0x00054B10
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISite.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x000079D7 File Offset: 0x00005BD7
		public ISite(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C9D RID: 3229
		private static readonly IntPtr NativeMethodInfoPtr_get_Container_Public_Abstract_Virtual_New_get_IContainer_0;

		// Token: 0x04000C9E RID: 3230
		private static readonly IntPtr NativeMethodInfoPtr_get_DesignMode_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;
	}
}
