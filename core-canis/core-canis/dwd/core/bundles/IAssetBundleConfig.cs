using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.bundles
{
	// Token: 0x02000200 RID: 512
	public class IAssetBundleConfig : Il2CppObjectBase
	{
		// Token: 0x06001C71 RID: 7281 RVA: 0x000842C8 File Offset: 0x000824C8
		// Note: this type is marked as 'beforefieldinit'.
		static IAssetBundleConfig()
		{
			Il2CppClassPointerStore<IAssetBundleConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.bundles", "IAssetBundleConfig");
			IAssetBundleConfig.NativeMethodInfoPtr_get_AssetURL_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAssetBundleConfig>.NativeClassPtr, 100667821);
			IAssetBundleConfig.NativeMethodInfoPtr_get_VersionURL_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAssetBundleConfig>.NativeClassPtr, 100667822);
			IAssetBundleConfig.NativeMethodInfoPtr_get_UseVersionedAssetNames_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAssetBundleConfig>.NativeClassPtr, 100667823);
			IAssetBundleConfig.NativeMethodInfoPtr_get_MaxConcurrentRequests_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAssetBundleConfig>.NativeClassPtr, 100667824);
			IAssetBundleConfig.NativeMethodInfoPtr_InitConfig_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAssetBundleConfig>.NativeClassPtr, 100667825);
			IAssetBundleConfig.NativeMethodInfoPtr_HandleError_Public_Abstract_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAssetBundleConfig>.NativeClassPtr, 100667826);
			IAssetBundleConfig.NativeMethodInfoPtr_HandleReattempt_Public_Abstract_Virtual_New_Void_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAssetBundleConfig>.NativeClassPtr, 100667827);
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06001C72 RID: 7282 RVA: 0x0008437C File Offset: 0x0008257C
		public unsafe virtual string AssetURL
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAssetBundleConfig.NativeMethodInfoPtr_get_AssetURL_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06001C73 RID: 7283 RVA: 0x000843C0 File Offset: 0x000825C0
		public unsafe virtual string VersionURL
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAssetBundleConfig.NativeMethodInfoPtr_get_VersionURL_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06001C74 RID: 7284 RVA: 0x00084404 File Offset: 0x00082604
		public unsafe virtual bool UseVersionedAssetNames
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAssetBundleConfig.NativeMethodInfoPtr_get_UseVersionedAssetNames_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06001C75 RID: 7285 RVA: 0x0008444C File Offset: 0x0008264C
		public unsafe virtual int MaxConcurrentRequests
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAssetBundleConfig.NativeMethodInfoPtr_get_MaxConcurrentRequests_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x00084494 File Offset: 0x00082694
		[CallerCount(0)]
		public unsafe virtual void InitConfig()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAssetBundleConfig.NativeMethodInfoPtr_InitConfig_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x000844D0 File Offset: 0x000826D0
		[CallerCount(0)]
		public unsafe virtual void HandleError(string Request, string Reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Reason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAssetBundleConfig.NativeMethodInfoPtr_HandleError_Public_Abstract_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x00084530 File Offset: 0x00082730
		[CallerCount(0)]
		public unsafe virtual void HandleReattempt(string Request, int number, string status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref number;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(status);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAssetBundleConfig.NativeMethodInfoPtr_HandleReattempt_Public_Abstract_Virtual_New_Void_String_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x0000C3F3 File Offset: 0x0000A5F3
		public IAssetBundleConfig(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040013EC RID: 5100
		private static readonly IntPtr NativeMethodInfoPtr_get_AssetURL_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040013ED RID: 5101
		private static readonly IntPtr NativeMethodInfoPtr_get_VersionURL_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040013EE RID: 5102
		private static readonly IntPtr NativeMethodInfoPtr_get_UseVersionedAssetNames_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040013EF RID: 5103
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxConcurrentRequests_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040013F0 RID: 5104
		private static readonly IntPtr NativeMethodInfoPtr_InitConfig_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040013F1 RID: 5105
		private static readonly IntPtr NativeMethodInfoPtr_HandleError_Public_Abstract_Virtual_New_Void_String_String_0;

		// Token: 0x040013F2 RID: 5106
		private static readonly IntPtr NativeMethodInfoPtr_HandleReattempt_Public_Abstract_Virtual_New_Void_String_Int32_String_0;
	}
}
