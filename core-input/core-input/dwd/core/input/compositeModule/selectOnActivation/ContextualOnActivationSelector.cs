using System;
using dwd.core.input.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.input.compositeModule.selectOnActivation
{
	// Token: 0x02000090 RID: 144
	public sealed class ContextualOnActivationSelector : OnActivationSelector
	{
		// Token: 0x0600062F RID: 1583 RVA: 0x0001A7D0 File Offset: 0x000189D0
		// Note: this type is marked as 'beforefieldinit'.
		static ContextualOnActivationSelector()
		{
			Il2CppClassPointerStore<ContextualOnActivationSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule.selectOnActivation", "ContextualOnActivationSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextualOnActivationSelector>.NativeClassPtr);
			ContextualOnActivationSelector.NativeFieldInfoPtr_activeContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextualOnActivationSelector>.NativeClassPtr, "activeContext");
			ContextualOnActivationSelector.NativeMethodInfoPtr_GetSelection_Public_Virtual_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualOnActivationSelector>.NativeClassPtr, 100664063);
			ContextualOnActivationSelector.NativeMethodInfoPtr_isValidContextualSelection_Private_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualOnActivationSelector>.NativeClassPtr, 100664064);
			ContextualOnActivationSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualOnActivationSelector>.NativeClassPtr, 100664065);
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0001A850 File Offset: 0x00018A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125233, XrefRangeEnd = 1125268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameObject GetSelection(GameObject lastSelectionOnDeactivation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastSelectionOnDeactivation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualOnActivationSelector.NativeMethodInfoPtr_GetSelection_Public_Virtual_GameObject_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0001A8A0 File Offset: 0x00018AA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1125281, RefRangeEnd = 1125284, XrefRangeStart = 1125268, XrefRangeEnd = 1125281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool isValidContextualSelection(GameObject selectedObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectedObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualOnActivationSelector.NativeMethodInfoPtr_isValidContextualSelection_Private_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0001A8F0 File Offset: 0x00018AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125284, XrefRangeEnd = 1125289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextualOnActivationSelector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextualOnActivationSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualOnActivationSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x000055DE File Offset: 0x000037DE
		public ContextualOnActivationSelector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x0001A92C File Offset: 0x00018B2C
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x000055E7 File Offset: 0x000037E7
		public unsafe InputContext activeContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextualOnActivationSelector.NativeFieldInfoPtr_activeContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextualOnActivationSelector.NativeFieldInfoPtr_activeContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeFieldInfoPtr_activeContext;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeMethodInfoPtr_GetSelection_Public_Virtual_GameObject_GameObject_0;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr_isValidContextualSelection_Private_Boolean_GameObject_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
