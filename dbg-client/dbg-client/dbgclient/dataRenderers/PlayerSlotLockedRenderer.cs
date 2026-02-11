using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dbgclient.dataRenderers
{
	// Token: 0x020000BD RID: 189
	public class PlayerSlotLockedRenderer : VersionedSubscriber<PlayerSlotLockData>
	{
		// Token: 0x060007B7 RID: 1975 RVA: 0x00035B10 File Offset: 0x00033D10
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerSlotLockedRenderer()
		{
			Il2CppClassPointerStore<PlayerSlotLockedRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.dataRenderers", "PlayerSlotLockedRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSlotLockedRenderer>.NativeClassPtr);
			PlayerSlotLockedRenderer.NativeFieldInfoPtr_objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSlotLockedRenderer>.NativeClassPtr, "objects");
			PlayerSlotLockedRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSlotLockedRenderer>.NativeClassPtr, 100664456);
			PlayerSlotLockedRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSlotLockedRenderer>.NativeClassPtr, 100664457);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00035B7C File Offset: 0x00033D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504520, XrefRangeEnd = 504523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerSlotLockedRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00035BB8 File Offset: 0x00033DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504523, XrefRangeEnd = 504530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerSlotLockedRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSlotLockedRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSlotLockedRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00005986 File Offset: 0x00003B86
		public PlayerSlotLockedRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x00035BF4 File Offset: 0x00033DF4
		// (set) Token: 0x060007BC RID: 1980 RVA: 0x0000598F File Offset: 0x00003B8F
		public unsafe Il2CppReferenceArray<GameObject> objects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSlotLockedRenderer.NativeFieldInfoPtr_objects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSlotLockedRenderer.NativeFieldInfoPtr_objects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeFieldInfoPtr_objects;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
