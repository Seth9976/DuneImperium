using System;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace lotus
{
	// Token: 0x02000089 RID: 137
	public static class VoodooSequenceUtil : Object
	{
		// Token: 0x06000840 RID: 2112 RVA: 0x00024E88 File Offset: 0x00023088
		// Note: this type is marked as 'beforefieldinit'.
		static VoodooSequenceUtil()
		{
			Il2CppClassPointerStore<VoodooSequenceUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "VoodooSequenceUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooSequenceUtil>.NativeClassPtr);
			VoodooSequenceUtil.NativeMethodInfoPtr_CreateGroupInitInfo_Public_Static_Nullable_1_GroupInitInfo_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooSequenceUtil>.NativeClassPtr, 100664493);
			VoodooSequenceUtil.NativeMethodInfoPtr_CreateGroupCommandForSequenceCommand_Public_Static_VoodooGroupCommand_Command_String_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooSequenceUtil>.NativeClassPtr, 100664494);
			VoodooSequenceUtil.NativeMethodInfoPtr_IsAbilities_Public_Static_Boolean_EntitiesProvider_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooSequenceUtil>.NativeClassPtr, 100664495);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00024EF4 File Offset: 0x000230F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1116136, RefRangeEnd = 1116138, XrefRangeStart = 1116041, XrefRangeEnd = 1116136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<VoodooGroupCommand.GroupInitInfo> CreateGroupInitInfo(Command command)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooSequenceUtil.NativeMethodInfoPtr_CreateGroupInitInfo_Public_Static_Nullable_1_GroupInitInfo_Command_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<VoodooGroupCommand.GroupInitInfo>(intPtr);
			}
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00024F30 File Offset: 0x00023130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116138, XrefRangeEnd = 1116142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VoodooGroupCommand CreateGroupCommandForSequenceCommand(Command seqCommand, string sequenceName, IHasAttributes attributes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(seqCommand);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sequenceName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooSequenceUtil.NativeMethodInfoPtr_CreateGroupCommandForSequenceCommand_Public_Static_VoodooGroupCommand_Command_String_IHasAttributes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VoodooGroupCommand>(intPtr3) : null;
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00024F98 File Offset: 0x00023198
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1116154, RefRangeEnd = 1116157, XrefRangeStart = 1116142, XrefRangeEnd = 1116154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAbilities(EntitiesProvider entitiesProvider, EntityID id)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entitiesProvider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooSequenceUtil.NativeMethodInfoPtr_IsAbilities_Public_Static_Boolean_EntitiesProvider_EntityID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00006093 File Offset: 0x00004293
		public VoodooSequenceUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeMethodInfoPtr_CreateGroupInitInfo_Public_Static_Nullable_1_GroupInitInfo_Command_0;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeMethodInfoPtr_CreateGroupCommandForSequenceCommand_Public_Static_VoodooGroupCommand_Command_String_IHasAttributes_0;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeMethodInfoPtr_IsAbilities_Public_Static_Boolean_EntitiesProvider_EntityID_0;
	}
}
