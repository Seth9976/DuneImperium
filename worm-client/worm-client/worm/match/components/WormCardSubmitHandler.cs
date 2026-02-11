using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace worm.match.components
{
	// Token: 0x020001D8 RID: 472
	public class WormCardSubmitHandler : MonoBehaviour
	{
		// Token: 0x060014E0 RID: 5344 RVA: 0x00057824 File Offset: 0x00055A24
		// Note: this type is marked as 'beforefieldinit'.
		static WormCardSubmitHandler()
		{
			Il2CppClassPointerStore<WormCardSubmitHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormCardSubmitHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCardSubmitHandler>.NativeClassPtr);
			WormCardSubmitHandler.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCardSubmitHandler>.NativeClassPtr, "card");
			WormCardSubmitHandler.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardSubmitHandler>.NativeClassPtr, 100666158);
			WormCardSubmitHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardSubmitHandler>.NativeClassPtr, 100666159);
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x00057890 File Offset: 0x00055A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714537, XrefRangeEnd = 714544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSubmit(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCardSubmitHandler.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x000578D4 File Offset: 0x00055AD4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormCardSubmitHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCardSubmitHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCardSubmitHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x0000CBE9 File Offset: 0x0000ADE9
		public WormCardSubmitHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x060014E4 RID: 5348 RVA: 0x00057910 File Offset: 0x00055B10
		// (set) Token: 0x060014E5 RID: 5349 RVA: 0x0000CBF2 File Offset: 0x0000ADF2
		public unsafe WormDraggableCard card
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardSubmitHandler.NativeFieldInfoPtr_card);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormDraggableCard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardSubmitHandler.NativeFieldInfoPtr_card), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeFieldInfoPtr_card;

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0;

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
