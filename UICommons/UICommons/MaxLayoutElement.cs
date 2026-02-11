using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.UI;

namespace Kyub.UI
{
	// Token: 0x02000005 RID: 5
	public class MaxLayoutElement : LayoutElement
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00002E4C File Offset: 0x0000104C
		// Note: this type is marked as 'beforefieldinit'.
		static MaxLayoutElement()
		{
			Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("UICommons.dll", "Kyub.UI", "MaxLayoutElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr);
			MaxLayoutElement.NativeFieldInfoPtr_m_MaxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, "m_MaxWidth");
			MaxLayoutElement.NativeFieldInfoPtr_m_MaxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, "m_MaxHeight");
			MaxLayoutElement.NativeFieldInfoPtr__CurrentPreferredWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, "_CurrentPreferredWidth");
			MaxLayoutElement.NativeFieldInfoPtr__CurrentPreferredHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, "_CurrentPreferredHeight");
			MaxLayoutElement.NativeFieldInfoPtr__CurrentFlexibleWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, "_CurrentFlexibleWidth");
			MaxLayoutElement.NativeFieldInfoPtr__CurrentFlexibleHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, "_CurrentFlexibleHeight");
			MaxLayoutElement.NativeMethodInfoPtr_get_maxWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663333);
			MaxLayoutElement.NativeMethodInfoPtr_set_maxWidth_Public_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663334);
			MaxLayoutElement.NativeMethodInfoPtr_get_maxHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663335);
			MaxLayoutElement.NativeMethodInfoPtr_set_maxHeight_Public_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663336);
			MaxLayoutElement.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663337);
			MaxLayoutElement.NativeMethodInfoPtr_set_preferredWidth_Public_Virtual_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663338);
			MaxLayoutElement.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663339);
			MaxLayoutElement.NativeMethodInfoPtr_set_preferredHeight_Public_Virtual_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663340);
			MaxLayoutElement.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663341);
			MaxLayoutElement.NativeMethodInfoPtr_set_flexibleWidth_Public_Virtual_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663342);
			MaxLayoutElement.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663343);
			MaxLayoutElement.NativeMethodInfoPtr_set_flexibleHeight_Public_Virtual_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663344);
			MaxLayoutElement.NativeMethodInfoPtr_get_basePreferredWidth_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663345);
			MaxLayoutElement.NativeMethodInfoPtr_set_basePreferredWidth_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663346);
			MaxLayoutElement.NativeMethodInfoPtr_get_basePreferredHeight_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663347);
			MaxLayoutElement.NativeMethodInfoPtr_set_basePreferredHeight_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663348);
			MaxLayoutElement.NativeMethodInfoPtr_get_baseFlexibleWidth_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663349);
			MaxLayoutElement.NativeMethodInfoPtr_set_baseFlexibleWidth_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663350);
			MaxLayoutElement.NativeMethodInfoPtr_get_baseFlexibleHeight_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663351);
			MaxLayoutElement.NativeMethodInfoPtr_set_baseFlexibleHeight_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663352);
			MaxLayoutElement.NativeMethodInfoPtr_get_baseMinWidth_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663353);
			MaxLayoutElement.NativeMethodInfoPtr_set_baseMinWidth_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663354);
			MaxLayoutElement.NativeMethodInfoPtr_get_baseMinHeight_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663355);
			MaxLayoutElement.NativeMethodInfoPtr_set_baseMinHeight_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663356);
			MaxLayoutElement.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663357);
			MaxLayoutElement.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663358);
			MaxLayoutElement.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663359);
			MaxLayoutElement.NativeMethodInfoPtr_CheckMaxSize_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663360);
			MaxLayoutElement.NativeMethodInfoPtr_CheckMaxSize_Protected_Virtual_New_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663361);
			MaxLayoutElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr, 100663362);
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000028 RID: 40 RVA: 0x0000314C File Offset: 0x0000134C
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00003194 File Offset: 0x00001394
		public unsafe virtual float maxWidth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300360, RefRangeEnd = 300361, XrefRangeStart = 300360, XrefRangeEnd = 300361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaxLayoutElement.NativeMethodInfoPtr_get_maxWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269448, XrefRangeEnd = 1269449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaxLayoutElement.NativeMethodInfoPtr_set_maxWidth_Public_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000031E0 File Offset: 0x000013E0
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00003228 File Offset: 0x00001428
		public unsafe virtual float maxHeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300359, RefRangeEnd = 300360, XrefRangeStart = 300359, XrefRangeEnd = 300360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaxLayoutElement.NativeMethodInfoPtr_get_maxHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269449, XrefRangeEnd = 1269450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaxLayoutElement.NativeMethodInfoPtr_set_maxHeight_Public_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00003274 File Offset: 0x00001474
		// (set) Token: 0x0600002D RID: 45 RVA: 0x000032BC File Offset: 0x000014BC
		public unsafe override float preferredWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaxLayoutElement.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269450, XrefRangeEnd = 1269451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaxLayoutElement.NativeMethodInfoPtr_set_preferredWidth_Public_Virtual_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00003308 File Offset: 0x00001508
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00003350 File Offset: 0x00001550
		public unsafe override float preferredHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaxLayoutElement.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269451, XrefRangeEnd = 1269452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaxLayoutElement.NativeMethodInfoPtr_set_preferredHeight_Public_Virtual_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000030 RID: 48 RVA: 0x0000339C File Offset: 0x0000159C
		// (set) Token: 0x06000031 RID: 49 RVA: 0x000033E4 File Offset: 0x000015E4
		public unsafe override float flexibleWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaxLayoutElement.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269452, XrefRangeEnd = 1269453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaxLayoutElement.NativeMethodInfoPtr_set_flexibleWidth_Public_Virtual_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00003430 File Offset: 0x00001630
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00003478 File Offset: 0x00001678
		public unsafe override float flexibleHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaxLayoutElement.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269453, XrefRangeEnd = 1269454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaxLayoutElement.NativeMethodInfoPtr_set_flexibleHeight_Public_Virtual_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000034C4 File Offset: 0x000016C4
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00003500 File Offset: 0x00001700
		public unsafe float basePreferredWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaxLayoutElement.NativeMethodInfoPtr_get_basePreferredWidth_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269454, XrefRangeEnd = 1269455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaxLayoutElement.NativeMethodInfoPtr_set_basePreferredWidth_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00003540 File Offset: 0x00001740
		// (set) Token: 0x06000037 RID: 55 RVA: 0x0000357C File Offset: 0x0000177C
		public unsafe float basePreferredHeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 318235, RefRangeEnd = 318236, XrefRangeStart = 318235, XrefRangeEnd = 318236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaxLayoutElement.NativeMethodInfoPtr_get_basePreferredHeight_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269455, XrefRangeEnd = 1269456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaxLayoutElement.NativeMethodInfoPtr_set_basePreferredHeight_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000035BC File Offset: 0x000017BC
		// (set) Token: 0x06000039 RID: 57 RVA: 0x000035F8 File Offset: 0x000017F8
		public unsafe float baseFlexibleWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaxLayoutElement.NativeMethodInfoPtr_get_baseFlexibleWidth_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269456, XrefRangeEnd = 1269457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaxLayoutElement.NativeMethodInfoPtr_set_baseFlexibleWidth_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00003638 File Offset: 0x00001838
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00003674 File Offset: 0x00001874
		public unsafe float baseFlexibleHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaxLayoutElement.NativeMethodInfoPtr_get_baseFlexibleHeight_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269457, XrefRangeEnd = 1269458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaxLayoutElement.NativeMethodInfoPtr_set_baseFlexibleHeight_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000036B4 File Offset: 0x000018B4
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000036F0 File Offset: 0x000018F0
		public unsafe float baseMinWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaxLayoutElement.NativeMethodInfoPtr_get_baseMinWidth_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269458, XrefRangeEnd = 1269459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaxLayoutElement.NativeMethodInfoPtr_set_baseMinWidth_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00003730 File Offset: 0x00001930
		// (set) Token: 0x0600003F RID: 63 RVA: 0x0000376C File Offset: 0x0000196C
		public unsafe float baseMinHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaxLayoutElement.NativeMethodInfoPtr_get_baseMinHeight_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269459, XrefRangeEnd = 1269460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaxLayoutElement.NativeMethodInfoPtr_set_baseMinHeight_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000037AC File Offset: 0x000019AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269460, XrefRangeEnd = 1269461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaxLayoutElement.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000037E8 File Offset: 0x000019E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269461, XrefRangeEnd = 1269489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaxLayoutElement.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003824 File Offset: 0x00001A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269489, XrefRangeEnd = 1269518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaxLayoutElement.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003860 File Offset: 0x00001A60
		[CallerCount(0)]
		public unsafe virtual bool CheckMaxSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaxLayoutElement.NativeMethodInfoPtr_CheckMaxSize_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000038A8 File Offset: 0x00001AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269518, XrefRangeEnd = 1269533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CheckMaxSize(bool p_forceCalculate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p_forceCalculate;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaxLayoutElement.NativeMethodInfoPtr_CheckMaxSize_Protected_Virtual_New_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000038FC File Offset: 0x00001AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269533, XrefRangeEnd = 1269534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaxLayoutElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaxLayoutElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaxLayoutElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000020DB File Offset: 0x000002DB
		public MaxLayoutElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00003938 File Offset: 0x00001B38
		// (set) Token: 0x06000048 RID: 72 RVA: 0x000020E4 File Offset: 0x000002E4
		public unsafe float m_MaxWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaxLayoutElement.NativeFieldInfoPtr_m_MaxWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaxLayoutElement.NativeFieldInfoPtr_m_MaxWidth)) = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00003960 File Offset: 0x00001B60
		// (set) Token: 0x0600004A RID: 74 RVA: 0x000020FF File Offset: 0x000002FF
		public unsafe float m_MaxHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaxLayoutElement.NativeFieldInfoPtr_m_MaxHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaxLayoutElement.NativeFieldInfoPtr_m_MaxHeight)) = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00003988 File Offset: 0x00001B88
		// (set) Token: 0x0600004C RID: 76 RVA: 0x0000211A File Offset: 0x0000031A
		public unsafe float _CurrentPreferredWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaxLayoutElement.NativeFieldInfoPtr__CurrentPreferredWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaxLayoutElement.NativeFieldInfoPtr__CurrentPreferredWidth)) = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600004D RID: 77 RVA: 0x000039B0 File Offset: 0x00001BB0
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00002135 File Offset: 0x00000335
		public unsafe float _CurrentPreferredHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaxLayoutElement.NativeFieldInfoPtr__CurrentPreferredHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaxLayoutElement.NativeFieldInfoPtr__CurrentPreferredHeight)) = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000039D8 File Offset: 0x00001BD8
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002150 File Offset: 0x00000350
		public unsafe float _CurrentFlexibleWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaxLayoutElement.NativeFieldInfoPtr__CurrentFlexibleWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaxLayoutElement.NativeFieldInfoPtr__CurrentFlexibleWidth)) = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00003A00 File Offset: 0x00001C00
		// (set) Token: 0x06000052 RID: 82 RVA: 0x0000216B File Offset: 0x0000036B
		public unsafe float _CurrentFlexibleHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaxLayoutElement.NativeFieldInfoPtr__CurrentFlexibleHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaxLayoutElement.NativeFieldInfoPtr__CurrentFlexibleHeight)) = value;
			}
		}

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxWidth;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxHeight;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPreferredWidth;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPreferredHeight;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr__CurrentFlexibleWidth;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr__CurrentFlexibleHeight;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_get_maxWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_set_maxWidth_Public_Virtual_New_set_Void_Single_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_get_maxHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_set_maxHeight_Public_Virtual_New_set_Void_Single_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_get_Single_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_set_preferredWidth_Public_Virtual_set_Void_Single_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_get_Single_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_set_preferredHeight_Public_Virtual_set_Void_Single_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_get_Single_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_set_flexibleWidth_Public_Virtual_set_Void_Single_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_get_Single_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_set_flexibleHeight_Public_Virtual_set_Void_Single_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_get_basePreferredWidth_Protected_get_Single_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_set_basePreferredWidth_Protected_set_Void_Single_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_get_basePreferredHeight_Protected_get_Single_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_set_basePreferredHeight_Protected_set_Void_Single_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_get_baseFlexibleWidth_Protected_get_Single_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_set_baseFlexibleWidth_Protected_set_Void_Single_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_get_baseFlexibleHeight_Protected_get_Single_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_set_baseFlexibleHeight_Protected_set_Void_Single_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_get_baseMinWidth_Protected_get_Single_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_set_baseMinWidth_Protected_set_Void_Single_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_get_baseMinHeight_Protected_get_Single_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_set_baseMinHeight_Protected_set_Void_Single_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_CheckMaxSize_Protected_Virtual_New_Boolean_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_CheckMaxSize_Protected_Virtual_New_Boolean_Boolean_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
