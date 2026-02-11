using System;
using Canis.context.contextToList;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.context.propertiesphrases
{
	// Token: 0x0200013B RID: 315
	public static class ContextualEntities : Object
	{
		// Token: 0x06000E3E RID: 3646 RVA: 0x00055CF0 File Offset: 0x00053EF0
		// Note: this type is marked as 'beforefieldinit'.
		static ContextualEntities()
		{
			Il2CppClassPointerStore<ContextualEntities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.propertiesphrases", "ContextualEntities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextualEntities>.NativeClassPtr);
			ContextualEntities.NativeMethodInfoPtr_With_Public_Static_ContextToList_1_Entity_ContextToList_1_Entity_PropertiesPhrase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualEntities>.NativeClassPtr, 100666402);
			ContextualEntities.NativeMethodInfoPtr_Children_Public_Static_ContextToList_1_Entity_ContextToList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualEntities>.NativeClassPtr, 100666403);
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x00055D48 File Offset: 0x00053F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577208, XrefRangeEnd = 577216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ContextToList<Entity> With(this ContextToList<Entity> contextualEnts, PropertiesPhrase props)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(contextualEnts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(props);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualEntities.NativeMethodInfoPtr_With_Public_Static_ContextToList_1_Entity_ContextToList_1_Entity_PropertiesPhrase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContextToList<Entity>>(intPtr3) : null;
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x00055DA0 File Offset: 0x00053FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577216, XrefRangeEnd = 577223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ContextToList<Entity> Children(this ContextToList<Entity> contextualEnts)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(contextualEnts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualEntities.NativeMethodInfoPtr_Children_Public_Static_ContextToList_1_Entity_ContextToList_1_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContextToList<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x00007369 File Offset: 0x00005569
		public ContextualEntities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009A7 RID: 2471
		private static readonly IntPtr NativeMethodInfoPtr_With_Public_Static_ContextToList_1_Entity_ContextToList_1_Entity_PropertiesPhrase_0;

		// Token: 0x040009A8 RID: 2472
		private static readonly IntPtr NativeMethodInfoPtr_Children_Public_Static_ContextToList_1_Entity_ContextToList_1_Entity_0;
	}
}
