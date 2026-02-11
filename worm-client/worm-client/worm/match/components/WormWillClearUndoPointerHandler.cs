using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.EventSystems;

namespace worm.match.components
{
	// Token: 0x02000223 RID: 547
	public class WormWillClearUndoPointerHandler : WormWillClearUndoCursorHandler
	{
		// Token: 0x060017FC RID: 6140 RVA: 0x00060DB8 File Offset: 0x0005EFB8
		// Note: this type is marked as 'beforefieldinit'.
		static WormWillClearUndoPointerHandler()
		{
			Il2CppClassPointerStore<WormWillClearUndoPointerHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormWillClearUndoPointerHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormWillClearUndoPointerHandler>.NativeClassPtr);
			WormWillClearUndoPointerHandler.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoPointerHandler>.NativeClassPtr, 100666623);
			WormWillClearUndoPointerHandler.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoPointerHandler>.NativeClassPtr, 100666624);
			WormWillClearUndoPointerHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoPointerHandler>.NativeClassPtr, 100666625);
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x00060E24 File Offset: 0x0005F024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717875, XrefRangeEnd = 717876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerEnter(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoPointerHandler.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x00060E68 File Offset: 0x0005F068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717876, XrefRangeEnd = 717877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerExit(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoPointerHandler.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x00060EAC File Offset: 0x0005F0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717877, XrefRangeEnd = 717878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormWillClearUndoPointerHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormWillClearUndoPointerHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoPointerHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x0000E474 File Offset: 0x0000C674
		public WormWillClearUndoPointerHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DE8 RID: 3560
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04000DE9 RID: 3561
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04000DEA RID: 3562
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
