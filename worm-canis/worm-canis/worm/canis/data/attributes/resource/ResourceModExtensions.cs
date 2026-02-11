using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.data.attributes.resource
{
	// Token: 0x020000E4 RID: 228
	public static class ResourceModExtensions : Object
	{
		// Token: 0x06000FA1 RID: 4001 RVA: 0x00008412 File Offset: 0x00006612
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceModExtensions()
		{
			Il2CppClassPointerStore<ResourceModExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.attributes.resource", "ResourceModExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceModExtensions>.NativeClassPtr);
			ResourceModExtensions.NativeMethodInfoPtr_ApplyResourceMods_Public_Static_Int32_WormPlayer_WormPlayable_AttributeDefinition_1_Nullable_1_Int32_Int32_byref_List_1_ResourceMod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceModExtensions>.NativeClassPtr, 100666032);
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x0009AB98 File Offset: 0x00098D98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77277, RefRangeEnd = 77278, XrefRangeStart = 77252, XrefRangeEnd = 77277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ApplyResourceMods(this WormPlayer player, WormPlayable origin, AttributeDefinition<Nullable<int>> resourceAttribute, int toGain, out List<ResourceMod> appliedMods)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(origin);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resourceAttribute);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toGain;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ResourceModExtensions.NativeMethodInfoPtr_ApplyResourceMods_Public_Static_Int32_WormPlayer_WormPlayable_AttributeDefinition_1_Nullable_1_Int32_Int32_byref_List_1_ResourceMod_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			appliedMods = ((intPtr4 == 0) ? null : new List<ResourceMod>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x0000844B File Offset: 0x0000664B
		public ResourceModExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeMethodInfoPtr_ApplyResourceMods_Public_Static_Int32_WormPlayer_WormPlayable_AttributeDefinition_1_Nullable_1_Int32_Int32_byref_List_1_ResourceMod_0;
	}
}
