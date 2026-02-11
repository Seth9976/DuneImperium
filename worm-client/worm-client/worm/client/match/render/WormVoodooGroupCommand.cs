using System;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using lotus;

namespace worm.client.match.render
{
	// Token: 0x0200029E RID: 670
	public class WormVoodooGroupCommand : VoodooGroupCommand
	{
		// Token: 0x06001B3F RID: 6975 RVA: 0x0006BBCC File Offset: 0x00069DCC
		// Note: this type is marked as 'beforefieldinit'.
		static WormVoodooGroupCommand()
		{
			Il2CppClassPointerStore<WormVoodooGroupCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.client.match.render", "WormVoodooGroupCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormVoodooGroupCommand>.NativeClassPtr);
			WormVoodooGroupCommand.NativeFieldInfoPtr_OpponentStingerSequenceNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVoodooGroupCommand>.NativeClassPtr, "OpponentStingerSequenceNames");
			WormVoodooGroupCommand.NativeFieldInfoPtr_OtherStingerSequenceNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVoodooGroupCommand>.NativeClassPtr, "OtherStingerSequenceNames");
			WormVoodooGroupCommand.NativeMethodInfoPtr_get_StingerPileID_Private_get_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVoodooGroupCommand>.NativeClassPtr, 100667266);
			WormVoodooGroupCommand.NativeMethodInfoPtr__ctor_Public_Void_String_ContainerView_ContainerView_EntityID_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVoodooGroupCommand>.NativeClassPtr, 100667267);
			WormVoodooGroupCommand.NativeMethodInfoPtr__ctor_Public_Void_String_GroupInitInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVoodooGroupCommand>.NativeClassPtr, 100667268);
			WormVoodooGroupCommand.NativeMethodInfoPtr_HandleAttributes_Public_Virtual_Void_String_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVoodooGroupCommand>.NativeClassPtr, 100667269);
			WormVoodooGroupCommand.NativeMethodInfoPtr_initializePositions_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVoodooGroupCommand>.NativeClassPtr, 100667270);
			WormVoodooGroupCommand.NativeMethodInfoPtr_isHiddenPile_Private_Boolean_ContainerView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVoodooGroupCommand>.NativeClassPtr, 100667271);
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001B40 RID: 6976 RVA: 0x0006BC9C File Offset: 0x00069E9C
		public unsafe EntityID StingerPileID
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724265, XrefRangeEnd = 724270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVoodooGroupCommand.NativeMethodInfoPtr_get_StingerPileID_Private_get_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
			}
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x0006BCDC File Offset: 0x00069EDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 724271, RefRangeEnd = 724272, XrefRangeStart = 724270, XrefRangeEnd = 724271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormVoodooGroupCommand(string sequenceName, ContainerView start, ContainerView dest, EntityID startId, EntityID destId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVoodooGroupCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sequenceName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(start);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startId);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVoodooGroupCommand.NativeMethodInfoPtr__ctor_Public_Void_String_ContainerView_ContainerView_EntityID_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x0006BD74 File Offset: 0x00069F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724272, XrefRangeEnd = 724273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormVoodooGroupCommand(string sequenceName, VoodooGroupCommand.GroupInitInfo initInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVoodooGroupCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sequenceName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(initInfo));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVoodooGroupCommand.NativeMethodInfoPtr__ctor_Public_Void_String_GroupInitInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x0006BDD8 File Offset: 0x00069FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724273, XrefRangeEnd = 724334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HandleAttributes(string sequenceName, IHasAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sequenceName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVoodooGroupCommand.NativeMethodInfoPtr_HandleAttributes_Public_Virtual_Void_String_IHasAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x0006BE38 File Offset: 0x0006A038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724334, XrefRangeEnd = 724395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initializePositions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVoodooGroupCommand.NativeMethodInfoPtr_initializePositions_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x0006BE74 File Offset: 0x0006A074
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 724417, RefRangeEnd = 724419, XrefRangeStart = 724395, XrefRangeEnd = 724417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool isHiddenPile(ContainerView pile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVoodooGroupCommand.NativeMethodInfoPtr_isHiddenPile_Private_Boolean_ContainerView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x0000FC8E File Offset: 0x0000DE8E
		public WormVoodooGroupCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06001B47 RID: 6983 RVA: 0x0006BEC4 File Offset: 0x0006A0C4
		// (set) Token: 0x06001B48 RID: 6984 RVA: 0x0000FC97 File Offset: 0x0000DE97
		public unsafe static IReadOnlyList<string> OpponentStingerSequenceNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormVoodooGroupCommand.NativeFieldInfoPtr_OpponentStingerSequenceNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormVoodooGroupCommand.NativeFieldInfoPtr_OpponentStingerSequenceNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001B49 RID: 6985 RVA: 0x0006BEEC File Offset: 0x0006A0EC
		// (set) Token: 0x06001B4A RID: 6986 RVA: 0x0000FCA9 File Offset: 0x0000DEA9
		public unsafe static IReadOnlyList<string> OtherStingerSequenceNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormVoodooGroupCommand.NativeFieldInfoPtr_OtherStingerSequenceNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormVoodooGroupCommand.NativeFieldInfoPtr_OtherStingerSequenceNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FB8 RID: 4024
		private static readonly IntPtr NativeFieldInfoPtr_OpponentStingerSequenceNames;

		// Token: 0x04000FB9 RID: 4025
		private static readonly IntPtr NativeFieldInfoPtr_OtherStingerSequenceNames;

		// Token: 0x04000FBA RID: 4026
		private static readonly IntPtr NativeMethodInfoPtr_get_StingerPileID_Private_get_EntityID_0;

		// Token: 0x04000FBB RID: 4027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ContainerView_ContainerView_EntityID_EntityID_0;

		// Token: 0x04000FBC RID: 4028
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_GroupInitInfo_0;

		// Token: 0x04000FBD RID: 4029
		private static readonly IntPtr NativeMethodInfoPtr_HandleAttributes_Public_Virtual_Void_String_IHasAttributes_0;

		// Token: 0x04000FBE RID: 4030
		private static readonly IntPtr NativeMethodInfoPtr_initializePositions_Protected_Virtual_Void_0;

		// Token: 0x04000FBF RID: 4031
		private static readonly IntPtr NativeMethodInfoPtr_isHiddenPile_Private_Boolean_ContainerView_0;
	}
}
