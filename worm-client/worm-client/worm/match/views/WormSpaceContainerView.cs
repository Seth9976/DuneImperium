using System;
using boardgames.match.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace worm.match.views
{
	// Token: 0x020000AF RID: 175
	public class WormSpaceContainerView : ContainerView
	{
		// Token: 0x060006C6 RID: 1734 RVA: 0x0002D4CC File Offset: 0x0002B6CC
		// Note: this type is marked as 'beforefieldinit'.
		static WormSpaceContainerView()
		{
			Il2CppClassPointerStore<WormSpaceContainerView>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.views", "WormSpaceContainerView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSpaceContainerView>.NativeClassPtr);
			WormSpaceContainerView.NativeFieldInfoPtr_agentTransformAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpaceContainerView>.NativeClassPtr, "agentTransformAnchor");
			WormSpaceContainerView.NativeFieldInfoPtr_controlMarkerAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpaceContainerView>.NativeClassPtr, "controlMarkerAnchor");
			WormSpaceContainerView.NativeFieldInfoPtr_unClaimedAgentTransformAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpaceContainerView>.NativeClassPtr, "unClaimedAgentTransformAnchor");
			WormSpaceContainerView.NativeFieldInfoPtr_hagalRivalsSwordmasterAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpaceContainerView>.NativeClassPtr, "hagalRivalsSwordmasterAnchor");
			WormSpaceContainerView.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpaceContainerView>.NativeClassPtr, "entitiesProvider");
			WormSpaceContainerView.NativeMethodInfoPtr_ContainerForViewAndSlot_Public_Virtual_Transform_UnitView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpaceContainerView>.NativeClassPtr, 100664242);
			WormSpaceContainerView.NativeMethodInfoPtr_RemoveView_Public_Virtual_Void_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpaceContainerView>.NativeClassPtr, 100664243);
			WormSpaceContainerView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpaceContainerView>.NativeClassPtr, 100664244);
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0002D59C File Offset: 0x0002B79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696770, XrefRangeEnd = 696798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Transform ContainerForViewAndSlot(UnitView view, int slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSpaceContainerView.NativeMethodInfoPtr_ContainerForViewAndSlot_Public_Virtual_Transform_UnitView_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x0002D608 File Offset: 0x0002B808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696798, XrefRangeEnd = 696799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RemoveView(UnitView view)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSpaceContainerView.NativeMethodInfoPtr_RemoveView_Public_Virtual_Void_UnitView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0002D658 File Offset: 0x0002B858
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 690714, RefRangeEnd = 690716, XrefRangeStart = 690714, XrefRangeEnd = 690716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSpaceContainerView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSpaceContainerView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpaceContainerView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00005683 File Offset: 0x00003883
		public WormSpaceContainerView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x0002D694 File Offset: 0x0002B894
		// (set) Token: 0x060006CC RID: 1740 RVA: 0x0000568C File Offset: 0x0000388C
		public unsafe Transform agentTransformAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpaceContainerView.NativeFieldInfoPtr_agentTransformAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpaceContainerView.NativeFieldInfoPtr_agentTransformAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x0002D6C4 File Offset: 0x0002B8C4
		// (set) Token: 0x060006CE RID: 1742 RVA: 0x000056AB File Offset: 0x000038AB
		public unsafe Transform controlMarkerAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpaceContainerView.NativeFieldInfoPtr_controlMarkerAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpaceContainerView.NativeFieldInfoPtr_controlMarkerAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x0002D6F4 File Offset: 0x0002B8F4
		// (set) Token: 0x060006D0 RID: 1744 RVA: 0x000056CA File Offset: 0x000038CA
		public unsafe Transform unClaimedAgentTransformAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpaceContainerView.NativeFieldInfoPtr_unClaimedAgentTransformAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpaceContainerView.NativeFieldInfoPtr_unClaimedAgentTransformAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x0002D724 File Offset: 0x0002B924
		// (set) Token: 0x060006D2 RID: 1746 RVA: 0x000056E9 File Offset: 0x000038E9
		public unsafe Transform hagalRivalsSwordmasterAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpaceContainerView.NativeFieldInfoPtr_hagalRivalsSwordmasterAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpaceContainerView.NativeFieldInfoPtr_hagalRivalsSwordmasterAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x0002D754 File Offset: 0x0002B954
		// (set) Token: 0x060006D4 RID: 1748 RVA: 0x00005708 File Offset: 0x00003908
		public unsafe DBGEntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpaceContainerView.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpaceContainerView.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeFieldInfoPtr_agentTransformAnchor;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeFieldInfoPtr_controlMarkerAnchor;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeFieldInfoPtr_unClaimedAgentTransformAnchor;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeFieldInfoPtr_hagalRivalsSwordmasterAnchor;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_ContainerForViewAndSlot_Public_Virtual_Transform_UnitView_Int32_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr_RemoveView_Public_Virtual_Void_UnitView_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
