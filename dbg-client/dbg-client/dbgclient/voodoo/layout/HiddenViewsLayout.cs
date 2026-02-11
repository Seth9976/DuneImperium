using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;

namespace dbgclient.voodoo.layout
{
	// Token: 0x02000089 RID: 137
	public class HiddenViewsLayout : MonoBehaviour
	{
		// Token: 0x06000550 RID: 1360 RVA: 0x0002E53C File Offset: 0x0002C73C
		// Note: this type is marked as 'beforefieldinit'.
		static HiddenViewsLayout()
		{
			Il2CppClassPointerStore<HiddenViewsLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.voodoo.layout", "HiddenViewsLayout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HiddenViewsLayout>.NativeClassPtr);
			HiddenViewsLayout.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HiddenViewsLayout>.NativeClassPtr, 100664108);
			HiddenViewsLayout.NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HiddenViewsLayout>.NativeClassPtr, 100664109);
			HiddenViewsLayout.NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HiddenViewsLayout>.NativeClassPtr, 100664110);
			HiddenViewsLayout.NativeMethodInfoPtr_OnViewsRemoved_Public_Virtual_Final_New_Void_List_1_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HiddenViewsLayout>.NativeClassPtr, 100664111);
			HiddenViewsLayout.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HiddenViewsLayout>.NativeClassPtr, 100664112);
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0002E5D0 File Offset: 0x0002C7D0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HiddenViewsLayout.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0002E604 File Offset: 0x0002C804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501694, XrefRangeEnd = 501718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Layout(List<UnitView> views)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(views);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HiddenViewsLayout.NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0002E648 File Offset: 0x0002C848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Transform GetSlotFor(UnitView view, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HiddenViewsLayout.NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0002E6A8 File Offset: 0x0002C8A8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnViewsRemoved(List<UnitView> views)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(views);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HiddenViewsLayout.NativeMethodInfoPtr_OnViewsRemoved_Public_Virtual_Final_New_Void_List_1_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0002E6EC File Offset: 0x0002C8EC
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HiddenViewsLayout()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HiddenViewsLayout>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HiddenViewsLayout.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0000469C File Offset: 0x0000289C
		public HiddenViewsLayout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_OnViewsRemoved_Public_Virtual_Final_New_Void_List_1_UnitView_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
