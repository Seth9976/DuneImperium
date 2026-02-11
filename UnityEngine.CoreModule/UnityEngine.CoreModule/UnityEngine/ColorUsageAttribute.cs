using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000116 RID: 278
	public sealed class ColorUsageAttribute : PropertyAttribute
	{
		// Token: 0x060016AF RID: 5807 RVA: 0x0006D168 File Offset: 0x0006B368
		// Note: this type is marked as 'beforefieldinit'.
		static ColorUsageAttribute()
		{
			Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ColorUsageAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr);
			ColorUsageAttribute.NativeFieldInfoPtr_showAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, "showAlpha");
			ColorUsageAttribute.NativeFieldInfoPtr_hdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, "hdr");
			ColorUsageAttribute.NativeFieldInfoPtr_minBrightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, "minBrightness");
			ColorUsageAttribute.NativeFieldInfoPtr_maxBrightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, "maxBrightness");
			ColorUsageAttribute.NativeFieldInfoPtr_minExposureValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, "minExposureValue");
			ColorUsageAttribute.NativeFieldInfoPtr_maxExposureValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, "maxExposureValue");
			ColorUsageAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, 100666436);
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x0006D224 File Offset: 0x0006B424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660175, XrefRangeEnd = 660176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorUsageAttribute(bool showAlpha)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref showAlpha;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUsageAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00008F2D File Offset: 0x0000712D
		public ColorUsageAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x060016B2 RID: 5810 RVA: 0x0006D26C File Offset: 0x0006B46C
		// (set) Token: 0x060016B3 RID: 5811 RVA: 0x00008F36 File Offset: 0x00007136
		public unsafe bool showAlpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_showAlpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_showAlpha)) = value;
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x060016B4 RID: 5812 RVA: 0x0006D294 File Offset: 0x0006B494
		// (set) Token: 0x060016B5 RID: 5813 RVA: 0x00008F51 File Offset: 0x00007151
		public unsafe bool hdr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_hdr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_hdr)) = value;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x060016B6 RID: 5814 RVA: 0x0006D2BC File Offset: 0x0006B4BC
		// (set) Token: 0x060016B7 RID: 5815 RVA: 0x00008F6C File Offset: 0x0000716C
		public unsafe float minBrightness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_minBrightness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_minBrightness)) = value;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x060016B8 RID: 5816 RVA: 0x0006D2E4 File Offset: 0x0006B4E4
		// (set) Token: 0x060016B9 RID: 5817 RVA: 0x00008F87 File Offset: 0x00007187
		public unsafe float maxBrightness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_maxBrightness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_maxBrightness)) = value;
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x060016BA RID: 5818 RVA: 0x0006D30C File Offset: 0x0006B50C
		// (set) Token: 0x060016BB RID: 5819 RVA: 0x00008FA2 File Offset: 0x000071A2
		public unsafe float minExposureValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_minExposureValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_minExposureValue)) = value;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x060016BC RID: 5820 RVA: 0x0006D334 File Offset: 0x0006B534
		// (set) Token: 0x060016BD RID: 5821 RVA: 0x00008FBD File Offset: 0x000071BD
		public unsafe float maxExposureValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_maxExposureValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_maxExposureValue)) = value;
			}
		}

		// Token: 0x040014C7 RID: 5319
		private static readonly IntPtr NativeFieldInfoPtr_showAlpha;

		// Token: 0x040014C8 RID: 5320
		private static readonly IntPtr NativeFieldInfoPtr_hdr;

		// Token: 0x040014C9 RID: 5321
		private static readonly IntPtr NativeFieldInfoPtr_minBrightness;

		// Token: 0x040014CA RID: 5322
		private static readonly IntPtr NativeFieldInfoPtr_maxBrightness;

		// Token: 0x040014CB RID: 5323
		private static readonly IntPtr NativeFieldInfoPtr_minExposureValue;

		// Token: 0x040014CC RID: 5324
		private static readonly IntPtr NativeFieldInfoPtr_maxExposureValue;

		// Token: 0x040014CD RID: 5325
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
	}
}
