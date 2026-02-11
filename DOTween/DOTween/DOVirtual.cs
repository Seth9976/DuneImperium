using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace DG.Tweening
{
	// Token: 0x02000009 RID: 9
	public static class DOVirtual : global::Il2CppSystem.Object
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x000080EC File Offset: 0x000062EC
		// Note: this type is marked as 'beforefieldinit'.
		static DOVirtual()
		{
			Il2CppClassPointerStore<DOVirtual>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening", "DOVirtual");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOVirtual>.NativeClassPtr);
			DOVirtual.NativeMethodInfoPtr_Float_Public_Static_Tweener_Single_Single_Single_TweenCallback_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOVirtual>.NativeClassPtr, 100663393);
			DOVirtual.NativeMethodInfoPtr_EasedValue_Public_Static_Single_Single_Single_Single_Ease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOVirtual>.NativeClassPtr, 100663394);
			DOVirtual.NativeMethodInfoPtr_EasedValue_Public_Static_Single_Single_Single_Single_Ease_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOVirtual>.NativeClassPtr, 100663395);
			DOVirtual.NativeMethodInfoPtr_EasedValue_Public_Static_Single_Single_Single_Single_Ease_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOVirtual>.NativeClassPtr, 100663396);
			DOVirtual.NativeMethodInfoPtr_EasedValue_Public_Static_Single_Single_Single_Single_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOVirtual>.NativeClassPtr, 100663397);
			DOVirtual.NativeMethodInfoPtr_DelayedCall_Public_Static_Tween_Single_TweenCallback_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOVirtual>.NativeClassPtr, 100663398);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00008194 File Offset: 0x00006394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127704, XrefRangeEnd = 1127737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener Float(float from, float to, float duration, TweenCallback<float> onVirtualUpdate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onVirtualUpdate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOVirtual.NativeMethodInfoPtr_Float_Public_Static_Tweener_Single_Single_Single_TweenCallback_1_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00008204 File Offset: 0x00006404
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1127742, RefRangeEnd = 1127745, XrefRangeStart = 1127737, XrefRangeEnd = 1127742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lifetimePercentage;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref easeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOVirtual.NativeMethodInfoPtr_EasedValue_Public_Static_Single_Single_Single_Single_Ease_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000826C File Offset: 0x0000646C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127745, XrefRangeEnd = 1127750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float overshoot)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lifetimePercentage;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref easeType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshoot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOVirtual.NativeMethodInfoPtr_EasedValue_Public_Static_Single_Single_Single_Single_Ease_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000082E4 File Offset: 0x000064E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127750, XrefRangeEnd = 1127751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float amplitude, float period)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lifetimePercentage;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref easeType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amplitude;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOVirtual.NativeMethodInfoPtr_EasedValue_Public_Static_Single_Single_Single_Single_Ease_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00008368 File Offset: 0x00006568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127751, XrefRangeEnd = 1127768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EasedValue(float from, float to, float lifetimePercentage, AnimationCurve easeCurve)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lifetimePercentage;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(easeCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOVirtual.NativeMethodInfoPtr_EasedValue_Public_Static_Single_Single_Single_Single_AnimationCurve_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000083D4 File Offset: 0x000065D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127768, XrefRangeEnd = 1127781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tween DelayedCall(float delay, TweenCallback callback, bool ignoreTimeScale = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delay;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreTimeScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOVirtual.NativeMethodInfoPtr_DelayedCall_Public_Static_Tween_Single_TweenCallback_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tween>(intPtr3) : null;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000228E File Offset: 0x0000048E
		public DOVirtual(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_Float_Public_Static_Tweener_Single_Single_Single_TweenCallback_1_Single_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_EasedValue_Public_Static_Single_Single_Single_Single_Ease_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_EasedValue_Public_Static_Single_Single_Single_Single_Ease_Single_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_EasedValue_Public_Static_Single_Single_Single_Single_Ease_Single_Single_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_EasedValue_Public_Static_Single_Single_Single_Single_AnimationCurve_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_DelayedCall_Public_Static_Tween_Single_TweenCallback_Boolean_0;

		// Token: 0x0200005F RID: 95
		[ObfuscatedName("DG.Tweening.DOVirtual+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000562 RID: 1378 RVA: 0x0001D910 File Offset: 0x0001BB10
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<DOVirtual.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOVirtual>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOVirtual.__c__DisplayClass0_0>.NativeClassPtr);
				DOVirtual.__c__DisplayClass0_0.NativeFieldInfoPtr_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOVirtual.__c__DisplayClass0_0>.NativeClassPtr, "val");
				DOVirtual.__c__DisplayClass0_0.NativeFieldInfoPtr_onVirtualUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOVirtual.__c__DisplayClass0_0>.NativeClassPtr, "onVirtualUpdate");
				DOVirtual.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOVirtual.__c__DisplayClass0_0>.NativeClassPtr, 100663399);
				DOVirtual.__c__DisplayClass0_0.NativeMethodInfoPtr__Float_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOVirtual.__c__DisplayClass0_0>.NativeClassPtr, 100663400);
				DOVirtual.__c__DisplayClass0_0.NativeMethodInfoPtr__Float_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOVirtual.__c__DisplayClass0_0>.NativeClassPtr, 100663401);
				DOVirtual.__c__DisplayClass0_0.NativeMethodInfoPtr__Float_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOVirtual.__c__DisplayClass0_0>.NativeClassPtr, 100663402);
			}

			// Token: 0x06000563 RID: 1379 RVA: 0x0001D9B4 File Offset: 0x0001BBB4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOVirtual.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOVirtual.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000564 RID: 1380 RVA: 0x0001D9F0 File Offset: 0x0001BBF0
			[CallerCount(0)]
			public unsafe float _Float_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOVirtual.__c__DisplayClass0_0.NativeMethodInfoPtr__Float_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000565 RID: 1381 RVA: 0x0001DA2C File Offset: 0x0001BC2C
			[CallerCount(0)]
			public unsafe void _Float_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOVirtual.__c__DisplayClass0_0.NativeMethodInfoPtr__Float_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000566 RID: 1382 RVA: 0x0001DA6C File Offset: 0x0001BC6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127703, XrefRangeEnd = 1127704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Float_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOVirtual.__c__DisplayClass0_0.NativeMethodInfoPtr__Float_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000567 RID: 1383 RVA: 0x00003C25 File Offset: 0x00001E25
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000103 RID: 259
			// (get) Token: 0x06000568 RID: 1384 RVA: 0x0001DAA0 File Offset: 0x0001BCA0
			// (set) Token: 0x06000569 RID: 1385 RVA: 0x00003C2E File Offset: 0x00001E2E
			public unsafe float val
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOVirtual.__c__DisplayClass0_0.NativeFieldInfoPtr_val);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOVirtual.__c__DisplayClass0_0.NativeFieldInfoPtr_val)) = value;
				}
			}

			// Token: 0x17000104 RID: 260
			// (get) Token: 0x0600056A RID: 1386 RVA: 0x0001DAC8 File Offset: 0x0001BCC8
			// (set) Token: 0x0600056B RID: 1387 RVA: 0x00003C49 File Offset: 0x00001E49
			public unsafe TweenCallback<float> onVirtualUpdate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOVirtual.__c__DisplayClass0_0.NativeFieldInfoPtr_onVirtualUpdate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOVirtual.__c__DisplayClass0_0.NativeFieldInfoPtr_onVirtualUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000458 RID: 1112
			private static readonly IntPtr NativeFieldInfoPtr_val;

			// Token: 0x04000459 RID: 1113
			private static readonly IntPtr NativeFieldInfoPtr_onVirtualUpdate;

			// Token: 0x0400045A RID: 1114
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400045B RID: 1115
			private static readonly IntPtr NativeMethodInfoPtr__Float_b__0_Internal_Single_0;

			// Token: 0x0400045C RID: 1116
			private static readonly IntPtr NativeMethodInfoPtr__Float_b__1_Internal_Void_Single_0;

			// Token: 0x0400045D RID: 1117
			private static readonly IntPtr NativeMethodInfoPtr__Float_b__2_Internal_Void_0;
		}
	}
}
