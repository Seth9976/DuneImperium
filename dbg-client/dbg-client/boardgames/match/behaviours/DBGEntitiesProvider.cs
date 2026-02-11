using System;
using dwd.core.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.match.behaviours
{
	// Token: 0x02000281 RID: 641
	public class DBGEntitiesProvider : EntitiesProvider
	{
		// Token: 0x06001E08 RID: 7688 RVA: 0x00081B6C File Offset: 0x0007FD6C
		// Note: this type is marked as 'beforefieldinit'.
		static DBGEntitiesProvider()
		{
			Il2CppClassPointerStore<DBGEntitiesProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.behaviours", "DBGEntitiesProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGEntitiesProvider>.NativeClassPtr);
			DBGEntitiesProvider.NativeMethodInfoPtr_get_DBGEntities_Public_get_DBGEntities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntitiesProvider>.NativeClassPtr, 100668220);
			DBGEntitiesProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntitiesProvider>.NativeClassPtr, 100668221);
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06001E09 RID: 7689 RVA: 0x00081BC4 File Offset: 0x0007FDC4
		public unsafe DBGEntities DBGEntities
		{
			[CallerCount(117)]
			[CachedScanResults(RefRangeStart = 538131, RefRangeEnd = 538248, XrefRangeStart = 538128, XrefRangeEnd = 538131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntitiesProvider.NativeMethodInfoPtr_get_DBGEntities_Public_get_DBGEntities_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr3) : null;
			}
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x00081C04 File Offset: 0x0007FE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538248, XrefRangeEnd = 538249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGEntitiesProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGEntitiesProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntitiesProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x0000FDAC File Offset: 0x0000DFAC
		public DBGEntitiesProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040012FA RID: 4858
		private static readonly IntPtr NativeMethodInfoPtr_get_DBGEntities_Public_get_DBGEntities_0;

		// Token: 0x040012FB RID: 4859
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
