using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace dwd.canis.dbg_client.input
{
	// Token: 0x02000074 RID: 116
	public class ScrollRectDragPassthrough : MonoBehaviour
	{
		// Token: 0x06000453 RID: 1107 RVA: 0x0002B04C File Offset: 0x0002924C
		// Note: this type is marked as 'beforefieldinit'.
		static ScrollRectDragPassthrough()
		{
			Il2CppClassPointerStore<ScrollRectDragPassthrough>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.dbg_client.input", "ScrollRectDragPassthrough");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollRectDragPassthrough>.NativeClassPtr);
			ScrollRectDragPassthrough.NativeFieldInfoPtr_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectDragPassthrough>.NativeClassPtr, "scrollRect");
			ScrollRectDragPassthrough.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectDragPassthrough>.NativeClassPtr, 100663935);
			ScrollRectDragPassthrough.NativeMethodInfoPtr_OnBeginDragPassthrough_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectDragPassthrough>.NativeClassPtr, 100663936);
			ScrollRectDragPassthrough.NativeMethodInfoPtr_OnUpdateDragPassthrough_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectDragPassthrough>.NativeClassPtr, 100663937);
			ScrollRectDragPassthrough.NativeMethodInfoPtr_OnEndDragPassthrough_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectDragPassthrough>.NativeClassPtr, 100663938);
			ScrollRectDragPassthrough.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectDragPassthrough>.NativeClassPtr, 100663939);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0002B0F4 File Offset: 0x000292F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500553, XrefRangeEnd = 500557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectDragPassthrough.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0002B128 File Offset: 0x00029328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500557, XrefRangeEnd = 500558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeginDragPassthrough(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectDragPassthrough.NativeMethodInfoPtr_OnBeginDragPassthrough_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0002B16C File Offset: 0x0002936C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500558, XrefRangeEnd = 500559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnUpdateDragPassthrough(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectDragPassthrough.NativeMethodInfoPtr_OnUpdateDragPassthrough_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0002B1B0 File Offset: 0x000293B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500559, XrefRangeEnd = 500560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEndDragPassthrough(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectDragPassthrough.NativeMethodInfoPtr_OnEndDragPassthrough_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0002B1F4 File Offset: 0x000293F4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScrollRectDragPassthrough()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollRectDragPassthrough>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectDragPassthrough.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00003F53 File Offset: 0x00002153
		public ScrollRectDragPassthrough(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x0002B230 File Offset: 0x00029430
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x00003F5C File Offset: 0x0000215C
		public unsafe ScrollRect scrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectDragPassthrough.NativeFieldInfoPtr_scrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectDragPassthrough.NativeFieldInfoPtr_scrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeFieldInfoPtr_scrollRect;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginDragPassthrough_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdateDragPassthrough_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeMethodInfoPtr_OnEndDragPassthrough_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
