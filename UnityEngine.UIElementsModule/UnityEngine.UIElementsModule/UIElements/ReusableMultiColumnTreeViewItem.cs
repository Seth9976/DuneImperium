using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000037 RID: 55
	public class ReusableMultiColumnTreeViewItem : ReusableTreeViewItem
	{
		// Token: 0x06000432 RID: 1074 RVA: 0x0002D1E4 File Offset: 0x0002B3E4
		// Note: this type is marked as 'beforefieldinit'.
		static ReusableMultiColumnTreeViewItem()
		{
			Il2CppClassPointerStore<ReusableMultiColumnTreeViewItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ReusableMultiColumnTreeViewItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReusableMultiColumnTreeViewItem>.NativeClassPtr);
			ReusableMultiColumnTreeViewItem.NativeMethodInfoPtr_get_rootElement_Public_Virtual_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableMultiColumnTreeViewItem>.NativeClassPtr, 100663916);
			ReusableMultiColumnTreeViewItem.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableMultiColumnTreeViewItem>.NativeClassPtr, 100663917);
			ReusableMultiColumnTreeViewItem.NativeMethodInfoPtr_Init_Public_Void_VisualElement_Columns_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableMultiColumnTreeViewItem>.NativeClassPtr, 100663918);
			ReusableMultiColumnTreeViewItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableMultiColumnTreeViewItem>.NativeClassPtr, 100663919);
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x0002D264 File Offset: 0x0002B464
		public unsafe override VisualElement rootElement
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReusableMultiColumnTreeViewItem.NativeMethodInfoPtr_get_rootElement_Public_Virtual_get_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0002D2B0 File Offset: 0x0002B4B0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init(VisualElement item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReusableMultiColumnTreeViewItem.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0002D300 File Offset: 0x0002B500
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287502, RefRangeEnd = 287503, XrefRangeStart = 287473, XrefRangeEnd = 287502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(VisualElement container, Columns columns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(columns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableMultiColumnTreeViewItem.NativeMethodInfoPtr_Init_Public_Void_VisualElement_Columns_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0002D354 File Offset: 0x0002B554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287503, XrefRangeEnd = 287525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReusableMultiColumnTreeViewItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReusableMultiColumnTreeViewItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableMultiColumnTreeViewItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x000032CE File Offset: 0x000014CE
		public ReusableMultiColumnTreeViewItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr_get_rootElement_Public_Virtual_get_VisualElement_0;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_0;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_VisualElement_Columns_0;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
