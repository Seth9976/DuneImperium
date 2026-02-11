using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace worm.match.components
{
	// Token: 0x0200021C RID: 540
	public class WormUndoTooltipSource : MonoBehaviour
	{
		// Token: 0x060017AF RID: 6063 RVA: 0x0005FEC8 File Offset: 0x0005E0C8
		// Note: this type is marked as 'beforefieldinit'.
		static WormUndoTooltipSource()
		{
			Il2CppClassPointerStore<WormUndoTooltipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormUndoTooltipSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormUndoTooltipSource>.NativeClassPtr);
			WormUndoTooltipSource.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormUndoTooltipSource>.NativeClassPtr, "button");
			WormUndoTooltipSource.NativeFieldInfoPtr_offLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormUndoTooltipSource>.NativeClassPtr, "offLocKey");
			WormUndoTooltipSource.NativeFieldInfoPtr_onLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormUndoTooltipSource>.NativeClassPtr, "onLocKey");
			WormUndoTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormUndoTooltipSource>.NativeClassPtr, 100666588);
			WormUndoTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormUndoTooltipSource>.NativeClassPtr, 100666589);
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x0005FF5C File Offset: 0x0005E15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717659, XrefRangeEnd = 717665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormUndoTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x0005FF94 File Offset: 0x0005E194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717665, XrefRangeEnd = 717671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormUndoTooltipSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormUndoTooltipSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormUndoTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x0000E22E File Offset: 0x0000C42E
		public WormUndoTooltipSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x060017B3 RID: 6067 RVA: 0x0005FFD0 File Offset: 0x0005E1D0
		// (set) Token: 0x060017B4 RID: 6068 RVA: 0x0000E237 File Offset: 0x0000C437
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormUndoTooltipSource.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormUndoTooltipSource.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x060017B5 RID: 6069 RVA: 0x00060000 File Offset: 0x0005E200
		// (set) Token: 0x060017B6 RID: 6070 RVA: 0x0000E256 File Offset: 0x0000C456
		public unsafe string offLocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormUndoTooltipSource.NativeFieldInfoPtr_offLocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormUndoTooltipSource.NativeFieldInfoPtr_offLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x060017B7 RID: 6071 RVA: 0x00060028 File Offset: 0x0005E228
		// (set) Token: 0x060017B8 RID: 6072 RVA: 0x0000E275 File Offset: 0x0000C475
		public unsafe string onLocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormUndoTooltipSource.NativeFieldInfoPtr_onLocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormUndoTooltipSource.NativeFieldInfoPtr_onLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000DBA RID: 3514
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x04000DBB RID: 3515
		private static readonly IntPtr NativeFieldInfoPtr_offLocKey;

		// Token: 0x04000DBC RID: 3516
		private static readonly IntPtr NativeFieldInfoPtr_onLocKey;

		// Token: 0x04000DBD RID: 3517
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0;

		// Token: 0x04000DBE RID: 3518
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
