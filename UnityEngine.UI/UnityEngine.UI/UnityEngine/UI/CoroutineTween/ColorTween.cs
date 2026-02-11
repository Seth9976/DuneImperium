using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Events;

namespace UnityEngine.UI.CoroutineTween
{
	// Token: 0x02000048 RID: 72
	public sealed class ColorTween : ValueType
	{
		// Token: 0x06000870 RID: 2160 RVA: 0x00028460 File Offset: 0x00026660
		// Note: this type is marked as 'beforefieldinit'.
		static ColorTween()
		{
			Il2CppClassPointerStore<ColorTween>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI.CoroutineTween", "ColorTween");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorTween>.NativeClassPtr);
			ColorTween.NativeFieldInfoPtr_m_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "m_Target");
			ColorTween.NativeFieldInfoPtr_m_StartColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "m_StartColor");
			ColorTween.NativeFieldInfoPtr_m_TargetColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "m_TargetColor");
			ColorTween.NativeFieldInfoPtr_m_TweenMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "m_TweenMode");
			ColorTween.NativeFieldInfoPtr_m_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "m_Duration");
			ColorTween.NativeFieldInfoPtr_m_IgnoreTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "m_IgnoreTimeScale");
			ColorTween.NativeMethodInfoPtr_get_startColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664670);
			ColorTween.NativeMethodInfoPtr_set_startColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664671);
			ColorTween.NativeMethodInfoPtr_get_targetColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664672);
			ColorTween.NativeMethodInfoPtr_set_targetColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664673);
			ColorTween.NativeMethodInfoPtr_get_tweenMode_Public_get_ColorTweenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664674);
			ColorTween.NativeMethodInfoPtr_set_tweenMode_Public_set_Void_ColorTweenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664675);
			ColorTween.NativeMethodInfoPtr_get_duration_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664676);
			ColorTween.NativeMethodInfoPtr_set_duration_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664677);
			ColorTween.NativeMethodInfoPtr_get_ignoreTimeScale_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664678);
			ColorTween.NativeMethodInfoPtr_set_ignoreTimeScale_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664679);
			ColorTween.NativeMethodInfoPtr_TweenValue_Public_Virtual_Final_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664680);
			ColorTween.NativeMethodInfoPtr_AddOnChangedCallback_Public_Void_UnityAction_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664681);
			ColorTween.NativeMethodInfoPtr_GetIgnoreTimescale_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664682);
			ColorTween.NativeMethodInfoPtr_GetDuration_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664683);
			ColorTween.NativeMethodInfoPtr_ValidTarget_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664684);
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x00028634 File Offset: 0x00026834
		// (set) Token: 0x06000872 RID: 2162 RVA: 0x00028678 File Offset: 0x00026878
		public unsafe Color startColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_get_startColor_Public_get_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_set_startColor_Public_set_Void_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x000286BC File Offset: 0x000268BC
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x00028700 File Offset: 0x00026900
		public unsafe Color targetColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_get_targetColor_Public_get_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_set_targetColor_Public_set_Void_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x00028744 File Offset: 0x00026944
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x00028788 File Offset: 0x00026988
		public unsafe ColorTween.ColorTweenMode tweenMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_get_tweenMode_Public_get_ColorTweenMode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_set_tweenMode_Public_set_Void_ColorTweenMode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x000287CC File Offset: 0x000269CC
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x00028810 File Offset: 0x00026A10
		public unsafe float duration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_get_duration_Public_Virtual_Final_New_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 318232, RefRangeEnd = 318235, XrefRangeStart = 318232, XrefRangeEnd = 318235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_set_duration_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x00028854 File Offset: 0x00026A54
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x00028898 File Offset: 0x00026A98
		public unsafe bool ignoreTimeScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_get_ignoreTimeScale_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_set_ignoreTimeScale_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x000288DC File Offset: 0x00026ADC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1094177, RefRangeEnd = 1094178, XrefRangeStart = 1094172, XrefRangeEnd = 1094177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TweenValue(float floatPercentage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref floatPercentage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_TweenValue_Public_Virtual_Final_New_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00028920 File Offset: 0x00026B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094178, XrefRangeEnd = 1094189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOnChangedCallback(UnityAction<Color> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_AddOnChangedCallback_Public_Void_UnityAction_1_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00028968 File Offset: 0x00026B68
		[CallerCount(0)]
		public unsafe bool GetIgnoreTimescale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_GetIgnoreTimescale_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x000289AC File Offset: 0x00026BAC
		[CallerCount(0)]
		public unsafe float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_GetDuration_Public_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x000289F0 File Offset: 0x00026BF0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 608772, RefRangeEnd = 608784, XrefRangeStart = 608772, XrefRangeEnd = 608784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_ValidTarget_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00004E25 File Offset: 0x00003025
		public ColorTween(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00004E2E File Offset: 0x0000302E
		public ColorTween()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorTween>.NativeClassPtr))
		{
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x00028A34 File Offset: 0x00026C34
		// (set) Token: 0x06000883 RID: 2179 RVA: 0x00004E40 File Offset: 0x00003040
		public unsafe ColorTween.ColorTweenCallback m_Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTween.NativeFieldInfoPtr_m_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorTween.ColorTweenCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTween.NativeFieldInfoPtr_m_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x00028A64 File Offset: 0x00026C64
		// (set) Token: 0x06000885 RID: 2181 RVA: 0x00004E5F File Offset: 0x0000305F
		public unsafe Color m_StartColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTween.NativeFieldInfoPtr_m_StartColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTween.NativeFieldInfoPtr_m_StartColor)) = value;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x00028A8C File Offset: 0x00026C8C
		// (set) Token: 0x06000887 RID: 2183 RVA: 0x00004E7A File Offset: 0x0000307A
		public unsafe Color m_TargetColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTween.NativeFieldInfoPtr_m_TargetColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTween.NativeFieldInfoPtr_m_TargetColor)) = value;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x00028AB4 File Offset: 0x00026CB4
		// (set) Token: 0x06000889 RID: 2185 RVA: 0x00004E95 File Offset: 0x00003095
		public unsafe ColorTween.ColorTweenMode m_TweenMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTween.NativeFieldInfoPtr_m_TweenMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTween.NativeFieldInfoPtr_m_TweenMode)) = value;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x00028ADC File Offset: 0x00026CDC
		// (set) Token: 0x0600088B RID: 2187 RVA: 0x00004EB0 File Offset: 0x000030B0
		public unsafe float m_Duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTween.NativeFieldInfoPtr_m_Duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTween.NativeFieldInfoPtr_m_Duration)) = value;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x00028B04 File Offset: 0x00026D04
		// (set) Token: 0x0600088D RID: 2189 RVA: 0x00004ECB File Offset: 0x000030CB
		public unsafe bool m_IgnoreTimeScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTween.NativeFieldInfoPtr_m_IgnoreTimeScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTween.NativeFieldInfoPtr_m_IgnoreTimeScale)) = value;
			}
		}

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeFieldInfoPtr_m_Target;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeFieldInfoPtr_m_StartColor;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetColor;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeFieldInfoPtr_m_TweenMode;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeFieldInfoPtr_m_Duration;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeFieldInfoPtr_m_IgnoreTimeScale;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeMethodInfoPtr_get_startColor_Public_get_Color_0;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeMethodInfoPtr_set_startColor_Public_set_Void_Color_0;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeMethodInfoPtr_get_targetColor_Public_get_Color_0;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeMethodInfoPtr_set_targetColor_Public_set_Void_Color_0;

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeMethodInfoPtr_get_tweenMode_Public_get_ColorTweenMode_0;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeMethodInfoPtr_set_tweenMode_Public_set_Void_ColorTweenMode_0;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeMethodInfoPtr_set_duration_Public_set_Void_Single_0;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreTimeScale_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeMethodInfoPtr_set_ignoreTimeScale_Public_set_Void_Boolean_0;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeMethodInfoPtr_TweenValue_Public_Virtual_Final_New_Void_Single_0;

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeMethodInfoPtr_AddOnChangedCallback_Public_Void_UnityAction_1_Color_0;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeMethodInfoPtr_GetIgnoreTimescale_Public_Boolean_0;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Single_0;

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeMethodInfoPtr_ValidTarget_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x020000C1 RID: 193
		public enum ColorTweenMode
		{
			// Token: 0x04000A3A RID: 2618
			All,
			// Token: 0x04000A3B RID: 2619
			RGB,
			// Token: 0x04000A3C RID: 2620
			Alpha
		}

		// Token: 0x020000C2 RID: 194
		public class ColorTweenCallback : UnityEvent<Color>
		{
			// Token: 0x06000D31 RID: 3377 RVA: 0x00007017 File Offset: 0x00005217
			// Note: this type is marked as 'beforefieldinit'.
			static ColorTweenCallback()
			{
				Il2CppClassPointerStore<ColorTween.ColorTweenCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "ColorTweenCallback");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorTween.ColorTweenCallback>.NativeClassPtr);
				ColorTween.ColorTweenCallback.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween.ColorTweenCallback>.NativeClassPtr, 100664685);
			}

			// Token: 0x06000D32 RID: 3378 RVA: 0x00038A4C File Offset: 0x00036C4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094169, XrefRangeEnd = 1094172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ColorTweenCallback()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorTween.ColorTweenCallback>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.ColorTweenCallback.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D33 RID: 3379 RVA: 0x0000704B File Offset: 0x0000524B
			public ColorTweenCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000A3D RID: 2621
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
