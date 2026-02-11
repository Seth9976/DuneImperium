using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200006F RID: 111
	public static class RaycasterManager : Object
	{
		// Token: 0x06000B3E RID: 2878 RVA: 0x00032CCC File Offset: 0x00030ECC
		// Note: this type is marked as 'beforefieldinit'.
		static RaycasterManager()
		{
			Il2CppClassPointerStore<RaycasterManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "RaycasterManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RaycasterManager>.NativeClassPtr);
			RaycasterManager.NativeFieldInfoPtr_s_Raycasters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycasterManager>.NativeClassPtr, "s_Raycasters");
			RaycasterManager.NativeMethodInfoPtr_AddRaycaster_Internal_Static_Void_BaseRaycaster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycasterManager>.NativeClassPtr, 100665146);
			RaycasterManager.NativeMethodInfoPtr_GetRaycasters_Public_Static_List_1_BaseRaycaster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycasterManager>.NativeClassPtr, 100665147);
			RaycasterManager.NativeMethodInfoPtr_RemoveRaycasters_Internal_Static_Void_BaseRaycaster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycasterManager>.NativeClassPtr, 100665148);
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00032D4C File Offset: 0x00030F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097497, XrefRangeEnd = 1097510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddRaycaster(BaseRaycaster baseRaycaster)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseRaycaster);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycasterManager.NativeMethodInfoPtr_AddRaycaster_Internal_Static_Void_BaseRaycaster_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00032D84 File Offset: 0x00030F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097510, XrefRangeEnd = 1097514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<BaseRaycaster> GetRaycasters()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycasterManager.NativeMethodInfoPtr_GetRaycasters_Public_Static_List_1_BaseRaycaster_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<BaseRaycaster>>(intPtr3) : null;
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x00032DB8 File Offset: 0x00030FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097514, XrefRangeEnd = 1097527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveRaycasters(BaseRaycaster baseRaycaster)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseRaycaster);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycasterManager.NativeMethodInfoPtr_RemoveRaycasters_Internal_Static_Void_BaseRaycaster_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00005FB5 File Offset: 0x000041B5
		public RaycasterManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x00032DF0 File Offset: 0x00030FF0
		// (set) Token: 0x06000B44 RID: 2884 RVA: 0x00005FBE File Offset: 0x000041BE
		public unsafe static List<BaseRaycaster> s_Raycasters
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RaycasterManager.NativeFieldInfoPtr_s_Raycasters, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BaseRaycaster>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RaycasterManager.NativeFieldInfoPtr_s_Raycasters, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeFieldInfoPtr_s_Raycasters;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeMethodInfoPtr_AddRaycaster_Internal_Static_Void_BaseRaycaster_0;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeMethodInfoPtr_GetRaycasters_Public_Static_List_1_BaseRaycaster_0;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRaycasters_Internal_Static_Void_BaseRaycaster_0;
	}
}
