using System;
using dwd.core.match;
using dwd.core.prefabs.implementations.byflavor;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace boardgames.moz
{
	// Token: 0x0200010D RID: 269
	public class CardHangersLoader : PrefabByFlavorLoader
	{
		// Token: 0x06000BFC RID: 3068 RVA: 0x000437EC File Offset: 0x000419EC
		// Note: this type is marked as 'beforefieldinit'.
		static CardHangersLoader()
		{
			Il2CppClassPointerStore<CardHangersLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.moz", "CardHangersLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardHangersLoader>.NativeClassPtr);
			CardHangersLoader.NativeFieldInfoPtr_hangersAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardHangersLoader>.NativeClassPtr, "hangersAnchor");
			CardHangersLoader.NativeFieldInfoPtr_instantiatedHangers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardHangersLoader>.NativeClassPtr, "instantiatedHangers");
			CardHangersLoader.NativeMethodInfoPtr_GetHangersList_Protected_Abstract_Virtual_New_IEnumerable_1_PrefabFlavorContext_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHangersLoader>.NativeClassPtr, 100665079);
			CardHangersLoader.NativeMethodInfoPtr_LoadHangers_Public_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHangersLoader>.NativeClassPtr, 100665080);
			CardHangersLoader.NativeMethodInfoPtr_hangerInstantiated_Protected_Virtual_New_Void_PrefabByFlavorMetadata_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHangersLoader>.NativeClassPtr, 100665081);
			CardHangersLoader.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHangersLoader>.NativeClassPtr, 100665082);
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00043894 File Offset: 0x00041A94
		[CallerCount(0)]
		public unsafe virtual IEnumerable<PrefabFlavorContext> GetHangersList(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardHangersLoader.NativeMethodInfoPtr_GetHangersList_Protected_Abstract_Virtual_New_IEnumerable_1_PrefabFlavorContext_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PrefabFlavorContext>>(intPtr3) : null;
			}
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x000438F0 File Offset: 0x00041AF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 509359, RefRangeEnd = 509361, XrefRangeStart = 509303, XrefRangeEnd = 509359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadHangers(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardHangersLoader.NativeMethodInfoPtr_LoadHangers_Public_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00043934 File Offset: 0x00041B34
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void hangerInstantiated(PrefabByFlavorMetadata hanger, EntityComponent entity)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardHangersLoader.NativeMethodInfoPtr_hangerInstantiated_Protected_Virtual_New_Void_PrefabByFlavorMetadata_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00043994 File Offset: 0x00041B94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 509369, RefRangeEnd = 509370, XrefRangeStart = 509361, XrefRangeEnd = 509369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CardHangersLoader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardHangersLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardHangersLoader.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00007BFD File Offset: 0x00005DFD
		public CardHangersLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000C02 RID: 3074 RVA: 0x000439D0 File Offset: 0x00041BD0
		// (set) Token: 0x06000C03 RID: 3075 RVA: 0x00007C06 File Offset: 0x00005E06
		public unsafe Transform hangersAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardHangersLoader.NativeFieldInfoPtr_hangersAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardHangersLoader.NativeFieldInfoPtr_hangersAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x00043A00 File Offset: 0x00041C00
		// (set) Token: 0x06000C05 RID: 3077 RVA: 0x00007C25 File Offset: 0x00005E25
		public unsafe List<GameObject> instantiatedHangers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardHangersLoader.NativeFieldInfoPtr_instantiatedHangers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardHangersLoader.NativeFieldInfoPtr_instantiatedHangers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeFieldInfoPtr_hangersAnchor;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeFieldInfoPtr_instantiatedHangers;

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeMethodInfoPtr_GetHangersList_Protected_Abstract_Virtual_New_IEnumerable_1_PrefabFlavorContext_EntityComponent_0;

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeMethodInfoPtr_LoadHangers_Public_Void_EntityComponent_0;

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeMethodInfoPtr_hangerInstantiated_Protected_Virtual_New_Void_PrefabByFlavorMetadata_EntityComponent_0;

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
