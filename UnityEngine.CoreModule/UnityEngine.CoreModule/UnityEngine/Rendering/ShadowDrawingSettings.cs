using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000248 RID: 584
	[StructLayout(2)]
	public struct ShadowDrawingSettings
	{
		// Token: 0x0600277F RID: 10111 RVA: 0x000A6C90 File Offset: 0x000A4E90
		// Note: this type is marked as 'beforefieldinit'.
		static ShadowDrawingSettings()
		{
			Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ShadowDrawingSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr);
			ShadowDrawingSettings.NativeFieldInfoPtr_m_CullingResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, "m_CullingResults");
			ShadowDrawingSettings.NativeFieldInfoPtr_m_LightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, "m_LightIndex");
			ShadowDrawingSettings.NativeFieldInfoPtr_m_UseRenderingLayerMaskTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, "m_UseRenderingLayerMaskTest");
			ShadowDrawingSettings.NativeFieldInfoPtr_m_SplitData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, "m_SplitData");
			ShadowDrawingSettings.NativeFieldInfoPtr_m_ObjectsFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, "m_ObjectsFilter");
			ShadowDrawingSettings.NativeFieldInfoPtr_m_ProjectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, "m_ProjectionType");
			ShadowDrawingSettings.NativeMethodInfoPtr_set_useRenderingLayerMaskTest_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, 100668370);
			ShadowDrawingSettings.NativeMethodInfoPtr_set_splitData_Public_set_Void_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, 100668371);
			ShadowDrawingSettings.NativeMethodInfoPtr__ctor_Public_Void_CullingResults_Int32_BatchCullingProjectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, 100668372);
			ShadowDrawingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShadowDrawingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, 100668373);
			ShadowDrawingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, 100668374);
			ShadowDrawingSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, 100668375);
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x0600278B RID: 10123 RVA: 0x000A6F4C File Offset: 0x000A514C
		// (set) Token: 0x06002780 RID: 10112 RVA: 0x000A6DB0 File Offset: 0x000A4FB0
		public unsafe bool useRenderingLayerMaskTest
		{
			get
			{
				return this.m_UseRenderingLayerMaskTest != 0;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 684964, RefRangeEnd = 684966, XrefRangeStart = 684964, XrefRangeEnd = 684964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowDrawingSettings.NativeMethodInfoPtr_set_useRenderingLayerMaskTest_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x0600278C RID: 10124 RVA: 0x000A6F68 File Offset: 0x000A5168
		// (set) Token: 0x06002781 RID: 10113 RVA: 0x000A6DE4 File Offset: 0x000A4FE4
		public unsafe ShadowSplitData splitData
		{
			get
			{
				return this.m_SplitData;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 684966, RefRangeEnd = 684968, XrefRangeStart = 684966, XrefRangeEnd = 684966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowDrawingSettings.NativeMethodInfoPtr_set_splitData_Public_set_Void_ShadowSplitData_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x000A6E18 File Offset: 0x000A5018
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 684973, RefRangeEnd = 684975, XrefRangeStart = 684968, XrefRangeEnd = 684973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShadowDrawingSettings(CullingResults cullingResults, int lightIndex, BatchCullingProjectionType projectionType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cullingResults;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref projectionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowDrawingSettings.NativeMethodInfoPtr__ctor_Public_Void_CullingResults_Int32_BatchCullingProjectionType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x000A6E68 File Offset: 0x000A5068
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684990, RefRangeEnd = 684991, XrefRangeStart = 684975, XrefRangeEnd = 684990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ShadowDrawingSettings other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowDrawingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShadowDrawingSettings_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x000A6EA8 File Offset: 0x000A50A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684991, XrefRangeEnd = 684995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowDrawingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x000A6EEC File Offset: 0x000A50EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684995, XrefRangeEnd = 685000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowDrawingSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x0000F579 File Offset: 0x0000D779
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, ref this));
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06002787 RID: 10119 RVA: 0x000A6F1C File Offset: 0x000A511C
		// (set) Token: 0x06002788 RID: 10120 RVA: 0x0000F58B File Offset: 0x0000D78B
		public CullingResults cullingResults
		{
			get
			{
				return this.m_CullingResults;
			}
			set
			{
				this.m_CullingResults = value;
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06002789 RID: 10121 RVA: 0x000A6F34 File Offset: 0x000A5134
		// (set) Token: 0x0600278A RID: 10122 RVA: 0x0000F595 File Offset: 0x0000D795
		public int lightIndex
		{
			get
			{
				return this.m_LightIndex;
			}
			set
			{
				this.m_LightIndex = value;
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x0600278D RID: 10125 RVA: 0x000A6F80 File Offset: 0x000A5180
		// (set) Token: 0x0600278E RID: 10126 RVA: 0x0000F59F File Offset: 0x0000D79F
		public ShadowObjectsFilter objectsFilter
		{
			get
			{
				return this.m_ObjectsFilter;
			}
			set
			{
				this.m_ObjectsFilter = value;
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x0600278F RID: 10127 RVA: 0x000A6F98 File Offset: 0x000A5198
		// (set) Token: 0x06002790 RID: 10128 RVA: 0x0000F5A9 File Offset: 0x0000D7A9
		public BatchCullingProjectionType projectionType
		{
			get
			{
				return this.m_ProjectionType;
			}
			set
			{
				this.m_ProjectionType = value;
			}
		}

		// Token: 0x06002791 RID: 10129 RVA: 0x000A6FB0 File Offset: 0x000A51B0
		public static bool operator ==(ShadowDrawingSettings left, ShadowDrawingSettings right)
		{
			return left.Equals(right);
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x000A6FCC File Offset: 0x000A51CC
		public static bool operator !=(ShadowDrawingSettings left, ShadowDrawingSettings right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04002338 RID: 9016
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingResults;

		// Token: 0x04002339 RID: 9017
		private static readonly IntPtr NativeFieldInfoPtr_m_LightIndex;

		// Token: 0x0400233A RID: 9018
		private static readonly IntPtr NativeFieldInfoPtr_m_UseRenderingLayerMaskTest;

		// Token: 0x0400233B RID: 9019
		private static readonly IntPtr NativeFieldInfoPtr_m_SplitData;

		// Token: 0x0400233C RID: 9020
		private static readonly IntPtr NativeFieldInfoPtr_m_ObjectsFilter;

		// Token: 0x0400233D RID: 9021
		private static readonly IntPtr NativeFieldInfoPtr_m_ProjectionType;

		// Token: 0x0400233E RID: 9022
		private static readonly IntPtr NativeMethodInfoPtr_set_useRenderingLayerMaskTest_Public_set_Void_Boolean_0;

		// Token: 0x0400233F RID: 9023
		private static readonly IntPtr NativeMethodInfoPtr_set_splitData_Public_set_Void_ShadowSplitData_0;

		// Token: 0x04002340 RID: 9024
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CullingResults_Int32_BatchCullingProjectionType_0;

		// Token: 0x04002341 RID: 9025
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShadowDrawingSettings_0;

		// Token: 0x04002342 RID: 9026
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002343 RID: 9027
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002344 RID: 9028
		[FieldOffset(0)]
		public CullingResults m_CullingResults;

		// Token: 0x04002345 RID: 9029
		[FieldOffset(16)]
		public int m_LightIndex;

		// Token: 0x04002346 RID: 9030
		[FieldOffset(20)]
		public int m_UseRenderingLayerMaskTest;

		// Token: 0x04002347 RID: 9031
		[FieldOffset(24)]
		public ShadowSplitData m_SplitData;

		// Token: 0x04002348 RID: 9032
		[FieldOffset(276)]
		public ShadowObjectsFilter m_ObjectsFilter;

		// Token: 0x04002349 RID: 9033
		[FieldOffset(280)]
		public BatchCullingProjectionType m_ProjectionType;
	}
}
