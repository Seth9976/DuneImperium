using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000D7 RID: 215
	public class HableCurve : Object
	{
		// Token: 0x06000FE2 RID: 4066 RVA: 0x00049BEC File Offset: 0x00047DEC
		// Note: this type is marked as 'beforefieldinit'.
		static HableCurve()
		{
			Il2CppClassPointerStore<HableCurve>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "HableCurve");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HableCurve>.NativeClassPtr);
			HableCurve.NativeFieldInfoPtr__whitePoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, "<whitePoint>k__BackingField");
			HableCurve.NativeFieldInfoPtr__inverseWhitePoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, "<inverseWhitePoint>k__BackingField");
			HableCurve.NativeFieldInfoPtr__x0_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, "<x0>k__BackingField");
			HableCurve.NativeFieldInfoPtr__x1_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, "<x1>k__BackingField");
			HableCurve.NativeFieldInfoPtr_segments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, "segments");
			HableCurve.NativeFieldInfoPtr_uniforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, "uniforms");
			HableCurve.NativeMethodInfoPtr_get_whitePoint_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100665647);
			HableCurve.NativeMethodInfoPtr_set_whitePoint_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100665648);
			HableCurve.NativeMethodInfoPtr_get_inverseWhitePoint_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100665649);
			HableCurve.NativeMethodInfoPtr_set_inverseWhitePoint_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100665650);
			HableCurve.NativeMethodInfoPtr_get_x0_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100665651);
			HableCurve.NativeMethodInfoPtr_set_x0_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100665652);
			HableCurve.NativeMethodInfoPtr_get_x1_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100665653);
			HableCurve.NativeMethodInfoPtr_set_x1_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100665654);
			HableCurve.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100665655);
			HableCurve.NativeMethodInfoPtr_Eval_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100665656);
			HableCurve.NativeMethodInfoPtr_Init_Public_Void_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100665657);
			HableCurve.NativeMethodInfoPtr_InitSegments_Private_Void_DirectParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100665658);
			HableCurve.NativeMethodInfoPtr_SolveAB_Private_Void_byref_Single_byref_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100665659);
			HableCurve.NativeMethodInfoPtr_AsSlopeIntercept_Private_Void_byref_Single_byref_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100665660);
			HableCurve.NativeMethodInfoPtr_EvalDerivativeLinearGamma_Private_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, 100665661);
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x00049DC0 File Offset: 0x00047FC0
		// (set) Token: 0x06000FE4 RID: 4068 RVA: 0x00049DFC File Offset: 0x00047FFC
		public unsafe float whitePoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_get_whitePoint_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_set_whitePoint_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x00049E3C File Offset: 0x0004803C
		// (set) Token: 0x06000FE6 RID: 4070 RVA: 0x00049E78 File Offset: 0x00048078
		public unsafe float inverseWhitePoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_get_inverseWhitePoint_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 644458, RefRangeEnd = 644459, XrefRangeStart = 644458, XrefRangeEnd = 644459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_set_inverseWhitePoint_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x00049EB8 File Offset: 0x000480B8
		// (set) Token: 0x06000FE8 RID: 4072 RVA: 0x00049EF4 File Offset: 0x000480F4
		public unsafe float x0
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_get_x0_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 644463, RefRangeEnd = 644464, XrefRangeStart = 644463, XrefRangeEnd = 644464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_set_x0_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x00049F34 File Offset: 0x00048134
		// (set) Token: 0x06000FEA RID: 4074 RVA: 0x00049F70 File Offset: 0x00048170
		public unsafe float x1
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_get_x1_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 604702, RefRangeEnd = 604705, XrefRangeStart = 604702, XrefRangeEnd = 604705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_set_x1_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x00049FB0 File Offset: 0x000481B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977258, XrefRangeEnd = 977279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HableCurve()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HableCurve>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x00049FEC File Offset: 0x000481EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977279, XrefRangeEnd = 977283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Eval(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_Eval_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x0004A038 File Offset: 0x00048238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977283, XrefRangeEnd = 977290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref toeStrength;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toeLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shoulderStrength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shoulderLength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shoulderAngle;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gamma;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_Init_Public_Void_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x0004A0BC File Offset: 0x000482BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 977303, RefRangeEnd = 977304, XrefRangeStart = 977290, XrefRangeEnd = 977303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitSegments(HableCurve.DirectParams srcParams)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref srcParams;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_InitSegments_Private_Void_DirectParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x0004A0FC File Offset: 0x000482FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977304, XrefRangeEnd = 977306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SolveAB(out float lnA, out float B, float x0, float y0, float m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &lnA;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &B;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x0;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y0;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_SolveAB_Private_Void_byref_Single_byref_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x0004A174 File Offset: 0x00048374
		[CallerCount(0)]
		public unsafe void AsSlopeIntercept(out float m, out float b, float x0, float x1, float y0, float y1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &m;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x0;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x1;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y0;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_AsSlopeIntercept_Private_Void_byref_Single_byref_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x0004A1F8 File Offset: 0x000483F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977306, XrefRangeEnd = 977307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float EvalDerivativeLinearGamma(float m, float b, float g, float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref g;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.NativeMethodInfoPtr_EvalDerivativeLinearGamma_Private_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x0000874D File Offset: 0x0000694D
		public HableCurve(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x0004A26C File Offset: 0x0004846C
		// (set) Token: 0x06000FF4 RID: 4084 RVA: 0x00008756 File Offset: 0x00006956
		public unsafe float _whitePoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.NativeFieldInfoPtr__whitePoint_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.NativeFieldInfoPtr__whitePoint_k__BackingField)) = value;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000FF5 RID: 4085 RVA: 0x0004A294 File Offset: 0x00048494
		// (set) Token: 0x06000FF6 RID: 4086 RVA: 0x00008771 File Offset: 0x00006971
		public unsafe float _inverseWhitePoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.NativeFieldInfoPtr__inverseWhitePoint_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.NativeFieldInfoPtr__inverseWhitePoint_k__BackingField)) = value;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x0004A2BC File Offset: 0x000484BC
		// (set) Token: 0x06000FF8 RID: 4088 RVA: 0x0000878C File Offset: 0x0000698C
		public unsafe float _x0_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.NativeFieldInfoPtr__x0_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.NativeFieldInfoPtr__x0_k__BackingField)) = value;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x0004A2E4 File Offset: 0x000484E4
		// (set) Token: 0x06000FFA RID: 4090 RVA: 0x000087A7 File Offset: 0x000069A7
		public unsafe float _x1_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.NativeFieldInfoPtr__x1_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.NativeFieldInfoPtr__x1_k__BackingField)) = value;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000FFB RID: 4091 RVA: 0x0004A30C File Offset: 0x0004850C
		// (set) Token: 0x06000FFC RID: 4092 RVA: 0x000087C2 File Offset: 0x000069C2
		public unsafe Il2CppReferenceArray<HableCurve.Segment> segments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.NativeFieldInfoPtr_segments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HableCurve.Segment>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.NativeFieldInfoPtr_segments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000FFD RID: 4093 RVA: 0x0004A33C File Offset: 0x0004853C
		// (set) Token: 0x06000FFE RID: 4094 RVA: 0x000087E1 File Offset: 0x000069E1
		public unsafe HableCurve.Uniforms uniforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.NativeFieldInfoPtr_uniforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HableCurve.Uniforms>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.NativeFieldInfoPtr_uniforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeFieldInfoPtr__whitePoint_k__BackingField;

		// Token: 0x04000C22 RID: 3106
		private static readonly IntPtr NativeFieldInfoPtr__inverseWhitePoint_k__BackingField;

		// Token: 0x04000C23 RID: 3107
		private static readonly IntPtr NativeFieldInfoPtr__x0_k__BackingField;

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeFieldInfoPtr__x1_k__BackingField;

		// Token: 0x04000C25 RID: 3109
		private static readonly IntPtr NativeFieldInfoPtr_segments;

		// Token: 0x04000C26 RID: 3110
		private static readonly IntPtr NativeFieldInfoPtr_uniforms;

		// Token: 0x04000C27 RID: 3111
		private static readonly IntPtr NativeMethodInfoPtr_get_whitePoint_Public_get_Single_0;

		// Token: 0x04000C28 RID: 3112
		private static readonly IntPtr NativeMethodInfoPtr_set_whitePoint_Private_set_Void_Single_0;

		// Token: 0x04000C29 RID: 3113
		private static readonly IntPtr NativeMethodInfoPtr_get_inverseWhitePoint_Public_get_Single_0;

		// Token: 0x04000C2A RID: 3114
		private static readonly IntPtr NativeMethodInfoPtr_set_inverseWhitePoint_Private_set_Void_Single_0;

		// Token: 0x04000C2B RID: 3115
		private static readonly IntPtr NativeMethodInfoPtr_get_x0_Public_get_Single_0;

		// Token: 0x04000C2C RID: 3116
		private static readonly IntPtr NativeMethodInfoPtr_set_x0_Private_set_Void_Single_0;

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeMethodInfoPtr_get_x1_Public_get_Single_0;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeMethodInfoPtr_set_x1_Private_set_Void_Single_0;

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Public_Single_Single_0;

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x04000C32 RID: 3122
		private static readonly IntPtr NativeMethodInfoPtr_InitSegments_Private_Void_DirectParams_0;

		// Token: 0x04000C33 RID: 3123
		private static readonly IntPtr NativeMethodInfoPtr_SolveAB_Private_Void_byref_Single_byref_Single_Single_Single_Single_0;

		// Token: 0x04000C34 RID: 3124
		private static readonly IntPtr NativeMethodInfoPtr_AsSlopeIntercept_Private_Void_byref_Single_byref_Single_Single_Single_Single_Single_0;

		// Token: 0x04000C35 RID: 3125
		private static readonly IntPtr NativeMethodInfoPtr_EvalDerivativeLinearGamma_Private_Single_Single_Single_Single_Single_0;

		// Token: 0x020001FC RID: 508
		public class Segment : Object
		{
			// Token: 0x06001AB7 RID: 6839 RVA: 0x0006DCD0 File Offset: 0x0006BED0
			// Note: this type is marked as 'beforefieldinit'.
			static Segment()
			{
				Il2CppClassPointerStore<HableCurve.Segment>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, "Segment");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HableCurve.Segment>.NativeClassPtr);
				HableCurve.Segment.NativeFieldInfoPtr_offsetX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.Segment>.NativeClassPtr, "offsetX");
				HableCurve.Segment.NativeFieldInfoPtr_offsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.Segment>.NativeClassPtr, "offsetY");
				HableCurve.Segment.NativeFieldInfoPtr_scaleX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.Segment>.NativeClassPtr, "scaleX");
				HableCurve.Segment.NativeFieldInfoPtr_scaleY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.Segment>.NativeClassPtr, "scaleY");
				HableCurve.Segment.NativeFieldInfoPtr_lnA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.Segment>.NativeClassPtr, "lnA");
				HableCurve.Segment.NativeFieldInfoPtr_B = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.Segment>.NativeClassPtr, "B");
				HableCurve.Segment.NativeMethodInfoPtr_Eval_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve.Segment>.NativeClassPtr, 100665662);
				HableCurve.Segment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve.Segment>.NativeClassPtr, 100665663);
			}

			// Token: 0x06001AB8 RID: 6840 RVA: 0x0006DD9C File Offset: 0x0006BF9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977256, XrefRangeEnd = 977258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float Eval(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.Segment.NativeMethodInfoPtr_Eval_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AB9 RID: 6841 RVA: 0x0006DDE8 File Offset: 0x0006BFE8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Segment()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HableCurve.Segment>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.Segment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001ABA RID: 6842 RVA: 0x0000D627 File Offset: 0x0000B827
			public Segment(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000786 RID: 1926
			// (get) Token: 0x06001ABB RID: 6843 RVA: 0x0006DE24 File Offset: 0x0006C024
			// (set) Token: 0x06001ABC RID: 6844 RVA: 0x0000D630 File Offset: 0x0000B830
			public unsafe float offsetX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Segment.NativeFieldInfoPtr_offsetX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Segment.NativeFieldInfoPtr_offsetX)) = value;
				}
			}

			// Token: 0x17000787 RID: 1927
			// (get) Token: 0x06001ABD RID: 6845 RVA: 0x0006DE4C File Offset: 0x0006C04C
			// (set) Token: 0x06001ABE RID: 6846 RVA: 0x0000D64B File Offset: 0x0000B84B
			public unsafe float offsetY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Segment.NativeFieldInfoPtr_offsetY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Segment.NativeFieldInfoPtr_offsetY)) = value;
				}
			}

			// Token: 0x17000788 RID: 1928
			// (get) Token: 0x06001ABF RID: 6847 RVA: 0x0006DE74 File Offset: 0x0006C074
			// (set) Token: 0x06001AC0 RID: 6848 RVA: 0x0000D666 File Offset: 0x0000B866
			public unsafe float scaleX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Segment.NativeFieldInfoPtr_scaleX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Segment.NativeFieldInfoPtr_scaleX)) = value;
				}
			}

			// Token: 0x17000789 RID: 1929
			// (get) Token: 0x06001AC1 RID: 6849 RVA: 0x0006DE9C File Offset: 0x0006C09C
			// (set) Token: 0x06001AC2 RID: 6850 RVA: 0x0000D681 File Offset: 0x0000B881
			public unsafe float scaleY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Segment.NativeFieldInfoPtr_scaleY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Segment.NativeFieldInfoPtr_scaleY)) = value;
				}
			}

			// Token: 0x1700078A RID: 1930
			// (get) Token: 0x06001AC3 RID: 6851 RVA: 0x0006DEC4 File Offset: 0x0006C0C4
			// (set) Token: 0x06001AC4 RID: 6852 RVA: 0x0000D69C File Offset: 0x0000B89C
			public unsafe float lnA
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Segment.NativeFieldInfoPtr_lnA);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Segment.NativeFieldInfoPtr_lnA)) = value;
				}
			}

			// Token: 0x1700078B RID: 1931
			// (get) Token: 0x06001AC5 RID: 6853 RVA: 0x0006DEEC File Offset: 0x0006C0EC
			// (set) Token: 0x06001AC6 RID: 6854 RVA: 0x0000D6B7 File Offset: 0x0000B8B7
			public unsafe float B
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Segment.NativeFieldInfoPtr_B);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Segment.NativeFieldInfoPtr_B)) = value;
				}
			}

			// Token: 0x0400136E RID: 4974
			private static readonly IntPtr NativeFieldInfoPtr_offsetX;

			// Token: 0x0400136F RID: 4975
			private static readonly IntPtr NativeFieldInfoPtr_offsetY;

			// Token: 0x04001370 RID: 4976
			private static readonly IntPtr NativeFieldInfoPtr_scaleX;

			// Token: 0x04001371 RID: 4977
			private static readonly IntPtr NativeFieldInfoPtr_scaleY;

			// Token: 0x04001372 RID: 4978
			private static readonly IntPtr NativeFieldInfoPtr_lnA;

			// Token: 0x04001373 RID: 4979
			private static readonly IntPtr NativeFieldInfoPtr_B;

			// Token: 0x04001374 RID: 4980
			private static readonly IntPtr NativeMethodInfoPtr_Eval_Public_Single_Single_0;

			// Token: 0x04001375 RID: 4981
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001FD RID: 509
		[StructLayout(2)]
		public struct DirectParams
		{
			// Token: 0x06001AC7 RID: 6855 RVA: 0x0006DF14 File Offset: 0x0006C114
			// Note: this type is marked as 'beforefieldinit'.
			static DirectParams()
			{
				Il2CppClassPointerStore<HableCurve.DirectParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, "DirectParams");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HableCurve.DirectParams>.NativeClassPtr);
				HableCurve.DirectParams.NativeFieldInfoPtr_x0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.DirectParams>.NativeClassPtr, "x0");
				HableCurve.DirectParams.NativeFieldInfoPtr_y0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.DirectParams>.NativeClassPtr, "y0");
				HableCurve.DirectParams.NativeFieldInfoPtr_x1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.DirectParams>.NativeClassPtr, "x1");
				HableCurve.DirectParams.NativeFieldInfoPtr_y1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.DirectParams>.NativeClassPtr, "y1");
				HableCurve.DirectParams.NativeFieldInfoPtr_W = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.DirectParams>.NativeClassPtr, "W");
				HableCurve.DirectParams.NativeFieldInfoPtr_overshootX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.DirectParams>.NativeClassPtr, "overshootX");
				HableCurve.DirectParams.NativeFieldInfoPtr_overshootY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.DirectParams>.NativeClassPtr, "overshootY");
				HableCurve.DirectParams.NativeFieldInfoPtr_gamma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.DirectParams>.NativeClassPtr, "gamma");
			}

			// Token: 0x06001AC8 RID: 6856 RVA: 0x0000D6D2 File Offset: 0x0000B8D2
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HableCurve.DirectParams>.NativeClassPtr, ref this));
			}

			// Token: 0x04001376 RID: 4982
			private static readonly IntPtr NativeFieldInfoPtr_x0;

			// Token: 0x04001377 RID: 4983
			private static readonly IntPtr NativeFieldInfoPtr_y0;

			// Token: 0x04001378 RID: 4984
			private static readonly IntPtr NativeFieldInfoPtr_x1;

			// Token: 0x04001379 RID: 4985
			private static readonly IntPtr NativeFieldInfoPtr_y1;

			// Token: 0x0400137A RID: 4986
			private static readonly IntPtr NativeFieldInfoPtr_W;

			// Token: 0x0400137B RID: 4987
			private static readonly IntPtr NativeFieldInfoPtr_overshootX;

			// Token: 0x0400137C RID: 4988
			private static readonly IntPtr NativeFieldInfoPtr_overshootY;

			// Token: 0x0400137D RID: 4989
			private static readonly IntPtr NativeFieldInfoPtr_gamma;

			// Token: 0x0400137E RID: 4990
			[FieldOffset(0)]
			public float x0;

			// Token: 0x0400137F RID: 4991
			[FieldOffset(4)]
			public float y0;

			// Token: 0x04001380 RID: 4992
			[FieldOffset(8)]
			public float x1;

			// Token: 0x04001381 RID: 4993
			[FieldOffset(12)]
			public float y1;

			// Token: 0x04001382 RID: 4994
			[FieldOffset(16)]
			public float W;

			// Token: 0x04001383 RID: 4995
			[FieldOffset(20)]
			public float overshootX;

			// Token: 0x04001384 RID: 4996
			[FieldOffset(24)]
			public float overshootY;

			// Token: 0x04001385 RID: 4997
			[FieldOffset(28)]
			public float gamma;
		}

		// Token: 0x020001FE RID: 510
		public class Uniforms : Object
		{
			// Token: 0x06001AC9 RID: 6857 RVA: 0x0006DFE0 File Offset: 0x0006C1E0
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<HableCurve.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HableCurve>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HableCurve.Uniforms>.NativeClassPtr);
				HableCurve.Uniforms.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HableCurve.Uniforms>.NativeClassPtr, "parent");
				HableCurve.Uniforms.NativeMethodInfoPtr__ctor_Internal_Void_HableCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve.Uniforms>.NativeClassPtr, 100665664);
				HableCurve.Uniforms.NativeMethodInfoPtr_get_curve_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve.Uniforms>.NativeClassPtr, 100665665);
				HableCurve.Uniforms.NativeMethodInfoPtr_get_toeSegmentA_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve.Uniforms>.NativeClassPtr, 100665666);
				HableCurve.Uniforms.NativeMethodInfoPtr_get_toeSegmentB_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve.Uniforms>.NativeClassPtr, 100665667);
				HableCurve.Uniforms.NativeMethodInfoPtr_get_midSegmentA_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve.Uniforms>.NativeClassPtr, 100665668);
				HableCurve.Uniforms.NativeMethodInfoPtr_get_midSegmentB_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve.Uniforms>.NativeClassPtr, 100665669);
				HableCurve.Uniforms.NativeMethodInfoPtr_get_shoSegmentA_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve.Uniforms>.NativeClassPtr, 100665670);
				HableCurve.Uniforms.NativeMethodInfoPtr_get_shoSegmentB_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HableCurve.Uniforms>.NativeClassPtr, 100665671);
			}

			// Token: 0x06001ACA RID: 6858 RVA: 0x0006E0C0 File Offset: 0x0006C2C0
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Uniforms(HableCurve parent)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HableCurve.Uniforms>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.Uniforms.NativeMethodInfoPtr__ctor_Internal_Void_HableCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700078D RID: 1933
			// (get) Token: 0x06001ACB RID: 6859 RVA: 0x0006E10C File Offset: 0x0006C30C
			public unsafe Vector4 curve
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.Uniforms.NativeMethodInfoPtr_get_curve_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700078E RID: 1934
			// (get) Token: 0x06001ACC RID: 6860 RVA: 0x0006E148 File Offset: 0x0006C348
			public unsafe Vector4 toeSegmentA
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.Uniforms.NativeMethodInfoPtr_get_toeSegmentA_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700078F RID: 1935
			// (get) Token: 0x06001ACD RID: 6861 RVA: 0x0006E184 File Offset: 0x0006C384
			public unsafe Vector4 toeSegmentB
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.Uniforms.NativeMethodInfoPtr_get_toeSegmentB_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000790 RID: 1936
			// (get) Token: 0x06001ACE RID: 6862 RVA: 0x0006E1C0 File Offset: 0x0006C3C0
			public unsafe Vector4 midSegmentA
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.Uniforms.NativeMethodInfoPtr_get_midSegmentA_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000791 RID: 1937
			// (get) Token: 0x06001ACF RID: 6863 RVA: 0x0006E1FC File Offset: 0x0006C3FC
			public unsafe Vector4 midSegmentB
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.Uniforms.NativeMethodInfoPtr_get_midSegmentB_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000792 RID: 1938
			// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x0006E238 File Offset: 0x0006C438
			public unsafe Vector4 shoSegmentA
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.Uniforms.NativeMethodInfoPtr_get_shoSegmentA_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000793 RID: 1939
			// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x0006E274 File Offset: 0x0006C474
			public unsafe Vector4 shoSegmentB
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HableCurve.Uniforms.NativeMethodInfoPtr_get_shoSegmentB_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AD2 RID: 6866 RVA: 0x0000D6E4 File Offset: 0x0000B8E4
			public Uniforms(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700078C RID: 1932
			// (get) Token: 0x06001AD3 RID: 6867 RVA: 0x0006E2B0 File Offset: 0x0006C4B0
			// (set) Token: 0x06001AD4 RID: 6868 RVA: 0x0000D6ED File Offset: 0x0000B8ED
			public unsafe HableCurve parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Uniforms.NativeFieldInfoPtr_parent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HableCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HableCurve.Uniforms.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001386 RID: 4998
			private static readonly IntPtr NativeFieldInfoPtr_parent;

			// Token: 0x04001387 RID: 4999
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_HableCurve_0;

			// Token: 0x04001388 RID: 5000
			private static readonly IntPtr NativeMethodInfoPtr_get_curve_Public_get_Vector4_0;

			// Token: 0x04001389 RID: 5001
			private static readonly IntPtr NativeMethodInfoPtr_get_toeSegmentA_Public_get_Vector4_0;

			// Token: 0x0400138A RID: 5002
			private static readonly IntPtr NativeMethodInfoPtr_get_toeSegmentB_Public_get_Vector4_0;

			// Token: 0x0400138B RID: 5003
			private static readonly IntPtr NativeMethodInfoPtr_get_midSegmentA_Public_get_Vector4_0;

			// Token: 0x0400138C RID: 5004
			private static readonly IntPtr NativeMethodInfoPtr_get_midSegmentB_Public_get_Vector4_0;

			// Token: 0x0400138D RID: 5005
			private static readonly IntPtr NativeMethodInfoPtr_get_shoSegmentA_Public_get_Vector4_0;

			// Token: 0x0400138E RID: 5006
			private static readonly IntPtr NativeMethodInfoPtr_get_shoSegmentB_Public_get_Vector4_0;
		}
	}
}
