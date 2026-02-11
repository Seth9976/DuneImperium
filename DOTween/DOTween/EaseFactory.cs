using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace DG.Tweening
{
	// Token: 0x0200000B RID: 11
	public class EaseFactory : global::Il2CppSystem.Object
	{
		// Token: 0x060000AE RID: 174 RVA: 0x00008434 File Offset: 0x00006634
		// Note: this type is marked as 'beforefieldinit'.
		static EaseFactory()
		{
			Il2CppClassPointerStore<EaseFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening", "EaseFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EaseFactory>.NativeClassPtr);
			EaseFactory.NativeMethodInfoPtr_StopMotion_Public_Static_EaseFunction_Int32_Nullable_1_Ease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseFactory>.NativeClassPtr, 100663403);
			EaseFactory.NativeMethodInfoPtr_StopMotion_Public_Static_EaseFunction_Int32_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseFactory>.NativeClassPtr, 100663404);
			EaseFactory.NativeMethodInfoPtr_StopMotion_Public_Static_EaseFunction_Int32_EaseFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseFactory>.NativeClassPtr, 100663405);
			EaseFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseFactory>.NativeClassPtr, 100663406);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000084B4 File Offset: 0x000066B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127783, XrefRangeEnd = 1127794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EaseFunction StopMotion(int motionFps, Nullable<Ease> ease = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motionFps;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ease));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseFactory.NativeMethodInfoPtr_StopMotion_Public_Static_EaseFunction_Int32_Nullable_1_Ease_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr3) : null;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000850C File Offset: 0x0000670C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127794, XrefRangeEnd = 1127809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EaseFunction StopMotion(int motionFps, AnimationCurve animCurve)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motionFps;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(animCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseFactory.NativeMethodInfoPtr_StopMotion_Public_Static_EaseFunction_Int32_AnimationCurve_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr3) : null;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00008560 File Offset: 0x00006760
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1127823, RefRangeEnd = 1127825, XrefRangeStart = 1127809, XrefRangeEnd = 1127823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EaseFunction StopMotion(int motionFps, EaseFunction customEase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motionFps;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customEase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseFactory.NativeMethodInfoPtr_StopMotion_Public_Static_EaseFunction_Int32_EaseFunction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr3) : null;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000085B4 File Offset: 0x000067B4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EaseFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EaseFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002297 File Offset: 0x00000497
		public EaseFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_StopMotion_Public_Static_EaseFunction_Int32_Nullable_1_Ease_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_StopMotion_Public_Static_EaseFunction_Int32_AnimationCurve_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_StopMotion_Public_Static_EaseFunction_Int32_EaseFunction_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000060 RID: 96
		[ObfuscatedName("DG.Tweening.EaseFactory+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600056C RID: 1388 RVA: 0x0001DAF8 File Offset: 0x0001BCF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<EaseFactory.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EaseFactory>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EaseFactory.__c__DisplayClass2_0>.NativeClassPtr);
				EaseFactory.__c__DisplayClass2_0.NativeFieldInfoPtr_motionDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseFactory.__c__DisplayClass2_0>.NativeClassPtr, "motionDelay");
				EaseFactory.__c__DisplayClass2_0.NativeFieldInfoPtr_customEase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EaseFactory.__c__DisplayClass2_0>.NativeClassPtr, "customEase");
				EaseFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseFactory.__c__DisplayClass2_0>.NativeClassPtr, 100663407);
				EaseFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__StopMotion_b__0_Internal_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseFactory.__c__DisplayClass2_0>.NativeClassPtr, 100663408);
			}

			// Token: 0x0600056D RID: 1389 RVA: 0x0001DB74 File Offset: 0x0001BD74
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EaseFactory.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600056E RID: 1390 RVA: 0x0001DBB0 File Offset: 0x0001BDB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127781, XrefRangeEnd = 1127783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _StopMotion_b__0(float time, float duration, float overshootOrAmplitude, float period)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EaseFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__StopMotion_b__0_Internal_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600056F RID: 1391 RVA: 0x00003C68 File Offset: 0x00001E68
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000105 RID: 261
			// (get) Token: 0x06000570 RID: 1392 RVA: 0x0001DC24 File Offset: 0x0001BE24
			// (set) Token: 0x06000571 RID: 1393 RVA: 0x00003C71 File Offset: 0x00001E71
			public unsafe float motionDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EaseFactory.__c__DisplayClass2_0.NativeFieldInfoPtr_motionDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EaseFactory.__c__DisplayClass2_0.NativeFieldInfoPtr_motionDelay)) = value;
				}
			}

			// Token: 0x17000106 RID: 262
			// (get) Token: 0x06000572 RID: 1394 RVA: 0x0001DC4C File Offset: 0x0001BE4C
			// (set) Token: 0x06000573 RID: 1395 RVA: 0x00003C8C File Offset: 0x00001E8C
			public unsafe EaseFunction customEase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EaseFactory.__c__DisplayClass2_0.NativeFieldInfoPtr_customEase);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EaseFactory.__c__DisplayClass2_0.NativeFieldInfoPtr_customEase), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400045E RID: 1118
			private static readonly IntPtr NativeFieldInfoPtr_motionDelay;

			// Token: 0x0400045F RID: 1119
			private static readonly IntPtr NativeFieldInfoPtr_customEase;

			// Token: 0x04000460 RID: 1120
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000461 RID: 1121
			private static readonly IntPtr NativeMethodInfoPtr__StopMotion_b__0_Internal_Single_Single_Single_Single_Single_0;
		}
	}
}
