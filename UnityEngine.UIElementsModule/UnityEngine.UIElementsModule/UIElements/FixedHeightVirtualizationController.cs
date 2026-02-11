using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000033 RID: 51
	public class FixedHeightVirtualizationController<T> : VerticalVirtualizationController<T> where T : ReusableCollectionItem, new()
	{
		// Token: 0x060003E6 RID: 998 RVA: 0x0002BD74 File Offset: 0x00029F74
		// Note: this type is marked as 'beforefieldinit'.
		static FixedHeightVirtualizationController()
		{
			Il2CppClassPointerStore<FixedHeightVirtualizationController<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "FixedHeightVirtualizationController`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixedHeightVirtualizationController<T>>.NativeClassPtr);
			FixedHeightVirtualizationController<T>.NativeMethodInfoPtr_get_resolvedItemHeight_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedHeightVirtualizationController<T>>.NativeClassPtr, 100663870);
			FixedHeightVirtualizationController<T>.NativeMethodInfoPtr_VisibleItemPredicate_Protected_Virtual_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedHeightVirtualizationController<T>>.NativeClassPtr, 100663871);
			FixedHeightVirtualizationController<T>.NativeMethodInfoPtr__ctor_Public_Void_BaseVerticalCollectionView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedHeightVirtualizationController<T>>.NativeClassPtr, 100663872);
			FixedHeightVirtualizationController<T>.NativeMethodInfoPtr_GetIndexFromPosition_Public_Virtual_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedHeightVirtualizationController<T>>.NativeClassPtr, 100663873);
			FixedHeightVirtualizationController<T>.NativeMethodInfoPtr_GetExpectedItemHeight_Public_Virtual_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedHeightVirtualizationController<T>>.NativeClassPtr, 100663874);
			FixedHeightVirtualizationController<T>.NativeMethodInfoPtr_GetExpectedContentHeight_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedHeightVirtualizationController<T>>.NativeClassPtr, 100663875);
			FixedHeightVirtualizationController<T>.NativeMethodInfoPtr_ScrollToItem_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedHeightVirtualizationController<T>>.NativeClassPtr, 100663876);
			FixedHeightVirtualizationController<T>.NativeMethodInfoPtr_Resize_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedHeightVirtualizationController<T>>.NativeClassPtr, 100663877);
			FixedHeightVirtualizationController<T>.NativeMethodInfoPtr_OnScroll_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedHeightVirtualizationController<T>>.NativeClassPtr, 100663878);
			FixedHeightVirtualizationController<T>.NativeMethodInfoPtr_GetOrMakeItemAtIndex_Internal_Virtual_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedHeightVirtualizationController<T>>.NativeClassPtr, 100663879);
			FixedHeightVirtualizationController<T>.NativeMethodInfoPtr_EndDrag_Internal_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedHeightVirtualizationController<T>>.NativeClassPtr, 100663880);
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x0002BEBC File Offset: 0x0002A0BC
		public unsafe float resolvedItemHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287200, XrefRangeEnd = 287202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedHeightVirtualizationController<T>.NativeMethodInfoPtr_get_resolvedItemHeight_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0002BEF8 File Offset: 0x0002A0F8
		[CallerCount(0)]
		public unsafe override bool VisibleItemPredicate(T i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = i;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref i;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FixedHeightVirtualizationController<T>.NativeMethodInfoPtr_VisibleItemPredicate_Protected_Virtual_Boolean_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0002BF88 File Offset: 0x0002A188
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287208, RefRangeEnd = 287209, XrefRangeStart = 287202, XrefRangeEnd = 287208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FixedHeightVirtualizationController(BaseVerticalCollectionView collectionView)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FixedHeightVirtualizationController<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collectionView);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedHeightVirtualizationController<T>.NativeMethodInfoPtr__ctor_Public_Void_BaseVerticalCollectionView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0002BFD4 File Offset: 0x0002A1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287209, XrefRangeEnd = 287210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetIndexFromPosition(Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FixedHeightVirtualizationController<T>.NativeMethodInfoPtr_GetIndexFromPosition_Public_Virtual_Int32_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0002C028 File Offset: 0x0002A228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetExpectedItemHeight(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FixedHeightVirtualizationController<T>.NativeMethodInfoPtr_GetExpectedItemHeight_Public_Virtual_Single_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0002C07C File Offset: 0x0002A27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287210, XrefRangeEnd = 287212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetExpectedContentHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FixedHeightVirtualizationController<T>.NativeMethodInfoPtr_GetExpectedContentHeight_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0002C0C4 File Offset: 0x0002A2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287212, XrefRangeEnd = 287217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ScrollToItem(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FixedHeightVirtualizationController<T>.NativeMethodInfoPtr_ScrollToItem_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0002C110 File Offset: 0x0002A310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287217, XrefRangeEnd = 287233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resize(Vector2 size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FixedHeightVirtualizationController<T>.NativeMethodInfoPtr_Resize_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0002C15C File Offset: 0x0002A35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287233, XrefRangeEnd = 287272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnScroll(Vector2 scrollOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scrollOffset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FixedHeightVirtualizationController<T>.NativeMethodInfoPtr_OnScroll_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0002C1A8 File Offset: 0x0002A3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287272, XrefRangeEnd = 287279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override T GetOrMakeItemAtIndex(int activeItemIndex = -1, int scrollViewIndex = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref activeItemIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scrollViewIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FixedHeightVirtualizationController<T>.NativeMethodInfoPtr_GetOrMakeItemAtIndex_Internal_Virtual_T_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0002C208 File Offset: 0x0002A408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287279, XrefRangeEnd = 287291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndDrag(int dropIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dropIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FixedHeightVirtualizationController<T>.NativeMethodInfoPtr_EndDrag_Internal_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00003161 File Offset: 0x00001361
		public FixedHeightVirtualizationController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr_get_resolvedItemHeight_Private_get_Single_0;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeMethodInfoPtr_VisibleItemPredicate_Protected_Virtual_Boolean_T_0;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BaseVerticalCollectionView_0;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexFromPosition_Public_Virtual_Int32_Vector2_0;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeMethodInfoPtr_GetExpectedItemHeight_Public_Virtual_Single_Int32_0;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeMethodInfoPtr_GetExpectedContentHeight_Public_Virtual_Single_0;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeMethodInfoPtr_ScrollToItem_Public_Virtual_Void_Int32_0;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Public_Virtual_Void_Vector2_0;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr_OnScroll_Public_Virtual_Void_Vector2_0;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr_GetOrMakeItemAtIndex_Internal_Virtual_T_Int32_Int32_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr_EndDrag_Internal_Virtual_Void_Int32_0;
	}
}
