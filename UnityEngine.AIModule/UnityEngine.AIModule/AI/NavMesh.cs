using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.AI
{
	// Token: 0x02000002 RID: 2
	public static class NavMesh : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002BCC File Offset: 0x00000DCC
		// Note: this type is marked as 'beforefieldinit'.
		static NavMesh()
		{
			Il2CppClassPointerStore<NavMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AIModule.dll", "UnityEngine.AI", "NavMesh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavMesh>.NativeClassPtr);
			NavMesh.NativeFieldInfoPtr_onPreUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMesh>.NativeClassPtr, "onPreUpdate");
			NavMesh.NativeMethodInfoPtr_Internal_CallOnNavMeshPreUpdate_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMesh>.NativeClassPtr, 100663297);
			NavMesh.SetLayerCostDelegateField = IL2CPP.ResolveICall<NavMesh.SetLayerCostDelegate>("UnityEngine.AI.NavMesh::SetLayerCost");
			NavMesh.GetLayerCostDelegateField = IL2CPP.ResolveICall<NavMesh.GetLayerCostDelegate>("UnityEngine.AI.NavMesh::GetLayerCost");
			NavMesh.GetNavMeshLayerFromNameDelegateField = IL2CPP.ResolveICall<NavMesh.GetNavMeshLayerFromNameDelegate>("UnityEngine.AI.NavMesh::GetNavMeshLayerFromName");
			NavMesh.SetAreaCostDelegateField = IL2CPP.ResolveICall<NavMesh.SetAreaCostDelegate>("UnityEngine.AI.NavMesh::SetAreaCost");
			NavMesh.GetAreaCostDelegateField = IL2CPP.ResolveICall<NavMesh.GetAreaCostDelegate>("UnityEngine.AI.NavMesh::GetAreaCost");
			NavMesh.GetAreaFromNameDelegateField = IL2CPP.ResolveICall<NavMesh.GetAreaFromNameDelegate>("UnityEngine.AI.NavMesh::GetAreaFromName");
			NavMesh.get_avoidancePredictionTimeDelegateField = IL2CPP.ResolveICall<NavMesh.get_avoidancePredictionTimeDelegate>("UnityEngine.AI.NavMesh::get_avoidancePredictionTime");
			NavMesh.set_avoidancePredictionTimeDelegateField = IL2CPP.ResolveICall<NavMesh.set_avoidancePredictionTimeDelegate>("UnityEngine.AI.NavMesh::set_avoidancePredictionTime");
			NavMesh.get_pathfindingIterationsPerFrameDelegateField = IL2CPP.ResolveICall<NavMesh.get_pathfindingIterationsPerFrameDelegate>("UnityEngine.AI.NavMesh::get_pathfindingIterationsPerFrame");
			NavMesh.set_pathfindingIterationsPerFrameDelegateField = IL2CPP.ResolveICall<NavMesh.set_pathfindingIterationsPerFrameDelegate>("UnityEngine.AI.NavMesh::set_pathfindingIterationsPerFrame");
			NavMesh.IsValidNavMeshDataHandleDelegateField = IL2CPP.ResolveICall<NavMesh.IsValidNavMeshDataHandleDelegate>("UnityEngine.AI.NavMesh::IsValidNavMeshDataHandle");
			NavMesh.IsValidLinkHandleDelegateField = IL2CPP.ResolveICall<NavMesh.IsValidLinkHandleDelegate>("UnityEngine.AI.NavMesh::IsValidLinkHandle");
			NavMesh.InternalGetOwnerDelegateField = IL2CPP.ResolveICall<NavMesh.InternalGetOwnerDelegate>("UnityEngine.AI.NavMesh::InternalGetOwner");
			NavMesh.InternalSetOwnerDelegateField = IL2CPP.ResolveICall<NavMesh.InternalSetOwnerDelegate>("UnityEngine.AI.NavMesh::InternalSetOwner");
			NavMesh.InternalGetLinkOwnerDelegateField = IL2CPP.ResolveICall<NavMesh.InternalGetLinkOwnerDelegate>("UnityEngine.AI.NavMesh::InternalGetLinkOwner");
			NavMesh.InternalSetLinkOwnerDelegateField = IL2CPP.ResolveICall<NavMesh.InternalSetLinkOwnerDelegate>("UnityEngine.AI.NavMesh::InternalSetLinkOwner");
			NavMesh.AddNavMeshDataInternalDelegateField = IL2CPP.ResolveICall<NavMesh.AddNavMeshDataInternalDelegate>("UnityEngine.AI.NavMesh::AddNavMeshDataInternal");
			NavMesh.RemoveNavMeshDataInternalDelegateField = IL2CPP.ResolveICall<NavMesh.RemoveNavMeshDataInternalDelegate>("UnityEngine.AI.NavMesh::RemoveNavMeshDataInternal");
			NavMesh.RemoveLinkInternalDelegateField = IL2CPP.ResolveICall<NavMesh.RemoveLinkInternalDelegate>("UnityEngine.AI.NavMesh::RemoveLinkInternal");
			NavMesh.RemoveSettingsDelegateField = IL2CPP.ResolveICall<NavMesh.RemoveSettingsDelegate>("UnityEngine.AI.NavMesh::RemoveSettings");
			NavMesh.GetSettingsCountDelegateField = IL2CPP.ResolveICall<NavMesh.GetSettingsCountDelegate>("UnityEngine.AI.NavMesh::GetSettingsCount");
			NavMesh.GetSettingsNameFromIDDelegateField = IL2CPP.ResolveICall<NavMesh.GetSettingsNameFromIDDelegate>("UnityEngine.AI.NavMesh::GetSettingsNameFromID");
			NavMesh.RemoveAllNavMeshDataDelegateField = IL2CPP.ResolveICall<NavMesh.RemoveAllNavMeshDataDelegate>("UnityEngine.AI.NavMesh::RemoveAllNavMeshData");
			NavMesh.CalculatePathInternal_InjectedDelegateField = IL2CPP.ResolveICall<NavMesh.CalculatePathInternal_InjectedDelegate>("UnityEngine.AI.NavMesh::CalculatePathInternal_Injected");
			NavMesh.AddNavMeshDataTransformedInternal_InjectedDelegateField = IL2CPP.ResolveICall<NavMesh.AddNavMeshDataTransformedInternal_InjectedDelegate>("UnityEngine.AI.NavMesh::AddNavMeshDataTransformedInternal_Injected");
			NavMesh.CalculatePathFilterInternal_InjectedDelegateField = IL2CPP.ResolveICall<NavMesh.CalculatePathFilterInternal_InjectedDelegate>("UnityEngine.AI.NavMesh::CalculatePathFilterInternal_Injected");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002DAC File Offset: 0x00000FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273075, XrefRangeEnd = 1273077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_CallOnNavMeshPreUpdate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMesh.NativeMethodInfoPtr_Internal_CallOnNavMeshPreUpdate_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		public NavMesh(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002DD4 File Offset: 0x00000FD4
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe static NavMesh.OnNavMeshPreUpdate onPreUpdate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NavMesh.NativeFieldInfoPtr_onPreUpdate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavMesh.OnNavMeshPreUpdate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavMesh.NativeFieldInfoPtr_onPreUpdate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002DFC File Offset: 0x00000FFC
		public static bool CalculatePath(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path)
		{
			path.ClearCorners();
			return NavMesh.CalculatePathInternal(sourcePosition, targetPosition, areaMask, path);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000206B File Offset: 0x0000026B
		public static bool CalculatePathInternal(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path)
		{
			return NavMesh.CalculatePathInternal_Injected(ref sourcePosition, ref targetPosition, areaMask, path);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002078 File Offset: 0x00000278
		public static void SetLayerCost(int layer, float cost)
		{
			NavMesh.SetLayerCostDelegateField(layer, cost);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002086 File Offset: 0x00000286
		public static float GetLayerCost(int layer)
		{
			return NavMesh.GetLayerCostDelegateField(layer);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002093 File Offset: 0x00000293
		public static int GetNavMeshLayerFromName(string layerName)
		{
			return NavMesh.GetNavMeshLayerFromNameDelegateField(IL2CPP.ManagedStringToIl2Cpp(layerName));
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020A5 File Offset: 0x000002A5
		public static void SetAreaCost(int areaIndex, float cost)
		{
			NavMesh.SetAreaCostDelegateField(areaIndex, cost);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020B3 File Offset: 0x000002B3
		public static float GetAreaCost(int areaIndex)
		{
			return NavMesh.GetAreaCostDelegateField(areaIndex);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020C0 File Offset: 0x000002C0
		public static int GetAreaFromName(string areaName)
		{
			return NavMesh.GetAreaFromNameDelegateField(IL2CPP.ManagedStringToIl2Cpp(areaName));
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020D2 File Offset: 0x000002D2
		public static void Triangulate(out Il2CppStructArray<Vector3> vertices, out Il2CppStructArray<int> indices)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020DF File Offset: 0x000002DF
		public static void AddOffMeshLinks()
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020E2 File Offset: 0x000002E2
		public static void RestoreNavMesh()
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000020E5 File Offset: 0x000002E5
		// (set) Token: 0x06000012 RID: 18 RVA: 0x000020F1 File Offset: 0x000002F1
		public static float avoidancePredictionTime
		{
			get
			{
				return NavMesh.get_avoidancePredictionTimeDelegateField();
			}
			set
			{
				NavMesh.set_avoidancePredictionTimeDelegateField(value);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000020FE File Offset: 0x000002FE
		// (set) Token: 0x06000014 RID: 20 RVA: 0x0000210A File Offset: 0x0000030A
		public static int pathfindingIterationsPerFrame
		{
			get
			{
				return NavMesh.get_pathfindingIterationsPerFrameDelegateField();
			}
			set
			{
				NavMesh.set_pathfindingIterationsPerFrameDelegateField(value);
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002117 File Offset: 0x00000317
		public static bool IsValidNavMeshDataHandle(int handle)
		{
			return NavMesh.IsValidNavMeshDataHandleDelegateField(handle);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002124 File Offset: 0x00000324
		public static bool IsValidLinkHandle(int handle)
		{
			return NavMesh.IsValidLinkHandleDelegateField(handle);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002E20 File Offset: 0x00001020
		public static Object InternalGetOwner(int dataID)
		{
			IntPtr intPtr = NavMesh.InternalGetOwnerDelegateField(dataID);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002131 File Offset: 0x00000331
		public static bool InternalSetOwner(int dataID, int ownerID)
		{
			return NavMesh.InternalSetOwnerDelegateField(dataID, ownerID);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002E48 File Offset: 0x00001048
		public static Object InternalGetLinkOwner(int linkID)
		{
			IntPtr intPtr = NavMesh.InternalGetLinkOwnerDelegateField(linkID);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000213F File Offset: 0x0000033F
		public static bool InternalSetLinkOwner(int linkID, int ownerID)
		{
			return NavMesh.InternalSetLinkOwnerDelegateField(linkID, ownerID);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000214D File Offset: 0x0000034D
		public static int AddNavMeshDataInternal(NavMeshData navMeshData)
		{
			return NavMesh.AddNavMeshDataInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(navMeshData));
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000215F File Offset: 0x0000035F
		public static int AddNavMeshDataTransformedInternal(NavMeshData navMeshData, Vector3 position, Quaternion rotation)
		{
			return NavMesh.AddNavMeshDataTransformedInternal_Injected(navMeshData, ref position, ref rotation);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000216B File Offset: 0x0000036B
		public static void RemoveNavMeshDataInternal(int handle)
		{
			NavMesh.RemoveNavMeshDataInternalDelegateField(handle);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002178 File Offset: 0x00000378
		public static void RemoveLinkInternal(int handle)
		{
			NavMesh.RemoveLinkInternalDelegateField(handle);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002185 File Offset: 0x00000385
		public static bool CalculatePathFilterInternal(Vector3 sourcePosition, Vector3 targetPosition, NavMeshPath path, int type, int mask, Il2CppStructArray<float> costs)
		{
			return NavMesh.CalculatePathFilterInternal_Injected(ref sourcePosition, ref targetPosition, path, type, mask, costs);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002196 File Offset: 0x00000396
		public static void RemoveSettings(int agentTypeID)
		{
			NavMesh.RemoveSettingsDelegateField(agentTypeID);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000021A3 File Offset: 0x000003A3
		public static int GetSettingsCount()
		{
			return NavMesh.GetSettingsCountDelegateField();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002E70 File Offset: 0x00001070
		public static string GetSettingsNameFromID(int agentTypeID)
		{
			IntPtr intPtr = NavMesh.GetSettingsNameFromIDDelegateField(agentTypeID);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000021AF File Offset: 0x000003AF
		public static void RemoveAllNavMeshData()
		{
			NavMesh.RemoveAllNavMeshDataDelegateField();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000021BB File Offset: 0x000003BB
		public static bool CalculatePathInternal_Injected(ref Vector3 sourcePosition, ref Vector3 targetPosition, int areaMask, NavMeshPath path)
		{
			return NavMesh.CalculatePathInternal_InjectedDelegateField(ref sourcePosition, ref targetPosition, areaMask, IL2CPP.Il2CppObjectBaseToPtr(path));
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000021D0 File Offset: 0x000003D0
		public static int AddNavMeshDataTransformedInternal_Injected(NavMeshData navMeshData, ref Vector3 position, ref Quaternion rotation)
		{
			return NavMesh.AddNavMeshDataTransformedInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(navMeshData), ref position, ref rotation);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000021E4 File Offset: 0x000003E4
		public static bool CalculatePathFilterInternal_Injected(ref Vector3 sourcePosition, ref Vector3 targetPosition, NavMeshPath path, int type, int mask, Il2CppStructArray<float> costs)
		{
			return NavMesh.CalculatePathFilterInternal_InjectedDelegateField(ref sourcePosition, ref targetPosition, IL2CPP.Il2CppObjectBaseToPtr(path), type, mask, IL2CPP.Il2CppObjectBaseToPtr(costs));
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_onPreUpdate;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CallOnNavMeshPreUpdate_Private_Static_Void_0;

		// Token: 0x04000003 RID: 3
		public const int AllAreas = -1;

		// Token: 0x04000004 RID: 4
		private static readonly NavMesh.SetLayerCostDelegate SetLayerCostDelegateField;

		// Token: 0x04000005 RID: 5
		private static readonly NavMesh.GetLayerCostDelegate GetLayerCostDelegateField;

		// Token: 0x04000006 RID: 6
		private static readonly NavMesh.GetNavMeshLayerFromNameDelegate GetNavMeshLayerFromNameDelegateField;

		// Token: 0x04000007 RID: 7
		private static readonly NavMesh.SetAreaCostDelegate SetAreaCostDelegateField;

		// Token: 0x04000008 RID: 8
		private static readonly NavMesh.GetAreaCostDelegate GetAreaCostDelegateField;

		// Token: 0x04000009 RID: 9
		private static readonly NavMesh.GetAreaFromNameDelegate GetAreaFromNameDelegateField;

		// Token: 0x0400000A RID: 10
		private static readonly NavMesh.get_avoidancePredictionTimeDelegate get_avoidancePredictionTimeDelegateField;

		// Token: 0x0400000B RID: 11
		private static readonly NavMesh.set_avoidancePredictionTimeDelegate set_avoidancePredictionTimeDelegateField;

		// Token: 0x0400000C RID: 12
		private static readonly NavMesh.get_pathfindingIterationsPerFrameDelegate get_pathfindingIterationsPerFrameDelegateField;

		// Token: 0x0400000D RID: 13
		private static readonly NavMesh.set_pathfindingIterationsPerFrameDelegate set_pathfindingIterationsPerFrameDelegateField;

		// Token: 0x0400000E RID: 14
		private static readonly NavMesh.IsValidNavMeshDataHandleDelegate IsValidNavMeshDataHandleDelegateField;

		// Token: 0x0400000F RID: 15
		private static readonly NavMesh.IsValidLinkHandleDelegate IsValidLinkHandleDelegateField;

		// Token: 0x04000010 RID: 16
		private static readonly NavMesh.InternalGetOwnerDelegate InternalGetOwnerDelegateField;

		// Token: 0x04000011 RID: 17
		private static readonly NavMesh.InternalSetOwnerDelegate InternalSetOwnerDelegateField;

		// Token: 0x04000012 RID: 18
		private static readonly NavMesh.InternalGetLinkOwnerDelegate InternalGetLinkOwnerDelegateField;

		// Token: 0x04000013 RID: 19
		private static readonly NavMesh.InternalSetLinkOwnerDelegate InternalSetLinkOwnerDelegateField;

		// Token: 0x04000014 RID: 20
		private static readonly NavMesh.AddNavMeshDataInternalDelegate AddNavMeshDataInternalDelegateField;

		// Token: 0x04000015 RID: 21
		private static readonly NavMesh.RemoveNavMeshDataInternalDelegate RemoveNavMeshDataInternalDelegateField;

		// Token: 0x04000016 RID: 22
		private static readonly NavMesh.RemoveLinkInternalDelegate RemoveLinkInternalDelegateField;

		// Token: 0x04000017 RID: 23
		private static readonly NavMesh.RemoveSettingsDelegate RemoveSettingsDelegateField;

		// Token: 0x04000018 RID: 24
		private static readonly NavMesh.GetSettingsCountDelegate GetSettingsCountDelegateField;

		// Token: 0x04000019 RID: 25
		private static readonly NavMesh.GetSettingsNameFromIDDelegate GetSettingsNameFromIDDelegateField;

		// Token: 0x0400001A RID: 26
		private static readonly NavMesh.RemoveAllNavMeshDataDelegate RemoveAllNavMeshDataDelegateField;

		// Token: 0x0400001B RID: 27
		private static readonly NavMesh.CalculatePathInternal_InjectedDelegate CalculatePathInternal_InjectedDelegateField;

		// Token: 0x0400001C RID: 28
		private static readonly NavMesh.AddNavMeshDataTransformedInternal_InjectedDelegate AddNavMeshDataTransformedInternal_InjectedDelegateField;

		// Token: 0x0400001D RID: 29
		private static readonly NavMesh.CalculatePathFilterInternal_InjectedDelegate CalculatePathFilterInternal_InjectedDelegateField;

		// Token: 0x02000013 RID: 19
		public sealed class OnNavMeshPreUpdate : MulticastDelegate
		{
			// Token: 0x060000CA RID: 202 RVA: 0x00002B5D File Offset: 0x00000D5D
			// Note: this type is marked as 'beforefieldinit'.
			static OnNavMeshPreUpdate()
			{
				Il2CppClassPointerStore<NavMesh.OnNavMeshPreUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavMesh>.NativeClassPtr, "OnNavMeshPreUpdate");
				NavMesh.OnNavMeshPreUpdate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMesh.OnNavMeshPreUpdate>.NativeClassPtr, 100663298);
				NavMesh.OnNavMeshPreUpdate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMesh.OnNavMeshPreUpdate>.NativeClassPtr, 100663299);
			}

			// Token: 0x060000CB RID: 203 RVA: 0x00003830 File Offset: 0x00001A30
			[CallerCount(288)]
			[CachedScanResults(RefRangeStart = 320972, RefRangeEnd = 321260, XrefRangeStart = 320972, XrefRangeEnd = 321260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnNavMeshPreUpdate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavMesh.OnNavMeshPreUpdate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMesh.OnNavMeshPreUpdate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000CC RID: 204 RVA: 0x0000388C File Offset: 0x00001A8C
			[CallerCount(0)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMesh.OnNavMeshPreUpdate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000CD RID: 205 RVA: 0x00002B9B File Offset: 0x00000D9B
			public OnNavMeshPreUpdate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060000CE RID: 206 RVA: 0x00002BA4 File Offset: 0x00000DA4
			public static implicit operator NavMesh.OnNavMeshPreUpdate(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<NavMesh.OnNavMeshPreUpdate>(A_0);
			}

			// Token: 0x060000CF RID: 207 RVA: 0x00002BAC File Offset: 0x00000DAC
			public static NavMesh.OnNavMeshPreUpdate operator +(NavMesh.OnNavMeshPreUpdate A_0, NavMesh.OnNavMeshPreUpdate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<NavMesh.OnNavMeshPreUpdate>();
			}

			// Token: 0x060000D0 RID: 208 RVA: 0x00002BBA File Offset: 0x00000DBA
			public static NavMesh.OnNavMeshPreUpdate operator -(NavMesh.OnNavMeshPreUpdate A_0, NavMesh.OnNavMeshPreUpdate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<NavMesh.OnNavMeshPreUpdate>();
				}
				return delegate2;
			}

			// Token: 0x040000CA RID: 202
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040000CB RID: 203
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
		}

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x060000D2 RID: 210
		private delegate void SetLayerCostDelegate(int layer, float cost);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x060000D4 RID: 212
		private delegate float GetLayerCostDelegate(int layer);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x060000D6 RID: 214
		private delegate int GetNavMeshLayerFromNameDelegate(IntPtr layerName);

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x060000D8 RID: 216
		private delegate void SetAreaCostDelegate(int areaIndex, float cost);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x060000DA RID: 218
		private delegate float GetAreaCostDelegate(int areaIndex);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x060000DC RID: 220
		private delegate int GetAreaFromNameDelegate(IntPtr areaName);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x060000DE RID: 222
		private delegate float get_avoidancePredictionTimeDelegate();

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x060000E0 RID: 224
		private delegate void set_avoidancePredictionTimeDelegate(float value);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x060000E2 RID: 226
		private delegate int get_pathfindingIterationsPerFrameDelegate();

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x060000E4 RID: 228
		private delegate void set_pathfindingIterationsPerFrameDelegate(int value);

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x060000E6 RID: 230
		private delegate bool IsValidNavMeshDataHandleDelegate(int handle);

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x060000E8 RID: 232
		private delegate bool IsValidLinkHandleDelegate(int handle);

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x060000EA RID: 234
		private delegate IntPtr InternalGetOwnerDelegate(int dataID);

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x060000EC RID: 236
		private delegate bool InternalSetOwnerDelegate(int dataID, int ownerID);

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x060000EE RID: 238
		private delegate IntPtr InternalGetLinkOwnerDelegate(int linkID);

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x060000F0 RID: 240
		private delegate bool InternalSetLinkOwnerDelegate(int linkID, int ownerID);

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x060000F2 RID: 242
		private delegate int AddNavMeshDataInternalDelegate(IntPtr navMeshData);

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x060000F4 RID: 244
		private delegate void RemoveNavMeshDataInternalDelegate(int handle);

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x060000F6 RID: 246
		private delegate void RemoveLinkInternalDelegate(int handle);

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x060000F8 RID: 248
		private delegate void RemoveSettingsDelegate(int agentTypeID);

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x060000FA RID: 250
		private delegate int GetSettingsCountDelegate();

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x060000FC RID: 252
		private delegate IntPtr GetSettingsNameFromIDDelegate(int agentTypeID);

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x060000FE RID: 254
		private delegate void RemoveAllNavMeshDataDelegate();

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x06000100 RID: 256
		private delegate bool CalculatePathInternal_InjectedDelegate(IntPtr sourcePosition, IntPtr targetPosition, int areaMask, IntPtr path);

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x06000102 RID: 258
		private delegate int AddNavMeshDataTransformedInternal_InjectedDelegate(IntPtr navMeshData, IntPtr position, IntPtr rotation);

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x06000104 RID: 260
		private delegate bool CalculatePathFilterInternal_InjectedDelegate(IntPtr sourcePosition, IntPtr targetPosition, IntPtr path, int type, int mask, IntPtr costs);
	}
}
