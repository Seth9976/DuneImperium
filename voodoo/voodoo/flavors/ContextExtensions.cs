using System;
using boardgames.kabbage;
using dwd.core.match;
using dwd.core.prefabs.implementations.byflavor;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lotus;
using UnityEngine;

namespace voodoo.flavors
{
	// Token: 0x0200003B RID: 59
	public static class ContextExtensions : global::Il2CppSystem.Object
	{
		// Token: 0x060003D3 RID: 979 RVA: 0x0001556C File Offset: 0x0001376C
		// Note: this type is marked as 'beforefieldinit'.
		static ContextExtensions()
		{
			Il2CppClassPointerStore<ContextExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.flavors", "ContextExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextExtensions>.NativeClassPtr);
			ContextExtensions.NativeFieldInfoPtr_Hidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextExtensions>.NativeClassPtr, "Hidden");
			ContextExtensions.NativeFieldInfoPtr_PnPOpponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextExtensions>.NativeClassPtr, "PnPOpponent");
			ContextExtensions.NativeFieldInfoPtr_gameContextExtensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextExtensions>.NativeClassPtr, "gameContextExtensions");
			ContextExtensions.NativeMethodInfoPtr_SetGameSpecificContextExtensions_Public_Static_Void_GameSpecificContextExtensions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextExtensions>.NativeClassPtr, 100663707);
			ContextExtensions.NativeMethodInfoPtr_WithEntityContext_Public_Static_PrefabFlavorContext_PrefabFlavorContext_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextExtensions>.NativeClassPtr, 100663708);
			ContextExtensions.NativeMethodInfoPtr_WithPileContext_Public_Static_PrefabFlavorContext_PrefabFlavorContext_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextExtensions>.NativeClassPtr, 100663709);
			ContextExtensions.NativeMethodInfoPtr_WithMoveContext_Public_Static_PrefabFlavorContext_PrefabFlavorContext_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextExtensions>.NativeClassPtr, 100663710);
			ContextExtensions.NativeMethodInfoPtr_GetMovePileName_Public_Static_String_ContainerView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextExtensions>.NativeClassPtr, 100663711);
			ContextExtensions.NativeMethodInfoPtr_isHiddenPile_Private_Static_Boolean_ContainerView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextExtensions>.NativeClassPtr, 100663712);
			ContextExtensions.NativeMethodInfoPtr_isPnPOpponentPile_Private_Static_Boolean_ContainerView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextExtensions>.NativeClassPtr, 100663713);
			ContextExtensions.NativeMethodInfoPtr_WithCameraMoveContext_Public_Static_Void_FlavoredVFXMoveContext_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextExtensions>.NativeClassPtr, 100663714);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00015678 File Offset: 0x00013878
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1109133, RefRangeEnd = 1109134, XrefRangeStart = 1109116, XrefRangeEnd = 1109133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGameSpecificContextExtensions(GameSpecificContextExtensions gscm)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gscm);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextExtensions.NativeMethodInfoPtr_SetGameSpecificContextExtensions_Public_Static_Void_GameSpecificContextExtensions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x000156B0 File Offset: 0x000138B0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1109174, RefRangeEnd = 1109184, XrefRangeStart = 1109134, XrefRangeEnd = 1109174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PrefabFlavorContext WithEntityContext(this PrefabFlavorContext context, EntityComponent entity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextExtensions.NativeMethodInfoPtr_WithEntityContext_Public_Static_PrefabFlavorContext_PrefabFlavorContext_EntityComponent_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new PrefabFlavorContext(intPtr);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00015704 File Offset: 0x00013904
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1109254, RefRangeEnd = 1109258, XrefRangeStart = 1109184, XrefRangeEnd = 1109254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PrefabFlavorContext WithPileContext(this PrefabFlavorContext context, Component component)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(component);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextExtensions.NativeMethodInfoPtr_WithPileContext_Public_Static_PrefabFlavorContext_PrefabFlavorContext_Component_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new PrefabFlavorContext(intPtr);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00015758 File Offset: 0x00013958
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1109448, RefRangeEnd = 1109451, XrefRangeStart = 1109258, XrefRangeEnd = 1109448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PrefabFlavorContext WithMoveContext(this PrefabFlavorContext context, MoveContext moveContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(moveContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextExtensions.NativeMethodInfoPtr_WithMoveContext_Public_Static_PrefabFlavorContext_PrefabFlavorContext_MoveContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new PrefabFlavorContext(intPtr);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x000157AC File Offset: 0x000139AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1109461, RefRangeEnd = 1109464, XrefRangeStart = 1109451, XrefRangeEnd = 1109461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMovePileName(ContainerView container)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextExtensions.NativeMethodInfoPtr_GetMovePileName_Public_Static_String_ContainerView_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x000157E8 File Offset: 0x000139E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1109478, RefRangeEnd = 1109480, XrefRangeStart = 1109464, XrefRangeEnd = 1109478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool isHiddenPile(ContainerView pile)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextExtensions.NativeMethodInfoPtr_isHiddenPile_Private_Static_Boolean_ContainerView_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0001582C File Offset: 0x00013A2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1109496, RefRangeEnd = 1109498, XrefRangeStart = 1109480, XrefRangeEnd = 1109496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool isPnPOpponentPile(ContainerView pile)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextExtensions.NativeMethodInfoPtr_isPnPOpponentPile_Private_Static_Boolean_ContainerView_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00015870 File Offset: 0x00013A70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1109537, RefRangeEnd = 1109538, XrefRangeStart = 1109498, XrefRangeEnd = 1109537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WithCameraMoveContext(this FlavoredVFXMoveContext context, Vector3 currentPosition, Vector3 destPosition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextExtensions.NativeMethodInfoPtr_WithCameraMoveContext_Public_Static_Void_FlavoredVFXMoveContext_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00004013 File Offset: 0x00002213
		public ContextExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060003DD RID: 989 RVA: 0x000158C4 File Offset: 0x00013AC4
		// (set) Token: 0x060003DE RID: 990 RVA: 0x0000401C File Offset: 0x0000221C
		public unsafe static string Hidden
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ContextExtensions.NativeFieldInfoPtr_Hidden, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ContextExtensions.NativeFieldInfoPtr_Hidden, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060003DF RID: 991 RVA: 0x000158E4 File Offset: 0x00013AE4
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x0000402E File Offset: 0x0000222E
		public unsafe static string PnPOpponent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ContextExtensions.NativeFieldInfoPtr_PnPOpponent, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ContextExtensions.NativeFieldInfoPtr_PnPOpponent, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x00015904 File Offset: 0x00013B04
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x00004040 File Offset: 0x00002240
		public unsafe static GameSpecificContextExtensions gameContextExtensions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ContextExtensions.NativeFieldInfoPtr_gameContextExtensions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameSpecificContextExtensions>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ContextExtensions.NativeFieldInfoPtr_gameContextExtensions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeFieldInfoPtr_Hidden;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeFieldInfoPtr_PnPOpponent;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeFieldInfoPtr_gameContextExtensions;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_SetGameSpecificContextExtensions_Public_Static_Void_GameSpecificContextExtensions_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_WithEntityContext_Public_Static_PrefabFlavorContext_PrefabFlavorContext_EntityComponent_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_WithPileContext_Public_Static_PrefabFlavorContext_PrefabFlavorContext_Component_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr_WithMoveContext_Public_Static_PrefabFlavorContext_PrefabFlavorContext_MoveContext_0;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr_GetMovePileName_Public_Static_String_ContainerView_0;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_isHiddenPile_Private_Static_Boolean_ContainerView_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr_isPnPOpponentPile_Private_Static_Boolean_ContainerView_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr_WithCameraMoveContext_Public_Static_Void_FlavoredVFXMoveContext_Vector3_Vector3_0;
	}
}
