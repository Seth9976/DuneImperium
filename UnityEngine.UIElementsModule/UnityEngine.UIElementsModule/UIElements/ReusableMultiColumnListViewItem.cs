using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000036 RID: 54
	public class ReusableMultiColumnListViewItem : ReusableListViewItem
	{
		// Token: 0x0600042C RID: 1068 RVA: 0x0002D028 File Offset: 0x0002B228
		// Note: this type is marked as 'beforefieldinit'.
		static ReusableMultiColumnListViewItem()
		{
			Il2CppClassPointerStore<ReusableMultiColumnListViewItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ReusableMultiColumnListViewItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReusableMultiColumnListViewItem>.NativeClassPtr);
			ReusableMultiColumnListViewItem.NativeMethodInfoPtr_get_rootElement_Public_Virtual_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableMultiColumnListViewItem>.NativeClassPtr, 100663912);
			ReusableMultiColumnListViewItem.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableMultiColumnListViewItem>.NativeClassPtr, 100663913);
			ReusableMultiColumnListViewItem.NativeMethodInfoPtr_Init_Public_Void_VisualElement_Columns_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableMultiColumnListViewItem>.NativeClassPtr, 100663914);
			ReusableMultiColumnListViewItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableMultiColumnListViewItem>.NativeClassPtr, 100663915);
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x0002D0A8 File Offset: 0x0002B2A8
		public unsafe override VisualElement rootElement
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReusableMultiColumnListViewItem.NativeMethodInfoPtr_get_rootElement_Public_Virtual_get_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0002D0F4 File Offset: 0x0002B2F4
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReusableMultiColumnListViewItem.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0002D144 File Offset: 0x0002B344
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287472, RefRangeEnd = 287473, XrefRangeStart = 287442, XrefRangeEnd = 287472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(VisualElement container, Columns columns, bool usesAnimatedDrag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(columns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usesAnimatedDrag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableMultiColumnListViewItem.NativeMethodInfoPtr_Init_Public_Void_VisualElement_Columns_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0002D1A8 File Offset: 0x0002B3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReusableMultiColumnListViewItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReusableMultiColumnListViewItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableMultiColumnListViewItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x000032C5 File Offset: 0x000014C5
		public ReusableMultiColumnListViewItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeMethodInfoPtr_get_rootElement_Public_Virtual_get_VisualElement_0;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_VisualElement_Columns_Boolean_0;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
