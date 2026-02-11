using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000DF RID: 223
	[Serializable]
	[StructLayout(2)]
	public struct BoneWeight1
	{
		// Token: 0x06001051 RID: 4177 RVA: 0x00052308 File Offset: 0x00050508
		// Note: this type is marked as 'beforefieldinit'.
		static BoneWeight1()
		{
			Il2CppClassPointerStore<BoneWeight1>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "BoneWeight1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoneWeight1>.NativeClassPtr);
			BoneWeight1.NativeFieldInfoPtr_m_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight1>.NativeClassPtr, "m_Weight");
			BoneWeight1.NativeFieldInfoPtr_m_BoneIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight1>.NativeClassPtr, "m_BoneIndex");
			BoneWeight1.NativeMethodInfoPtr_get_weight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight1>.NativeClassPtr, 100665541);
			BoneWeight1.NativeMethodInfoPtr_get_boneIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight1>.NativeClassPtr, 100665542);
			BoneWeight1.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight1>.NativeClassPtr, 100665543);
			BoneWeight1.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoneWeight1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight1>.NativeClassPtr, 100665544);
			BoneWeight1.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight1>.NativeClassPtr, 100665545);
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x000523C4 File Offset: 0x000505C4
		// (set) Token: 0x06001058 RID: 4184 RVA: 0x0000748E File Offset: 0x0000568E
		public unsafe float weight
		{
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 283150, RefRangeEnd = 283208, XrefRangeStart = 283150, XrefRangeEnd = 283208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneWeight1.NativeMethodInfoPtr_get_weight_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Weight = value;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06001053 RID: 4179 RVA: 0x000523F4 File Offset: 0x000505F4
		// (set) Token: 0x06001059 RID: 4185 RVA: 0x00007498 File Offset: 0x00005698
		public unsafe int boneIndex
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 283125, RefRangeEnd = 283150, XrefRangeStart = 283125, XrefRangeEnd = 283150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneWeight1.NativeMethodInfoPtr_get_boneIndex_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_BoneIndex = value;
			}
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x00052424 File Offset: 0x00050624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655693, XrefRangeEnd = 655698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneWeight1.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x00052468 File Offset: 0x00050668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655698, XrefRangeEnd = 655699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(BoneWeight1 other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneWeight1.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoneWeight1_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x000524A8 File Offset: 0x000506A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 655699, XrefRangeEnd = 655701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneWeight1.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x0000747C File Offset: 0x0000567C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BoneWeight1>.NativeClassPtr, ref this));
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x000524D8 File Offset: 0x000506D8
		public static bool operator ==(BoneWeight1 lhs, BoneWeight1 rhs)
		{
			return lhs.boneIndex == rhs.boneIndex && lhs.weight == rhs.weight;
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x00052510 File Offset: 0x00050710
		public static bool operator !=(BoneWeight1 lhs, BoneWeight1 rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x04000E75 RID: 3701
		private static readonly IntPtr NativeFieldInfoPtr_m_Weight;

		// Token: 0x04000E76 RID: 3702
		private static readonly IntPtr NativeFieldInfoPtr_m_BoneIndex;

		// Token: 0x04000E77 RID: 3703
		private static readonly IntPtr NativeMethodInfoPtr_get_weight_Public_get_Single_0;

		// Token: 0x04000E78 RID: 3704
		private static readonly IntPtr NativeMethodInfoPtr_get_boneIndex_Public_get_Int32_0;

		// Token: 0x04000E79 RID: 3705
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000E7A RID: 3706
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoneWeight1_0;

		// Token: 0x04000E7B RID: 3707
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000E7C RID: 3708
		[FieldOffset(0)]
		public float m_Weight;

		// Token: 0x04000E7D RID: 3709
		[FieldOffset(4)]
		public int m_BoneIndex;
	}
}
