using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace lib.canis.dbg_client.dataRenderers
{
	// Token: 0x02000039 RID: 57
	public class AnimatedWaitingForPlayersSlotRenderer : VersionedSubscriber<PlayerTypeData>
	{
		// Token: 0x06000247 RID: 583 RVA: 0x00024D8C File Offset: 0x00022F8C
		// Note: this type is marked as 'beforefieldinit'.
		static AnimatedWaitingForPlayersSlotRenderer()
		{
			Il2CppClassPointerStore<AnimatedWaitingForPlayersSlotRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.dbg_client.dataRenderers", "AnimatedWaitingForPlayersSlotRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatedWaitingForPlayersSlotRenderer>.NativeClassPtr);
			AnimatedWaitingForPlayersSlotRenderer.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatedWaitingForPlayersSlotRenderer>.NativeClassPtr, "animator");
			AnimatedWaitingForPlayersSlotRenderer.NativeFieldInfoPtr_openParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatedWaitingForPlayersSlotRenderer>.NativeClassPtr, "openParameter");
			AnimatedWaitingForPlayersSlotRenderer.NativeFieldInfoPtr_disabledParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatedWaitingForPlayersSlotRenderer>.NativeClassPtr, "disabledParameter");
			AnimatedWaitingForPlayersSlotRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedWaitingForPlayersSlotRenderer>.NativeClassPtr, 100663669);
			AnimatedWaitingForPlayersSlotRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedWaitingForPlayersSlotRenderer>.NativeClassPtr, 100663670);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00024E20 File Offset: 0x00023020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498309, XrefRangeEnd = 498315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimatedWaitingForPlayersSlotRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00024E5C File Offset: 0x0002305C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498315, XrefRangeEnd = 498326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimatedWaitingForPlayersSlotRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatedWaitingForPlayersSlotRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedWaitingForPlayersSlotRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002FB3 File Offset: 0x000011B3
		public AnimatedWaitingForPlayersSlotRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00024E98 File Offset: 0x00023098
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00002FBC File Offset: 0x000011BC
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedWaitingForPlayersSlotRenderer.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedWaitingForPlayersSlotRenderer.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00024EC8 File Offset: 0x000230C8
		// (set) Token: 0x0600024E RID: 590 RVA: 0x00002FDB File Offset: 0x000011DB
		public unsafe string openParameter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedWaitingForPlayersSlotRenderer.NativeFieldInfoPtr_openParameter);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedWaitingForPlayersSlotRenderer.NativeFieldInfoPtr_openParameter), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00024EF0 File Offset: 0x000230F0
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00002FFA File Offset: 0x000011FA
		public unsafe string disabledParameter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedWaitingForPlayersSlotRenderer.NativeFieldInfoPtr_disabledParameter);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedWaitingForPlayersSlotRenderer.NativeFieldInfoPtr_disabledParameter), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeFieldInfoPtr_openParameter;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeFieldInfoPtr_disabledParameter;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
