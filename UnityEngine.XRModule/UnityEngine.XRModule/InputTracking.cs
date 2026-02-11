using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.XR
{
	// Token: 0x02000002 RID: 2
	public static class InputTracking : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002EC0 File Offset: 0x000010C0
		// Note: this type is marked as 'beforefieldinit'.
		static InputTracking()
		{
			Il2CppClassPointerStore<InputTracking>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "InputTracking");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputTracking>.NativeClassPtr);
			InputTracking.NativeFieldInfoPtr_trackingAcquired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputTracking>.NativeClassPtr, "trackingAcquired");
			InputTracking.NativeFieldInfoPtr_trackingLost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputTracking>.NativeClassPtr, "trackingLost");
			InputTracking.NativeFieldInfoPtr_nodeAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputTracking>.NativeClassPtr, "nodeAdded");
			InputTracking.NativeFieldInfoPtr_nodeRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputTracking>.NativeClassPtr, "nodeRemoved");
			InputTracking.NativeMethodInfoPtr_InvokeTrackingEvent_Private_Static_Void_TrackingStateEventType_XRNode_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputTracking>.NativeClassPtr, 100663297);
			InputTracking.RecenterDelegateField = IL2CPP.ResolveICall<InputTracking.RecenterDelegate>("UnityEngine.XR.InputTracking::Recenter");
			InputTracking.GetNodeNameDelegateField = IL2CPP.ResolveICall<InputTracking.GetNodeNameDelegate>("UnityEngine.XR.InputTracking::GetNodeName");
			InputTracking.GetNodeStates_InternalDelegateField = IL2CPP.ResolveICall<InputTracking.GetNodeStates_InternalDelegate>("UnityEngine.XR.InputTracking::GetNodeStates_Internal");
			InputTracking.get_disablePositionalTrackingDelegateField = IL2CPP.ResolveICall<InputTracking.get_disablePositionalTrackingDelegate>("UnityEngine.XR.InputTracking::get_disablePositionalTracking");
			InputTracking.set_disablePositionalTrackingDelegateField = IL2CPP.ResolveICall<InputTracking.set_disablePositionalTrackingDelegate>("UnityEngine.XR.InputTracking::set_disablePositionalTracking");
			InputTracking.GetDeviceIdAtXRNodeDelegateField = IL2CPP.ResolveICall<InputTracking.GetDeviceIdAtXRNodeDelegate>("UnityEngine.XR.InputTracking::GetDeviceIdAtXRNode");
			InputTracking.GetDeviceIdsAtXRNode_InternalDelegateField = IL2CPP.ResolveICall<InputTracking.GetDeviceIdsAtXRNode_InternalDelegate>("UnityEngine.XR.InputTracking::GetDeviceIdsAtXRNode_Internal");
			InputTracking.GetLocalPosition_InjectedDelegateField = IL2CPP.ResolveICall<InputTracking.GetLocalPosition_InjectedDelegate>("UnityEngine.XR.InputTracking::GetLocalPosition_Injected");
			InputTracking.GetLocalRotation_InjectedDelegateField = IL2CPP.ResolveICall<InputTracking.GetLocalRotation_InjectedDelegate>("UnityEngine.XR.InputTracking::GetLocalRotation_Injected");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002FDC File Offset: 0x000011DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258686, XrefRangeEnd = 1258694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeTrackingEvent(InputTracking.TrackingStateEventType eventType, XRNode nodeType, long uniqueID, bool tracked)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nodeType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uniqueID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tracked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputTracking.NativeMethodInfoPtr_InvokeTrackingEvent_Private_Static_Void_TrackingStateEventType_XRNode_Int64_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		public InputTracking(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00003038 File Offset: 0x00001238
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe static Action<XRNodeState> trackingAcquired
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputTracking.NativeFieldInfoPtr_trackingAcquired, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<XRNodeState>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputTracking.NativeFieldInfoPtr_trackingAcquired, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00003060 File Offset: 0x00001260
		// (set) Token: 0x06000007 RID: 7 RVA: 0x0000206B File Offset: 0x0000026B
		public unsafe static Action<XRNodeState> trackingLost
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputTracking.NativeFieldInfoPtr_trackingLost, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<XRNodeState>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputTracking.NativeFieldInfoPtr_trackingLost, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00003088 File Offset: 0x00001288
		// (set) Token: 0x06000009 RID: 9 RVA: 0x0000207D File Offset: 0x0000027D
		public unsafe static Action<XRNodeState> nodeAdded
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputTracking.NativeFieldInfoPtr_nodeAdded, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<XRNodeState>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputTracking.NativeFieldInfoPtr_nodeAdded, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000030B0 File Offset: 0x000012B0
		// (set) Token: 0x0600000B RID: 11 RVA: 0x0000208F File Offset: 0x0000028F
		public unsafe static Action<XRNodeState> nodeRemoved
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputTracking.NativeFieldInfoPtr_nodeRemoved, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<XRNodeState>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputTracking.NativeFieldInfoPtr_nodeRemoved, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020A1 File Offset: 0x000002A1
		public static void add_trackingAcquired(Action<XRNodeState> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020AE File Offset: 0x000002AE
		public static void remove_trackingAcquired(Action<XRNodeState> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020BB File Offset: 0x000002BB
		public static void add_trackingLost(Action<XRNodeState> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020C8 File Offset: 0x000002C8
		public static void remove_trackingLost(Action<XRNodeState> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020D5 File Offset: 0x000002D5
		public static void add_nodeAdded(Action<XRNodeState> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000020E2 File Offset: 0x000002E2
		public static void remove_nodeAdded(Action<XRNodeState> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000020EF File Offset: 0x000002EF
		public static void add_nodeRemoved(Action<XRNodeState> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000020FC File Offset: 0x000002FC
		public static void remove_nodeRemoved(Action<XRNodeState> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000030D8 File Offset: 0x000012D8
		public static Vector3 GetLocalPosition(XRNode node)
		{
			Vector3 vector;
			InputTracking.GetLocalPosition_Injected(node, out vector);
			return vector;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000030F0 File Offset: 0x000012F0
		public static Quaternion GetLocalRotation(XRNode node)
		{
			Quaternion quaternion;
			InputTracking.GetLocalRotation_Injected(node, out quaternion);
			return quaternion;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002109 File Offset: 0x00000309
		public static void Recenter()
		{
			InputTracking.RecenterDelegateField();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003108 File Offset: 0x00001308
		public static string GetNodeName(ulong uniqueId)
		{
			IntPtr intPtr = InputTracking.GetNodeNameDelegateField(uniqueId);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003128 File Offset: 0x00001328
		public static void GetNodeStates(List<XRNodeState> nodeStates)
		{
			bool flag = nodeStates == null;
			if (flag)
			{
				throw new ArgumentNullException("nodeStates");
			}
			nodeStates.Clear();
			InputTracking.GetNodeStates_Internal(nodeStates);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002115 File Offset: 0x00000315
		public static void GetNodeStates_Internal(List<XRNodeState> nodeStates)
		{
			InputTracking.GetNodeStates_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(nodeStates));
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002127 File Offset: 0x00000327
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00002133 File Offset: 0x00000333
		public static bool disablePositionalTracking
		{
			get
			{
				return InputTracking.get_disablePositionalTrackingDelegateField();
			}
			set
			{
				InputTracking.set_disablePositionalTrackingDelegateField(value);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002140 File Offset: 0x00000340
		public static ulong GetDeviceIdAtXRNode(XRNode node)
		{
			return InputTracking.GetDeviceIdAtXRNodeDelegateField(node);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000214D File Offset: 0x0000034D
		public static void GetDeviceIdsAtXRNode_Internal(XRNode node, List<ulong> deviceIds)
		{
			InputTracking.GetDeviceIdsAtXRNode_InternalDelegateField(node, IL2CPP.Il2CppObjectBaseToPtr(deviceIds));
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002160 File Offset: 0x00000360
		public static void GetLocalPosition_Injected(XRNode node, out Vector3 ret)
		{
			InputTracking.GetLocalPosition_InjectedDelegateField(node, out ret);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000216E File Offset: 0x0000036E
		public static void GetLocalRotation_Injected(XRNode node, out Quaternion ret)
		{
			InputTracking.GetLocalRotation_InjectedDelegateField(node, out ret);
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_trackingAcquired;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_trackingLost;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_nodeAdded;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr_nodeRemoved;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_InvokeTrackingEvent_Private_Static_Void_TrackingStateEventType_XRNode_Int64_Boolean_0;

		// Token: 0x04000006 RID: 6
		private static readonly InputTracking.RecenterDelegate RecenterDelegateField;

		// Token: 0x04000007 RID: 7
		private static readonly InputTracking.GetNodeNameDelegate GetNodeNameDelegateField;

		// Token: 0x04000008 RID: 8
		private static readonly InputTracking.GetNodeStates_InternalDelegate GetNodeStates_InternalDelegateField;

		// Token: 0x04000009 RID: 9
		private static readonly InputTracking.get_disablePositionalTrackingDelegate get_disablePositionalTrackingDelegateField;

		// Token: 0x0400000A RID: 10
		private static readonly InputTracking.set_disablePositionalTrackingDelegate set_disablePositionalTrackingDelegateField;

		// Token: 0x0400000B RID: 11
		private static readonly InputTracking.GetDeviceIdAtXRNodeDelegate GetDeviceIdAtXRNodeDelegateField;

		// Token: 0x0400000C RID: 12
		private static readonly InputTracking.GetDeviceIdsAtXRNode_InternalDelegate GetDeviceIdsAtXRNode_InternalDelegateField;

		// Token: 0x0400000D RID: 13
		private static readonly InputTracking.GetLocalPosition_InjectedDelegate GetLocalPosition_InjectedDelegateField;

		// Token: 0x0400000E RID: 14
		private static readonly InputTracking.GetLocalRotation_InjectedDelegate GetLocalRotation_InjectedDelegateField;

		// Token: 0x02000025 RID: 37
		public enum TrackingStateEventType
		{
			// Token: 0x0400015D RID: 349
			NodeAdded,
			// Token: 0x0400015E RID: 350
			NodeRemoved,
			// Token: 0x0400015F RID: 351
			TrackingAcquired,
			// Token: 0x04000160 RID: 352
			TrackingLost
		}

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x06000178 RID: 376
		private delegate void RecenterDelegate();

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x0600017A RID: 378
		private delegate IntPtr GetNodeNameDelegate(ulong uniqueId);

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x0600017C RID: 380
		private delegate void GetNodeStates_InternalDelegate(IntPtr nodeStates);

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x0600017E RID: 382
		private delegate bool get_disablePositionalTrackingDelegate();

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x06000180 RID: 384
		private delegate void set_disablePositionalTrackingDelegate(bool value);

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x06000182 RID: 386
		private delegate ulong GetDeviceIdAtXRNodeDelegate(XRNode node);

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x06000184 RID: 388
		private delegate void GetDeviceIdsAtXRNode_InternalDelegate(XRNode node, IntPtr deviceIds);

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x06000186 RID: 390
		private delegate void GetLocalPosition_InjectedDelegate(XRNode node, [Out] IntPtr ret);

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x06000188 RID: 392
		private delegate void GetLocalRotation_InjectedDelegate(XRNode node, [Out] IntPtr ret);
	}
}
