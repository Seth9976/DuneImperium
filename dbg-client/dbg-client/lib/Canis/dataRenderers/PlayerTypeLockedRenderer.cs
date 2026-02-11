using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;

namespace lib.canis.dataRenderers
{
	// Token: 0x02000030 RID: 48
	public class PlayerTypeLockedRenderer : VersionedSubscriber<PlayerSlotLockData>
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x000233F4 File Offset: 0x000215F4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerTypeLockedRenderer()
		{
			Il2CppClassPointerStore<PlayerTypeLockedRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.dataRenderers", "PlayerTypeLockedRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerTypeLockedRenderer>.NativeClassPtr);
			PlayerTypeLockedRenderer.NativeFieldInfoPtr_EventForPlayerTypeLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTypeLockedRenderer>.NativeClassPtr, "EventForPlayerTypeLocked");
			PlayerTypeLockedRenderer.NativeFieldInfoPtr_EventForPlayerTypeUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTypeLockedRenderer>.NativeClassPtr, "EventForPlayerTypeUnlocked");
			PlayerTypeLockedRenderer.NativeFieldInfoPtr_OnPlayerTypeLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTypeLockedRenderer>.NativeClassPtr, "OnPlayerTypeLocked");
			PlayerTypeLockedRenderer.NativeFieldInfoPtr_OnPlayerTypeUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTypeLockedRenderer>.NativeClassPtr, "OnPlayerTypeUnlocked");
			PlayerTypeLockedRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTypeLockedRenderer>.NativeClassPtr, 100663596);
			PlayerTypeLockedRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTypeLockedRenderer>.NativeClassPtr, 100663597);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0002349C File Offset: 0x0002169C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497878, XrefRangeEnd = 497885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerTypeLockedRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000234D8 File Offset: 0x000216D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497885, XrefRangeEnd = 497909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerTypeLockedRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTypeLockedRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTypeLockedRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002BCD File Offset: 0x00000DCD
		public PlayerTypeLockedRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00023514 File Offset: 0x00021714
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00002BD6 File Offset: 0x00000DD6
		public unsafe UnityEvent<bool> EventForPlayerTypeLocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTypeLockedRenderer.NativeFieldInfoPtr_EventForPlayerTypeLocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTypeLockedRenderer.NativeFieldInfoPtr_EventForPlayerTypeLocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00023544 File Offset: 0x00021744
		// (set) Token: 0x060001CC RID: 460 RVA: 0x00002BF5 File Offset: 0x00000DF5
		public unsafe UnityEvent<bool> EventForPlayerTypeUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTypeLockedRenderer.NativeFieldInfoPtr_EventForPlayerTypeUnlocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTypeLockedRenderer.NativeFieldInfoPtr_EventForPlayerTypeUnlocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00023574 File Offset: 0x00021774
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00002C14 File Offset: 0x00000E14
		public unsafe UnityEvent OnPlayerTypeLocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTypeLockedRenderer.NativeFieldInfoPtr_OnPlayerTypeLocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTypeLockedRenderer.NativeFieldInfoPtr_OnPlayerTypeLocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001CF RID: 463 RVA: 0x000235A4 File Offset: 0x000217A4
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x00002C33 File Offset: 0x00000E33
		public unsafe UnityEvent OnPlayerTypeUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTypeLockedRenderer.NativeFieldInfoPtr_OnPlayerTypeUnlocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTypeLockedRenderer.NativeFieldInfoPtr_OnPlayerTypeUnlocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeFieldInfoPtr_EventForPlayerTypeLocked;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeFieldInfoPtr_EventForPlayerTypeUnlocked;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeFieldInfoPtr_OnPlayerTypeLocked;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeFieldInfoPtr_OnPlayerTypeUnlocked;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
