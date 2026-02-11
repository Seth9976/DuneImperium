using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200003B RID: 59
	public class ShadowCasterGroup2DManager : Object
	{
		// Token: 0x06000566 RID: 1382 RVA: 0x00028440 File Offset: 0x00026640
		// Note: this type is marked as 'beforefieldinit'.
		static ShadowCasterGroup2DManager()
		{
			Il2CppClassPointerStore<ShadowCasterGroup2DManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ShadowCasterGroup2DManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowCasterGroup2DManager>.NativeClassPtr);
			ShadowCasterGroup2DManager.NativeFieldInfoPtr_s_ShadowCasterGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCasterGroup2DManager>.NativeClassPtr, "s_ShadowCasterGroups");
			ShadowCasterGroup2DManager.NativeMethodInfoPtr_get_shadowCasterGroups_Public_Static_get_List_1_ShadowCasterGroup2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCasterGroup2DManager>.NativeClassPtr, 100663918);
			ShadowCasterGroup2DManager.NativeMethodInfoPtr_CacheValues_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCasterGroup2DManager>.NativeClassPtr, 100663919);
			ShadowCasterGroup2DManager.NativeMethodInfoPtr_AddShadowCasterGroupToList_Public_Static_Void_ShadowCasterGroup2D_List_1_ShadowCasterGroup2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCasterGroup2DManager>.NativeClassPtr, 100663920);
			ShadowCasterGroup2DManager.NativeMethodInfoPtr_RemoveShadowCasterGroupFromList_Public_Static_Void_ShadowCasterGroup2D_List_1_ShadowCasterGroup2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCasterGroup2DManager>.NativeClassPtr, 100663921);
			ShadowCasterGroup2DManager.NativeMethodInfoPtr_FindTopMostCompositeShadowCaster_Private_Static_CompositeShadowCaster2D_ShadowCaster2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCasterGroup2DManager>.NativeClassPtr, 100663922);
			ShadowCasterGroup2DManager.NativeMethodInfoPtr_AddToShadowCasterGroup_Public_Static_Boolean_ShadowCaster2D_byref_ShadowCasterGroup2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCasterGroup2DManager>.NativeClassPtr, 100663923);
			ShadowCasterGroup2DManager.NativeMethodInfoPtr_RemoveFromShadowCasterGroup_Public_Static_Void_ShadowCaster2D_ShadowCasterGroup2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCasterGroup2DManager>.NativeClassPtr, 100663924);
			ShadowCasterGroup2DManager.NativeMethodInfoPtr_AddGroup_Public_Static_Void_ShadowCasterGroup2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCasterGroup2DManager>.NativeClassPtr, 100663925);
			ShadowCasterGroup2DManager.NativeMethodInfoPtr_RemoveGroup_Public_Static_Void_ShadowCasterGroup2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCasterGroup2DManager>.NativeClassPtr, 100663926);
			ShadowCasterGroup2DManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCasterGroup2DManager>.NativeClassPtr, 100663927);
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x0002854C File Offset: 0x0002674C
		public unsafe static List<ShadowCasterGroup2D> shadowCasterGroups
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602379, XrefRangeEnd = 602381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCasterGroup2DManager.NativeMethodInfoPtr_get_shadowCasterGroups_Public_Static_get_List_1_ShadowCasterGroup2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ShadowCasterGroup2D>>(intPtr3) : null;
			}
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00028580 File Offset: 0x00026780
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 602399, RefRangeEnd = 602400, XrefRangeStart = 602381, XrefRangeEnd = 602399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CacheValues()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCasterGroup2DManager.NativeMethodInfoPtr_CacheValues_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x000285A8 File Offset: 0x000267A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602400, XrefRangeEnd = 602409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddShadowCasterGroupToList(ShadowCasterGroup2D shadowCaster, List<ShadowCasterGroup2D> list)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shadowCaster);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(list);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCasterGroup2DManager.NativeMethodInfoPtr_AddShadowCasterGroupToList_Public_Static_Void_ShadowCasterGroup2D_List_1_ShadowCasterGroup2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x000285F0 File Offset: 0x000267F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602409, XrefRangeEnd = 602413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveShadowCasterGroupFromList(ShadowCasterGroup2D shadowCaster, List<ShadowCasterGroup2D> list)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shadowCaster);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(list);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCasterGroup2DManager.NativeMethodInfoPtr_RemoveShadowCasterGroupFromList_Public_Static_Void_ShadowCasterGroup2D_List_1_ShadowCasterGroup2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00028638 File Offset: 0x00026838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602413, XrefRangeEnd = 602423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CompositeShadowCaster2D FindTopMostCompositeShadowCaster(ShadowCaster2D shadowCaster)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shadowCaster);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCasterGroup2DManager.NativeMethodInfoPtr_FindTopMostCompositeShadowCaster_Private_Static_CompositeShadowCaster2D_ShadowCaster2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CompositeShadowCaster2D>(intPtr3) : null;
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0002867C File Offset: 0x0002687C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 602459, RefRangeEnd = 602460, XrefRangeStart = 602423, XrefRangeEnd = 602459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AddToShadowCasterGroup(ShadowCaster2D shadowCaster, ref ShadowCasterGroup2D shadowCasterGroup)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shadowCaster);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(shadowCasterGroup);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ShadowCasterGroup2DManager.NativeMethodInfoPtr_AddToShadowCasterGroup_Public_Static_Boolean_ShadowCaster2D_byref_ShadowCasterGroup2D_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			shadowCasterGroup = ((intPtr4 == 0) ? null : new ShadowCasterGroup2D(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x000286E8 File Offset: 0x000268E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 602471, RefRangeEnd = 602473, XrefRangeStart = 602460, XrefRangeEnd = 602471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveFromShadowCasterGroup(ShadowCaster2D shadowCaster, ShadowCasterGroup2D shadowCasterGroup)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shadowCaster);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(shadowCasterGroup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCasterGroup2DManager.NativeMethodInfoPtr_RemoveFromShadowCasterGroup_Public_Static_Void_ShadowCaster2D_ShadowCasterGroup2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00028730 File Offset: 0x00026930
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 602497, RefRangeEnd = 602500, XrefRangeStart = 602473, XrefRangeEnd = 602497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddGroup(ShadowCasterGroup2D group)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCasterGroup2DManager.NativeMethodInfoPtr_AddGroup_Public_Static_Void_ShadowCasterGroup2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00028768 File Offset: 0x00026968
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 602509, RefRangeEnd = 602514, XrefRangeStart = 602500, XrefRangeEnd = 602509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveGroup(ShadowCasterGroup2D group)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCasterGroup2DManager.NativeMethodInfoPtr_RemoveGroup_Public_Static_Void_ShadowCasterGroup2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x000287A0 File Offset: 0x000269A0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShadowCasterGroup2DManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadowCasterGroup2DManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCasterGroup2DManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x000046DE File Offset: 0x000028DE
		public ShadowCasterGroup2DManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x000287DC File Offset: 0x000269DC
		// (set) Token: 0x06000573 RID: 1395 RVA: 0x000046E7 File Offset: 0x000028E7
		public unsafe static List<ShadowCasterGroup2D> s_ShadowCasterGroups
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShadowCasterGroup2DManager.NativeFieldInfoPtr_s_ShadowCasterGroups, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShadowCasterGroup2D>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowCasterGroup2DManager.NativeFieldInfoPtr_s_ShadowCasterGroups, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeFieldInfoPtr_s_ShadowCasterGroups;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowCasterGroups_Public_Static_get_List_1_ShadowCasterGroup2D_0;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeMethodInfoPtr_CacheValues_Public_Static_Void_0;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeMethodInfoPtr_AddShadowCasterGroupToList_Public_Static_Void_ShadowCasterGroup2D_List_1_ShadowCasterGroup2D_0;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeMethodInfoPtr_RemoveShadowCasterGroupFromList_Public_Static_Void_ShadowCasterGroup2D_List_1_ShadowCasterGroup2D_0;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeMethodInfoPtr_FindTopMostCompositeShadowCaster_Private_Static_CompositeShadowCaster2D_ShadowCaster2D_0;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeMethodInfoPtr_AddToShadowCasterGroup_Public_Static_Boolean_ShadowCaster2D_byref_ShadowCasterGroup2D_0;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromShadowCasterGroup_Public_Static_Void_ShadowCaster2D_ShadowCasterGroup2D_0;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeMethodInfoPtr_AddGroup_Public_Static_Void_ShadowCasterGroup2D_0;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeMethodInfoPtr_RemoveGroup_Public_Static_Void_ShadowCasterGroup2D_0;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
