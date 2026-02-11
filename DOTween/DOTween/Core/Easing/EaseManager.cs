using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace DG.Tweening.Core.Easing
{
	// Token: 0x02000058 RID: 88
	public static class EaseManager : Object
	{
		// Token: 0x06000536 RID: 1334 RVA: 0x0001CF20 File Offset: 0x0001B120
		// Note: this type is marked as 'beforefieldinit'.
		static EaseManager()
		{
			Il2CppClassPointerStore<EaseManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core.Easing", "EaseManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EaseManager>.NativeClassPtr);
			EaseManager.NativeFieldInfoPtr__PiOver2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager>.NativeClassPtr, "_PiOver2");
			EaseManager.NativeFieldInfoPtr__TwoPi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager>.NativeClassPtr, "_TwoPi");
			EaseManager.NativeMethodInfoPtr_Evaluate_Public_Static_Single_Tween_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager>.NativeClassPtr, 100664287);
			EaseManager.NativeMethodInfoPtr_Evaluate_Public_Static_Single_Ease_EaseFunction_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager>.NativeClassPtr, 100664288);
			EaseManager.NativeMethodInfoPtr_ToEaseFunction_Public_Static_EaseFunction_Ease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager>.NativeClassPtr, 100664289);
			EaseManager.NativeMethodInfoPtr_IsFlashEase_Internal_Static_Boolean_Ease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager>.NativeClassPtr, 100664290);
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0001CFC8 File Offset: 0x0001B1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134825, XrefRangeEnd = 1134826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Evaluate(Tween t, float time, float duration, float overshootOrAmplitude, float period)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.NativeMethodInfoPtr_Evaluate_Public_Static_Single_Tween_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0001D044 File Offset: 0x0001B244
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1134945, RefRangeEnd = 1134971, XrefRangeStart = 1134826, XrefRangeEnd = 1134945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Evaluate(Ease easeType, EaseFunction customEase, float time, float duration, float overshootOrAmplitude, float period)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref easeType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customEase);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.NativeMethodInfoPtr_Evaluate_Public_Static_Single_Ease_EaseFunction_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0001D0CC File Offset: 0x0001B2CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1135441, RefRangeEnd = 1135442, XrefRangeStart = 1134971, XrefRangeEnd = 1135441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EaseFunction ToEaseFunction(Ease ease)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ease;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.NativeMethodInfoPtr_ToEaseFunction_Public_Static_EaseFunction_Ease_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr3) : null;
			}
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0001D10C File Offset: 0x0001B30C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1135442, RefRangeEnd = 1135445, XrefRangeStart = 1135442, XrefRangeEnd = 1135442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsFlashEase(Ease ease)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ease;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.NativeMethodInfoPtr_IsFlashEase_Internal_Static_Boolean_Ease_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00003B4B File Offset: 0x00001D4B
		public EaseManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x0001D14C File Offset: 0x0001B34C
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x00003B54 File Offset: 0x00001D54
		public unsafe static float _PiOver2
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(EaseManager.NativeFieldInfoPtr__PiOver2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EaseManager.NativeFieldInfoPtr__PiOver2, (void*)(&value));
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x0001D168 File Offset: 0x0001B368
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x00003B62 File Offset: 0x00001D62
		public unsafe static float _TwoPi
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(EaseManager.NativeFieldInfoPtr__TwoPi, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EaseManager.NativeFieldInfoPtr__TwoPi, (void*)(&value));
			}
		}

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeFieldInfoPtr__PiOver2;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeFieldInfoPtr__TwoPi;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Static_Single_Tween_Single_Single_Single_Single_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Static_Single_Ease_EaseFunction_Single_Single_Single_Single_0;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeMethodInfoPtr_ToEaseFunction_Public_Static_EaseFunction_Ease_0;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr_IsFlashEase_Internal_Static_Boolean_Ease_0;

		// Token: 0x020000F2 RID: 242
		[ObfuscatedName("DG.Tweening.Core.Easing.EaseManager+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000895 RID: 2197 RVA: 0x00027F38 File Offset: 0x00026138
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EaseManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr);
				EaseManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9");
				EaseManager.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_0");
				EaseManager.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_1");
				EaseManager.__c.NativeFieldInfoPtr___9__4_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_2");
				EaseManager.__c.NativeFieldInfoPtr___9__4_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_3");
				EaseManager.__c.NativeFieldInfoPtr___9__4_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_4");
				EaseManager.__c.NativeFieldInfoPtr___9__4_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_5");
				EaseManager.__c.NativeFieldInfoPtr___9__4_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_6");
				EaseManager.__c.NativeFieldInfoPtr___9__4_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_7");
				EaseManager.__c.NativeFieldInfoPtr___9__4_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_8");
				EaseManager.__c.NativeFieldInfoPtr___9__4_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_9");
				EaseManager.__c.NativeFieldInfoPtr___9__4_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_10");
				EaseManager.__c.NativeFieldInfoPtr___9__4_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_11");
				EaseManager.__c.NativeFieldInfoPtr___9__4_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_12");
				EaseManager.__c.NativeFieldInfoPtr___9__4_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_13");
				EaseManager.__c.NativeFieldInfoPtr___9__4_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_14");
				EaseManager.__c.NativeFieldInfoPtr___9__4_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_15");
				EaseManager.__c.NativeFieldInfoPtr___9__4_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_16");
				EaseManager.__c.NativeFieldInfoPtr___9__4_17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_17");
				EaseManager.__c.NativeFieldInfoPtr___9__4_18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_18");
				EaseManager.__c.NativeFieldInfoPtr___9__4_19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_19");
				EaseManager.__c.NativeFieldInfoPtr___9__4_20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_20");
				EaseManager.__c.NativeFieldInfoPtr___9__4_21 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_21");
				EaseManager.__c.NativeFieldInfoPtr___9__4_22 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_22");
				EaseManager.__c.NativeFieldInfoPtr___9__4_23 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_23");
				EaseManager.__c.NativeFieldInfoPtr___9__4_24 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_24");
				EaseManager.__c.NativeFieldInfoPtr___9__4_25 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_25");
				EaseManager.__c.NativeFieldInfoPtr___9__4_26 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_26");
				EaseManager.__c.NativeFieldInfoPtr___9__4_27 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_27");
				EaseManager.__c.NativeFieldInfoPtr___9__4_28 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_28");
				EaseManager.__c.NativeFieldInfoPtr___9__4_29 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_29");
				EaseManager.__c.NativeFieldInfoPtr___9__4_30 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_30");
				EaseManager.__c.NativeFieldInfoPtr___9__4_31 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_31");
				EaseManager.__c.NativeFieldInfoPtr___9__4_32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_32");
				EaseManager.__c.NativeFieldInfoPtr___9__4_33 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_33");
				EaseManager.__c.NativeFieldInfoPtr___9__4_34 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_34");
				EaseManager.__c.NativeFieldInfoPtr___9__4_35 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, "<>9__4_35");
				EaseManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664292);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_0_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664293);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_1_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664294);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_2_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664295);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_3_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664296);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_4_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664297);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_5_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664298);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_6_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664299);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_7_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664300);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_8_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664301);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_9_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664302);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_10_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664303);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_11_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664304);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_12_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664305);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_13_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664306);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_14_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664307);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_15_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664308);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_16_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664309);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_17_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664310);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_18_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664311);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_19_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664312);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_20_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664313);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_21_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664314);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_22_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664315);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_23_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664316);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_24_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664317);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_25_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664318);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_26_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664319);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_27_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664320);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_28_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664321);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_29_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664322);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_30_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664323);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_31_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664324);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_32_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664325);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_33_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664326);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_34_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664327);
				EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_35_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr, 100664328);
			}

			// Token: 0x06000896 RID: 2198 RVA: 0x0002852C File Offset: 0x0002672C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EaseManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000897 RID: 2199 RVA: 0x00028568 File Offset: 0x00026768
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_0(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_0_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000898 RID: 2200 RVA: 0x000285DC File Offset: 0x000267DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134736, XrefRangeEnd = 1134740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_1(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_1_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000899 RID: 2201 RVA: 0x00028650 File Offset: 0x00026850
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134740, XrefRangeEnd = 1134744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_2(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_2_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600089A RID: 2202 RVA: 0x000286C4 File Offset: 0x000268C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134744, XrefRangeEnd = 1134748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_3(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_3_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600089B RID: 2203 RVA: 0x00028738 File Offset: 0x00026938
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_4(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_4_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600089C RID: 2204 RVA: 0x000287AC File Offset: 0x000269AC
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_5(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_5_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600089D RID: 2205 RVA: 0x00028820 File Offset: 0x00026A20
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_6(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_6_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600089E RID: 2206 RVA: 0x00028894 File Offset: 0x00026A94
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_7(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_7_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600089F RID: 2207 RVA: 0x00028908 File Offset: 0x00026B08
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_8(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_8_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008A0 RID: 2208 RVA: 0x0002897C File Offset: 0x00026B7C
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_9(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_9_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008A1 RID: 2209 RVA: 0x000289F0 File Offset: 0x00026BF0
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_10(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_10_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008A2 RID: 2210 RVA: 0x00028A64 File Offset: 0x00026C64
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_11(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_11_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008A3 RID: 2211 RVA: 0x00028AD8 File Offset: 0x00026CD8
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_12(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_12_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008A4 RID: 2212 RVA: 0x00028B4C File Offset: 0x00026D4C
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_13(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_13_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008A5 RID: 2213 RVA: 0x00028BC0 File Offset: 0x00026DC0
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_14(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_14_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008A6 RID: 2214 RVA: 0x00028C34 File Offset: 0x00026E34
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_15(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_15_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008A7 RID: 2215 RVA: 0x00028CA8 File Offset: 0x00026EA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134748, XrefRangeEnd = 1134752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_16(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_16_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008A8 RID: 2216 RVA: 0x00028D1C File Offset: 0x00026F1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134752, XrefRangeEnd = 1134753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_17(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_17_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008A9 RID: 2217 RVA: 0x00028D90 File Offset: 0x00026F90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134753, XrefRangeEnd = 1134754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_18(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_18_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008AA RID: 2218 RVA: 0x00028E04 File Offset: 0x00027004
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134754, XrefRangeEnd = 1134759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_19(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_19_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008AB RID: 2219 RVA: 0x00028E78 File Offset: 0x00027078
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134759, XrefRangeEnd = 1134762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_20(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_20_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008AC RID: 2220 RVA: 0x00028EEC File Offset: 0x000270EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134762, XrefRangeEnd = 1134767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_21(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_21_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008AD RID: 2221 RVA: 0x00028F60 File Offset: 0x00027160
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134767, XrefRangeEnd = 1134776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_22(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_22_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008AE RID: 2222 RVA: 0x00028FD4 File Offset: 0x000271D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134776, XrefRangeEnd = 1134786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_23(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_23_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008AF RID: 2223 RVA: 0x00029048 File Offset: 0x00027248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134786, XrefRangeEnd = 1134801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_24(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_24_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008B0 RID: 2224 RVA: 0x000290BC File Offset: 0x000272BC
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_25(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_25_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008B1 RID: 2225 RVA: 0x00029130 File Offset: 0x00027330
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_26(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_26_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008B2 RID: 2226 RVA: 0x000291A4 File Offset: 0x000273A4
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_27(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_27_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008B3 RID: 2227 RVA: 0x00029218 File Offset: 0x00027418
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134801, XrefRangeEnd = 1134802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_28(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_28_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008B4 RID: 2228 RVA: 0x0002928C File Offset: 0x0002748C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134802, XrefRangeEnd = 1134803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_29(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_29_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008B5 RID: 2229 RVA: 0x00029300 File Offset: 0x00027500
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134803, XrefRangeEnd = 1134804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_30(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_30_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008B6 RID: 2230 RVA: 0x00029374 File Offset: 0x00027574
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134804, XrefRangeEnd = 1134809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_31(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_31_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008B7 RID: 2231 RVA: 0x000293E8 File Offset: 0x000275E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134809, XrefRangeEnd = 1134814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_32(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_32_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008B8 RID: 2232 RVA: 0x0002945C File Offset: 0x0002765C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134814, XrefRangeEnd = 1134819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_33(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_33_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008B9 RID: 2233 RVA: 0x000294D0 File Offset: 0x000276D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134819, XrefRangeEnd = 1134825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ToEaseFunction_b__4_34(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_34_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008BA RID: 2234 RVA: 0x00029544 File Offset: 0x00027744
			[CallerCount(0)]
			public unsafe float _ToEaseFunction_b__4_35(float time, float duration, float overshootOrAmplitude, float period)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref time;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshootOrAmplitude;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseManager.__c.NativeMethodInfoPtr__ToEaseFunction_b__4_35_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060008BB RID: 2235 RVA: 0x00005013 File Offset: 0x00003213
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700019D RID: 413
			// (get) Token: 0x060008BC RID: 2236 RVA: 0x000295B8 File Offset: 0x000277B8
			// (set) Token: 0x060008BD RID: 2237 RVA: 0x0000501C File Offset: 0x0000321C
			public unsafe static EaseManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700019E RID: 414
			// (get) Token: 0x060008BE RID: 2238 RVA: 0x000295E0 File Offset: 0x000277E0
			// (set) Token: 0x060008BF RID: 2239 RVA: 0x0000502E File Offset: 0x0000322E
			public unsafe static EaseFunction __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700019F RID: 415
			// (get) Token: 0x060008C0 RID: 2240 RVA: 0x00029608 File Offset: 0x00027808
			// (set) Token: 0x060008C1 RID: 2241 RVA: 0x00005040 File Offset: 0x00003240
			public unsafe static EaseFunction __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001A0 RID: 416
			// (get) Token: 0x060008C2 RID: 2242 RVA: 0x00029630 File Offset: 0x00027830
			// (set) Token: 0x060008C3 RID: 2243 RVA: 0x00005052 File Offset: 0x00003252
			public unsafe static EaseFunction __9__4_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001A1 RID: 417
			// (get) Token: 0x060008C4 RID: 2244 RVA: 0x00029658 File Offset: 0x00027858
			// (set) Token: 0x060008C5 RID: 2245 RVA: 0x00005064 File Offset: 0x00003264
			public unsafe static EaseFunction __9__4_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001A2 RID: 418
			// (get) Token: 0x060008C6 RID: 2246 RVA: 0x00029680 File Offset: 0x00027880
			// (set) Token: 0x060008C7 RID: 2247 RVA: 0x00005076 File Offset: 0x00003276
			public unsafe static EaseFunction __9__4_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001A3 RID: 419
			// (get) Token: 0x060008C8 RID: 2248 RVA: 0x000296A8 File Offset: 0x000278A8
			// (set) Token: 0x060008C9 RID: 2249 RVA: 0x00005088 File Offset: 0x00003288
			public unsafe static EaseFunction __9__4_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001A4 RID: 420
			// (get) Token: 0x060008CA RID: 2250 RVA: 0x000296D0 File Offset: 0x000278D0
			// (set) Token: 0x060008CB RID: 2251 RVA: 0x0000509A File Offset: 0x0000329A
			public unsafe static EaseFunction __9__4_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001A5 RID: 421
			// (get) Token: 0x060008CC RID: 2252 RVA: 0x000296F8 File Offset: 0x000278F8
			// (set) Token: 0x060008CD RID: 2253 RVA: 0x000050AC File Offset: 0x000032AC
			public unsafe static EaseFunction __9__4_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001A6 RID: 422
			// (get) Token: 0x060008CE RID: 2254 RVA: 0x00029720 File Offset: 0x00027920
			// (set) Token: 0x060008CF RID: 2255 RVA: 0x000050BE File Offset: 0x000032BE
			public unsafe static EaseFunction __9__4_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001A7 RID: 423
			// (get) Token: 0x060008D0 RID: 2256 RVA: 0x00029748 File Offset: 0x00027948
			// (set) Token: 0x060008D1 RID: 2257 RVA: 0x000050D0 File Offset: 0x000032D0
			public unsafe static EaseFunction __9__4_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001A8 RID: 424
			// (get) Token: 0x060008D2 RID: 2258 RVA: 0x00029770 File Offset: 0x00027970
			// (set) Token: 0x060008D3 RID: 2259 RVA: 0x000050E2 File Offset: 0x000032E2
			public unsafe static EaseFunction __9__4_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001A9 RID: 425
			// (get) Token: 0x060008D4 RID: 2260 RVA: 0x00029798 File Offset: 0x00027998
			// (set) Token: 0x060008D5 RID: 2261 RVA: 0x000050F4 File Offset: 0x000032F4
			public unsafe static EaseFunction __9__4_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001AA RID: 426
			// (get) Token: 0x060008D6 RID: 2262 RVA: 0x000297C0 File Offset: 0x000279C0
			// (set) Token: 0x060008D7 RID: 2263 RVA: 0x00005106 File Offset: 0x00003306
			public unsafe static EaseFunction __9__4_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001AB RID: 427
			// (get) Token: 0x060008D8 RID: 2264 RVA: 0x000297E8 File Offset: 0x000279E8
			// (set) Token: 0x060008D9 RID: 2265 RVA: 0x00005118 File Offset: 0x00003318
			public unsafe static EaseFunction __9__4_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001AC RID: 428
			// (get) Token: 0x060008DA RID: 2266 RVA: 0x00029810 File Offset: 0x00027A10
			// (set) Token: 0x060008DB RID: 2267 RVA: 0x0000512A File Offset: 0x0000332A
			public unsafe static EaseFunction __9__4_14
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_14, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_14, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001AD RID: 429
			// (get) Token: 0x060008DC RID: 2268 RVA: 0x00029838 File Offset: 0x00027A38
			// (set) Token: 0x060008DD RID: 2269 RVA: 0x0000513C File Offset: 0x0000333C
			public unsafe static EaseFunction __9__4_15
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_15, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_15, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001AE RID: 430
			// (get) Token: 0x060008DE RID: 2270 RVA: 0x00029860 File Offset: 0x00027A60
			// (set) Token: 0x060008DF RID: 2271 RVA: 0x0000514E File Offset: 0x0000334E
			public unsafe static EaseFunction __9__4_16
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_16, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_16, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001AF RID: 431
			// (get) Token: 0x060008E0 RID: 2272 RVA: 0x00029888 File Offset: 0x00027A88
			// (set) Token: 0x060008E1 RID: 2273 RVA: 0x00005160 File Offset: 0x00003360
			public unsafe static EaseFunction __9__4_17
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_17, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_17, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001B0 RID: 432
			// (get) Token: 0x060008E2 RID: 2274 RVA: 0x000298B0 File Offset: 0x00027AB0
			// (set) Token: 0x060008E3 RID: 2275 RVA: 0x00005172 File Offset: 0x00003372
			public unsafe static EaseFunction __9__4_18
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_18, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_18, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001B1 RID: 433
			// (get) Token: 0x060008E4 RID: 2276 RVA: 0x000298D8 File Offset: 0x00027AD8
			// (set) Token: 0x060008E5 RID: 2277 RVA: 0x00005184 File Offset: 0x00003384
			public unsafe static EaseFunction __9__4_19
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_19, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_19, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001B2 RID: 434
			// (get) Token: 0x060008E6 RID: 2278 RVA: 0x00029900 File Offset: 0x00027B00
			// (set) Token: 0x060008E7 RID: 2279 RVA: 0x00005196 File Offset: 0x00003396
			public unsafe static EaseFunction __9__4_20
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_20, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_20, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001B3 RID: 435
			// (get) Token: 0x060008E8 RID: 2280 RVA: 0x00029928 File Offset: 0x00027B28
			// (set) Token: 0x060008E9 RID: 2281 RVA: 0x000051A8 File Offset: 0x000033A8
			public unsafe static EaseFunction __9__4_21
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_21, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_21, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001B4 RID: 436
			// (get) Token: 0x060008EA RID: 2282 RVA: 0x00029950 File Offset: 0x00027B50
			// (set) Token: 0x060008EB RID: 2283 RVA: 0x000051BA File Offset: 0x000033BA
			public unsafe static EaseFunction __9__4_22
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_22, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_22, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001B5 RID: 437
			// (get) Token: 0x060008EC RID: 2284 RVA: 0x00029978 File Offset: 0x00027B78
			// (set) Token: 0x060008ED RID: 2285 RVA: 0x000051CC File Offset: 0x000033CC
			public unsafe static EaseFunction __9__4_23
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_23, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_23, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001B6 RID: 438
			// (get) Token: 0x060008EE RID: 2286 RVA: 0x000299A0 File Offset: 0x00027BA0
			// (set) Token: 0x060008EF RID: 2287 RVA: 0x000051DE File Offset: 0x000033DE
			public unsafe static EaseFunction __9__4_24
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_24, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_24, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001B7 RID: 439
			// (get) Token: 0x060008F0 RID: 2288 RVA: 0x000299C8 File Offset: 0x00027BC8
			// (set) Token: 0x060008F1 RID: 2289 RVA: 0x000051F0 File Offset: 0x000033F0
			public unsafe static EaseFunction __9__4_25
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_25, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_25, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001B8 RID: 440
			// (get) Token: 0x060008F2 RID: 2290 RVA: 0x000299F0 File Offset: 0x00027BF0
			// (set) Token: 0x060008F3 RID: 2291 RVA: 0x00005202 File Offset: 0x00003402
			public unsafe static EaseFunction __9__4_26
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_26, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_26, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001B9 RID: 441
			// (get) Token: 0x060008F4 RID: 2292 RVA: 0x00029A18 File Offset: 0x00027C18
			// (set) Token: 0x060008F5 RID: 2293 RVA: 0x00005214 File Offset: 0x00003414
			public unsafe static EaseFunction __9__4_27
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_27, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_27, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001BA RID: 442
			// (get) Token: 0x060008F6 RID: 2294 RVA: 0x00029A40 File Offset: 0x00027C40
			// (set) Token: 0x060008F7 RID: 2295 RVA: 0x00005226 File Offset: 0x00003426
			public unsafe static EaseFunction __9__4_28
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_28, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_28, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001BB RID: 443
			// (get) Token: 0x060008F8 RID: 2296 RVA: 0x00029A68 File Offset: 0x00027C68
			// (set) Token: 0x060008F9 RID: 2297 RVA: 0x00005238 File Offset: 0x00003438
			public unsafe static EaseFunction __9__4_29
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_29, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_29, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001BC RID: 444
			// (get) Token: 0x060008FA RID: 2298 RVA: 0x00029A90 File Offset: 0x00027C90
			// (set) Token: 0x060008FB RID: 2299 RVA: 0x0000524A File Offset: 0x0000344A
			public unsafe static EaseFunction __9__4_30
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_30, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_30, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001BD RID: 445
			// (get) Token: 0x060008FC RID: 2300 RVA: 0x00029AB8 File Offset: 0x00027CB8
			// (set) Token: 0x060008FD RID: 2301 RVA: 0x0000525C File Offset: 0x0000345C
			public unsafe static EaseFunction __9__4_31
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_31, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_31, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001BE RID: 446
			// (get) Token: 0x060008FE RID: 2302 RVA: 0x00029AE0 File Offset: 0x00027CE0
			// (set) Token: 0x060008FF RID: 2303 RVA: 0x0000526E File Offset: 0x0000346E
			public unsafe static EaseFunction __9__4_32
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_32, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_32, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001BF RID: 447
			// (get) Token: 0x06000900 RID: 2304 RVA: 0x00029B08 File Offset: 0x00027D08
			// (set) Token: 0x06000901 RID: 2305 RVA: 0x00005280 File Offset: 0x00003480
			public unsafe static EaseFunction __9__4_33
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_33, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_33, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001C0 RID: 448
			// (get) Token: 0x06000902 RID: 2306 RVA: 0x00029B30 File Offset: 0x00027D30
			// (set) Token: 0x06000903 RID: 2307 RVA: 0x00005292 File Offset: 0x00003492
			public unsafe static EaseFunction __9__4_34
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_34, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_34, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001C1 RID: 449
			// (get) Token: 0x06000904 RID: 2308 RVA: 0x00029B58 File Offset: 0x00027D58
			// (set) Token: 0x06000905 RID: 2309 RVA: 0x000052A4 File Offset: 0x000034A4
			public unsafe static EaseFunction __9__4_35
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EaseManager.__c.NativeFieldInfoPtr___9__4_35, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EaseManager.__c.NativeFieldInfoPtr___9__4_35, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400064D RID: 1613
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400064E RID: 1614
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x0400064F RID: 1615
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x04000650 RID: 1616
			private static readonly IntPtr NativeFieldInfoPtr___9__4_2;

			// Token: 0x04000651 RID: 1617
			private static readonly IntPtr NativeFieldInfoPtr___9__4_3;

			// Token: 0x04000652 RID: 1618
			private static readonly IntPtr NativeFieldInfoPtr___9__4_4;

			// Token: 0x04000653 RID: 1619
			private static readonly IntPtr NativeFieldInfoPtr___9__4_5;

			// Token: 0x04000654 RID: 1620
			private static readonly IntPtr NativeFieldInfoPtr___9__4_6;

			// Token: 0x04000655 RID: 1621
			private static readonly IntPtr NativeFieldInfoPtr___9__4_7;

			// Token: 0x04000656 RID: 1622
			private static readonly IntPtr NativeFieldInfoPtr___9__4_8;

			// Token: 0x04000657 RID: 1623
			private static readonly IntPtr NativeFieldInfoPtr___9__4_9;

			// Token: 0x04000658 RID: 1624
			private static readonly IntPtr NativeFieldInfoPtr___9__4_10;

			// Token: 0x04000659 RID: 1625
			private static readonly IntPtr NativeFieldInfoPtr___9__4_11;

			// Token: 0x0400065A RID: 1626
			private static readonly IntPtr NativeFieldInfoPtr___9__4_12;

			// Token: 0x0400065B RID: 1627
			private static readonly IntPtr NativeFieldInfoPtr___9__4_13;

			// Token: 0x0400065C RID: 1628
			private static readonly IntPtr NativeFieldInfoPtr___9__4_14;

			// Token: 0x0400065D RID: 1629
			private static readonly IntPtr NativeFieldInfoPtr___9__4_15;

			// Token: 0x0400065E RID: 1630
			private static readonly IntPtr NativeFieldInfoPtr___9__4_16;

			// Token: 0x0400065F RID: 1631
			private static readonly IntPtr NativeFieldInfoPtr___9__4_17;

			// Token: 0x04000660 RID: 1632
			private static readonly IntPtr NativeFieldInfoPtr___9__4_18;

			// Token: 0x04000661 RID: 1633
			private static readonly IntPtr NativeFieldInfoPtr___9__4_19;

			// Token: 0x04000662 RID: 1634
			private static readonly IntPtr NativeFieldInfoPtr___9__4_20;

			// Token: 0x04000663 RID: 1635
			private static readonly IntPtr NativeFieldInfoPtr___9__4_21;

			// Token: 0x04000664 RID: 1636
			private static readonly IntPtr NativeFieldInfoPtr___9__4_22;

			// Token: 0x04000665 RID: 1637
			private static readonly IntPtr NativeFieldInfoPtr___9__4_23;

			// Token: 0x04000666 RID: 1638
			private static readonly IntPtr NativeFieldInfoPtr___9__4_24;

			// Token: 0x04000667 RID: 1639
			private static readonly IntPtr NativeFieldInfoPtr___9__4_25;

			// Token: 0x04000668 RID: 1640
			private static readonly IntPtr NativeFieldInfoPtr___9__4_26;

			// Token: 0x04000669 RID: 1641
			private static readonly IntPtr NativeFieldInfoPtr___9__4_27;

			// Token: 0x0400066A RID: 1642
			private static readonly IntPtr NativeFieldInfoPtr___9__4_28;

			// Token: 0x0400066B RID: 1643
			private static readonly IntPtr NativeFieldInfoPtr___9__4_29;

			// Token: 0x0400066C RID: 1644
			private static readonly IntPtr NativeFieldInfoPtr___9__4_30;

			// Token: 0x0400066D RID: 1645
			private static readonly IntPtr NativeFieldInfoPtr___9__4_31;

			// Token: 0x0400066E RID: 1646
			private static readonly IntPtr NativeFieldInfoPtr___9__4_32;

			// Token: 0x0400066F RID: 1647
			private static readonly IntPtr NativeFieldInfoPtr___9__4_33;

			// Token: 0x04000670 RID: 1648
			private static readonly IntPtr NativeFieldInfoPtr___9__4_34;

			// Token: 0x04000671 RID: 1649
			private static readonly IntPtr NativeFieldInfoPtr___9__4_35;

			// Token: 0x04000672 RID: 1650
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000673 RID: 1651
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_0_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x04000674 RID: 1652
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_1_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x04000675 RID: 1653
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_2_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x04000676 RID: 1654
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_3_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x04000677 RID: 1655
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_4_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x04000678 RID: 1656
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_5_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x04000679 RID: 1657
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_6_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x0400067A RID: 1658
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_7_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x0400067B RID: 1659
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_8_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x0400067C RID: 1660
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_9_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x0400067D RID: 1661
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_10_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x0400067E RID: 1662
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_11_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x0400067F RID: 1663
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_12_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x04000680 RID: 1664
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_13_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x04000681 RID: 1665
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_14_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x04000682 RID: 1666
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_15_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x04000683 RID: 1667
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_16_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x04000684 RID: 1668
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_17_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x04000685 RID: 1669
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_18_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x04000686 RID: 1670
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_19_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x04000687 RID: 1671
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_20_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x04000688 RID: 1672
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_21_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x04000689 RID: 1673
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_22_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x0400068A RID: 1674
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_23_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x0400068B RID: 1675
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_24_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x0400068C RID: 1676
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_25_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x0400068D RID: 1677
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_26_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x0400068E RID: 1678
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_27_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x0400068F RID: 1679
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_28_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x04000690 RID: 1680
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_29_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x04000691 RID: 1681
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_30_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x04000692 RID: 1682
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_31_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x04000693 RID: 1683
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_32_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x04000694 RID: 1684
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_33_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x04000695 RID: 1685
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_34_Internal_Single_Single_Single_Single_Single_0;

			// Token: 0x04000696 RID: 1686
			private static readonly IntPtr NativeMethodInfoPtr__ToEaseFunction_b__4_35_Internal_Single_Single_Single_Single_Single_0;
		}
	}
}
