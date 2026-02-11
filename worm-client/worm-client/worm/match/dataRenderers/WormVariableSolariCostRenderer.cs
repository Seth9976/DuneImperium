using System;
using dwd.core.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000174 RID: 372
	public class WormVariableSolariCostRenderer : WormVariableCostRenderer<WormSolariCostData>
	{
		// Token: 0x060010AD RID: 4269 RVA: 0x0004A0B4 File Offset: 0x000482B4
		// Note: this type is marked as 'beforefieldinit'.
		static WormVariableSolariCostRenderer()
		{
			Il2CppClassPointerStore<WormVariableSolariCostRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormVariableSolariCostRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormVariableSolariCostRenderer>.NativeClassPtr);
			WormVariableSolariCostRenderer.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableSolariCostRenderer>.NativeClassPtr, "entitiesProvider");
			WormVariableSolariCostRenderer.NativeFieldInfoPtr_isLeto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableSolariCostRenderer>.NativeClassPtr, "isLeto");
			WormVariableSolariCostRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableSolariCostRenderer>.NativeClassPtr, 100665608);
			WormVariableSolariCostRenderer.NativeMethodInfoPtr_OverrideShowDiscount_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableSolariCostRenderer>.NativeClassPtr, 100665609);
			WormVariableSolariCostRenderer.NativeMethodInfoPtr_GetDisplayCost_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableSolariCostRenderer>.NativeClassPtr, 100665610);
			WormVariableSolariCostRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableSolariCostRenderer>.NativeClassPtr, 100665611);
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x0004A15C File Offset: 0x0004835C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709865, XrefRangeEnd = 709869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVariableSolariCostRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x0004A198 File Offset: 0x00048398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709869, XrefRangeEnd = 709898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool OverrideShowDiscount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVariableSolariCostRenderer.NativeMethodInfoPtr_OverrideShowDiscount_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x0004A1E0 File Offset: 0x000483E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709898, XrefRangeEnd = 709927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetDisplayCost()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVariableSolariCostRenderer.NativeMethodInfoPtr_GetDisplayCost_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x0004A228 File Offset: 0x00048428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709927, XrefRangeEnd = 709930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormVariableSolariCostRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVariableSolariCostRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableSolariCostRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x0000ACC8 File Offset: 0x00008EC8
		public WormVariableSolariCostRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x060010B3 RID: 4275 RVA: 0x0004A264 File Offset: 0x00048464
		// (set) Token: 0x060010B4 RID: 4276 RVA: 0x0000ACD1 File Offset: 0x00008ED1
		public unsafe EntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableSolariCostRenderer.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableSolariCostRenderer.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x0004A294 File Offset: 0x00048494
		// (set) Token: 0x060010B6 RID: 4278 RVA: 0x0000ACF0 File Offset: 0x00008EF0
		public unsafe bool isLeto
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableSolariCostRenderer.NativeFieldInfoPtr_isLeto);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableSolariCostRenderer.NativeFieldInfoPtr_isLeto)) = value;
			}
		}

		// Token: 0x04000995 RID: 2453
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x04000996 RID: 2454
		private static readonly IntPtr NativeFieldInfoPtr_isLeto;

		// Token: 0x04000997 RID: 2455
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000998 RID: 2456
		private static readonly IntPtr NativeMethodInfoPtr_OverrideShowDiscount_Protected_Virtual_Boolean_0;

		// Token: 0x04000999 RID: 2457
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayCost_Protected_Virtual_Int32_0;

		// Token: 0x0400099A RID: 2458
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
