using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.input
{
	// Token: 0x0200012B RID: 299
	public class AlwaysSelectableDragTarget : PointerDragTarget
	{
		// Token: 0x06000D4C RID: 3404 RVA: 0x00047928 File Offset: 0x00045B28
		// Note: this type is marked as 'beforefieldinit'.
		static AlwaysSelectableDragTarget()
		{
			Il2CppClassPointerStore<AlwaysSelectableDragTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.input", "AlwaysSelectableDragTarget");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AlwaysSelectableDragTarget>.NativeClassPtr);
			AlwaysSelectableDragTarget.NativeMethodInfoPtr_GetIsSelectable_Public_Virtual_Boolean_List_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlwaysSelectableDragTarget>.NativeClassPtr, 100665233);
			AlwaysSelectableDragTarget.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlwaysSelectableDragTarget>.NativeClassPtr, 100665234);
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00047980 File Offset: 0x00045B80
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetIsSelectable(List<EntityID> selectableEntities)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectableEntities);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AlwaysSelectableDragTarget.NativeMethodInfoPtr_GetIsSelectable_Public_Virtual_Boolean_List_1_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x000479D8 File Offset: 0x00045BD8
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AlwaysSelectableDragTarget()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AlwaysSelectableDragTarget>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AlwaysSelectableDragTarget.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00008707 File Offset: 0x00006907
		public AlwaysSelectableDragTarget(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeMethodInfoPtr_GetIsSelectable_Public_Virtual_Boolean_List_1_EntityID_0;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
