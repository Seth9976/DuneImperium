using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TerrainUtils
{
	// Token: 0x02000006 RID: 6
	[StructLayout(2)]
	public struct TerrainTileCoord
	{
		// Token: 0x0600010E RID: 270 RVA: 0x00005678 File Offset: 0x00003878
		// Note: this type is marked as 'beforefieldinit'.
		static TerrainTileCoord()
		{
			Il2CppClassPointerStore<TerrainTileCoord>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TerrainModule.dll", "UnityEngine.TerrainUtils", "TerrainTileCoord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainTileCoord>.NativeClassPtr);
			TerrainTileCoord.NativeFieldInfoPtr_tileX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainTileCoord>.NativeClassPtr, "tileX");
			TerrainTileCoord.NativeFieldInfoPtr_tileZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainTileCoord>.NativeClassPtr, "tileZ");
			TerrainTileCoord.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainTileCoord>.NativeClassPtr, 100663317);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000056E4 File Offset: 0x000038E4
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 283577, RefRangeEnd = 283616, XrefRangeStart = 283577, XrefRangeEnd = 283616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TerrainTileCoord(int tileX, int tileZ)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tileX;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tileZ;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainTileCoord.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002CD6 File Offset: 0x00000ED6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TerrainTileCoord>.NativeClassPtr, ref this));
		}

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeFieldInfoPtr_tileX;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeFieldInfoPtr_tileZ;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x040000C6 RID: 198
		[FieldOffset(0)]
		public readonly int tileX;

		// Token: 0x040000C7 RID: 199
		[FieldOffset(4)]
		public readonly int tileZ;
	}
}
