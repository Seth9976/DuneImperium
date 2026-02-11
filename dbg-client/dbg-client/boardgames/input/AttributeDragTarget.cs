using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.input
{
	// Token: 0x0200012C RID: 300
	public class AttributeDragTarget : PointerDragTarget
	{
		// Token: 0x06000D50 RID: 3408 RVA: 0x00047A14 File Offset: 0x00045C14
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeDragTarget()
		{
			Il2CppClassPointerStore<AttributeDragTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.input", "AttributeDragTarget");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeDragTarget>.NativeClassPtr);
			AttributeDragTarget.NativeMethodInfoPtr_GetIsSelectable_Public_Virtual_Boolean_List_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDragTarget>.NativeClassPtr, 100665235);
			AttributeDragTarget.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDragTarget>.NativeClassPtr, 100665236);
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00047A6C File Offset: 0x00045C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510739, XrefRangeEnd = 510746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetIsSelectable(List<EntityID> selectableEntities)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectableEntities);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeDragTarget.NativeMethodInfoPtr_GetIsSelectable_Public_Virtual_Boolean_List_1_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00047AC4 File Offset: 0x00045CC4
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeDragTarget()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeDragTarget>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeDragTarget.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x00008710 File Offset: 0x00006910
		public AttributeDragTarget(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeMethodInfoPtr_GetIsSelectable_Public_Virtual_Boolean_List_1_EntityID_0;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
