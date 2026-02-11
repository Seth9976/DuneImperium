using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000027 RID: 39
	[StructLayout(2)]
	public struct LightStats
	{
		// Token: 0x06000319 RID: 793 RVA: 0x00020988 File Offset: 0x0001EB88
		// Note: this type is marked as 'beforefieldinit'.
		static LightStats()
		{
			Il2CppClassPointerStore<LightStats>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "LightStats");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightStats>.NativeClassPtr);
			LightStats.NativeFieldInfoPtr_totalLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightStats>.NativeClassPtr, "totalLights");
			LightStats.NativeFieldInfoPtr_totalNormalMapUsage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightStats>.NativeClassPtr, "totalNormalMapUsage");
			LightStats.NativeFieldInfoPtr_totalVolumetricUsage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightStats>.NativeClassPtr, "totalVolumetricUsage");
			LightStats.NativeFieldInfoPtr_blendStylesUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightStats>.NativeClassPtr, "blendStylesUsed");
			LightStats.NativeFieldInfoPtr_blendStylesWithLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightStats>.NativeClassPtr, "blendStylesWithLights");
			LightStats.NativeMethodInfoPtr_get_useNormalMap_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightStats>.NativeClassPtr, 100663688);
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600031A RID: 794 RVA: 0x00020A30 File Offset: 0x0001EC30
		public unsafe bool useNormalMap
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightStats.NativeMethodInfoPtr_get_useNormalMap_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600031B RID: 795 RVA: 0x000035D0 File Offset: 0x000017D0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightStats>.NativeClassPtr, ref this));
		}

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeFieldInfoPtr_totalLights;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeFieldInfoPtr_totalNormalMapUsage;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeFieldInfoPtr_totalVolumetricUsage;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeFieldInfoPtr_blendStylesUsed;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeFieldInfoPtr_blendStylesWithLights;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_get_useNormalMap_Public_get_Boolean_0;

		// Token: 0x04000265 RID: 613
		[FieldOffset(0)]
		public int totalLights;

		// Token: 0x04000266 RID: 614
		[FieldOffset(4)]
		public int totalNormalMapUsage;

		// Token: 0x04000267 RID: 615
		[FieldOffset(8)]
		public int totalVolumetricUsage;

		// Token: 0x04000268 RID: 616
		[FieldOffset(12)]
		public uint blendStylesUsed;

		// Token: 0x04000269 RID: 617
		[FieldOffset(16)]
		public uint blendStylesWithLights;
	}
}
