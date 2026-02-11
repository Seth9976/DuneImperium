using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B2 RID: 178
	public static class ListViewDraggerExtension : Object
	{
		// Token: 0x060010CD RID: 4301 RVA: 0x00058164 File Offset: 0x00056364
		// Note: this type is marked as 'beforefieldinit'.
		static ListViewDraggerExtension()
		{
			Il2CppClassPointerStore<ListViewDraggerExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ListViewDraggerExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListViewDraggerExtension>.NativeClassPtr);
			ListViewDraggerExtension.NativeMethodInfoPtr_GetRecycledItemFromId_Public_Static_ReusableCollectionItem_BaseVerticalCollectionView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDraggerExtension>.NativeClassPtr, 100665700);
			ListViewDraggerExtension.NativeMethodInfoPtr_GetRecycledItemFromIndex_Public_Static_ReusableCollectionItem_BaseVerticalCollectionView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListViewDraggerExtension>.NativeClassPtr, 100665701);
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x000581BC File Offset: 0x000563BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310938, RefRangeEnd = 310939, XrefRangeStart = 310918, XrefRangeEnd = 310938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReusableCollectionItem GetRecycledItemFromId(this BaseVerticalCollectionView listView, int id)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listView);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDraggerExtension.NativeMethodInfoPtr_GetRecycledItemFromId_Public_Static_ReusableCollectionItem_BaseVerticalCollectionView_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReusableCollectionItem>(intPtr3) : null;
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x00058210 File Offset: 0x00056410
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 310959, RefRangeEnd = 310962, XrefRangeStart = 310939, XrefRangeEnd = 310959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReusableCollectionItem GetRecycledItemFromIndex(this BaseVerticalCollectionView listView, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listView);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListViewDraggerExtension.NativeMethodInfoPtr_GetRecycledItemFromIndex_Public_Static_ReusableCollectionItem_BaseVerticalCollectionView_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReusableCollectionItem>(intPtr3) : null;
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x000086DE File Offset: 0x000068DE
		public ListViewDraggerExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B9B RID: 2971
		private static readonly IntPtr NativeMethodInfoPtr_GetRecycledItemFromId_Public_Static_ReusableCollectionItem_BaseVerticalCollectionView_Int32_0;

		// Token: 0x04000B9C RID: 2972
		private static readonly IntPtr NativeMethodInfoPtr_GetRecycledItemFromIndex_Public_Static_ReusableCollectionItem_BaseVerticalCollectionView_Int32_0;
	}
}
