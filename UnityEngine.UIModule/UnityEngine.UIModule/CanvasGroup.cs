using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	public sealed class CanvasGroup : Behaviour
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002214 File Offset: 0x00000414
		// Note: this type is marked as 'beforefieldinit'.
		static CanvasGroup()
		{
			Il2CppClassPointerStore<CanvasGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIModule.dll", "UnityEngine", "CanvasGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasGroup>.NativeClassPtr);
			CanvasGroup.NativeMethodInfoPtr_get_alpha_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroup>.NativeClassPtr, 100663298);
			CanvasGroup.NativeMethodInfoPtr_set_alpha_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroup>.NativeClassPtr, 100663299);
			CanvasGroup.NativeMethodInfoPtr_get_interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroup>.NativeClassPtr, 100663300);
			CanvasGroup.NativeMethodInfoPtr_set_interactable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroup>.NativeClassPtr, 100663301);
			CanvasGroup.NativeMethodInfoPtr_get_blocksRaycasts_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroup>.NativeClassPtr, 100663302);
			CanvasGroup.NativeMethodInfoPtr_set_blocksRaycasts_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroup>.NativeClassPtr, 100663303);
			CanvasGroup.NativeMethodInfoPtr_get_ignoreParentGroups_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroup>.NativeClassPtr, 100663304);
			CanvasGroup.NativeMethodInfoPtr_set_ignoreParentGroups_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroup>.NativeClassPtr, 100663305);
			CanvasGroup.NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_Final_New_Boolean_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroup>.NativeClassPtr, 100663306);
			CanvasGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroup>.NativeClassPtr, 100663307);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000230C File Offset: 0x0000050C
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002348 File Offset: 0x00000548
		public unsafe float alpha
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 1256307, RefRangeEnd = 1256321, XrefRangeStart = 1256305, XrefRangeEnd = 1256307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroup.NativeMethodInfoPtr_get_alpha_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 1256323, RefRangeEnd = 1256344, XrefRangeStart = 1256321, XrefRangeEnd = 1256323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroup.NativeMethodInfoPtr_set_alpha_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002388 File Offset: 0x00000588
		// (set) Token: 0x06000008 RID: 8 RVA: 0x000023C4 File Offset: 0x000005C4
		public unsafe bool interactable
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1256346, RefRangeEnd = 1256351, XrefRangeStart = 1256344, XrefRangeEnd = 1256346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroup.NativeMethodInfoPtr_get_interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1256353, RefRangeEnd = 1256361, XrefRangeStart = 1256351, XrefRangeEnd = 1256353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroup.NativeMethodInfoPtr_set_interactable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002404 File Offset: 0x00000604
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002440 File Offset: 0x00000640
		public unsafe bool blocksRaycasts
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1256363, RefRangeEnd = 1256365, XrefRangeStart = 1256361, XrefRangeEnd = 1256363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroup.NativeMethodInfoPtr_get_blocksRaycasts_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1256367, RefRangeEnd = 1256374, XrefRangeStart = 1256365, XrefRangeEnd = 1256367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroup.NativeMethodInfoPtr_set_blocksRaycasts_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002480 File Offset: 0x00000680
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000024BC File Offset: 0x000006BC
		public unsafe bool ignoreParentGroups
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1256376, RefRangeEnd = 1256378, XrefRangeStart = 1256374, XrefRangeEnd = 1256376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroup.NativeMethodInfoPtr_get_ignoreParentGroups_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1256380, RefRangeEnd = 1256381, XrefRangeStart = 1256378, XrefRangeEnd = 1256380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroup.NativeMethodInfoPtr_set_ignoreParentGroups_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000024FC File Offset: 0x000006FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1256363, RefRangeEnd = 1256365, XrefRangeStart = 1256363, XrefRangeEnd = 1256365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventCamera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroup.NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_Final_New_Boolean_Vector2_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002558 File Offset: 0x00000758
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanvasGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002088 File Offset: 0x00000288
		public CanvasGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_get_alpha_Public_get_Single_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_set_alpha_Public_set_Void_Single_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_get_interactable_Public_get_Boolean_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_set_interactable_Public_set_Void_Boolean_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_get_blocksRaycasts_Public_get_Boolean_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_set_blocksRaycasts_Public_set_Void_Boolean_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreParentGroups_Public_get_Boolean_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_set_ignoreParentGroups_Public_set_Void_Boolean_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_Final_New_Boolean_Vector2_Camera_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
