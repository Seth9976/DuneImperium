using System;
using dwd.core.input.transforms;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.input.click
{
	// Token: 0x020000A3 RID: 163
	public class ClickDispatcher : MonoBehaviour
	{
		// Token: 0x0600076B RID: 1899 RVA: 0x0001F288 File Offset: 0x0001D488
		// Note: this type is marked as 'beforefieldinit'.
		static ClickDispatcher()
		{
			Il2CppClassPointerStore<ClickDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.click", "ClickDispatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClickDispatcher>.NativeClassPtr);
			ClickDispatcher.NativeFieldInfoPtr_clickSlopInches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickDispatcher>.NativeClassPtr, "clickSlopInches");
			ClickDispatcher.NativeFieldInfoPtr_clickTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickDispatcher>.NativeClassPtr, "clickTimeout");
			ClickDispatcher.NativeFieldInfoPtr_clickConsecutiveSlopInches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickDispatcher>.NativeClassPtr, "clickConsecutiveSlopInches");
			ClickDispatcher.NativeFieldInfoPtr_clickConsecutiveTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickDispatcher>.NativeClassPtr, "clickConsecutiveTimeout");
			ClickDispatcher.NativeFieldInfoPtr_longPressSlopInches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickDispatcher>.NativeClassPtr, "longPressSlopInches");
			ClickDispatcher.NativeFieldInfoPtr_longPressTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickDispatcher>.NativeClassPtr, "longPressTimeout");
			ClickDispatcher.NativeFieldInfoPtr_processors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickDispatcher>.NativeClassPtr, "processors");
			ClickDispatcher.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickDispatcher>.NativeClassPtr, "input");
			ClickDispatcher.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDispatcher>.NativeClassPtr, 100664220);
			ClickDispatcher.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDispatcher>.NativeClassPtr, 100664221);
			ClickDispatcher.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDispatcher>.NativeClassPtr, 100664222);
			ClickDispatcher.NativeMethodInfoPtr_mouseListenerFactory_Private_MouseClickProcessor_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDispatcher>.NativeClassPtr, 100664223);
			ClickDispatcher.NativeMethodInfoPtr_touchListenerFactory_Private_SingleTouchClickProcessor_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDispatcher>.NativeClassPtr, 100664224);
			ClickDispatcher.NativeMethodInfoPtr_dwd_core_input_click_IClickConfig_get_ClickSlop_Private_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDispatcher>.NativeClassPtr, 100664225);
			ClickDispatcher.NativeMethodInfoPtr_dwd_core_input_click_IClickConfig_get_ClickTimeout_Private_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDispatcher>.NativeClassPtr, 100664226);
			ClickDispatcher.NativeMethodInfoPtr_dwd_core_input_click_IClickConfig_get_ClickConsecutiveSlop_Private_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDispatcher>.NativeClassPtr, 100664227);
			ClickDispatcher.NativeMethodInfoPtr_dwd_core_input_click_IClickConfig_get_ClickConsecutiveTimeout_Private_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDispatcher>.NativeClassPtr, 100664228);
			ClickDispatcher.NativeMethodInfoPtr_dwd_core_input_click_IClickConfig_get_LongPressSlop_Private_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDispatcher>.NativeClassPtr, 100664229);
			ClickDispatcher.NativeMethodInfoPtr_dwd_core_input_click_IClickConfig_get_LongPressTimeout_Private_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDispatcher>.NativeClassPtr, 100664230);
			ClickDispatcher.NativeMethodInfoPtr_Find_Public_Static_ClickDispatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDispatcher>.NativeClassPtr, 100664231);
			ClickDispatcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDispatcher>.NativeClassPtr, 100664232);
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0001F45C File Offset: 0x0001D65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126509, XrefRangeEnd = 1126545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDispatcher.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0001F490 File Offset: 0x0001D690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126545, XrefRangeEnd = 1126567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDispatcher.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0001F4C4 File Offset: 0x0001D6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126567, XrefRangeEnd = 1126570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDispatcher.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0001F4F8 File Offset: 0x0001D6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126570, XrefRangeEnd = 1126594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseClickProcessor mouseListenerFactory(Transform tr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDispatcher.NativeMethodInfoPtr_mouseListenerFactory_Private_MouseClickProcessor_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseClickProcessor>(intPtr3) : null;
			}
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x0001F548 File Offset: 0x0001D748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126594, XrefRangeEnd = 1126600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SingleTouchClickProcessor touchListenerFactory(Transform tr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDispatcher.NativeMethodInfoPtr_touchListenerFactory_Private_SingleTouchClickProcessor_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SingleTouchClickProcessor>(intPtr3) : null;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x0001F598 File Offset: 0x0001D798
		public unsafe virtual float dwd.core.input.click.IClickConfig.ClickSlop
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126600, XrefRangeEnd = 1126604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDispatcher.NativeMethodInfoPtr_dwd_core_input_click_IClickConfig_get_ClickSlop_Private_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x0001F5D4 File Offset: 0x0001D7D4
		public unsafe virtual float dwd.core.input.click.IClickConfig.ClickTimeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDispatcher.NativeMethodInfoPtr_dwd_core_input_click_IClickConfig_get_ClickTimeout_Private_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x0001F610 File Offset: 0x0001D810
		public unsafe virtual float dwd.core.input.click.IClickConfig.ClickConsecutiveSlop
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126604, XrefRangeEnd = 1126608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDispatcher.NativeMethodInfoPtr_dwd_core_input_click_IClickConfig_get_ClickConsecutiveSlop_Private_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x0001F64C File Offset: 0x0001D84C
		public unsafe virtual float dwd.core.input.click.IClickConfig.ClickConsecutiveTimeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDispatcher.NativeMethodInfoPtr_dwd_core_input_click_IClickConfig_get_ClickConsecutiveTimeout_Private_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x0001F688 File Offset: 0x0001D888
		public unsafe virtual float dwd.core.input.click.IClickConfig.LongPressSlop
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126608, XrefRangeEnd = 1126612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDispatcher.NativeMethodInfoPtr_dwd_core_input_click_IClickConfig_get_LongPressSlop_Private_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x0001F6C4 File Offset: 0x0001D8C4
		public unsafe virtual float dwd.core.input.click.IClickConfig.LongPressTimeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDispatcher.NativeMethodInfoPtr_dwd_core_input_click_IClickConfig_get_LongPressTimeout_Private_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x0001F700 File Offset: 0x0001D900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126612, XrefRangeEnd = 1126615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ClickDispatcher Find()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDispatcher.NativeMethodInfoPtr_Find_Public_Static_ClickDispatcher_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClickDispatcher>(intPtr3) : null;
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x0001F734 File Offset: 0x0001D934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126615, XrefRangeEnd = 1126616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClickDispatcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClickDispatcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDispatcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00005E01 File Offset: 0x00004001
		public ClickDispatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x0001F770 File Offset: 0x0001D970
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x00005E0A File Offset: 0x0000400A
		public unsafe float clickSlopInches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDispatcher.NativeFieldInfoPtr_clickSlopInches);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDispatcher.NativeFieldInfoPtr_clickSlopInches)) = value;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x0001F798 File Offset: 0x0001D998
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x00005E25 File Offset: 0x00004025
		public unsafe float clickTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDispatcher.NativeFieldInfoPtr_clickTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDispatcher.NativeFieldInfoPtr_clickTimeout)) = value;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x0001F7C0 File Offset: 0x0001D9C0
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x00005E40 File Offset: 0x00004040
		public unsafe float clickConsecutiveSlopInches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDispatcher.NativeFieldInfoPtr_clickConsecutiveSlopInches);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDispatcher.NativeFieldInfoPtr_clickConsecutiveSlopInches)) = value;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x0001F7E8 File Offset: 0x0001D9E8
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x00005E5B File Offset: 0x0000405B
		public unsafe float clickConsecutiveTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDispatcher.NativeFieldInfoPtr_clickConsecutiveTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDispatcher.NativeFieldInfoPtr_clickConsecutiveTimeout)) = value;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x0001F810 File Offset: 0x0001DA10
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x00005E76 File Offset: 0x00004076
		public unsafe float longPressSlopInches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDispatcher.NativeFieldInfoPtr_longPressSlopInches);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDispatcher.NativeFieldInfoPtr_longPressSlopInches)) = value;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x0001F838 File Offset: 0x0001DA38
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x00005E91 File Offset: 0x00004091
		public unsafe float longPressTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDispatcher.NativeFieldInfoPtr_longPressTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDispatcher.NativeFieldInfoPtr_longPressTimeout)) = value;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x0001F860 File Offset: 0x0001DA60
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x00005EAC File Offset: 0x000040AC
		public unsafe Il2CppReferenceArray<PressProcessors> processors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDispatcher.NativeFieldInfoPtr_processors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PressProcessors>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDispatcher.NativeFieldInfoPtr_processors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x0001F890 File Offset: 0x0001DA90
		// (set) Token: 0x06000789 RID: 1929 RVA: 0x00005ECB File Offset: 0x000040CB
		public unsafe InputManager input
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDispatcher.NativeFieldInfoPtr_input);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDispatcher.NativeFieldInfoPtr_input), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeFieldInfoPtr_clickSlopInches;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeFieldInfoPtr_clickTimeout;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeFieldInfoPtr_clickConsecutiveSlopInches;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeFieldInfoPtr_clickConsecutiveTimeout;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeFieldInfoPtr_longPressSlopInches;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeFieldInfoPtr_longPressTimeout;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeFieldInfoPtr_processors;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeFieldInfoPtr_input;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeMethodInfoPtr_mouseListenerFactory_Private_MouseClickProcessor_Transform_0;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeMethodInfoPtr_touchListenerFactory_Private_SingleTouchClickProcessor_Transform_0;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_input_click_IClickConfig_get_ClickSlop_Private_Virtual_Final_New_get_Single_0;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_input_click_IClickConfig_get_ClickTimeout_Private_Virtual_Final_New_get_Single_0;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_input_click_IClickConfig_get_ClickConsecutiveSlop_Private_Virtual_Final_New_get_Single_0;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_input_click_IClickConfig_get_ClickConsecutiveTimeout_Private_Virtual_Final_New_get_Single_0;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_input_click_IClickConfig_get_LongPressSlop_Private_Virtual_Final_New_get_Single_0;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_input_click_IClickConfig_get_LongPressTimeout_Private_Virtual_Final_New_get_Single_0;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_ClickDispatcher_0;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
