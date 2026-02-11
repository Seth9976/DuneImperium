using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000BC RID: 188
	public sealed class ReflectionProbeManager : ValueType
	{
		// Token: 0x06000EDC RID: 3804 RVA: 0x00048C2C File Offset: 0x00046E2C
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionProbeManager()
		{
			Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ReflectionProbeManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr);
			ReflectionProbeManager.NativeFieldInfoPtr_m_Resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "m_Resolution");
			ReflectionProbeManager.NativeFieldInfoPtr_m_AtlasTexture0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "m_AtlasTexture0");
			ReflectionProbeManager.NativeFieldInfoPtr_m_AtlasTexture1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "m_AtlasTexture1");
			ReflectionProbeManager.NativeFieldInfoPtr_m_AtlasAllocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "m_AtlasAllocator");
			ReflectionProbeManager.NativeFieldInfoPtr_m_Cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "m_Cache");
			ReflectionProbeManager.NativeFieldInfoPtr_m_WarningCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "m_WarningCache");
			ReflectionProbeManager.NativeFieldInfoPtr_m_NeedsUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "m_NeedsUpdate");
			ReflectionProbeManager.NativeFieldInfoPtr_m_NeedsRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "m_NeedsRemove");
			ReflectionProbeManager.NativeFieldInfoPtr_m_BoxMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "m_BoxMax");
			ReflectionProbeManager.NativeFieldInfoPtr_m_BoxMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "m_BoxMin");
			ReflectionProbeManager.NativeFieldInfoPtr_m_ProbePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "m_ProbePosition");
			ReflectionProbeManager.NativeFieldInfoPtr_m_MipScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "m_MipScaleOffset");
			ReflectionProbeManager.NativeFieldInfoPtr_k_MaxMipCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "k_MaxMipCount");
			ReflectionProbeManager.NativeFieldInfoPtr_k_ReflectionProbeAtlasName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "k_ReflectionProbeAtlasName");
			ReflectionProbeManager.NativeMethodInfoPtr_get_atlasRT_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, 100665197);
			ReflectionProbeManager.NativeMethodInfoPtr_Create_Public_Static_ReflectionProbeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, 100665198);
			ReflectionProbeManager.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, 100665199);
			ReflectionProbeManager.NativeMethodInfoPtr_UpdateGpuData_Public_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, 100665200);
			ReflectionProbeManager.NativeMethodInfoPtr_GetScaleOffset_Private_float4_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, 100665201);
			ReflectionProbeManager.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, 100665202);
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06000EDD RID: 3805 RVA: 0x00048DEC File Offset: 0x00046FEC
		public unsafe RenderTexture atlasRT
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeManager.NativeMethodInfoPtr_get_atlasRT_Public_get_RenderTexture_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x00048E30 File Offset: 0x00047030
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 614573, RefRangeEnd = 614574, XrefRangeStart = 614572, XrefRangeEnd = 614573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReflectionProbeManager Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeManager.NativeMethodInfoPtr_Create_Public_Static_ReflectionProbeManager_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ReflectionProbeManager(intPtr);
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x00048E5C File Offset: 0x0004705C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 614643, RefRangeEnd = 614644, XrefRangeStart = 614574, XrefRangeEnd = 614643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeManager.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x00048E94 File Offset: 0x00047094
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 614865, RefRangeEnd = 614866, XrefRangeStart = 614644, XrefRangeEnd = 614865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGpuData(CommandBuffer cmd, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeManager.NativeMethodInfoPtr_UpdateGpuData_Public_Void_CommandBuffer_byref_RenderingData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x00048EF0 File Offset: 0x000470F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 614867, RefRangeEnd = 614870, XrefRangeStart = 614866, XrefRangeEnd = 614867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float4 GetScaleOffset(int level, int dataIndex, bool includePadding, bool yflip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includePadding;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yflip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeManager.NativeMethodInfoPtr_GetScaleOffset_Private_float4_Int32_Int32_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x00048F68 File Offset: 0x00047168
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 614879, RefRangeEnd = 614880, XrefRangeStart = 614870, XrefRangeEnd = 614879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeManager.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x0000923D File Offset: 0x0000743D
		public ReflectionProbeManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x00009246 File Offset: 0x00007446
		public ReflectionProbeManager()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr))
		{
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x00048FA0 File Offset: 0x000471A0
		// (set) Token: 0x06000EE6 RID: 3814 RVA: 0x00009258 File Offset: 0x00007458
		public unsafe int2 m_Resolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.NativeFieldInfoPtr_m_Resolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.NativeFieldInfoPtr_m_Resolution)) = value;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x00048FC8 File Offset: 0x000471C8
		// (set) Token: 0x06000EE8 RID: 3816 RVA: 0x00009273 File Offset: 0x00007473
		public unsafe RenderTexture m_AtlasTexture0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.NativeFieldInfoPtr_m_AtlasTexture0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.NativeFieldInfoPtr_m_AtlasTexture0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x00048FF8 File Offset: 0x000471F8
		// (set) Token: 0x06000EEA RID: 3818 RVA: 0x00009292 File Offset: 0x00007492
		public unsafe RenderTexture m_AtlasTexture1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.NativeFieldInfoPtr_m_AtlasTexture1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.NativeFieldInfoPtr_m_AtlasTexture1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x00049028 File Offset: 0x00047228
		// (set) Token: 0x06000EEC RID: 3820 RVA: 0x000092B1 File Offset: 0x000074B1
		public BuddyAllocator m_AtlasAllocator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.NativeFieldInfoPtr_m_AtlasAllocator);
				return new BuddyAllocator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.NativeFieldInfoPtr_m_AtlasAllocator), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06000EED RID: 3821 RVA: 0x00049058 File Offset: 0x00047258
		// (set) Token: 0x06000EEE RID: 3822 RVA: 0x000092DF File Offset: 0x000074DF
		public unsafe Dictionary<int, ReflectionProbeManager.CachedProbe> m_Cache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.NativeFieldInfoPtr_m_Cache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ReflectionProbeManager.CachedProbe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.NativeFieldInfoPtr_m_Cache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06000EEF RID: 3823 RVA: 0x00049088 File Offset: 0x00047288
		// (set) Token: 0x06000EF0 RID: 3824 RVA: 0x000092FE File Offset: 0x000074FE
		public unsafe Dictionary<int, int> m_WarningCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.NativeFieldInfoPtr_m_WarningCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.NativeFieldInfoPtr_m_WarningCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06000EF1 RID: 3825 RVA: 0x000490B8 File Offset: 0x000472B8
		// (set) Token: 0x06000EF2 RID: 3826 RVA: 0x0000931D File Offset: 0x0000751D
		public unsafe List<int> m_NeedsUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.NativeFieldInfoPtr_m_NeedsUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.NativeFieldInfoPtr_m_NeedsUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06000EF3 RID: 3827 RVA: 0x000490E8 File Offset: 0x000472E8
		// (set) Token: 0x06000EF4 RID: 3828 RVA: 0x0000933C File Offset: 0x0000753C
		public unsafe List<int> m_NeedsRemove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.NativeFieldInfoPtr_m_NeedsRemove);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.NativeFieldInfoPtr_m_NeedsRemove), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x00049118 File Offset: 0x00047318
		// (set) Token: 0x06000EF6 RID: 3830 RVA: 0x0000935B File Offset: 0x0000755B
		public unsafe Il2CppStructArray<Vector4> m_BoxMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.NativeFieldInfoPtr_m_BoxMax);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.NativeFieldInfoPtr_m_BoxMax), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x00049148 File Offset: 0x00047348
		// (set) Token: 0x06000EF8 RID: 3832 RVA: 0x0000937A File Offset: 0x0000757A
		public unsafe Il2CppStructArray<Vector4> m_BoxMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.NativeFieldInfoPtr_m_BoxMin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.NativeFieldInfoPtr_m_BoxMin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x00049178 File Offset: 0x00047378
		// (set) Token: 0x06000EFA RID: 3834 RVA: 0x00009399 File Offset: 0x00007599
		public unsafe Il2CppStructArray<Vector4> m_ProbePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.NativeFieldInfoPtr_m_ProbePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.NativeFieldInfoPtr_m_ProbePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x000491A8 File Offset: 0x000473A8
		// (set) Token: 0x06000EFC RID: 3836 RVA: 0x000093B8 File Offset: 0x000075B8
		public unsafe Il2CppStructArray<Vector4> m_MipScaleOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.NativeFieldInfoPtr_m_MipScaleOffset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.NativeFieldInfoPtr_m_MipScaleOffset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x000491D8 File Offset: 0x000473D8
		// (set) Token: 0x06000EFE RID: 3838 RVA: 0x000093D7 File Offset: 0x000075D7
		public unsafe static int k_MaxMipCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ReflectionProbeManager.NativeFieldInfoPtr_k_MaxMipCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionProbeManager.NativeFieldInfoPtr_k_MaxMipCount, (void*)(&value));
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06000EFF RID: 3839 RVA: 0x000491F4 File Offset: 0x000473F4
		// (set) Token: 0x06000F00 RID: 3840 RVA: 0x000093E5 File Offset: 0x000075E5
		public unsafe static string k_ReflectionProbeAtlasName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectionProbeManager.NativeFieldInfoPtr_k_ReflectionProbeAtlasName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionProbeManager.NativeFieldInfoPtr_k_ReflectionProbeAtlasName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000AD2 RID: 2770
		private static readonly IntPtr NativeFieldInfoPtr_m_Resolution;

		// Token: 0x04000AD3 RID: 2771
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasTexture0;

		// Token: 0x04000AD4 RID: 2772
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasTexture1;

		// Token: 0x04000AD5 RID: 2773
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasAllocator;

		// Token: 0x04000AD6 RID: 2774
		private static readonly IntPtr NativeFieldInfoPtr_m_Cache;

		// Token: 0x04000AD7 RID: 2775
		private static readonly IntPtr NativeFieldInfoPtr_m_WarningCache;

		// Token: 0x04000AD8 RID: 2776
		private static readonly IntPtr NativeFieldInfoPtr_m_NeedsUpdate;

		// Token: 0x04000AD9 RID: 2777
		private static readonly IntPtr NativeFieldInfoPtr_m_NeedsRemove;

		// Token: 0x04000ADA RID: 2778
		private static readonly IntPtr NativeFieldInfoPtr_m_BoxMax;

		// Token: 0x04000ADB RID: 2779
		private static readonly IntPtr NativeFieldInfoPtr_m_BoxMin;

		// Token: 0x04000ADC RID: 2780
		private static readonly IntPtr NativeFieldInfoPtr_m_ProbePosition;

		// Token: 0x04000ADD RID: 2781
		private static readonly IntPtr NativeFieldInfoPtr_m_MipScaleOffset;

		// Token: 0x04000ADE RID: 2782
		private static readonly IntPtr NativeFieldInfoPtr_k_MaxMipCount;

		// Token: 0x04000ADF RID: 2783
		private static readonly IntPtr NativeFieldInfoPtr_k_ReflectionProbeAtlasName;

		// Token: 0x04000AE0 RID: 2784
		private static readonly IntPtr NativeMethodInfoPtr_get_atlasRT_Public_get_RenderTexture_0;

		// Token: 0x04000AE1 RID: 2785
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ReflectionProbeManager_0;

		// Token: 0x04000AE2 RID: 2786
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x04000AE3 RID: 2787
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGpuData_Public_Void_CommandBuffer_byref_RenderingData_0;

		// Token: 0x04000AE4 RID: 2788
		private static readonly IntPtr NativeMethodInfoPtr_GetScaleOffset_Private_float4_Int32_Int32_Boolean_Boolean_0;

		// Token: 0x04000AE5 RID: 2789
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x020001B0 RID: 432
		public sealed class CachedProbe : ValueType
		{
			// Token: 0x06001F63 RID: 8035 RVA: 0x0007C018 File Offset: 0x0007A218
			// Note: this type is marked as 'beforefieldinit'.
			static CachedProbe()
			{
				Il2CppClassPointerStore<ReflectionProbeManager.CachedProbe>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "CachedProbe");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionProbeManager.CachedProbe>.NativeClassPtr);
				ReflectionProbeManager.CachedProbe.NativeFieldInfoPtr_updateCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager.CachedProbe>.NativeClassPtr, "updateCount");
				ReflectionProbeManager.CachedProbe.NativeFieldInfoPtr_imageContentsHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager.CachedProbe>.NativeClassPtr, "imageContentsHash");
				ReflectionProbeManager.CachedProbe.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager.CachedProbe>.NativeClassPtr, "size");
				ReflectionProbeManager.CachedProbe.NativeFieldInfoPtr_mipCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager.CachedProbe>.NativeClassPtr, "mipCount");
				ReflectionProbeManager.CachedProbe.NativeFieldInfoPtr_dataIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager.CachedProbe>.NativeClassPtr, "dataIndices");
				ReflectionProbeManager.CachedProbe.NativeFieldInfoPtr_levels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager.CachedProbe>.NativeClassPtr, "levels");
				ReflectionProbeManager.CachedProbe.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager.CachedProbe>.NativeClassPtr, "texture");
				ReflectionProbeManager.CachedProbe.NativeFieldInfoPtr_lastUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager.CachedProbe>.NativeClassPtr, "lastUsed");
				ReflectionProbeManager.CachedProbe.NativeFieldInfoPtr_hdrData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager.CachedProbe>.NativeClassPtr, "hdrData");
			}

			// Token: 0x06001F64 RID: 8036 RVA: 0x00011F8F File Offset: 0x0001018F
			public CachedProbe(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F65 RID: 8037 RVA: 0x00011F98 File Offset: 0x00010198
			public CachedProbe()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionProbeManager.CachedProbe>.NativeClassPtr))
			{
			}

			// Token: 0x17000B46 RID: 2886
			// (get) Token: 0x06001F66 RID: 8038 RVA: 0x0007C0F8 File Offset: 0x0007A2F8
			// (set) Token: 0x06001F67 RID: 8039 RVA: 0x00011FAA File Offset: 0x000101AA
			public unsafe uint updateCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.CachedProbe.NativeFieldInfoPtr_updateCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.CachedProbe.NativeFieldInfoPtr_updateCount)) = value;
				}
			}

			// Token: 0x17000B47 RID: 2887
			// (get) Token: 0x06001F68 RID: 8040 RVA: 0x0007C120 File Offset: 0x0007A320
			// (set) Token: 0x06001F69 RID: 8041 RVA: 0x00011FC5 File Offset: 0x000101C5
			public unsafe Hash128 imageContentsHash
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.CachedProbe.NativeFieldInfoPtr_imageContentsHash);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.CachedProbe.NativeFieldInfoPtr_imageContentsHash)) = value;
				}
			}

			// Token: 0x17000B48 RID: 2888
			// (get) Token: 0x06001F6A RID: 8042 RVA: 0x0007C148 File Offset: 0x0007A348
			// (set) Token: 0x06001F6B RID: 8043 RVA: 0x00011FE0 File Offset: 0x000101E0
			public unsafe int size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.CachedProbe.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.CachedProbe.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x17000B49 RID: 2889
			// (get) Token: 0x06001F6C RID: 8044 RVA: 0x0007C170 File Offset: 0x0007A370
			// (set) Token: 0x06001F6D RID: 8045 RVA: 0x00011FFB File Offset: 0x000101FB
			public unsafe int mipCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.CachedProbe.NativeFieldInfoPtr_mipCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.CachedProbe.NativeFieldInfoPtr_mipCount)) = value;
				}
			}

			// Token: 0x17000B4A RID: 2890
			// (get) Token: 0x06001F6E RID: 8046 RVA: 0x0007C198 File Offset: 0x0007A398
			// (set) Token: 0x06001F6F RID: 8047 RVA: 0x00012016 File Offset: 0x00010216
			public unsafe ReflectionProbeManager.CachedProbe._dataIndices_e__FixedBuffer dataIndices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.CachedProbe.NativeFieldInfoPtr_dataIndices);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.CachedProbe.NativeFieldInfoPtr_dataIndices)) = value;
				}
			}

			// Token: 0x17000B4B RID: 2891
			// (get) Token: 0x06001F70 RID: 8048 RVA: 0x0007C1C0 File Offset: 0x0007A3C0
			// (set) Token: 0x06001F71 RID: 8049 RVA: 0x00012031 File Offset: 0x00010231
			public unsafe ReflectionProbeManager.CachedProbe._levels_e__FixedBuffer levels
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.CachedProbe.NativeFieldInfoPtr_levels);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.CachedProbe.NativeFieldInfoPtr_levels)) = value;
				}
			}

			// Token: 0x17000B4C RID: 2892
			// (get) Token: 0x06001F72 RID: 8050 RVA: 0x0007C1E8 File Offset: 0x0007A3E8
			// (set) Token: 0x06001F73 RID: 8051 RVA: 0x0001204C File Offset: 0x0001024C
			public unsafe Texture texture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.CachedProbe.NativeFieldInfoPtr_texture);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.CachedProbe.NativeFieldInfoPtr_texture), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B4D RID: 2893
			// (get) Token: 0x06001F74 RID: 8052 RVA: 0x0007C218 File Offset: 0x0007A418
			// (set) Token: 0x06001F75 RID: 8053 RVA: 0x0001206B File Offset: 0x0001026B
			public unsafe int lastUsed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.CachedProbe.NativeFieldInfoPtr_lastUsed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.CachedProbe.NativeFieldInfoPtr_lastUsed)) = value;
				}
			}

			// Token: 0x17000B4E RID: 2894
			// (get) Token: 0x06001F76 RID: 8054 RVA: 0x0007C240 File Offset: 0x0007A440
			// (set) Token: 0x06001F77 RID: 8055 RVA: 0x00012086 File Offset: 0x00010286
			public unsafe Vector4 hdrData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.CachedProbe.NativeFieldInfoPtr_hdrData);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeManager.CachedProbe.NativeFieldInfoPtr_hdrData)) = value;
				}
			}

			// Token: 0x04001654 RID: 5716
			private static readonly IntPtr NativeFieldInfoPtr_updateCount;

			// Token: 0x04001655 RID: 5717
			private static readonly IntPtr NativeFieldInfoPtr_imageContentsHash;

			// Token: 0x04001656 RID: 5718
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x04001657 RID: 5719
			private static readonly IntPtr NativeFieldInfoPtr_mipCount;

			// Token: 0x04001658 RID: 5720
			private static readonly IntPtr NativeFieldInfoPtr_dataIndices;

			// Token: 0x04001659 RID: 5721
			private static readonly IntPtr NativeFieldInfoPtr_levels;

			// Token: 0x0400165A RID: 5722
			private static readonly IntPtr NativeFieldInfoPtr_texture;

			// Token: 0x0400165B RID: 5723
			private static readonly IntPtr NativeFieldInfoPtr_lastUsed;

			// Token: 0x0400165C RID: 5724
			private static readonly IntPtr NativeFieldInfoPtr_hdrData;

			// Token: 0x0200024A RID: 586
			[ObfuscatedName("UnityEngine.Rendering.Universal.ReflectionProbeManager+CachedProbe+<dataIndices>e__FixedBuffer")]
			[StructLayout(2)]
			public struct _dataIndices_e__FixedBuffer
			{
				// Token: 0x0600252F RID: 9519 RVA: 0x0001517F File Offset: 0x0001337F
				// Note: this type is marked as 'beforefieldinit'.
				static _dataIndices_e__FixedBuffer()
				{
					Il2CppClassPointerStore<ReflectionProbeManager.CachedProbe._dataIndices_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionProbeManager.CachedProbe>.NativeClassPtr, "<dataIndices>e__FixedBuffer");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionProbeManager.CachedProbe._dataIndices_e__FixedBuffer>.NativeClassPtr);
					ReflectionProbeManager.CachedProbe._dataIndices_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager.CachedProbe._dataIndices_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
				}

				// Token: 0x06002530 RID: 9520 RVA: 0x000151B3 File Offset: 0x000133B3
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReflectionProbeManager.CachedProbe._dataIndices_e__FixedBuffer>.NativeClassPtr, ref this));
				}

				// Token: 0x040019CE RID: 6606
				private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

				// Token: 0x040019CF RID: 6607
				[FieldOffset(0)]
				public int FixedElementField;
			}

			// Token: 0x0200024B RID: 587
			[ObfuscatedName("UnityEngine.Rendering.Universal.ReflectionProbeManager+CachedProbe+<levels>e__FixedBuffer")]
			[StructLayout(2)]
			public struct _levels_e__FixedBuffer
			{
				// Token: 0x06002531 RID: 9521 RVA: 0x000151C5 File Offset: 0x000133C5
				// Note: this type is marked as 'beforefieldinit'.
				static _levels_e__FixedBuffer()
				{
					Il2CppClassPointerStore<ReflectionProbeManager.CachedProbe._levels_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionProbeManager.CachedProbe>.NativeClassPtr, "<levels>e__FixedBuffer");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionProbeManager.CachedProbe._levels_e__FixedBuffer>.NativeClassPtr);
					ReflectionProbeManager.CachedProbe._levels_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager.CachedProbe._levels_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
				}

				// Token: 0x06002532 RID: 9522 RVA: 0x000151F9 File Offset: 0x000133F9
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReflectionProbeManager.CachedProbe._levels_e__FixedBuffer>.NativeClassPtr, ref this));
				}

				// Token: 0x040019D0 RID: 6608
				private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

				// Token: 0x040019D1 RID: 6609
				[FieldOffset(0)]
				public int FixedElementField;
			}
		}

		// Token: 0x020001B1 RID: 433
		public static class ShaderProperties : Object
		{
			// Token: 0x06001F78 RID: 8056 RVA: 0x0007C268 File Offset: 0x0007A468
			// Note: this type is marked as 'beforefieldinit'.
			static ShaderProperties()
			{
				Il2CppClassPointerStore<ReflectionProbeManager.ShaderProperties>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, "ShaderProperties");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionProbeManager.ShaderProperties>.NativeClassPtr);
				ReflectionProbeManager.ShaderProperties.NativeFieldInfoPtr_BoxMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager.ShaderProperties>.NativeClassPtr, "BoxMin");
				ReflectionProbeManager.ShaderProperties.NativeFieldInfoPtr_BoxMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager.ShaderProperties>.NativeClassPtr, "BoxMax");
				ReflectionProbeManager.ShaderProperties.NativeFieldInfoPtr_ProbePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager.ShaderProperties>.NativeClassPtr, "ProbePosition");
				ReflectionProbeManager.ShaderProperties.NativeFieldInfoPtr_MipScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager.ShaderProperties>.NativeClassPtr, "MipScaleOffset");
				ReflectionProbeManager.ShaderProperties.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager.ShaderProperties>.NativeClassPtr, "Count");
				ReflectionProbeManager.ShaderProperties.NativeFieldInfoPtr_Atlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeManager.ShaderProperties>.NativeClassPtr, "Atlas");
			}

			// Token: 0x06001F79 RID: 8057 RVA: 0x000120A1 File Offset: 0x000102A1
			public ShaderProperties(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B4F RID: 2895
			// (get) Token: 0x06001F7A RID: 8058 RVA: 0x0007C30C File Offset: 0x0007A50C
			// (set) Token: 0x06001F7B RID: 8059 RVA: 0x000120AA File Offset: 0x000102AA
			public unsafe static int BoxMin
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ReflectionProbeManager.ShaderProperties.NativeFieldInfoPtr_BoxMin, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReflectionProbeManager.ShaderProperties.NativeFieldInfoPtr_BoxMin, (void*)(&value));
				}
			}

			// Token: 0x17000B50 RID: 2896
			// (get) Token: 0x06001F7C RID: 8060 RVA: 0x0007C328 File Offset: 0x0007A528
			// (set) Token: 0x06001F7D RID: 8061 RVA: 0x000120B8 File Offset: 0x000102B8
			public unsafe static int BoxMax
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ReflectionProbeManager.ShaderProperties.NativeFieldInfoPtr_BoxMax, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReflectionProbeManager.ShaderProperties.NativeFieldInfoPtr_BoxMax, (void*)(&value));
				}
			}

			// Token: 0x17000B51 RID: 2897
			// (get) Token: 0x06001F7E RID: 8062 RVA: 0x0007C344 File Offset: 0x0007A544
			// (set) Token: 0x06001F7F RID: 8063 RVA: 0x000120C6 File Offset: 0x000102C6
			public unsafe static int ProbePosition
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ReflectionProbeManager.ShaderProperties.NativeFieldInfoPtr_ProbePosition, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReflectionProbeManager.ShaderProperties.NativeFieldInfoPtr_ProbePosition, (void*)(&value));
				}
			}

			// Token: 0x17000B52 RID: 2898
			// (get) Token: 0x06001F80 RID: 8064 RVA: 0x0007C360 File Offset: 0x0007A560
			// (set) Token: 0x06001F81 RID: 8065 RVA: 0x000120D4 File Offset: 0x000102D4
			public unsafe static int MipScaleOffset
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ReflectionProbeManager.ShaderProperties.NativeFieldInfoPtr_MipScaleOffset, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReflectionProbeManager.ShaderProperties.NativeFieldInfoPtr_MipScaleOffset, (void*)(&value));
				}
			}

			// Token: 0x17000B53 RID: 2899
			// (get) Token: 0x06001F82 RID: 8066 RVA: 0x0007C37C File Offset: 0x0007A57C
			// (set) Token: 0x06001F83 RID: 8067 RVA: 0x000120E2 File Offset: 0x000102E2
			public unsafe static int Count
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ReflectionProbeManager.ShaderProperties.NativeFieldInfoPtr_Count, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReflectionProbeManager.ShaderProperties.NativeFieldInfoPtr_Count, (void*)(&value));
				}
			}

			// Token: 0x17000B54 RID: 2900
			// (get) Token: 0x06001F84 RID: 8068 RVA: 0x0007C398 File Offset: 0x0007A598
			// (set) Token: 0x06001F85 RID: 8069 RVA: 0x000120F0 File Offset: 0x000102F0
			public unsafe static int Atlas
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ReflectionProbeManager.ShaderProperties.NativeFieldInfoPtr_Atlas, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReflectionProbeManager.ShaderProperties.NativeFieldInfoPtr_Atlas, (void*)(&value));
				}
			}

			// Token: 0x0400165D RID: 5725
			private static readonly IntPtr NativeFieldInfoPtr_BoxMin;

			// Token: 0x0400165E RID: 5726
			private static readonly IntPtr NativeFieldInfoPtr_BoxMax;

			// Token: 0x0400165F RID: 5727
			private static readonly IntPtr NativeFieldInfoPtr_ProbePosition;

			// Token: 0x04001660 RID: 5728
			private static readonly IntPtr NativeFieldInfoPtr_MipScaleOffset;

			// Token: 0x04001661 RID: 5729
			private static readonly IntPtr NativeFieldInfoPtr_Count;

			// Token: 0x04001662 RID: 5730
			private static readonly IntPtr NativeFieldInfoPtr_Atlas;
		}
	}
}
