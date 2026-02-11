using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000026 RID: 38
	[Serializable]
	public class TMP_ColorGradient : ScriptableObject
	{
		// Token: 0x06000381 RID: 897 RVA: 0x00014EA0 File Offset: 0x000130A0
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_ColorGradient()
		{
			Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_ColorGradient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr);
			TMP_ColorGradient.NativeFieldInfoPtr_colorMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, "colorMode");
			TMP_ColorGradient.NativeFieldInfoPtr_topLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, "topLeft");
			TMP_ColorGradient.NativeFieldInfoPtr_topRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, "topRight");
			TMP_ColorGradient.NativeFieldInfoPtr_bottomLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, "bottomLeft");
			TMP_ColorGradient.NativeFieldInfoPtr_bottomRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, "bottomRight");
			TMP_ColorGradient.NativeFieldInfoPtr_k_DefaultColorMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, "k_DefaultColorMode");
			TMP_ColorGradient.NativeFieldInfoPtr_k_DefaultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, "k_DefaultColor");
			TMP_ColorGradient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, 100663619);
			TMP_ColorGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, 100663620);
			TMP_ColorGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_Color_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, 100663621);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00014F98 File Offset: 0x00013198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038107, XrefRangeEnd = 1038115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_ColorGradient()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ColorGradient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00014FD4 File Offset: 0x000131D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038115, XrefRangeEnd = 1038116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_ColorGradient(Color color)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ColorGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0001501C File Offset: 0x0001321C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038116, XrefRangeEnd = 1038117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_ColorGradient(Color color0, Color color1, Color color2, Color color3)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ColorGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_Color_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00003CBA File Offset: 0x00001EBA
		public TMP_ColorGradient(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00015090 File Offset: 0x00013290
		// (set) Token: 0x06000387 RID: 903 RVA: 0x00003CC3 File Offset: 0x00001EC3
		public unsafe ColorMode colorMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_colorMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_colorMode)) = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000388 RID: 904 RVA: 0x000150B8 File Offset: 0x000132B8
		// (set) Token: 0x06000389 RID: 905 RVA: 0x00003CDE File Offset: 0x00001EDE
		public unsafe Color topLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_topLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_topLeft)) = value;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600038A RID: 906 RVA: 0x000150E0 File Offset: 0x000132E0
		// (set) Token: 0x0600038B RID: 907 RVA: 0x00003CF9 File Offset: 0x00001EF9
		public unsafe Color topRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_topRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_topRight)) = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00015108 File Offset: 0x00013308
		// (set) Token: 0x0600038D RID: 909 RVA: 0x00003D14 File Offset: 0x00001F14
		public unsafe Color bottomLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_bottomLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_bottomLeft)) = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600038E RID: 910 RVA: 0x00015130 File Offset: 0x00013330
		// (set) Token: 0x0600038F RID: 911 RVA: 0x00003D2F File Offset: 0x00001F2F
		public unsafe Color bottomRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_bottomRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_bottomRight)) = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00015158 File Offset: 0x00013358
		// (set) Token: 0x06000391 RID: 913 RVA: 0x00003D4A File Offset: 0x00001F4A
		public unsafe static ColorMode k_DefaultColorMode
		{
			get
			{
				ColorMode colorMode;
				IL2CPP.il2cpp_field_static_get_value(TMP_ColorGradient.NativeFieldInfoPtr_k_DefaultColorMode, (void*)(&colorMode));
				return colorMode;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_ColorGradient.NativeFieldInfoPtr_k_DefaultColorMode, (void*)(&value));
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00015174 File Offset: 0x00013374
		// (set) Token: 0x06000393 RID: 915 RVA: 0x00003D58 File Offset: 0x00001F58
		public unsafe static Color k_DefaultColor
		{
			get
			{
				Color color;
				IL2CPP.il2cpp_field_static_get_value(TMP_ColorGradient.NativeFieldInfoPtr_k_DefaultColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_ColorGradient.NativeFieldInfoPtr_k_DefaultColor, (void*)(&value));
			}
		}

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeFieldInfoPtr_colorMode;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeFieldInfoPtr_topLeft;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeFieldInfoPtr_topRight;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeFieldInfoPtr_bottomLeft;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeFieldInfoPtr_bottomRight;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultColorMode;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultColor;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_0;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_Color_Color_Color_0;
	}
}
