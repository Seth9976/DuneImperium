using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.U2D
{
	// Token: 0x02000186 RID: 390
	[Serializable]
	public sealed class SpriteBone : ValueType
	{
		// Token: 0x06001D20 RID: 7456 RVA: 0x000860F8 File Offset: 0x000842F8
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteBone()
		{
			Il2CppClassPointerStore<SpriteBone>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.U2D", "SpriteBone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr);
			SpriteBone.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, "m_Name");
			SpriteBone.NativeFieldInfoPtr_m_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, "m_Guid");
			SpriteBone.NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, "m_Position");
			SpriteBone.NativeFieldInfoPtr_m_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, "m_Rotation");
			SpriteBone.NativeFieldInfoPtr_m_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, "m_Length");
			SpriteBone.NativeFieldInfoPtr_m_ParentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, "m_ParentId");
			SpriteBone.NativeFieldInfoPtr_m_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, "m_Color");
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x0000AD72 File Offset: 0x00008F72
		public SpriteBone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x0000AD7B File Offset: 0x00008F7B
		public SpriteBone()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr))
		{
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x000861B4 File Offset: 0x000843B4
		// (set) Token: 0x06001D24 RID: 7460 RVA: 0x0000AD8D File Offset: 0x00008F8D
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x000861DC File Offset: 0x000843DC
		// (set) Token: 0x06001D26 RID: 7462 RVA: 0x0000ADAC File Offset: 0x00008FAC
		public unsafe string m_Guid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Guid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Guid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x00086204 File Offset: 0x00084404
		// (set) Token: 0x06001D28 RID: 7464 RVA: 0x0000ADCB File Offset: 0x00008FCB
		public unsafe Vector3 m_Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Position)) = value;
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x0008622C File Offset: 0x0008442C
		// (set) Token: 0x06001D2A RID: 7466 RVA: 0x0000ADE6 File Offset: 0x00008FE6
		public unsafe Quaternion m_Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Rotation)) = value;
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x00086254 File Offset: 0x00084454
		// (set) Token: 0x06001D2C RID: 7468 RVA: 0x0000AE01 File Offset: 0x00009001
		public unsafe float m_Length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Length)) = value;
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001D2D RID: 7469 RVA: 0x0008627C File Offset: 0x0008447C
		// (set) Token: 0x06001D2E RID: 7470 RVA: 0x0000AE1C File Offset: 0x0000901C
		public unsafe int m_ParentId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_ParentId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_ParentId)) = value;
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001D2F RID: 7471 RVA: 0x000862A4 File Offset: 0x000844A4
		// (set) Token: 0x06001D30 RID: 7472 RVA: 0x0000AE37 File Offset: 0x00009037
		public unsafe Color32 m_Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Color)) = value;
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x000862CC File Offset: 0x000844CC
		// (set) Token: 0x06001D32 RID: 7474 RVA: 0x0000AE52 File Offset: 0x00009052
		public string name
		{
			get
			{
				return this.m_Name;
			}
			set
			{
				this.m_Name = value;
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001D33 RID: 7475 RVA: 0x000862E4 File Offset: 0x000844E4
		// (set) Token: 0x06001D34 RID: 7476 RVA: 0x0000AE5C File Offset: 0x0000905C
		public string guid
		{
			get
			{
				return this.m_Guid;
			}
			set
			{
				this.m_Guid = value;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001D35 RID: 7477 RVA: 0x000862FC File Offset: 0x000844FC
		// (set) Token: 0x06001D36 RID: 7478 RVA: 0x0000AE66 File Offset: 0x00009066
		public Vector3 position
		{
			get
			{
				return this.m_Position;
			}
			set
			{
				this.m_Position = value;
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001D37 RID: 7479 RVA: 0x00086314 File Offset: 0x00084514
		// (set) Token: 0x06001D38 RID: 7480 RVA: 0x0000AE70 File Offset: 0x00009070
		public Quaternion rotation
		{
			get
			{
				return this.m_Rotation;
			}
			set
			{
				this.m_Rotation = value;
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001D39 RID: 7481 RVA: 0x0008632C File Offset: 0x0008452C
		// (set) Token: 0x06001D3A RID: 7482 RVA: 0x0000AE7A File Offset: 0x0000907A
		public float length
		{
			get
			{
				return this.m_Length;
			}
			set
			{
				this.m_Length = value;
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001D3B RID: 7483 RVA: 0x00086344 File Offset: 0x00084544
		// (set) Token: 0x06001D3C RID: 7484 RVA: 0x0000AE84 File Offset: 0x00009084
		public int parentId
		{
			get
			{
				return this.m_ParentId;
			}
			set
			{
				this.m_ParentId = value;
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001D3D RID: 7485 RVA: 0x0008635C File Offset: 0x0008455C
		// (set) Token: 0x06001D3E RID: 7486 RVA: 0x0000AE8E File Offset: 0x0000908E
		public Color32 color
		{
			get
			{
				return this.m_Color;
			}
			set
			{
				this.m_Color = value;
			}
		}

		// Token: 0x040019E6 RID: 6630
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x040019E7 RID: 6631
		private static readonly IntPtr NativeFieldInfoPtr_m_Guid;

		// Token: 0x040019E8 RID: 6632
		private static readonly IntPtr NativeFieldInfoPtr_m_Position;

		// Token: 0x040019E9 RID: 6633
		private static readonly IntPtr NativeFieldInfoPtr_m_Rotation;

		// Token: 0x040019EA RID: 6634
		private static readonly IntPtr NativeFieldInfoPtr_m_Length;

		// Token: 0x040019EB RID: 6635
		private static readonly IntPtr NativeFieldInfoPtr_m_ParentId;

		// Token: 0x040019EC RID: 6636
		private static readonly IntPtr NativeFieldInfoPtr_m_Color;
	}
}
