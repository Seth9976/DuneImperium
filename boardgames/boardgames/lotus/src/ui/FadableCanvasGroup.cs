using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus.src.ui.commands;
using UnityEngine;

namespace lotus.src.ui
{
	// Token: 0x020000EC RID: 236
	public class FadableCanvasGroup : MonoBehaviour
	{
		// Token: 0x06000B66 RID: 2918 RVA: 0x0003577C File Offset: 0x0003397C
		// Note: this type is marked as 'beforefieldinit'.
		static FadableCanvasGroup()
		{
			Il2CppClassPointerStore<FadableCanvasGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.src.ui", "FadableCanvasGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FadableCanvasGroup>.NativeClassPtr);
			FadableCanvasGroup.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadableCanvasGroup>.NativeClassPtr, "canvasGroup");
			FadableCanvasGroup.NativeFieldInfoPtr_alphaCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadableCanvasGroup>.NativeClassPtr, "alphaCommand");
			FadableCanvasGroup.NativeFieldInfoPtr_executor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadableCanvasGroup>.NativeClassPtr, "executor");
			FadableCanvasGroup.NativeMethodInfoPtr_get_Alpha_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadableCanvasGroup>.NativeClassPtr, 100665118);
			FadableCanvasGroup.NativeMethodInfoPtr_set_Alpha_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadableCanvasGroup>.NativeClassPtr, 100665119);
			FadableCanvasGroup.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadableCanvasGroup>.NativeClassPtr, 100665120);
			FadableCanvasGroup.NativeMethodInfoPtr_FadeIn_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadableCanvasGroup>.NativeClassPtr, 100665121);
			FadableCanvasGroup.NativeMethodInfoPtr_FadeOut_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadableCanvasGroup>.NativeClassPtr, 100665122);
			FadableCanvasGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadableCanvasGroup>.NativeClassPtr, 100665123);
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x00035860 File Offset: 0x00033A60
		// (set) Token: 0x06000B68 RID: 2920 RVA: 0x0003589C File Offset: 0x00033A9C
		public unsafe float Alpha
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994680, XrefRangeEnd = 994682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FadableCanvasGroup.NativeMethodInfoPtr_get_Alpha_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994682, XrefRangeEnd = 994684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FadableCanvasGroup.NativeMethodInfoPtr_set_Alpha_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x000358DC File Offset: 0x00033ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994684, XrefRangeEnd = 994692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FadableCanvasGroup.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00035910 File Offset: 0x00033B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994692, XrefRangeEnd = 994702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeIn(float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref duration;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FadableCanvasGroup.NativeMethodInfoPtr_FadeIn_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x00035950 File Offset: 0x00033B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994702, XrefRangeEnd = 994712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeOut(float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref duration;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FadableCanvasGroup.NativeMethodInfoPtr_FadeOut_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00035990 File Offset: 0x00033B90
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FadableCanvasGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FadableCanvasGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FadableCanvasGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x000072E6 File Offset: 0x000054E6
		public FadableCanvasGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x000359CC File Offset: 0x00033BCC
		// (set) Token: 0x06000B6F RID: 2927 RVA: 0x000072EF File Offset: 0x000054EF
		public unsafe CanvasGroup canvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FadableCanvasGroup.NativeFieldInfoPtr_canvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FadableCanvasGroup.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x000359FC File Offset: 0x00033BFC
		// (set) Token: 0x06000B71 RID: 2929 RVA: 0x0000730E File Offset: 0x0000550E
		public unsafe AnimateCanvasGroupAlpha alphaCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FadableCanvasGroup.NativeFieldInfoPtr_alphaCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimateCanvasGroupAlpha>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FadableCanvasGroup.NativeFieldInfoPtr_alphaCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000B72 RID: 2930 RVA: 0x00035A2C File Offset: 0x00033C2C
		// (set) Token: 0x06000B73 RID: 2931 RVA: 0x0000732D File Offset: 0x0000552D
		public unsafe CommandExecutor executor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FadableCanvasGroup.NativeFieldInfoPtr_executor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandExecutor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FadableCanvasGroup.NativeFieldInfoPtr_executor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeFieldInfoPtr_canvasGroup;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeFieldInfoPtr_alphaCommand;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeFieldInfoPtr_executor;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeMethodInfoPtr_get_Alpha_Public_get_Single_0;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeMethodInfoPtr_set_Alpha_Public_set_Void_Single_0;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeMethodInfoPtr_FadeIn_Public_Void_Single_0;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeMethodInfoPtr_FadeOut_Public_Void_Single_0;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
