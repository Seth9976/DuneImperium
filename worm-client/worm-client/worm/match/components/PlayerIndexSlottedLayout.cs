using System;
using boardgames.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001B7 RID: 439
	public class PlayerIndexSlottedLayout : MonoBehaviour
	{
		// Token: 0x0600135E RID: 4958 RVA: 0x00052DFC File Offset: 0x00050FFC
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerIndexSlottedLayout()
		{
			Il2CppClassPointerStore<PlayerIndexSlottedLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "PlayerIndexSlottedLayout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerIndexSlottedLayout>.NativeClassPtr);
			PlayerIndexSlottedLayout.NativeFieldInfoPtr_slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerIndexSlottedLayout>.NativeClassPtr, "slots");
			PlayerIndexSlottedLayout.NativeFieldInfoPtr__entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerIndexSlottedLayout>.NativeClassPtr, "_entities");
			PlayerIndexSlottedLayout.NativeMethodInfoPtr_get_entities_Private_get_DBGEntities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerIndexSlottedLayout>.NativeClassPtr, 100665948);
			PlayerIndexSlottedLayout.NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerIndexSlottedLayout>.NativeClassPtr, 100665949);
			PlayerIndexSlottedLayout.NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerIndexSlottedLayout>.NativeClassPtr, 100665950);
			PlayerIndexSlottedLayout.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerIndexSlottedLayout>.NativeClassPtr, 100665951);
			PlayerIndexSlottedLayout.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerIndexSlottedLayout>.NativeClassPtr, 100665952);
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x0600135F RID: 4959 RVA: 0x00052EB8 File Offset: 0x000510B8
		public unsafe DBGEntities entities
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 712903, RefRangeEnd = 712907, XrefRangeStart = 712898, XrefRangeEnd = 712903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerIndexSlottedLayout.NativeMethodInfoPtr_get_entities_Private_get_DBGEntities_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr3) : null;
			}
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x00052EF8 File Offset: 0x000510F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712907, XrefRangeEnd = 712947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Layout(List<UnitView> views)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(views);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerIndexSlottedLayout.NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x00052F3C File Offset: 0x0005113C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712947, XrefRangeEnd = 712966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerIndexSlottedLayout.NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x00052F9C File Offset: 0x0005119C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712966, XrefRangeEnd = 712996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerIndexSlottedLayout.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x00052FD0 File Offset: 0x000511D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712996, XrefRangeEnd = 713004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerIndexSlottedLayout()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerIndexSlottedLayout>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerIndexSlottedLayout.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x0000BFE2 File Offset: 0x0000A1E2
		public PlayerIndexSlottedLayout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001365 RID: 4965 RVA: 0x0005300C File Offset: 0x0005120C
		// (set) Token: 0x06001366 RID: 4966 RVA: 0x0000BFEB File Offset: 0x0000A1EB
		public unsafe List<Transform> slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerIndexSlottedLayout.NativeFieldInfoPtr_slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerIndexSlottedLayout.NativeFieldInfoPtr_slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001367 RID: 4967 RVA: 0x0005303C File Offset: 0x0005123C
		// (set) Token: 0x06001368 RID: 4968 RVA: 0x0000C00A File Offset: 0x0000A20A
		public unsafe DBGEntities _entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerIndexSlottedLayout.NativeFieldInfoPtr__entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerIndexSlottedLayout.NativeFieldInfoPtr__entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B38 RID: 2872
		private static readonly IntPtr NativeFieldInfoPtr_slots;

		// Token: 0x04000B39 RID: 2873
		private static readonly IntPtr NativeFieldInfoPtr__entities;

		// Token: 0x04000B3A RID: 2874
		private static readonly IntPtr NativeMethodInfoPtr_get_entities_Private_get_DBGEntities_0;

		// Token: 0x04000B3B RID: 2875
		private static readonly IntPtr NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0;

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0;

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04000B3E RID: 2878
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
