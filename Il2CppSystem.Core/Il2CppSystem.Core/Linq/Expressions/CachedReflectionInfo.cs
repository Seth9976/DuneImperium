using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000025 RID: 37
	public static class CachedReflectionInfo : Object
	{
		// Token: 0x06000180 RID: 384 RVA: 0x000169BC File Offset: 0x00014BBC
		// Note: this type is marked as 'beforefieldinit'.
		static CachedReflectionInfo()
		{
			Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "CachedReflectionInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr);
			CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_SetNotMatched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr, "s_CallSiteOps_SetNotMatched");
			CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_CreateMatchmaker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr, "s_CallSiteOps_CreateMatchmaker");
			CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_GetMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr, "s_CallSiteOps_GetMatch");
			CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_ClearMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr, "s_CallSiteOps_ClearMatch");
			CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_UpdateRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr, "s_CallSiteOps_UpdateRules");
			CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_GetRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr, "s_CallSiteOps_GetRules");
			CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_GetRuleCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr, "s_CallSiteOps_GetRuleCache");
			CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_GetCachedRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr, "s_CallSiteOps_GetCachedRules");
			CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_AddRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr, "s_CallSiteOps_AddRule");
			CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_MoveRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr, "s_CallSiteOps_MoveRule");
			CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_Bind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr, "s_CallSiteOps_Bind");
			CachedReflectionInfo.NativeFieldInfoPtr_s_String_op_Equality_String_String = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr, "s_String_op_Equality_String_String");
			CachedReflectionInfo.NativeFieldInfoPtr_s_Math_Pow_Double_Double = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr, "s_Math_Pow_Double_Double");
			CachedReflectionInfo.NativeMethodInfoPtr_get_CallSiteOps_SetNotMatched_Public_Static_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr, 100663795);
			CachedReflectionInfo.NativeMethodInfoPtr_get_CallSiteOps_CreateMatchmaker_Public_Static_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr, 100663796);
			CachedReflectionInfo.NativeMethodInfoPtr_get_CallSiteOps_GetMatch_Public_Static_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr, 100663797);
			CachedReflectionInfo.NativeMethodInfoPtr_get_CallSiteOps_ClearMatch_Public_Static_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr, 100663798);
			CachedReflectionInfo.NativeMethodInfoPtr_get_CallSiteOps_UpdateRules_Public_Static_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr, 100663799);
			CachedReflectionInfo.NativeMethodInfoPtr_get_CallSiteOps_GetRules_Public_Static_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr, 100663800);
			CachedReflectionInfo.NativeMethodInfoPtr_get_CallSiteOps_GetRuleCache_Public_Static_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr, 100663801);
			CachedReflectionInfo.NativeMethodInfoPtr_get_CallSiteOps_GetCachedRules_Public_Static_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr, 100663802);
			CachedReflectionInfo.NativeMethodInfoPtr_get_CallSiteOps_AddRule_Public_Static_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr, 100663803);
			CachedReflectionInfo.NativeMethodInfoPtr_get_CallSiteOps_MoveRule_Public_Static_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr, 100663804);
			CachedReflectionInfo.NativeMethodInfoPtr_get_CallSiteOps_Bind_Public_Static_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr, 100663805);
			CachedReflectionInfo.NativeMethodInfoPtr_get_String_op_Equality_String_String_Public_Static_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr, 100663806);
			CachedReflectionInfo.NativeMethodInfoPtr_get_Math_Pow_Double_Double_Public_Static_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedReflectionInfo>.NativeClassPtr, 100663807);
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00016BF4 File Offset: 0x00014DF4
		public unsafe static MethodInfo CallSiteOps_SetNotMatched
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1006643, RefRangeEnd = 1006644, XrefRangeStart = 1006629, XrefRangeEnd = 1006643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CachedReflectionInfo.NativeMethodInfoPtr_get_CallSiteOps_SetNotMatched_Public_Static_get_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00016C28 File Offset: 0x00014E28
		public unsafe static MethodInfo CallSiteOps_CreateMatchmaker
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1006658, RefRangeEnd = 1006659, XrefRangeStart = 1006644, XrefRangeEnd = 1006658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CachedReflectionInfo.NativeMethodInfoPtr_get_CallSiteOps_CreateMatchmaker_Public_Static_get_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00016C5C File Offset: 0x00014E5C
		public unsafe static MethodInfo CallSiteOps_GetMatch
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1006673, RefRangeEnd = 1006674, XrefRangeStart = 1006659, XrefRangeEnd = 1006673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CachedReflectionInfo.NativeMethodInfoPtr_get_CallSiteOps_GetMatch_Public_Static_get_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00016C90 File Offset: 0x00014E90
		public unsafe static MethodInfo CallSiteOps_ClearMatch
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1006688, RefRangeEnd = 1006689, XrefRangeStart = 1006674, XrefRangeEnd = 1006688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CachedReflectionInfo.NativeMethodInfoPtr_get_CallSiteOps_ClearMatch_Public_Static_get_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00016CC4 File Offset: 0x00014EC4
		public unsafe static MethodInfo CallSiteOps_UpdateRules
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1006703, RefRangeEnd = 1006704, XrefRangeStart = 1006689, XrefRangeEnd = 1006703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CachedReflectionInfo.NativeMethodInfoPtr_get_CallSiteOps_UpdateRules_Public_Static_get_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00016CF8 File Offset: 0x00014EF8
		public unsafe static MethodInfo CallSiteOps_GetRules
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1006718, RefRangeEnd = 1006719, XrefRangeStart = 1006704, XrefRangeEnd = 1006718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CachedReflectionInfo.NativeMethodInfoPtr_get_CallSiteOps_GetRules_Public_Static_get_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00016D2C File Offset: 0x00014F2C
		public unsafe static MethodInfo CallSiteOps_GetRuleCache
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1006733, RefRangeEnd = 1006734, XrefRangeStart = 1006719, XrefRangeEnd = 1006733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CachedReflectionInfo.NativeMethodInfoPtr_get_CallSiteOps_GetRuleCache_Public_Static_get_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00016D60 File Offset: 0x00014F60
		public unsafe static MethodInfo CallSiteOps_GetCachedRules
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1006748, RefRangeEnd = 1006749, XrefRangeStart = 1006734, XrefRangeEnd = 1006748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CachedReflectionInfo.NativeMethodInfoPtr_get_CallSiteOps_GetCachedRules_Public_Static_get_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00016D94 File Offset: 0x00014F94
		public unsafe static MethodInfo CallSiteOps_AddRule
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1006763, RefRangeEnd = 1006765, XrefRangeStart = 1006749, XrefRangeEnd = 1006763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CachedReflectionInfo.NativeMethodInfoPtr_get_CallSiteOps_AddRule_Public_Static_get_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00016DC8 File Offset: 0x00014FC8
		public unsafe static MethodInfo CallSiteOps_MoveRule
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1006779, RefRangeEnd = 1006780, XrefRangeStart = 1006765, XrefRangeEnd = 1006779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CachedReflectionInfo.NativeMethodInfoPtr_get_CallSiteOps_MoveRule_Public_Static_get_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00016DFC File Offset: 0x00014FFC
		public unsafe static MethodInfo CallSiteOps_Bind
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1006794, RefRangeEnd = 1006795, XrefRangeStart = 1006780, XrefRangeEnd = 1006794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CachedReflectionInfo.NativeMethodInfoPtr_get_CallSiteOps_Bind_Public_Static_get_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00016E30 File Offset: 0x00015030
		public unsafe static MethodInfo String_op_Equality_String_String
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006795, XrefRangeEnd = 1006820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CachedReflectionInfo.NativeMethodInfoPtr_get_String_op_Equality_String_String_Public_Static_get_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00016E64 File Offset: 0x00015064
		public unsafe static MethodInfo Math_Pow_Double_Double
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1006846, RefRangeEnd = 1006848, XrefRangeStart = 1006820, XrefRangeEnd = 1006846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CachedReflectionInfo.NativeMethodInfoPtr_get_Math_Pow_Double_Double_Public_Static_get_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000261F File Offset: 0x0000081F
		public CachedReflectionInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00016E98 File Offset: 0x00015098
		// (set) Token: 0x06000190 RID: 400 RVA: 0x00002628 File Offset: 0x00000828
		public unsafe static MethodInfo s_CallSiteOps_SetNotMatched
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_SetNotMatched, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_SetNotMatched, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00016EC0 File Offset: 0x000150C0
		// (set) Token: 0x06000192 RID: 402 RVA: 0x0000263A File Offset: 0x0000083A
		public unsafe static MethodInfo s_CallSiteOps_CreateMatchmaker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_CreateMatchmaker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_CreateMatchmaker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00016EE8 File Offset: 0x000150E8
		// (set) Token: 0x06000194 RID: 404 RVA: 0x0000264C File Offset: 0x0000084C
		public unsafe static MethodInfo s_CallSiteOps_GetMatch
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_GetMatch, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_GetMatch, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00016F10 File Offset: 0x00015110
		// (set) Token: 0x06000196 RID: 406 RVA: 0x0000265E File Offset: 0x0000085E
		public unsafe static MethodInfo s_CallSiteOps_ClearMatch
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_ClearMatch, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_ClearMatch, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00016F38 File Offset: 0x00015138
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00002670 File Offset: 0x00000870
		public unsafe static MethodInfo s_CallSiteOps_UpdateRules
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_UpdateRules, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_UpdateRules, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00016F60 File Offset: 0x00015160
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00002682 File Offset: 0x00000882
		public unsafe static MethodInfo s_CallSiteOps_GetRules
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_GetRules, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_GetRules, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00016F88 File Offset: 0x00015188
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00002694 File Offset: 0x00000894
		public unsafe static MethodInfo s_CallSiteOps_GetRuleCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_GetRuleCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_GetRuleCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00016FB0 File Offset: 0x000151B0
		// (set) Token: 0x0600019E RID: 414 RVA: 0x000026A6 File Offset: 0x000008A6
		public unsafe static MethodInfo s_CallSiteOps_GetCachedRules
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_GetCachedRules, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_GetCachedRules, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00016FD8 File Offset: 0x000151D8
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x000026B8 File Offset: 0x000008B8
		public unsafe static MethodInfo s_CallSiteOps_AddRule
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_AddRule, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_AddRule, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00017000 File Offset: 0x00015200
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x000026CA File Offset: 0x000008CA
		public unsafe static MethodInfo s_CallSiteOps_MoveRule
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_MoveRule, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_MoveRule, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00017028 File Offset: 0x00015228
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x000026DC File Offset: 0x000008DC
		public unsafe static MethodInfo s_CallSiteOps_Bind
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_Bind, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CachedReflectionInfo.NativeFieldInfoPtr_s_CallSiteOps_Bind, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00017050 File Offset: 0x00015250
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x000026EE File Offset: 0x000008EE
		public unsafe static MethodInfo s_String_op_Equality_String_String
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CachedReflectionInfo.NativeFieldInfoPtr_s_String_op_Equality_String_String, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CachedReflectionInfo.NativeFieldInfoPtr_s_String_op_Equality_String_String, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00017078 File Offset: 0x00015278
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00002700 File Offset: 0x00000900
		public unsafe static MethodInfo s_Math_Pow_Double_Double
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CachedReflectionInfo.NativeFieldInfoPtr_s_Math_Pow_Double_Double, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CachedReflectionInfo.NativeFieldInfoPtr_s_Math_Pow_Double_Double, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeFieldInfoPtr_s_CallSiteOps_SetNotMatched;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeFieldInfoPtr_s_CallSiteOps_CreateMatchmaker;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeFieldInfoPtr_s_CallSiteOps_GetMatch;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeFieldInfoPtr_s_CallSiteOps_ClearMatch;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeFieldInfoPtr_s_CallSiteOps_UpdateRules;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeFieldInfoPtr_s_CallSiteOps_GetRules;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeFieldInfoPtr_s_CallSiteOps_GetRuleCache;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeFieldInfoPtr_s_CallSiteOps_GetCachedRules;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeFieldInfoPtr_s_CallSiteOps_AddRule;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeFieldInfoPtr_s_CallSiteOps_MoveRule;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeFieldInfoPtr_s_CallSiteOps_Bind;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeFieldInfoPtr_s_String_op_Equality_String_String;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeFieldInfoPtr_s_Math_Pow_Double_Double;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_get_CallSiteOps_SetNotMatched_Public_Static_get_MethodInfo_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_get_CallSiteOps_CreateMatchmaker_Public_Static_get_MethodInfo_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_get_CallSiteOps_GetMatch_Public_Static_get_MethodInfo_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_get_CallSiteOps_ClearMatch_Public_Static_get_MethodInfo_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_get_CallSiteOps_UpdateRules_Public_Static_get_MethodInfo_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_get_CallSiteOps_GetRules_Public_Static_get_MethodInfo_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_get_CallSiteOps_GetRuleCache_Public_Static_get_MethodInfo_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_get_CallSiteOps_GetCachedRules_Public_Static_get_MethodInfo_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_get_CallSiteOps_AddRule_Public_Static_get_MethodInfo_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_get_CallSiteOps_MoveRule_Public_Static_get_MethodInfo_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_get_CallSiteOps_Bind_Public_Static_get_MethodInfo_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_get_String_op_Equality_String_String_Public_Static_get_MethodInfo_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_get_Math_Pow_Double_Double_Public_Static_get_MethodInfo_0;
	}
}
