using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace dwd.core.settings
{
	// Token: 0x020000AB RID: 171
	public class ISessionWritableSetting : Il2CppObjectBase
	{
		// Token: 0x06000B58 RID: 2904 RVA: 0x0003EB8C File Offset: 0x0003CD8C
		// Note: this type is marked as 'beforefieldinit'.
		static ISessionWritableSetting()
		{
			Il2CppClassPointerStore<ISessionWritableSetting>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings", "ISessionWritableSetting");
			ISessionWritableSetting.NativeMethodInfoPtr_SetWithoutSave_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISessionWritableSetting>.NativeClassPtr, 100664878);
			ISessionWritableSetting.NativeMethodInfoPtr_DeleteWithoutSave_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISessionWritableSetting>.NativeClassPtr, 100664879);
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x0003EBDC File Offset: 0x0003CDDC
		[CallerCount(0)]
		public unsafe virtual void SetWithoutSave(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISessionWritableSetting.NativeMethodInfoPtr_SetWithoutSave_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x0003EC2C File Offset: 0x0003CE2C
		[CallerCount(0)]
		public unsafe virtual void DeleteWithoutSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISessionWritableSetting.NativeMethodInfoPtr_DeleteWithoutSave_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00006013 File Offset: 0x00004213
		public ISessionWritableSetting(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeMethodInfoPtr_SetWithoutSave_Public_Abstract_Virtual_New_Void_Object_0;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeMethodInfoPtr_DeleteWithoutSave_Public_Abstract_Virtual_New_Void_0;
	}
}
