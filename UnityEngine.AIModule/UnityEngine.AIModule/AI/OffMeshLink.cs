using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.AI
{
	// Token: 0x0200000C RID: 12
	public sealed class OffMeshLink : Behaviour
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00002924 File Offset: 0x00000B24
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00002936 File Offset: 0x00000B36
		public bool activated
		{
			get
			{
				return OffMeshLink.get_activatedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				OffMeshLink.set_activatedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00002949 File Offset: 0x00000B49
		public bool occupied
		{
			get
			{
				return OffMeshLink.get_occupiedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000295B File Offset: 0x00000B5B
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x0000296D File Offset: 0x00000B6D
		public float costOverride
		{
			get
			{
				return OffMeshLink.get_costOverrideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				OffMeshLink.set_costOverrideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00002980 File Offset: 0x00000B80
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00002992 File Offset: 0x00000B92
		public bool biDirectional
		{
			get
			{
				return OffMeshLink.get_biDirectionalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				OffMeshLink.set_biDirectionalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000029A5 File Offset: 0x00000BA5
		public void UpdatePositions()
		{
			OffMeshLink.UpdatePositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0000366C File Offset: 0x0000186C
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x000029B7 File Offset: 0x00000BB7
		public int navMeshLayer
		{
			get
			{
				return this.area;
			}
			set
			{
				this.area = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000AA RID: 170 RVA: 0x000029C2 File Offset: 0x00000BC2
		// (set) Token: 0x060000AB RID: 171 RVA: 0x000029D4 File Offset: 0x00000BD4
		public int area
		{
			get
			{
				return OffMeshLink.get_areaDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				OffMeshLink.set_areaDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000AC RID: 172 RVA: 0x000029E7 File Offset: 0x00000BE7
		// (set) Token: 0x060000AD RID: 173 RVA: 0x000029F9 File Offset: 0x00000BF9
		public bool autoUpdatePositions
		{
			get
			{
				return OffMeshLink.get_autoUpdatePositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				OffMeshLink.set_autoUpdatePositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00003684 File Offset: 0x00001884
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00002A0C File Offset: 0x00000C0C
		public Transform startTransform
		{
			get
			{
				IntPtr intPtr = OffMeshLink.get_startTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				OffMeshLink.set_startTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000036B0 File Offset: 0x000018B0
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00002A24 File Offset: 0x00000C24
		public Transform endTransform
		{
			get
			{
				IntPtr intPtr = OffMeshLink.get_endTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				OffMeshLink.set_endTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000095 RID: 149
		private static readonly OffMeshLink.get_activatedDelegate get_activatedDelegateField = IL2CPP.ResolveICall<OffMeshLink.get_activatedDelegate>("UnityEngine.AI.OffMeshLink::get_activated");

		// Token: 0x04000096 RID: 150
		private static readonly OffMeshLink.set_activatedDelegate set_activatedDelegateField = IL2CPP.ResolveICall<OffMeshLink.set_activatedDelegate>("UnityEngine.AI.OffMeshLink::set_activated");

		// Token: 0x04000097 RID: 151
		private static readonly OffMeshLink.get_occupiedDelegate get_occupiedDelegateField = IL2CPP.ResolveICall<OffMeshLink.get_occupiedDelegate>("UnityEngine.AI.OffMeshLink::get_occupied");

		// Token: 0x04000098 RID: 152
		private static readonly OffMeshLink.get_costOverrideDelegate get_costOverrideDelegateField = IL2CPP.ResolveICall<OffMeshLink.get_costOverrideDelegate>("UnityEngine.AI.OffMeshLink::get_costOverride");

		// Token: 0x04000099 RID: 153
		private static readonly OffMeshLink.set_costOverrideDelegate set_costOverrideDelegateField = IL2CPP.ResolveICall<OffMeshLink.set_costOverrideDelegate>("UnityEngine.AI.OffMeshLink::set_costOverride");

		// Token: 0x0400009A RID: 154
		private static readonly OffMeshLink.get_biDirectionalDelegate get_biDirectionalDelegateField = IL2CPP.ResolveICall<OffMeshLink.get_biDirectionalDelegate>("UnityEngine.AI.OffMeshLink::get_biDirectional");

		// Token: 0x0400009B RID: 155
		private static readonly OffMeshLink.set_biDirectionalDelegate set_biDirectionalDelegateField = IL2CPP.ResolveICall<OffMeshLink.set_biDirectionalDelegate>("UnityEngine.AI.OffMeshLink::set_biDirectional");

		// Token: 0x0400009C RID: 156
		private static readonly OffMeshLink.UpdatePositionsDelegate UpdatePositionsDelegateField = IL2CPP.ResolveICall<OffMeshLink.UpdatePositionsDelegate>("UnityEngine.AI.OffMeshLink::UpdatePositions");

		// Token: 0x0400009D RID: 157
		private static readonly OffMeshLink.get_areaDelegate get_areaDelegateField = IL2CPP.ResolveICall<OffMeshLink.get_areaDelegate>("UnityEngine.AI.OffMeshLink::get_area");

		// Token: 0x0400009E RID: 158
		private static readonly OffMeshLink.set_areaDelegate set_areaDelegateField = IL2CPP.ResolveICall<OffMeshLink.set_areaDelegate>("UnityEngine.AI.OffMeshLink::set_area");

		// Token: 0x0400009F RID: 159
		private static readonly OffMeshLink.get_autoUpdatePositionsDelegate get_autoUpdatePositionsDelegateField = IL2CPP.ResolveICall<OffMeshLink.get_autoUpdatePositionsDelegate>("UnityEngine.AI.OffMeshLink::get_autoUpdatePositions");

		// Token: 0x040000A0 RID: 160
		private static readonly OffMeshLink.set_autoUpdatePositionsDelegate set_autoUpdatePositionsDelegateField = IL2CPP.ResolveICall<OffMeshLink.set_autoUpdatePositionsDelegate>("UnityEngine.AI.OffMeshLink::set_autoUpdatePositions");

		// Token: 0x040000A1 RID: 161
		private static readonly OffMeshLink.get_startTransformDelegate get_startTransformDelegateField = IL2CPP.ResolveICall<OffMeshLink.get_startTransformDelegate>("UnityEngine.AI.OffMeshLink::get_startTransform");

		// Token: 0x040000A2 RID: 162
		private static readonly OffMeshLink.set_startTransformDelegate set_startTransformDelegateField = IL2CPP.ResolveICall<OffMeshLink.set_startTransformDelegate>("UnityEngine.AI.OffMeshLink::set_startTransform");

		// Token: 0x040000A3 RID: 163
		private static readonly OffMeshLink.get_endTransformDelegate get_endTransformDelegateField = IL2CPP.ResolveICall<OffMeshLink.get_endTransformDelegate>("UnityEngine.AI.OffMeshLink::get_endTransform");

		// Token: 0x040000A4 RID: 164
		private static readonly OffMeshLink.set_endTransformDelegate set_endTransformDelegateField = IL2CPP.ResolveICall<OffMeshLink.set_endTransformDelegate>("UnityEngine.AI.OffMeshLink::set_endTransform");

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x060001BA RID: 442
		private delegate bool get_activatedDelegate(IntPtr @this);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x060001BC RID: 444
		private delegate void set_activatedDelegate(IntPtr @this, bool value);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x060001BE RID: 446
		private delegate bool get_occupiedDelegate(IntPtr @this);

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x060001C0 RID: 448
		private delegate float get_costOverrideDelegate(IntPtr @this);

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x060001C2 RID: 450
		private delegate void set_costOverrideDelegate(IntPtr @this, float value);

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x060001C4 RID: 452
		private delegate bool get_biDirectionalDelegate(IntPtr @this);

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x060001C6 RID: 454
		private delegate void set_biDirectionalDelegate(IntPtr @this, bool value);

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x060001C8 RID: 456
		private delegate void UpdatePositionsDelegate(IntPtr @this);

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x060001CA RID: 458
		private delegate int get_areaDelegate(IntPtr @this);

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x060001CC RID: 460
		private delegate void set_areaDelegate(IntPtr @this, int value);

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x060001CE RID: 462
		private delegate bool get_autoUpdatePositionsDelegate(IntPtr @this);

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x060001D0 RID: 464
		private delegate void set_autoUpdatePositionsDelegate(IntPtr @this, bool value);

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x060001D2 RID: 466
		private delegate IntPtr get_startTransformDelegate(IntPtr @this);

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x060001D4 RID: 468
		private delegate void set_startTransformDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x060001D6 RID: 470
		private delegate IntPtr get_endTransformDelegate(IntPtr @this);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x060001D8 RID: 472
		private delegate void set_endTransformDelegate(IntPtr @this, IntPtr value);
	}
}
