using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000018 RID: 24
	[Serializable]
	public class TextColorGradient : ScriptableObject
	{
		// Token: 0x0600022A RID: 554 RVA: 0x0000DCAC File Offset: 0x0000BEAC
		// Note: this type is marked as 'beforefieldinit'.
		static TextColorGradient()
		{
			Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextColorGradient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr);
			TextColorGradient.NativeFieldInfoPtr_colorMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr, "colorMode");
			TextColorGradient.NativeFieldInfoPtr_topLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr, "topLeft");
			TextColorGradient.NativeFieldInfoPtr_topRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr, "topRight");
			TextColorGradient.NativeFieldInfoPtr_bottomLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr, "bottomLeft");
			TextColorGradient.NativeFieldInfoPtr_bottomRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr, "bottomRight");
			TextColorGradient.NativeFieldInfoPtr_k_DefaultColorMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr, "k_DefaultColorMode");
			TextColorGradient.NativeFieldInfoPtr_k_DefaultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr, "k_DefaultColor");
			TextColorGradient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr, 100663521);
			TextColorGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr, 100663522);
			TextColorGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_Color_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr, 100663523);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000DDA4 File Offset: 0x0000BFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101028, XrefRangeEnd = 1101036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextColorGradient()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextColorGradient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000DDE0 File Offset: 0x0000BFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextColorGradient(Color color)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextColorGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000DE28 File Offset: 0x0000C028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextColorGradient(Color color0, Color color1, Color color2, Color color3)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextColorGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_Color_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00003113 File Offset: 0x00001313
		public TextColorGradient(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600022F RID: 559 RVA: 0x0000DE9C File Offset: 0x0000C09C
		// (set) Token: 0x06000230 RID: 560 RVA: 0x0000311C File Offset: 0x0000131C
		public unsafe ColorGradientMode colorMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextColorGradient.NativeFieldInfoPtr_colorMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextColorGradient.NativeFieldInfoPtr_colorMode)) = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000231 RID: 561 RVA: 0x0000DEC4 File Offset: 0x0000C0C4
		// (set) Token: 0x06000232 RID: 562 RVA: 0x00003137 File Offset: 0x00001337
		public unsafe Color topLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextColorGradient.NativeFieldInfoPtr_topLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextColorGradient.NativeFieldInfoPtr_topLeft)) = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0000DEEC File Offset: 0x0000C0EC
		// (set) Token: 0x06000234 RID: 564 RVA: 0x00003152 File Offset: 0x00001352
		public unsafe Color topRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextColorGradient.NativeFieldInfoPtr_topRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextColorGradient.NativeFieldInfoPtr_topRight)) = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000235 RID: 565 RVA: 0x0000DF14 File Offset: 0x0000C114
		// (set) Token: 0x06000236 RID: 566 RVA: 0x0000316D File Offset: 0x0000136D
		public unsafe Color bottomLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextColorGradient.NativeFieldInfoPtr_bottomLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextColorGradient.NativeFieldInfoPtr_bottomLeft)) = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0000DF3C File Offset: 0x0000C13C
		// (set) Token: 0x06000238 RID: 568 RVA: 0x00003188 File Offset: 0x00001388
		public unsafe Color bottomRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextColorGradient.NativeFieldInfoPtr_bottomRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextColorGradient.NativeFieldInfoPtr_bottomRight)) = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0000DF64 File Offset: 0x0000C164
		// (set) Token: 0x0600023A RID: 570 RVA: 0x000031A3 File Offset: 0x000013A3
		public unsafe static ColorGradientMode k_DefaultColorMode
		{
			get
			{
				ColorGradientMode colorGradientMode;
				IL2CPP.il2cpp_field_static_get_value(TextColorGradient.NativeFieldInfoPtr_k_DefaultColorMode, (void*)(&colorGradientMode));
				return colorGradientMode;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextColorGradient.NativeFieldInfoPtr_k_DefaultColorMode, (void*)(&value));
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0000DF80 File Offset: 0x0000C180
		// (set) Token: 0x0600023C RID: 572 RVA: 0x000031B1 File Offset: 0x000013B1
		public unsafe static Color k_DefaultColor
		{
			get
			{
				Color color;
				IL2CPP.il2cpp_field_static_get_value(TextColorGradient.NativeFieldInfoPtr_k_DefaultColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextColorGradient.NativeFieldInfoPtr_k_DefaultColor, (void*)(&value));
			}
		}

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeFieldInfoPtr_colorMode;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeFieldInfoPtr_topLeft;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeFieldInfoPtr_topRight;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeFieldInfoPtr_bottomLeft;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeFieldInfoPtr_bottomRight;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultColorMode;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultColor;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_Color_Color_Color_0;
	}
}
