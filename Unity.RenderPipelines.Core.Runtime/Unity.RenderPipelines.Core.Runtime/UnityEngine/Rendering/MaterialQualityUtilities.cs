using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000DC RID: 220
	public static class MaterialQualityUtilities : Object
	{
		// Token: 0x0600101F RID: 4127 RVA: 0x0004AB5C File Offset: 0x00048D5C
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialQualityUtilities()
		{
			Il2CppClassPointerStore<MaterialQualityUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "MaterialQualityUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialQualityUtilities>.NativeClassPtr);
			MaterialQualityUtilities.NativeFieldInfoPtr_KeywordNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialQualityUtilities>.NativeClassPtr, "KeywordNames");
			MaterialQualityUtilities.NativeFieldInfoPtr_EnumNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialQualityUtilities>.NativeClassPtr, "EnumNames");
			MaterialQualityUtilities.NativeFieldInfoPtr_Keywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialQualityUtilities>.NativeClassPtr, "Keywords");
			MaterialQualityUtilities.NativeMethodInfoPtr_GetHighestQuality_Public_Static_MaterialQuality_MaterialQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialQualityUtilities>.NativeClassPtr, 100665697);
			MaterialQualityUtilities.NativeMethodInfoPtr_GetClosestQuality_Public_Static_MaterialQuality_MaterialQuality_MaterialQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialQualityUtilities>.NativeClassPtr, 100665698);
			MaterialQualityUtilities.NativeMethodInfoPtr_SetGlobalShaderKeywords_Public_Static_Void_MaterialQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialQualityUtilities>.NativeClassPtr, 100665699);
			MaterialQualityUtilities.NativeMethodInfoPtr_SetGlobalShaderKeywords_Public_Static_Void_MaterialQuality_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialQualityUtilities>.NativeClassPtr, 100665700);
			MaterialQualityUtilities.NativeMethodInfoPtr_ToFirstIndex_Public_Static_Int32_MaterialQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialQualityUtilities>.NativeClassPtr, 100665701);
			MaterialQualityUtilities.NativeMethodInfoPtr_FromIndex_Public_Static_MaterialQuality_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialQualityUtilities>.NativeClassPtr, 100665702);
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x0004AC40 File Offset: 0x00048E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977509, XrefRangeEnd = 977513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MaterialQuality GetHighestQuality(this MaterialQuality levels)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref levels;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialQualityUtilities.NativeMethodInfoPtr_GetHighestQuality_Public_Static_MaterialQuality_MaterialQuality_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x0004AC80 File Offset: 0x00048E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977513, XrefRangeEnd = 977526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MaterialQuality GetClosestQuality(this MaterialQuality availableLevels, MaterialQuality requestedLevel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref availableLevels;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestedLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialQualityUtilities.NativeMethodInfoPtr_GetClosestQuality_Public_Static_MaterialQuality_MaterialQuality_MaterialQuality_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x0004ACCC File Offset: 0x00048ECC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 977538, RefRangeEnd = 977542, XrefRangeStart = 977526, XrefRangeEnd = 977538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalShaderKeywords(this MaterialQuality level)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialQualityUtilities.NativeMethodInfoPtr_SetGlobalShaderKeywords_Public_Static_Void_MaterialQuality_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x0004AD00 File Offset: 0x00048F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977542, XrefRangeEnd = 977554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalShaderKeywords(this MaterialQuality level, CommandBuffer cmd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialQualityUtilities.NativeMethodInfoPtr_SetGlobalShaderKeywords_Public_Static_Void_MaterialQuality_CommandBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x0004AD44 File Offset: 0x00048F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977554, XrefRangeEnd = 977559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToFirstIndex(this MaterialQuality level)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialQualityUtilities.NativeMethodInfoPtr_ToFirstIndex_Public_Static_Int32_MaterialQuality_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x0004AD84 File Offset: 0x00048F84
		[CallerCount(0)]
		public unsafe static MaterialQuality FromIndex(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialQualityUtilities.NativeMethodInfoPtr_FromIndex_Public_Static_MaterialQuality_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x00008879 File Offset: 0x00006A79
		public MaterialQualityUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06001027 RID: 4135 RVA: 0x0004ADC4 File Offset: 0x00048FC4
		// (set) Token: 0x06001028 RID: 4136 RVA: 0x00008882 File Offset: 0x00006A82
		public unsafe static Il2CppStringArray KeywordNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialQualityUtilities.NativeFieldInfoPtr_KeywordNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialQualityUtilities.NativeFieldInfoPtr_KeywordNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06001029 RID: 4137 RVA: 0x0004ADEC File Offset: 0x00048FEC
		// (set) Token: 0x0600102A RID: 4138 RVA: 0x00008894 File Offset: 0x00006A94
		public unsafe static Il2CppStringArray EnumNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialQualityUtilities.NativeFieldInfoPtr_EnumNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialQualityUtilities.NativeFieldInfoPtr_EnumNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x0600102B RID: 4139 RVA: 0x0004AE14 File Offset: 0x00049014
		// (set) Token: 0x0600102C RID: 4140 RVA: 0x000088A6 File Offset: 0x00006AA6
		public unsafe static Il2CppReferenceArray<ShaderKeyword> Keywords
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialQualityUtilities.NativeFieldInfoPtr_Keywords, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ShaderKeyword>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialQualityUtilities.NativeFieldInfoPtr_Keywords, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C54 RID: 3156
		private static readonly IntPtr NativeFieldInfoPtr_KeywordNames;

		// Token: 0x04000C55 RID: 3157
		private static readonly IntPtr NativeFieldInfoPtr_EnumNames;

		// Token: 0x04000C56 RID: 3158
		private static readonly IntPtr NativeFieldInfoPtr_Keywords;

		// Token: 0x04000C57 RID: 3159
		private static readonly IntPtr NativeMethodInfoPtr_GetHighestQuality_Public_Static_MaterialQuality_MaterialQuality_0;

		// Token: 0x04000C58 RID: 3160
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestQuality_Public_Static_MaterialQuality_MaterialQuality_MaterialQuality_0;

		// Token: 0x04000C59 RID: 3161
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalShaderKeywords_Public_Static_Void_MaterialQuality_0;

		// Token: 0x04000C5A RID: 3162
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalShaderKeywords_Public_Static_Void_MaterialQuality_CommandBuffer_0;

		// Token: 0x04000C5B RID: 3163
		private static readonly IntPtr NativeMethodInfoPtr_ToFirstIndex_Public_Static_Int32_MaterialQuality_0;

		// Token: 0x04000C5C RID: 3164
		private static readonly IntPtr NativeMethodInfoPtr_FromIndex_Public_Static_MaterialQuality_Int32_0;
	}
}
