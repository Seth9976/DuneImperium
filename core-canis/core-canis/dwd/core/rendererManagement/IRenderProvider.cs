using System;
using dwd.core.data.composition;
using dwd.core.rendererManagement.configData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.rendererManagement
{
	// Token: 0x020000FC RID: 252
	public class IRenderProvider : Il2CppObjectBase
	{
		// Token: 0x06000EC8 RID: 3784 RVA: 0x0004E720 File Offset: 0x0004C920
		// Note: this type is marked as 'beforefieldinit'.
		static IRenderProvider()
		{
			Il2CppClassPointerStore<IRenderProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.rendererManagement", "IRenderProvider");
			IRenderProvider.NativeMethodInfoPtr_GetBoundsForData_Public_Abstract_Virtual_New_Bounds_DataComposition_VisibilityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRenderProvider>.NativeClassPtr, 100665444);
			IRenderProvider.NativeMethodInfoPtr_ApplyDataToRenderers_Public_Abstract_Virtual_New_Void_Dictionary_2_DataComposition_VisibilityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRenderProvider>.NativeClassPtr, 100665445);
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x0004E770 File Offset: 0x0004C970
		[CallerCount(0)]
		public unsafe virtual Bounds GetBoundsForData(DataComposition data, VisibilityConfiguration config)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(config);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRenderProvider.NativeMethodInfoPtr_GetBoundsForData_Public_Abstract_Virtual_New_Bounds_DataComposition_VisibilityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x0004E7DC File Offset: 0x0004C9DC
		[CallerCount(0)]
		public unsafe virtual void ApplyDataToRenderers(Dictionary<DataComposition, VisibilityConfiguration> dataMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRenderProvider.NativeMethodInfoPtr_ApplyDataToRenderers_Public_Abstract_Virtual_New_Void_Dictionary_2_DataComposition_VisibilityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x00007018 File Offset: 0x00005218
		public IRenderProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AA2 RID: 2722
		private static readonly IntPtr NativeMethodInfoPtr_GetBoundsForData_Public_Abstract_Virtual_New_Bounds_DataComposition_VisibilityConfiguration_0;

		// Token: 0x04000AA3 RID: 2723
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDataToRenderers_Public_Abstract_Virtual_New_Void_Dictionary_2_DataComposition_VisibilityConfiguration_0;
	}
}
