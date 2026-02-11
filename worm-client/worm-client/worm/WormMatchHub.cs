using System;
using boardgames.match.behaviours;
using Canis.messages;
using Canis.utils.localization;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm
{
	// Token: 0x02000058 RID: 88
	public class WormMatchHub : DBGMatchHub
	{
		// Token: 0x0600038D RID: 909 RVA: 0x000240EC File Offset: 0x000222EC
		// Note: this type is marked as 'beforefieldinit'.
		static WormMatchHub()
		{
			Il2CppClassPointerStore<WormMatchHub>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormMatchHub");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMatchHub>.NativeClassPtr);
			WormMatchHub.NativeMethodInfoPtr_createEntities_Protected_Virtual_Entities_SerializedGameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchHub>.NativeClassPtr, 100663892);
			WormMatchHub.NativeMethodInfoPtr_ConfigurePlaymat_Public_Virtual_Final_New_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchHub>.NativeClassPtr, 100663893);
			WormMatchHub.NativeMethodInfoPtr_ConfigurePlayer_Public_Virtual_Final_New_Void_EntityComponent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchHub>.NativeClassPtr, 100663894);
			WormMatchHub.NativeMethodInfoPtr_ConfigureEntity_Public_Virtual_Final_New_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchHub>.NativeClassPtr, 100663895);
			WormMatchHub.NativeMethodInfoPtr_GetResignConfirmationWarning_Public_Virtual_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchHub>.NativeClassPtr, 100663896);
			WormMatchHub.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchHub>.NativeClassPtr, 100663897);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00024194 File Offset: 0x00022394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692881, XrefRangeEnd = 692902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Entities createEntities(SerializedGameState gameState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameState);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatchHub.NativeMethodInfoPtr_createEntities_Protected_Virtual_Entities_SerializedGameState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entities>(intPtr3) : null;
			}
		}

		// Token: 0x0600038F RID: 911 RVA: 0x000241F0 File Offset: 0x000223F0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ConfigurePlaymat(EntityComponent composition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(composition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatchHub.NativeMethodInfoPtr_ConfigurePlaymat_Public_Virtual_Final_New_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00024234 File Offset: 0x00022434
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ConfigurePlayer(EntityComponent composition, int playerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(composition);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatchHub.NativeMethodInfoPtr_ConfigurePlayer_Public_Virtual_Final_New_Void_EntityComponent_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00024284 File Offset: 0x00022484
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ConfigureEntity(EntityComponent composition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(composition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatchHub.NativeMethodInfoPtr_ConfigureEntity_Public_Virtual_Final_New_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000242C8 File Offset: 0x000224C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692902, XrefRangeEnd = 692923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override LocalizedString GetResignConfirmationWarning()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatchHub.NativeMethodInfoPtr_GetResignConfirmationWarning_Public_Virtual_LocalizedString_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr3) : null;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00024314 File Offset: 0x00022514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692923, XrefRangeEnd = 692924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormMatchHub()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatchHub>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatchHub.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000396B File Offset: 0x00001B6B
		public WormMatchHub(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_createEntities_Protected_Virtual_Entities_SerializedGameState_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_ConfigurePlaymat_Public_Virtual_Final_New_Void_EntityComponent_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_ConfigurePlayer_Public_Virtual_Final_New_Void_EntityComponent_Int32_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureEntity_Public_Virtual_Final_New_Void_EntityComponent_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_GetResignConfirmationWarning_Public_Virtual_LocalizedString_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
