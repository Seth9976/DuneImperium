using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.UI;

namespace dwd.canis.lib.canis.dbg_client.layouts
{
	// Token: 0x02000056 RID: 86
	public class CenteredGridLayoutGroup : GridLayoutGroup
	{
		// Token: 0x06000352 RID: 850 RVA: 0x00028190 File Offset: 0x00026390
		// Note: this type is marked as 'beforefieldinit'.
		static CenteredGridLayoutGroup()
		{
			Il2CppClassPointerStore<CenteredGridLayoutGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.lib.canis.dbg_client.layouts", "CenteredGridLayoutGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CenteredGridLayoutGroup>.NativeClassPtr);
			CenteredGridLayoutGroup.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CenteredGridLayoutGroup>.NativeClassPtr, 100663818);
			CenteredGridLayoutGroup.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CenteredGridLayoutGroup>.NativeClassPtr, 100663819);
			CenteredGridLayoutGroup.NativeMethodInfoPtr_SetCellsAlongAxis_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CenteredGridLayoutGroup>.NativeClassPtr, 100663820);
			CenteredGridLayoutGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CenteredGridLayoutGroup>.NativeClassPtr, 100663821);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00028210 File Offset: 0x00026410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499688, XrefRangeEnd = 499689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLayoutHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CenteredGridLayoutGroup.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0002824C File Offset: 0x0002644C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499689, XrefRangeEnd = 499690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLayoutVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CenteredGridLayoutGroup.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00028288 File Offset: 0x00026488
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 499730, RefRangeEnd = 499732, XrefRangeStart = 499690, XrefRangeEnd = 499730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void SetCellsAlongAxis(int axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CenteredGridLayoutGroup.NativeMethodInfoPtr_SetCellsAlongAxis_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x000282C8 File Offset: 0x000264C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499732, XrefRangeEnd = 499733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CenteredGridLayoutGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CenteredGridLayoutGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CenteredGridLayoutGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00003763 File Offset: 0x00001963
		public CenteredGridLayoutGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr_SetCellsAlongAxis_Private_Void_Int32_0;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
