using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.attributes
{
	// Token: 0x02000014 RID: 20
	public static class IEntityExtensions : Object
	{
		// Token: 0x0600015D RID: 349 RVA: 0x00002A59 File Offset: 0x00000C59
		// Note: this type is marked as 'beforefieldinit'.
		static IEntityExtensions()
		{
			Il2CppClassPointerStore<IEntityExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes", "IEntityExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IEntityExtensions>.NativeClassPtr);
			IEntityExtensions.NativeMethodInfoPtr_IsArchetype_Public_Static_Boolean_IEntity_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntityExtensions>.NativeClassPtr, 100663366);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00006FA0 File Offset: 0x000051A0
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 1215785, RefRangeEnd = 1215812, XrefRangeStart = 1215767, XrefRangeEnd = 1215785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsArchetype(this IEntity self, ArchetypeID archID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(archID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IEntityExtensions.NativeMethodInfoPtr_IsArchetype_Public_Static_Boolean_IEntity_ArchetypeID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002A92 File Offset: 0x00000C92
		public IEntityExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_IsArchetype_Public_Static_Boolean_IEntity_ArchetypeID_0;
	}
}
