using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace TMPro
{
	// Token: 0x02000029 RID: 41
	public sealed class ColorTween : ValueType
	{
		// Token: 0x0600039D RID: 925 RVA: 0x0001536C File Offset: 0x0001356C
		// Note: this type is marked as 'beforefieldinit'.
		static ColorTween()
		{
			Il2CppClassPointerStore<ColorTween>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "ColorTween");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorTween>.NativeClassPtr);
			ColorTween.NativeFieldInfoPtr_m_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "m_Target");
			ColorTween.NativeFieldInfoPtr_m_StartColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "m_StartColor");
			ColorTween.NativeFieldInfoPtr_m_TargetColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "m_TargetColor");
			ColorTween.NativeFieldInfoPtr_m_TweenMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "m_TweenMode");
			ColorTween.NativeFieldInfoPtr_m_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "m_Duration");
			ColorTween.NativeFieldInfoPtr_m_IgnoreTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "m_IgnoreTimeScale");
			ColorTween.NativeMethodInfoPtr_get_startColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663628);
			ColorTween.NativeMethodInfoPtr_set_startColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663629);
			ColorTween.NativeMethodInfoPtr_get_targetColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663630);
			ColorTween.NativeMethodInfoPtr_set_targetColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663631);
			ColorTween.NativeMethodInfoPtr_get_tweenMode_Public_get_ColorTweenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663632);
			ColorTween.NativeMethodInfoPtr_set_tweenMode_Public_set_Void_ColorTweenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663633);
			ColorTween.NativeMethodInfoPtr_get_duration_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663634);
			ColorTween.NativeMethodInfoPtr_set_duration_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663635);
			ColorTween.NativeMethodInfoPtr_get_ignoreTimeScale_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663636);
			ColorTween.NativeMethodInfoPtr_set_ignoreTimeScale_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663637);
			ColorTween.NativeMethodInfoPtr_TweenValue_Public_Virtual_Final_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663638);
			ColorTween.NativeMethodInfoPtr_AddOnChangedCallback_Public_Void_UnityAction_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663639);
			ColorTween.NativeMethodInfoPtr_GetIgnoreTimescale_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663640);
			ColorTween.NativeMethodInfoPtr_GetDuration_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663641);
			ColorTween.NativeMethodInfoPtr_ValidTarget_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663642);
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00015540 File Offset: 0x00013740
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00015584 File Offset: 0x00013784
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

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x000155C8 File Offset: 0x000137C8
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x0001560C File Offset: 0x0001380C
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

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00015650 File Offset: 0x00013850
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x00015694 File Offset: 0x00013894
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

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x000156D8 File Offset: 0x000138D8
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x0001571C File Offset: 0x0001391C
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

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x00015760 File Offset: 0x00013960
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x000157A4 File Offset: 0x000139A4
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

		// Token: 0x060003A8 RID: 936 RVA: 0x000157E8 File Offset: 0x000139E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038121, XrefRangeEnd = 1038126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003A9 RID: 937 RVA: 0x0001582C File Offset: 0x00013A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038126, XrefRangeEnd = 1038137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003AA RID: 938 RVA: 0x00015874 File Offset: 0x00013A74
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

		// Token: 0x060003AB RID: 939 RVA: 0x000158B8 File Offset: 0x00013AB8
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

		// Token: 0x060003AC RID: 940 RVA: 0x000158FC File Offset: 0x00013AFC
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

		// Token: 0x060003AD RID: 941 RVA: 0x00003DB1 File Offset: 0x00001FB1
		public ColorTween(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00003DBA File Offset: 0x00001FBA
		public ColorTween()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorTween>.NativeClassPtr))
		{
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00015940 File Offset: 0x00013B40
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x00003DCC File Offset: 0x00001FCC
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

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x00015970 File Offset: 0x00013B70
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x00003DEB File Offset: 0x00001FEB
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

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x00015998 File Offset: 0x00013B98
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x00003E06 File Offset: 0x00002006
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

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x000159C0 File Offset: 0x00013BC0
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x00003E21 File Offset: 0x00002021
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

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x000159E8 File Offset: 0x00013BE8
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00003E3C File Offset: 0x0000203C
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

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00015A10 File Offset: 0x00013C10
		// (set) Token: 0x060003BA RID: 954 RVA: 0x00003E57 File Offset: 0x00002057
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

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeFieldInfoPtr_m_Target;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeFieldInfoPtr_m_StartColor;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetColor;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeFieldInfoPtr_m_TweenMode;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeFieldInfoPtr_m_Duration;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeFieldInfoPtr_m_IgnoreTimeScale;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_get_startColor_Public_get_Color_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_set_startColor_Public_set_Void_Color_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_get_targetColor_Public_get_Color_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr_set_targetColor_Public_set_Void_Color_0;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr_get_tweenMode_Public_get_ColorTweenMode_0;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr_set_tweenMode_Public_set_Void_ColorTweenMode_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_set_duration_Public_set_Void_Single_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreTimeScale_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_set_ignoreTimeScale_Public_set_Void_Boolean_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_TweenValue_Public_Virtual_Final_New_Void_Single_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_AddOnChangedCallback_Public_Void_UnityAction_1_Color_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_GetIgnoreTimescale_Public_Boolean_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Single_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_ValidTarget_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0200007C RID: 124
		public enum ColorTweenMode
		{
			// Token: 0x04000BA5 RID: 2981
			All,
			// Token: 0x04000BA6 RID: 2982
			RGB,
			// Token: 0x04000BA7 RID: 2983
			Alpha
		}

		// Token: 0x0200007D RID: 125
		public class ColorTweenCallback : UnityEvent<Color>
		{
			// Token: 0x06000EB1 RID: 3761 RVA: 0x00008EA9 File Offset: 0x000070A9
			// Note: this type is marked as 'beforefieldinit'.
			static ColorTweenCallback()
			{
				Il2CppClassPointerStore<ColorTween.ColorTweenCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "ColorTweenCallback");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorTween.ColorTweenCallback>.NativeClassPtr);
				ColorTween.ColorTweenCallback.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween.ColorTweenCallback>.NativeClassPtr, 100663643);
			}

			// Token: 0x06000EB2 RID: 3762 RVA: 0x0003B3AC File Offset: 0x000395AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038118, XrefRangeEnd = 1038121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ColorTweenCallback()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorTween.ColorTweenCallback>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.ColorTweenCallback.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000EB3 RID: 3763 RVA: 0x00008EDD File Offset: 0x000070DD
			public ColorTweenCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000BA8 RID: 2984
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
