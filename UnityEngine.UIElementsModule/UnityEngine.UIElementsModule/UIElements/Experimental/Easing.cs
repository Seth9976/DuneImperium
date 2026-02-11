using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.Experimental
{
	// Token: 0x0200029F RID: 671
	public static class Easing : Object
	{
		// Token: 0x06003180 RID: 12672 RVA: 0x000D1F48 File Offset: 0x000D0148
		// Note: this type is marked as 'beforefieldinit'.
		static Easing()
		{
			Il2CppClassPointerStore<Easing>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.Experimental", "Easing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Easing>.NativeClassPtr);
			Easing.NativeMethodInfoPtr_Linear_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Easing>.NativeClassPtr, 100670478);
			Easing.NativeMethodInfoPtr_InSine_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Easing>.NativeClassPtr, 100670479);
			Easing.NativeMethodInfoPtr_OutSine_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Easing>.NativeClassPtr, 100670480);
			Easing.NativeMethodInfoPtr_InOutSine_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Easing>.NativeClassPtr, 100670481);
			Easing.NativeMethodInfoPtr_InQuad_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Easing>.NativeClassPtr, 100670482);
			Easing.NativeMethodInfoPtr_OutQuad_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Easing>.NativeClassPtr, 100670483);
			Easing.NativeMethodInfoPtr_InOutQuad_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Easing>.NativeClassPtr, 100670484);
			Easing.NativeMethodInfoPtr_InCubic_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Easing>.NativeClassPtr, 100670485);
			Easing.NativeMethodInfoPtr_OutCubic_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Easing>.NativeClassPtr, 100670486);
			Easing.NativeMethodInfoPtr_InOutCubic_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Easing>.NativeClassPtr, 100670487);
			Easing.NativeMethodInfoPtr_InPower_Public_Static_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Easing>.NativeClassPtr, 100670488);
			Easing.NativeMethodInfoPtr_OutPower_Public_Static_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Easing>.NativeClassPtr, 100670489);
			Easing.NativeMethodInfoPtr_InOutPower_Public_Static_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Easing>.NativeClassPtr, 100670490);
			Easing.NativeMethodInfoPtr_InBounce_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Easing>.NativeClassPtr, 100670491);
			Easing.NativeMethodInfoPtr_OutBounce_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Easing>.NativeClassPtr, 100670492);
			Easing.NativeMethodInfoPtr_InOutBounce_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Easing>.NativeClassPtr, 100670493);
			Easing.NativeMethodInfoPtr_InElastic_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Easing>.NativeClassPtr, 100670494);
			Easing.NativeMethodInfoPtr_OutElastic_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Easing>.NativeClassPtr, 100670495);
			Easing.NativeMethodInfoPtr_InOutElastic_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Easing>.NativeClassPtr, 100670496);
			Easing.NativeMethodInfoPtr_InBack_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Easing>.NativeClassPtr, 100670497);
			Easing.NativeMethodInfoPtr_OutBack_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Easing>.NativeClassPtr, 100670498);
			Easing.NativeMethodInfoPtr_InOutBack_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Easing>.NativeClassPtr, 100670499);
			Easing.NativeMethodInfoPtr_InCirc_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Easing>.NativeClassPtr, 100670500);
			Easing.NativeMethodInfoPtr_OutCirc_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Easing>.NativeClassPtr, 100670501);
			Easing.NativeMethodInfoPtr_InOutCirc_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Easing>.NativeClassPtr, 100670502);
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x000D216C File Offset: 0x000D036C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 359432, RefRangeEnd = 359440, XrefRangeStart = 359432, XrefRangeEnd = 359432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Linear(float t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Easing.NativeMethodInfoPtr_Linear_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003182 RID: 12674 RVA: 0x000D21AC File Offset: 0x000D03AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359441, RefRangeEnd = 359442, XrefRangeStart = 359440, XrefRangeEnd = 359441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float InSine(float t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Easing.NativeMethodInfoPtr_InSine_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003183 RID: 12675 RVA: 0x000D21EC File Offset: 0x000D03EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359443, RefRangeEnd = 359444, XrefRangeStart = 359442, XrefRangeEnd = 359443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float OutSine(float t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Easing.NativeMethodInfoPtr_OutSine_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003184 RID: 12676 RVA: 0x000D222C File Offset: 0x000D042C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359445, RefRangeEnd = 359446, XrefRangeStart = 359444, XrefRangeEnd = 359445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float InOutSine(float t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Easing.NativeMethodInfoPtr_InOutSine_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003185 RID: 12677 RVA: 0x000D226C File Offset: 0x000D046C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359446, RefRangeEnd = 359447, XrefRangeStart = 359446, XrefRangeEnd = 359446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float InQuad(float t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Easing.NativeMethodInfoPtr_InQuad_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003186 RID: 12678 RVA: 0x000D22AC File Offset: 0x000D04AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359447, RefRangeEnd = 359448, XrefRangeStart = 359447, XrefRangeEnd = 359447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float OutQuad(float t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Easing.NativeMethodInfoPtr_OutQuad_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003187 RID: 12679 RVA: 0x000D22EC File Offset: 0x000D04EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359448, RefRangeEnd = 359449, XrefRangeStart = 359448, XrefRangeEnd = 359448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float InOutQuad(float t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Easing.NativeMethodInfoPtr_InOutQuad_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003188 RID: 12680 RVA: 0x000D232C File Offset: 0x000D052C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359450, RefRangeEnd = 359451, XrefRangeStart = 359449, XrefRangeEnd = 359450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float InCubic(float t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Easing.NativeMethodInfoPtr_InCubic_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003189 RID: 12681 RVA: 0x000D236C File Offset: 0x000D056C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359452, RefRangeEnd = 359453, XrefRangeStart = 359451, XrefRangeEnd = 359452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float OutCubic(float t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Easing.NativeMethodInfoPtr_OutCubic_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600318A RID: 12682 RVA: 0x000D23AC File Offset: 0x000D05AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359454, RefRangeEnd = 359455, XrefRangeStart = 359453, XrefRangeEnd = 359454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float InOutCubic(float t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Easing.NativeMethodInfoPtr_InOutCubic_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600318B RID: 12683 RVA: 0x000D23EC File Offset: 0x000D05EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359455, XrefRangeEnd = 359456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float InPower(float t, int power)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref power;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Easing.NativeMethodInfoPtr_InPower_Public_Static_Single_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600318C RID: 12684 RVA: 0x000D2438 File Offset: 0x000D0638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359456, XrefRangeEnd = 359457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float OutPower(float t, int power)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref power;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Easing.NativeMethodInfoPtr_OutPower_Public_Static_Single_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600318D RID: 12685 RVA: 0x000D2484 File Offset: 0x000D0684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359457, XrefRangeEnd = 359458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float InOutPower(float t, int power)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref power;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Easing.NativeMethodInfoPtr_InOutPower_Public_Static_Single_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600318E RID: 12686 RVA: 0x000D24D0 File Offset: 0x000D06D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359458, RefRangeEnd = 359459, XrefRangeStart = 359458, XrefRangeEnd = 359458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float InBounce(float t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Easing.NativeMethodInfoPtr_InBounce_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600318F RID: 12687 RVA: 0x000D2510 File Offset: 0x000D0710
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359459, RefRangeEnd = 359460, XrefRangeStart = 359459, XrefRangeEnd = 359459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float OutBounce(float t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Easing.NativeMethodInfoPtr_OutBounce_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003190 RID: 12688 RVA: 0x000D2550 File Offset: 0x000D0750
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359460, RefRangeEnd = 359461, XrefRangeStart = 359460, XrefRangeEnd = 359460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float InOutBounce(float t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Easing.NativeMethodInfoPtr_InOutBounce_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003191 RID: 12689 RVA: 0x000D2590 File Offset: 0x000D0790
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359463, RefRangeEnd = 359464, XrefRangeStart = 359461, XrefRangeEnd = 359463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float InElastic(float t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Easing.NativeMethodInfoPtr_InElastic_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003192 RID: 12690 RVA: 0x000D25D0 File Offset: 0x000D07D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359464, RefRangeEnd = 359465, XrefRangeStart = 359464, XrefRangeEnd = 359464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float OutElastic(float t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Easing.NativeMethodInfoPtr_OutElastic_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003193 RID: 12691 RVA: 0x000D2610 File Offset: 0x000D0810
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359470, RefRangeEnd = 359471, XrefRangeStart = 359465, XrefRangeEnd = 359470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float InOutElastic(float t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Easing.NativeMethodInfoPtr_InOutElastic_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003194 RID: 12692 RVA: 0x000D2650 File Offset: 0x000D0850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359471, RefRangeEnd = 359472, XrefRangeStart = 359471, XrefRangeEnd = 359471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float InBack(float t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Easing.NativeMethodInfoPtr_InBack_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003195 RID: 12693 RVA: 0x000D2690 File Offset: 0x000D0890
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359472, RefRangeEnd = 359473, XrefRangeStart = 359472, XrefRangeEnd = 359472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float OutBack(float t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Easing.NativeMethodInfoPtr_OutBack_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003196 RID: 12694 RVA: 0x000D26D0 File Offset: 0x000D08D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359473, RefRangeEnd = 359474, XrefRangeStart = 359473, XrefRangeEnd = 359473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float InOutBack(float t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Easing.NativeMethodInfoPtr_InOutBack_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003197 RID: 12695 RVA: 0x000D2710 File Offset: 0x000D0910
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359474, RefRangeEnd = 359475, XrefRangeStart = 359474, XrefRangeEnd = 359474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float InCirc(float t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Easing.NativeMethodInfoPtr_InCirc_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003198 RID: 12696 RVA: 0x000D2750 File Offset: 0x000D0950
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359475, RefRangeEnd = 359476, XrefRangeStart = 359475, XrefRangeEnd = 359475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float OutCirc(float t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Easing.NativeMethodInfoPtr_OutCirc_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003199 RID: 12697 RVA: 0x000D2790 File Offset: 0x000D0990
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359476, RefRangeEnd = 359477, XrefRangeStart = 359476, XrefRangeEnd = 359476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float InOutCirc(float t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Easing.NativeMethodInfoPtr_InOutCirc_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600319A RID: 12698 RVA: 0x000142C4 File Offset: 0x000124C4
		public Easing(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600319B RID: 12699 RVA: 0x000D27D0 File Offset: 0x000D09D0
		public static float Step(float t)
		{
			return (float)((t < 0.5f) ? 0 : 1);
		}

		// Token: 0x0600319C RID: 12700 RVA: 0x000D27F0 File Offset: 0x000D09F0
		public static float InBack(float t, float s)
		{
			return t * t * ((s + 1f) * t - s);
		}

		// Token: 0x0600319D RID: 12701 RVA: 0x000D2814 File Offset: 0x000D0A14
		public static float OutBack(float t, float s)
		{
			return 1f - Easing.InBack(1f - t, s);
		}

		// Token: 0x0600319E RID: 12702 RVA: 0x000D283C File Offset: 0x000D0A3C
		public static float InOutBack(float t, float s)
		{
			bool flag = t < 0.5f;
			float num;
			if (flag)
			{
				num = Easing.InBack(t * 2f, s) * 0.5f;
			}
			else
			{
				num = Easing.OutBack((t - 0.5f) * 2f, s) * 0.5f + 0.5f;
			}
			return num;
		}

		// Token: 0x0400246B RID: 9323
		private static readonly IntPtr NativeMethodInfoPtr_Linear_Public_Static_Single_Single_0;

		// Token: 0x0400246C RID: 9324
		private static readonly IntPtr NativeMethodInfoPtr_InSine_Public_Static_Single_Single_0;

		// Token: 0x0400246D RID: 9325
		private static readonly IntPtr NativeMethodInfoPtr_OutSine_Public_Static_Single_Single_0;

		// Token: 0x0400246E RID: 9326
		private static readonly IntPtr NativeMethodInfoPtr_InOutSine_Public_Static_Single_Single_0;

		// Token: 0x0400246F RID: 9327
		private static readonly IntPtr NativeMethodInfoPtr_InQuad_Public_Static_Single_Single_0;

		// Token: 0x04002470 RID: 9328
		private static readonly IntPtr NativeMethodInfoPtr_OutQuad_Public_Static_Single_Single_0;

		// Token: 0x04002471 RID: 9329
		private static readonly IntPtr NativeMethodInfoPtr_InOutQuad_Public_Static_Single_Single_0;

		// Token: 0x04002472 RID: 9330
		private static readonly IntPtr NativeMethodInfoPtr_InCubic_Public_Static_Single_Single_0;

		// Token: 0x04002473 RID: 9331
		private static readonly IntPtr NativeMethodInfoPtr_OutCubic_Public_Static_Single_Single_0;

		// Token: 0x04002474 RID: 9332
		private static readonly IntPtr NativeMethodInfoPtr_InOutCubic_Public_Static_Single_Single_0;

		// Token: 0x04002475 RID: 9333
		private static readonly IntPtr NativeMethodInfoPtr_InPower_Public_Static_Single_Single_Int32_0;

		// Token: 0x04002476 RID: 9334
		private static readonly IntPtr NativeMethodInfoPtr_OutPower_Public_Static_Single_Single_Int32_0;

		// Token: 0x04002477 RID: 9335
		private static readonly IntPtr NativeMethodInfoPtr_InOutPower_Public_Static_Single_Single_Int32_0;

		// Token: 0x04002478 RID: 9336
		private static readonly IntPtr NativeMethodInfoPtr_InBounce_Public_Static_Single_Single_0;

		// Token: 0x04002479 RID: 9337
		private static readonly IntPtr NativeMethodInfoPtr_OutBounce_Public_Static_Single_Single_0;

		// Token: 0x0400247A RID: 9338
		private static readonly IntPtr NativeMethodInfoPtr_InOutBounce_Public_Static_Single_Single_0;

		// Token: 0x0400247B RID: 9339
		private static readonly IntPtr NativeMethodInfoPtr_InElastic_Public_Static_Single_Single_0;

		// Token: 0x0400247C RID: 9340
		private static readonly IntPtr NativeMethodInfoPtr_OutElastic_Public_Static_Single_Single_0;

		// Token: 0x0400247D RID: 9341
		private static readonly IntPtr NativeMethodInfoPtr_InOutElastic_Public_Static_Single_Single_0;

		// Token: 0x0400247E RID: 9342
		private static readonly IntPtr NativeMethodInfoPtr_InBack_Public_Static_Single_Single_0;

		// Token: 0x0400247F RID: 9343
		private static readonly IntPtr NativeMethodInfoPtr_OutBack_Public_Static_Single_Single_0;

		// Token: 0x04002480 RID: 9344
		private static readonly IntPtr NativeMethodInfoPtr_InOutBack_Public_Static_Single_Single_0;

		// Token: 0x04002481 RID: 9345
		private static readonly IntPtr NativeMethodInfoPtr_InCirc_Public_Static_Single_Single_0;

		// Token: 0x04002482 RID: 9346
		private static readonly IntPtr NativeMethodInfoPtr_OutCirc_Public_Static_Single_Single_0;

		// Token: 0x04002483 RID: 9347
		private static readonly IntPtr NativeMethodInfoPtr_InOutCirc_Public_Static_Single_Single_0;

		// Token: 0x04002484 RID: 9348
		public const float HalfPi = 1.5707964f;
	}
}
