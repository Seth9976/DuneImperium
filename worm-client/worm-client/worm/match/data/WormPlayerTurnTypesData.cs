using System;
using Canis.attributes;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm.canis.data.enums;

namespace worm.match.data
{
	// Token: 0x0200019B RID: 411
	public class WormPlayerTurnTypesData : VersionedDataComponent
	{
		// Token: 0x0600124E RID: 4686 RVA: 0x0004F78C File Offset: 0x0004D98C
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayerTurnTypesData()
		{
			Il2CppClassPointerStore<WormPlayerTurnTypesData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormPlayerTurnTypesData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerTurnTypesData>.NativeClassPtr);
			WormPlayerTurnTypesData.NativeFieldInfoPtr_playerTurnAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerTurnTypesData>.NativeClassPtr, "playerTurnAttribute");
			WormPlayerTurnTypesData.NativeMethodInfoPtr_get_Selecting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerTurnTypesData>.NativeClassPtr, 100665794);
			WormPlayerTurnTypesData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerTurnTypesData>.NativeClassPtr, 100665795);
			WormPlayerTurnTypesData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerTurnTypesData>.NativeClassPtr, 100665796);
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x0600124F RID: 4687 RVA: 0x0004F80C File Offset: 0x0004DA0C
		public unsafe bool Selecting
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 711874, RefRangeEnd = 711875, XrefRangeStart = 711869, XrefRangeEnd = 711874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerTurnTypesData.NativeMethodInfoPtr_get_Selecting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x0004F848 File Offset: 0x0004DA48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 711885, RefRangeEnd = 711886, XrefRangeStart = 711875, XrefRangeEnd = 711885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerTurnTypesData(AttributeDataComponent attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerTurnTypesData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerTurnTypesData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001251 RID: 4689 RVA: 0x0004F894 File Offset: 0x0004DA94
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711886, XrefRangeEnd = 711890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayerTurnTypesData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x0000B887 File Offset: 0x00009A87
		public WormPlayerTurnTypesData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001253 RID: 4691 RVA: 0x0004F8DC File Offset: 0x0004DADC
		// (set) Token: 0x06001254 RID: 4692 RVA: 0x0000B890 File Offset: 0x00009A90
		public unsafe IAttribute<Nullable<PlayerTurnTypes>> playerTurnAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerTurnTypesData.NativeFieldInfoPtr_playerTurnAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<PlayerTurnTypes>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerTurnTypesData.NativeFieldInfoPtr_playerTurnAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeFieldInfoPtr_playerTurnAttribute;

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeMethodInfoPtr_get_Selecting_Public_get_Boolean_0;

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;
	}
}
