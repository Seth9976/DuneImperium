using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace DG.Tweening.Core.Easing
{
	// Token: 0x0200005A RID: 90
	public static class Flash : Object
	{
		// Token: 0x06000546 RID: 1350 RVA: 0x0001D2E0 File Offset: 0x0001B4E0
		// Note: this type is marked as 'beforefieldinit'.
		static Flash()
		{
			Il2CppClassPointerStore<Flash>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core.Easing", "Flash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Flash>.NativeClassPtr);
			Flash.NativeMethodInfoPtr_Ease_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flash>.NativeClassPtr, 100664331);
			Flash.NativeMethodInfoPtr_EaseIn_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flash>.NativeClassPtr, 100664332);
			Flash.NativeMethodInfoPtr_EaseOut_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flash>.NativeClassPtr, 100664333);
			Flash.NativeMethodInfoPtr_EaseInOut_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flash>.NativeClassPtr, 100664334);
			Flash.NativeMethodInfoPtr_WeightedEase_Private_Static_Single_Single_Single_Int32_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flash>.NativeClassPtr, 100664335);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0001D374 File Offset: 0x0001B574
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1135454, RefRangeEnd = 1135455, XrefRangeStart = 1135449, XrefRangeEnd = 1135454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Ease(float time, float duration, float overshootOrAmplitude, float period)
		{
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flash.NativeMethodInfoPtr_Ease_Public_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0001D3DC File Offset: 0x0001B5DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1135460, RefRangeEnd = 1135461, XrefRangeStart = 1135455, XrefRangeEnd = 1135460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseIn(float time, float duration, float overshootOrAmplitude, float period)
		{
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flash.NativeMethodInfoPtr_EaseIn_Public_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0001D444 File Offset: 0x0001B644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1135466, RefRangeEnd = 1135467, XrefRangeStart = 1135461, XrefRangeEnd = 1135466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseOut(float time, float duration, float overshootOrAmplitude, float period)
		{
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flash.NativeMethodInfoPtr_EaseOut_Public_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0001D4AC File Offset: 0x0001B6AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1135473, RefRangeEnd = 1135474, XrefRangeStart = 1135467, XrefRangeEnd = 1135473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInOut(float time, float duration, float overshootOrAmplitude, float period)
		{
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flash.NativeMethodInfoPtr_EaseInOut_Public_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0001D514 File Offset: 0x0001B714
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1135480, RefRangeEnd = 1135488, XrefRangeStart = 1135474, XrefRangeEnd = 1135480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float WeightedEase(float overshootOrAmplitude, float period, int stepIndex, float stepDuration, float dir, float res)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref overshootOrAmplitude;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stepIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stepDuration;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dir;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref res;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flash.NativeMethodInfoPtr_WeightedEase_Private_Static_Single_Single_Single_Int32_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00003B98 File Offset: 0x00001D98
		public Flash(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeMethodInfoPtr_Ease_Public_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeMethodInfoPtr_EaseIn_Public_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeMethodInfoPtr_EaseOut_Public_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr_EaseInOut_Public_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr_WeightedEase_Private_Static_Single_Single_Single_Int32_Single_Single_Single_0;
	}
}
