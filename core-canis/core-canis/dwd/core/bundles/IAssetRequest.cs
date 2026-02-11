using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.bundles
{
	// Token: 0x02000203 RID: 515
	public class IAssetRequest<T> : Il2CppObjectBase where T : global::UnityEngine.Object
	{
		// Token: 0x06001C88 RID: 7304 RVA: 0x00084A0C File Offset: 0x00082C0C
		// Note: this type is marked as 'beforefieldinit'.
		static IAssetRequest()
		{
			Il2CppClassPointerStore<IAssetRequest<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.bundles", "IAssetRequest`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IAssetRequest<T>.NativeMethodInfoPtr_get_State_Public_Abstract_Virtual_New_get_AssetRequestStates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAssetRequest<T>>.NativeClassPtr, 100667838);
			IAssetRequest<T>.NativeMethodInfoPtr_get_Asset_Public_Abstract_Virtual_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAssetRequest<T>>.NativeClassPtr, 100667839);
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06001C89 RID: 7305 RVA: 0x00084A98 File Offset: 0x00082C98
		public unsafe virtual AssetRequestStates State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAssetRequest<T>.NativeMethodInfoPtr_get_State_Public_Abstract_Virtual_New_get_AssetRequestStates_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06001C8A RID: 7306 RVA: 0x00084AE0 File Offset: 0x00082CE0
		public unsafe virtual T Asset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAssetRequest<T>.NativeMethodInfoPtr_get_Asset_Public_Abstract_Virtual_New_get_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x0000C40E File Offset: 0x0000A60E
		public IAssetRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040013FD RID: 5117
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_Abstract_Virtual_New_get_AssetRequestStates_0;

		// Token: 0x040013FE RID: 5118
		private static readonly IntPtr NativeMethodInfoPtr_get_Asset_Public_Abstract_Virtual_New_get_T_0;
	}
}
