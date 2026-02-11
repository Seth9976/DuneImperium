using System;
using canis.archetypes;
using Canis.attributes;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using lib.canis.boardgames.src.match;

namespace worm
{
	// Token: 0x02000036 RID: 54
	public class WormArchetypeProvider : ArchetypeProvider
	{
		// Token: 0x0600025E RID: 606 RVA: 0x00020548 File Offset: 0x0001E748
		// Note: this type is marked as 'beforefieldinit'.
		static WormArchetypeProvider()
		{
			Il2CppClassPointerStore<WormArchetypeProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormArchetypeProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormArchetypeProvider>.NativeClassPtr);
			WormArchetypeProvider.NativeMethodInfoPtr_getArchetypes_Protected_Virtual_IEnumerable_1_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeProvider>.NativeClassPtr, 100663704);
			WormArchetypeProvider.NativeMethodInfoPtr_introduce_Protected_Virtual_Void_EntityComponent_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeProvider>.NativeClassPtr, 100663705);
			WormArchetypeProvider.NativeMethodInfoPtr_ConfigurePlayable_Private_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeProvider>.NativeClassPtr, 100663706);
			WormArchetypeProvider.NativeMethodInfoPtr_ConfigureLeader_Private_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeProvider>.NativeClassPtr, 100663707);
			WormArchetypeProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeProvider>.NativeClassPtr, 100663708);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000205DC File Offset: 0x0001E7DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690260, XrefRangeEnd = 690265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Archetype> getArchetypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormArchetypeProvider.NativeMethodInfoPtr_getArchetypes_Protected_Virtual_IEnumerable_1_Archetype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Archetype>>(intPtr3) : null;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00020628 File Offset: 0x0001E828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690265, XrefRangeEnd = 690319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void introduce(EntityComponent entity, ReadOnlyAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormArchetypeProvider.NativeMethodInfoPtr_introduce_Protected_Virtual_Void_EntityComponent_ReadOnlyAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00020688 File Offset: 0x0001E888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690319, XrefRangeEnd = 690366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigurePlayable(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeProvider.NativeMethodInfoPtr_ConfigurePlayable_Private_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000206CC File Offset: 0x0001E8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690366, XrefRangeEnd = 690399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureLeader(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeProvider.NativeMethodInfoPtr_ConfigureLeader_Private_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00020710 File Offset: 0x0001E910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormArchetypeProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormArchetypeProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00003178 File Offset: 0x00001378
		public WormArchetypeProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_getArchetypes_Protected_Virtual_IEnumerable_1_Archetype_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_introduce_Protected_Virtual_Void_EntityComponent_ReadOnlyAttributes_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_ConfigurePlayable_Private_Void_EntityComponent_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureLeader_Private_Void_EntityComponent_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
