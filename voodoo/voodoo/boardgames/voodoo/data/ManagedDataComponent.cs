using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;

namespace boardgames.voodoo.data
{
	// Token: 0x020000A0 RID: 160
	public class ManagedDataComponent : DataComponent
	{
		// Token: 0x06000945 RID: 2373 RVA: 0x0002834C File Offset: 0x0002654C
		// Note: this type is marked as 'beforefieldinit'.
		static ManagedDataComponent()
		{
			Il2CppClassPointerStore<ManagedDataComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "boardgames.voodoo.data", "ManagedDataComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedDataComponent>.NativeClassPtr);
			ManagedDataComponent.NativeFieldInfoPtr_updateManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedDataComponent>.NativeClassPtr, "updateManager");
			ManagedDataComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedDataComponent>.NativeClassPtr, 100664647);
			ManagedDataComponent.NativeMethodInfoPtr_MarkDirty_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedDataComponent>.NativeClassPtr, 100664648);
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x000283B8 File Offset: 0x000265B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1117288, RefRangeEnd = 1117289, XrefRangeStart = 1117275, XrefRangeEnd = 1117288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagedDataComponent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedDataComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedDataComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x000283F4 File Offset: 0x000265F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1117295, RefRangeEnd = 1117298, XrefRangeStart = 1117289, XrefRangeEnd = 1117295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedDataComponent.NativeMethodInfoPtr_MarkDirty_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0000688B File Offset: 0x00004A8B
		public ManagedDataComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x00028428 File Offset: 0x00026628
		// (set) Token: 0x0600094A RID: 2378 RVA: 0x00006894 File Offset: 0x00004A94
		public unsafe static UpdateManager updateManager
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ManagedDataComponent.NativeFieldInfoPtr_updateManager, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManagedDataComponent.NativeFieldInfoPtr_updateManager, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeFieldInfoPtr_updateManager;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeMethodInfoPtr_MarkDirty_Protected_Void_0;
	}
}
