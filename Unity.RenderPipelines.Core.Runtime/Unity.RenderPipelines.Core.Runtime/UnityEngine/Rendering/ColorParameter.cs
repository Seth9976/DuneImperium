using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000104 RID: 260
	[Serializable]
	public class ColorParameter : VolumeParameter<Color>
	{
		// Token: 0x060011C1 RID: 4545 RVA: 0x00050E38 File Offset: 0x0004F038
		// Note: this type is marked as 'beforefieldinit'.
		static ColorParameter()
		{
			Il2CppClassPointerStore<ColorParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ColorParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorParameter>.NativeClassPtr);
			ColorParameter.NativeFieldInfoPtr_hdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorParameter>.NativeClassPtr, "hdr");
			ColorParameter.NativeFieldInfoPtr_showAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorParameter>.NativeClassPtr, "showAlpha");
			ColorParameter.NativeFieldInfoPtr_showEyeDropper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorParameter>.NativeClassPtr, "showEyeDropper");
			ColorParameter.NativeMethodInfoPtr__ctor_Public_Void_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorParameter>.NativeClassPtr, 100665903);
			ColorParameter.NativeMethodInfoPtr__ctor_Public_Void_Color_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorParameter>.NativeClassPtr, 100665904);
			ColorParameter.NativeMethodInfoPtr_Interp_Public_Virtual_Void_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorParameter>.NativeClassPtr, 100665905);
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x00050EE0 File Offset: 0x0004F0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978995, XrefRangeEnd = 978998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorParameter(Color value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorParameter.NativeMethodInfoPtr__ctor_Public_Void_Color_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x00050F38 File Offset: 0x0004F138
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 979001, RefRangeEnd = 979006, XrefRangeStart = 978998, XrefRangeEnd = 979001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorParameter(Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hdr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showAlpha;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showEyeDropper;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorParameter.NativeMethodInfoPtr__ctor_Public_Void_Color_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x00050FB8 File Offset: 0x0004F1B8
		[CallerCount(0)]
		public unsafe override void Interp(Color from, Color to, float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorParameter.NativeMethodInfoPtr_Interp_Public_Virtual_Void_Color_Color_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00009303 File Offset: 0x00007503
		public ColorParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060011C6 RID: 4550 RVA: 0x00051020 File Offset: 0x0004F220
		// (set) Token: 0x060011C7 RID: 4551 RVA: 0x0000930C File Offset: 0x0000750C
		public unsafe bool hdr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorParameter.NativeFieldInfoPtr_hdr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorParameter.NativeFieldInfoPtr_hdr)) = value;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060011C8 RID: 4552 RVA: 0x00051048 File Offset: 0x0004F248
		// (set) Token: 0x060011C9 RID: 4553 RVA: 0x00009327 File Offset: 0x00007527
		public unsafe bool showAlpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorParameter.NativeFieldInfoPtr_showAlpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorParameter.NativeFieldInfoPtr_showAlpha)) = value;
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060011CA RID: 4554 RVA: 0x00051070 File Offset: 0x0004F270
		// (set) Token: 0x060011CB RID: 4555 RVA: 0x00009342 File Offset: 0x00007542
		public unsafe bool showEyeDropper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorParameter.NativeFieldInfoPtr_showEyeDropper);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorParameter.NativeFieldInfoPtr_showEyeDropper)) = value;
			}
		}

		// Token: 0x04000D5D RID: 3421
		private static readonly IntPtr NativeFieldInfoPtr_hdr;

		// Token: 0x04000D5E RID: 3422
		private static readonly IntPtr NativeFieldInfoPtr_showAlpha;

		// Token: 0x04000D5F RID: 3423
		private static readonly IntPtr NativeFieldInfoPtr_showEyeDropper;

		// Token: 0x04000D60 RID: 3424
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_Boolean_0;

		// Token: 0x04000D61 RID: 3425
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x04000D62 RID: 3426
		private static readonly IntPtr NativeMethodInfoPtr_Interp_Public_Virtual_Void_Color_Color_Single_0;
	}
}
