using System;
using boardgames.match.selection;
using boardgames.moz;
using dwd.core.match;
using dwd.core.prefabs.implementations.byflavor;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using worm.match.dataRenderers;

namespace worm.utils
{
	// Token: 0x0200005C RID: 92
	public class WormCardHangersLoader : CardHangersLoader
	{
		// Token: 0x060003A9 RID: 937 RVA: 0x00024804 File Offset: 0x00022A04
		// Note: this type is marked as 'beforefieldinit'.
		static WormCardHangersLoader()
		{
			Il2CppClassPointerStore<WormCardHangersLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.utils", "WormCardHangersLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCardHangersLoader>.NativeClassPtr);
			WormCardHangersLoader.NativeFieldInfoPtr_pileCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCardHangersLoader>.NativeClassPtr, "pileCount");
			WormCardHangersLoader.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCardHangersLoader>.NativeClassPtr, "selectionResponder");
			WormCardHangersLoader.NativeMethodInfoPtr_GetHangersList_Protected_Virtual_IEnumerable_1_PrefabFlavorContext_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardHangersLoader>.NativeClassPtr, 100663908);
			WormCardHangersLoader.NativeMethodInfoPtr_hangerInstantiated_Protected_Virtual_Void_PrefabByFlavorMetadata_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardHangersLoader>.NativeClassPtr, 100663909);
			WormCardHangersLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardHangersLoader>.NativeClassPtr, 100663910);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00024898 File Offset: 0x00022A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693104, XrefRangeEnd = 693585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<PrefabFlavorContext> GetHangersList(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCardHangersLoader.NativeMethodInfoPtr_GetHangersList_Protected_Virtual_IEnumerable_1_PrefabFlavorContext_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PrefabFlavorContext>>(intPtr3) : null;
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x000248F4 File Offset: 0x00022AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693585, XrefRangeEnd = 693589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void hangerInstantiated(PrefabByFlavorMetadata hanger, EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hanger);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCardHangersLoader.NativeMethodInfoPtr_hangerInstantiated_Protected_Virtual_Void_PrefabByFlavorMetadata_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00024954 File Offset: 0x00022B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693589, XrefRangeEnd = 693590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormCardHangersLoader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCardHangersLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCardHangersLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x000039CD File Offset: 0x00001BCD
		public WormCardHangersLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060003AE RID: 942 RVA: 0x00024990 File Offset: 0x00022B90
		// (set) Token: 0x060003AF RID: 943 RVA: 0x000039D6 File Offset: 0x00001BD6
		public unsafe WormReservePileCountRenderer pileCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardHangersLoader.NativeFieldInfoPtr_pileCount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormReservePileCountRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardHangersLoader.NativeFieldInfoPtr_pileCount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x000249C0 File Offset: 0x00022BC0
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x000039F5 File Offset: 0x00001BF5
		public unsafe DBGSelectionResponder selectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardHangersLoader.NativeFieldInfoPtr_selectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardHangersLoader.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeFieldInfoPtr_pileCount;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_GetHangersList_Protected_Virtual_IEnumerable_1_PrefabFlavorContext_EntityComponent_0;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_hangerInstantiated_Protected_Virtual_Void_PrefabByFlavorMetadata_EntityComponent_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
