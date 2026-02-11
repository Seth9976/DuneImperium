using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x02000075 RID: 117
	public class IVolumeDebugSettings2 : Il2CppObjectBase
	{
		// Token: 0x060007D0 RID: 2000 RVA: 0x0002AEB4 File Offset: 0x000290B4
		// Note: this type is marked as 'beforefieldinit'.
		static IVolumeDebugSettings2()
		{
			Il2CppClassPointerStore<IVolumeDebugSettings2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "IVolumeDebugSettings2");
			IVolumeDebugSettings2.NativeMethodInfoPtr_get_targetRenderPipeline_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVolumeDebugSettings2>.NativeClassPtr, 100664545);
			IVolumeDebugSettings2.NativeMethodInfoPtr_get_volumeComponentsPathAndType_Public_Abstract_Virtual_New_get_List_1_ValueTuple_2_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVolumeDebugSettings2>.NativeClassPtr, 100664546);
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x0002AF04 File Offset: 0x00029104
		public unsafe virtual Type targetRenderPipeline
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVolumeDebugSettings2.NativeMethodInfoPtr_get_targetRenderPipeline_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x0002AF50 File Offset: 0x00029150
		public unsafe virtual List<ValueTuple<string, Type>> volumeComponentsPathAndType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVolumeDebugSettings2.NativeMethodInfoPtr_get_volumeComponentsPathAndType_Public_Abstract_Virtual_New_get_List_1_ValueTuple_2_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<string, Type>>>(intPtr3) : null;
			}
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00005194 File Offset: 0x00003394
		public IVolumeDebugSettings2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeMethodInfoPtr_get_targetRenderPipeline_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeMethodInfoPtr_get_volumeComponentsPathAndType_Public_Abstract_Virtual_New_get_List_1_ValueTuple_2_String_Type_0;
	}
}
