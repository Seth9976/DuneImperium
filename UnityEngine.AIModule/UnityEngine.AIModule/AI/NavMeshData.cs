using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine.AI
{
	// Token: 0x0200000D RID: 13
	public sealed class NavMeshData : Object
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x00002A3C File Offset: 0x00000C3C
		public static void Internal_Create(NavMeshData mono, int agentTypeID)
		{
			NavMeshData.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mono), agentTypeID);
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00003754 File Offset: 0x00001954
		public Bounds sourceBounds
		{
			get
			{
				Bounds bounds;
				this.get_sourceBounds_Injected(out bounds);
				return bounds;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000376C File Offset: 0x0000196C
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00002A4F File Offset: 0x00000C4F
		public Vector3 position
		{
			get
			{
				Vector3 vector;
				this.get_position_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_position_Injected(ref value);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00003784 File Offset: 0x00001984
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00002A59 File Offset: 0x00000C59
		public Quaternion rotation
		{
			get
			{
				Quaternion quaternion;
				this.get_rotation_Injected(out quaternion);
				return quaternion;
			}
			set
			{
				this.set_rotation_Injected(ref value);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00002A63 File Offset: 0x00000C63
		public bool hasHeightMeshData
		{
			get
			{
				return NavMeshData.get_hasHeightMeshDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002A75 File Offset: 0x00000C75
		public void get_sourceBounds_Injected(out Bounds ret)
		{
			NavMeshData.get_sourceBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002A88 File Offset: 0x00000C88
		public void get_position_Injected(out Vector3 ret)
		{
			NavMeshData.get_position_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002A9B File Offset: 0x00000C9B
		public void set_position_Injected(ref Vector3 value)
		{
			NavMeshData.set_position_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002AAE File Offset: 0x00000CAE
		public void get_rotation_Injected(out Quaternion ret)
		{
			NavMeshData.get_rotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002AC1 File Offset: 0x00000CC1
		public void set_rotation_Injected(ref Quaternion value)
		{
			NavMeshData.set_rotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040000A5 RID: 165
		private static readonly NavMeshData.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<NavMeshData.Internal_CreateDelegate>("UnityEngine.AI.NavMeshData::Internal_Create");

		// Token: 0x040000A6 RID: 166
		private static readonly NavMeshData.get_hasHeightMeshDataDelegate get_hasHeightMeshDataDelegateField = IL2CPP.ResolveICall<NavMeshData.get_hasHeightMeshDataDelegate>("UnityEngine.AI.NavMeshData::get_hasHeightMeshData");

		// Token: 0x040000A7 RID: 167
		private static readonly NavMeshData.get_sourceBounds_InjectedDelegate get_sourceBounds_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshData.get_sourceBounds_InjectedDelegate>("UnityEngine.AI.NavMeshData::get_sourceBounds_Injected");

		// Token: 0x040000A8 RID: 168
		private static readonly NavMeshData.get_position_InjectedDelegate get_position_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshData.get_position_InjectedDelegate>("UnityEngine.AI.NavMeshData::get_position_Injected");

		// Token: 0x040000A9 RID: 169
		private static readonly NavMeshData.set_position_InjectedDelegate set_position_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshData.set_position_InjectedDelegate>("UnityEngine.AI.NavMeshData::set_position_Injected");

		// Token: 0x040000AA RID: 170
		private static readonly NavMeshData.get_rotation_InjectedDelegate get_rotation_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshData.get_rotation_InjectedDelegate>("UnityEngine.AI.NavMeshData::get_rotation_Injected");

		// Token: 0x040000AB RID: 171
		private static readonly NavMeshData.set_rotation_InjectedDelegate set_rotation_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshData.set_rotation_InjectedDelegate>("UnityEngine.AI.NavMeshData::set_rotation_Injected");

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x060001DA RID: 474
		private delegate void Internal_CreateDelegate(IntPtr mono, int agentTypeID);

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x060001DC RID: 476
		private delegate bool get_hasHeightMeshDataDelegate(IntPtr @this);

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x060001DE RID: 478
		private delegate void get_sourceBounds_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x060001E0 RID: 480
		private delegate void get_position_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x060001E2 RID: 482
		private delegate void set_position_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200009D RID: 157
		// (Invoke) Token: 0x060001E4 RID: 484
		private delegate void get_rotation_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200009E RID: 158
		// (Invoke) Token: 0x060001E6 RID: 486
		private delegate void set_rotation_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
