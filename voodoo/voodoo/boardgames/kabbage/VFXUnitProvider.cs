using System;
using boardgames.voodoo;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace boardgames.kabbage
{
	// Token: 0x02000096 RID: 150
	public class VFXUnitProvider : MonoBehaviour
	{
		// Token: 0x060008E1 RID: 2273 RVA: 0x00026EF8 File Offset: 0x000250F8
		// Note: this type is marked as 'beforefieldinit'.
		static VFXUnitProvider()
		{
			Il2CppClassPointerStore<VFXUnitProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "boardgames.kabbage", "VFXUnitProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXUnitProvider>.NativeClassPtr);
			VFXUnitProvider.NativeFieldInfoPtr_unitViewProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXUnitProvider>.NativeClassPtr, "unitViewProvider");
			VFXUnitProvider.NativeMethodInfoPtr_GetVFXUnit_Public_UnitView_FlavoredVFXMoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXUnitProvider>.NativeClassPtr, 100664582);
			VFXUnitProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXUnitProvider>.NativeClassPtr, 100664583);
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00026F64 File Offset: 0x00025164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116925, XrefRangeEnd = 1116935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitView GetVFXUnit(FlavoredVFXMoveContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXUnitProvider.NativeMethodInfoPtr_GetVFXUnit_Public_UnitView_FlavoredVFXMoveContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr3) : null;
			}
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00026FB4 File Offset: 0x000251B4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VFXUnitProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXUnitProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXUnitProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00006570 File Offset: 0x00004770
		public VFXUnitProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x00026FF0 File Offset: 0x000251F0
		// (set) Token: 0x060008E6 RID: 2278 RVA: 0x00006579 File Offset: 0x00004779
		public unsafe FlavoredUnitViewProvider unitViewProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXUnitProvider.NativeFieldInfoPtr_unitViewProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlavoredUnitViewProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXUnitProvider.NativeFieldInfoPtr_unitViewProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeFieldInfoPtr_unitViewProvider;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeMethodInfoPtr_GetVFXUnit_Public_UnitView_FlavoredVFXMoveContext_0;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
