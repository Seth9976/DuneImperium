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
	// Token: 0x0200005B RID: 91
	public sealed class ScrollOnAxisInputGlobal : RegisterGlobalInputFunction
	{
		// Token: 0x06000335 RID: 821 RVA: 0x00010E6C File Offset: 0x0000F06C
		// Note: this type is marked as 'beforefieldinit'.
		static ScrollOnAxisInputGlobal()
		{
			Il2CppClassPointerStore<ScrollOnAxisInputGlobal>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "ScrollOnAxisInputGlobal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollOnAxisInputGlobal>.NativeClassPtr);
			ScrollOnAxisInputGlobal.NativeFieldInfoPtr_scrollMaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollOnAxisInputGlobal>.NativeClassPtr, "scrollMaxSpeed");
			ScrollOnAxisInputGlobal.NativeFieldInfoPtr_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollOnAxisInputGlobal>.NativeClassPtr, "scrollRect");
			ScrollOnAxisInputGlobal.NativeFieldInfoPtr_inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollOnAxisInputGlobal>.NativeClassPtr, "inputField");
			ScrollOnAxisInputGlobal.NativeFieldInfoPtr_scrollBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollOnAxisInputGlobal>.NativeClassPtr, "scrollBar");
			ScrollOnAxisInputGlobal.NativeFieldInfoPtr_scrollAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollOnAxisInputGlobal>.NativeClassPtr, "scrollAxis");
			ScrollOnAxisInputGlobal.NativeFieldInfoPtr_inputDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollOnAxisInputGlobal>.NativeClassPtr, "inputDetector");
			ScrollOnAxisInputGlobal.NativeFieldInfoPtr_OnDragOrScrolled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollOnAxisInputGlobal>.NativeClassPtr, "OnDragOrScrolled");
			ScrollOnAxisInputGlobal.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollOnAxisInputGlobal>.NativeClassPtr, 100663669);
			ScrollOnAxisInputGlobal.NativeMethodInfoPtr_executeFunction_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollOnAxisInputGlobal>.NativeClassPtr, 100663670);
			ScrollOnAxisInputGlobal.NativeMethodInfoPtr_getContentSize_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollOnAxisInputGlobal>.NativeClassPtr, 100663671);
			ScrollOnAxisInputGlobal.NativeMethodInfoPtr_Scroll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollOnAxisInputGlobal>.NativeClassPtr, 100663672);
			ScrollOnAxisInputGlobal.NativeMethodInfoPtr_Invoke_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollOnAxisInputGlobal>.NativeClassPtr, 100663673);
			ScrollOnAxisInputGlobal.NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollOnAxisInputGlobal>.NativeClassPtr, 100663674);
			ScrollOnAxisInputGlobal.NativeMethodInfoPtr_OnScroll_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollOnAxisInputGlobal>.NativeClassPtr, 100663675);
			ScrollOnAxisInputGlobal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollOnAxisInputGlobal>.NativeClassPtr, 100663676);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00010FC8 File Offset: 0x0000F1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121490, XrefRangeEnd = 1121518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollOnAxisInputGlobal.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00010FFC File Offset: 0x0000F1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121518, XrefRangeEnd = 1121546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void executeFunction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollOnAxisInputGlobal.NativeMethodInfoPtr_executeFunction_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00011030 File Offset: 0x0000F230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121546, XrefRangeEnd = 1121551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float getContentSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollOnAxisInputGlobal.NativeMethodInfoPtr_getContentSize_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0001106C File Offset: 0x0000F26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121551, XrefRangeEnd = 1121555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Scroll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollOnAxisInputGlobal.NativeMethodInfoPtr_Scroll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x000110A0 File Offset: 0x0000F2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121555, XrefRangeEnd = 1121557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollOnAxisInputGlobal.NativeMethodInfoPtr_Invoke_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x000110D4 File Offset: 0x0000F2D4
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollOnAxisInputGlobal.NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00011118 File Offset: 0x0000F318
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollOnAxisInputGlobal.NativeMethodInfoPtr_OnScroll_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0001115C File Offset: 0x0000F35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121557, XrefRangeEnd = 1121566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScrollOnAxisInputGlobal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollOnAxisInputGlobal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollOnAxisInputGlobal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00003DAC File Offset: 0x00001FAC
		public ScrollOnAxisInputGlobal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600033F RID: 831 RVA: 0x00011198 File Offset: 0x0000F398
		// (set) Token: 0x06000340 RID: 832 RVA: 0x00003DB5 File Offset: 0x00001FB5
		public unsafe float scrollMaxSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputGlobal.NativeFieldInfoPtr_scrollMaxSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputGlobal.NativeFieldInfoPtr_scrollMaxSpeed)) = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000341 RID: 833 RVA: 0x000111C0 File Offset: 0x0000F3C0
		// (set) Token: 0x06000342 RID: 834 RVA: 0x00003DD0 File Offset: 0x00001FD0
		public unsafe ScrollRect scrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputGlobal.NativeFieldInfoPtr_scrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputGlobal.NativeFieldInfoPtr_scrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000343 RID: 835 RVA: 0x000111F0 File Offset: 0x0000F3F0
		// (set) Token: 0x06000344 RID: 836 RVA: 0x00003DEF File Offset: 0x00001FEF
		public unsafe TMP_InputField inputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputGlobal.NativeFieldInfoPtr_inputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputGlobal.NativeFieldInfoPtr_inputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000345 RID: 837 RVA: 0x00011220 File Offset: 0x0000F420
		// (set) Token: 0x06000346 RID: 838 RVA: 0x00003E0E File Offset: 0x0000200E
		public unsafe Scrollbar scrollBar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputGlobal.NativeFieldInfoPtr_scrollBar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputGlobal.NativeFieldInfoPtr_scrollBar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000347 RID: 839 RVA: 0x00011250 File Offset: 0x0000F450
		// (set) Token: 0x06000348 RID: 840 RVA: 0x00003E2D File Offset: 0x0000202D
		public unsafe ScrollOnAxisInputGlobal.Axis scrollAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputGlobal.NativeFieldInfoPtr_scrollAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputGlobal.NativeFieldInfoPtr_scrollAxis)) = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000349 RID: 841 RVA: 0x00011278 File Offset: 0x0000F478
		// (set) Token: 0x0600034A RID: 842 RVA: 0x00003E48 File Offset: 0x00002048
		public unsafe InputDetector inputDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputGlobal.NativeFieldInfoPtr_inputDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputGlobal.NativeFieldInfoPtr_inputDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600034B RID: 843 RVA: 0x000112A8 File Offset: 0x0000F4A8
		// (set) Token: 0x0600034C RID: 844 RVA: 0x00003E67 File Offset: 0x00002067
		public unsafe UnityEvent OnDragOrScrolled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputGlobal.NativeFieldInfoPtr_OnDragOrScrolled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInputGlobal.NativeFieldInfoPtr_OnDragOrScrolled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeFieldInfoPtr_scrollMaxSpeed;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeFieldInfoPtr_scrollRect;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeFieldInfoPtr_inputField;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeFieldInfoPtr_scrollBar;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeFieldInfoPtr_scrollAxis;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeFieldInfoPtr_inputDetector;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeFieldInfoPtr_OnDragOrScrolled;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_executeFunction_Protected_Virtual_Void_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_getContentSize_Private_Single_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_Scroll_Public_Void_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_OnScroll_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000C6 RID: 198
		public enum Axis
		{
			// Token: 0x0400056E RID: 1390
			Horizontal,
			// Token: 0x0400056F RID: 1391
			Vertical
		}
	}
}
