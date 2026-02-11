using System;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.match.data
{
	// Token: 0x02000187 RID: 391
	public class WormConflictPlayerStateData : VersionedDataComponent
	{
		// Token: 0x06001196 RID: 4502 RVA: 0x0004D1A4 File Offset: 0x0004B3A4
		// Note: this type is marked as 'beforefieldinit'.
		static WormConflictPlayerStateData()
		{
			Il2CppClassPointerStore<WormConflictPlayerStateData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormConflictPlayerStateData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictPlayerStateData>.NativeClassPtr);
			WormConflictPlayerStateData.NativeFieldInfoPtr_passedAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictPlayerStateData>.NativeClassPtr, "passedAttribute");
			WormConflictPlayerStateData.NativeMethodInfoPtr_get_Cost_Public_get_List_1_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictPlayerStateData>.NativeClassPtr, 100665721);
			WormConflictPlayerStateData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictPlayerStateData>.NativeClassPtr, 100665722);
			WormConflictPlayerStateData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictPlayerStateData>.NativeClassPtr, 100665723);
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x0004D224 File Offset: 0x0004B424
		public unsafe List<AccountID> Cost
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 711347, RefRangeEnd = 711349, XrefRangeStart = 711343, XrefRangeEnd = 711347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictPlayerStateData.NativeMethodInfoPtr_get_Cost_Public_get_List_1_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<AccountID>>(intPtr3) : null;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06001198 RID: 4504 RVA: 0x0004D264 File Offset: 0x0004B464
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711349, XrefRangeEnd = 711353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormConflictPlayerStateData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x0004D2AC File Offset: 0x0004B4AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 711363, RefRangeEnd = 711365, XrefRangeStart = 711353, XrefRangeEnd = 711363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormConflictPlayerStateData(AttributeDataComponent attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictPlayerStateData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictPlayerStateData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x0000B372 File Offset: 0x00009572
		public WormConflictPlayerStateData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x0600119B RID: 4507 RVA: 0x0004D2F8 File Offset: 0x0004B4F8
		// (set) Token: 0x0600119C RID: 4508 RVA: 0x0000B37B File Offset: 0x0000957B
		public unsafe IAttribute<List<AccountID>> passedAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayerStateData.NativeFieldInfoPtr_passedAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<List<AccountID>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayerStateData.NativeFieldInfoPtr_passedAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeFieldInfoPtr_passedAttribute;

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeMethodInfoPtr_get_Cost_Public_get_List_1_AccountID_0;

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0;
	}
}
