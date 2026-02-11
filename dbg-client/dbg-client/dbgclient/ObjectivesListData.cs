using System;
using Canis.attributes;
using Canis.tutorialScripts;
using dwd.core.data.composition;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dbgclient
{
	// Token: 0x0200007F RID: 127
	public class ObjectivesListData : DataComponent
	{
		// Token: 0x060004E0 RID: 1248 RVA: 0x0002CCB8 File Offset: 0x0002AEB8
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectivesListData()
		{
			Il2CppClassPointerStore<ObjectivesListData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient", "ObjectivesListData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectivesListData>.NativeClassPtr);
			ObjectivesListData.NativeFieldInfoPtr_objectives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectivesListData>.NativeClassPtr, "objectives");
			ObjectivesListData.NativeFieldInfoPtr_completedObjectives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectivesListData>.NativeClassPtr, "completedObjectives");
			ObjectivesListData.NativeFieldInfoPtr_readonlyObjectives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectivesListData>.NativeClassPtr, "readonlyObjectives");
			ObjectivesListData.NativeFieldInfoPtr_objectivesData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectivesListData>.NativeClassPtr, "objectivesData");
			ObjectivesListData.NativeFieldInfoPtr_cachedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectivesListData>.NativeClassPtr, "cachedVersion");
			ObjectivesListData.NativeFieldInfoPtr_newDataScratch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectivesListData>.NativeClassPtr, "newDataScratch");
			ObjectivesListData.NativeMethodInfoPtr_get_Objectives_Public_get_ReadOnlyVersionedList_1_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectivesListData>.NativeClassPtr, 100664035);
			ObjectivesListData.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectivesListData>.NativeClassPtr, 100664036);
			ObjectivesListData.NativeMethodInfoPtr_updateData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectivesListData>.NativeClassPtr, 100664037);
			ObjectivesListData.NativeMethodInfoPtr_objectiveDataComparer_Private_Static_Int32_DataComposition_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectivesListData>.NativeClassPtr, 100664038);
			ObjectivesListData.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectivesListData>.NativeClassPtr, 100664039);
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x0002CDC4 File Offset: 0x0002AFC4
		public unsafe ReadOnlyVersionedList<DataComposition> Objectives
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 501164, RefRangeEnd = 501168, XrefRangeStart = 501158, XrefRangeEnd = 501164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectivesListData.NativeMethodInfoPtr_get_Objectives_Public_get_ReadOnlyVersionedList_1_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyVersionedList<DataComposition>>(intPtr3) : null;
			}
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0002CE04 File Offset: 0x0002B004
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 501204, RefRangeEnd = 501205, XrefRangeStart = 501168, XrefRangeEnd = 501204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectivesListData(EntityComponent entity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectivesListData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectivesListData.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0002CE50 File Offset: 0x0002B050
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 501279, RefRangeEnd = 501280, XrefRangeStart = 501205, XrefRangeEnd = 501279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectivesListData.NativeMethodInfoPtr_updateData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0002CE84 File Offset: 0x0002B084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501280, XrefRangeEnd = 501290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int objectiveDataComparer(DataComposition a, DataComposition b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectivesListData.NativeMethodInfoPtr_objectiveDataComparer_Private_Static_Int32_DataComposition_DataComposition_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x0002CED8 File Offset: 0x0002B0D8
		public unsafe virtual ulong Version
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 501295, RefRangeEnd = 501297, XrefRangeStart = 501290, XrefRangeEnd = 501295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectivesListData.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0000434D File Offset: 0x0000254D
		public ObjectivesListData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x0002CF14 File Offset: 0x0002B114
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x00004356 File Offset: 0x00002556
		public unsafe IAttribute<Il2CppReferenceArray<Objective>> objectives
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectivesListData.NativeFieldInfoPtr_objectives);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Il2CppReferenceArray<Objective>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectivesListData.NativeFieldInfoPtr_objectives), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x0002CF44 File Offset: 0x0002B144
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x00004375 File Offset: 0x00002575
		public unsafe IAttribute<Il2CppStructArray<int>> completedObjectives
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectivesListData.NativeFieldInfoPtr_completedObjectives);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Il2CppStructArray<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectivesListData.NativeFieldInfoPtr_completedObjectives), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x0002CF74 File Offset: 0x0002B174
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x00004394 File Offset: 0x00002594
		public unsafe ReadOnlyVersionedList<DataComposition> readonlyObjectives
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectivesListData.NativeFieldInfoPtr_readonlyObjectives);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyVersionedList<DataComposition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectivesListData.NativeFieldInfoPtr_readonlyObjectives), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x0002CFA4 File Offset: 0x0002B1A4
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x000043B3 File Offset: 0x000025B3
		public unsafe VersionedList<DataComposition> objectivesData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectivesListData.NativeFieldInfoPtr_objectivesData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedList<DataComposition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectivesListData.NativeFieldInfoPtr_objectivesData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x0002CFD4 File Offset: 0x0002B1D4
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x000043D2 File Offset: 0x000025D2
		public unsafe ulong cachedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectivesListData.NativeFieldInfoPtr_cachedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectivesListData.NativeFieldInfoPtr_cachedVersion)) = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x0002CFFC File Offset: 0x0002B1FC
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x000043ED File Offset: 0x000025ED
		public unsafe List<DataComposition> newDataScratch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectivesListData.NativeFieldInfoPtr_newDataScratch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DataComposition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectivesListData.NativeFieldInfoPtr_newDataScratch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeFieldInfoPtr_objectives;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeFieldInfoPtr_completedObjectives;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeFieldInfoPtr_readonlyObjectives;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeFieldInfoPtr_objectivesData;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeFieldInfoPtr_cachedVersion;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeFieldInfoPtr_newDataScratch;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr_get_Objectives_Public_get_ReadOnlyVersionedList_1_DataComposition_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_updateData_Private_Void_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_objectiveDataComparer_Private_Static_Int32_DataComposition_DataComposition_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x020002FC RID: 764
		[ObfuscatedName("dbgclient.ObjectivesListData+<>O")]
		public static class __O : Object
		{
			// Token: 0x06002401 RID: 9217 RVA: 0x00012B8C File Offset: 0x00010D8C
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<ObjectivesListData.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectivesListData>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectivesListData.__O>.NativeClassPtr);
				ObjectivesListData.__O.NativeFieldInfoPtr__0___objectiveDataComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectivesListData.__O>.NativeClassPtr, "<0>__objectiveDataComparer");
			}

			// Token: 0x06002402 RID: 9218 RVA: 0x00012BC0 File Offset: 0x00010DC0
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009CD RID: 2509
			// (get) Token: 0x06002403 RID: 9219 RVA: 0x000942F8 File Offset: 0x000924F8
			// (set) Token: 0x06002404 RID: 9220 RVA: 0x00012BC9 File Offset: 0x00010DC9
			public unsafe static Comparison<DataComposition> _0___objectiveDataComparer
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ObjectivesListData.__O.NativeFieldInfoPtr__0___objectiveDataComparer, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<DataComposition>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ObjectivesListData.__O.NativeFieldInfoPtr__0___objectiveDataComparer, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016A1 RID: 5793
			private static readonly IntPtr NativeFieldInfoPtr__0___objectiveDataComparer;
		}
	}
}
