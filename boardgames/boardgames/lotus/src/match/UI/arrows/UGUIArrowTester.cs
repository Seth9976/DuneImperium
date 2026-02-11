using System;
using dwd.core.input;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace lotus.src.match.UI.arrows
{
	// Token: 0x020000F4 RID: 244
	public class UGUIArrowTester : MonoBehaviour
	{
		// Token: 0x06000BD4 RID: 3028 RVA: 0x00036A78 File Offset: 0x00034C78
		// Note: this type is marked as 'beforefieldinit'.
		static UGUIArrowTester()
		{
			Il2CppClassPointerStore<UGUIArrowTester>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.src.match.UI.arrows", "UGUIArrowTester");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UGUIArrowTester>.NativeClassPtr);
			UGUIArrowTester.NativeFieldInfoPtr_arrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIArrowTester>.NativeClassPtr, "arrow");
			UGUIArrowTester.NativeFieldInfoPtr_activePress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIArrowTester>.NativeClassPtr, "activePress");
			UGUIArrowTester.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIArrowTester>.NativeClassPtr, 100665170);
			UGUIArrowTester.NativeMethodInfoPtr_handleStart_Private_Void_PressStartedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIArrowTester>.NativeClassPtr, 100665171);
			UGUIArrowTester.NativeMethodInfoPtr_handleEnd_Private_Void_PressEndedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIArrowTester>.NativeClassPtr, 100665172);
			UGUIArrowTester.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIArrowTester>.NativeClassPtr, 100665173);
			UGUIArrowTester.NativeMethodInfoPtr_updateArrow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIArrowTester>.NativeClassPtr, 100665174);
			UGUIArrowTester.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIArrowTester>.NativeClassPtr, 100665175);
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00036B48 File Offset: 0x00034D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995026, XrefRangeEnd = 995040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIArrowTester.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x00036B7C File Offset: 0x00034D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995040, XrefRangeEnd = 995042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleStart(PressStartedEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIArrowTester.NativeMethodInfoPtr_handleStart_Private_Void_PressStartedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x00036BC0 File Offset: 0x00034DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995042, XrefRangeEnd = 995045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleEnd(PressEndedEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIArrowTester.NativeMethodInfoPtr_handleEnd_Private_Void_PressEndedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x00036C04 File Offset: 0x00034E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995045, XrefRangeEnd = 995048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIArrowTester.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x00036C38 File Offset: 0x00034E38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 995052, RefRangeEnd = 995054, XrefRangeStart = 995048, XrefRangeEnd = 995052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateArrow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIArrowTester.NativeMethodInfoPtr_updateArrow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x00036C6C File Offset: 0x00034E6C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UGUIArrowTester()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UGUIArrowTester>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIArrowTester.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x00007779 File Offset: 0x00005979
		public UGUIArrowTester(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x00036CA8 File Offset: 0x00034EA8
		// (set) Token: 0x06000BDD RID: 3037 RVA: 0x00007782 File Offset: 0x00005982
		public unsafe UGUIArrow arrow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrowTester.NativeFieldInfoPtr_arrow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UGUIArrow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrowTester.NativeFieldInfoPtr_arrow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000BDE RID: 3038 RVA: 0x00036CD8 File Offset: 0x00034ED8
		// (set) Token: 0x06000BDF RID: 3039 RVA: 0x000077A1 File Offset: 0x000059A1
		public unsafe Press activePress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrowTester.NativeFieldInfoPtr_activePress);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Press>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIArrowTester.NativeFieldInfoPtr_activePress), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeFieldInfoPtr_arrow;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeFieldInfoPtr_activePress;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeMethodInfoPtr_handleStart_Private_Void_PressStartedEvent_0;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeMethodInfoPtr_handleEnd_Private_Void_PressEndedEvent_0;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeMethodInfoPtr_updateArrow_Private_Void_0;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
