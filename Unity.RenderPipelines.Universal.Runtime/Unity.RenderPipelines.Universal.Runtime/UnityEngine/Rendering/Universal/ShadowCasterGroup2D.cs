using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200003A RID: 58
	public class ShadowCasterGroup2D : MonoBehaviour
	{
		// Token: 0x0600055A RID: 1370 RVA: 0x0002819C File Offset: 0x0002639C
		// Note: this type is marked as 'beforefieldinit'.
		static ShadowCasterGroup2D()
		{
			Il2CppClassPointerStore<ShadowCasterGroup2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ShadowCasterGroup2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowCasterGroup2D>.NativeClassPtr);
			ShadowCasterGroup2D.NativeFieldInfoPtr_m_ShadowGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCasterGroup2D>.NativeClassPtr, "m_ShadowGroup");
			ShadowCasterGroup2D.NativeFieldInfoPtr_m_ShadowCasters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCasterGroup2D>.NativeClassPtr, "m_ShadowCasters");
			ShadowCasterGroup2D.NativeMethodInfoPtr_CacheValues_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCasterGroup2D>.NativeClassPtr, 100663912);
			ShadowCasterGroup2D.NativeMethodInfoPtr_GetShadowCasters_Public_List_1_ShadowCaster2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCasterGroup2D>.NativeClassPtr, 100663913);
			ShadowCasterGroup2D.NativeMethodInfoPtr_GetShadowGroup_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCasterGroup2D>.NativeClassPtr, 100663914);
			ShadowCasterGroup2D.NativeMethodInfoPtr_RegisterShadowCaster2D_Public_Void_ShadowCaster2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCasterGroup2D>.NativeClassPtr, 100663915);
			ShadowCasterGroup2D.NativeMethodInfoPtr_UnregisterShadowCaster2D_Public_Void_ShadowCaster2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCasterGroup2D>.NativeClassPtr, 100663916);
			ShadowCasterGroup2D.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCasterGroup2D>.NativeClassPtr, 100663917);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0002826C File Offset: 0x0002646C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602358, XrefRangeEnd = 602363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CacheValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShadowCasterGroup2D.NativeMethodInfoPtr_CacheValues_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x000282A8 File Offset: 0x000264A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ShadowCaster2D> GetShadowCasters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCasterGroup2D.NativeMethodInfoPtr_GetShadowCasters_Public_List_1_ShadowCaster2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ShadowCaster2D>>(intPtr3) : null;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x000282E8 File Offset: 0x000264E8
		[CallerCount(0)]
		public unsafe int GetShadowGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCasterGroup2D.NativeMethodInfoPtr_GetShadowGroup_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00028324 File Offset: 0x00026524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602363, XrefRangeEnd = 602376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterShadowCaster2D(ShadowCaster2D shadowCaster2D)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shadowCaster2D);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCasterGroup2D.NativeMethodInfoPtr_RegisterShadowCaster2D_Public_Void_ShadowCaster2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00028368 File Offset: 0x00026568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602376, XrefRangeEnd = 602379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterShadowCaster2D(ShadowCaster2D shadowCaster2D)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shadowCaster2D);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCasterGroup2D.NativeMethodInfoPtr_UnregisterShadowCaster2D_Public_Void_ShadowCaster2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x000283AC File Offset: 0x000265AC
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShadowCasterGroup2D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadowCasterGroup2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCasterGroup2D.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0000469B File Offset: 0x0000289B
		public ShadowCasterGroup2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x000283E8 File Offset: 0x000265E8
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x000046A4 File Offset: 0x000028A4
		public unsafe int m_ShadowGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCasterGroup2D.NativeFieldInfoPtr_m_ShadowGroup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCasterGroup2D.NativeFieldInfoPtr_m_ShadowGroup)) = value;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x00028410 File Offset: 0x00026610
		// (set) Token: 0x06000565 RID: 1381 RVA: 0x000046BF File Offset: 0x000028BF
		public unsafe List<ShadowCaster2D> m_ShadowCasters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCasterGroup2D.NativeFieldInfoPtr_m_ShadowCasters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShadowCaster2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCasterGroup2D.NativeFieldInfoPtr_m_ShadowCasters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowGroup;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowCasters;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_CacheValues_Internal_Virtual_New_Void_0;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_GetShadowCasters_Public_List_1_ShadowCaster2D_0;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr_GetShadowGroup_Public_Int32_0;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr_RegisterShadowCaster2D_Public_Void_ShadowCaster2D_0;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterShadowCaster2D_Public_Void_ShadowCaster2D_0;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
