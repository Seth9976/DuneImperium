using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Steamworks
{
	// Token: 0x02000005 RID: 5
	public class ICallbackData : Il2CppObjectBase
	{
		// Token: 0x06000016 RID: 22 RVA: 0x0000EDA4 File Offset: 0x0000CFA4
		// Note: this type is marked as 'beforefieldinit'.
		static ICallbackData()
		{
			Il2CppClassPointerStore<ICallbackData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ICallbackData");
			ICallbackData.NativeMethodInfoPtr_get_CallbackType_Public_Abstract_Virtual_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICallbackData>.NativeClassPtr, 100663304);
			ICallbackData.NativeMethodInfoPtr_get_DataSize_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICallbackData>.NativeClassPtr, 100663305);
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000017 RID: 23 RVA: 0x0000EDF4 File Offset: 0x0000CFF4
		public unsafe virtual CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICallbackData.NativeMethodInfoPtr_get_CallbackType_Public_Abstract_Virtual_New_get_CallbackType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000018 RID: 24 RVA: 0x0000EE3C File Offset: 0x0000D03C
		public unsafe virtual int DataSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICallbackData.NativeMethodInfoPtr_get_DataSize_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002152 File Offset: 0x00000352
		public ICallbackData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Abstract_Virtual_New_get_CallbackType_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
