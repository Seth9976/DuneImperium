using System;
using dwd.core.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000173 RID: 371
	public class WormVariablePersuasionCostRenderer : WormVariableCostRenderer<WormPersuasionCostData>
	{
		// Token: 0x060010A6 RID: 4262 RVA: 0x00049F44 File Offset: 0x00048144
		// Note: this type is marked as 'beforefieldinit'.
		static WormVariablePersuasionCostRenderer()
		{
			Il2CppClassPointerStore<WormVariablePersuasionCostRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormVariablePersuasionCostRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormVariablePersuasionCostRenderer>.NativeClassPtr);
			WormVariablePersuasionCostRenderer.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariablePersuasionCostRenderer>.NativeClassPtr, "entitiesProvider");
			WormVariablePersuasionCostRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariablePersuasionCostRenderer>.NativeClassPtr, 100665605);
			WormVariablePersuasionCostRenderer.NativeMethodInfoPtr_GetDisplayCost_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariablePersuasionCostRenderer>.NativeClassPtr, 100665606);
			WormVariablePersuasionCostRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariablePersuasionCostRenderer>.NativeClassPtr, 100665607);
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x00049FC4 File Offset: 0x000481C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709822, XrefRangeEnd = 709826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVariablePersuasionCostRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x0004A000 File Offset: 0x00048200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709826, XrefRangeEnd = 709862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetDisplayCost()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVariablePersuasionCostRenderer.NativeMethodInfoPtr_GetDisplayCost_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x0004A048 File Offset: 0x00048248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709862, XrefRangeEnd = 709865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormVariablePersuasionCostRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVariablePersuasionCostRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariablePersuasionCostRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x0000ACA0 File Offset: 0x00008EA0
		public WormVariablePersuasionCostRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x060010AB RID: 4267 RVA: 0x0004A084 File Offset: 0x00048284
		// (set) Token: 0x060010AC RID: 4268 RVA: 0x0000ACA9 File Offset: 0x00008EA9
		public unsafe EntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariablePersuasionCostRenderer.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariablePersuasionCostRenderer.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x04000992 RID: 2450
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000993 RID: 2451
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayCost_Protected_Virtual_Int32_0;

		// Token: 0x04000994 RID: 2452
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
