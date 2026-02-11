using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine.UI
{
	// Token: 0x02000039 RID: 57
	public static class StencilMaterial : Object
	{
		// Token: 0x0600075A RID: 1882 RVA: 0x00023BE4 File Offset: 0x00021DE4
		// Note: this type is marked as 'beforefieldinit'.
		static StencilMaterial()
		{
			Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "StencilMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr);
			StencilMaterial.NativeFieldInfoPtr_m_List = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr, "m_List");
			StencilMaterial.NativeMethodInfoPtr_Add_Public_Static_Material_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr, 100664474);
			StencilMaterial.NativeMethodInfoPtr_Add_Public_Static_Material_Material_Int32_StencilOp_CompareFunction_ColorWriteMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr, 100664475);
			StencilMaterial.NativeMethodInfoPtr_LogWarningWhenNotInBatchmode_Private_Static_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr, 100664476);
			StencilMaterial.NativeMethodInfoPtr_Add_Public_Static_Material_Material_Int32_StencilOp_CompareFunction_ColorWriteMask_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr, 100664477);
			StencilMaterial.NativeMethodInfoPtr_Remove_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr, 100664478);
			StencilMaterial.NativeMethodInfoPtr_ClearAll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr, 100664479);
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00023CA0 File Offset: 0x00021EA0
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material Add(Material baseMat, int stencilID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMat);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilMaterial.NativeMethodInfoPtr_Add_Public_Static_Material_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00023CF4 File Offset: 0x00021EF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1092414, RefRangeEnd = 1092416, XrefRangeStart = 1092410, XrefRangeEnd = 1092414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMat);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref operation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compareFunction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorWriteMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilMaterial.NativeMethodInfoPtr_Add_Public_Static_Material_Material_Int32_StencilOp_CompareFunction_ColorWriteMask_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00023D70 File Offset: 0x00021F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092416, XrefRangeEnd = 1092424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarningWhenNotInBatchmode(string warning, Object context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(warning);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilMaterial.NativeMethodInfoPtr_LogWarningWhenNotInBatchmode_Private_Static_Void_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00023DB8 File Offset: 0x00021FB8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1092480, RefRangeEnd = 1092486, XrefRangeStart = 1092424, XrefRangeEnd = 1092480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMat);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref operation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compareFunction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorWriteMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readMask;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilMaterial.NativeMethodInfoPtr_Add_Public_Static_Material_Material_Int32_StencilOp_CompareFunction_ColorWriteMask_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00023E50 File Offset: 0x00022050
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1092513, RefRangeEnd = 1092523, XrefRangeStart = 1092486, XrefRangeEnd = 1092513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Remove(Material customMat)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(customMat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilMaterial.NativeMethodInfoPtr_Remove_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00023E88 File Offset: 0x00022088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092523, XrefRangeEnd = 1092540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilMaterial.NativeMethodInfoPtr_ClearAll_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x000048D7 File Offset: 0x00002AD7
		public StencilMaterial(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x00023EB0 File Offset: 0x000220B0
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x000048E0 File Offset: 0x00002AE0
		public unsafe static List<StencilMaterial.MatEntry> m_List
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StencilMaterial.NativeFieldInfoPtr_m_List, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StencilMaterial.MatEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StencilMaterial.NativeFieldInfoPtr_m_List, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeFieldInfoPtr_m_List;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_Material_Material_Int32_0;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_Material_Material_Int32_StencilOp_CompareFunction_ColorWriteMask_0;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeMethodInfoPtr_LogWarningWhenNotInBatchmode_Private_Static_Void_String_Object_0;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_Material_Material_Int32_StencilOp_CompareFunction_ColorWriteMask_Int32_Int32_0;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Static_Void_Material_0;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeMethodInfoPtr_ClearAll_Public_Static_Void_0;

		// Token: 0x020000B7 RID: 183
		public class MatEntry : Object
		{
			// Token: 0x06000CD9 RID: 3289 RVA: 0x00037828 File Offset: 0x00035A28
			// Note: this type is marked as 'beforefieldinit'.
			static MatEntry()
			{
				Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StencilMaterial>.NativeClassPtr, "MatEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr);
				StencilMaterial.MatEntry.NativeFieldInfoPtr_baseMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "baseMat");
				StencilMaterial.MatEntry.NativeFieldInfoPtr_customMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "customMat");
				StencilMaterial.MatEntry.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "count");
				StencilMaterial.MatEntry.NativeFieldInfoPtr_stencilId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "stencilId");
				StencilMaterial.MatEntry.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "operation");
				StencilMaterial.MatEntry.NativeFieldInfoPtr_compareFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "compareFunction");
				StencilMaterial.MatEntry.NativeFieldInfoPtr_readMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "readMask");
				StencilMaterial.MatEntry.NativeFieldInfoPtr_writeMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "writeMask");
				StencilMaterial.MatEntry.NativeFieldInfoPtr_useAlphaClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "useAlphaClip");
				StencilMaterial.MatEntry.NativeFieldInfoPtr_colorMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, "colorMask");
				StencilMaterial.MatEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr, 100664481);
			}

			// Token: 0x06000CDA RID: 3290 RVA: 0x00037930 File Offset: 0x00035B30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092409, XrefRangeEnd = 1092410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MatEntry()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StencilMaterial.MatEntry>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilMaterial.MatEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CDB RID: 3291 RVA: 0x00006D83 File Offset: 0x00004F83
			public MatEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700043C RID: 1084
			// (get) Token: 0x06000CDC RID: 3292 RVA: 0x0003796C File Offset: 0x00035B6C
			// (set) Token: 0x06000CDD RID: 3293 RVA: 0x00006D8C File Offset: 0x00004F8C
			public unsafe Material baseMat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_baseMat);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_baseMat), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700043D RID: 1085
			// (get) Token: 0x06000CDE RID: 3294 RVA: 0x0003799C File Offset: 0x00035B9C
			// (set) Token: 0x06000CDF RID: 3295 RVA: 0x00006DAB File Offset: 0x00004FAB
			public unsafe Material customMat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_customMat);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_customMat), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700043E RID: 1086
			// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x000379CC File Offset: 0x00035BCC
			// (set) Token: 0x06000CE1 RID: 3297 RVA: 0x00006DCA File Offset: 0x00004FCA
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x1700043F RID: 1087
			// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x000379F4 File Offset: 0x00035BF4
			// (set) Token: 0x06000CE3 RID: 3299 RVA: 0x00006DE5 File Offset: 0x00004FE5
			public unsafe int stencilId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_stencilId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_stencilId)) = value;
				}
			}

			// Token: 0x17000440 RID: 1088
			// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x00037A1C File Offset: 0x00035C1C
			// (set) Token: 0x06000CE5 RID: 3301 RVA: 0x00006E00 File Offset: 0x00005000
			public unsafe StencilOp operation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_operation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_operation)) = value;
				}
			}

			// Token: 0x17000441 RID: 1089
			// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x00037A44 File Offset: 0x00035C44
			// (set) Token: 0x06000CE7 RID: 3303 RVA: 0x00006E1B File Offset: 0x0000501B
			public unsafe CompareFunction compareFunction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_compareFunction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_compareFunction)) = value;
				}
			}

			// Token: 0x17000442 RID: 1090
			// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x00037A6C File Offset: 0x00035C6C
			// (set) Token: 0x06000CE9 RID: 3305 RVA: 0x00006E36 File Offset: 0x00005036
			public unsafe int readMask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_readMask);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_readMask)) = value;
				}
			}

			// Token: 0x17000443 RID: 1091
			// (get) Token: 0x06000CEA RID: 3306 RVA: 0x00037A94 File Offset: 0x00035C94
			// (set) Token: 0x06000CEB RID: 3307 RVA: 0x00006E51 File Offset: 0x00005051
			public unsafe int writeMask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_writeMask);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_writeMask)) = value;
				}
			}

			// Token: 0x17000444 RID: 1092
			// (get) Token: 0x06000CEC RID: 3308 RVA: 0x00037ABC File Offset: 0x00035CBC
			// (set) Token: 0x06000CED RID: 3309 RVA: 0x00006E6C File Offset: 0x0000506C
			public unsafe bool useAlphaClip
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_useAlphaClip);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_useAlphaClip)) = value;
				}
			}

			// Token: 0x17000445 RID: 1093
			// (get) Token: 0x06000CEE RID: 3310 RVA: 0x00037AE4 File Offset: 0x00035CE4
			// (set) Token: 0x06000CEF RID: 3311 RVA: 0x00006E87 File Offset: 0x00005087
			public unsafe ColorWriteMask colorMask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_colorMask);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilMaterial.MatEntry.NativeFieldInfoPtr_colorMask)) = value;
				}
			}

			// Token: 0x04000A0C RID: 2572
			private static readonly IntPtr NativeFieldInfoPtr_baseMat;

			// Token: 0x04000A0D RID: 2573
			private static readonly IntPtr NativeFieldInfoPtr_customMat;

			// Token: 0x04000A0E RID: 2574
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04000A0F RID: 2575
			private static readonly IntPtr NativeFieldInfoPtr_stencilId;

			// Token: 0x04000A10 RID: 2576
			private static readonly IntPtr NativeFieldInfoPtr_operation;

			// Token: 0x04000A11 RID: 2577
			private static readonly IntPtr NativeFieldInfoPtr_compareFunction;

			// Token: 0x04000A12 RID: 2578
			private static readonly IntPtr NativeFieldInfoPtr_readMask;

			// Token: 0x04000A13 RID: 2579
			private static readonly IntPtr NativeFieldInfoPtr_writeMask;

			// Token: 0x04000A14 RID: 2580
			private static readonly IntPtr NativeFieldInfoPtr_useAlphaClip;

			// Token: 0x04000A15 RID: 2581
			private static readonly IntPtr NativeFieldInfoPtr_colorMask;

			// Token: 0x04000A16 RID: 2582
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
