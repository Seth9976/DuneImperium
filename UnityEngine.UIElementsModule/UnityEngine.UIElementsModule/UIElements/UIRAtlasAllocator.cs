using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x02000168 RID: 360
	public class UIRAtlasAllocator : Object
	{
		// Token: 0x06001A75 RID: 6773 RVA: 0x0007A9D4 File Offset: 0x00078BD4
		// Note: this type is marked as 'beforefieldinit'.
		static UIRAtlasAllocator()
		{
			Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UIRAtlasAllocator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr);
			UIRAtlasAllocator.NativeFieldInfoPtr__maxAtlasSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, "<maxAtlasSize>k__BackingField");
			UIRAtlasAllocator.NativeFieldInfoPtr__maxImageWidth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, "<maxImageWidth>k__BackingField");
			UIRAtlasAllocator.NativeFieldInfoPtr__maxImageHeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, "<maxImageHeight>k__BackingField");
			UIRAtlasAllocator.NativeFieldInfoPtr__virtualWidth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, "<virtualWidth>k__BackingField");
			UIRAtlasAllocator.NativeFieldInfoPtr__virtualHeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, "<virtualHeight>k__BackingField");
			UIRAtlasAllocator.NativeFieldInfoPtr__physicalWidth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, "<physicalWidth>k__BackingField");
			UIRAtlasAllocator.NativeFieldInfoPtr__physicalHeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, "<physicalHeight>k__BackingField");
			UIRAtlasAllocator.NativeFieldInfoPtr_m_FirstUnpartitionedArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, "m_FirstUnpartitionedArea");
			UIRAtlasAllocator.NativeFieldInfoPtr_m_OpenRows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, "m_OpenRows");
			UIRAtlasAllocator.NativeFieldInfoPtr_m_1SidePadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, "m_1SidePadding");
			UIRAtlasAllocator.NativeFieldInfoPtr_m_2SidePadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, "m_2SidePadding");
			UIRAtlasAllocator.NativeFieldInfoPtr_s_MarkerTryAllocate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, "s_MarkerTryAllocate");
			UIRAtlasAllocator.NativeFieldInfoPtr__disposed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, "<disposed>k__BackingField");
			UIRAtlasAllocator.NativeMethodInfoPtr_get_maxAtlasSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, 100667161);
			UIRAtlasAllocator.NativeMethodInfoPtr_get_maxImageWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, 100667162);
			UIRAtlasAllocator.NativeMethodInfoPtr_get_maxImageHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, 100667163);
			UIRAtlasAllocator.NativeMethodInfoPtr_get_virtualWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, 100667164);
			UIRAtlasAllocator.NativeMethodInfoPtr_set_virtualWidth_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, 100667165);
			UIRAtlasAllocator.NativeMethodInfoPtr_get_virtualHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, 100667166);
			UIRAtlasAllocator.NativeMethodInfoPtr_set_virtualHeight_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, 100667167);
			UIRAtlasAllocator.NativeMethodInfoPtr_get_physicalWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, 100667168);
			UIRAtlasAllocator.NativeMethodInfoPtr_set_physicalWidth_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, 100667169);
			UIRAtlasAllocator.NativeMethodInfoPtr_get_physicalHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, 100667170);
			UIRAtlasAllocator.NativeMethodInfoPtr_set_physicalHeight_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, 100667171);
			UIRAtlasAllocator.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, 100667172);
			UIRAtlasAllocator.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, 100667173);
			UIRAtlasAllocator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, 100667174);
			UIRAtlasAllocator.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, 100667175);
			UIRAtlasAllocator.NativeMethodInfoPtr_GetLog2OfNextPower_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, 100667176);
			UIRAtlasAllocator.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, 100667177);
			UIRAtlasAllocator.NativeMethodInfoPtr_TryAllocate_Public_Boolean_Int32_Int32_byref_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, 100667178);
			UIRAtlasAllocator.NativeMethodInfoPtr_TryPartitionArea_Private_Boolean_AreaNode_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, 100667179);
			UIRAtlasAllocator.NativeMethodInfoPtr_BuildAreas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, 100667180);
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06001A76 RID: 6774 RVA: 0x0007AC98 File Offset: 0x00078E98
		public unsafe int maxAtlasSize
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.NativeMethodInfoPtr_get_maxAtlasSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06001A77 RID: 6775 RVA: 0x0007ACD4 File Offset: 0x00078ED4
		public unsafe int maxImageWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.NativeMethodInfoPtr_get_maxImageWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06001A78 RID: 6776 RVA: 0x0007AD10 File Offset: 0x00078F10
		public unsafe int maxImageHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.NativeMethodInfoPtr_get_maxImageHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06001A79 RID: 6777 RVA: 0x0007AD4C File Offset: 0x00078F4C
		// (set) Token: 0x06001A7A RID: 6778 RVA: 0x0007AD88 File Offset: 0x00078F88
		public unsafe int virtualWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.NativeMethodInfoPtr_get_virtualWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.NativeMethodInfoPtr_set_virtualWidth_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06001A7B RID: 6779 RVA: 0x0007ADC8 File Offset: 0x00078FC8
		// (set) Token: 0x06001A7C RID: 6780 RVA: 0x0007AE04 File Offset: 0x00079004
		public unsafe int virtualHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.NativeMethodInfoPtr_get_virtualHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.NativeMethodInfoPtr_set_virtualHeight_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06001A7D RID: 6781 RVA: 0x0007AE44 File Offset: 0x00079044
		// (set) Token: 0x06001A7E RID: 6782 RVA: 0x0007AE80 File Offset: 0x00079080
		public unsafe int physicalWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.NativeMethodInfoPtr_get_physicalWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.NativeMethodInfoPtr_set_physicalWidth_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06001A7F RID: 6783 RVA: 0x0007AEC0 File Offset: 0x000790C0
		// (set) Token: 0x06001A80 RID: 6784 RVA: 0x0007AEFC File Offset: 0x000790FC
		public unsafe int physicalHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.NativeMethodInfoPtr_get_physicalHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.NativeMethodInfoPtr_set_physicalHeight_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06001A81 RID: 6785 RVA: 0x0007AF3C File Offset: 0x0007913C
		// (set) Token: 0x06001A82 RID: 6786 RVA: 0x0007AF78 File Offset: 0x00079178
		public unsafe bool disposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x0007AFB8 File Offset: 0x000791B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322172, RefRangeEnd = 322173, XrefRangeStart = 322168, XrefRangeEnd = 322172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x0007AFEC File Offset: 0x000791EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322173, XrefRangeEnd = 322184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIRAtlasAllocator.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x0007B038 File Offset: 0x00079238
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322190, RefRangeEnd = 322191, XrefRangeStart = 322184, XrefRangeEnd = 322190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLog2OfNextPower(int n)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.NativeMethodInfoPtr_GetLog2OfNextPower_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x0007B078 File Offset: 0x00079278
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322227, RefRangeEnd = 322228, XrefRangeStart = 322191, XrefRangeEnd = 322227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIRAtlasAllocator(int initialAtlasSize, int maxAtlasSize, int sidePadding = 1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialAtlasSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxAtlasSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sidePadding;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x0007B0DC File Offset: 0x000792DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322267, RefRangeEnd = 322268, XrefRangeStart = 322228, XrefRangeEnd = 322267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAllocate(int width, int height, out RectInt location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &location;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.NativeMethodInfoPtr_TryAllocate_Public_Boolean_Int32_Int32_byref_RectInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x0007B144 File Offset: 0x00079344
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322288, RefRangeEnd = 322289, XrefRangeStart = 322268, XrefRangeEnd = 322288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryPartitionArea(UIRAtlasAllocator.AreaNode areaNode, int rowIndex, int rowHeight, int minWidth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(areaNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rowIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rowHeight;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minWidth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.NativeMethodInfoPtr_TryPartitionArea_Private_Boolean_AreaNode_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x0007B1BC File Offset: 0x000793BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322289, XrefRangeEnd = 322296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildAreas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.NativeMethodInfoPtr_BuildAreas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x0000C04F File Offset: 0x0000A24F
		public UIRAtlasAllocator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06001A8B RID: 6795 RVA: 0x0007B1F0 File Offset: 0x000793F0
		// (set) Token: 0x06001A8C RID: 6796 RVA: 0x0000C058 File Offset: 0x0000A258
		public unsafe int _maxAtlasSize_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.NativeFieldInfoPtr__maxAtlasSize_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.NativeFieldInfoPtr__maxAtlasSize_k__BackingField)) = value;
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06001A8D RID: 6797 RVA: 0x0007B218 File Offset: 0x00079418
		// (set) Token: 0x06001A8E RID: 6798 RVA: 0x0000C073 File Offset: 0x0000A273
		public unsafe int _maxImageWidth_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.NativeFieldInfoPtr__maxImageWidth_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.NativeFieldInfoPtr__maxImageWidth_k__BackingField)) = value;
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06001A8F RID: 6799 RVA: 0x0007B240 File Offset: 0x00079440
		// (set) Token: 0x06001A90 RID: 6800 RVA: 0x0000C08E File Offset: 0x0000A28E
		public unsafe int _maxImageHeight_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.NativeFieldInfoPtr__maxImageHeight_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.NativeFieldInfoPtr__maxImageHeight_k__BackingField)) = value;
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06001A91 RID: 6801 RVA: 0x0007B268 File Offset: 0x00079468
		// (set) Token: 0x06001A92 RID: 6802 RVA: 0x0000C0A9 File Offset: 0x0000A2A9
		public unsafe int _virtualWidth_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.NativeFieldInfoPtr__virtualWidth_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.NativeFieldInfoPtr__virtualWidth_k__BackingField)) = value;
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06001A93 RID: 6803 RVA: 0x0007B290 File Offset: 0x00079490
		// (set) Token: 0x06001A94 RID: 6804 RVA: 0x0000C0C4 File Offset: 0x0000A2C4
		public unsafe int _virtualHeight_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.NativeFieldInfoPtr__virtualHeight_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.NativeFieldInfoPtr__virtualHeight_k__BackingField)) = value;
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06001A95 RID: 6805 RVA: 0x0007B2B8 File Offset: 0x000794B8
		// (set) Token: 0x06001A96 RID: 6806 RVA: 0x0000C0DF File Offset: 0x0000A2DF
		public unsafe int _physicalWidth_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.NativeFieldInfoPtr__physicalWidth_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.NativeFieldInfoPtr__physicalWidth_k__BackingField)) = value;
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06001A97 RID: 6807 RVA: 0x0007B2E0 File Offset: 0x000794E0
		// (set) Token: 0x06001A98 RID: 6808 RVA: 0x0000C0FA File Offset: 0x0000A2FA
		public unsafe int _physicalHeight_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.NativeFieldInfoPtr__physicalHeight_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.NativeFieldInfoPtr__physicalHeight_k__BackingField)) = value;
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06001A99 RID: 6809 RVA: 0x0007B308 File Offset: 0x00079508
		// (set) Token: 0x06001A9A RID: 6810 RVA: 0x0000C115 File Offset: 0x0000A315
		public unsafe UIRAtlasAllocator.AreaNode m_FirstUnpartitionedArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.NativeFieldInfoPtr_m_FirstUnpartitionedArea);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIRAtlasAllocator.AreaNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.NativeFieldInfoPtr_m_FirstUnpartitionedArea), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06001A9B RID: 6811 RVA: 0x0007B338 File Offset: 0x00079538
		// (set) Token: 0x06001A9C RID: 6812 RVA: 0x0000C134 File Offset: 0x0000A334
		public unsafe Il2CppReferenceArray<UIRAtlasAllocator.Row> m_OpenRows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.NativeFieldInfoPtr_m_OpenRows);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UIRAtlasAllocator.Row>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.NativeFieldInfoPtr_m_OpenRows), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06001A9D RID: 6813 RVA: 0x0007B368 File Offset: 0x00079568
		// (set) Token: 0x06001A9E RID: 6814 RVA: 0x0000C153 File Offset: 0x0000A353
		public unsafe int m_1SidePadding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.NativeFieldInfoPtr_m_1SidePadding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.NativeFieldInfoPtr_m_1SidePadding)) = value;
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06001A9F RID: 6815 RVA: 0x0007B390 File Offset: 0x00079590
		// (set) Token: 0x06001AA0 RID: 6816 RVA: 0x0000C16E File Offset: 0x0000A36E
		public unsafe int m_2SidePadding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.NativeFieldInfoPtr_m_2SidePadding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.NativeFieldInfoPtr_m_2SidePadding)) = value;
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06001AA1 RID: 6817 RVA: 0x0007B3B8 File Offset: 0x000795B8
		// (set) Token: 0x06001AA2 RID: 6818 RVA: 0x0000C189 File Offset: 0x0000A389
		public unsafe static ProfilerMarker s_MarkerTryAllocate
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(UIRAtlasAllocator.NativeFieldInfoPtr_s_MarkerTryAllocate, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRAtlasAllocator.NativeFieldInfoPtr_s_MarkerTryAllocate, (void*)(&value));
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06001AA3 RID: 6819 RVA: 0x0007B3D4 File Offset: 0x000795D4
		// (set) Token: 0x06001AA4 RID: 6820 RVA: 0x0000C197 File Offset: 0x0000A397
		public unsafe bool _disposed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.NativeFieldInfoPtr__disposed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.NativeFieldInfoPtr__disposed_k__BackingField)) = value;
			}
		}

		// Token: 0x0400124E RID: 4686
		private static readonly IntPtr NativeFieldInfoPtr__maxAtlasSize_k__BackingField;

		// Token: 0x0400124F RID: 4687
		private static readonly IntPtr NativeFieldInfoPtr__maxImageWidth_k__BackingField;

		// Token: 0x04001250 RID: 4688
		private static readonly IntPtr NativeFieldInfoPtr__maxImageHeight_k__BackingField;

		// Token: 0x04001251 RID: 4689
		private static readonly IntPtr NativeFieldInfoPtr__virtualWidth_k__BackingField;

		// Token: 0x04001252 RID: 4690
		private static readonly IntPtr NativeFieldInfoPtr__virtualHeight_k__BackingField;

		// Token: 0x04001253 RID: 4691
		private static readonly IntPtr NativeFieldInfoPtr__physicalWidth_k__BackingField;

		// Token: 0x04001254 RID: 4692
		private static readonly IntPtr NativeFieldInfoPtr__physicalHeight_k__BackingField;

		// Token: 0x04001255 RID: 4693
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstUnpartitionedArea;

		// Token: 0x04001256 RID: 4694
		private static readonly IntPtr NativeFieldInfoPtr_m_OpenRows;

		// Token: 0x04001257 RID: 4695
		private static readonly IntPtr NativeFieldInfoPtr_m_1SidePadding;

		// Token: 0x04001258 RID: 4696
		private static readonly IntPtr NativeFieldInfoPtr_m_2SidePadding;

		// Token: 0x04001259 RID: 4697
		private static readonly IntPtr NativeFieldInfoPtr_s_MarkerTryAllocate;

		// Token: 0x0400125A RID: 4698
		private static readonly IntPtr NativeFieldInfoPtr__disposed_k__BackingField;

		// Token: 0x0400125B RID: 4699
		private static readonly IntPtr NativeMethodInfoPtr_get_maxAtlasSize_Public_get_Int32_0;

		// Token: 0x0400125C RID: 4700
		private static readonly IntPtr NativeMethodInfoPtr_get_maxImageWidth_Public_get_Int32_0;

		// Token: 0x0400125D RID: 4701
		private static readonly IntPtr NativeMethodInfoPtr_get_maxImageHeight_Public_get_Int32_0;

		// Token: 0x0400125E RID: 4702
		private static readonly IntPtr NativeMethodInfoPtr_get_virtualWidth_Public_get_Int32_0;

		// Token: 0x0400125F RID: 4703
		private static readonly IntPtr NativeMethodInfoPtr_set_virtualWidth_Private_set_Void_Int32_0;

		// Token: 0x04001260 RID: 4704
		private static readonly IntPtr NativeMethodInfoPtr_get_virtualHeight_Public_get_Int32_0;

		// Token: 0x04001261 RID: 4705
		private static readonly IntPtr NativeMethodInfoPtr_set_virtualHeight_Private_set_Void_Int32_0;

		// Token: 0x04001262 RID: 4706
		private static readonly IntPtr NativeMethodInfoPtr_get_physicalWidth_Public_get_Int32_0;

		// Token: 0x04001263 RID: 4707
		private static readonly IntPtr NativeMethodInfoPtr_set_physicalWidth_Private_set_Void_Int32_0;

		// Token: 0x04001264 RID: 4708
		private static readonly IntPtr NativeMethodInfoPtr_get_physicalHeight_Public_get_Int32_0;

		// Token: 0x04001265 RID: 4709
		private static readonly IntPtr NativeMethodInfoPtr_set_physicalHeight_Private_set_Void_Int32_0;

		// Token: 0x04001266 RID: 4710
		private static readonly IntPtr NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0;

		// Token: 0x04001267 RID: 4711
		private static readonly IntPtr NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0;

		// Token: 0x04001268 RID: 4712
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001269 RID: 4713
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x0400126A RID: 4714
		private static readonly IntPtr NativeMethodInfoPtr_GetLog2OfNextPower_Private_Static_Int32_Int32_0;

		// Token: 0x0400126B RID: 4715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x0400126C RID: 4716
		private static readonly IntPtr NativeMethodInfoPtr_TryAllocate_Public_Boolean_Int32_Int32_byref_RectInt_0;

		// Token: 0x0400126D RID: 4717
		private static readonly IntPtr NativeMethodInfoPtr_TryPartitionArea_Private_Boolean_AreaNode_Int32_Int32_Int32_0;

		// Token: 0x0400126E RID: 4718
		private static readonly IntPtr NativeMethodInfoPtr_BuildAreas_Private_Void_0;

		// Token: 0x02000493 RID: 1171
		public class Row : Object
		{
			// Token: 0x06003C70 RID: 15472 RVA: 0x000F21E4 File Offset: 0x000F03E4
			// Note: this type is marked as 'beforefieldinit'.
			static Row()
			{
				Il2CppClassPointerStore<UIRAtlasAllocator.Row>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, "Row");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIRAtlasAllocator.Row>.NativeClassPtr);
				UIRAtlasAllocator.Row.NativeFieldInfoPtr_s_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRAtlasAllocator.Row>.NativeClassPtr, "s_Pool");
				UIRAtlasAllocator.Row.NativeFieldInfoPtr__offsetX_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRAtlasAllocator.Row>.NativeClassPtr, "<offsetX>k__BackingField");
				UIRAtlasAllocator.Row.NativeFieldInfoPtr__offsetY_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRAtlasAllocator.Row>.NativeClassPtr, "<offsetY>k__BackingField");
				UIRAtlasAllocator.Row.NativeFieldInfoPtr__width_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRAtlasAllocator.Row>.NativeClassPtr, "<width>k__BackingField");
				UIRAtlasAllocator.Row.NativeFieldInfoPtr__height_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRAtlasAllocator.Row>.NativeClassPtr, "<height>k__BackingField");
				UIRAtlasAllocator.Row.NativeFieldInfoPtr_Cursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRAtlasAllocator.Row>.NativeClassPtr, "Cursor");
				UIRAtlasAllocator.Row.NativeMethodInfoPtr_get_offsetX_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator.Row>.NativeClassPtr, 100667182);
				UIRAtlasAllocator.Row.NativeMethodInfoPtr_set_offsetX_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator.Row>.NativeClassPtr, 100667183);
				UIRAtlasAllocator.Row.NativeMethodInfoPtr_get_offsetY_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator.Row>.NativeClassPtr, 100667184);
				UIRAtlasAllocator.Row.NativeMethodInfoPtr_set_offsetY_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator.Row>.NativeClassPtr, 100667185);
				UIRAtlasAllocator.Row.NativeMethodInfoPtr_get_width_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator.Row>.NativeClassPtr, 100667186);
				UIRAtlasAllocator.Row.NativeMethodInfoPtr_set_width_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator.Row>.NativeClassPtr, 100667187);
				UIRAtlasAllocator.Row.NativeMethodInfoPtr_set_height_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator.Row>.NativeClassPtr, 100667188);
				UIRAtlasAllocator.Row.NativeMethodInfoPtr_Acquire_Public_Static_Row_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator.Row>.NativeClassPtr, 100667189);
				UIRAtlasAllocator.Row.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator.Row>.NativeClassPtr, 100667190);
				UIRAtlasAllocator.Row.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator.Row>.NativeClassPtr, 100667191);
			}

			// Token: 0x17001246 RID: 4678
			// (get) Token: 0x06003C71 RID: 15473 RVA: 0x000F2350 File Offset: 0x000F0550
			// (set) Token: 0x06003C72 RID: 15474 RVA: 0x000F238C File Offset: 0x000F058C
			public unsafe int offsetX
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.Row.NativeMethodInfoPtr_get_offsetX_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.Row.NativeMethodInfoPtr_set_offsetX_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001247 RID: 4679
			// (get) Token: 0x06003C73 RID: 15475 RVA: 0x000F23CC File Offset: 0x000F05CC
			// (set) Token: 0x06003C74 RID: 15476 RVA: 0x000F2408 File Offset: 0x000F0608
			public unsafe int offsetY
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.Row.NativeMethodInfoPtr_get_offsetY_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 310312, RefRangeEnd = 310318, XrefRangeStart = 310312, XrefRangeEnd = 310318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.Row.NativeMethodInfoPtr_set_offsetY_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001248 RID: 4680
			// (get) Token: 0x06003C75 RID: 15477 RVA: 0x000F2448 File Offset: 0x000F0648
			// (set) Token: 0x06003C76 RID: 15478 RVA: 0x000F2484 File Offset: 0x000F0684
			public unsafe int width
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.Row.NativeMethodInfoPtr_get_width_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.Row.NativeMethodInfoPtr_set_width_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001249 RID: 4681
			// (set) Token: 0x06003C77 RID: 15479 RVA: 0x000F24C4 File Offset: 0x000F06C4
			public unsafe int height
			{
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.Row.NativeMethodInfoPtr_set_height_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06003C78 RID: 15480 RVA: 0x000F2504 File Offset: 0x000F0704
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322089, XrefRangeEnd = 322096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static UIRAtlasAllocator.Row Acquire(int offsetX, int offsetY, int width, int height)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref offsetX;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetY;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.Row.NativeMethodInfoPtr_Acquire_Public_Static_Row_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIRAtlasAllocator.Row>(intPtr3) : null;
			}

			// Token: 0x06003C79 RID: 15481 RVA: 0x000F2570 File Offset: 0x000F0770
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 322103, RefRangeEnd = 322105, XrefRangeStart = 322096, XrefRangeEnd = 322103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Release()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.Row.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C7A RID: 15482 RVA: 0x000F25A4 File Offset: 0x000F07A4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Row()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIRAtlasAllocator.Row>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.Row.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C7B RID: 15483 RVA: 0x00019502 File Offset: 0x00017702
			public Row(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001240 RID: 4672
			// (get) Token: 0x06003C7C RID: 15484 RVA: 0x000F25E0 File Offset: 0x000F07E0
			// (set) Token: 0x06003C7D RID: 15485 RVA: 0x0001950B File Offset: 0x0001770B
			public unsafe static ObjectPool<UIRAtlasAllocator.Row> s_Pool
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UIRAtlasAllocator.Row.NativeFieldInfoPtr_s_Pool, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<UIRAtlasAllocator.Row>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UIRAtlasAllocator.Row.NativeFieldInfoPtr_s_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001241 RID: 4673
			// (get) Token: 0x06003C7E RID: 15486 RVA: 0x000F2608 File Offset: 0x000F0808
			// (set) Token: 0x06003C7F RID: 15487 RVA: 0x0001951D File Offset: 0x0001771D
			public unsafe int _offsetX_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.Row.NativeFieldInfoPtr__offsetX_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.Row.NativeFieldInfoPtr__offsetX_k__BackingField)) = value;
				}
			}

			// Token: 0x17001242 RID: 4674
			// (get) Token: 0x06003C80 RID: 15488 RVA: 0x000F2630 File Offset: 0x000F0830
			// (set) Token: 0x06003C81 RID: 15489 RVA: 0x00019538 File Offset: 0x00017738
			public unsafe int _offsetY_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.Row.NativeFieldInfoPtr__offsetY_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.Row.NativeFieldInfoPtr__offsetY_k__BackingField)) = value;
				}
			}

			// Token: 0x17001243 RID: 4675
			// (get) Token: 0x06003C82 RID: 15490 RVA: 0x000F2658 File Offset: 0x000F0858
			// (set) Token: 0x06003C83 RID: 15491 RVA: 0x00019553 File Offset: 0x00017753
			public unsafe int _width_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.Row.NativeFieldInfoPtr__width_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.Row.NativeFieldInfoPtr__width_k__BackingField)) = value;
				}
			}

			// Token: 0x17001244 RID: 4676
			// (get) Token: 0x06003C84 RID: 15492 RVA: 0x000F2680 File Offset: 0x000F0880
			// (set) Token: 0x06003C85 RID: 15493 RVA: 0x0001956E File Offset: 0x0001776E
			public unsafe int _height_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.Row.NativeFieldInfoPtr__height_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.Row.NativeFieldInfoPtr__height_k__BackingField)) = value;
				}
			}

			// Token: 0x17001245 RID: 4677
			// (get) Token: 0x06003C86 RID: 15494 RVA: 0x000F26A8 File Offset: 0x000F08A8
			// (set) Token: 0x06003C87 RID: 15495 RVA: 0x00019589 File Offset: 0x00017789
			public unsafe int Cursor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.Row.NativeFieldInfoPtr_Cursor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.Row.NativeFieldInfoPtr_Cursor)) = value;
				}
			}

			// Token: 0x04002AC6 RID: 10950
			private static readonly IntPtr NativeFieldInfoPtr_s_Pool;

			// Token: 0x04002AC7 RID: 10951
			private static readonly IntPtr NativeFieldInfoPtr__offsetX_k__BackingField;

			// Token: 0x04002AC8 RID: 10952
			private static readonly IntPtr NativeFieldInfoPtr__offsetY_k__BackingField;

			// Token: 0x04002AC9 RID: 10953
			private static readonly IntPtr NativeFieldInfoPtr__width_k__BackingField;

			// Token: 0x04002ACA RID: 10954
			private static readonly IntPtr NativeFieldInfoPtr__height_k__BackingField;

			// Token: 0x04002ACB RID: 10955
			private static readonly IntPtr NativeFieldInfoPtr_Cursor;

			// Token: 0x04002ACC RID: 10956
			private static readonly IntPtr NativeMethodInfoPtr_get_offsetX_Public_get_Int32_0;

			// Token: 0x04002ACD RID: 10957
			private static readonly IntPtr NativeMethodInfoPtr_set_offsetX_Private_set_Void_Int32_0;

			// Token: 0x04002ACE RID: 10958
			private static readonly IntPtr NativeMethodInfoPtr_get_offsetY_Public_get_Int32_0;

			// Token: 0x04002ACF RID: 10959
			private static readonly IntPtr NativeMethodInfoPtr_set_offsetY_Private_set_Void_Int32_0;

			// Token: 0x04002AD0 RID: 10960
			private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Int32_0;

			// Token: 0x04002AD1 RID: 10961
			private static readonly IntPtr NativeMethodInfoPtr_set_width_Private_set_Void_Int32_0;

			// Token: 0x04002AD2 RID: 10962
			private static readonly IntPtr NativeMethodInfoPtr_set_height_Private_set_Void_Int32_0;

			// Token: 0x04002AD3 RID: 10963
			private static readonly IntPtr NativeMethodInfoPtr_Acquire_Public_Static_Row_Int32_Int32_Int32_Int32_0;

			// Token: 0x04002AD4 RID: 10964
			private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

			// Token: 0x04002AD5 RID: 10965
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000591 RID: 1425
			[ObfuscatedName("UnityEngine.UIElements.UIRAtlasAllocator+Row+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x060042B7 RID: 17079 RVA: 0x00105834 File Offset: 0x00103A34
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<UIRAtlasAllocator.Row.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIRAtlasAllocator.Row>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIRAtlasAllocator.Row.__c>.NativeClassPtr);
					UIRAtlasAllocator.Row.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRAtlasAllocator.Row.__c>.NativeClassPtr, "<>9");
					UIRAtlasAllocator.Row.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator.Row.__c>.NativeClassPtr, 100667194);
					UIRAtlasAllocator.Row.__c.NativeMethodInfoPtr___cctor_b__21_0_Internal_Row_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator.Row.__c>.NativeClassPtr, 100667195);
				}

				// Token: 0x060042B8 RID: 17080 RVA: 0x0010589C File Offset: 0x00103A9C
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIRAtlasAllocator.Row.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.Row.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060042B9 RID: 17081 RVA: 0x001058D8 File Offset: 0x00103AD8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322085, XrefRangeEnd = 322089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UIRAtlasAllocator.Row __cctor_b__21_0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.Row.__c.NativeMethodInfoPtr___cctor_b__21_0_Internal_Row_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIRAtlasAllocator.Row>(intPtr3) : null;
				}

				// Token: 0x060042BA RID: 17082 RVA: 0x0001C7D8 File Offset: 0x0001A9D8
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170013F5 RID: 5109
				// (get) Token: 0x060042BB RID: 17083 RVA: 0x00105918 File Offset: 0x00103B18
				// (set) Token: 0x060042BC RID: 17084 RVA: 0x0001C7E1 File Offset: 0x0001A9E1
				public unsafe static UIRAtlasAllocator.Row.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(UIRAtlasAllocator.Row.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIRAtlasAllocator.Row.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(UIRAtlasAllocator.Row.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04002EB8 RID: 11960
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x04002EB9 RID: 11961
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04002EBA RID: 11962
				private static readonly IntPtr NativeMethodInfoPtr___cctor_b__21_0_Internal_Row_0;
			}

			// Token: 0x02000592 RID: 1426
			[Serializable]
			public sealed class <>c
			{
			}
		}

		// Token: 0x02000494 RID: 1172
		public class AreaNode : Object
		{
			// Token: 0x06003C88 RID: 15496 RVA: 0x000F26D0 File Offset: 0x000F08D0
			// Note: this type is marked as 'beforefieldinit'.
			static AreaNode()
			{
				Il2CppClassPointerStore<UIRAtlasAllocator.AreaNode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIRAtlasAllocator>.NativeClassPtr, "AreaNode");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIRAtlasAllocator.AreaNode>.NativeClassPtr);
				UIRAtlasAllocator.AreaNode.NativeFieldInfoPtr_s_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRAtlasAllocator.AreaNode>.NativeClassPtr, "s_Pool");
				UIRAtlasAllocator.AreaNode.NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRAtlasAllocator.AreaNode>.NativeClassPtr, "rect");
				UIRAtlasAllocator.AreaNode.NativeFieldInfoPtr_previous = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRAtlasAllocator.AreaNode>.NativeClassPtr, "previous");
				UIRAtlasAllocator.AreaNode.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRAtlasAllocator.AreaNode>.NativeClassPtr, "next");
				UIRAtlasAllocator.AreaNode.NativeMethodInfoPtr_Acquire_Public_Static_AreaNode_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator.AreaNode>.NativeClassPtr, 100667196);
				UIRAtlasAllocator.AreaNode.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator.AreaNode>.NativeClassPtr, 100667197);
				UIRAtlasAllocator.AreaNode.NativeMethodInfoPtr_RemoveFromChain_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator.AreaNode>.NativeClassPtr, 100667198);
				UIRAtlasAllocator.AreaNode.NativeMethodInfoPtr_AddAfter_Public_Void_AreaNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator.AreaNode>.NativeClassPtr, 100667199);
				UIRAtlasAllocator.AreaNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator.AreaNode>.NativeClassPtr, 100667200);
			}

			// Token: 0x06003C89 RID: 15497 RVA: 0x000F27B0 File Offset: 0x000F09B0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 322118, RefRangeEnd = 322121, XrefRangeStart = 322109, XrefRangeEnd = 322118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static UIRAtlasAllocator.AreaNode Acquire(RectInt rect)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref rect;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.AreaNode.NativeMethodInfoPtr_Acquire_Public_Static_AreaNode_RectInt_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIRAtlasAllocator.AreaNode>(intPtr3) : null;
				}
			}

			// Token: 0x06003C8A RID: 15498 RVA: 0x000F27F0 File Offset: 0x000F09F0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 322129, RefRangeEnd = 322130, XrefRangeStart = 322121, XrefRangeEnd = 322129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Release()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.AreaNode.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C8B RID: 15499 RVA: 0x000F2824 File Offset: 0x000F0A24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322130, XrefRangeEnd = 322154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RemoveFromChain()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.AreaNode.NativeMethodInfoPtr_RemoveFromChain_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C8C RID: 15500 RVA: 0x000F2858 File Offset: 0x000F0A58
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 322166, RefRangeEnd = 322168, XrefRangeStart = 322154, XrefRangeEnd = 322166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AddAfter(UIRAtlasAllocator.AreaNode previous)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(previous);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.AreaNode.NativeMethodInfoPtr_AddAfter_Public_Void_AreaNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003C8D RID: 15501 RVA: 0x000F289C File Offset: 0x000F0A9C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AreaNode()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIRAtlasAllocator.AreaNode>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.AreaNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C8E RID: 15502 RVA: 0x000195A4 File Offset: 0x000177A4
			public AreaNode(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700124A RID: 4682
			// (get) Token: 0x06003C8F RID: 15503 RVA: 0x000F28D8 File Offset: 0x000F0AD8
			// (set) Token: 0x06003C90 RID: 15504 RVA: 0x000195AD File Offset: 0x000177AD
			public unsafe static ObjectPool<UIRAtlasAllocator.AreaNode> s_Pool
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UIRAtlasAllocator.AreaNode.NativeFieldInfoPtr_s_Pool, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<UIRAtlasAllocator.AreaNode>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UIRAtlasAllocator.AreaNode.NativeFieldInfoPtr_s_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700124B RID: 4683
			// (get) Token: 0x06003C91 RID: 15505 RVA: 0x000F2900 File Offset: 0x000F0B00
			// (set) Token: 0x06003C92 RID: 15506 RVA: 0x000195BF File Offset: 0x000177BF
			public unsafe RectInt rect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.AreaNode.NativeFieldInfoPtr_rect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.AreaNode.NativeFieldInfoPtr_rect)) = value;
				}
			}

			// Token: 0x1700124C RID: 4684
			// (get) Token: 0x06003C93 RID: 15507 RVA: 0x000F2928 File Offset: 0x000F0B28
			// (set) Token: 0x06003C94 RID: 15508 RVA: 0x000195DA File Offset: 0x000177DA
			public unsafe UIRAtlasAllocator.AreaNode previous
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.AreaNode.NativeFieldInfoPtr_previous);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIRAtlasAllocator.AreaNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.AreaNode.NativeFieldInfoPtr_previous), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700124D RID: 4685
			// (get) Token: 0x06003C95 RID: 15509 RVA: 0x000F2958 File Offset: 0x000F0B58
			// (set) Token: 0x06003C96 RID: 15510 RVA: 0x000195F9 File Offset: 0x000177F9
			public unsafe UIRAtlasAllocator.AreaNode next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.AreaNode.NativeFieldInfoPtr_next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIRAtlasAllocator.AreaNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRAtlasAllocator.AreaNode.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002AD6 RID: 10966
			private static readonly IntPtr NativeFieldInfoPtr_s_Pool;

			// Token: 0x04002AD7 RID: 10967
			private static readonly IntPtr NativeFieldInfoPtr_rect;

			// Token: 0x04002AD8 RID: 10968
			private static readonly IntPtr NativeFieldInfoPtr_previous;

			// Token: 0x04002AD9 RID: 10969
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x04002ADA RID: 10970
			private static readonly IntPtr NativeMethodInfoPtr_Acquire_Public_Static_AreaNode_RectInt_0;

			// Token: 0x04002ADB RID: 10971
			private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

			// Token: 0x04002ADC RID: 10972
			private static readonly IntPtr NativeMethodInfoPtr_RemoveFromChain_Public_Void_0;

			// Token: 0x04002ADD RID: 10973
			private static readonly IntPtr NativeMethodInfoPtr_AddAfter_Public_Void_AreaNode_0;

			// Token: 0x04002ADE RID: 10974
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000593 RID: 1427
			[ObfuscatedName("UnityEngine.UIElements.UIRAtlasAllocator+AreaNode+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x060042BD RID: 17085 RVA: 0x00105940 File Offset: 0x00103B40
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<UIRAtlasAllocator.AreaNode.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIRAtlasAllocator.AreaNode>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIRAtlasAllocator.AreaNode.__c>.NativeClassPtr);
					UIRAtlasAllocator.AreaNode.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRAtlasAllocator.AreaNode.__c>.NativeClassPtr, "<>9");
					UIRAtlasAllocator.AreaNode.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator.AreaNode.__c>.NativeClassPtr, 100667203);
					UIRAtlasAllocator.AreaNode.__c.NativeMethodInfoPtr___cctor_b__9_0_Internal_AreaNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRAtlasAllocator.AreaNode.__c>.NativeClassPtr, 100667204);
				}

				// Token: 0x060042BE RID: 17086 RVA: 0x001059A8 File Offset: 0x00103BA8
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIRAtlasAllocator.AreaNode.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.AreaNode.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060042BF RID: 17087 RVA: 0x001059E4 File Offset: 0x00103BE4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322105, XrefRangeEnd = 322109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UIRAtlasAllocator.AreaNode __cctor_b__9_0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRAtlasAllocator.AreaNode.__c.NativeMethodInfoPtr___cctor_b__9_0_Internal_AreaNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIRAtlasAllocator.AreaNode>(intPtr3) : null;
				}

				// Token: 0x060042C0 RID: 17088 RVA: 0x0001C7F3 File Offset: 0x0001A9F3
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170013F6 RID: 5110
				// (get) Token: 0x060042C1 RID: 17089 RVA: 0x00105A24 File Offset: 0x00103C24
				// (set) Token: 0x060042C2 RID: 17090 RVA: 0x0001C7FC File Offset: 0x0001A9FC
				public unsafe static UIRAtlasAllocator.AreaNode.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(UIRAtlasAllocator.AreaNode.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIRAtlasAllocator.AreaNode.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(UIRAtlasAllocator.AreaNode.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04002EBB RID: 11963
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x04002EBC RID: 11964
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04002EBD RID: 11965
				private static readonly IntPtr NativeMethodInfoPtr___cctor_b__9_0_Internal_AreaNode_0;
			}

			// Token: 0x02000594 RID: 1428
			[Serializable]
			public sealed class <>c
			{
			}
		}
	}
}
