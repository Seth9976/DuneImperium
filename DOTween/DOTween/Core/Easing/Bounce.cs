using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace DG.Tweening.Core.Easing
{
	// Token: 0x02000057 RID: 87
	public static class Bounce : Object
	{
		// Token: 0x06000531 RID: 1329 RVA: 0x0001CD7C File Offset: 0x0001AF7C
		// Note: this type is marked as 'beforefieldinit'.
		static Bounce()
		{
			Il2CppClassPointerStore<Bounce>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core.Easing", "Bounce");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bounce>.NativeClassPtr);
			Bounce.NativeMethodInfoPtr_EaseIn_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounce>.NativeClassPtr, 100664284);
			Bounce.NativeMethodInfoPtr_EaseOut_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounce>.NativeClassPtr, 100664285);
			Bounce.NativeMethodInfoPtr_EaseInOut_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounce>.NativeClassPtr, 100664286);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0001CDE8 File Offset: 0x0001AFE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1134730, RefRangeEnd = 1134733, XrefRangeStart = 1134730, XrefRangeEnd = 1134730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseIn(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unusedOvershootOrAmplitude;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unusedPeriod;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounce.NativeMethodInfoPtr_EaseIn_Public_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0001CE50 File Offset: 0x0001B050
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1134733, RefRangeEnd = 1134735, XrefRangeStart = 1134733, XrefRangeEnd = 1134733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unusedOvershootOrAmplitude;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unusedPeriod;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounce.NativeMethodInfoPtr_EaseOut_Public_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0001CEB8 File Offset: 0x0001B0B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1134735, RefRangeEnd = 1134736, XrefRangeStart = 1134735, XrefRangeEnd = 1134735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unusedOvershootOrAmplitude;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unusedPeriod;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounce.NativeMethodInfoPtr_EaseInOut_Public_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00003B42 File Offset: 0x00001D42
		public Bounce(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr_EaseIn_Public_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeMethodInfoPtr_EaseOut_Public_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeMethodInfoPtr_EaseInOut_Public_Static_Single_Single_Single_Single_Single_0;
	}
}
