using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.AI
{
	// Token: 0x0200000F RID: 15
	public sealed class NavMeshPath
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x00002AD4 File Offset: 0x00000CD4
		public override void Finalize()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002AE1 File Offset: 0x00000CE1
		public static IntPtr InitializeNavMeshPath()
		{
			return NavMeshPath.InitializeNavMeshPathDelegateField();
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002AED File Offset: 0x00000CED
		public static void DestroyNavMeshPath(IntPtr ptr)
		{
			NavMeshPath.DestroyNavMeshPathDelegateField(ptr);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002AFA File Offset: 0x00000CFA
		public int GetCornersNonAlloc([Out] Il2CppStructArray<Vector3> results)
		{
			return NavMeshPath.GetCornersNonAllocDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00003804 File Offset: 0x00001A04
		public Il2CppStructArray<Vector3> CalculateCornersInternal()
		{
			IntPtr intPtr = NavMeshPath.CalculateCornersInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002B12 File Offset: 0x00000D12
		public void ClearCornersInternal()
		{
			NavMeshPath.ClearCornersInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002B24 File Offset: 0x00000D24
		public void ClearCorners()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002B31 File Offset: 0x00000D31
		public void CalculateCorners()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00002B3E File Offset: 0x00000D3E
		public Il2CppStructArray<Vector3> corners
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00002B4B File Offset: 0x00000D4B
		public NavMeshPathStatus status
		{
			get
			{
				return NavMeshPath.get_statusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x040000B0 RID: 176
		private static readonly NavMeshPath.InitializeNavMeshPathDelegate InitializeNavMeshPathDelegateField = IL2CPP.ResolveICall<NavMeshPath.InitializeNavMeshPathDelegate>("UnityEngine.AI.NavMeshPath::InitializeNavMeshPath");

		// Token: 0x040000B1 RID: 177
		private static readonly NavMeshPath.DestroyNavMeshPathDelegate DestroyNavMeshPathDelegateField = IL2CPP.ResolveICall<NavMeshPath.DestroyNavMeshPathDelegate>("UnityEngine.AI.NavMeshPath::DestroyNavMeshPath");

		// Token: 0x040000B2 RID: 178
		private static readonly NavMeshPath.GetCornersNonAllocDelegate GetCornersNonAllocDelegateField = IL2CPP.ResolveICall<NavMeshPath.GetCornersNonAllocDelegate>("UnityEngine.AI.NavMeshPath::GetCornersNonAlloc");

		// Token: 0x040000B3 RID: 179
		private static readonly NavMeshPath.CalculateCornersInternalDelegate CalculateCornersInternalDelegateField = IL2CPP.ResolveICall<NavMeshPath.CalculateCornersInternalDelegate>("UnityEngine.AI.NavMeshPath::CalculateCornersInternal");

		// Token: 0x040000B4 RID: 180
		private static readonly NavMeshPath.ClearCornersInternalDelegate ClearCornersInternalDelegateField = IL2CPP.ResolveICall<NavMeshPath.ClearCornersInternalDelegate>("UnityEngine.AI.NavMeshPath::ClearCornersInternal");

		// Token: 0x040000B5 RID: 181
		private static readonly NavMeshPath.get_statusDelegate get_statusDelegateField = IL2CPP.ResolveICall<NavMeshPath.get_statusDelegate>("UnityEngine.AI.NavMeshPath::get_status");

		// Token: 0x0200009F RID: 159
		// (Invoke) Token: 0x060001E8 RID: 488
		private delegate IntPtr InitializeNavMeshPathDelegate();

		// Token: 0x020000A0 RID: 160
		// (Invoke) Token: 0x060001EA RID: 490
		private delegate void DestroyNavMeshPathDelegate(IntPtr ptr);

		// Token: 0x020000A1 RID: 161
		// (Invoke) Token: 0x060001EC RID: 492
		private delegate int GetCornersNonAllocDelegate(IntPtr @this, [Out] IntPtr results);

		// Token: 0x020000A2 RID: 162
		// (Invoke) Token: 0x060001EE RID: 494
		private delegate IntPtr CalculateCornersInternalDelegate(IntPtr @this);

		// Token: 0x020000A3 RID: 163
		// (Invoke) Token: 0x060001F0 RID: 496
		private delegate void ClearCornersInternalDelegate(IntPtr @this);

		// Token: 0x020000A4 RID: 164
		// (Invoke) Token: 0x060001F2 RID: 498
		private delegate NavMeshPathStatus get_statusDelegate(IntPtr @this);
	}
}
