using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.XR
{
	// Token: 0x0200000C RID: 12
	[StructLayout(2)]
	public struct Bone
	{
		// Token: 0x06000084 RID: 132 RVA: 0x00004200 File Offset: 0x00002400
		// Note: this type is marked as 'beforefieldinit'.
		static Bone()
		{
			Il2CppClassPointerStore<Bone>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "Bone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bone>.NativeClassPtr);
			Bone.NativeFieldInfoPtr_m_DeviceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bone>.NativeClassPtr, "m_DeviceId");
			Bone.NativeFieldInfoPtr_m_FeatureIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bone>.NativeClassPtr, "m_FeatureIndex");
			Bone.NativeMethodInfoPtr_get_deviceId_Internal_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bone>.NativeClassPtr, 100663321);
			Bone.NativeMethodInfoPtr_get_featureIndex_Internal_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bone>.NativeClassPtr, 100663322);
			Bone.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bone>.NativeClassPtr, 100663323);
			Bone.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Bone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bone>.NativeClassPtr, 100663324);
			Bone.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bone>.NativeClassPtr, 100663325);
			Bone.Bone_TryGetPosition_InjectedDelegateField = IL2CPP.ResolveICall<Bone.Bone_TryGetPosition_InjectedDelegate>("UnityEngine.XR.Bone::Bone_TryGetPosition_Injected");
			Bone.Bone_TryGetRotation_InjectedDelegateField = IL2CPP.ResolveICall<Bone.Bone_TryGetRotation_InjectedDelegate>("UnityEngine.XR.Bone::Bone_TryGetRotation_Injected");
			Bone.Bone_TryGetParentBone_InjectedDelegateField = IL2CPP.ResolveICall<Bone.Bone_TryGetParentBone_InjectedDelegate>("UnityEngine.XR.Bone::Bone_TryGetParentBone_Injected");
			Bone.Bone_TryGetChildBones_InjectedDelegateField = IL2CPP.ResolveICall<Bone.Bone_TryGetChildBones_InjectedDelegate>("UnityEngine.XR.Bone::Bone_TryGetChildBones_Injected");
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000085 RID: 133 RVA: 0x000042F8 File Offset: 0x000024F8
		public unsafe ulong deviceId
		{
			[CallerCount(128)]
			[CachedScanResults(RefRangeStart = 323623, RefRangeEnd = 323751, XrefRangeStart = 323623, XrefRangeEnd = 323751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bone.NativeMethodInfoPtr_get_deviceId_Internal_get_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00004328 File Offset: 0x00002528
		public unsafe uint featureIndex
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 335516, RefRangeEnd = 335543, XrefRangeStart = 335516, XrefRangeEnd = 335543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bone.NativeMethodInfoPtr_get_featureIndex_Internal_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00004358 File Offset: 0x00002558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258715, XrefRangeEnd = 1258718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bone.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000439C File Offset: 0x0000259C
		[CallerCount(0)]
		public unsafe bool Equals(Bone other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bone.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Bone_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000043DC File Offset: 0x000025DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bone.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002369 File Offset: 0x00000569
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Bone>.NativeClassPtr, ref this));
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000440C File Offset: 0x0000260C
		public bool TryGetPosition(out Vector3 position)
		{
			return Bone.Bone_TryGetPosition(this, out position);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000237B File Offset: 0x0000057B
		public static bool Bone_TryGetPosition(Bone bone, out Vector3 position)
		{
			return Bone.Bone_TryGetPosition_Injected(ref bone, out position);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000442C File Offset: 0x0000262C
		public bool TryGetRotation(out Quaternion rotation)
		{
			return Bone.Bone_TryGetRotation(this, out rotation);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002385 File Offset: 0x00000585
		public static bool Bone_TryGetRotation(Bone bone, out Quaternion rotation)
		{
			return Bone.Bone_TryGetRotation_Injected(ref bone, out rotation);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000444C File Offset: 0x0000264C
		public bool TryGetParentBone(out Bone parentBone)
		{
			return Bone.Bone_TryGetParentBone(this, out parentBone);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000238F File Offset: 0x0000058F
		public static bool Bone_TryGetParentBone(Bone bone, out Bone parentBone)
		{
			return Bone.Bone_TryGetParentBone_Injected(ref bone, out parentBone);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000446C File Offset: 0x0000266C
		public bool TryGetChildBones(List<Bone> childBones)
		{
			return Bone.Bone_TryGetChildBones(this, childBones);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002399 File Offset: 0x00000599
		public static bool Bone_TryGetChildBones(Bone bone, List<Bone> childBones)
		{
			return Bone.Bone_TryGetChildBones_Injected(ref bone, childBones);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000448C File Offset: 0x0000268C
		public static bool operator ==(Bone a, Bone b)
		{
			return a.Equals(b);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000044A8 File Offset: 0x000026A8
		public static bool operator !=(Bone a, Bone b)
		{
			return !(a == b);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000023A3 File Offset: 0x000005A3
		public static bool Bone_TryGetPosition_Injected(ref Bone bone, out Vector3 position)
		{
			return Bone.Bone_TryGetPosition_InjectedDelegateField(ref bone, out position);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000023B1 File Offset: 0x000005B1
		public static bool Bone_TryGetRotation_Injected(ref Bone bone, out Quaternion rotation)
		{
			return Bone.Bone_TryGetRotation_InjectedDelegateField(ref bone, out rotation);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000023BF File Offset: 0x000005BF
		public static bool Bone_TryGetParentBone_Injected(ref Bone bone, out Bone parentBone)
		{
			return Bone.Bone_TryGetParentBone_InjectedDelegateField(ref bone, out parentBone);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000023CD File Offset: 0x000005CD
		public static bool Bone_TryGetChildBones_Injected(ref Bone bone, List<Bone> childBones)
		{
			return Bone.Bone_TryGetChildBones_InjectedDelegateField(ref bone, IL2CPP.Il2CppObjectBaseToPtr(childBones));
		}

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_m_DeviceId;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_m_FeatureIndex;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceId_Internal_get_UInt64_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_get_featureIndex_Internal_get_UInt32_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Bone_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000077 RID: 119
		[FieldOffset(0)]
		public ulong m_DeviceId;

		// Token: 0x04000078 RID: 120
		[FieldOffset(8)]
		public uint m_FeatureIndex;

		// Token: 0x04000079 RID: 121
		private static readonly Bone.Bone_TryGetPosition_InjectedDelegate Bone_TryGetPosition_InjectedDelegateField;

		// Token: 0x0400007A RID: 122
		private static readonly Bone.Bone_TryGetRotation_InjectedDelegate Bone_TryGetRotation_InjectedDelegateField;

		// Token: 0x0400007B RID: 123
		private static readonly Bone.Bone_TryGetParentBone_InjectedDelegate Bone_TryGetParentBone_InjectedDelegateField;

		// Token: 0x0400007C RID: 124
		private static readonly Bone.Bone_TryGetChildBones_InjectedDelegate Bone_TryGetChildBones_InjectedDelegateField;

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x06000196 RID: 406
		private delegate bool Bone_TryGetPosition_InjectedDelegate(IntPtr bone, [Out] IntPtr position);

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x06000198 RID: 408
		private delegate bool Bone_TryGetRotation_InjectedDelegate(IntPtr bone, [Out] IntPtr rotation);

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x0600019A RID: 410
		private delegate bool Bone_TryGetParentBone_InjectedDelegate(IntPtr bone, [Out] IntPtr parentBone);

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x0600019C RID: 412
		private delegate bool Bone_TryGetChildBones_InjectedDelegate(IntPtr bone, IntPtr childBones);
	}
}
