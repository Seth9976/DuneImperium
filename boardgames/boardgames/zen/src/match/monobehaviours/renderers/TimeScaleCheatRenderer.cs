using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace zen.src.match.monobehaviours.renderers
{
	// Token: 0x0200007B RID: 123
	public class TimeScaleCheatRenderer : MonoBehaviour
	{
		// Token: 0x06000657 RID: 1623 RVA: 0x00024854 File Offset: 0x00022A54
		// Note: this type is marked as 'beforefieldinit'.
		static TimeScaleCheatRenderer()
		{
			Il2CppClassPointerStore<TimeScaleCheatRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.match.monobehaviours.renderers", "TimeScaleCheatRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeScaleCheatRenderer>.NativeClassPtr);
			TimeScaleCheatRenderer.NativeFieldInfoPtr_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeScaleCheatRenderer>.NativeClassPtr, "slider");
			TimeScaleCheatRenderer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeScaleCheatRenderer>.NativeClassPtr, 100664281);
			TimeScaleCheatRenderer.NativeMethodInfoPtr_OnValueChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeScaleCheatRenderer>.NativeClassPtr, 100664282);
			TimeScaleCheatRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeScaleCheatRenderer>.NativeClassPtr, 100664283);
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x000248D4 File Offset: 0x00022AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988540, XrefRangeEnd = 988545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeScaleCheatRenderer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00024908 File Offset: 0x00022B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988545, XrefRangeEnd = 988547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeScaleCheatRenderer.NativeMethodInfoPtr_OnValueChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0002493C File Offset: 0x00022B3C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeScaleCheatRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeScaleCheatRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeScaleCheatRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00004E39 File Offset: 0x00003039
		public TimeScaleCheatRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x00024978 File Offset: 0x00022B78
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x00004E42 File Offset: 0x00003042
		public unsafe Slider slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeScaleCheatRenderer.NativeFieldInfoPtr_slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeScaleCheatRenderer.NativeFieldInfoPtr_slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeFieldInfoPtr_slider;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Public_Void_0;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
