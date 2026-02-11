using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.prefabs.implementations.byflavor
{
	// Token: 0x02000113 RID: 275
	public class PrefabByFlavorLoader : PrefabLoader<PrefabByFlavorLookup, PrefabFlavorsMetaData, PrefabByFlavorMetadata>
	{
		// Token: 0x06000FA0 RID: 4000 RVA: 0x00051914 File Offset: 0x0004FB14
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabByFlavorLoader()
		{
			Il2CppClassPointerStore<PrefabByFlavorLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.prefabs.implementations.byflavor", "PrefabByFlavorLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabByFlavorLoader>.NativeClassPtr);
			PrefabByFlavorLoader.NativeFieldInfoPtr_byFlavorLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabByFlavorLoader>.NativeClassPtr, "byFlavorLookup");
			PrefabByFlavorLoader.NativeMethodInfoPtr_get_lookup_Protected_Virtual_get_PrefabByFlavorLookup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabByFlavorLoader>.NativeClassPtr, 100665563);
			PrefabByFlavorLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabByFlavorLoader>.NativeClassPtr, 100665564);
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000FA1 RID: 4001 RVA: 0x00051980 File Offset: 0x0004FB80
		public unsafe override PrefabByFlavorLookup lookup
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabByFlavorLoader.NativeMethodInfoPtr_get_lookup_Protected_Virtual_get_PrefabByFlavorLookup_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrefabByFlavorLookup>(intPtr3) : null;
			}
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x000519CC File Offset: 0x0004FBCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 868548, RefRangeEnd = 868549, XrefRangeStart = 868545, XrefRangeEnd = 868548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabByFlavorLoader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabByFlavorLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabByFlavorLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x00007586 File Offset: 0x00005786
		public PrefabByFlavorLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x00051A08 File Offset: 0x0004FC08
		// (set) Token: 0x06000FA5 RID: 4005 RVA: 0x0000758F File Offset: 0x0000578F
		public unsafe PrefabByFlavorLookup byFlavorLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabByFlavorLoader.NativeFieldInfoPtr_byFlavorLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabByFlavorLookup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabByFlavorLoader.NativeFieldInfoPtr_byFlavorLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeFieldInfoPtr_byFlavorLookup;

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeMethodInfoPtr_get_lookup_Protected_Virtual_get_PrefabByFlavorLookup_0;

		// Token: 0x04000B27 RID: 2855
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
