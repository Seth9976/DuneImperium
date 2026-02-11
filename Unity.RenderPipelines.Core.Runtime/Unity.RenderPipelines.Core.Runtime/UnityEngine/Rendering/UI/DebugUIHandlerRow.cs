using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.UI
{
	// Token: 0x02000134 RID: 308
	public class DebugUIHandlerRow : DebugUIHandlerFoldout
	{
		// Token: 0x06001401 RID: 5121 RVA: 0x00059054 File Offset: 0x00057254
		// Note: this type is marked as 'beforefieldinit'.
		static DebugUIHandlerRow()
		{
			Il2CppClassPointerStore<DebugUIHandlerRow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.UI", "DebugUIHandlerRow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUIHandlerRow>.NativeClassPtr);
			DebugUIHandlerRow.NativeFieldInfoPtr_m_Timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerRow>.NativeClassPtr, "m_Timer");
			DebugUIHandlerRow.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerRow>.NativeClassPtr, 100666181);
			DebugUIHandlerRow.NativeMethodInfoPtr_GetChild_Private_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerRow>.NativeClassPtr, 100666182);
			DebugUIHandlerRow.NativeMethodInfoPtr_TryGetChild_Private_Boolean_Int32_byref_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerRow>.NativeClassPtr, 100666183);
			DebugUIHandlerRow.NativeMethodInfoPtr_IsActive_Private_Boolean_Table_Int32_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerRow>.NativeClassPtr, 100666184);
			DebugUIHandlerRow.NativeMethodInfoPtr_Update_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerRow>.NativeClassPtr, 100666185);
			DebugUIHandlerRow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerRow>.NativeClassPtr, 100666186);
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x00059110 File Offset: 0x00057310
		[CallerCount(0)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerRow.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x0005914C File Offset: 0x0005734C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 981152, RefRangeEnd = 981156, XrefRangeStart = 981137, XrefRangeEnd = 981152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject GetChild(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerRow.NativeMethodInfoPtr_GetChild_Private_GameObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x00059198 File Offset: 0x00057398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 981162, RefRangeEnd = 981163, XrefRangeStart = 981156, XrefRangeEnd = 981162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetChild(int index, out GameObject child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerRow.NativeMethodInfoPtr_TryGetChild_Private_Boolean_Int32_byref_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			child = ((intPtr4 == 0) ? null : new GameObject(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x00059204 File Offset: 0x00057404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981163, XrefRangeEnd = 981176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsActive(DebugUI.Table table, int index, GameObject child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(child);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerRow.NativeMethodInfoPtr_IsActive_Private_Boolean_Table_Int32_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x00059274 File Offset: 0x00057474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981176, XrefRangeEnd = 981272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerRow.NativeMethodInfoPtr_Update_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x000592A8 File Offset: 0x000574A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 979810, RefRangeEnd = 979814, XrefRangeStart = 979810, XrefRangeEnd = 979814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugUIHandlerRow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUIHandlerRow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerRow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x0000A27B File Offset: 0x0000847B
		public DebugUIHandlerRow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001409 RID: 5129 RVA: 0x000592E4 File Offset: 0x000574E4
		// (set) Token: 0x0600140A RID: 5130 RVA: 0x0000A284 File Offset: 0x00008484
		public unsafe float m_Timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerRow.NativeFieldInfoPtr_m_Timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerRow.NativeFieldInfoPtr_m_Timer)) = value;
			}
		}

		// Token: 0x04000ECA RID: 3786
		private static readonly IntPtr NativeFieldInfoPtr_m_Timer;

		// Token: 0x04000ECB RID: 3787
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000ECC RID: 3788
		private static readonly IntPtr NativeMethodInfoPtr_GetChild_Private_GameObject_Int32_0;

		// Token: 0x04000ECD RID: 3789
		private static readonly IntPtr NativeMethodInfoPtr_TryGetChild_Private_Boolean_Int32_byref_GameObject_0;

		// Token: 0x04000ECE RID: 3790
		private static readonly IntPtr NativeMethodInfoPtr_IsActive_Private_Boolean_Table_Int32_GameObject_0;

		// Token: 0x04000ECF RID: 3791
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Void_0;

		// Token: 0x04000ED0 RID: 3792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
