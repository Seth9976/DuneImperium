using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000D9 RID: 217
	public class Random : Object
	{
		// Token: 0x06000DFD RID: 3581 RVA: 0x00067598 File Offset: 0x00065798
		// Note: this type is marked as 'beforefieldinit'.
		static Random()
		{
			Il2CppClassPointerStore<Random>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Random");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Random>.NativeClassPtr);
			Random.NativeFieldInfoPtr_MBIG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random>.NativeClassPtr, "MBIG");
			Random.NativeFieldInfoPtr_MSEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random>.NativeClassPtr, "MSEED");
			Random.NativeFieldInfoPtr_MZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random>.NativeClassPtr, "MZ");
			Random.NativeFieldInfoPtr__inext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random>.NativeClassPtr, "_inext");
			Random.NativeFieldInfoPtr__inextp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random>.NativeClassPtr, "_inextp");
			Random.NativeFieldInfoPtr__seedArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random>.NativeClassPtr, "_seedArray");
			Random.NativeFieldInfoPtr_t_threadRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random>.NativeClassPtr, "t_threadRandom");
			Random.NativeFieldInfoPtr_s_globalRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random>.NativeClassPtr, "s_globalRandom");
			Random.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665753);
			Random.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665754);
			Random.NativeMethodInfoPtr_Sample_Protected_Virtual_New_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665755);
			Random.NativeMethodInfoPtr_InternalSample_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665756);
			Random.NativeMethodInfoPtr_GenerateSeed_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665757);
			Random.NativeMethodInfoPtr_GenerateGlobalSeed_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665758);
			Random.NativeMethodInfoPtr_Next_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665759);
			Random.NativeMethodInfoPtr_GetSampleForLargeRange_Private_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665760);
			Random.NativeMethodInfoPtr_Next_Public_Virtual_New_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665761);
			Random.NativeMethodInfoPtr_Next_Public_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665762);
			Random.NativeMethodInfoPtr_NextDouble_Public_Virtual_New_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665763);
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x00067744 File Offset: 0x00065944
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1318696, RefRangeEnd = 1318702, XrefRangeStart = 1318691, XrefRangeEnd = 1318696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Random()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Random>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00067780 File Offset: 0x00065980
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1318711, RefRangeEnd = 1318718, XrefRangeStart = 1318702, XrefRangeEnd = 1318711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Random(int Seed)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Random>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Seed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x000677C8 File Offset: 0x000659C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1318718, XrefRangeEnd = 1318719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual double Sample()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Random.NativeMethodInfoPtr_Sample_Protected_Virtual_New_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00067810 File Offset: 0x00065A10
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1318719, RefRangeEnd = 1318725, XrefRangeStart = 1318719, XrefRangeEnd = 1318719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalSample()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_InternalSample_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x0006784C File Offset: 0x00065A4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1318750, RefRangeEnd = 1318751, XrefRangeStart = 1318725, XrefRangeEnd = 1318750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GenerateSeed()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_GenerateSeed_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x0006787C File Offset: 0x00065A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GenerateGlobalSeed()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_GenerateGlobalSeed_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x000678AC File Offset: 0x00065AAC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1318752, RefRangeEnd = 1318757, XrefRangeStart = 1318751, XrefRangeEnd = 1318752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Next()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Random.NativeMethodInfoPtr_Next_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x000678F4 File Offset: 0x00065AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1318757, XrefRangeEnd = 1318759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetSampleForLargeRange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_GetSampleForLargeRange_Private_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00067930 File Offset: 0x00065B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1318759, XrefRangeEnd = 1318761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Next(int minValue, int maxValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Random.NativeMethodInfoPtr_Next_Public_Virtual_New_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00067994 File Offset: 0x00065B94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1318761, RefRangeEnd = 1318762, XrefRangeStart = 1318761, XrefRangeEnd = 1318761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Next(int maxValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Random.NativeMethodInfoPtr_Next_Public_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x000679E8 File Offset: 0x00065BE8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 660290, RefRangeEnd = 660296, XrefRangeStart = 660290, XrefRangeEnd = 660296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual double NextDouble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Random.NativeMethodInfoPtr_NextDouble_Public_Virtual_New_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00005602 File Offset: 0x00003802
		public Random(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000E0A RID: 3594 RVA: 0x00067A30 File Offset: 0x00065C30
		// (set) Token: 0x06000E0B RID: 3595 RVA: 0x0000560B File Offset: 0x0000380B
		public unsafe static int MBIG
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Random.NativeFieldInfoPtr_MBIG, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Random.NativeFieldInfoPtr_MBIG, (void*)(&value));
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000E0C RID: 3596 RVA: 0x00067A4C File Offset: 0x00065C4C
		// (set) Token: 0x06000E0D RID: 3597 RVA: 0x00005619 File Offset: 0x00003819
		public unsafe static int MSEED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Random.NativeFieldInfoPtr_MSEED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Random.NativeFieldInfoPtr_MSEED, (void*)(&value));
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000E0E RID: 3598 RVA: 0x00067A68 File Offset: 0x00065C68
		// (set) Token: 0x06000E0F RID: 3599 RVA: 0x00005627 File Offset: 0x00003827
		public unsafe static int MZ
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Random.NativeFieldInfoPtr_MZ, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Random.NativeFieldInfoPtr_MZ, (void*)(&value));
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000E10 RID: 3600 RVA: 0x00067A84 File Offset: 0x00065C84
		// (set) Token: 0x06000E11 RID: 3601 RVA: 0x00005635 File Offset: 0x00003835
		public unsafe int _inext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Random.NativeFieldInfoPtr__inext);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Random.NativeFieldInfoPtr__inext)) = value;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000E12 RID: 3602 RVA: 0x00067AAC File Offset: 0x00065CAC
		// (set) Token: 0x06000E13 RID: 3603 RVA: 0x00005650 File Offset: 0x00003850
		public unsafe int _inextp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Random.NativeFieldInfoPtr__inextp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Random.NativeFieldInfoPtr__inextp)) = value;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x00067AD4 File Offset: 0x00065CD4
		// (set) Token: 0x06000E15 RID: 3605 RVA: 0x0000566B File Offset: 0x0000386B
		public unsafe Il2CppStructArray<int> _seedArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Random.NativeFieldInfoPtr__seedArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Random.NativeFieldInfoPtr__seedArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000E16 RID: 3606 RVA: 0x00067B04 File Offset: 0x00065D04
		// (set) Token: 0x06000E17 RID: 3607 RVA: 0x0000568A File Offset: 0x0000388A
		public unsafe static Random t_threadRandom
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Random.NativeFieldInfoPtr_t_threadRandom, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Random>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Random.NativeFieldInfoPtr_t_threadRandom, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000E18 RID: 3608 RVA: 0x00067B2C File Offset: 0x00065D2C
		// (set) Token: 0x06000E19 RID: 3609 RVA: 0x0000569C File Offset: 0x0000389C
		public unsafe static Random s_globalRandom
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Random.NativeFieldInfoPtr_s_globalRandom, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Random>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Random.NativeFieldInfoPtr_s_globalRandom, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeFieldInfoPtr_MBIG;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeFieldInfoPtr_MSEED;

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeFieldInfoPtr_MZ;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeFieldInfoPtr__inext;

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeFieldInfoPtr__inextp;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeFieldInfoPtr__seedArray;

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeFieldInfoPtr_t_threadRandom;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeFieldInfoPtr_s_globalRandom;

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeMethodInfoPtr_Sample_Protected_Virtual_New_Double_0;

		// Token: 0x04000B80 RID: 2944
		private static readonly IntPtr NativeMethodInfoPtr_InternalSample_Private_Int32_0;

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeMethodInfoPtr_GenerateSeed_Private_Static_Int32_0;

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeMethodInfoPtr_GenerateGlobalSeed_Private_Static_Int32_0;

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeMethodInfoPtr_Next_Public_Virtual_New_Int32_0;

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeMethodInfoPtr_GetSampleForLargeRange_Private_Double_0;

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeMethodInfoPtr_Next_Public_Virtual_New_Int32_Int32_Int32_0;

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeMethodInfoPtr_Next_Public_Virtual_New_Int32_Int32_0;

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeMethodInfoPtr_NextDouble_Public_Virtual_New_Double_0;
	}
}
