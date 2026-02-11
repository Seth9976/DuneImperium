using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000C6 RID: 198
	[Serializable]
	[StructLayout(2)]
	public struct BatchRendererGroupGlobals
	{
		// Token: 0x06000E5A RID: 3674 RVA: 0x00041FB0 File Offset: 0x000401B0
		// Note: this type is marked as 'beforefieldinit'.
		static BatchRendererGroupGlobals()
		{
			Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "BatchRendererGroupGlobals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr);
			BatchRendererGroupGlobals.NativeFieldInfoPtr_kGlobalsPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr, "kGlobalsPropertyName");
			BatchRendererGroupGlobals.NativeFieldInfoPtr_kGlobalsPropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr, "kGlobalsPropertyId");
			BatchRendererGroupGlobals.NativeFieldInfoPtr_ProbesOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr, "ProbesOcclusion");
			BatchRendererGroupGlobals.NativeFieldInfoPtr_SpecCube0_HDR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr, "SpecCube0_HDR");
			BatchRendererGroupGlobals.NativeFieldInfoPtr_SpecCube1_HDR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr, "SpecCube1_HDR");
			BatchRendererGroupGlobals.NativeFieldInfoPtr_SHCoefficients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr, "SHCoefficients");
			BatchRendererGroupGlobals.NativeMethodInfoPtr_get_Default_Public_Static_get_BatchRendererGroupGlobals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr, 100665355);
			BatchRendererGroupGlobals.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchRendererGroupGlobals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr, 100665356);
			BatchRendererGroupGlobals.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr, 100665357);
			BatchRendererGroupGlobals.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr, 100665358);
			BatchRendererGroupGlobals.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BatchRendererGroupGlobals_BatchRendererGroupGlobals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr, 100665359);
			BatchRendererGroupGlobals.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BatchRendererGroupGlobals_BatchRendererGroupGlobals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr, 100665360);
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000E5B RID: 3675 RVA: 0x000420D0 File Offset: 0x000402D0
		public unsafe static BatchRendererGroupGlobals Default
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974006, XrefRangeEnd = 974015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRendererGroupGlobals.NativeMethodInfoPtr_get_Default_Public_Static_get_BatchRendererGroupGlobals_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x00042100 File Offset: 0x00040300
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 974016, RefRangeEnd = 974019, XrefRangeStart = 974015, XrefRangeEnd = 974016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(BatchRendererGroupGlobals other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRendererGroupGlobals.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchRendererGroupGlobals_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x00042140 File Offset: 0x00040340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974019, XrefRangeEnd = 974025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRendererGroupGlobals.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x00042184 File Offset: 0x00040384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974025, XrefRangeEnd = 974031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRendererGroupGlobals.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x000421B4 File Offset: 0x000403B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974031, XrefRangeEnd = 974035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(BatchRendererGroupGlobals left, BatchRendererGroupGlobals right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRendererGroupGlobals.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BatchRendererGroupGlobals_BatchRendererGroupGlobals_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x00042200 File Offset: 0x00040400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974035, XrefRangeEnd = 974039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(BatchRendererGroupGlobals left, BatchRendererGroupGlobals right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRendererGroupGlobals.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BatchRendererGroupGlobals_BatchRendererGroupGlobals_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x000083B7 File Offset: 0x000065B7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr, ref this));
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x0004224C File Offset: 0x0004044C
		// (set) Token: 0x06000E63 RID: 3683 RVA: 0x000083C9 File Offset: 0x000065C9
		public unsafe static string kGlobalsPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BatchRendererGroupGlobals.NativeFieldInfoPtr_kGlobalsPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BatchRendererGroupGlobals.NativeFieldInfoPtr_kGlobalsPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x0004226C File Offset: 0x0004046C
		// (set) Token: 0x06000E65 RID: 3685 RVA: 0x000083DB File Offset: 0x000065DB
		public unsafe static int kGlobalsPropertyId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BatchRendererGroupGlobals.NativeFieldInfoPtr_kGlobalsPropertyId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BatchRendererGroupGlobals.NativeFieldInfoPtr_kGlobalsPropertyId, (void*)(&value));
			}
		}

		// Token: 0x04000AC7 RID: 2759
		private static readonly IntPtr NativeFieldInfoPtr_kGlobalsPropertyName;

		// Token: 0x04000AC8 RID: 2760
		private static readonly IntPtr NativeFieldInfoPtr_kGlobalsPropertyId;

		// Token: 0x04000AC9 RID: 2761
		private static readonly IntPtr NativeFieldInfoPtr_ProbesOcclusion;

		// Token: 0x04000ACA RID: 2762
		private static readonly IntPtr NativeFieldInfoPtr_SpecCube0_HDR;

		// Token: 0x04000ACB RID: 2763
		private static readonly IntPtr NativeFieldInfoPtr_SpecCube1_HDR;

		// Token: 0x04000ACC RID: 2764
		private static readonly IntPtr NativeFieldInfoPtr_SHCoefficients;

		// Token: 0x04000ACD RID: 2765
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_BatchRendererGroupGlobals_0;

		// Token: 0x04000ACE RID: 2766
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchRendererGroupGlobals_0;

		// Token: 0x04000ACF RID: 2767
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000AD0 RID: 2768
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000AD1 RID: 2769
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BatchRendererGroupGlobals_BatchRendererGroupGlobals_0;

		// Token: 0x04000AD2 RID: 2770
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BatchRendererGroupGlobals_BatchRendererGroupGlobals_0;

		// Token: 0x04000AD3 RID: 2771
		[FieldOffset(0)]
		public Vector4 ProbesOcclusion;

		// Token: 0x04000AD4 RID: 2772
		[FieldOffset(16)]
		public Vector4 SpecCube0_HDR;

		// Token: 0x04000AD5 RID: 2773
		[FieldOffset(32)]
		public Vector4 SpecCube1_HDR;

		// Token: 0x04000AD6 RID: 2774
		[FieldOffset(48)]
		public SHCoefficients SHCoefficients;
	}
}
