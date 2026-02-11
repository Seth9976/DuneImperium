using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace dwd.canis.behaviours
{
	// Token: 0x02000068 RID: 104
	public class SettingsAllowObserversButton : MonoBehaviour
	{
		// Token: 0x060003E0 RID: 992 RVA: 0x00029BDC File Offset: 0x00027DDC
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsAllowObserversButton()
		{
			Il2CppClassPointerStore<SettingsAllowObserversButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.behaviours", "SettingsAllowObserversButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsAllowObserversButton>.NativeClassPtr);
			SettingsAllowObserversButton.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsAllowObserversButton>.NativeClassPtr, "toggle");
			SettingsAllowObserversButton.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsAllowObserversButton>.NativeClassPtr, 100663897);
			SettingsAllowObserversButton.NativeMethodInfoPtr_Event_Toggle_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsAllowObserversButton>.NativeClassPtr, 100663898);
			SettingsAllowObserversButton.NativeMethodInfoPtr_SetInteractable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsAllowObserversButton>.NativeClassPtr, 100663899);
			SettingsAllowObserversButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsAllowObserversButton>.NativeClassPtr, 100663900);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00029C70 File Offset: 0x00027E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500117, XrefRangeEnd = 500132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsAllowObserversButton.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00029CA4 File Offset: 0x00027EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500132, XrefRangeEnd = 500147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Toggle(bool isOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isOn;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsAllowObserversButton.NativeMethodInfoPtr_Event_Toggle_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00029CE4 File Offset: 0x00027EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500147, XrefRangeEnd = 500149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsAllowObserversButton.NativeMethodInfoPtr_SetInteractable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00029D18 File Offset: 0x00027F18
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsAllowObserversButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsAllowObserversButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsAllowObserversButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00003B73 File Offset: 0x00001D73
		public SettingsAllowObserversButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x00029D54 File Offset: 0x00027F54
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x00003B7C File Offset: 0x00001D7C
		public unsafe Toggle toggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsAllowObserversButton.NativeFieldInfoPtr_toggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsAllowObserversButton.NativeFieldInfoPtr_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeFieldInfoPtr_toggle;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_Event_Toggle_Public_Void_Boolean_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Private_Void_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
