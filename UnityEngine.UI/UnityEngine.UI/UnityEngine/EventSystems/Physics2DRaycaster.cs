using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000071 RID: 113
	public class Physics2DRaycaster : PhysicsRaycaster
	{
		// Token: 0x06000B55 RID: 2901 RVA: 0x000332B0 File Offset: 0x000314B0
		// Note: this type is marked as 'beforefieldinit'.
		static Physics2DRaycaster()
		{
			Il2CppClassPointerStore<Physics2DRaycaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "Physics2DRaycaster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Physics2DRaycaster>.NativeClassPtr);
			Physics2DRaycaster.NativeFieldInfoPtr_m_Hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Physics2DRaycaster>.NativeClassPtr, "m_Hits");
			Physics2DRaycaster.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2DRaycaster>.NativeClassPtr, 100665162);
			Physics2DRaycaster.NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2DRaycaster>.NativeClassPtr, 100665163);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x0003331C File Offset: 0x0003151C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097595, XrefRangeEnd = 1097597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Physics2DRaycaster()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Physics2DRaycaster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2DRaycaster.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00033358 File Offset: 0x00031558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097597, XrefRangeEnd = 1097664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultAppendList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Physics2DRaycaster.NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00005FF8 File Offset: 0x000041F8
		public Physics2DRaycaster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x000333B8 File Offset: 0x000315B8
		// (set) Token: 0x06000B5A RID: 2906 RVA: 0x00006001 File Offset: 0x00004201
		public new unsafe Il2CppStructArray<RaycastHit2D> m_Hits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Physics2DRaycaster.NativeFieldInfoPtr_m_Hits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Physics2DRaycaster.NativeFieldInfoPtr_m_Hits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeFieldInfoPtr_m_Hits;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0;
	}
}
