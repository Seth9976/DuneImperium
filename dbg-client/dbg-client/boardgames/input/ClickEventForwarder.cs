using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace boardgames.input
{
	// Token: 0x0200012F RID: 303
	public class ClickEventForwarder : MonoBehaviour
	{
		// Token: 0x06000D6D RID: 3437 RVA: 0x00047F94 File Offset: 0x00046194
		// Note: this type is marked as 'beforefieldinit'.
		static ClickEventForwarder()
		{
			Il2CppClassPointerStore<ClickEventForwarder>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.input", "ClickEventForwarder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClickEventForwarder>.NativeClassPtr);
			ClickEventForwarder.NativeFieldInfoPtr_parentHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickEventForwarder>.NativeClassPtr, "parentHandler");
			ClickEventForwarder.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickEventForwarder>.NativeClassPtr, 100665246);
			ClickEventForwarder.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickEventForwarder>.NativeClassPtr, 100665247);
			ClickEventForwarder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickEventForwarder>.NativeClassPtr, 100665248);
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x00048014 File Offset: 0x00046214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510801, XrefRangeEnd = 510813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickEventForwarder.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x00048048 File Offset: 0x00046248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510813, XrefRangeEnd = 510816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickEventForwarder.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x0004808C File Offset: 0x0004628C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClickEventForwarder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClickEventForwarder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickEventForwarder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x000087D5 File Offset: 0x000069D5
		public ClickEventForwarder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x000480C8 File Offset: 0x000462C8
		// (set) Token: 0x06000D73 RID: 3443 RVA: 0x000087DE File Offset: 0x000069DE
		public unsafe IPointerClickHandler parentHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickEventForwarder.NativeFieldInfoPtr_parentHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPointerClickHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickEventForwarder.NativeFieldInfoPtr_parentHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeFieldInfoPtr_parentHandler;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
