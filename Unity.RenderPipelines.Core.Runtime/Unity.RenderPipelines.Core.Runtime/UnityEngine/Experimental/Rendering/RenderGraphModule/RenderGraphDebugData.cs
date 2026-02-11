using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x02000014 RID: 20
	public class RenderGraphDebugData : Object
	{
		// Token: 0x0600017F RID: 383 RVA: 0x00012AB8 File Offset: 0x00010CB8
		// Note: this type is marked as 'beforefieldinit'.
		static RenderGraphDebugData()
		{
			Il2CppClassPointerStore<RenderGraphDebugData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "RenderGraphDebugData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphDebugData>.NativeClassPtr);
			RenderGraphDebugData.NativeFieldInfoPtr_passList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugData>.NativeClassPtr, "passList");
			RenderGraphDebugData.NativeFieldInfoPtr_resourceLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugData>.NativeClassPtr, "resourceLists");
			RenderGraphDebugData.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugData>.NativeClassPtr, 100663437);
			RenderGraphDebugData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugData>.NativeClassPtr, 100663438);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00012B38 File Offset: 0x00010D38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 954779, RefRangeEnd = 954780, XrefRangeStart = 954767, XrefRangeEnd = 954779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDebugData.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00012B6C File Offset: 0x00010D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954780, XrefRangeEnd = 954792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderGraphDebugData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphDebugData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDebugData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002AE5 File Offset: 0x00000CE5
		public RenderGraphDebugData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00012BA8 File Offset: 0x00010DA8
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00002AEE File Offset: 0x00000CEE
		public unsafe List<RenderGraphDebugData.PassDebugData> passList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.NativeFieldInfoPtr_passList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RenderGraphDebugData.PassDebugData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.NativeFieldInfoPtr_passList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00012BD8 File Offset: 0x00010DD8
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00002B0D File Offset: 0x00000D0D
		public unsafe Il2CppReferenceArray<List<RenderGraphDebugData.ResourceDebugData>> resourceLists
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.NativeFieldInfoPtr_resourceLists);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<RenderGraphDebugData.ResourceDebugData>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.NativeFieldInfoPtr_resourceLists), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeFieldInfoPtr_passList;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeFieldInfoPtr_resourceLists;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000146 RID: 326
		public sealed class PassDebugData : ValueType
		{
			// Token: 0x06001530 RID: 5424 RVA: 0x0005D0B4 File Offset: 0x0005B2B4
			// Note: this type is marked as 'beforefieldinit'.
			static PassDebugData()
			{
				Il2CppClassPointerStore<RenderGraphDebugData.PassDebugData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraphDebugData>.NativeClassPtr, "PassDebugData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphDebugData.PassDebugData>.NativeClassPtr);
				RenderGraphDebugData.PassDebugData.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugData.PassDebugData>.NativeClassPtr, "name");
				RenderGraphDebugData.PassDebugData.NativeFieldInfoPtr_resourceReadLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugData.PassDebugData>.NativeClassPtr, "resourceReadLists");
				RenderGraphDebugData.PassDebugData.NativeFieldInfoPtr_resourceWriteLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugData.PassDebugData>.NativeClassPtr, "resourceWriteLists");
				RenderGraphDebugData.PassDebugData.NativeFieldInfoPtr_culled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugData.PassDebugData>.NativeClassPtr, "culled");
				RenderGraphDebugData.PassDebugData.NativeFieldInfoPtr_async = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugData.PassDebugData>.NativeClassPtr, "async");
				RenderGraphDebugData.PassDebugData.NativeFieldInfoPtr_syncToPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugData.PassDebugData>.NativeClassPtr, "syncToPassIndex");
				RenderGraphDebugData.PassDebugData.NativeFieldInfoPtr_syncFromPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugData.PassDebugData>.NativeClassPtr, "syncFromPassIndex");
				RenderGraphDebugData.PassDebugData.NativeFieldInfoPtr_generateDebugData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugData.PassDebugData>.NativeClassPtr, "generateDebugData");
			}

			// Token: 0x06001531 RID: 5425 RVA: 0x0000AB11 File Offset: 0x00008D11
			public PassDebugData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001532 RID: 5426 RVA: 0x0000AB1A File Offset: 0x00008D1A
			public PassDebugData()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphDebugData.PassDebugData>.NativeClassPtr))
			{
			}

			// Token: 0x170005F3 RID: 1523
			// (get) Token: 0x06001533 RID: 5427 RVA: 0x0005D180 File Offset: 0x0005B380
			// (set) Token: 0x06001534 RID: 5428 RVA: 0x0000AB2C File Offset: 0x00008D2C
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.PassDebugData.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.PassDebugData.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170005F4 RID: 1524
			// (get) Token: 0x06001535 RID: 5429 RVA: 0x0005D1A8 File Offset: 0x0005B3A8
			// (set) Token: 0x06001536 RID: 5430 RVA: 0x0000AB4B File Offset: 0x00008D4B
			public unsafe Il2CppReferenceArray<List<int>> resourceReadLists
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.PassDebugData.NativeFieldInfoPtr_resourceReadLists);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.PassDebugData.NativeFieldInfoPtr_resourceReadLists), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005F5 RID: 1525
			// (get) Token: 0x06001537 RID: 5431 RVA: 0x0005D1D8 File Offset: 0x0005B3D8
			// (set) Token: 0x06001538 RID: 5432 RVA: 0x0000AB6A File Offset: 0x00008D6A
			public unsafe Il2CppReferenceArray<List<int>> resourceWriteLists
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.PassDebugData.NativeFieldInfoPtr_resourceWriteLists);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.PassDebugData.NativeFieldInfoPtr_resourceWriteLists), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005F6 RID: 1526
			// (get) Token: 0x06001539 RID: 5433 RVA: 0x0005D208 File Offset: 0x0005B408
			// (set) Token: 0x0600153A RID: 5434 RVA: 0x0000AB89 File Offset: 0x00008D89
			public unsafe bool culled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.PassDebugData.NativeFieldInfoPtr_culled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.PassDebugData.NativeFieldInfoPtr_culled)) = value;
				}
			}

			// Token: 0x170005F7 RID: 1527
			// (get) Token: 0x0600153B RID: 5435 RVA: 0x0005D230 File Offset: 0x0005B430
			// (set) Token: 0x0600153C RID: 5436 RVA: 0x0000ABA4 File Offset: 0x00008DA4
			public unsafe bool async
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.PassDebugData.NativeFieldInfoPtr_async);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.PassDebugData.NativeFieldInfoPtr_async)) = value;
				}
			}

			// Token: 0x170005F8 RID: 1528
			// (get) Token: 0x0600153D RID: 5437 RVA: 0x0005D258 File Offset: 0x0005B458
			// (set) Token: 0x0600153E RID: 5438 RVA: 0x0000ABBF File Offset: 0x00008DBF
			public unsafe int syncToPassIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.PassDebugData.NativeFieldInfoPtr_syncToPassIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.PassDebugData.NativeFieldInfoPtr_syncToPassIndex)) = value;
				}
			}

			// Token: 0x170005F9 RID: 1529
			// (get) Token: 0x0600153F RID: 5439 RVA: 0x0005D280 File Offset: 0x0005B480
			// (set) Token: 0x06001540 RID: 5440 RVA: 0x0000ABDA File Offset: 0x00008DDA
			public unsafe int syncFromPassIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.PassDebugData.NativeFieldInfoPtr_syncFromPassIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.PassDebugData.NativeFieldInfoPtr_syncFromPassIndex)) = value;
				}
			}

			// Token: 0x170005FA RID: 1530
			// (get) Token: 0x06001541 RID: 5441 RVA: 0x0005D2A8 File Offset: 0x0005B4A8
			// (set) Token: 0x06001542 RID: 5442 RVA: 0x0000ABF5 File Offset: 0x00008DF5
			public unsafe bool generateDebugData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.PassDebugData.NativeFieldInfoPtr_generateDebugData);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.PassDebugData.NativeFieldInfoPtr_generateDebugData)) = value;
				}
			}

			// Token: 0x04000F96 RID: 3990
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04000F97 RID: 3991
			private static readonly IntPtr NativeFieldInfoPtr_resourceReadLists;

			// Token: 0x04000F98 RID: 3992
			private static readonly IntPtr NativeFieldInfoPtr_resourceWriteLists;

			// Token: 0x04000F99 RID: 3993
			private static readonly IntPtr NativeFieldInfoPtr_culled;

			// Token: 0x04000F9A RID: 3994
			private static readonly IntPtr NativeFieldInfoPtr_async;

			// Token: 0x04000F9B RID: 3995
			private static readonly IntPtr NativeFieldInfoPtr_syncToPassIndex;

			// Token: 0x04000F9C RID: 3996
			private static readonly IntPtr NativeFieldInfoPtr_syncFromPassIndex;

			// Token: 0x04000F9D RID: 3997
			private static readonly IntPtr NativeFieldInfoPtr_generateDebugData;
		}

		// Token: 0x02000147 RID: 327
		public sealed class ResourceDebugData : ValueType
		{
			// Token: 0x06001543 RID: 5443 RVA: 0x0005D2D0 File Offset: 0x0005B4D0
			// Note: this type is marked as 'beforefieldinit'.
			static ResourceDebugData()
			{
				Il2CppClassPointerStore<RenderGraphDebugData.ResourceDebugData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraphDebugData>.NativeClassPtr, "ResourceDebugData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphDebugData.ResourceDebugData>.NativeClassPtr);
				RenderGraphDebugData.ResourceDebugData.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugData.ResourceDebugData>.NativeClassPtr, "name");
				RenderGraphDebugData.ResourceDebugData.NativeFieldInfoPtr_imported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugData.ResourceDebugData>.NativeClassPtr, "imported");
				RenderGraphDebugData.ResourceDebugData.NativeFieldInfoPtr_creationPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugData.ResourceDebugData>.NativeClassPtr, "creationPassIndex");
				RenderGraphDebugData.ResourceDebugData.NativeFieldInfoPtr_releasePassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugData.ResourceDebugData>.NativeClassPtr, "releasePassIndex");
				RenderGraphDebugData.ResourceDebugData.NativeFieldInfoPtr_consumerList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugData.ResourceDebugData>.NativeClassPtr, "consumerList");
				RenderGraphDebugData.ResourceDebugData.NativeFieldInfoPtr_producerList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugData.ResourceDebugData>.NativeClassPtr, "producerList");
			}

			// Token: 0x06001544 RID: 5444 RVA: 0x0000AC10 File Offset: 0x00008E10
			public ResourceDebugData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001545 RID: 5445 RVA: 0x0000AC19 File Offset: 0x00008E19
			public ResourceDebugData()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphDebugData.ResourceDebugData>.NativeClassPtr))
			{
			}

			// Token: 0x170005FB RID: 1531
			// (get) Token: 0x06001546 RID: 5446 RVA: 0x0005D374 File Offset: 0x0005B574
			// (set) Token: 0x06001547 RID: 5447 RVA: 0x0000AC2B File Offset: 0x00008E2B
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.ResourceDebugData.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.ResourceDebugData.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170005FC RID: 1532
			// (get) Token: 0x06001548 RID: 5448 RVA: 0x0005D39C File Offset: 0x0005B59C
			// (set) Token: 0x06001549 RID: 5449 RVA: 0x0000AC4A File Offset: 0x00008E4A
			public unsafe bool imported
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.ResourceDebugData.NativeFieldInfoPtr_imported);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.ResourceDebugData.NativeFieldInfoPtr_imported)) = value;
				}
			}

			// Token: 0x170005FD RID: 1533
			// (get) Token: 0x0600154A RID: 5450 RVA: 0x0005D3C4 File Offset: 0x0005B5C4
			// (set) Token: 0x0600154B RID: 5451 RVA: 0x0000AC65 File Offset: 0x00008E65
			public unsafe int creationPassIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.ResourceDebugData.NativeFieldInfoPtr_creationPassIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.ResourceDebugData.NativeFieldInfoPtr_creationPassIndex)) = value;
				}
			}

			// Token: 0x170005FE RID: 1534
			// (get) Token: 0x0600154C RID: 5452 RVA: 0x0005D3EC File Offset: 0x0005B5EC
			// (set) Token: 0x0600154D RID: 5453 RVA: 0x0000AC80 File Offset: 0x00008E80
			public unsafe int releasePassIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.ResourceDebugData.NativeFieldInfoPtr_releasePassIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.ResourceDebugData.NativeFieldInfoPtr_releasePassIndex)) = value;
				}
			}

			// Token: 0x170005FF RID: 1535
			// (get) Token: 0x0600154E RID: 5454 RVA: 0x0005D414 File Offset: 0x0005B614
			// (set) Token: 0x0600154F RID: 5455 RVA: 0x0000AC9B File Offset: 0x00008E9B
			public unsafe List<int> consumerList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.ResourceDebugData.NativeFieldInfoPtr_consumerList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.ResourceDebugData.NativeFieldInfoPtr_consumerList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000600 RID: 1536
			// (get) Token: 0x06001550 RID: 5456 RVA: 0x0005D444 File Offset: 0x0005B644
			// (set) Token: 0x06001551 RID: 5457 RVA: 0x0000ACBA File Offset: 0x00008EBA
			public unsafe List<int> producerList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.ResourceDebugData.NativeFieldInfoPtr_producerList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugData.ResourceDebugData.NativeFieldInfoPtr_producerList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F9E RID: 3998
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04000F9F RID: 3999
			private static readonly IntPtr NativeFieldInfoPtr_imported;

			// Token: 0x04000FA0 RID: 4000
			private static readonly IntPtr NativeFieldInfoPtr_creationPassIndex;

			// Token: 0x04000FA1 RID: 4001
			private static readonly IntPtr NativeFieldInfoPtr_releasePassIndex;

			// Token: 0x04000FA2 RID: 4002
			private static readonly IntPtr NativeFieldInfoPtr_consumerList;

			// Token: 0x04000FA3 RID: 4003
			private static readonly IntPtr NativeFieldInfoPtr_producerList;
		}
	}
}
