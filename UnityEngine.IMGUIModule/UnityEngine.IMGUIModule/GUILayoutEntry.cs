using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000016 RID: 22
	public class GUILayoutEntry : Object
	{
		// Token: 0x0600049A RID: 1178 RVA: 0x000112CC File Offset: 0x0000F4CC
		// Note: this type is marked as 'beforefieldinit'.
		static GUILayoutEntry()
		{
			Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUILayoutEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr);
			GUILayoutEntry.NativeFieldInfoPtr_minWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "minWidth");
			GUILayoutEntry.NativeFieldInfoPtr_maxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "maxWidth");
			GUILayoutEntry.NativeFieldInfoPtr_minHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "minHeight");
			GUILayoutEntry.NativeFieldInfoPtr_maxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "maxHeight");
			GUILayoutEntry.NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "rect");
			GUILayoutEntry.NativeFieldInfoPtr_stretchWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "stretchWidth");
			GUILayoutEntry.NativeFieldInfoPtr_stretchHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "stretchHeight");
			GUILayoutEntry.NativeFieldInfoPtr_consideredForMargin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "consideredForMargin");
			GUILayoutEntry.NativeFieldInfoPtr_m_Style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "m_Style");
			GUILayoutEntry.NativeFieldInfoPtr_kDummyRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "kDummyRect");
			GUILayoutEntry.NativeFieldInfoPtr_indent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "indent");
			GUILayoutEntry.NativeMethodInfoPtr_get_style_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663614);
			GUILayoutEntry.NativeMethodInfoPtr_set_style_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663615);
			GUILayoutEntry.NativeMethodInfoPtr_get_marginLeft_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663616);
			GUILayoutEntry.NativeMethodInfoPtr_get_marginRight_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663617);
			GUILayoutEntry.NativeMethodInfoPtr_get_marginTop_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663618);
			GUILayoutEntry.NativeMethodInfoPtr_get_marginBottom_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663619);
			GUILayoutEntry.NativeMethodInfoPtr_get_marginHorizontal_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663620);
			GUILayoutEntry.NativeMethodInfoPtr_get_marginVertical_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663621);
			GUILayoutEntry.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663622);
			GUILayoutEntry.NativeMethodInfoPtr_CalcWidth_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663623);
			GUILayoutEntry.NativeMethodInfoPtr_CalcHeight_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663624);
			GUILayoutEntry.NativeMethodInfoPtr_SetHorizontal_Public_Virtual_New_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663625);
			GUILayoutEntry.NativeMethodInfoPtr_SetVertical_Public_Virtual_New_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663626);
			GUILayoutEntry.NativeMethodInfoPtr_ApplyStyleSettings_Protected_Virtual_New_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663627);
			GUILayoutEntry.NativeMethodInfoPtr_ApplyOptions_Public_Virtual_New_Void_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663628);
			GUILayoutEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663629);
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x00011518 File Offset: 0x0000F718
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x00011558 File Offset: 0x0000F758
		public unsafe GUIStyle style
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 331976, RefRangeEnd = 331977, XrefRangeStart = 331976, XrefRangeEnd = 331977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutEntry.NativeMethodInfoPtr_get_style_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187718, XrefRangeEnd = 1187719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutEntry.NativeMethodInfoPtr_set_style_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x0001159C File Offset: 0x0000F79C
		public unsafe virtual int marginLeft
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187719, XrefRangeEnd = 1187722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_get_marginLeft_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x000115E4 File Offset: 0x0000F7E4
		public unsafe virtual int marginRight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187722, XrefRangeEnd = 1187725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_get_marginRight_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x0001162C File Offset: 0x0000F82C
		public unsafe virtual int marginTop
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187725, XrefRangeEnd = 1187728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_get_marginTop_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x00011674 File Offset: 0x0000F874
		public unsafe virtual int marginBottom
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187728, XrefRangeEnd = 1187731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_get_marginBottom_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x000116BC File Offset: 0x0000F8BC
		public unsafe int marginHorizontal
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1187731, RefRangeEnd = 1187735, XrefRangeStart = 1187731, XrefRangeEnd = 1187731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutEntry.NativeMethodInfoPtr_get_marginHorizontal_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x000116F8 File Offset: 0x0000F8F8
		public unsafe int marginVertical
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1187735, RefRangeEnd = 1187737, XrefRangeStart = 1187735, XrefRangeEnd = 1187735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutEntry.NativeMethodInfoPtr_get_marginVertical_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00011734 File Offset: 0x0000F934
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1187747, RefRangeEnd = 1187748, XrefRangeStart = 1187737, XrefRangeEnd = 1187747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref _minWidth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _maxWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _minHeight;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _maxHeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutEntry.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x000117B8 File Offset: 0x0000F9B8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalcWidth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_CalcWidth_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x000117F4 File Offset: 0x0000F9F4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalcHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_CalcHeight_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00011830 File Offset: 0x0000FA30
		[CallerCount(0)]
		public unsafe virtual void SetHorizontal(float x, float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_SetHorizontal_Public_Virtual_New_Void_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00011888 File Offset: 0x0000FA88
		[CallerCount(0)]
		public unsafe virtual void SetVertical(float y, float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref y;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_SetVertical_Public_Virtual_New_Void_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x000118E0 File Offset: 0x0000FAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187748, XrefRangeEnd = 1187759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyStyleSettings(GUIStyle style)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(style);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_ApplyStyleSettings_Protected_Virtual_New_Void_GUIStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00011930 File Offset: 0x0000FB30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1187785, RefRangeEnd = 1187786, XrefRangeStart = 1187759, XrefRangeEnd = 1187785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyOptions(Il2CppReferenceArray<GUILayoutOption> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_ApplyOptions_Public_Virtual_New_Void_Il2CppReferenceArray_1_GUILayoutOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00011980 File Offset: 0x0000FB80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1187881, RefRangeEnd = 1187882, XrefRangeStart = 1187786, XrefRangeEnd = 1187881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00003F97 File Offset: 0x00002197
		public GUILayoutEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x000119C4 File Offset: 0x0000FBC4
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x00003FA0 File Offset: 0x000021A0
		public unsafe float minWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_minWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_minWidth)) = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x000119EC File Offset: 0x0000FBEC
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x00003FBB File Offset: 0x000021BB
		public unsafe float maxWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_maxWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_maxWidth)) = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00011A14 File Offset: 0x0000FC14
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00003FD6 File Offset: 0x000021D6
		public unsafe float minHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_minHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_minHeight)) = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00011A3C File Offset: 0x0000FC3C
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x00003FF1 File Offset: 0x000021F1
		public unsafe float maxHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_maxHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_maxHeight)) = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00011A64 File Offset: 0x0000FC64
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x0000400C File Offset: 0x0000220C
		public unsafe Rect rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_rect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_rect)) = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x00011A8C File Offset: 0x0000FC8C
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x00004027 File Offset: 0x00002227
		public unsafe int stretchWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_stretchWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_stretchWidth)) = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00011AB4 File Offset: 0x0000FCB4
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x00004042 File Offset: 0x00002242
		public unsafe int stretchHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_stretchHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_stretchHeight)) = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x00011ADC File Offset: 0x0000FCDC
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x0000405D File Offset: 0x0000225D
		public unsafe bool consideredForMargin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_consideredForMargin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_consideredForMargin)) = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x00011B04 File Offset: 0x0000FD04
		// (set) Token: 0x060004BD RID: 1213 RVA: 0x00004078 File Offset: 0x00002278
		public unsafe GUIStyle m_Style
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_m_Style);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_m_Style), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x00011B34 File Offset: 0x0000FD34
		// (set) Token: 0x060004BF RID: 1215 RVA: 0x00004097 File Offset: 0x00002297
		public unsafe static Rect kDummyRect
		{
			get
			{
				Rect rect;
				IL2CPP.il2cpp_field_static_get_value(GUILayoutEntry.NativeFieldInfoPtr_kDummyRect, (void*)(&rect));
				return rect;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUILayoutEntry.NativeFieldInfoPtr_kDummyRect, (void*)(&value));
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x00011B50 File Offset: 0x0000FD50
		// (set) Token: 0x060004C1 RID: 1217 RVA: 0x000040A5 File Offset: 0x000022A5
		public unsafe static int indent
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUILayoutEntry.NativeFieldInfoPtr_indent, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUILayoutEntry.NativeFieldInfoPtr_indent, (void*)(&value));
			}
		}

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeFieldInfoPtr_minWidth;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeFieldInfoPtr_maxWidth;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeFieldInfoPtr_minHeight;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeFieldInfoPtr_maxHeight;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeFieldInfoPtr_rect;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeFieldInfoPtr_stretchWidth;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeFieldInfoPtr_stretchHeight;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeFieldInfoPtr_consideredForMargin;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeFieldInfoPtr_m_Style;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeFieldInfoPtr_kDummyRect;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeFieldInfoPtr_indent;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr_get_style_Public_get_GUIStyle_0;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr_set_style_Public_set_Void_GUIStyle_0;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeMethodInfoPtr_get_marginLeft_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeMethodInfoPtr_get_marginRight_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeMethodInfoPtr_get_marginTop_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr_get_marginBottom_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr_get_marginHorizontal_Public_get_Int32_0;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_get_marginVertical_Public_get_Int32_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_GUIStyle_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_CalcWidth_Public_Virtual_New_Void_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_CalcHeight_Public_Virtual_New_Void_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_SetHorizontal_Public_Virtual_New_Void_Single_Single_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_SetVertical_Public_Virtual_New_Void_Single_Single_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_ApplyStyleSettings_Protected_Virtual_New_Void_GUIStyle_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_ApplyOptions_Public_Virtual_New_Void_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
