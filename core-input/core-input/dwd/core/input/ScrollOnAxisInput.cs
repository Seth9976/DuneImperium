using System;
using dwd.core.input.compositeModule.inputDetection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine.UI;

namespace dwd.core.input
{
	// Token: 0x02000059 RID: 89
	public sealed class ScrollOnAxisInput : RegisterGlobalInputFunction
	{
		// Token: 0x0600030A RID: 778 RVA: 0x000106D0 File Offset: 0x0000E8D0
		// Note: this type is marked as 'beforefieldinit'.
		static ScrollOnAxisInput()
		{
			Il2CppClassPointerStore<ScrollOnAxisInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "ScrollOnAxisInput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollOnAxisInput>.NativeClassPtr);
			ScrollOnAxisInput.NativeFieldInfoPtr_scrollMaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollOnAxisInput>.NativeClassPtr, "scrollMaxSpeed");
			ScrollOnAxisInput.NativeFieldInfoPtr_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollOnAxisInput>.NativeClassPtr, "scrollRect");
			ScrollOnAxisInput.NativeFieldInfoPtr_inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollOnAxisInput>.NativeClassPtr, "inputField");
			ScrollOnAxisInput.NativeFieldInfoPtr_scrollBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollOnAxisInput>.NativeClassPtr, "scrollBar");
			ScrollOnAxisInput.NativeFieldInfoPtr_scrollAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollOnAxisInput>.NativeClassPtr, "scrollAxis");
			ScrollOnAxisInput.NativeFieldInfoPtr_inputDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollOnAxisInput>.NativeClassPtr, "inputDetector");
			ScrollOnAxisInput.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollOnAxisInput>.NativeClassPtr, 100663656);
			ScrollOnAxisInput.NativeMethodInfoPtr_executeFunction_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollOnAxisInput>.NativeClassPtr, 100663657);
			ScrollOnAxisInput.NativeMethodInfoPtr_getContentSize_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollOnAxisInput>.NativeClassPtr, 100663658);
			ScrollOnAxisInput.NativeMethodInfoPtr_Scroll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollOnAxisInput>.NativeClassPtr, 100663659);
			ScrollOnAxisInput.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollOnAxisInput>.NativeClassPtr, 100663660);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x000107DC File Offset: 0x0000E9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121345, XrefRangeEnd = 1121373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollOnAxisInput.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00010810 File Offset: 0x0000EA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121373, XrefRangeEnd = 1121401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void executeFunction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollOnAxisInput.NativeMethodInfoPtr_executeFunction_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00010844 File Offset: 0x0000EA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121401, XrefRangeEnd = 1121406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float getContentSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollOnAxisInput.NativeMethodInfoPtr_getContentSize_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00010880 File Offset: 0x0000EA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121406, XrefRangeEnd = 1121410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Scroll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollOnAxisInput.NativeMethodInfoPtr_Scroll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x000108B4 File Offset: 0x0000EAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121410, XrefRangeEnd = 1121414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScrollOnAxisInput()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollOnAxisInput>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollOnAxisInput.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00003C17 File Offset: 0x00001E17
		public ScrollOnAxisInput(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000311 RID: 785 RVA: 0x000108F0 File Offset: 0x0000EAF0
		// (set) Token: 0x06000312 RID: 786 RVA: 0x00003C20 File Offset: 0x00001E20
		public unsafe float scrollMaxSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInput.NativeFieldInfoPtr_scrollMaxSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInput.NativeFieldInfoPtr_scrollMaxSpeed)) = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000313 RID: 787 RVA: 0x00010918 File Offset: 0x0000EB18
		// (set) Token: 0x06000314 RID: 788 RVA: 0x00003C3B File Offset: 0x00001E3B
		public unsafe ScrollRect scrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInput.NativeFieldInfoPtr_scrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInput.NativeFieldInfoPtr_scrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00010948 File Offset: 0x0000EB48
		// (set) Token: 0x06000316 RID: 790 RVA: 0x00003C5A File Offset: 0x00001E5A
		public unsafe TMP_InputField inputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInput.NativeFieldInfoPtr_inputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInput.NativeFieldInfoPtr_inputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00010978 File Offset: 0x0000EB78
		// (set) Token: 0x06000318 RID: 792 RVA: 0x00003C79 File Offset: 0x00001E79
		public unsafe Scrollbar scrollBar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInput.NativeFieldInfoPtr_scrollBar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInput.NativeFieldInfoPtr_scrollBar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000319 RID: 793 RVA: 0x000109A8 File Offset: 0x0000EBA8
		// (set) Token: 0x0600031A RID: 794 RVA: 0x00003C98 File Offset: 0x00001E98
		public unsafe ScrollOnAxisInput.Axis scrollAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInput.NativeFieldInfoPtr_scrollAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInput.NativeFieldInfoPtr_scrollAxis)) = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600031B RID: 795 RVA: 0x000109D0 File Offset: 0x0000EBD0
		// (set) Token: 0x0600031C RID: 796 RVA: 0x00003CB3 File Offset: 0x00001EB3
		public unsafe InputDetector inputDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInput.NativeFieldInfoPtr_inputDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollOnAxisInput.NativeFieldInfoPtr_inputDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeFieldInfoPtr_scrollMaxSpeed;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeFieldInfoPtr_scrollRect;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeFieldInfoPtr_inputField;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeFieldInfoPtr_scrollBar;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeFieldInfoPtr_scrollAxis;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeFieldInfoPtr_inputDetector;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_executeFunction_Protected_Virtual_Void_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_getContentSize_Private_Single_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_Scroll_Public_Void_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000C4 RID: 196
		public enum Axis
		{
			// Token: 0x04000568 RID: 1384
			Horizontal,
			// Token: 0x04000569 RID: 1385
			Vertical
		}
	}
}
