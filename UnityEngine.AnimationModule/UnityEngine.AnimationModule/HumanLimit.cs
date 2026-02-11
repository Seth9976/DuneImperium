using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000020 RID: 32
	[StructLayout(2)]
	public struct HumanLimit
	{
		// Token: 0x06000261 RID: 609 RVA: 0x0000F61C File Offset: 0x0000D81C
		// Note: this type is marked as 'beforefieldinit'.
		static HumanLimit()
		{
			Il2CppClassPointerStore<HumanLimit>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "HumanLimit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr);
			HumanLimit.NativeFieldInfoPtr_m_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, "m_Min");
			HumanLimit.NativeFieldInfoPtr_m_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, "m_Max");
			HumanLimit.NativeFieldInfoPtr_m_Center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, "m_Center");
			HumanLimit.NativeFieldInfoPtr_m_AxisLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, "m_AxisLength");
			HumanLimit.NativeFieldInfoPtr_m_UseDefaultValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, "m_UseDefaultValues");
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000026D2 File Offset: 0x000008D2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, ref this));
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000263 RID: 611 RVA: 0x0000F6B0 File Offset: 0x0000D8B0
		// (set) Token: 0x06000264 RID: 612 RVA: 0x000026E4 File Offset: 0x000008E4
		public bool useDefaultValues
		{
			get
			{
				return this.m_UseDefaultValues != 0;
			}
			set
			{
				this.m_UseDefaultValues = (value ? 1 : 0);
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000265 RID: 613 RVA: 0x0000F6CC File Offset: 0x0000D8CC
		// (set) Token: 0x06000266 RID: 614 RVA: 0x000026F4 File Offset: 0x000008F4
		public Vector3 min
		{
			get
			{
				return this.m_Min;
			}
			set
			{
				this.m_Min = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000267 RID: 615 RVA: 0x0000F6E4 File Offset: 0x0000D8E4
		// (set) Token: 0x06000268 RID: 616 RVA: 0x000026FE File Offset: 0x000008FE
		public Vector3 max
		{
			get
			{
				return this.m_Max;
			}
			set
			{
				this.m_Max = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000269 RID: 617 RVA: 0x0000F6FC File Offset: 0x0000D8FC
		// (set) Token: 0x0600026A RID: 618 RVA: 0x00002708 File Offset: 0x00000908
		public Vector3 center
		{
			get
			{
				return this.m_Center;
			}
			set
			{
				this.m_Center = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600026B RID: 619 RVA: 0x0000F714 File Offset: 0x0000D914
		// (set) Token: 0x0600026C RID: 620 RVA: 0x00002712 File Offset: 0x00000912
		public float axisLength
		{
			get
			{
				return this.m_AxisLength;
			}
			set
			{
				this.m_AxisLength = value;
			}
		}

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeFieldInfoPtr_m_Min;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeFieldInfoPtr_m_Max;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeFieldInfoPtr_m_Center;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeFieldInfoPtr_m_AxisLength;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeFieldInfoPtr_m_UseDefaultValues;

		// Token: 0x04000283 RID: 643
		[FieldOffset(0)]
		public Vector3 m_Min;

		// Token: 0x04000284 RID: 644
		[FieldOffset(12)]
		public Vector3 m_Max;

		// Token: 0x04000285 RID: 645
		[FieldOffset(24)]
		public Vector3 m_Center;

		// Token: 0x04000286 RID: 646
		[FieldOffset(36)]
		public float m_AxisLength;

		// Token: 0x04000287 RID: 647
		[FieldOffset(40)]
		public int m_UseDefaultValues;
	}
}
