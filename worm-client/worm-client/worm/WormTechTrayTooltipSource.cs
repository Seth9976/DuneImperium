using System;
using boardgames.match.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace worm
{
	// Token: 0x0200003E RID: 62
	public class WormTechTrayTooltipSource : MonoBehaviour
	{
		// Token: 0x060002B0 RID: 688 RVA: 0x000211F4 File Offset: 0x0001F3F4
		// Note: this type is marked as 'beforefieldinit'.
		static WormTechTrayTooltipSource()
		{
			Il2CppClassPointerStore<WormTechTrayTooltipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormTechTrayTooltipSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTechTrayTooltipSource>.NativeClassPtr);
			WormTechTrayTooltipSource.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechTrayTooltipSource>.NativeClassPtr, "entitiesProvider");
			WormTechTrayTooltipSource.NativeFieldInfoPtr_tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechTrayTooltipSource>.NativeClassPtr, "tooltip");
			WormTechTrayTooltipSource.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTrayTooltipSource>.NativeClassPtr, 100663737);
			WormTechTrayTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTrayTooltipSource>.NativeClassPtr, 100663738);
			WormTechTrayTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTrayTooltipSource>.NativeClassPtr, 100663739);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00021288 File Offset: 0x0001F488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690595, XrefRangeEnd = 690598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTrayTooltipSource.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000212BC File Offset: 0x0001F4BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690598, XrefRangeEnd = 690637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTrayTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000212F4 File Offset: 0x0001F4F4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTechTrayTooltipSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTechTrayTooltipSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTrayTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000033D0 File Offset: 0x000015D0
		public WormTechTrayTooltipSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x00021330 File Offset: 0x0001F530
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x000033D9 File Offset: 0x000015D9
		public unsafe DBGEntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechTrayTooltipSource.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechTrayTooltipSource.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x00021360 File Offset: 0x0001F560
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x000033F8 File Offset: 0x000015F8
		public unsafe static string tooltip
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTechTrayTooltipSource.NativeFieldInfoPtr_tooltip, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTechTrayTooltipSource.NativeFieldInfoPtr_tooltip, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeFieldInfoPtr_tooltip;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
