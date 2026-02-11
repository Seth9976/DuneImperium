using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.XR
{
	// Token: 0x0200000A RID: 10
	[StructLayout(2)]
	public struct Hand
	{
		// Token: 0x0600005D RID: 93 RVA: 0x00003C60 File Offset: 0x00001E60
		// Note: this type is marked as 'beforefieldinit'.
		static Hand()
		{
			Il2CppClassPointerStore<Hand>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "Hand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hand>.NativeClassPtr);
			Hand.NativeFieldInfoPtr_m_DeviceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hand>.NativeClassPtr, "m_DeviceId");
			Hand.NativeFieldInfoPtr_m_FeatureIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hand>.NativeClassPtr, "m_FeatureIndex");
			Hand.NativeMethodInfoPtr_get_deviceId_Internal_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hand>.NativeClassPtr, 100663311);
			Hand.NativeMethodInfoPtr_get_featureIndex_Internal_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hand>.NativeClassPtr, 100663312);
			Hand.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hand>.NativeClassPtr, 100663313);
			Hand.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Hand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hand>.NativeClassPtr, 100663314);
			Hand.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hand>.NativeClassPtr, 100663315);
			Hand.Hand_TryGetRootBone_InjectedDelegateField = IL2CPP.ResolveICall<Hand.Hand_TryGetRootBone_InjectedDelegate>("UnityEngine.XR.Hand::Hand_TryGetRootBone_Injected");
			Hand.Hand_TryGetFingerBonesAsList_InjectedDelegateField = IL2CPP.ResolveICall<Hand.Hand_TryGetFingerBonesAsList_InjectedDelegate>("UnityEngine.XR.Hand::Hand_TryGetFingerBonesAsList_Injected");
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00003D3C File Offset: 0x00001F3C
		public unsafe ulong deviceId
		{
			[CallerCount(128)]
			[CachedScanResults(RefRangeStart = 323623, RefRangeEnd = 323751, XrefRangeStart = 323623, XrefRangeEnd = 323751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hand.NativeMethodInfoPtr_get_deviceId_Internal_get_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00003D6C File Offset: 0x00001F6C
		public unsafe uint featureIndex
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 335516, RefRangeEnd = 335543, XrefRangeStart = 335516, XrefRangeEnd = 335543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hand.NativeMethodInfoPtr_get_featureIndex_Internal_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003D9C File Offset: 0x00001F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258707, XrefRangeEnd = 1258710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hand.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003DE0 File Offset: 0x00001FE0
		[CallerCount(0)]
		public unsafe bool Equals(Hand other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hand.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Hand_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003E20 File Offset: 0x00002020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258710, XrefRangeEnd = 1258712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hand.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000022A8 File Offset: 0x000004A8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Hand>.NativeClassPtr, ref this));
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003E50 File Offset: 0x00002050
		public bool TryGetRootBone(out Bone boneOut)
		{
			return Hand.Hand_TryGetRootBone(this, out boneOut);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000022BA File Offset: 0x000004BA
		public static bool Hand_TryGetRootBone(Hand hand, out Bone boneOut)
		{
			return Hand.Hand_TryGetRootBone_Injected(ref hand, out boneOut);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003E70 File Offset: 0x00002070
		public bool TryGetFingerBones(HandFinger finger, List<Bone> bonesOut)
		{
			bool flag = bonesOut == null;
			if (flag)
			{
				throw new ArgumentNullException("bonesOut");
			}
			return Hand.Hand_TryGetFingerBonesAsList(this, finger, bonesOut);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000022C4 File Offset: 0x000004C4
		public static bool Hand_TryGetFingerBonesAsList(Hand hand, HandFinger finger, List<Bone> bonesOut)
		{
			return Hand.Hand_TryGetFingerBonesAsList_Injected(ref hand, finger, bonesOut);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003EA4 File Offset: 0x000020A4
		public static bool operator ==(Hand a, Hand b)
		{
			return a.Equals(b);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003EC0 File Offset: 0x000020C0
		public static bool operator !=(Hand a, Hand b)
		{
			return !(a == b);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000022CF File Offset: 0x000004CF
		public static bool Hand_TryGetRootBone_Injected(ref Hand hand, out Bone boneOut)
		{
			return Hand.Hand_TryGetRootBone_InjectedDelegateField(ref hand, out boneOut);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000022DD File Offset: 0x000004DD
		public static bool Hand_TryGetFingerBonesAsList_Injected(ref Hand hand, HandFinger finger, List<Bone> bonesOut)
		{
			return Hand.Hand_TryGetFingerBonesAsList_InjectedDelegateField(ref hand, finger, IL2CPP.Il2CppObjectBaseToPtr(bonesOut));
		}

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr_m_DeviceId;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr_m_FeatureIndex;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceId_Internal_get_UInt64_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_get_featureIndex_Internal_get_UInt32_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Hand_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400005F RID: 95
		[FieldOffset(0)]
		public ulong m_DeviceId;

		// Token: 0x04000060 RID: 96
		[FieldOffset(8)]
		public uint m_FeatureIndex;

		// Token: 0x04000061 RID: 97
		private static readonly Hand.Hand_TryGetRootBone_InjectedDelegate Hand_TryGetRootBone_InjectedDelegateField;

		// Token: 0x04000062 RID: 98
		private static readonly Hand.Hand_TryGetFingerBonesAsList_InjectedDelegate Hand_TryGetFingerBonesAsList_InjectedDelegateField;

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x0600018A RID: 394
		private delegate bool Hand_TryGetRootBone_InjectedDelegate(IntPtr hand, [Out] IntPtr boneOut);

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x0600018C RID: 396
		private delegate bool Hand_TryGetFingerBonesAsList_InjectedDelegate(IntPtr hand, HandFinger finger, IntPtr bonesOut);
	}
}
