using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace dbg_client.display
{
	// Token: 0x0200003E RID: 62
	public class UIScalarOverrideSlider : MonoBehaviour
	{
		// Token: 0x0600026F RID: 623 RVA: 0x00025518 File Offset: 0x00023718
		// Note: this type is marked as 'beforefieldinit'.
		static UIScalarOverrideSlider()
		{
			Il2CppClassPointerStore<UIScalarOverrideSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbg_client.display", "UIScalarOverrideSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIScalarOverrideSlider>.NativeClassPtr);
			UIScalarOverrideSlider.NativeFieldInfoPtr_warningLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScalarOverrideSlider>.NativeClassPtr, "warningLabel");
			UIScalarOverrideSlider.NativeFieldInfoPtr_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScalarOverrideSlider>.NativeClassPtr, "slider");
			UIScalarOverrideSlider.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScalarOverrideSlider>.NativeClassPtr, 100663694);
			UIScalarOverrideSlider.NativeMethodInfoPtr_Event_OnSlider_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScalarOverrideSlider>.NativeClassPtr, 100663695);
			UIScalarOverrideSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScalarOverrideSlider>.NativeClassPtr, 100663696);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x000255AC File Offset: 0x000237AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498778, XrefRangeEnd = 498819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScalarOverrideSlider.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x000255E0 File Offset: 0x000237E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498819, XrefRangeEnd = 498856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OnSlider(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScalarOverrideSlider.NativeMethodInfoPtr_Event_OnSlider_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00025620 File Offset: 0x00023820
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIScalarOverrideSlider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIScalarOverrideSlider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScalarOverrideSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x000030CC File Offset: 0x000012CC
		public UIScalarOverrideSlider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0002565C File Offset: 0x0002385C
		// (set) Token: 0x06000275 RID: 629 RVA: 0x000030D5 File Offset: 0x000012D5
		public unsafe TMP_Text warningLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScalarOverrideSlider.NativeFieldInfoPtr_warningLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScalarOverrideSlider.NativeFieldInfoPtr_warningLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000276 RID: 630 RVA: 0x0002568C File Offset: 0x0002388C
		// (set) Token: 0x06000277 RID: 631 RVA: 0x000030F4 File Offset: 0x000012F4
		public unsafe Slider slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScalarOverrideSlider.NativeFieldInfoPtr_slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScalarOverrideSlider.NativeFieldInfoPtr_slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeFieldInfoPtr_warningLabel;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeFieldInfoPtr_slider;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnSlider_Public_Void_Single_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
