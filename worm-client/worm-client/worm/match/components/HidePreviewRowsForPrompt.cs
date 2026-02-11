using System;
using boardgames.match.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001B2 RID: 434
	public class HidePreviewRowsForPrompt : MonoBehaviour
	{
		// Token: 0x06001323 RID: 4899 RVA: 0x00052348 File Offset: 0x00050548
		// Note: this type is marked as 'beforefieldinit'.
		static HidePreviewRowsForPrompt()
		{
			Il2CppClassPointerStore<HidePreviewRowsForPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "HidePreviewRowsForPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HidePreviewRowsForPrompt>.NativeClassPtr);
			HidePreviewRowsForPrompt.NativeFieldInfoPtr_minimize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HidePreviewRowsForPrompt>.NativeClassPtr, "minimize");
			HidePreviewRowsForPrompt.NativeFieldInfoPtr_rows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HidePreviewRowsForPrompt>.NativeClassPtr, "rows");
			HidePreviewRowsForPrompt.NativeFieldInfoPtr_wasHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HidePreviewRowsForPrompt>.NativeClassPtr, "wasHidden");
			HidePreviewRowsForPrompt.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidePreviewRowsForPrompt>.NativeClassPtr, 100665917);
			HidePreviewRowsForPrompt.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidePreviewRowsForPrompt>.NativeClassPtr, 100665918);
			HidePreviewRowsForPrompt.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidePreviewRowsForPrompt>.NativeClassPtr, 100665919);
			HidePreviewRowsForPrompt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HidePreviewRowsForPrompt>.NativeClassPtr, 100665920);
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x00052404 File Offset: 0x00050604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712768, XrefRangeEnd = 712775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidePreviewRowsForPrompt.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x00052438 File Offset: 0x00050638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712775, XrefRangeEnd = 712776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidePreviewRowsForPrompt.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x0005246C File Offset: 0x0005066C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712776, XrefRangeEnd = 712778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidePreviewRowsForPrompt.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x000524A0 File Offset: 0x000506A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 509850, RefRangeEnd = 509851, XrefRangeStart = 509850, XrefRangeEnd = 509851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HidePreviewRowsForPrompt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HidePreviewRowsForPrompt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HidePreviewRowsForPrompt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x0000BE28 File Offset: 0x0000A028
		public HidePreviewRowsForPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001329 RID: 4905 RVA: 0x000524DC File Offset: 0x000506DC
		// (set) Token: 0x0600132A RID: 4906 RVA: 0x0000BE31 File Offset: 0x0000A031
		public unsafe MinimizablePrompt minimize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidePreviewRowsForPrompt.NativeFieldInfoPtr_minimize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinimizablePrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidePreviewRowsForPrompt.NativeFieldInfoPtr_minimize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x0600132B RID: 4907 RVA: 0x0005250C File Offset: 0x0005070C
		// (set) Token: 0x0600132C RID: 4908 RVA: 0x0000BE50 File Offset: 0x0000A050
		public unsafe PreviewRowsVisibility rows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidePreviewRowsForPrompt.NativeFieldInfoPtr_rows);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PreviewRowsVisibility>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidePreviewRowsForPrompt.NativeFieldInfoPtr_rows), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x0005253C File Offset: 0x0005073C
		// (set) Token: 0x0600132E RID: 4910 RVA: 0x0000BE6F File Offset: 0x0000A06F
		public unsafe bool wasHidden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidePreviewRowsForPrompt.NativeFieldInfoPtr_wasHidden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HidePreviewRowsForPrompt.NativeFieldInfoPtr_wasHidden)) = value;
			}
		}

		// Token: 0x04000B15 RID: 2837
		private static readonly IntPtr NativeFieldInfoPtr_minimize;

		// Token: 0x04000B16 RID: 2838
		private static readonly IntPtr NativeFieldInfoPtr_rows;

		// Token: 0x04000B17 RID: 2839
		private static readonly IntPtr NativeFieldInfoPtr_wasHidden;

		// Token: 0x04000B18 RID: 2840
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000B19 RID: 2841
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000B1A RID: 2842
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000B1B RID: 2843
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
