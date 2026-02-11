using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements.Experimental
{
	// Token: 0x020002A5 RID: 677
	public sealed class StyleValues : ValueType
	{
		// Token: 0x060031DD RID: 12765 RVA: 0x000D34D8 File Offset: 0x000D16D8
		// Note: this type is marked as 'beforefieldinit'.
		static StyleValues()
		{
			Il2CppClassPointerStore<StyleValues>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.Experimental", "StyleValues");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleValues>.NativeClassPtr);
			StyleValues.NativeFieldInfoPtr_m_StyleValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, "m_StyleValues");
			StyleValues.NativeMethodInfoPtr_set_top_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670551);
			StyleValues.NativeMethodInfoPtr_set_left_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670552);
			StyleValues.NativeMethodInfoPtr_set_width_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670553);
			StyleValues.NativeMethodInfoPtr_set_height_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670554);
			StyleValues.NativeMethodInfoPtr_set_right_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670555);
			StyleValues.NativeMethodInfoPtr_set_bottom_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670556);
			StyleValues.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670557);
			StyleValues.NativeMethodInfoPtr_set_backgroundColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670558);
			StyleValues.NativeMethodInfoPtr_set_unityBackgroundImageTintColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670559);
			StyleValues.NativeMethodInfoPtr_set_borderColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670560);
			StyleValues.NativeMethodInfoPtr_set_marginLeft_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670561);
			StyleValues.NativeMethodInfoPtr_set_marginTop_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670562);
			StyleValues.NativeMethodInfoPtr_set_marginRight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670563);
			StyleValues.NativeMethodInfoPtr_set_marginBottom_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670564);
			StyleValues.NativeMethodInfoPtr_set_paddingLeft_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670565);
			StyleValues.NativeMethodInfoPtr_get_paddingTop_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670566);
			StyleValues.NativeMethodInfoPtr_set_paddingTop_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670567);
			StyleValues.NativeMethodInfoPtr_set_paddingRight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670568);
			StyleValues.NativeMethodInfoPtr_set_paddingBottom_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670569);
			StyleValues.NativeMethodInfoPtr_set_borderLeftWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670570);
			StyleValues.NativeMethodInfoPtr_set_borderRightWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670571);
			StyleValues.NativeMethodInfoPtr_set_borderTopWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670572);
			StyleValues.NativeMethodInfoPtr_set_borderBottomWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670573);
			StyleValues.NativeMethodInfoPtr_set_borderTopLeftRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670574);
			StyleValues.NativeMethodInfoPtr_set_borderTopRightRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670575);
			StyleValues.NativeMethodInfoPtr_set_borderBottomLeftRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670576);
			StyleValues.NativeMethodInfoPtr_set_borderBottomRightRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670577);
			StyleValues.NativeMethodInfoPtr_set_opacity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670578);
			StyleValues.NativeMethodInfoPtr_set_flexGrow_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670579);
			StyleValues.NativeMethodInfoPtr_set_flexShrink_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670580);
			StyleValues.NativeMethodInfoPtr_SetValue_Internal_Void_StylePropertyId_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670581);
			StyleValues.NativeMethodInfoPtr_SetValue_Internal_Void_StylePropertyId_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670582);
			StyleValues.NativeMethodInfoPtr_Values_Internal_StyleValueCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValues>.NativeClassPtr, 100670583);
		}

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x06003203 RID: 12803 RVA: 0x000D40C4 File Offset: 0x000D22C4
		// (set) Token: 0x060031DE RID: 12766 RVA: 0x000D37B0 File Offset: 0x000D19B0
		public unsafe float top
		{
			get
			{
				return this.Values().GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.Top).value;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359567, RefRangeEnd = 359568, XrefRangeStart = 359566, XrefRangeEnd = 359567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_top_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x06003204 RID: 12804 RVA: 0x000D40F0 File Offset: 0x000D22F0
		// (set) Token: 0x060031DF RID: 12767 RVA: 0x000D37F4 File Offset: 0x000D19F4
		public unsafe float left
		{
			get
			{
				return this.Values().GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.Left).value;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359569, RefRangeEnd = 359570, XrefRangeStart = 359568, XrefRangeEnd = 359569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_left_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x06003205 RID: 12805 RVA: 0x000D411C File Offset: 0x000D231C
		// (set) Token: 0x060031E0 RID: 12768 RVA: 0x000D3838 File Offset: 0x000D1A38
		public unsafe float width
		{
			get
			{
				return this.Values().GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.Width).value;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359571, RefRangeEnd = 359572, XrefRangeStart = 359570, XrefRangeEnd = 359571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_width_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x06003206 RID: 12806 RVA: 0x000D4148 File Offset: 0x000D2348
		// (set) Token: 0x060031E1 RID: 12769 RVA: 0x000D387C File Offset: 0x000D1A7C
		public unsafe float height
		{
			get
			{
				return this.Values().GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.Height).value;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 359573, RefRangeEnd = 359575, XrefRangeStart = 359572, XrefRangeEnd = 359573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_height_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x06003207 RID: 12807 RVA: 0x000D4174 File Offset: 0x000D2374
		// (set) Token: 0x060031E2 RID: 12770 RVA: 0x000D38C0 File Offset: 0x000D1AC0
		public unsafe float right
		{
			get
			{
				return this.Values().GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.Right).value;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359576, RefRangeEnd = 359577, XrefRangeStart = 359575, XrefRangeEnd = 359576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_right_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x06003208 RID: 12808 RVA: 0x000D41A0 File Offset: 0x000D23A0
		// (set) Token: 0x060031E3 RID: 12771 RVA: 0x000D3904 File Offset: 0x000D1B04
		public unsafe float bottom
		{
			get
			{
				return this.Values().GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.Bottom).value;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359578, RefRangeEnd = 359579, XrefRangeStart = 359577, XrefRangeEnd = 359578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_bottom_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x06003209 RID: 12809 RVA: 0x000D41CC File Offset: 0x000D23CC
		// (set) Token: 0x060031E4 RID: 12772 RVA: 0x000D3948 File Offset: 0x000D1B48
		public unsafe Color color
		{
			get
			{
				return this.Values().GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId.Color).value;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359585, RefRangeEnd = 359586, XrefRangeStart = 359579, XrefRangeEnd = 359585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x0600320A RID: 12810 RVA: 0x000D41F8 File Offset: 0x000D23F8
		// (set) Token: 0x060031E5 RID: 12773 RVA: 0x000D398C File Offset: 0x000D1B8C
		public unsafe Color backgroundColor
		{
			get
			{
				return this.Values().GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundColor).value;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359592, RefRangeEnd = 359593, XrefRangeStart = 359586, XrefRangeEnd = 359592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_backgroundColor_Public_set_Void_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x0600320B RID: 12811 RVA: 0x000D4224 File Offset: 0x000D2424
		// (set) Token: 0x060031E6 RID: 12774 RVA: 0x000D39D0 File Offset: 0x000D1BD0
		public unsafe Color unityBackgroundImageTintColor
		{
			get
			{
				return this.Values().GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityBackgroundImageTintColor).value;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359599, RefRangeEnd = 359600, XrefRangeStart = 359593, XrefRangeEnd = 359599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_unityBackgroundImageTintColor_Public_set_Void_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x0600320C RID: 12812 RVA: 0x000D4250 File Offset: 0x000D2450
		// (set) Token: 0x060031E7 RID: 12775 RVA: 0x000D3A14 File Offset: 0x000D1C14
		public unsafe Color borderColor
		{
			get
			{
				return this.Values().GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderColor).value;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359606, RefRangeEnd = 359607, XrefRangeStart = 359600, XrefRangeEnd = 359606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_borderColor_Public_set_Void_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x0600320D RID: 12813 RVA: 0x000D427C File Offset: 0x000D247C
		// (set) Token: 0x060031E8 RID: 12776 RVA: 0x000D3A58 File Offset: 0x000D1C58
		public unsafe float marginLeft
		{
			get
			{
				return this.Values().GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginLeft).value;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359608, RefRangeEnd = 359609, XrefRangeStart = 359607, XrefRangeEnd = 359608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_marginLeft_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x0600320E RID: 12814 RVA: 0x000D42A8 File Offset: 0x000D24A8
		// (set) Token: 0x060031E9 RID: 12777 RVA: 0x000D3A9C File Offset: 0x000D1C9C
		public unsafe float marginTop
		{
			get
			{
				return this.Values().GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginTop).value;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359610, RefRangeEnd = 359611, XrefRangeStart = 359609, XrefRangeEnd = 359610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_marginTop_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x0600320F RID: 12815 RVA: 0x000D42D4 File Offset: 0x000D24D4
		// (set) Token: 0x060031EA RID: 12778 RVA: 0x000D3AE0 File Offset: 0x000D1CE0
		public unsafe float marginRight
		{
			get
			{
				return this.Values().GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginRight).value;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359612, RefRangeEnd = 359613, XrefRangeStart = 359611, XrefRangeEnd = 359612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_marginRight_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x06003210 RID: 12816 RVA: 0x000D4300 File Offset: 0x000D2500
		// (set) Token: 0x060031EB RID: 12779 RVA: 0x000D3B24 File Offset: 0x000D1D24
		public unsafe float marginBottom
		{
			get
			{
				return this.Values().GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginBottom).value;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359614, RefRangeEnd = 359615, XrefRangeStart = 359613, XrefRangeEnd = 359614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_marginBottom_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x06003211 RID: 12817 RVA: 0x000D432C File Offset: 0x000D252C
		// (set) Token: 0x060031EC RID: 12780 RVA: 0x000D3B68 File Offset: 0x000D1D68
		public unsafe float paddingLeft
		{
			get
			{
				return this.Values().GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingLeft).value;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359616, RefRangeEnd = 359617, XrefRangeStart = 359615, XrefRangeEnd = 359616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_paddingLeft_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x060031ED RID: 12781 RVA: 0x000D3BAC File Offset: 0x000D1DAC
		// (set) Token: 0x060031EE RID: 12782 RVA: 0x000D3BF0 File Offset: 0x000D1DF0
		public unsafe float paddingTop
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359624, RefRangeEnd = 359625, XrefRangeStart = 359617, XrefRangeEnd = 359624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_get_paddingTop_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 359626, RefRangeEnd = 359629, XrefRangeStart = 359625, XrefRangeEnd = 359626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_paddingTop_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x06003212 RID: 12818 RVA: 0x000D4358 File Offset: 0x000D2558
		// (set) Token: 0x060031EF RID: 12783 RVA: 0x000D3C34 File Offset: 0x000D1E34
		public unsafe float paddingRight
		{
			get
			{
				return this.Values().GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingRight).value;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359630, RefRangeEnd = 359631, XrefRangeStart = 359629, XrefRangeEnd = 359630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_paddingRight_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06003213 RID: 12819 RVA: 0x000D4384 File Offset: 0x000D2584
		// (set) Token: 0x060031F0 RID: 12784 RVA: 0x000D3C78 File Offset: 0x000D1E78
		public unsafe float paddingBottom
		{
			get
			{
				return this.Values().GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingBottom).value;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359632, RefRangeEnd = 359633, XrefRangeStart = 359631, XrefRangeEnd = 359632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_paddingBottom_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06003214 RID: 12820 RVA: 0x000D43B0 File Offset: 0x000D25B0
		// (set) Token: 0x060031F1 RID: 12785 RVA: 0x000D3CBC File Offset: 0x000D1EBC
		public unsafe float borderLeftWidth
		{
			get
			{
				return this.Values().GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderLeftWidth).value;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359634, RefRangeEnd = 359635, XrefRangeStart = 359633, XrefRangeEnd = 359634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_borderLeftWidth_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x06003215 RID: 12821 RVA: 0x000D43DC File Offset: 0x000D25DC
		// (set) Token: 0x060031F2 RID: 12786 RVA: 0x000D3D00 File Offset: 0x000D1F00
		public unsafe float borderRightWidth
		{
			get
			{
				return this.Values().GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderRightWidth).value;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359636, RefRangeEnd = 359637, XrefRangeStart = 359635, XrefRangeEnd = 359636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_borderRightWidth_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x06003216 RID: 12822 RVA: 0x000D4408 File Offset: 0x000D2608
		// (set) Token: 0x060031F3 RID: 12787 RVA: 0x000D3D44 File Offset: 0x000D1F44
		public unsafe float borderTopWidth
		{
			get
			{
				return this.Values().GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopWidth).value;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359638, RefRangeEnd = 359639, XrefRangeStart = 359637, XrefRangeEnd = 359638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_borderTopWidth_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x06003217 RID: 12823 RVA: 0x000D4434 File Offset: 0x000D2634
		// (set) Token: 0x060031F4 RID: 12788 RVA: 0x000D3D88 File Offset: 0x000D1F88
		public unsafe float borderBottomWidth
		{
			get
			{
				return this.Values().GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomWidth).value;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359640, RefRangeEnd = 359641, XrefRangeStart = 359639, XrefRangeEnd = 359640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_borderBottomWidth_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x06003218 RID: 12824 RVA: 0x000D4460 File Offset: 0x000D2660
		// (set) Token: 0x060031F5 RID: 12789 RVA: 0x000D3DCC File Offset: 0x000D1FCC
		public unsafe float borderTopLeftRadius
		{
			get
			{
				return this.Values().GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopLeftRadius).value;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359642, RefRangeEnd = 359643, XrefRangeStart = 359641, XrefRangeEnd = 359642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_borderTopLeftRadius_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x06003219 RID: 12825 RVA: 0x000D448C File Offset: 0x000D268C
		// (set) Token: 0x060031F6 RID: 12790 RVA: 0x000D3E10 File Offset: 0x000D2010
		public unsafe float borderTopRightRadius
		{
			get
			{
				return this.Values().GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopRightRadius).value;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359644, RefRangeEnd = 359645, XrefRangeStart = 359643, XrefRangeEnd = 359644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_borderTopRightRadius_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x0600321A RID: 12826 RVA: 0x000D44B8 File Offset: 0x000D26B8
		// (set) Token: 0x060031F7 RID: 12791 RVA: 0x000D3E54 File Offset: 0x000D2054
		public unsafe float borderBottomLeftRadius
		{
			get
			{
				return this.Values().GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomLeftRadius).value;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359646, RefRangeEnd = 359647, XrefRangeStart = 359645, XrefRangeEnd = 359646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_borderBottomLeftRadius_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x0600321B RID: 12827 RVA: 0x000D44E4 File Offset: 0x000D26E4
		// (set) Token: 0x060031F8 RID: 12792 RVA: 0x000D3E98 File Offset: 0x000D2098
		public unsafe float borderBottomRightRadius
		{
			get
			{
				return this.Values().GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomRightRadius).value;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359648, RefRangeEnd = 359649, XrefRangeStart = 359647, XrefRangeEnd = 359648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_borderBottomRightRadius_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x0600321C RID: 12828 RVA: 0x000D4510 File Offset: 0x000D2710
		// (set) Token: 0x060031F9 RID: 12793 RVA: 0x000D3EDC File Offset: 0x000D20DC
		public unsafe float opacity
		{
			get
			{
				return this.Values().GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.Opacity).value;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359650, RefRangeEnd = 359651, XrefRangeStart = 359649, XrefRangeEnd = 359650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_opacity_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x0600321D RID: 12829 RVA: 0x000D453C File Offset: 0x000D273C
		// (set) Token: 0x060031FA RID: 12794 RVA: 0x000D3F20 File Offset: 0x000D2120
		public unsafe float flexGrow
		{
			get
			{
				return this.Values().GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexGrow).value;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 359652, RefRangeEnd = 359654, XrefRangeStart = 359651, XrefRangeEnd = 359652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_flexGrow_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x0600321E RID: 12830 RVA: 0x000D4568 File Offset: 0x000D2768
		// (set) Token: 0x060031FB RID: 12795 RVA: 0x000D3F64 File Offset: 0x000D2164
		public unsafe float flexShrink
		{
			get
			{
				return this.Values().GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexShrink).value;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 359652, RefRangeEnd = 359654, XrefRangeStart = 359652, XrefRangeEnd = 359654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_set_flexShrink_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060031FC RID: 12796 RVA: 0x000D3FA8 File Offset: 0x000D21A8
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 359660, RefRangeEnd = 359686, XrefRangeStart = 359654, XrefRangeEnd = 359660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_SetValue_Internal_Void_StylePropertyId_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031FD RID: 12797 RVA: 0x000D3FFC File Offset: 0x000D21FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359686, XrefRangeEnd = 359692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_SetValue_Internal_Void_StylePropertyId_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031FE RID: 12798 RVA: 0x000D4050 File Offset: 0x000D2250
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359697, RefRangeEnd = 359698, XrefRangeStart = 359692, XrefRangeEnd = 359697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleValueCollection Values()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValues.NativeMethodInfoPtr_Values_Internal_StyleValueCollection_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StyleValueCollection>(intPtr3) : null;
		}

		// Token: 0x060031FF RID: 12799 RVA: 0x00014432 File Offset: 0x00012632
		public StyleValues(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06003200 RID: 12800 RVA: 0x0001443B File Offset: 0x0001263B
		public StyleValues()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleValues>.NativeClassPtr))
		{
		}

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x06003201 RID: 12801 RVA: 0x000D4094 File Offset: 0x000D2294
		// (set) Token: 0x06003202 RID: 12802 RVA: 0x0001444D File Offset: 0x0001264D
		public unsafe StyleValueCollection m_StyleValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleValues.NativeFieldInfoPtr_m_StyleValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleValueCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleValues.NativeFieldInfoPtr_m_StyleValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040024A9 RID: 9385
		private static readonly IntPtr NativeFieldInfoPtr_m_StyleValues;

		// Token: 0x040024AA RID: 9386
		private static readonly IntPtr NativeMethodInfoPtr_set_top_Public_set_Void_Single_0;

		// Token: 0x040024AB RID: 9387
		private static readonly IntPtr NativeMethodInfoPtr_set_left_Public_set_Void_Single_0;

		// Token: 0x040024AC RID: 9388
		private static readonly IntPtr NativeMethodInfoPtr_set_width_Public_set_Void_Single_0;

		// Token: 0x040024AD RID: 9389
		private static readonly IntPtr NativeMethodInfoPtr_set_height_Public_set_Void_Single_0;

		// Token: 0x040024AE RID: 9390
		private static readonly IntPtr NativeMethodInfoPtr_set_right_Public_set_Void_Single_0;

		// Token: 0x040024AF RID: 9391
		private static readonly IntPtr NativeMethodInfoPtr_set_bottom_Public_set_Void_Single_0;

		// Token: 0x040024B0 RID: 9392
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_set_Void_Color_0;

		// Token: 0x040024B1 RID: 9393
		private static readonly IntPtr NativeMethodInfoPtr_set_backgroundColor_Public_set_Void_Color_0;

		// Token: 0x040024B2 RID: 9394
		private static readonly IntPtr NativeMethodInfoPtr_set_unityBackgroundImageTintColor_Public_set_Void_Color_0;

		// Token: 0x040024B3 RID: 9395
		private static readonly IntPtr NativeMethodInfoPtr_set_borderColor_Public_set_Void_Color_0;

		// Token: 0x040024B4 RID: 9396
		private static readonly IntPtr NativeMethodInfoPtr_set_marginLeft_Public_set_Void_Single_0;

		// Token: 0x040024B5 RID: 9397
		private static readonly IntPtr NativeMethodInfoPtr_set_marginTop_Public_set_Void_Single_0;

		// Token: 0x040024B6 RID: 9398
		private static readonly IntPtr NativeMethodInfoPtr_set_marginRight_Public_set_Void_Single_0;

		// Token: 0x040024B7 RID: 9399
		private static readonly IntPtr NativeMethodInfoPtr_set_marginBottom_Public_set_Void_Single_0;

		// Token: 0x040024B8 RID: 9400
		private static readonly IntPtr NativeMethodInfoPtr_set_paddingLeft_Public_set_Void_Single_0;

		// Token: 0x040024B9 RID: 9401
		private static readonly IntPtr NativeMethodInfoPtr_get_paddingTop_Public_get_Single_0;

		// Token: 0x040024BA RID: 9402
		private static readonly IntPtr NativeMethodInfoPtr_set_paddingTop_Public_set_Void_Single_0;

		// Token: 0x040024BB RID: 9403
		private static readonly IntPtr NativeMethodInfoPtr_set_paddingRight_Public_set_Void_Single_0;

		// Token: 0x040024BC RID: 9404
		private static readonly IntPtr NativeMethodInfoPtr_set_paddingBottom_Public_set_Void_Single_0;

		// Token: 0x040024BD RID: 9405
		private static readonly IntPtr NativeMethodInfoPtr_set_borderLeftWidth_Public_set_Void_Single_0;

		// Token: 0x040024BE RID: 9406
		private static readonly IntPtr NativeMethodInfoPtr_set_borderRightWidth_Public_set_Void_Single_0;

		// Token: 0x040024BF RID: 9407
		private static readonly IntPtr NativeMethodInfoPtr_set_borderTopWidth_Public_set_Void_Single_0;

		// Token: 0x040024C0 RID: 9408
		private static readonly IntPtr NativeMethodInfoPtr_set_borderBottomWidth_Public_set_Void_Single_0;

		// Token: 0x040024C1 RID: 9409
		private static readonly IntPtr NativeMethodInfoPtr_set_borderTopLeftRadius_Public_set_Void_Single_0;

		// Token: 0x040024C2 RID: 9410
		private static readonly IntPtr NativeMethodInfoPtr_set_borderTopRightRadius_Public_set_Void_Single_0;

		// Token: 0x040024C3 RID: 9411
		private static readonly IntPtr NativeMethodInfoPtr_set_borderBottomLeftRadius_Public_set_Void_Single_0;

		// Token: 0x040024C4 RID: 9412
		private static readonly IntPtr NativeMethodInfoPtr_set_borderBottomRightRadius_Public_set_Void_Single_0;

		// Token: 0x040024C5 RID: 9413
		private static readonly IntPtr NativeMethodInfoPtr_set_opacity_Public_set_Void_Single_0;

		// Token: 0x040024C6 RID: 9414
		private static readonly IntPtr NativeMethodInfoPtr_set_flexGrow_Public_set_Void_Single_0;

		// Token: 0x040024C7 RID: 9415
		private static readonly IntPtr NativeMethodInfoPtr_set_flexShrink_Public_set_Void_Single_0;

		// Token: 0x040024C8 RID: 9416
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Internal_Void_StylePropertyId_Single_0;

		// Token: 0x040024C9 RID: 9417
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Internal_Void_StylePropertyId_Color_0;

		// Token: 0x040024CA RID: 9418
		private static readonly IntPtr NativeMethodInfoPtr_Values_Internal_StyleValueCollection_0;
	}
}
