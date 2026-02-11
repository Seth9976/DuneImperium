using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000B4 RID: 180
	public static class Hammersley : Object
	{
		// Token: 0x06000CB9 RID: 3257 RVA: 0x0003AD24 File Offset: 0x00038F24
		// Note: this type is marked as 'beforefieldinit'.
		static Hammersley()
		{
			Il2CppClassPointerStore<Hammersley>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "Hammersley");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hammersley>.NativeClassPtr);
			Hammersley.NativeFieldInfoPtr_k_Hammersley2dSeq16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hammersley>.NativeClassPtr, "k_Hammersley2dSeq16");
			Hammersley.NativeFieldInfoPtr_k_Hammersley2dSeq32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hammersley>.NativeClassPtr, "k_Hammersley2dSeq32");
			Hammersley.NativeFieldInfoPtr_k_Hammersley2dSeq64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hammersley>.NativeClassPtr, "k_Hammersley2dSeq64");
			Hammersley.NativeFieldInfoPtr_k_Hammersley2dSeq256 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hammersley>.NativeClassPtr, "k_Hammersley2dSeq256");
			Hammersley.NativeFieldInfoPtr_s_hammersley2DSeq16Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hammersley>.NativeClassPtr, "s_hammersley2DSeq16Id");
			Hammersley.NativeFieldInfoPtr_s_hammersley2DSeq32Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hammersley>.NativeClassPtr, "s_hammersley2DSeq32Id");
			Hammersley.NativeFieldInfoPtr_s_hammersley2DSeq64Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hammersley>.NativeClassPtr, "s_hammersley2DSeq64Id");
			Hammersley.NativeFieldInfoPtr_s_hammersley2DSeq256Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hammersley>.NativeClassPtr, "s_hammersley2DSeq256Id");
			Hammersley.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hammersley>.NativeClassPtr, 100665127);
			Hammersley.NativeMethodInfoPtr_BindConstants_Public_Static_Void_CommandBuffer_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hammersley>.NativeClassPtr, 100665128);
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x0003AE1C File Offset: 0x0003901C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971677, XrefRangeEnd = 971719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hammersley.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x0003AE44 File Offset: 0x00039044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971719, XrefRangeEnd = 971741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BindConstants(CommandBuffer cmd, ComputeShader cs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hammersley.NativeMethodInfoPtr_BindConstants_Public_Static_Void_CommandBuffer_ComputeShader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00007A72 File Offset: 0x00005C72
		public Hammersley(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x0003AE8C File Offset: 0x0003908C
		// (set) Token: 0x06000CBE RID: 3262 RVA: 0x00007A7B File Offset: 0x00005C7B
		public unsafe static Il2CppStructArray<float> k_Hammersley2dSeq16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hammersley.NativeFieldInfoPtr_k_Hammersley2dSeq16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hammersley.NativeFieldInfoPtr_k_Hammersley2dSeq16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x0003AEB4 File Offset: 0x000390B4
		// (set) Token: 0x06000CC0 RID: 3264 RVA: 0x00007A8D File Offset: 0x00005C8D
		public unsafe static Il2CppStructArray<float> k_Hammersley2dSeq32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hammersley.NativeFieldInfoPtr_k_Hammersley2dSeq32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hammersley.NativeFieldInfoPtr_k_Hammersley2dSeq32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x0003AEDC File Offset: 0x000390DC
		// (set) Token: 0x06000CC2 RID: 3266 RVA: 0x00007A9F File Offset: 0x00005C9F
		public unsafe static Il2CppStructArray<float> k_Hammersley2dSeq64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hammersley.NativeFieldInfoPtr_k_Hammersley2dSeq64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hammersley.NativeFieldInfoPtr_k_Hammersley2dSeq64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x0003AF04 File Offset: 0x00039104
		// (set) Token: 0x06000CC4 RID: 3268 RVA: 0x00007AB1 File Offset: 0x00005CB1
		public unsafe static Il2CppStructArray<float> k_Hammersley2dSeq256
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hammersley.NativeFieldInfoPtr_k_Hammersley2dSeq256, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hammersley.NativeFieldInfoPtr_k_Hammersley2dSeq256, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x0003AF2C File Offset: 0x0003912C
		// (set) Token: 0x06000CC6 RID: 3270 RVA: 0x00007AC3 File Offset: 0x00005CC3
		public unsafe static int s_hammersley2DSeq16Id
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Hammersley.NativeFieldInfoPtr_s_hammersley2DSeq16Id, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hammersley.NativeFieldInfoPtr_s_hammersley2DSeq16Id, (void*)(&value));
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x0003AF48 File Offset: 0x00039148
		// (set) Token: 0x06000CC8 RID: 3272 RVA: 0x00007AD1 File Offset: 0x00005CD1
		public unsafe static int s_hammersley2DSeq32Id
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Hammersley.NativeFieldInfoPtr_s_hammersley2DSeq32Id, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hammersley.NativeFieldInfoPtr_s_hammersley2DSeq32Id, (void*)(&value));
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x0003AF64 File Offset: 0x00039164
		// (set) Token: 0x06000CCA RID: 3274 RVA: 0x00007ADF File Offset: 0x00005CDF
		public unsafe static int s_hammersley2DSeq64Id
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Hammersley.NativeFieldInfoPtr_s_hammersley2DSeq64Id, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hammersley.NativeFieldInfoPtr_s_hammersley2DSeq64Id, (void*)(&value));
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x0003AF80 File Offset: 0x00039180
		// (set) Token: 0x06000CCC RID: 3276 RVA: 0x00007AED File Offset: 0x00005CED
		public unsafe static int s_hammersley2DSeq256Id
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Hammersley.NativeFieldInfoPtr_s_hammersley2DSeq256Id, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hammersley.NativeFieldInfoPtr_s_hammersley2DSeq256Id, (void*)(&value));
			}
		}

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeFieldInfoPtr_k_Hammersley2dSeq16;

		// Token: 0x04000980 RID: 2432
		private static readonly IntPtr NativeFieldInfoPtr_k_Hammersley2dSeq32;

		// Token: 0x04000981 RID: 2433
		private static readonly IntPtr NativeFieldInfoPtr_k_Hammersley2dSeq64;

		// Token: 0x04000982 RID: 2434
		private static readonly IntPtr NativeFieldInfoPtr_k_Hammersley2dSeq256;

		// Token: 0x04000983 RID: 2435
		private static readonly IntPtr NativeFieldInfoPtr_s_hammersley2DSeq16Id;

		// Token: 0x04000984 RID: 2436
		private static readonly IntPtr NativeFieldInfoPtr_s_hammersley2DSeq32Id;

		// Token: 0x04000985 RID: 2437
		private static readonly IntPtr NativeFieldInfoPtr_s_hammersley2DSeq64Id;

		// Token: 0x04000986 RID: 2438
		private static readonly IntPtr NativeFieldInfoPtr_s_hammersley2DSeq256Id;

		// Token: 0x04000987 RID: 2439
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeMethodInfoPtr_BindConstants_Public_Static_Void_CommandBuffer_ComputeShader_0;

		// Token: 0x020001E4 RID: 484
		[StructLayout(2)]
		public struct Hammersley2dSeq16
		{
			// Token: 0x06001A25 RID: 6693 RVA: 0x0000D1D9 File Offset: 0x0000B3D9
			// Note: this type is marked as 'beforefieldinit'.
			static Hammersley2dSeq16()
			{
				Il2CppClassPointerStore<Hammersley.Hammersley2dSeq16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hammersley>.NativeClassPtr, "Hammersley2dSeq16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq16>.NativeClassPtr);
				Hammersley.Hammersley2dSeq16.NativeFieldInfoPtr_hammersley2dSeq16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq16>.NativeClassPtr, "hammersley2dSeq16");
			}

			// Token: 0x06001A26 RID: 6694 RVA: 0x0000D20D File Offset: 0x0000B40D
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq16>.NativeClassPtr, ref this));
			}

			// Token: 0x04001301 RID: 4865
			private static readonly IntPtr NativeFieldInfoPtr_hammersley2dSeq16;

			// Token: 0x04001302 RID: 4866
			[FieldOffset(0)]
			public Hammersley.Hammersley2dSeq16._hammersley2dSeq16_e__FixedBuffer hammersley2dSeq16;

			// Token: 0x02000238 RID: 568
			[ObfuscatedName("UnityEngine.Rendering.Hammersley+Hammersley2dSeq16+<hammersley2dSeq16>e__FixedBuffer")]
			[StructLayout(2)]
			public struct _hammersley2dSeq16_e__FixedBuffer
			{
				// Token: 0x06001C1C RID: 7196 RVA: 0x0000E1D1 File Offset: 0x0000C3D1
				// Note: this type is marked as 'beforefieldinit'.
				static _hammersley2dSeq16_e__FixedBuffer()
				{
					Il2CppClassPointerStore<Hammersley.Hammersley2dSeq16._hammersley2dSeq16_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq16>.NativeClassPtr, "<hammersley2dSeq16>e__FixedBuffer");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq16._hammersley2dSeq16_e__FixedBuffer>.NativeClassPtr);
					Hammersley.Hammersley2dSeq16._hammersley2dSeq16_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq16._hammersley2dSeq16_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
				}

				// Token: 0x06001C1D RID: 7197 RVA: 0x0000E205 File Offset: 0x0000C405
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq16._hammersley2dSeq16_e__FixedBuffer>.NativeClassPtr, ref this));
				}

				// Token: 0x0400144F RID: 5199
				private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

				// Token: 0x04001450 RID: 5200
				[FieldOffset(0)]
				public float FixedElementField;
			}
		}

		// Token: 0x020001E5 RID: 485
		[StructLayout(2)]
		public struct Hammersley2dSeq32
		{
			// Token: 0x06001A27 RID: 6695 RVA: 0x0000D21F File Offset: 0x0000B41F
			// Note: this type is marked as 'beforefieldinit'.
			static Hammersley2dSeq32()
			{
				Il2CppClassPointerStore<Hammersley.Hammersley2dSeq32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hammersley>.NativeClassPtr, "Hammersley2dSeq32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq32>.NativeClassPtr);
				Hammersley.Hammersley2dSeq32.NativeFieldInfoPtr_hammersley2dSeq32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq32>.NativeClassPtr, "hammersley2dSeq32");
			}

			// Token: 0x06001A28 RID: 6696 RVA: 0x0000D253 File Offset: 0x0000B453
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq32>.NativeClassPtr, ref this));
			}

			// Token: 0x04001303 RID: 4867
			private static readonly IntPtr NativeFieldInfoPtr_hammersley2dSeq32;

			// Token: 0x04001304 RID: 4868
			[FieldOffset(0)]
			public Hammersley.Hammersley2dSeq32._hammersley2dSeq32_e__FixedBuffer hammersley2dSeq32;

			// Token: 0x02000239 RID: 569
			[ObfuscatedName("UnityEngine.Rendering.Hammersley+Hammersley2dSeq32+<hammersley2dSeq32>e__FixedBuffer")]
			[StructLayout(2)]
			public struct _hammersley2dSeq32_e__FixedBuffer
			{
				// Token: 0x06001C1E RID: 7198 RVA: 0x0000E217 File Offset: 0x0000C417
				// Note: this type is marked as 'beforefieldinit'.
				static _hammersley2dSeq32_e__FixedBuffer()
				{
					Il2CppClassPointerStore<Hammersley.Hammersley2dSeq32._hammersley2dSeq32_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq32>.NativeClassPtr, "<hammersley2dSeq32>e__FixedBuffer");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq32._hammersley2dSeq32_e__FixedBuffer>.NativeClassPtr);
					Hammersley.Hammersley2dSeq32._hammersley2dSeq32_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq32._hammersley2dSeq32_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
				}

				// Token: 0x06001C1F RID: 7199 RVA: 0x0000E24B File Offset: 0x0000C44B
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq32._hammersley2dSeq32_e__FixedBuffer>.NativeClassPtr, ref this));
				}

				// Token: 0x04001451 RID: 5201
				private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

				// Token: 0x04001452 RID: 5202
				[FieldOffset(0)]
				public float FixedElementField;
			}
		}

		// Token: 0x020001E6 RID: 486
		[StructLayout(2)]
		public struct Hammersley2dSeq64
		{
			// Token: 0x06001A29 RID: 6697 RVA: 0x0000D265 File Offset: 0x0000B465
			// Note: this type is marked as 'beforefieldinit'.
			static Hammersley2dSeq64()
			{
				Il2CppClassPointerStore<Hammersley.Hammersley2dSeq64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hammersley>.NativeClassPtr, "Hammersley2dSeq64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq64>.NativeClassPtr);
				Hammersley.Hammersley2dSeq64.NativeFieldInfoPtr_hammersley2dSeq64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq64>.NativeClassPtr, "hammersley2dSeq64");
			}

			// Token: 0x06001A2A RID: 6698 RVA: 0x0000D299 File Offset: 0x0000B499
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq64>.NativeClassPtr, ref this));
			}

			// Token: 0x04001305 RID: 4869
			private static readonly IntPtr NativeFieldInfoPtr_hammersley2dSeq64;

			// Token: 0x04001306 RID: 4870
			[FieldOffset(0)]
			public Hammersley.Hammersley2dSeq64._hammersley2dSeq64_e__FixedBuffer hammersley2dSeq64;

			// Token: 0x0200023A RID: 570
			[ObfuscatedName("UnityEngine.Rendering.Hammersley+Hammersley2dSeq64+<hammersley2dSeq64>e__FixedBuffer")]
			[StructLayout(2)]
			public struct _hammersley2dSeq64_e__FixedBuffer
			{
				// Token: 0x06001C20 RID: 7200 RVA: 0x0000E25D File Offset: 0x0000C45D
				// Note: this type is marked as 'beforefieldinit'.
				static _hammersley2dSeq64_e__FixedBuffer()
				{
					Il2CppClassPointerStore<Hammersley.Hammersley2dSeq64._hammersley2dSeq64_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq64>.NativeClassPtr, "<hammersley2dSeq64>e__FixedBuffer");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq64._hammersley2dSeq64_e__FixedBuffer>.NativeClassPtr);
					Hammersley.Hammersley2dSeq64._hammersley2dSeq64_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq64._hammersley2dSeq64_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
				}

				// Token: 0x06001C21 RID: 7201 RVA: 0x0000E291 File Offset: 0x0000C491
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq64._hammersley2dSeq64_e__FixedBuffer>.NativeClassPtr, ref this));
				}

				// Token: 0x04001453 RID: 5203
				private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

				// Token: 0x04001454 RID: 5204
				[FieldOffset(0)]
				public float FixedElementField;
			}
		}

		// Token: 0x020001E7 RID: 487
		[StructLayout(2)]
		public struct Hammersley2dSeq256
		{
			// Token: 0x06001A2B RID: 6699 RVA: 0x0000D2AB File Offset: 0x0000B4AB
			// Note: this type is marked as 'beforefieldinit'.
			static Hammersley2dSeq256()
			{
				Il2CppClassPointerStore<Hammersley.Hammersley2dSeq256>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hammersley>.NativeClassPtr, "Hammersley2dSeq256");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq256>.NativeClassPtr);
				Hammersley.Hammersley2dSeq256.NativeFieldInfoPtr_hammersley2dSeq256 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq256>.NativeClassPtr, "hammersley2dSeq256");
			}

			// Token: 0x06001A2C RID: 6700 RVA: 0x0000D2DF File Offset: 0x0000B4DF
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq256>.NativeClassPtr, ref this));
			}

			// Token: 0x04001307 RID: 4871
			private static readonly IntPtr NativeFieldInfoPtr_hammersley2dSeq256;

			// Token: 0x04001308 RID: 4872
			[FieldOffset(0)]
			public Hammersley.Hammersley2dSeq256._hammersley2dSeq256_e__FixedBuffer hammersley2dSeq256;

			// Token: 0x0200023B RID: 571
			[ObfuscatedName("UnityEngine.Rendering.Hammersley+Hammersley2dSeq256+<hammersley2dSeq256>e__FixedBuffer")]
			[StructLayout(2)]
			public struct _hammersley2dSeq256_e__FixedBuffer
			{
				// Token: 0x06001C22 RID: 7202 RVA: 0x0000E2A3 File Offset: 0x0000C4A3
				// Note: this type is marked as 'beforefieldinit'.
				static _hammersley2dSeq256_e__FixedBuffer()
				{
					Il2CppClassPointerStore<Hammersley.Hammersley2dSeq256._hammersley2dSeq256_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq256>.NativeClassPtr, "<hammersley2dSeq256>e__FixedBuffer");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq256._hammersley2dSeq256_e__FixedBuffer>.NativeClassPtr);
					Hammersley.Hammersley2dSeq256._hammersley2dSeq256_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq256._hammersley2dSeq256_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
				}

				// Token: 0x06001C23 RID: 7203 RVA: 0x0000E2D7 File Offset: 0x0000C4D7
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Hammersley.Hammersley2dSeq256._hammersley2dSeq256_e__FixedBuffer>.NativeClassPtr, ref this));
				}

				// Token: 0x04001455 RID: 5205
				private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

				// Token: 0x04001456 RID: 5206
				[FieldOffset(0)]
				public float FixedElementField;
			}
		}
	}
}
