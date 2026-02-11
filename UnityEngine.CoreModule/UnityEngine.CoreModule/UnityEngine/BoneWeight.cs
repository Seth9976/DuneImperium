using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000DE RID: 222
	[Serializable]
	[StructLayout(2)]
	public struct BoneWeight
	{
		// Token: 0x0600103A RID: 4154 RVA: 0x00051E70 File Offset: 0x00050070
		// Note: this type is marked as 'beforefieldinit'.
		static BoneWeight()
		{
			Il2CppClassPointerStore<BoneWeight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "BoneWeight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr);
			BoneWeight.NativeFieldInfoPtr_m_Weight0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, "m_Weight0");
			BoneWeight.NativeFieldInfoPtr_m_Weight1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, "m_Weight1");
			BoneWeight.NativeFieldInfoPtr_m_Weight2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, "m_Weight2");
			BoneWeight.NativeFieldInfoPtr_m_Weight3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, "m_Weight3");
			BoneWeight.NativeFieldInfoPtr_m_BoneIndex0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, "m_BoneIndex0");
			BoneWeight.NativeFieldInfoPtr_m_BoneIndex1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, "m_BoneIndex1");
			BoneWeight.NativeFieldInfoPtr_m_BoneIndex2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, "m_BoneIndex2");
			BoneWeight.NativeFieldInfoPtr_m_BoneIndex3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, "m_BoneIndex3");
			BoneWeight.NativeMethodInfoPtr_get_weight0_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100665530);
			BoneWeight.NativeMethodInfoPtr_get_weight1_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100665531);
			BoneWeight.NativeMethodInfoPtr_get_weight2_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100665532);
			BoneWeight.NativeMethodInfoPtr_get_weight3_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100665533);
			BoneWeight.NativeMethodInfoPtr_get_boneIndex0_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100665534);
			BoneWeight.NativeMethodInfoPtr_get_boneIndex1_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100665535);
			BoneWeight.NativeMethodInfoPtr_get_boneIndex2_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100665536);
			BoneWeight.NativeMethodInfoPtr_get_boneIndex3_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100665537);
			BoneWeight.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100665538);
			BoneWeight.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100665539);
			BoneWeight.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoneWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100665540);
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x0600103B RID: 4155 RVA: 0x0005201C File Offset: 0x0005021C
		// (set) Token: 0x06001047 RID: 4167 RVA: 0x0000742C File Offset: 0x0000562C
		public unsafe float weight0
		{
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 283150, RefRangeEnd = 283208, XrefRangeStart = 283150, XrefRangeEnd = 283208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_get_weight0_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Weight0 = value;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x0005204C File Offset: 0x0005024C
		// (set) Token: 0x06001048 RID: 4168 RVA: 0x00007436 File Offset: 0x00005636
		public unsafe float weight1
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 644349, RefRangeEnd = 644397, XrefRangeStart = 644349, XrefRangeEnd = 644397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_get_weight1_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Weight1 = value;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x0005207C File Offset: 0x0005027C
		// (set) Token: 0x06001049 RID: 4169 RVA: 0x00007440 File Offset: 0x00005640
		public unsafe float weight2
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 644403, RefRangeEnd = 644429, XrefRangeStart = 644403, XrefRangeEnd = 644429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_get_weight2_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Weight2 = value;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x000520AC File Offset: 0x000502AC
		// (set) Token: 0x0600104A RID: 4170 RVA: 0x0000744A File Offset: 0x0000564A
		public unsafe float weight3
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 644431, RefRangeEnd = 644456, XrefRangeStart = 644431, XrefRangeEnd = 644456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_get_weight3_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Weight3 = value;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x0600103F RID: 4159 RVA: 0x000520DC File Offset: 0x000502DC
		// (set) Token: 0x0600104B RID: 4171 RVA: 0x00007454 File Offset: 0x00005654
		public unsafe int boneIndex0
		{
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 334600, RefRangeEnd = 334642, XrefRangeStart = 334600, XrefRangeEnd = 334642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_get_boneIndex0_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_BoneIndex0 = value;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06001040 RID: 4160 RVA: 0x0005210C File Offset: 0x0005030C
		// (set) Token: 0x0600104C RID: 4172 RVA: 0x0000745E File Offset: 0x0000565E
		public unsafe int boneIndex1
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 334566, RefRangeEnd = 334587, XrefRangeStart = 334566, XrefRangeEnd = 334587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_get_boneIndex1_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_BoneIndex1 = value;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x0005213C File Offset: 0x0005033C
		// (set) Token: 0x0600104D RID: 4173 RVA: 0x00007468 File Offset: 0x00005668
		public unsafe int boneIndex2
		{
			[CallerCount(66)]
			[CachedScanResults(RefRangeStart = 320372, RefRangeEnd = 320438, XrefRangeStart = 320372, XrefRangeEnd = 320438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_get_boneIndex2_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_BoneIndex2 = value;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x0005216C File Offset: 0x0005036C
		// (set) Token: 0x0600104E RID: 4174 RVA: 0x00007472 File Offset: 0x00005672
		public unsafe int boneIndex3
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 347794, RefRangeEnd = 347795, XrefRangeStart = 347794, XrefRangeEnd = 347795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_get_boneIndex3_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_BoneIndex3 = value;
			}
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x0005219C File Offset: 0x0005039C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655676, XrefRangeEnd = 655684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x000521CC File Offset: 0x000503CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655684, XrefRangeEnd = 655688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x00052210 File Offset: 0x00050410
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 655692, RefRangeEnd = 655693, XrefRangeStart = 655688, XrefRangeEnd = 655692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(BoneWeight other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoneWeight_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x0000741A File Offset: 0x0000561A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, ref this));
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x00052250 File Offset: 0x00050450
		public static bool operator ==(BoneWeight lhs, BoneWeight rhs)
		{
			return lhs.boneIndex0 == rhs.boneIndex0 && lhs.boneIndex1 == rhs.boneIndex1 && lhs.boneIndex2 == rhs.boneIndex2 && lhs.boneIndex3 == rhs.boneIndex3 && new Vector4(lhs.weight0, lhs.weight1, lhs.weight2, lhs.weight3) == new Vector4(rhs.weight0, rhs.weight1, rhs.weight2, rhs.weight3);
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x000522EC File Offset: 0x000504EC
		public static bool operator !=(BoneWeight lhs, BoneWeight rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x04000E5A RID: 3674
		private static readonly IntPtr NativeFieldInfoPtr_m_Weight0;

		// Token: 0x04000E5B RID: 3675
		private static readonly IntPtr NativeFieldInfoPtr_m_Weight1;

		// Token: 0x04000E5C RID: 3676
		private static readonly IntPtr NativeFieldInfoPtr_m_Weight2;

		// Token: 0x04000E5D RID: 3677
		private static readonly IntPtr NativeFieldInfoPtr_m_Weight3;

		// Token: 0x04000E5E RID: 3678
		private static readonly IntPtr NativeFieldInfoPtr_m_BoneIndex0;

		// Token: 0x04000E5F RID: 3679
		private static readonly IntPtr NativeFieldInfoPtr_m_BoneIndex1;

		// Token: 0x04000E60 RID: 3680
		private static readonly IntPtr NativeFieldInfoPtr_m_BoneIndex2;

		// Token: 0x04000E61 RID: 3681
		private static readonly IntPtr NativeFieldInfoPtr_m_BoneIndex3;

		// Token: 0x04000E62 RID: 3682
		private static readonly IntPtr NativeMethodInfoPtr_get_weight0_Public_get_Single_0;

		// Token: 0x04000E63 RID: 3683
		private static readonly IntPtr NativeMethodInfoPtr_get_weight1_Public_get_Single_0;

		// Token: 0x04000E64 RID: 3684
		private static readonly IntPtr NativeMethodInfoPtr_get_weight2_Public_get_Single_0;

		// Token: 0x04000E65 RID: 3685
		private static readonly IntPtr NativeMethodInfoPtr_get_weight3_Public_get_Single_0;

		// Token: 0x04000E66 RID: 3686
		private static readonly IntPtr NativeMethodInfoPtr_get_boneIndex0_Public_get_Int32_0;

		// Token: 0x04000E67 RID: 3687
		private static readonly IntPtr NativeMethodInfoPtr_get_boneIndex1_Public_get_Int32_0;

		// Token: 0x04000E68 RID: 3688
		private static readonly IntPtr NativeMethodInfoPtr_get_boneIndex2_Public_get_Int32_0;

		// Token: 0x04000E69 RID: 3689
		private static readonly IntPtr NativeMethodInfoPtr_get_boneIndex3_Public_get_Int32_0;

		// Token: 0x04000E6A RID: 3690
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000E6B RID: 3691
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000E6C RID: 3692
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoneWeight_0;

		// Token: 0x04000E6D RID: 3693
		[FieldOffset(0)]
		public float m_Weight0;

		// Token: 0x04000E6E RID: 3694
		[FieldOffset(4)]
		public float m_Weight1;

		// Token: 0x04000E6F RID: 3695
		[FieldOffset(8)]
		public float m_Weight2;

		// Token: 0x04000E70 RID: 3696
		[FieldOffset(12)]
		public float m_Weight3;

		// Token: 0x04000E71 RID: 3697
		[FieldOffset(16)]
		public int m_BoneIndex0;

		// Token: 0x04000E72 RID: 3698
		[FieldOffset(20)]
		public int m_BoneIndex1;

		// Token: 0x04000E73 RID: 3699
		[FieldOffset(24)]
		public int m_BoneIndex2;

		// Token: 0x04000E74 RID: 3700
		[FieldOffset(28)]
		public int m_BoneIndex3;
	}
}
