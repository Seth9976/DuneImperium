using System;
using boardgames.menus;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.match;

namespace worm
{
	// Token: 0x02000054 RID: 84
	public class WormOfflineMatches : OfflineMatches<WormMatchInitData>
	{
		// Token: 0x0600035F RID: 863 RVA: 0x00023598 File Offset: 0x00021798
		// Note: this type is marked as 'beforefieldinit'.
		static WormOfflineMatches()
		{
			Il2CppClassPointerStore<WormOfflineMatches>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormOfflineMatches");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormOfflineMatches>.NativeClassPtr);
			WormOfflineMatches.NativeMethodInfoPtr_ConfigureSavedGameMatchInitDataPlayers_Protected_Virtual_Void_List_1_PlayerInfoSaveData_WormMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOfflineMatches>.NativeClassPtr, 100663860);
			WormOfflineMatches.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOfflineMatches>.NativeClassPtr, 100663861);
		}

		// Token: 0x06000360 RID: 864 RVA: 0x000235F0 File Offset: 0x000217F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692046, XrefRangeEnd = 692069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ConfigureSavedGameMatchInitDataPlayers(List<PlayerInfoSaveData> orderedPlayers, WormMatchInitData matchInitData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(orderedPlayers);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matchInitData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormOfflineMatches.NativeMethodInfoPtr_ConfigureSavedGameMatchInitDataPlayers_Protected_Virtual_Void_List_1_PlayerInfoSaveData_WormMatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00023650 File Offset: 0x00021850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692069, XrefRangeEnd = 692072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormOfflineMatches()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormOfflineMatches>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOfflineMatches.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00003861 File Offset: 0x00001A61
		public WormOfflineMatches(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureSavedGameMatchInitDataPlayers_Protected_Virtual_Void_List_1_PlayerInfoSaveData_WormMatchInitData_0;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002EA RID: 746
		[ObfuscatedName("worm.WormOfflineMatches+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001E64 RID: 7780 RVA: 0x00075398 File Offset: 0x00073598
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormOfflineMatches.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormOfflineMatches>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormOfflineMatches.__c>.NativeClassPtr);
				WormOfflineMatches.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormOfflineMatches.__c>.NativeClassPtr, "<>9");
				WormOfflineMatches.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormOfflineMatches.__c>.NativeClassPtr, "<>9__0_0");
				WormOfflineMatches.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOfflineMatches.__c>.NativeClassPtr, 100663863);
				WormOfflineMatches.__c.NativeMethodInfoPtr__ConfigureSavedGameMatchInitDataPlayers_b__0_0_Internal_WormPlayerMatchInitData_PlayerInfoSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOfflineMatches.__c>.NativeClassPtr, 100663864);
			}

			// Token: 0x06001E65 RID: 7781 RVA: 0x00075414 File Offset: 0x00073614
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormOfflineMatches.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOfflineMatches.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E66 RID: 7782 RVA: 0x00075450 File Offset: 0x00073650
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692042, XrefRangeEnd = 692046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WormPlayerMatchInitData _ConfigureSavedGameMatchInitDataPlayers_b__0_0(PlayerInfoSaveData player)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOfflineMatches.__c.NativeMethodInfoPtr__ConfigureSavedGameMatchInitDataPlayers_b__0_0_Internal_WormPlayerMatchInitData_PlayerInfoSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayerMatchInitData>(intPtr3) : null;
				}
			}

			// Token: 0x06001E67 RID: 7783 RVA: 0x00011434 File Offset: 0x0000F634
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000858 RID: 2136
			// (get) Token: 0x06001E68 RID: 7784 RVA: 0x000754A0 File Offset: 0x000736A0
			// (set) Token: 0x06001E69 RID: 7785 RVA: 0x0001143D File Offset: 0x0000F63D
			public unsafe static WormOfflineMatches.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormOfflineMatches.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormOfflineMatches.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormOfflineMatches.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000859 RID: 2137
			// (get) Token: 0x06001E6A RID: 7786 RVA: 0x000754C8 File Offset: 0x000736C8
			// (set) Token: 0x06001E6B RID: 7787 RVA: 0x0001144F File Offset: 0x0000F64F
			public unsafe static Func<PlayerInfoSaveData, WormPlayerMatchInitData> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormOfflineMatches.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerInfoSaveData, WormPlayerMatchInitData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormOfflineMatches.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400119E RID: 4510
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400119F RID: 4511
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x040011A0 RID: 4512
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011A1 RID: 4513
			private static readonly IntPtr NativeMethodInfoPtr__ConfigureSavedGameMatchInitDataPlayers_b__0_0_Internal_WormPlayerMatchInitData_PlayerInfoSaveData_0;
		}
	}
}
