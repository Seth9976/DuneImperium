using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.XR
{
	// Token: 0x0200000B RID: 11
	[StructLayout(2)]
	public struct Eyes
	{
		// Token: 0x0600006C RID: 108 RVA: 0x00003EDC File Offset: 0x000020DC
		// Note: this type is marked as 'beforefieldinit'.
		static Eyes()
		{
			Il2CppClassPointerStore<Eyes>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "Eyes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eyes>.NativeClassPtr);
			Eyes.NativeFieldInfoPtr_m_DeviceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyes>.NativeClassPtr, "m_DeviceId");
			Eyes.NativeFieldInfoPtr_m_FeatureIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyes>.NativeClassPtr, "m_FeatureIndex");
			Eyes.NativeMethodInfoPtr_get_deviceId_Internal_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100663316);
			Eyes.NativeMethodInfoPtr_get_featureIndex_Internal_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100663317);
			Eyes.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100663318);
			Eyes.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Eyes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100663319);
			Eyes.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100663320);
			Eyes.Eyes_TryGetEyePosition_InjectedDelegateField = IL2CPP.ResolveICall<Eyes.Eyes_TryGetEyePosition_InjectedDelegate>("UnityEngine.XR.Eyes::Eyes_TryGetEyePosition_Injected");
			Eyes.Eyes_TryGetEyeRotation_InjectedDelegateField = IL2CPP.ResolveICall<Eyes.Eyes_TryGetEyeRotation_InjectedDelegate>("UnityEngine.XR.Eyes::Eyes_TryGetEyeRotation_Injected");
			Eyes.Eyes_TryGetFixationPoint_InjectedDelegateField = IL2CPP.ResolveICall<Eyes.Eyes_TryGetFixationPoint_InjectedDelegate>("UnityEngine.XR.Eyes::Eyes_TryGetFixationPoint_Injected");
			Eyes.Eyes_TryGetEyeOpenAmount_InjectedDelegateField = IL2CPP.ResolveICall<Eyes.Eyes_TryGetEyeOpenAmount_InjectedDelegate>("UnityEngine.XR.Eyes::Eyes_TryGetEyeOpenAmount_Injected");
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00003FD4 File Offset: 0x000021D4
		public unsafe ulong deviceId
		{
			[CallerCount(128)]
			[CachedScanResults(RefRangeStart = 323623, RefRangeEnd = 323751, XrefRangeStart = 323623, XrefRangeEnd = 323751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyes.NativeMethodInfoPtr_get_deviceId_Internal_get_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00004004 File Offset: 0x00002204
		public unsafe uint featureIndex
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 335516, RefRangeEnd = 335543, XrefRangeStart = 335516, XrefRangeEnd = 335543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyes.NativeMethodInfoPtr_get_featureIndex_Internal_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004034 File Offset: 0x00002234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258712, XrefRangeEnd = 1258715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyes.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00004078 File Offset: 0x00002278
		[CallerCount(0)]
		public unsafe bool Equals(Eyes other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyes.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Eyes_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000040B8 File Offset: 0x000022B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyes.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000022F1 File Offset: 0x000004F1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Eyes>.NativeClassPtr, ref this));
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000040E8 File Offset: 0x000022E8
		public bool TryGetLeftEyePosition(out Vector3 position)
		{
			return Eyes.Eyes_TryGetEyePosition(this, EyeSide.Left, out position);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00004108 File Offset: 0x00002308
		public bool TryGetRightEyePosition(out Vector3 position)
		{
			return Eyes.Eyes_TryGetEyePosition(this, EyeSide.Right, out position);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00004128 File Offset: 0x00002328
		public bool TryGetLeftEyeRotation(out Quaternion rotation)
		{
			return Eyes.Eyes_TryGetEyeRotation(this, EyeSide.Left, out rotation);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00004148 File Offset: 0x00002348
		public bool TryGetRightEyeRotation(out Quaternion rotation)
		{
			return Eyes.Eyes_TryGetEyeRotation(this, EyeSide.Right, out rotation);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002303 File Offset: 0x00000503
		public static bool Eyes_TryGetEyePosition(Eyes eyes, EyeSide chirality, out Vector3 position)
		{
			return Eyes.Eyes_TryGetEyePosition_Injected(ref eyes, chirality, out position);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000230E File Offset: 0x0000050E
		public static bool Eyes_TryGetEyeRotation(Eyes eyes, EyeSide chirality, out Quaternion rotation)
		{
			return Eyes.Eyes_TryGetEyeRotation_Injected(ref eyes, chirality, out rotation);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00004168 File Offset: 0x00002368
		public bool TryGetFixationPoint(out Vector3 fixationPoint)
		{
			return Eyes.Eyes_TryGetFixationPoint(this, out fixationPoint);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002319 File Offset: 0x00000519
		public static bool Eyes_TryGetFixationPoint(Eyes eyes, out Vector3 fixationPoint)
		{
			return Eyes.Eyes_TryGetFixationPoint_Injected(ref eyes, out fixationPoint);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00004188 File Offset: 0x00002388
		public bool TryGetLeftEyeOpenAmount(out float openAmount)
		{
			return Eyes.Eyes_TryGetEyeOpenAmount(this, EyeSide.Left, out openAmount);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000041A8 File Offset: 0x000023A8
		public bool TryGetRightEyeOpenAmount(out float openAmount)
		{
			return Eyes.Eyes_TryGetEyeOpenAmount(this, EyeSide.Right, out openAmount);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002323 File Offset: 0x00000523
		public static bool Eyes_TryGetEyeOpenAmount(Eyes eyes, EyeSide chirality, out float openAmount)
		{
			return Eyes.Eyes_TryGetEyeOpenAmount_Injected(ref eyes, chirality, out openAmount);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000041C8 File Offset: 0x000023C8
		public static bool operator ==(Eyes a, Eyes b)
		{
			return a.Equals(b);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000041E4 File Offset: 0x000023E4
		public static bool operator !=(Eyes a, Eyes b)
		{
			return !(a == b);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000232E File Offset: 0x0000052E
		public static bool Eyes_TryGetEyePosition_Injected(ref Eyes eyes, EyeSide chirality, out Vector3 position)
		{
			return Eyes.Eyes_TryGetEyePosition_InjectedDelegateField(ref eyes, chirality, out position);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000233D File Offset: 0x0000053D
		public static bool Eyes_TryGetEyeRotation_Injected(ref Eyes eyes, EyeSide chirality, out Quaternion rotation)
		{
			return Eyes.Eyes_TryGetEyeRotation_InjectedDelegateField(ref eyes, chirality, out rotation);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000234C File Offset: 0x0000054C
		public static bool Eyes_TryGetFixationPoint_Injected(ref Eyes eyes, out Vector3 fixationPoint)
		{
			return Eyes.Eyes_TryGetFixationPoint_InjectedDelegateField(ref eyes, out fixationPoint);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000235A File Offset: 0x0000055A
		public static bool Eyes_TryGetEyeOpenAmount_Injected(ref Eyes eyes, EyeSide chirality, out float openAmount)
		{
			return Eyes.Eyes_TryGetEyeOpenAmount_InjectedDelegateField(ref eyes, chirality, out openAmount);
		}

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_m_DeviceId;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr_m_FeatureIndex;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceId_Internal_get_UInt64_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_get_featureIndex_Internal_get_UInt32_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Eyes_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400006A RID: 106
		[FieldOffset(0)]
		public ulong m_DeviceId;

		// Token: 0x0400006B RID: 107
		[FieldOffset(8)]
		public uint m_FeatureIndex;

		// Token: 0x0400006C RID: 108
		private static readonly Eyes.Eyes_TryGetEyePosition_InjectedDelegate Eyes_TryGetEyePosition_InjectedDelegateField;

		// Token: 0x0400006D RID: 109
		private static readonly Eyes.Eyes_TryGetEyeRotation_InjectedDelegate Eyes_TryGetEyeRotation_InjectedDelegateField;

		// Token: 0x0400006E RID: 110
		private static readonly Eyes.Eyes_TryGetFixationPoint_InjectedDelegate Eyes_TryGetFixationPoint_InjectedDelegateField;

		// Token: 0x0400006F RID: 111
		private static readonly Eyes.Eyes_TryGetEyeOpenAmount_InjectedDelegate Eyes_TryGetEyeOpenAmount_InjectedDelegateField;

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x0600018E RID: 398
		private delegate bool Eyes_TryGetEyePosition_InjectedDelegate(IntPtr eyes, EyeSide chirality, [Out] IntPtr position);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x06000190 RID: 400
		private delegate bool Eyes_TryGetEyeRotation_InjectedDelegate(IntPtr eyes, EyeSide chirality, [Out] IntPtr rotation);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x06000192 RID: 402
		private delegate bool Eyes_TryGetFixationPoint_InjectedDelegate(IntPtr eyes, [Out] IntPtr fixationPoint);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x06000194 RID: 404
		private delegate bool Eyes_TryGetEyeOpenAmount_InjectedDelegate(IntPtr eyes, EyeSide chirality, [Out] IntPtr openAmount);
	}
}
