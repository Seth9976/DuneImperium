using System;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine.Device
{
	// Token: 0x02000361 RID: 865
	public static class SystemInfo
	{
		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06002EC9 RID: 11977 RVA: 0x00012AEE File Offset: 0x00010CEE
		public static float batteryLevel
		{
			get
			{
				return SystemInfo.batteryLevel;
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06002ECA RID: 11978 RVA: 0x00012AF5 File Offset: 0x00010CF5
		public static BatteryStatus batteryStatus
		{
			get
			{
				return SystemInfo.batteryStatus;
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06002ECB RID: 11979 RVA: 0x00012AFC File Offset: 0x00010CFC
		public static string operatingSystem
		{
			get
			{
				return SystemInfo.operatingSystem;
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06002ECC RID: 11980 RVA: 0x00012B03 File Offset: 0x00010D03
		public static OperatingSystemFamily operatingSystemFamily
		{
			get
			{
				return SystemInfo.operatingSystemFamily;
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06002ECD RID: 11981 RVA: 0x00012B0A File Offset: 0x00010D0A
		public static string processorType
		{
			get
			{
				return SystemInfo.processorType;
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06002ECE RID: 11982 RVA: 0x00012B11 File Offset: 0x00010D11
		public static int processorFrequency
		{
			get
			{
				return SystemInfo.processorFrequency;
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06002ECF RID: 11983 RVA: 0x00012B18 File Offset: 0x00010D18
		public static int processorCount
		{
			get
			{
				return SystemInfo.processorCount;
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06002ED0 RID: 11984 RVA: 0x00012B1F File Offset: 0x00010D1F
		public static int systemMemorySize
		{
			get
			{
				return SystemInfo.systemMemorySize;
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06002ED1 RID: 11985 RVA: 0x00012B26 File Offset: 0x00010D26
		public static string deviceUniqueIdentifier
		{
			get
			{
				return SystemInfo.deviceUniqueIdentifier;
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06002ED2 RID: 11986 RVA: 0x00012B2D File Offset: 0x00010D2D
		public static string deviceName
		{
			get
			{
				return SystemInfo.deviceName;
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06002ED3 RID: 11987 RVA: 0x00012B34 File Offset: 0x00010D34
		public static string deviceModel
		{
			get
			{
				return SystemInfo.deviceModel;
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06002ED4 RID: 11988 RVA: 0x00012B3B File Offset: 0x00010D3B
		public static bool supportsAccelerometer
		{
			get
			{
				return SystemInfo.supportsAccelerometer;
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06002ED5 RID: 11989 RVA: 0x00012B42 File Offset: 0x00010D42
		public static bool supportsGyroscope
		{
			get
			{
				return SystemInfo.supportsGyroscope;
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06002ED6 RID: 11990 RVA: 0x00012B49 File Offset: 0x00010D49
		public static bool supportsLocationService
		{
			get
			{
				return SystemInfo.supportsLocationService;
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06002ED7 RID: 11991 RVA: 0x00012B50 File Offset: 0x00010D50
		public static bool supportsVibration
		{
			get
			{
				return SystemInfo.supportsVibration;
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06002ED8 RID: 11992 RVA: 0x00012B57 File Offset: 0x00010D57
		public static bool supportsAudio
		{
			get
			{
				return SystemInfo.supportsAudio;
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06002ED9 RID: 11993 RVA: 0x00012B5E File Offset: 0x00010D5E
		public static DeviceType deviceType
		{
			get
			{
				return SystemInfo.deviceType;
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06002EDA RID: 11994 RVA: 0x00012B65 File Offset: 0x00010D65
		public static int graphicsMemorySize
		{
			get
			{
				return SystemInfo.graphicsMemorySize;
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06002EDB RID: 11995 RVA: 0x00012B6C File Offset: 0x00010D6C
		public static string graphicsDeviceName
		{
			get
			{
				return SystemInfo.graphicsDeviceName;
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06002EDC RID: 11996 RVA: 0x00012B73 File Offset: 0x00010D73
		public static string graphicsDeviceVendor
		{
			get
			{
				return SystemInfo.graphicsDeviceVendor;
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06002EDD RID: 11997 RVA: 0x00012B7A File Offset: 0x00010D7A
		public static int graphicsDeviceID
		{
			get
			{
				return SystemInfo.graphicsDeviceID;
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06002EDE RID: 11998 RVA: 0x00012B81 File Offset: 0x00010D81
		public static int graphicsDeviceVendorID
		{
			get
			{
				return SystemInfo.graphicsDeviceVendorID;
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06002EDF RID: 11999 RVA: 0x00012B88 File Offset: 0x00010D88
		public static UnityEngine.Rendering.GraphicsDeviceType graphicsDeviceType
		{
			get
			{
				return SystemInfo.graphicsDeviceType;
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06002EE0 RID: 12000 RVA: 0x00012B8F File Offset: 0x00010D8F
		public static bool graphicsUVStartsAtTop
		{
			get
			{
				return SystemInfo.graphicsUVStartsAtTop;
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06002EE1 RID: 12001 RVA: 0x00012B96 File Offset: 0x00010D96
		public static string graphicsDeviceVersion
		{
			get
			{
				return SystemInfo.graphicsDeviceVersion;
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06002EE2 RID: 12002 RVA: 0x00012B9D File Offset: 0x00010D9D
		public static int graphicsShaderLevel
		{
			get
			{
				return SystemInfo.graphicsShaderLevel;
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06002EE3 RID: 12003 RVA: 0x00012BA4 File Offset: 0x00010DA4
		public static bool graphicsMultiThreaded
		{
			get
			{
				return SystemInfo.graphicsMultiThreaded;
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06002EE4 RID: 12004 RVA: 0x00012BAB File Offset: 0x00010DAB
		public static UnityEngine.Rendering.RenderingThreadingMode renderingThreadingMode
		{
			get
			{
				return SystemInfo.renderingThreadingMode;
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06002EE5 RID: 12005 RVA: 0x00012BB2 File Offset: 0x00010DB2
		public static UnityEngine.Rendering.FoveatedRenderingCaps foveatedRenderingCaps
		{
			get
			{
				return SystemInfo.foveatedRenderingCaps;
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06002EE6 RID: 12006 RVA: 0x00012BB9 File Offset: 0x00010DB9
		public static bool hasHiddenSurfaceRemovalOnGPU
		{
			get
			{
				return SystemInfo.hasHiddenSurfaceRemovalOnGPU;
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06002EE7 RID: 12007 RVA: 0x00012BC0 File Offset: 0x00010DC0
		public static bool hasDynamicUniformArrayIndexingInFragmentShaders
		{
			get
			{
				return SystemInfo.hasDynamicUniformArrayIndexingInFragmentShaders;
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06002EE8 RID: 12008 RVA: 0x00012BC7 File Offset: 0x00010DC7
		public static bool supportsShadows
		{
			get
			{
				return SystemInfo.supportsShadows;
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06002EE9 RID: 12009 RVA: 0x00012BCE File Offset: 0x00010DCE
		public static bool supportsRawShadowDepthSampling
		{
			get
			{
				return SystemInfo.supportsRawShadowDepthSampling;
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06002EEA RID: 12010 RVA: 0x00012BD5 File Offset: 0x00010DD5
		public static bool supportsMotionVectors
		{
			get
			{
				return SystemInfo.supportsMotionVectors;
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06002EEB RID: 12011 RVA: 0x00012BDC File Offset: 0x00010DDC
		public static bool supports3DTextures
		{
			get
			{
				return SystemInfo.supports3DTextures;
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06002EEC RID: 12012 RVA: 0x00012BE3 File Offset: 0x00010DE3
		public static bool supportsCompressed3DTextures
		{
			get
			{
				return SystemInfo.supportsCompressed3DTextures;
			}
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06002EED RID: 12013 RVA: 0x00012BEA File Offset: 0x00010DEA
		public static bool supports2DArrayTextures
		{
			get
			{
				return SystemInfo.supports2DArrayTextures;
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06002EEE RID: 12014 RVA: 0x00012BF1 File Offset: 0x00010DF1
		public static bool supports3DRenderTextures
		{
			get
			{
				return SystemInfo.supports3DRenderTextures;
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06002EEF RID: 12015 RVA: 0x00012BF8 File Offset: 0x00010DF8
		public static bool supportsCubemapArrayTextures
		{
			get
			{
				return SystemInfo.supportsCubemapArrayTextures;
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06002EF0 RID: 12016 RVA: 0x00012BFF File Offset: 0x00010DFF
		public static bool supportsAnisotropicFilter
		{
			get
			{
				return SystemInfo.supportsAnisotropicFilter;
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06002EF1 RID: 12017 RVA: 0x00012C06 File Offset: 0x00010E06
		public static UnityEngine.Rendering.CopyTextureSupport copyTextureSupport
		{
			get
			{
				return SystemInfo.copyTextureSupport;
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06002EF2 RID: 12018 RVA: 0x00012C0D File Offset: 0x00010E0D
		public static bool supportsComputeShaders
		{
			get
			{
				return SystemInfo.supportsComputeShaders;
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06002EF3 RID: 12019 RVA: 0x00012C14 File Offset: 0x00010E14
		public static bool supportsGeometryShaders
		{
			get
			{
				return SystemInfo.supportsGeometryShaders;
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06002EF4 RID: 12020 RVA: 0x00012C1B File Offset: 0x00010E1B
		public static bool supportsTessellationShaders
		{
			get
			{
				return SystemInfo.supportsTessellationShaders;
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06002EF5 RID: 12021 RVA: 0x00012C22 File Offset: 0x00010E22
		public static bool supportsRenderTargetArrayIndexFromVertexShader
		{
			get
			{
				return SystemInfo.supportsRenderTargetArrayIndexFromVertexShader;
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06002EF6 RID: 12022 RVA: 0x00012C29 File Offset: 0x00010E29
		public static bool supportsInstancing
		{
			get
			{
				return SystemInfo.supportsInstancing;
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06002EF7 RID: 12023 RVA: 0x00012C30 File Offset: 0x00010E30
		public static bool supportsHardwareQuadTopology
		{
			get
			{
				return SystemInfo.supportsHardwareQuadTopology;
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06002EF8 RID: 12024 RVA: 0x00012C37 File Offset: 0x00010E37
		public static bool supports32bitsIndexBuffer
		{
			get
			{
				return SystemInfo.supports32bitsIndexBuffer;
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06002EF9 RID: 12025 RVA: 0x00012C3E File Offset: 0x00010E3E
		public static bool supportsSparseTextures
		{
			get
			{
				return SystemInfo.supportsSparseTextures;
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06002EFA RID: 12026 RVA: 0x00012C45 File Offset: 0x00010E45
		public static int supportedRenderTargetCount
		{
			get
			{
				return SystemInfo.supportedRenderTargetCount;
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06002EFB RID: 12027 RVA: 0x00012C4C File Offset: 0x00010E4C
		public static bool supportsSeparatedRenderTargetsBlend
		{
			get
			{
				return SystemInfo.supportsSeparatedRenderTargetsBlend;
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06002EFC RID: 12028 RVA: 0x00012C53 File Offset: 0x00010E53
		public static int supportedRandomWriteTargetCount
		{
			get
			{
				return SystemInfo.supportedRandomWriteTargetCount;
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06002EFD RID: 12029 RVA: 0x00012C5A File Offset: 0x00010E5A
		public static int supportsMultisampledTextures
		{
			get
			{
				return SystemInfo.supportsMultisampledTextures;
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06002EFE RID: 12030 RVA: 0x00012C61 File Offset: 0x00010E61
		public static bool supportsMultisampled2DArrayTextures
		{
			get
			{
				return SystemInfo.supportsMultisampled2DArrayTextures;
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06002EFF RID: 12031 RVA: 0x00012C68 File Offset: 0x00010E68
		public static bool supportsMultisampleAutoResolve
		{
			get
			{
				return SystemInfo.supportsMultisampleAutoResolve;
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06002F00 RID: 12032 RVA: 0x00012C6F File Offset: 0x00010E6F
		public static int supportsTextureWrapMirrorOnce
		{
			get
			{
				return SystemInfo.supportsTextureWrapMirrorOnce;
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06002F01 RID: 12033 RVA: 0x00012C76 File Offset: 0x00010E76
		public static bool usesReversedZBuffer
		{
			get
			{
				return SystemInfo.usesReversedZBuffer;
			}
		}

		// Token: 0x06002F02 RID: 12034 RVA: 0x000B59B8 File Offset: 0x000B3BB8
		public static bool SupportsRenderTextureFormat(RenderTextureFormat format)
		{
			return SystemInfo.SupportsRenderTextureFormat(format);
		}

		// Token: 0x06002F03 RID: 12035 RVA: 0x000B59D0 File Offset: 0x000B3BD0
		public static bool SupportsBlendingOnRenderTextureFormat(RenderTextureFormat format)
		{
			return SystemInfo.SupportsBlendingOnRenderTextureFormat(format);
		}

		// Token: 0x06002F04 RID: 12036 RVA: 0x000B59E8 File Offset: 0x000B3BE8
		public static bool SupportsTextureFormat(TextureFormat format)
		{
			return SystemInfo.SupportsTextureFormat(format);
		}

		// Token: 0x06002F05 RID: 12037 RVA: 0x000B5A00 File Offset: 0x000B3C00
		public static bool SupportsVertexAttributeFormat(UnityEngine.Rendering.VertexAttributeFormat format, int dimension)
		{
			return SystemInfo.SupportsVertexAttributeFormat(format, dimension);
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06002F06 RID: 12038 RVA: 0x00012C7D File Offset: 0x00010E7D
		public static NPOTSupport npotSupport
		{
			get
			{
				return SystemInfo.npotSupport;
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06002F07 RID: 12039 RVA: 0x00012C84 File Offset: 0x00010E84
		public static int maxTextureSize
		{
			get
			{
				return SystemInfo.maxTextureSize;
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06002F08 RID: 12040 RVA: 0x00012C8B File Offset: 0x00010E8B
		public static int maxTexture3DSize
		{
			get
			{
				return SystemInfo.maxTexture3DSize;
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06002F09 RID: 12041 RVA: 0x00012C92 File Offset: 0x00010E92
		public static int maxTextureArraySlices
		{
			get
			{
				return SystemInfo.maxTextureArraySlices;
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06002F0A RID: 12042 RVA: 0x00012C99 File Offset: 0x00010E99
		public static int maxCubemapSize
		{
			get
			{
				return SystemInfo.maxCubemapSize;
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06002F0B RID: 12043 RVA: 0x00012CA0 File Offset: 0x00010EA0
		public static int maxAnisotropyLevel
		{
			get
			{
				return SystemInfo.maxAnisotropyLevel;
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06002F0C RID: 12044 RVA: 0x00012CA7 File Offset: 0x00010EA7
		public static int maxComputeBufferInputsVertex
		{
			get
			{
				return SystemInfo.maxComputeBufferInputsVertex;
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06002F0D RID: 12045 RVA: 0x00012CAE File Offset: 0x00010EAE
		public static int maxComputeBufferInputsFragment
		{
			get
			{
				return SystemInfo.maxComputeBufferInputsFragment;
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06002F0E RID: 12046 RVA: 0x00012CB5 File Offset: 0x00010EB5
		public static int maxComputeBufferInputsGeometry
		{
			get
			{
				return SystemInfo.maxComputeBufferInputsGeometry;
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06002F0F RID: 12047 RVA: 0x00012CBC File Offset: 0x00010EBC
		public static int maxComputeBufferInputsDomain
		{
			get
			{
				return SystemInfo.maxComputeBufferInputsDomain;
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06002F10 RID: 12048 RVA: 0x00012CC3 File Offset: 0x00010EC3
		public static int maxComputeBufferInputsHull
		{
			get
			{
				return SystemInfo.maxComputeBufferInputsHull;
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06002F11 RID: 12049 RVA: 0x00012CCA File Offset: 0x00010ECA
		public static int maxComputeBufferInputsCompute
		{
			get
			{
				return SystemInfo.maxComputeBufferInputsCompute;
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06002F12 RID: 12050 RVA: 0x00012CD1 File Offset: 0x00010ED1
		public static int maxComputeWorkGroupSize
		{
			get
			{
				return SystemInfo.maxComputeWorkGroupSize;
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06002F13 RID: 12051 RVA: 0x00012CD8 File Offset: 0x00010ED8
		public static int maxComputeWorkGroupSizeX
		{
			get
			{
				return SystemInfo.maxComputeWorkGroupSizeX;
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06002F14 RID: 12052 RVA: 0x00012CDF File Offset: 0x00010EDF
		public static int maxComputeWorkGroupSizeY
		{
			get
			{
				return SystemInfo.maxComputeWorkGroupSizeY;
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06002F15 RID: 12053 RVA: 0x00012CE6 File Offset: 0x00010EE6
		public static int maxComputeWorkGroupSizeZ
		{
			get
			{
				return SystemInfo.maxComputeWorkGroupSizeZ;
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06002F16 RID: 12054 RVA: 0x00012CED File Offset: 0x00010EED
		public static int computeSubGroupSize
		{
			get
			{
				return SystemInfo.computeSubGroupSize;
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06002F17 RID: 12055 RVA: 0x00012CF4 File Offset: 0x00010EF4
		public static bool supportsAsyncCompute
		{
			get
			{
				return SystemInfo.supportsAsyncCompute;
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06002F18 RID: 12056 RVA: 0x00012CFB File Offset: 0x00010EFB
		public static bool supportsGpuRecorder
		{
			get
			{
				return SystemInfo.supportsGpuRecorder;
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06002F19 RID: 12057 RVA: 0x00012D02 File Offset: 0x00010F02
		public static bool supportsGraphicsFence
		{
			get
			{
				return SystemInfo.supportsGraphicsFence;
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06002F1A RID: 12058 RVA: 0x00012D09 File Offset: 0x00010F09
		public static bool supportsAsyncGPUReadback
		{
			get
			{
				return SystemInfo.supportsAsyncGPUReadback;
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06002F1B RID: 12059 RVA: 0x00012D10 File Offset: 0x00010F10
		public static bool supportsRayTracing
		{
			get
			{
				return SystemInfo.supportsRayTracing;
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06002F1C RID: 12060 RVA: 0x00012D17 File Offset: 0x00010F17
		public static bool supportsSetConstantBuffer
		{
			get
			{
				return SystemInfo.supportsSetConstantBuffer;
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06002F1D RID: 12061 RVA: 0x00012D1E File Offset: 0x00010F1E
		public static int constantBufferOffsetAlignment
		{
			get
			{
				return SystemInfo.constantBufferOffsetAlignment;
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06002F1E RID: 12062 RVA: 0x00012D25 File Offset: 0x00010F25
		public static int maxConstantBufferSize
		{
			get
			{
				return SystemInfo.maxConstantBufferSize;
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06002F1F RID: 12063 RVA: 0x00012D2C File Offset: 0x00010F2C
		public static long maxGraphicsBufferSize
		{
			get
			{
				return SystemInfo.maxGraphicsBufferSize;
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06002F20 RID: 12064 RVA: 0x00012D33 File Offset: 0x00010F33
		public static bool hasMipMaxLevel
		{
			get
			{
				return SystemInfo.hasMipMaxLevel;
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06002F21 RID: 12065 RVA: 0x00012D3A File Offset: 0x00010F3A
		public static bool supportsMipStreaming
		{
			get
			{
				return SystemInfo.supportsMipStreaming;
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06002F22 RID: 12066 RVA: 0x00012D41 File Offset: 0x00010F41
		public static bool usesLoadStoreActions
		{
			get
			{
				return SystemInfo.usesLoadStoreActions;
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06002F23 RID: 12067 RVA: 0x00012D48 File Offset: 0x00010F48
		public static HDRDisplaySupportFlags hdrDisplaySupportFlags
		{
			get
			{
				return SystemInfo.hdrDisplaySupportFlags;
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06002F24 RID: 12068 RVA: 0x00012D4F File Offset: 0x00010F4F
		public static bool supportsConservativeRaster
		{
			get
			{
				return SystemInfo.supportsConservativeRaster;
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06002F25 RID: 12069 RVA: 0x00012D56 File Offset: 0x00010F56
		public static bool supportsMultiview
		{
			get
			{
				return SystemInfo.supportsMultiview;
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06002F26 RID: 12070 RVA: 0x00012D5D File Offset: 0x00010F5D
		public static bool supportsStoreAndResolveAction
		{
			get
			{
				return SystemInfo.supportsStoreAndResolveAction;
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06002F27 RID: 12071 RVA: 0x00012D64 File Offset: 0x00010F64
		public static bool supportsMultisampleResolveDepth
		{
			get
			{
				return SystemInfo.supportsMultisampleResolveDepth;
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06002F28 RID: 12072 RVA: 0x00012D6B File Offset: 0x00010F6B
		public static bool supportsMultisampleResolveStencil
		{
			get
			{
				return SystemInfo.supportsMultisampleResolveStencil;
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06002F29 RID: 12073 RVA: 0x00012D72 File Offset: 0x00010F72
		public static bool supportsIndirectArgumentsBuffer
		{
			get
			{
				return SystemInfo.supportsIndirectArgumentsBuffer;
			}
		}

		// Token: 0x06002F2A RID: 12074 RVA: 0x000B5A1C File Offset: 0x000B3C1C
		public static bool IsFormatSupported(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage)
		{
			return SystemInfo.IsFormatSupported(format, usage);
		}

		// Token: 0x06002F2B RID: 12075 RVA: 0x000B5A38 File Offset: 0x000B3C38
		public static UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage)
		{
			return SystemInfo.GetCompatibleFormat(format, usage);
		}

		// Token: 0x06002F2C RID: 12076 RVA: 0x000B5A54 File Offset: 0x000B3C54
		public static UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.Experimental.Rendering.DefaultFormat format)
		{
			return SystemInfo.GetGraphicsFormat(format);
		}

		// Token: 0x06002F2D RID: 12077 RVA: 0x000B5A6C File Offset: 0x000B3C6C
		public static int GetRenderTextureSupportedMSAASampleCount(RenderTextureDescriptor desc)
		{
			return SystemInfo.GetRenderTextureSupportedMSAASampleCount(desc);
		}

		// Token: 0x06002F2E RID: 12078 RVA: 0x000B5A84 File Offset: 0x000B3C84
		public static bool SupportsRandomWriteOnRenderTextureFormat(RenderTextureFormat format)
		{
			return SystemInfo.SupportsRandomWriteOnRenderTextureFormat(format);
		}

		// Token: 0x04002A5C RID: 10844
		public const string unsupportedIdentifier = "n/a";
	}
}
