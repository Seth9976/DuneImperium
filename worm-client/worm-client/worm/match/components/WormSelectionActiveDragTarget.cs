using System;
using boardgames.input;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x0200020F RID: 527
	public class WormSelectionActiveDragTarget : AlwaysSelectableDragTarget
	{
		// Token: 0x06001752 RID: 5970 RVA: 0x0005ED24 File Offset: 0x0005CF24
		// Note: this type is marked as 'beforefieldinit'.
		static WormSelectionActiveDragTarget()
		{
			Il2CppClassPointerStore<WormSelectionActiveDragTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormSelectionActiveDragTarget");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectionActiveDragTarget>.NativeClassPtr);
			WormSelectionActiveDragTarget.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectionActiveDragTarget>.NativeClassPtr, "anim");
			WormSelectionActiveDragTarget.NativeFieldInfoPtr_trigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectionActiveDragTarget>.NativeClassPtr, "trigger");
			WormSelectionActiveDragTarget.NativeMethodInfoPtr_HandleDropOnTarget_Public_Virtual_Boolean_DraggableCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectionActiveDragTarget>.NativeClassPtr, 100666543);
			WormSelectionActiveDragTarget.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectionActiveDragTarget>.NativeClassPtr, 100666544);
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x0005EDA4 File Offset: 0x0005CFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717365, XrefRangeEnd = 717368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HandleDropOnTarget(DraggableCard draggableCard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(draggableCard);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectionActiveDragTarget.NativeMethodInfoPtr_HandleDropOnTarget_Public_Virtual_Boolean_DraggableCard_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x0005EDFC File Offset: 0x0005CFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717368, XrefRangeEnd = 717372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectionActiveDragTarget()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectionActiveDragTarget>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectionActiveDragTarget.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x0000DF62 File Offset: 0x0000C162
		public WormSelectionActiveDragTarget(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001756 RID: 5974 RVA: 0x0005EE38 File Offset: 0x0005D038
		// (set) Token: 0x06001757 RID: 5975 RVA: 0x0000DF6B File Offset: 0x0000C16B
		public unsafe Animator anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectionActiveDragTarget.NativeFieldInfoPtr_anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectionActiveDragTarget.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001758 RID: 5976 RVA: 0x0005EE68 File Offset: 0x0005D068
		// (set) Token: 0x06001759 RID: 5977 RVA: 0x0000DF8A File Offset: 0x0000C18A
		public unsafe string trigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectionActiveDragTarget.NativeFieldInfoPtr_trigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectionActiveDragTarget.NativeFieldInfoPtr_trigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000D88 RID: 3464
		private static readonly IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x04000D89 RID: 3465
		private static readonly IntPtr NativeFieldInfoPtr_trigger;

		// Token: 0x04000D8A RID: 3466
		private static readonly IntPtr NativeMethodInfoPtr_HandleDropOnTarget_Public_Virtual_Boolean_DraggableCard_0;

		// Token: 0x04000D8B RID: 3467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
