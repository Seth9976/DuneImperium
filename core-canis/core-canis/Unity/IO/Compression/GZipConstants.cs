using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.IO.Compression
{
	// Token: 0x02000072 RID: 114
	public static class GZipConstants : Object
	{
		// Token: 0x0600086E RID: 2158 RVA: 0x00034F54 File Offset: 0x00033154
		// Note: this type is marked as 'beforefieldinit'.
		static GZipConstants()
		{
			Il2CppClassPointerStore<GZipConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "Unity.IO.Compression", "GZipConstants");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GZipConstants>.NativeClassPtr);
			GZipConstants.NativeFieldInfoPtr_CompressionLevel_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GZipConstants>.NativeClassPtr, "CompressionLevel_3");
			GZipConstants.NativeFieldInfoPtr_CompressionLevel_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GZipConstants>.NativeClassPtr, "CompressionLevel_10");
			GZipConstants.NativeFieldInfoPtr_FileLengthModulo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GZipConstants>.NativeClassPtr, "FileLengthModulo");
			GZipConstants.NativeFieldInfoPtr_ID1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GZipConstants>.NativeClassPtr, "ID1");
			GZipConstants.NativeFieldInfoPtr_ID2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GZipConstants>.NativeClassPtr, "ID2");
			GZipConstants.NativeFieldInfoPtr_Deflate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GZipConstants>.NativeClassPtr, "Deflate");
			GZipConstants.NativeFieldInfoPtr_Xfl_HeaderPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GZipConstants>.NativeClassPtr, "Xfl_HeaderPos");
			GZipConstants.NativeFieldInfoPtr_Xfl_FastestAlgorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GZipConstants>.NativeClassPtr, "Xfl_FastestAlgorithm");
			GZipConstants.NativeFieldInfoPtr_Xfl_MaxCompressionSlowestAlgorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GZipConstants>.NativeClassPtr, "Xfl_MaxCompressionSlowestAlgorithm");
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00004CA1 File Offset: 0x00002EA1
		public GZipConstants(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x00035038 File Offset: 0x00033238
		// (set) Token: 0x06000871 RID: 2161 RVA: 0x00004CAA File Offset: 0x00002EAA
		public unsafe static int CompressionLevel_3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GZipConstants.NativeFieldInfoPtr_CompressionLevel_3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GZipConstants.NativeFieldInfoPtr_CompressionLevel_3, (void*)(&value));
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x00035054 File Offset: 0x00033254
		// (set) Token: 0x06000873 RID: 2163 RVA: 0x00004CB8 File Offset: 0x00002EB8
		public unsafe static int CompressionLevel_10
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GZipConstants.NativeFieldInfoPtr_CompressionLevel_10, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GZipConstants.NativeFieldInfoPtr_CompressionLevel_10, (void*)(&value));
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000874 RID: 2164 RVA: 0x00035070 File Offset: 0x00033270
		// (set) Token: 0x06000875 RID: 2165 RVA: 0x00004CC6 File Offset: 0x00002EC6
		public unsafe static long FileLengthModulo
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(GZipConstants.NativeFieldInfoPtr_FileLengthModulo, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GZipConstants.NativeFieldInfoPtr_FileLengthModulo, (void*)(&value));
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x0003508C File Offset: 0x0003328C
		// (set) Token: 0x06000877 RID: 2167 RVA: 0x00004CD4 File Offset: 0x00002ED4
		public unsafe static byte ID1
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(GZipConstants.NativeFieldInfoPtr_ID1, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GZipConstants.NativeFieldInfoPtr_ID1, (void*)(&value));
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x000350A8 File Offset: 0x000332A8
		// (set) Token: 0x06000879 RID: 2169 RVA: 0x00004CE2 File Offset: 0x00002EE2
		public unsafe static byte ID2
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(GZipConstants.NativeFieldInfoPtr_ID2, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GZipConstants.NativeFieldInfoPtr_ID2, (void*)(&value));
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x000350C4 File Offset: 0x000332C4
		// (set) Token: 0x0600087B RID: 2171 RVA: 0x00004CF0 File Offset: 0x00002EF0
		public unsafe static byte Deflate
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(GZipConstants.NativeFieldInfoPtr_Deflate, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GZipConstants.NativeFieldInfoPtr_Deflate, (void*)(&value));
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x000350E0 File Offset: 0x000332E0
		// (set) Token: 0x0600087D RID: 2173 RVA: 0x00004CFE File Offset: 0x00002EFE
		public unsafe static int Xfl_HeaderPos
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GZipConstants.NativeFieldInfoPtr_Xfl_HeaderPos, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GZipConstants.NativeFieldInfoPtr_Xfl_HeaderPos, (void*)(&value));
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x000350FC File Offset: 0x000332FC
		// (set) Token: 0x0600087F RID: 2175 RVA: 0x00004D0C File Offset: 0x00002F0C
		public unsafe static byte Xfl_FastestAlgorithm
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(GZipConstants.NativeFieldInfoPtr_Xfl_FastestAlgorithm, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GZipConstants.NativeFieldInfoPtr_Xfl_FastestAlgorithm, (void*)(&value));
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x00035118 File Offset: 0x00033318
		// (set) Token: 0x06000881 RID: 2177 RVA: 0x00004D1A File Offset: 0x00002F1A
		public unsafe static byte Xfl_MaxCompressionSlowestAlgorithm
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(GZipConstants.NativeFieldInfoPtr_Xfl_MaxCompressionSlowestAlgorithm, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GZipConstants.NativeFieldInfoPtr_Xfl_MaxCompressionSlowestAlgorithm, (void*)(&value));
			}
		}

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeFieldInfoPtr_CompressionLevel_3;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeFieldInfoPtr_CompressionLevel_10;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeFieldInfoPtr_FileLengthModulo;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeFieldInfoPtr_ID1;

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeFieldInfoPtr_ID2;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeFieldInfoPtr_Deflate;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeFieldInfoPtr_Xfl_HeaderPos;

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeFieldInfoPtr_Xfl_FastestAlgorithm;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeFieldInfoPtr_Xfl_MaxCompressionSlowestAlgorithm;
	}
}
