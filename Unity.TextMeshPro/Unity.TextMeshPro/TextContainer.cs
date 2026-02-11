using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TMPro
{
	// Token: 0x0200000C RID: 12
	public class TextContainer : UIBehaviour
	{
		// Token: 0x06000072 RID: 114 RVA: 0x0000B9B0 File Offset: 0x00009BB0
		// Note: this type is marked as 'beforefieldinit'.
		static TextContainer()
		{
			Il2CppClassPointerStore<TextContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TextContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextContainer>.NativeClassPtr);
			TextContainer.NativeFieldInfoPtr_m_hasChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_hasChanged");
			TextContainer.NativeFieldInfoPtr_m_pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_pivot");
			TextContainer.NativeFieldInfoPtr_m_anchorPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_anchorPosition");
			TextContainer.NativeFieldInfoPtr_m_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_rect");
			TextContainer.NativeFieldInfoPtr_m_isDefaultWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_isDefaultWidth");
			TextContainer.NativeFieldInfoPtr_m_isDefaultHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_isDefaultHeight");
			TextContainer.NativeFieldInfoPtr_m_isAutoFitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_isAutoFitting");
			TextContainer.NativeFieldInfoPtr_m_corners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_corners");
			TextContainer.NativeFieldInfoPtr_m_worldCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_worldCorners");
			TextContainer.NativeFieldInfoPtr_m_margins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_margins");
			TextContainer.NativeFieldInfoPtr_m_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_rectTransform");
			TextContainer.NativeFieldInfoPtr_k_defaultSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "k_defaultSize");
			TextContainer.NativeFieldInfoPtr_m_textMeshPro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_textMeshPro");
			TextContainer.NativeMethodInfoPtr_get_hasChanged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663342);
			TextContainer.NativeMethodInfoPtr_set_hasChanged_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663343);
			TextContainer.NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663344);
			TextContainer.NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663345);
			TextContainer.NativeMethodInfoPtr_get_anchorPosition_Public_get_TextContainerAnchors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663346);
			TextContainer.NativeMethodInfoPtr_set_anchorPosition_Public_set_Void_TextContainerAnchors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663347);
			TextContainer.NativeMethodInfoPtr_get_rect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663348);
			TextContainer.NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663349);
			TextContainer.NativeMethodInfoPtr_get_size_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663350);
			TextContainer.NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663351);
			TextContainer.NativeMethodInfoPtr_get_width_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663352);
			TextContainer.NativeMethodInfoPtr_set_width_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663353);
			TextContainer.NativeMethodInfoPtr_get_height_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663354);
			TextContainer.NativeMethodInfoPtr_set_height_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663355);
			TextContainer.NativeMethodInfoPtr_get_isDefaultWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663356);
			TextContainer.NativeMethodInfoPtr_get_isDefaultHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663357);
			TextContainer.NativeMethodInfoPtr_get_isAutoFitting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663358);
			TextContainer.NativeMethodInfoPtr_set_isAutoFitting_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663359);
			TextContainer.NativeMethodInfoPtr_get_corners_Public_get_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663360);
			TextContainer.NativeMethodInfoPtr_get_worldCorners_Public_get_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663361);
			TextContainer.NativeMethodInfoPtr_get_margins_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663362);
			TextContainer.NativeMethodInfoPtr_set_margins_Public_set_Void_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663363);
			TextContainer.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663364);
			TextContainer.NativeMethodInfoPtr_get_textMeshPro_Public_get_TextMeshPro_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663365);
			TextContainer.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663366);
			TextContainer.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663367);
			TextContainer.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663368);
			TextContainer.NativeMethodInfoPtr_OnContainerChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663369);
			TextContainer.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663370);
			TextContainer.NativeMethodInfoPtr_SetRect_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663371);
			TextContainer.NativeMethodInfoPtr_UpdateCorners_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663372);
			TextContainer.NativeMethodInfoPtr_GetPivot_Private_Vector2_TextContainerAnchors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663373);
			TextContainer.NativeMethodInfoPtr_GetAnchorPosition_Private_TextContainerAnchors_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663374);
			TextContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100663375);
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000073 RID: 115 RVA: 0x0000BD8C File Offset: 0x00009F8C
		// (set) Token: 0x06000074 RID: 116 RVA: 0x0000BDC8 File Offset: 0x00009FC8
		public unsafe bool hasChanged
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_hasChanged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_set_hasChanged_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000075 RID: 117 RVA: 0x0000BE08 File Offset: 0x0000A008
		// (set) Token: 0x06000076 RID: 118 RVA: 0x0000BE44 File Offset: 0x0000A044
		public unsafe Vector2 pivot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032687, XrefRangeEnd = 1032689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000077 RID: 119 RVA: 0x0000BE84 File Offset: 0x0000A084
		// (set) Token: 0x06000078 RID: 120 RVA: 0x0000BEC0 File Offset: 0x0000A0C0
		public unsafe TextContainerAnchors anchorPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_anchorPosition_Public_get_TextContainerAnchors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032689, XrefRangeEnd = 1032700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_set_anchorPosition_Public_set_Void_TextContainerAnchors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000079 RID: 121 RVA: 0x0000BF00 File Offset: 0x0000A100
		// (set) Token: 0x0600007A RID: 122 RVA: 0x0000BF3C File Offset: 0x0000A13C
		public unsafe Rect rect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_rect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032700, XrefRangeEnd = 1032701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0000BF7C File Offset: 0x0000A17C
		// (set) Token: 0x0600007C RID: 124 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
		public unsafe Vector2 size
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_size_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032701, XrefRangeEnd = 1032702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600007D RID: 125 RVA: 0x0000BFF8 File Offset: 0x0000A1F8
		// (set) Token: 0x0600007E RID: 126 RVA: 0x0000C034 File Offset: 0x0000A234
		public unsafe float width
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 1032702, RefRangeEnd = 1032747, XrefRangeStart = 1032702, XrefRangeEnd = 1032702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_width_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032747, XrefRangeEnd = 1032748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_set_width_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0000C074 File Offset: 0x0000A274
		// (set) Token: 0x06000080 RID: 128 RVA: 0x0000C0B0 File Offset: 0x0000A2B0
		public unsafe float height
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1032748, RefRangeEnd = 1032751, XrefRangeStart = 1032748, XrefRangeEnd = 1032748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_height_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032751, XrefRangeEnd = 1032752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_set_height_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		public unsafe bool isDefaultWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_isDefaultWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0000C12C File Offset: 0x0000A32C
		public unsafe bool isDefaultHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_isDefaultHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000083 RID: 131 RVA: 0x0000C168 File Offset: 0x0000A368
		// (set) Token: 0x06000084 RID: 132 RVA: 0x0000C1A4 File Offset: 0x0000A3A4
		public unsafe bool isAutoFitting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_isAutoFitting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_set_isAutoFitting_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000085 RID: 133 RVA: 0x0000C1E4 File Offset: 0x0000A3E4
		public unsafe Il2CppStructArray<Vector3> corners
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_corners_Public_get_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000086 RID: 134 RVA: 0x0000C224 File Offset: 0x0000A424
		public unsafe Il2CppStructArray<Vector3> worldCorners
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_worldCorners_Public_get_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000087 RID: 135 RVA: 0x0000C264 File Offset: 0x0000A464
		// (set) Token: 0x06000088 RID: 136 RVA: 0x0000C2A0 File Offset: 0x0000A4A0
		public unsafe Vector4 margins
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_margins_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032752, XrefRangeEnd = 1032753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_set_margins_Public_set_Void_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000089 RID: 137 RVA: 0x0000C2E0 File Offset: 0x0000A4E0
		public unsafe RectTransform rectTransform
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032753, XrefRangeEnd = 1032761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0000C320 File Offset: 0x0000A520
		public unsafe TextMeshPro textMeshPro
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032761, XrefRangeEnd = 1032769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_textMeshPro_Public_get_TextMeshPro_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr3) : null;
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000C360 File Offset: 0x0000A560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032769, XrefRangeEnd = 1032781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextContainer.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000C39C File Offset: 0x0000A59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032781, XrefRangeEnd = 1032782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextContainer.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextContainer.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000C414 File Offset: 0x0000A614
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1032800, RefRangeEnd = 1032811, XrefRangeStart = 1032782, XrefRangeEnd = 1032800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnContainerChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_OnContainerChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000C448 File Offset: 0x0000A648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032811, XrefRangeEnd = 1032840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextContainer.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000C484 File Offset: 0x0000A684
		[CallerCount(0)]
		public unsafe void SetRect(Vector2 size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_SetRect_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000C4C4 File Offset: 0x0000A6C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1032845, RefRangeEnd = 1032846, XrefRangeStart = 1032840, XrefRangeEnd = 1032845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCorners()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_UpdateCorners_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000C4F8 File Offset: 0x0000A6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032846, XrefRangeEnd = 1032848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetPivot(TextContainerAnchors anchor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref anchor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_GetPivot_Private_Vector2_TextContainerAnchors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000C544 File Offset: 0x0000A744
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1032848, RefRangeEnd = 1032850, XrefRangeStart = 1032848, XrefRangeEnd = 1032848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextContainerAnchors GetAnchorPosition(Vector2 pivot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pivot;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_GetAnchorPosition_Private_TextContainerAnchors_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000C590 File Offset: 0x0000A790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032850, XrefRangeEnd = 1032858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextContainer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000023B7 File Offset: 0x000005B7
		public TextContainer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0000C5CC File Offset: 0x0000A7CC
		// (set) Token: 0x06000097 RID: 151 RVA: 0x000023C0 File Offset: 0x000005C0
		public unsafe bool m_hasChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_hasChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_hasChanged)) = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000098 RID: 152 RVA: 0x0000C5F4 File Offset: 0x0000A7F4
		// (set) Token: 0x06000099 RID: 153 RVA: 0x000023DB File Offset: 0x000005DB
		public unsafe Vector2 m_pivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_pivot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_pivot)) = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0000C61C File Offset: 0x0000A81C
		// (set) Token: 0x0600009B RID: 155 RVA: 0x000023F6 File Offset: 0x000005F6
		public unsafe TextContainerAnchors m_anchorPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_anchorPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_anchorPosition)) = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0000C644 File Offset: 0x0000A844
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00002411 File Offset: 0x00000611
		public unsafe Rect m_rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_rect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_rect)) = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0000C66C File Offset: 0x0000A86C
		// (set) Token: 0x0600009F RID: 159 RVA: 0x0000242C File Offset: 0x0000062C
		public unsafe bool m_isDefaultWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_isDefaultWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_isDefaultWidth)) = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0000C694 File Offset: 0x0000A894
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00002447 File Offset: 0x00000647
		public unsafe bool m_isDefaultHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_isDefaultHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_isDefaultHeight)) = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000C6BC File Offset: 0x0000A8BC
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00002462 File Offset: 0x00000662
		public unsafe bool m_isAutoFitting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_isAutoFitting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_isAutoFitting)) = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0000C6E4 File Offset: 0x0000A8E4
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x0000247D File Offset: 0x0000067D
		public unsafe Il2CppStructArray<Vector3> m_corners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_corners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_corners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0000C714 File Offset: 0x0000A914
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x0000249C File Offset: 0x0000069C
		public unsafe Il2CppStructArray<Vector3> m_worldCorners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_worldCorners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_worldCorners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0000C744 File Offset: 0x0000A944
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x000024BB File Offset: 0x000006BB
		public unsafe Vector4 m_margins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_margins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_margins)) = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0000C76C File Offset: 0x0000A96C
		// (set) Token: 0x060000AB RID: 171 RVA: 0x000024D6 File Offset: 0x000006D6
		public unsafe RectTransform m_rectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_rectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_rectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0000C79C File Offset: 0x0000A99C
		// (set) Token: 0x060000AD RID: 173 RVA: 0x000024F5 File Offset: 0x000006F5
		public unsafe static Vector2 k_defaultSize
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TextContainer.NativeFieldInfoPtr_k_defaultSize, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextContainer.NativeFieldInfoPtr_k_defaultSize, (void*)(&value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0000C7B8 File Offset: 0x0000A9B8
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00002503 File Offset: 0x00000703
		public unsafe TextMeshPro m_textMeshPro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_textMeshPro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_textMeshPro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr_m_hasChanged;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr_m_pivot;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeFieldInfoPtr_m_anchorPosition;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeFieldInfoPtr_m_rect;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeFieldInfoPtr_m_isDefaultWidth;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeFieldInfoPtr_m_isDefaultHeight;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeFieldInfoPtr_m_isAutoFitting;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr_m_corners;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr_m_worldCorners;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeFieldInfoPtr_m_margins;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr_m_rectTransform;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr_k_defaultSize;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr_m_textMeshPro;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_get_hasChanged_Public_get_Boolean_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_set_hasChanged_Public_set_Void_Boolean_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector2_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_get_anchorPosition_Public_get_TextContainerAnchors_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_set_anchorPosition_Public_set_Void_TextContainerAnchors_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_get_rect_Public_get_Rect_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_get_Vector2_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Single_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_set_width_Public_set_Void_Single_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Single_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_set_height_Public_set_Void_Single_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_get_isDefaultWidth_Public_get_Boolean_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_get_isDefaultHeight_Public_get_Boolean_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_get_isAutoFitting_Public_get_Boolean_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_set_isAutoFitting_Public_set_Void_Boolean_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_get_corners_Public_get_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_get_worldCorners_Public_get_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_get_margins_Public_get_Vector4_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_set_margins_Public_set_Void_Vector4_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_get_textMeshPro_Public_get_TextMeshPro_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_OnContainerChanged_Private_Void_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_SetRect_Private_Void_Vector2_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCorners_Private_Void_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_GetPivot_Private_Vector2_TextContainerAnchors_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_GetAnchorPosition_Private_TextContainerAnchors_Vector2_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
