using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200007A RID: 122
	[StructLayout(2)]
	public struct CullingGroupEvent
	{
		// Token: 0x06000593 RID: 1427 RVA: 0x000289B4 File Offset: 0x00026BB4
		// Note: this type is marked as 'beforefieldinit'.
		static CullingGroupEvent()
		{
			Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CullingGroupEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr);
			CullingGroupEvent.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr, "m_Index");
			CullingGroupEvent.NativeFieldInfoPtr_m_PrevState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr, "m_PrevState");
			CullingGroupEvent.NativeFieldInfoPtr_m_ThisState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr, "m_ThisState");
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x000041F5 File Offset: 0x000023F5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr, ref this));
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x00028A20 File Offset: 0x00026C20
		public int index
		{
			get
			{
				return this.m_Index;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x00028A38 File Offset: 0x00026C38
		public bool isVisible
		{
			get
			{
				return (this.m_ThisState & 128) > 0;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00028A5C File Offset: 0x00026C5C
		public bool wasVisible
		{
			get
			{
				return (this.m_PrevState & 128) > 0;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x00028A80 File Offset: 0x00026C80
		public bool hasBecomeVisible
		{
			get
			{
				return this.isVisible && !this.wasVisible;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00028AA8 File Offset: 0x00026CA8
		public bool hasBecomeInvisible
		{
			get
			{
				return !this.isVisible && this.wasVisible;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x00028ACC File Offset: 0x00026CCC
		public int currentDistance
		{
			get
			{
				return (int)(this.m_ThisState & 127);
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x00028AE8 File Offset: 0x00026CE8
		public int previousDistance
		{
			get
			{
				return (int)(this.m_PrevState & 127);
			}
		}

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeFieldInfoPtr_m_Index;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevState;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeFieldInfoPtr_m_ThisState;

		// Token: 0x040004ED RID: 1261
		[FieldOffset(0)]
		public int m_Index;

		// Token: 0x040004EE RID: 1262
		[FieldOffset(4)]
		public byte m_PrevState;

		// Token: 0x040004EF RID: 1263
		[FieldOffset(5)]
		public byte m_ThisState;

		// Token: 0x040004F0 RID: 1264
		public const byte kIsVisibleMask = 128;

		// Token: 0x040004F1 RID: 1265
		public const byte kDistanceMask = 127;
	}
}
