using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace DG.Tweening.Core
{
	// Token: 0x02000049 RID: 73
	public static class Debugger : Object
	{
		// Token: 0x06000444 RID: 1092 RVA: 0x00019C38 File Offset: 0x00017E38
		// Note: this type is marked as 'beforefieldinit'.
		static Debugger()
		{
			Il2CppClassPointerStore<Debugger>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core", "Debugger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Debugger>.NativeClassPtr);
			Debugger.NativeFieldInfoPtr_logPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debugger>.NativeClassPtr, "logPriority");
			Debugger.NativeMethodInfoPtr_Log_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100664160);
			Debugger.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100664161);
			Debugger.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100664162);
			Debugger.NativeMethodInfoPtr_LogReport_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100664163);
			Debugger.NativeMethodInfoPtr_LogInvalidTween_Public_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100664164);
			Debugger.NativeMethodInfoPtr_LogNestedTween_Public_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100664165);
			Debugger.NativeMethodInfoPtr_LogNullTween_Public_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100664166);
			Debugger.NativeMethodInfoPtr_LogNonPathTween_Public_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100664167);
			Debugger.NativeMethodInfoPtr_LogMissingMaterialProperty_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100664168);
			Debugger.NativeMethodInfoPtr_LogRemoveActiveTweenError_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100664169);
			Debugger.NativeMethodInfoPtr_SetLogPriority_Public_Static_Void_LogBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100664170);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00019D58 File Offset: 0x00017F58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1133119, RefRangeEnd = 1133120, XrefRangeStart = 1133112, XrefRangeEnd = 1133119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(Object message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_Log_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00019D90 File Offset: 0x00017F90
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1133127, RefRangeEnd = 1133133, XrefRangeStart = 1133120, XrefRangeEnd = 1133127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarning(Object message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00019DC8 File Offset: 0x00017FC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1133140, RefRangeEnd = 1133142, XrefRangeStart = 1133133, XrefRangeEnd = 1133140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogError(Object message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00019E00 File Offset: 0x00018000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133142, XrefRangeEnd = 1133151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogReport(Object message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_LogReport_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00019E38 File Offset: 0x00018038
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1133160, RefRangeEnd = 1133177, XrefRangeStart = 1133151, XrefRangeEnd = 1133160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogInvalidTween(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_LogInvalidTween_Public_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00019E70 File Offset: 0x00018070
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1133186, RefRangeEnd = 1133197, XrefRangeStart = 1133177, XrefRangeEnd = 1133186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogNestedTween(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_LogNestedTween_Public_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00019EA8 File Offset: 0x000180A8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1133206, RefRangeEnd = 1133217, XrefRangeStart = 1133197, XrefRangeEnd = 1133206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogNullTween(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_LogNullTween_Public_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00019EE0 File Offset: 0x000180E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1133226, RefRangeEnd = 1133227, XrefRangeStart = 1133217, XrefRangeEnd = 1133226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogNonPathTween(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_LogNonPathTween_Public_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00019F18 File Offset: 0x00018118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133227, XrefRangeEnd = 1133237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogMissingMaterialProperty(string propertyName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_LogMissingMaterialProperty_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00019F50 File Offset: 0x00018150
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1133247, RefRangeEnd = 1133254, XrefRangeStart = 1133237, XrefRangeEnd = 1133247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogRemoveActiveTweenError(string propertyName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_LogRemoveActiveTweenError_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00019F88 File Offset: 0x00018188
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1133256, RefRangeEnd = 1133258, XrefRangeStart = 1133254, XrefRangeEnd = 1133256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLogPriority(LogBehaviour logBehaviour)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logBehaviour;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_SetLogPriority_Public_Static_Void_LogBehaviour_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x000035C8 File Offset: 0x000017C8
		public Debugger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x00019FBC File Offset: 0x000181BC
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x000035D1 File Offset: 0x000017D1
		public unsafe static int logPriority
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Debugger.NativeFieldInfoPtr_logPriority, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Debugger.NativeFieldInfoPtr_logPriority, (void*)(&value));
			}
		}

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeFieldInfoPtr_logPriority;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_Object_0;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_0;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_Object_0;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr_LogReport_Public_Static_Void_Object_0;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeMethodInfoPtr_LogInvalidTween_Public_Static_Void_Tween_0;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeMethodInfoPtr_LogNestedTween_Public_Static_Void_Tween_0;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr_LogNullTween_Public_Static_Void_Tween_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr_LogNonPathTween_Public_Static_Void_Tween_0;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeMethodInfoPtr_LogMissingMaterialProperty_Public_Static_Void_String_0;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr_LogRemoveActiveTweenError_Public_Static_Void_String_0;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeMethodInfoPtr_SetLogPriority_Public_Static_Void_LogBehaviour_0;
	}
}
