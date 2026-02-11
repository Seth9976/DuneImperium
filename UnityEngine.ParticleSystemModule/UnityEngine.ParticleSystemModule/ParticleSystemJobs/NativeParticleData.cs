using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.ParticleSystemJobs
{
	// Token: 0x02000013 RID: 19
	[StructLayout(2)]
	public struct NativeParticleData
	{
		// Token: 0x060000EC RID: 236 RVA: 0x0000808C File Offset: 0x0000628C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeParticleData()
		{
			Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.ParticleSystemModule.dll", "UnityEngine.ParticleSystemJobs", "NativeParticleData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr);
			NativeParticleData.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "count");
			NativeParticleData.NativeFieldInfoPtr_positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "positions");
			NativeParticleData.NativeFieldInfoPtr_velocities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "velocities");
			NativeParticleData.NativeFieldInfoPtr_axisOfRotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "axisOfRotations");
			NativeParticleData.NativeFieldInfoPtr_rotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "rotations");
			NativeParticleData.NativeFieldInfoPtr_rotationalSpeeds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "rotationalSpeeds");
			NativeParticleData.NativeFieldInfoPtr_sizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "sizes");
			NativeParticleData.NativeFieldInfoPtr_startColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "startColors");
			NativeParticleData.NativeFieldInfoPtr_aliveTimePercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "aliveTimePercent");
			NativeParticleData.NativeFieldInfoPtr_inverseStartLifetimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "inverseStartLifetimes");
			NativeParticleData.NativeFieldInfoPtr_randomSeeds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "randomSeeds");
			NativeParticleData.NativeFieldInfoPtr_customData1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "customData1");
			NativeParticleData.NativeFieldInfoPtr_customData2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "customData2");
			NativeParticleData.NativeFieldInfoPtr_meshIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "meshIndices");
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002062 File Offset: 0x00000262
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, ref this));
		}

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeFieldInfoPtr_positions;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeFieldInfoPtr_velocities;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeFieldInfoPtr_axisOfRotations;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeFieldInfoPtr_rotations;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeFieldInfoPtr_rotationalSpeeds;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeFieldInfoPtr_sizes;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeFieldInfoPtr_startColors;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeFieldInfoPtr_aliveTimePercent;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeFieldInfoPtr_inverseStartLifetimes;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeFieldInfoPtr_randomSeeds;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeFieldInfoPtr_customData1;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeFieldInfoPtr_customData2;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeFieldInfoPtr_meshIndices;

		// Token: 0x0400017E RID: 382
		[FieldOffset(0)]
		public int count;

		// Token: 0x0400017F RID: 383
		[FieldOffset(8)]
		public NativeParticleData.Array3 positions;

		// Token: 0x04000180 RID: 384
		[FieldOffset(32)]
		public NativeParticleData.Array3 velocities;

		// Token: 0x04000181 RID: 385
		[FieldOffset(56)]
		public NativeParticleData.Array3 axisOfRotations;

		// Token: 0x04000182 RID: 386
		[FieldOffset(80)]
		public NativeParticleData.Array3 rotations;

		// Token: 0x04000183 RID: 387
		[FieldOffset(104)]
		public NativeParticleData.Array3 rotationalSpeeds;

		// Token: 0x04000184 RID: 388
		[FieldOffset(128)]
		public NativeParticleData.Array3 sizes;

		// Token: 0x04000185 RID: 389
		[FieldOffset(152)]
		public IntPtr startColors;

		// Token: 0x04000186 RID: 390
		[FieldOffset(160)]
		public IntPtr aliveTimePercent;

		// Token: 0x04000187 RID: 391
		[FieldOffset(168)]
		public IntPtr inverseStartLifetimes;

		// Token: 0x04000188 RID: 392
		[FieldOffset(176)]
		public IntPtr randomSeeds;

		// Token: 0x04000189 RID: 393
		[FieldOffset(184)]
		public NativeParticleData.Array4 customData1;

		// Token: 0x0400018A RID: 394
		[FieldOffset(216)]
		public NativeParticleData.Array4 customData2;

		// Token: 0x0400018B RID: 395
		[FieldOffset(248)]
		public IntPtr meshIndices;

		// Token: 0x0200005C RID: 92
		[StructLayout(2)]
		public struct Array3
		{
			// Token: 0x0600025F RID: 607 RVA: 0x0000C594 File Offset: 0x0000A794
			// Note: this type is marked as 'beforefieldinit'.
			static Array3()
			{
				Il2CppClassPointerStore<NativeParticleData.Array3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "Array3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeParticleData.Array3>.NativeClassPtr);
				NativeParticleData.Array3.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData.Array3>.NativeClassPtr, "x");
				NativeParticleData.Array3.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData.Array3>.NativeClassPtr, "y");
				NativeParticleData.Array3.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData.Array3>.NativeClassPtr, "z");
			}

			// Token: 0x06000260 RID: 608 RVA: 0x00002B95 File Offset: 0x00000D95
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParticleData.Array3>.NativeClassPtr, ref this));
			}

			// Token: 0x04000337 RID: 823
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04000338 RID: 824
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x04000339 RID: 825
			private static readonly IntPtr NativeFieldInfoPtr_z;

			// Token: 0x0400033A RID: 826
			[FieldOffset(0)]
			public IntPtr x;

			// Token: 0x0400033B RID: 827
			[FieldOffset(8)]
			public IntPtr y;

			// Token: 0x0400033C RID: 828
			[FieldOffset(16)]
			public IntPtr z;
		}

		// Token: 0x0200005D RID: 93
		[StructLayout(2)]
		public struct Array4
		{
			// Token: 0x06000261 RID: 609 RVA: 0x0000C5FC File Offset: 0x0000A7FC
			// Note: this type is marked as 'beforefieldinit'.
			static Array4()
			{
				Il2CppClassPointerStore<NativeParticleData.Array4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "Array4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeParticleData.Array4>.NativeClassPtr);
				NativeParticleData.Array4.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData.Array4>.NativeClassPtr, "x");
				NativeParticleData.Array4.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData.Array4>.NativeClassPtr, "y");
				NativeParticleData.Array4.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData.Array4>.NativeClassPtr, "z");
				NativeParticleData.Array4.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData.Array4>.NativeClassPtr, "w");
			}

			// Token: 0x06000262 RID: 610 RVA: 0x00002BA7 File Offset: 0x00000DA7
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParticleData.Array4>.NativeClassPtr, ref this));
			}

			// Token: 0x0400033D RID: 829
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x0400033E RID: 830
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x0400033F RID: 831
			private static readonly IntPtr NativeFieldInfoPtr_z;

			// Token: 0x04000340 RID: 832
			private static readonly IntPtr NativeFieldInfoPtr_w;

			// Token: 0x04000341 RID: 833
			[FieldOffset(0)]
			public IntPtr x;

			// Token: 0x04000342 RID: 834
			[FieldOffset(8)]
			public IntPtr y;

			// Token: 0x04000343 RID: 835
			[FieldOffset(16)]
			public IntPtr z;

			// Token: 0x04000344 RID: 836
			[FieldOffset(24)]
			public IntPtr w;
		}
	}
}
