using System;
using boardgames.menus.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.canis
{
	// Token: 0x0200004B RID: 75
	public class GameOptionDropdownTooltipSource : MonoBehaviour
	{
		// Token: 0x060002DF RID: 735 RVA: 0x000269A0 File Offset: 0x00024BA0
		// Note: this type is marked as 'beforefieldinit'.
		static GameOptionDropdownTooltipSource()
		{
			Il2CppClassPointerStore<GameOptionDropdownTooltipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis", "GameOptionDropdownTooltipSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameOptionDropdownTooltipSource>.NativeClassPtr);
			GameOptionDropdownTooltipSource.NativeFieldInfoPtr_locPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptionDropdownTooltipSource>.NativeClassPtr, "locPrefix");
			GameOptionDropdownTooltipSource.NativeFieldInfoPtr_dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptionDropdownTooltipSource>.NativeClassPtr, "dropdown");
			GameOptionDropdownTooltipSource.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionDropdownTooltipSource>.NativeClassPtr, 100663758);
			GameOptionDropdownTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionDropdownTooltipSource>.NativeClassPtr, 100663759);
			GameOptionDropdownTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionDropdownTooltipSource>.NativeClassPtr, 100663760);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00026A34 File Offset: 0x00024C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499222, XrefRangeEnd = 499226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionDropdownTooltipSource.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00026A68 File Offset: 0x00024C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499226, XrefRangeEnd = 499229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionDropdownTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00026AA0 File Offset: 0x00024CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499229, XrefRangeEnd = 499233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameOptionDropdownTooltipSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameOptionDropdownTooltipSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionDropdownTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00003457 File Offset: 0x00001657
		public GameOptionDropdownTooltipSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x00026ADC File Offset: 0x00024CDC
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x00003460 File Offset: 0x00001660
		public unsafe string locPrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionDropdownTooltipSource.NativeFieldInfoPtr_locPrefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionDropdownTooltipSource.NativeFieldInfoPtr_locPrefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x00026B04 File Offset: 0x00024D04
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x0000347F File Offset: 0x0000167F
		public unsafe ConfigureGameOptionDropdown dropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionDropdownTooltipSource.NativeFieldInfoPtr_dropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigureGameOptionDropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionDropdownTooltipSource.NativeFieldInfoPtr_dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeFieldInfoPtr_locPrefix;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeFieldInfoPtr_dropdown;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
