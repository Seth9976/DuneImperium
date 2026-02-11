using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000270 RID: 624
	[StructLayout(2)]
	public struct LinearColor
	{
		// Token: 0x06002B01 RID: 11009 RVA: 0x000AE2F0 File Offset: 0x000AC4F0
		// Note: this type is marked as 'beforefieldinit'.
		static LinearColor()
		{
			Il2CppClassPointerStore<LinearColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "LinearColor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinearColor>.NativeClassPtr);
			LinearColor.NativeFieldInfoPtr_m_red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, "m_red");
			LinearColor.NativeFieldInfoPtr_m_green = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, "m_green");
			LinearColor.NativeFieldInfoPtr_m_blue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, "m_blue");
			LinearColor.NativeFieldInfoPtr_m_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, "m_intensity");
			LinearColor.NativeMethodInfoPtr_get_red_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100668583);
			LinearColor.NativeMethodInfoPtr_set_red_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100668584);
			LinearColor.NativeMethodInfoPtr_get_green_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100668585);
			LinearColor.NativeMethodInfoPtr_set_green_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100668586);
			LinearColor.NativeMethodInfoPtr_get_blue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100668587);
			LinearColor.NativeMethodInfoPtr_set_blue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100668588);
			LinearColor.NativeMethodInfoPtr_Convert_Public_Static_LinearColor_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100668589);
			LinearColor.NativeMethodInfoPtr_Black_Public_Static_LinearColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100668590);
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06002B02 RID: 11010 RVA: 0x000AE410 File Offset: 0x000AC610
		// (set) Token: 0x06002B03 RID: 11011 RVA: 0x000AE440 File Offset: 0x000AC640
		public unsafe float red
		{
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 283150, RefRangeEnd = 283208, XrefRangeStart = 283150, XrefRangeEnd = 283208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_get_red_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 685907, RefRangeEnd = 685918, XrefRangeStart = 685907, XrefRangeEnd = 685907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_set_red_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06002B04 RID: 11012 RVA: 0x000AE474 File Offset: 0x000AC674
		// (set) Token: 0x06002B05 RID: 11013 RVA: 0x000AE4A4 File Offset: 0x000AC6A4
		public unsafe float green
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 644349, RefRangeEnd = 644397, XrefRangeStart = 644349, XrefRangeEnd = 644397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_get_green_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 685918, RefRangeEnd = 685929, XrefRangeStart = 685918, XrefRangeEnd = 685918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_set_green_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06002B06 RID: 11014 RVA: 0x000AE4D8 File Offset: 0x000AC6D8
		// (set) Token: 0x06002B07 RID: 11015 RVA: 0x000AE508 File Offset: 0x000AC708
		public unsafe float blue
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 644403, RefRangeEnd = 644429, XrefRangeStart = 644403, XrefRangeEnd = 644429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_get_blue_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 685929, RefRangeEnd = 685940, XrefRangeStart = 685929, XrefRangeEnd = 685929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_set_blue_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x000AE53C File Offset: 0x000AC73C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 685951, RefRangeEnd = 685962, XrefRangeStart = 685940, XrefRangeEnd = 685951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LinearColor Convert(Color color, float intensity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intensity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_Convert_Public_Static_LinearColor_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x000AE588 File Offset: 0x000AC788
		[CallerCount(0)]
		public unsafe static LinearColor Black()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_Black_Public_Static_LinearColor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x00010D67 File Offset: 0x0000EF67
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, ref this));
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06002B0B RID: 11019 RVA: 0x000AE5B8 File Offset: 0x000AC7B8
		// (set) Token: 0x06002B0C RID: 11020 RVA: 0x000AE5D0 File Offset: 0x000AC7D0
		public float intensity
		{
			get
			{
				return this.m_intensity;
			}
			set
			{
				bool flag = value < 0f;
				if (flag)
				{
					throw new ArgumentOutOfRangeException(String.Concat("Intensity (", value.ToString(), ") must be positive."));
				}
				this.m_intensity = value;
			}
		}

		// Token: 0x0400259F RID: 9631
		private static readonly IntPtr NativeFieldInfoPtr_m_red;

		// Token: 0x040025A0 RID: 9632
		private static readonly IntPtr NativeFieldInfoPtr_m_green;

		// Token: 0x040025A1 RID: 9633
		private static readonly IntPtr NativeFieldInfoPtr_m_blue;

		// Token: 0x040025A2 RID: 9634
		private static readonly IntPtr NativeFieldInfoPtr_m_intensity;

		// Token: 0x040025A3 RID: 9635
		private static readonly IntPtr NativeMethodInfoPtr_get_red_Public_get_Single_0;

		// Token: 0x040025A4 RID: 9636
		private static readonly IntPtr NativeMethodInfoPtr_set_red_Public_set_Void_Single_0;

		// Token: 0x040025A5 RID: 9637
		private static readonly IntPtr NativeMethodInfoPtr_get_green_Public_get_Single_0;

		// Token: 0x040025A6 RID: 9638
		private static readonly IntPtr NativeMethodInfoPtr_set_green_Public_set_Void_Single_0;

		// Token: 0x040025A7 RID: 9639
		private static readonly IntPtr NativeMethodInfoPtr_get_blue_Public_get_Single_0;

		// Token: 0x040025A8 RID: 9640
		private static readonly IntPtr NativeMethodInfoPtr_set_blue_Public_set_Void_Single_0;

		// Token: 0x040025A9 RID: 9641
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Static_LinearColor_Color_Single_0;

		// Token: 0x040025AA RID: 9642
		private static readonly IntPtr NativeMethodInfoPtr_Black_Public_Static_LinearColor_0;

		// Token: 0x040025AB RID: 9643
		[FieldOffset(0)]
		public float m_red;

		// Token: 0x040025AC RID: 9644
		[FieldOffset(4)]
		public float m_green;

		// Token: 0x040025AD RID: 9645
		[FieldOffset(8)]
		public float m_blue;

		// Token: 0x040025AE RID: 9646
		[FieldOffset(12)]
		public float m_intensity;
	}
}
