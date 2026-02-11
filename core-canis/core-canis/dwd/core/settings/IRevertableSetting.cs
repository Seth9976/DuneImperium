using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.settings
{
	// Token: 0x020000A8 RID: 168
	public class IRevertableSetting : Il2CppObjectBase
	{
		// Token: 0x06000B4B RID: 2891 RVA: 0x0003E824 File Offset: 0x0003CA24
		// Note: this type is marked as 'beforefieldinit'.
		static IRevertableSetting()
		{
			Il2CppClassPointerStore<IRevertableSetting>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings", "IRevertableSetting");
			IRevertableSetting.NativeMethodInfoPtr_Save_Public_Abstract_Virtual_New_ISaveSettingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRevertableSetting>.NativeClassPtr, 100664871);
			IRevertableSetting.NativeMethodInfoPtr_Revert_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRevertableSetting>.NativeClassPtr, 100664872);
			IRevertableSetting.NativeMethodInfoPtr_SetWithoutSave_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRevertableSetting>.NativeClassPtr, 100664873);
			IRevertableSetting.NativeMethodInfoPtr_DeleteWithoutSave_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRevertableSetting>.NativeClassPtr, 100664874);
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x0003E89C File Offset: 0x0003CA9C
		[CallerCount(0)]
		public unsafe virtual ISaveSettingRequest Save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRevertableSetting.NativeMethodInfoPtr_Save_Public_Abstract_Virtual_New_ISaveSettingRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0003E8E8 File Offset: 0x0003CAE8
		[CallerCount(0)]
		public unsafe virtual void Revert()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRevertableSetting.NativeMethodInfoPtr_Revert_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x0003E924 File Offset: 0x0003CB24
		[CallerCount(0)]
		public unsafe virtual void SetWithoutSave(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRevertableSetting.NativeMethodInfoPtr_SetWithoutSave_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x0003E974 File Offset: 0x0003CB74
		[CallerCount(0)]
		public unsafe virtual void DeleteWithoutSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRevertableSetting.NativeMethodInfoPtr_DeleteWithoutSave_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00005FF8 File Offset: 0x000041F8
		public IRevertableSetting(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Abstract_Virtual_New_ISaveSettingRequest_0;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeMethodInfoPtr_Revert_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeMethodInfoPtr_SetWithoutSave_Public_Abstract_Virtual_New_Void_Object_0;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeMethodInfoPtr_DeleteWithoutSave_Public_Abstract_Virtual_New_Void_0;
	}
}
