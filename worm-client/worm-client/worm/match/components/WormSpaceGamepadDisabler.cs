using System;
using boardgames.match.behaviours;
using boardgames.match.selection;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x02000218 RID: 536
	public class WormSpaceGamepadDisabler : VersionedView<DBGSelectionResponder>
	{
		// Token: 0x06001793 RID: 6035 RVA: 0x0005F9CC File Offset: 0x0005DBCC
		// Note: this type is marked as 'beforefieldinit'.
		static WormSpaceGamepadDisabler()
		{
			Il2CppClassPointerStore<WormSpaceGamepadDisabler>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormSpaceGamepadDisabler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSpaceGamepadDisabler>.NativeClassPtr);
			WormSpaceGamepadDisabler.NativeFieldInfoPtr_gamepadSelectables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpaceGamepadDisabler>.NativeClassPtr, "gamepadSelectables");
			WormSpaceGamepadDisabler.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpaceGamepadDisabler>.NativeClassPtr, "entitiesProvider");
			WormSpaceGamepadDisabler.NativeFieldInfoPtr_spaceView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpaceGamepadDisabler>.NativeClassPtr, "spaceView");
			WormSpaceGamepadDisabler.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpaceGamepadDisabler>.NativeClassPtr, 100666578);
			WormSpaceGamepadDisabler.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpaceGamepadDisabler>.NativeClassPtr, 100666579);
			WormSpaceGamepadDisabler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpaceGamepadDisabler>.NativeClassPtr, 100666580);
			WormSpaceGamepadDisabler.NativeMethodInfoPtr__dirtyUpdate_b__4_0_Private_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpaceGamepadDisabler>.NativeClassPtr, 100666581);
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x0005FA88 File Offset: 0x0005DC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717584, XrefRangeEnd = 717598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSpaceGamepadDisabler.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x0005FAC4 File Offset: 0x0005DCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717598, XrefRangeEnd = 717619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSpaceGamepadDisabler.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x0005FB00 File Offset: 0x0005DD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717619, XrefRangeEnd = 717626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSpaceGamepadDisabler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSpaceGamepadDisabler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpaceGamepadDisabler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x0005FB3C File Offset: 0x0005DD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717626, XrefRangeEnd = 717630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _dirtyUpdate_b__4_0(EntityID s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpaceGamepadDisabler.NativeMethodInfoPtr__dirtyUpdate_b__4_0_Private_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x0000E127 File Offset: 0x0000C327
		public WormSpaceGamepadDisabler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06001799 RID: 6041 RVA: 0x0005FB8C File Offset: 0x0005DD8C
		// (set) Token: 0x0600179A RID: 6042 RVA: 0x0000E130 File Offset: 0x0000C330
		public unsafe Il2CppReferenceArray<GameObject> gamepadSelectables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpaceGamepadDisabler.NativeFieldInfoPtr_gamepadSelectables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpaceGamepadDisabler.NativeFieldInfoPtr_gamepadSelectables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x0600179B RID: 6043 RVA: 0x0005FBBC File Offset: 0x0005DDBC
		// (set) Token: 0x0600179C RID: 6044 RVA: 0x0000E14F File Offset: 0x0000C34F
		public unsafe DBGEntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpaceGamepadDisabler.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpaceGamepadDisabler.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x0600179D RID: 6045 RVA: 0x0005FBEC File Offset: 0x0005DDEC
		// (set) Token: 0x0600179E RID: 6046 RVA: 0x0000E16E File Offset: 0x0000C36E
		public unsafe EntityView spaceView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpaceGamepadDisabler.NativeFieldInfoPtr_spaceView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpaceGamepadDisabler.NativeFieldInfoPtr_spaceView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DAB RID: 3499
		private static readonly IntPtr NativeFieldInfoPtr_gamepadSelectables;

		// Token: 0x04000DAC RID: 3500
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x04000DAD RID: 3501
		private static readonly IntPtr NativeFieldInfoPtr_spaceView;

		// Token: 0x04000DAE RID: 3502
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000DAF RID: 3503
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000DB0 RID: 3504
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000DB1 RID: 3505
		private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__4_0_Private_Boolean_EntityID_0;
	}
}
