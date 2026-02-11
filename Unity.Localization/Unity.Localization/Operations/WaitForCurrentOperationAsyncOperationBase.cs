using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Operations
{
	// Token: 0x020000BF RID: 191
	public class WaitForCurrentOperationAsyncOperationBase<TObject> : AsyncOperationBase<TObject>
	{
		// Token: 0x06000A55 RID: 2645 RVA: 0x0003050C File Offset: 0x0002E70C
		// Note: this type is marked as 'beforefieldinit'.
		static WaitForCurrentOperationAsyncOperationBase()
		{
			Il2CppClassPointerStore<WaitForCurrentOperationAsyncOperationBase<TObject>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Operations", "WaitForCurrentOperationAsyncOperationBase`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForCurrentOperationAsyncOperationBase<TObject>>.NativeClassPtr);
			WaitForCurrentOperationAsyncOperationBase<TObject>.NativeFieldInfoPtr__CurrentOperation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForCurrentOperationAsyncOperationBase<TObject>>.NativeClassPtr, "<CurrentOperation>k__BackingField");
			WaitForCurrentOperationAsyncOperationBase<TObject>.NativeFieldInfoPtr__Dependency_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForCurrentOperationAsyncOperationBase<TObject>>.NativeClassPtr, "<Dependency>k__BackingField");
			WaitForCurrentOperationAsyncOperationBase<TObject>.NativeFieldInfoPtr_m_Waiting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForCurrentOperationAsyncOperationBase<TObject>>.NativeClassPtr, "m_Waiting");
			WaitForCurrentOperationAsyncOperationBase<TObject>.NativeMethodInfoPtr_get_CurrentOperation_Protected_get_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForCurrentOperationAsyncOperationBase<TObject>>.NativeClassPtr, 100665037);
			WaitForCurrentOperationAsyncOperationBase<TObject>.NativeMethodInfoPtr_set_CurrentOperation_Protected_set_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForCurrentOperationAsyncOperationBase<TObject>>.NativeClassPtr, 100665038);
			WaitForCurrentOperationAsyncOperationBase<TObject>.NativeMethodInfoPtr_get_Dependency_Public_get_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForCurrentOperationAsyncOperationBase<TObject>>.NativeClassPtr, 100665039);
			WaitForCurrentOperationAsyncOperationBase<TObject>.NativeMethodInfoPtr_set_Dependency_Public_set_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForCurrentOperationAsyncOperationBase<TObject>>.NativeClassPtr, 100665040);
			WaitForCurrentOperationAsyncOperationBase<TObject>.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForCurrentOperationAsyncOperationBase<TObject>>.NativeClassPtr, 100665041);
			WaitForCurrentOperationAsyncOperationBase<TObject>.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForCurrentOperationAsyncOperationBase<TObject>>.NativeClassPtr, 100665042);
			WaitForCurrentOperationAsyncOperationBase<TObject>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForCurrentOperationAsyncOperationBase<TObject>>.NativeClassPtr, 100665043);
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000A56 RID: 2646 RVA: 0x00030640 File Offset: 0x0002E840
		// (set) Token: 0x06000A57 RID: 2647 RVA: 0x00030678 File Offset: 0x0002E878
		public unsafe AsyncOperationHandle CurrentOperation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForCurrentOperationAsyncOperationBase<TObject>.NativeMethodInfoPtr_get_CurrentOperation_Protected_get_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078703, XrefRangeEnd = 1078711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForCurrentOperationAsyncOperationBase<TObject>.NativeMethodInfoPtr_set_CurrentOperation_Protected_set_Void_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x000306C0 File Offset: 0x0002E8C0
		// (set) Token: 0x06000A59 RID: 2649 RVA: 0x000306F8 File Offset: 0x0002E8F8
		public unsafe AsyncOperationHandle Dependency
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForCurrentOperationAsyncOperationBase<TObject>.NativeMethodInfoPtr_get_Dependency_Public_get_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078711, XrefRangeEnd = 1078713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForCurrentOperationAsyncOperationBase<TObject>.NativeMethodInfoPtr_set_Dependency_Public_set_Void_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00030740 File Offset: 0x0002E940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078713, XrefRangeEnd = 1078737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool InvokeWaitForCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitForCurrentOperationAsyncOperationBase<TObject>.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00030788 File Offset: 0x0002E988
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1078740, RefRangeEnd = 1078741, XrefRangeStart = 1078737, XrefRangeEnd = 1078740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitForCurrentOperationAsyncOperationBase<TObject>.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x000307C4 File Offset: 0x0002E9C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1078743, RefRangeEnd = 1078744, XrefRangeStart = 1078741, XrefRangeEnd = 1078743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitForCurrentOperationAsyncOperationBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForCurrentOperationAsyncOperationBase<TObject>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForCurrentOperationAsyncOperationBase<TObject>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x0000640A File Offset: 0x0000460A
		public WaitForCurrentOperationAsyncOperationBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x00030800 File Offset: 0x0002EA00
		// (set) Token: 0x06000A5F RID: 2655 RVA: 0x00006413 File Offset: 0x00004613
		public AsyncOperationHandle _CurrentOperation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForCurrentOperationAsyncOperationBase<TObject>.NativeFieldInfoPtr__CurrentOperation_k__BackingField);
				return new AsyncOperationHandle(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForCurrentOperationAsyncOperationBase<TObject>.NativeFieldInfoPtr__CurrentOperation_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x00030830 File Offset: 0x0002EA30
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x00006441 File Offset: 0x00004641
		public AsyncOperationHandle _Dependency_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForCurrentOperationAsyncOperationBase<TObject>.NativeFieldInfoPtr__Dependency_k__BackingField);
				return new AsyncOperationHandle(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForCurrentOperationAsyncOperationBase<TObject>.NativeFieldInfoPtr__Dependency_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x00030860 File Offset: 0x0002EA60
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x0000646F File Offset: 0x0000466F
		public unsafe bool m_Waiting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForCurrentOperationAsyncOperationBase<TObject>.NativeFieldInfoPtr_m_Waiting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForCurrentOperationAsyncOperationBase<TObject>.NativeFieldInfoPtr_m_Waiting)) = value;
			}
		}

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeFieldInfoPtr__CurrentOperation_k__BackingField;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeFieldInfoPtr__Dependency_k__BackingField;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeFieldInfoPtr_m_Waiting;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentOperation_Protected_get_AsyncOperationHandle_0;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentOperation_Protected_set_Void_AsyncOperationHandle_0;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeMethodInfoPtr_get_Dependency_Public_get_AsyncOperationHandle_0;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeMethodInfoPtr_set_Dependency_Public_set_Void_AsyncOperationHandle_0;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
