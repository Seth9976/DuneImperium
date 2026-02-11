using System;
using dwd.core.input.compositeModule.inputDetection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace dwd.core.input
{
	// Token: 0x0200005A RID: 90
	public sealed class ScrollOnAxisInputContext : RegisterContextInputFunction
	{
		// Token: 0x0600031D RID: 797 RVA: 0x00010A00 File Offset: 0x0000EC00
		// Note: this type is marked as 'beforefieldinit'.
		static ScrollOnAxisInputContext()
		{
			Il2CppClassPointerStore<ScrollOnAxisInputContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "ScrollOnAxisInputContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollOnAxisInputContext>.NativeClassPtr);
			ScrollOnAxisInputContext.NativeFieldInfoPtr_scrollMaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollOnAxisInputContext>.NativeClassPtr, "scrollMaxSpeed");
			ScrollOnAxisInputContext.NativeFieldInfoPtr_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollOnAxisInputContext>.NativeClassPtr, "scrollRect");
			ScrollOnAxisInputContext.NativeFieldInfoPtr_inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollOnAxisInputContext>.NativeClassPtr, "inputField");
			ScrollOnAxisInputContext.NativeFieldInfoPtr_scrollBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollOnAxisInputContext>.NativeClassPtr, "scrollBar");
			ScrollOnAxisInputContext.NativeFieldInfoPtr_scrollAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollOnAxisInputContext>.NativeClassPtr, "scrollAxis");
			ScrollOnAxisInputContext.NativeFieldInfoPtr_inputDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollOnAxisInputContext>.NativeClassPtr, "inputDetector");
			ScrollOnAxisInputContext.NativeFieldInfoPtr_OnDragOrScrolled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollOnAxisInputContext>.NativeClassPtr, "OnDragOrScrolled");
			ScrollOnAxisInputContext.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollOnAxisInputContext>.NativeClassPtr, 100663661);
			ScrollOnAxisInputContext.NativeMethodInfoPtr_executeFunction_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollOnAxisInputContext>.NativeClassPtr, 100663662);
			ScrollOnAxisInputContext.NativeMethodInfoPtr_getContentSize_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollOnAxisInputContext>.NativeClassPtr, 100663663);
			ScrollOnAxisInputContext.NativeMethodInfoPtr_Scroll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollOnAxisInputContext>.NativeClassPtr, 100663664);
			ScrollOnAxisInputContext.NativeMethodInfoPtr_Invoke_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollOnAxisInputContext>.NativeClassPtr, 100663665);
			ScrollOnAxisInputContext.NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollOnAxisInputContext>.NativeClassPtr, 100663666);
			ScrollOnAxisInputContext.NativeMethodInfoPtr_OnScroll_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollOnAxisInputContext>.NativeClassPtr, 100663667);
			ScrollOnAxisInputContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollOnAxisInputContext>.NativeClassPtr, 100663668);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00010B5C File Offset: 0x0000ED5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121414, XrefRangeEnd = 1121442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollOnAxisInputContext.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00010B90 File Offset: 0x0000ED90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121442, XrefRangeEnd = 1121470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void executeFunction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollOnAxisInputContext.NativeMethodInfoPtr_executeFunction_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00010BC4 File Offset: 0x0000EDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121470, XrefRangeEnd = 1121475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float getContentSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollOnAxisInputContext.NativeMethodInfoPtr_getContentSize_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00010C00 File Offset: 0x0000EE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121475, XrefRangeEnd = 1121479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Scroll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollOnAxisInputContext.NativeMethodInfoPtr_Scroll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00010C34 File Offset: 0x0000EE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121479, XrefRangeEnd = 1121481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollOnAxisInputContext.NativeMethodInfoPtr_Invoke_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00010C68 File Offset: 0x0000EE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollOnAxisInputContext.NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00010CAC File Offset: 0x0000EEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnScroll(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollOnAxisInputContext.NativeMethodInfoPtr_OnScroll_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00010CF0 File Offset: 0x0000EEF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121481, XrefRangeEnd = 1121490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScrollOnAxisInputContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollOnAxisInputContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollOnAxisInputContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00003CD2 File Offset: 0x00001ED2
		public ScrollOnAxisInputContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000327 RID: 807 RVA: 0x00010D2C File Offset: 0x0000EF2C
		// (set) Token: 0x06000328 RID: 808 RVA: 0x00003CDB File Offset: 0x00001EDB
		public unsafe float scrollMaxSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputContext.NativeFieldInfoPtr_scrollMaxSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputContext.NativeFieldInfoPtr_scrollMaxSpeed)) = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000329 RID: 809 RVA: 0x00010D54 File Offset: 0x0000EF54
		// (set) Token: 0x0600032A RID: 810 RVA: 0x00003CF6 File Offset: 0x00001EF6
		public unsafe ScrollRect scrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputContext.NativeFieldInfoPtr_scrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputContext.NativeFieldInfoPtr_scrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600032B RID: 811 RVA: 0x00010D84 File Offset: 0x0000EF84
		// (set) Token: 0x0600032C RID: 812 RVA: 0x00003D15 File Offset: 0x00001F15
		public unsafe TMP_InputField inputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputContext.NativeFieldInfoPtr_inputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputContext.NativeFieldInfoPtr_inputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600032D RID: 813 RVA: 0x00010DB4 File Offset: 0x0000EFB4
		// (set) Token: 0x0600032E RID: 814 RVA: 0x00003D34 File Offset: 0x00001F34
		public unsafe Scrollbar scrollBar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputContext.NativeFieldInfoPtr_scrollBar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputContext.NativeFieldInfoPtr_scrollBar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00010DE4 File Offset: 0x0000EFE4
		// (set) Token: 0x06000330 RID: 816 RVA: 0x00003D53 File Offset: 0x00001F53
		public unsafe ScrollOnAxisInputContext.Axis scrollAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputContext.NativeFieldInfoPtr_scrollAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputContext.NativeFieldInfoPtr_scrollAxis)) = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000331 RID: 817 RVA: 0x00010E0C File Offset: 0x0000F00C
		// (set) Token: 0x06000332 RID: 818 RVA: 0x00003D6E File Offset: 0x00001F6E
		public unsafe InputDetector inputDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputContext.NativeFieldInfoPtr_inputDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputContext.NativeFieldInfoPtr_inputDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000333 RID: 819 RVA: 0x00010E3C File Offset: 0x0000F03C
		// (set) Token: 0x06000334 RID: 820 RVA: 0x00003D8D File Offset: 0x00001F8D
		public unsafe UnityEvent OnDragOrScrolled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputContext.NativeFieldInfoPtr_OnDragOrScrolled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputContext.NativeFieldInfoPtr_OnDragOrScrolled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeFieldInfoPtr_scrollMaxSpeed;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeFieldInfoPtr_scrollRect;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeFieldInfoPtr_inputField;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeFieldInfoPtr_scrollBar;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeFieldInfoPtr_scrollAxis;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeFieldInfoPtr_inputDetector;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeFieldInfoPtr_OnDragOrScrolled;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_executeFunction_Protected_Virtual_Void_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_getContentSize_Private_Single_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_Scroll_Public_Void_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_OnScroll_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000C5 RID: 197
		public enum Axis
		{
			// Token: 0x0400056B RID: 1387
			Horizontal,
			// Token: 0x0400056C RID: 1388
			Vertical
		}
	}
}
