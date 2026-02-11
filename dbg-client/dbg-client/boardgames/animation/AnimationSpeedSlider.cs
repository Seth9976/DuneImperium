using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace boardgames.animation
{
	// Token: 0x020002BA RID: 698
	public class AnimationSpeedSlider : MonoBehaviour
	{
		// Token: 0x060020ED RID: 8429 RVA: 0x0008B0C4 File Offset: 0x000892C4
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationSpeedSlider()
		{
			Il2CppClassPointerStore<AnimationSpeedSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.animation", "AnimationSpeedSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationSpeedSlider>.NativeClassPtr);
			AnimationSpeedSlider.NativeFieldInfoPtr_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationSpeedSlider>.NativeClassPtr, "slider");
			AnimationSpeedSlider.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSpeedSlider>.NativeClassPtr, 100668753);
			AnimationSpeedSlider.NativeMethodInfoPtr_Event_OnSlider_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSpeedSlider>.NativeClassPtr, 100668754);
			AnimationSpeedSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSpeedSlider>.NativeClassPtr, 100668755);
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x0008B144 File Offset: 0x00089344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542850, XrefRangeEnd = 542862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSpeedSlider.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x0008B178 File Offset: 0x00089378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542862, XrefRangeEnd = 542897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OnSlider(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSpeedSlider.NativeMethodInfoPtr_Event_OnSlider_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x0008B1B8 File Offset: 0x000893B8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationSpeedSlider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationSpeedSlider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSpeedSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x000113AF File Offset: 0x0000F5AF
		public AnimationSpeedSlider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x060020F2 RID: 8434 RVA: 0x0008B1F4 File Offset: 0x000893F4
		// (set) Token: 0x060020F3 RID: 8435 RVA: 0x000113B8 File Offset: 0x0000F5B8
		public unsafe Slider slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSpeedSlider.NativeFieldInfoPtr_slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSpeedSlider.NativeFieldInfoPtr_slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014C2 RID: 5314
		private static readonly IntPtr NativeFieldInfoPtr_slider;

		// Token: 0x040014C3 RID: 5315
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040014C4 RID: 5316
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnSlider_Public_Void_Single_0;

		// Token: 0x040014C5 RID: 5317
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
