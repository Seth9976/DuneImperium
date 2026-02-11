using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000D6 RID: 214
	public static class FSRUtils : Object
	{
		// Token: 0x06000FD6 RID: 4054 RVA: 0x000499C4 File Offset: 0x00047BC4
		// Note: this type is marked as 'beforefieldinit'.
		static FSRUtils()
		{
			Il2CppClassPointerStore<FSRUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "FSRUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FSRUtils>.NativeClassPtr);
			FSRUtils.NativeFieldInfoPtr_kMaxSharpnessStops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSRUtils>.NativeClassPtr, "kMaxSharpnessStops");
			FSRUtils.NativeFieldInfoPtr_kDefaultSharpnessStops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSRUtils>.NativeClassPtr, "kDefaultSharpnessStops");
			FSRUtils.NativeFieldInfoPtr_kDefaultSharpnessLinear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSRUtils>.NativeClassPtr, "kDefaultSharpnessLinear");
			FSRUtils.NativeMethodInfoPtr_SetEasuConstants_Public_Static_Void_CommandBuffer_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSRUtils>.NativeClassPtr, 100665642);
			FSRUtils.NativeMethodInfoPtr_SetRcasConstants_Public_Static_Void_CommandBuffer_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSRUtils>.NativeClassPtr, 100665643);
			FSRUtils.NativeMethodInfoPtr_SetRcasConstantsLinear_Public_Static_Void_CommandBuffer_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSRUtils>.NativeClassPtr, 100665644);
			FSRUtils.NativeMethodInfoPtr_IsSupported_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSRUtils>.NativeClassPtr, 100665645);
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x00049A80 File Offset: 0x00047C80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 977236, RefRangeEnd = 977237, XrefRangeStart = 977225, XrefRangeEnd = 977236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetEasuConstants(CommandBuffer cmd, Vector2 inputViewportSizeInPixels, Vector2 inputImageSizeInPixels, Vector2 outputImageSizeInPixels)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputViewportSizeInPixels;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputImageSizeInPixels;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outputImageSizeInPixels;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSRUtils.NativeMethodInfoPtr_SetEasuConstants_Public_Static_Void_CommandBuffer_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x00049AE0 File Offset: 0x00047CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977237, XrefRangeEnd = 977244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRcasConstants(CommandBuffer cmd, float sharpnessStops = 0.2f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sharpnessStops;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSRUtils.NativeMethodInfoPtr_SetRcasConstants_Public_Static_Void_CommandBuffer_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x00049B24 File Offset: 0x00047D24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 977251, RefRangeEnd = 977253, XrefRangeStart = 977244, XrefRangeEnd = 977251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRcasConstantsLinear(CommandBuffer cmd, float sharpnessLinear = 0.92f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sharpnessLinear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSRUtils.NativeMethodInfoPtr_SetRcasConstantsLinear_Public_Static_Void_CommandBuffer_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00049B68 File Offset: 0x00047D68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 977254, RefRangeEnd = 977256, XrefRangeStart = 977253, XrefRangeEnd = 977254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSupported()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSRUtils.NativeMethodInfoPtr_IsSupported_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x0000871A File Offset: 0x0000691A
		public FSRUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x00049B98 File Offset: 0x00047D98
		// (set) Token: 0x06000FDD RID: 4061 RVA: 0x00008723 File Offset: 0x00006923
		public unsafe static float kMaxSharpnessStops
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(FSRUtils.NativeFieldInfoPtr_kMaxSharpnessStops, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FSRUtils.NativeFieldInfoPtr_kMaxSharpnessStops, (void*)(&value));
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x00049BB4 File Offset: 0x00047DB4
		// (set) Token: 0x06000FDF RID: 4063 RVA: 0x00008731 File Offset: 0x00006931
		public unsafe static float kDefaultSharpnessStops
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(FSRUtils.NativeFieldInfoPtr_kDefaultSharpnessStops, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FSRUtils.NativeFieldInfoPtr_kDefaultSharpnessStops, (void*)(&value));
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x00049BD0 File Offset: 0x00047DD0
		// (set) Token: 0x06000FE1 RID: 4065 RVA: 0x0000873F File Offset: 0x0000693F
		public unsafe static float kDefaultSharpnessLinear
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(FSRUtils.NativeFieldInfoPtr_kDefaultSharpnessLinear, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FSRUtils.NativeFieldInfoPtr_kDefaultSharpnessLinear, (void*)(&value));
			}
		}

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeFieldInfoPtr_kMaxSharpnessStops;

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeFieldInfoPtr_kDefaultSharpnessStops;

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeFieldInfoPtr_kDefaultSharpnessLinear;

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeMethodInfoPtr_SetEasuConstants_Public_Static_Void_CommandBuffer_Vector2_Vector2_Vector2_0;

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeMethodInfoPtr_SetRcasConstants_Public_Static_Void_CommandBuffer_Single_0;

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeMethodInfoPtr_SetRcasConstantsLinear_Public_Static_Void_CommandBuffer_Single_0;

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeMethodInfoPtr_IsSupported_Public_Static_Boolean_0;

		// Token: 0x020001FB RID: 507
		public static class ShaderConstants : Object
		{
			// Token: 0x06001AAB RID: 6827 RVA: 0x0006DBB4 File Offset: 0x0006BDB4
			// Note: this type is marked as 'beforefieldinit'.
			static ShaderConstants()
			{
				Il2CppClassPointerStore<FSRUtils.ShaderConstants>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FSRUtils>.NativeClassPtr, "ShaderConstants");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FSRUtils.ShaderConstants>.NativeClassPtr);
				FSRUtils.ShaderConstants.NativeFieldInfoPtr__FsrEasuConstants0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSRUtils.ShaderConstants>.NativeClassPtr, "_FsrEasuConstants0");
				FSRUtils.ShaderConstants.NativeFieldInfoPtr__FsrEasuConstants1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSRUtils.ShaderConstants>.NativeClassPtr, "_FsrEasuConstants1");
				FSRUtils.ShaderConstants.NativeFieldInfoPtr__FsrEasuConstants2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSRUtils.ShaderConstants>.NativeClassPtr, "_FsrEasuConstants2");
				FSRUtils.ShaderConstants.NativeFieldInfoPtr__FsrEasuConstants3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSRUtils.ShaderConstants>.NativeClassPtr, "_FsrEasuConstants3");
				FSRUtils.ShaderConstants.NativeFieldInfoPtr__FsrRcasConstants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSRUtils.ShaderConstants>.NativeClassPtr, "_FsrRcasConstants");
			}

			// Token: 0x06001AAC RID: 6828 RVA: 0x0000D5D8 File Offset: 0x0000B7D8
			public ShaderConstants(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000781 RID: 1921
			// (get) Token: 0x06001AAD RID: 6829 RVA: 0x0006DC44 File Offset: 0x0006BE44
			// (set) Token: 0x06001AAE RID: 6830 RVA: 0x0000D5E1 File Offset: 0x0000B7E1
			public unsafe static int _FsrEasuConstants0
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(FSRUtils.ShaderConstants.NativeFieldInfoPtr__FsrEasuConstants0, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FSRUtils.ShaderConstants.NativeFieldInfoPtr__FsrEasuConstants0, (void*)(&value));
				}
			}

			// Token: 0x17000782 RID: 1922
			// (get) Token: 0x06001AAF RID: 6831 RVA: 0x0006DC60 File Offset: 0x0006BE60
			// (set) Token: 0x06001AB0 RID: 6832 RVA: 0x0000D5EF File Offset: 0x0000B7EF
			public unsafe static int _FsrEasuConstants1
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(FSRUtils.ShaderConstants.NativeFieldInfoPtr__FsrEasuConstants1, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FSRUtils.ShaderConstants.NativeFieldInfoPtr__FsrEasuConstants1, (void*)(&value));
				}
			}

			// Token: 0x17000783 RID: 1923
			// (get) Token: 0x06001AB1 RID: 6833 RVA: 0x0006DC7C File Offset: 0x0006BE7C
			// (set) Token: 0x06001AB2 RID: 6834 RVA: 0x0000D5FD File Offset: 0x0000B7FD
			public unsafe static int _FsrEasuConstants2
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(FSRUtils.ShaderConstants.NativeFieldInfoPtr__FsrEasuConstants2, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FSRUtils.ShaderConstants.NativeFieldInfoPtr__FsrEasuConstants2, (void*)(&value));
				}
			}

			// Token: 0x17000784 RID: 1924
			// (get) Token: 0x06001AB3 RID: 6835 RVA: 0x0006DC98 File Offset: 0x0006BE98
			// (set) Token: 0x06001AB4 RID: 6836 RVA: 0x0000D60B File Offset: 0x0000B80B
			public unsafe static int _FsrEasuConstants3
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(FSRUtils.ShaderConstants.NativeFieldInfoPtr__FsrEasuConstants3, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FSRUtils.ShaderConstants.NativeFieldInfoPtr__FsrEasuConstants3, (void*)(&value));
				}
			}

			// Token: 0x17000785 RID: 1925
			// (get) Token: 0x06001AB5 RID: 6837 RVA: 0x0006DCB4 File Offset: 0x0006BEB4
			// (set) Token: 0x06001AB6 RID: 6838 RVA: 0x0000D619 File Offset: 0x0000B819
			public unsafe static int _FsrRcasConstants
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(FSRUtils.ShaderConstants.NativeFieldInfoPtr__FsrRcasConstants, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FSRUtils.ShaderConstants.NativeFieldInfoPtr__FsrRcasConstants, (void*)(&value));
				}
			}

			// Token: 0x04001369 RID: 4969
			private static readonly IntPtr NativeFieldInfoPtr__FsrEasuConstants0;

			// Token: 0x0400136A RID: 4970
			private static readonly IntPtr NativeFieldInfoPtr__FsrEasuConstants1;

			// Token: 0x0400136B RID: 4971
			private static readonly IntPtr NativeFieldInfoPtr__FsrEasuConstants2;

			// Token: 0x0400136C RID: 4972
			private static readonly IntPtr NativeFieldInfoPtr__FsrEasuConstants3;

			// Token: 0x0400136D RID: 4973
			private static readonly IntPtr NativeFieldInfoPtr__FsrRcasConstants;
		}
	}
}
